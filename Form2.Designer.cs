
namespace УП
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDOplatauslugDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomerabonementaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDKlientiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.klientiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.уПDataSet = new УП.УПDataSet();
            this.iDVidabonementaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.vidAbonementaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dlitelnostabonimentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateoplatiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateaktivaciiabonementaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDSposoboplatiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.sposobOplatiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oplataUslugBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vedenieSportivnihProgramBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vedenie_sportivnih_programTableAdapter = new УП.УПDataSetTableAdapters.Vedenie_sportivnih_programTableAdapter();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.oplata_uslugTableAdapter = new УП.УПDataSetTableAdapters.Oplata_uslugTableAdapter();
            this.sposob_oplatiTableAdapter = new УП.УПDataSetTableAdapters.Sposob_oplatiTableAdapter();
            this.klientiTableAdapter = new УП.УПDataSetTableAdapters.KlientiTableAdapter();
            this.vid_abonementaTableAdapter = new УП.УПDataSetTableAdapters.Vid_abonementaTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.уПDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vidAbonementaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sposobOplatiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oplataUslugBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vedenieSportivnihProgramBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDOplatauslugDataGridViewTextBoxColumn,
            this.nomerabonementaDataGridViewTextBoxColumn,
            this.iDKlientiDataGridViewTextBoxColumn,
            this.iDVidabonementaDataGridViewTextBoxColumn,
            this.dlitelnostabonimentaDataGridViewTextBoxColumn,
            this.dateoplatiDataGridViewTextBoxColumn,
            this.dateaktivaciiabonementaDataGridViewTextBoxColumn,
            this.iDSposoboplatiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.oplataUslugBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(14, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(852, 346);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDOplatauslugDataGridViewTextBoxColumn
            // 
            this.iDOplatauslugDataGridViewTextBoxColumn.DataPropertyName = "ID_Oplata_uslug";
            this.iDOplatauslugDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDOplatauslugDataGridViewTextBoxColumn.Name = "iDOplatauslugDataGridViewTextBoxColumn";
            this.iDOplatauslugDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomerabonementaDataGridViewTextBoxColumn
            // 
            this.nomerabonementaDataGridViewTextBoxColumn.DataPropertyName = "Nomer_abonementa";
            this.nomerabonementaDataGridViewTextBoxColumn.HeaderText = "Номер абонемента";
            this.nomerabonementaDataGridViewTextBoxColumn.Name = "nomerabonementaDataGridViewTextBoxColumn";
            // 
            // iDKlientiDataGridViewTextBoxColumn
            // 
            this.iDKlientiDataGridViewTextBoxColumn.DataPropertyName = "ID_Klienti";
            this.iDKlientiDataGridViewTextBoxColumn.DataSource = this.klientiBindingSource;
            this.iDKlientiDataGridViewTextBoxColumn.DisplayMember = "Familia";
            this.iDKlientiDataGridViewTextBoxColumn.HeaderText = "Клиент";
            this.iDKlientiDataGridViewTextBoxColumn.Name = "iDKlientiDataGridViewTextBoxColumn";
            this.iDKlientiDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iDKlientiDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iDKlientiDataGridViewTextBoxColumn.ValueMember = "ID_Klienti";
            // 
            // klientiBindingSource
            // 
            this.klientiBindingSource.DataMember = "Klienti";
            this.klientiBindingSource.DataSource = this.уПDataSet;
            // 
            // уПDataSet
            // 
            this.уПDataSet.DataSetName = "УПDataSet";
            this.уПDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iDVidabonementaDataGridViewTextBoxColumn
            // 
            this.iDVidabonementaDataGridViewTextBoxColumn.DataPropertyName = "ID_Vid_abonementa";
            this.iDVidabonementaDataGridViewTextBoxColumn.DataSource = this.vidAbonementaBindingSource;
            this.iDVidabonementaDataGridViewTextBoxColumn.DisplayMember = "Naimenovanie";
            this.iDVidabonementaDataGridViewTextBoxColumn.HeaderText = "Вид абонемента";
            this.iDVidabonementaDataGridViewTextBoxColumn.Name = "iDVidabonementaDataGridViewTextBoxColumn";
            this.iDVidabonementaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iDVidabonementaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iDVidabonementaDataGridViewTextBoxColumn.ValueMember = "ID_Vid_abonementa";
            // 
            // vidAbonementaBindingSource
            // 
            this.vidAbonementaBindingSource.DataMember = "Vid abonementa";
            this.vidAbonementaBindingSource.DataSource = this.уПDataSet;
            // 
            // dlitelnostabonimentaDataGridViewTextBoxColumn
            // 
            this.dlitelnostabonimentaDataGridViewTextBoxColumn.DataPropertyName = "Dlitelnost_abonimenta";
            this.dlitelnostabonimentaDataGridViewTextBoxColumn.HeaderText = "Длительность абонемента";
            this.dlitelnostabonimentaDataGridViewTextBoxColumn.Name = "dlitelnostabonimentaDataGridViewTextBoxColumn";
            // 
            // dateoplatiDataGridViewTextBoxColumn
            // 
            this.dateoplatiDataGridViewTextBoxColumn.DataPropertyName = "Date_oplati";
            this.dateoplatiDataGridViewTextBoxColumn.HeaderText = "Дата оплаты";
            this.dateoplatiDataGridViewTextBoxColumn.Name = "dateoplatiDataGridViewTextBoxColumn";
            // 
            // dateaktivaciiabonementaDataGridViewTextBoxColumn
            // 
            this.dateaktivaciiabonementaDataGridViewTextBoxColumn.DataPropertyName = "Date_aktivacii_abonementa";
            this.dateaktivaciiabonementaDataGridViewTextBoxColumn.HeaderText = "Дата активации";
            this.dateaktivaciiabonementaDataGridViewTextBoxColumn.Name = "dateaktivaciiabonementaDataGridViewTextBoxColumn";
            // 
            // iDSposoboplatiDataGridViewTextBoxColumn
            // 
            this.iDSposoboplatiDataGridViewTextBoxColumn.DataPropertyName = "ID_Sposob_oplati";
            this.iDSposoboplatiDataGridViewTextBoxColumn.DataSource = this.sposobOplatiBindingSource;
            this.iDSposoboplatiDataGridViewTextBoxColumn.DisplayMember = "Naimenovanie";
            this.iDSposoboplatiDataGridViewTextBoxColumn.HeaderText = "Способ оплаты";
            this.iDSposoboplatiDataGridViewTextBoxColumn.Name = "iDSposoboplatiDataGridViewTextBoxColumn";
            this.iDSposoboplatiDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iDSposoboplatiDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iDSposoboplatiDataGridViewTextBoxColumn.ValueMember = "ID_Sposob_oplati";
            // 
            // sposobOplatiBindingSource
            // 
            this.sposobOplatiBindingSource.DataMember = "Sposob oplati";
            this.sposobOplatiBindingSource.DataSource = this.уПDataSet;
            // 
            // oplataUslugBindingSource
            // 
            this.oplataUslugBindingSource.DataMember = "Oplata uslug";
            this.oplataUslugBindingSource.DataSource = this.уПDataSet;
            // 
            // vedenieSportivnihProgramBindingSource
            // 
            this.vedenieSportivnihProgramBindingSource.DataMember = "Vedenie sportivnih program";
            this.vedenieSportivnihProgramBindingSource.DataSource = this.уПDataSet;
            // 
            // vedenie_sportivnih_programTableAdapter
            // 
            this.vedenie_sportivnih_programTableAdapter.ClearBeforeFill = true;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.oplataUslugBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(982, 25);
            this.bindingNavigator1.TabIndex = 1;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // oplata_uslugTableAdapter
            // 
            this.oplata_uslugTableAdapter.ClearBeforeFill = true;
            // 
            // sposob_oplatiTableAdapter
            // 
            this.sposob_oplatiTableAdapter.ClearBeforeFill = true;
            // 
            // klientiTableAdapter
            // 
            this.klientiTableAdapter.ClearBeforeFill = true;
            // 
            // vid_abonementaTableAdapter
            // 
            this.vid_abonementaTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(872, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(872, 322);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(872, 54);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Поиск";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(872, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(982, 387);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Оплата услуг";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.уПDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vidAbonementaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sposobOplatiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oplataUslugBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vedenieSportivnihProgramBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private УПDataSet уПDataSet;
        private System.Windows.Forms.BindingSource vedenieSportivnihProgramBindingSource;
        private УПDataSetTableAdapters.Vedenie_sportivnih_programTableAdapter vedenie_sportivnih_programTableAdapter;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.BindingSource oplataUslugBindingSource;
        private УПDataSetTableAdapters.Oplata_uslugTableAdapter oplata_uslugTableAdapter;
        private System.Windows.Forms.BindingSource sposobOplatiBindingSource;
        private УПDataSetTableAdapters.Sposob_oplatiTableAdapter sposob_oplatiTableAdapter;
        private System.Windows.Forms.BindingSource klientiBindingSource;
        private УПDataSetTableAdapters.KlientiTableAdapter klientiTableAdapter;
        private System.Windows.Forms.BindingSource vidAbonementaBindingSource;
        private УПDataSetTableAdapters.Vid_abonementaTableAdapter vid_abonementaTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDOplatauslugDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomerabonementaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn iDKlientiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn iDVidabonementaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dlitelnostabonimentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateoplatiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateaktivaciiabonementaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn iDSposoboplatiDataGridViewTextBoxColumn;
    }
}