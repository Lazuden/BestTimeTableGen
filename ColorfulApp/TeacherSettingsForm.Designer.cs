namespace ColorfulApp
{
    partial class TeacherSettingsForm
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
            this.lbTeacherList = new System.Windows.Forms.ListBox();
            this.cbFreeDay = new System.Windows.Forms.CheckBox();
            this.gbTeacherInterest = new System.Windows.Forms.GroupBox();
            this.nudLessonsPerDay = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.cbLessonsPerDay = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.gbTeacher = new System.Windows.Forms.GroupBox();
            this.gbTeacherInterest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLessonsPerDay)).BeginInit();
            this.gbTeacher.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTeacherList
            // 
            this.lbTeacherList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTeacherList.FormattingEnabled = true;
            this.lbTeacherList.Location = new System.Drawing.Point(3, 16);
            this.lbTeacherList.Name = "lbTeacherList";
            this.lbTeacherList.Size = new System.Drawing.Size(316, 201);
            this.lbTeacherList.TabIndex = 0;
            // 
            // cbFreeDay
            // 
            this.cbFreeDay.AutoSize = true;
            this.cbFreeDay.Location = new System.Drawing.Point(6, 19);
            this.cbFreeDay.Name = "cbFreeDay";
            this.cbFreeDay.Size = new System.Drawing.Size(179, 17);
            this.cbFreeDay.TabIndex = 1;
            this.cbFreeDay.Text = "Желателен свободный день - ";
            this.cbFreeDay.UseVisualStyleBackColor = true;
            // 
            // gbTeacherInterest
            // 
            this.gbTeacherInterest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbTeacherInterest.Controls.Add(this.comboBox1);
            this.gbTeacherInterest.Controls.Add(this.cbLessonsPerDay);
            this.gbTeacherInterest.Controls.Add(this.nudLessonsPerDay);
            this.gbTeacherInterest.Controls.Add(this.label2);
            this.gbTeacherInterest.Controls.Add(this.cbFreeDay);
            this.gbTeacherInterest.Location = new System.Drawing.Point(12, 238);
            this.gbTeacherInterest.Name = "gbTeacherInterest";
            this.gbTeacherInterest.Size = new System.Drawing.Size(319, 77);
            this.gbTeacherInterest.TabIndex = 2;
            this.gbTeacherInterest.TabStop = false;
            this.gbTeacherInterest.Text = "Предпочтения";
            // 
            // nudLessonsPerDay
            // 
            this.nudLessonsPerDay.Location = new System.Drawing.Point(81, 42);
            this.nudLessonsPerDay.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudLessonsPerDay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLessonsPerDay.Name = "nudLessonsPerDay";
            this.nudLessonsPerDay.Size = new System.Drawing.Size(33, 20);
            this.nudLessonsPerDay.TabIndex = 4;
            this.nudLessonsPerDay.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "пар в день";
            // 
            // cbLessonsPerDay
            // 
            this.cbLessonsPerDay.AutoSize = true;
            this.cbLessonsPerDay.Location = new System.Drawing.Point(7, 43);
            this.cbLessonsPerDay.Name = "cbLessonsPerDay";
            this.cbLessonsPerDay.Size = new System.Drawing.Size(73, 17);
            this.cbLessonsPerDay.TabIndex = 5;
            this.cbLessonsPerDay.Text = "Не более";
            this.cbLessonsPerDay.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Любой",
            "Понедельник",
            "Вторник",
            "Среда",
            "Четверг",
            "Пятница"});
            this.comboBox1.Location = new System.Drawing.Point(183, 17);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // gbTeacher
            // 
            this.gbTeacher.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbTeacher.Controls.Add(this.lbTeacherList);
            this.gbTeacher.Location = new System.Drawing.Point(12, 12);
            this.gbTeacher.Name = "gbTeacher";
            this.gbTeacher.Size = new System.Drawing.Size(322, 220);
            this.gbTeacher.TabIndex = 3;
            this.gbTeacher.TabStop = false;
            this.gbTeacher.Text = "Преподаватель";
            // 
            // TeacherSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 325);
            this.Controls.Add(this.gbTeacher);
            this.Controls.Add(this.gbTeacherInterest);
            this.Name = "TeacherSettingsForm";
            this.Text = "Пожелания учителей";
            this.gbTeacherInterest.ResumeLayout(false);
            this.gbTeacherInterest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLessonsPerDay)).EndInit();
            this.gbTeacher.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbTeacherList;
        private System.Windows.Forms.CheckBox cbFreeDay;
        private System.Windows.Forms.GroupBox gbTeacherInterest;
        private System.Windows.Forms.NumericUpDown nudLessonsPerDay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox cbLessonsPerDay;
        private System.Windows.Forms.GroupBox gbTeacher;
    }
}