
namespace ProjectOne
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblEarthWeight = new System.Windows.Forms.Label();
            this.lblMarsWeight = new System.Windows.Forms.Label();
            this.txtEarthWeight = new System.Windows.Forms.TextBox();
            this.txtMarsWeight = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEarthWeight
            // 
            this.lblEarthWeight.AutoSize = true;
            this.lblEarthWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEarthWeight.Location = new System.Drawing.Point(12, 15);
            this.lblEarthWeight.Name = "lblEarthWeight";
            this.lblEarthWeight.Size = new System.Drawing.Size(197, 20);
            this.lblEarthWeight.TabIndex = 0;
            this.lblEarthWeight.Text = "Enter your weight on Earth";
            // 
            // lblMarsWeight
            // 
            this.lblMarsWeight.AutoSize = true;
            this.lblMarsWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarsWeight.Location = new System.Drawing.Point(55, 115);
            this.lblMarsWeight.Name = "lblMarsWeight";
            this.lblMarsWeight.Size = new System.Drawing.Size(154, 20);
            this.lblMarsWeight.TabIndex = 0;
            this.lblMarsWeight.Text = "Your weight on Mars";
            // 
            // txtEarthWeight
            // 
            this.txtEarthWeight.Location = new System.Drawing.Point(59, 38);
            this.txtEarthWeight.Name = "txtEarthWeight";
            this.txtEarthWeight.Size = new System.Drawing.Size(150, 20);
            this.txtEarthWeight.TabIndex = 1;
            this.txtEarthWeight.Text = "0.000";
            this.txtEarthWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMarsWeight
            // 
            this.txtMarsWeight.Location = new System.Drawing.Point(59, 138);
            this.txtMarsWeight.Name = "txtMarsWeight";
            this.txtMarsWeight.Size = new System.Drawing.Size(150, 20);
            this.txtMarsWeight.TabIndex = 3;
            this.txtMarsWeight.Text = "0.000";
            this.txtMarsWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnConvert
            // 
            this.btnConvert.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnConvert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnConvert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConvert.Location = new System.Drawing.Point(142, 64);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(67, 35);
            this.btnConvert.TabIndex = 2;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 216);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtMarsWeight);
            this.Controls.Add(this.txtEarthWeight);
            this.Controls.Add(this.lblMarsWeight);
            this.Controls.Add(this.lblEarthWeight);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Your Weight on Mars";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEarthWeight;
        private System.Windows.Forms.Label lblMarsWeight;
        private System.Windows.Forms.TextBox txtEarthWeight;
        private System.Windows.Forms.TextBox txtMarsWeight;
        private System.Windows.Forms.Button btnConvert;
    }
}

