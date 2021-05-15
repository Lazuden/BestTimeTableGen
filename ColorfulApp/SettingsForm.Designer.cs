namespace ColorfulApp
{
    partial class SettingsForm
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
            this.gbMainSettings = new System.Windows.Forms.GroupBox();
            this.llSubjectSettings = new System.Windows.Forms.LinkLabel();
            this.btTeacherSettings = new System.Windows.Forms.Button();
            this.cbLessonRotation = new System.Windows.Forms.CheckBox();
            this.cbWindowTeachers = new System.Windows.Forms.CheckBox();
            this.cbWindowStudents = new System.Windows.Forms.CheckBox();
            this.gbGaSettings = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nudIndividualsCount = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.nudGenerationCount = new System.Windows.Forms.NumericUpDown();
            this.btnGenerationRules = new System.Windows.Forms.Button();
            this.gbMainSettings.SuspendLayout();
            this.gbGaSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudIndividualsCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGenerationCount)).BeginInit();
            this.SuspendLayout();
            // 
            // gbMainSettings
            // 
            this.gbMainSettings.Controls.Add(this.btnGenerationRules);
            this.gbMainSettings.Controls.Add(this.llSubjectSettings);
            this.gbMainSettings.Controls.Add(this.btTeacherSettings);
            this.gbMainSettings.Controls.Add(this.cbLessonRotation);
            this.gbMainSettings.Controls.Add(this.cbWindowTeachers);
            this.gbMainSettings.Controls.Add(this.cbWindowStudents);
            this.gbMainSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbMainSettings.Location = new System.Drawing.Point(0, 0);
            this.gbMainSettings.Name = "gbMainSettings";
            this.gbMainSettings.Size = new System.Drawing.Size(458, 151);
            this.gbMainSettings.TabIndex = 0;
            this.gbMainSettings.TabStop = false;
            this.gbMainSettings.Text = "Основные настройки";
            // 
            // llSubjectSettings
            // 
            this.llSubjectSettings.AutoSize = true;
            this.llSubjectSettings.Location = new System.Drawing.Point(353, 67);
            this.llSubjectSettings.Name = "llSubjectSettings";
            this.llSubjectSettings.Size = new System.Drawing.Size(81, 13);
            this.llSubjectSettings.TabIndex = 4;
            this.llSubjectSettings.TabStop = true;
            this.llSubjectSettings.Text = "Настроить тип";
            this.llSubjectSettings.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llSubjectSettings_LinkClicked);
            // 
            // btTeacherSettings
            // 
            this.btTeacherSettings.Location = new System.Drawing.Point(13, 89);
            this.btTeacherSettings.Name = "btTeacherSettings";
            this.btTeacherSettings.Size = new System.Drawing.Size(227, 23);
            this.btTeacherSettings.TabIndex = 3;
            this.btTeacherSettings.Text = "Предпочтения учителей";
            this.btTeacherSettings.UseVisualStyleBackColor = true;
            this.btTeacherSettings.Click += new System.EventHandler(this.btTeacherSettings_Click);
            // 
            // cbLessonRotation
            // 
            this.cbLessonRotation.AutoSize = true;
            this.cbLessonRotation.Checked = true;
            this.cbLessonRotation.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbLessonRotation.Location = new System.Drawing.Point(13, 66);
            this.cbLessonRotation.Name = "cbLessonRotation";
            this.cbLessonRotation.Size = new System.Drawing.Size(347, 17);
            this.cbLessonRotation.TabIndex = 2;
            this.cbLessonRotation.Text = "Чередование естественно-научных и гуманитарных предметов";
            this.cbLessonRotation.UseVisualStyleBackColor = true;
            this.cbLessonRotation.CheckedChanged += new System.EventHandler(this.cbLessonRotation_CheckedChanged);
            // 
            // cbWindowTeachers
            // 
            this.cbWindowTeachers.AutoSize = true;
            this.cbWindowTeachers.Checked = true;
            this.cbWindowTeachers.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbWindowTeachers.Location = new System.Drawing.Point(13, 43);
            this.cbWindowTeachers.Name = "cbWindowTeachers";
            this.cbWindowTeachers.Size = new System.Drawing.Size(205, 17);
            this.cbWindowTeachers.TabIndex = 1;
            this.cbWindowTeachers.Text = "Отсутствие окон у преподавателей";
            this.cbWindowTeachers.UseVisualStyleBackColor = true;
            this.cbWindowTeachers.CheckedChanged += new System.EventHandler(this.cbWindowTeachers_CheckedChanged);
            // 
            // cbWindowStudents
            // 
            this.cbWindowStudents.AutoSize = true;
            this.cbWindowStudents.Checked = true;
            this.cbWindowStudents.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbWindowStudents.Location = new System.Drawing.Point(13, 20);
            this.cbWindowStudents.Name = "cbWindowStudents";
            this.cbWindowStudents.Size = new System.Drawing.Size(168, 17);
            this.cbWindowStudents.TabIndex = 0;
            this.cbWindowStudents.Text = "Отсутствие окон у учеников";
            this.cbWindowStudents.UseVisualStyleBackColor = true;
            this.cbWindowStudents.CheckedChanged += new System.EventHandler(this.cbWindowStudents_CheckedChanged);
            // 
            // gbGaSettings
            // 
            this.gbGaSettings.Controls.Add(this.label2);
            this.gbGaSettings.Controls.Add(this.nudIndividualsCount);
            this.gbGaSettings.Controls.Add(this.label1);
            this.gbGaSettings.Controls.Add(this.nudGenerationCount);
            this.gbGaSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbGaSettings.Location = new System.Drawing.Point(0, 151);
            this.gbGaSettings.Name = "gbGaSettings";
            this.gbGaSettings.Size = new System.Drawing.Size(458, 67);
            this.gbGaSettings.TabIndex = 1;
            this.gbGaSettings.TabStop = false;
            this.gbGaSettings.Text = "Настройки генетического алгоритма";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Число особей в поколении";
            // 
            // nudIndividualsCount
            // 
            this.nudIndividualsCount.Location = new System.Drawing.Point(162, 41);
            this.nudIndividualsCount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudIndividualsCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudIndividualsCount.Name = "nudIndividualsCount";
            this.nudIndividualsCount.Size = new System.Drawing.Size(120, 20);
            this.nudIndividualsCount.TabIndex = 2;
            this.nudIndividualsCount.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudIndividualsCount.ValueChanged += new System.EventHandler(this.nudIndividualsCount_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Число поколений";
            // 
            // nudGenerationCount
            // 
            this.nudGenerationCount.Location = new System.Drawing.Point(162, 19);
            this.nudGenerationCount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudGenerationCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudGenerationCount.Name = "nudGenerationCount";
            this.nudGenerationCount.Size = new System.Drawing.Size(120, 20);
            this.nudGenerationCount.TabIndex = 0;
            this.nudGenerationCount.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudGenerationCount.ValueChanged += new System.EventHandler(this.nudGenerationCount_ValueChanged);
            // 
            // btnGenerationRules
            // 
            this.btnGenerationRules.Location = new System.Drawing.Point(13, 119);
            this.btnGenerationRules.Name = "btnGenerationRules";
            this.btnGenerationRules.Size = new System.Drawing.Size(227, 23);
            this.btnGenerationRules.TabIndex = 5;
            this.btnGenerationRules.Text = "Правила генерации";
            this.btnGenerationRules.UseVisualStyleBackColor = true;
            this.btnGenerationRules.Click += new System.EventHandler(this.btnGenerationRules_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 258);
            this.Controls.Add(this.gbGaSettings);
            this.Controls.Add(this.gbMainSettings);
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Параметры генерации";
            this.gbMainSettings.ResumeLayout(false);
            this.gbMainSettings.PerformLayout();
            this.gbGaSettings.ResumeLayout(false);
            this.gbGaSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudIndividualsCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGenerationCount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbMainSettings;
        private System.Windows.Forms.LinkLabel llSubjectSettings;
        private System.Windows.Forms.Button btTeacherSettings;
        private System.Windows.Forms.CheckBox cbLessonRotation;
        private System.Windows.Forms.CheckBox cbWindowTeachers;
        private System.Windows.Forms.CheckBox cbWindowStudents;
        private System.Windows.Forms.GroupBox gbGaSettings;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudIndividualsCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudGenerationCount;
        private System.Windows.Forms.Button btnGenerationRules;
    }
}