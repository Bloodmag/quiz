using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.IO;

namespace quiz
{
    public partial class Form1 : Form
    {
        public static List<Dictionary> dataBase = new List<Dictionary>();
        //Functions
        public Form1()
        {
            InitializeComponent();
            Form1.ReloadDB();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (dataBase.Count() == 0)
            {
                MessageBox.Show("No words found. Please, check the \"Edit\" section.", "WARNING");
                return;
            }
            Learn learn = new Learn();
            learn.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataBase.Count() == 0)
            {
                MessageBox.Show("No words found. Please, check the \"Edit\" section.", "WARNING");
                return;
            }
            Test test = new Test();
            test.ShowDialog();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ПрограммаДляИзученияСлов(НЕ ЗАБЫТЬ ПЕРЕИМЕНОВАТЬ!) v. BETA 0.9\n Сделано в образовательных целях на добровольных началах. Во время разработки данного приложения ни один динозаврик не пострадал. Также я нахожу крайне удивительным тот факт, что кто-то читает данный текст. Я в замешательстве и всё, что мне остаётся - пожелать вам хорошего дня!","INFO");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Edit edit = new Edit();
            edit.ShowDialog();
        }

        public static void ReloadDB()
        {
            dataBase.Clear();
            string[] files = Directory.GetFiles(".");
            foreach (string s in files)
            {
                if (s.Contains(".txt"))
                {
                    dataBase.Add(new Dictionary(s));
                    dataBase[dataBase.Count() - 1].name = s.Substring(2, s.IndexOf(".txt") - 2);
                    dataBase[dataBase.Count() - 1].ReadFromFile(s);
                }
            }
        }

        
    }
}
