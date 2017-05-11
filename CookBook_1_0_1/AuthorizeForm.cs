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

namespace CookBook_1_0_1
{
    public partial class AuthorizeForm : Form
    {
        bool Admin = false;
        string pass = "";
        TextBox Password = new TextBox();

        public AuthorizeForm()
        {
            InitializeComponent();
            DatabaseManager dbManager = new DatabaseManager();
            pass = dbManager.Request("User", "Login = 'Admin'").Rows[0][1].ToString();
            Password.GotFocus += Password_MouseHover;
        }
        private void Password_MouseHover(object sender , EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(Password, "Введите пароль в этой строке");
        }
        private void btnRegistration_Click(object sender, EventArgs e)
        {
            MusicManagers.playSound();
            Registration reg = new Registration();
            reg.ShowDialog();
            UserManager userManager = new UserManager();
            cbUsers.DataSource = userManager.GetList().Select(u => u.Login).ToList();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MusicManagers.playSound();
            if (cbUsers.SelectedItem != null)
            {
                if (Admin && cbUsers.SelectedItem.ToString() != "Admin")
                {
                    Admin = false;
                    Controls.Remove(Password);
                    Password.Text = "";
                    cbUsers.Location = new Point(104, 224);
                    Menu mainForm = new Menu(cbUsers.SelectedItem.ToString(), this);
                    mainForm.Show();
                    this.Hide();
                    return;
                }
                if (!Admin)
                {
                    if (cbUsers.SelectedItem.ToString() == "Admin")
                    {
                        Admin = true;
                        cbUsers.Location = new Point(cbUsers.Location.X, cbUsers.Location.Y - 40);
                        Password.Location = new Point(cbUsers.Location.X, cbUsers.Location.Y + 40);
                        Password.Height = 31;
                        Password.Width = 240;
                        Password.Font = new Font("Candara", 14, FontStyle.Regular);
                        Controls.Add(Password);
                    }
                    else
                    {
                        Menu mainForm = new Menu(cbUsers.SelectedItem.ToString(), this);
                        mainForm.Show();
                        this.Hide();
                    }
                }
                else
                {
                    if (Password.Text == pass)
                    {
                        Menu mainForm = new Menu("Admin", this);
                        Admin = false;
                        Controls.Remove(Password);
                        Password.Text = "";
                        cbUsers.Location = new Point(104, 224);
                        mainForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        InfoForm iform = new InfoForm("Неверный пароль!", true);
                        iform.ShowDialog();
                        Password.Text = "";
                    }
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSvernut_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void AuthorizeForm_Load(object sender, EventArgs e)
        {
            this.AllowTransparency = true;
            this.BackColor = Color.Gold;
            this.TransparencyKey = this.BackColor;
            GetUsers();
        }
        public void GetUsers()
        {
            UserManager userManager = new UserManager();
            cbUsers.DataSource = userManager.GetList().Select(u => u.Login).ToList();
            cbUsers.SelectedIndex = -1;
        }
  
        private void cbUsers_SelectedIndexChanged(object sender , EventArgs e)
        {
            if(Admin && cbUsers.Text != "Admin")
            {
                Admin = false;
                Controls.Remove(Password);
                Password.Text = "";
                cbUsers.Location = new Point(104, 224);
                return;
            }
            if(!Admin && cbUsers.Text == "Admin" && cbUsers.SelectedIndex != -1)
            {
                Admin = true;
                cbUsers.Location = new Point(cbUsers.Location.X, cbUsers.Location.Y - 40);
                Password.Location = new Point(cbUsers.Location.X, cbUsers.Location.Y + 40);
                Password.Height = 30;
                Password.Width = 300;
                Password.Font = new Font("Candara", 14, FontStyle.Regular);
                Controls.Add(Password);
            }
        }

        private void AuthorizeForm_MouseDown_1(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }
    }
}
