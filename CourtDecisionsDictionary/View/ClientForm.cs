using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace CourtDecisionsDictionary.View
{
    public partial class ClientForm : UserControl
    {
        private List<Model.Document> docs;

        public ClientForm()
        {
            InitializeComponent();

            docs = Controller.DB.AccessDB.GetAllDocuments();

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
            // Filters
            string d_f_number = txtFilterDecisionNumber.Text.Trim().ToLower();
            string d_f_court = txtFilterCourt.Text.Trim().ToLower();
            string d_f_judge = txtFilterJudge.Text.Trim().ToLower();
            string d_f_region = txtFilterRegion.Text.Trim().ToLower();
            string d_f_law_article = txtFilterLawArticle.Text.Trim().ToLower();

            documentDataGridView.Rows.Clear();
            foreach (var doc in GetDocumentsByUserQuery(
                chkFilterDecisionNumberOn.Checked ? d_f_number : "",
                chkFilterCourtOn.Checked ? d_f_court : "",
                chkFilterJudgeOn.Checked ? d_f_judge : "",
                chkFilterRegionOn.Checked ? d_f_region : "",
                chkFilterLawArticleOn.Checked ? d_f_law_article : ""))
            {
                documentDataGridView.Rows.Add(new object[] {
                    doc.ID,
                    doc.DecisionNumber,
                    doc.Date,
                    doc.LawArticleID,
                    doc.ContentFileName,
                    doc.DecisionTypeID,
                    doc.DocumentTypeID,
                    doc.CourtID,
                    doc.JudgeID
                });
            }

            documentDataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            documentDataGridView.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            documentDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            documentDataGridView.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
        }

        public List<Model.Document> GetDocumentsByUserQuery(
            string FilterDocNumber = "", string FilterCourtName = "",
            string FilterJudgeSecondName = "", string FilterRegionName = "",
            string FilterLawArticleName = "")
        {
            List<Model.Document> result = new List<Model.Document>();

            foreach (var doc in docs)
            {
                if (!string.IsNullOrEmpty(FilterCourtName))
                    if (doc.ItsCourt.Name.ToLower().IndexOf(FilterCourtName.ToLower()) < 0)
                        continue;

                if (!string.IsNullOrEmpty(FilterDocNumber))
                    if (doc.DecisionNumber.ToLower().IndexOf(FilterDocNumber.ToLower()) < 0)
                        continue;

                if (!string.IsNullOrEmpty(FilterJudgeSecondName))
                    if (doc.ItsJudge.SecondName.ToLower().IndexOf(FilterJudgeSecondName.ToLower()) < 0)
                        continue;

                if (!string.IsNullOrEmpty(FilterLawArticleName))
                    if (doc.ItsLawArticle.Name.ToLower().IndexOf(FilterLawArticleName.ToLower()) < 0)
                        continue;

                if (!string.IsNullOrEmpty(FilterRegionName))
                    if (doc.ItsCourt.ItsRegion.Name.ToLower().IndexOf(FilterRegionName.ToLower()) < 0)
                        continue;

                result.Add(doc);
            }

            return result;
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

        protected int GetSelectedDocumentID(bool showMessage = true)
        {
            if (documentDataGridView.SelectedRows.Count == 0)
            {
                if (showMessage)
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


        private void btnApplyFilter_Click(object sender, EventArgs e)
        {
            FillTable();
        }

        private void btnResetFilter_Click(object sender, EventArgs e)
        {
            txtFilterCourt.Text = txtFilterDecisionNumber.Text =
                txtFilterJudge.Text = txtFilterLawArticle.Text =
                txtFilterRegion.Text = string.Empty;
            chkFilterCourtOn.Checked = chkFilterDecisionNumberOn.Checked =
                chkFilterJudgeOn.Checked = chkFilterLawArticleOn.Checked =
                chkFilterRegionOn.Checked = false;

            FillTable();
        }
    }
}