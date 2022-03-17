using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form3 : Form
    {
        public Form mainform;
        public ListBox lb;
        public TextBox tb;
        public Form3()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = comboBox1.SelectedItem.ToString();
            mainform.BackColor = Color.FromName(name);
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Type colorType = typeof(System.Drawing.Color);
            // We take only static property to avoid properties like Name, IsSystemColor ...
            PropertyInfo[] propInfos = colorType.GetProperties(BindingFlags.Static | BindingFlags.DeclaredOnly | BindingFlags.Public);
            foreach (PropertyInfo propInfo in propInfos)
            {
                comboBox1.Items.Add(propInfo.Name);
                comboBox2.Items.Add(propInfo.Name);
            }
            }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = comboBox2.SelectedItem.ToString();
            mainform.ForeColor = Color.FromName(name);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string name = comboBox1.SelectedItem.ToString();
            mainform.BackColor = Color.FromName(name);
            lb.BackColor = Color.FromName(name);
            tb.BackColor = Color.FromName(name);
        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string name = comboBox2.SelectedItem.ToString();
            mainform.ForeColor = Color.FromName(name);
            lb.ForeColor = Color.FromName(name);
            tb.ForeColor = Color.FromName(name);
        }
    }
}
