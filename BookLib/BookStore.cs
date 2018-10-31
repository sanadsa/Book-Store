using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Log;

namespace BookLib
{
    /// <summary>
    /// Class that applies the book store system, implements the interfaces IUser, IAbstractItem and IPurchase, using SqlClient
    /// </summary>
    public class BookStore : IUser, IAbstractItem, IPurchase
    {
        string path = @"Data Source=DESKTOP-7Q5OG91\SQLEXPRESS01;Initial Catalog=bookStore;Integrated Security=True;MultipleActiveResultSets=true;";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adpt;
        SqlDataReader rs;
        private static BookStore singletone;
        private LogWriter log = new LogWriter();

        private BookStore()
        {
            con = new SqlConnection(path);
        }

        public static BookStore GetInstance()
        {
            if (singletone == null)
            {
                singletone = new BookStore();
            }

            return singletone;
        }

        /// <summary>
        /// adds new user to the users table in the database
        /// throws exception if user not added
        /// </summary>
        /// <param name="user">the user we want to add to the table</param>
        public void AddUser(User user)
        {
            try
            {                
                con.Open();
                if (user != null)
                {
                    cmd = new SqlCommand("select 1 from UserTable where email=@Email", con);
                    cmd.Parameters.Add("@Email", user.Email);
                    adpt = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adpt.Fill(ds);
                    int count = ds.Tables[0].Rows.Count;
                    if (count == 1)
                    {
                        throw new Exception("User already exists, choose another email");
                    }
                    else
                    {
                        cmd = new SqlCommand("insert into UserTable (userName, email, userPassword, userType) " +
                                     "values ('" + user.Name + "', '" + user.Email + "', '" + user.Password + "', '" + user.UserType + "') ", con);
                        cmd.ExecuteNonQuery();
                    }
                }                
            }
            catch (Exception ex)
            {
                log.LogWrite("Add user error: " + ex.Message);
                throw new Exception("Add user error: " + ex.Message);
            }
            finally
            {
                if (con != null) { con.Close(); }
            }
        }

        /// <summary>
        /// delete user from userTable in database
        /// </summary>
        /// <param name="userId">id of the user we want to delete</param>
        public void DeleteUser(int userId)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("delete from UserTable where id='"+userId+"'", con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                log.LogWrite("Delete user error: " + ex.Message);
                throw new Exception("Delete user error " + ex.Message);
            }
            finally
            {
                if (con != null) { con.Close(); }
            }
        }        

        /// <summary>
        /// gets the user type to know the permissions of the user (admin user can use all function of the app)
        /// </summary>
        /// <param name="email">the email of the user we want to get its type</param>
        /// <returns>type of the user</returns>
        public eUserType GetUserType(string email)
        {
            eUserType userType;
            try
            {
                con.Open();
                cmd = new SqlCommand("SELECT userType from UserTable WHERE email = '" + email + "';", con);
                cmd.ExecuteNonQuery();
                SqlDataReader rdr = cmd.ExecuteReader();
                rdr.Read();                
                string type = rdr[0].ToString();
                if (type == eUserType.admin.ToString())
                {
                    userType = eUserType.admin;
                }
                else
                {
                    userType = eUserType.employee;
                }
            }
            catch (Exception ex)
            {
                log.LogWrite("Get user type error: " + ex.Message);
                throw new Exception("Get user type error: " + ex.Message);
            }
            finally
            {
                if (con != null) { con.Close(); }
            }

            return userType;
        }

        /// <summary>
        /// checks if user exits in database by email and password
        /// </summary>
        /// <param name="email">users email</param>
        /// <param name="password">users password</param>
        /// <returns>true if the user exists</returns>
        public bool IsUserExists(string email, string password)
        {
            bool isUserExists = false;
            try
            {
                con.Open();
                cmd = new SqlCommand("select * from UserTable where email=@Email and userPassword=@Pass", con);                
                cmd.Parameters.Add("@Email", email);
                cmd.Parameters.Add("@Pass", password);
                adpt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adpt.Fill(ds);
                int count = ds.Tables[0].Rows.Count;
                if(count == 1)
                {
                    isUserExists = true;
                }                
            }
            catch (Exception ex)
            {
                log.LogWrite("Get user error: " + ex.Message);
                throw new Exception("Get user error: " + ex.Message);
            }
            finally
            {
                if (con != null) { con.Close(); }                            
            }
            return isUserExists;
        }   
      
        /// <summary>
        /// adds new book to the Book table in the database
        /// </summary>
        /// <param name="item">the book that we want to add</param>
        public void AddBook(Book item)
        {
            try
            {
                con.Open();
                if (item != null)
                {
                    if (ISBNExists(item))
                    {
                        throw new Exception("ISBN exists, choose another isbn");
                    }
                    cmd = new SqlCommand("insert into Book (isbn, itemName, publishDate, price, copyNumber, topic, category, stock, edition) " +
                                     "values ('" + item.Isbn + "', '" + item.Name + "', '" + item.Date + "', '" + item.Price + "', '" + item.CopyNumber + "', '" + item.Topic + "', '" + item.Category + "', '" + item.Stock + "', '" + item.Edition + "') ", con);

                    cmd.ExecuteNonQuery();
                }                
            }
            catch (Exception ex)
            {
                log.LogWrite("Add book error: " + ex.Message);
                throw new Exception("Add book error: " + ex.Message);
            }
            finally
            {
                if (con != null) { con.Close(); }
            }
        }

        /// <summary>
        /// adds new journal to the Journal table in the database
        /// </summary>
        /// <param name="item"></param>
        public void AddJournal(Journal item)
        {
            try
            {
                con.Open();
                if (item != null)
                {
                    if (ISBNExists(item))
                    {
                        throw new Exception("ISBN exists, choose another isbn");
                    }
                    cmd = new SqlCommand("insert into Journal (isbn, itemName, publishDate, price, copyNumber, topic, category, stock, volume) " +
                                     "values ('" + item.Isbn + "', '" + item.Name + "', '" + item.Date + "', '" + item.Price + "', '" + item.CopyNumber + "', '" + item.Topic + "', '" + item.Category + "', '" + item.Stock + "', '" + item.Volume + "') ", con);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                log.LogWrite("Add journal error: " + ex.Message);
                throw new Exception("Add journal error: " + ex.Message);
            }
            finally
            {
                if (con != null) { con.Close(); }
            }
        }

        /// <summary>
        /// checks if isbn of an item exists in the DB
        /// </summary>
        /// <param name="item">the item to check its isbn</param>
        /// <returns>true if the item exists</returns>
        private bool ISBNExists(AbstractItem item)
        {
            try
            {
                bool isbnExists = false;
                if (rowsCount("Book", item) == 1 || rowsCount("Journal", item) == 1)
                {
                    isbnExists = true;
                }
                return isbnExists;
            }
            catch (Exception ex)
            {
                log.LogWrite("Check for isbn error");
                throw new Exception("Check for isbn error");
            }
        }

        /// <summary>
        /// count the rows of an exitsting item in the DB
        /// </summary>
        /// <param name="itemType">type of the item (Book, journal...)</param>
        /// <param name="item">the item to check in db</param>
        /// <returns>number of result rows (if 1 so item exist in DB)</returns>
        private int rowsCount(string itemType, AbstractItem item)
        {
            try
            {
                cmd = new SqlCommand("select 1 from " + itemType + " where isbn=@ISBN", con);
                cmd.Parameters.Add("@ISBN", item.Isbn);
                adpt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adpt.Fill(ds);
                int count = ds.Tables[0].Rows.Count;
                return count;
            }
            catch (Exception ex)
            {
                log.LogWrite("Get number of rows by isbn error in table " + itemType);
                throw new Exception("Get number of rows by isbn error in table " + itemType);
            }
        }     

        /// <summary>
        /// reduces stock by newStock from the book that have the id bookId
        /// delete the book from Book table in DB if the current stock is 1
        /// </summary>
        /// <param name="bookId"></param>
        /// <param name="newStock">number of stock to reduce from the item</param>
        public void SellBook(int bookId, int newStock)
        {
            try
            {
                con.Open();
                if (newStock == 0)
                {
                    cmd = new SqlCommand("delete from Book where bookId='"+bookId+"' ", con);
                }
                else
                {
                    cmd = new SqlCommand("update Book set stock='"+newStock+"' where bookId='"+bookId+"' ", con);
                }
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                log.LogWrite("Sell book error: " + ex.Message);
                throw new Exception("Sell book error: " + ex.Message);
            }
            finally
            {
                if (con != null) { con.Close(); }
            }
        }

        /// <summary>
        /// reduces stock by newStock from the journal that have the id journalId
        /// delete the journal from Journal table in DB if the current stock is 1
        /// </summary>
        /// <param name="journalId"></param>
        /// <param name="newStock">number of stock to reduce from the item</param>
        public void SellJournal(int journalId, int newStock)
        {
            try
            {
                con.Open();
                if (newStock == 0)
                {
                    cmd = new SqlCommand("delete from Journal where journalId='" + journalId + "' ", con);
                }
                else
                {
                    cmd = new SqlCommand("update Journal set stock='" + newStock + "' where journalId='" + journalId + "' ", con);
                }                
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                log.LogWrite("Sell journal error: " + ex.Message);
                throw new Exception("Sell journal error " + ex.Message);
            }
            finally
            {
                if (con != null) { con.Close(); }
            }
        }       

        /// <summary>
        /// gets all the items from a specific table in the DB
        /// </summary>
        /// <param name="type">name of the table to gets its items from the DB</param>
        /// <returns>data table of the table that we choose</returns>
        public DataTable GetItemsTable(string type)
        {
            try
            {
                DataTable dt = new DataTable();
                con.Open();
                adpt = new SqlDataAdapter("select * from " + type + " ", con);
                adpt.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                log.LogWrite("Get " +type+ " items error: " + ex.Message);
                throw new Exception("Get " + type + " items error: " + ex.Message);
            }
            finally
            {
                if (con != null) { con.Close(); }
            }
        }            
    
        /// <summary>
        /// Updates a book in Book table in the DB
        /// </summary>
        /// <param name="newBook">book with new values</param>
        /// <param name="itemId">the book id that we want to update</param>
        public void UpdateBook(Book newBook, int itemId)
        {
            try
            {
                con.Open();
                if (newBook != null)
                {
                    cmd = new SqlCommand("update Book set isbn='"+newBook.Isbn+"', itemName='"+newBook.Name+"'," +
                                         " publishDate='"+newBook.Date+"', price='"+newBook.Price+"'," +
                                         " copyNumber='"+newBook.CopyNumber+"', topic='"+newBook.Topic+"', category='"+newBook.Category+"'," +
                                         " stock='"+newBook.Stock+"', edition='"+newBook.Edition+"' where bookId='"+itemId+"' ", con);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                log.LogWrite("Update book error: " + ex.Message);
                throw new Exception("Update book error: " + ex.Message);
            }
            finally
            {
                if (con != null) { con.Close(); }
            }
        }

        /// <summary>
        /// Updates a journal in Journal table in the DB
        /// </summary>
        /// <param name="newJournal">journal with new values</param>
        /// <param name="itemId">the journal id that we want to update</param>
        public void UpdateJournal(Journal newJournal, int itemId)
        {
            try
            {
                con.Open();
                if (newJournal != null)
                {
                    cmd = new SqlCommand("update Journal set isbn='" + newJournal.Isbn + "', itemName='" + newJournal.Name + "'," +
                                         " publishDate='" + newJournal.Date + "', price='" + newJournal.Price + "'," +
                                         " copyNumber='" + newJournal.CopyNumber + "', topic='" + newJournal.Topic + "', category='" + newJournal.Category + "'," +
                                         " stock='" + newJournal.Stock + "', volume='" + newJournal.Volume + "' where journalId='" + itemId + "' ", con);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                log.LogWrite("Update journal error: " + ex.Message);
                throw new Exception("Update journal error: " + ex.Message);
            }
            finally
            {
                if (con != null) { con.Close(); }
            }
        }

        /// <summary>
        /// search for item from the table by and string column
        /// </summary>
        /// <param name="tableName">the table to search in</param>
        /// <param name="value">which value to look for</param>
        /// <param name="searchBy">search by column table</param>
        /// <returns>datatable with the rows that contain only searched value</returns>
        public DataTable SearchItem(string tableName, string value, string searchBy)
        {
            try
            {
                con.Open();
                adpt = new SqlDataAdapter("select * from " + tableName + " where " + searchBy + " like '%" + value + "%' ", con);
                DataTable dt = new DataTable();
                adpt.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                log.LogWrite("Search item error: " + ex.Message);
                throw new Exception("Search item error: " + ex.Message);
            }
            finally
            {
                if (con != null) { con.Close(); }
            }
        }

        /// <summary>
        /// search for item from the table by isbn
        /// </summary>
        /// <param name="tableName">the table to search in</param>
        /// <param name="value">which isbn to look for</param>
        /// <returns>datatable with the rows that contain only the searched ones</returns>
        public DataTable SearchItemByIsbn(string tableName, int value)
        {
            try
            {
                con.Open();
                if (value == 0)
                {
                    adpt = new SqlDataAdapter("select * from " + tableName, con);
                }
                else
                {
                    adpt = new SqlDataAdapter("select * from " + tableName + " where isbn like '%" + value + "%' ", con);
                }                
                DataTable dt = new DataTable();
                adpt.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                log.LogWrite("Search item by isbn error: " + ex.Message);
                throw new Exception("Search item by isbn error: " + ex.Message);
            }
            finally
            {
                if (con != null) { con.Close(); }
            }
        }

        /// <summary>
        /// adds new customer and new purchase to the DB
        /// </summary>
        /// <param name="purchase">contains customer name and id fields</param>
        public void AddPurchase(Purchase purchase)
        {
            try
            {
                con.Open();
                if (purchase != null)
                {
                    cmd = new SqlCommand("insert into Customers (customerName) " +
                                     "values ('" + purchase.CustomerName + "') ", con);
                    cmd.ExecuteNonQuery();
                    cmd = new SqlCommand("select top 1 ID from Customers where customerName='" + purchase.CustomerName + "' order by ID desc", con);
                    rs = cmd.ExecuteReader();
                    rs.Read();
                    int customerID = (int)rs[0];
                    cmd = new SqlCommand("insert into Purchases (customerId, customerName, itemName, itemPrice, quantity, purchaseDate) " +
                                     "values ("+customerID+", '" + purchase.CustomerName + "', '" + purchase.ItemName + "', '" + purchase.ItemPrice + "', '" + purchase.Quantity + "', '" + purchase.PurchaseDate + "') ", con);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                log.LogWrite("Add purchase error: " + ex.Message);
                throw new Exception("Add purchase error: " + ex.Message);
            }
            finally
            {
                if (con != null) {
                    rs.Close();
                    con.Close();
                }
            }
        }
    }
}
