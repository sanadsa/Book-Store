using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BookLib
{
    /// <summary>
    /// Interface for the abstract items
    /// </summary>
    interface IAbstractItem
    {
        /// <summary>
        /// adds new book to the db
        /// </summary>
        /// <param name="book"></param>
        void AddBook(Book book);

        /// <summary>
        /// adds new journal to the db
        /// </summary>
        /// <param name="journal"></param>
        void AddJournal(Journal journal);

        /// <summary>
        /// reduces stock by newStock from the book that have the id bookId
        /// delete the book from Book table in DB if the current stock is 1
        /// </summary>
        /// <param name="id"></param>
        /// <param name="newStock"></param>
        void SellBook(int id, int newStock);

        /// <summary>
        /// reduces stock by newStock from the journal that have the id journalId
        /// delete the journal from Journal table in DB if the current stock is 1
        /// </summary>
        /// <param name="id"></param>
        /// <param name="newStock"></param>
        void SellJournal(int id, int newStock);

        /// <summary>
        /// Updates a book in Book table in the DB
        /// </summary>
        /// <param name="newBook"></param>
        /// <param name="id"></param>
        void UpdateBook(Book newBook, int id);

        /// <summary>
        /// Updates a journal in Journal table in the DB
        /// </summary>
        /// <param name="newJournal"></param>
        /// <param name="id"></param>
        void UpdateJournal(Journal newJournal, int id);

        /// <summary>
        /// gets all the items from a specific table in the DB
        /// </summary>
        /// <param name="type">name of the table to gets its items from the DB</param>
        /// <returns>data table of the table that we choose</returns>
        DataTable GetItemsTable(string type);

        /// <summary>
        /// search for item from the table by and string column
        /// </summary>
        /// <param name="tableName">the table to search in</param>
        /// <param name="value">which value to look for</param>
        /// <param name="searchBy">search by column table</param>
        /// <returns>datatable with the rows that contain only searched value</returns>
        DataTable SearchItem(string table, string value, string searchBy);

        /// <summary>
        /// search for item from the table by isbn
        /// </summary>
        /// <param name="tableName">the table to search in</param>
        /// <param name="value">which isbn to look for</param>
        /// <returns>datatable with the rows that contain only searched value</returns>
        DataTable SearchItemByIsbn(string tableName, int value);
    }
}
