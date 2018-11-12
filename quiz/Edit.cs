using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace quiz
{
    public partial class Edit : Form
    {
        //DirectoryInfo dir = new DirectoryInfo("."); //for file IO purposes
        string strBuff; //temp string variable


        public Edit()
        {
            InitializeComponent();
            foreach (Dictionary element in Form1.dataBase)
            {
                listBox1.Items.Add(element.name);
            }
        }

        private void Button1_Click(object sender, EventArgs e) //create a dictionary
        {
            strBuff = InputBox.ShowDialog("Введите имя словаря:");
            if (strBuff != "!*NONE*!")
            {
                if (!File.Exists(strBuff + ".txt"))
                {
                    if ((strBuff.Length > 0) && !strBuff.Any(c => ("<>:!\\/\"|?*".ToCharArray()).Contains(c)))
                    {
                        //Creating a new dictionary and a corresponding file
                        File.Create(strBuff + ".txt").Close();
                        Form1.ReloadDB();
                        //File.Delete(strBuff + ".txt");
                        //Reloading listbox
                        listBox1.Items.Clear();
                        foreach (Dictionary element in Form1.dataBase)
                        {
                            listBox1.Items.Add(element.name);
                        }
                    } else if (strBuff.Any(c => ("<>:!\\/\"|?*".ToCharArray()).Contains(c)))
                    {
                        //An exception for incorrect characters in dictionary name
                        MessageBox.Show("INCORRECT DICTIONARY NAME!", "WARNING");
                    } else
                    {
                        //An exception for empty dictionary name
                        MessageBox.Show("Empty name not allowed", "WARNING");
                    }
                } else
                {
                    MessageBox.Show("FILE ALREADY EXISTS!","WARNING");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e) //delete a dictionary
        {
            strBuff = listBox1.SelectedItem.ToString();
            File.Delete(strBuff + ".txt");
            Form1.ReloadDB();
            //Reloading listbox
            listBox1.Items.Clear();
            foreach (Dictionary element in Form1.dataBase)
            {
                listBox1.Items.Add(element.name);
            }
        }

        private void listbox1_DoubleClick(Object sender, EventArgs e)
        {
            EditTool editTool = new EditTool(listBox1.SelectedItem.ToString());
            editTool.ShowDialog();
            Form1.ReloadDB();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            EditTool editTool = new EditTool(listBox1.SelectedItem.ToString());
            editTool.ShowDialog();
            Form1.ReloadDB();
        }
    }
}
