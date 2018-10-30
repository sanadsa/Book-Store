using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Log;

namespace BookLib
{
    /// <summary>
    /// Class for purchases, when the user sells item a new purchase is added
    /// </summary>
    public class Purchase
    {
        private string customerName;
        private string itemName;
        private double itemPrice;
        private int quantity;
        private DateTime purchaseDate;
        private LogWriter log = new LogWriter();

        /// <summary>
        /// constructor that initializes the purchase data member 
        /// </summary>
        public Purchase(string customer, string itemName, double price, int quantity, DateTime purchaseDate)
        {
            this.CustomerName = customer;
            this.ItemName = itemName;
            this.ItemPrice = price;
            this.Quantity = quantity;
            this.PurchaseDate = purchaseDate;
        }

        /// <summary>
        /// get and set for customer name
        /// </summary>
        public string CustomerName
        {
            get { return customerName; }
            set
            {
                try
                {
                    customerName = value;
                }
                catch (Exception ex)
                {
                    log.LogWrite("Assigning customer name error");
                    throw new Exception("Assigning customer name error: " + ex.Message);
                }
            }
        }

        /// <summary>
        /// get and set for item name that the customer buy
        /// </summary>
        public string ItemName
        {
            get { return itemName; }
            set
            {
                try
                {
                    itemName = value;
                }
                catch (Exception ex)
                {
                    log.LogWrite("Assigning item name error");
                    throw new Exception("Assigning item name error: " + ex.Message);
                }
            }
        }

        /// <summary>
        /// get and set for item price that the customer buy
        /// </summary>
        public double ItemPrice 
        {
            get { return itemPrice; }
            set {
                    try
                    {
                        if (value > 0) { itemPrice = value; }
                        else
                        {
                            throw new Exception("value must be non-negative");
                        }
                    }
                    catch (Exception ex)
                    {
                        log.LogWrite("Assigning item price error: " + ex.Message);
                        throw new Exception("Assigning item price error: " + ex.Message);
                    }
            }
        }

        /// <summary>
        /// get and set for the quantity of the items that the customer buy
        /// </summary>
        public int Quantity
        {
            get { return quantity; }
            set
            {
                try
                {
                    if (value > 0) { quantity = value; }
                    else
                    {
                        throw new Exception("value must be non-negative");
                    }
                }
                catch (Exception ex)
                {
                    log.LogWrite("Assigning quantity error: " + ex.Message);
                    throw new Exception("assigning quantity error " + ex.Message);
                }
            }
        }

        /// <summary>
        /// get and set for the date of the purchase
        /// </summary>
        public DateTime PurchaseDate
        {
            get { return purchaseDate; }
            set
            {
                try
                {
                    purchaseDate = value;
                }
                catch (Exception ex)
                {
                    log.LogWrite("Assigning purchase date error");
                    throw new Exception("assigning purchase date error " + ex.Message);
                }
            }
        }
    }
}
