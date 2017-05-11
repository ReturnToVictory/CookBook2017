using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CookBook_1_0_1.Managers;
using CookBook_1_0_1.Models;


namespace CookBook_1_0_1
{
    public partial class TestIngredients : Form
    {
        public Recipe MyRecipe { get; set; }
        public List<string> Ingredients { get; set; }
        public List<string> RecipeIngredients { get; set; }
        public List<int> indexes;
        public int countWrong;
        public bool change = false;
        public bool answer = false;
        public bool exitGame = false;
        public bool cancelGame = false;
        bool volume;

        public TestIngredients(Recipe recipe , bool vol)
        {
            InitializeComponent();
            MyRecipe = recipe;
            volume = vol;
            lbName.Text += recipe.Name;
            TestManager testManager = new TestManager(false);
            int count = MyRecipe.Ingredients.Count;
            int ingrcount = count - 3;
            Ingredients = testManager.GetWrongIngreds(MyRecipe, ingrcount);
            Random rnd = new Random();
            indexes = testManager.GetIndexesForDelete(MyRecipe.Ingredients, 3);
            RecipeIngredients = new List<string>();
            for (int i = 0; i < MyRecipe.Ingredients.Count; i++)
                RecipeIngredients.Add(MyRecipe.Ingredients[i]);
            countWrong = indexes.Count;
            for(int i = 0; i < indexes.Count; i++)
            {
                Ingredients.Insert(rnd.Next(Ingredients.Count), MyRecipe.Ingredients[indexes[i]]);
                RecipeIngredients[indexes[i]] = "__________";
            }
            for (int i = 0; i < RecipeIngredients.Count; i++)
                lbRecipeIngreds.Items.Add(RecipeIngredients[i]);
            for (int i = 0; i < RecipeIngredients.Count; i++)
                lbIngreds.Items.Add(Ingredients[i]);
            lbIngreds.SelectedIndex = -1;
        }


        private void TestIngredients_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!cancelGame && !exitGame && !answer)
                countWrong = 3;
            DialogResult = DialogResult.OK;
        }
        private void btnClancel_Click(object sender, EventArgs e)
        {
            if (volume)
                MusicManagers.playSound();
            cancelGame = true;
            DialogResult = DialogResult.OK;
        }
        private void btnExitGame_Click(object sender, EventArgs e)
        {
            if (volume)
                MusicManagers.playSound();
            exitGame = true;
            DialogResult = DialogResult.OK;
        }

        //test nado
        private void btnAgain_Click(object sender, EventArgs e)
        {
            if (volume)
                MusicManagers.playSound();
            lbIngreds.Items.Clear();
            //test sdelat 
            lbRecipeIngreds.Items.Clear();
            countWrong = indexes.Count;
            for (int i = 0; i < indexes.Count; i++)
            {
                RecipeIngredients[indexes[i]] = "__________";
            }
            for (int i = 0; i < RecipeIngredients.Count; i++)
                lbRecipeIngreds.Items.Add(RecipeIngredients[i]);
            for (int i = 0; i < RecipeIngredients.Count; i++)
                lbIngreds.Items.Add(Ingredients[i]);
            lbIngreds.SelectedIndex = -1;
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            if (volume)
                MusicManagers.playSound();
            answer = true;
            DialogResult = DialogResult.OK;
        }
    }
}
