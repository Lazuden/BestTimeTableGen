using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorfulApp
{
    // Особь
    class Individual : IComparable<Individual>
    {
        public int[] StrikeOrder { get; private set; }
        public int[] ColorizeOrder { get; private set; }
        public int[] Colors { get; private set; }
        public int ColorsCount { get; private set; }
        public int Rating { get; private set; }

        /// <summary>
        /// Конструктор для случайного порядка
        /// </summary>
        public Individual()
        {
            Colors = new int[Data.Instance.N];
            StrikeOrder = new int[Data.Instance.N];
            ColorizeOrder = new int[Data.Instance.N];
            Array.Copy(Data.Instance.Numbers, ColorizeOrder, Data.Instance.N);
            Rand.Shuffle(ColorizeOrder);
            Encode();
        }

        /// <summary>
        /// Конструктор для создания потомка
        /// </summary>
        /// <param name="indA">Первая особь родитель</param>
        /// <param name="indB">Вторая особь родитель</param>
        public Individual(Individual indA, Individual indB)
        {
            Colors = new int[Data.Instance.N];
            StrikeOrder = new int[Data.Instance.N];
            ColorizeOrder = new int[Data.Instance.N];            
            int middle = Data.Instance.N / 2;
            int i;
            for (i = 0; i < middle; i++)
                StrikeOrder[i] = indA.StrikeOrder[i];

            for (i = middle; i < Data.Instance.N; i++)
                StrikeOrder[i] = indB.StrikeOrder[i];

            Decode();
            if (ThreadSafeRandom.ThisThreadsRandom.Next(100) > 95)
                Mutate();
        }

        public DataTable CreateTimeTable()
        {
            int clsCount = Data.Instance.Classes.Count;
            Dictionary<int, Dictionary<int, Lesson>> TimeTable = new Dictionary<int, Dictionary<int, Lesson>>(clsCount);
            foreach (int key in Data.Instance.Classes.Keys)
                TimeTable.Add(key, new Dictionary<int, Lesson>());
            // подготовка таблицы для расписания ^^^
            for (int i = 0; i < Data.Instance.N; i++)
                TimeTable[Data.Instance.LL[i].Cls.Id].Add(Colors[i], Data.Instance.LL[i]);


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

        public DataTable CreateTeacherTimeTable()
        {
            int clsCount = Data.Instance.Classes.Count;
            Dictionary<int, Dictionary<int, Lesson>> TimeTable = new Dictionary<int, Dictionary<int, Lesson>>(clsCount);
            foreach (int key in Data.Instance.Teachers.Keys)
                TimeTable.Add(key, new Dictionary<int, Lesson>());
            // подготовка таблицы для расписания ^^^
            for (int i = 0; i < Data.Instance.N; i++)
                TimeTable[Data.Instance.LL[i].Teacher.Id].Add(Colors[i], Data.Instance.LL[i]);


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

        public void BuildAndColorize()
        {
            ColorizeByOrder();
            CalcRating();
        }

        private void CalcRating()
        {
            int clsCount = Data.Instance.Classes.Count;
            // таблица для учителей
            var teacherTimeTable = new Dictionary<int, Dictionary<int, Lesson>>(clsCount);
            foreach (int key in Data.Instance.Teachers.Keys)
                teacherTimeTable.Add(key, new Dictionary<int, Lesson>());
            // таблица для классов
            var clsTimeTable = new Dictionary<int, Dictionary<int, Lesson>>(clsCount);
            foreach(int key in Data.Instance.Classes.Keys)
                clsTimeTable.Add(key, new Dictionary<int, Lesson>());
            // подготовка таблицы для расписания ^^^
            for (int i = 0; i < Data.Instance.N; i++)
            {
                clsTimeTable[Data.Instance.LL[i].Cls.Id].Add(Colors[i], Data.Instance.LL[i]);
                teacherTimeTable[Data.Instance.LL[i].Teacher.Id].Add(Colors[i], Data.Instance.LL[i]);
            }

            // подсчет рейтинга
            Rating = 0;
            if (ColorsCount > 29) // 34
                Rating = -100;
            Lesson curLesson;
            bool lessonsBefore = false, emptyBefore = false, isPrevMath, curMath = false;
            foreach (Dictionary<int, Lesson> oneClsTimeTable in clsTimeTable.Values)
            {
                for (int i = 1; i < 31; i++) // 36
                {
                    if ((i - 1) % 6 == 0) // 7
                        lessonsBefore = emptyBefore = false;
                    curLesson = null;
                    oneClsTimeTable.TryGetValue(i, out curLesson);
                    if (curLesson == null)
                        emptyBefore = lessonsBefore;
                    else
                    {
                        if (Data.Instance.StudentsWindows)
                            Rating += emptyBefore ? -30 : 1;   
                        if (Data.Instance.LessonRotation)
                        {
                            isPrevMath = curMath;
                            curMath = curLesson.Subject.IsTechnicalSubject;
                            if (lessonsBefore)
                                Rating += isPrevMath != !curMath ? 1 : 0;
                        }
                        lessonsBefore = true;
                    }
                }
            }
            if (Data.Instance.TeacherWindows)
            {
                lessonsBefore = emptyBefore = false;
                foreach (Dictionary<int, Lesson> oneTeacherTimeTable in teacherTimeTable.Values)
                {
                    for (int i = 1; i < 31; i++) 
                    {
                        if ((i - 1) % 6 == 0)
                            lessonsBefore = emptyBefore = false;
                        curLesson = null;
                        oneTeacherTimeTable.TryGetValue(i, out curLesson);
                        if (curLesson == null)
                            emptyBefore = lessonsBefore;
                        else
                        {
                            // подумать над коэффицентами!
                            Rating += emptyBefore ? -1 : 10;
                            lessonsBefore = true;
                        }
                    }
                }
            }
            if (Data.Instance.Rules != null)
            {
                int rate = CalcRulesRating();
                Rating += rate;
            }
        }

        private int CalcRulesRating()
        {
            double result = 0.0;
            var connection = new SQLiteConnection("Data Source=:memory:");
            connection.Open();
            var sqlCmd = new SQLiteCommand();
            sqlCmd.Connection = connection;

            sqlCmd.CommandText = "DROP TABLE IF EXISTS timetable";
            sqlCmd.ExecuteNonQuery();
            sqlCmd.CommandText = "CREATE TABLE timetable (t int, c int, s int, d int, x int)";
            sqlCmd.ExecuteNonQuery();
            sqlCmd.CommandText = "INSERT INTO timetable VALUES " + prepareDataForInserting();
            sqlCmd.ExecuteNonQuery();

            foreach (string query in Data.Instance.Rules)
            {
                sqlCmd.CommandText = query;
                sqlCmd.CommandText = "SELECT res, COUNT(res) as count FROM(" + query + 
                    @")
                    GROUP BY res
                    ORDER BY res DESC";

                var reader = sqlCmd.ExecuteReader();

                reader.Read();
                int positiveCount = Convert.ToInt32(reader["count"]);
                int negativeCount = 0;
                reader.Read();
                if (reader.HasRows)
                {
                    negativeCount = Convert.ToInt32(reader["count"]);
                }
                result += 30 * ((double)(positiveCount - negativeCount)) / (positiveCount + negativeCount);
            }

            return Convert.ToInt32(result);
        }

        private string prepareDataForInserting()
        {
            string result = "";
            for (int i = 0; i < Data.Instance.N; i++)
            {
                Lesson l = Data.Instance.LL[i];
                int time = Colors[i];
                result += $"({l.Teacher.Id}, {l.Cls.Id}, {Data.Instance.SubjList.IndexOf(l.Subject)}, {(time - 1) / 6}, {(time - 1) % 6})";
                if (i != Data.Instance.N - 1)
                {
                    result += ", ";
                }
            }

            return result;
        }

        private void ColorizeByOrder()
        {
            ColorsCount = 0;
            for (int i = 0; i < Data.Instance.N; i++)
            {
                Colors[ColorizeOrder[i]] = 1;
                HashSet<int> usedColors = new HashSet<int>();
                for (int j = 0; j < i; j++)
                {
                    if (i != j && IsAdjacent(i, j))
                    {
                        usedColors.Add(Colors[ColorizeOrder[j]]);
                        while (usedColors.Contains(Colors[ColorizeOrder[i]]))
                            Colors[ColorizeOrder[i]]++;
                        if (ColorsCount < Colors[ColorizeOrder[i]])
                            ColorsCount = Colors[ColorizeOrder[i]];
                    }
                }
            }
        }

        private bool IsAdjacent(int i, int j)
        {
            return Data.Instance.Mas[Data.Instance.LL[ColorizeOrder[i]].Id, Data.Instance.LL[ColorizeOrder[j]].Id];
        }

        private void Encode() // закодировать - приведение к виду, удобному для скрещивания
        {
            List<int> numbers = new List<int>(Data.Instance.Numbers);
            int curDelete;
            for (int i = 0; i < Data.Instance.N; i++)
            {
                curDelete = numbers.FindIndex(x => x == ColorizeOrder[i]);
                numbers.RemoveAt(curDelete);
                StrikeOrder[i] = curDelete;
            } 
        }

        private void Decode() // раскодировать - преведение к привычному виду порядка раскраски
        {
            List<int> numbers = new List<int>(Data.Instance.Numbers);
            for (int i = 0; i < Data.Instance.N; i++)
            {
                ColorizeOrder[i] = numbers[StrikeOrder[i]];
                numbers.RemoveAt(StrikeOrder[i]);
            }            
        }

        /// <summary>
        /// Мутация
        /// </summary>
        /// <param name="count"> количество мутирующих генов </param>
        private void Mutate(int count = 2)
        {
            int firstIndex, secondIndex, tmpValue;
            for(int i = 0; i < count; i++)
            {
                firstIndex = ThreadSafeRandom.ThisThreadsRandom.Next(Data.Instance.N);
                secondIndex = ThreadSafeRandom.ThisThreadsRandom.Next(Data.Instance.N);
                tmpValue = ColorizeOrder[firstIndex];
                ColorizeOrder[firstIndex] = ColorizeOrder[secondIndex];
                ColorizeOrder[secondIndex] = tmpValue;
            }
            Encode();
        }

        int IComparable<Individual>.CompareTo(Individual other)
        {
            return Rating.CompareTo(other.Rating);
        }
    }
}
