using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLib
{
    /// <summary>
    /// Interface for the purchases
    /// </summary>
    interface IPurchase
    {
        /// <summary>
        /// adds new purchase to the Purchase table in the database
        /// </summary>
        /// <param name="purchase"></param>
        void AddPurchase(Purchase purchase);
    }
}
