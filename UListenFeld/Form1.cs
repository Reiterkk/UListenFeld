using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UListenFeld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LstLinks.Items.Add("Malta");
            LstLinks.Items.Add("Zypern");
            LstLinks.Items.Add("Slowenien");
            LstLinks.Items.Add("Estland");
            LstLinks.Items.Add("Rumänien");

            LstRechts.Items.Add("Belgien");
            LstRechts.Items.Add("Spanien");
            LstRechts.Items.Add("Italien");
            LstRechts.Items.Add("Portugal");
            LstRechts.Items.Add("Dänemark");
        }

        private void CmdRechts_Click(object sender, EventArgs e)
        {
            Move(LstLinks, LstRechts);
        }

        private void CmdLinks_Click(object sender, EventArgs e)
        {
            Move(LstRechts, LstLinks);

        }
        private void Move(ListBox from, ListBox to)
        {
            foreach (string s in from.SelectedItems)
            {
                to.Items.Add(s);
            }

            for (int i = from.SelectedIndices.Count - 1; i >= 0; i--)
            {
                int position = from.SelectedIndices[i];
                from.Items.RemoveAt(position);
            }
        }

        private void Form1_Activated(object sender, EventArgs e)
        {

        }
    }
}
