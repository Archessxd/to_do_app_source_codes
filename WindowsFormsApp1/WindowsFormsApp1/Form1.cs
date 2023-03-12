using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void add_BTN_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Add(textBox1.Text);
                textBox1.Text = null;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void doing_BTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBox1.SelectedItem!= null)
                {
                    int selIndex = listBox1.SelectedIndex;
                    listBox2.Items.Add(listBox1.SelectedItem.ToString());
                    listBox1.Items.RemoveAt(selIndex);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBox1.SelectedItem != null)
                {
                    int selIndex = listBox1.SelectedIndex;
                    listBox3.Items.Add(listBox1.SelectedItem.ToString());
                    listBox1.Items.RemoveAt(selIndex);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBox2.SelectedItem != null)
                {
                    int selIndex = listBox2.SelectedIndex;
                    listBox3.Items.Add(listBox2.SelectedItem.ToString());
                    listBox2.Items.RemoveAt(selIndex);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        }
    }
}
