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
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уПDataSet.Vid_abonementa". При необходимости она может быть перемещена или удалена.
            this.vid_abonementaTableAdapter.Fill(this.уПDataSet.Vid_abonementa);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уПDataSet.Klienti". При необходимости она может быть перемещена или удалена.
            this.klientiTableAdapter.Fill(this.уПDataSet.Klienti);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уПDataSet.Sposob_oplati". При необходимости она может быть перемещена или удалена.
            this.sposob_oplatiTableAdapter.Fill(this.уПDataSet.Sposob_oplati);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уПDataSet.Oplata_uslug". При необходимости она может быть перемещена или удалена.
            this.oplata_uslugTableAdapter.Fill(this.уПDataSet.Oplata_uslug);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уПDataSet.Vedenie_sportivnih_program". При необходимости она может быть перемещена или удалена.
            this.vedenie_sportivnih_programTableAdapter.Fill(this.уПDataSet.Vedenie_sportivnih_program);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            oplataUslugBindingSource.EndEdit();
            oplata_uslugTableAdapter.Update(уПDataSet);
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
