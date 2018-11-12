using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz
{
    public partial class EditTool : Form
    {
        public EditTool()
        {
            InitializeComponent();
        }
        public EditTool(string dictionaryName)
        {
            InitializeComponent();
            label1.Text = dictionaryName;
            try
            {
                textBox2.Text = System.IO.File.ReadAllText(dictionaryName + ".txt");
            }
            catch (Exception)
            {
                this.Close();
                throw;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText(label1.Text + ".txt",textBox2.Text);
            this.Close();
        }

    }
}
