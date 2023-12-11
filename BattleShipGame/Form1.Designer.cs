namespace BattleShipGame
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
            components = new System.ComponentModel.Container();
            moveTimer = new System.Windows.Forms.Timer(components);
            MeteorTimer = new System.Windows.Forms.Timer(components);
            scoreBox = new Label();
            SuspendLayout();
            // 
            // moveTimer
            // 
            moveTimer.Enabled = true;
            moveTimer.Interval = 12;
            // 
            // scoreBox
            // 
            scoreBox.AutoSize = true;
            scoreBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            scoreBox.Location = new Point(37, 65);
            scoreBox.Name = "scoreBox";
            scoreBox.Size = new Size(24, 28);
            scoreBox.TabIndex = 3;
            scoreBox.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 739);
            Controls.Add(scoreBox);
            Name = "Form1";
            Text = "Form1";
            Paint += Form1_Paint;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer moveTimer;
        private System.Windows.Forms.Timer MeteorTimer;
        private Label scoreBox;
    }
}