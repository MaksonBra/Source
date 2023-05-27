namespace CourtDecisionsDictionary.View.Subsystems
{
    partial class JudgesDictionarySubsystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JudgesDictionarySubsystem));
            this.dB_CDRSDataSet = new CourtDecisionsDictionary.DB_CDRSDataSet();
            this.judgeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.judgeTableAdapter = new CourtDecisionsDictionary.DB_CDRSDataSetTableAdapters.judgeTableAdapter();
            this.tableAdapterManager = new CourtDecisionsDictionary.DB_CDRSDataSetTableAdapters.TableAdapterManager();
            this.judgeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.judgeBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.judgeDataGridView = new System.Windows.Forms.DataGridView();
            this.postBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postTableAdapter = new CourtDecisionsDictionary.DB_CDRSDataSetTableAdapters.postTableAdapter();
            this.courtBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courtTableAdapter = new CourtDecisionsDictionary.DB_CDRSDataSetTableAdapters.courtTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tsbtnUpdate = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dB_CDRSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.judgeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.judgeBindingNavigator)).BeginInit();
            this.judgeBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.judgeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courtBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dB_CDRSDataSet
            // 
            this.dB_CDRSDataSet.DataSetName = "DB_CDRSDataSet";
            this.dB_CDRSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // judgeBindingSource
            // 
            this.judgeBindingSource.DataMember = "judge";
            this.judgeBindingSource.DataSource = this.dB_CDRSDataSet;
            // 
            // judgeTableAdapter
            // 
            this.judgeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.courtTableAdapter = this.courtTableAdapter;
            this.tableAdapterManager.decision_typeTableAdapter = null;
            this.tableAdapterManager.document_typeTableAdapter = null;
            this.tableAdapterManager.documentTableAdapter = null;
            this.tableAdapterManager.judgeTableAdapter = this.judgeTableAdapter;
            this.tableAdapterManager.law_articleTableAdapter = null;
            this.tableAdapterManager.postTableAdapter = this.postTableAdapter;
            this.tableAdapterManager.regionTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CourtDecisionsDictionary.DB_CDRSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usersTableAdapter = null;
            // 
            // judgeBindingNavigator
            // 
            this.judgeBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.judgeBindingNavigator.BindingSource = this.judgeBindingSource;
            this.judgeBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.judgeBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.judgeBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.judgeBindingNavigatorSaveItem,
            this.tsbtnUpdate});
            this.judgeBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.judgeBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.judgeBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.judgeBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.judgeBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.judgeBindingNavigator.Name = "judgeBindingNavigator";
            this.judgeBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.judgeBindingNavigator.Size = new System.Drawing.Size(541, 25);
            this.judgeBindingNavigator.TabIndex = 0;
            this.judgeBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // judgeBindingNavigatorSaveItem
            // 
            this.judgeBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("judgeBindingNavigatorSaveItem.Image")));
            this.judgeBindingNavigatorSaveItem.Name = "judgeBindingNavigatorSaveItem";
            this.judgeBindingNavigatorSaveItem.Size = new System.Drawing.Size(129, 22);
            this.judgeBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.judgeBindingNavigatorSaveItem.Click += new System.EventHandler(this.judgeBindingNavigatorSaveItem_Click);
            // 
            // judgeDataGridView
            // 
            this.judgeDataGridView.AutoGenerateColumns = false;
            this.judgeDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.judgeDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.judgeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.judgeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.judgeDataGridView.DataSource = this.judgeBindingSource;
            this.judgeDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.judgeDataGridView.Location = new System.Drawing.Point(0, 25);
            this.judgeDataGridView.Name = "judgeDataGridView";
            this.judgeDataGridView.Size = new System.Drawing.Size(541, 383);
            this.judgeDataGridView.TabIndex = 1;
            // 
            // postBindingSource
            // 
            this.postBindingSource.DataMember = "post";
            this.postBindingSource.DataSource = this.dB_CDRSDataSet;
            // 
            // postTableAdapter
            // 
            this.postTableAdapter.ClearBeforeFill = true;
            // 
            // courtBindingSource
            // 
            this.courtBindingSource.DataMember = "court";
            this.courtBindingSource.DataSource = this.dB_CDRSDataSet;
            // 
            // courtTableAdapter
            // 
            this.courtTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "second_name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Фамилия";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "first_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Имя";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "fur_name";
            this.dataGridViewTextBoxColumn4.HeaderText = "Отчество";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "post_id";
            this.dataGridViewTextBoxColumn5.DataSource = this.postBindingSource;
            this.dataGridViewTextBoxColumn5.DisplayMember = "name";
            this.dataGridViewTextBoxColumn5.HeaderText = "Должность";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn5.ValueMember = "id";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "court_id";
            this.dataGridViewTextBoxColumn6.DataSource = this.courtBindingSource;
            this.dataGridViewTextBoxColumn6.DisplayMember = "name";
            this.dataGridViewTextBoxColumn6.HeaderText = "Судебный участок";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn6.ValueMember = "id";
            // 
            // tsbtnUpdate
            // 
            this.tsbtnUpdate.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbtnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnUpdate.Image")));
            this.tsbtnUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnUpdate.Name = "tsbtnUpdate";
            this.tsbtnUpdate.Size = new System.Drawing.Size(125, 22);
            this.tsbtnUpdate.Text = "Обновить данные";
            this.tsbtnUpdate.Click += new System.EventHandler(this.tsbtnUpdate_Click);
            // 
            // JudgesDictionarySubsystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.judgeDataGridView);
            this.Controls.Add(this.judgeBindingNavigator);
            this.Name = "JudgesDictionarySubsystem";
            this.Size = new System.Drawing.Size(541, 408);
            ((System.ComponentModel.ISupportInitialize)(this.dB_CDRSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.judgeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.judgeBindingNavigator)).EndInit();
            this.judgeBindingNavigator.ResumeLayout(false);
            this.judgeBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.judgeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courtBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DB_CDRSDataSet dB_CDRSDataSet;
        private System.Windows.Forms.BindingSource judgeBindingSource;
        private DB_CDRSDataSetTableAdapters.judgeTableAdapter judgeTableAdapter;
        private DB_CDRSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator judgeBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton judgeBindingNavigatorSaveItem;
        private DB_CDRSDataSetTableAdapters.courtTableAdapter courtTableAdapter;
        private DB_CDRSDataSetTableAdapters.postTableAdapter postTableAdapter;
        private System.Windows.Forms.DataGridView judgeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.BindingSource postBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.BindingSource courtBindingSource;
        private System.Windows.Forms.ToolStripButton tsbtnUpdate;
    }
}
