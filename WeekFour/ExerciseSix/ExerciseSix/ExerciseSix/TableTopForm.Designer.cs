
namespace ExerciseSix
{
    partial class TableTopForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableTopForm));
            this.btnRollDice = new System.Windows.Forms.Button();
            this.lblDieOne = new System.Windows.Forms.Label();
            this.lblDieTwo = new System.Windows.Forms.Label();
            this.lblSides = new System.Windows.Forms.Label();
            this.btnChangeSides = new System.Windows.Forms.Button();
            this.btnRollSnakeEyes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRollDice
            // 
            this.btnRollDice.BackColor = System.Drawing.Color.DarkCyan;
            this.btnRollDice.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnRollDice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRollDice.Location = new System.Drawing.Point(9, 151);
            this.btnRollDice.Margin = new System.Windows.Forms.Padding(0);
            this.btnRollDice.Name = "btnRollDice";
            this.btnRollDice.Size = new System.Drawing.Size(103, 45);
            this.btnRollDice.TabIndex = 0;
            this.btnRollDice.Text = "Roll Dice";
            this.btnRollDice.UseVisualStyleBackColor = false;
            this.btnRollDice.Click += new System.EventHandler(this.btnRollDice_Click);
            // 
            // lblDieOne
            // 
            this.lblDieOne.BackColor = System.Drawing.Color.White;
            this.lblDieOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDieOne.Location = new System.Drawing.Point(74, 66);
            this.lblDieOne.Name = "lblDieOne";
            this.lblDieOne.Size = new System.Drawing.Size(64, 64);
            this.lblDieOne.TabIndex = 1;
            this.lblDieOne.Text = "1";
            this.lblDieOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDieTwo
            // 
            this.lblDieTwo.BackColor = System.Drawing.Color.White;
            this.lblDieTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDieTwo.Location = new System.Drawing.Point(190, 66);
            this.lblDieTwo.Name = "lblDieTwo";
            this.lblDieTwo.Size = new System.Drawing.Size(64, 64);
            this.lblDieTwo.TabIndex = 2;
            this.lblDieTwo.Text = "1";
            this.lblDieTwo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSides
            // 
            this.lblSides.AutoSize = true;
            this.lblSides.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSides.ForeColor = System.Drawing.Color.Black;
            this.lblSides.Location = new System.Drawing.Point(116, 31);
            this.lblSides.Name = "lblSides";
            this.lblSides.Size = new System.Drawing.Size(60, 24);
            this.lblSides.TabIndex = 3;
            this.lblSides.Text = "label1";
            // 
            // btnChangeSides
            // 
            this.btnChangeSides.BackColor = System.Drawing.Color.DarkCyan;
            this.btnChangeSides.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnChangeSides.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeSides.Location = new System.Drawing.Point(161, 209);
            this.btnChangeSides.Margin = new System.Windows.Forms.Padding(0);
            this.btnChangeSides.Name = "btnChangeSides";
            this.btnChangeSides.Size = new System.Drawing.Size(151, 45);
            this.btnChangeSides.TabIndex = 4;
            this.btnChangeSides.Text = "Change Dice";
            this.btnChangeSides.UseVisualStyleBackColor = false;
            this.btnChangeSides.Click += new System.EventHandler(this.btnChangeSides_Click);
            // 
            // btnRollSnakeEyes
            // 
            this.btnRollSnakeEyes.BackColor = System.Drawing.Color.DarkCyan;
            this.btnRollSnakeEyes.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnRollSnakeEyes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRollSnakeEyes.Location = new System.Drawing.Point(9, 209);
            this.btnRollSnakeEyes.Margin = new System.Windows.Forms.Padding(0);
            this.btnRollSnakeEyes.Name = "btnRollSnakeEyes";
            this.btnRollSnakeEyes.Size = new System.Drawing.Size(129, 45);
            this.btnRollSnakeEyes.TabIndex = 5;
            this.btnRollSnakeEyes.Text = "Roll Multiple";
            this.btnRollSnakeEyes.UseVisualStyleBackColor = false;
            this.btnRollSnakeEyes.Click += new System.EventHandler(this.btnRollSnakeEyes_Click);
            // 
            // TableTopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(332, 263);
            this.Controls.Add(this.btnRollSnakeEyes);
            this.Controls.Add(this.btnChangeSides);
            this.Controls.Add(this.lblSides);
            this.Controls.Add(this.lblDieTwo);
            this.Controls.Add(this.lblDieOne);
            this.Controls.Add(this.btnRollDice);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TableTopForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Roll the Dice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRollDice;
        private System.Windows.Forms.Label lblDieOne;
        private System.Windows.Forms.Label lblDieTwo;
        private System.Windows.Forms.Label lblSides;
        private System.Windows.Forms.Button btnChangeSides;
        private System.Windows.Forms.Button btnRollSnakeEyes;
    }
}

