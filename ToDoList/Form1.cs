using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using MissionLib;

namespace ToDoList
{
    public partial class Form1 : Form
    {
        Serializer serializer;
        Missions missions;
        int selectedIndex;
        public Form1()
        {
            InitializeComponent();
            serializer = new Serializer();
            missions = new Missions();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                foreach (Mission item in serializer.Deserialize<List<Mission>>())
                    missions.AddMission(item);

                if (missions.AllMissions.Count > 0)
                    FillToDoList();
            }
            catch { }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            serializer.Serialize(missions.AllMissions);
        }

        private void FillToDoList()
        {
            toDoList.Items.Clear();
            foreach (Mission item in missions.AllMissions)
            {
                toDoList.Items.Add(item);
                if (item.State == true)
                    toDoList.SetItemChecked(toDoList.Items.Count - 1, true);
            }
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(FormStyle.Add, null);
            form2.ShowDialog();
            if (form2.DialogResult == DialogResult.OK)
            {
                missions.AddMission(form2.Mission);
                FillToDoList();
            }
        }

        private void toDoList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (toDoList.SelectedItem != null)
            {
                label_StartDt.Text = $"Start Date: {(toDoList.SelectedItem as Mission).StartDate}";
                label_EndDt.Text = $"End Date:  {(toDoList.SelectedItem as Mission).EndDate}";
                selectedIndex = toDoList.SelectedIndex;
            }
        }

        private void toDoList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
                missions.ChangeCheckState(e.Index, true);
            else if (e.NewValue == CheckState.Unchecked)
                missions.ChangeCheckState(e.Index, false);
        }

        private void button_Edit_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(FormStyle.Edit, toDoList.SelectedItem as Mission);
            selectedIndex = toDoList.SelectedIndex;
            form2.ShowDialog();
            if (form2.DialogResult == DialogResult.OK)
            {
                missions.UpdateMission(toDoList.SelectedIndex, form2.Mission);
                FillToDoList();
            }

            toDoList.SelectedIndex = selectedIndex;
        }

        private void button_Remove_Click(object sender, EventArgs e)
        {
            missions.RemoveMission(toDoList.SelectedItem as Mission);
            toDoList.Items.RemoveAt(selectedIndex);

            label_StartDt.Text = $"Start Date: ";
            label_EndDt.Text = $"End Date: ";
        }
    }
}
