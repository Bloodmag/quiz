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
    public partial class Learn : Form
    {
        public Dictionary testDictionary = new Dictionary();
        public Dictionary randomDictionary = new Dictionary();
        private Random rnd = new Random();
        private int mode = 0; //object visibility
        private int currentWord = 0;

        public Learn()
        {
            InitializeComponent();
            foreach (Dictionary element in Form1.dataBase)
            {
                lessonsList.Items.Add(element.name);
            }
            buttonStart.Enabled = false;
            this.KeyUp += new KeyEventHandler(Learn_KeyUp);
            this.buttonNext.GotFocus += new EventHandler(buttonNext_Focused);
            this.buttonPrev.GotFocus += new EventHandler(buttonPrev_Focused);
        }


        private void Learn_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Right || e.KeyCode == Keys.D || e.KeyCode == Keys.Space)&& mode == 1) buttonNext.PerformClick();
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A) buttonPrev.PerformClick();
            if (e.KeyCode == Keys.Escape) this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lessonsList.Items.Count; i++)
            {
                lessonsList.SetItemChecked(i, true);
            }
            buttonStart.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lessonsList.Items.Count; i++)
            {
                lessonsList.SetItemChecked(i,false);
            }
            buttonStart.Enabled = false;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(Form1.dataBase.Count.ToString());
            this.ChangeMode();
            testDictionary.words.Clear();
            currentWord = 0;
            foreach(int i in lessonsList.CheckedIndices)
            {
                testDictionary.words.AddRange(Form1.dataBase[i].words);
            }
            if (testDictionary.words.Count==0)
            {
                MessageBox.Show("The choosen dictionaries are empty or corrupted =(","WARNING");
                return;
            }
            ShuffleDictionary();
            labelProgress.Text = (currentWord + 1).ToString() + "/" + randomDictionary.words.Count.ToString();
            wordEng.Text = randomDictionary.words[currentWord].en;
            wordRU.Text = randomDictionary.words[currentWord].ru;
            buttonNext.Text = ">>";
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            if (buttonNext.Text != ">>") buttonNext.Text = ">>";
            if (currentWord > 0)
            {
                currentWord--;
                labelProgress.Text = (currentWord + 1).ToString() + "/" + randomDictionary.words.Count.ToString();
                wordEng.Text = randomDictionary.words[currentWord].en;
                wordRU.Text = randomDictionary.words[currentWord].ru;
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (currentWord < randomDictionary.words.Count-1)
            {
                currentWord++;
                labelProgress.Text = (currentWord + 1).ToString() + "/" + randomDictionary.words.Count.ToString();
                wordEng.Text = randomDictionary.words[currentWord].en;
                wordRU.Text = randomDictionary.words[currentWord].ru;
                if (currentWord == randomDictionary.words.Count - 1) buttonNext.Text = "FINISH";
            } else
            {
                ChangeMode();
            }
            
        }

        public void ShuffleDictionary()
        {
            randomDictionary.words.Clear();
            int r;
            //List<int> index = new List<int>();
            //for (i = 0; i < testDictionary.words.Count; i++) index.Add(i);
            while (testDictionary.words.Count>0)
            {
                r = rnd.Next(testDictionary.words.Count);
                randomDictionary.words.Add(testDictionary.words[r]);
                testDictionary.words.RemoveAt(r);
                /*
                r = rnd.Next(testDictionary.words.Count - i);
                randomDictionary.words.Add(testDictionary.words[index[r]]);
                index.Remove(r);
                */
            }
        }
        
        private void ChangeMode()
        {
            if(mode == 0)
            {
                mode = 1;
                lessonsList.Hide();
                lessonsList.Enabled = false;
                button1.Hide();
                button1.Enabled = false;
                button2.Hide();
                button2.Enabled = false;
                label1.Hide();
                label1.Enabled = false;
                buttonStart.Hide();
                buttonStart.Enabled = false;
                wordEng.Show();
                wordEng.Enabled = true;
                wordRU.Show();
                wordRU.Enabled = true;
                buttonNext.Show();
                buttonNext.Enabled = true;
                buttonPrev.Show();
                buttonPrev.Enabled = true;
                labelProgress.Show();
                labelProgress.Enabled = true;
                wordEng.Focus();
            }
            else
            {
                mode = 0;
                lessonsList.Show();
                lessonsList.Enabled = true;
                button1.Show();
                button1.Enabled = true;
                button2.Show();
                button2.Enabled = true;
                label1.Show();
                label1.Enabled = true;
                buttonStart.Show();
                buttonStart.Enabled = true;
                wordEng.Hide();
                wordEng.Enabled = false;
                wordRU.Hide();
                wordRU.Enabled = false;
                buttonNext.Hide();
                buttonNext.Enabled = false;
                buttonPrev.Hide();
                buttonPrev.Enabled = false;
                labelProgress.Hide();
                labelProgress.Enabled = false;
            }
        }

        private void buttonNext_Focused(object sender, EventArgs e)
        {
            wordEng.Focus();
        }
        private void buttonPrev_Focused(object sender, EventArgs e)
        {
            wordEng.Focus();
        }



        private void lessonsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lessonsList.CheckedIndices.Count > 0)
            {
                buttonStart.Enabled =  true;
            } else
            {
                buttonStart.Enabled = false;
            }
        }
    }
}
