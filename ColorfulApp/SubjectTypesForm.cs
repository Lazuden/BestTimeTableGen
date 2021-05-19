using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace ColorfulApp
{
    public partial class SubjectTypesForm : Form
    {
        public SubjectTypesForm()
        {
            InitializeComponent();
            techSubj = new BindingList<Subject>();
            naturalSubj = new BindingList<Subject>();
            foreach(Subject s in Data.Instance.Subjects)
            {
                if (s.IsTechnicalSubject)
                    techSubj.Add(s);
                else
                    naturalSubj.Add(s);
            }
            lbTech.DataSource = techSubj;
            lbNaturalScience.DataSource = naturalSubj;
            lbNaturalScience.DisplayMember = "Name";
            lbTech.DisplayMember = "Name";
        }

        public BindingList<Subject> TechSubjects { get; set; }
        public BindingList<Subject> NaturalSubject { get; set; }

        #region Drag&Drop
        private void lbTech_MouseDown(object sender, MouseEventArgs e)
        {
            int index = lbTech.IndexFromPoint(e.X, e.Y);
            if (lbTech.Items.Count == 0 || index == -1)
                return;            
            lbNaturalScience.AllowDrop = true;
            
            Subject s = TechSubjects[index];
            DragDropEffects dde1 = DoDragDrop(s, DragDropEffects.All);

            if (dde1 == DragDropEffects.All)
            {
                TechSubjects.RemoveAt(index);
            }
        }

        private void lbNaturalScience_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void lbNaturalScience_DragDrop(object sender, DragEventArgs e)
        {
            Subject str = (Subject)e.Data.GetData(typeof(Subject));
            NaturalSubject.Add(str);
            lbNaturalScience.AllowDrop = false;
        }

        private void lbTech_DragDrop(object sender, DragEventArgs e)
        {
            Subject str = (Subject)e.Data.GetData(typeof(Subject));
            TechSubjects.Add(str);
            lbTech.AllowDrop = false;
        }

        private void lbTech_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void lbNaturalScience_MouseDown(object sender, MouseEventArgs e)
        {
            int index = lbNaturalScience.IndexFromPoint(e.X, e.Y);
            if (lbNaturalScience.Items.Count == 0 || index == -1)
                return;
            lbTech.AllowDrop = true;

            Subject s = NaturalSubject[index];
            DragDropEffects dde1 = DoDragDrop(s,
                DragDropEffects.All);

            if (dde1 == DragDropEffects.All)
            {
                NaturalSubject.RemoveAt(index);
            }
        }
        #endregion

        private void btToNaturalScience_Click(object sender, EventArgs e)
        {
            if (lbTech.SelectedIndex != -1)
            {
                NaturalSubject.Add(TechSubjects[lbTech.SelectedIndex]);
                TechSubjects.RemoveAt(lbTech.SelectedIndex);
            }
        }

        private void btToTech_Click(object sender, EventArgs e)
        {
            if (lbNaturalScience.SelectedIndex != -1)
            {
                TechSubjects.Add(NaturalSubject[lbNaturalScience.SelectedIndex]);
                NaturalSubject.RemoveAt(lbNaturalScience.SelectedIndex);
            }
        }
    }
}
