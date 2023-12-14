namespace Component1
{
    partial class Form1
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
            btnRun = new Button();
            btnSyntax = new Button();
            outputPanel = new Panel();
            errorBox = new TextBox();
            singleLineField = new TextBox();
            multiLineField = new TextBox();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            loadToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnRun
            // 
            btnRun.Location = new Point(569, 500);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(110, 49);
            btnRun.TabIndex = 0;
            btnRun.Text = "Run";
            btnRun.UseVisualStyleBackColor = true;
            btnRun.Click += btnRun_Click;
            // 
            // btnSyntax
            // 
            btnSyntax.Location = new Point(702, 500);
            btnSyntax.Name = "btnSyntax";
            btnSyntax.Size = new Size(107, 49);
            btnSyntax.TabIndex = 1;
            btnSyntax.Text = "Syntax";
            btnSyntax.UseVisualStyleBackColor = true;
            // 
            // outputPanel
            // 
            outputPanel.Location = new Point(544, 75);
            outputPanel.Name = "outputPanel";
            outputPanel.Size = new Size(384, 388);
            outputPanel.TabIndex = 2;
            // 
            // errorBox
            // 
            errorBox.Location = new Point(38, 577);
            errorBox.Multiline = true;
            errorBox.Name = "errorBox";
            errorBox.Size = new Size(686, 110);
            errorBox.TabIndex = 3;
            // 
            // singleLineField
            // 
            singleLineField.Location = new Point(38, 522);
            singleLineField.Name = "singleLineField";
            singleLineField.Size = new Size(452, 27);
            singleLineField.TabIndex = 4;
            // 
            // multiLineField
            // 
            multiLineField.Location = new Point(38, 75);
            multiLineField.Multiline = true;
            multiLineField.Name = "multiLineField";
            multiLineField.Size = new Size(452, 388);
            multiLineField.TabIndex = 5;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1019, 28);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveToolStripMenuItem, loadToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(224, 26);
            saveToolStripMenuItem.Text = "Save";
            // 
            // loadToolStripMenuItem
            // 
            loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            loadToolStripMenuItem.Size = new Size(224, 26);
            loadToolStripMenuItem.Text = "Load";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(224, 26);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(55, 24);
            helpToolStripMenuItem.Text = "Help";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1019, 719);
            Controls.Add(singleLineField);
            Controls.Add(multiLineField);
            Controls.Add(errorBox);
            Controls.Add(outputPanel);
            Controls.Add(btnSyntax);
            Controls.Add(btnRun);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRun;
        private Button btnSyntax;
        private Panel outputPanel;
        private TextBox errorBox;
        private TextBox singleLineField;
        private TextBox multiLineField;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem loadToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
    }
}