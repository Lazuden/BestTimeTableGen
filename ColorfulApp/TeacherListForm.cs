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
    public partial class TeacherListForm : Form
    {
        BindingSource teachersBs;
        public TeacherListForm()
        {
            InitializeComponent();
            teachersBs = new BindingSource();
            teachersBs.DataSource = Data.Instance.Teachers.Values.ToList();
            dgvTeachers.AutoGenerateColumns = false;
            dgvTeachers.DataSource = teachersBs;
        }

        private void btAddTeacher_Click(object sender, EventArgs e)
        {
            var taef = new TeacherAddEditForm();
            if (taef.ShowDialog() == DialogResult.OK)
            {
                taef.curTeacher.Id = Data.Instance.Teachers.Last().Key + 1;
                Data.Instance.Teachers.Add(taef.curTeacher.Id, taef.curTeacher);
                teachersBs.DataSource = Data.Instance.Teachers.Values.ToList();
            }
        }

        private void btChangeTeacher_Click(object sender, EventArgs e)
        {
            if (dgvTeachers.SelectedCells.Count > 0)
            {
                var taef = new TeacherAddEditForm(Data.Instance.Teachers[dgvTeachers.SelectedCells[0].RowIndex + 1]);
                if (taef.ShowDialog() == DialogResult.OK)
                {
                    int tmp = dgvTeachers.SelectedCells[0].RowIndex;
                    dgvTeachers.ClearSelection();
                    dgvTeachers.Rows[tmp].Selected = true;
                }
            }
        }

        private void btDelTeacher_Click(object sender, EventArgs e)
        {
            if (dgvTeachers.SelectedCells.Count > 0)
            {
                Data.Instance.Teachers.Remove(dgvTeachers.SelectedCells[0].RowIndex);
            }
        }
    }
}
