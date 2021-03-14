
namespace ExerciseFour
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
            this.txtSeconds = new System.Windows.Forms.TextBox();
            this.lblSeconds = new System.Windows.Forms.Label();
            this.lblMinutesLabel = new System.Windows.Forms.Label();
            this.lblHoursLabel = new System.Windows.Forms.Label();
            this.lblDaysLabel = new System.Windows.Forms.Label();
            this.lblMinutes = new System.Windows.Forms.Label();
            this.lblHours = new System.Windows.Forms.Label();
            this.lblDays = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSeconds
            // 
            this.txtSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeconds.Location = new System.Drawing.Point(197, 54);
            this.txtSeconds.MaxLength = 9;
            this.txtSeconds.Name = "txtSeconds";
            this.txtSeconds.Size = new System.Drawing.Size(147, 26);
            this.txtSeconds.TabIndex = 0;
            this.txtSeconds.Text = "0";
            this.txtSeconds.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblSeconds
            // 
            this.lblSeconds.AutoSize = true;
            this.lblSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeconds.Location = new System.Drawing.Point(33, 26);
            this.lblSeconds.Name = "lblSeconds";
            this.lblSeconds.Size = new System.Drawing.Size(484, 25);
            this.lblSeconds.TabIndex = 1;
            this.lblSeconds.Text = "Enter the number of seconds you would like to convert!";
            // 
            // lblMinutesLabel
            // 
            this.lblMinutesLabel.AutoSize = true;
            this.lblMinutesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinutesLabel.Location = new System.Drawing.Point(104, 148);
            this.lblMinutesLabel.Name = "lblMinutesLabel";
            this.lblMinutesLabel.Size = new System.Drawing.Size(65, 20);
            this.lblMinutesLabel.TabIndex = 2;
            this.lblMinutesLabel.Text = "Minutes";
            this.lblMinutesLabel.Visible = false;
            // 
            // lblHoursLabel
            // 
            this.lblHoursLabel.AutoSize = true;
            this.lblHoursLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoursLabel.Location = new System.Drawing.Point(243, 148);
            this.lblHoursLabel.Name = "lblHoursLabel";
            this.lblHoursLabel.Size = new System.Drawing.Size(52, 20);
            this.lblHoursLabel.TabIndex = 3;
            this.lblHoursLabel.Text = "Hours";
            this.lblHoursLabel.Visible = false;
            // 
            // lblDaysLabel
            // 
            this.lblDaysLabel.AutoSize = true;
            this.lblDaysLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDaysLabel.Location = new System.Drawing.Point(387, 148);
            this.lblDaysLabel.Name = "lblDaysLabel";
            this.lblDaysLabel.Size = new System.Drawing.Size(45, 20);
            this.lblDaysLabel.TabIndex = 4;
            this.lblDaysLabel.Text = "Days";
            this.lblDaysLabel.Visible = false;
            // 
            // lblMinutes
            // 
            this.lblMinutes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMinutes.Location = new System.Drawing.Point(66, 168);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMinutes.Size = new System.Drawing.Size(100, 23);
            this.lblMinutes.TabIndex = 5;
            this.lblMinutes.Text = "0";
            this.lblMinutes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblMinutes.Visible = false;
            // 
            // lblHours
            // 
            this.lblHours.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHours.Location = new System.Drawing.Point(192, 168);
            this.lblHours.Name = "lblHours";
            this.lblHours.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblHours.Size = new System.Drawing.Size(100, 23);
            this.lblHours.TabIndex = 6;
            this.lblHours.Text = "0";
            this.lblHours.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblHours.Visible = false;
            // 
            // lblDays
            // 
            this.lblDays.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDays.Location = new System.Drawing.Point(332, 168);
            this.lblDays.Name = "lblDays";
            this.lblDays.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDays.Size = new System.Drawing.Size(100, 23);
            this.lblDays.TabIndex = 7;
            this.lblDays.Text = "0";
            this.lblDays.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDays.Visible = false;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(203, 108);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(135, 37);
            this.btnCalc.TabIndex = 8;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 226);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.lblDays);
            this.Controls.Add(this.lblHours);
            this.Controls.Add(this.lblMinutes);
            this.Controls.Add(this.lblDaysLabel);
            this.Controls.Add(this.lblHoursLabel);
            this.Controls.Add(this.lblMinutesLabel);
            this.Controls.Add(this.lblSeconds);
            this.Controls.Add(this.txtSeconds);
            this.Name = "Form1";
            this.Text = "Seconds Conversion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSeconds;
        private System.Windows.Forms.Label lblSeconds;
        private System.Windows.Forms.Label lblMinutesLabel;
        private System.Windows.Forms.Label lblHoursLabel;
        private System.Windows.Forms.Label lblDaysLabel;
        private System.Windows.Forms.Label lblMinutes;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.Button btnCalc;
    }
}

