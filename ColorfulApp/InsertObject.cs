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
    public partial class InsertObject : Form
    {
        public string InsertedName {get; set;}

        public InsertObject()
        {
            InitializeComponent();
            cbObjectType.SelectedIndex = 0;
            lbObjects.DataSource = Data.Instance.Teachers.Values.ToList();
            lbObjects.DisplayMember = "Name";
            lbObjects.ValueMember = "Name";
        }

        private void btInsert_Click(object sender, EventArgs e)
        {
            InsertedName = "'" + (string)lbObjects.SelectedValue + "'";
            DialogResult = DialogResult.OK;
            Close();
        }

        private void cbObjectType_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbObjects.SelectedIndex = -1;
            lbObjects.DataSource = null;
            switch (cbObjectType.SelectedIndex)
            {
                case 1:
                    lbObjects.DataSource = Data.Instance.SubjList.ToList();
                    break;
                case 2:
                    lbObjects.DataSource = Data.Instance.Classes.Values.ToList();
                    break;
                case 0:
                default:
                    lbObjects.DataSource = Data.Instance.Teachers.Values.ToList();
                    break;
            }
            lbObjects.DisplayMember = "Name";
            lbObjects.ValueMember = "Name";
        }
    }
}
