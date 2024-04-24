using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace InfomatikEksamen.Tables
{
   
    public class Item
    {
        public int Id;
        public string Name;
        public int TotalAmount;

        public Item(
            int id,
            string name,
            int totalAmount
            )
        {
            Id = id;
            Name = name; 
            TotalAmount = totalAmount;
        }
    }

}
