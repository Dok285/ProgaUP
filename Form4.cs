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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уПDataSet.Vid_zanatia". При необходимости она может быть перемещена или удалена.
            this.vid_zanatiaTableAdapter.Fill(this.уПDataSet.Vid_zanatia);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уПDataSet.Specializacia_trenera". При необходимости она может быть перемещена или удалена.
            this.specializacia_treneraTableAdapter.Fill(this.уПDataSet.Specializacia_trenera);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уПDataSet.Sotrudniki". При необходимости она может быть перемещена или удалена.
            this.sotrudnikiTableAdapter.Fill(this.уПDataSet.Sotrudniki);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уПDataSet.Vedenie_sportivnih_program". При необходимости она может быть перемещена или удалена.
            this.vedenie_sportivnih_programTableAdapter.Fill(this.уПDataSet.Vedenie_sportivnih_program);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уПDataSet.Sposob_oplati". При необходимости она может быть перемещена или удалена.
            this.sposob_oplatiTableAdapter.Fill(this.уПDataSet.Sposob_oplati);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уПDataSet.Oplata_uslug". При необходимости она может быть перемещена или удалена.
            this.oplata_uslugTableAdapter.Fill(this.уПDataSet.Oplata_uslug);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уПDataSet.Obslujivanie_bara". При необходимости она может быть перемещена или удалена.
            this.obslujivanie_baraTableAdapter.Fill(this.уПDataSet.Obslujivanie_bara);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            vedenieSportivnihProgramBindingSource.EndEdit();
            vedenie_sportivnih_programTableAdapter.Update(уПDataSet);
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
    }
}
