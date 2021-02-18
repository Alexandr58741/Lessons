
namespace Lessons_18._02._21
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonNewGame = new System.Windows.Forms.Button();
            this.textBoxMin = new System.Windows.Forms.TextBox();
            this.textBoxMax = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.textBoxStart = new System.Windows.Forms.TextBox();
            this.listBoxQuestions = new System.Windows.Forms.ListBox();
            this.textBoxMore = new System.Windows.Forms.TextBox();
            this.textBoxLess = new System.Windows.Forms.TextBox();
            this.textBoxIqal = new System.Windows.Forms.TextBox();
            this.buttonMore = new System.Windows.Forms.Button();
            this.buttonLess = new System.Windows.Forms.Button();
            this.buttonIqal = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonNewGame
            // 
            this.buttonNewGame.Location = new System.Drawing.Point(694, 12);
            this.buttonNewGame.Name = "buttonNewGame";
            this.buttonNewGame.Size = new System.Drawing.Size(94, 35);
            this.buttonNewGame.TabIndex = 0;
            this.buttonNewGame.Text = "Новая игра";
            this.buttonNewGame.UseVisualStyleBackColor = true;
            this.buttonNewGame.Click += new System.EventHandler(this.buttonNewGame_Click);
            // 
            // textBoxMin
            // 
            this.textBoxMin.Location = new System.Drawing.Point(67, 43);
            this.textBoxMin.Name = "textBoxMin";
            this.textBoxMin.Size = new System.Drawing.Size(100, 20);
            this.textBoxMin.TabIndex = 1;
            // 
            // textBoxMax
            // 
            this.textBoxMax.Location = new System.Drawing.Point(67, 99);
            this.textBoxMax.Name = "textBoxMax";
            this.textBoxMax.Size = new System.Drawing.Size(100, 20);
            this.textBoxMax.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Мин.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Макс.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Границы диапазона";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(16, 145);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(171, 39);
            this.buttonStart.TabIndex = 6;
            this.buttonStart.Text = "Компьютер, загадай число";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // textBoxStart
            // 
            this.textBoxStart.Location = new System.Drawing.Point(223, 46);
            this.textBoxStart.Multiline = true;
            this.textBoxStart.Name = "textBoxStart";
            this.textBoxStart.Size = new System.Drawing.Size(394, 163);
            this.textBoxStart.TabIndex = 7;
            // 
            // listBoxQuestions
            // 
            this.listBoxQuestions.FormattingEnabled = true;
            this.listBoxQuestions.Location = new System.Drawing.Point(285, 259);
            this.listBoxQuestions.Name = "listBoxQuestions";
            this.listBoxQuestions.Size = new System.Drawing.Size(265, 160);
            this.listBoxQuestions.TabIndex = 8;
            // 
            // textBoxMore
            // 
            this.textBoxMore.Location = new System.Drawing.Point(136, 280);
            this.textBoxMore.Name = "textBoxMore";
            this.textBoxMore.Size = new System.Drawing.Size(100, 20);
            this.textBoxMore.TabIndex = 9;
            // 
            // textBoxLess
            // 
            this.textBoxLess.Location = new System.Drawing.Point(136, 337);
            this.textBoxLess.Name = "textBoxLess";
            this.textBoxLess.Size = new System.Drawing.Size(100, 20);
            this.textBoxLess.TabIndex = 10;
            // 
            // textBoxIqal
            // 
            this.textBoxIqal.Location = new System.Drawing.Point(136, 399);
            this.textBoxIqal.Name = "textBoxIqal";
            this.textBoxIqal.Size = new System.Drawing.Size(100, 20);
            this.textBoxIqal.TabIndex = 11;
            // 
            // buttonMore
            // 
            this.buttonMore.Location = new System.Drawing.Point(29, 269);
            this.buttonMore.Name = "buttonMore";
            this.buttonMore.Size = new System.Drawing.Size(92, 32);
            this.buttonMore.TabIndex = 12;
            this.buttonMore.Text = "Число больше";
            this.buttonMore.UseVisualStyleBackColor = true;
            this.buttonMore.Click += new System.EventHandler(this.buttonMore_Click);
            // 
            // buttonLess
            // 
            this.buttonLess.Location = new System.Drawing.Point(29, 326);
            this.buttonLess.Name = "buttonLess";
            this.buttonLess.Size = new System.Drawing.Size(92, 30);
            this.buttonLess.TabIndex = 13;
            this.buttonLess.Text = "Число меньше";
            this.buttonLess.UseVisualStyleBackColor = true;
            this.buttonLess.Click += new System.EventHandler(this.buttonLess_Click);
            // 
            // buttonIqal
            // 
            this.buttonIqal.Location = new System.Drawing.Point(29, 388);
            this.buttonIqal.Name = "buttonIqal";
            this.buttonIqal.Size = new System.Drawing.Size(92, 34);
            this.buttonIqal.TabIndex = 14;
            this.buttonIqal.Text = "Число ровно";
            this.buttonIqal.UseVisualStyleBackColor = true;
            this.buttonIqal.Click += new System.EventHandler(this.buttonIqal_Click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(597, 296);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(191, 113);
            this.textBoxResult.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(669, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Результат";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(375, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Вопросы и ответы";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.buttonIqal);
            this.Controls.Add(this.buttonLess);
            this.Controls.Add(this.buttonMore);
            this.Controls.Add(this.textBoxIqal);
            this.Controls.Add(this.textBoxLess);
            this.Controls.Add(this.textBoxMore);
            this.Controls.Add(this.listBoxQuestions);
            this.Controls.Add(this.textBoxStart);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMax);
            this.Controls.Add(this.textBoxMin);
            this.Controls.Add(this.buttonNewGame);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNewGame;
        private System.Windows.Forms.TextBox textBoxMin;
        private System.Windows.Forms.TextBox textBoxMax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.TextBox textBoxStart;
        private System.Windows.Forms.ListBox listBoxQuestions;
        private System.Windows.Forms.TextBox textBoxMore;
        private System.Windows.Forms.TextBox textBoxLess;
        private System.Windows.Forms.TextBox textBoxIqal;
        private System.Windows.Forms.Button buttonMore;
        private System.Windows.Forms.Button buttonLess;
        private System.Windows.Forms.Button buttonIqal;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

