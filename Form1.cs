using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clicker_App
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
            RandomLocation.Start();
        }

        private void FirstButton_Click(object sender, EventArgs e)
        {
            int size = 1;
            
            FirstButton.BackColor = Color.Red;            
            FirstButton.Width -= 5;
            FirstButton.Height -= 5;
            FirstButton.Top = rand.Next(0, 300);
            FirstButton.Left = rand.Next(0, 500);
            int red = rand.Next(0, 256);
            int green = rand.Next(0, 256);
            int blue = rand.Next(0, 256);
            FirstButton.BackColor = Color.FromArgb(red, green, blue);
        }

        private void FirstButton_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void ResetButton_MouseEnter(object sender, EventArgs e)
        {
            ResetButton.Top = rand.Next(0, 300);
            ResetButton.Left = rand.Next(0, 400);
        }

        private void RandomLocation_Tick(object sender, EventArgs e)
        {
            FirstButton.Top = rand.Next(0, 300);
            FirstButton.Left = rand.Next(0, 300);
            ResetButton.Top = rand.Next(0, 300);
            ResetButton.Left = rand.Next(0, 300);
        }
    }
}
