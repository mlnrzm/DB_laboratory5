
namespace HardwareStoreView
{
    partial class FormTechnic
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
            this.textBoxTechnicName = new System.Windows.Forms.TextBox();
            this.textBoxWarranty = new System.Windows.Forms.TextBox();
            this.textBoxProduction = new System.Windows.Forms.TextBox();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.labelCategory = new System.Windows.Forms.Label();
            this.labelTechnicName = new System.Windows.Forms.Label();
            this.labelProduction = new System.Windows.Forms.Label();
            this.labelWarranty = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxTechnicName
            // 
            this.textBoxTechnicName.Location = new System.Drawing.Point(178, 88);
            this.textBoxTechnicName.Name = "textBoxTechnicName";
            this.textBoxTechnicName.Size = new System.Drawing.Size(285, 27);
            this.textBoxTechnicName.TabIndex = 0;
            // 
            // textBoxWarranty
            // 
            this.textBoxWarranty.Location = new System.Drawing.Point(178, 196);
            this.textBoxWarranty.Name = "textBoxWarranty";
            this.textBoxWarranty.Size = new System.Drawing.Size(285, 27);
            this.textBoxWarranty.TabIndex = 1;
            // 
            // textBoxProduction
            // 
            this.textBoxProduction.Location = new System.Drawing.Point(178, 144);
            this.textBoxProduction.Name = "textBoxProduction";
            this.textBoxProduction.Size = new System.Drawing.Size(285, 27);
            this.textBoxProduction.TabIndex = 2;
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(178, 32);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(285, 28);
            this.comboBoxCategory.TabIndex = 3;
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(35, 35);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(84, 20);
            this.labelCategory.TabIndex = 4;
            this.labelCategory.Text = "Категория:";
            // 
            // labelTechnicName
            // 
            this.labelTechnicName.AutoSize = true;
            this.labelTechnicName.Location = new System.Drawing.Point(35, 91);
            this.labelTechnicName.Name = "labelTechnicName";
            this.labelTechnicName.Size = new System.Drawing.Size(119, 20);
            this.labelTechnicName.TabIndex = 5;
            this.labelTechnicName.Text = "Наименование:";
            // 
            // labelProduction
            // 
            this.labelProduction.AutoSize = true;
            this.labelProduction.Location = new System.Drawing.Point(35, 147);
            this.labelProduction.Name = "labelProduction";
            this.labelProduction.Size = new System.Drawing.Size(112, 20);
            this.labelProduction.TabIndex = 6;
            this.labelProduction.Text = "Производство:";
            // 
            // labelWarranty
            // 
            this.labelWarranty.AutoSize = true;
            this.labelWarranty.Location = new System.Drawing.Point(35, 199);
            this.labelWarranty.Name = "labelWarranty";
            this.labelWarranty.Size = new System.Drawing.Size(76, 20);
            this.labelWarranty.TabIndex = 7;
            this.labelWarranty.Text = "Гарантия:";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(178, 241);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(135, 36);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(328, 241);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(135, 36);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Отменить";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FormTechnic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 299);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelWarranty);
            this.Controls.Add(this.labelProduction);
            this.Controls.Add(this.labelTechnicName);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.textBoxProduction);
            this.Controls.Add(this.textBoxWarranty);
            this.Controls.Add(this.textBoxTechnicName);
            this.Name = "FormTechnic";
            this.Text = "Техника";
            this.Load += new System.EventHandler(this.FormTechnic_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTechnicName;
        private System.Windows.Forms.TextBox textBoxWarranty;
        private System.Windows.Forms.TextBox textBoxProduction;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label labelTechnicName;
        private System.Windows.Forms.Label labelProduction;
        private System.Windows.Forms.Label labelWarranty;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
    }
}