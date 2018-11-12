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
    //Этот файл создавался как копия формы "Learn", и комментированный код - напоминание об этом
    public partial class Test : Form
    {
        public Dictionary testDictionary = new Dictionary();
        public Dictionary randomDictionary = new Dictionary();
        private Random rnd = new Random();
        private int mode = 0; //object visibility
        private int currentWord = 0;
        private int correctAnswers = 0;
        private int testAnswer = 0;
        private List<Button> testButtons = new List<Button>();
        private Results results;

        public Test()
        {
            InitializeComponent();
            foreach (Dictionary element in Form1.dataBase)
            {
                lessonsList.Items.Add(element.name);
            }
            buttonStart.Enabled = false;
            testButtons.Add(buttonAns1);
            testButtons.Add(buttonAns2);
            testButtons.Add(buttonAns3);
            testButtons.Add(buttonAns4);
            this.KeyUp += new KeyEventHandler(Test_KeyUp);
            this.buttonAns1.GotFocus += new EventHandler(buttonAns_Focused);
            this.buttonAns2.GotFocus += new EventHandler(buttonAns_Focused);
            this.buttonAns3.GotFocus += new EventHandler(buttonAns_Focused);
            this.buttonAns4.GotFocus += new EventHandler(buttonAns_Focused);
        }


        private void Test_KeyUp(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Escape) this.Close();
            if (e.KeyCode == Keys.D1 && mode == 2) buttonAns1.PerformClick();
            if (e.KeyCode == Keys.D2 && mode == 2) buttonAns2.PerformClick();
            if (e.KeyCode == Keys.D3 && mode == 2) buttonAns3.PerformClick();
            if (e.KeyCode == Keys.D4 && mode == 2) buttonAns4.PerformClick();
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
            //this.ChangeMode();
            if (mode == 0)
            {
                testDictionary.words.Clear();
                currentWord = 0;
                correctAnswers = 0;
                foreach (int i in lessonsList.CheckedIndices)
                {
                    testDictionary.words.AddRange(Form1.dataBase[i].words);
                }

                if (testDictionary.words.Count == 0)
                {
                    MessageBox.Show("The choosen dictionaries are empty or corrupted =(", "WARNING");
                    return;
                }
                if (testDictionary.words.Count < 4)
                {
                    MessageBox.Show("There are less then 4 words in the choosen dictionaries. Are you serious?", "WARNING");
                    return;
                }

                ShuffleDictionary();
                labelProgress.Text = (currentWord + 1).ToString() + "/" + randomDictionary.words.Count.ToString();
                if (radioButton1.Checked)
                {
                    ChangeMode(1);
                    question.Text = randomDictionary.words[currentWord].ru;
                }
                if (radioButton2.Checked)
                {
                    ChangeMode(2);
                    question.Text = randomDictionary.words[currentWord].en;
                    testAnswer = PrepareTestButtons();

                }
                return;
            }

            if (mode == 1)
            {
                if (AnswerIsCorrect(randomDictionary.words[currentWord].en, answer.Text))
                {
                    correctAnswers++;
                } else
                {
                    MessageBox.Show("\""+ answer.Text.Trim()+"\" is worng. The correct answer is: \""+ randomDictionary.words[currentWord].en.Trim()+"\"", "(T.T)");
                }

                answer.Text = "";

                if (currentWord < randomDictionary.words.Count - 1) {
                    currentWord++;
                    labelProgress.Text = (currentWord + 1).ToString() + "/" + randomDictionary.words.Count.ToString();
                    question.Text = randomDictionary.words[currentWord].ru;
                } else
                {
                    ChangeMode(0);

                    //************************SHOW RESULTS
                    results = new Results("YOUR SCORE:\n"+correctAnswers.ToString()+"/"+randomDictionary.words.Count.ToString()+"\n\nYOUR MARK:\n"+Math.Round((float)correctAnswers/(float)randomDictionary.words.Count*10).ToString()+"/10\n\n" + ((((float)correctAnswers / (float)randomDictionary.words.Count*10)<7)? "YOU SHOULD TRY HARDER":"GOOD JOB!"));
                    results.ShowDialog();
                }
                return;
            }
            
        }
        /*
        private void buttonPrev_Click(object sender, EventArgs e)
        {
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
            } else
            {
                ChangeMode();
            }
            
        }*/

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

        public int RandomExcept(int max, int n) //returns a random number except some sertain values
        {
            int r = rnd.Next(max - 1);
            if (r >= n) r++;
            return r;
        }
        public int RandomExcept(int max, List<int> n)
        {
            n.Sort();
            int r = rnd.Next(max - n.Count);
            foreach (int i in n) {
                if (r >= i) r++;
            }
            return r;
        }

        private int PrepareTestButtons()
        {
            int r = rnd.Next(4) + 1;// ШОК!!!! НЕ С НУЛЯ!!! это потому, что кнопки ответов нумеруются 1-4 
            List<int> used = new List<int>
            {
                currentWord
            };
            int buff;
            switch (r)
            {
                case 1:
                    buttonAns1.Text = randomDictionary.words[currentWord].ru;
                    break;
                case 2:
                    buttonAns2.Text = randomDictionary.words[currentWord].ru;
                    break;
                case 3:
                    buttonAns3.Text = randomDictionary.words[currentWord].ru;
                    break;
                case 4:
                    buttonAns4.Text = randomDictionary.words[currentWord].ru;
                    break;
            }
            for(int i = 1; i <= 4; i++)
            {
                if (i == r) continue;
                buff = RandomExcept(randomDictionary.words.Count, used);
                testButtons[i-1].Text = randomDictionary.words[buff].ru;
                used.Add(buff);
            }
            

            return r;
        }

        private void ChangeMode(int m)
        {
            switch (m)
            {
                case 0:
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
                    buttonStart.Text = "Start";

                    tableLayoutPanel1.Hide();
                    buttonAns1.Enabled = false;
                    buttonAns2.Enabled = false;
                    buttonAns3.Enabled = false;
                    buttonAns4.Enabled = false;
                    answer.Enabled = false;
                    answer.Hide();
                    groupBox1.Show();
                    radioButton1.Enabled = true;
                    radioButton2.Enabled = true;

                    question.Hide();
                    question.Enabled = false;
                    labelProgress.Hide();
                    labelProgress.Enabled = false;
                    break;

                case 1:
                    mode = 1;
                    lessonsList.Hide();
                    lessonsList.Enabled = false;
                    button1.Hide();
                    button1.Enabled = false;
                    button2.Hide();
                    button2.Enabled = false;
                    label1.Hide();
                    label1.Enabled = false;

                    tableLayoutPanel1.Hide();
                    buttonAns1.Enabled = false;
                    buttonAns2.Enabled = false;
                    buttonAns3.Enabled = false;
                    buttonAns4.Enabled = false;
                    answer.Enabled = true;
                    answer.Show();
                    answer.Focus();
                    groupBox1.Hide();
                    radioButton1.Enabled = false;
                    radioButton2.Enabled = false;

                    buttonStart.Show();
                    buttonStart.Enabled = true;
                    buttonStart.Text = "SUBMIT";
                    question.Show();
                    question.Enabled = true;
                    labelProgress.Show();
                    labelProgress.Enabled = true;
                    //question.Focus();
                    break;
                case 2:
                    mode = 2;
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

                    tableLayoutPanel1.Show();
                    buttonAns1.Enabled = true;
                    buttonAns2.Enabled = true;
                    buttonAns3.Enabled = true;
                    buttonAns4.Enabled = true;
                    answer.Enabled = false;
                    answer.Hide();
                    groupBox1.Hide();
                    radioButton1.Enabled = false;
                    radioButton2.Enabled = false;

                    question.Show();
                    question.Enabled = true;
                    labelProgress.Show();
                    labelProgress.Enabled = true;
                    question.Focus();
                    break;
            }
        }
/*
        private void buttonNext_Focused(object sender, EventArgs e)
        {
            wordEng.Focus();
        }
        private void buttonPrev_Focused(object sender, EventArgs e)
        {
            wordEng.Focus();
        }
        */


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

        private bool AnswerIsCorrect(string s1, string s2)
        {
            if (s1.Split(' ').Last().ToLower().Trim() == s2.Split(' ').Last().ToLower().Trim()) return true;
            if (s1.ToLower().Trim() == s2.ToLower().Trim())                                     return true;
            return false;
        }

        private void question_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonAns1_Click(object sender, EventArgs e)
        {
            if (testAnswer == 1)
            {
                correctAnswers++;
            } else
            {
                MessageBox.Show("You are worng. The correct answer is: \"" + randomDictionary.words[currentWord].ru.Trim() + "\"", "(T.T)");
            }
            if (currentWord < randomDictionary.words.Count - 1)
            {
                currentWord++;
                labelProgress.Text = (currentWord + 1).ToString() + "/" + randomDictionary.words.Count.ToString();
                question.Text = randomDictionary.words[currentWord].en;
                testAnswer = PrepareTestButtons();

            } else
            {
                //results
                results = new Results("YOUR SCORE:\n" + correctAnswers.ToString() + "/" + randomDictionary.words.Count.ToString() + "\n\nYOUR MARK:\n" + Math.Round((float)correctAnswers / (float)randomDictionary.words.Count * 10).ToString() + "/10\n\n" + ((((float)correctAnswers / (float)randomDictionary.words.Count * 10) < 7) ? "YOU SHOULD TRY HARDER" : "GOOD JOB!"));
                results.ShowDialog();
                ChangeMode(0);
            }
        }

        private void buttonAns2_Click(object sender, EventArgs e)
        {
            if (testAnswer == 2)
            {
                correctAnswers++;
            } else
            {
                MessageBox.Show("You are worng. The correct answer is: \"" + randomDictionary.words[currentWord].ru.Trim() + "\"", "(T.T)");
            }
            if (currentWord < randomDictionary.words.Count - 1)
            {
                currentWord++;
                labelProgress.Text = (currentWord + 1).ToString() + "/" + randomDictionary.words.Count.ToString();
                question.Text = randomDictionary.words[currentWord].en;
                testAnswer = PrepareTestButtons();

            } else
            {
                //results
                results = new Results("YOUR SCORE:\n" + correctAnswers.ToString() + "/" + randomDictionary.words.Count.ToString() + "\n\nYOUR MARK:\n" + Math.Round((float)correctAnswers / (float)randomDictionary.words.Count * 10).ToString() + "/10\n\n" + ((((float)correctAnswers / (float)randomDictionary.words.Count * 10) < 7) ? "YOU SHOULD TRY HARDER" : "GOOD JOB!"));
                results.ShowDialog();
                ChangeMode(0);
            }
        }

        private void buttonAns3_Click(object sender, EventArgs e)
        {
            if (testAnswer == 3)
            {
                correctAnswers++;
            } else
            {
                MessageBox.Show("You are worng. The correct answer is: \"" + randomDictionary.words[currentWord].ru.Trim() + "\"", "(T.T)");
            }
            if (currentWord < randomDictionary.words.Count - 1)
            {
                currentWord++;
                labelProgress.Text = (currentWord + 1).ToString() + "/" + randomDictionary.words.Count.ToString();
                question.Text = randomDictionary.words[currentWord].en;
                testAnswer = PrepareTestButtons();

            } else
            {
                //results
                results = new Results("YOUR SCORE:\n" + correctAnswers.ToString() + "/" + randomDictionary.words.Count.ToString() + "\n\nYOUR MARK:\n" + Math.Round((float)correctAnswers / (float)randomDictionary.words.Count * 10).ToString() + "/10\n\n" + ((((float)correctAnswers / (float)randomDictionary.words.Count * 10) < 7) ? "YOU SHOULD TRY HARDER" : "GOOD JOB!"));
                results.ShowDialog();
                ChangeMode(0);
            }
        }

        private void buttonAns4_Click(object sender, EventArgs e)
        {
            if (testAnswer == 4)
            {
                correctAnswers++;
            } else
            {
                MessageBox.Show("You are worng. The correct answer is: \"" + randomDictionary.words[currentWord].ru.Trim() + "\"", "(T.T)");
            }
            if (currentWord < randomDictionary.words.Count - 1)
            {
                currentWord++;
                labelProgress.Text = (currentWord + 1).ToString() + "/" + randomDictionary.words.Count.ToString();
                question.Text = randomDictionary.words[currentWord].en;
                testAnswer = PrepareTestButtons();

            } else
            {
                //results
                results = new Results("YOUR SCORE:\n" + correctAnswers.ToString() + "/" + randomDictionary.words.Count.ToString() + "\n\nYOUR MARK:\n" + Math.Round((float)correctAnswers / (float)randomDictionary.words.Count * 10).ToString() + "/10\n\n" + ((((float)correctAnswers / (float)randomDictionary.words.Count * 10) < 7) ? "YOU SHOULD TRY HARDER" : "GOOD JOB!"));
                results.ShowDialog();
                ChangeMode(0);
            }
        }

        private void buttonAns_Focused(object sender, EventArgs e)
        {
            question.Focus();
        }
    }
}
