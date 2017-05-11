using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CookBook_1_0_1.Models;

namespace CookBook_1_0_1.Managers
{
    public class CategoryManager
    {
        public List<Category> GetList()
        {
            List<Category> catList = new List<Category>();
            DatabaseManager dbManager = new DatabaseManager();
            DataTable cats = dbManager.GetFullList("Category");

            for(int i = 0; i < cats.Rows.Count;i++)
            {
                Category cat = new Category(Convert.ToInt32(cats.Rows[i][0]), Convert.ToString(cats.Rows[i][1]) , Convert.ToInt32(cats.Rows[i][2]));
                catList.Add(cat);
            }
            return catList;
        }
    }
}
