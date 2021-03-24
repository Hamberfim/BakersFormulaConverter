
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
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.rdoNapolitanoRecipe = new System.Windows.Forms.RadioButton();
            this.rdoPainaLAncienne = new System.Windows.Forms.RadioButton();
            this.rdoSourdoughBaguettes = new System.Windows.Forms.RadioButton();
            this.lblTitleSelectFormulas = new System.Windows.Forms.Label();
            this.lblTitleAboutFormulas = new System.Windows.Forms.Label();
            this.lblHRdivider = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.btnSelectFormula = new System.Windows.Forms.Button();
            this.rdoCiabatta = new System.Windows.Forms.RadioButton();
            this.label17 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFlour
            // 
            this.lblFlour.AutoSize = true;
            this.lblFlour.Location = new System.Drawing.Point(14, 114);
            this.lblFlour.Name = "lblFlour";
            this.lblFlour.Size = new System.Drawing.Size(137, 13);
            this.lblFlour.TabIndex = 0;
            this.lblFlour.Text = "Flour (Expressed as 100%): ";
            // 
            // txtEnterFlour
            // 
            this.txtEnterFlour.Location = new System.Drawing.Point(150, 110);
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
            this.lblWater.Location = new System.Drawing.Point(105, 150);
            this.lblWater.Name = "lblWater";
            this.lblWater.Size = new System.Drawing.Size(46, 13);
            this.lblWater.TabIndex = 2;
            this.lblWater.Text = "*Water: ";
            // 
            // txtEnterWaterPercent
            // 
            this.txtEnterWaterPercent.Location = new System.Drawing.Point(150, 146);
            this.txtEnterWaterPercent.Name = "txtEnterWaterPercent";
            this.txtEnterWaterPercent.Size = new System.Drawing.Size(100, 20);
            this.txtEnterWaterPercent.TabIndex = 2;
            this.txtEnterWaterPercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtEnterWaterPercent.TextChanged += new System.EventHandler(this.txtEnterWater_TextChanged);
            // 
            // lblSalt
            // 
            this.lblSalt.AutoSize = true;
            this.lblSalt.Location = new System.Drawing.Point(116, 185);
            this.lblSalt.Name = "lblSalt";
            this.lblSalt.Size = new System.Drawing.Size(35, 13);
            this.lblSalt.TabIndex = 4;
            this.lblSalt.Text = "*Salt: ";
            // 
            // txtEnterSaltPercent
            // 
            this.txtEnterSaltPercent.Location = new System.Drawing.Point(150, 181);
            this.txtEnterSaltPercent.Name = "txtEnterSaltPercent";
            this.txtEnterSaltPercent.Size = new System.Drawing.Size(100, 20);
            this.txtEnterSaltPercent.TabIndex = 3;
            this.txtEnterSaltPercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTeast
            // 
            this.lblTeast.AutoSize = true;
            this.lblTeast.Location = new System.Drawing.Point(71, 223);
            this.lblTeast.Name = "lblTeast";
            this.lblTeast.Size = new System.Drawing.Size(80, 13);
            this.lblTeast.TabIndex = 6;
            this.lblTeast.Text = "Yeast (instant): ";
            // 
            // txtEnterYeastPercent
            // 
            this.txtEnterYeastPercent.Location = new System.Drawing.Point(150, 219);
            this.txtEnterYeastPercent.Name = "txtEnterYeastPercent";
            this.txtEnterYeastPercent.Size = new System.Drawing.Size(100, 20);
            this.txtEnterYeastPercent.TabIndex = 4;
            this.txtEnterYeastPercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblSourdoughStarter
            // 
            this.lblSourdoughStarter.AutoSize = true;
            this.lblSourdoughStarter.Location = new System.Drawing.Point(28, 263);
            this.lblSourdoughStarter.Name = "lblSourdoughStarter";
            this.lblSourdoughStarter.Size = new System.Drawing.Size(123, 13);
            this.lblSourdoughStarter.TabIndex = 8;
            this.lblSourdoughStarter.Text = "Sourdough Starter (1:1): ";
            // 
            // txtEnterStarterPercent
            // 
            this.txtEnterStarterPercent.Location = new System.Drawing.Point(150, 259);
            this.txtEnterStarterPercent.Name = "txtEnterStarterPercent";
            this.txtEnterStarterPercent.Size = new System.Drawing.Size(100, 20);
            this.txtEnterStarterPercent.TabIndex = 5;
            this.txtEnterStarterPercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblFatOil
            // 
            this.lblFatOil.AutoSize = true;
            this.lblFatOil.Location = new System.Drawing.Point(106, 301);
            this.lblFatOil.Name = "lblFatOil";
            this.lblFatOil.Size = new System.Drawing.Size(45, 13);
            this.lblFatOil.TabIndex = 10;
            this.lblFatOil.Text = "Fat/Oil: ";
            this.lblFatOil.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtEnterFatOilPercent
            // 
            this.txtEnterFatOilPercent.Location = new System.Drawing.Point(150, 297);
            this.txtEnterFatOilPercent.Name = "txtEnterFatOilPercent";
            this.txtEnterFatOilPercent.Size = new System.Drawing.Size(100, 20);
            this.txtEnterFatOilPercent.TabIndex = 6;
            this.txtEnterFatOilPercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPercentRatios
            // 
            this.lblPercentRatios.AutoSize = true;
            this.lblPercentRatios.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentRatios.Location = new System.Drawing.Point(44, 81);
            this.lblPercentRatios.Name = "lblPercentRatios";
            this.lblPercentRatios.Size = new System.Drawing.Size(206, 13);
            this.lblPercentRatios.TabIndex = 12;
            this.lblPercentRatios.Text = "Recipe Formula/Ratios (Percent %)";
            this.lblPercentRatios.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtFlourInputBase
            // 
            this.txtFlourInputBase.Location = new System.Drawing.Point(291, 110);
            this.txtFlourInputBase.Name = "txtFlourInputBase";
            this.txtFlourInputBase.Size = new System.Drawing.Size(100, 20);
            this.txtFlourInputBase.TabIndex = 1;
            this.txtFlourInputBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtWaterResultsQuantity
            // 
            this.txtWaterResultsQuantity.Location = new System.Drawing.Point(291, 146);
            this.txtWaterResultsQuantity.Name = "txtWaterResultsQuantity";
            this.txtWaterResultsQuantity.ReadOnly = true;
            this.txtWaterResultsQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtWaterResultsQuantity.TabIndex = 14;
            this.txtWaterResultsQuantity.TabStop = false;
            this.txtWaterResultsQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSaltResultsQuantity
            // 
            this.txtSaltResultsQuantity.Location = new System.Drawing.Point(291, 181);
            this.txtSaltResultsQuantity.Name = "txtSaltResultsQuantity";
            this.txtSaltResultsQuantity.ReadOnly = true;
            this.txtSaltResultsQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtSaltResultsQuantity.TabIndex = 15;
            this.txtSaltResultsQuantity.TabStop = false;
            this.txtSaltResultsQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtYeastResultsQuantity
            // 
            this.txtYeastResultsQuantity.Location = new System.Drawing.Point(291, 219);
            this.txtYeastResultsQuantity.Name = "txtYeastResultsQuantity";
            this.txtYeastResultsQuantity.ReadOnly = true;
            this.txtYeastResultsQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtYeastResultsQuantity.TabIndex = 16;
            this.txtYeastResultsQuantity.TabStop = false;
            this.txtYeastResultsQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtStarterResultsQuantity
            // 
            this.txtStarterResultsQuantity.Location = new System.Drawing.Point(291, 259);
            this.txtStarterResultsQuantity.Name = "txtStarterResultsQuantity";
            this.txtStarterResultsQuantity.ReadOnly = true;
            this.txtStarterResultsQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtStarterResultsQuantity.TabIndex = 17;
            this.txtStarterResultsQuantity.TabStop = false;
            this.txtStarterResultsQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtFatOilResultsQuantity
            // 
            this.txtFatOilResultsQuantity.Location = new System.Drawing.Point(291, 297);
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
            this.lblQuantityResults.Location = new System.Drawing.Point(291, 81);
            this.lblQuantityResults.Name = "lblQuantityResults";
            this.lblQuantityResults.Size = new System.Drawing.Size(200, 13);
            this.lblQuantityResults.TabIndex = 19;
            this.lblQuantityResults.Text = "Recipe Quantity/Results(Grams g)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(274, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(274, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "=";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(274, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "=";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(274, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "=";
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(195, 346);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(315, 346);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(75, 346);
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
            this.lblFlourBase.Location = new System.Drawing.Point(392, 114);
            this.lblFlourBase.Name = "lblFlourBase";
            this.lblFlourBase.Size = new System.Drawing.Size(283, 13);
            this.lblFlourBase.TabIndex = 0;
            this.lblFlourBase.Text = "g *Flour amount in grams to calculate remaining ingredients";
            this.lblFlourBase.Click += new System.EventHandler(this.lblFlourBase_Click);
            // 
            // lblPerct
            // 
            this.lblPerct.AutoSize = true;
            this.lblPerct.Location = new System.Drawing.Point(251, 114);
            this.lblPerct.Name = "lblPerct";
            this.lblPerct.Size = new System.Drawing.Size(15, 13);
            this.lblPerct.TabIndex = 30;
            this.lblPerct.Text = "%";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(251, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "%";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(251, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "%";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(251, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "%";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(251, 263);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "%";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(251, 301);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(15, 13);
            this.label10.TabIndex = 35;
            this.label10.Text = "%";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(392, 150);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 13);
            this.label11.TabIndex = 36;
            this.label11.Text = "g";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(392, 185);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 13);
            this.label12.TabIndex = 37;
            this.label12.Text = "g";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(392, 223);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(13, 13);
            this.label13.TabIndex = 38;
            this.label13.Text = "g";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(392, 263);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(13, 13);
            this.label14.TabIndex = 39;
            this.label14.Text = "g";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(392, 301);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(13, 13);
            this.label15.TabIndex = 40;
            this.label15.Text = "g";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(690, 60);
            this.lblDescription.MaximumSize = new System.Drawing.Size(305, 0);
            this.lblDescription.MinimumSize = new System.Drawing.Size(305, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(305, 112);
            this.lblDescription.TabIndex = 41;
            this.lblDescription.Text = resources.GetString("lblDescription.Text");
            // 
            // lblEqual
            // 
            this.lblEqual.AutoSize = true;
            this.lblEqual.Location = new System.Drawing.Point(274, 114);
            this.lblEqual.Name = "lblEqual";
            this.lblEqual.Size = new System.Drawing.Size(11, 13);
            this.lblEqual.TabIndex = 20;
            this.lblEqual.Text = "*";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(690, 231);
            this.label16.MaximumSize = new System.Drawing.Size(305, 0);
            this.label16.MinimumSize = new System.Drawing.Size(305, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(305, 45);
            this.label16.TabIndex = 42;
            this.label16.Text = "Assuming we need *500 grams of flour to make a loaf we calculate the weights of e" +
    "ach of the additional ingredients like this: ";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(12, 32);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(349, 22);
            this.label18.TabIndex = 100;
            this.label18.Text = "Baker\'s Percent - Formula Converter";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(22, 58);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(528, 13);
            this.label19.TabIndex = 101;
            this.label19.Text = "* Input of Flour, Water and Salt amounts are the minimum required for any calcula" +
    "tion. Or select a formula below.";
            // 
            // rdoNapolitanoRecipe
            // 
            this.rdoNapolitanoRecipe.AutoSize = true;
            this.rdoNapolitanoRecipe.Location = new System.Drawing.Point(435, 176);
            this.rdoNapolitanoRecipe.Name = "rdoNapolitanoRecipe";
            this.rdoNapolitanoRecipe.Size = new System.Drawing.Size(139, 17);
            this.rdoNapolitanoRecipe.TabIndex = 102;
            this.rdoNapolitanoRecipe.TabStop = true;
            this.rdoNapolitanoRecipe.Text = "Napolitano Pizza Dough";
            this.rdoNapolitanoRecipe.UseVisualStyleBackColor = true;
            // 
            // rdoPainaLAncienne
            // 
            this.rdoPainaLAncienne.AutoSize = true;
            this.rdoPainaLAncienne.Location = new System.Drawing.Point(435, 199);
            this.rdoPainaLAncienne.Name = "rdoPainaLAncienne";
            this.rdoPainaLAncienne.Size = new System.Drawing.Size(109, 17);
            this.rdoPainaLAncienne.TabIndex = 103;
            this.rdoPainaLAncienne.TabStop = true;
            this.rdoPainaLAncienne.Text = "Pain a\' l\'Ancienne";
            this.rdoPainaLAncienne.UseVisualStyleBackColor = true;
            // 
            // rdoSourdoughBaguettes
            // 
            this.rdoSourdoughBaguettes.AutoSize = true;
            this.rdoSourdoughBaguettes.Location = new System.Drawing.Point(435, 222);
            this.rdoSourdoughBaguettes.Name = "rdoSourdoughBaguettes";
            this.rdoSourdoughBaguettes.Size = new System.Drawing.Size(128, 17);
            this.rdoSourdoughBaguettes.TabIndex = 104;
            this.rdoSourdoughBaguettes.TabStop = true;
            this.rdoSourdoughBaguettes.Text = "Sourdough Baguettes";
            this.rdoSourdoughBaguettes.UseVisualStyleBackColor = true;
            // 
            // lblTitleSelectFormulas
            // 
            this.lblTitleSelectFormulas.AutoSize = true;
            this.lblTitleSelectFormulas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleSelectFormulas.Location = new System.Drawing.Point(432, 146);
            this.lblTitleSelectFormulas.Name = "lblTitleSelectFormulas";
            this.lblTitleSelectFormulas.Size = new System.Drawing.Size(118, 17);
            this.lblTitleSelectFormulas.TabIndex = 105;
            this.lblTitleSelectFormulas.Text = "Select a Formula:";
            // 
            // lblTitleAboutFormulas
            // 
            this.lblTitleAboutFormulas.AutoSize = true;
            this.lblTitleAboutFormulas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleAboutFormulas.Location = new System.Drawing.Point(690, 37);
            this.lblTitleAboutFormulas.Name = "lblTitleAboutFormulas";
            this.lblTitleAboutFormulas.Size = new System.Drawing.Size(156, 18);
            this.lblTitleAboutFormulas.TabIndex = 106;
            this.lblTitleAboutFormulas.Text = "About Baker Formulas";
            // 
            // lblHRdivider
            // 
            this.lblHRdivider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHRdivider.Location = new System.Drawing.Point(435, 167);
            this.lblHRdivider.Name = "lblHRdivider";
            this.lblHRdivider.Size = new System.Drawing.Size(135, 2);
            this.lblHRdivider.TabIndex = 107;
            this.lblHRdivider.Text = "\r\n";
            // 
            // label20
            // 
            this.label20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label20.Location = new System.Drawing.Point(435, 269);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(135, 2);
            this.label20.TabIndex = 108;
            this.label20.Text = "\r\n";
            // 
            // btnSelectFormula
            // 
            this.btnSelectFormula.Location = new System.Drawing.Point(435, 276);
            this.btnSelectFormula.Name = "btnSelectFormula";
            this.btnSelectFormula.Size = new System.Drawing.Size(135, 23);
            this.btnSelectFormula.TabIndex = 109;
            this.btnSelectFormula.Text = "Add Select Formula";
            this.btnSelectFormula.UseVisualStyleBackColor = true;
            this.btnSelectFormula.Click += new System.EventHandler(this.btnSelectFormula_Click);
            // 
            // rdoCiabatta
            // 
            this.rdoCiabatta.AutoSize = true;
            this.rdoCiabatta.Location = new System.Drawing.Point(435, 245);
            this.rdoCiabatta.Name = "rdoCiabatta";
            this.rdoCiabatta.Size = new System.Drawing.Size(64, 17);
            this.rdoCiabatta.TabIndex = 110;
            this.rdoCiabatta.TabStop = true;
            this.rdoCiabatta.Text = "Ciabatta";
            this.rdoCiabatta.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(690, 339);
            this.label17.MaximumSize = new System.Drawing.Size(305, 0);
            this.label17.MinimumSize = new System.Drawing.Size(305, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(305, 30);
            this.label17.TabIndex = 43;
            this.label17.Text = "So our resulting formula/recipe to make our loaf is 500g flour, 345.5g water, 11g" +
    " of salt and 2.5g of yeast.";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(690, 196);
            this.label21.MaximumSize = new System.Drawing.Size(305, 0);
            this.label21.MinimumSize = new System.Drawing.Size(305, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(305, 30);
            this.label21.TabIndex = 111;
            this.label21.Text = "Say we have this formula: Flour(100%), Water(69.1%), Salt(2.2%), Yeast(0.5%).";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(690, 286);
            this.label22.MaximumSize = new System.Drawing.Size(305, 0);
            this.label22.MinimumSize = new System.Drawing.Size(305, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(305, 13);
            this.label22.TabIndex = 112;
            this.label22.Text = "Water: 69.1% divided by 100 = 0.691 * 500 = 345.5g water";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(690, 302);
            this.label23.MaximumSize = new System.Drawing.Size(305, 0);
            this.label23.MinimumSize = new System.Drawing.Size(305, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(305, 13);
            this.label23.TabIndex = 113;
            this.label23.Text = "Salt: 2.2% divided by 100 = 0.022 * 500 = 11.0g salt";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(690, 318);
            this.label24.MaximumSize = new System.Drawing.Size(305, 0);
            this.label24.MinimumSize = new System.Drawing.Size(305, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(305, 13);
            this.label24.TabIndex = 114;
            this.label24.Text = "Yeast: 0.5 divided by 100 = 0.005 * 500 = 2.5g yeast";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(690, 179);
            this.label25.MaximumSize = new System.Drawing.Size(305, 0);
            this.label25.MinimumSize = new System.Drawing.Size(305, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(305, 17);
            this.label25.TabIndex = 115;
            this.label25.Text = "Example:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1011, 24);
            this.menuStrip1.TabIndex = 116;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // frmBakersPercentages
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(1011, 408);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.rdoCiabatta);
            this.Controls.Add(this.btnSelectFormula);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.lblHRdivider);
            this.Controls.Add(this.lblTitleAboutFormulas);
            this.Controls.Add(this.lblTitleSelectFormulas);
            this.Controls.Add(this.rdoSourdoughBaguettes);
            this.Controls.Add(this.rdoPainaLAncienne);
            this.Controls.Add(this.rdoNapolitanoRecipe);
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
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmBakersPercentages";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bakers Percent -Bakers Formula";
            this.Load += new System.EventHandler(this.frmBakersPercentages_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.RadioButton rdoNapolitanoRecipe;
        private System.Windows.Forms.RadioButton rdoPainaLAncienne;
        private System.Windows.Forms.RadioButton rdoSourdoughBaguettes;
        private System.Windows.Forms.Label lblTitleSelectFormulas;
        private System.Windows.Forms.Label lblTitleAboutFormulas;
        private System.Windows.Forms.Label lblHRdivider;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnSelectFormula;
        private System.Windows.Forms.RadioButton rdoCiabatta;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

