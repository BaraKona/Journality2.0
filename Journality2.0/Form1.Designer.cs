namespace Journality2._0
{
    partial class JournalityMainForm
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
            this.toppanel = new System.Windows.Forms.Panel();
            this.JournalityTitle = new System.Windows.Forms.Label();
            this.MinimiseButton = new System.Windows.Forms.Button();
            this.FullScreenButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.todoLabel = new System.Windows.Forms.Label();
            this.doneLabel = new System.Windows.Forms.Label();
            this.todoButton = new System.Windows.Forms.Button();
            this.toppanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // toppanel
            // 
            this.toppanel.Controls.Add(this.JournalityTitle);
            this.toppanel.Controls.Add(this.MinimiseButton);
            this.toppanel.Controls.Add(this.FullScreenButton);
            this.toppanel.Controls.Add(this.ExitButton);
            this.toppanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.toppanel.Location = new System.Drawing.Point(0, 0);
            this.toppanel.Name = "toppanel";
            this.toppanel.Size = new System.Drawing.Size(1149, 52);
            this.toppanel.TabIndex = 0;
            this.toppanel.Paint += new System.Windows.Forms.PaintEventHandler(this.toppanel_Paint);
            this.toppanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toppanel_MouseDown);
            this.toppanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.toppanel_MouseMove);
            this.toppanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.toppanel_MouseUp);
            // 
            // JournalityTitle
            // 
            this.JournalityTitle.AllowDrop = true;
            this.JournalityTitle.AutoSize = true;
            this.JournalityTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.JournalityTitle.Font = new System.Drawing.Font("Modern No. 20", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JournalityTitle.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.JournalityTitle.Location = new System.Drawing.Point(24, 9);
            this.JournalityTitle.Name = "JournalityTitle";
            this.JournalityTitle.Size = new System.Drawing.Size(198, 41);
            this.JournalityTitle.TabIndex = 4;
            this.JournalityTitle.Text = "Journality";
            this.JournalityTitle.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.JournalityTitle.UseMnemonic = false;
            // 
            // MinimiseButton
            // 
            this.MinimiseButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.MinimiseButton.FlatAppearance.BorderSize = 0;
            this.MinimiseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimiseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimiseButton.ForeColor = System.Drawing.Color.Snow;
            this.MinimiseButton.Location = new System.Drawing.Point(918, 0);
            this.MinimiseButton.Name = "MinimiseButton";
            this.MinimiseButton.Size = new System.Drawing.Size(77, 52);
            this.MinimiseButton.TabIndex = 3;
            this.MinimiseButton.Text = "_";
            this.MinimiseButton.UseVisualStyleBackColor = true;
            // 
            // FullScreenButton
            // 
            this.FullScreenButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.FullScreenButton.FlatAppearance.BorderSize = 0;
            this.FullScreenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FullScreenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullScreenButton.ForeColor = System.Drawing.Color.Snow;
            this.FullScreenButton.Location = new System.Drawing.Point(995, 0);
            this.FullScreenButton.Name = "FullScreenButton";
            this.FullScreenButton.Size = new System.Drawing.Size(77, 52);
            this.FullScreenButton.TabIndex = 2;
            this.FullScreenButton.Text = "O";
            this.FullScreenButton.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            this.ExitButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.Color.Snow;
            this.ExitButton.Location = new System.Drawing.Point(1072, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(77, 52);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "X";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.Silver;
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 52);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(10, 635);
            this.sidePanel.TabIndex = 24;
            // 
            // todoLabel
            // 
            this.todoLabel.AllowDrop = true;
            this.todoLabel.AutoSize = true;
            this.todoLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.todoLabel.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todoLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.todoLabel.Location = new System.Drawing.Point(143, 104);
            this.todoLabel.Name = "todoLabel";
            this.todoLabel.Size = new System.Drawing.Size(79, 22);
            this.todoLabel.TabIndex = 25;
            this.todoLabel.Text = "TO DO:";
            this.todoLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.todoLabel.UseMnemonic = false;
            // 
            // doneLabel
            // 
            this.doneLabel.AllowDrop = true;
            this.doneLabel.AutoSize = true;
            this.doneLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doneLabel.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doneLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.doneLabel.Location = new System.Drawing.Point(523, 104);
            this.doneLabel.Name = "doneLabel";
            this.doneLabel.Size = new System.Drawing.Size(76, 22);
            this.doneLabel.TabIndex = 27;
            this.doneLabel.Text = "DONE:";
            this.doneLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.doneLabel.UseMnemonic = false;
            // 
            // todoButton
            // 
            this.todoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.todoButton.FlatAppearance.BorderSize = 0;
            this.todoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.todoButton.ForeColor = System.Drawing.Color.Snow;
            this.todoButton.Location = new System.Drawing.Point(156, 149);
            this.todoButton.Name = "todoButton";
            this.todoButton.Size = new System.Drawing.Size(50, 50);
            this.todoButton.TabIndex = 28;
            this.todoButton.Text = "+";
            this.todoButton.UseVisualStyleBackColor = false;
            this.todoButton.Click += new System.EventHandler(this.todoButton_Click);
            // 
            // JournalityMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(1149, 687);
            this.Controls.Add(this.todoButton);
            this.Controls.Add(this.doneLabel);
            this.Controls.Add(this.todoLabel);
            this.Controls.Add(this.sidePanel);
            this.Controls.Add(this.toppanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "JournalityMainForm";
            this.Text = "Journality";
            this.toppanel.ResumeLayout(false);
            this.toppanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel toppanel;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label JournalityTitle;
        private System.Windows.Forms.Button MinimiseButton;
        private System.Windows.Forms.Button FullScreenButton;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Label todoLabel;
        private System.Windows.Forms.Label doneLabel;
        private System.Windows.Forms.Button todoButton;
    }
}

