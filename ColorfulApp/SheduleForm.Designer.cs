namespace ColorfulApp
{
    partial class SheduleForm
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
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.dgvTimeTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimeTable)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Location = new System.Drawing.Point(0, 669);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1130, 22);
            this.statusStrip.TabIndex = 0;
            this.statusStrip.Text = "statusStrip1";
            // 
            // dgvTimeTable
            // 
            this.dgvTimeTable.AllowUserToAddRows = false;
            this.dgvTimeTable.AllowUserToDeleteRows = false;
            this.dgvTimeTable.AllowUserToResizeColumns = false;
            this.dgvTimeTable.AllowUserToResizeRows = false;
            this.dgvTimeTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimeTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTimeTable.Location = new System.Drawing.Point(0, 0);
            this.dgvTimeTable.MultiSelect = false;
            this.dgvTimeTable.Name = "dgvTimeTable";
            this.dgvTimeTable.ReadOnly = true;
            this.dgvTimeTable.RowHeadersVisible = false;
            this.dgvTimeTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvTimeTable.Size = new System.Drawing.Size(1130, 669);
            this.dgvTimeTable.TabIndex = 1;
            this.dgvTimeTable.DragDrop += new System.Windows.Forms.DragEventHandler(this.dgvTimeTable_DragDrop);
            this.dgvTimeTable.DragOver += new System.Windows.Forms.DragEventHandler(this.dgvTimeTable_DragOver);
            this.dgvTimeTable.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvTimeTable_MouseDown);
            // 
            // SheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 691);
            this.Controls.Add(this.dgvTimeTable);
            this.Controls.Add(this.statusStrip);
            this.Name = "SheduleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Расписание";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimeTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.DataGridView dgvTimeTable;
    }
}