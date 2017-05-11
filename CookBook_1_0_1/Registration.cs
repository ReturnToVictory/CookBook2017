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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            //ошибки при заполнении имени пользователя
            #region
            if (tbUserName.Text == "")
            {
                InfoForm iform = new InfoForm("Поле не может быть пустым", true);
                iform.ShowDialog();
                return;
            }
            if (tbUserName.Text.Contains(" "))
            {
                InfoForm iform = new InfoForm("Введенное имя содержит пробелы", true);
                iform.Show();
                return;
            }

            if (tbUserName.Text.Length > 30)
            {
                InfoForm iform = new InfoForm("Введенное имя слишком длинное", true);
                iform.Show();
                return;
            }
            #endregion

            UserManager userManager = new UserManager();
            if(userManager.CreateNewUser(tbUserName.Text))
            {
                InfoForm iform = new InfoForm("Пользователь успешно добавлен!", true);
                if (iform.ShowDialog() == DialogResult.OK)
                    this.Close();
            }
            else
            {
                InfoForm iform = new InfoForm("Пользователь с таким именем уже существует", true);
                if (iform.ShowDialog() == DialogResult.OK)
                    this.Close();
            }
        }
    }
}
