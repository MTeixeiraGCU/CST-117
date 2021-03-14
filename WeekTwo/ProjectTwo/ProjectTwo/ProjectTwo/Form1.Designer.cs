
namespace ProjectTwo
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
            this.gbType = new System.Windows.Forms.GroupBox();
            this.rbStrawberry = new System.Windows.Forms.RadioButton();
            this.rbChocolate = new System.Windows.Forms.RadioButton();
            this.rbVanilla = new System.Windows.Forms.RadioButton();
            this.gbToppings = new System.Windows.Forms.GroupBox();
            this.cbCherries = new System.Windows.Forms.CheckBox();
            this.cbSyrup = new System.Windows.Forms.CheckBox();
            this.cbGummies = new System.Windows.Forms.CheckBox();
            this.cbNuts = new System.Windows.Forms.CheckBox();
            this.cbSprinkles = new System.Windows.Forms.CheckBox();
            this.btnCost = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lbSize = new System.Windows.Forms.ListBox();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblIceCreamLabel = new System.Windows.Forms.Label();
            this.lblIceCream = new System.Windows.Forms.Label();
            this.lblCostLabel = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblIceCreamTwo = new System.Windows.Forms.Label();
            this.gbType.SuspendLayout();
            this.gbToppings.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbType
            // 
            this.gbType.Controls.Add(this.rbStrawberry);
            this.gbType.Controls.Add(this.rbChocolate);
            this.gbType.Controls.Add(this.rbVanilla);
            this.gbType.Location = new System.Drawing.Point(82, 151);
            this.gbType.Name = "gbType";
            this.gbType.Size = new System.Drawing.Size(145, 100);
            this.gbType.TabIndex = 0;
            this.gbType.TabStop = false;
            this.gbType.Text = "Ice Cream Type";
            // 
            // rbStrawberry
            // 
            this.rbStrawberry.AutoSize = true;
            this.rbStrawberry.Location = new System.Drawing.Point(28, 65);
            this.rbStrawberry.Name = "rbStrawberry";
            this.rbStrawberry.Size = new System.Drawing.Size(75, 17);
            this.rbStrawberry.TabIndex = 2;
            this.rbStrawberry.TabStop = true;
            this.rbStrawberry.Text = "Strawberry";
            this.rbStrawberry.UseVisualStyleBackColor = true;
            // 
            // rbChocolate
            // 
            this.rbChocolate.AutoSize = true;
            this.rbChocolate.Location = new System.Drawing.Point(28, 42);
            this.rbChocolate.Name = "rbChocolate";
            this.rbChocolate.Size = new System.Drawing.Size(73, 17);
            this.rbChocolate.TabIndex = 1;
            this.rbChocolate.TabStop = true;
            this.rbChocolate.Text = "Chocolate";
            this.rbChocolate.UseVisualStyleBackColor = true;
            // 
            // rbVanilla
            // 
            this.rbVanilla.AutoSize = true;
            this.rbVanilla.Location = new System.Drawing.Point(28, 19);
            this.rbVanilla.Name = "rbVanilla";
            this.rbVanilla.Size = new System.Drawing.Size(56, 17);
            this.rbVanilla.TabIndex = 0;
            this.rbVanilla.TabStop = true;
            this.rbVanilla.Text = "Vanilla";
            this.rbVanilla.UseVisualStyleBackColor = true;
            // 
            // gbToppings
            // 
            this.gbToppings.Controls.Add(this.cbCherries);
            this.gbToppings.Controls.Add(this.cbSyrup);
            this.gbToppings.Controls.Add(this.cbGummies);
            this.gbToppings.Controls.Add(this.cbNuts);
            this.gbToppings.Controls.Add(this.cbSprinkles);
            this.gbToppings.Location = new System.Drawing.Point(274, 93);
            this.gbToppings.Name = "gbToppings";
            this.gbToppings.Size = new System.Drawing.Size(215, 158);
            this.gbToppings.TabIndex = 1;
            this.gbToppings.TabStop = false;
            this.gbToppings.Text = "Toppings (one free, $1.90 for each extra)";
            // 
            // cbCherries
            // 
            this.cbCherries.AutoSize = true;
            this.cbCherries.Location = new System.Drawing.Point(28, 135);
            this.cbCherries.Name = "cbCherries";
            this.cbCherries.Size = new System.Drawing.Size(64, 17);
            this.cbCherries.TabIndex = 4;
            this.cbCherries.Text = "Cherries";
            this.cbCherries.UseVisualStyleBackColor = true;
            // 
            // cbSyrup
            // 
            this.cbSyrup.AutoSize = true;
            this.cbSyrup.Location = new System.Drawing.Point(28, 111);
            this.cbSyrup.Name = "cbSyrup";
            this.cbSyrup.Size = new System.Drawing.Size(98, 17);
            this.cbSyrup.TabIndex = 3;
            this.cbSyrup.Text = "Chcolate Syrup";
            this.cbSyrup.UseVisualStyleBackColor = true;
            // 
            // cbGummies
            // 
            this.cbGummies.AutoSize = true;
            this.cbGummies.Location = new System.Drawing.Point(28, 87);
            this.cbGummies.Name = "cbGummies";
            this.cbGummies.Size = new System.Drawing.Size(94, 17);
            this.cbGummies.TabIndex = 2;
            this.cbGummies.Text = "Gummie Bears";
            this.cbGummies.UseVisualStyleBackColor = true;
            // 
            // cbNuts
            // 
            this.cbNuts.AutoSize = true;
            this.cbNuts.Location = new System.Drawing.Point(28, 63);
            this.cbNuts.Name = "cbNuts";
            this.cbNuts.Size = new System.Drawing.Size(48, 17);
            this.cbNuts.TabIndex = 1;
            this.cbNuts.Text = "Nuts";
            this.cbNuts.UseVisualStyleBackColor = true;
            // 
            // cbSprinkles
            // 
            this.cbSprinkles.AutoSize = true;
            this.cbSprinkles.Location = new System.Drawing.Point(28, 39);
            this.cbSprinkles.Name = "cbSprinkles";
            this.cbSprinkles.Size = new System.Drawing.Size(69, 17);
            this.cbSprinkles.TabIndex = 0;
            this.cbSprinkles.Text = "Sprinkles";
            this.cbSprinkles.UseVisualStyleBackColor = true;
            // 
            // btnCost
            // 
            this.btnCost.Location = new System.Drawing.Point(119, 273);
            this.btnCost.Name = "btnCost";
            this.btnCost.Size = new System.Drawing.Size(121, 33);
            this.btnCost.TabIndex = 2;
            this.btnCost.Text = "Price";
            this.btnCost.UseVisualStyleBackColor = true;
            this.btnCost.Click += new System.EventHandler(this.btnCost_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(262, 273);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(122, 33);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lbSize
            // 
            this.lbSize.FormattingEnabled = true;
            this.lbSize.Items.AddRange(new object[] {
            "One",
            "Two",
            "Three"});
            this.lbSize.Location = new System.Drawing.Point(82, 84);
            this.lbSize.Name = "lbSize";
            this.lbSize.Size = new System.Drawing.Size(166, 56);
            this.lbSize.TabIndex = 4;
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(82, 65);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(166, 13);
            this.lblSize.TabIndex = 5;
            this.lblSize.Text = "Number of Scoops ($3 per scoop)";
            // 
            // lblIceCreamLabel
            // 
            this.lblIceCreamLabel.AutoSize = true;
            this.lblIceCreamLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIceCreamLabel.Location = new System.Drawing.Point(51, 323);
            this.lblIceCreamLabel.Name = "lblIceCreamLabel";
            this.lblIceCreamLabel.Size = new System.Drawing.Size(82, 20);
            this.lblIceCreamLabel.TabIndex = 6;
            this.lblIceCreamLabel.Text = "Ice Cream";
            this.lblIceCreamLabel.Visible = false;
            // 
            // lblIceCream
            // 
            this.lblIceCream.AutoSize = true;
            this.lblIceCream.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIceCream.Location = new System.Drawing.Point(56, 348);
            this.lblIceCream.Name = "lblIceCream";
            this.lblIceCream.Size = new System.Drawing.Size(51, 20);
            this.lblIceCream.TabIndex = 7;
            this.lblIceCream.Text = "label1";
            this.lblIceCream.Visible = false;
            // 
            // lblCostLabel
            // 
            this.lblCostLabel.AutoSize = true;
            this.lblCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostLabel.Location = new System.Drawing.Point(51, 397);
            this.lblCostLabel.Name = "lblCostLabel";
            this.lblCostLabel.Size = new System.Drawing.Size(42, 20);
            this.lblCostLabel.TabIndex = 8;
            this.lblCostLabel.Text = "Cost";
            this.lblCostLabel.Visible = false;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.Location = new System.Drawing.Point(56, 417);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(51, 20);
            this.lblCost.TabIndex = 9;
            this.lblCost.Text = "label1";
            this.lblCost.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(168, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Make a Selection";
            // 
            // lblIceCreamTwo
            // 
            this.lblIceCreamTwo.AutoSize = true;
            this.lblIceCreamTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIceCreamTwo.Location = new System.Drawing.Point(56, 368);
            this.lblIceCreamTwo.Name = "lblIceCreamTwo";
            this.lblIceCreamTwo.Size = new System.Drawing.Size(51, 20);
            this.lblIceCreamTwo.TabIndex = 11;
            this.lblIceCreamTwo.Text = "label1";
            this.lblIceCreamTwo.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 465);
            this.Controls.Add(this.lblIceCreamTwo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.lblCostLabel);
            this.Controls.Add(this.lblIceCream);
            this.Controls.Add(this.lblIceCreamLabel);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.lbSize);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCost);
            this.Controls.Add(this.gbToppings);
            this.Controls.Add(this.gbType);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Ice Cream Selection";
            this.gbType.ResumeLayout(false);
            this.gbType.PerformLayout();
            this.gbToppings.ResumeLayout(false);
            this.gbToppings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbType;
        private System.Windows.Forms.RadioButton rbStrawberry;
        private System.Windows.Forms.RadioButton rbChocolate;
        private System.Windows.Forms.RadioButton rbVanilla;
        private System.Windows.Forms.GroupBox gbToppings;
        private System.Windows.Forms.CheckBox cbCherries;
        private System.Windows.Forms.CheckBox cbSyrup;
        private System.Windows.Forms.CheckBox cbGummies;
        private System.Windows.Forms.CheckBox cbNuts;
        private System.Windows.Forms.CheckBox cbSprinkles;
        private System.Windows.Forms.Button btnCost;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ListBox lbSize;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblIceCreamLabel;
        private System.Windows.Forms.Label lblIceCream;
        private System.Windows.Forms.Label lblCostLabel;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblIceCreamTwo;
    }
}

