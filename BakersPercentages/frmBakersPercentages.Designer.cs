
namespace BakersPercentages
{
    partial class frmBakersPercentages
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBakersPercentages));
            this.lblFlour = new System.Windows.Forms.Label();
            this.txtEnterFlour = new System.Windows.Forms.TextBox();
            this.lblWater = new System.Windows.Forms.Label();
            this.txtEnterWaterPercent = new System.Windows.Forms.TextBox();
            this.lblSalt = new System.Windows.Forms.Label();
            this.txtEnterSaltPercent = new System.Windows.Forms.TextBox();
            this.lblTeast = new System.Windows.Forms.Label();
            this.txtEnterYeastPercent = new System.Windows.Forms.TextBox();
            this.lblSourdoughStarter = new System.Windows.Forms.Label();
            this.txtEnterStarterPercent = new System.Windows.Forms.TextBox();
            this.lblFatOil = new System.Windows.Forms.Label();
            this.txtEnterFatOilPercent = new System.Windows.Forms.TextBox();
            this.lblPercentRatios = new System.Windows.Forms.Label();
            this.txtFlourInputBase = new System.Windows.Forms.TextBox();
            this.txtWaterResultsQuantity = new System.Windows.Forms.TextBox();
            this.txtSaltResultsQuantity = new System.Windows.Forms.TextBox();
            this.txtYeastResultsQuantity = new System.Windows.Forms.TextBox();
            this.txtStarterResultsQuantity = new System.Windows.Forms.TextBox();
            this.txtFatOilResultsQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantityResults = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblFlourBase = new System.Windows.Forms.Label();
            this.lblPerct = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblEqual = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFlour
            // 
            this.lblFlour.AutoSize = true;
            this.lblFlour.Location = new System.Drawing.Point(23, 94);
            this.lblFlour.Name = "lblFlour";
            this.lblFlour.Size = new System.Drawing.Size(137, 13);
            this.lblFlour.TabIndex = 0;
            this.lblFlour.Text = "Flour (Expressed as 100%): ";
            // 
            // txtEnterFlour
            // 
            this.txtEnterFlour.Location = new System.Drawing.Point(159, 90);
            this.txtEnterFlour.Name = "txtEnterFlour";
            this.txtEnterFlour.ReadOnly = true;
            this.txtEnterFlour.Size = new System.Drawing.Size(100, 20);
            this.txtEnterFlour.TabIndex = 99;
            this.txtEnterFlour.TabStop = false;
            this.txtEnterFlour.Text = "100";
            this.txtEnterFlour.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblWater
            // 
            this.lblWater.AutoSize = true;
            this.lblWater.Location = new System.Drawing.Point(114, 130);
            this.lblWater.Name = "lblWater";
            this.lblWater.Size = new System.Drawing.Size(46, 13);
            this.lblWater.TabIndex = 2;
            this.lblWater.Text = "*Water: ";
            // 
            // txtEnterWaterPercent
            // 
            this.txtEnterWaterPercent.Location = new System.Drawing.Point(159, 126);
            this.txtEnterWaterPercent.Name = "txtEnterWaterPercent";
            this.txtEnterWaterPercent.Size = new System.Drawing.Size(100, 20);
            this.txtEnterWaterPercent.TabIndex = 2;
            this.txtEnterWaterPercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtEnterWaterPercent.TextChanged += new System.EventHandler(this.txtEnterWater_TextChanged);
            // 
            // lblSalt
            // 
            this.lblSalt.AutoSize = true;
            this.lblSalt.Location = new System.Drawing.Point(125, 165);
            this.lblSalt.Name = "lblSalt";
            this.lblSalt.Size = new System.Drawing.Size(35, 13);
            this.lblSalt.TabIndex = 4;
            this.lblSalt.Text = "*Salt: ";
            // 
            // txtEnterSaltPercent
            // 
            this.txtEnterSaltPercent.Location = new System.Drawing.Point(159, 161);
            this.txtEnterSaltPercent.Name = "txtEnterSaltPercent";
            this.txtEnterSaltPercent.Size = new System.Drawing.Size(100, 20);
            this.txtEnterSaltPercent.TabIndex = 3;
            this.txtEnterSaltPercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTeast
            // 
            this.lblTeast.AutoSize = true;
            this.lblTeast.Location = new System.Drawing.Point(80, 203);
            this.lblTeast.Name = "lblTeast";
            this.lblTeast.Size = new System.Drawing.Size(80, 13);
            this.lblTeast.TabIndex = 6;
            this.lblTeast.Text = "Yeast (instant): ";
            // 
            // txtEnterYeastPercent
            // 
            this.txtEnterYeastPercent.Location = new System.Drawing.Point(159, 199);
            this.txtEnterYeastPercent.Name = "txtEnterYeastPercent";
            this.txtEnterYeastPercent.Size = new System.Drawing.Size(100, 20);
            this.txtEnterYeastPercent.TabIndex = 4;
            this.txtEnterYeastPercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblSourdoughStarter
            // 
            this.lblSourdoughStarter.AutoSize = true;
            this.lblSourdoughStarter.Location = new System.Drawing.Point(37, 243);
            this.lblSourdoughStarter.Name = "lblSourdoughStarter";
            this.lblSourdoughStarter.Size = new System.Drawing.Size(123, 13);
            this.lblSourdoughStarter.TabIndex = 8;
            this.lblSourdoughStarter.Text = "Sourdough Starter (1:1): ";
            // 
            // txtEnterStarterPercent
            // 
            this.txtEnterStarterPercent.Location = new System.Drawing.Point(159, 239);
            this.txtEnterStarterPercent.Name = "txtEnterStarterPercent";
            this.txtEnterStarterPercent.Size = new System.Drawing.Size(100, 20);
            this.txtEnterStarterPercent.TabIndex = 5;
            this.txtEnterStarterPercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblFatOil
            // 
            this.lblFatOil.AutoSize = true;
            this.lblFatOil.Location = new System.Drawing.Point(115, 281);
            this.lblFatOil.Name = "lblFatOil";
            this.lblFatOil.Size = new System.Drawing.Size(45, 13);
            this.lblFatOil.TabIndex = 10;
            this.lblFatOil.Text = "Fat/Oil: ";
            this.lblFatOil.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtEnterFatOilPercent
            // 
            this.txtEnterFatOilPercent.Location = new System.Drawing.Point(159, 277);
            this.txtEnterFatOilPercent.Name = "txtEnterFatOilPercent";
            this.txtEnterFatOilPercent.Size = new System.Drawing.Size(100, 20);
            this.txtEnterFatOilPercent.TabIndex = 6;
            this.txtEnterFatOilPercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPercentRatios
            // 
            this.lblPercentRatios.AutoSize = true;
            this.lblPercentRatios.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentRatios.Location = new System.Drawing.Point(53, 61);
            this.lblPercentRatios.Name = "lblPercentRatios";
            this.lblPercentRatios.Size = new System.Drawing.Size(206, 13);
            this.lblPercentRatios.TabIndex = 12;
            this.lblPercentRatios.Text = "Recipe Formula/Ratios (Percent %)";
            this.lblPercentRatios.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtFlourInputBase
            // 
            this.txtFlourInputBase.Location = new System.Drawing.Point(300, 90);
            this.txtFlourInputBase.Name = "txtFlourInputBase";
            this.txtFlourInputBase.Size = new System.Drawing.Size(100, 20);
            this.txtFlourInputBase.TabIndex = 1;
            this.txtFlourInputBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtWaterResultsQuantity
            // 
            this.txtWaterResultsQuantity.Location = new System.Drawing.Point(300, 126);
            this.txtWaterResultsQuantity.Name = "txtWaterResultsQuantity";
            this.txtWaterResultsQuantity.ReadOnly = true;
            this.txtWaterResultsQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtWaterResultsQuantity.TabIndex = 14;
            this.txtWaterResultsQuantity.TabStop = false;
            this.txtWaterResultsQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSaltResultsQuantity
            // 
            this.txtSaltResultsQuantity.Location = new System.Drawing.Point(300, 161);
            this.txtSaltResultsQuantity.Name = "txtSaltResultsQuantity";
            this.txtSaltResultsQuantity.ReadOnly = true;
            this.txtSaltResultsQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtSaltResultsQuantity.TabIndex = 15;
            this.txtSaltResultsQuantity.TabStop = false;
            this.txtSaltResultsQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtYeastResultsQuantity
            // 
            this.txtYeastResultsQuantity.Location = new System.Drawing.Point(300, 199);
            this.txtYeastResultsQuantity.Name = "txtYeastResultsQuantity";
            this.txtYeastResultsQuantity.ReadOnly = true;
            this.txtYeastResultsQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtYeastResultsQuantity.TabIndex = 16;
            this.txtYeastResultsQuantity.TabStop = false;
            this.txtYeastResultsQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtStarterResultsQuantity
            // 
            this.txtStarterResultsQuantity.Location = new System.Drawing.Point(300, 239);
            this.txtStarterResultsQuantity.Name = "txtStarterResultsQuantity";
            this.txtStarterResultsQuantity.ReadOnly = true;
            this.txtStarterResultsQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtStarterResultsQuantity.TabIndex = 17;
            this.txtStarterResultsQuantity.TabStop = false;
            this.txtStarterResultsQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtFatOilResultsQuantity
            // 
            this.txtFatOilResultsQuantity.Location = new System.Drawing.Point(300, 277);
            this.txtFatOilResultsQuantity.Name = "txtFatOilResultsQuantity";
            this.txtFatOilResultsQuantity.ReadOnly = true;
            this.txtFatOilResultsQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtFatOilResultsQuantity.TabIndex = 18;
            this.txtFatOilResultsQuantity.TabStop = false;
            this.txtFatOilResultsQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblQuantityResults
            // 
            this.lblQuantityResults.AutoSize = true;
            this.lblQuantityResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantityResults.Location = new System.Drawing.Point(300, 61);
            this.lblQuantityResults.Name = "lblQuantityResults";
            this.lblQuantityResults.Size = new System.Drawing.Size(200, 13);
            this.lblQuantityResults.TabIndex = 19;
            this.lblQuantityResults.Text = "Recipe Quantity/Results(Grams g)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(283, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(283, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "=";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(283, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "=";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(283, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "=";
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(204, 326);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(324, 326);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(84, 326);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblFlourBase
            // 
            this.lblFlourBase.AutoSize = true;
            this.lblFlourBase.Location = new System.Drawing.Point(401, 94);
            this.lblFlourBase.Name = "lblFlourBase";
            this.lblFlourBase.Size = new System.Drawing.Size(241, 13);
            this.lblFlourBase.TabIndex = 0;
            this.lblFlourBase.Text = "g *Flour amount to calculate remaining ingredients";
            this.lblFlourBase.Click += new System.EventHandler(this.lblFlourBase_Click);
            // 
            // lblPerct
            // 
            this.lblPerct.AutoSize = true;
            this.lblPerct.Location = new System.Drawing.Point(260, 94);
            this.lblPerct.Name = "lblPerct";
            this.lblPerct.Size = new System.Drawing.Size(15, 13);
            this.lblPerct.TabIndex = 30;
            this.lblPerct.Text = "%";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(260, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "%";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(260, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "%";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(260, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "%";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(260, 243);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "%";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(260, 281);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(15, 13);
            this.label10.TabIndex = 35;
            this.label10.Text = "%";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(401, 130);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 13);
            this.label11.TabIndex = 36;
            this.label11.Text = "g";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(401, 165);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 13);
            this.label12.TabIndex = 37;
            this.label12.Text = "g";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(401, 203);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(13, 13);
            this.label13.TabIndex = 38;
            this.label13.Text = "g";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(401, 243);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(13, 13);
            this.label14.TabIndex = 39;
            this.label14.Text = "g";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(401, 281);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(13, 13);
            this.label15.TabIndex = 40;
            this.label15.Text = "g";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(432, 125);
            this.lblDescription.MaximumSize = new System.Drawing.Size(305, 0);
            this.lblDescription.MinimumSize = new System.Drawing.Size(305, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(305, 78);
            this.lblDescription.TabIndex = 41;
            this.lblDescription.Text = resources.GetString("lblDescription.Text");
            // 
            // lblEqual
            // 
            this.lblEqual.AutoSize = true;
            this.lblEqual.Location = new System.Drawing.Point(283, 94);
            this.lblEqual.Name = "lblEqual";
            this.lblEqual.Size = new System.Drawing.Size(11, 13);
            this.lblEqual.TabIndex = 20;
            this.lblEqual.Text = "*";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(432, 216);
            this.label16.MaximumSize = new System.Drawing.Size(305, 0);
            this.label16.MinimumSize = new System.Drawing.Size(305, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(305, 91);
            this.label16.TabIndex = 42;
            this.label16.Text = resources.GetString("label16.Text");
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(432, 320);
            this.label17.MaximumSize = new System.Drawing.Size(305, 0);
            this.label17.MinimumSize = new System.Drawing.Size(305, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(305, 26);
            this.label17.TabIndex = 43;
            this.label17.Text = "So our resulting formula/recipe to make our pizza dough is 500g flour, 345.5g wat" +
    "er, 11g of salt and 2.5g of yeast.";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(22, 14);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(410, 22);
            this.label18.TabIndex = 100;
            this.label18.Text = "Baker\'s Percent - Baker\'s Formula Converter";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(31, 38);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(388, 13);
            this.label19.TabIndex = 101;
            this.label19.Text = "* Flour, Water and Salt amounts are the minimum input required for any calculatio" +
    "n";
            // 
            // frmBakersPercentages
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(764, 377);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblPerct);
            this.Controls.Add(this.lblFlourBase);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEqual);
            this.Controls.Add(this.lblQuantityResults);
            this.Controls.Add(this.txtFatOilResultsQuantity);
            this.Controls.Add(this.txtStarterResultsQuantity);
            this.Controls.Add(this.txtYeastResultsQuantity);
            this.Controls.Add(this.txtSaltResultsQuantity);
            this.Controls.Add(this.txtWaterResultsQuantity);
            this.Controls.Add(this.txtFlourInputBase);
            this.Controls.Add(this.lblPercentRatios);
            this.Controls.Add(this.txtEnterFatOilPercent);
            this.Controls.Add(this.lblFatOil);
            this.Controls.Add(this.txtEnterStarterPercent);
            this.Controls.Add(this.lblSourdoughStarter);
            this.Controls.Add(this.txtEnterYeastPercent);
            this.Controls.Add(this.lblTeast);
            this.Controls.Add(this.txtEnterSaltPercent);
            this.Controls.Add(this.lblSalt);
            this.Controls.Add(this.txtEnterWaterPercent);
            this.Controls.Add(this.lblWater);
            this.Controls.Add(this.txtEnterFlour);
            this.Controls.Add(this.lblFlour);
            this.Name = "frmBakersPercentages";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bakers Percent -Bakers Formula";
            this.Load += new System.EventHandler(this.frmBakersPercentages_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFlour;
        private System.Windows.Forms.TextBox txtEnterFlour;
        private System.Windows.Forms.Label lblWater;
        private System.Windows.Forms.TextBox txtEnterWaterPercent;
        private System.Windows.Forms.Label lblSalt;
        private System.Windows.Forms.TextBox txtEnterSaltPercent;
        private System.Windows.Forms.Label lblTeast;
        private System.Windows.Forms.TextBox txtEnterYeastPercent;
        private System.Windows.Forms.Label lblSourdoughStarter;
        private System.Windows.Forms.TextBox txtEnterStarterPercent;
        private System.Windows.Forms.Label lblFatOil;
        private System.Windows.Forms.TextBox txtEnterFatOilPercent;
        private System.Windows.Forms.Label lblPercentRatios;
        private System.Windows.Forms.TextBox txtFlourInputBase;
        private System.Windows.Forms.TextBox txtWaterResultsQuantity;
        private System.Windows.Forms.TextBox txtSaltResultsQuantity;
        private System.Windows.Forms.TextBox txtYeastResultsQuantity;
        private System.Windows.Forms.TextBox txtStarterResultsQuantity;
        private System.Windows.Forms.TextBox txtFatOilResultsQuantity;
        private System.Windows.Forms.Label lblQuantityResults;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblFlourBase;
        private System.Windows.Forms.Label lblPerct;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblEqual;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
    }
}

