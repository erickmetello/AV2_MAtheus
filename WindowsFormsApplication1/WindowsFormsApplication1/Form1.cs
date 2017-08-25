using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        int atk;
        int def;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            atk = (int)numericUpDown1.Value;
            def = (int)numericUpDown2.Value;

            if (comboBox1.SelectedItem == "Água" && comboBox2.SelectedItem == "Fogo")
            {
                atk = (int)numericUpDown1.Value * 2;
            }

            if (comboBox1.SelectedItem == "Água" && comboBox2.SelectedItem == "Planta")
            {
                def = (int)numericUpDown1.Value * 2;
            }

            if (comboBox1.SelectedItem == "Fogo" && comboBox2.SelectedItem == "Água")
            {
                def = (int)numericUpDown1.Value * 2;
            }

            if (comboBox1.SelectedItem == "Fogo" && comboBox2.SelectedItem == "Planta")
            {
                atk = (int)numericUpDown1.Value * 2;
            }

            if (comboBox1.SelectedItem == "Planta" && comboBox2.SelectedItem == "Água")
            {
                atk = (int)numericUpDown1.Value * 2;
            }

            if (comboBox1.SelectedItem == "Planta" && comboBox2.SelectedItem == "Fogo")
            {
                def = (int)numericUpDown1.Value * 2;
            }           

            

            label3.Text = (atk - def).ToString() ;

            if (atk - def < 0)
            {
                label3.Text = 0.ToString();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
