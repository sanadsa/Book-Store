using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Log;

namespace BookLib
{
    /// <summary>
    /// enum for items category
    /// </summary>
    public enum eCategory
    {
        action = 1,
        science,
        romance,
        drama,
        horror,
        adventure
    };    

    /// <summary>
    ///  Class for the items for the store, contains all common fields of item types
    /// </summary>
    public class AbstractItem
    {
        private int itemId;
        private int isbn;
        private string name;
        private DateTime date;
        private double price;
        private int copyNumber;
        private string topic;
        private eCategory category;
        private int stock;
        private LogWriter log = new LogWriter();
     
        // default constructor
        public AbstractItem()
        {

        }
        
        /// <summary>
        /// constructor that initializes the abstractitem data member 
        /// </summary>
        /// <param name="isbn"></param>
        /// <param name="name"></param>
        /// <param name="date"></param>
        /// <param name="price"></param>
        /// <param name="copyNumber"></param>
        /// <param name="topic"></param>
        /// <param name="category"></param>
        /// <param name="stock"></param>
        public AbstractItem(int isbn, string name, DateTime date, double price, int copyNumber, string topic, eCategory category, int stock)
        {
            this.Isbn = isbn;         
            this.Name = name;            
            this.Date = date;            
            this.Price = price;            
            this.CopyNumber = copyNumber;            
            this.Topic = topic;
            this.Category = category;
            this.Stock = stock;
        }

        /// <summary>
        /// get item id        
        /// set item id - if value is negative throw exception
        /// </summary>
        public int ItemId
        {
            get { return itemId; }
            set
            {
                try
                {
                    if (value > 0)
                    {
                        itemId = value;
                    }
                    else
                    {
                        throw new Exception("value must be non-negative");
                    }
                }
                catch (Exception ex)
                {
                    log.LogWrite("Assigning id error: " + ex.Message);
                    throw new Exception("Assigning id error: " + ex.Message);
                }
            }
        }

        /// <summary>
        /// get isbn       
        /// set isbn - if value is negative throw exception
        /// </summary>
        public int Isbn
        {
            get { return isbn; }
            set
            {
                try
                {
                    if (value > 0)
                    {
                        isbn = value;
                    }
                    else
                    {
                        throw new Exception("value must be non-negative");
                    }
                }
                catch (Exception ex)
                {
                    log.LogWrite("Assigning isbn error: " + ex.Message);
                    throw new Exception("Assigning isbn error: " + ex.Message);
                }
            }
        }

        /// <summary>
        /// get stock        
        /// set stock - if value is negative throw exception
        /// </summary>
        public int Stock
        {
            get { return stock; }
            set
            {
                try
                {
                    if (value > 0)
                    {
                        stock = value;
                    }
                    else
                    {
                        throw new Exception("value must be non-negative");
                    }
                }
                catch (Exception ex)
                {
                    log.LogWrite("Assigning stock error: " + ex.Message);
                    throw new Exception("Assigning stock error: " + ex.Message);
                }
            }
        }

        /// <summary>
        /// get and set item name 
        /// </summary>
        public string Name
        {
            get { return name; }
            set
            {
                try
                {
                    name = value;
                }
                catch (Exception ex)
                {
                    log.LogWrite("Assigning item name error: " + ex.Message);
                    throw new Exception("Assigning item name error: " + ex.Message);
                }
            }
        }

        /// <summary>
        /// get and set date
        /// </summary>
        public DateTime Date
        {
            get { return date; }
            set
            {
                try
                {
                    date = value;
                }
                catch (Exception ex)
                {
                    log.LogWrite("Assigning date error: " + ex.Message);
                    throw new Exception("Assigning date error: " + ex.Message);
                }
            }
        }

        /// <summary>
        /// get price
        /// set price - if negavite throw exception
        /// </summary>
        public double Price
        {
            get { return price; }
            set
            {
                try
                {
                    if (value > 0)
                    {
                        price = value;
                    }
                    else
                    {
                        throw new Exception("value must be non-negative");
                    }
                }
                catch (Exception ex)
                {
                    log.LogWrite("Assigning price error: " + ex.Message);
                    throw new Exception("Assigning price error: " + ex.Message);
                }
            }
        }

        /// <summary>
        /// get copy number
        /// set copy number - if value is negative throw exception
        /// </summary>
        public int CopyNumber
        {
            get { return copyNumber; }
            set
            {
                try
                {
                    if (value > 0)
                    {
                        copyNumber = value;
                    }
                    else
                    {
                        throw new Exception("value must be non-negative");
                    }
                }
                catch (Exception ex)
                {
                    log.LogWrite("Assigning copy number error: " + ex.Message);
                    throw new Exception("Assigning copy number error: " + ex.Message);
                }
            }
        }

        /// <summary>
        /// get and set topic
        /// </summary>
        public string Topic
        {
            get { return topic; }
            set
            {
                try
                {
                    topic = value;
                }
                catch (Exception ex)
                {
                    log.LogWrite("Assigning topic error: " + ex.Message);
                    throw new Exception("Assigning topic error: " + ex.Message);
                }
            }
        }

        /// <summary>
        /// get and set category
        /// </summary>
        public eCategory Category
        {
            get { return category; }
            set
            {
                try
                {
                    category = value;
                }
                catch (Exception ex)
                {
                    log.LogWrite("Assigning category error: " + ex.Message);
                    throw new Exception("Assigning category error: " + ex.Message);
                }
            }
        }
    }
}
