namespace ColorfulApp
{
    partial class InsertObject
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
            this.cbObjectType = new System.Windows.Forms.ComboBox();
            this.lbObjects = new System.Windows.Forms.ListBox();
            this.btInsert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbObjectType
            // 
            this.cbObjectType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbObjectType.FormattingEnabled = true;
            this.cbObjectType.Items.AddRange(new object[] {
            "Преподаватели",
            "Предметы",
            "Классы"});
            this.cbObjectType.Location = new System.Drawing.Point(13, 13);
            this.cbObjectType.Name = "cbObjectType";
            this.cbObjectType.Size = new System.Drawing.Size(293, 21);
            this.cbObjectType.TabIndex = 0;
            this.cbObjectType.SelectedIndexChanged += new System.EventHandler(this.cbObjectType_SelectedIndexChanged);
            // 
            // lbObjects
            // 
            this.lbObjects.FormattingEnabled = true;
            this.lbObjects.Location = new System.Drawing.Point(13, 41);
            this.lbObjects.Name = "lbObjects";
            this.lbObjects.Size = new System.Drawing.Size(293, 381);
            this.lbObjects.TabIndex = 1;
            // 
            // btInsert
            // 
            this.btInsert.Location = new System.Drawing.Point(13, 429);
            this.btInsert.Name = "btInsert";
            this.btInsert.Size = new System.Drawing.Size(293, 23);
            this.btInsert.TabIndex = 2;
            this.btInsert.Text = "Вставить";
            this.btInsert.UseVisualStyleBackColor = true;
            this.btInsert.Click += new System.EventHandler(this.btInsert_Click);
            // 
            // InsertObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 465);
            this.Controls.Add(this.btInsert);
            this.Controls.Add(this.lbObjects);
            this.Controls.Add(this.cbObjectType);
            this.Name = "InsertObject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Вставка значения справочника";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbObjectType;
        private System.Windows.Forms.ListBox lbObjects;
        private System.Windows.Forms.Button btInsert;
    }
}