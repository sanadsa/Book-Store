using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Log;

namespace BookLib
{
    /// <summary>
    /// class for item of type journal contain fields that only journal have
    /// </summary>
    public class Journal : AbstractItem
    {
        private string volume;
        private LogWriter log = new LogWriter();

        public Journal() { }

        /// <summary>
        /// constructor that initializes the journal data member 
        /// </summary>
        public Journal(string volume, int isbn, string name, DateTime date, double price, int copyNumber, string topic, eCategory category, int stock)
            : base(isbn, name, date, price, copyNumber, topic, category, stock)
        {
            this.Volume = volume;
        }

        /// <summary>
        /// get and set for volume
        /// </summary>
        public string Volume
        {
            get { return volume; }
            set {
                try
                {
                    volume = value;
                }
                catch (Exception ex)
                {
                    log.LogWrite("Assigning volume error");
                    throw new Exception("Assigning volume error: " + ex.Message);
                }
            }
        }

    }
}
