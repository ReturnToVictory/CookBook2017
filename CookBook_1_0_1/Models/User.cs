using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBook_1_0_1.Models
{
    public class User
    {
        public string Login { get; set; }
        public string Pass { get; set; }
        public bool IsAdmin { get; set; }
        public int Points { get; set; }
        public List<int> DoneIds { get; set; }

        public User(string log , string pass , bool isadmin , int point , List <int> ids)
        {
            Login = log;
            Pass = pass;
            IsAdmin = isadmin;
            Points = point;
            DoneIds = ids;
        }

       
    }
}
