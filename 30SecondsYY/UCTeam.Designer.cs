namespace _30SecondsYY
{
    partial class UCTeam
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
            this.btnRemoveTeam = new System.Windows.Forms.Button();
            this.lblTeamName = new System.Windows.Forms.Label();
            this.tbxTeamName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnRemoveTeam
            // 
            this.btnRemoveTeam.Location = new System.Drawing.Point(120, 3);
            this.btnRemoveTeam.Name = "btnRemoveTeam";
            this.btnRemoveTeam.Size = new System.Drawing.Size(68, 55);
            this.btnRemoveTeam.TabIndex = 13;
            this.btnRemoveTeam.Text = "Remove this team";
            this.btnRemoveTeam.UseVisualStyleBackColor = false;
            this.btnRemoveTeam.Click += new System.EventHandler(this.btnRemoveTeam_Click);
            // 
            // lblTeamName
            // 
            this.lblTeamName.AutoSize = true;
            this.lblTeamName.Location = new System.Drawing.Point(14, 12);
            this.lblTeamName.Name = "lblTeamName";
            this.lblTeamName.Size = new System.Drawing.Size(66, 13);
            this.lblTeamName.TabIndex = 12;
            this.lblTeamName.Text = "Team name:";
            // 
            // tbxTeamName
            // 
            this.tbxTeamName.Location = new System.Drawing.Point(14, 28);
            this.tbxTeamName.Name = "tbxTeamName";
            this.tbxTeamName.Size = new System.Drawing.Size(100, 20);
            this.tbxTeamName.TabIndex = 11;
            this.tbxTeamName.TextChanged += new System.EventHandler(this.tbxTeamName_TextChanged);
            // 
            // UCTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRemoveTeam);
            this.Controls.Add(this.lblTeamName);
            this.Controls.Add(this.tbxTeamName);
            this.Name = "UCTeam";
            this.Size = new System.Drawing.Size(191, 73);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRemoveTeam;
        private System.Windows.Forms.Label lblTeamName;
        public System.Windows.Forms.TextBox tbxTeamName;
    }
}
