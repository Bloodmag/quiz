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
    public partial class InputBox : Form
    {
        private static InputBox objInputBox;
        string output = "!*NONE*!";

        public InputBox()
        {
            InitializeComponent();
        }
        public static string ShowDialog(string question)
        {
            
            objInputBox = new InputBox();
            objInputBox.textBox1.Text = string.Empty;
            objInputBox.label1.Text = question;
            objInputBox.ShowDialog();
            return objInputBox.output;

        }
        

        private void InputBox_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            output = textBox1.Text;
            this.Close();
        }
    }
}
