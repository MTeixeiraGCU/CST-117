
namespace ExerciseSix
{
    partial class SidesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SidesForm));
            this.lblSidesInfo = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.txtSides = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblSidesInfo
            // 
            this.lblSidesInfo.AutoSize = true;
            this.lblSidesInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSidesInfo.Location = new System.Drawing.Point(27, 34);
            this.lblSidesInfo.Name = "lblSidesInfo";
            this.lblSidesInfo.Size = new System.Drawing.Size(562, 26);
            this.lblSidesInfo.TabIndex = 0;
            this.lblSidesInfo.Text = "How many sides would you like the dice to have (4 - 20)?";
            // 
            // btnChange
            // 
            this.btnChange.BackColor = System.Drawing.Color.DarkCyan;
            this.btnChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChange.Location = new System.Drawing.Point(277, 98);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(114, 41);
            this.btnChange.TabIndex = 1;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // txtSides
            // 
            this.txtSides.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSides.Location = new System.Drawing.Point(144, 103);
            this.txtSides.MaxLength = 2;
            this.txtSides.Name = "txtSides";
            this.txtSides.Size = new System.Drawing.Size(100, 32);
            this.txtSides.TabIndex = 2;
            // 
            // SidesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(619, 189);
            this.ControlBox = false;
            this.Controls.Add(this.txtSides);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.lblSidesInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SidesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change the die sides";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSidesInfo;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.TextBox txtSides;
    }
}