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
    public partial class InfoForm : Form
    {
        public InfoForm(string text , bool volume)
        {
            InitializeComponent();
            lText.Text = text;

            Volume = volume;
        }
        bool Volume;

        private void btnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void InfoForm_Load(object sender, EventArgs e)
        {
            lText.AutoSize = true;
            if (Volume)
                MusicManagers.playResultSound("simplesound1.wav");
            btnOk.Location = new Point(this.Width / 2 - 40, lText.Location.Y + lText.Size.Height + 20);

                
        }
    }
}
