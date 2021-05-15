using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ColorfulApp
{
    public partial class MainForm : Form
    {
        string FileName;
        BindingSource lessonsBs;
        BinaryFormatter bf;
        DataTable shedule, teacherShedule;
        bool ChangesHappend;

        public MainForm()
        {
            InitializeComponent();
            bf = new BinaryFormatter();


            // Временно при загрузке, чтобы вечно не тыкать
            FillStartData();
            lessonsBs = new BindingSource();
            lessonsBs.DataSource = Data.Instance.LessonEditors;

            dgvPlan.AutoGenerateColumns = false;
            dgvPlan.DataSource = lessonsBs;            
            ChangesHappend = false;
        }

        private void FillStartData()
        {
            Data.Instance.Lessons = new List<Lesson>();
            Data.Instance.LessonEditors = new List<LessonEditor>();

            #region SubjectsWrite
            Data.Instance.Subjects = new List<Subject>()
            {
                new Subject("Математика", true),        // 0
                new Subject("Алгебра", true),           // 1
                new Subject("Геометрия", true),         // 2
                new Subject("Русский язык"),            // 3
                new Subject("Литература"),              // 4 
                new Subject("Иностранный язык"),        // 5
                new Subject("История"),                 // 6
                new Subject("Обществознание"),          // 7
                new Subject("География", true),         // 8
                new Subject("Биология", true),          // 9
                new Subject("Музыка"),                  // 10
                new Subject("ИЗО"),                     // 11
                new Subject("Технология"),              // 12
                new Subject("Физическая культура"),     // 13
                new Subject("Физика", true),            // 14
                new Subject("Химия", true),             // 15
                new Subject("Информатика", true)        // 16
            };
            #endregion

            #region TeacherWrite
            Data.Instance.Teachers = new Dictionary<int, Teacher>
            {
                // 5 класс
                { 1, new Teacher(1, "Иванов В.В.", new HashSet<Subject>{ Data.Instance.Subjects[3], Data.Instance.Subjects[4]} ) },// русский литература
                { 2, new Teacher(2, "Петров К.С.", new HashSet<Subject>{ Data.Instance.Subjects[5]}) }, // Английский язык
                { 3, new Teacher(3, "Климов М.Т.", new HashSet<Subject>{ Data.Instance.Subjects[0], Data.Instance.Subjects[1], Data.Instance.Subjects[2]}) }, // математика алгебра геометрия
                { 4, new Teacher(4, "Гаврилова О.И.", new HashSet<Subject>{ Data.Instance.Subjects[6], Data.Instance.Subjects[7]}) },// История обществознание
                { 5, new Teacher(5, "Тунчак С.К.", new HashSet<Subject>{ Data.Instance.Subjects[8]})}, // География
                { 6, new Teacher(6, "Лотуш Е.М.", new HashSet<Subject>{ Data.Instance.Subjects[9]}) }, // Биология
                { 7, new Teacher(7, "Кринчук М.В.", new HashSet<Subject>{ Data.Instance.Subjects[10]}) }, // Музыка
                { 8, new Teacher(8, "Кхалова С.С.", new HashSet<Subject>{ Data.Instance.Subjects[11]}) }, // ИЗО
                { 9, new Teacher(9, "Тоттава Н.И.", new HashSet<Subject>{ Data.Instance.Subjects[12]}) }, // Технология
                { 10, new Teacher(10, "Мордлина Г.А.", new HashSet<Subject>{ Data.Instance.Subjects[13]}) },// физкультура
                // 6 класс
                { 11, new Teacher(11, "Скрипка Р.Н.", new HashSet<Subject>{ Data.Instance.Subjects[3], Data.Instance.Subjects[4]})}, // Русский Литература
                { 12, new Teacher(12, "Кривоухова С.А.", new HashSet<Subject>{ Data.Instance.Subjects[0]}) }, // Математика
                // 7 класс
                { 13, new Teacher(13, "Орлова И.Н.", new HashSet<Subject>{ Data.Instance.Subjects[3], Data.Instance.Subjects[4]})}, // Русский Литература
                { 14, new Teacher(14, "Усынбаева В.Е.", new HashSet<Subject>{ Data.Instance.Subjects[5]}) }, // Английский язык
                { 15, new Teacher(15, "Сычева Е.Г.", new HashSet<Subject>{ Data.Instance.Subjects[0], Data.Instance.Subjects[1], Data.Instance.Subjects[2] }) }, // математика алгебра геометрия
                { 16, new Teacher(16, "Копылова Т.А.", new HashSet<Subject>{ Data.Instance.Subjects[14]} ) }, // Физика
                { 17, new Teacher(17, "Руков К.Г.", new HashSet<Subject>{ Data.Instance.Subjects[6], Data.Instance.Subjects[7]}) }, // История/обществознание 
                // 8 класс
                { 18, new Teacher(18, "Кирюшина У.Э.", new HashSet<Subject>{ Data.Instance.Subjects[3], Data.Instance.Subjects[4]})}, // Русский Литература
                { 19, new Teacher(19, "Романова Е.К.", new HashSet<Subject>{ Data.Instance.Subjects[0], Data.Instance.Subjects[1], Data.Instance.Subjects[2]})}, // математика алгебра геометрия
                { 20, new Teacher(20, "Дитрова Н.А.", new HashSet<Subject>{ Data.Instance.Subjects[16]})}, // Информатика
                { 21, new Teacher(21, "Кочубеев О.В.", new HashSet<Subject>{ Data.Instance.Subjects[15]})}, // Химия
                { 22, new Teacher(22, "Конюхов К.Е.", new HashSet<Subject>{ Data.Instance.Subjects[13]})}, // Физкультура
                // 9 класс
                { 23, new Teacher(23, "Нулотова Е.В.", new HashSet<Subject>{Data.Instance.Subjects[3], Data.Instance.Subjects[4] })}, // Русский Литература
                { 24, new Teacher(24, "Гурсина Р.В.", new HashSet<Subject>{ Data.Instance.Subjects[0]}) }, // Математика
                { 25, new Teacher(25, "Препода У.К.", new HashSet<Subject>{ Data.Instance.Subjects[5]}) }, // Английский язык
                { 26, new Teacher(26, "Щукина М.С.", new HashSet<Subject>{ Data.Instance.Subjects[6], Data.Instance.Subjects[7]}) }, // История/обществознание 
                { 27, new Teacher(27, "Пискунова Л.В.", new HashSet<Subject>{ Data.Instance.Subjects[8]})}, // География
                { 28, new Teacher(28, "Ипатова Г.У.", new HashSet<Subject>{ Data.Instance.Subjects[9] }) }, // Биология
                { 29, new Teacher(29, "Плетунов К.В.", new HashSet<Subject>{ Data.Instance.Subjects[13] })}, // Физкультура
            };
            #endregion

            #region ClassWrite
            Data.Instance.Classes = new Dictionary<int, tClass>()
            {
                {1, new tClass("5А", 1) },
                {2, new tClass("5Б", 2) },
                {3, new tClass("5В", 3) },
                {4, new tClass("6А", 4) },
                {5, new tClass("6Б", 5) },
                {6, new tClass("6В", 6) },
                {7, new tClass("7A", 7) },
                {8, new tClass("7Б", 8) },
                {9, new tClass("7В", 9) },
                {10, new tClass("8A", 10) },
                {11, new tClass("8Б", 11) },
                {12, new tClass("8В", 12) },
                {13, new tClass("9A", 13) },
                {14, new tClass("9Б", 14) },
                {15, new tClass("9В", 15) }
            };
            #endregion

            #region LessonWrite
            List<Lesson> lessons = Data.Instance.Lessons;
            List<LessonEditor> lesEdit = Data.Instance.LessonEditors;
            Dictionary<int, Teacher> teachers = Data.Instance.Teachers;
            Dictionary<int, tClass> classes = Data.Instance.Classes;
            List<Subject> subjects = Data.Instance.Subjects;



            for (int i = 0; i < 4; i++)  // по 4 урока руского у каждого класса 7 класса
            {
                lessons.Add(new Lesson(teachers[13], classes[7], subjects[3]));
                lessons.Add(new Lesson(teachers[13], classes[8], subjects[3]));
                lessons.Add(new Lesson(teachers[13], classes[9], subjects[3]));
            }
            lesEdit.Add(new LessonEditor(new Lesson(teachers[13], classes[7], subjects[3]), 4));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[13], classes[8], subjects[3]), 4));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[13], classes[9], subjects[3]), 4));

            for (int i = 0; i < 2; i++)  // по 2 урока литературы у каждого класса 7 класса
            {
                lessons.Add(new Lesson(teachers[13], classes[7], subjects[4]));
                lessons.Add(new Lesson(teachers[13], classes[8], subjects[4]));
                lessons.Add(new Lesson(teachers[13], classes[9], subjects[4]));
            }
            lesEdit.Add(new LessonEditor(new Lesson(teachers[13], classes[7], subjects[4]), 2));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[13], classes[8], subjects[4]), 2));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[13], classes[9], subjects[4]), 2));


            for (int i = 0; i < 7; i++)  // по 7 уроков русского у каждого класса 6 класса
            {
                lessons.Add(new Lesson(teachers[11], classes[4], subjects[7]));
                lessons.Add(new Lesson(teachers[11], classes[5], subjects[3]));
                lessons.Add(new Lesson(teachers[11], classes[6], subjects[3]));
            }
            lesEdit.Add(new LessonEditor(new Lesson(teachers[11], classes[4], subjects[3]), 7));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[11], classes[5], subjects[3]), 7));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[11], classes[6], subjects[3]), 7));

            for (int i = 0; i < 2; i++)  // по 2 урока литературы у каждого класса 6 класса
            {
                lessons.Add(new Lesson(teachers[11], classes[5], subjects[4]));
                lessons.Add(new Lesson(teachers[11], classes[6], subjects[4]));
                lessons.Add(new Lesson(teachers[11], classes[4], subjects[4]));
            }
            lesEdit.Add(new LessonEditor(new Lesson(teachers[11], classes[5], subjects[4]), 2));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[11], classes[6], subjects[4]), 2));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[11], classes[4], subjects[4]), 2));


            for (int i = 0; i < 6; i++)  // по 6 уроков русского у каждого 5 класса
            {
                lessons.Add(new Lesson(teachers[1], classes[1], subjects[3]));
                lessons.Add(new Lesson(teachers[1], classes[2], subjects[3]));
                lessons.Add(new Lesson(teachers[1], classes[3], subjects[3]));
            }
            lesEdit.Add(new LessonEditor(new Lesson(teachers[1], classes[1], subjects[3]), 6));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[1], classes[2], subjects[3]), 6));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[1], classes[3], subjects[3]), 6));

            for (int i = 0; i < 2; i++)  // по 2 уроков литературы у каждого 5 класса
            {
                lessons.Add(new Lesson(teachers[1], classes[1], subjects[4]));
                lessons.Add(new Lesson(teachers[1], classes[2], subjects[4]));
                lessons.Add(new Lesson(teachers[1], classes[3], subjects[4]));
            }
            lesEdit.Add(new LessonEditor(new Lesson(teachers[1], classes[1], subjects[4]), 2));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[1], classes[2], subjects[4]), 2));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[1], classes[3], subjects[4]), 2));

            for (int i = 0; i < 5; i++)  // по 3 урока русского у каждого класса 8 класса
            {
                lessons.Add(new Lesson(teachers[18], classes[10], subjects[3]));
                lessons.Add(new Lesson(teachers[18], classes[11], subjects[3]));
                lessons.Add(new Lesson(teachers[18], classes[12], subjects[3]));
                // 9 класс
                lessons.Add(new Lesson(teachers[23], classes[13], subjects[3]));
                lessons.Add(new Lesson(teachers[23], classes[14], subjects[3]));
                lessons.Add(new Lesson(teachers[23], classes[15], subjects[3]));
            }
            lesEdit.Add(new LessonEditor(new Lesson(teachers[18], classes[10], subjects[3]), 5));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[18], classes[11], subjects[3]), 5));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[18], classes[12], subjects[3]), 5));
            // 9 класс
            lesEdit.Add(new LessonEditor(new Lesson(teachers[23], classes[13], subjects[3]), 5));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[23], classes[14], subjects[3]), 5));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[23], classes[15], subjects[3]), 5));

            for (int i = 0; i < 5; i++)  // по 2 урока литературы у каждого класса 8 класса
            {
                lessons.Add(new Lesson(teachers[18], classes[10], subjects[4]));
                lessons.Add(new Lesson(teachers[18], classes[11], subjects[4]));
                lessons.Add(new Lesson(teachers[18], classes[12], subjects[4]));
                // 9 класс
                lessons.Add(new Lesson(teachers[23], classes[13], subjects[4]));
                lessons.Add(new Lesson(teachers[23], classes[14], subjects[4]));
                lessons.Add(new Lesson(teachers[23], classes[15], subjects[4]));
            }
            lesEdit.Add(new LessonEditor(new Lesson(teachers[18], classes[10], subjects[4]), 5));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[18], classes[11], subjects[4]), 5));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[18], classes[12], subjects[4]), 5));
            // 9 класс
            lesEdit.Add(new LessonEditor(new Lesson(teachers[23], classes[13], subjects[4]), 5));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[23], classes[14], subjects[4]), 5));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[23], classes[15], subjects[4]), 5));

            for (int i = 0; i < 3; i++)  // три урока Англ
            {
                lessons.Add(new Lesson(teachers[2], classes[1], subjects[5]));
                lessons.Add(new Lesson(teachers[2], classes[2], subjects[5]));
                lessons.Add(new Lesson(teachers[2], classes[3], subjects[5]));
                // 6 класс
                lessons.Add(new Lesson(teachers[2], classes[4], subjects[5]));
                lessons.Add(new Lesson(teachers[2], classes[5], subjects[5]));
                lessons.Add(new Lesson(teachers[2], classes[6], subjects[5]));
                // 7 класс
                lessons.Add(new Lesson(teachers[14], classes[7], subjects[5]));
                lessons.Add(new Lesson(teachers[14], classes[8], subjects[5]));
                lessons.Add(new Lesson(teachers[14], classes[9], subjects[5]));
                // 8 класс
                lessons.Add(new Lesson(teachers[14], classes[10], subjects[5]));
                lessons.Add(new Lesson(teachers[14], classes[11], subjects[5]));
                lessons.Add(new Lesson(teachers[14], classes[12], subjects[5]));
                // 9 класс
                lessons.Add(new Lesson(teachers[25], classes[13], subjects[5]));
                lessons.Add(new Lesson(teachers[25], classes[14], subjects[5]));
                lessons.Add(new Lesson(teachers[25], classes[15], subjects[5]));
            }
            lesEdit.Add(new LessonEditor(new Lesson(teachers[2], classes[1], subjects[5]), 3));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[2], classes[2], subjects[5]), 3));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[2], classes[3], subjects[5]), 3));
            // 6 класс
            lesEdit.Add(new LessonEditor(new Lesson(teachers[2], classes[4], subjects[5]), 3));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[2], classes[5], subjects[5]), 3));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[2], classes[6], subjects[5]), 3));
            // 7 класс
            lesEdit.Add(new LessonEditor(new Lesson(teachers[14], classes[7], subjects[5]), 3));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[14], classes[8], subjects[5]), 3));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[14], classes[9], subjects[5]), 3));
            // 8 класс
            lesEdit.Add(new LessonEditor(new Lesson(teachers[14], classes[10], subjects[5]), 3));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[14], classes[11], subjects[5]), 3));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[14], classes[12], subjects[5]), 3));
            // 9 класс
            lesEdit.Add(new LessonEditor(new Lesson(teachers[25], classes[13], subjects[5]), 3));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[25], classes[14], subjects[5]), 3));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[25], classes[15], subjects[5]), 3));


            for (int i = 0; i < 5; i++)  // по 5 уроков математики в 5-6 классах
            {
                lessons.Add(new Lesson(teachers[3], classes[1], subjects[0]));
                lessons.Add(new Lesson(teachers[3], classes[2], subjects[0]));
                lessons.Add(new Lesson(teachers[3], classes[3], subjects[0]));
                // 6 класс
                lessons.Add(new Lesson(teachers[12], classes[4], subjects[0]));
                lessons.Add(new Lesson(teachers[12], classes[5], subjects[0]));
                lessons.Add(new Lesson(teachers[12], classes[6], subjects[0]));
            }
            lesEdit.Add(new LessonEditor(new Lesson(teachers[3], classes[1], subjects[0]), 5));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[3], classes[2], subjects[0]), 5));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[3], classes[3], subjects[0]), 5));
            // 6 класс
            lesEdit.Add(new LessonEditor(new Lesson(teachers[12], classes[4], subjects[0]), 5));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[12], classes[5], subjects[0]), 5));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[12], classes[6], subjects[0]), 5));

            for (int i = 0; i < 3; i++) { // 3 урока алгебры
                // 7 класс
                lessons.Add(new Lesson(teachers[15], classes[7], subjects[1]));
                lessons.Add(new Lesson(teachers[15], classes[8], subjects[1]));
                lessons.Add(new Lesson(teachers[15], classes[9], subjects[1]));
                // 8 класс
                lessons.Add(new Lesson(teachers[19], classes[10], subjects[1]));
                lessons.Add(new Lesson(teachers[19], classes[11], subjects[1]));
                lessons.Add(new Lesson(teachers[19], classes[12], subjects[1]));
                // 9 класс
                lessons.Add(new Lesson(teachers[24], classes[13], subjects[1]));
                lessons.Add(new Lesson(teachers[24], classes[14], subjects[1]));
                lessons.Add(new Lesson(teachers[24], classes[15], subjects[1]));
            }
            // 7 класс
            lesEdit.Add(new LessonEditor(new Lesson(teachers[15], classes[7], subjects[1]), 3));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[15], classes[8], subjects[1]), 3));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[15], classes[9], subjects[1]), 3));
            // 8 класс
            lesEdit.Add(new LessonEditor(new Lesson(teachers[19], classes[10], subjects[1]), 3));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[19], classes[11], subjects[1]), 3));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[19], classes[12], subjects[1]), 3));
            // 9 класс
            lesEdit.Add(new LessonEditor(new Lesson(teachers[24], classes[13], subjects[1]), 3));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[24], classes[14], subjects[1]), 3));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[24], classes[15], subjects[1]), 3));

            for (int i = 0; i < 2; i++) {  // 2 урока геометрии
                // 7 класс
                lessons.Add(new Lesson(teachers[15], classes[7], subjects[2]));
                lessons.Add(new Lesson(teachers[15], classes[8], subjects[2]));
                lessons.Add(new Lesson(teachers[15], classes[9], subjects[2]));
                // 8 класс
                lessons.Add(new Lesson(teachers[19], classes[10], subjects[2]));
                lessons.Add(new Lesson(teachers[19], classes[11], subjects[2]));
                lessons.Add(new Lesson(teachers[19], classes[12], subjects[2]));
                // 9 класс
                lessons.Add(new Lesson(teachers[24], classes[13], subjects[2]));
                lessons.Add(new Lesson(teachers[24], classes[14], subjects[2]));
                lessons.Add(new Lesson(teachers[24], classes[15], subjects[2]));
            }
            // 7 класс
            lesEdit.Add(new LessonEditor(new Lesson(teachers[15], classes[7], subjects[2]), 2));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[15], classes[8], subjects[2]), 2));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[15], classes[9], subjects[2]), 2));
            // 8 класс
            lesEdit.Add(new LessonEditor(new Lesson(teachers[19], classes[10], subjects[2]), 2));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[19], classes[11], subjects[2]), 2));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[19], classes[12], subjects[2]), 2));
            // 9 класс
            lesEdit.Add(new LessonEditor(new Lesson(teachers[24], classes[13], subjects[2]), 2));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[24], classes[14], subjects[2]), 2));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[24], classes[15], subjects[2]), 2));


            // один урок информатики в 8 классе
            lessons.Add(new Lesson(teachers[20], classes[10], subjects[16]));
            lessons.Add(new Lesson(teachers[20], classes[11], subjects[16]));
            lessons.Add(new Lesson(teachers[20], classes[12], subjects[16]));

            lesEdit.Add(new LessonEditor(new Lesson(teachers[20], classes[10], subjects[16]), 1));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[20], classes[11], subjects[16]), 1));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[20], classes[12], subjects[16]), 1));
            // два урока в 9 классе
            for (int i = 0; i < 2; i++)
            {
                lessons.Add(new Lesson(teachers[20], classes[13], subjects[16]));
                lessons.Add(new Lesson(teachers[20], classes[14], subjects[16]));
                lessons.Add(new Lesson(teachers[20], classes[15], subjects[16]));
            }
            lesEdit.Add(new LessonEditor(new Lesson(teachers[20], classes[13], subjects[16]), 2));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[20], classes[14], subjects[16]), 2));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[20], classes[15], subjects[16]), 2));

            for (int i = 0; i < 2; i++)  // 2 урока истории
            {
                lessons.Add(new Lesson(teachers[4], classes[1], subjects[6]));
                lessons.Add(new Lesson(teachers[4], classes[2], subjects[6]));
                lessons.Add(new Lesson(teachers[4], classes[3], subjects[6]));
                // 6 класс
                lessons.Add(new Lesson(teachers[4], classes[4], subjects[6]));
                lessons.Add(new Lesson(teachers[4], classes[5], subjects[6]));
                lessons.Add(new Lesson(teachers[4], classes[6], subjects[6]));
                // 7 класс
                lessons.Add(new Lesson(teachers[17], classes[7], subjects[6]));
                lessons.Add(new Lesson(teachers[17], classes[8], subjects[6]));
                lessons.Add(new Lesson(teachers[17], classes[9], subjects[6]));
                // 8 класс
                lessons.Add(new Lesson(teachers[17], classes[10], subjects[6]));
                lessons.Add(new Lesson(teachers[17], classes[11], subjects[6]));
                lessons.Add(new Lesson(teachers[17], classes[12], subjects[6]));
                // 9 класс
                lessons.Add(new Lesson(teachers[26], classes[13], subjects[6]));
                lessons.Add(new Lesson(teachers[26], classes[14], subjects[6]));
                lessons.Add(new Lesson(teachers[26], classes[15], subjects[6]));
            }
            lesEdit.Add(new LessonEditor(new Lesson(teachers[4], classes[1], subjects[6]), 2));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[4], classes[2], subjects[6]), 2));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[4], classes[3], subjects[6]), 2));
            // 6 класс
            lesEdit.Add(new LessonEditor(new Lesson(teachers[4], classes[4], subjects[6]), 2));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[4], classes[5], subjects[6]), 2));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[4], classes[6], subjects[6]), 2));
            // 7 класс
            lesEdit.Add(new LessonEditor(new Lesson(teachers[17], classes[7], subjects[6]), 2));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[17], classes[8], subjects[6]), 2));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[17], classes[9], subjects[6]), 2));
            // 8 класс
            lesEdit.Add(new LessonEditor(new Lesson(teachers[17], classes[10], subjects[6]), 2));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[17], classes[11], subjects[6]), 2));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[17], classes[12], subjects[6]), 2));
            // 9 класс
            lesEdit.Add(new LessonEditor(new Lesson(teachers[26], classes[13], subjects[6]), 2));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[26], classes[14], subjects[6]), 2));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[26], classes[15], subjects[6]), 2));

            // 1 урок обществознания 
            lessons.Add(new Lesson(teachers[4], classes[1], subjects[7]));
            lessons.Add(new Lesson(teachers[4], classes[2], subjects[7]));
            lessons.Add(new Lesson(teachers[4], classes[3], subjects[7]));
            // 6 класс
            lessons.Add(new Lesson(teachers[4], classes[4], subjects[7]));
            lessons.Add(new Lesson(teachers[4], classes[5], subjects[7]));
            lessons.Add(new Lesson(teachers[4], classes[6], subjects[7]));
            // 7 класс
            lessons.Add(new Lesson(teachers[17], classes[7], subjects[7]));
            lessons.Add(new Lesson(teachers[17], classes[8], subjects[7]));
            lessons.Add(new Lesson(teachers[17], classes[9], subjects[7]));
            // 8 класс
            lessons.Add(new Lesson(teachers[17], classes[10], subjects[7]));
            lessons.Add(new Lesson(teachers[17], classes[11], subjects[7]));
            lessons.Add(new Lesson(teachers[17], classes[12], subjects[7]));
            // 9 класс
            lessons.Add(new Lesson(teachers[26], classes[13], subjects[7]));
            lessons.Add(new Lesson(teachers[26], classes[14], subjects[7]));
            lessons.Add(new Lesson(teachers[26], classes[15], subjects[7]));

            lesEdit.Add(new LessonEditor(new Lesson(teachers[4], classes[1], subjects[7]), 1));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[4], classes[2], subjects[7]), 1));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[4], classes[3], subjects[7]), 1));
            // 6 класс
            lesEdit.Add(new LessonEditor(new Lesson(teachers[4], classes[4], subjects[7]), 1));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[4], classes[5], subjects[7]), 1));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[4], classes[6], subjects[7]), 1));
            // 7 класс
            lesEdit.Add(new LessonEditor(new Lesson(teachers[17], classes[7], subjects[7]), 1));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[17], classes[8], subjects[7]), 1));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[17], classes[9], subjects[7]), 1));
            // 8 класс
            lesEdit.Add(new LessonEditor(new Lesson(teachers[17], classes[10], subjects[7]), 1));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[17], classes[11], subjects[7]), 1));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[17], classes[12], subjects[7]), 1));
            // 9 класс
            lesEdit.Add(new LessonEditor(new Lesson(teachers[26], classes[13], subjects[7]), 1));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[26], classes[14], subjects[7]), 1));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[26], classes[15], subjects[7]), 1));

            // один урок географии
            lessons.Add(new Lesson(teachers[5], classes[1], subjects[8]));
            lessons.Add(new Lesson(teachers[5], classes[2], subjects[8]));
            lessons.Add(new Lesson(teachers[5], classes[3], subjects[8]));

            lesEdit.Add(new LessonEditor(new Lesson(teachers[5], classes[1], subjects[8]), 1));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[5], classes[2], subjects[8]), 1));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[5], classes[3], subjects[8]), 1));
            // 6 класс
            lessons.Add(new Lesson(teachers[5], classes[4], subjects[8]));
            lessons.Add(new Lesson(teachers[5], classes[5], subjects[8]));
            lessons.Add(new Lesson(teachers[5], classes[6], subjects[8]));

            lesEdit.Add(new LessonEditor(new Lesson(teachers[5], classes[4], subjects[8]), 1));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[5], classes[5], subjects[8]), 1));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[5], classes[6], subjects[8]), 1));
            for (int i = 0; i < 2; i++)  // 2 урока география 7 класс
            {
                lessons.Add(new Lesson(teachers[5], classes[7], subjects[8]));
                lessons.Add(new Lesson(teachers[5], classes[8], subjects[8]));
                lessons.Add(new Lesson(teachers[5], classes[9], subjects[8]));
                // 8 класс
                lessons.Add(new Lesson(teachers[27], classes[10], subjects[8]));
                lessons.Add(new Lesson(teachers[27], classes[11], subjects[8]));
                lessons.Add(new Lesson(teachers[27], classes[12], subjects[8]));
                // 9 класс
                lessons.Add(new Lesson(teachers[27], classes[13], subjects[8]));
                lessons.Add(new Lesson(teachers[27], classes[14], subjects[8]));
                lessons.Add(new Lesson(teachers[27], classes[15], subjects[8]));
            }
            lesEdit.Add(new LessonEditor(new Lesson(teachers[5], classes[7], subjects[8]), 2));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[5], classes[8], subjects[8]), 2));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[5], classes[9], subjects[8]), 2));
            // 8 класс
            lesEdit.Add(new LessonEditor(new Lesson(teachers[27], classes[10], subjects[8]), 2));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[27], classes[11], subjects[8]), 2));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[27], classes[12], subjects[8]), 2));
            // 9 класс
            lesEdit.Add(new LessonEditor(new Lesson(teachers[27], classes[13], subjects[8]), 2));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[27], classes[14], subjects[8]), 2));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[27], classes[15], subjects[8]), 2));

            // 2 урока физики
            for (int i = 0; i < 2; i++)  
            {
                // 7 класс
                lessons.Add(new Lesson(teachers[16], classes[7], subjects[14]));
                lessons.Add(new Lesson(teachers[16], classes[8], subjects[14]));
                lessons.Add(new Lesson(teachers[16], classes[9], subjects[14]));
                // 8 класс
                lessons.Add(new Lesson(teachers[16], classes[10], subjects[14]));
                lessons.Add(new Lesson(teachers[16], classes[11], subjects[14]));
                lessons.Add(new Lesson(teachers[16], classes[12], subjects[14]));
                // 9 класс
                lessons.Add(new Lesson(teachers[16], classes[13], subjects[14]));
                lessons.Add(new Lesson(teachers[16], classes[14], subjects[14]));
                lessons.Add(new Lesson(teachers[16], classes[15], subjects[14]));
            }
            // 7 класс
            lesEdit.Add(new LessonEditor(new Lesson(teachers[16], classes[7], subjects[14]), 2));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[16], classes[8], subjects[14]), 2));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[16], classes[9], subjects[14]), 2));
            // 8 класс
            lesEdit.Add(new LessonEditor(new Lesson(teachers[16], classes[10], subjects[14]), 2));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[16], classes[11], subjects[14]), 2));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[16], classes[12], subjects[14]), 2));
            // 9 класс
            lesEdit.Add(new LessonEditor(new Lesson(teachers[16], classes[13], subjects[14]), 2));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[16], classes[14], subjects[14]), 2));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[16], classes[15], subjects[14]), 2));

            // 2 урока химии 
            for (int i = 0; i < 2; i++)
            {
                // 8 класс
                lessons.Add(new Lesson(teachers[21], classes[10], subjects[15]));
                lessons.Add(new Lesson(teachers[21], classes[11], subjects[15]));
                lessons.Add(new Lesson(teachers[21], classes[12], subjects[15]));
                // 9 класс
                lessons.Add(new Lesson(teachers[21], classes[13], subjects[15]));
                lessons.Add(new Lesson(teachers[21], classes[14], subjects[15]));
                lessons.Add(new Lesson(teachers[21], classes[15], subjects[15]));
            }
            // 8 класс
            lesEdit.Add(new LessonEditor(new Lesson(teachers[21], classes[10], subjects[15]), 2));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[21], classes[11], subjects[15]), 2));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[21], classes[12], subjects[15]), 2));
            // 9 класс
            lesEdit.Add(new LessonEditor(new Lesson(teachers[21], classes[13], subjects[15]), 2));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[21], classes[14], subjects[15]), 2));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[21], classes[15], subjects[15]), 2));

            // один урок Биологии
            lessons.Add(new Lesson(teachers[6], classes[1], subjects[9]));
            lessons.Add(new Lesson(teachers[6], classes[2], subjects[9]));
            lessons.Add(new Lesson(teachers[6], classes[3], subjects[9]));
            // 6 класс
            lessons.Add(new Lesson(teachers[6], classes[4], subjects[9]));
            lessons.Add(new Lesson(teachers[6], classes[5], subjects[9]));
            lessons.Add(new Lesson(teachers[6], classes[6], subjects[9]));
            // один урок Биологии
            lesEdit.Add(new LessonEditor(new Lesson(teachers[6], classes[1], subjects[9]), 1));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[6], classes[2], subjects[9]), 1));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[6], classes[3], subjects[9]), 1));
            // 6 класс
            lesEdit.Add(new LessonEditor(new Lesson(teachers[6], classes[4], subjects[9]), 1));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[6], classes[5], subjects[9]), 1));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[6], classes[6], subjects[9]), 1));

            // 2 урока биологии 7 класс
            for (int i = 0; i < 2; i++)
            {
                lessons.Add(new Lesson(teachers[6], classes[7], subjects[9]));
                lessons.Add(new Lesson(teachers[6], classes[8], subjects[9]));
                lessons.Add(new Lesson(teachers[6], classes[9], subjects[9]));
                // 8 класс
                lessons.Add(new Lesson(teachers[28], classes[10], subjects[9]));
                lessons.Add(new Lesson(teachers[28], classes[11], subjects[9]));
                lessons.Add(new Lesson(teachers[28], classes[12], subjects[9]));
                // 9 класс
                lessons.Add(new Lesson(teachers[28], classes[13], subjects[9]));
                lessons.Add(new Lesson(teachers[28], classes[14], subjects[9]));
                lessons.Add(new Lesson(teachers[28], classes[15], subjects[9]));
            }
            lesEdit.Add(new LessonEditor(new Lesson(teachers[6], classes[7], subjects[9]), 2));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[6], classes[8], subjects[9]), 2));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[6], classes[9], subjects[9]), 2));
            // 8 класс
            lesEdit.Add(new LessonEditor(new Lesson(teachers[28], classes[10], subjects[9]), 2));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[28], classes[11], subjects[9]), 2));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[28], classes[12], subjects[9]), 2));
            // 9 класс
            lesEdit.Add(new LessonEditor(new Lesson(teachers[28], classes[13], subjects[9]), 2));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[28], classes[14], subjects[9]), 2));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[28], classes[15], subjects[9]), 2));

            // один урок Музыки
            lessons.Add(new Lesson(teachers[7], classes[1], subjects[10]));
            lessons.Add(new Lesson(teachers[7], classes[2], subjects[10]));
            lessons.Add(new Lesson(teachers[7], classes[3], subjects[10]));
            // 6 класс
            lessons.Add(new Lesson(teachers[7], classes[4], subjects[10]));
            lessons.Add(new Lesson(teachers[7], classes[5], subjects[10]));
            lessons.Add(new Lesson(teachers[7], classes[6], subjects[10]));
            // 7 класс
            lessons.Add(new Lesson(teachers[7], classes[7], subjects[10]));
            lessons.Add(new Lesson(teachers[7], classes[8], subjects[10]));
            lessons.Add(new Lesson(teachers[7], classes[9], subjects[10]));

            // один урок Музыки
            lesEdit.Add(new LessonEditor(new Lesson(teachers[7], classes[1], subjects[10]), 1));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[7], classes[2], subjects[10]), 1));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[7], classes[3], subjects[10]), 1));
            // 6 класс
            lesEdit.Add(new LessonEditor(new Lesson(teachers[7], classes[4], subjects[10]), 1));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[7], classes[5], subjects[10]), 1));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[7], classes[6], subjects[10]), 1));
            // 7 класс
            lesEdit.Add(new LessonEditor(new Lesson(teachers[7], classes[7], subjects[10]), 1));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[7], classes[8], subjects[10]), 1));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[7], classes[9], subjects[10]), 1));


            // один урок ИЗО
            lessons.Add(new Lesson(teachers[8], classes[1], subjects[11]));
            lessons.Add(new Lesson(teachers[8], classes[2], subjects[11]));
            lessons.Add(new Lesson(teachers[8], classes[3], subjects[11]));
            // 6 класс
            lessons.Add(new Lesson(teachers[8], classes[4], subjects[11]));
            lessons.Add(new Lesson(teachers[8], classes[5], subjects[11]));
            lessons.Add(new Lesson(teachers[8], classes[6], subjects[11]));
            // 7 класс
            lessons.Add(new Lesson(teachers[8], classes[7], subjects[11]));
            lessons.Add(new Lesson(teachers[8], classes[8], subjects[11]));
            lessons.Add(new Lesson(teachers[8], classes[9], subjects[11]));
            // 8 класс
            lessons.Add(new Lesson(teachers[8], classes[10], subjects[11]));
            lessons.Add(new Lesson(teachers[8], classes[11], subjects[11]));
            lessons.Add(new Lesson(teachers[8], classes[12], subjects[11]));
            // 9 класс
            lessons.Add(new Lesson(teachers[8], classes[13], subjects[11]));
            lessons.Add(new Lesson(teachers[8], classes[14], subjects[11]));
            lessons.Add(new Lesson(teachers[8], classes[15], subjects[11]));

            // один урок ИЗО
            lesEdit.Add(new LessonEditor(new Lesson(teachers[8], classes[1], subjects[11]), 1));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[8], classes[2], subjects[11]), 1));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[8], classes[3], subjects[11]), 1));
            // 6 класс
            lesEdit.Add(new LessonEditor(new Lesson(teachers[8], classes[4], subjects[11]), 1));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[8], classes[5], subjects[11]), 1));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[8], classes[6], subjects[11]), 1));
            // 7 класс
            lesEdit.Add(new LessonEditor(new Lesson(teachers[8], classes[7], subjects[11]), 1));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[8], classes[8], subjects[11]), 1));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[8], classes[9], subjects[11]), 1));
            // 8 класс
            lesEdit.Add(new LessonEditor(new Lesson(teachers[8], classes[10], subjects[11]), 1));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[8], classes[11], subjects[11]), 1));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[8], classes[12], subjects[11]), 1));
            // 9 класс
            lesEdit.Add(new LessonEditor(new Lesson(teachers[8], classes[13], subjects[11]), 1));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[8], classes[14], subjects[11]), 1));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[8], classes[15], subjects[11]), 1));

            for (int i = 0; i < 2; i++)  // два урока технологии
            {
                lessons.Add(new Lesson(teachers[9], classes[1], subjects[12]));
                lessons.Add(new Lesson(teachers[9], classes[2], subjects[12]));
                lessons.Add(new Lesson(teachers[9], classes[3], subjects[12]));
                // 6 класс
                lessons.Add(new Lesson(teachers[9], classes[4], subjects[12]));
                lessons.Add(new Lesson(teachers[9], classes[5], subjects[12]));
                lessons.Add(new Lesson(teachers[9], classes[6], subjects[12]));
                // 7 класс
                lessons.Add(new Lesson(teachers[9], classes[7], subjects[12]));
                lessons.Add(new Lesson(teachers[9], classes[8], subjects[12]));
                lessons.Add(new Lesson(teachers[9], classes[9], subjects[12]));
            }
            lesEdit.Add(new LessonEditor(new Lesson(teachers[9], classes[1], subjects[12]), 2));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[9], classes[2], subjects[12]), 2));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[9], classes[3], subjects[12]), 2));
            // 6 класс
            lesEdit.Add(new LessonEditor(new Lesson(teachers[9], classes[4], subjects[12]), 2));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[9], classes[5], subjects[12]), 2));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[9], classes[6], subjects[12]), 2));
            // 7 класс
            lesEdit.Add(new LessonEditor(new Lesson(teachers[9], classes[7], subjects[12]), 2));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[9], classes[8], subjects[12]), 2));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[9], classes[9], subjects[12]), 2));

            for (int i = 0; i < 3; i++)  // три урока физкультуры
            {
                lessons.Add(new Lesson(teachers[10], classes[1], subjects[13]));
                lessons.Add(new Lesson(teachers[10], classes[2], subjects[13]));
                lessons.Add(new Lesson(teachers[10], classes[3], subjects[13]));
                // 6 класс
                lessons.Add(new Lesson(teachers[10], classes[4], subjects[13]));
                lessons.Add(new Lesson(teachers[10], classes[5], subjects[13]));
                lessons.Add(new Lesson(teachers[10], classes[6], subjects[13]));
                // 7 класс
                lessons.Add(new Lesson(teachers[22], classes[7], subjects[13]));
                lessons.Add(new Lesson(teachers[22], classes[8], subjects[13]));
                lessons.Add(new Lesson(teachers[22], classes[9], subjects[13]));
                // 8 класс
                lessons.Add(new Lesson(teachers[22], classes[10], subjects[13]));
                lessons.Add(new Lesson(teachers[22], classes[11], subjects[13]));
                lessons.Add(new Lesson(teachers[22], classes[12], subjects[13]));
                // 9 класс
                lessons.Add(new Lesson(teachers[29], classes[13], subjects[13]));
                lessons.Add(new Lesson(teachers[29], classes[14], subjects[13]));
                lessons.Add(new Lesson(teachers[29], classes[15], subjects[13]));
            }
            lesEdit.Add(new LessonEditor(new Lesson(teachers[10], classes[1], subjects[13]), 3));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[10], classes[2], subjects[13]), 3));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[10], classes[3], subjects[13]), 3));
            // 6 класс
            lesEdit.Add(new LessonEditor(new Lesson(teachers[10], classes[4], subjects[13]), 3));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[10], classes[5], subjects[13]), 3));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[10], classes[6], subjects[13]), 3));
            // 7 класс
            lesEdit.Add(new LessonEditor(new Lesson(teachers[22], classes[7], subjects[13]), 3));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[22], classes[8], subjects[13]), 3));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[22], classes[9], subjects[13]), 3));
            // 8 класс
            lesEdit.Add(new LessonEditor(new Lesson(teachers[22], classes[10], subjects[13]), 3));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[22], classes[11], subjects[13]), 3));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[22], classes[12], subjects[13]), 3));
            // 9 класс
            lesEdit.Add(new LessonEditor(new Lesson(teachers[29], classes[13], subjects[13]), 3));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[29], classes[14], subjects[13]), 3));
            lesEdit.Add(new LessonEditor(new Lesson(teachers[29], classes[15], subjects[13]), 3));

            #endregion
        }

        private void CalculationThread()
        {
            Generation gen = new Generation();
            rtbOutput.Invoke(new Action(() => rtbOutput.Text += gen.ToString()));
            for (int _try = 0; _try < Data.Instance.GenerationCount; _try++)
            {
                gen.Next();
                rtbOutput.Invoke(new Action(() => rtbOutput.Text += gen.ToString()));                
            }
            shedule = gen.BestSolution();
            teacherShedule = gen.TeacherTable();
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChooseFilePathToSave();
        }

        private void ChooseFilePathToSave()
        {
            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "Файлы генератора расписаний (*.gtf)|*.gtf",
                RestoreDirectory = true
            };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                FileName = sfd.FileName;
                Text = "Оболочка баз знаний : " + Path.GetFileNameWithoutExtension(FileName);
                Data.Instance.Name = Path.GetFileNameWithoutExtension(FileName);
                SaveFile();
            }
        }

        private void SaveFile()
        {
            using (FileStream fs = new FileStream(FileName, FileMode.Create))
            {
                bf.Serialize(fs, Data.Instance);
                MessageBox.Show("Сохранено успешно!");
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FileName))
                ChooseFilePathToSave();
            else
                SaveFile();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog()
            {
                Filter = "Файлы генератора расписаний (*.gtf)|*.gtf",
                RestoreDirectory = true
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileName = ofd.FileName;
                Text = "Файл генератора расписаний : " + Path.GetFileNameWithoutExtension(FileName);
                OpenFile();
            }
        }

        private void OpenFile()
        {
            using (FileStream fs = new FileStream(FileName, FileMode.Open))
            {
                try
                {
                    Data.Instance = (Data)bf.Deserialize(fs);
                }
                catch
                {
                    MessageBox.Show("Ошибка открытия файла");
                }
            }
        }

        private void экспортВExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (shedule != null)
                WorkWithExcel.ExportToExcel(shedule);
        }

        private void показатьЛогToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gbResults.Visible = !gbResults.Visible;
        }

        #region Plan Buttons
        private void btAddPlan_Click(object sender, EventArgs e)
        {
            var paef = new PlanAddEditForm();
            if (paef.ShowDialog() == DialogResult.OK)
            {
                LessonEditor additionalLe = paef.GetLe();
                Data.Instance.LessonEditors.Add(additionalLe);
                ChangesHappend = true;
            }
        }

        private void btChangePlan_Click(object sender, EventArgs e)
        {
            if (dgvPlan.SelectedCells.Count > 0)
            {
                var paef = new PlanAddEditForm(Data.Instance.LessonEditors[dgvPlan.SelectedCells[0].RowIndex]);
                if (paef.ShowDialog() == DialogResult.OK)
                {
                    LessonEditor changingLe = paef.GetLe();
                    Data.Instance.LessonEditors[dgvPlan.SelectedCells[0].RowIndex] = changingLe;
                    ChangesHappend = true;
                }
            }
        }

        private void btDelPlan_Click(object sender, EventArgs e)
        {
            if (dgvPlan.SelectedCells.Count > 0)
            {
                Data.Instance.LessonEditors.RemoveAt(dgvPlan.SelectedCells[0].RowIndex);
            }
        }
        #endregion

        private void настройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var settingsForm = new SettingsForm();
            settingsForm.ShowDialog();
        }

        private void расписаниеКлассовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ChangesHappend)
            {
                Data.Instance.Lessons.Clear();
                foreach (LessonEditor le in Data.Instance.LessonEditors)
                {
                    for (int i = 0; i < le.Count; i++)
                    {
                        Data.Instance.Lessons.Add(new Lesson(le.Lesson.Teacher, le.Lesson.Cls, le.Lesson.Subject));
                    }
                }
                ChangesHappend = false;
            }
            Thread t = new Thread(CalculationThread);
            t.Start();
        }

        private void предметыToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var subj = new SubjectForm();
            subj.ShowDialog();
        }

        private void классыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var clsForm = new ClassListForm();
            clsForm.ShowDialog();
        }

        private void учителяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var teachersList = new TeacherListForm();
            teachersList.ShowDialog();
        }

        private void полученноеРасписаниеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sheduleForm = new SheduleForm(shedule);
            sheduleForm.ShowDialog();
        }

        private void расписаниеУчителейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sheduleForm = new SheduleForm(teacherShedule);
            sheduleForm.ShowDialog();
        }
    }
}
