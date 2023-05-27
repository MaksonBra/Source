using System;
using System.Windows.Forms;

namespace CourtDecisionsDictionary.View.Subsystems
{
    public partial class JudgesDictionarySubsystem : UserControl
    {
        public JudgesDictionarySubsystem()
        {
            InitializeComponent();
            UpdateData();
        }

        private void judgeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                Validate();
                judgeBindingSource.EndEdit();
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
                postTableAdapter.Fill(dB_CDRSDataSet.post);
                courtTableAdapter.Fill(dB_CDRSDataSet.court);
                judgeTableAdapter.Fill(dB_CDRSDataSet.judge);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}