
namespace УП
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
            this.components = new System.ComponentModel.Container();
            this.уПDataSet = new УП.УПDataSet();
            this.produktBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produktTableAdapter = new УП.УПDataSetTableAdapters.ProduktTableAdapter();
            this.oplataUslugBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oplata_uslugTableAdapter = new УП.УПDataSetTableAdapters.Oplata_uslugTableAdapter();
            this.sposobOplatiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sposob_oplatiTableAdapter = new УП.УПDataSetTableAdapters.Sposob_oplatiTableAdapter();
            this.klientiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.klientiTableAdapter = new УП.УПDataSetTableAdapters.KlientiTableAdapter();
            this.vidAbonementaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vid_abonementaTableAdapter = new УП.УПDataSetTableAdapters.Vid_abonementaTableAdapter();
            this.obslujivanieBaraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.obslujivanie_baraTableAdapter = new УП.УПDataSetTableAdapters.Obslujivanie_baraTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.уПDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oplataUslugBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sposobOplatiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vidAbonementaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obslujivanieBaraBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // уПDataSet
            // 
            this.уПDataSet.DataSetName = "УПDataSet";
            this.уПDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produktBindingSource
            // 
            this.produktBindingSource.DataMember = "Produkt";
            this.produktBindingSource.DataSource = this.уПDataSet;
            // 
            // produktTableAdapter
            // 
            this.produktTableAdapter.ClearBeforeFill = true;
            // 
            // oplataUslugBindingSource
            // 
            this.oplataUslugBindingSource.DataMember = "Oplata uslug";
            this.oplataUslugBindingSource.DataSource = this.уПDataSet;
            // 
            // oplata_uslugTableAdapter
            // 
            this.oplata_uslugTableAdapter.ClearBeforeFill = true;
            // 
            // sposobOplatiBindingSource
            // 
            this.sposobOplatiBindingSource.DataMember = "Sposob oplati";
            this.sposobOplatiBindingSource.DataSource = this.уПDataSet;
            // 
            // sposob_oplatiTableAdapter
            // 
            this.sposob_oplatiTableAdapter.ClearBeforeFill = true;
            // 
            // klientiBindingSource
            // 
            this.klientiBindingSource.DataMember = "Klienti";
            this.klientiBindingSource.DataSource = this.уПDataSet;
            // 
            // klientiTableAdapter
            // 
            this.klientiTableAdapter.ClearBeforeFill = true;
            // 
            // vidAbonementaBindingSource
            // 
            this.vidAbonementaBindingSource.DataMember = "Vid abonementa";
            this.vidAbonementaBindingSource.DataSource = this.уПDataSet;
            // 
            // vid_abonementaTableAdapter
            // 
            this.vid_abonementaTableAdapter.ClearBeforeFill = true;
            // 
            // obslujivanieBaraBindingSource
            // 
            this.obslujivanieBaraBindingSource.DataMember = "Obslujivanie bara";
            this.obslujivanieBaraBindingSource.DataSource = this.уПDataSet;
            // 
            // obslujivanie_baraTableAdapter
            // 
            this.obslujivanie_baraTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "Оплата услуг";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(198, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 44);
            this.button2.TabIndex = 1;
            this.button2.Text = "Обслуживание бара";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(381, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(184, 44);
            this.button3.TabIndex = 2;
            this.button3.Text = "Ведение спортивных занятий";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(490, 197);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Выход";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(198, 126);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(367, 44);
            this.button5.TabIndex = 5;
            this.button5.Text = "Сотрудники/Должность";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(198, 76);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(140, 44);
            this.button6.TabIndex = 6;
            this.button6.Text = "Продукт";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(8, 176);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(330, 44);
            this.button7.TabIndex = 7;
            this.button7.Text = "Способ оплаты";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(381, 76);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(184, 44);
            this.button8.TabIndex = 8;
            this.button8.Text = "Специализация тренера/Вид занятия";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(10, 76);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(142, 44);
            this.button9.TabIndex = 9;
            this.button9.Text = "Клиенты";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(8, 126);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(144, 44);
            this.button10.TabIndex = 10;
            this.button10.Text = "Вид абонемента";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(575, 233);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = " ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.уПDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oplataUslugBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sposobOplatiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vidAbonementaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obslujivanieBaraBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private УПDataSet уПDataSet;
        private System.Windows.Forms.BindingSource produktBindingSource;
        private УПDataSetTableAdapters.ProduktTableAdapter produktTableAdapter;
        private System.Windows.Forms.BindingSource oplataUslugBindingSource;
        private УПDataSetTableAdapters.Oplata_uslugTableAdapter oplata_uslugTableAdapter;
        private System.Windows.Forms.BindingSource sposobOplatiBindingSource;
        private УПDataSetTableAdapters.Sposob_oplatiTableAdapter sposob_oplatiTableAdapter;
        private System.Windows.Forms.BindingSource klientiBindingSource;
        private УПDataSetTableAdapters.KlientiTableAdapter klientiTableAdapter;
        private System.Windows.Forms.BindingSource vidAbonementaBindingSource;
        private УПDataSetTableAdapters.Vid_abonementaTableAdapter vid_abonementaTableAdapter;
        private System.Windows.Forms.BindingSource obslujivanieBaraBindingSource;
        private УПDataSetTableAdapters.Obslujivanie_baraTableAdapter obslujivanie_baraTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
    }
}

