using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace Assignment_4._1
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AddressBookForm());


            /*Design a personal phone / address book using Dictionary collection. 
             * Write a person class to store details of person like : 
             *  FirstName , LastName , Mobile Phone, Work Phone and Address.
            Provide a grid to display all, add more, delete(with confirmation message) and search by name.
            Search should show details of person searched. You may use the key as name of person.*/
        }
    }
    
}

