namespace CourtDecisionsDictionary.View.Subsystems
{
    partial class DeisionsCatalogueSubsystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeisionsCatalogueSubsystem));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dB_CDRSDataSet = new CourtDecisionsDictionary.DB_CDRSDataSet();
            this.documentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.documentTableAdapter = new CourtDecisionsDictionary.DB_CDRSDataSetTableAdapters.documentTableAdapter();
            this.tableAdapterManager = new CourtDecisionsDictionary.DB_CDRSDataSetTableAdapters.TableAdapterManager();
            this.documentBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorEditItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorViewContentItem = new System.Windows.Forms.ToolStripButton();
            this.documentDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.lawarticleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.decisiontypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.documenttypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewCourtColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.courtBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewJudgeColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.judgeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.law_articleTableAdapter = new CourtDecisionsDictionary.DB_CDRSDataSetTableAdapters.law_articleTableAdapter();
            this.decision_typeTableAdapter = new CourtDecisionsDictionary.DB_CDRSDataSetTableAdapters.decision_typeTableAdapter();
            this.document_typeTableAdapter = new CourtDecisionsDictionary.DB_CDRSDataSetTableAdapters.document_typeTableAdapter();
            this.courtTableAdapter = new CourtDecisionsDictionary.DB_CDRSDataSetTableAdapters.courtTableAdapter();
            this.judgeTableAdapter = new CourtDecisionsDictionary.DB_CDRSDataSetTableAdapters.judgeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dB_CDRSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentBindingNavigator)).BeginInit();
            this.documentBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documentDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lawarticleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.decisiontypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documenttypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courtBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.judgeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dB_CDRSDataSet
            // 
            this.dB_CDRSDataSet.DataSetName = "DB_CDRSDataSet";
            this.dB_CDRSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // documentBindingSource
            // 
            this.documentBindingSource.DataMember = "document";
            this.documentBindingSource.DataSource = this.dB_CDRSDataSet;
            // 
            // documentTableAdapter
            // 
            this.documentTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.courtTableAdapter = null;
            this.tableAdapterManager.decision_typeTableAdapter = null;
            this.tableAdapterManager.document_typeTableAdapter = null;
            this.tableAdapterManager.documentTableAdapter = this.documentTableAdapter;
            this.tableAdapterManager.judgeTableAdapter = null;
            this.tableAdapterManager.law_articleTableAdapter = null;
            this.tableAdapterManager.postTableAdapter = null;
            this.tableAdapterManager.regionTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CourtDecisionsDictionary.DB_CDRSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usersTableAdapter = null;
            // 
            // documentBindingNavigator
            // 
            this.documentBindingNavigator.AddNewItem = null;
            this.documentBindingNavigator.BindingSource = this.documentBindingSource;
            this.documentBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.documentBindingNavigator.DeleteItem = null;
            this.documentBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorEditItem,
            this.bindingNavigatorDeleteItem,
            this.bindingNavigatorSeparator3,
            this.bindingNavigatorViewContentItem});
            this.documentBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.documentBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.documentBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.documentBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.documentBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.documentBindingNavigator.Name = "documentBindingNavigator";
            this.documentBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.documentBindingNavigator.Size = new System.Drawing.Size(543, 25);
            this.documentBindingNavigator.TabIndex = 0;
            this.documentBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorEditItem
            // 
            this.bindingNavigatorEditItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorEditItem.Image")));
            this.bindingNavigatorEditItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorEditItem.Name = "bindingNavigatorEditItem";
            this.bindingNavigatorEditItem.Size = new System.Drawing.Size(107, 22);
            this.bindingNavigatorEditItem.Text = "Редактировать";
            this.bindingNavigatorEditItem.Click += new System.EventHandler(this.bindingNavigatorEditItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(71, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorSeparator3
            // 
            this.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator3";
            this.bindingNavigatorSeparator3.Size = new System.Drawing.Size(6, 25);
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
            this.documentDataGridView.AutoGenerateColumns = false;
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
            this.documentDataGridView.DataSource = this.documentBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.documentDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.documentDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.documentDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.documentDataGridView.Location = new System.Drawing.Point(0, 25);
            this.documentDataGridView.MultiSelect = false;
            this.documentDataGridView.Name = "documentDataGridView";
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.documentDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.documentDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.documentDataGridView.Size = new System.Drawing.Size(543, 395);
            this.documentDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "decision_number";
            this.dataGridViewTextBoxColumn2.HeaderText = "Дело №";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 70;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "decision_date";
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
            this.dataGridViewTextBoxColumn9.DataPropertyName = "law_area_id";
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
            // lawarticleBindingSource
            // 
            this.lawarticleBindingSource.DataMember = "law_article";
            this.lawarticleBindingSource.DataSource = this.dB_CDRSDataSet;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "content_file_name";
            this.dataGridViewTextBoxColumn4.HeaderText = "content_file_name";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "decision_type_id";
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
            // decisiontypeBindingSource
            // 
            this.decisiontypeBindingSource.DataMember = "decision_type";
            this.decisiontypeBindingSource.DataSource = this.dB_CDRSDataSet;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "document_type_id";
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
            // documenttypeBindingSource
            // 
            this.documenttypeBindingSource.DataMember = "document_type";
            this.documenttypeBindingSource.DataSource = this.dB_CDRSDataSet;
            // 
            // dataGridViewCourtColumn
            // 
            this.dataGridViewCourtColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewCourtColumn.DataPropertyName = "court_id";
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
            // courtBindingSource
            // 
            this.courtBindingSource.DataMember = "court";
            this.courtBindingSource.DataSource = this.dB_CDRSDataSet;
            // 
            // dataGridViewJudgeColumn
            // 
            this.dataGridViewJudgeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewJudgeColumn.DataPropertyName = "judge_id";
            this.dataGridViewJudgeColumn.DataSource = this.judgeBindingSource;
            this.dataGridViewJudgeColumn.DisplayMember = "first_name";
            this.dataGridViewJudgeColumn.FillWeight = 25F;
            this.dataGridViewJudgeColumn.HeaderText = "Судья";
            this.dataGridViewJudgeColumn.Name = "dataGridViewJudgeColumn";
            this.dataGridViewJudgeColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewJudgeColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewJudgeColumn.ValueMember = "id";
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
            // DeisionsCatalogueSubsystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.documentDataGridView);
            this.Controls.Add(this.documentBindingNavigator);
            this.Name = "DeisionsCatalogueSubsystem";
            this.Size = new System.Drawing.Size(543, 420);
            ((System.ComponentModel.ISupportInitialize)(this.dB_CDRSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentBindingNavigator)).EndInit();
            this.documentBindingNavigator.ResumeLayout(false);
            this.documentBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documentDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lawarticleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.decisiontypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documenttypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courtBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.judgeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DB_CDRSDataSet dB_CDRSDataSet;
        private System.Windows.Forms.BindingSource documentBindingSource;
        private DB_CDRSDataSetTableAdapters.documentTableAdapter documentTableAdapter;
        private DB_CDRSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator documentBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorEditItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
        private System.Windows.Forms.ToolStripButton bindingNavigatorViewContentItem;
        private System.Windows.Forms.DataGridView documentDataGridView;
        private System.Windows.Forms.BindingSource lawarticleBindingSource;
        private System.Windows.Forms.BindingSource decisiontypeBindingSource;
        private System.Windows.Forms.BindingSource documenttypeBindingSource;
        private System.Windows.Forms.BindingSource courtBindingSource;
        private System.Windows.Forms.BindingSource judgeBindingSource;
        private DB_CDRSDataSetTableAdapters.law_articleTableAdapter law_articleTableAdapter;
        private DB_CDRSDataSetTableAdapters.decision_typeTableAdapter decision_typeTableAdapter;
        private DB_CDRSDataSetTableAdapters.document_typeTableAdapter document_typeTableAdapter;
        private DB_CDRSDataSetTableAdapters.courtTableAdapter courtTableAdapter;
        private DB_CDRSDataSetTableAdapters.judgeTableAdapter judgeTableAdapter;
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
