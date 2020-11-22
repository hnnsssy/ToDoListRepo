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
    /**
     *@class Mission
     *Class Mission contains all info about mission.
     */
    [Serializable]
    public class Mission
    {
        public string Title { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public bool State { get; set; }

        /// @param title Missoion title
        /// @param startDate Missoion start date
        /// @param endDate Missoion end date
        /// @param bool Missoion state
        public Mission(string title, DateTime startDate, DateTime endDate, bool state)
        {
            Title = title;
            StartDate = startDate.ToString("dd.MM.yyyy");
            EndDate = endDate.ToString("dd.MM.yyyy");
            State = state;
        }
        /** Empty consctructor 
         */
        public Mission() { }

        /// @return string Title
        public override string ToString()
        {
            return $"{Title}";
        }
    }

    /**
     *@class Mission
     *Class Mission contains list of Missions and methods for change this list.
     */
    [Serializable]
    public class Missions
    {
        private List<Mission> missions;
        public List<Mission> AllMissions { get { return missions; } }

        /** Empty consctructor 
         */
        public Missions()
        {
            missions = new List<Mission>();
        }

        /// @param mission Mission for add.
        public void AddMission(Mission mission)
        {
            missions.Add(mission);
        }

        /// @param mission Mission for remove.
        public void RemoveMission(Mission mission)
        {
            missions.Remove(mission);
        }

        /// @param index Index of mission in list you want to change.
        /// @param newState New state for mission.
        public void ChangeCheckState(int index, bool newState)
        {
            missions[index].State = newState;
        }

        /// @param index Index of mission in list you want to update.
        /// @param mission Mission for replace.
        public void UpdateMission(int index, Mission mission)
        {
            missions[index] = mission;
        }
    }
}
