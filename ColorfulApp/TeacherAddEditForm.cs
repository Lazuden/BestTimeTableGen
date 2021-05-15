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
    public partial class TeacherAddEditForm : Form
    {
        public Teacher curTeacher;

        public TeacherAddEditForm(Teacher teacher = null)
        {
            InitializeComponent();            
            clbSubjects.DataSource = Data.Instance.SubjList;
            clbSubjects.DisplayMember = "Name";
            if (teacher != null)
            {
                curTeacher = teacher;
                tbFIO.Text = teacher.Name;
                Name = "Редактирование учителя";
                for (int i = 0; i < Data.Instance.SubjList.Count; i++)
                    if (teacher.Subjs.Contains(Data.Instance.SubjList[i]))
                        clbSubjects.SetItemChecked(i, true);
            }
            else
                curTeacher = new Teacher();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            var subjForm = new SubjectForm();
            subjForm.ShowDialog();
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            curTeacher.Name = tbFIO.Text;
            curTeacher.Subjs = new HashSet<Subject> ();
            foreach (Subject s in clbSubjects.CheckedItems)
            {
                curTeacher.Subjs.Add(s);
            }
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
