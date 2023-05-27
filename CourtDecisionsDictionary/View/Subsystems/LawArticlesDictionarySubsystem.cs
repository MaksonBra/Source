using System;
using System.Windows.Forms;

namespace CourtDecisionsDictionary.View.Subsystems
{
    public partial class LawArticlesDictionarySubsystem : UserControl
    {
        public LawArticlesDictionarySubsystem()
        {
            InitializeComponent();
            UpdateData();
        }

        private void law_articleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                Validate();
                law_articleBindingSource.EndEdit();
                tableAdapterManager.UpdateAll(dB_CDRSDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsbtnUpdate_Click(object sender, EventArgs e)
        {
            UpdateData();
        }
        public void UpdateData()
        {
            try
            {
                law_articleTableAdapter.Fill(dB_CDRSDataSet.law_article);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}