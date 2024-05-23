namespace Labirintus_ProjektZH
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
            startButton = new Button();
            kilepesButton = new Button();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(156, 92);
            label1.Name = "label1";
            label1.Size = new Size(165, 30);
            label1.TabIndex = 0;
            label1.Text = "Labirintus játék";
            // 
            // startButton
            // 
            startButton.Location = new Point(201, 153);
            startButton.Name = "startButton";
            startButton.Size = new Size(75, 23);
            startButton.TabIndex = 1;
            startButton.Text = "&START";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // kilepesButton
            // 
            kilepesButton.Location = new Point(201, 185);
            kilepesButton.Name = "kilepesButton";
            kilepesButton.Size = new Size(75, 23);
            kilepesButton.TabIndex = 2;
            kilepesButton.Text = "&Kilépés";
            kilepesButton.UseVisualStyleBackColor = true;
            kilepesButton.Click += kilepesButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(189, 267);
            label2.Name = "label2";
            label2.Size = new Size(98, 15);
            label2.TabIndex = 0;
            label2.Text = "Pause menü: ESC";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(191, 288);
            label3.Name = "label3";
            label3.Size = new Size(95, 15);
            label3.TabIndex = 1;
            label3.Text = "Irányítás: ← ↑→ ↓";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(484, 461);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(kilepesButton);
            Controls.Add(startButton);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximumSize = new Size(500, 500);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Labirintus";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button startButton;
        private Button kilepesButton;
        private Label label2;
        private Label label3;
    }
}
