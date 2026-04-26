namespace cs2_skins_market
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
            flpSkins = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // flpSkins
            // 
            flpSkins.AutoScroll = true;
            flpSkins.Dock = DockStyle.Fill;
            flpSkins.Location = new Point(0, 0);
            flpSkins.Margin = new Padding(3, 2, 3, 2);
            flpSkins.Name = "flpSkins";
            flpSkins.Size = new Size(800, 450);
            flpSkins.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(800, 450);
            Controls.Add(flpSkins);
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flpSkins;
    }
}
