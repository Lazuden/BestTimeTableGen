using System;
using System.Collections.Generic;
using System.Linq;

namespace ColorfulApp
{
    [Serializable]
    public class Data
    {
        private static Data _instance;

        public static Data Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Data();
                return _instance;
            }
            set
            {
                _instance = value;
            }
        }

        private Data()
        {
            Name = "Безымянный";
        }

        public List<Subject> Subjects { get; set; }
        public int N { get => Lessons.Count; }
        public bool [,] Mas { get; set; }
        public List<Lesson> Lessons { get; set; }
        public Dictionary<int, tClass> Classes { get; set; }
        public List<string> Rules { get; set; }
        public List<RuleItem> OriginalRules { get; set; }

        /// <summary>
        /// Просто подряд идущие числа, необходимы для преоброзований, чтобы каждый раз не считать
        /// </summary>
        public int[] Numbers { get; private set; }
        public Dictionary<int, Teacher> Teachers { get; set; }
        public string Name { get; set; }
        public List<LessonEditor> LessonEditors { get; set; }
        public int GenerationCount { get; set; } = 5;
        public int IndividualCount { get; set; } = 100;
        public bool StudentsWindows { get; set; } = true;
        public bool LessonRotation { get; set; } = true;
        public bool TeacherWindows { get; set; } = true;

        public void InitializeSupportData()
        {
            //N = Lessons.Count;
            for(int i = 0; i < N; i++)
            {
                Lessons[i].Id = i;
            }
            CreateAdjacencyMatrix();
            Numbers = new int[N];
            for (int i = 0; i < N; i++)
            {
                Lessons[i].Id = i;
            }
            CreateAdjacencyMatrix();
            Numbers = Enumerable.Range(0, N).ToArray();
        }

        private void CreateAdjacencyMatrix()
        {
            Mas = new bool[N, N];
            for (int i = 0; i < N; i++)
            {
                for (int j = i + 1; j < N; j++)
                {
                    if (Lessons[i].Teacher == Lessons[j].Teacher || Lessons[i].Cls == Lessons[j].Cls)
                    {
                        Mas[i, j] = Mas[j, i] = true;
                        Lessons[i].Weight++;
                        Lessons[j].Weight++;
                    }
                }
            }
        }
    }
}
