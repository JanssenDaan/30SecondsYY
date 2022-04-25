namespace _30SecondsYY
{
    partial class Form1
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
            this.tclControl = new System.Windows.Forms.TabControl();
            this.tbpTeamsPlayers = new System.Windows.Forms.TabPage();
            this.btnNext = new System.Windows.Forms.Button();
            this.pnlTeams = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddTeamsDjan = new System.Windows.Forms.Button();
            this.pnlPlayers = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddPlayer = new System.Windows.Forms.Button();
            this.tbpGameView = new System.Windows.Forms.TabPage();
            this.btnPlayGame = new System.Windows.Forms.Button();
            this.lbxPlayersInTeams = new System.Windows.Forms.ListBox();
            this.lbxTeams = new System.Windows.Forms.ListBox();
            this.tbpPlay = new System.Windows.Forms.TabPage();
            this.cbxFive = new System.Windows.Forms.CheckBox();
            this.cbxThree = new System.Windows.Forms.CheckBox();
            this.cbxTwo = new System.Windows.Forms.CheckBox();
            this.cbxFour = new System.Windows.Forms.CheckBox();
            this.lblWordFive = new System.Windows.Forms.Label();
            this.lblWordFour = new System.Windows.Forms.Label();
            this.lblWordThree = new System.Windows.Forms.Label();
            this.lblWordTwo = new System.Windows.Forms.Label();
            this.lblWordOne = new System.Windows.Forms.Label();
            this.cbxOne = new System.Windows.Forms.CheckBox();
            this.lblCurrentPlayer = new System.Windows.Forms.Label();
            this.tmrGameTimer = new System.Windows.Forms.Timer(this.components);
            this.btnNextInPlay = new System.Windows.Forms.Button();
            this.lblCountdown = new System.Windows.Forms.Label();
            this.tclControl.SuspendLayout();
            this.tbpTeamsPlayers.SuspendLayout();
            this.tbpGameView.SuspendLayout();
            this.tbpPlay.SuspendLayout();
            this.SuspendLayout();
            // 
            // tclControl
            // 
            this.tclControl.Controls.Add(this.tbpTeamsPlayers);
            this.tclControl.Controls.Add(this.tbpGameView);
            this.tclControl.Controls.Add(this.tbpPlay);
            this.tclControl.Location = new System.Drawing.Point(2, 2);
            this.tclControl.Name = "tclControl";
            this.tclControl.SelectedIndex = 0;
            this.tclControl.Size = new System.Drawing.Size(665, 488);
            this.tclControl.TabIndex = 0;
            // 
            // tbpTeamsPlayers
            // 
            this.tbpTeamsPlayers.Controls.Add(this.btnNext);
            this.tbpTeamsPlayers.Controls.Add(this.pnlTeams);
            this.tbpTeamsPlayers.Controls.Add(this.btnAddTeamsDjan);
            this.tbpTeamsPlayers.Controls.Add(this.pnlPlayers);
            this.tbpTeamsPlayers.Controls.Add(this.btnAddPlayer);
            this.tbpTeamsPlayers.Location = new System.Drawing.Point(4, 22);
            this.tbpTeamsPlayers.Name = "tbpTeamsPlayers";
            this.tbpTeamsPlayers.Padding = new System.Windows.Forms.Padding(3);
            this.tbpTeamsPlayers.Size = new System.Drawing.Size(657, 462);
            this.tbpTeamsPlayers.TabIndex = 0;
            this.tbpTeamsPlayers.Text = "Teams and Players";
            this.tbpTeamsPlayers.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(525, 110);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(103, 61);
            this.btnNext.TabIndex = 9;
            this.btnNext.Text = "Go to Game View";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // pnlTeams
            // 
            this.pnlTeams.AutoScroll = true;
            this.pnlTeams.Location = new System.Drawing.Point(6, 58);
            this.pnlTeams.Name = "pnlTeams";
            this.pnlTeams.Size = new System.Drawing.Size(217, 395);
            this.pnlTeams.TabIndex = 8;
            // 
            // btnAddTeamsDjan
            // 
            this.btnAddTeamsDjan.Location = new System.Drawing.Point(45, 6);
            this.btnAddTeamsDjan.Name = "btnAddTeamsDjan";
            this.btnAddTeamsDjan.Size = new System.Drawing.Size(135, 46);
            this.btnAddTeamsDjan.TabIndex = 7;
            this.btnAddTeamsDjan.Text = "Add Team";
            this.btnAddTeamsDjan.UseVisualStyleBackColor = true;
            this.btnAddTeamsDjan.Click += new System.EventHandler(this.btnAddTeamsDjan_Click);
            // 
            // pnlPlayers
            // 
            this.pnlPlayers.AutoScroll = true;
            this.pnlPlayers.Location = new System.Drawing.Point(231, 58);
            this.pnlPlayers.Name = "pnlPlayers";
            this.pnlPlayers.Size = new System.Drawing.Size(288, 401);
            this.pnlPlayers.TabIndex = 6;
            // 
            // btnAddPlayer
            // 
            this.btnAddPlayer.Location = new System.Drawing.Point(315, 6);
            this.btnAddPlayer.Name = "btnAddPlayer";
            this.btnAddPlayer.Size = new System.Drawing.Size(135, 46);
            this.btnAddPlayer.TabIndex = 5;
            this.btnAddPlayer.Text = "Add Player";
            this.btnAddPlayer.UseVisualStyleBackColor = true;
            this.btnAddPlayer.Click += new System.EventHandler(this.btnAddPlayer_Click);
            // 
            // tbpGameView
            // 
            this.tbpGameView.Controls.Add(this.btnPlayGame);
            this.tbpGameView.Controls.Add(this.lbxPlayersInTeams);
            this.tbpGameView.Controls.Add(this.lbxTeams);
            this.tbpGameView.Location = new System.Drawing.Point(4, 22);
            this.tbpGameView.Name = "tbpGameView";
            this.tbpGameView.Padding = new System.Windows.Forms.Padding(3);
            this.tbpGameView.Size = new System.Drawing.Size(657, 462);
            this.tbpGameView.TabIndex = 1;
            this.tbpGameView.Text = "Game View";
            this.tbpGameView.UseVisualStyleBackColor = true;
            // 
            // btnPlayGame
            // 
            this.btnPlayGame.Location = new System.Drawing.Point(308, 35);
            this.btnPlayGame.Name = "btnPlayGame";
            this.btnPlayGame.Size = new System.Drawing.Size(89, 46);
            this.btnPlayGame.TabIndex = 2;
            this.btnPlayGame.Text = "Play Game!";
            this.btnPlayGame.UseVisualStyleBackColor = true;
            this.btnPlayGame.Click += new System.EventHandler(this.btnPlayGame_Click);
            // 
            // lbxPlayersInTeams
            // 
            this.lbxPlayersInTeams.FormattingEnabled = true;
            this.lbxPlayersInTeams.Location = new System.Drawing.Point(157, 35);
            this.lbxPlayersInTeams.Name = "lbxPlayersInTeams";
            this.lbxPlayersInTeams.Size = new System.Drawing.Size(145, 277);
            this.lbxPlayersInTeams.TabIndex = 1;
            // 
            // lbxTeams
            // 
            this.lbxTeams.FormattingEnabled = true;
            this.lbxTeams.Location = new System.Drawing.Point(6, 35);
            this.lbxTeams.Name = "lbxTeams";
            this.lbxTeams.Size = new System.Drawing.Size(145, 277);
            this.lbxTeams.TabIndex = 0;
            this.lbxTeams.SelectedIndexChanged += new System.EventHandler(this.lbxTeams_SelectedIndexChanged);
            // 
            // tbpPlay
            // 
            this.tbpPlay.Controls.Add(this.lblCountdown);
            this.tbpPlay.Controls.Add(this.btnNextInPlay);
            this.tbpPlay.Controls.Add(this.cbxFive);
            this.tbpPlay.Controls.Add(this.cbxThree);
            this.tbpPlay.Controls.Add(this.cbxTwo);
            this.tbpPlay.Controls.Add(this.cbxFour);
            this.tbpPlay.Controls.Add(this.lblWordFive);
            this.tbpPlay.Controls.Add(this.lblWordFour);
            this.tbpPlay.Controls.Add(this.lblWordThree);
            this.tbpPlay.Controls.Add(this.lblWordTwo);
            this.tbpPlay.Controls.Add(this.lblWordOne);
            this.tbpPlay.Controls.Add(this.cbxOne);
            this.tbpPlay.Controls.Add(this.lblCurrentPlayer);
            this.tbpPlay.Location = new System.Drawing.Point(4, 22);
            this.tbpPlay.Name = "tbpPlay";
            this.tbpPlay.Size = new System.Drawing.Size(657, 462);
            this.tbpPlay.TabIndex = 2;
            this.tbpPlay.Text = "Play";
            this.tbpPlay.UseVisualStyleBackColor = true;
            // 
            // cbxFive
            // 
            this.cbxFive.AutoSize = true;
            this.cbxFive.Location = new System.Drawing.Point(271, 204);
            this.cbxFive.Name = "cbxFive";
            this.cbxFive.Size = new System.Drawing.Size(52, 17);
            this.cbxFive.TabIndex = 23;
            this.cbxFive.Text = "Done";
            this.cbxFive.UseVisualStyleBackColor = true;
            // 
            // cbxThree
            // 
            this.cbxThree.AutoSize = true;
            this.cbxThree.Location = new System.Drawing.Point(271, 122);
            this.cbxThree.Name = "cbxThree";
            this.cbxThree.Size = new System.Drawing.Size(52, 17);
            this.cbxThree.TabIndex = 22;
            this.cbxThree.Text = "Done";
            this.cbxThree.UseVisualStyleBackColor = true;
            // 
            // cbxTwo
            // 
            this.cbxTwo.AutoSize = true;
            this.cbxTwo.Location = new System.Drawing.Point(271, 82);
            this.cbxTwo.Name = "cbxTwo";
            this.cbxTwo.Size = new System.Drawing.Size(52, 17);
            this.cbxTwo.TabIndex = 20;
            this.cbxTwo.Text = "Done";
            this.cbxTwo.UseVisualStyleBackColor = true;
            // 
            // cbxFour
            // 
            this.cbxFour.AutoSize = true;
            this.cbxFour.Location = new System.Drawing.Point(271, 164);
            this.cbxFour.Name = "cbxFour";
            this.cbxFour.Size = new System.Drawing.Size(52, 17);
            this.cbxFour.TabIndex = 21;
            this.cbxFour.Text = "Done";
            this.cbxFour.UseVisualStyleBackColor = true;
            // 
            // lblWordFive
            // 
            this.lblWordFive.AutoSize = true;
            this.lblWordFive.Location = new System.Drawing.Point(18, 208);
            this.lblWordFive.Name = "lblWordFive";
            this.lblWordFive.Size = new System.Drawing.Size(16, 13);
            this.lblWordFive.TabIndex = 19;
            this.lblWordFive.Text = "---";
            // 
            // lblWordFour
            // 
            this.lblWordFour.AutoSize = true;
            this.lblWordFour.Location = new System.Drawing.Point(18, 168);
            this.lblWordFour.Name = "lblWordFour";
            this.lblWordFour.Size = new System.Drawing.Size(16, 13);
            this.lblWordFour.TabIndex = 18;
            this.lblWordFour.Text = "---";
            // 
            // lblWordThree
            // 
            this.lblWordThree.AutoSize = true;
            this.lblWordThree.Location = new System.Drawing.Point(18, 126);
            this.lblWordThree.Name = "lblWordThree";
            this.lblWordThree.Size = new System.Drawing.Size(16, 13);
            this.lblWordThree.TabIndex = 17;
            this.lblWordThree.Text = "---";
            // 
            // lblWordTwo
            // 
            this.lblWordTwo.AutoSize = true;
            this.lblWordTwo.Location = new System.Drawing.Point(18, 86);
            this.lblWordTwo.Name = "lblWordTwo";
            this.lblWordTwo.Size = new System.Drawing.Size(16, 13);
            this.lblWordTwo.TabIndex = 16;
            this.lblWordTwo.Text = "---";
            // 
            // lblWordOne
            // 
            this.lblWordOne.AutoSize = true;
            this.lblWordOne.Location = new System.Drawing.Point(18, 47);
            this.lblWordOne.Name = "lblWordOne";
            this.lblWordOne.Size = new System.Drawing.Size(16, 13);
            this.lblWordOne.TabIndex = 15;
            this.lblWordOne.Text = "---";
            // 
            // cbxOne
            // 
            this.cbxOne.AutoSize = true;
            this.cbxOne.Location = new System.Drawing.Point(271, 43);
            this.cbxOne.Name = "cbxOne";
            this.cbxOne.Size = new System.Drawing.Size(52, 17);
            this.cbxOne.TabIndex = 14;
            this.cbxOne.Text = "Done";
            this.cbxOne.UseVisualStyleBackColor = true;
            // 
            // lblCurrentPlayer
            // 
            this.lblCurrentPlayer.AutoSize = true;
            this.lblCurrentPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentPlayer.Location = new System.Drawing.Point(17, 13);
            this.lblCurrentPlayer.Name = "lblCurrentPlayer";
            this.lblCurrentPlayer.Size = new System.Drawing.Size(113, 20);
            this.lblCurrentPlayer.TabIndex = 1;
            this.lblCurrentPlayer.Text = "CurrentPlayer: ";
            // 
            // tmrGameTimer
            // 
            this.tmrGameTimer.Enabled = true;
            this.tmrGameTimer.Interval = 1000;
            this.tmrGameTimer.Tick += new System.EventHandler(this.tmrGameTimer_Tick);
            // 
            // btnNextInPlay
            // 
            this.btnNextInPlay.Location = new System.Drawing.Point(470, 37);
            this.btnNextInPlay.Name = "btnNextInPlay";
            this.btnNextInPlay.Size = new System.Drawing.Size(75, 23);
            this.btnNextInPlay.TabIndex = 24;
            this.btnNextInPlay.Text = "Next";
            this.btnNextInPlay.UseVisualStyleBackColor = true;
            this.btnNextInPlay.Click += new System.EventHandler(this.btnNextInPlay_Click);
            // 
            // lblCountdown
            // 
            this.lblCountdown.AutoSize = true;
            this.lblCountdown.Location = new System.Drawing.Point(492, 359);
            this.lblCountdown.Name = "lblCountdown";
            this.lblCountdown.Size = new System.Drawing.Size(76, 13);
            this.lblCountdown.TabIndex = 25;
            this.lblCountdown.Text = "Countdown: ...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 489);
            this.Controls.Add(this.tclControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tclControl.ResumeLayout(false);
            this.tbpTeamsPlayers.ResumeLayout(false);
            this.tbpGameView.ResumeLayout(false);
            this.tbpPlay.ResumeLayout(false);
            this.tbpPlay.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tclControl;
        private System.Windows.Forms.TabPage tbpTeamsPlayers;
        private System.Windows.Forms.Button btnNext;
        public System.Windows.Forms.FlowLayoutPanel pnlTeams;
        private System.Windows.Forms.Button btnAddTeamsDjan;
        public System.Windows.Forms.FlowLayoutPanel pnlPlayers;
        private System.Windows.Forms.Button btnAddPlayer;
        private System.Windows.Forms.TabPage tbpGameView;
        private System.Windows.Forms.TabPage tbpPlay;
        private System.Windows.Forms.ListBox lbxPlayersInTeams;
        private System.Windows.Forms.ListBox lbxTeams;
        private System.Windows.Forms.Button btnPlayGame;
        private System.Windows.Forms.Timer tmrGameTimer;
        private System.Windows.Forms.CheckBox cbxFive;
        private System.Windows.Forms.CheckBox cbxThree;
        private System.Windows.Forms.CheckBox cbxTwo;
        private System.Windows.Forms.CheckBox cbxFour;
        private System.Windows.Forms.Label lblWordFive;
        private System.Windows.Forms.Label lblWordFour;
        private System.Windows.Forms.Label lblWordThree;
        private System.Windows.Forms.Label lblWordTwo;
        private System.Windows.Forms.Label lblWordOne;
        private System.Windows.Forms.CheckBox cbxOne;
        private System.Windows.Forms.Label lblCurrentPlayer;
        private System.Windows.Forms.Button btnNextInPlay;
        private System.Windows.Forms.Label lblCountdown;
    }
}

