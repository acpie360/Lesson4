namespace Lesson4
{
    partial class frmLesson4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLesson4));
            this.chkWindow = new System.Windows.Forms.CheckBox();
            this.chkAir = new System.Windows.Forms.CheckBox();
            this.chkChrome = new System.Windows.Forms.CheckBox();
            this.lblChooseOption = new System.Windows.Forms.Label();
            this.btnCalPrice = new System.Windows.Forms.Button();
            this.grpType = new System.Windows.Forms.GroupBox();
            this.radBusiness = new System.Windows.Forms.RadioButton();
            this.radPersonal = new System.Windows.Forms.RadioButton();
            this.grpColor = new System.Windows.Forms.GroupBox();
            this.radWhite = new System.Windows.Forms.RadioButton();
            this.radBlue = new System.Windows.Forms.RadioButton();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.grpType.SuspendLayout();
            this.grpColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkWindow
            // 
            this.chkWindow.AutoSize = true;
            this.chkWindow.Checked = true;
            this.chkWindow.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.chkWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkWindow.ForeColor = System.Drawing.Color.Black;
            this.chkWindow.Location = new System.Drawing.Point(47, 134);
            this.chkWindow.Name = "chkWindow";
            this.chkWindow.Size = new System.Drawing.Size(151, 24);
            this.chkWindow.TabIndex = 1;
            this.chkWindow.Text = "Power Windows";
            this.chkWindow.UseVisualStyleBackColor = true;
            // 
            // chkAir
            // 
            this.chkAir.AutoSize = true;
            this.chkAir.Checked = true;
            this.chkAir.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.chkAir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAir.ForeColor = System.Drawing.Color.Black;
            this.chkAir.Location = new System.Drawing.Point(47, 184);
            this.chkAir.Name = "chkAir";
            this.chkAir.Size = new System.Drawing.Size(149, 24);
            this.chkAir.TabIndex = 2;
            this.chkAir.Text = "Air Conditioning";
            this.chkAir.UseVisualStyleBackColor = true;
            // 
            // chkChrome
            // 
            this.chkChrome.AutoSize = true;
            this.chkChrome.Checked = true;
            this.chkChrome.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.chkChrome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkChrome.ForeColor = System.Drawing.Color.Black;
            this.chkChrome.Location = new System.Drawing.Point(47, 227);
            this.chkChrome.Name = "chkChrome";
            this.chkChrome.Size = new System.Drawing.Size(90, 24);
            this.chkChrome.TabIndex = 3;
            this.chkChrome.Text = "Chrome";
            this.chkChrome.UseVisualStyleBackColor = true;
            // 
            // lblChooseOption
            // 
            this.lblChooseOption.AutoSize = true;
            this.lblChooseOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChooseOption.Location = new System.Drawing.Point(47, 39);
            this.lblChooseOption.Name = "lblChooseOption";
            this.lblChooseOption.Size = new System.Drawing.Size(344, 25);
            this.lblChooseOption.TabIndex = 0;
            this.lblChooseOption.Text = "Choose from the following options:";
            // 
            // btnCalPrice
            // 
            this.btnCalPrice.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalPrice.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCalPrice.Location = new System.Drawing.Point(47, 347);
            this.btnCalPrice.Name = "btnCalPrice";
            this.btnCalPrice.Size = new System.Drawing.Size(160, 60);
            this.btnCalPrice.TabIndex = 6;
            this.btnCalPrice.Text = "&Calcuate Price";
            this.btnCalPrice.UseVisualStyleBackColor = true;
            this.btnCalPrice.Click += new System.EventHandler(this.btnCalPrice_Click);
            // 
            // grpType
            // 
            this.grpType.Controls.Add(this.radBusiness);
            this.grpType.Controls.Add(this.radPersonal);
            this.grpType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpType.ForeColor = System.Drawing.Color.Black;
            this.grpType.Location = new System.Drawing.Point(286, 134);
            this.grpType.Name = "grpType";
            this.grpType.Size = new System.Drawing.Size(200, 132);
            this.grpType.TabIndex = 4;
            this.grpType.TabStop = false;
            this.grpType.Text = "Account Type";
            // 
            // radBusiness
            // 
            this.radBusiness.AutoSize = true;
            this.radBusiness.Location = new System.Drawing.Point(7, 92);
            this.radBusiness.Name = "radBusiness";
            this.radBusiness.Size = new System.Drawing.Size(108, 24);
            this.radBusiness.TabIndex = 1;
            this.radBusiness.TabStop = true;
            this.radBusiness.Text = "Business";
            this.radBusiness.UseVisualStyleBackColor = true;
            // 
            // radPersonal
            // 
            this.radPersonal.AutoSize = true;
            this.radPersonal.Location = new System.Drawing.Point(7, 49);
            this.radPersonal.Name = "radPersonal";
            this.radPersonal.Size = new System.Drawing.Size(104, 24);
            this.radPersonal.TabIndex = 0;
            this.radPersonal.TabStop = true;
            this.radPersonal.Text = "Personal";
            this.radPersonal.UseVisualStyleBackColor = true;
            // 
            // grpColor
            // 
            this.grpColor.Controls.Add(this.radWhite);
            this.grpColor.Controls.Add(this.radBlue);
            this.grpColor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpColor.Location = new System.Drawing.Point(532, 134);
            this.grpColor.Name = "grpColor";
            this.grpColor.Size = new System.Drawing.Size(200, 132);
            this.grpColor.TabIndex = 5;
            this.grpColor.TabStop = false;
            this.grpColor.Text = "Color";
            // 
            // radWhite
            // 
            this.radWhite.AutoSize = true;
            this.radWhite.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.radWhite.FlatAppearance.BorderSize = 5;
            this.radWhite.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.radWhite.ForeColor = System.Drawing.Color.Black;
            this.radWhite.Location = new System.Drawing.Point(6, 89);
            this.radWhite.Name = "radWhite";
            this.radWhite.Size = new System.Drawing.Size(78, 24);
            this.radWhite.TabIndex = 1;
            this.radWhite.TabStop = true;
            this.radWhite.Text = "White";
            this.radWhite.UseVisualStyleBackColor = true;
            // 
            // radBlue
            // 
            this.radBlue.AutoSize = true;
            this.radBlue.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.radBlue.FlatAppearance.BorderSize = 5;
            this.radBlue.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.radBlue.ForeColor = System.Drawing.Color.Black;
            this.radBlue.Location = new System.Drawing.Point(6, 37);
            this.radBlue.Name = "radBlue";
            this.radBlue.Size = new System.Drawing.Size(68, 24);
            this.radBlue.TabIndex = 0;
            this.radBlue.TabStop = true;
            this.radBlue.Text = "Blue";
            this.radBlue.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(127, 88);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(187, 26);
            this.txtName.TabIndex = 0;
            this.txtName.Click += new System.EventHandler(this.txtName_Enter);
            this.txtName.Enter += new System.EventHandler(this.txtName_Enter);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(47, 88);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(63, 20);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "&Name:";
            // 
            // frmLesson4
            // 
            this.AcceptButton = this.btnCalPrice;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.grpColor);
            this.Controls.Add(this.grpType);
            this.Controls.Add(this.btnCalPrice);
            this.Controls.Add(this.lblChooseOption);
            this.Controls.Add(this.chkChrome);
            this.Controls.Add(this.chkAir);
            this.Controls.Add(this.chkWindow);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLesson4";
            this.Text = "New Car Sales";
            this.grpType.ResumeLayout(false);
            this.grpType.PerformLayout();
            this.grpColor.ResumeLayout(false);
            this.grpColor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkWindow;
        private System.Windows.Forms.CheckBox chkAir;
        private System.Windows.Forms.CheckBox chkChrome;
        private System.Windows.Forms.Label lblChooseOption;
        private System.Windows.Forms.Button btnCalPrice;
        private System.Windows.Forms.GroupBox grpType;
        private System.Windows.Forms.RadioButton radBusiness;
        private System.Windows.Forms.RadioButton radPersonal;
        private System.Windows.Forms.GroupBox grpColor;
        private System.Windows.Forms.RadioButton radWhite;
        private System.Windows.Forms.RadioButton radBlue;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
    }
}

