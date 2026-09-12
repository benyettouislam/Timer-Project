namespace Timer_Project
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
            this.btncurrentclock = new System.Windows.Forms.Button();
            this.btntime = new System.Windows.Forms.Button();
            this.btnstopwatch = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btncurrentclock
            // 
            this.btncurrentclock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btncurrentclock.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncurrentclock.Location = new System.Drawing.Point(490, 65);
            this.btncurrentclock.Name = "btncurrentclock";
            this.btncurrentclock.Size = new System.Drawing.Size(348, 92);
            this.btncurrentclock.TabIndex = 0;
            this.btncurrentclock.Text = "Current Clock";
            this.btncurrentclock.UseVisualStyleBackColor = false;
            this.btncurrentclock.Click += new System.EventHandler(this.btncurrentclock_Click);
            // 
            // btntime
            // 
            this.btntime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btntime.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntime.Location = new System.Drawing.Point(490, 244);
            this.btntime.Name = "btntime";
            this.btntime.Size = new System.Drawing.Size(348, 92);
            this.btntime.TabIndex = 1;
            this.btntime.Text = "Time";
            this.btntime.UseVisualStyleBackColor = false;
            this.btntime.Click += new System.EventHandler(this.btntime_Click);
            // 
            // btnstopwatch
            // 
            this.btnstopwatch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnstopwatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstopwatch.Location = new System.Drawing.Point(490, 424);
            this.btnstopwatch.Name = "btnstopwatch";
            this.btnstopwatch.Size = new System.Drawing.Size(348, 92);
            this.btnstopwatch.TabIndex = 2;
            this.btnstopwatch.Text = "Stop Watch";
            this.btnstopwatch.UseVisualStyleBackColor = false;
            this.btnstopwatch.Click += new System.EventHandler(this.btnstopwatch_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.BackgroundImage = global::Timer_Project.Properties.Resources.close;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(1141, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 65);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1480, 585);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnstopwatch);
            this.Controls.Add(this.btntime);
            this.Controls.Add(this.btncurrentclock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btncurrentclock;
        private System.Windows.Forms.Button btntime;
        private System.Windows.Forms.Button btnstopwatch;
        private System.Windows.Forms.Button button1;
    }
}

