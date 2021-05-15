namespace ColorfulApp
{
    partial class SubjectForm
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
            this.btOK = new System.Windows.Forms.Button();
            this.lbSubjects = new System.Windows.Forms.ListBox();
            this.tbCurSubj = new System.Windows.Forms.TextBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.btDel = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btOK
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btOK, 2);
            this.btOK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btOK.Location = new System.Drawing.Point(3, 394);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(261, 24);
            this.btOK.TabIndex = 1;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            // 
            // lbSubjects
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.lbSubjects, 2);
            this.lbSubjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbSubjects.FormattingEnabled = true;
            this.lbSubjects.Location = new System.Drawing.Point(3, 3);
            this.lbSubjects.Name = "lbSubjects";
            this.lbSubjects.Size = new System.Drawing.Size(261, 330);
            this.lbSubjects.TabIndex = 2;
            // 
            // tbCurSubj
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.tbCurSubj, 2);
            this.tbCurSubj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCurSubj.Location = new System.Drawing.Point(3, 339);
            this.tbCurSubj.Name = "tbCurSubj";
            this.tbCurSubj.Size = new System.Drawing.Size(261, 20);
            this.tbCurSubj.TabIndex = 3;
            // 
            // btAdd
            // 
            this.btAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btAdd.Location = new System.Drawing.Point(3, 364);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(127, 24);
            this.btAdd.TabIndex = 4;
            this.btAdd.Text = "Добавить";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btDel
            // 
            this.btDel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btDel.Location = new System.Drawing.Point(136, 364);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(128, 24);
            this.btDel.TabIndex = 5;
            this.btDel.Text = "Удалить";
            this.btDel.UseVisualStyleBackColor = true;
            this.btDel.Click += new System.EventHandler(this.btDel_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btOK, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tbCurSubj, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btDel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbSubjects, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btAdd, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(267, 421);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // SubjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 421);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SubjectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Предметы";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox tbCurSubj;
        private System.Windows.Forms.Button btDel;
        private System.Windows.Forms.ListBox lbSubjects;
        private System.Windows.Forms.Button btAdd;
    }
}