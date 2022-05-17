
namespace HardwareStoreView
{
    partial class FormMovementType
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
            this.textBoxMovementTypeName = new System.Windows.Forms.TextBox();
            this.labelMovementTypeName = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxMovementTypeName
            // 
            this.textBoxMovementTypeName.Location = new System.Drawing.Point(168, 31);
            this.textBoxMovementTypeName.Name = "textBoxMovementTypeName";
            this.textBoxMovementTypeName.Size = new System.Drawing.Size(196, 27);
            this.textBoxMovementTypeName.TabIndex = 0;
            // 
            // labelMovementTypeName
            // 
            this.labelMovementTypeName.AutoSize = true;
            this.labelMovementTypeName.Location = new System.Drawing.Point(27, 34);
            this.labelMovementTypeName.Name = "labelMovementTypeName";
            this.labelMovementTypeName.Size = new System.Drawing.Size(112, 20);
            this.labelMovementTypeName.TabIndex = 1;
            this.labelMovementTypeName.Text = "Вид движения:";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(69, 82);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(136, 33);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(228, 82);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(136, 33);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FormMovementType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 146);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelMovementTypeName);
            this.Controls.Add(this.textBoxMovementTypeName);
            this.Name = "FormMovementType";
            this.Text = "Вид движения";
            this.Load += new System.EventHandler(this.FormMovementType_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMovementTypeName;
        private System.Windows.Forms.Label labelMovementTypeName;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
    }
}