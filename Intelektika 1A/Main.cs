using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace Intelektika_1A
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            UpdateInterface();
            sportText.SelectedIndex = 0;
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            var s = new Stopwatch();
            if (string.IsNullOrEmpty(neibCombo.Text))
            {
                MessageBox.Show("Please select number of neighbour");
                return;
            }
            if (string.IsNullOrEmpty(pointCombo.Text))
            {
                MessageBox.Show("Please select a point to calculate");
                return;
            }
            if (string.IsNullOrEmpty(sportText.Text))
            {
                MessageBox.Show("Please select sport");
            }
            if (sportText.Text=="----------")
            {
                Method2 method2 = new Method2();
                string pointComboText = pointCombo.Text;
                string[] split = pointComboText.Split(':');
                s.Start();
                List<string> calResult = method2.Calculate(split[1], split[3], neibCombo.Text);
                s.Stop();
                timeLabel.Text = "alculation time: " + s.ElapsedMilliseconds + " ms";
                if (calResult[0] == "No")
                {
                    MessageBox.Show("There is no valid position or sport");
                }
                else
                {
                    DialogResult dr = MessageBox.Show($"Position is {calResult[0]}, sport is {calResult[1]} do you want to save it ?", "Result", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        Database database = new Database();
                        database.AddPerson(split[1], split[3], calResult[0], calResult[1]);
                        database.DeletePerson(split[1], split[3]);
                        UpdateInterface();
                    }
                }
            }
            else
            {
                Method method = new Method();
                string pointComboText = pointCombo.Text;
                string[] split = pointComboText.Split(':');
                s.Start();
                string calResult = method.Calculate(sportText.Text, split[1], split[3], neibCombo.Text);
                s.Stop();
                timeLabel.Text = "alculation time: " + s.ElapsedMilliseconds + " ms";
                if (calResult =="No")
                {
                    MessageBox.Show("There is no valid position");
                }
                else
                {
                    DialogResult dr = MessageBox.Show($"Position is {calResult} do you want to save it ?", "Result", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        Database database = new Database();
                        database.AddPerson(split[1],split[3], sportText.Text, calResult);
                        database.DeletePerson(split[1], split[3]);
                        UpdateInterface();
                    }
                }
            }
        }
        public void UpdateInterface()
        {
            sportView.Items.Clear();
            notSportView.Items.Clear();
            neibCombo.Items.Clear();
            pointCombo.Items.Clear();
            neibCombo.Text = null;
            pointCombo.Text = null;
            Database database = new Database();
            List<Sport> sports = database.GetData();
            for (int i = 1; i <= sports.Count; i++)
            {
                neibCombo.Items.Add(i);
            }
            for (int i = 0; i < sports.Count; i++)
            {
                sportView.Items.Add(sports[i].height);
                sportView.Items[i].SubItems.Add(sports[i].weight);
                sportView.Items[i].SubItems.Add(sports[i].sport);
                sportView.Items[i].SubItems.Add(sports[i].position);
            }
            List<Sport> notSport = database.GetSportData();
            for (int i = 0; i < notSport.Count; i++)
            {
                notSportView.Items.Add(notSport[i].height);
                notSportView.Items[i].SubItems.Add(notSport[i].weight);
            }
            for (int i =0; i<notSport.Count;i++)
            {
                string player = "Height:" + notSport[i].height+ ": " + "Weight:" + notSport[i].weight;
                pointCombo.Items.Add(player);
            }
        }

        private void sportText_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sportText.Text == "----------")
            {
                UpdateInterface();
            }
            else
            {
                Database database = new Database();
                List<Sport> counter = database.GetSpecificData(sportText.Text);
                neibCombo.Items.Clear();
                neibCombo.Text = null;
                for (int i = 1; i <= counter.Count; i++)
                {
                    neibCombo.Items.Add(i);
                }
            }
        }
    }

}
