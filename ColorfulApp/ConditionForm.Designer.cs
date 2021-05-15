namespace ColorfulApp
{
    partial class ConditionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConditionForm));
            this.gbRuleEdit = new System.Windows.Forms.GroupBox();
            this.tbRule = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tbRuleName = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btAll = new System.Windows.Forms.ToolStripButton();
            this.btExist = new System.Windows.Forms.ToolStripButton();
            this.btThen = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btRule = new System.Windows.Forms.ToolStripButton();
            this.btAnd = new System.Windows.Forms.ToolStripButton();
            this.btOr = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btEQ = new System.Windows.Forms.ToolStripButton();
            this.btNE = new System.Windows.Forms.ToolStripButton();
            this.btGE = new System.Windows.Forms.ToolStripButton();
            this.btLE = new System.Windows.Forms.ToolStripButton();
            this.btGT = new System.Windows.Forms.ToolStripButton();
            this.btLT = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btObj = new System.Windows.Forms.ToolStripButton();
            this.lbRuleList = new System.Windows.Forms.ListBox();
            this.gbRuleList = new System.Windows.Forms.GroupBox();
            this.tlpConditionForm = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btRemove = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.gbRuleEdit.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.gbRuleList.SuspendLayout();
            this.tlpConditionForm.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbRuleEdit
            // 
            this.gbRuleEdit.Controls.Add(this.tbRule);
            this.gbRuleEdit.Controls.Add(this.toolStrip1);
            this.gbRuleEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbRuleEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbRuleEdit.Location = new System.Drawing.Point(3, 3);
            this.gbRuleEdit.Name = "gbRuleEdit";
            this.tlpConditionForm.SetRowSpan(this.gbRuleEdit, 2);
            this.gbRuleEdit.Size = new System.Drawing.Size(698, 420);
            this.gbRuleEdit.TabIndex = 1;
            this.gbRuleEdit.TabStop = false;
            this.gbRuleEdit.Text = "Редактирование ограничения";
            // 
            // tbRule
            // 
            this.tbRule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbRule.Location = new System.Drawing.Point(3, 49);
            this.tbRule.Multiline = true;
            this.tbRule.Name = "tbRule";
            this.tbRule.Size = new System.Drawing.Size(692, 368);
            this.tbRule.TabIndex = 2;
            this.tbRule.TextChanged += new System.EventHandler(this.tbRule_TextChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.tbRuleName,
            this.toolStripSeparator3,
            this.btAll,
            this.btExist,
            this.btThen,
            this.toolStripSeparator1,
            this.btRule,
            this.btAnd,
            this.btOr,
            this.toolStripSeparator2,
            this.btEQ,
            this.btNE,
            this.btGE,
            this.btLE,
            this.btGT,
            this.btLT,
            this.toolStripSeparator4,
            this.btObj});
            this.toolStrip1.Location = new System.Drawing.Point(3, 22);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(692, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(106, 24);
            this.toolStripLabel1.Text = "Имя ограничения";
            // 
            // tbRuleName
            // 
            this.tbRuleName.Enabled = false;
            this.tbRuleName.Name = "tbRuleName";
            this.tbRuleName.Size = new System.Drawing.Size(100, 27);
            this.tbRuleName.TextChanged += new System.EventHandler(this.tbRuleName_TextChanged);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // btAll
            // 
            this.btAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btAll.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btAll.Name = "btAll";
            this.btAll.Size = new System.Drawing.Size(26, 24);
            this.btAll.Text = "∀";
            this.btAll.ToolTipText = "Для каждого";
            this.btAll.Click += new System.EventHandler(this.btAll_Click);
            // 
            // btExist
            // 
            this.btExist.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btExist.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btExist.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btExist.Name = "btExist";
            this.btExist.Size = new System.Drawing.Size(23, 24);
            this.btExist.Text = "∃";
            this.btExist.ToolTipText = "Существует";
            this.btExist.Click += new System.EventHandler(this.btExist_Click);
            // 
            // btThen
            // 
            this.btThen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btThen.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btThen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btThen.Name = "btThen";
            this.btThen.Size = new System.Drawing.Size(26, 24);
            this.btThen.Text = "⇒";
            this.btThen.ToolTipText = "Импликация (Следует)";
            this.btThen.Click += new System.EventHandler(this.btThen_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // btRule
            // 
            this.btRule.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btRule.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btRule.Name = "btRule";
            this.btRule.Size = new System.Drawing.Size(23, 24);
            this.btRule.Text = "R";
            this.btRule.ToolTipText = "Правило (Основной предикат)";
            this.btRule.Click += new System.EventHandler(this.btRule_Click);
            // 
            // btAnd
            // 
            this.btAnd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btAnd.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btAnd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btAnd.Name = "btAnd";
            this.btAnd.Size = new System.Drawing.Size(26, 24);
            this.btAnd.Text = "⋀";
            this.btAnd.ToolTipText = "Конъюнкция (И)";
            this.btAnd.Click += new System.EventHandler(this.btAnd_Click);
            // 
            // btOr
            // 
            this.btOr.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btOr.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btOr.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btOr.Name = "btOr";
            this.btOr.Size = new System.Drawing.Size(26, 24);
            this.btOr.Text = "⋁";
            this.btOr.ToolTipText = "Дизъюнкция (ИЛИ)";
            this.btOr.Click += new System.EventHandler(this.btOr_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // btEQ
            // 
            this.btEQ.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btEQ.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btEQ.Name = "btEQ";
            this.btEQ.Size = new System.Drawing.Size(23, 24);
            this.btEQ.Text = "=";
            this.btEQ.Click += new System.EventHandler(this.btEQ_Click);
            // 
            // btNE
            // 
            this.btNE.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btNE.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btNE.Name = "btNE";
            this.btNE.Size = new System.Drawing.Size(23, 24);
            this.btNE.Text = "!=";
            this.btNE.Click += new System.EventHandler(this.btNE_Click);
            // 
            // btGE
            // 
            this.btGE.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btGE.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btGE.Name = "btGE";
            this.btGE.Size = new System.Drawing.Size(27, 24);
            this.btGE.Text = ">=";
            this.btGE.Click += new System.EventHandler(this.btGE_Click);
            // 
            // btLE
            // 
            this.btLE.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btLE.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btLE.Name = "btLE";
            this.btLE.Size = new System.Drawing.Size(27, 24);
            this.btLE.Text = "<=";
            this.btLE.Click += new System.EventHandler(this.btLE_Click);
            // 
            // btGT
            // 
            this.btGT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btGT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btGT.Name = "btGT";
            this.btGT.Size = new System.Drawing.Size(23, 24);
            this.btGT.Text = ">";
            this.btGT.Click += new System.EventHandler(this.btGT_Click);
            // 
            // btLT
            // 
            this.btLT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btLT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btLT.Name = "btLT";
            this.btLT.Size = new System.Drawing.Size(23, 24);
            this.btLT.Text = "<";
            this.btLT.Click += new System.EventHandler(this.btLT_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // btObj
            // 
            this.btObj.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btObj.Image = ((System.Drawing.Image)(resources.GetObject("btObj.Image")));
            this.btObj.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btObj.Name = "btObj";
            this.btObj.Size = new System.Drawing.Size(67, 24);
            this.btObj.Text = "Константа";
            this.btObj.Click += new System.EventHandler(this.btObj_Click);
            // 
            // lbRuleList
            // 
            this.lbRuleList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbRuleList.FormattingEnabled = true;
            this.lbRuleList.Location = new System.Drawing.Point(3, 16);
            this.lbRuleList.Name = "lbRuleList";
            this.lbRuleList.Size = new System.Drawing.Size(239, 281);
            this.lbRuleList.TabIndex = 1;
            this.lbRuleList.SelectedIndexChanged += new System.EventHandler(this.lbRuleList_SelectedIndexChanged);
            // 
            // gbRuleList
            // 
            this.gbRuleList.Controls.Add(this.lbRuleList);
            this.gbRuleList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbRuleList.Location = new System.Drawing.Point(707, 123);
            this.gbRuleList.Name = "gbRuleList";
            this.gbRuleList.Size = new System.Drawing.Size(245, 300);
            this.gbRuleList.TabIndex = 2;
            this.gbRuleList.TabStop = false;
            this.gbRuleList.Text = "Список ограничений";
            // 
            // tlpConditionForm
            // 
            this.tlpConditionForm.ColumnCount = 2;
            this.tlpConditionForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.72881F));
            this.tlpConditionForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.27119F));
            this.tlpConditionForm.Controls.Add(this.gbRuleList, 1, 1);
            this.tlpConditionForm.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.tlpConditionForm.Controls.Add(this.gbRuleEdit, 0, 0);
            this.tlpConditionForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpConditionForm.Location = new System.Drawing.Point(0, 0);
            this.tlpConditionForm.Name = "tlpConditionForm";
            this.tlpConditionForm.RowCount = 2;
            this.tlpConditionForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tlpConditionForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpConditionForm.Size = new System.Drawing.Size(955, 426);
            this.tlpConditionForm.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btRemove, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btAdd, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(707, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(245, 114);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // btRemove
            // 
            this.btRemove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btRemove.Location = new System.Drawing.Point(10, 67);
            this.btRemove.Margin = new System.Windows.Forms.Padding(10);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(225, 37);
            this.btRemove.TabIndex = 1;
            this.btRemove.Text = "Удалить";
            this.btRemove.UseVisualStyleBackColor = true;
            this.btRemove.Click += new System.EventHandler(this.btRemove_Click);
            // 
            // btAdd
            // 
            this.btAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btAdd.Location = new System.Drawing.Point(10, 10);
            this.btAdd.Margin = new System.Windows.Forms.Padding(10);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(225, 37);
            this.btAdd.TabIndex = 0;
            this.btAdd.Text = "Добавить";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // ConditionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 426);
            this.Controls.Add(this.tlpConditionForm);
            this.Name = "ConditionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редактор ограничений";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConditionForm_FormClosing);
            this.gbRuleEdit.ResumeLayout(false);
            this.gbRuleEdit.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.gbRuleList.ResumeLayout(false);
            this.tlpConditionForm.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbRuleEdit;
        private System.Windows.Forms.TableLayoutPanel tlpConditionForm;
        private System.Windows.Forms.GroupBox gbRuleList;
        private System.Windows.Forms.ListBox lbRuleList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btRemove;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btAll;
        private System.Windows.Forms.ToolStripButton btExist;
        private System.Windows.Forms.ToolStripButton btThen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btAnd;
        private System.Windows.Forms.ToolStripButton btOr;
        private System.Windows.Forms.TextBox tbRule;
        private System.Windows.Forms.ToolStripButton btRule;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btEQ;
        private System.Windows.Forms.ToolStripButton btNE;
        private System.Windows.Forms.ToolStripButton btGE;
        private System.Windows.Forms.ToolStripButton btLE;
        private System.Windows.Forms.ToolStripButton btGT;
        private System.Windows.Forms.ToolStripButton btLT;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox tbRuleName;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btObj;
    }
}