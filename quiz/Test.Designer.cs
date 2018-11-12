namespace quiz
{
    partial class Test
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Test));
            this.lessonsList = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.question = new System.Windows.Forms.Label();
            this.labelProgress = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.answer = new System.Windows.Forms.TextBox();
            this.buttonAns1 = new System.Windows.Forms.Button();
            this.buttonAns2 = new System.Windows.Forms.Button();
            this.buttonAns3 = new System.Windows.Forms.Button();
            this.buttonAns4 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lessonsList
            // 
            this.lessonsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lessonsList.CheckOnClick = true;
            this.lessonsList.FormattingEnabled = true;
            this.lessonsList.Location = new System.Drawing.Point(314, 28);
            this.lessonsList.Margin = new System.Windows.Forms.Padding(2);
            this.lessonsList.Name = "lessonsList";
            this.lessonsList.Size = new System.Drawing.Size(270, 244);
            this.lessonsList.TabIndex = 0;
            this.lessonsList.TabStop = false;
            this.lessonsList.SelectedIndexChanged += new System.EventHandler(this.lessonsList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(11, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 74);
            this.label1.TabIndex = 1;
            this.label1.Text = "CHOOSE \r\nYOUR DESTINY:";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(468, 276);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 19);
            this.button1.TabIndex = 2;
            this.button1.Text = "ALL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(528, 276);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 19);
            this.button2.TabIndex = 3;
            this.button2.Text = "None";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonStart.Location = new System.Drawing.Point(258, 289);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(109, 55);
            this.buttonStart.TabIndex = 4;
            this.buttonStart.Text = "START";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // question
            // 
            this.question.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.question.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.question.Location = new System.Drawing.Point(9, 53);
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(600, 124);
            this.question.TabIndex = 5;
            this.question.Text = "WordEng";
            this.question.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.question.Visible = false;
            this.question.Click += new System.EventHandler(this.question_Click);
            // 
            // labelProgress
            // 
            this.labelProgress.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProgress.Location = new System.Drawing.Point(258, 349);
            this.labelProgress.Name = "labelProgress";
            this.labelProgress.Size = new System.Drawing.Size(109, 23);
            this.labelProgress.TabIndex = 9;
            this.labelProgress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelProgress.Visible = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(74, 17);
            this.radioButton1.TabIndex = 10;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "RU >> EN";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 42);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(74, 17);
            this.radioButton2.TabIndex = 11;
            this.radioButton2.Text = "EN >> RU";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(46, 171);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(98, 68);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "mode";
            // 
            // answer
            // 
            this.answer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answer.Location = new System.Drawing.Point(169, 231);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(290, 26);
            this.answer.TabIndex = 14;
            this.answer.Visible = false;
            this.answer.WordWrap = false;
            // 
            // buttonAns1
            // 
            this.buttonAns1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAns1.Location = new System.Drawing.Point(8, 8);
            this.buttonAns1.Margin = new System.Windows.Forms.Padding(8);
            this.buttonAns1.Name = "buttonAns1";
            this.buttonAns1.Size = new System.Drawing.Size(134, 52);
            this.buttonAns1.TabIndex = 15;
            this.buttonAns1.Text = "1";
            this.buttonAns1.UseVisualStyleBackColor = true;
            this.buttonAns1.Click += new System.EventHandler(this.buttonAns1_Click);
            // 
            // buttonAns2
            // 
            this.buttonAns2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAns2.Location = new System.Drawing.Point(158, 8);
            this.buttonAns2.Margin = new System.Windows.Forms.Padding(8);
            this.buttonAns2.Name = "buttonAns2";
            this.buttonAns2.Size = new System.Drawing.Size(134, 52);
            this.buttonAns2.TabIndex = 16;
            this.buttonAns2.Text = "2";
            this.buttonAns2.UseVisualStyleBackColor = true;
            this.buttonAns2.Click += new System.EventHandler(this.buttonAns2_Click);
            // 
            // buttonAns3
            // 
            this.buttonAns3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAns3.Location = new System.Drawing.Point(308, 8);
            this.buttonAns3.Margin = new System.Windows.Forms.Padding(8);
            this.buttonAns3.Name = "buttonAns3";
            this.buttonAns3.Size = new System.Drawing.Size(134, 52);
            this.buttonAns3.TabIndex = 17;
            this.buttonAns3.Text = "3";
            this.buttonAns3.UseVisualStyleBackColor = true;
            this.buttonAns3.Click += new System.EventHandler(this.buttonAns3_Click);
            // 
            // buttonAns4
            // 
            this.buttonAns4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAns4.Location = new System.Drawing.Point(458, 8);
            this.buttonAns4.Margin = new System.Windows.Forms.Padding(8);
            this.buttonAns4.Name = "buttonAns4";
            this.buttonAns4.Size = new System.Drawing.Size(134, 52);
            this.buttonAns4.TabIndex = 18;
            this.buttonAns4.Text = "4";
            this.buttonAns4.UseVisualStyleBackColor = true;
            this.buttonAns4.Click += new System.EventHandler(this.buttonAns4_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.buttonAns1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonAns4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonAns3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonAns2, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 277);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(600, 68);
            this.tableLayoutPanel1.TabIndex = 19;
            this.tableLayoutPanel1.Visible = false;
            // 
            // Test
            // 
            this.AcceptButton = this.buttonStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(624, 381);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelProgress);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lessonsList);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.question);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(640, 420);
            this.Name = "Test";
            this.Text = "Test";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void LessonsList_DoubleClick(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.CheckedListBox lessonsList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label question;
        private System.Windows.Forms.Label labelProgress;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox answer;
        private System.Windows.Forms.Button buttonAns1;
        private System.Windows.Forms.Button buttonAns2;
        private System.Windows.Forms.Button buttonAns3;
        private System.Windows.Forms.Button buttonAns4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}