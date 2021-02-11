using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lessons_11._02._21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string[] student = new string[4];

            student[0] = (dataGridView1.Rows.Count + 1).ToString();
            student[1] = textBoxName.Text;
            student[2] = textBoxSurname.Text;
            student[3] = textBoxMark.Text;

            dataGridView1.Rows.Add(student[0], student[1], student[2], student[3]);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);

            textBoxName.Clear();
            textBoxSurname.Clear();
            textBoxMark.Clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBoxSurname.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBoxMark.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            dataGridView1.SelectedRows[0].Cells[1].Value = textBoxName.Text;
            dataGridView1.SelectedRows[0].Cells[2].Value = textBoxSurname.Text;
            dataGridView1.SelectedRows[0].Cells[3].Value = textBoxMark.Text;
        }

        private void buttonSr_Click(object sender, EventArgs e)
        {
            double summ = 0;
            double count = dataGridView1.Rows.Count;

            if(count != 0)
            {
                for(int i = 0; i < count; i++)
                {
                    summ += Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);

                }
                double average = summ / count;
                textBoxSr.Text = average.ToString();

            }
        }
    }
}

