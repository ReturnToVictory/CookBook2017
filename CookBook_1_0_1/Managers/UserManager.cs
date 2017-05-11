using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CookBook_1_0_1.Models;
using System.Data;

namespace CookBook_1_0_1.Managers
{
    public class UserManager
    {
        public  List <User> GetList()
        {
            List<User> userList = new List<User>();
            DatabaseManager dbmManager = new DatabaseManager();
            DataTable users = dbmManager.GetFullList("User");
            for (int i=0; i < users.Rows.Count; i++)
            {
                User user = new User(users.Rows[i][0].ToString(), users.Rows[i][1].ToString(), Convert.ToBoolean(users.Rows[i][2]), int.Parse(users.Rows[i][3].ToString()), new List<int>());
                userList.Add(user);
            }
            return userList;
        }

        public bool CheckUsers(string userName)
        {
            List<User> userList = GetList();
            if(userList.Any(user => user.Login.Equals(userName , StringComparison.OrdinalIgnoreCase)))
            {
                return false;
            }
            return true;
        }
        public void ChangeUserPoints(string username , int points , List<int> recipes)
        {
            List<User> users = GetList();
            for(int i = 0; i < users.Count; i++)
            {
                if(users[i].Login == username)
                {
                    users[i].Points += points;
                    DatabaseManager dbManager = new DatabaseManager();
                    dbManager.Update("User", "Points", users[i].Points.ToString(), "Login", username);
                }
            }
        }

        public bool CreateNewUser(string userName)
        {
            User newUser = new User(userName, "123", false, 0, new List<int>());


            if (CheckUsers(userName))
            {
                DatabaseManager dbManager = new DatabaseManager();
                dbManager.AddUser(newUser);
                return true;
            }
            else
                return false;
        }
        public int GetLevel(int points)
        {
            int level = (int)Math.Log(points / 10, 2) + 1;
            if (points < 10)
                level = 1;
            if (level > 5) level = 5;
            return level;
        }





















    }

}
