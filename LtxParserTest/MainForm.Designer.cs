namespace LtxParserTest
{
    partial class MainForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageNormal = new System.Windows.Forms.TabPage();
            this.buttonNormalRead = new System.Windows.Forms.Button();
            this.labelNormalFile = new System.Windows.Forms.Label();
            this.textBoxNormalFile = new System.Windows.Forms.TextBox();
            this.tabPageMod = new System.Windows.Forms.TabPage();
            this.buttonModRead = new System.Windows.Forms.Button();
            this.textBoxModFile = new System.Windows.Forms.TextBox();
            this.labelModFile = new System.Windows.Forms.Label();
            this.textBoxModVanillaConfig = new System.Windows.Forms.TextBox();
            this.labelModVanillaConfig = new System.Windows.Forms.Label();
            this.textBoxModModConfig = new System.Windows.Forms.TextBox();
            this.labelModModConfig = new System.Windows.Forms.Label();
            this.tabPageString = new System.Windows.Forms.TabPage();
            this.buttonStringRead = new System.Windows.Forms.Button();
            this.textBoxString = new System.Windows.Forms.TextBox();
            this.labelString = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPageNormal.SuspendLayout();
            this.tabPageMod.SuspendLayout();
            this.tabPageString.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageNormal);
            this.tabControl1.Controls.Add(this.tabPageMod);
            this.tabControl1.Controls.Add(this.tabPageString);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(500, 500);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageNormal
            // 
            this.tabPageNormal.Controls.Add(this.buttonNormalRead);
            this.tabPageNormal.Controls.Add(this.labelNormalFile);
            this.tabPageNormal.Controls.Add(this.textBoxNormalFile);
            this.tabPageNormal.Location = new System.Drawing.Point(4, 22);
            this.tabPageNormal.Name = "tabPageNormal";
            this.tabPageNormal.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNormal.Size = new System.Drawing.Size(492, 474);
            this.tabPageNormal.TabIndex = 0;
            this.tabPageNormal.Text = "Normal Read";
            this.tabPageNormal.UseVisualStyleBackColor = true;
            // 
            // buttonNormalRead
            // 
            this.buttonNormalRead.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNormalRead.Location = new System.Drawing.Point(411, 445);
            this.buttonNormalRead.Name = "buttonNormalRead";
            this.buttonNormalRead.Size = new System.Drawing.Size(75, 23);
            this.buttonNormalRead.TabIndex = 5;
            this.buttonNormalRead.Text = "Read";
            this.buttonNormalRead.UseVisualStyleBackColor = true;
            this.buttonNormalRead.Click += new System.EventHandler(this.buttonNormalRead_Click);
            // 
            // labelNormalFile
            // 
            this.labelNormalFile.AutoSize = true;
            this.labelNormalFile.Location = new System.Drawing.Point(6, 3);
            this.labelNormalFile.Name = "labelNormalFile";
            this.labelNormalFile.Size = new System.Drawing.Size(49, 13);
            this.labelNormalFile.TabIndex = 1;
            this.labelNormalFile.Text = "Root File";
            // 
            // textBoxNormalFile
            // 
            this.textBoxNormalFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNormalFile.Location = new System.Drawing.Point(6, 19);
            this.textBoxNormalFile.Name = "textBoxNormalFile";
            this.textBoxNormalFile.Size = new System.Drawing.Size(480, 20);
            this.textBoxNormalFile.TabIndex = 0;
            // 
            // tabPageMod
            // 
            this.tabPageMod.Controls.Add(this.buttonModRead);
            this.tabPageMod.Controls.Add(this.textBoxModFile);
            this.tabPageMod.Controls.Add(this.labelModFile);
            this.tabPageMod.Controls.Add(this.textBoxModVanillaConfig);
            this.tabPageMod.Controls.Add(this.labelModVanillaConfig);
            this.tabPageMod.Controls.Add(this.textBoxModModConfig);
            this.tabPageMod.Controls.Add(this.labelModModConfig);
            this.tabPageMod.Location = new System.Drawing.Point(4, 22);
            this.tabPageMod.Name = "tabPageMod";
            this.tabPageMod.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMod.Size = new System.Drawing.Size(492, 474);
            this.tabPageMod.TabIndex = 1;
            this.tabPageMod.Text = "Mod Read";
            this.tabPageMod.UseVisualStyleBackColor = true;
            // 
            // buttonModRead
            // 
            this.buttonModRead.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonModRead.Location = new System.Drawing.Point(411, 445);
            this.buttonModRead.Name = "buttonModRead";
            this.buttonModRead.Size = new System.Drawing.Size(75, 23);
            this.buttonModRead.TabIndex = 6;
            this.buttonModRead.Text = "Read";
            this.buttonModRead.UseVisualStyleBackColor = true;
            this.buttonModRead.Click += new System.EventHandler(this.buttonModRead_Click);
            // 
            // textBoxModFile
            // 
            this.textBoxModFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxModFile.Location = new System.Drawing.Point(6, 97);
            this.textBoxModFile.Name = "textBoxModFile";
            this.textBoxModFile.Size = new System.Drawing.Size(480, 20);
            this.textBoxModFile.TabIndex = 5;
            // 
            // labelModFile
            // 
            this.labelModFile.AutoSize = true;
            this.labelModFile.Location = new System.Drawing.Point(6, 81);
            this.labelModFile.Name = "labelModFile";
            this.labelModFile.Size = new System.Drawing.Size(49, 13);
            this.labelModFile.TabIndex = 4;
            this.labelModFile.Text = "Root File";
            // 
            // textBoxModVanillaConfig
            // 
            this.textBoxModVanillaConfig.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxModVanillaConfig.Location = new System.Drawing.Point(6, 58);
            this.textBoxModVanillaConfig.Name = "textBoxModVanillaConfig";
            this.textBoxModVanillaConfig.Size = new System.Drawing.Size(480, 20);
            this.textBoxModVanillaConfig.TabIndex = 3;
            // 
            // labelModVanillaConfig
            // 
            this.labelModVanillaConfig.AutoSize = true;
            this.labelModVanillaConfig.Location = new System.Drawing.Point(6, 42);
            this.labelModVanillaConfig.Name = "labelModVanillaConfig";
            this.labelModVanillaConfig.Size = new System.Drawing.Size(71, 13);
            this.labelModVanillaConfig.TabIndex = 2;
            this.labelModVanillaConfig.Text = "Vanilla Config";
            // 
            // textBoxModModConfig
            // 
            this.textBoxModModConfig.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxModModConfig.Location = new System.Drawing.Point(6, 19);
            this.textBoxModModConfig.Name = "textBoxModModConfig";
            this.textBoxModModConfig.Size = new System.Drawing.Size(480, 20);
            this.textBoxModModConfig.TabIndex = 1;
            // 
            // labelModModConfig
            // 
            this.labelModModConfig.AutoSize = true;
            this.labelModModConfig.Location = new System.Drawing.Point(6, 3);
            this.labelModModConfig.Name = "labelModModConfig";
            this.labelModModConfig.Size = new System.Drawing.Size(61, 13);
            this.labelModModConfig.TabIndex = 0;
            this.labelModModConfig.Text = "Mod Config";
            // 
            // tabPageString
            // 
            this.tabPageString.Controls.Add(this.buttonStringRead);
            this.tabPageString.Controls.Add(this.textBoxString);
            this.tabPageString.Controls.Add(this.labelString);
            this.tabPageString.Location = new System.Drawing.Point(4, 22);
            this.tabPageString.Name = "tabPageString";
            this.tabPageString.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageString.Size = new System.Drawing.Size(492, 474);
            this.tabPageString.TabIndex = 2;
            this.tabPageString.Text = "String Read";
            this.tabPageString.UseVisualStyleBackColor = true;
            // 
            // buttonStringRead
            // 
            this.buttonStringRead.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStringRead.Location = new System.Drawing.Point(411, 445);
            this.buttonStringRead.Name = "buttonStringRead";
            this.buttonStringRead.Size = new System.Drawing.Size(75, 23);
            this.buttonStringRead.TabIndex = 4;
            this.buttonStringRead.Text = "Read";
            this.buttonStringRead.UseVisualStyleBackColor = true;
            this.buttonStringRead.Click += new System.EventHandler(this.buttonStringRead_Click);
            // 
            // textBoxString
            // 
            this.textBoxString.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxString.Location = new System.Drawing.Point(6, 19);
            this.textBoxString.Multiline = true;
            this.textBoxString.Name = "textBoxString";
            this.textBoxString.Size = new System.Drawing.Size(480, 420);
            this.textBoxString.TabIndex = 3;
            // 
            // labelString
            // 
            this.labelString.AutoSize = true;
            this.labelString.Location = new System.Drawing.Point(6, 3);
            this.labelString.Name = "labelString";
            this.labelString.Size = new System.Drawing.Size(34, 13);
            this.labelString.TabIndex = 2;
            this.labelString.Text = "String";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 523);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "MainForm";
            this.Text = "Ltx Parser Test";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageNormal.ResumeLayout(false);
            this.tabPageNormal.PerformLayout();
            this.tabPageMod.ResumeLayout(false);
            this.tabPageMod.PerformLayout();
            this.tabPageString.ResumeLayout(false);
            this.tabPageString.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageNormal;
        private System.Windows.Forms.Button buttonNormalRead;
        private System.Windows.Forms.Label labelNormalFile;
        private System.Windows.Forms.TextBox textBoxNormalFile;
        private System.Windows.Forms.TabPage tabPageMod;
        private System.Windows.Forms.Button buttonModRead;
        private System.Windows.Forms.TextBox textBoxModFile;
        private System.Windows.Forms.Label labelModFile;
        private System.Windows.Forms.TextBox textBoxModVanillaConfig;
        private System.Windows.Forms.Label labelModVanillaConfig;
        private System.Windows.Forms.TextBox textBoxModModConfig;
        private System.Windows.Forms.Label labelModModConfig;
        private System.Windows.Forms.TabPage tabPageString;
        private System.Windows.Forms.Button buttonStringRead;
        private System.Windows.Forms.TextBox textBoxString;
        private System.Windows.Forms.Label labelString;
    }
}

