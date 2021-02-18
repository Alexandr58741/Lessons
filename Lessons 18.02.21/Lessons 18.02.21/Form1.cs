using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lessons_18._02._21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        int number;
        const int N = 6;
        int countQuestion = 0;
        string question;
        int min = 10;
        int max = 100;

        const string IGUESS = "Я задумал число в замкнутом интервале [";
        const string NUMOFQUESTIONS = "Если отгадаешь число за";
        const string WILLMASTER = " вопросов, - станешь Магистром игры!\r\n";
        const string YESORNO = "Ответом на любой вопрос может быть только 'Да' или 'Нет'";
        const string CONGRATS = "Поздравляю! Вы Магистр игры!\r\n";
        const string YOUGUESSED = "Вы угадали! Я задумал число ";

        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            textBoxMore.Clear();
            textBoxLess.Clear();
            textBoxMin.Clear();
            textBoxMax.Clear();
            textBoxIqal.Clear();
            textBoxResult.Clear();
            textBoxStart.Clear();
            listBoxQuestions.Items.Clear();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            number = rnd.Next(min, max);

            textBoxMin.Text = min.ToString();
            textBoxMax.Text = max.ToString();
            string answer = IGUESS + min + ", " + max + "]\r\n" + NUMOFQUESTIONS + N + WILLMASTER + YESORNO;
            textBoxStart.Text = answer;
        }

        private void buttonMore_Click(object sender, EventArgs e)
        {
            countQuestion++;
            question = countQuestion.ToString() + ". ";
            question += "Число больше ";
            int n = int.Parse(textBoxMore.Text);
            question += n + "?";
            if (number > n)
                question += " - Да!";
            else
                question += " - Нет!";
            listBoxQuestions.Items.Add(question);


        }

        private void buttonLess_Click(object sender, EventArgs e)
        {
            countQuestion++;
            question = countQuestion.ToString() + ". ";
            question += "Число меньше ";
            int n = int.Parse(textBoxMore.Text);
            question += n + "?";
            if (number < n)
                question += " - Да!";
            else
                question += " - Нет!";
            listBoxQuestions.Items.Add(question);
        }

        private void buttonIqal_Click(object sender, EventArgs e)
        {
            countQuestion++;
            question = countQuestion.ToString() + ". ";
            question += "Число ровно ";
            int n = int.Parse(textBoxIqal.Text);
            question += n + "?";

            if (number == n)
            {
                question += " - Да!";
                if (countQuestion <= N)
                    textBoxResult.Text = CONGRATS + "\r\n" + YOUGUESSED + number;
                else
                    textBoxResult.Text = YOUGUESSED + number;
            }
            else
                question += " - Нет!";
            listBoxQuestions.Items.Add(question);
        }
    }
}
