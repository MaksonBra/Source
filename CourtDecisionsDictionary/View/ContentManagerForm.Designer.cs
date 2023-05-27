namespace CourtDecisionsDictionary.View
{
    partial class ContentManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContentManagerForm));
            this.pnlSubsystemContainer = new System.Windows.Forms.Panel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnLawArticlesDictionary = new System.Windows.Forms.Button();
            this.btnDecisionsCatalogue = new System.Windows.Forms.Button();
            this.btnNewDecision = new System.Windows.Forms.Button();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSubsystemContainer
            // 
            this.pnlSubsystemContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSubsystemContainer.Location = new System.Drawing.Point(112, 0);
            this.pnlSubsystemContainer.Name = "pnlSubsystemContainer";
            this.pnlSubsystemContainer.Size = new System.Drawing.Size(543, 408);
            this.pnlSubsystemContainer.TabIndex = 3;
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.btnLawArticlesDictionary);
            this.pnlMenu.Controls.Add(this.btnDecisionsCatalogue);
            this.pnlMenu.Controls.Add(this.btnNewDecision);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(109, 408);
            this.pnlMenu.TabIndex = 2;
            // 
            // btnLawArticlesDictionary
            // 
            this.btnLawArticlesDictionary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLawArticlesDictionary.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLawArticlesDictionary.Font = new System.Drawing.Font("Cambria", 10F);
            this.btnLawArticlesDictionary.Image = ((System.Drawing.Image)(resources.GetObject("btnLawArticlesDictionary.Image")));
            this.btnLawArticlesDictionary.Location = new System.Drawing.Point(0, 203);
            this.btnLawArticlesDictionary.Name = "btnLawArticlesDictionary";
            this.btnLawArticlesDictionary.Size = new System.Drawing.Size(109, 75);
            this.btnLawArticlesDictionary.TabIndex = 3;
            this.btnLawArticlesDictionary.Text = "Справочник\r\nстатей закона";
            this.btnLawArticlesDictionary.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLawArticlesDictionary.UseVisualStyleBackColor = true;
            this.btnLawArticlesDictionary.Click += new System.EventHandler(this.btnLawArticlesDictionary_Click);
            // 
            // btnDecisionsCatalogue
            // 
            this.btnDecisionsCatalogue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDecisionsCatalogue.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDecisionsCatalogue.Font = new System.Drawing.Font("Cambria", 10F);
            this.btnDecisionsCatalogue.Image = ((System.Drawing.Image)(resources.GetObject("btnDecisionsCatalogue.Image")));
            this.btnDecisionsCatalogue.Location = new System.Drawing.Point(0, 111);
            this.btnDecisionsCatalogue.Name = "btnDecisionsCatalogue";
            this.btnDecisionsCatalogue.Size = new System.Drawing.Size(109, 92);
            this.btnDecisionsCatalogue.TabIndex = 2;
            this.btnDecisionsCatalogue.Text = "Каталог\r\nсудебных\r\nрешений";
            this.btnDecisionsCatalogue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDecisionsCatalogue.UseVisualStyleBackColor = true;
            this.btnDecisionsCatalogue.Click += new System.EventHandler(this.btnDecisionsCatalogue_Click);
            // 
            // btnNewDecision
            // 
            this.btnNewDecision.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewDecision.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNewDecision.Font = new System.Drawing.Font("Cambria", 10F);
            this.btnNewDecision.Image = ((System.Drawing.Image)(resources.GetObject("btnNewDecision.Image")));
            this.btnNewDecision.Location = new System.Drawing.Point(0, 0);
            this.btnNewDecision.Name = "btnNewDecision";
            this.btnNewDecision.Size = new System.Drawing.Size(109, 111);
            this.btnNewDecision.TabIndex = 1;
            this.btnNewDecision.Text = "Регистрация\r\nнового\r\nсудебного\r\nрешения";
            this.btnNewDecision.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNewDecision.UseVisualStyleBackColor = true;
            this.btnNewDecision.Click += new System.EventHandler(this.btnNewDecision_Click);
            // 
            // ContentManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlSubsystemContainer);
            this.Controls.Add(this.pnlMenu);
            this.Name = "ContentManagerForm";
            this.Size = new System.Drawing.Size(655, 408);
            this.pnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSubsystemContainer;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnLawArticlesDictionary;
        private System.Windows.Forms.Button btnDecisionsCatalogue;
        private System.Windows.Forms.Button btnNewDecision;
    }
}
