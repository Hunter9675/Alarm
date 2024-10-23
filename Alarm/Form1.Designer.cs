namespace Alarm
{
    partial class Alarm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alarm));
            this.ProgramTitleLabel = new System.Windows.Forms.Label();
            this.SoundAlarmButton = new System.Windows.Forms.Button();
            this.AlarmStatusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ProgramTitleLabel
            // 
            this.ProgramTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgramTitleLabel.Location = new System.Drawing.Point(12, 9);
            this.ProgramTitleLabel.Name = "ProgramTitleLabel";
            this.ProgramTitleLabel.Size = new System.Drawing.Size(154, 62);
            this.ProgramTitleLabel.TabIndex = 1;
            this.ProgramTitleLabel.Text = "Alarm";
            // 
            // SoundAlarmButton
            // 
            this.SoundAlarmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoundAlarmButton.Location = new System.Drawing.Point(274, 360);
            this.SoundAlarmButton.Name = "SoundAlarmButton";
            this.SoundAlarmButton.Size = new System.Drawing.Size(198, 89);
            this.SoundAlarmButton.TabIndex = 2;
            this.SoundAlarmButton.Text = "Sound Alarm";
            this.SoundAlarmButton.UseVisualStyleBackColor = true;
            this.SoundAlarmButton.Click += new System.EventHandler(this.SoundAlarmButton_Click_1);
            // 
            // AlarmStatusLabel
            // 
            this.AlarmStatusLabel.BackColor = System.Drawing.Color.LimeGreen;
            this.AlarmStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlarmStatusLabel.Location = new System.Drawing.Point(23, 145);
            this.AlarmStatusLabel.Name = "AlarmStatusLabel";
            this.AlarmStatusLabel.Size = new System.Drawing.Size(436, 131);
            this.AlarmStatusLabel.TabIndex = 3;
            this.AlarmStatusLabel.Text = "The alarm is not currently going off.";
            // 
            // Alarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.AlarmStatusLabel);
            this.Controls.Add(this.SoundAlarmButton);
            this.Controls.Add(this.ProgramTitleLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Alarm";
            this.Text = "Alarm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ProgramTitleLabel;
        private System.Windows.Forms.Button SoundAlarmButton;
        private System.Windows.Forms.Label AlarmStatusLabel;
    }
}
