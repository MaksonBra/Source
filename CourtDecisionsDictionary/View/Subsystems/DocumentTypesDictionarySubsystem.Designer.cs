namespace CourtDecisionsDictionary.View.Subsystems
{
    partial class DocumentTypesDictionarySubsystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocumentTypesDictionarySubsystem));
            this.dB_CDRSDataSet = new CourtDecisionsDictionary.DB_CDRSDataSet();
            this.document_typeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.document_typeTableAdapter = new CourtDecisionsDictionary.DB_CDRSDataSetTableAdapters.document_typeTableAdapter();
            this.tableAdapterManager = new CourtDecisionsDictionary.DB_CDRSDataSetTableAdapters.TableAdapterManager();
            this.document_typeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.document_typeBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.document_typeDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsbtnUpdate = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dB_CDRSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.document_typeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.document_typeBindingNavigator)).BeginInit();
            this.document_typeBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.document_typeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dB_CDRSDataSet
            // 
            this.dB_CDRSDataSet.DataSetName = "DB_CDRSDataSet";
            this.dB_CDRSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // document_typeBindingSource
            // 
            this.document_typeBindingSource.DataMember = "document_type";
            this.document_typeBindingSource.DataSource = this.dB_CDRSDataSet;
            // 
            // document_typeTableAdapter
            // 
            this.document_typeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.courtTableAdapter = null;
            this.tableAdapterManager.decision_typeTableAdapter = null;
            this.tableAdapterManager.document_typeTableAdapter = this.document_typeTableAdapter;
            this.tableAdapterManager.documentTableAdapter = null;
            this.tableAdapterManager.judgeTableAdapter = null;
            this.tableAdapterManager.law_articleTableAdapter = null;
            this.tableAdapterManager.postTableAdapter = null;
            this.tableAdapterManager.regionTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CourtDecisionsDictionary.DB_CDRSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usersTableAdapter = null;
            // 
            // document_typeBindingNavigator
            // 
            this.document_typeBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.document_typeBindingNavigator.BindingSource = this.document_typeBindingSource;
            this.document_typeBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.document_typeBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.document_typeBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.document_typeBindingNavigatorSaveItem,
            this.tsbtnUpdate});
            this.document_typeBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.document_typeBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.document_typeBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.document_typeBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.document_typeBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.document_typeBindingNavigator.Name = "document_typeBindingNavigator";
            this.document_typeBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.document_typeBindingNavigator.Size = new System.Drawing.Size(541, 25);
            this.document_typeBindingNavigator.TabIndex = 0;
            this.document_typeBindingNavigator.Text = "bindingNavigator1";
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
            // document_typeBindingNavigatorSaveItem
            // 
            this.document_typeBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("document_typeBindingNavigatorSaveItem.Image")));
            this.document_typeBindingNavigatorSaveItem.Name = "document_typeBindingNavigatorSaveItem";
            this.document_typeBindingNavigatorSaveItem.Size = new System.Drawing.Size(129, 22);
            this.document_typeBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.document_typeBindingNavigatorSaveItem.Click += new System.EventHandler(this.document_typeBindingNavigatorSaveItem_Click);
            // 
            // document_typeDataGridView
            // 
            this.document_typeDataGridView.AutoGenerateColumns = false;
            this.document_typeDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.document_typeDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.document_typeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.document_typeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.document_typeDataGridView.DataSource = this.document_typeBindingSource;
            this.document_typeDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.document_typeDataGridView.Location = new System.Drawing.Point(0, 25);
            this.document_typeDataGridView.Name = "document_typeDataGridView";
            this.document_typeDataGridView.Size = new System.Drawing.Size(541, 383);
            this.document_typeDataGridView.TabIndex = 1;
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Наименование";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
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
            // DocumentTypesDictionarySubsystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.document_typeDataGridView);
            this.Controls.Add(this.document_typeBindingNavigator);
            this.Name = "DocumentTypesDictionarySubsystem";
            this.Size = new System.Drawing.Size(541, 408);
            ((System.ComponentModel.ISupportInitialize)(this.dB_CDRSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.document_typeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.document_typeBindingNavigator)).EndInit();
            this.document_typeBindingNavigator.ResumeLayout(false);
            this.document_typeBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.document_typeDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DB_CDRSDataSet dB_CDRSDataSet;
        private System.Windows.Forms.BindingSource document_typeBindingSource;
        private DB_CDRSDataSetTableAdapters.document_typeTableAdapter document_typeTableAdapter;
        private DB_CDRSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator document_typeBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton document_typeBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView document_typeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.ToolStripButton tsbtnUpdate;
    }
}
