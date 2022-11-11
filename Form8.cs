using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace УП
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уПDataSet.Vid_zanatia". При необходимости она может быть перемещена или удалена.
            this.vid_zanatiaTableAdapter.Fill(this.уПDataSet.Vid_zanatia);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уПDataSet.Specializacia_trenera". При необходимости она может быть перемещена или удалена.
            this.specializacia_treneraTableAdapter.Fill(this.уПDataSet.Specializacia_trenera);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                        if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                        {
                            dataGridView1.Rows[i].Selected = true;
                            break;
                        }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView2.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView2.ColumnCount; j++)
                    if (dataGridView2.Rows[i].Cells[j].Value != null)
                        if (dataGridView2.Rows[i].Cells[j].Value.ToString().Contains(textBox2.Text))
                        {
                            dataGridView2.Rows[i].Selected = true;
                            break;
                        }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            specializaciaTreneraBindingSource.EndEdit();
            specializacia_treneraTableAdapter.Update(уПDataSet);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            vidZanatiaBindingSource.EndEdit();
            vid_zanatiaTableAdapter.Update(уПDataSet);
        }
    }
}
