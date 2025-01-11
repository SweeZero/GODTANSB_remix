using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Xml.Linq;
using System.IO;
using Microsoft.VisualBasic.Logging;
using System.Runtime.CompilerServices;
using System.Text;

namespace Games
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string[] games = new string[999];
        public string[] disks = new string[999];
        public string[] icons = new string[999];
        public string[] paths = new string[999];
        private void Form1_Load(object sender, EventArgs e)
        {
            Text = System.IO.Directory.GetCurrentDirectory();
            using (var reader = new StreamReader(Text + "\\data\\games"))
            {
                int num = 0;
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    games[num] = line;
                    num++;
                }
            }
            using (var reader = new StreamReader(Text + "\\data\\disks"))
            {
                int num = 0;
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    disks[num] = line;
                    num++;
                }
            }
            using (var reader = new StreamReader(Text + "\\data\\icons"))
            {
                int num = 0;
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    icons[num] = line;
                    num++;
                }
            }
            using (var reader = new StreamReader(Text + "\\data\\paths"))
            {
                int num = 0;
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    paths[num] = line;
                    num++;
                }
            }
            int i = 0;
            foreach (string game in games)
            {
                if (game != null)
                {
                    iconslol.Images.Add("icon" + i, Image.FromFile(Text + icons[i]));
                    ListViewItem item = new ListViewItem();
                    item.ImageIndex = i;
                    item.Text = game;
                    item.Tag = i;
                    listView1.Items.Add(item);
                }
                i++;
            }
        }
        private void startGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int disk = Int32.Parse(disks[Int32.Parse(listView1.SelectedItems[0].Tag.ToString())]);
            if (disk == getdisknum())
            {
                try
                {
                    string item = paths[Int32.Parse(listView1.SelectedItems[0].Tag.ToString())];
                    ProcessStartInfo start = new ProcessStartInfo();
                    start.FileName = Text + item;
                    MessageBox.Show("Game is about to start, just click OK! enjoy!", "Get ready!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Process.Start(start);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred when trying to start: " + ex.GetType().ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please insert disk " + disks[Int32.Parse(listView1.SelectedItems[0].Tag.ToString())] + " to " + Text + " and try again.", "Disk missing", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private int getdisknum()
        {
            string readContents;
            try
            {
                using (StreamReader streamReader = new StreamReader(Text + "\\disknum.inf"))
                {
                    readContents = streamReader.ReadToEnd();
                }
                return Int32.Parse(readContents);
            }
            catch
            {
                return 0;
            }
        }
    }
}