using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorfulApp
{
    public partial class SubjectForm : Form
    {
        BindingSource bs;
        public SubjectForm()
        {
            InitializeComponent();
            bs = new BindingSource();
            bs.DataSource = Data.Instance.Subjects;
            lbSubjects.DataSource = bs;
            lbSubjects.DisplayMember = "Name";
            //lbSubjects.ValueMember = "Value";
            tbCurSubj.DataBindings.Add("Text", bs, "Name", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            bs.Add(new Subject("Имя предмета"));
            lbSubjects.SelectedIndex = bs.Count-1;
            tbCurSubj.Focus();
            tbCurSubj.SelectAll();
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            bs.RemoveCurrent();
        }
    }
}
