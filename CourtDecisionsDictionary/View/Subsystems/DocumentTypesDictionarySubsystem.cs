using System;
using System.Windows.Forms;

namespace CourtDecisionsDictionary.View.Subsystems
{
    public partial class DocumentTypesDictionarySubsystem : UserControl
    {
        public DocumentTypesDictionarySubsystem()
        {
            InitializeComponent();
            UpdateData();
        }

        private void document_typeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            document_typeBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(dB_CDRSDataSet);

        }

        private void tsbtnUpdate_Click(object sender, EventArgs e)
        {
            UpdateData();
        }
        public void UpdateData()
        {
            try
            {
                document_typeTableAdapter.Fill(dB_CDRSDataSet.document_type);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}