using System;
using System.Windows.Forms;

namespace ColorfulApp
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            cbWindowStudents.Checked = Data.Instance.StudentsWindows;
            cbLessonRotation.Checked = Data.Instance.LessonRotation;
            cbWindowTeachers.Checked = Data.Instance.TeacherWindows;
        }

        private void nudGenerationCount_ValueChanged(object sender, EventArgs e)
        {
            Data.Instance.GenerationCount = decimal.ToInt32(nudGenerationCount.Value);
        }

        private void nudIndividualsCount_ValueChanged(object sender, EventArgs e)
        {
            Data.Instance.IndividualCount = decimal.ToInt32(nudIndividualsCount.Value);
        }

        private void cbWindowStudents_CheckedChanged(object sender, EventArgs e)
        {
            Data.Instance.StudentsWindows = cbWindowStudents.Checked;
        }

        private void cbLessonRotation_CheckedChanged(object sender, EventArgs e)
        {
            Data.Instance.LessonRotation = cbLessonRotation.Checked;
        }

        private void llSubjectSettings_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var subjTypeForm = new SubjectTypesForm();
            if (subjTypeForm.ShowDialog() == DialogResult.OK)
            {
                foreach (Subject s in subjTypeForm.TechSubjects)
                    s.IsTechnicalSubject = true;
                foreach (Subject s in subjTypeForm.NaturalSubject)
                    s.IsTechnicalSubject = false;
            }
        }

        private void cbWindowTeachers_CheckedChanged(object sender, EventArgs e)
        {
            Data.Instance.TeacherWindows = cbWindowTeachers.Checked;
        }

        private void btTeacherSettings_Click(object sender, EventArgs e)
        {
            var tSettingsForm = new TeacherSettingsForm();
            tSettingsForm.ShowDialog();
        }

        private void btnGenerationRules_Click(object sender, EventArgs e)
        {
            var conditionForm = new ConditionForm();
            conditionForm.ShowDialog();
        }
    }
}
