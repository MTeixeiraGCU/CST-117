
namespace ProjectThree
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
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.btnFindFile = new System.Windows.Forms.Button();
            this.lblFind = new System.Windows.Forms.Label();
            this.lblAlphaFirst = new System.Windows.Forms.Label();
            this.lblAlphaLast = new System.Windows.Forms.Label();
            this.lblLongest = new System.Windows.Forms.Label();
            this.lblMostVowels = new System.Windows.Forms.Label();
            this.lblAlphaFirstLabel = new System.Windows.Forms.Label();
            this.lblAlphaLastLabel = new System.Windows.Forms.Label();
            this.lblLongestLabel = new System.Windows.Forms.Label();
            this.lblMostVowelsLabel = new System.Windows.Forms.Label();
            this.lblFile = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openFile
            // 
            this.openFile.FileName = "test.txt";
            this.openFile.Filter = "\"txt files (*.txt)|*.txt|All files (*.*)|*.*\"";
            // 
            // btnFindFile
            // 
            this.btnFindFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindFile.Location = new System.Drawing.Point(40, 53);
            this.btnFindFile.Name = "btnFindFile";
            this.btnFindFile.Size = new System.Drawing.Size(124, 39);
            this.btnFindFile.TabIndex = 0;
            this.btnFindFile.Text = "Find File";
            this.btnFindFile.UseVisualStyleBackColor = true;
            this.btnFindFile.Click += new System.EventHandler(this.btnFindFile_Click);
            // 
            // lblFind
            // 
            this.lblFind.AutoSize = true;
            this.lblFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFind.Location = new System.Drawing.Point(22, 26);
            this.lblFind.Name = "lblFind";
            this.lblFind.Size = new System.Drawing.Size(299, 24);
            this.lblFind.TabIndex = 1;
            this.lblFind.Text = "Find a file to parse and search:";
            // 
            // lblAlphaFirst
            // 
            this.lblAlphaFirst.AutoSize = true;
            this.lblAlphaFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlphaFirst.Location = new System.Drawing.Point(22, 171);
            this.lblAlphaFirst.Name = "lblAlphaFirst";
            this.lblAlphaFirst.Size = new System.Drawing.Size(60, 24);
            this.lblAlphaFirst.TabIndex = 2;
            this.lblAlphaFirst.Text = "label1";
            this.lblAlphaFirst.Visible = false;
            // 
            // lblAlphaLast
            // 
            this.lblAlphaLast.AutoSize = true;
            this.lblAlphaLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlphaLast.Location = new System.Drawing.Point(22, 232);
            this.lblAlphaLast.Name = "lblAlphaLast";
            this.lblAlphaLast.Size = new System.Drawing.Size(60, 24);
            this.lblAlphaLast.TabIndex = 3;
            this.lblAlphaLast.Text = "label2";
            this.lblAlphaLast.Visible = false;
            // 
            // lblLongest
            // 
            this.lblLongest.AutoSize = true;
            this.lblLongest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLongest.Location = new System.Drawing.Point(22, 297);
            this.lblLongest.Name = "lblLongest";
            this.lblLongest.Size = new System.Drawing.Size(60, 24);
            this.lblLongest.TabIndex = 4;
            this.lblLongest.Text = "label3";
            this.lblLongest.Visible = false;
            // 
            // lblMostVowels
            // 
            this.lblMostVowels.AutoSize = true;
            this.lblMostVowels.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostVowels.Location = new System.Drawing.Point(22, 364);
            this.lblMostVowels.Name = "lblMostVowels";
            this.lblMostVowels.Size = new System.Drawing.Size(60, 24);
            this.lblMostVowels.TabIndex = 5;
            this.lblMostVowels.Text = "label4";
            this.lblMostVowels.Visible = false;
            // 
            // lblAlphaFirstLabel
            // 
            this.lblAlphaFirstLabel.AutoSize = true;
            this.lblAlphaFirstLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlphaFirstLabel.Location = new System.Drawing.Point(22, 147);
            this.lblAlphaFirstLabel.Name = "lblAlphaFirstLabel";
            this.lblAlphaFirstLabel.Size = new System.Drawing.Size(241, 24);
            this.lblAlphaFirstLabel.TabIndex = 6;
            this.lblAlphaFirstLabel.Text = "First word alphabetically:";
            // 
            // lblAlphaLastLabel
            // 
            this.lblAlphaLastLabel.AutoSize = true;
            this.lblAlphaLastLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlphaLastLabel.Location = new System.Drawing.Point(22, 208);
            this.lblAlphaLastLabel.Name = "lblAlphaLastLabel";
            this.lblAlphaLastLabel.Size = new System.Drawing.Size(238, 24);
            this.lblAlphaLastLabel.TabIndex = 7;
            this.lblAlphaLastLabel.Text = "Last word alphabetically:";
            // 
            // lblLongestLabel
            // 
            this.lblLongestLabel.AutoSize = true;
            this.lblLongestLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLongestLabel.Location = new System.Drawing.Point(22, 273);
            this.lblLongestLabel.Name = "lblLongestLabel";
            this.lblLongestLabel.Size = new System.Drawing.Size(142, 24);
            this.lblLongestLabel.TabIndex = 8;
            this.lblLongestLabel.Text = "Longest word:";
            // 
            // lblMostVowelsLabel
            // 
            this.lblMostVowelsLabel.AutoSize = true;
            this.lblMostVowelsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostVowelsLabel.Location = new System.Drawing.Point(22, 340);
            this.lblMostVowelsLabel.Name = "lblMostVowelsLabel";
            this.lblMostVowelsLabel.Size = new System.Drawing.Size(264, 24);
            this.lblMostVowelsLabel.TabIndex = 9;
            this.lblMostVowelsLabel.Text = "Word with the most vowels:";
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFile.Location = new System.Drawing.Point(22, 104);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(60, 24);
            this.lblFile.TabIndex = 10;
            this.lblFile.Text = "label5";
            this.lblFile.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 438);
            this.Controls.Add(this.lblFile);
            this.Controls.Add(this.lblMostVowelsLabel);
            this.Controls.Add(this.lblLongestLabel);
            this.Controls.Add(this.lblAlphaLastLabel);
            this.Controls.Add(this.lblAlphaFirstLabel);
            this.Controls.Add(this.lblMostVowels);
            this.Controls.Add(this.lblLongest);
            this.Controls.Add(this.lblAlphaLast);
            this.Controls.Add(this.lblAlphaFirst);
            this.Controls.Add(this.lblFind);
            this.Controls.Add(this.btnFindFile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Search and Parse a file";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.Button btnFindFile;
        private System.Windows.Forms.Label lblFind;
        private System.Windows.Forms.Label lblAlphaFirst;
        private System.Windows.Forms.Label lblAlphaLast;
        private System.Windows.Forms.Label lblLongest;
        private System.Windows.Forms.Label lblMostVowels;
        private System.Windows.Forms.Label lblAlphaFirstLabel;
        private System.Windows.Forms.Label lblAlphaLastLabel;
        private System.Windows.Forms.Label lblLongestLabel;
        private System.Windows.Forms.Label lblMostVowelsLabel;
        private System.Windows.Forms.Label lblFile;
    }
}

