namespace MyFirstWiinFrameProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            gbSize = new GroupBox();
            rbLarg = new RadioButton();
            rbMeduim = new RadioButton();
            rbSmall = new RadioButton();
            gbcrustType = new GroupBox();
            rbThickCrust = new RadioButton();
            rbThinCrust = new RadioButton();
            gbToppings = new GroupBox();
            ChkMushrooms = new CheckBox();
            ChkTomatoes = new CheckBox();
            ChkOnion = new CheckBox();
            ChkOLives = new CheckBox();
            ChkExtracheese = new CheckBox();
            ChkGreenPeppers = new CheckBox();
            gbOrderSummary = new GroupBox();
            lblTotalPrice = new TextBox();
            lblWhereToEat = new TextBox();
            lblCrustType = new TextBox();
            lblToppings = new TextBox();
            lblSize = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label7 = new Label();
            label2 = new Label();
            gbwhereToEat = new GroupBox();
            rbTakeOut = new RadioButton();
            rbEatIn = new RadioButton();
            btnOrderPizza = new Button();
            btnReset = new Button();
            gbSize.SuspendLayout();
            gbcrustType.SuspendLayout();
            gbToppings.SuspendLayout();
            gbOrderSummary.SuspendLayout();
            gbwhereToEat.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Times New Roman", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkGoldenrod;
            label1.Location = new Point(126, 38);
            label1.Name = "label1";
            label1.Size = new Size(355, 45);
            label1.TabIndex = 0;
            label1.Text = "MAKE YOUR PIZZA";
            // 
            // gbSize
            // 
            gbSize.BackColor = Color.Transparent;
            gbSize.Controls.Add(rbLarg);
            gbSize.Controls.Add(rbMeduim);
            gbSize.Controls.Add(rbSmall);
            gbSize.FlatStyle = FlatStyle.Flat;
            gbSize.Font = new Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            gbSize.ForeColor = Color.White;
            gbSize.Location = new Point(30, 150);
            gbSize.Name = "gbSize";
            gbSize.Size = new Size(173, 150);
            gbSize.TabIndex = 1;
            gbSize.TabStop = false;
            gbSize.Text = "Size";
            // 
            // rbLarg
            // 
            rbLarg.AutoSize = true;
            rbLarg.ForeColor = Color.White;
            rbLarg.Location = new Point(6, 82);
            rbLarg.Name = "rbLarg";
            rbLarg.Size = new Size(57, 23);
            rbLarg.TabIndex = 3;
            rbLarg.TabStop = true;
            rbLarg.Tag = "50";
            rbLarg.Text = "Larg";
            rbLarg.UseVisualStyleBackColor = true;
            rbLarg.CheckedChanged += rbLarg_CheckedChanged;
            // 
            // rbMeduim
            // 
            rbMeduim.AutoSize = true;
            rbMeduim.Font = new Font("Times New Roman", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            rbMeduim.Location = new Point(6, 57);
            rbMeduim.Name = "rbMeduim";
            rbMeduim.Size = new Size(76, 21);
            rbMeduim.TabIndex = 1;
            rbMeduim.TabStop = true;
            rbMeduim.Tag = "30";
            rbMeduim.Text = "Meduim";
            rbMeduim.UseVisualStyleBackColor = true;
            rbMeduim.CheckedChanged += rbMeduim_CheckedChanged;
            // 
            // rbSmall
            // 
            rbSmall.AutoSize = true;
            rbSmall.BackColor = Color.Transparent;
            rbSmall.Font = new Font("Times New Roman", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            rbSmall.Location = new Point(6, 32);
            rbSmall.Name = "rbSmall";
            rbSmall.Size = new Size(60, 21);
            rbSmall.TabIndex = 0;
            rbSmall.TabStop = true;
            rbSmall.Tag = "20";
            rbSmall.Text = "Small";
            rbSmall.UseVisualStyleBackColor = false;
            rbSmall.CheckedChanged += rbSmall_CheckedChanged;
            // 
            // gbcrustType
            // 
            gbcrustType.BackColor = Color.Transparent;
            gbcrustType.Controls.Add(rbThickCrust);
            gbcrustType.Controls.Add(rbThinCrust);
            gbcrustType.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbcrustType.ForeColor = Color.White;
            gbcrustType.Location = new Point(30, 380);
            gbcrustType.Name = "gbcrustType";
            gbcrustType.Size = new Size(220, 150);
            gbcrustType.TabIndex = 2;
            gbcrustType.TabStop = false;
            gbcrustType.Text = "Crust Types";
            // 
            // rbThickCrust
            // 
            rbThickCrust.AutoSize = true;
            rbThickCrust.Location = new Point(6, 81);
            rbThickCrust.Name = "rbThickCrust";
            rbThickCrust.Size = new Size(98, 23);
            rbThickCrust.TabIndex = 4;
            rbThickCrust.TabStop = true;
            rbThickCrust.Tag = "6";
            rbThickCrust.Text = "Think Crust";
            rbThickCrust.UseVisualStyleBackColor = true;
            rbThickCrust.CheckedChanged += rbThickCrust_CheckedChanged;
            // 
            // rbThinCrust
            // 
            rbThinCrust.AutoSize = true;
            rbThinCrust.Location = new Point(6, 37);
            rbThinCrust.Name = "rbThinCrust";
            rbThinCrust.Size = new Size(90, 23);
            rbThinCrust.TabIndex = 3;
            rbThinCrust.TabStop = true;
            rbThinCrust.Tag = "0";
            rbThinCrust.Text = "Thin Crust";
            rbThinCrust.UseVisualStyleBackColor = true;
            rbThinCrust.CheckedChanged += rbThinCrust_CheckedChanged;
            // 
            // gbToppings
            // 
            gbToppings.BackColor = Color.Transparent;
            gbToppings.Controls.Add(ChkMushrooms);
            gbToppings.Controls.Add(ChkTomatoes);
            gbToppings.Controls.Add(ChkOnion);
            gbToppings.Controls.Add(ChkOLives);
            gbToppings.Controls.Add(ChkExtracheese);
            gbToppings.Controls.Add(ChkGreenPeppers);
            gbToppings.Font = new Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            gbToppings.ForeColor = Color.White;
            gbToppings.Location = new Point(220, 150);
            gbToppings.Name = "gbToppings";
            gbToppings.Size = new Size(276, 150);
            gbToppings.TabIndex = 3;
            gbToppings.TabStop = false;
            gbToppings.Text = "Toopings";
            // 
            // ChkMushrooms
            // 
            ChkMushrooms.AutoSize = true;
            ChkMushrooms.Font = new Font("Times New Roman", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            ChkMushrooms.Location = new Point(6, 47);
            ChkMushrooms.Name = "ChkMushrooms";
            ChkMushrooms.Size = new Size(99, 21);
            ChkMushrooms.TabIndex = 6;
            ChkMushrooms.Tag = "2";
            ChkMushrooms.Text = "Mushrooms";
            ChkMushrooms.UseVisualStyleBackColor = true;
            ChkMushrooms.CheckedChanged += ChkMushrooms_CheckedChanged;
            // 
            // ChkTomatoes
            // 
            ChkTomatoes.AutoSize = true;
            ChkTomatoes.Location = new Point(6, 72);
            ChkTomatoes.Name = "ChkTomatoes";
            ChkTomatoes.Size = new Size(90, 23);
            ChkTomatoes.TabIndex = 7;
            ChkTomatoes.Tag = "2";
            ChkTomatoes.Text = "Tomatoes";
            ChkTomatoes.UseVisualStyleBackColor = true;
            ChkTomatoes.CheckedChanged += ChkTomatoes_CheckedChanged;
            // 
            // ChkOnion
            // 
            ChkOnion.AutoSize = true;
            ChkOnion.Location = new Point(114, 22);
            ChkOnion.Name = "ChkOnion";
            ChkOnion.Size = new Size(67, 23);
            ChkOnion.TabIndex = 8;
            ChkOnion.Tag = "1";
            ChkOnion.Text = "Onion";
            ChkOnion.UseVisualStyleBackColor = true;
            ChkOnion.CheckedChanged += ChkOnion_CheckedChanged;
            // 
            // ChkOLives
            // 
            ChkOLives.AutoSize = true;
            ChkOLives.Location = new Point(113, 47);
            ChkOLives.Name = "ChkOLives";
            ChkOLives.Size = new Size(73, 23);
            ChkOLives.TabIndex = 9;
            ChkOLives.Tag = "2";
            ChkOLives.Text = "OLives";
            ChkOLives.UseVisualStyleBackColor = true;
            ChkOLives.CheckedChanged += ChkOLives_CheckedChanged;
            // 
            // ChkExtracheese
            // 
            ChkExtracheese.AutoSize = true;
            ChkExtracheese.Font = new Font("Times New Roman", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            ChkExtracheese.Location = new Point(6, 22);
            ChkExtracheese.Name = "ChkExtracheese";
            ChkExtracheese.Size = new Size(103, 21);
            ChkExtracheese.TabIndex = 5;
            ChkExtracheese.Tag = "2";
            ChkExtracheese.Text = "Extra Chees";
            ChkExtracheese.UseVisualStyleBackColor = true;
            ChkExtracheese.CheckedChanged += ChkExtracheese_CheckedChanged;
            // 
            // ChkGreenPeppers
            // 
            ChkGreenPeppers.AutoSize = true;
            ChkGreenPeppers.Location = new Point(113, 72);
            ChkGreenPeppers.Name = "ChkGreenPeppers";
            ChkGreenPeppers.Size = new Size(123, 23);
            ChkGreenPeppers.TabIndex = 10;
            ChkGreenPeppers.Tag = "3";
            ChkGreenPeppers.Text = "Green Peppers";
            ChkGreenPeppers.UseVisualStyleBackColor = true;
            ChkGreenPeppers.CheckedChanged += ChkGreenPeppers_CheckedChanged;
            // 
            // gbOrderSummary
            // 
            gbOrderSummary.BackColor = Color.White;
            gbOrderSummary.Controls.Add(lblTotalPrice);
            gbOrderSummary.Controls.Add(lblWhereToEat);
            gbOrderSummary.Controls.Add(lblCrustType);
            gbOrderSummary.Controls.Add(lblToppings);
            gbOrderSummary.Controls.Add(lblSize);
            gbOrderSummary.Controls.Add(label6);
            gbOrderSummary.Controls.Add(label5);
            gbOrderSummary.Controls.Add(label4);
            gbOrderSummary.Controls.Add(label3);
            gbOrderSummary.Controls.Add(label7);
            gbOrderSummary.Controls.Add(label2);
            gbOrderSummary.Location = new Point(601, 343);
            gbOrderSummary.Name = "gbOrderSummary";
            gbOrderSummary.Size = new Size(195, 318);
            gbOrderSummary.TabIndex = 4;
            gbOrderSummary.TabStop = false;
            gbOrderSummary.Text = "Order Summary";
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.BackColor = Color.White;
            lblTotalPrice.BorderStyle = BorderStyle.None;
            lblTotalPrice.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTotalPrice.ForeColor = Color.Black;
            lblTotalPrice.Location = new Point(105, 255);
            lblTotalPrice.Multiline = true;
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.ReadOnly = true;
            lblTotalPrice.Size = new Size(88, 36);
            lblTotalPrice.TabIndex = 17;
            lblTotalPrice.TabStop = false;
            lblTotalPrice.Text = "$0";
            // 
            // lblWhereToEat
            // 
            lblWhereToEat.BackColor = SystemColors.ButtonHighlight;
            lblWhereToEat.BorderStyle = BorderStyle.None;
            lblWhereToEat.Enabled = false;
            lblWhereToEat.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWhereToEat.Location = new Point(106, 195);
            lblWhereToEat.Name = "lblWhereToEat";
            lblWhereToEat.ReadOnly = true;
            lblWhereToEat.Size = new Size(84, 18);
            lblWhereToEat.TabIndex = 16;
            lblWhereToEat.TabStop = false;
            // 
            // lblCrustType
            // 
            lblCrustType.BackColor = SystemColors.ButtonHighlight;
            lblCrustType.BorderStyle = BorderStyle.None;
            lblCrustType.Enabled = false;
            lblCrustType.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCrustType.Location = new Point(79, 150);
            lblCrustType.Name = "lblCrustType";
            lblCrustType.ReadOnly = true;
            lblCrustType.Size = new Size(124, 18);
            lblCrustType.TabIndex = 15;
            lblCrustType.TabStop = false;
            // 
            // lblToppings
            // 
            lblToppings.BackColor = SystemColors.ButtonHighlight;
            lblToppings.BorderStyle = BorderStyle.None;
            lblToppings.Enabled = false;
            lblToppings.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblToppings.Location = new Point(9, 70);
            lblToppings.Multiline = true;
            lblToppings.Name = "lblToppings";
            lblToppings.ReadOnly = true;
            lblToppings.Size = new Size(184, 65);
            lblToppings.TabIndex = 14;
            lblToppings.TabStop = false;
            lblToppings.Text = " No toppings";
            // 
            // lblSize
            // 
            lblSize.BackColor = Color.White;
            lblSize.BorderStyle = BorderStyle.None;
            lblSize.Enabled = false;
            lblSize.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblSize.Location = new Point(119, 20);
            lblSize.Name = "lblSize";
            lblSize.ReadOnly = true;
            lblSize.Size = new Size(84, 18);
            lblSize.TabIndex = 13;
            lblSize.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(5, 226);
            label6.Name = "label6";
            label6.Size = new Size(98, 20);
            label6.TabIndex = 11;
            label6.Text = "Total Price :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(5, 172);
            label5.Name = "label5";
            label5.Size = new Size(106, 20);
            label5.TabIndex = 9;
            label5.Text = "Where To Eat ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(9, 130);
            label4.Name = "label4";
            label4.Size = new Size(91, 20);
            label4.TabIndex = 7;
            label4.Text = "Crust Type :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(9, 38);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 1;
            label3.Text = "Toppings :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(9, 19);
            label7.Name = "label7";
            label7.Size = new Size(44, 20);
            label7.TabIndex = 0;
            label7.Text = "Size :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(10, 19);
            label2.Name = "label2";
            label2.Size = new Size(40, 17);
            label2.TabIndex = 0;
            label2.Text = "Size :";
            // 
            // gbwhereToEat
            // 
            gbwhereToEat.BackColor = Color.Transparent;
            gbwhereToEat.Controls.Add(rbTakeOut);
            gbwhereToEat.Controls.Add(rbEatIn);
            gbwhereToEat.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbwhereToEat.ForeColor = Color.White;
            gbwhereToEat.Location = new Point(266, 392);
            gbwhereToEat.Name = "gbwhereToEat";
            gbwhereToEat.Size = new Size(300, 130);
            gbwhereToEat.TabIndex = 5;
            gbwhereToEat.TabStop = false;
            gbwhereToEat.Text = "Where To Eat ";
            // 
            // rbTakeOut
            // 
            rbTakeOut.AutoSize = true;
            rbTakeOut.Location = new Point(79, 37);
            rbTakeOut.Name = "rbTakeOut";
            rbTakeOut.Size = new Size(84, 23);
            rbTakeOut.TabIndex = 12;
            rbTakeOut.TabStop = true;
            rbTakeOut.Text = "Take Out";
            rbTakeOut.UseVisualStyleBackColor = true;
            rbTakeOut.CheckedChanged += rbTakeOut_CheckedChanged;
            // 
            // rbEatIn
            // 
            rbEatIn.AutoSize = true;
            rbEatIn.Location = new Point(6, 37);
            rbEatIn.Name = "rbEatIn";
            rbEatIn.Size = new Size(63, 23);
            rbEatIn.TabIndex = 11;
            rbEatIn.TabStop = true;
            rbEatIn.Text = "Eat In";
            rbEatIn.UseVisualStyleBackColor = true;
            rbEatIn.CheckedChanged += rbEatIn_CheckedChanged;
            // 
            // btnOrderPizza
            // 
            btnOrderPizza.BackColor = Color.White;
            btnOrderPizza.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOrderPizza.Location = new Point(235, 625);
            btnOrderPizza.Name = "btnOrderPizza";
            btnOrderPizza.Size = new Size(130, 45);
            btnOrderPizza.TabIndex = 13;
            btnOrderPizza.Text = "Order Pizza";
            btnOrderPizza.UseVisualStyleBackColor = false;
            btnOrderPizza.Click += btnOrderPizza_Click_1;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.White;
            btnReset.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReset.Location = new Point(388, 625);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(130, 45);
            btnReset.TabIndex = 14;
            btnReset.Text = "Rest Form";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1050, 745);
            Controls.Add(btnReset);
            Controls.Add(btnOrderPizza);
            Controls.Add(gbwhereToEat);
            Controls.Add(gbOrderSummary);
            Controls.Add(gbToppings);
            Controls.Add(gbcrustType);
            Controls.Add(gbSize);
            Controls.Add(label1);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Italin Pizza";
            TopMost = true;
            gbSize.ResumeLayout(false);
            gbSize.PerformLayout();
            gbcrustType.ResumeLayout(false);
            gbcrustType.PerformLayout();
            gbToppings.ResumeLayout(false);
            gbToppings.PerformLayout();
            gbOrderSummary.ResumeLayout(false);
            gbOrderSummary.PerformLayout();
            gbwhereToEat.ResumeLayout(false);
            gbwhereToEat.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox gbSize;
        private GroupBox gbcrustType;
        private GroupBox gbToppings;
        private GroupBox gbOrderSummary;
        private GroupBox gbwhereToEat;
        private RadioButton rbSmall;
        private RadioButton rbMeduim;
        private RadioButton rbLarg;
        private RadioButton rbThinCrust;
        private RadioButton rbThickCrust;
        private CheckBox ChkMushrooms;
        private CheckBox ChkTomatoes;
        private CheckBox ChkOnion;
        private CheckBox ChkOLives;
        private CheckBox ChkExtracheese;
        private CheckBox ChkGreenPeppers;
        private RadioButton rbEatIn;
        private RadioButton rbTakeOut;
        private Label label3;
        private Label label2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button btnOrderPizza;
        private Button btnReset;
        private TextBox lblSize;
        private TextBox lblCrustType;
        private TextBox lblToppings;
        private TextBox lblWhereToEat;
        private TextBox lblTotalPrice;
        private Label label7;
    }
}
