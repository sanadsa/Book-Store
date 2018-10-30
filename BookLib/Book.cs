using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Log;

namespace BookLib
{
    /// <summary>
    /// class for item of type book contain fields that only book have
    /// </summary>
    public class Book : AbstractItem
    {
        private int edition;
        private LogWriter log = new LogWriter();

        /// <summary>
        /// constructor that initializes the book data member 
        /// </summary>
        /// <param name="edition"></param>
        /// <param name="isbn"></param>
        /// <param name="name"></param>
        /// <param name="date"></param>
        /// <param name="price"></param>
        /// <param name="copyNumber"></param>
        /// <param name="topic"></param>
        /// <param name="category"></param>
        /// <param name="stock"></param>
        public Book(int edition, int isbn, string name, DateTime date, double price, int copyNumber, string topic, eCategory category, int stock)
            : base(isbn, name, date, price, copyNumber, topic, category, stock)
        {
            this.Edition = edition;
        }    

        /// <summary>
        /// get and set for book edition
        /// </summary>
        public int Edition
        {
            get { return edition; }
            set
            {
                try
                {
                    if (value > 0)
                    {
                        edition = value;
                    }
                    else
                    {
                        throw new Exception("value must be non-negative");
                    }
                }
                catch (Exception ex)
                {
                    log.LogWrite("Assigning edition error: " + ex.Message);
                    throw new Exception("Assigning edition error: " + ex.Message);
                }
            }
        }      
    }
}
