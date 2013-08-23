using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Collections.Generic;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> team_members = new List<string>();
        int count = 0;

        private void listViewEx1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            if (count < Convert.ToInt32(textBox1.Text))
            {
                team_members.Add(textBox3.Text);
                listBox1.Items.Add(textBox3.Text);
                count = count + 1;
            }
            else
            {
                MessageBox.Show("U cannot add more");
            }
            textBox3.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //team_members.Count = Convert.ToInt32(textBox2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int seed = 1;
            Random rand = new Random(seed);

    //        for (int idx = 1; idx <= Convert.ToInt32(textBox2.Text); idx++)
      //      {
        //        int val = rand.Next(1, (Convert.ToInt32(textBox1.Text)));
          //      
            //    team_members.RemoveAt(val);
            //}

           // for (int i = 1; i <= Convert.ToInt32(textBox2.Text); i++)
           // {
            for (int i = Convert.ToInt32(textBox1.Text); i >= 0; i--)
            {
                int val = rand.Next(1, (Convert.ToInt32(textBox1.Text)));
                string name;
                if (team_members[val] != "-1")
                {
                    name = team_members[val];
                    listBox2.Items.Add(name);
                    team_members[val] = "-1";
                }
            }
            //}

//            int perTeamCount = Convert.ToInt32(textBox1.Text) / Convert.ToInt32(textBox2.Text);

  /*          for (int y = 0; y < perTeamCount; y++)
            {
                ListViewItem members = new ListViewItem();
                for (int j = 0; j < 2; j++)
                {
                    members.SubItems.Add(j.ToString());
                    //int val = rand.Next(1, (Convert.ToInt32(textBox1.Text)));
                    members.SubItems.Add(team_members[j]);
                    team_members.RemoveAt(j);
                }
                this.listViewEx1.Items.Add(members);
            }*/

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if(textBox3.Text != "")
                button2.Enabled = true;
        }
    }
}
