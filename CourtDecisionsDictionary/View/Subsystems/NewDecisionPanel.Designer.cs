namespace CourtDecisionsDictionary.View.Subsystems
{
    partial class NewDecisionPanel
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
            System.Windows.Forms.Label decision_numberLabel;
            System.Windows.Forms.Label decision_dateLabel;
            System.Windows.Forms.Label content_file_nameLabel;
            System.Windows.Forms.Label decision_type_idLabel;
            System.Windows.Forms.Label document_type_idLabel;
            System.Windows.Forms.Label court_idLabel;
            System.Windows.Forms.Label judge_idLabel;
            System.Windows.Forms.Label law_area_idLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewDecisionPanel));
            this.dB_CDRSDataSet = new CourtDecisionsDictionary.DB_CDRSDataSet();
            this.courtTableAdapter = new CourtDecisionsDictionary.DB_CDRSDataSetTableAdapters.courtTableAdapter();
            this.decision_typeTableAdapter = new CourtDecisionsDictionary.DB_CDRSDataSetTableAdapters.decision_typeTableAdapter();
            this.document_typeTableAdapter = new CourtDecisionsDictionary.DB_CDRSDataSetTableAdapters.document_typeTableAdapter();
            this.documentBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.documentBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.decision_numberTextBox = new System.Windows.Forms.TextBox();
            this.decision_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.content_file_nameTextBox = new System.Windows.Forms.TextBox();
            this.decision_type_idComboBox = new System.Windows.Forms.ComboBox();
            this.decisiontypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.document_type_idComboBox = new System.Windows.Forms.ComboBox();
            this.documenttypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.court_idComboBox = new System.Windows.Forms.ComboBox();
            this.courtBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.judge_idComboBox = new System.Windows.Forms.ComboBox();
            this.judgeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.law_area_idComboBox = new System.Windows.Forms.ComboBox();
            this.lawarticleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnBrowseFile = new System.Windows.Forms.Button();
            this.judgeTableAdapter = new CourtDecisionsDictionary.DB_CDRSDataSetTableAdapters.judgeTableAdapter();
            this.law_articleTableAdapter = new CourtDecisionsDictionary.DB_CDRSDataSetTableAdapters.law_articleTableAdapter();
            decision_numberLabel = new System.Windows.Forms.Label();
            decision_dateLabel = new System.Windows.Forms.Label();
            content_file_nameLabel = new System.Windows.Forms.Label();
            decision_type_idLabel = new System.Windows.Forms.Label();
            document_type_idLabel = new System.Windows.Forms.Label();
            court_idLabel = new System.Windows.Forms.Label();
            judge_idLabel = new System.Windows.Forms.Label();
            law_area_idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dB_CDRSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentBindingNavigator)).BeginInit();
            this.documentBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.decisiontypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documenttypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courtBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.judgeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lawarticleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // decision_numberLabel
            // 
            decision_numberLabel.AutoSize = true;
            decision_numberLabel.Location = new System.Drawing.Point(73, 48);
            decision_numberLabel.Name = "decision_numberLabel";
            decision_numberLabel.Size = new System.Drawing.Size(71, 13);
            decision_numberLabel.TabIndex = 1;
            decision_numberLabel.Text = "Номер дела:";
            // 
            // decision_dateLabel
            // 
            decision_dateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            decision_dateLabel.AutoSize = true;
            decision_dateLabel.Location = new System.Drawing.Point(357, 48);
            decision_dateLabel.Name = "decision_dateLabel";
            decision_dateLabel.Size = new System.Drawing.Size(36, 13);
            decision_dateLabel.TabIndex = 3;
            decision_dateLabel.Text = "Дата:";
            // 
            // content_file_nameLabel
            // 
            content_file_nameLabel.AutoSize = true;
            content_file_nameLabel.Location = new System.Drawing.Point(7, 98);
            content_file_nameLabel.Name = "content_file_nameLabel";
            content_file_nameLabel.Size = new System.Drawing.Size(137, 13);
            content_file_nameLabel.TabIndex = 5;
            content_file_nameLabel.Text = "Файл содерджания дела:";
            // 
            // decision_type_idLabel
            // 
            decision_type_idLabel.AutoSize = true;
            decision_type_idLabel.Location = new System.Drawing.Point(88, 124);
            decision_type_idLabel.Name = "decision_type_idLabel";
            decision_type_idLabel.Size = new System.Drawing.Size(56, 13);
            decision_type_idLabel.TabIndex = 7;
            decision_type_idLabel.Text = "Вид дела:";
            // 
            // document_type_idLabel
            // 
            document_type_idLabel.AutoSize = true;
            document_type_idLabel.Location = new System.Drawing.Point(68, 151);
            document_type_idLabel.Name = "document_type_idLabel";
            document_type_idLabel.Size = new System.Drawing.Size(76, 13);
            document_type_idLabel.TabIndex = 9;
            document_type_idLabel.Text = "Вид решения:";
            // 
            // court_idLabel
            // 
            court_idLabel.AutoSize = true;
            court_idLabel.Location = new System.Drawing.Point(92, 178);
            court_idLabel.Name = "court_idLabel";
            court_idLabel.Size = new System.Drawing.Size(52, 13);
            court_idLabel.TabIndex = 11;
            court_idLabel.Text = "Участок:";
            // 
            // judge_idLabel
            // 
            judge_idLabel.AutoSize = true;
            judge_idLabel.Location = new System.Drawing.Point(104, 205);
            judge_idLabel.Name = "judge_idLabel";
            judge_idLabel.Size = new System.Drawing.Size(40, 13);
            judge_idLabel.TabIndex = 13;
            judge_idLabel.Text = "Судья:";
            // 
            // law_area_idLabel
            // 
            law_area_idLabel.AutoSize = true;
            law_area_idLabel.Location = new System.Drawing.Point(56, 232);
            law_area_idLabel.Name = "law_area_idLabel";
            law_area_idLabel.Size = new System.Drawing.Size(88, 13);
            law_area_idLabel.TabIndex = 15;
            law_area_idLabel.Text = "Предмет спора:";
            // 
            // dB_CDRSDataSet
            // 
            this.dB_CDRSDataSet.DataSetName = "DB_CDRSDataSet";
            this.dB_CDRSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courtTableAdapter
            // 
            this.courtTableAdapter.ClearBeforeFill = true;
            // 
            // decision_typeTableAdapter
            // 
            this.decision_typeTableAdapter.ClearBeforeFill = true;
            // 
            // document_typeTableAdapter
            // 
            this.document_typeTableAdapter.ClearBeforeFill = true;
            // 
            // documentBindingNavigator
            // 
            this.documentBindingNavigator.AddNewItem = null;
            this.documentBindingNavigator.CountItem = null;
            this.documentBindingNavigator.DeleteItem = null;
            this.documentBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.documentBindingNavigatorSaveItem});
            this.documentBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.documentBindingNavigator.MoveFirstItem = null;
            this.documentBindingNavigator.MoveLastItem = null;
            this.documentBindingNavigator.MoveNextItem = null;
            this.documentBindingNavigator.MovePreviousItem = null;
            this.documentBindingNavigator.Name = "documentBindingNavigator";
            this.documentBindingNavigator.PositionItem = null;
            this.documentBindingNavigator.Size = new System.Drawing.Size(571, 25);
            this.documentBindingNavigator.TabIndex = 0;
            this.documentBindingNavigator.Text = "bindingNavigator1";
            // 
            // documentBindingNavigatorSaveItem
            // 
            this.documentBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("documentBindingNavigatorSaveItem.Image")));
            this.documentBindingNavigatorSaveItem.Name = "documentBindingNavigatorSaveItem";
            this.documentBindingNavigatorSaveItem.Size = new System.Drawing.Size(129, 22);
            this.documentBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.documentBindingNavigatorSaveItem.Click += new System.EventHandler(this.documentBindingNavigatorSaveItem_Click);
            // 
            // decision_numberTextBox
            // 
            this.decision_numberTextBox.Location = new System.Drawing.Point(147, 44);
            this.decision_numberTextBox.MaxLength = 30;
            this.decision_numberTextBox.Name = "decision_numberTextBox";
            this.decision_numberTextBox.Size = new System.Drawing.Size(200, 20);
            this.decision_numberTextBox.TabIndex = 2;
            // 
            // decision_dateDateTimePicker
            // 
            this.decision_dateDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.decision_dateDateTimePicker.Location = new System.Drawing.Point(396, 44);
            this.decision_dateDateTimePicker.Name = "decision_dateDateTimePicker";
            this.decision_dateDateTimePicker.Size = new System.Drawing.Size(163, 20);
            this.decision_dateDateTimePicker.TabIndex = 4;
            // 
            // content_file_nameTextBox
            // 
            this.content_file_nameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.content_file_nameTextBox.Location = new System.Drawing.Point(147, 94);
            this.content_file_nameTextBox.Name = "content_file_nameTextBox";
            this.content_file_nameTextBox.Size = new System.Drawing.Size(344, 20);
            this.content_file_nameTextBox.TabIndex = 6;
            // 
            // decision_type_idComboBox
            // 
            this.decision_type_idComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.decision_type_idComboBox.DataSource = this.decisiontypeBindingSource;
            this.decision_type_idComboBox.DisplayMember = "name";
            this.decision_type_idComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.decision_type_idComboBox.FormattingEnabled = true;
            this.decision_type_idComboBox.Location = new System.Drawing.Point(147, 120);
            this.decision_type_idComboBox.Name = "decision_type_idComboBox";
            this.decision_type_idComboBox.Size = new System.Drawing.Size(412, 21);
            this.decision_type_idComboBox.TabIndex = 8;
            this.decision_type_idComboBox.ValueMember = "id";
            // 
            // decisiontypeBindingSource
            // 
            this.decisiontypeBindingSource.DataMember = "decision_type";
            this.decisiontypeBindingSource.DataSource = this.dB_CDRSDataSet;
            // 
            // document_type_idComboBox
            // 
            this.document_type_idComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.document_type_idComboBox.DataSource = this.documenttypeBindingSource;
            this.document_type_idComboBox.DisplayMember = "name";
            this.document_type_idComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.document_type_idComboBox.FormattingEnabled = true;
            this.document_type_idComboBox.Location = new System.Drawing.Point(147, 147);
            this.document_type_idComboBox.Name = "document_type_idComboBox";
            this.document_type_idComboBox.Size = new System.Drawing.Size(412, 21);
            this.document_type_idComboBox.TabIndex = 10;
            this.document_type_idComboBox.ValueMember = "id";
            // 
            // documenttypeBindingSource
            // 
            this.documenttypeBindingSource.DataMember = "document_type";
            this.documenttypeBindingSource.DataSource = this.dB_CDRSDataSet;
            // 
            // court_idComboBox
            // 
            this.court_idComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.court_idComboBox.DataSource = this.courtBindingSource;
            this.court_idComboBox.DisplayMember = "name";
            this.court_idComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.court_idComboBox.FormattingEnabled = true;
            this.court_idComboBox.Location = new System.Drawing.Point(147, 174);
            this.court_idComboBox.Name = "court_idComboBox";
            this.court_idComboBox.Size = new System.Drawing.Size(412, 21);
            this.court_idComboBox.TabIndex = 12;
            this.court_idComboBox.ValueMember = "id";
            // 
            // courtBindingSource
            // 
            this.courtBindingSource.DataMember = "court";
            this.courtBindingSource.DataSource = this.dB_CDRSDataSet;
            // 
            // judge_idComboBox
            // 
            this.judge_idComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.judge_idComboBox.DataSource = this.judgeBindingSource;
            this.judge_idComboBox.DisplayMember = "first_name";
            this.judge_idComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.judge_idComboBox.FormattingEnabled = true;
            this.judge_idComboBox.Location = new System.Drawing.Point(147, 201);
            this.judge_idComboBox.Name = "judge_idComboBox";
            this.judge_idComboBox.Size = new System.Drawing.Size(412, 21);
            this.judge_idComboBox.TabIndex = 14;
            this.judge_idComboBox.ValueMember = "id";
            // 
            // judgeBindingSource
            // 
            this.judgeBindingSource.DataMember = "judge";
            this.judgeBindingSource.DataSource = this.dB_CDRSDataSet;
            // 
            // law_area_idComboBox
            // 
            this.law_area_idComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.law_area_idComboBox.DataSource = this.lawarticleBindingSource;
            this.law_area_idComboBox.DisplayMember = "name";
            this.law_area_idComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.law_area_idComboBox.FormattingEnabled = true;
            this.law_area_idComboBox.Location = new System.Drawing.Point(147, 228);
            this.law_area_idComboBox.Name = "law_area_idComboBox";
            this.law_area_idComboBox.Size = new System.Drawing.Size(412, 21);
            this.law_area_idComboBox.TabIndex = 16;
            this.law_area_idComboBox.ValueMember = "id";
            // 
            // lawarticleBindingSource
            // 
            this.lawarticleBindingSource.DataMember = "law_article";
            this.lawarticleBindingSource.DataSource = this.dB_CDRSDataSet;
            // 
            // btnBrowseFile
            // 
            this.btnBrowseFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseFile.Location = new System.Drawing.Point(493, 93);
            this.btnBrowseFile.Name = "btnBrowseFile";
            this.btnBrowseFile.Size = new System.Drawing.Size(66, 23);
            this.btnBrowseFile.TabIndex = 17;
            this.btnBrowseFile.Text = "Обзор...";
            this.btnBrowseFile.UseVisualStyleBackColor = true;
            this.btnBrowseFile.Click += new System.EventHandler(this.btnBrowseFile_Click);
            // 
            // judgeTableAdapter
            // 
            this.judgeTableAdapter.ClearBeforeFill = true;
            // 
            // law_articleTableAdapter
            // 
            this.law_articleTableAdapter.ClearBeforeFill = true;
            // 
            // NewDecisionPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnBrowseFile);
            this.Controls.Add(law_area_idLabel);
            this.Controls.Add(this.law_area_idComboBox);
            this.Controls.Add(judge_idLabel);
            this.Controls.Add(this.judge_idComboBox);
            this.Controls.Add(court_idLabel);
            this.Controls.Add(this.court_idComboBox);
            this.Controls.Add(document_type_idLabel);
            this.Controls.Add(this.document_type_idComboBox);
            this.Controls.Add(decision_type_idLabel);
            this.Controls.Add(this.decision_type_idComboBox);
            this.Controls.Add(content_file_nameLabel);
            this.Controls.Add(this.content_file_nameTextBox);
            this.Controls.Add(decision_dateLabel);
            this.Controls.Add(this.decision_dateDateTimePicker);
            this.Controls.Add(decision_numberLabel);
            this.Controls.Add(this.decision_numberTextBox);
            this.Controls.Add(this.documentBindingNavigator);
            this.Name = "NewDecisionPanel";
            this.Size = new System.Drawing.Size(571, 420);
            this.Load += new System.EventHandler(this.NewDecisionPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dB_CDRSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentBindingNavigator)).EndInit();
            this.documentBindingNavigator.ResumeLayout(false);
            this.documentBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.decisiontypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documenttypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courtBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.judgeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lawarticleBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DB_CDRSDataSet dB_CDRSDataSet;
        private System.Windows.Forms.BindingNavigator documentBindingNavigator;
        private System.Windows.Forms.ToolStripButton documentBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox decision_numberTextBox;
        private System.Windows.Forms.DateTimePicker decision_dateDateTimePicker;
        private System.Windows.Forms.TextBox content_file_nameTextBox;
        private System.Windows.Forms.ComboBox decision_type_idComboBox;
        private System.Windows.Forms.ComboBox document_type_idComboBox;
        private System.Windows.Forms.ComboBox court_idComboBox;
        private System.Windows.Forms.ComboBox judge_idComboBox;
        private System.Windows.Forms.ComboBox law_area_idComboBox;
        private System.Windows.Forms.Button btnBrowseFile;
        private DB_CDRSDataSetTableAdapters.courtTableAdapter courtTableAdapter;
        private DB_CDRSDataSetTableAdapters.decision_typeTableAdapter decision_typeTableAdapter;
        private DB_CDRSDataSetTableAdapters.document_typeTableAdapter document_typeTableAdapter;
        private System.Windows.Forms.BindingSource decisiontypeBindingSource;
        private System.Windows.Forms.BindingSource documenttypeBindingSource;
        private System.Windows.Forms.BindingSource courtBindingSource;
        private System.Windows.Forms.BindingSource judgeBindingSource;
        private DB_CDRSDataSetTableAdapters.judgeTableAdapter judgeTableAdapter;
        private System.Windows.Forms.BindingSource lawarticleBindingSource;
        private DB_CDRSDataSetTableAdapters.law_articleTableAdapter law_articleTableAdapter;
    }
}
