namespace Brew
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
            this.gBPI = new System.Windows.Forms.GroupBox();
            this.upPax = new System.Windows.Forms.NumericUpDown();
            this.updAge = new System.Windows.Forms.NumericUpDown();
            this.tBContact = new System.Windows.Forms.TextBox();
            this.tBName = new System.Windows.Forms.TextBox();
            this.lblPax = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.gBAccomodation = new System.Windows.Forms.GroupBox();
            this.cmdExecutive = new System.Windows.Forms.RadioButton();
            this.cmdDeluxe = new System.Windows.Forms.RadioButton();
            this.cmdEconomy = new System.Windows.Forms.RadioButton();
            this.cmdStandard = new System.Windows.Forms.RadioButton();
            this.gBDiscount = new System.Windows.Forms.GroupBox();
            this.cmdVIP = new System.Windows.Forms.RadioButton();
            this.cmdPWD = new System.Windows.Forms.RadioButton();
            this.cmdRegular = new System.Windows.Forms.RadioButton();
            this.cmdSenior = new System.Windows.Forms.RadioButton();
            this.cmdNew = new System.Windows.Forms.RadioButton();
            this.gBBilling = new System.Windows.Forms.GroupBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.lblPayment = new System.Windows.Forms.Label();
            this.tBPayment = new System.Windows.Forms.TextBox();
            this.lblAmountDue = new System.Windows.Forms.Label();
            this.tBAmountDue = new System.Windows.Forms.TextBox();
            this.tBDiscount = new System.Windows.Forms.TextBox();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.tBTotalAmount = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.gBPI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upPax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updAge)).BeginInit();
            this.gBAccomodation.SuspendLayout();
            this.gBDiscount.SuspendLayout();
            this.gBBilling.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBPI
            // 
            this.gBPI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(221)))));
            this.gBPI.Controls.Add(this.upPax);
            this.gBPI.Controls.Add(this.updAge);
            this.gBPI.Controls.Add(this.tBContact);
            this.gBPI.Controls.Add(this.tBName);
            this.gBPI.Controls.Add(this.lblPax);
            this.gBPI.Controls.Add(this.lblAge);
            this.gBPI.Controls.Add(this.lblContact);
            this.gBPI.Controls.Add(this.lblName);
            this.gBPI.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBPI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(106)))), ((int)(((byte)(112)))));
            this.gBPI.Location = new System.Drawing.Point(31, 70);
            this.gBPI.Name = "gBPI";
            this.gBPI.Size = new System.Drawing.Size(423, 167);
            this.gBPI.TabIndex = 0;
            this.gBPI.TabStop = false;
            this.gBPI.Text = "Personal Information";
            this.gBPI.Enter += new System.EventHandler(this.Form1_Load);
            // 
            // upPax
            // 
            this.upPax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(106)))), ((int)(((byte)(112)))));
            this.upPax.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upPax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(221)))));
            this.upPax.Location = new System.Drawing.Point(144, 132);
            this.upPax.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.upPax.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.upPax.Name = "upPax";
            this.upPax.Size = new System.Drawing.Size(41, 26);
            this.upPax.TabIndex = 7;
            this.upPax.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // updAge
            // 
            this.updAge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(106)))), ((int)(((byte)(112)))));
            this.updAge.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.updAge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(221)))));
            this.updAge.Location = new System.Drawing.Point(144, 97);
            this.updAge.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.updAge.Name = "updAge";
            this.updAge.Size = new System.Drawing.Size(41, 25);
            this.updAge.TabIndex = 6;
            this.updAge.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // tBContact
            // 
            this.tBContact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(106)))), ((int)(((byte)(112)))));
            this.tBContact.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.tBContact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(221)))));
            this.tBContact.Location = new System.Drawing.Point(144, 64);
            this.tBContact.Name = "tBContact";
            this.tBContact.Size = new System.Drawing.Size(228, 27);
            this.tBContact.TabIndex = 5;
            this.tBContact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.contactKeypressed);
            // 
            // tBName
            // 
            this.tBName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(106)))), ((int)(((byte)(112)))));
            this.tBName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.tBName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(221)))));
            this.tBName.Location = new System.Drawing.Point(144, 33);
            this.tBName.Name = "tBName";
            this.tBName.Size = new System.Drawing.Size(228, 27);
            this.tBName.TabIndex = 4;
            this.tBName.TextChanged += new System.EventHandler(this.tBName_TextChanged);
            this.tBName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameKeypressed);
            // 
            // lblPax
            // 
            this.lblPax.AutoSize = true;
            this.lblPax.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.lblPax.Location = new System.Drawing.Point(94, 132);
            this.lblPax.Name = "lblPax";
            this.lblPax.Size = new System.Drawing.Size(44, 22);
            this.lblPax.TabIndex = 3;
            this.lblPax.Text = "Pax";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.lblAge.Location = new System.Drawing.Point(92, 100);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(44, 22);
            this.lblAge.TabIndex = 2;
            this.lblAge.Text = "Age";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.lblContact.Location = new System.Drawing.Point(21, 68);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(110, 22);
            this.lblContact.TabIndex = 1;
            this.lblContact.Text = "Contact No";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.lblName.Location = new System.Drawing.Point(73, 36);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(63, 22);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // gBAccomodation
            // 
            this.gBAccomodation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(221)))));
            this.gBAccomodation.Controls.Add(this.cmdExecutive);
            this.gBAccomodation.Controls.Add(this.cmdDeluxe);
            this.gBAccomodation.Controls.Add(this.cmdEconomy);
            this.gBAccomodation.Controls.Add(this.cmdStandard);
            this.gBAccomodation.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            this.gBAccomodation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(106)))), ((int)(((byte)(112)))));
            this.gBAccomodation.Location = new System.Drawing.Point(31, 262);
            this.gBAccomodation.Name = "gBAccomodation";
            this.gBAccomodation.Size = new System.Drawing.Size(212, 213);
            this.gBAccomodation.TabIndex = 2;
            this.gBAccomodation.TabStop = false;
            this.gBAccomodation.Text = "Accomodation";
            this.gBAccomodation.Enter += new System.EventHandler(this.gBAccomodation_Enter);
            // 
            // cmdExecutive
            // 
            this.cmdExecutive.AutoSize = true;
            this.cmdExecutive.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.cmdExecutive.Location = new System.Drawing.Point(11, 156);
            this.cmdExecutive.Name = "cmdExecutive";
            this.cmdExecutive.Size = new System.Drawing.Size(200, 23);
            this.cmdExecutive.TabIndex = 3;
            this.cmdExecutive.TabStop = true;
            this.cmdExecutive.Text = "Executive ($1000.00)";
            this.cmdExecutive.UseVisualStyleBackColor = true;
            this.cmdExecutive.CheckedChanged += new System.EventHandler(this.cmdExecutive_CheckedChanged);
            // 
            // cmdDeluxe
            // 
            this.cmdDeluxe.AutoSize = true;
            this.cmdDeluxe.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.cmdDeluxe.Location = new System.Drawing.Point(11, 114);
            this.cmdDeluxe.Name = "cmdDeluxe";
            this.cmdDeluxe.Size = new System.Drawing.Size(168, 23);
            this.cmdDeluxe.TabIndex = 2;
            this.cmdDeluxe.TabStop = true;
            this.cmdDeluxe.Text = "Deluxe ($850.00)";
            this.cmdDeluxe.UseVisualStyleBackColor = true;
            this.cmdDeluxe.CheckedChanged += new System.EventHandler(this.cmdDeluxe_CheckedChanged);
            // 
            // cmdEconomy
            // 
            this.cmdEconomy.AutoSize = true;
            this.cmdEconomy.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.cmdEconomy.Location = new System.Drawing.Point(11, 72);
            this.cmdEconomy.Name = "cmdEconomy";
            this.cmdEconomy.Size = new System.Drawing.Size(183, 23);
            this.cmdEconomy.TabIndex = 1;
            this.cmdEconomy.TabStop = true;
            this.cmdEconomy.Text = "Economy ($300.00)";
            this.cmdEconomy.UseVisualStyleBackColor = false;
            this.cmdEconomy.CheckedChanged += new System.EventHandler(this.cmdEconomy_CheckedChanged);
            // 
            // cmdStandard
            // 
            this.cmdStandard.AutoSize = true;
            this.cmdStandard.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdStandard.Location = new System.Drawing.Point(11, 29);
            this.cmdStandard.Name = "cmdStandard";
            this.cmdStandard.Size = new System.Drawing.Size(185, 23);
            this.cmdStandard.TabIndex = 0;
            this.cmdStandard.TabStop = true;
            this.cmdStandard.Text = "Standard ($400.00)";
            this.cmdStandard.UseVisualStyleBackColor = true;
            this.cmdStandard.CheckedChanged += new System.EventHandler(this.cmdStandard_CheckedChanged);
            // 
            // gBDiscount
            // 
            this.gBDiscount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(221)))));
            this.gBDiscount.Controls.Add(this.cmdVIP);
            this.gBDiscount.Controls.Add(this.cmdPWD);
            this.gBDiscount.Controls.Add(this.cmdRegular);
            this.gBDiscount.Controls.Add(this.cmdSenior);
            this.gBDiscount.Controls.Add(this.cmdNew);
            this.gBDiscount.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBDiscount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(106)))), ((int)(((byte)(112)))));
            this.gBDiscount.Location = new System.Drawing.Point(249, 262);
            this.gBDiscount.Name = "gBDiscount";
            this.gBDiscount.Size = new System.Drawing.Size(205, 213);
            this.gBDiscount.TabIndex = 3;
            this.gBDiscount.TabStop = false;
            this.gBDiscount.Text = "Discount";
            // 
            // cmdVIP
            // 
            this.cmdVIP.AutoSize = true;
            this.cmdVIP.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.cmdVIP.Location = new System.Drawing.Point(15, 171);
            this.cmdVIP.Name = "cmdVIP";
            this.cmdVIP.Size = new System.Drawing.Size(109, 22);
            this.cmdVIP.TabIndex = 5;
            this.cmdVIP.TabStop = true;
            this.cmdVIP.Text = "VIP (40%)";
            this.cmdVIP.UseVisualStyleBackColor = true;
            this.cmdVIP.CheckedChanged += new System.EventHandler(this.cmdVIP_CheckedChanged);
            // 
            // cmdPWD
            // 
            this.cmdPWD.AutoSize = true;
            this.cmdPWD.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.cmdPWD.Location = new System.Drawing.Point(15, 138);
            this.cmdPWD.Name = "cmdPWD";
            this.cmdPWD.Size = new System.Drawing.Size(118, 22);
            this.cmdPWD.TabIndex = 4;
            this.cmdPWD.TabStop = true;
            this.cmdPWD.Text = "PWD (20%)";
            this.cmdPWD.UseVisualStyleBackColor = true;
            this.cmdPWD.CheckedChanged += new System.EventHandler(this.cmdPWD_CheckedChanged);
            // 
            // cmdRegular
            // 
            this.cmdRegular.AutoSize = true;
            this.cmdRegular.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.cmdRegular.Location = new System.Drawing.Point(15, 72);
            this.cmdRegular.Name = "cmdRegular";
            this.cmdRegular.Size = new System.Drawing.Size(131, 22);
            this.cmdRegular.TabIndex = 3;
            this.cmdRegular.TabStop = true;
            this.cmdRegular.Text = "Regular (5%)";
            this.cmdRegular.UseVisualStyleBackColor = true;
            this.cmdRegular.CheckedChanged += new System.EventHandler(this.cmdRegular_CheckedChanged);
            // 
            // cmdSenior
            // 
            this.cmdSenior.AutoSize = true;
            this.cmdSenior.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.cmdSenior.Location = new System.Drawing.Point(15, 105);
            this.cmdSenior.Name = "cmdSenior";
            this.cmdSenior.Size = new System.Drawing.Size(187, 22);
            this.cmdSenior.TabIndex = 2;
            this.cmdSenior.TabStop = true;
            this.cmdSenior.Text = "Senior Citizen (20%)";
            this.cmdSenior.UseVisualStyleBackColor = true;
            this.cmdSenior.CheckedChanged += new System.EventHandler(this.cmdSenior_CheckedChanged);
            // 
            // cmdNew
            // 
            this.cmdNew.AutoSize = true;
            this.cmdNew.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.cmdNew.Location = new System.Drawing.Point(15, 39);
            this.cmdNew.Name = "cmdNew";
            this.cmdNew.Size = new System.Drawing.Size(139, 22);
            this.cmdNew.TabIndex = 1;
            this.cmdNew.TabStop = true;
            this.cmdNew.Text = "New Customer ";
            this.cmdNew.UseVisualStyleBackColor = true;
            this.cmdNew.CheckedChanged += new System.EventHandler(this.cmdNew_CheckedChanged);
            // 
            // gBBilling
            // 
            this.gBBilling.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(221)))));
            this.gBBilling.Controls.Add(this.btnCalc);
            this.gBBilling.Controls.Add(this.lblPayment);
            this.gBBilling.Controls.Add(this.tBPayment);
            this.gBBilling.Controls.Add(this.lblAmountDue);
            this.gBBilling.Controls.Add(this.tBAmountDue);
            this.gBBilling.Controls.Add(this.tBDiscount);
            this.gBBilling.Controls.Add(this.lblDiscount);
            this.gBBilling.Controls.Add(this.lblTotalAmount);
            this.gBBilling.Controls.Add(this.tBTotalAmount);
            this.gBBilling.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBBilling.ForeColor = System.Drawing.Color.White;
            this.gBBilling.Location = new System.Drawing.Point(495, 70);
            this.gBBilling.Name = "gBBilling";
            this.gBBilling.Size = new System.Drawing.Size(293, 405);
            this.gBBilling.TabIndex = 4;
            this.gBBilling.TabStop = false;
            this.gBBilling.Text = "Billing Information";
            // 
            // btnCalc
            // 
            this.btnCalc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(106)))), ((int)(((byte)(112)))));
            this.btnCalc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(221)))));
            this.btnCalc.Location = new System.Drawing.Point(62, 361);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(186, 36);
            this.btnCalc.TabIndex = 13;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = false;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(106)))), ((int)(((byte)(112)))));
            this.lblPayment.Location = new System.Drawing.Point(84, 295);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(150, 23);
            this.lblPayment.TabIndex = 12;
            this.lblPayment.Text = "Enter Payment";
            // 
            // tBPayment
            // 
            this.tBPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(106)))), ((int)(((byte)(112)))));
            this.tBPayment.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.tBPayment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(221)))));
            this.tBPayment.Location = new System.Drawing.Point(41, 328);
            this.tBPayment.Name = "tBPayment";
            this.tBPayment.Size = new System.Drawing.Size(228, 27);
            this.tBPayment.TabIndex = 11;
            this.tBPayment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Payment_Pressed);
            // 
            // lblAmountDue
            // 
            this.lblAmountDue.AutoSize = true;
            this.lblAmountDue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(106)))), ((int)(((byte)(112)))));
            this.lblAmountDue.Location = new System.Drawing.Point(94, 207);
            this.lblAmountDue.Name = "lblAmountDue";
            this.lblAmountDue.Size = new System.Drawing.Size(128, 23);
            this.lblAmountDue.TabIndex = 10;
            this.lblAmountDue.Text = "Amount Due";
            // 
            // tBAmountDue
            // 
            this.tBAmountDue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(106)))), ((int)(((byte)(112)))));
            this.tBAmountDue.Enabled = false;
            this.tBAmountDue.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.tBAmountDue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(221)))));
            this.tBAmountDue.Location = new System.Drawing.Point(41, 245);
            this.tBAmountDue.Name = "tBAmountDue";
            this.tBAmountDue.Size = new System.Drawing.Size(228, 27);
            this.tBAmountDue.TabIndex = 9;
            // 
            // tBDiscount
            // 
            this.tBDiscount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(106)))), ((int)(((byte)(112)))));
            this.tBDiscount.Enabled = false;
            this.tBDiscount.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.tBDiscount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(221)))));
            this.tBDiscount.Location = new System.Drawing.Point(41, 161);
            this.tBDiscount.Name = "tBDiscount";
            this.tBDiscount.Size = new System.Drawing.Size(228, 27);
            this.tBDiscount.TabIndex = 8;
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(106)))), ((int)(((byte)(112)))));
            this.lblDiscount.Location = new System.Drawing.Point(104, 130);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(94, 23);
            this.lblDiscount.TabIndex = 7;
            this.lblDiscount.Text = "Discount";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(106)))), ((int)(((byte)(112)))));
            this.lblTotalAmount.Location = new System.Drawing.Point(84, 37);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(140, 23);
            this.lblTotalAmount.TabIndex = 6;
            this.lblTotalAmount.Text = "Total Amount";
            // 
            // tBTotalAmount
            // 
            this.tBTotalAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(106)))), ((int)(((byte)(112)))));
            this.tBTotalAmount.Enabled = false;
            this.tBTotalAmount.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.tBTotalAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(221)))));
            this.tBTotalAmount.Location = new System.Drawing.Point(41, 81);
            this.tBTotalAmount.Name = "tBTotalAmount";
            this.tBTotalAmount.Size = new System.Drawing.Size(228, 27);
            this.tBTotalAmount.TabIndex = 5;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(221)))));
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(106)))), ((int)(((byte)(112)))));
            this.lblTitle.Location = new System.Drawing.Point(368, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(119, 45);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Hotel";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(106)))), ((int)(((byte)(112)))));
            this.ClientSize = new System.Drawing.Size(810, 505);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.gBBilling);
            this.Controls.Add(this.gBDiscount);
            this.Controls.Add(this.gBAccomodation);
            this.Controls.Add(this.gBPI);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Name = "Form1";
            this.Text = "Hotel";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Load += new System.EventHandler(this.Form1_Load);
            this.BackgroundImageChanged += new System.EventHandler(this.Form1_BackgroundImageChanged);
            this.gBPI.ResumeLayout(false);
            this.gBPI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upPax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updAge)).EndInit();
            this.gBAccomodation.ResumeLayout(false);
            this.gBAccomodation.PerformLayout();
            this.gBDiscount.ResumeLayout(false);
            this.gBDiscount.PerformLayout();
            this.gBBilling.ResumeLayout(false);
            this.gBBilling.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gBPI;
        private System.Windows.Forms.Label lblPax;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.NumericUpDown upPax;
        private System.Windows.Forms.NumericUpDown updAge;
        private System.Windows.Forms.TextBox tBContact;
        private System.Windows.Forms.TextBox tBName;
        private System.Windows.Forms.GroupBox gBAccomodation;
        private System.Windows.Forms.RadioButton cmdExecutive;
        private System.Windows.Forms.RadioButton cmdDeluxe;
        private System.Windows.Forms.RadioButton cmdEconomy;
        private System.Windows.Forms.RadioButton cmdStandard;
        private System.Windows.Forms.GroupBox gBDiscount;
        private System.Windows.Forms.RadioButton cmdPWD;
        private System.Windows.Forms.RadioButton cmdRegular;
        private System.Windows.Forms.RadioButton cmdSenior;
        private System.Windows.Forms.RadioButton cmdNew;
        private System.Windows.Forms.RadioButton cmdVIP;
        private System.Windows.Forms.GroupBox gBBilling;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.TextBox tBTotalAmount;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblAmountDue;
        private System.Windows.Forms.TextBox tBAmountDue;
        private System.Windows.Forms.TextBox tBDiscount;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.TextBox tBPayment;
        private System.Windows.Forms.Label lblTitle;
    }
}

