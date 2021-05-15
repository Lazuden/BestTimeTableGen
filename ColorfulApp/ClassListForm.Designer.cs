namespace ColorfulApp
{
    partial class ClassListForm
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
            this.dgvClasses = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btDelClass = new System.Windows.Forms.Button();
            this.btChangeClass = new System.Windows.Forms.Button();
            this.btAddClass = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasses)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvClasses
            // 
            this.dgvClasses.AllowUserToResizeRows = false;
            this.dgvClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClasses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.dgvClasses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClasses.Location = new System.Drawing.Point(0, 0);
            this.dgvClasses.MultiSelect = false;
            this.dgvClasses.Name = "dgvClasses";
            this.dgvClasses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClasses.Size = new System.Drawing.Size(362, 450);
            this.dgvClasses.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Наименование";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btDelClass);
            this.groupBox1.Controls.Add(this.btChangeClass);
            this.groupBox1.Controls.Add(this.btAddClass);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(362, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 450);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Действия";
            // 
            // btDelClass
            // 
            this.btDelClass.Location = new System.Drawing.Point(7, 78);
            this.btDelClass.Name = "btDelClass";
            this.btDelClass.Size = new System.Drawing.Size(187, 23);
            this.btDelClass.TabIndex = 9;
            this.btDelClass.Text = "Удалить";
            this.btDelClass.UseVisualStyleBackColor = true;
            // 
            // btChangeClass
            // 
            this.btChangeClass.Location = new System.Drawing.Point(7, 49);
            this.btChangeClass.Name = "btChangeClass";
            this.btChangeClass.Size = new System.Drawing.Size(187, 23);
            this.btChangeClass.TabIndex = 8;
            this.btChangeClass.Text = "Изменить";
            this.btChangeClass.UseVisualStyleBackColor = true;
            // 
            // btAddClass
            // 
            this.btAddClass.Location = new System.Drawing.Point(7, 20);
            this.btAddClass.Name = "btAddClass";
            this.btAddClass.Size = new System.Drawing.Size(187, 23);
            this.btAddClass.TabIndex = 7;
            this.btAddClass.Text = "Добавить";
            this.btAddClass.UseVisualStyleBackColor = true;
            // 
            // ClassListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 450);
            this.Controls.Add(this.dgvClasses);
            this.Controls.Add(this.groupBox1);
            this.Name = "ClassListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Список классов";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClassListForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasses)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClasses;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btDelClass;
        private System.Windows.Forms.Button btChangeClass;
        private System.Windows.Forms.Button btAddClass;
    }
}