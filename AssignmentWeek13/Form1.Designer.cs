namespace AssignmentWeek13
{
    partial class FormPlayer
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
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblPlayerID = new System.Windows.Forms.Label();
            this.lblTeamNum = new System.Windows.Forms.Label();
            this.lblTeam = new System.Windows.Forms.Label();
            this.lblNationality = new System.Windows.Forms.Label();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbPlayerID = new System.Windows.Forms.TextBox();
            this.tbPlayerName = new System.Windows.Forms.TextBox();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.cbNationality = new System.Windows.Forms.ComboBox();
            this.lblNotOrAvailable = new System.Windows.Forms.Label();
            this.numudTeamNum = new System.Windows.Forms.NumericUpDown();
            this.cbTeam = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numudTeamNum)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(32, 12);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(47, 39);
            this.btnFirst.TabIndex = 0;
            this.btnFirst.Text = "<<";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(99, 12);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(47, 39);
            this.btnPrev.TabIndex = 1;
            this.btnPrev.Text = "<";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(231, 12);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(47, 39);
            this.btnLast.TabIndex = 2;
            this.btnLast.Text = ">>";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(166, 12);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(47, 39);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblPlayerID
            // 
            this.lblPlayerID.AutoSize = true;
            this.lblPlayerID.Location = new System.Drawing.Point(9, 79);
            this.lblPlayerID.Name = "lblPlayerID";
            this.lblPlayerID.Size = new System.Drawing.Size(56, 13);
            this.lblPlayerID.TabIndex = 4;
            this.lblPlayerID.Text = "Player ID :";
            // 
            // lblTeamNum
            // 
            this.lblTeamNum.AutoSize = true;
            this.lblTeamNum.Location = new System.Drawing.Point(7, 251);
            this.lblTeamNum.Name = "lblTeamNum";
            this.lblTeamNum.Size = new System.Drawing.Size(80, 13);
            this.lblTeamNum.TabIndex = 5;
            this.lblTeamNum.Text = "Team Number :";
            // 
            // lblTeam
            // 
            this.lblTeam.AutoSize = true;
            this.lblTeam.Location = new System.Drawing.Point(9, 212);
            this.lblTeam.Name = "lblTeam";
            this.lblTeam.Size = new System.Drawing.Size(40, 13);
            this.lblTeam.TabIndex = 6;
            this.lblTeam.Text = "Team :";
            // 
            // lblNationality
            // 
            this.lblNationality.AutoSize = true;
            this.lblNationality.Location = new System.Drawing.Point(9, 177);
            this.lblNationality.Name = "lblNationality";
            this.lblNationality.Size = new System.Drawing.Size(62, 13);
            this.lblNationality.TabIndex = 7;
            this.lblNationality.Text = "Nationality :";
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(9, 143);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(57, 13);
            this.lblBirthDate.TabIndex = 8;
            this.lblBirthDate.Text = "BirthDate :";
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Location = new System.Drawing.Point(9, 110);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(73, 13);
            this.lblPlayerName.TabIndex = 9;
            this.lblPlayerName.Text = "Player Name :";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(65, 289);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(81, 39);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(166, 289);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(81, 39);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tbPlayerID
            // 
            this.tbPlayerID.Enabled = false;
            this.tbPlayerID.Location = new System.Drawing.Point(93, 79);
            this.tbPlayerID.Name = "tbPlayerID";
            this.tbPlayerID.Size = new System.Drawing.Size(100, 20);
            this.tbPlayerID.TabIndex = 12;
            // 
            // tbPlayerName
            // 
            this.tbPlayerName.Location = new System.Drawing.Point(93, 110);
            this.tbPlayerName.Name = "tbPlayerName";
            this.tbPlayerName.Size = new System.Drawing.Size(165, 20);
            this.tbPlayerName.TabIndex = 13;
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Location = new System.Drawing.Point(93, 143);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(200, 20);
            this.dtpBirthDate.TabIndex = 14;
            // 
            // cbNationality
            // 
            this.cbNationality.FormattingEnabled = true;
            this.cbNationality.Location = new System.Drawing.Point(93, 177);
            this.cbNationality.Name = "cbNationality";
            this.cbNationality.Size = new System.Drawing.Size(121, 21);
            this.cbNationality.TabIndex = 18;
            // 
            // lblNotOrAvailable
            // 
            this.lblNotOrAvailable.AutoSize = true;
            this.lblNotOrAvailable.Location = new System.Drawing.Point(243, 257);
            this.lblNotOrAvailable.Name = "lblNotOrAvailable";
            this.lblNotOrAvailable.Size = new System.Drawing.Size(19, 13);
            this.lblNotOrAvailable.TabIndex = 19;
            this.lblNotOrAvailable.Text = "....";
            // 
            // numudTeamNum
            // 
            this.numudTeamNum.Location = new System.Drawing.Point(93, 251);
            this.numudTeamNum.Name = "numudTeamNum";
            this.numudTeamNum.Size = new System.Drawing.Size(120, 20);
            this.numudTeamNum.TabIndex = 20;
            // 
            // cbTeam
            // 
            this.cbTeam.FormattingEnabled = true;
            this.cbTeam.Location = new System.Drawing.Point(93, 212);
            this.cbTeam.Name = "cbTeam";
            this.cbTeam.Size = new System.Drawing.Size(121, 21);
            this.cbTeam.TabIndex = 21;
            // 
            // FormPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 340);
            this.Controls.Add(this.cbTeam);
            this.Controls.Add(this.numudTeamNum);
            this.Controls.Add(this.lblNotOrAvailable);
            this.Controls.Add(this.cbNationality);
            this.Controls.Add(this.dtpBirthDate);
            this.Controls.Add(this.tbPlayerName);
            this.Controls.Add(this.tbPlayerID);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.lblBirthDate);
            this.Controls.Add(this.lblNationality);
            this.Controls.Add(this.lblTeam);
            this.Controls.Add(this.lblTeamNum);
            this.Controls.Add(this.lblPlayerID);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnFirst);
            this.Name = "FormPlayer";
            this.Text = "Player";
            this.Load += new System.EventHandler(this.FormPlayer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numudTeamNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblPlayerID;
        private System.Windows.Forms.Label lblTeamNum;
        private System.Windows.Forms.Label lblTeam;
        private System.Windows.Forms.Label lblNationality;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tbPlayerID;
        private System.Windows.Forms.TextBox tbPlayerName;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.ComboBox cbNationality;
        private System.Windows.Forms.Label lblNotOrAvailable;
        private System.Windows.Forms.NumericUpDown numudTeamNum;
        private System.Windows.Forms.ComboBox cbTeam;
    }
}

