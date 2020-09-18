using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part_1_3_Forms
{
    public partial class Form1 : Form
    {
        string name;
        double age;
        double height;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = txtInputName.Text;
            double age = barAge.Value;
            double height = Convert.ToDouble(txtInputHeight.Text);
            lblMessage.Text = $"Hello There {name}, you are {age} years old and {height} meters tall";

        }
        

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnAge_Click(object sender, EventArgs e)
        {
            

        }

        private void lblMessageAge_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void lblAge_Click(object sender, EventArgs e)
        {
            

        }

        private void barAge_Scroll(object sender, EventArgs e)
        {
            lblAge.Text = (barAge.Value.ToString());
        }

        private void lblInstrucionHeight_Click(object sender, EventArgs e)
        {

        }

        private void txtInputName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtInputHeight_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
