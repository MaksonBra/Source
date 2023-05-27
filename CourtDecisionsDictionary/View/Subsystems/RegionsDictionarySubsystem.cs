using System;
using System.Windows.Forms;

namespace CourtDecisionsDictionary.View.Subsystems
{
    public partial class RegionsDictionarySubsystem : UserControl
    {
        public RegionsDictionarySubsystem()
        {
            InitializeComponent();
            UpdateData();
        }

        private void regionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                Validate();
                regionBindingSource.EndEdit();
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}