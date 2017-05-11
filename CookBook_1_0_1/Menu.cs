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
    public partial class Menu : Form
    {
        AuthorizeForm auth;
        public string UserName { get; set; }
        bool closing = false;
        bool volume;

        public Menu(string username , AuthorizeForm auth)
        {
            InitializeComponent();
            volume = true;
            UserName = username;
            this.auth = auth;
            UserManager userManager = new UserManager();
            List<User> users = userManager.GetList();
            for(int i= 0; i < users.Count; i++)
            {
                if(users[i].Login == username)
                    if(!users[i].IsAdmin)
                    {
                        btnAdmin.Visible = false;
                        pbVolume.Location = new Point(pbVolume.Location.X, pbVolume.Location.Y - 64);
                    }
            }
        }
        private void Menu_Load(object sender, EventArgs e)
        {
            ChangeLabelLevel();
        }
        public void ChangeLabelLevel()
        {
            UserManager userManager = new UserManager();
            User user = userManager.GetList().First(u => u.Login == UserName);
            lbUserName.Text = user.Login;
            lbUserPoint.Text = "Набранные баллы: " + user.Points.ToString();
            lbUserLevel.Text = "Уровень: " + userManager.GetLevel(user.Points).ToString();
        }
        private void btnUserChange_Click(object sender, EventArgs e)
        {
            if (volume)
                MusicManagers.playSound();
            auth.GetUsers();
            auth.Show();
            closing = true;
            this.Close();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            auth.Close();
        }
        private void btnGame_Click(object sender, EventArgs e)
        {
            if (volume)
                MusicManagers.playSound();
            GameForm gForm = new GameForm(int.Parse(lbUserLevel.Text.Split(' ')[1]), this, UserName, volume);
            gForm.Show();
            this.Hide();
        }
        private void btnCookBook_Click(object sender, EventArgs e)
        {
            if (volume)
                MusicManagers.playSound();
            CategoriesForm cform = new CategoriesForm(int.Parse(lbUserLevel.Text.Split(' ')[1]), this, volume);
            cform.Show();
            this.Hide();
        }
        private void bpVolume_Click(object sender, EventArgs e)
        {
            if (volume)
            {
                volume = false;
                pbVolume.BackgroundImage = CookBook_1_0_1.Properties.Resources.volumeoff;
            }
            else
            {
                volume = true;
                pbVolume.BackgroundImage = CookBook_1_0_1.Properties.Resources.volumeon;
            }
        }
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            if (volume)
                MusicManagers.playSound();
            //AdminForm aform = new AdminForm(volume , UserName);
            //aform.Show();
        }
        private void Menu_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (!closing)
                auth.Close();
        }
    }
}
