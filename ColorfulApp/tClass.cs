using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace ColorfulApp
{
    [XmlType(TypeName = "Class")]
    [Serializable]
    public class tClass
    {
        public tClass(string name, int id)
        {
            Name = name;
            Id = id;
            Rasp = new Dictionary<int, Lesson>();
        }

        //todo: используется?
        public tClass()
        {
            Id = -1;
            Rasp = new Dictionary<int, Lesson>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        // todo: не используется.
        [XmlIgnore]
        public Dictionary<int, Lesson> Rasp { get; set; }
    }
}
