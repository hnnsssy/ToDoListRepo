using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MissionLib
{
    [Serializable]
    public class Mission
    {
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool State { get; set; }

        public Mission(string title, DateTime startDate, DateTime endDate, bool state) 
        {
            Title = title;
            StartDate = startDate;
            EndDate = endDate;
            State = state;
        }
        public Mission() { }

        public override string ToString()
        {
            return $"{Title}";
        }
    }

    [Serializable]
    public class Missions
    {
        private List<Mission> missions;
        public List<Mission> AllMissions { get { return missions; } }

        public Missions()
        {
            missions = new List<Mission>();
        }

        public void AddMission(Mission mission)
        {
            missions.Add(mission);
        }

        public void RemoveMission(Mission mission)
        {
            missions.Remove(mission);
        }

        public void ChangeCheckState(int index, bool newState)
        {
            missions[index].State = newState;
        }

        public void UpdateMission(int index, Mission mission)
        {
            missions[index] = mission;
        }
    }

    public class Serializer
    {
        public T Deserialize<T>() where T : class
        {
            XmlSerializer ser = new XmlSerializer(typeof(T));

            using (Stream stream = File.Open("missions.xml", FileMode.Open))
            {
                return (T)ser.Deserialize(stream);
            }
        }
        public void Serialize<T>(T ObjectToSerialize)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(ObjectToSerialize.GetType());
            using (FileStream fs = new FileStream("missions.xml", FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(fs, ObjectToSerialize);
            }
        }
    }
}
