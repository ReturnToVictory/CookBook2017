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
    public partial class TestName : Form
    {
        string RName;
        public bool right = false;
        public bool exitGame = false;
        public bool cancelGame = false;
        public bool answer = false;
        bool volume;


        public TestName(Image image , string name , List<Recipe> recipes , bool vol)
        {
            InitializeComponent();
            RName = name;
            pbImage.Image = image;
            volume = vol;
            Random rand = new Random();
            if(recipes.Count > 10)
            {
                for(int i = 0; i < 10; i++)
                {
                    int ind = rand.Next(0, recipes.Count);
                    if (!cbVars.Items.Contains(recipes[ind].Name))
                        cbVars.Items.Add(recipes[ind].Name);
                    else
                        i--;
                }
                if (!cbVars.Items.Contains(name))
                    cbVars.Items.Add(name);
            }
            else
            {
                for (int i = 0; i < recipes.Count; i++)
                    cbVars.Items.Add(recipes[i].Name);
            }

        }

        private void TestName_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!cancelGame && !exitGame && !answer)
                right = false;
            DialogResult = DialogResult.OK;
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            if (volume)
                MusicManagers.playSound();
            if (cbVars.Text == RName)
                right = true;
            answer = true;
            DialogResult = DialogResult.OK;
        }

        private void btnExitGame_Click(object sender, EventArgs e)
        {
            if (volume)
                MusicManagers.playSound();
            exitGame = true;
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (volume)
                MusicManagers.playSound();
            cancelGame = true;
            DialogResult = DialogResult.OK;
        }
    }
}
