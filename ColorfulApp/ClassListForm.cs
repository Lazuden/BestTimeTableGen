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
    public partial class ClassListForm : Form
    {
        BindingSource classesBs;
        public ClassListForm()
        {
            InitializeComponent();

            classesBs = new BindingSource();
            classesBs.DataSource = Data.Instance.Classes.Values.ToList();
            dgvClasses.AutoGenerateColumns = false;
            dgvClasses.DataSource = classesBs;
        }

        private void ClassListForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (tClass cls in classesBs)
            {
                if (cls.Id == -1)
                {
                    cls.Id = Data.Instance.Classes.Last().Key + 1;
                    Data.Instance.Classes.Add(cls.Id, cls);
                }
                else
                {
                    Data.Instance.Classes[cls.Id].Name = cls.Name;
                }
            }
        }
    }
}
