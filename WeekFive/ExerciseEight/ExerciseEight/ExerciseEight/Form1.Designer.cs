
namespace ExerciseEight
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
            this.txtFatGrams = new System.Windows.Forms.TextBox();
            this.txtCarbGrams = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblFatCalories = new System.Windows.Forms.Label();
            this.lblCarbCalories = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFatGrams
            // 
            this.txtFatGrams.Location = new System.Drawing.Point(30, 47);
            this.txtFatGrams.MaxLength = 10;
            this.txtFatGrams.Name = "txtFatGrams";
            this.txtFatGrams.Size = new System.Drawing.Size(100, 20);
            this.txtFatGrams.TabIndex = 0;
            // 
            // txtCarbGrams
            // 
            this.txtCarbGrams.Location = new System.Drawing.Point(30, 103);
            this.txtCarbGrams.MaxLength = 10;
            this.txtCarbGrams.Name = "txtCarbGrams";
            this.txtCarbGrams.Size = new System.Drawing.Size(100, 20);
            this.txtCarbGrams.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fat grams:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Carbohydrate grams:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(151, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "Calculate Calories";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblFatCalories
            // 
            this.lblFatCalories.AutoSize = true;
            this.lblFatCalories.Location = new System.Drawing.Point(300, 54);
            this.lblFatCalories.Name = "lblFatCalories";
            this.lblFatCalories.Size = new System.Drawing.Size(0, 13);
            this.lblFatCalories.TabIndex = 5;
            // 
            // lblCarbCalories
            // 
            this.lblCarbCalories.AutoSize = true;
            this.lblCarbCalories.Location = new System.Drawing.Point(300, 103);
            this.lblCarbCalories.Name = "lblCarbCalories";
            this.lblCarbCalories.Size = new System.Drawing.Size(0, 13);
            this.lblCarbCalories.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 176);
            this.Controls.Add(this.lblCarbCalories);
            this.Controls.Add(this.lblFatCalories);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCarbGrams);
            this.Controls.Add(this.txtFatGrams);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calorie Counter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFatGrams;
        private System.Windows.Forms.TextBox txtCarbGrams;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblFatCalories;
        private System.Windows.Forms.Label lblCarbCalories;
    }
}

