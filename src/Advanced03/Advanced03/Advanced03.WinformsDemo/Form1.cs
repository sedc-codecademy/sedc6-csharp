using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Advanced03.WinformsDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            HelloButton.Click += HelloButton_Click;
            HelloButton.MouseHover += OnHover;
            HelloButton.MouseHover += (o, e) => { };

            this.timer1.Tick += (p1,p2)=>{ MessageBox.Show("2 secconds passed in africa"); };
        }

        private void OnHover(object sender, EventArgs e)
        {
            MessageBox.Show("you hovered this button");
        }

        private void HelloButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox1.Text);
        }

        private void HelloButton_Click_1(object sender, EventArgs e)
        {

        }

        
    }
}
