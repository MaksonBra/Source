namespace CourtDecisionsDictionary.View
{
    partial class AdministratorForm
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministratorForm));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnRegionsDictionary = new System.Windows.Forms.Button();
            this.btnCourtsDictionary = new System.Windows.Forms.Button();
            this.btnDocumentTypesDictionary = new System.Windows.Forms.Button();
            this.btnDecisionTypesDictionary = new System.Windows.Forms.Button();
            this.btnJudgesDictionary = new System.Windows.Forms.Button();
            this.pnlSubsystemContainer = new System.Windows.Forms.Panel();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.btnJudgesDictionary);
            this.pnlMenu.Controls.Add(this.btnDecisionTypesDictionary);
            this.pnlMenu.Controls.Add(this.btnDocumentTypesDictionary);
            this.pnlMenu.Controls.Add(this.btnCourtsDictionary);
            this.pnlMenu.Controls.Add(this.btnRegionsDictionary);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(109, 408);
            this.pnlMenu.TabIndex = 0;
            // 
            // btnRegionsDictionary
            // 
            this.btnRegionsDictionary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegionsDictionary.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegionsDictionary.Font = new System.Drawing.Font("Cambria", 10F);
            this.btnRegionsDictionary.Image = ((System.Drawing.Image)(resources.GetObject("btnRegionsDictionary.Image")));
            this.btnRegionsDictionary.Location = new System.Drawing.Point(0, 0);
            this.btnRegionsDictionary.Name = "btnRegionsDictionary";
            this.btnRegionsDictionary.Size = new System.Drawing.Size(109, 68);
            this.btnRegionsDictionary.TabIndex = 0;
            this.btnRegionsDictionary.Text = "Справочник\r\nрегионов";
            this.btnRegionsDictionary.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRegionsDictionary.UseVisualStyleBackColor = true;
            this.btnRegionsDictionary.Click += new System.EventHandler(this.btnRegionsDictionary_Click);
            // 
            // btnCourtsDictionary
            // 
            this.btnCourtsDictionary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCourtsDictionary.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCourtsDictionary.Font = new System.Drawing.Font("Cambria", 10F);
            this.btnCourtsDictionary.Image = ((System.Drawing.Image)(resources.GetObject("btnCourtsDictionary.Image")));
            this.btnCourtsDictionary.Location = new System.Drawing.Point(0, 68);
            this.btnCourtsDictionary.Name = "btnCourtsDictionary";
            this.btnCourtsDictionary.Size = new System.Drawing.Size(109, 86);
            this.btnCourtsDictionary.TabIndex = 1;
            this.btnCourtsDictionary.Text = "Справочник\r\nсудебных\r\nучастков";
            this.btnCourtsDictionary.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCourtsDictionary.UseVisualStyleBackColor = true;
            this.btnCourtsDictionary.Click += new System.EventHandler(this.btnCourtsDictionary_Click);
            // 
            // btnDocumentTypesDictionary
            // 
            this.btnDocumentTypesDictionary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDocumentTypesDictionary.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDocumentTypesDictionary.Font = new System.Drawing.Font("Cambria", 10F);
            this.btnDocumentTypesDictionary.Image = ((System.Drawing.Image)(resources.GetObject("btnDocumentTypesDictionary.Image")));
            this.btnDocumentTypesDictionary.Location = new System.Drawing.Point(0, 154);
            this.btnDocumentTypesDictionary.Name = "btnDocumentTypesDictionary";
            this.btnDocumentTypesDictionary.Size = new System.Drawing.Size(109, 96);
            this.btnDocumentTypesDictionary.TabIndex = 2;
            this.btnDocumentTypesDictionary.Text = "Справочник\r\nтипов\r\nдокументов";
            this.btnDocumentTypesDictionary.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDocumentTypesDictionary.UseVisualStyleBackColor = true;
            this.btnDocumentTypesDictionary.Click += new System.EventHandler(this.btnDocumentTypesDictionary_Click);
            // 
            // btnDecisionTypesDictionary
            // 
            this.btnDecisionTypesDictionary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDecisionTypesDictionary.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDecisionTypesDictionary.Font = new System.Drawing.Font("Cambria", 10F);
            this.btnDecisionTypesDictionary.Image = ((System.Drawing.Image)(resources.GetObject("btnDecisionTypesDictionary.Image")));
            this.btnDecisionTypesDictionary.Location = new System.Drawing.Point(0, 250);
            this.btnDecisionTypesDictionary.Name = "btnDecisionTypesDictionary";
            this.btnDecisionTypesDictionary.Size = new System.Drawing.Size(109, 71);
            this.btnDecisionTypesDictionary.TabIndex = 3;
            this.btnDecisionTypesDictionary.Text = "Справочник\r\nвидов дел";
            this.btnDecisionTypesDictionary.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDecisionTypesDictionary.UseVisualStyleBackColor = true;
            this.btnDecisionTypesDictionary.Click += new System.EventHandler(this.btnDecisionTypesDictionary_Click);
            // 
            // btnJudgesDictionary
            // 
            this.btnJudgesDictionary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnJudgesDictionary.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnJudgesDictionary.Font = new System.Drawing.Font("Cambria", 10F);
            this.btnJudgesDictionary.Image = ((System.Drawing.Image)(resources.GetObject("btnJudgesDictionary.Image")));
            this.btnJudgesDictionary.Location = new System.Drawing.Point(0, 321);
            this.btnJudgesDictionary.Name = "btnJudgesDictionary";
            this.btnJudgesDictionary.Size = new System.Drawing.Size(109, 71);
            this.btnJudgesDictionary.TabIndex = 4;
            this.btnJudgesDictionary.Text = "Справочник\r\nсудей";
            this.btnJudgesDictionary.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnJudgesDictionary.UseVisualStyleBackColor = true;
            this.btnJudgesDictionary.Click += new System.EventHandler(this.btnJudgesDictionary_Click);
            // 
            // pnlSubsystemContainer
            // 
            this.pnlSubsystemContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSubsystemContainer.Location = new System.Drawing.Point(111, 0);
            this.pnlSubsystemContainer.Name = "pnlSubsystemContainer";
            this.pnlSubsystemContainer.Size = new System.Drawing.Size(541, 408);
            this.pnlSubsystemContainer.TabIndex = 1;
            // 
            // AdministratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlSubsystemContainer);
            this.Controls.Add(this.pnlMenu);
            this.Name = "AdministratorForm";
            this.Size = new System.Drawing.Size(655, 408);
            this.pnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnJudgesDictionary;
        private System.Windows.Forms.Button btnDecisionTypesDictionary;
        private System.Windows.Forms.Button btnDocumentTypesDictionary;
        private System.Windows.Forms.Button btnCourtsDictionary;
        private System.Windows.Forms.Button btnRegionsDictionary;
        private System.Windows.Forms.Panel pnlSubsystemContainer;
    }
}
