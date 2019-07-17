namespace JadrovyPanel
{
    partial class ControlPanel
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
            this.components = new System.ComponentModel.Container();
            this.TemperatureProgress = new System.Windows.Forms.ProgressBar();
            this.code = new System.Windows.Forms.Label();
            this.EpisodeTimer = new System.Windows.Forms.Timer(this.components);
            this.TemperatureTimer = new System.Windows.Forms.Timer(this.components);
            this.Password = new System.Windows.Forms.Label();
            this.Stopwatch = new System.Windows.Forms.Label();
            this.SecondTimer = new System.Windows.Forms.Timer(this.components);
            this.TemperatureLabel = new System.Windows.Forms.Label();
            this.NumberCode = new System.Windows.Forms.Label();
            this.Elements = new System.Windows.Forms.Label();
            this.Joke = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TemperatureProgress
            // 
            this.TemperatureProgress.Location = new System.Drawing.Point(12, 451);
            this.TemperatureProgress.Name = "TemperatureProgress";
            this.TemperatureProgress.Size = new System.Drawing.Size(307, 31);
            this.TemperatureProgress.TabIndex = 0;
            this.TemperatureProgress.Value = 50;
            // 
            // code
            // 
            this.code.AutoSize = true;
            this.code.Location = new System.Drawing.Point(9, 28);
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(0, 17);
            this.code.TabIndex = 1;
            // 
            // EpisodeTimer
            // 
            this.EpisodeTimer.Tick += new System.EventHandler(this.EpisodeTimer_Tick);
            // 
            // TemperatureTimer
            // 
            this.TemperatureTimer.Tick += new System.EventHandler(this.TemperatureTimer_Tick);
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Password.Location = new System.Drawing.Point(12, 239);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(131, 69);
            this.Password.TabIndex = 2;
            this.Password.Text = "text";
            // 
            // Stopwatch
            // 
            this.Stopwatch.AutoSize = true;
            this.Stopwatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Stopwatch.Location = new System.Drawing.Point(437, 396);
            this.Stopwatch.Name = "Stopwatch";
            this.Stopwatch.Size = new System.Drawing.Size(255, 91);
            this.Stopwatch.TabIndex = 3;
            this.Stopwatch.Text = "label1";
            // 
            // SecondTimer
            // 
            this.SecondTimer.Tick += new System.EventHandler(this.SecondTimer_Tick);
            // 
            // TemperatureLabel
            // 
            this.TemperatureLabel.AutoSize = true;
            this.TemperatureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TemperatureLabel.Location = new System.Drawing.Point(12, 396);
            this.TemperatureLabel.Name = "TemperatureLabel";
            this.TemperatureLabel.Size = new System.Drawing.Size(188, 52);
            this.TemperatureLabel.TabIndex = 4;
            this.TemperatureLabel.Text = "Teplota:";
            this.TemperatureLabel.Click += new System.EventHandler(this.TemperatureLabel_Click);
            // 
            // NumberCode
            // 
            this.NumberCode.AutoSize = true;
            this.NumberCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NumberCode.Location = new System.Drawing.Point(441, 239);
            this.NumberCode.Name = "NumberCode";
            this.NumberCode.Size = new System.Drawing.Size(131, 69);
            this.NumberCode.TabIndex = 5;
            this.NumberCode.Text = "text";
            // 
            // Elements
            // 
            this.Elements.AutoSize = true;
            this.Elements.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Elements.Location = new System.Drawing.Point(12, 9);
            this.Elements.Name = "Elements";
            this.Elements.Size = new System.Drawing.Size(61, 32);
            this.Elements.TabIndex = 6;
            this.Elements.Text = "text";
            // 
            // Joke
            // 
            this.Joke.AutoSize = true;
            this.Joke.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Joke.Location = new System.Drawing.Point(447, 15);
            this.Joke.Name = "Joke";
            this.Joke.Size = new System.Drawing.Size(61, 32);
            this.Joke.TabIndex = 7;
            this.Joke.Text = "text";
            // 
            // ControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 515);
            this.Controls.Add(this.Joke);
            this.Controls.Add(this.Elements);
            this.Controls.Add(this.NumberCode);
            this.Controls.Add(this.TemperatureLabel);
            this.Controls.Add(this.Stopwatch);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.code);
            this.Controls.Add(this.TemperatureProgress);
            this.Name = "ControlPanel";
            this.Text = "Control panel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ControlPanel_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar TemperatureProgress;
        private System.Windows.Forms.Label code;
        private System.Windows.Forms.Timer EpisodeTimer;
        private System.Windows.Forms.Timer TemperatureTimer;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label Stopwatch;
        private System.Windows.Forms.Timer SecondTimer;
        private System.Windows.Forms.Label TemperatureLabel;
        private System.Windows.Forms.Label NumberCode;
        private System.Windows.Forms.Label Elements;
        private System.Windows.Forms.Label Joke;
    }
}

