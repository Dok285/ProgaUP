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


    public partial class Form5 : Form
    {

        public Form5 selfRef { get; set; }
        public Form5()
        {
            selfRef = this;
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уПDataSet.Doljnost". При необходимости она может быть перемещена или удалена.
            this.doljnostTableAdapter.Fill(this.уПDataSet.Doljnost);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уПDataSet.Sotrudniki". При необходимости она может быть перемещена или удалена.
            this.sotrudnikiTableAdapter.Fill(this.уПDataSet.Sotrudniki);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            doljnostBindingSource.EndEdit();
            doljnostTableAdapter.Update(уПDataSet);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sotrudnikiBindingSource.EndEdit();
            sotrudnikiTableAdapter.Update(уПDataSet);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
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
