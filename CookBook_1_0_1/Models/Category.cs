using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBook_1_0_1.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }

        public Category(int id ,string name , int lvl)
        {
            Id = id;
            Name = name;
            Level = lvl;
        }
        public override string ToString()
        {
            return Name;

        }
    }
}
