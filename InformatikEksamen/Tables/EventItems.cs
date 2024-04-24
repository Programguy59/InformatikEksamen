using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace InfomatikEksamen.Tables
{
   
    public class EventItems
    {
        public int Id;
        public int EventId;
        public int ItemId;
        public int ItemAmount;

        public EventItems(
            int id,
            int eventId,
            int itemId,
            int itemAmount
            )
        {
            Id = id;
            EventId = eventId;
            ItemId = itemId;
            ItemAmount = itemAmount;
        }
    }

}
