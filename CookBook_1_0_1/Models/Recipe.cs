using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CookBook_1_0_1.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public Image Image { get; set; }
        public string Name { get; set; }
        public List<string> Ingredients { get; set; }
        public string Descreption { get; set; }
        public int Level { get; set; }
        public int Points { get; set; }
        public int CategoryId { get; set; }

        public Recipe(int id , Image image , string name , List<string> ingredients , string descreption , int level, int points , int categoryid)
        {
            Id = id;
            Image = image;
            Name = name;
            Ingredients = ingredients;
            Descreption = descreption;
            Level = level;
            Points = points;
            CategoryId = categoryid;
        }
    }
}
