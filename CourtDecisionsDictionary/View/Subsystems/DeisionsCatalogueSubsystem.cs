using System;
using System.Windows.Forms;

namespace CourtDecisionsDictionary.View.Subsystems
{
    public partial class DeisionsCatalogueSubsystem : UserControl
    {
        public DeisionsCatalogueSubsystem()
        {
            InitializeComponent();

            FillLists();
            FillTable();
        }

        private void FillLists()
        {
            try
            {
                courtTableAdapter.Fill(dB_CDRSDataSet.court);
                judgeTableAdapter.FillQData(dB_CDRSDataSet.judge);
                law_articleTableAdapter.Fill(dB_CDRSDataSet.law_article);
                document_typeTableAdapter.Fill(dB_CDRSDataSet.document_type);
                decision_typeTableAdapter.Fill(dB_CDRSDataSet.decision_type);

                dataGridViewJudgeColumn.DisplayMember = "FIO";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected void FillTable()
        {
            documentTableAdapter.Fill(dB_CDRSDataSet.document);

            documentDataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            documentDataGridView.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            documentDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            documentDataGridView.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            int doc_id = GetSelectedDocumentID();

            if (doc_id == 0) return;

            Model.Document doc = Controller.DB.AccessDB.GetDocumentData(doc_id);

            if (MessageBox.Show($"Удалить дело № {doc.DecisionNumber}?", 
                Application.ProductName,
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (Controller.DB.AccessDB.DeleteDocument(doc_id))
                {
                    FillTable();
                }
                else
                    MessageBox.Show($"Дело не было удалено:\n\n{Controller.DB.AccessDB.LastErrorText}",
                        Application.ProductName,
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void bindingNavigatorViewContentItem_Click(object sender, EventArgs e)
        {
            int doc_id = GetSelectedDocumentID();

            if (doc_id > 0)
            {
                Model.Document doc = Controller.DB.AccessDB.GetDocumentData(doc_id);

                string content_file = $"{Application.StartupPath}\\Decisions\\{doc.ContentFileName}";

                try
                {
                    Form content_form = new Form()
                    {
                        Text = $"Дело №{doc.DecisionNumber} от {doc.Date.ToLongDateString()}",
                        Size = new System.Drawing.Size(800, 800),
                        ShowIcon = false,
                        ShowInTaskbar = true,
                        MaximizeBox = false,
                        MinimizeBox = false,
                        StartPosition = FormStartPosition.CenterParent
                    };

                    WebBrowser wbb = new WebBrowser();

                    content_form.Controls.Add(wbb);
                    wbb.Dock = DockStyle.Fill;
                    wbb.Navigate(content_file);

                    content_form.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка отображения содержания дела!\n" +
                        $"Возможно, не найден файл: '{content_file}'\\n\nПодробности:\n\n{ex.Message}",
                        Application.ProductName,
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void bindingNavigatorEditItem_Click(object sender, EventArgs e)
        {
            int doc_id = GetSelectedDocumentID();

            if (doc_id > 0)
            {
                Model.Document.CurrentDocument = Controller.DB.AccessDB.GetDocumentData(doc_id);

                Control container = Parent;

                container.Controls.Clear();
                container.Controls.Add(new NewDecisionPanel() { Dock = DockStyle.Fill });
            }
        }

        
        protected int GetSelectedDocumentID(bool showMessage = true)
        {
            if (documentDataGridView.SelectedRows.Count == 0)
            {
                if(showMessage)
                    MessageBox.Show("Не выбрано дело для совершения операции!", 
                        Application.ProductName,
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Exclamation);

                return 0;
            }
            else
            {
                int doc_id = Convert.ToInt32(documentDataGridView
                    [0, documentDataGridView.SelectedRows[0].Index].Value);

                return doc_id;
            }
        }
    }
}