
namespace ProjectFour
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
            this.lbWinner = new System.Windows.Forms.Label();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.gbGameBoard = new System.Windows.Forms.GroupBox();
            this.lbTL = new System.Windows.Forms.Label();
            this.lbTM = new System.Windows.Forms.Label();
            this.lbTR = new System.Windows.Forms.Label();
            this.lbML = new System.Windows.Forms.Label();
            this.lbMM = new System.Windows.Forms.Label();
            this.lbMR = new System.Windows.Forms.Label();
            this.lbBL = new System.Windows.Forms.Label();
            this.lbBM = new System.Windows.Forms.Label();
            this.lbBR = new System.Windows.Forms.Label();
            this.gbGameBoard.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbWinner
            // 
            this.lbWinner.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbWinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWinner.Location = new System.Drawing.Point(31, 260);
            this.lbWinner.Name = "lbWinner";
            this.lbWinner.Size = new System.Drawing.Size(213, 30);
            this.lbWinner.TabIndex = 9;
            this.lbWinner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(31, 310);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(94, 30);
            this.btnNewGame.TabIndex = 10;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(148, 310);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(96, 30);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // gbGameBoard
            // 
            this.gbGameBoard.Controls.Add(this.lbTL);
            this.gbGameBoard.Controls.Add(this.lbTM);
            this.gbGameBoard.Controls.Add(this.lbTR);
            this.gbGameBoard.Controls.Add(this.lbML);
            this.gbGameBoard.Controls.Add(this.lbMM);
            this.gbGameBoard.Controls.Add(this.lbMR);
            this.gbGameBoard.Controls.Add(this.lbBL);
            this.gbGameBoard.Controls.Add(this.lbBM);
            this.gbGameBoard.Controls.Add(this.lbBR);
            this.gbGameBoard.Location = new System.Drawing.Point(22, 12);
            this.gbGameBoard.Name = "gbGameBoard";
            this.gbGameBoard.Size = new System.Drawing.Size(232, 236);
            this.gbGameBoard.TabIndex = 12;
            this.gbGameBoard.TabStop = false;
            // 
            // lbTL
            // 
            this.lbTL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbTL.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTL.Location = new System.Drawing.Point(9, 13);
            this.lbTL.Name = "lbTL";
            this.lbTL.Size = new System.Drawing.Size(64, 64);
            this.lbTL.TabIndex = 18;
            this.lbTL.Text = "X";
            this.lbTL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTM
            // 
            this.lbTM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbTM.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTM.Location = new System.Drawing.Point(82, 13);
            this.lbTM.Name = "lbTM";
            this.lbTM.Size = new System.Drawing.Size(64, 64);
            this.lbTM.TabIndex = 19;
            this.lbTM.Text = "X";
            this.lbTM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTR
            // 
            this.lbTR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbTR.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTR.Location = new System.Drawing.Point(158, 13);
            this.lbTR.Name = "lbTR";
            this.lbTR.Size = new System.Drawing.Size(64, 64);
            this.lbTR.TabIndex = 20;
            this.lbTR.Text = "X";
            this.lbTR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbML
            // 
            this.lbML.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbML.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbML.Location = new System.Drawing.Point(9, 87);
            this.lbML.Name = "lbML";
            this.lbML.Size = new System.Drawing.Size(64, 64);
            this.lbML.TabIndex = 21;
            this.lbML.Text = "X";
            this.lbML.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbMM
            // 
            this.lbMM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbMM.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMM.Location = new System.Drawing.Point(82, 87);
            this.lbMM.Name = "lbMM";
            this.lbMM.Size = new System.Drawing.Size(64, 64);
            this.lbMM.TabIndex = 22;
            this.lbMM.Text = "X";
            this.lbMM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbMR
            // 
            this.lbMR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbMR.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMR.Location = new System.Drawing.Point(158, 87);
            this.lbMR.Name = "lbMR";
            this.lbMR.Size = new System.Drawing.Size(64, 64);
            this.lbMR.TabIndex = 23;
            this.lbMR.Text = "X";
            this.lbMR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbBL
            // 
            this.lbBL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBL.Location = new System.Drawing.Point(9, 163);
            this.lbBL.Name = "lbBL";
            this.lbBL.Size = new System.Drawing.Size(64, 64);
            this.lbBL.TabIndex = 24;
            this.lbBL.Text = "X";
            this.lbBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbBM
            // 
            this.lbBM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbBM.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBM.Location = new System.Drawing.Point(82, 163);
            this.lbBM.Name = "lbBM";
            this.lbBM.Size = new System.Drawing.Size(64, 64);
            this.lbBM.TabIndex = 25;
            this.lbBM.Text = "X";
            this.lbBM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbBR
            // 
            this.lbBR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbBR.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBR.Location = new System.Drawing.Point(158, 163);
            this.lbBR.Name = "lbBR";
            this.lbBR.Size = new System.Drawing.Size(64, 64);
            this.lbBR.TabIndex = 26;
            this.lbBR.Text = "X";
            this.lbBR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 366);
            this.Controls.Add(this.gbGameBoard);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.lbWinner);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic-Tac-Toe";
            this.gbGameBoard.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbWinner;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox gbGameBoard;
        private System.Windows.Forms.Label lbBR;
        private System.Windows.Forms.Label lbBM;
        private System.Windows.Forms.Label lbBL;
        private System.Windows.Forms.Label lbMR;
        private System.Windows.Forms.Label lbMM;
        private System.Windows.Forms.Label lbML;
        private System.Windows.Forms.Label lbTR;
        private System.Windows.Forms.Label lbTM;
        private System.Windows.Forms.Label lbTL;
    }
}

