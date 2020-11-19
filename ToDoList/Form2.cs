using MissionLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList
{
    public partial class Form2 : Form
    {
        public Mission Mission { get; set; }
        public Form2(FormStyle formStyle, Mission mission)
        {
            InitializeComponent();

            if(formStyle == FormStyle.Edit)
            {
                textBox_Title.Text = mission.Title;
                dateTimePicker_Start.Value = mission.StartDate;
                dateTimePicker_End.Value = mission.EndDate;
                Mission.State = mission.State;
            }
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            Mission = new Mission(textBox_Title.Text, dateTimePicker_Start.Value, dateTimePicker_End.Value, false);
            this.DialogResult = DialogResult.OK;
        }
    }
}
