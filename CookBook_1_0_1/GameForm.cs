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
    public partial class GameForm : Form
    {
        string User;
        int Level;
        Menu Menu;
        bool volume;
        bool closing = false;


        public GameForm(int level , Menu menu , string user , bool vol)
        {
            InitializeComponent();
            this.Level = level;
            User = user;
            this.Menu = menu;
            volume = vol;
        }
        private void btnCBack_Click(object sender, EventArgs e)
        {
            if (volume)
                MusicManagers.playSound();
            ReturnToMenu();
        }
        public void ReturnToMenu()
        {
            Menu.Show();
            Menu.ChangeLabelLevel();
            closing = true;
            this.Close();
        }
        private void btnCategory_Click(object sender, EventArgs e)
        {
            if (volume)
                MusicManagers.playSound();
            //CategoryGameForm
        }

        private void btnLevel_Click(object sender, EventArgs e)
        {
            if (volume)
                MusicManagers.playSound();

            //LevelGameForm
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            if (volume)
                MusicManagers.playSound();
            RecipeManager recipesManager = new RecipeManager();
            List<Recipe> recipes = recipesManager.GetList();
            List<int> indexes = new List<int>(); 
            for(int i = 0; i < recipes.Count; i++)
            {
                if (recipes[i].Level > Level)
                {
                    recipes.RemoveAt(i);
                    i--;
                }
                else
                    indexes.Add(i);
            }
            //TestManager
        }

        private void GameForm_Load(object sender, EventArgs e)
        {

        }

        private void GameForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!closing)
                ReturnToMenu();
        }
    }
}
