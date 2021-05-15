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
    public partial class TeacherSettingsForm : Form
    {
        public TeacherSettingsForm()
        {
            InitializeComponent();
            lbTeacherList.DataSource = Data.Instance.Teachers.Values.ToList();
            lbTeacherList.DisplayMember = "Name";
        }
    }
}
