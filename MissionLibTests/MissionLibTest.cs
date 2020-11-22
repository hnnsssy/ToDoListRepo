using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MissionLib;

namespace MissionLibTests
{
    [TestClass]
    public class MissionLibTest
    {
        Missions missions;
        [TestInitialize]
        public void Init()
        {
            missions = new Missions();
        }
        

        [TestMethod]
        public void AddMission_Test()
        {          
            missions.AddMission(new Mission());
            Assert.AreEqual(1, missions.AllMissions.Count);
        }
        [TestMethod]
        public void RemoveMission_Test()
        {
            missions.AddMission(new Mission());
            missions.RemoveMission(missions.AllMissions[0]);
            Assert.AreEqual(0, missions.AllMissions.Count);
        }

        [TestMethod]
        public void ChangeCheckState_Test()
        {
            missions.AddMission(new Mission());
            missions.ChangeCheckState(0, true);
            Assert.AreEqual(true, missions.AllMissions[0].State);
        }

        [TestMethod]
        public void UpdateMission_Test()
        {
            missions.AddMission(new Mission());
            missions.UpdateMission(0, new Mission("test", DateTime.Now, DateTime.Now, true));
            Assert.AreEqual("test", missions.AllMissions[0].Title);
        }
    }
}
