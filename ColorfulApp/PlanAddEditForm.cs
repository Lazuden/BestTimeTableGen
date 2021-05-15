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
    public partial class PlanAddEditForm : Form
    {
        public PlanAddEditForm(LessonEditor le = null)
        {
            InitializeComponent();
            cbTeacher.DataSource = Data.Instance.Teachers.Values.ToList();
            cbTeacher.DisplayMember = "Name";
            cbTeacher.ValueMember = "Id";

            cbClass.DataSource = Data.Instance.Classes.Values.ToList();
            cbClass.DisplayMember = "Name";
            cbClass.ValueMember = "Id";

            cbSubject.DataSource = Data.Instance.Teachers[(int)cbTeacher.SelectedValue].Subjs.ToList();
            cbSubject.DisplayMember = "Name";

            

            if (le != null)
            {
                btOK.Text = "Применить";
                cbTeacher.SelectedValue = le.Lesson.Teacher.Id;
                cbClass.SelectedValue = le.Lesson.Cls.Id;
                cbSubject.SelectedItem = le.Lesson.Subject;
                nudHours.Value = le.Count;
                Text = "Изменение позиции учебного плана";
            }
            else
                Text = "Добавление позиции учебного плана";
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        public LessonEditor GetLe()
        {
            return new LessonEditor(new Lesson(
                (Teacher)cbTeacher.SelectedItem, 
                (tClass)cbClass.SelectedItem, 
                (Subject)cbSubject.SelectedItem), 
                Decimal.ToInt32(nudHours.Value));
        }
    }
}
