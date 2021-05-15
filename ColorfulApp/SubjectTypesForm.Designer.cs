namespace ColorfulApp
{
    partial class SubjectTypesForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btToNaturalScience = new System.Windows.Forms.Button();
            this.btToTech = new System.Windows.Forms.Button();
            this.gbTech = new System.Windows.Forms.GroupBox();
            this.gbNaturalScience = new System.Windows.Forms.GroupBox();
            this.btOK = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.lbTech = new System.Windows.Forms.ListBox();
            this.lbNaturalScience = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbTech.SuspendLayout();
            this.gbNaturalScience.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.gbNaturalScience, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btToNaturalScience, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btToTech, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.gbTech, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btCancel, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.btOK, 2, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(429, 345);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btToNaturalScience
            // 
            this.btToNaturalScience.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btToNaturalScience.Location = new System.Drawing.Point(202, 106);
            this.btToNaturalScience.Name = "btToNaturalScience";
            this.btToNaturalScience.Size = new System.Drawing.Size(24, 40);
            this.btToNaturalScience.TabIndex = 0;
            this.btToNaturalScience.Text = ">";
            this.btToNaturalScience.UseVisualStyleBackColor = true;
            this.btToNaturalScience.Click += new System.EventHandler(this.btToNaturalScience_Click);
            // 
            // btToTech
            // 
            this.btToTech.Location = new System.Drawing.Point(202, 172);
            this.btToTech.Name = "btToTech";
            this.btToTech.Size = new System.Drawing.Size(24, 40);
            this.btToTech.TabIndex = 1;
            this.btToTech.Text = "<";
            this.btToTech.UseVisualStyleBackColor = true;
            this.btToTech.Click += new System.EventHandler(this.btToTech_Click);
            // 
            // gbTech
            // 
            this.gbTech.Controls.Add(this.lbTech);
            this.gbTech.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbTech.Location = new System.Drawing.Point(3, 3);
            this.gbTech.Name = "gbTech";
            this.tableLayoutPanel1.SetRowSpan(this.gbTech, 3);
            this.gbTech.Size = new System.Drawing.Size(193, 312);
            this.gbTech.TabIndex = 2;
            this.gbTech.TabStop = false;
            this.gbTech.Text = "Технические";
            // 
            // gbNaturalScience
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.gbNaturalScience, 2);
            this.gbNaturalScience.Controls.Add(this.lbNaturalScience);
            this.gbNaturalScience.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbNaturalScience.Location = new System.Drawing.Point(232, 3);
            this.gbNaturalScience.Name = "gbNaturalScience";
            this.tableLayoutPanel1.SetRowSpan(this.gbNaturalScience, 3);
            this.gbNaturalScience.Size = new System.Drawing.Size(194, 312);
            this.gbNaturalScience.TabIndex = 3;
            this.gbNaturalScience.TabStop = false;
            this.gbNaturalScience.Text = "Естественно-научные";
            // 
            // btOK
            // 
            this.btOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btOK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btOK.Location = new System.Drawing.Point(232, 321);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(93, 21);
            this.btOK.TabIndex = 4;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            // 
            // btCancel
            // 
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btCancel.Location = new System.Drawing.Point(331, 321);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(95, 21);
            this.btCancel.TabIndex = 5;
            this.btCancel.Text = "Отмена";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // lbTech
            // 
            this.lbTech.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTech.FormattingEnabled = true;
            this.lbTech.Location = new System.Drawing.Point(3, 16);
            this.lbTech.Name = "lbTech";
            this.lbTech.Size = new System.Drawing.Size(187, 293);
            this.lbTech.TabIndex = 0;
            this.lbTech.DragDrop += new System.Windows.Forms.DragEventHandler(this.lbTech_DragDrop);
            this.lbTech.DragOver += new System.Windows.Forms.DragEventHandler(this.lbTech_DragOver);
            this.lbTech.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbTech_MouseDown);
            // 
            // lbNaturalScience
            // 
            this.lbNaturalScience.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbNaturalScience.FormattingEnabled = true;
            this.lbNaturalScience.Location = new System.Drawing.Point(3, 16);
            this.lbNaturalScience.Name = "lbNaturalScience";
            this.lbNaturalScience.Size = new System.Drawing.Size(188, 293);
            this.lbNaturalScience.TabIndex = 1;
            this.lbNaturalScience.DragDrop += new System.Windows.Forms.DragEventHandler(this.lbNaturalScience_DragDrop);
            this.lbNaturalScience.DragOver += new System.Windows.Forms.DragEventHandler(this.lbNaturalScience_DragOver);
            this.lbNaturalScience.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbNaturalScience_MouseDown);
            // 
            // SubjectTypesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 345);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SubjectTypesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Определение типа предметов";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.gbTech.ResumeLayout(false);
            this.gbNaturalScience.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox gbNaturalScience;
        private System.Windows.Forms.Button btToNaturalScience;
        private System.Windows.Forms.Button btToTech;
        private System.Windows.Forms.GroupBox gbTech;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.ListBox lbNaturalScience;
        private System.Windows.Forms.ListBox lbTech;
    }
}