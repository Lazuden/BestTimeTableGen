namespace ColorfulApp
{
    partial class TeacherAddEditForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbFIO = new System.Windows.Forms.TextBox();
            this.clbSubjects = new System.Windows.Forms.CheckedListBox();
            this.btOK = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btEdit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbFIO);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 41);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ФИО";
            // 
            // tbFIO
            // 
            this.tbFIO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbFIO.Location = new System.Drawing.Point(3, 16);
            this.tbFIO.Name = "tbFIO";
            this.tbFIO.Size = new System.Drawing.Size(338, 20);
            this.tbFIO.TabIndex = 0;
            // 
            // clbSubjects
            // 
            this.clbSubjects.CheckOnClick = true;
            this.clbSubjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbSubjects.FormattingEnabled = true;
            this.clbSubjects.Location = new System.Drawing.Point(3, 39);
            this.clbSubjects.Name = "clbSubjects";
            this.clbSubjects.Size = new System.Drawing.Size(338, 289);
            this.clbSubjects.TabIndex = 1;
            // 
            // btOK
            // 
            this.btOK.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btOK.Location = new System.Drawing.Point(0, 372);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(344, 23);
            this.btOK.TabIndex = 2;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.clbSubjects);
            this.groupBox2.Controls.Add(this.btEdit);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(344, 331);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Предметы";
            // 
            // btEdit
            // 
            this.btEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btEdit.Location = new System.Drawing.Point(3, 16);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(338, 23);
            this.btEdit.TabIndex = 2;
            this.btEdit.Text = "Редактировать предметы";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // TeacherAddEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 395);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.groupBox1);
            this.Name = "TeacherAddEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавление учителя";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbFIO;
        private System.Windows.Forms.CheckedListBox clbSubjects;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btEdit;
    }
}