using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookLib;
using Log;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            BookStore bookStore = BookStore.GetInstance();
            User user = new User("amir", "james@gmail", "321", eUserType.employee);
            //bookStore.AddUser(user);                      
            Purchase c = new Purchase("hamis", "book", 101.56, 3, new DateTime(2010,05,04));
            Book abs = new Book(5, 798, "itememem", DateTime.Today, 54.6, 8, "dsad", eCategory.science, 4);
            Journal bb = new Journal("volvol", 321, "itememem", DateTime.Today, 54.6, 8, "dsad", eCategory.science, 2);
            //bookStore.AddJournal(bb);
            //eUserType eUser= bookStore.GetUserType("safir@g.com");            
            //LogWriter l = new LogWriter("hi kefak");
            LogWriter log = new LogWriter();
            log.LogWrite("add item errorrrr venommmmmm");
        }
    }
}
