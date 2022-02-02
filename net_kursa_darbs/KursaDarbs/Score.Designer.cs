namespace KursaDarbs
{
    partial class frmScore
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
            System.Windows.Forms.Label lblScore;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmScore));
            this.lvwScore = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.playerScore = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnBack = new System.Windows.Forms.Button();
            lblScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Font = new System.Drawing.Font("Ravie", 20.25F);
            lblScore.Location = new System.Drawing.Point(317, 26);
            lblScore.Name = "lblScore";
            lblScore.Size = new System.Drawing.Size(117, 36);
            lblScore.TabIndex = 0;
            lblScore.Text = "Score";
            lblScore.Click += new System.EventHandler(this.lblScore_Click);
            // 
            // lvwScore
            // 
            this.lvwScore.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.playerScore});
            this.lvwScore.Font = new System.Drawing.Font("Ravie", 20.25F);
            this.lvwScore.HideSelection = false;
            this.lvwScore.Location = new System.Drawing.Point(195, 84);
            this.lvwScore.Name = "lvwScore";
            this.lvwScore.Size = new System.Drawing.Size(399, 226);
            this.lvwScore.TabIndex = 1;
            this.lvwScore.UseCompatibleStateImageBehavior = false;
            this.lvwScore.View = System.Windows.Forms.View.Details;
            this.lvwScore.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // name
            // 
            this.name.Text = "Name";
            this.name.Width = 246;
            // 
            // playerScore
            // 
            this.playerScore.Text = "Score";
            this.playerScore.Width = 118;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Ravie", 20.25F);
            this.btnBack.Location = new System.Drawing.Point(265, 316);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(250, 50);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lvwScore);
            this.Controls.Add(lblScore);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmScore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Score";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmScore_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView lvwScore;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader playerScore;
        private System.Windows.Forms.Button btnBack;
    }
}