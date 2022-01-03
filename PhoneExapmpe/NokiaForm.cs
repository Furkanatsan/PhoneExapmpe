using PhoneExapmpe.concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneExapmpe
{
    public partial class NokiaForm : Form
    {
        Nokia nokia;
        public NokiaForm()
        {
            InitializeComponent();
            nokia = new Nokia();
            nokia.Id = 1;
            nokia.Brand = "nokia";
            nokia.Model = "3310";
            nokia.UnitPrice = 222.22m;
            lblNokia.Text = nokia.ToString();
            nokia.PlaySound();
        }

        private void NokiaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            nokia.StopSound();
        }

    }
}
