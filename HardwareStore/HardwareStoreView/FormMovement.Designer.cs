
namespace HardwareStoreView
{
    partial class FormMovement
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
            this.comboBoxMovementType = new System.Windows.Forms.ComboBox();
            this.comboBoxCounterparty = new System.Windows.Forms.ComboBox();
            this.labelMovementType = new System.Windows.Forms.Label();
            this.labelCounterparty = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxMovementType
            // 
            this.comboBoxMovementType.FormattingEnabled = true;
            this.comboBoxMovementType.Location = new System.Drawing.Point(168, 30);
            this.comboBoxMovementType.Name = "comboBoxMovementType";
            this.comboBoxMovementType.Size = new System.Drawing.Size(238, 28);
            this.comboBoxMovementType.TabIndex = 0;
            // 
            // comboBoxCounterparty
            // 
            this.comboBoxCounterparty.FormattingEnabled = true;
            this.comboBoxCounterparty.Location = new System.Drawing.Point(168, 82);
            this.comboBoxCounterparty.Name = "comboBoxCounterparty";
            this.comboBoxCounterparty.Size = new System.Drawing.Size(238, 28);
            this.comboBoxCounterparty.TabIndex = 1;
            // 
            // labelMovementType
            // 
            this.labelMovementType.AutoSize = true;
            this.labelMovementType.Location = new System.Drawing.Point(39, 33);
            this.labelMovementType.Name = "labelMovementType";
            this.labelMovementType.Size = new System.Drawing.Size(112, 20);
            this.labelMovementType.TabIndex = 2;
            this.labelMovementType.Text = "Вид движения:";
            // 
            // labelCounterparty
            // 
            this.labelCounterparty.AutoSize = true;
            this.labelCounterparty.Location = new System.Drawing.Point(39, 85);
            this.labelCounterparty.Name = "labelCounterparty";
            this.labelCounterparty.Size = new System.Drawing.Size(91, 20);
            this.labelCounterparty.TabIndex = 3;
            this.labelCounterparty.Text = "Контрагент:";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(39, 152);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(0, 20);
            this.labelDate.TabIndex = 4;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(278, 138);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(128, 34);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(135, 138);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(128, 34);
            this.buttonSave.TabIndex = 10;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // FormMovement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 201);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelCounterparty);
            this.Controls.Add(this.labelMovementType);
            this.Controls.Add(this.comboBoxCounterparty);
            this.Controls.Add(this.comboBoxMovementType);
            this.Name = "FormMovement";
            this.Text = "Движение";
            this.Load += new System.EventHandler(this.FormMovement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxMovementType;
        private System.Windows.Forms.ComboBox comboBoxCounterparty;
        private System.Windows.Forms.Label labelMovementType;
        private System.Windows.Forms.Label labelCounterparty;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
    }
}