namespace ColorfulApp
{
    partial class TeacherListForm
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
            this.dgvTeachers = new System.Windows.Forms.DataGridView();
            this.clFIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbControl = new System.Windows.Forms.GroupBox();
            this.btDelTeacher = new System.Windows.Forms.Button();
            this.btChangeTeacher = new System.Windows.Forms.Button();
            this.btAddTeacher = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeachers)).BeginInit();
            this.gbControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTeachers
            // 
            this.dgvTeachers.AllowUserToAddRows = false;
            this.dgvTeachers.AllowUserToDeleteRows = false;
            this.dgvTeachers.AllowUserToResizeRows = false;
            this.dgvTeachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeachers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clFIO,
            this.clSubject});
            this.dgvTeachers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTeachers.Location = new System.Drawing.Point(0, 0);
            this.dgvTeachers.MultiSelect = false;
            this.dgvTeachers.Name = "dgvTeachers";
            this.dgvTeachers.RowHeadersVisible = false;
            this.dgvTeachers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTeachers.Size = new System.Drawing.Size(600, 450);
            this.dgvTeachers.TabIndex = 1;
            // 
            // clFIO
            // 
            this.clFIO.DataPropertyName = "Name";
            this.clFIO.HeaderText = "ФИО";
            this.clFIO.Name = "clFIO";
            this.clFIO.Width = 200;
            // 
            // clSubject
            // 
            this.clSubject.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clSubject.DataPropertyName = "SubjectsText";
            this.clSubject.HeaderText = "Предметы";
            this.clSubject.Name = "clSubject";
            // 
            // gbControl
            // 
            this.gbControl.Controls.Add(this.btDelTeacher);
            this.gbControl.Controls.Add(this.btChangeTeacher);
            this.gbControl.Controls.Add(this.btAddTeacher);
            this.gbControl.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbControl.Location = new System.Drawing.Point(600, 0);
            this.gbControl.Name = "gbControl";
            this.gbControl.Size = new System.Drawing.Size(200, 450);
            this.gbControl.TabIndex = 2;
            this.gbControl.TabStop = false;
            this.gbControl.Text = "Действия";
            // 
            // btDelTeacher
            // 
            this.btDelTeacher.Location = new System.Drawing.Point(7, 78);
            this.btDelTeacher.Name = "btDelTeacher";
            this.btDelTeacher.Size = new System.Drawing.Size(187, 23);
            this.btDelTeacher.TabIndex = 9;
            this.btDelTeacher.Text = "Удалить";
            this.btDelTeacher.UseVisualStyleBackColor = true;
            this.btDelTeacher.Click += new System.EventHandler(this.btDelTeacher_Click);
            // 
            // btChangeTeacher
            // 
            this.btChangeTeacher.Location = new System.Drawing.Point(7, 49);
            this.btChangeTeacher.Name = "btChangeTeacher";
            this.btChangeTeacher.Size = new System.Drawing.Size(187, 23);
            this.btChangeTeacher.TabIndex = 8;
            this.btChangeTeacher.Text = "Изменить";
            this.btChangeTeacher.UseVisualStyleBackColor = true;
            this.btChangeTeacher.Click += new System.EventHandler(this.btChangeTeacher_Click);
            // 
            // btAddTeacher
            // 
            this.btAddTeacher.Location = new System.Drawing.Point(7, 20);
            this.btAddTeacher.Name = "btAddTeacher";
            this.btAddTeacher.Size = new System.Drawing.Size(187, 23);
            this.btAddTeacher.TabIndex = 7;
            this.btAddTeacher.Text = "Добавить";
            this.btAddTeacher.UseVisualStyleBackColor = true;
            this.btAddTeacher.Click += new System.EventHandler(this.btAddTeacher_Click);
            // 
            // TeacherListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvTeachers);
            this.Controls.Add(this.gbControl);
            this.Name = "TeacherListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Список учителей";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeachers)).EndInit();
            this.gbControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTeachers;
        private System.Windows.Forms.DataGridViewTextBoxColumn clFIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSubject;
        private System.Windows.Forms.GroupBox gbControl;
        private System.Windows.Forms.Button btDelTeacher;
        private System.Windows.Forms.Button btChangeTeacher;
        private System.Windows.Forms.Button btAddTeacher;
    }
}