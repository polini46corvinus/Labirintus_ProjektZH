namespace Labirintus_ProjektZH
{
    partial class GameForm
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
            components = new System.ComponentModel.Container();
            elteltIdoLabel = new Label();
            lepesszamLabel = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // elteltIdoLabel
            // 
            elteltIdoLabel.AutoSize = true;
            elteltIdoLabel.Location = new Point(77, 9);
            elteltIdoLabel.Name = "elteltIdoLabel";
            elteltIdoLabel.Size = new Size(65, 15);
            elteltIdoLabel.TabIndex = 0;
            elteltIdoLabel.Text = "Eltelt idő: 0";
            // 
            // lepesszamLabel
            // 
            lepesszamLabel.AutoSize = true;
            lepesszamLabel.Location = new Point(201, 9);
            lepesszamLabel.Name = "lepesszamLabel";
            lepesszamLabel.Size = new Size(76, 15);
            lepesszamLabel.TabIndex = 1;
            lepesszamLabel.Text = "Lépésszám: 0";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(443, 201);
            Controls.Add(lepesszamLabel);
            Controls.Add(elteltIdoLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "GameForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Játék";
            Load += GameForm_Load;
            KeyDown += GameForm_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label elteltIdoLabel;
        private Label lepesszamLabel;
        private System.Windows.Forms.Timer timer1;
    }
}