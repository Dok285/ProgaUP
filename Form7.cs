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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уПDataSet.Sposob_oplati". При необходимости она может быть перемещена или удалена.
            this.sposob_oplatiTableAdapter.Fill(this.уПDataSet.Sposob_oplati);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sposobOplatiBindingSource.EndEdit();
            sposob_oplatiTableAdapter.Update(уПDataSet);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
