namespace ColorfulApp
{
    partial class PlanAddEditForm
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
            this.cbTeacher = new System.Windows.Forms.ComboBox();
            this.gbTeacher = new System.Windows.Forms.GroupBox();
            this.gbSubject = new System.Windows.Forms.GroupBox();
            this.cbSubject = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbClass = new System.Windows.Forms.ComboBox();
            this.gbHours = new System.Windows.Forms.GroupBox();
            this.nudHours = new System.Windows.Forms.NumericUpDown();
            this.btOK = new System.Windows.Forms.Button();
            this.gbTeacher.SuspendLayout();
            this.gbSubject.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbHours.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHours)).BeginInit();
            this.SuspendLayout();
            // 
            // cbTeacher
            // 
            this.cbTeacher.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbTeacher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTeacher.FormattingEnabled = true;
            this.cbTeacher.Location = new System.Drawing.Point(3, 16);
            this.cbTeacher.Name = "cbTeacher";
            this.cbTeacher.Size = new System.Drawing.Size(269, 21);
            this.cbTeacher.TabIndex = 0;
            // 
            // gbTeacher
            // 
            this.gbTeacher.Controls.Add(this.cbTeacher);
            this.gbTeacher.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbTeacher.Location = new System.Drawing.Point(0, 0);
            this.gbTeacher.Name = "gbTeacher";
            this.gbTeacher.Size = new System.Drawing.Size(275, 41);
            this.gbTeacher.TabIndex = 1;
            this.gbTeacher.TabStop = false;
            this.gbTeacher.Text = "Преподаватель";
            // 
            // gbSubject
            // 
            this.gbSubject.Controls.Add(this.cbSubject);
            this.gbSubject.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbSubject.Location = new System.Drawing.Point(0, 41);
            this.gbSubject.Name = "gbSubject";
            this.gbSubject.Size = new System.Drawing.Size(275, 41);
            this.gbSubject.TabIndex = 2;
            this.gbSubject.TabStop = false;
            this.gbSubject.Text = "Предмет";
            // 
            // cbSubject
            // 
            this.cbSubject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSubject.FormattingEnabled = true;
            this.cbSubject.Location = new System.Drawing.Point(3, 16);
            this.cbSubject.Name = "cbSubject";
            this.cbSubject.Size = new System.Drawing.Size(269, 21);
            this.cbSubject.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbClass);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(275, 41);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Класс";
            // 
            // cbClass
            // 
            this.cbClass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClass.FormattingEnabled = true;
            this.cbClass.Location = new System.Drawing.Point(3, 16);
            this.cbClass.Name = "cbClass";
            this.cbClass.Size = new System.Drawing.Size(269, 21);
            this.cbClass.TabIndex = 0;
            // 
            // gbHours
            // 
            this.gbHours.Controls.Add(this.nudHours);
            this.gbHours.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbHours.Location = new System.Drawing.Point(0, 123);
            this.gbHours.Name = "gbHours";
            this.gbHours.Size = new System.Drawing.Size(275, 41);
            this.gbHours.TabIndex = 4;
            this.gbHours.TabStop = false;
            this.gbHours.Text = "Количество часов в неделю";
            // 
            // nudHours
            // 
            this.nudHours.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudHours.Location = new System.Drawing.Point(3, 16);
            this.nudHours.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudHours.Name = "nudHours";
            this.nudHours.Size = new System.Drawing.Size(269, 20);
            this.nudHours.TabIndex = 0;
            this.nudHours.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btOK
            // 
            this.btOK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btOK.Location = new System.Drawing.Point(0, 164);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(275, 27);
            this.btOK.TabIndex = 5;
            this.btOK.Text = "Добавить";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // PlanAddEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 191);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.gbHours);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbSubject);
            this.Controls.Add(this.gbTeacher);
            this.Name = "PlanAddEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PlanAddEditForm";
            this.gbTeacher.ResumeLayout(false);
            this.gbSubject.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.gbHours.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudHours)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbTeacher;
        private System.Windows.Forms.GroupBox gbTeacher;
        private System.Windows.Forms.GroupBox gbSubject;
        private System.Windows.Forms.ComboBox cbSubject;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbClass;
        private System.Windows.Forms.GroupBox gbHours;
        private System.Windows.Forms.NumericUpDown nudHours;
        private System.Windows.Forms.Button btOK;
    }
}