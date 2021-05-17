using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace ColorfulApp
{
    public static class ExtensionMethods
    {
        public static void DoubleBuffered(this DataGridView dgv, bool value)
        {
            Type dgvType = dgv.GetType();
            PropertyInfo pi = dgvType.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(dgv, value, null);
        }

        public static DataTable CreateTimeTable(this Individual individual)
        {
            int clsCount = Data.Instance.Classes.Count;
            Dictionary<int, Dictionary<int, Lesson>> TimeTable = new Dictionary<int, Dictionary<int, Lesson>>(clsCount);
            foreach (int key in Data.Instance.Classes.Keys)
                TimeTable.Add(key, new Dictionary<int, Lesson>());
            // подготовка таблицы для расписания ^^^
            for (int i = 0; i < Data.Instance.N; i++)
                TimeTable[Data.Instance.Lessons[i].Cls.Id].Add(individual.Colors[i], Data.Instance.Lessons[i]);


            DataTable dt = new DataTable();
            dt.Columns.Add("уроки\\классы");
            string[] tmpList = new string[31];
            for (int i = 1; i < 31; i++)
            {
                dt.Columns.Add(i.ToString());
            }

            Lesson curLes;
            foreach (Dictionary<int, Lesson> clsTimeTable in TimeTable.Values)
            {
                tmpList[0] = clsTimeTable.First().Value.Cls.Name;
                for (int i = 1; i < 31; i++)
                {
                    curLes = null;
                    clsTimeTable.TryGetValue(i, out curLes);
                    tmpList[i] = curLes?.ToString() ?? "-----------";
                }
                dt.Rows.Add(tmpList);
            }
            DataTable correctTable = WorkWithExcel.GenerateTransposedTable(dt);
            return correctTable;
        }

        public static DataTable CreateTeacherTimeTable(this Individual individual)
        {
            int clsCount = Data.Instance.Classes.Count;
            Dictionary<int, Dictionary<int, Lesson>> TimeTable = new Dictionary<int, Dictionary<int, Lesson>>(clsCount);
            foreach (int key in Data.Instance.Teachers.Keys)
                TimeTable.Add(key, new Dictionary<int, Lesson>());
            // подготовка таблицы для расписания ^^^
            for (int i = 0; i < Data.Instance.N; i++)
                TimeTable[Data.Instance.Lessons[i].Teacher.Id].Add(individual.Colors[i], Data.Instance.Lessons[i]);


            DataTable dt = new DataTable();
            dt.Columns.Add("уроки\\Учителя");
            string[] tmpList = new string[31];
            for (int i = 1; i < 31; i++)
            {
                dt.Columns.Add(i.ToString());
            }

            Lesson curLes;
            foreach (Dictionary<int, Lesson> teacherTimeTable in TimeTable.Values)
            {
                tmpList[0] = teacherTimeTable.First().Value.Teacher.Name;
                for (int i = 1; i < 31; i++)
                {
                    curLes = null;
                    teacherTimeTable.TryGetValue(i, out curLes);
                    tmpList[i] = curLes?.Info ?? "-----------";
                }
                dt.Rows.Add(tmpList);
            }
            DataTable correctTable = WorkWithExcel.GenerateTransposedTable(dt);
            return correctTable;
        }
    }
}
