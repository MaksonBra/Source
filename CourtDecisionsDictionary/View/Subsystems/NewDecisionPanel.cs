using System;
using System.Windows.Forms;

namespace CourtDecisionsDictionary.View.Subsystems
{
    public partial class NewDecisionPanel : UserControl
    {
        string DecisionsPath = "";

        public NewDecisionPanel()
        {
            InitializeComponent();

            FillLists();
        }

        private void documentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (decision_numberTextBox.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Укажите номер дела!", "Error!",
                       MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (content_file_nameTextBox.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Укажите файл решения по делу!", "Error!",
                       MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (decision_type_idComboBox.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Укажите вид дела!", "Error!",
                       MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (document_type_idComboBox.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Укажите вид решения!", "Error!",
                       MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (court_idComboBox.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Укажите судебный участок!", "Error!",
                       MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (judge_idComboBox.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Укажите данные судьи!", "Error!",
                       MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (law_area_idComboBox.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Укажите предмет спора!", "Error!",
                       MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                bool create_new = false;

                if (Model.Document.CurrentDocument == null)
                {
                    create_new = true;
                    Model.Document.CurrentDocument = new Model.Document();
                }

                var c_doc = Model.Document.CurrentDocument;

                c_doc.DecisionNumber = decision_numberTextBox.Text.Trim();
                c_doc.Date = decision_dateDateTimePicker.Value;
                c_doc.ContentFileName = content_file_nameTextBox.Text.Trim();
                c_doc.DecisionTypeID = Convert.ToInt32(decision_type_idComboBox.SelectedValue);
                c_doc.DocumentTypeID = Convert.ToInt32(document_type_idComboBox.SelectedValue);
                c_doc.CourtID = Convert.ToInt32(court_idComboBox.SelectedValue);
                c_doc.JudgeID = Convert.ToInt32(judge_idComboBox.SelectedValue);
                c_doc.LawArticleID = Convert.ToInt32(law_area_idComboBox.SelectedValue);

                bool result_ok = create_new
                    ? Controller.DB.AccessDB.SaveNewDocument(c_doc)
                    : Controller.DB.AccessDB.SaveEditedDocument(c_doc);

                if (result_ok)
                {
                    MessageBox.Show($"Дело № {c_doc.DecisionNumber} от " +
                        $"{c_doc.Date.ToLongDateString()} зарегистрировано / изменено!",
                        "Данные добавлены",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Model.Document.CurrentDocument = null;

                    Parent.Controls.Clear();
                }
                else
                {
                    MessageBox.Show($"Дело № {c_doc.DecisionNumber} от " +
                        $"{c_doc.Date.ToLongDateString()} не зарегистрировано / изменено\n\n" +
                        $"Причина:\n\n{Controller.DB.AccessDB.LastErrorText}",
                        "Данные добавлены",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

                judge_idComboBox.DisplayMember = "FIO";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBrowseFile_Click(object sender, EventArgs e)
        {
            DecisionsPath = $"{Application.StartupPath}\\Decisions";

            if (!System.IO.Directory.Exists(DecisionsPath))
                System.IO.Directory.CreateDirectory(Application.StartupPath);

            OpenFileDialog ofd = new OpenFileDialog()
            {
                Filter = "Single-file web page (*.mht; *.mhtml)|*.mht; *.mhtml" +
                         "|Web-page (*.htm; *.html)|*.htm; *.html",
                InitialDirectory = Application.StartupPath + "\\Decisions"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
                content_file_nameTextBox.Text = ofd.SafeFileName;
        }

        private void NewDecisionPanel_Load(object sender, EventArgs e)
        {
            if (Model.Document.CurrentDocument != null)
            {
                var c_doc = Model.Document.CurrentDocument;

                decision_numberTextBox.Text = c_doc.DecisionNumber;
                decision_dateDateTimePicker.Value = c_doc.Date;
                content_file_nameTextBox.Text = c_doc.ContentFileName;
                decision_type_idComboBox.SelectedValue = c_doc.DecisionTypeID;
                document_type_idComboBox.SelectedValue = c_doc.DocumentTypeID;
                court_idComboBox.SelectedValue = c_doc.CourtID;
                judge_idComboBox.SelectedValue = c_doc.JudgeID;
                law_area_idComboBox.SelectedValue = c_doc.LawArticleID;
            }
        }
    }
}