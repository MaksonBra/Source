using System;
using System.Windows.Forms;

namespace CourtDecisionsDictionary.View.Subsystems
{
    public partial class DecisionTypesDictionarySubsystem : UserControl
    {
        public DecisionTypesDictionarySubsystem()
        {
            InitializeComponent();
            UpdateData();
        }

        private void decision_typeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                Validate();
                decision_typeBindingSource.EndEdit();
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
                decision_typeTableAdapter.Fill(dB_CDRSDataSet.decision_type);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}