using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miniräknare
{
    [DebuggerDisplay("{" + nameof(DebuggerDisplayAttribute ) + "(),nq}")]
    public partial class Form1 : Form {    
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;// sender är den knapp som tryckes på. konvertera om den till en Button 
            // lägg till siffran som står i knappen på texten i label 1 
            label1.Text = label1.Text + btn.Text; 
        }

        private void label4_Click(object sender, EventArgs e)
        { 

        }

        private void label3_Click(object sender, EventArgs e)
        {


        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
 
        private void Form1_Load(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
        }

        private void label14_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            
        }
    }
}
