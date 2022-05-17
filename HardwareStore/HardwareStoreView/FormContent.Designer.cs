
namespace HardwareStoreView
{
    partial class FormContent
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
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.textBoxCost = new System.Windows.Forms.TextBox();
            this.labelMovement = new System.Windows.Forms.Label();
            this.labelCost = new System.Windows.Forms.Label();
            this.labelCount = new System.Windows.Forms.Label();
            this.labelTechnic = new System.Windows.Forms.Label();
            this.comboBoxMovement = new System.Windows.Forms.ComboBox();
            this.comboBoxTechnic = new System.Windows.Forms.ComboBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxCount
            // 
            this.textBoxCount.Location = new System.Drawing.Point(209, 121);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(199, 27);
            this.textBoxCount.TabIndex = 0;
            // 
            // textBoxCost
            // 
            this.textBoxCost.Location = new System.Drawing.Point(209, 170);
            this.textBoxCost.Name = "textBoxCost";
            this.textBoxCost.Size = new System.Drawing.Size(199, 27);
            this.textBoxCost.TabIndex = 1;
            // 
            // labelMovement
            // 
            this.labelMovement.AutoSize = true;
            this.labelMovement.Location = new System.Drawing.Point(36, 28);
            this.labelMovement.Name = "labelMovement";
            this.labelMovement.Size = new System.Drawing.Size(84, 20);
            this.labelMovement.TabIndex = 2;
            this.labelMovement.Text = "Движение:";
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Location = new System.Drawing.Point(36, 173);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(153, 20);
            this.labelCost.TabIndex = 3;
            this.labelCost.Text = "Стоимость единицы:";
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(36, 124);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(93, 20);
            this.labelCount.TabIndex = 4;
            this.labelCount.Text = "Количество:";
            // 
            // labelTechnic
            // 
            this.labelTechnic.AutoSize = true;
            this.labelTechnic.Location = new System.Drawing.Point(36, 75);
            this.labelTechnic.Name = "labelTechnic";
            this.labelTechnic.Size = new System.Drawing.Size(68, 20);
            this.labelTechnic.TabIndex = 5;
            this.labelTechnic.Text = "Техника:";
            // 
            // comboBoxMovement
            // 
            this.comboBoxMovement.FormattingEnabled = true;
            this.comboBoxMovement.Location = new System.Drawing.Point(157, 25);
            this.comboBoxMovement.Name = "comboBoxMovement";
            this.comboBoxMovement.Size = new System.Drawing.Size(299, 28);
            this.comboBoxMovement.TabIndex = 6;
            // 
            // comboBoxTechnic
            // 
            this.comboBoxTechnic.FormattingEnabled = true;
            this.comboBoxTechnic.Location = new System.Drawing.Point(157, 72);
            this.comboBoxTechnic.Name = "comboBoxTechnic";
            this.comboBoxTechnic.Size = new System.Drawing.Size(299, 28);
            this.comboBoxTechnic.TabIndex = 7;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(185, 226);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(128, 34);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(328, 226);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(128, 34);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FormContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 299);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.comboBoxTechnic);
            this.Controls.Add(this.comboBoxMovement);
            this.Controls.Add(this.labelTechnic);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.labelCost);
            this.Controls.Add(this.labelMovement);
            this.Controls.Add(this.textBoxCost);
            this.Controls.Add(this.textBoxCount);
            this.Name = "FormContent";
            this.Text = "Создание состава";
            this.Load += new System.EventHandler(this.FormContent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.TextBox textBoxCost;
        private System.Windows.Forms.Label labelMovement;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Label labelTechnic;
        private System.Windows.Forms.ComboBox comboBoxMovement;
        private System.Windows.Forms.ComboBox comboBoxTechnic;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
    }
}