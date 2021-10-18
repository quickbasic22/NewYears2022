namespace NewYearsEve
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelCurrentDays = new System.Windows.Forms.Label();
            this.labelCurrentHours = new System.Windows.Forms.Label();
            this.labelCurrentMinutes = new System.Windows.Forms.Label();
            this.labelCurrentSeconds = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelHours = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 96F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.HotPink;
            this.label1.Location = new System.Drawing.Point(268, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1039, 147);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Years 2021!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkViolet;
            this.label2.Location = new System.Drawing.Point(142, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 91);
            this.label2.TabIndex = 1;
            this.label2.Text = "Days";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkViolet;
            this.label3.Location = new System.Drawing.Point(443, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(252, 91);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hours";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkViolet;
            this.label4.Location = new System.Drawing.Point(712, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(317, 91);
            this.label4.TabIndex = 3;
            this.label4.Text = "Minutes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkViolet;
            this.label5.Location = new System.Drawing.Point(1053, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(348, 91);
            this.label5.TabIndex = 4;
            this.label5.Text = "Seconds";
            // 
            // labelCurrentDays
            // 
            this.labelCurrentDays.AutoSize = true;
            this.labelCurrentDays.BackColor = System.Drawing.Color.Transparent;
            this.labelCurrentDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentDays.ForeColor = System.Drawing.Color.Blue;
            this.labelCurrentDays.Location = new System.Drawing.Point(138, 452);
            this.labelCurrentDays.Name = "labelCurrentDays";
            this.labelCurrentDays.Size = new System.Drawing.Size(295, 120);
            this.labelCurrentDays.TabIndex = 5;
            this.labelCurrentDays.Text = "Days";
            // 
            // labelCurrentHours
            // 
            this.labelCurrentHours.AutoSize = true;
            this.labelCurrentHours.BackColor = System.Drawing.Color.Transparent;
            this.labelCurrentHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentHours.ForeColor = System.Drawing.Color.Blue;
            this.labelCurrentHours.Location = new System.Drawing.Point(485, 452);
            this.labelCurrentHours.Name = "labelCurrentHours";
            this.labelCurrentHours.Size = new System.Drawing.Size(337, 120);
            this.labelCurrentHours.TabIndex = 6;
            this.labelCurrentHours.Text = "Hours";
            // 
            // labelCurrentMinutes
            // 
            this.labelCurrentMinutes.AutoSize = true;
            this.labelCurrentMinutes.BackColor = System.Drawing.Color.Transparent;
            this.labelCurrentMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentMinutes.ForeColor = System.Drawing.Color.Blue;
            this.labelCurrentMinutes.Location = new System.Drawing.Point(795, 452);
            this.labelCurrentMinutes.Name = "labelCurrentMinutes";
            this.labelCurrentMinutes.Size = new System.Drawing.Size(427, 120);
            this.labelCurrentMinutes.TabIndex = 7;
            this.labelCurrentMinutes.Text = "Minutes";
            // 
            // labelCurrentSeconds
            // 
            this.labelCurrentSeconds.AutoSize = true;
            this.labelCurrentSeconds.BackColor = System.Drawing.Color.Transparent;
            this.labelCurrentSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentSeconds.ForeColor = System.Drawing.Color.Blue;
            this.labelCurrentSeconds.Location = new System.Drawing.Point(1150, 452);
            this.labelCurrentSeconds.Name = "labelCurrentSeconds";
            this.labelCurrentSeconds.Size = new System.Drawing.Size(469, 120);
            this.labelCurrentSeconds.TabIndex = 8;
            this.labelCurrentSeconds.Text = "Seconds";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(641, 589);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 64);
            this.button1.TabIndex = 9;
            this.button1.Text = "Close Form";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelHours
            // 
            this.labelHours.AutoSize = true;
            this.labelHours.BackColor = System.Drawing.Color.Transparent;
            this.labelHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHours.ForeColor = System.Drawing.Color.Purple;
            this.labelHours.Location = new System.Drawing.Point(1071, 625);
            this.labelHours.Name = "labelHours";
            this.labelHours.Size = new System.Drawing.Size(202, 37);
            this.labelHours.TabIndex = 10;
            this.labelHours.Text = "Hours To Go";
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.Control;
            this.progressBar1.ForeColor = System.Drawing.Color.Indigo;
            this.progressBar1.Location = new System.Drawing.Point(346, 49);
            this.progressBar1.Maximum = 365;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(914, 57);
            this.progressBar1.Step = 1;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(900, 800);
            this.AutoScrollMinSize = new System.Drawing.Size(300, 200);
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.Teal;
            this.BackgroundImage = global::NewYearsEve.Properties.Resources.SunsetwithMountains;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1502, 726);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.labelHours);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelCurrentSeconds);
            this.Controls.Add(this.labelCurrentMinutes);
            this.Controls.Add(this.labelCurrentHours);
            this.Controls.Add(this.labelCurrentDays);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "text here";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelCurrentDays;
        private System.Windows.Forms.Label labelCurrentHours;
        private System.Windows.Forms.Label labelCurrentMinutes;
        private System.Windows.Forms.Label labelCurrentSeconds;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelHours;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

