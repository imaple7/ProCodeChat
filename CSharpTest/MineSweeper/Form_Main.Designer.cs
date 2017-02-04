namespace MineSweeper
{
    partial class Form_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.MenuStrip_Main = new System.Windows.Forms.MenuStrip();
            this.gameGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beginnerBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.intermediateIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expertEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.settingSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.markMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.audioAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.rankRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.exitXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TableLayoutPanel_Main = new System.Windows.Forms.TableLayoutPanel();
            this.PictureBox_Mine = new System.Windows.Forms.PictureBox();
            this.PictureBox_Timer = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Timer_Main = new System.Windows.Forms.Timer(this.components);
            this.MenuStrip_Main.SuspendLayout();
            this.TableLayoutPanel_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Mine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Timer)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuStrip_Main
            // 
            this.MenuStrip_Main.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MenuStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameGToolStripMenuItem,
            this.helpHToolStripMenuItem});
            this.MenuStrip_Main.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip_Main.Name = "MenuStrip_Main";
            this.MenuStrip_Main.Size = new System.Drawing.Size(1006, 33);
            this.MenuStrip_Main.TabIndex = 0;
            this.MenuStrip_Main.Text = "menuStrip1";
            // 
            // gameGToolStripMenuItem
            // 
            this.gameGToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameNToolStripMenuItem,
            this.beginnerBToolStripMenuItem,
            this.toolStripSeparator1,
            this.intermediateIToolStripMenuItem,
            this.expertEToolStripMenuItem,
            this.toolStripSeparator2,
            this.settingSToolStripMenuItem,
            this.toolStripSeparator3,
            this.markMToolStripMenuItem,
            this.audioAToolStripMenuItem,
            this.toolStripSeparator5,
            this.rankRToolStripMenuItem,
            this.toolStripSeparator4,
            this.exitXToolStripMenuItem});
            this.gameGToolStripMenuItem.Name = "gameGToolStripMenuItem";
            this.gameGToolStripMenuItem.Size = new System.Drawing.Size(92, 29);
            this.gameGToolStripMenuItem.Text = "Game(&G)";
            // 
            // newGameNToolStripMenuItem
            // 
            this.newGameNToolStripMenuItem.Name = "newGameNToolStripMenuItem";
            this.newGameNToolStripMenuItem.Size = new System.Drawing.Size(212, 30);
            this.newGameNToolStripMenuItem.Text = "New Game(&N)";
            // 
            // beginnerBToolStripMenuItem
            // 
            this.beginnerBToolStripMenuItem.Name = "beginnerBToolStripMenuItem";
            this.beginnerBToolStripMenuItem.Size = new System.Drawing.Size(212, 30);
            this.beginnerBToolStripMenuItem.Text = "Beginner(&B)";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(209, 6);
            // 
            // intermediateIToolStripMenuItem
            // 
            this.intermediateIToolStripMenuItem.Name = "intermediateIToolStripMenuItem";
            this.intermediateIToolStripMenuItem.Size = new System.Drawing.Size(212, 30);
            this.intermediateIToolStripMenuItem.Text = "Intermediate(I)";
            // 
            // expertEToolStripMenuItem
            // 
            this.expertEToolStripMenuItem.Name = "expertEToolStripMenuItem";
            this.expertEToolStripMenuItem.Size = new System.Drawing.Size(212, 30);
            this.expertEToolStripMenuItem.Text = "Expert(&E)";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(209, 6);
            // 
            // settingSToolStripMenuItem
            // 
            this.settingSToolStripMenuItem.Name = "settingSToolStripMenuItem";
            this.settingSToolStripMenuItem.Size = new System.Drawing.Size(212, 30);
            this.settingSToolStripMenuItem.Text = "Setting(&S)";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(209, 6);
            // 
            // markMToolStripMenuItem
            // 
            this.markMToolStripMenuItem.Name = "markMToolStripMenuItem";
            this.markMToolStripMenuItem.Size = new System.Drawing.Size(212, 30);
            this.markMToolStripMenuItem.Text = "Mark(?)(&M)";
            // 
            // audioAToolStripMenuItem
            // 
            this.audioAToolStripMenuItem.Name = "audioAToolStripMenuItem";
            this.audioAToolStripMenuItem.Size = new System.Drawing.Size(212, 30);
            this.audioAToolStripMenuItem.Text = "Audio(&A)";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(209, 6);
            // 
            // rankRToolStripMenuItem
            // 
            this.rankRToolStripMenuItem.Name = "rankRToolStripMenuItem";
            this.rankRToolStripMenuItem.Size = new System.Drawing.Size(212, 30);
            this.rankRToolStripMenuItem.Text = "Rank(&R)";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(209, 6);
            // 
            // exitXToolStripMenuItem
            // 
            this.exitXToolStripMenuItem.Name = "exitXToolStripMenuItem";
            this.exitXToolStripMenuItem.Size = new System.Drawing.Size(212, 30);
            this.exitXToolStripMenuItem.Text = "Exit(&X)";
            // 
            // helpHToolStripMenuItem
            // 
            this.helpHToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutAToolStripMenuItem});
            this.helpHToolStripMenuItem.Name = "helpHToolStripMenuItem";
            this.helpHToolStripMenuItem.Size = new System.Drawing.Size(84, 29);
            this.helpHToolStripMenuItem.Text = "Help(&H)";
            // 
            // aboutAToolStripMenuItem
            // 
            this.aboutAToolStripMenuItem.Name = "aboutAToolStripMenuItem";
            this.aboutAToolStripMenuItem.Size = new System.Drawing.Size(169, 30);
            this.aboutAToolStripMenuItem.Text = "About(&A)";
            // 
            // TableLayoutPanel_Main
            // 
            this.TableLayoutPanel_Main.ColumnCount = 9;
            this.TableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.TableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.TableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.TableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.TableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.TableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.TableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.TableLayoutPanel_Main.Controls.Add(this.PictureBox_Mine, 1, 0);
            this.TableLayoutPanel_Main.Controls.Add(this.PictureBox_Timer, 7, 0);
            this.TableLayoutPanel_Main.Controls.Add(this.label1, 3, 0);
            this.TableLayoutPanel_Main.Controls.Add(this.label2, 5, 0);
            this.TableLayoutPanel_Main.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TableLayoutPanel_Main.Location = new System.Drawing.Point(0, 781);
            this.TableLayoutPanel_Main.Name = "TableLayoutPanel_Main";
            this.TableLayoutPanel_Main.RowCount = 1;
            this.TableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel_Main.Size = new System.Drawing.Size(1006, 48);
            this.TableLayoutPanel_Main.TabIndex = 1;
            // 
            // PictureBox_Mine
            // 
            this.PictureBox_Mine.BackgroundImage = global::MineSweeper.Properties.Resources.Mine_Snow;
            this.PictureBox_Mine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictureBox_Mine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBox_Mine.Location = new System.Drawing.Point(35, 3);
            this.PictureBox_Mine.Name = "PictureBox_Mine";
            this.PictureBox_Mine.Size = new System.Drawing.Size(42, 42);
            this.PictureBox_Mine.TabIndex = 0;
            this.PictureBox_Mine.TabStop = false;
            // 
            // PictureBox_Timer
            // 
            this.PictureBox_Timer.BackgroundImage = global::MineSweeper.Properties.Resources.Timer;
            this.PictureBox_Timer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictureBox_Timer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBox_Timer.Location = new System.Drawing.Point(929, 3);
            this.PictureBox_Timer.Name = "PictureBox_Timer";
            this.PictureBox_Timer.Size = new System.Drawing.Size(42, 42);
            this.PictureBox_Timer.TabIndex = 1;
            this.PictureBox_Timer.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(99, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 48);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lable_Mine";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(522, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(385, 48);
            this.label2.TabIndex = 3;
            this.label2.Text = "Label_Timer";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Timer_Main
            // 
            this.Timer_Main.Interval = 1000;
            // 
            // Form_Main
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1006, 829);
            this.Controls.Add(this.TableLayoutPanel_Main);
            this.Controls.Add(this.MenuStrip_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip_Main;
            this.MaximizeBox = false;
            this.Name = "Form_Main";
            this.Text = "MineSweeper";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form_Main_Paint);
            this.MenuStrip_Main.ResumeLayout(false);
            this.MenuStrip_Main.PerformLayout();
            this.TableLayoutPanel_Main.ResumeLayout(false);
            this.TableLayoutPanel_Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Mine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Timer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip_Main;
        private System.Windows.Forms.ToolStripMenuItem gameGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beginnerBToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem intermediateIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expertEToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem settingSToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem markMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem audioAToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem rankRToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem exitXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutAToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanel_Main;
        private System.Windows.Forms.PictureBox PictureBox_Mine;
        private System.Windows.Forms.PictureBox PictureBox_Timer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer Timer_Main;
    }
}

