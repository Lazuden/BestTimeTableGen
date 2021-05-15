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
    public partial class SheduleForm : Form
    {
        DataTable dataTable;
        public SheduleForm(DataTable shedule)
        {
            InitializeComponent();
            dgvTimeTable.DoubleBuffered(true);
            dataTable = shedule;
            dgvTimeTable.DataSource = shedule;
            foreach (DataGridViewColumn column in dgvTimeTable.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void dgvTimeTable_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void dgvTimeTable_DragDrop(object sender, DragEventArgs e)
        {
            Point fromCell = (Point)e.Data.GetData(typeof(Point));            
            Point cursorLocation = dgvTimeTable.PointToClient(new Point(e.X, e.Y));
            DataGridView.HitTestInfo hitTestInfo = dgvTimeTable.HitTest(cursorLocation.X, cursorLocation.Y);
            if (hitTestInfo.ColumnIndex > 1 && hitTestInfo.RowIndex != -1 && hitTestInfo.ColumnIndex == fromCell.X)
            {
                string cellvalue = dataTable.Rows[fromCell.Y][fromCell.X].ToString();
                dataTable.Rows[fromCell.Y][fromCell.X] = dataTable.Rows[hitTestInfo.RowIndex][hitTestInfo.ColumnIndex].ToString();
                dataTable.Rows[hitTestInfo.RowIndex][hitTestInfo.ColumnIndex] = cellvalue;
            }
            dgvTimeTable.AllowDrop = false;
        }

        private void dgvTimeTable_MouseDown(object sender, MouseEventArgs e)
        {
            Point fromCell = new Point();
            DataGridView.HitTestInfo hitTestInfo = dgvTimeTable.HitTest(e.X, e.Y);
            if (hitTestInfo.ColumnIndex > 1 && hitTestInfo.RowIndex != -1)
            {
                dgvTimeTable.AllowDrop = true;
                fromCell.X = hitTestInfo.ColumnIndex;
                fromCell.Y = hitTestInfo.RowIndex;
                DragDropEffects dde = DoDragDrop(fromCell, DragDropEffects.All);
            }
        }
    }
}
