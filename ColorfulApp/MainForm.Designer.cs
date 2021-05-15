namespace ColorfulApp
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.gbResults = new System.Windows.Forms.GroupBox();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.экспортВExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.предметыToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.классыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.учителяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.решитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьРасписаниеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.расписаниеКлассовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.расписаниеУчителейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.показатьЛогToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLb = new System.Windows.Forms.ToolStripStatusLabel();
            this.gbPlan = new System.Windows.Forms.GroupBox();
            this.dgvPlan = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoursCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btDelPlan = new System.Windows.Forms.Button();
            this.btChangePlan = new System.Windows.Forms.Button();
            this.btAddPlan = new System.Windows.Forms.Button();
            this.gbResults.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.gbPlan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlan)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbResults
            // 
            this.gbResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbResults.Controls.Add(this.rtbOutput);
            this.gbResults.Location = new System.Drawing.Point(496, 3);
            this.gbResults.Name = "gbResults";
            this.gbResults.Size = new System.Drawing.Size(559, 567);
            this.gbResults.TabIndex = 1;
            this.gbResults.TabStop = false;
            this.gbResults.Text = "Лог";
            this.gbResults.Visible = false;
            // 
            // rtbOutput
            // 
            this.rtbOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbOutput.Location = new System.Drawing.Point(3, 16);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.ReadOnly = true;
            this.rtbOutput.Size = new System.Drawing.Size(553, 548);
            this.rtbOutput.TabIndex = 0;
            this.rtbOutput.Text = "";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справочникToolStripMenuItem,
            this.решитьToolStripMenuItem,
            this.показатьЛогToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1055, 24);
            this.menuStrip.TabIndex = 4;
            this.menuStrip.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.сохранитьКакToolStripMenuItem,
            this.экспортВExcelToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.сохранитьКакToolStripMenuItem.Text = "Сохранить как...";
            this.сохранитьКакToolStripMenuItem.Click += new System.EventHandler(this.сохранитьКакToolStripMenuItem_Click);
            // 
            // экспортВExcelToolStripMenuItem
            // 
            this.экспортВExcelToolStripMenuItem.Name = "экспортВExcelToolStripMenuItem";
            this.экспортВExcelToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.экспортВExcelToolStripMenuItem.Text = "Экспорт в Excel";
            this.экспортВExcelToolStripMenuItem.Click += new System.EventHandler(this.экспортВExcelToolStripMenuItem_Click);
            // 
            // справочникToolStripMenuItem
            // 
            this.справочникToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.предметыToolStripMenuItem1,
            this.классыToolStripMenuItem,
            this.учителяToolStripMenuItem});
            this.справочникToolStripMenuItem.Name = "справочникToolStripMenuItem";
            this.справочникToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.справочникToolStripMenuItem.Text = "Справочник";
            // 
            // предметыToolStripMenuItem1
            // 
            this.предметыToolStripMenuItem1.Name = "предметыToolStripMenuItem1";
            this.предметыToolStripMenuItem1.Size = new System.Drawing.Size(131, 22);
            this.предметыToolStripMenuItem1.Text = "Предметы";
            this.предметыToolStripMenuItem1.Click += new System.EventHandler(this.предметыToolStripMenuItem1_Click);
            // 
            // классыToolStripMenuItem
            // 
            this.классыToolStripMenuItem.Name = "классыToolStripMenuItem";
            this.классыToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.классыToolStripMenuItem.Text = "Классы";
            this.классыToolStripMenuItem.Click += new System.EventHandler(this.классыToolStripMenuItem_Click);
            // 
            // учителяToolStripMenuItem
            // 
            this.учителяToolStripMenuItem.Name = "учителяToolStripMenuItem";
            this.учителяToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.учителяToolStripMenuItem.Text = "Учителя";
            this.учителяToolStripMenuItem.Click += new System.EventHandler(this.учителяToolStripMenuItem_Click);
            // 
            // решитьToolStripMenuItem
            // 
            this.решитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настройкиToolStripMenuItem,
            this.создатьРасписаниеToolStripMenuItem,
            this.расписаниеКлассовToolStripMenuItem,
            this.расписаниеУчителейToolStripMenuItem});
            this.решитьToolStripMenuItem.Name = "решитьToolStripMenuItem";
            this.решитьToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.решитьToolStripMenuItem.Text = "Расписание";
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.настройкиToolStripMenuItem.Text = "Параметры создания";
            this.настройкиToolStripMenuItem.Click += new System.EventHandler(this.настройкиToolStripMenuItem_Click);
            // 
            // создатьРасписаниеToolStripMenuItem
            // 
            this.создатьРасписаниеToolStripMenuItem.Name = "создатьРасписаниеToolStripMenuItem";
            this.создатьРасписаниеToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.создатьРасписаниеToolStripMenuItem.Text = "Создать";
            this.создатьРасписаниеToolStripMenuItem.Click += new System.EventHandler(this.расписаниеКлассовToolStripMenuItem_Click);
            // 
            // расписаниеКлассовToolStripMenuItem
            // 
            this.расписаниеКлассовToolStripMenuItem.Name = "расписаниеКлассовToolStripMenuItem";
            this.расписаниеКлассовToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.расписаниеКлассовToolStripMenuItem.Text = "Расписание классов";
            this.расписаниеКлассовToolStripMenuItem.Click += new System.EventHandler(this.полученноеРасписаниеToolStripMenuItem_Click);
            // 
            // расписаниеУчителейToolStripMenuItem
            // 
            this.расписаниеУчителейToolStripMenuItem.Name = "расписаниеУчителейToolStripMenuItem";
            this.расписаниеУчителейToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.расписаниеУчителейToolStripMenuItem.Text = "Расписание учителей";
            this.расписаниеУчителейToolStripMenuItem.Click += new System.EventHandler(this.расписаниеУчителейToolStripMenuItem_Click);
            // 
            // показатьЛогToolStripMenuItem
            // 
            this.показатьЛогToolStripMenuItem.Name = "показатьЛогToolStripMenuItem";
            this.показатьЛогToolStripMenuItem.Size = new System.Drawing.Size(135, 20);
            this.показатьЛогToolStripMenuItem.Text = "Показать/скрыть лог";
            this.показатьЛогToolStripMenuItem.Visible = false;
            this.показатьЛогToolStripMenuItem.Click += new System.EventHandler(this.показатьЛогToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLb});
            this.statusStrip.Location = new System.Drawing.Point(0, 594);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1055, 22);
            this.statusStrip.TabIndex = 5;
            this.statusStrip.Text = "statusStrip1";
            // 
            // statusLb
            // 
            this.statusLb.Name = "statusLb";
            this.statusLb.Size = new System.Drawing.Size(0, 17);
            // 
            // gbPlan
            // 
            this.gbPlan.Controls.Add(this.gbResults);
            this.gbPlan.Controls.Add(this.dgvPlan);
            this.gbPlan.Controls.Add(this.groupBox2);
            this.gbPlan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbPlan.Location = new System.Drawing.Point(0, 24);
            this.gbPlan.Name = "gbPlan";
            this.gbPlan.Size = new System.Drawing.Size(1055, 570);
            this.gbPlan.TabIndex = 6;
            this.gbPlan.TabStop = false;
            this.gbPlan.Text = "Учебный план";
            // 
            // dgvPlan
            // 
            this.dgvPlan.AllowUserToAddRows = false;
            this.dgvPlan.AllowUserToDeleteRows = false;
            this.dgvPlan.AllowUserToOrderColumns = true;
            this.dgvPlan.AllowUserToResizeRows = false;
            this.dgvPlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.Column1,
            this.dataGridViewTextBoxColumn3,
            this.HoursCount});
            this.dgvPlan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPlan.Location = new System.Drawing.Point(3, 16);
            this.dgvPlan.MultiSelect = false;
            this.dgvPlan.Name = "dgvPlan";
            this.dgvPlan.RowHeadersVisible = false;
            this.dgvPlan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlan.Size = new System.Drawing.Size(849, 551);
            this.dgvPlan.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Teacher";
            this.dataGridViewTextBoxColumn2.HeaderText = "Преподаватель";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Class";
            this.Column1.HeaderText = "Класс";
            this.Column1.Name = "Column1";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Subject";
            this.dataGridViewTextBoxColumn3.HeaderText = "Предмет";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // HoursCount
            // 
            this.HoursCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HoursCount.DataPropertyName = "Count";
            this.HoursCount.HeaderText = "Часы";
            this.HoursCount.Name = "HoursCount";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btDelPlan);
            this.groupBox2.Controls.Add(this.btChangePlan);
            this.groupBox2.Controls.Add(this.btAddPlan);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(852, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 551);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Действия";
            // 
            // btDelPlan
            // 
            this.btDelPlan.Location = new System.Drawing.Point(7, 78);
            this.btDelPlan.Name = "btDelPlan";
            this.btDelPlan.Size = new System.Drawing.Size(187, 23);
            this.btDelPlan.TabIndex = 9;
            this.btDelPlan.Text = "Удалить";
            this.btDelPlan.UseVisualStyleBackColor = true;
            this.btDelPlan.Click += new System.EventHandler(this.btDelPlan_Click);
            // 
            // btChangePlan
            // 
            this.btChangePlan.Location = new System.Drawing.Point(7, 49);
            this.btChangePlan.Name = "btChangePlan";
            this.btChangePlan.Size = new System.Drawing.Size(187, 23);
            this.btChangePlan.TabIndex = 8;
            this.btChangePlan.Text = "Изменить";
            this.btChangePlan.UseVisualStyleBackColor = true;
            this.btChangePlan.Click += new System.EventHandler(this.btChangePlan_Click);
            // 
            // btAddPlan
            // 
            this.btAddPlan.Location = new System.Drawing.Point(7, 20);
            this.btAddPlan.Name = "btAddPlan";
            this.btAddPlan.Size = new System.Drawing.Size(187, 23);
            this.btAddPlan.TabIndex = 7;
            this.btAddPlan.Text = "Добавить";
            this.btAddPlan.UseVisualStyleBackColor = true;
            this.btAddPlan.Click += new System.EventHandler(this.btAddPlan_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 616);
            this.Controls.Add(this.gbPlan);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.statusStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "Автоматическая генерация расписания";
            this.gbResults.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.gbPlan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlan)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbResults;
        private System.Windows.Forms.RichTextBox rtbOutput;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLb;
        private System.Windows.Forms.ToolStripMenuItem справочникToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem решитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem экспортВExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem показатьЛогToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьРасписаниеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem предметыToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem классыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem учителяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem расписаниеКлассовToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbPlan;
        private System.Windows.Forms.DataGridView dgvPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoursCount;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btDelPlan;
        private System.Windows.Forms.Button btChangePlan;
        private System.Windows.Forms.Button btAddPlan;
        private System.Windows.Forms.ToolStripMenuItem расписаниеУчителейToolStripMenuItem;
    }
}

