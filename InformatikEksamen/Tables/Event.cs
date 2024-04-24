using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace InfomatikEksamen.Tables
{
   
    public class Event
    {
        public int Id;
        public int UserId;
        public DateTime Date;
        public string Name;
        public string Location;
        public string Description;

        public Event(
            int id,
            int userId, 
            DateTime date,
            string name,
            string location,
            string description
            )
        {
            Id = id;
            UserId = userId; 
            Date = date; 
            Name = name; 
            Location = location; 
            Description = description;
        }
    }

}
