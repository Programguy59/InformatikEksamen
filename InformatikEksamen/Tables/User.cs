using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfomatikEksamen.Tables
{
   
    public class User
    {
        public int Id;
        public string UserName;
        public User(
            int id,
            string userName
            )
        {
            Id = id;
            UserName = userName;
        }
    }

}
