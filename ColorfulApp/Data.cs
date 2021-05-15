using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ColorfulApp
{
    [Serializable]
    public class Data
    {
        private static Data instance;

        public static Data Instance
        {
            get
            {
                if (instance == null)
                    instance = new Data();
                return instance;
            }
            set
            {
                instance = value;
            }
        }

        string name;

        private Data()
        {
            name = "Безымянный";
        }

        int generationCount = 5;
        int individualCount = 100;
        bool studentsWindows = true;
        bool teacherWindows = true;
        bool lessonRotation = true;
        List<Lesson> LesList;
        Dictionary<int, Teacher> teacherDict;
        Dictionary<int, tClass> clsDict;
        List<LessonEditor> lessonEditors;
        List<string> rules;
        List<RuleItem> originalRules;

        public List<Subject> SubjList;

        public int N { get; set; }

        public bool [,] Mas { get; set; }

        public List<Lesson> LL
        {
            get { return LesList; }
            set { LesList = value; }
        }

        public Dictionary<int, tClass> Classes
        {
            get { return clsDict; }
            set { clsDict = value; }
        }

        public List<string> Rules
        {
            get { return rules; }
            set { rules = value; }
        }

        public List<RuleItem> OriginalRules
        {
            get { return originalRules; }
            set { originalRules = value; }
        }

        /// <summary>
        /// Просто подряд идущие числа, необходимы для преоброзований, чтобы каждый раз не считать
        /// </summary>
        public int[] Numbers { get; private set; }
        public Dictionary<int, Teacher> Teachers { get => teacherDict; set => teacherDict = value; }
        public string Name { get => name; set => name = value; }
        public List<LessonEditor> LessonEditors { get => lessonEditors; set => lessonEditors = value; }
        public int GenerationCount { get => generationCount; set => generationCount = value; }
        public int IndividualCount { get => individualCount; set => individualCount = value; }
        public bool StudentsWindows { get => studentsWindows; set => studentsWindows = value; }
        public bool LessonRotation { get => lessonRotation; set => lessonRotation = value; }
        public bool TeacherWindows { get => teacherWindows; set => teacherWindows = value; }

        public void InitializeSupportData()
        {
            N = LesList.Count;
            for(int i = 0; i < LL.Count; i++)
            {
                LL[i].Id = i;
            }
            CreateAdjacencyMatrix();
            Numbers = new int[N];
            for (int i = 0; i < N; i++)
            {
                Numbers[i] = i;
            }
        }

        void CreateAdjacencyMatrix()
        {
            Mas = new bool[N, N];
            for (int i = 0; i < N; i++)
            {
                for (int j = i + 1; j < N; j++)
                {
                    if (LesList[i].Teacher == LesList[j].Teacher || LesList[i].Cls == LesList[j].Cls)
                    {
                        Mas[i, j] = Mas[j, i] = true;
                        LesList[i].Weight++;
                        LesList[j].Weight++;
                    }
                }
            }
        }
        
    }
}
