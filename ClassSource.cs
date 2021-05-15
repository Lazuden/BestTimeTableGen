using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTableGenerator
{
    public partial class MainForm : Form
    {
        Dictionary<int, Teacher> teachers;
        List<Class> Classes = new List<Class>();
        Generator test;
        public MainForm()
        {
            InitializeComponent();
            // супер мего быдло, но что поделаешь)
#region Subjects
            Subject math = new Subject("Математика", 11); 
            Subject russianLang = new Subject("Русский язык", 11); 
            Subject literature = new Subject("Литература", 7); 
            Subject foreignLanguage = new Subject("Иностранный язык", 10);
            Subject phisics = new Subject("Физика", 9);
            Subject chemistry = new Subject("Химия", 9);
            Subject history = new Subject("История", 8);
            Subject geography = new Subject("География", 6);
            Subject phisicalCulture = new Subject("Физкультура", 5);
            Subject technology = new Subject("Технология", 4);
            Subject drawing = new Subject("Черчение", 3);
            Subject painting = new Subject("Рисование", 2);
            Subject music = new Subject("Музыка", 1);
            Subject socialStudies = new Subject("Обществознание", 5);
            Subject algebra = new Subject("Алгебра", 11);
            Subject geometry = new Subject("Геометрия", 11);
            Subject biology = new Subject("Биология", 5);
#endregion
#region teachers
            teachers = new Dictionary<int, Teacher>();

            Teacher tcher = new Teacher("Фамилия1", "И", "Н");
            tcher.AddSubject(russianLang);
            tcher.AddSubject(literature);
            teachers.Add(1, tcher);

            tcher = new Teacher("Фамилия2", "И", "Н");
            tcher.AddSubject(russianLang);
            tcher.AddSubject(literature);
            teachers.Add(2, tcher);

            tcher = new Teacher("Фамилия3", "И", "Н");
            tcher.AddSubject(russianLang);
            tcher.AddSubject(literature);
            teachers.Add(3, tcher);

            tcher = new Teacher("Фамилия4", "И", "Н");
            tcher.AddSubject(foreignLanguage);
            teachers.Add(4, tcher);

            tcher = new Teacher("Фамилия5", "И", "Н");
            tcher.AddSubject(russianLang);
            tcher.AddSubject(literature);
            teachers.Add(5, tcher);

            tcher = new Teacher("Фамилия6", "И", "Н");
            tcher.AddSubject(foreignLanguage);
            teachers.Add(6, tcher);

            tcher = new Teacher("Фамилия7", "И", "Н");
            tcher.AddSubject(foreignLanguage);
            teachers.Add(7, tcher);

            tcher = new Teacher("Фамилия8", "И", "Н");
            tcher.AddSubject(history);
            tcher.AddSubject(socialStudies);
            teachers.Add(8, tcher);

            tcher = new Teacher("Фамилия9", "И", "Н");
            tcher.AddSubject(history);
            tcher.AddSubject(socialStudies);
            teachers.Add(9, tcher);

            tcher = new Teacher("Фамилия10", "И", "Н");
            tcher.AddSubject(history);
            tcher.AddSubject(socialStudies);
            teachers.Add(10, tcher);

            tcher = new Teacher("Фамилия11", "И", "Н");
            tcher.AddSubject(history);
            tcher.AddSubject(socialStudies);
            teachers.Add(11, tcher);

            tcher = new Teacher("Фамилия12", "И", "Н");
            tcher.AddSubject(math);
            tcher.AddSubject(algebra);
            tcher.AddSubject(geometry);
            teachers.Add(12, tcher);

            tcher = new Teacher("Фамилия13", "И", "Н");
            tcher.AddSubject(algebra);
            tcher.AddSubject(geometry);
            teachers.Add(13, tcher);

            tcher = new Teacher("Фамилия14", "И", "Н");
            tcher.AddSubject(math);
            tcher.AddSubject(algebra);
            tcher.AddSubject(geometry);
            teachers.Add(14, tcher);

            tcher = new Teacher("Фамилия15", "И", "Н");
            tcher.AddSubject(math);
            tcher.AddSubject(algebra);
            tcher.AddSubject(geometry);
            teachers.Add(15, tcher);

            tcher = new Teacher("Фамилия16", "И", "Н");
            tcher.AddSubject(phisics);
            teachers.Add(16, tcher);

            tcher = new Teacher("Фамилия17", "И", "Н");
            tcher.AddSubject(phisics);
            teachers.Add(17, tcher);

            tcher = new Teacher("Фамилия18", "И", "Н");
            tcher.AddSubject(geography);
            teachers.Add(18, tcher);

            tcher = new Teacher("Фамилия19", "И", "Н");
            tcher.AddSubject(biology);
            teachers.Add(19, tcher);

            tcher = new Teacher("Фамилия20", "И", "Н");
            tcher.AddSubject(chemistry);
            teachers.Add(20, tcher);

            tcher = new Teacher("Фамилия21", "И", "Н");
            tcher.AddSubject(music);
            teachers.Add(21, tcher);

            tcher = new Teacher("Фамилия22", "И", "Н");
            tcher.AddSubject(painting);
            teachers.Add(22, tcher);

            tcher = new Teacher("Фамилия23", "И", "Н");
            tcher.AddSubject(technology);
            teachers.Add(23, tcher);

            tcher = new Teacher("Фамилия24", "И", "Н");
            tcher.AddSubject(phisicalCulture);
            teachers.Add(24, tcher);

            tcher = new Teacher("Фамилия25", "И", "Н");
            tcher.AddSubject(phisicalCulture);
            teachers.Add(25, tcher);
            #endregion

            //===================================================
#region Classes

            Class cls = new Class("5А");
            cls.AddStudyLoad(new StudyLoad(russianLang, teachers[1], 5));
            cls.AddStudyLoad(new StudyLoad(literature, teachers[1], 3));
            cls.AddStudyLoad(new StudyLoad(foreignLanguage, teachers[6], 3));
            cls.AddStudyLoad(new StudyLoad(math, teachers[15], 5));
            cls.AddStudyLoad(new StudyLoad(history, teachers[11], 2));
            cls.AddStudyLoad(new StudyLoad(socialStudies, teachers[11], 1));
            cls.AddStudyLoad(new StudyLoad(geography, teachers[18], 1));
            cls.AddStudyLoad(new StudyLoad(biology, teachers[19], 1));
            cls.AddStudyLoad(new StudyLoad(music, teachers[21], 1));
            cls.AddStudyLoad(new StudyLoad(painting, teachers[22], 1));
            cls.AddStudyLoad(new StudyLoad(phisicalCulture, teachers[24], 3));

            Class cls2 = new Class("5Б");
            cls2.AddStudyLoad(new StudyLoad(russianLang, teachers[2], 5));
            cls2.AddStudyLoad(new StudyLoad(literature, teachers[2], 3));
            cls2.AddStudyLoad(new StudyLoad(foreignLanguage, teachers[6], 3));
            cls2.AddStudyLoad(new StudyLoad(math, teachers[13], 5));
            cls2.AddStudyLoad(new StudyLoad(history, teachers[11], 2));
            cls2.AddStudyLoad(new StudyLoad(socialStudies, teachers[11], 1));
            cls2.AddStudyLoad(new StudyLoad(geography, teachers[18], 1));
            cls2.AddStudyLoad(new StudyLoad(biology, teachers[19], 1));
            cls2.AddStudyLoad(new StudyLoad(music, teachers[21], 1));
            cls2.AddStudyLoad(new StudyLoad(painting, teachers[22], 1));
            cls2.AddStudyLoad(new StudyLoad(phisicalCulture, teachers[24], 3));

            Class cls3 = new Class("5В");
            cls3.AddStudyLoad(new StudyLoad(russianLang, teachers[3], 5));
            cls3.AddStudyLoad(new StudyLoad(literature, teachers[3], 3));
            cls3.AddStudyLoad(new StudyLoad(foreignLanguage, teachers[6], 3));
            cls3.AddStudyLoad(new StudyLoad(math, teachers[12], 5));
            cls3.AddStudyLoad(new StudyLoad(history, teachers[11], 2));
            cls3.AddStudyLoad(new StudyLoad(socialStudies, teachers[11], 1));
            cls3.AddStudyLoad(new StudyLoad(geography, teachers[18], 1));
            cls3.AddStudyLoad(new StudyLoad(biology, teachers[19], 1));
            cls3.AddStudyLoad(new StudyLoad(music, teachers[21], 1));
            cls3.AddStudyLoad(new StudyLoad(painting, teachers[22], 1));
            cls3.AddStudyLoad(new StudyLoad(phisicalCulture, teachers[24], 3));

            Class cls4 = new Class("5Г");
            cls4.AddStudyLoad(new StudyLoad(russianLang, teachers[2], 5));
            cls4.AddStudyLoad(new StudyLoad(literature, teachers[2], 3));
            cls4.AddStudyLoad(new StudyLoad(foreignLanguage, teachers[6], 3));
            cls4.AddStudyLoad(new StudyLoad(math, teachers[13], 5));
            cls4.AddStudyLoad(new StudyLoad(history, teachers[11], 2));
            cls4.AddStudyLoad(new StudyLoad(socialStudies, teachers[11], 1));
            cls4.AddStudyLoad(new StudyLoad(geography, teachers[18], 1));
            cls4.AddStudyLoad(new StudyLoad(biology, teachers[19], 1));
            cls4.AddStudyLoad(new StudyLoad(music, teachers[21], 1));
            cls4.AddStudyLoad(new StudyLoad(painting, teachers[22], 1));
            cls4.AddStudyLoad(new StudyLoad(phisicalCulture, teachers[24], 3));

            Class cls5 = new Class("6А");
            cls5.AddStudyLoad(new StudyLoad(russianLang, teachers[1], 6));
            cls5.AddStudyLoad(new StudyLoad(literature, teachers[1], 3));
            cls5.AddStudyLoad(new StudyLoad(foreignLanguage, teachers[7], 3));
            cls5.AddStudyLoad(new StudyLoad(math, teachers[14], 5));
            cls5.AddStudyLoad(new StudyLoad(history, teachers[8], 2));
            cls5.AddStudyLoad(new StudyLoad(socialStudies, teachers[8], 1));
            cls5.AddStudyLoad(new StudyLoad(geography, teachers[18], 1));
            cls5.AddStudyLoad(new StudyLoad(biology, teachers[19], 1));
            cls5.AddStudyLoad(new StudyLoad(music, teachers[21], 1));
            cls5.AddStudyLoad(new StudyLoad(painting, teachers[22], 1));
            cls5.AddStudyLoad(new StudyLoad(phisicalCulture, teachers[25], 3));

            Class cls6 = new Class("6Б");
            cls6.AddStudyLoad(new StudyLoad(russianLang, teachers[2], 6));
            cls6.AddStudyLoad(new StudyLoad(literature, teachers[2], 3));
            cls6.AddStudyLoad(new StudyLoad(foreignLanguage, teachers[7], 3));
            cls6.AddStudyLoad(new StudyLoad(math, teachers[14], 5));
            cls6.AddStudyLoad(new StudyLoad(history, teachers[8], 2));
            cls6.AddStudyLoad(new StudyLoad(socialStudies, teachers[8], 1));
            cls6.AddStudyLoad(new StudyLoad(geography, teachers[18], 1));
            cls6.AddStudyLoad(new StudyLoad(biology, teachers[19], 1));
            cls6.AddStudyLoad(new StudyLoad(music, teachers[21], 1));
            cls6.AddStudyLoad(new StudyLoad(painting, teachers[22], 1));
            cls6.AddStudyLoad(new StudyLoad(phisicalCulture, teachers[25], 3));

            Class cls7 = new Class("6В");
            cls7.AddStudyLoad(new StudyLoad(russianLang, teachers[3], 6));
            cls7.AddStudyLoad(new StudyLoad(literature, teachers[3], 3));
            cls7.AddStudyLoad(new StudyLoad(foreignLanguage, teachers[7], 3));
            cls7.AddStudyLoad(new StudyLoad(math, teachers[14], 5));
            cls7.AddStudyLoad(new StudyLoad(history, teachers[8], 2));
            cls7.AddStudyLoad(new StudyLoad(socialStudies, teachers[8], 1));
            cls7.AddStudyLoad(new StudyLoad(geography, teachers[18], 1));
            cls7.AddStudyLoad(new StudyLoad(biology, teachers[19], 1));
            cls7.AddStudyLoad(new StudyLoad(music, teachers[21], 1));
            cls7.AddStudyLoad(new StudyLoad(painting, teachers[22], 1));
            cls7.AddStudyLoad(new StudyLoad(phisicalCulture, teachers[25], 3));

            Class cls8 = new Class("6Г");
            cls8.AddStudyLoad(new StudyLoad(russianLang, teachers[5], 6));
            cls8.AddStudyLoad(new StudyLoad(literature, teachers[5], 3));
            cls8.AddStudyLoad(new StudyLoad(foreignLanguage, teachers[6], 3));
            cls8.AddStudyLoad(new StudyLoad(math, teachers[14], 5));
            cls8.AddStudyLoad(new StudyLoad(history, teachers[8], 2));
            cls8.AddStudyLoad(new StudyLoad(socialStudies, teachers[8], 1));
            cls8.AddStudyLoad(new StudyLoad(geography, teachers[18], 1));
            cls8.AddStudyLoad(new StudyLoad(biology, teachers[19], 1));
            cls8.AddStudyLoad(new StudyLoad(music, teachers[21], 1));
            cls8.AddStudyLoad(new StudyLoad(painting, teachers[22], 1));
            cls8.AddStudyLoad(new StudyLoad(phisicalCulture, teachers[25], 3));
            #endregion
            Classes.Add(cls);
            Classes.Add(cls2);
            Classes.Add(cls3);
            Classes.Add(cls4);
            Classes.Add(cls5);
            Classes.Add(cls6);
            Classes.Add(cls7);
            Classes.Add(cls8);

        }

        private void btGenerate_Click(object sender, EventArgs e)
        {
            TestGenerateMany();
        }

        private void TestGenerateOne()
        {
            test = new Generator(Classes, new TeachersLoad(30, teachers));
            test.GenerateAll();
            tbResult.Text = test.Show(0);
            tbResult2.Text = test.Show(1);
            if (test.isCollided())
                MessageBox.Show("Ошибка колизии");
            MessageBox.Show("Фитнесс функциия = " + test.FitnessFunction());
        }

        private void TestGenerateMany()
        {
            int super = 0;
            string s = "";
            pgGener.Maximum = 99;
            while (super < 100)
            {
                pgGener.Value = super;
                int k = 0, collisCount = 0;
                while (k < 1000)
                {
                    test = new Generator(Classes, new TeachersLoad(30, teachers));
                    test.GenerateAll();
                    if (test.isCollided())
                        collisCount++;
                    k++;
                }
                //tbResult.Text += "Сгенерировано расписаний " + k + " и с коллизиями " + collisCount + " из них\n";
                s += collisCount + "\n";
                super++;
            }
            tbResult.Text = s;
        }

        private void TestGenerateWorked()
        {
            bool collided = true;
            int k = 0;
            while (collided)
            {
                k++;
                test = new Generator(Classes, new TeachersLoad(30, teachers));
                test.GenerateAll();
                collided = test.isCollided();
                tbResult.Text = k.ToString() + '\n' + test.FitnessFunction();
            }
            tbResult2.Text = "";
            for (int i = 0; i< 8; i++)
            {
                tbResult2.Text += test.Show(i);
            }

        }
    }
}
