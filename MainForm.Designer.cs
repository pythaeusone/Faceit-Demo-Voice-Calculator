﻿namespace FaceitDemoVoiceCalc
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            menuStrip1 = new MenuStrip();
            howToUseToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            changeDemoFolderPathToolStripMenuItem = new ToolStripMenuItem();
            lbl_demoFilePath = new Label();
            tb_demoFilePath = new TextBox();
            dGv_CT = new DataGridView();
            dGv_T = new DataGridView();
            lbl_TeamA = new Label();
            lbl_TeamB = new Label();
            lbl_VS = new Label();
            lbl_byTeam = new Label();
            cb_TeamAP1 = new CheckBox();
            cb_TeamAP2 = new CheckBox();
            cb_TeamAP3 = new CheckBox();
            cb_TeamAP4 = new CheckBox();
            cb_TeamAP5 = new CheckBox();
            cb_TeamBP5 = new CheckBox();
            cb_TeamBP4 = new CheckBox();
            cb_TeamBP3 = new CheckBox();
            cb_TeamBP2 = new CheckBox();
            cb_TeamBP1 = new CheckBox();
            tb_ConsoleCommand = new TextBox();
            cb_AllTeamA = new CheckBox();
            cb_AllTeamB = new CheckBox();
            lbl_ConsolCommand = new Label();
            lbl_ReadInfo = new Label();
            btn_CopyToClipboard = new Button();
            btn_MoveToCSFolder = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dGv_CT).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dGv_T).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { howToUseToolStripMenuItem, aboutToolStripMenuItem, settingsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RightToLeft = RightToLeft.No;
            menuStrip1.Size = new Size(822, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // howToUseToolStripMenuItem
            // 
            howToUseToolStripMenuItem.Name = "howToUseToolStripMenuItem";
            howToUseToolStripMenuItem.Size = new Size(79, 20);
            howToUseToolStripMenuItem.Text = "How to use";
            howToUseToolStripMenuItem.Click += HowToUseToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(52, 20);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += AboutToolStripMenuItem_Click;
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { changeDemoFolderPathToolStripMenuItem });
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(61, 20);
            settingsToolStripMenuItem.Text = "Settings";
            // 
            // changeDemoFolderPathToolStripMenuItem
            // 
            changeDemoFolderPathToolStripMenuItem.Name = "changeDemoFolderPathToolStripMenuItem";
            changeDemoFolderPathToolStripMenuItem.Size = new Size(211, 22);
            changeDemoFolderPathToolStripMenuItem.Text = "Change Demo folder path";
            changeDemoFolderPathToolStripMenuItem.Click += changeDemoFolderPathToolStripMenuItem_Click;
            // 
            // lbl_demoFilePath
            // 
            lbl_demoFilePath.AutoSize = true;
            lbl_demoFilePath.Location = new Point(12, 30);
            lbl_demoFilePath.Name = "lbl_demoFilePath";
            lbl_demoFilePath.Size = new Size(52, 15);
            lbl_demoFilePath.TabIndex = 1;
            lbl_demoFilePath.Text = "Filepath:";
            // 
            // tb_demoFilePath
            // 
            tb_demoFilePath.AllowDrop = true;
            tb_demoFilePath.Location = new Point(70, 27);
            tb_demoFilePath.Name = "tb_demoFilePath";
            tb_demoFilePath.ReadOnly = true;
            tb_demoFilePath.Size = new Size(634, 23);
            tb_demoFilePath.TabIndex = 2;
            tb_demoFilePath.Text = "drop demo File here ...";
            tb_demoFilePath.DragDrop += TB_demoFilePath_DragDrop;
            tb_demoFilePath.DragEnter += TB_demoFilePath_DragEnter;
            // 
            // dGv_CT
            // 
            dGv_CT.AllowUserToAddRows = false;
            dGv_CT.AllowUserToDeleteRows = false;
            dGv_CT.AllowUserToResizeColumns = false;
            dGv_CT.AllowUserToResizeRows = false;
            dGv_CT.BackgroundColor = SystemColors.Control;
            dGv_CT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGv_CT.Enabled = false;
            dGv_CT.Location = new Point(33, 103);
            dGv_CT.MultiSelect = false;
            dGv_CT.Name = "dGv_CT";
            dGv_CT.ReadOnly = true;
            dGv_CT.Size = new Size(325, 150);
            dGv_CT.TabIndex = 3;
            // 
            // dGv_T
            // 
            dGv_T.AllowUserToAddRows = false;
            dGv_T.AllowUserToDeleteRows = false;
            dGv_T.AllowUserToResizeColumns = false;
            dGv_T.AllowUserToResizeRows = false;
            dGv_T.BackgroundColor = SystemColors.Control;
            dGv_T.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGv_T.Enabled = false;
            dGv_T.Location = new Point(458, 103);
            dGv_T.MultiSelect = false;
            dGv_T.Name = "dGv_T";
            dGv_T.ReadOnly = true;
            dGv_T.Size = new Size(325, 150);
            dGv_T.TabIndex = 4;
            // 
            // lbl_TeamA
            // 
            lbl_TeamA.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_TeamA.Location = new Point(12, 73);
            lbl_TeamA.Name = "lbl_TeamA";
            lbl_TeamA.Size = new Size(350, 21);
            lbl_TeamA.TabIndex = 5;
            lbl_TeamA.Text = "Team A";
            lbl_TeamA.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_TeamB
            // 
            lbl_TeamB.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_TeamB.Location = new Point(458, 73);
            lbl_TeamB.Name = "lbl_TeamB";
            lbl_TeamB.Size = new Size(350, 21);
            lbl_TeamB.TabIndex = 6;
            lbl_TeamB.Text = "Team B";
            lbl_TeamB.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_VS
            // 
            lbl_VS.Font = new Font("Comic Sans MS", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_VS.Location = new Point(364, 146);
            lbl_VS.Name = "lbl_VS";
            lbl_VS.Size = new Size(88, 48);
            lbl_VS.TabIndex = 7;
            lbl_VS.Text = "VS";
            lbl_VS.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_byTeam
            // 
            lbl_byTeam.AutoSize = true;
            lbl_byTeam.Enabled = false;
            lbl_byTeam.Location = new Point(643, 393);
            lbl_byTeam.Name = "lbl_byTeam";
            lbl_byTeam.Size = new Size(167, 15);
            lbl_byTeam.TabIndex = 8;
            lbl_byTeam.Text = "by Pythaeus | Team Kinzo 2025";
            // 
            // cb_TeamAP1
            // 
            cb_TeamAP1.AutoSize = true;
            cb_TeamAP1.Enabled = false;
            cb_TeamAP1.Location = new Point(12, 131);
            cb_TeamAP1.Name = "cb_TeamAP1";
            cb_TeamAP1.Size = new Size(15, 14);
            cb_TeamAP1.TabIndex = 9;
            cb_TeamAP1.UseVisualStyleBackColor = true;
            // 
            // cb_TeamAP2
            // 
            cb_TeamAP2.AutoSize = true;
            cb_TeamAP2.Enabled = false;
            cb_TeamAP2.Location = new Point(12, 156);
            cb_TeamAP2.Name = "cb_TeamAP2";
            cb_TeamAP2.Size = new Size(15, 14);
            cb_TeamAP2.TabIndex = 10;
            cb_TeamAP2.UseVisualStyleBackColor = true;
            // 
            // cb_TeamAP3
            // 
            cb_TeamAP3.AutoSize = true;
            cb_TeamAP3.Enabled = false;
            cb_TeamAP3.Location = new Point(12, 181);
            cb_TeamAP3.Name = "cb_TeamAP3";
            cb_TeamAP3.Size = new Size(15, 14);
            cb_TeamAP3.TabIndex = 11;
            cb_TeamAP3.UseVisualStyleBackColor = true;
            // 
            // cb_TeamAP4
            // 
            cb_TeamAP4.AutoSize = true;
            cb_TeamAP4.Enabled = false;
            cb_TeamAP4.Location = new Point(12, 206);
            cb_TeamAP4.Name = "cb_TeamAP4";
            cb_TeamAP4.Size = new Size(15, 14);
            cb_TeamAP4.TabIndex = 12;
            cb_TeamAP4.UseVisualStyleBackColor = true;
            // 
            // cb_TeamAP5
            // 
            cb_TeamAP5.AutoSize = true;
            cb_TeamAP5.Enabled = false;
            cb_TeamAP5.Location = new Point(12, 231);
            cb_TeamAP5.Name = "cb_TeamAP5";
            cb_TeamAP5.Size = new Size(15, 14);
            cb_TeamAP5.TabIndex = 13;
            cb_TeamAP5.UseVisualStyleBackColor = true;
            // 
            // cb_TeamBP5
            // 
            cb_TeamBP5.AutoSize = true;
            cb_TeamBP5.Enabled = false;
            cb_TeamBP5.Location = new Point(793, 231);
            cb_TeamBP5.Name = "cb_TeamBP5";
            cb_TeamBP5.Size = new Size(15, 14);
            cb_TeamBP5.TabIndex = 18;
            cb_TeamBP5.UseVisualStyleBackColor = true;
            // 
            // cb_TeamBP4
            // 
            cb_TeamBP4.AutoSize = true;
            cb_TeamBP4.Enabled = false;
            cb_TeamBP4.Location = new Point(793, 206);
            cb_TeamBP4.Name = "cb_TeamBP4";
            cb_TeamBP4.Size = new Size(15, 14);
            cb_TeamBP4.TabIndex = 17;
            cb_TeamBP4.UseVisualStyleBackColor = true;
            // 
            // cb_TeamBP3
            // 
            cb_TeamBP3.AutoSize = true;
            cb_TeamBP3.Enabled = false;
            cb_TeamBP3.Location = new Point(793, 181);
            cb_TeamBP3.Name = "cb_TeamBP3";
            cb_TeamBP3.Size = new Size(15, 14);
            cb_TeamBP3.TabIndex = 16;
            cb_TeamBP3.UseVisualStyleBackColor = true;
            // 
            // cb_TeamBP2
            // 
            cb_TeamBP2.AutoSize = true;
            cb_TeamBP2.Enabled = false;
            cb_TeamBP2.Location = new Point(793, 156);
            cb_TeamBP2.Name = "cb_TeamBP2";
            cb_TeamBP2.Size = new Size(15, 14);
            cb_TeamBP2.TabIndex = 15;
            cb_TeamBP2.UseVisualStyleBackColor = true;
            // 
            // cb_TeamBP1
            // 
            cb_TeamBP1.AutoSize = true;
            cb_TeamBP1.Enabled = false;
            cb_TeamBP1.Location = new Point(793, 131);
            cb_TeamBP1.Name = "cb_TeamBP1";
            cb_TeamBP1.Size = new Size(15, 14);
            cb_TeamBP1.TabIndex = 14;
            cb_TeamBP1.UseVisualStyleBackColor = true;
            // 
            // tb_ConsoleCommand
            // 
            tb_ConsoleCommand.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tb_ConsoleCommand.Location = new Point(33, 326);
            tb_ConsoleCommand.Name = "tb_ConsoleCommand";
            tb_ConsoleCommand.ReadOnly = true;
            tb_ConsoleCommand.Size = new Size(750, 29);
            tb_ConsoleCommand.TabIndex = 20;
            tb_ConsoleCommand.Text = "select one or more players you would like to hear in the demo ...";
            tb_ConsoleCommand.TextAlign = HorizontalAlignment.Center;
            // 
            // cb_AllTeamA
            // 
            cb_AllTeamA.AutoSize = true;
            cb_AllTeamA.Enabled = false;
            cb_AllTeamA.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cb_AllTeamA.Location = new Point(12, 259);
            cb_AllTeamA.Name = "cb_AllTeamA";
            cb_AllTeamA.Size = new Size(78, 19);
            cb_AllTeamA.TabIndex = 21;
            cb_AllTeamA.Text = "Select All";
            cb_AllTeamA.UseVisualStyleBackColor = true;
            cb_AllTeamA.CheckStateChanged += CB_AllTeamA_CheckStateChanged;
            // 
            // cb_AllTeamB
            // 
            cb_AllTeamB.AutoSize = true;
            cb_AllTeamB.Enabled = false;
            cb_AllTeamB.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cb_AllTeamB.Location = new Point(729, 259);
            cb_AllTeamB.Name = "cb_AllTeamB";
            cb_AllTeamB.RightToLeft = RightToLeft.Yes;
            cb_AllTeamB.Size = new Size(78, 19);
            cb_AllTeamB.TabIndex = 22;
            cb_AllTeamB.Text = "Select All";
            cb_AllTeamB.UseVisualStyleBackColor = true;
            cb_AllTeamB.CheckStateChanged += CB_AllTeamB_CheckStateChanged;
            // 
            // lbl_ConsolCommand
            // 
            lbl_ConsolCommand.Location = new Point(96, 300);
            lbl_ConsolCommand.Name = "lbl_ConsolCommand";
            lbl_ConsolCommand.Size = new Size(627, 23);
            lbl_ConsolCommand.TabIndex = 23;
            lbl_ConsolCommand.Text = "Copy the command below into your CS2 console after you have loaded this demo.";
            lbl_ConsolCommand.TextAlign = ContentAlignment.BottomCenter;
            // 
            // lbl_ReadInfo
            // 
            lbl_ReadInfo.AutoSize = true;
            lbl_ReadInfo.Location = new Point(12, 393);
            lbl_ReadInfo.Name = "lbl_ReadInfo";
            lbl_ReadInfo.Size = new Size(10, 15);
            lbl_ReadInfo.TabIndex = 24;
            lbl_ReadInfo.Text = " ";
            lbl_ReadInfo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btn_CopyToClipboard
            // 
            btn_CopyToClipboard.Enabled = false;
            btn_CopyToClipboard.FlatStyle = FlatStyle.Flat;
            btn_CopyToClipboard.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_CopyToClipboard.Location = new Point(348, 361);
            btn_CopyToClipboard.Name = "btn_CopyToClipboard";
            btn_CopyToClipboard.Size = new Size(120, 25);
            btn_CopyToClipboard.TabIndex = 25;
            btn_CopyToClipboard.Text = "Copy Command";
            btn_CopyToClipboard.UseVisualStyleBackColor = true;
            // 
            // btn_MoveToCSFolder
            // 
            btn_MoveToCSFolder.Enabled = false;
            btn_MoveToCSFolder.FlatStyle = FlatStyle.Flat;
            btn_MoveToCSFolder.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_MoveToCSFolder.Location = new Point(710, 27);
            btn_MoveToCSFolder.Name = "btn_MoveToCSFolder";
            btn_MoveToCSFolder.Size = new Size(100, 23);
            btn_MoveToCSFolder.TabIndex = 26;
            btn_MoveToCSFolder.Text = "Move to CS2";
            btn_MoveToCSFolder.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(822, 417);
            Controls.Add(btn_MoveToCSFolder);
            Controls.Add(btn_CopyToClipboard);
            Controls.Add(lbl_ReadInfo);
            Controls.Add(lbl_ConsolCommand);
            Controls.Add(cb_AllTeamB);
            Controls.Add(cb_AllTeamA);
            Controls.Add(tb_ConsoleCommand);
            Controls.Add(cb_TeamBP5);
            Controls.Add(cb_TeamBP4);
            Controls.Add(cb_TeamBP3);
            Controls.Add(cb_TeamBP2);
            Controls.Add(cb_TeamBP1);
            Controls.Add(cb_TeamAP5);
            Controls.Add(cb_TeamAP4);
            Controls.Add(cb_TeamAP3);
            Controls.Add(cb_TeamAP2);
            Controls.Add(cb_TeamAP1);
            Controls.Add(lbl_byTeam);
            Controls.Add(lbl_VS);
            Controls.Add(lbl_TeamB);
            Controls.Add(lbl_TeamA);
            Controls.Add(dGv_T);
            Controls.Add(dGv_CT);
            Controls.Add(tb_demoFilePath);
            Controls.Add(lbl_demoFilePath);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Faceit Demo Voice Calculator v0.9.2";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dGv_CT).EndInit();
            ((System.ComponentModel.ISupportInitialize)dGv_T).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private Label lbl_demoFilePath;
        private TextBox tb_demoFilePath;
        private DataGridView dGv_CT;
        private DataGridView dGv_T;
        private Label lbl_TeamA;
        private Label lbl_TeamB;
        private Label lbl_VS;
        private Label lbl_byTeam;
        private CheckBox cb_TeamAP1;
        private CheckBox cb_TeamAP2;
        private CheckBox cb_TeamAP3;
        private CheckBox cb_TeamAP4;
        private CheckBox cb_TeamAP5;
        private CheckBox cb_TeamBP5;
        private CheckBox cb_TeamBP4;
        private CheckBox cb_TeamBP3;
        private CheckBox cb_TeamBP2;
        private CheckBox cb_TeamBP1;
        private TextBox tb_ConsoleCommand;
        private CheckBox cb_AllTeamA;
        private CheckBox cb_AllTeamB;
        private Label lbl_ConsolCommand;
        private Label lbl_ReadInfo;
        private ToolStripMenuItem howToUseToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private Button btn_CopyToClipboard;
        private Button btn_MoveToCSFolder;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem changeDemoFolderPathToolStripMenuItem;
    }
}
