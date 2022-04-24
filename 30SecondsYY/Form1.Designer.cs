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
            this.tbpGameView = new System.Windows.Forms.TabPage();
            this.pnlTeams = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddTeamsDjan = new System.Windows.Forms.Button();
            this.pnlPlayers = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddPlayer = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.tbpPlay = new System.Windows.Forms.TabPage();
            this.lbxTeams = new System.Windows.Forms.ListBox();
            this.lbxPlayersInTeams = new System.Windows.Forms.ListBox();
            this.btnPlayGame = new System.Windows.Forms.Button();
            this.tmrGameTimer = new System.Windows.Forms.Timer(this.components);
            this.lblCurrentPlayer = new System.Windows.Forms.Label();
            this.cbxFiveDjan = new System.Windows.Forms.CheckBox();
            this.cbxThreeDjan = new System.Windows.Forms.CheckBox();
            this.cbxTwoDjan = new System.Windows.Forms.CheckBox();
            this.cbxFourDjan = new System.Windows.Forms.CheckBox();
            this.lblWordFiveDjan = new System.Windows.Forms.Label();
            this.lblWordFourDjan = new System.Windows.Forms.Label();
            this.lblWordThreeDjan = new System.Windows.Forms.Label();
            this.lblWordTwoDjan = new System.Windows.Forms.Label();
            this.lblWordOneDjan = new System.Windows.Forms.Label();
            this.cbxOneDjan = new System.Windows.Forms.CheckBox();
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
            // tbpPlay
            // 
            this.tbpPlay.Controls.Add(this.cbxFiveDjan);
            this.tbpPlay.Controls.Add(this.cbxThreeDjan);
            this.tbpPlay.Controls.Add(this.cbxTwoDjan);
            this.tbpPlay.Controls.Add(this.cbxFourDjan);
            this.tbpPlay.Controls.Add(this.lblWordFiveDjan);
            this.tbpPlay.Controls.Add(this.lblWordFourDjan);
            this.tbpPlay.Controls.Add(this.lblWordThreeDjan);
            this.tbpPlay.Controls.Add(this.lblWordTwoDjan);
            this.tbpPlay.Controls.Add(this.lblWordOneDjan);
            this.tbpPlay.Controls.Add(this.cbxOneDjan);
            this.tbpPlay.Controls.Add(this.lblCurrentPlayer);
            this.tbpPlay.Location = new System.Drawing.Point(4, 22);
            this.tbpPlay.Name = "tbpPlay";
            this.tbpPlay.Size = new System.Drawing.Size(657, 462);
            this.tbpPlay.TabIndex = 2;
            this.tbpPlay.Text = "Play";
            this.tbpPlay.UseVisualStyleBackColor = true;
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
            // lbxPlayersInTeams
            // 
            this.lbxPlayersInTeams.FormattingEnabled = true;
            this.lbxPlayersInTeams.Location = new System.Drawing.Point(157, 35);
            this.lbxPlayersInTeams.Name = "lbxPlayersInTeams";
            this.lbxPlayersInTeams.Size = new System.Drawing.Size(145, 277);
            this.lbxPlayersInTeams.TabIndex = 1;
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
            // tmrGameTimer
            // 
            this.tmrGameTimer.Enabled = true;
            this.tmrGameTimer.Interval = 1000;
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
            // cbxFiveDjan
            // 
            this.cbxFiveDjan.AutoSize = true;
            this.cbxFiveDjan.Location = new System.Drawing.Point(271, 204);
            this.cbxFiveDjan.Name = "cbxFiveDjan";
            this.cbxFiveDjan.Size = new System.Drawing.Size(52, 17);
            this.cbxFiveDjan.TabIndex = 23;
            this.cbxFiveDjan.Text = "Done";
            this.cbxFiveDjan.UseVisualStyleBackColor = true;
            // 
            // cbxThreeDjan
            // 
            this.cbxThreeDjan.AutoSize = true;
            this.cbxThreeDjan.Location = new System.Drawing.Point(271, 122);
            this.cbxThreeDjan.Name = "cbxThreeDjan";
            this.cbxThreeDjan.Size = new System.Drawing.Size(52, 17);
            this.cbxThreeDjan.TabIndex = 22;
            this.cbxThreeDjan.Text = "Done";
            this.cbxThreeDjan.UseVisualStyleBackColor = true;
            // 
            // cbxTwoDjan
            // 
            this.cbxTwoDjan.AutoSize = true;
            this.cbxTwoDjan.Location = new System.Drawing.Point(271, 82);
            this.cbxTwoDjan.Name = "cbxTwoDjan";
            this.cbxTwoDjan.Size = new System.Drawing.Size(52, 17);
            this.cbxTwoDjan.TabIndex = 20;
            this.cbxTwoDjan.Text = "Done";
            this.cbxTwoDjan.UseVisualStyleBackColor = true;
            // 
            // cbxFourDjan
            // 
            this.cbxFourDjan.AutoSize = true;
            this.cbxFourDjan.Location = new System.Drawing.Point(271, 164);
            this.cbxFourDjan.Name = "cbxFourDjan";
            this.cbxFourDjan.Size = new System.Drawing.Size(52, 17);
            this.cbxFourDjan.TabIndex = 21;
            this.cbxFourDjan.Text = "Done";
            this.cbxFourDjan.UseVisualStyleBackColor = true;
            // 
            // lblWordFiveDjan
            // 
            this.lblWordFiveDjan.AutoSize = true;
            this.lblWordFiveDjan.Location = new System.Drawing.Point(18, 208);
            this.lblWordFiveDjan.Name = "lblWordFiveDjan";
            this.lblWordFiveDjan.Size = new System.Drawing.Size(16, 13);
            this.lblWordFiveDjan.TabIndex = 19;
            this.lblWordFiveDjan.Text = "---";
            // 
            // lblWordFourDjan
            // 
            this.lblWordFourDjan.AutoSize = true;
            this.lblWordFourDjan.Location = new System.Drawing.Point(18, 168);
            this.lblWordFourDjan.Name = "lblWordFourDjan";
            this.lblWordFourDjan.Size = new System.Drawing.Size(16, 13);
            this.lblWordFourDjan.TabIndex = 18;
            this.lblWordFourDjan.Text = "---";
            // 
            // lblWordThreeDjan
            // 
            this.lblWordThreeDjan.AutoSize = true;
            this.lblWordThreeDjan.Location = new System.Drawing.Point(18, 126);
            this.lblWordThreeDjan.Name = "lblWordThreeDjan";
            this.lblWordThreeDjan.Size = new System.Drawing.Size(16, 13);
            this.lblWordThreeDjan.TabIndex = 17;
            this.lblWordThreeDjan.Text = "---";
            // 
            // lblWordTwoDjan
            // 
            this.lblWordTwoDjan.AutoSize = true;
            this.lblWordTwoDjan.Location = new System.Drawing.Point(18, 86);
            this.lblWordTwoDjan.Name = "lblWordTwoDjan";
            this.lblWordTwoDjan.Size = new System.Drawing.Size(16, 13);
            this.lblWordTwoDjan.TabIndex = 16;
            this.lblWordTwoDjan.Text = "---";
            // 
            // lblWordOneDjan
            // 
            this.lblWordOneDjan.AutoSize = true;
            this.lblWordOneDjan.Location = new System.Drawing.Point(18, 47);
            this.lblWordOneDjan.Name = "lblWordOneDjan";
            this.lblWordOneDjan.Size = new System.Drawing.Size(16, 13);
            this.lblWordOneDjan.TabIndex = 15;
            this.lblWordOneDjan.Text = "---";
            // 
            // cbxOneDjan
            // 
            this.cbxOneDjan.AutoSize = true;
            this.cbxOneDjan.Location = new System.Drawing.Point(271, 43);
            this.cbxOneDjan.Name = "cbxOneDjan";
            this.cbxOneDjan.Size = new System.Drawing.Size(52, 17);
            this.cbxOneDjan.TabIndex = 14;
            this.cbxOneDjan.Text = "Done";
            this.cbxOneDjan.UseVisualStyleBackColor = true;
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
        private System.Windows.Forms.CheckBox cbxFiveDjan;
        private System.Windows.Forms.CheckBox cbxThreeDjan;
        private System.Windows.Forms.CheckBox cbxTwoDjan;
        private System.Windows.Forms.CheckBox cbxFourDjan;
        private System.Windows.Forms.Label lblWordFiveDjan;
        private System.Windows.Forms.Label lblWordFourDjan;
        private System.Windows.Forms.Label lblWordThreeDjan;
        private System.Windows.Forms.Label lblWordTwoDjan;
        private System.Windows.Forms.Label lblWordOneDjan;
        private System.Windows.Forms.CheckBox cbxOneDjan;
        private System.Windows.Forms.Label lblCurrentPlayer;
    }
}

