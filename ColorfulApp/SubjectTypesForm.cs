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
    public partial class SubjectTypesForm : Form
    {
        BindingList<Subject> techSubj;
        BindingList<Subject> naturalSubj;
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

        public BindingList<Subject> TechSubj { get => techSubj; set => techSubj = value; }
        public BindingList<Subject> NaturalSubj { get => naturalSubj; set => naturalSubj = value; }

        #region Drag&Drop
        private void lbTech_MouseDown(object sender, MouseEventArgs e)
        {
            int index = lbTech.IndexFromPoint(e.X, e.Y);
            if (lbTech.Items.Count == 0 || index == -1)
                return;            
            lbNaturalScience.AllowDrop = true;
            
            Subject s = techSubj[index];
            DragDropEffects dde1 = DoDragDrop(s,
                DragDropEffects.All);

            if (dde1 == DragDropEffects.All)
            {
                techSubj.RemoveAt(index);
            }
        }

        private void lbNaturalScience_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void lbNaturalScience_DragDrop(object sender, DragEventArgs e)
        {
            Subject str = (Subject)e.Data.GetData(typeof(Subject));
            naturalSubj.Add(str);
            lbNaturalScience.AllowDrop = false;
        }

        private void lbTech_DragDrop(object sender, DragEventArgs e)
        {
            Subject str = (Subject)e.Data.GetData(typeof(Subject));
            techSubj.Add(str);
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

            Subject s = naturalSubj[index];
            DragDropEffects dde1 = DoDragDrop(s,
                DragDropEffects.All);

            if (dde1 == DragDropEffects.All)
            {
                naturalSubj.RemoveAt(index);
            }
        }
        #endregion

        private void btToNaturalScience_Click(object sender, EventArgs e)
        {
            if (lbTech.SelectedIndex != -1)
            {
                naturalSubj.Add(techSubj[lbTech.SelectedIndex]);
                techSubj.RemoveAt(lbTech.SelectedIndex);
            }
        }

        private void btToTech_Click(object sender, EventArgs e)
        {
            if (lbNaturalScience.SelectedIndex != -1)
            {
                techSubj.Add(naturalSubj[lbNaturalScience.SelectedIndex]);
                naturalSubj.RemoveAt(lbNaturalScience.SelectedIndex);
            }
        }
    }
}
