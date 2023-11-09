namespace Games
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            listView1 = new ListView();
            iconslol = new ImageList(components);
            pictureBox1 = new PictureBox();
            Menu = new MenuStrip();
            startGameToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            Menu.SuspendLayout();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.AllowColumnReorder = true;
            listView1.Dock = DockStyle.Fill;
            listView1.LargeImageList = iconslol;
            listView1.Location = new Point(0, 216);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(404, 305);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // iconslol
            // 
            iconslol.ColorDepth = ColorDepth.Depth32Bit;
            iconslol.ImageSize = new Size(32, 32);
            iconslol.TransparentColor = Color.Transparent;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.ImageLocation = "cover.png";
            pictureBox1.Location = new Point(0, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(404, 192);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            Menu.Items.AddRange(new ToolStripItem[] { startGameToolStripMenuItem, aboutToolStripMenuItem });
            Menu.Location = new Point(0, 0);
            Menu.Name = "Menu";
            Menu.Size = new Size(404, 24);
            Menu.TabIndex = 2;
            Menu.Text = "menuStrip1";
            // 
            // startGameToolStripMenuItem
            // 
            startGameToolStripMenuItem.Name = "startGameToolStripMenuItem";
            startGameToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Space;
            startGameToolStripMenuItem.Size = new Size(76, 20);
            startGameToolStripMenuItem.Text = "Start game";
            startGameToolStripMenuItem.Click += startGameToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(52, 20);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 521);
            Controls.Add(listView1);
            Controls.Add(pictureBox1);
            Controls.Add(Menu);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = Menu;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Initializing...";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            Menu.ResumeLayout(false);
            Menu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private HelpProvider helpProvider1;
        private PictureBox pictureBox1;
        private ListView listView1;
        private ImageList imageList1;
        private MenuStrip Menu;
        private ToolStripMenuItem startGameToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ImageList iconslol;
    }
}