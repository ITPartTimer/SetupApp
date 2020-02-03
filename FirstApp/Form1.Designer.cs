namespace FirstApp
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
            this.components = new System.ComponentModel.Container();
            this.lblKnives = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblClear = new System.Windows.Forms.Label();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtClear = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMale = new System.Windows.Forms.Label();
            this.btnSetup = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGauge = new System.Windows.Forms.TextBox();
            this.lstKnives = new System.Windows.Forms.ListBox();
            this.gvMale = new System.Windows.Forms.DataGridView();
            this.lblMaleSum = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gvFemale = new System.Windows.Forms.DataGridView();
            this.lblFemaleSum = new System.Windows.Forms.Label();
            this.lstMach = new System.Windows.Forms.ListBox();
            this.lblMach = new System.Windows.Forms.Label();
            this.lblFemaleFormula = new System.Windows.Forms.Label();
            this.lblSpacersInv = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvMale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFemale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKnives
            // 
            this.lblKnives.AutoSize = true;
            this.lblKnives.Location = new System.Drawing.Point(277, 35);
            this.lblKnives.Name = "lblKnives";
            this.lblKnives.Size = new System.Drawing.Size(39, 13);
            this.lblKnives.TabIndex = 0;
            this.lblKnives.Text = "Knives";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(103, 36);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(35, 13);
            this.lblWidth.TabIndex = 1;
            this.lblWidth.Text = "Width";
            // 
            // lblClear
            // 
            this.lblClear.AutoSize = true;
            this.lblClear.Location = new System.Drawing.Point(355, 33);
            this.lblClear.Name = "lblClear";
            this.lblClear.Size = new System.Drawing.Size(91, 13);
            this.lblClear.TabIndex = 2;
            this.lblClear.Text = "Clearance (0.000)";
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(106, 52);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(60, 20);
            this.txtWidth.TabIndex = 2;
            this.txtWidth.Validating += new System.ComponentModel.CancelEventHandler(this.txtWidth_Validating);
            this.txtWidth.Validated += new System.EventHandler(this.txtWidth_Validated);
            // 
            // txtClear
            // 
            this.txtClear.Location = new System.Drawing.Point(356, 50);
            this.txtClear.Name = "txtClear";
            this.txtClear.Size = new System.Drawing.Size(88, 20);
            this.txtClear.TabIndex = 5;
            this.txtClear.Validating += new System.ComponentModel.CancelEventHandler(this.txtClear_Validating);
            this.txtClear.Validated += new System.EventHandler(this.txtClear_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sum Spacers:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Sum Spacers:";
            // 
            // lblMale
            // 
            this.lblMale.AutoSize = true;
            this.lblMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMale.Location = new System.Drawing.Point(63, 171);
            this.lblMale.Name = "lblMale";
            this.lblMale.Size = new System.Drawing.Size(23, 13);
            this.lblMale.TabIndex = 8;
            this.lblMale.Text = "Cut";
            // 
            // btnSetup
            // 
            this.btnSetup.Location = new System.Drawing.Point(356, 76);
            this.btnSetup.Name = "btnSetup";
            this.btnSetup.Size = new System.Drawing.Size(88, 23);
            this.btnSetup.TabIndex = 6;
            this.btnSetup.Text = "Setup";
            this.btnSetup.UseVisualStyleBackColor = true;
            this.btnSetup.Click += new System.EventHandler(this.btnSetup_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Gauge";
            // 
            // txtGauge
            // 
            this.txtGauge.Location = new System.Drawing.Point(23, 51);
            this.txtGauge.Name = "txtGauge";
            this.txtGauge.Size = new System.Drawing.Size(60, 20);
            this.txtGauge.TabIndex = 1;
            this.txtGauge.Validating += new System.ComponentModel.CancelEventHandler(this.txtGauge_Validating);
            this.txtGauge.Validated += new System.EventHandler(this.txtGauge_Validated);
            // 
            // lstKnives
            // 
            this.lstKnives.FormattingEnabled = true;
            this.lstKnives.Location = new System.Drawing.Point(280, 51);
            this.lstKnives.Name = "lstKnives";
            this.lstKnives.Size = new System.Drawing.Size(53, 82);
            this.lstKnives.TabIndex = 3;
            // 
            // gvMale
            // 
            this.gvMale.AllowUserToAddRows = false;
            this.gvMale.AllowUserToDeleteRows = false;
            this.gvMale.AllowUserToResizeColumns = false;
            this.gvMale.AllowUserToResizeRows = false;
            this.gvMale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvMale.Location = new System.Drawing.Point(26, 204);
            this.gvMale.Name = "gvMale";
            this.gvMale.Size = new System.Drawing.Size(240, 83);
            this.gvMale.TabIndex = 12;
            // 
            // lblMaleSum
            // 
            this.lblMaleSum.AutoSize = true;
            this.lblMaleSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaleSum.Location = new System.Drawing.Point(105, 187);
            this.lblMaleSum.Name = "lblMaleSum";
            this.lblMaleSum.Size = new System.Drawing.Size(28, 13);
            this.lblMaleSum.TabIndex = 14;
            this.lblMaleSum.Text = "Sum";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Male:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(289, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Female:";
            // 
            // gvFemale
            // 
            this.gvFemale.AllowUserToAddRows = false;
            this.gvFemale.AllowUserToDeleteRows = false;
            this.gvFemale.AllowUserToOrderColumns = true;
            this.gvFemale.AllowUserToResizeColumns = false;
            this.gvFemale.AllowUserToResizeRows = false;
            this.gvFemale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvFemale.Location = new System.Drawing.Point(292, 204);
            this.gvFemale.Name = "gvFemale";
            this.gvFemale.Size = new System.Drawing.Size(240, 84);
            this.gvFemale.TabIndex = 17;
            // 
            // lblFemaleSum
            // 
            this.lblFemaleSum.AutoSize = true;
            this.lblFemaleSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFemaleSum.Location = new System.Drawing.Point(368, 187);
            this.lblFemaleSum.Name = "lblFemaleSum";
            this.lblFemaleSum.Size = new System.Drawing.Size(28, 13);
            this.lblFemaleSum.TabIndex = 18;
            this.lblFemaleSum.Text = "Sum";
            // 
            // lstMach
            // 
            this.lstMach.FormattingEnabled = true;
            this.lstMach.Items.AddRange(new object[] {
            "60 ST",
            "72 ST",
            "60 MI",
            "Kevin",
            "72 AR"});
            this.lstMach.Location = new System.Drawing.Point(194, 51);
            this.lstMach.Name = "lstMach";
            this.lstMach.Size = new System.Drawing.Size(57, 82);
            this.lstMach.TabIndex = 4;
            this.lstMach.SelectedIndexChanged += new System.EventHandler(this.lstMach_SelectedIndexChanged);
            // 
            // lblMach
            // 
            this.lblMach.AutoSize = true;
            this.lblMach.Location = new System.Drawing.Point(194, 36);
            this.lblMach.Name = "lblMach";
            this.lblMach.Size = new System.Drawing.Size(48, 13);
            this.lblMach.TabIndex = 20;
            this.lblMach.Text = "Machine";
            // 
            // lblFemaleFormula
            // 
            this.lblFemaleFormula.AutoSize = true;
            this.lblFemaleFormula.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFemaleFormula.Location = new System.Drawing.Point(339, 171);
            this.lblFemaleFormula.Name = "lblFemaleFormula";
            this.lblFemaleFormula.Size = new System.Drawing.Size(44, 13);
            this.lblFemaleFormula.TabIndex = 24;
            this.lblFemaleFormula.Text = "Formula";
            // 
            // lblSpacersInv
            // 
            this.lblSpacersInv.AutoSize = true;
            this.lblSpacersInv.Location = new System.Drawing.Point(23, 145);
            this.lblSpacersInv.Name = "lblSpacersInv";
            this.lblSpacersInv.Size = new System.Drawing.Size(70, 13);
            this.lblSpacersInv.TabIndex = 25;
            this.lblSpacersInv.Text = "Spacer Invtry";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(23, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 26);
            this.label4.TabIndex = 26;
            this.label4.Text = "Enter numbers in the format 0.000\nSelect Machine to see Knives";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Arbor Spacers:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(559, 341);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblSpacersInv);
            this.Controls.Add(this.lblFemaleFormula);
            this.Controls.Add(this.lblMach);
            this.Controls.Add(this.lstMach);
            this.Controls.Add(this.lblFemaleSum);
            this.Controls.Add(this.gvFemale);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblMaleSum);
            this.Controls.Add(this.gvMale);
            this.Controls.Add(this.lstKnives);
            this.Controls.Add(this.txtGauge);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSetup);
            this.Controls.Add(this.lblMale);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtClear);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.lblClear);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.lblKnives);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 20, 20);
            this.Text = "Arbor Mult Tooling";
            ((System.ComponentModel.ISupportInitialize)(this.gvMale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFemale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKnives;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblClear;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.TextBox txtClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMale;
        private System.Windows.Forms.Button btnSetup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGauge;
        private System.Windows.Forms.ListBox lstKnives;
        private System.Windows.Forms.DataGridView gvMale;
        private System.Windows.Forms.Label lblMaleSum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView gvFemale;
        private System.Windows.Forms.Label lblFemaleSum;
        private System.Windows.Forms.ListBox lstMach;
        private System.Windows.Forms.Label lblMach;
        private System.Windows.Forms.Label lblFemaleFormula;
        private System.Windows.Forms.Label lblSpacersInv;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
    }
}

