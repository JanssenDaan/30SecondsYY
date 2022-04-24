namespace _30SecondsYY
{
    partial class UCPlayer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSelectTeam = new System.Windows.Forms.Label();
            this.cbxSelectTeam = new System.Windows.Forms.ComboBox();
            this.btnRemovePlayer = new System.Windows.Forms.Button();
            this.btnChangeColor = new System.Windows.Forms.Button();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.tbxPlayerName = new System.Windows.Forms.TextBox();
            this.cdlColor = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // lblSelectTeam
            // 
            this.lblSelectTeam.AutoSize = true;
            this.lblSelectTeam.Location = new System.Drawing.Point(182, 71);
            this.lblSelectTeam.Name = "lblSelectTeam";
            this.lblSelectTeam.Size = new System.Drawing.Size(67, 13);
            this.lblSelectTeam.TabIndex = 23;
            this.lblSelectTeam.Text = "Select Team";
            // 
            // cbxSelectTeam
            // 
            this.cbxSelectTeam.FormattingEnabled = true;
            this.cbxSelectTeam.Location = new System.Drawing.Point(125, 87);
            this.cbxSelectTeam.Name = "cbxSelectTeam";
            this.cbxSelectTeam.Size = new System.Drawing.Size(121, 21);
            this.cbxSelectTeam.TabIndex = 22;
            this.cbxSelectTeam.SelectedIndexChanged += new System.EventHandler(this.cbxSelectTeam_SelectedIndexChanged);
            this.cbxSelectTeam.Click += new System.EventHandler(this.cbxSelectTeam_Click);
            // 
            // btnRemovePlayer
            // 
            this.btnRemovePlayer.Location = new System.Drawing.Point(185, 4);
            this.btnRemovePlayer.Name = "btnRemovePlayer";
            this.btnRemovePlayer.Size = new System.Drawing.Size(56, 34);
            this.btnRemovePlayer.TabIndex = 21;
            this.btnRemovePlayer.Text = "Delete Player";
            this.btnRemovePlayer.UseVisualStyleBackColor = false;
            this.btnRemovePlayer.Click += new System.EventHandler(this.btnRemovePlayer_Click);
            // 
            // btnChangeColor
            // 
            this.btnChangeColor.Location = new System.Drawing.Point(6, 79);
            this.btnChangeColor.Name = "btnChangeColor";
            this.btnChangeColor.Size = new System.Drawing.Size(100, 34);
            this.btnChangeColor.TabIndex = 20;
            this.btnChangeColor.Text = "Change BackColor";
            this.btnChangeColor.UseVisualStyleBackColor = true;
            this.btnChangeColor.Click += new System.EventHandler(this.btnChangeColor_Click);
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Location = new System.Drawing.Point(3, 0);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(67, 13);
            this.lblPlayerName.TabIndex = 19;
            this.lblPlayerName.Text = "Player Name";
            // 
            // tbxPlayerName
            // 
            this.tbxPlayerName.Location = new System.Drawing.Point(6, 18);
            this.tbxPlayerName.Name = "tbxPlayerName";
            this.tbxPlayerName.Size = new System.Drawing.Size(100, 20);
            this.tbxPlayerName.TabIndex = 18;
            this.tbxPlayerName.TextChanged += new System.EventHandler(this.tbxPlayerName_TextChanged);
            // 
            // UCPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblSelectTeam);
            this.Controls.Add(this.cbxSelectTeam);
            this.Controls.Add(this.btnRemovePlayer);
            this.Controls.Add(this.btnChangeColor);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.tbxPlayerName);
            this.Name = "UCPlayer";
            this.Size = new System.Drawing.Size(249, 116);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectTeam;
        private System.Windows.Forms.ComboBox cbxSelectTeam;
        private System.Windows.Forms.Button btnRemovePlayer;
        private System.Windows.Forms.Button btnChangeColor;
        private System.Windows.Forms.Label lblPlayerName;
        public System.Windows.Forms.TextBox tbxPlayerName;
        private System.Windows.Forms.ColorDialog cdlColor;
    }
}
