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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уПDataSet.Obslujivanie_bara". При необходимости она может быть перемещена или удалена.
            this.obslujivanie_baraTableAdapter.Fill(this.уПDataSet.Obslujivanie_bara);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уПDataSet.Vid_abonementa". При необходимости она может быть перемещена или удалена.
            this.vid_abonementaTableAdapter.Fill(this.уПDataSet.Vid_abonementa);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уПDataSet.Klienti". При необходимости она может быть перемещена или удалена.
            this.klientiTableAdapter.Fill(this.уПDataSet.Klienti);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уПDataSet.Sposob_oplati". При необходимости она может быть перемещена или удалена.
            this.sposob_oplatiTableAdapter.Fill(this.уПDataSet.Sposob_oplati);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уПDataSet.Oplata_uslug". При необходимости она может быть перемещена или удалена.
            this.oplata_uslugTableAdapter.Fill(this.уПDataSet.Oplata_uslug);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уПDataSet.Produkt". При необходимости она может быть перемещена или удалена.
            this.produktTableAdapter.Fill(this.уПDataSet.Produkt);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 F2 = new Form2();
                F2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 F3 = new Form3();
            F3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 F4 = new Form4();
            F4.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form5 F5 = new Form5();
            F5.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form6 F6 = new Form6();
            F6.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form7 F7 = new Form7();
            F7.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form8 F8 = new Form8();
            F8.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form9 F9 = new Form9();
            F9.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form10 F10 = new Form10();
            F10.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Завершить работу программы?",
                    "Запрос",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question) == DialogResult.Cancel)

                e.Cancel = true;
        }
    }
}
