using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookBook_1_0_1
{
    public partial class TransparentRTB_ : RichTextBox
    {
        public TransparentRTB_()
        {
            //InitializeComponent();
            this.SetStyle(ControlStyles.Opaque, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, false);
            this.TextChanged += TransparentLabel_TextChanged;
            this.VScroll += TransparentLabel_TextChanged;
            this.HScroll += TransparentLabel_TextChanged;
        }

        void TransparentLabel_TextChanged(object sender, System.EventArgs e)
        {
            this.ForceRefresh();
        }
        public void ForceRefresh()
        {
            this.UpdateStyles();
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams parms = base.CreateParams;
                parms.ExStyle |= 0x20;
                return parms;
            }
        }
    }
}

