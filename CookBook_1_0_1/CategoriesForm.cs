using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CookBook_1_0_1.Models;
using CookBook_1_0_1.Managers;


namespace CookBook_1_0_1
{
    public partial class CategoriesForm : Form
    {
        Menu Menu;
        int Level;
        List<Category> cats = null;
        bool volume;

        public CategoriesForm(int level , Menu menu , bool vol)
        {
            InitializeComponent();
            Level = level;
            Menu = menu;
            volume = vol;
            lbCategories.BackColor = Color.AntiqueWhite;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (volume)
                MusicManagers.playSound();
            this.Close();
            Menu.Show();
        }
        private void CategoriesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Menu.Show();
        }

        private void CategoriesForm_Load(object sender, EventArgs e)
        {
            CategoryManager catManager = new CategoryManager();
            cats = catManager.GetList();
            for (int i = 0; i < cats.Count; i++)
            {
                if (cats[i].Level <= Level)
                    lbCategories.Items.Add(cats[i]);
            }
        }
      
        private void lbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void lbCategories_DoubleClick_1(object sender, EventArgs e)
        {
            int Category = 0;
            if (lbCategories.SelectedItem != null)
            {
                for (int i = 0; i < cats.Count; i++)
                    if (cats[i].Name == lbCategories.SelectedItem.ToString())
                    {
                        Category = cats[i].Id;
                    }
                RecipeBookForm rbform = new RecipeBookForm(Level, Category, this, volume);
                rbform.Show();
                this.Hide();
            }
        }
    }
}
