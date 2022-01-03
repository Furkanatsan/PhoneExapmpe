using PhoneExapmpe.concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneExapmpe
{
    public partial class Form1 : Form
    {
        bool tiklanmadi = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDefault_Click(object sender, EventArgs e)
        {
            BasePhone basePhone = new BasePhone();
            if (tiklanmadi)
            {
                basePhone.PlaySound();
                tiklanmadi = false;
                btnDefault.Text = "playing";
            }
            else
            {
                basePhone.StopSound();
                tiklanmadi = true;
                btnDefault.Text = "DEFAULT";
            }
            
            
        }

        private void btnIphone_Click(object sender, EventArgs e)
        {
            Iphone iphone = new Iphone();
            iphone.PlaySound();
            Thread.Sleep(3000);//3 saniye çaldırır.
            iphone.StopSound();
        }

        private void btnNokia_Click(object sender, EventArgs e)
        {
            NokiaForm nokiaForm = new NokiaForm();
            nokiaForm.ShowDialog();
        }

        private void btnSamsung_Click(object sender, EventArgs e)
        {
            Samsung samsung = new Samsung();
            samsung.PlaySound();
            Thread.Sleep(2000);
            samsung.StopSound();
        }
    }
}
