using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollectionApp
{
    public partial class Form1 : Form
    {
        ArrayList fruitlist;
        public Form1()
        {
            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fruitlist = new ArrayList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String fruitText = textBox1.Text;
            fruitlist.Add(fruitText);
            listBox1.Items.Clear();

            foreach(String item in fruitlist)
            {
                listBox1.Items.Add(item);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String fruitText = listBox1.SelectedItem.ToString();
            fruitlist.Remove(fruitText);
            listBox1.Items.Clear();

            foreach (String item in fruitlist)
            {
                listBox1.Items.Add(item);
            }
        }
    }
}
