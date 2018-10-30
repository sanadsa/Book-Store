using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLib
{
    /// <summary>
    /// Interface for the abstract items
    /// </summary>
    interface IAbstractItem
    {
        /**
         * returns the id of the added item so it can be used to add a derived type of item with same id
         * */
        int AddItem(AbstractItem item);

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
    }
}
