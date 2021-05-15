using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ColorfulApp
{
    [XmlType(TypeName = "Class")]
    [Serializable]
    public class tClass
    {
        string name;
        int id;
        [XmlIgnore]
        Dictionary<int, Lesson> rasp;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }
        [XmlIgnore]
        public Dictionary<int, Lesson> Rasp
        {
            get
            {
                return rasp;
            }

            set
            {
                rasp = value;
            }
        }

        public tClass(string name, int id)
        {
            this.name = name;
            this.id = id;
            Rasp = new Dictionary<int, Lesson>();
        }
        public tClass()
        {
            id = -1;
            Rasp = new Dictionary<int, Lesson>();
        }
    }
}
