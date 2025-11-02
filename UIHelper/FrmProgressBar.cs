using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIHelper
{
    public partial class FrmProgressBar : Form
    {
        public FrmProgressBar(string text)
        {
            InitializeComponent();
            lblWait.Text = text;
        }

        }
}
