namespace sudoku
{
    partial class MainForm
    {
        
        private System.ComponentModel.IContainer components = null;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.msMainMenu = new System.Windows.Forms.MenuStrip();
            this.msMainMenuGame = new System.Windows.Forms.ToolStripMenuItem();
            this.msMainMenuGameNew = new System.Windows.Forms.ToolStripMenuItem();
            this.msMainMenuGameSolve = new System.Windows.Forms.ToolStripMenuItem();
            this.msMainMenuFieldClear = new System.Windows.Forms.ToolStripMenuItem();
            this.msMainMenuSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.msMainMenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.msMainMenuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.msMainMenuRules = new System.Windows.Forms.ToolStripMenuItem();
            this.msMainMenuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.msMainMenu.SuspendLayout();
            this.SuspendLayout();
          

            this.msMainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msMainMenuGame,
            this.msMainMenuHelp});
            this.msMainMenu.Location = new System.Drawing.Point(0, 0);
            this.msMainMenu.Name = "msMainMenu";
            this.msMainMenu.Size = new System.Drawing.Size(412, 28);
            this.msMainMenu.TabIndex = 0;
            this.msMainMenu.Text = "menuStrip1";
         

            this.msMainMenuGame.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.msMainMenuGame.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msMainMenuGameNew,
            this.msMainMenuGameSolve,
            this.msMainMenuFieldClear,
            this.msMainMenuSeparator1,
            this.msMainMenuExit});
            this.msMainMenuGame.Image = global::sudoku.Properties.Resources.games_controller_game_icon_17;
            this.msMainMenuGame.Name = "msMainMenuGame";
            this.msMainMenuGame.Size = new System.Drawing.Size(65, 24);
            this.msMainMenuGame.Text = "منو";
            this.msMainMenuGame.Click += new System.EventHandler(this.msMainMenuGame_Click);
          

            this.msMainMenuGameNew.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.msMainMenuGameNew.Image = global::sudoku.Properties.Resources.pngwing_com;
            this.msMainMenuGameNew.Name = "msMainMenuGameNew";
            this.msMainMenuGameNew.Size = new System.Drawing.Size(224, 26);
            this.msMainMenuGameNew.Text = "بازی جدید";
            this.msMainMenuGameNew.Click += new System.EventHandler(this.msMainMenuGameNew_Click_1);
          

            this.msMainMenuGameSolve.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.msMainMenuGameSolve.Image = global::sudoku.Properties.Resources._6487594;
            this.msMainMenuGameSolve.Name = "msMainMenuGameSolve";
            this.msMainMenuGameSolve.Size = new System.Drawing.Size(224, 26);
            this.msMainMenuGameSolve.Text = "حل کردن";
            this.msMainMenuGameSolve.Click += new System.EventHandler(this.msMainMenuGameSolve_Click);
          
            
            this.msMainMenuFieldClear.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.msMainMenuFieldClear.Image = global::sudoku.Properties.Resources._1214594;
            this.msMainMenuFieldClear.Name = "msMainMenuFieldClear";
            this.msMainMenuFieldClear.Size = new System.Drawing.Size(224, 26);
            this.msMainMenuFieldClear.Text = "پاک کردن";
            this.msMainMenuFieldClear.Click += new System.EventHandler(this.msMainMenuFieldClear_Click_1);
            
            
            this.msMainMenuSeparator1.Name = "msMainMenuSeparator1";
            this.msMainMenuSeparator1.Size = new System.Drawing.Size(221, 6);
           

            this.msMainMenuExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.msMainMenuExit.Image = global::sudoku.Properties.Resources._320140;
            this.msMainMenuExit.Name = "msMainMenuExit";
            this.msMainMenuExit.Size = new System.Drawing.Size(224, 26);
            this.msMainMenuExit.Text = "خروج";
            this.msMainMenuExit.Click += new System.EventHandler(this.msMainMenuExit_Click);
          

            this.msMainMenuHelp.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.msMainMenuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msMainMenuRules,
            this.msMainMenuAbout});
            this.msMainMenuHelp.Image = global::sudoku.Properties.Resources.Help_Support_Transparent_Background;
            this.msMainMenuHelp.Name = "msMainMenuHelp";
            this.msMainMenuHelp.Size = new System.Drawing.Size(80, 24);
            this.msMainMenuHelp.Text = "راهنما";
            this.msMainMenuHelp.Click += new System.EventHandler(this.msMainMenuHelp_Click);
            

            this.msMainMenuRules.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.msMainMenuRules.Image = global::sudoku.Properties.Resources._4436501;
            this.msMainMenuRules.Name = "msMainMenuRules";
            this.msMainMenuRules.Size = new System.Drawing.Size(231, 26);
            this.msMainMenuRules.Text = "قوانین";
            this.msMainMenuRules.Click += new System.EventHandler(this.msMainMenuRules_Click);
           

            this.msMainMenuAbout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.msMainMenuAbout.Image = global::sudoku.Properties.Resources.ad046d9b697c7b69bae6ba9ae5f33330_how_question_doodle;
            this.msMainMenuAbout.Name = "msMainMenuAbout";
            this.msMainMenuAbout.Size = new System.Drawing.Size(231, 26);
            this.msMainMenuAbout.Text = "چجوری عدد وارد کنیم؟";
            this.msMainMenuAbout.Click += new System.EventHandler(this.msMainMenuAbout_Click);
           

            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::sudoku.Properties.Resources.Screenshot_2023_07_01_142007;
            this.ClientSize = new System.Drawing.Size(412, 401);
            this.Controls.Add(this.msMainMenu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msMainMenu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Sudoku";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.msMainMenu.ResumeLayout(false);
            this.msMainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMainMenu;
        private System.Windows.Forms.ToolStripMenuItem msMainMenuGame;
        private System.Windows.Forms.ToolStripMenuItem msMainMenuGameNew;
        private System.Windows.Forms.ToolStripSeparator msMainMenuSeparator1;
        private System.Windows.Forms.ToolStripMenuItem msMainMenuGameSolve;
        private System.Windows.Forms.ToolStripMenuItem msMainMenuExit;
        private System.Windows.Forms.ToolStripMenuItem msMainMenuHelp;
        private System.Windows.Forms.ToolStripMenuItem msMainMenuRules;
        private System.Windows.Forms.ToolStripMenuItem msMainMenuAbout;
        private System.Windows.Forms.ToolStripMenuItem msMainMenuFieldClear;
    }
}

