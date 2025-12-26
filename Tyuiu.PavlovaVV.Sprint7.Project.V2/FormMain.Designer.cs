namespace Tyuiu.PavlovaVV.Sprint7.Project.V2
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            menuStrip1 = new MenuStrip();
            справкаToolStripMenuItem = new ToolStripMenuItem();
            оПрограммеToolStripMenuItem = new ToolStripMenuItem();
            оРазработчикеToolStripMenuItem = new ToolStripMenuItem();
            поддержкаToolStripMenuItem = new ToolStripMenuItem();
            tabControl_PVV = new TabControl();
            tabPage2 = new TabPage();
            dataGridViewData_PVV = new DataGridView();
            Number_PVV = new DataGridViewTextBoxColumn();
            Name_PVV = new DataGridViewTextBoxColumn();
            Adress_PVV = new DataGridViewTextBoxColumn();
            Money_PVV = new DataGridViewTextBoxColumn();
            Phone_PVV = new DataGridViewTextBoxColumn();
            groupBoxFilter_PVV = new GroupBox();
            buttonFilter_PVV = new Button();
            comboBoxNames_PVV = new ComboBox();
            textBoxFilter_PVV = new TextBox();
            textBoxSearch_PVV = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            buttonDel_PVV = new Button();
            buttonAdd_PVV = new Button();
            groupBoxWorkData_PVV = new GroupBox();
            buttonDownload_PVV = new Button();
            buttonOpen_PVV = new Button();
            tabPage1 = new TabPage();
            buttonCalculate = new Button();
            buttonStats_PVV = new Button();
            chartMoney_PVV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            toolTip_PVV = new ToolTip(components);
            openFileDialog_PVV = new OpenFileDialog();
            saveFileDialog_PVV = new SaveFileDialog();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            menuStrip1.SuspendLayout();
            tabControl_PVV.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewData_PVV).BeginInit();
            groupBoxFilter_PVV.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBoxWorkData_PVV.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartMoney_PVV).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { справкаToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(2069, 53);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // справкаToolStripMenuItem
            // 
            справкаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { оПрограммеToolStripMenuItem, оРазработчикеToolStripMenuItem, поддержкаToolStripMenuItem });
            справкаToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            справкаToolStripMenuItem.Size = new Size(171, 49);
            справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            оПрограммеToolStripMenuItem.Size = new Size(408, 54);
            оПрограммеToolStripMenuItem.Text = "О программе";
            оПрограммеToolStripMenuItem.Click += оПрограммеToolStripMenuItem_Click;
            // 
            // оРазработчикеToolStripMenuItem
            // 
            оРазработчикеToolStripMenuItem.Name = "оРазработчикеToolStripMenuItem";
            оРазработчикеToolStripMenuItem.Size = new Size(408, 54);
            оРазработчикеToolStripMenuItem.Text = "О разработчике";
            оРазработчикеToolStripMenuItem.Click += оРазработчикеToolStripMenuItem_Click;
            // 
            // поддержкаToolStripMenuItem
            // 
            поддержкаToolStripMenuItem.Name = "поддержкаToolStripMenuItem";
            поддержкаToolStripMenuItem.Size = new Size(408, 54);
            поддержкаToolStripMenuItem.Text = "Поддержка";
            поддержкаToolStripMenuItem.Click += поддержкаToolStripMenuItem_Click;
            // 
            // tabControl_PVV
            // 
            tabControl_PVV.Controls.Add(tabPage2);
            tabControl_PVV.Controls.Add(tabPage1);
            tabControl_PVV.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            tabControl_PVV.Location = new Point(27, 70);
            tabControl_PVV.Name = "tabControl_PVV";
            tabControl_PVV.SelectedIndex = 0;
            tabControl_PVV.Size = new Size(2030, 1169);
            tabControl_PVV.TabIndex = 1;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridViewData_PVV);
            tabPage2.Controls.Add(groupBoxFilter_PVV);
            tabPage2.Controls.Add(groupBox1);
            tabPage2.Controls.Add(groupBoxWorkData_PVV);
            tabPage2.Location = new Point(8, 59);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(2014, 1102);
            tabPage2.TabIndex = 0;
            tabPage2.Text = "База данных";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewData_PVV
            // 
            dataGridViewData_PVV.AllowUserToAddRows = false;
            dataGridViewData_PVV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewData_PVV.BackgroundColor = SystemColors.ActiveBorder;
            dataGridViewData_PVV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewData_PVV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewData_PVV.Columns.AddRange(new DataGridViewColumn[] { Number_PVV, Name_PVV, Adress_PVV, Money_PVV, Phone_PVV });
            dataGridViewData_PVV.Location = new Point(23, 286);
            dataGridViewData_PVV.Name = "dataGridViewData_PVV";
            dataGridViewData_PVV.RowHeadersVisible = false;
            dataGridViewData_PVV.RowHeadersWidth = 82;
            dataGridViewData_PVV.Size = new Size(1985, 810);
            dataGridViewData_PVV.TabIndex = 0;
            dataGridViewData_PVV.RowPrePaint += dataGridViewData_PVV_RowPrePaint;
            // 
            // Number_PVV
            // 
            Number_PVV.DataPropertyName = "1";
            Number_PVV.DividerWidth = 1;
            Number_PVV.HeaderText = "Номер филиала";
            Number_PVV.MinimumWidth = 10;
            Number_PVV.Name = "Number_PVV";
            Number_PVV.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // Name_PVV
            // 
            Name_PVV.DataPropertyName = "2";
            Name_PVV.DividerWidth = 1;
            Name_PVV.HeaderText = "Название";
            Name_PVV.MinimumWidth = 10;
            Name_PVV.Name = "Name_PVV";
            Name_PVV.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Adress_PVV
            // 
            Adress_PVV.DataPropertyName = "3";
            Adress_PVV.DividerWidth = 1;
            Adress_PVV.HeaderText = "Адрес";
            Adress_PVV.MinimumWidth = 10;
            Adress_PVV.Name = "Adress_PVV";
            Adress_PVV.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Money_PVV
            // 
            Money_PVV.DataPropertyName = "4";
            Money_PVV.DividerWidth = 1;
            Money_PVV.HeaderText = "Капитал владельца в данной точке";
            Money_PVV.MinimumWidth = 10;
            Money_PVV.Name = "Money_PVV";
            Money_PVV.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Phone_PVV
            // 
            Phone_PVV.DataPropertyName = "5";
            Phone_PVV.HeaderText = "Контактный телефон";
            Phone_PVV.MinimumWidth = 10;
            Phone_PVV.Name = "Phone_PVV";
            Phone_PVV.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // groupBoxFilter_PVV
            // 
            groupBoxFilter_PVV.Controls.Add(buttonFilter_PVV);
            groupBoxFilter_PVV.Controls.Add(comboBoxNames_PVV);
            groupBoxFilter_PVV.Controls.Add(textBoxFilter_PVV);
            groupBoxFilter_PVV.Controls.Add(textBoxSearch_PVV);
            groupBoxFilter_PVV.Controls.Add(label3);
            groupBoxFilter_PVV.Controls.Add(label2);
            groupBoxFilter_PVV.Controls.Add(label1);
            groupBoxFilter_PVV.Location = new Point(1062, 6);
            groupBoxFilter_PVV.Name = "groupBoxFilter_PVV";
            groupBoxFilter_PVV.Size = new Size(949, 274);
            groupBoxFilter_PVV.TabIndex = 1;
            groupBoxFilter_PVV.TabStop = false;
            groupBoxFilter_PVV.Text = "Фильтрация и поиск";
            // 
            // buttonFilter_PVV
            // 
            buttonFilter_PVV.Location = new Point(225, 180);
            buttonFilter_PVV.Name = "buttonFilter_PVV";
            buttonFilter_PVV.Size = new Size(529, 71);
            buttonFilter_PVV.TabIndex = 12;
            buttonFilter_PVV.Text = "Отфильтровать";
            buttonFilter_PVV.UseVisualStyleBackColor = true;
            buttonFilter_PVV.Click += buttonFilter_PVV_Click_1;
            // 
            // comboBoxNames_PVV
            // 
            comboBoxNames_PVV.FormattingEnabled = true;
            comboBoxNames_PVV.Items.AddRange(new object[] { "", "Номер филиала", "Название магазина", "Адрес", "Капитал владельца в данной точке", "Контактный телефон" });
            comboBoxNames_PVV.Location = new Point(331, 118);
            comboBoxNames_PVV.Name = "comboBoxNames_PVV";
            comboBoxNames_PVV.Size = new Size(308, 53);
            comboBoxNames_PVV.TabIndex = 11;
            comboBoxNames_PVV.SelectedIndexChanged += comboBoxNames_PVV_SelectedIndexChanged;
            // 
            // textBoxFilter_PVV
            // 
            textBoxFilter_PVV.Location = new Point(665, 121);
            textBoxFilter_PVV.Name = "textBoxFilter_PVV";
            textBoxFilter_PVV.Size = new Size(275, 50);
            textBoxFilter_PVV.TabIndex = 10;
            textBoxFilter_PVV.TextChanged += textBoxFilter_PVV_TextChanged;
            // 
            // textBoxSearch_PVV
            // 
            textBoxSearch_PVV.Location = new Point(24, 121);
            textBoxSearch_PVV.Name = "textBoxSearch_PVV";
            textBoxSearch_PVV.Size = new Size(275, 50);
            textBoxSearch_PVV.TabIndex = 9;
            textBoxSearch_PVV.TextChanged += textBoxSearch_PVV_TextChanged;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(674, 68);
            label3.Name = "label3";
            label3.Size = new Size(256, 53);
            label3.TabIndex = 8;
            label3.Text = "Ключ для фильтра:";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(355, 68);
            label2.Name = "label2";
            label2.Size = new Size(241, 53);
            label2.TabIndex = 7;
            label2.Text = "Выберите столбец:";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(24, 68);
            label1.Name = "label1";
            label1.Size = new Size(247, 53);
            label1.TabIndex = 6;
            label1.Text = "Ключ для поиска:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonDel_PVV);
            groupBox1.Controls.Add(buttonAdd_PVV);
            groupBox1.Location = new Point(534, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(522, 274);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Добавление/удаление данных";
            // 
            // buttonDel_PVV
            // 
            buttonDel_PVV.Image = (Image)resources.GetObject("buttonDel_PVV.Image");
            buttonDel_PVV.Location = new Point(276, 90);
            buttonDel_PVV.Name = "buttonDel_PVV";
            buttonDel_PVV.Size = new Size(121, 112);
            buttonDel_PVV.TabIndex = 5;
            toolTip_PVV.SetToolTip(buttonDel_PVV, "Удалить данные о магазине");
            buttonDel_PVV.UseVisualStyleBackColor = true;
            buttonDel_PVV.Click += buttonDel_PVV_Click_1;
            // 
            // buttonAdd_PVV
            // 
            buttonAdd_PVV.Image = (Image)resources.GetObject("buttonAdd_PVV.Image");
            buttonAdd_PVV.Location = new Point(96, 90);
            buttonAdd_PVV.Name = "buttonAdd_PVV";
            buttonAdd_PVV.Size = new Size(121, 112);
            buttonAdd_PVV.TabIndex = 4;
            toolTip_PVV.SetToolTip(buttonAdd_PVV, "Добавить данные о новом магазине");
            buttonAdd_PVV.UseVisualStyleBackColor = true;
            buttonAdd_PVV.Click += buttonAdd_PVV_Click_1;
            // 
            // groupBoxWorkData_PVV
            // 
            groupBoxWorkData_PVV.Controls.Add(buttonDownload_PVV);
            groupBoxWorkData_PVV.Controls.Add(buttonOpen_PVV);
            groupBoxWorkData_PVV.Location = new Point(6, 6);
            groupBoxWorkData_PVV.Name = "groupBoxWorkData_PVV";
            groupBoxWorkData_PVV.Size = new Size(522, 274);
            groupBoxWorkData_PVV.TabIndex = 0;
            groupBoxWorkData_PVV.TabStop = false;
            groupBoxWorkData_PVV.Text = "Загрузка/Выгрузка файла";
            // 
            // buttonDownload_PVV
            // 
            buttonDownload_PVV.Image = (Image)resources.GetObject("buttonDownload_PVV.Image");
            buttonDownload_PVV.Location = new Point(256, 90);
            buttonDownload_PVV.Name = "buttonDownload_PVV";
            buttonDownload_PVV.Size = new Size(121, 112);
            buttonDownload_PVV.TabIndex = 3;
            toolTip_PVV.SetToolTip(buttonDownload_PVV, "Сохранить изменёную базу данных");
            buttonDownload_PVV.UseVisualStyleBackColor = true;
            buttonDownload_PVV.Click += buttonDownload_PVV_Click_1;
            // 
            // buttonOpen_PVV
            // 
            buttonOpen_PVV.Image = (Image)resources.GetObject("buttonOpen_PVV.Image");
            buttonOpen_PVV.Location = new Point(76, 90);
            buttonOpen_PVV.Name = "buttonOpen_PVV";
            buttonOpen_PVV.Size = new Size(121, 112);
            buttonOpen_PVV.TabIndex = 2;
            toolTip_PVV.SetToolTip(buttonOpen_PVV, "Загрузить исходную базу данных");
            buttonOpen_PVV.UseVisualStyleBackColor = true;
            buttonOpen_PVV.Click += buttonOpen_PVV_Click;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(buttonCalculate);
            tabPage1.Controls.Add(buttonStats_PVV);
            tabPage1.Controls.Add(chartMoney_PVV);
            tabPage1.Location = new Point(8, 59);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(2014, 1102);
            tabPage1.TabIndex = 1;
            tabPage1.Text = "Статистика";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // buttonCalculate
            // 
            buttonCalculate.Location = new Point(488, 25);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(668, 94);
            buttonCalculate.TabIndex = 2;
            buttonCalculate.Text = "Статистика по капиталу";
            buttonCalculate.UseVisualStyleBackColor = true;
            buttonCalculate.Click += buttonCalculate_Click;
            // 
            // buttonStats_PVV
            // 
            buttonStats_PVV.Location = new Point(26, 25);
            buttonStats_PVV.Name = "buttonStats_PVV";
            buttonStats_PVV.Size = new Size(380, 94);
            buttonStats_PVV.TabIndex = 1;
            buttonStats_PVV.Text = "Рассчитать";
            buttonStats_PVV.UseVisualStyleBackColor = true;
            buttonStats_PVV.Click += buttonStats_PVV_Click_1;
            // 
            // chartMoney_PVV
            // 
            chartArea1.Name = "ChartArea1";
            chartMoney_PVV.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartMoney_PVV.Legends.Add(legend1);
            chartMoney_PVV.Location = new Point(6, 143);
            chartMoney_PVV.Name = "chartMoney_PVV";
            chartMoney_PVV.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartMoney_PVV.Series.Add(series1);
            chartMoney_PVV.Size = new Size(2005, 953);
            chartMoney_PVV.TabIndex = 0;
            chartMoney_PVV.Text = "Сумма выручки";
            // 
            // openFileDialog_PVV
            // 
            openFileDialog_PVV.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2069, 1251);
            Controls.Add(tabControl_PVV);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormMain";
            Text = "Сеть магазинов | Выполнила Павлова В. В.";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tabControl_PVV.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewData_PVV).EndInit();
            groupBoxFilter_PVV.ResumeLayout(false);
            groupBoxFilter_PVV.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBoxWorkData_PVV.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartMoney_PVV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem справкаToolStripMenuItem;
        private ToolStripMenuItem оПрограммеToolStripMenuItem;
        private ToolStripMenuItem оРазработчикеToolStripMenuItem;
        private ToolStripMenuItem поддержкаToolStripMenuItem;
        private TabControl tabControl_PVV;
        private TabPage tabPage2;
        private TabPage tabPage1;
        private GroupBox groupBoxFilter_PVV;
        private GroupBox groupBox1;
        private GroupBox groupBoxWorkData_PVV;
        private Button buttonOpen_PVV;
        private Button buttonDel_PVV;
        private Button buttonAdd_PVV;
        private Button buttonDownload_PVV;
        private Label label2;
        private Label label1;
        private ComboBox comboBoxNames_PVV;
        private TextBox textBoxFilter_PVV;
        private TextBox textBoxSearch_PVV;
        private Label label3;
        private Button buttonFilter_PVV;
        private DataGridView dataGridViewData_PVV;
        private Button buttonStats_PVV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMoney_PVV;
        private ToolTip toolTip_PVV;
        private OpenFileDialog openFileDialog_PVV;
        private SaveFileDialog saveFileDialog_PVV;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DataGridViewTextBoxColumn Number_PVV;
        private DataGridViewTextBoxColumn Name_PVV;
        private DataGridViewTextBoxColumn Adress_PVV;
        private DataGridViewTextBoxColumn Money_PVV;
        private DataGridViewTextBoxColumn Phone_PVV;
        private Button buttonCalculate;
    }
}
