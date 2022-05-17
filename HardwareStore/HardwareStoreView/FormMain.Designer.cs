
namespace HardwareStoreView
{
    partial class FormMain
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
            this.dataGridViewContents = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.категорииТехникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.техникаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видыДвиженияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.движенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.контрагентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonUpd = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonRef = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContents)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewContents
            // 
            this.dataGridViewContents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewContents.Location = new System.Drawing.Point(0, 36);
            this.dataGridViewContents.Name = "dataGridViewContents";
            this.dataGridViewContents.RowHeadersWidth = 51;
            this.dataGridViewContents.RowTemplate.Height = 29;
            this.dataGridViewContents.Size = new System.Drawing.Size(552, 402);
            this.dataGridViewContents.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справочникиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.категорииТехникиToolStripMenuItem,
            this.техникаToolStripMenuItem,
            this.видыДвиженияToolStripMenuItem,
            this.движенияToolStripMenuItem,
            this.контрагентыToolStripMenuItem});
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // категорииТехникиToolStripMenuItem
            // 
            this.категорииТехникиToolStripMenuItem.Name = "категорииТехникиToolStripMenuItem";
            this.категорииТехникиToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.категорииТехникиToolStripMenuItem.Text = "Категории техники";
            this.категорииТехникиToolStripMenuItem.Click += new System.EventHandler(this.категорииТехникиToolStripMenuItem_Click);
            // 
            // техникаToolStripMenuItem
            // 
            this.техникаToolStripMenuItem.Name = "техникаToolStripMenuItem";
            this.техникаToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.техникаToolStripMenuItem.Text = "Техника";
            this.техникаToolStripMenuItem.Click += new System.EventHandler(this.техникаToolStripMenuItem_Click);
            // 
            // видыДвиженияToolStripMenuItem
            // 
            this.видыДвиженияToolStripMenuItem.Name = "видыДвиженияToolStripMenuItem";
            this.видыДвиженияToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.видыДвиженияToolStripMenuItem.Text = "Виды движения";
            this.видыДвиженияToolStripMenuItem.Click += new System.EventHandler(this.видыДвиженияToolStripMenuItem_Click);
            // 
            // движенияToolStripMenuItem
            // 
            this.движенияToolStripMenuItem.Name = "движенияToolStripMenuItem";
            this.движенияToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.движенияToolStripMenuItem.Text = "Движения";
            this.движенияToolStripMenuItem.Click += new System.EventHandler(this.движенияToolStripMenuItem_Click);
            // 
            // контрагентыToolStripMenuItem
            // 
            this.контрагентыToolStripMenuItem.Name = "контрагентыToolStripMenuItem";
            this.контрагентыToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.контрагентыToolStripMenuItem.Text = "Контрагенты";
            this.контрагентыToolStripMenuItem.Click += new System.EventHandler(this.контрагентыToolStripMenuItem_Click);
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(594, 55);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(170, 34);
            this.buttonCreate.TabIndex = 2;
            this.buttonCreate.Text = "Создать";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // buttonUpd
            // 
            this.buttonUpd.Location = new System.Drawing.Point(594, 112);
            this.buttonUpd.Name = "buttonUpd";
            this.buttonUpd.Size = new System.Drawing.Size(170, 34);
            this.buttonUpd.TabIndex = 3;
            this.buttonUpd.Text = "Изменить";
            this.buttonUpd.UseVisualStyleBackColor = true;
            this.buttonUpd.Click += new System.EventHandler(this.buttonUpd_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(594, 165);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(170, 34);
            this.buttonDel.TabIndex = 4;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonRef
            // 
            this.buttonRef.Location = new System.Drawing.Point(594, 220);
            this.buttonRef.Name = "buttonRef";
            this.buttonRef.Size = new System.Drawing.Size(170, 34);
            this.buttonRef.TabIndex = 5;
            this.buttonRef.Text = "Обновить";
            this.buttonRef.UseVisualStyleBackColor = true;
            this.buttonRef.Click += new System.EventHandler(this.buttonRef_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonRef);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonUpd);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.dataGridViewContents);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Составы продаж/покупок";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContents)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewContents;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem категорииТехникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem техникаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видыДвиженияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem движенияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem контрагентыToolStripMenuItem;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonUpd;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonRef;
    }
}

