namespace CMSWinFormsApp
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
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            workerToolStripMenuItem = new ToolStripMenuItem();
            custmerToolStripMenuItem = new ToolStripMenuItem();
            jToolStripMenuItem = new ToolStripMenuItem();
            retToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 25.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(95, 87);
            label1.Name = "label1";
            label1.Size = new Size(593, 48);
            label1.TabIndex = 0;
            label1.Text = "Customer Maintenance Project";
            label1.Click += label1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { workerToolStripMenuItem, custmerToolStripMenuItem, jToolStripMenuItem, retToolStripMenuItem, exitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // workerToolStripMenuItem
            // 
            workerToolStripMenuItem.Name = "workerToolStripMenuItem";
            workerToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.W;
            workerToolStripMenuItem.Size = new Size(77, 24);
            workerToolStripMenuItem.Text = "&Worker";
            // 
            // custmerToolStripMenuItem
            // 
            custmerToolStripMenuItem.Name = "custmerToolStripMenuItem";
            custmerToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.C;
            custmerToolStripMenuItem.Size = new Size(94, 24);
            custmerToolStripMenuItem.Text = "&Customer";
            // 
            // jToolStripMenuItem
            // 
            jToolStripMenuItem.Name = "jToolStripMenuItem";
            jToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.J;
            jToolStripMenuItem.Size = new Size(102, 24);
            jToolStripMenuItem.Text = "&Job Details";
            // 
            // retToolStripMenuItem
            // 
            retToolStripMenuItem.Name = "retToolStripMenuItem";
            retToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.R;
            retToolStripMenuItem.Size = new Size(81, 24);
            retToolStripMenuItem.Text = "&Reports";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.X;
            exitToolStripMenuItem.Size = new Size(49, 24);
            exitToolStripMenuItem.Text = "&Exit";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
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

        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem workerToolStripMenuItem;
        private ToolStripMenuItem custmerToolStripMenuItem;
        private ToolStripMenuItem jToolStripMenuItem;
        private ToolStripMenuItem retToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}