using System;
using System.Windows.Forms;

namespace CourtDecisionsDictionary.View.Subsystems
{
    public partial class CourtsDictionarySubsystem : UserControl
    {
        public CourtsDictionarySubsystem()
        {
            InitializeComponent();
            UpdateData();
        }

        private void courtBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                Validate();
                courtBindingSource.EndEdit();
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
                regionTableAdapter.Fill(dB_CDRSDataSet.region);
                courtTableAdapter.Fill(dB_CDRSDataSet.court);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}