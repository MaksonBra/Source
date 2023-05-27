namespace CourtDecisionsDictionary.View
{
    partial class ClientForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lawarticleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_CDRSDataSet = new CourtDecisionsDictionary.DB_CDRSDataSet();
            this.documenttypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courtBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.judgeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.law_articleTableAdapter = new CourtDecisionsDictionary.DB_CDRSDataSetTableAdapters.law_articleTableAdapter();
            this.decision_typeTableAdapter = new CourtDecisionsDictionary.DB_CDRSDataSetTableAdapters.decision_typeTableAdapter();
            this.document_typeTableAdapter = new CourtDecisionsDictionary.DB_CDRSDataSetTableAdapters.document_typeTableAdapter();
            this.courtTableAdapter = new CourtDecisionsDictionary.DB_CDRSDataSetTableAdapters.courtTableAdapter();
            this.judgeTableAdapter = new CourtDecisionsDictionary.DB_CDRSDataSetTableAdapters.judgeTableAdapter();
            this.decisiontypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorViewContentItem = new System.Windows.Forms.ToolStripButton();
            this.documentDataGridView = new System.Windows.Forms.DataGridView();
            this.documentBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.grpFilter = new System.Windows.Forms.GroupBox();
            this.btnResetFilter = new System.Windows.Forms.Button();
            this.btnApplyFilter = new System.Windows.Forms.Button();
            this.txtFilterCourt = new System.Windows.Forms.TextBox();
            this.txtFilterLawArticle = new System.Windows.Forms.TextBox();
            this.txtFilterRegion = new System.Windows.Forms.TextBox();
            this.txtFilterJudge = new System.Windows.Forms.TextBox();
            this.txtFilterDecisionNumber = new System.Windows.Forms.TextBox();
            this.chkFilterLawArticleOn = new System.Windows.Forms.CheckBox();
            this.chkFilterCourtOn = new System.Windows.Forms.CheckBox();
            this.chkFilterRegionOn = new System.Windows.Forms.CheckBox();
            this.chkFilterJudgeOn = new System.Windows.Forms.CheckBox();
            this.chkFilterDecisionNumberOn = new System.Windows.Forms.CheckBox();
            this.picFilterIcon = new System.Windows.Forms.PictureBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewCourtColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewJudgeColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.lawarticleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_CDRSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documenttypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courtBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.judgeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.decisiontypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentBindingNavigator)).BeginInit();
            this.documentBindingNavigator.SuspendLayout();
            this.grpFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFilterIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lawarticleBindingSource
            // 
            this.lawarticleBindingSource.DataMember = "law_article";
            this.lawarticleBindingSource.DataSource = this.dB_CDRSDataSet;
            // 
            // dB_CDRSDataSet
            // 
            this.dB_CDRSDataSet.DataSetName = "DB_CDRSDataSet";
            this.dB_CDRSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // documenttypeBindingSource
            // 
            this.documenttypeBindingSource.DataMember = "document_type";
            this.documenttypeBindingSource.DataSource = this.dB_CDRSDataSet;
            // 
            // courtBindingSource
            // 
            this.courtBindingSource.DataMember = "court";
            this.courtBindingSource.DataSource = this.dB_CDRSDataSet;
            // 
            // judgeBindingSource
            // 
            this.judgeBindingSource.DataMember = "judge";
            this.judgeBindingSource.DataSource = this.dB_CDRSDataSet;
            // 
            // law_articleTableAdapter
            // 
            this.law_articleTableAdapter.ClearBeforeFill = true;
            // 
            // decision_typeTableAdapter
            // 
            this.decision_typeTableAdapter.ClearBeforeFill = true;
            // 
            // document_typeTableAdapter
            // 
            this.document_typeTableAdapter.ClearBeforeFill = true;
            // 
            // courtTableAdapter
            // 
            this.courtTableAdapter.ClearBeforeFill = true;
            // 
            // judgeTableAdapter
            // 
            this.judgeTableAdapter.ClearBeforeFill = true;
            // 
            // decisiontypeBindingSource
            // 
            this.decisiontypeBindingSource.DataMember = "decision_type";
            this.decisiontypeBindingSource.DataSource = this.dB_CDRSDataSet;
            // 
            // bindingNavigatorViewContentItem
            // 
            this.bindingNavigatorViewContentItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorViewContentItem.Image")));
            this.bindingNavigatorViewContentItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorViewContentItem.Name = "bindingNavigatorViewContentItem";
            this.bindingNavigatorViewContentItem.Size = new System.Drawing.Size(112, 22);
            this.bindingNavigatorViewContentItem.Text = "Просмотр дела";
            this.bindingNavigatorViewContentItem.Click += new System.EventHandler(this.bindingNavigatorViewContentItem_Click);
            // 
            // documentDataGridView
            // 
            this.documentDataGridView.AllowUserToAddRows = false;
            this.documentDataGridView.AllowUserToDeleteRows = false;
            this.documentDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.documentDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.documentDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.documentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.documentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewCourtColumn,
            this.dataGridViewJudgeColumn});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.documentDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.documentDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.documentDataGridView.Location = new System.Drawing.Point(0, 25);
            this.documentDataGridView.MultiSelect = false;
            this.documentDataGridView.Name = "documentDataGridView";
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.documentDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.documentDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.documentDataGridView.Size = new System.Drawing.Size(655, 263);
            this.documentDataGridView.TabIndex = 3;
            // 
            // documentBindingNavigator
            // 
            this.documentBindingNavigator.AddNewItem = null;
            this.documentBindingNavigator.CountItem = null;
            this.documentBindingNavigator.DeleteItem = null;
            this.documentBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorViewContentItem});
            this.documentBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.documentBindingNavigator.MoveFirstItem = null;
            this.documentBindingNavigator.MoveLastItem = null;
            this.documentBindingNavigator.MoveNextItem = null;
            this.documentBindingNavigator.MovePreviousItem = null;
            this.documentBindingNavigator.Name = "documentBindingNavigator";
            this.documentBindingNavigator.PositionItem = null;
            this.documentBindingNavigator.Size = new System.Drawing.Size(655, 25);
            this.documentBindingNavigator.TabIndex = 2;
            this.documentBindingNavigator.Text = "bindingNavigator1";
            // 
            // grpFilter
            // 
            this.grpFilter.Controls.Add(this.btnResetFilter);
            this.grpFilter.Controls.Add(this.btnApplyFilter);
            this.grpFilter.Controls.Add(this.txtFilterCourt);
            this.grpFilter.Controls.Add(this.txtFilterLawArticle);
            this.grpFilter.Controls.Add(this.txtFilterRegion);
            this.grpFilter.Controls.Add(this.txtFilterJudge);
            this.grpFilter.Controls.Add(this.txtFilterDecisionNumber);
            this.grpFilter.Controls.Add(this.chkFilterLawArticleOn);
            this.grpFilter.Controls.Add(this.chkFilterCourtOn);
            this.grpFilter.Controls.Add(this.chkFilterRegionOn);
            this.grpFilter.Controls.Add(this.chkFilterJudgeOn);
            this.grpFilter.Controls.Add(this.chkFilterDecisionNumberOn);
            this.grpFilter.Controls.Add(this.picFilterIcon);
            this.grpFilter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpFilter.Location = new System.Drawing.Point(0, 294);
            this.grpFilter.Name = "grpFilter";
            this.grpFilter.Size = new System.Drawing.Size(655, 90);
            this.grpFilter.TabIndex = 4;
            this.grpFilter.TabStop = false;
            this.grpFilter.Text = "Фильтр:";
            // 
            // btnResetFilter
            // 
            this.btnResetFilter.Location = new System.Drawing.Point(486, 39);
            this.btnResetFilter.Name = "btnResetFilter";
            this.btnResetFilter.Size = new System.Drawing.Size(75, 23);
            this.btnResetFilter.TabIndex = 11;
            this.btnResetFilter.Text = "Сбросить";
            this.btnResetFilter.UseVisualStyleBackColor = true;
            this.btnResetFilter.Click += new System.EventHandler(this.btnResetFilter_Click);
            // 
            // btnApplyFilter
            // 
            this.btnApplyFilter.Location = new System.Drawing.Point(486, 16);
            this.btnApplyFilter.Name = "btnApplyFilter";
            this.btnApplyFilter.Size = new System.Drawing.Size(75, 23);
            this.btnApplyFilter.TabIndex = 10;
            this.btnApplyFilter.Text = "Применить";
            this.btnApplyFilter.UseVisualStyleBackColor = true;
            this.btnApplyFilter.Click += new System.EventHandler(this.btnApplyFilter_Click);
            // 
            // txtFilterCourt
            // 
            this.txtFilterCourt.Location = new System.Drawing.Point(358, 40);
            this.txtFilterCourt.Name = "txtFilterCourt";
            this.txtFilterCourt.Size = new System.Drawing.Size(121, 20);
            this.txtFilterCourt.TabIndex = 9;
            // 
            // txtFilterLawArticle
            // 
            this.txtFilterLawArticle.Location = new System.Drawing.Point(358, 17);
            this.txtFilterLawArticle.Name = "txtFilterLawArticle";
            this.txtFilterLawArticle.Size = new System.Drawing.Size(121, 20);
            this.txtFilterLawArticle.TabIndex = 8;
            // 
            // txtFilterRegion
            // 
            this.txtFilterRegion.Location = new System.Drawing.Point(148, 63);
            this.txtFilterRegion.Name = "txtFilterRegion";
            this.txtFilterRegion.Size = new System.Drawing.Size(121, 20);
            this.txtFilterRegion.TabIndex = 7;
            // 
            // txtFilterJudge
            // 
            this.txtFilterJudge.Location = new System.Drawing.Point(148, 40);
            this.txtFilterJudge.Name = "txtFilterJudge";
            this.txtFilterJudge.Size = new System.Drawing.Size(121, 20);
            this.txtFilterJudge.TabIndex = 6;
            // 
            // txtFilterDecisionNumber
            // 
            this.txtFilterDecisionNumber.Location = new System.Drawing.Point(148, 17);
            this.txtFilterDecisionNumber.Name = "txtFilterDecisionNumber";
            this.txtFilterDecisionNumber.Size = new System.Drawing.Size(121, 20);
            this.txtFilterDecisionNumber.TabIndex = 5;
            // 
            // chkFilterLawArticleOn
            // 
            this.chkFilterLawArticleOn.AutoSize = true;
            this.chkFilterLawArticleOn.Location = new System.Drawing.Point(288, 19);
            this.chkFilterLawArticleOn.Name = "chkFilterLawArticleOn";
            this.chkFilterLawArticleOn.Size = new System.Drawing.Size(64, 17);
            this.chkFilterLawArticleOn.TabIndex = 4;
            this.chkFilterLawArticleOn.Text = "Статья:";
            this.chkFilterLawArticleOn.UseVisualStyleBackColor = true;
            // 
            // chkFilterCourtOn
            // 
            this.chkFilterCourtOn.AutoSize = true;
            this.chkFilterCourtOn.Location = new System.Drawing.Point(288, 42);
            this.chkFilterCourtOn.Name = "chkFilterCourtOn";
            this.chkFilterCourtOn.Size = new System.Drawing.Size(71, 17);
            this.chkFilterCourtOn.TabIndex = 4;
            this.chkFilterCourtOn.Text = "Участок:";
            this.chkFilterCourtOn.UseVisualStyleBackColor = true;
            // 
            // chkFilterRegionOn
            // 
            this.chkFilterRegionOn.AutoSize = true;
            this.chkFilterRegionOn.Location = new System.Drawing.Point(52, 65);
            this.chkFilterRegionOn.Name = "chkFilterRegionOn";
            this.chkFilterRegionOn.Size = new System.Drawing.Size(65, 17);
            this.chkFilterRegionOn.TabIndex = 3;
            this.chkFilterRegionOn.Text = "Регион:";
            this.chkFilterRegionOn.UseVisualStyleBackColor = true;
            // 
            // chkFilterJudgeOn
            // 
            this.chkFilterJudgeOn.AutoSize = true;
            this.chkFilterJudgeOn.Location = new System.Drawing.Point(52, 42);
            this.chkFilterJudgeOn.Name = "chkFilterJudgeOn";
            this.chkFilterJudgeOn.Size = new System.Drawing.Size(59, 17);
            this.chkFilterJudgeOn.TabIndex = 2;
            this.chkFilterJudgeOn.Text = "Судья:";
            this.chkFilterJudgeOn.UseVisualStyleBackColor = true;
            // 
            // chkFilterDecisionNumberOn
            // 
            this.chkFilterDecisionNumberOn.AutoSize = true;
            this.chkFilterDecisionNumberOn.Location = new System.Drawing.Point(52, 19);
            this.chkFilterDecisionNumberOn.Name = "chkFilterDecisionNumberOn";
            this.chkFilterDecisionNumberOn.Size = new System.Drawing.Size(90, 17);
            this.chkFilterDecisionNumberOn.TabIndex = 1;
            this.chkFilterDecisionNumberOn.Text = "Номер дела:";
            this.chkFilterDecisionNumberOn.UseVisualStyleBackColor = true;
            // 
            // picFilterIcon
            // 
            this.picFilterIcon.Image = ((System.Drawing.Image)(resources.GetObject("picFilterIcon.Image")));
            this.picFilterIcon.Location = new System.Drawing.Point(9, 24);
            this.picFilterIcon.Name = "picFilterIcon";
            this.picFilterIcon.Size = new System.Drawing.Size(30, 30);
            this.picFilterIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFilterIcon.TabIndex = 0;
            this.picFilterIcon.TabStop = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn2.HeaderText = "Дело №";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 70;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn3.HeaderText = "Дата";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 70;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn9.DataSource = this.lawarticleBindingSource;
            this.dataGridViewTextBoxColumn9.DisplayMember = "name";
            this.dataGridViewTextBoxColumn9.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn9.FillWeight = 11F;
            this.dataGridViewTextBoxColumn9.HeaderText = "Предмет спора";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn9.ValueMember = "id";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "content_file_name";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataSource = this.decisiontypeBindingSource;
            this.dataGridViewTextBoxColumn5.DisplayMember = "name";
            this.dataGridViewTextBoxColumn5.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn5.FillWeight = 17F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Вид дела";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn5.ValueMember = "id";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataSource = this.documenttypeBindingSource;
            this.dataGridViewTextBoxColumn6.DisplayMember = "name";
            this.dataGridViewTextBoxColumn6.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn6.FillWeight = 17F;
            this.dataGridViewTextBoxColumn6.HeaderText = "Вид решения";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn6.ValueMember = "id";
            // 
            // dataGridViewCourtColumn
            // 
            this.dataGridViewCourtColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewCourtColumn.DataSource = this.courtBindingSource;
            this.dataGridViewCourtColumn.DisplayMember = "name";
            this.dataGridViewCourtColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewCourtColumn.FillWeight = 30F;
            this.dataGridViewCourtColumn.HeaderText = "Участок";
            this.dataGridViewCourtColumn.Name = "dataGridViewCourtColumn";
            this.dataGridViewCourtColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCourtColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewCourtColumn.ValueMember = "id";
            // 
            // dataGridViewJudgeColumn
            // 
            this.dataGridViewJudgeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewJudgeColumn.DataSource = this.judgeBindingSource;
            this.dataGridViewJudgeColumn.DisplayMember = "first_name";
            this.dataGridViewJudgeColumn.FillWeight = 25F;
            this.dataGridViewJudgeColumn.HeaderText = "Судья";
            this.dataGridViewJudgeColumn.Name = "dataGridViewJudgeColumn";
            this.dataGridViewJudgeColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewJudgeColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewJudgeColumn.ValueMember = "id";
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpFilter);
            this.Controls.Add(this.documentDataGridView);
            this.Controls.Add(this.documentBindingNavigator);
            this.Name = "ClientForm";
            this.Size = new System.Drawing.Size(655, 384);
            ((System.ComponentModel.ISupportInitialize)(this.lawarticleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_CDRSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documenttypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courtBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.judgeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.decisiontypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentBindingNavigator)).EndInit();
            this.documentBindingNavigator.ResumeLayout(false);
            this.documentBindingNavigator.PerformLayout();
            this.grpFilter.ResumeLayout(false);
            this.grpFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFilterIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource lawarticleBindingSource;
        private DB_CDRSDataSet dB_CDRSDataSet;
        private System.Windows.Forms.BindingSource documenttypeBindingSource;
        private System.Windows.Forms.BindingSource courtBindingSource;
        private System.Windows.Forms.BindingSource judgeBindingSource;
        private DB_CDRSDataSetTableAdapters.law_articleTableAdapter law_articleTableAdapter;
        private DB_CDRSDataSetTableAdapters.decision_typeTableAdapter decision_typeTableAdapter;
        private DB_CDRSDataSetTableAdapters.document_typeTableAdapter document_typeTableAdapter;
        private DB_CDRSDataSetTableAdapters.courtTableAdapter courtTableAdapter;
        private DB_CDRSDataSetTableAdapters.judgeTableAdapter judgeTableAdapter;
        private System.Windows.Forms.BindingSource decisiontypeBindingSource;
        private System.Windows.Forms.ToolStripButton bindingNavigatorViewContentItem;
        private System.Windows.Forms.DataGridView documentDataGridView;
        private System.Windows.Forms.BindingNavigator documentBindingNavigator;
        private System.Windows.Forms.GroupBox grpFilter;
        private System.Windows.Forms.Button btnResetFilter;
        private System.Windows.Forms.Button btnApplyFilter;
        private System.Windows.Forms.TextBox txtFilterCourt;
        private System.Windows.Forms.TextBox txtFilterLawArticle;
        private System.Windows.Forms.TextBox txtFilterRegion;
        private System.Windows.Forms.TextBox txtFilterJudge;
        private System.Windows.Forms.TextBox txtFilterDecisionNumber;
        private System.Windows.Forms.CheckBox chkFilterLawArticleOn;
        private System.Windows.Forms.CheckBox chkFilterCourtOn;
        private System.Windows.Forms.CheckBox chkFilterRegionOn;
        private System.Windows.Forms.CheckBox chkFilterJudgeOn;
        private System.Windows.Forms.CheckBox chkFilterDecisionNumberOn;
        private System.Windows.Forms.PictureBox picFilterIcon;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewCourtColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewJudgeColumn;
    }
}
