﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ToDoList
{
    /**
     @class Serializer
    Class for serialization objects to XML file.
     */
    public class Serializer
    {
        /// @param T Object for deserialize
        /// @return T
        public T Deserialize<T>() where T : class
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
            using (FileStream stream = File.Open("missions.xml", FileMode.Open))
            {
                return (T)xmlSerializer.Deserialize(stream);
            }
        }

        /// @param T Object for object to serialize
        public void Serialize<T>(T ObjectToSerialize)
        {
            XmlSerializer formatter = new XmlSerializer(ObjectToSerialize.GetType());
            if (!File.Exists("missions.xml"))
                File.Create("missions.xml").Dispose();
            using (FileStream fs = new FileStream("missions.xml", FileMode.Truncate))
            {
                formatter.Serialize(fs, ObjectToSerialize);
            }
        }
    }
}
