using System;
using System.Windows.Forms;

namespace CourtDecisionsDictionary.View
{
    public partial class AdministratorForm : UserControl
    {
        public AdministratorForm()
        {
            InitializeComponent();
        }

        private void btnRegionsDictionary_Click(object sender, EventArgs e)
        {
            pnlSubsystemContainer.Controls.Clear();
            pnlSubsystemContainer.Controls.Add(new Subsystems.RegionsDictionarySubsystem()
            { Dock = DockStyle.Fill });
        }
        private void btnCourtsDictionary_Click(object sender, EventArgs e)
        {
            pnlSubsystemContainer.Controls.Clear();
            pnlSubsystemContainer.Controls.Add(new Subsystems.CourtsDictionarySubsystem()
            { Dock = DockStyle.Fill });
        }
        private void btnDocumentTypesDictionary_Click(object sender, EventArgs e)
        {
            pnlSubsystemContainer.Controls.Clear();
            pnlSubsystemContainer.Controls.Add(new Subsystems.DocumentTypesDictionarySubsystem()
            { Dock = DockStyle.Fill });
        }
        private void btnDecisionTypesDictionary_Click(object sender, EventArgs e)
        {
            pnlSubsystemContainer.Controls.Clear();
            pnlSubsystemContainer.Controls.Add(new Subsystems.DecisionTypesDictionarySubsystem()
            { Dock = DockStyle.Fill });
        }
        private void btnJudgesDictionary_Click(object sender, EventArgs e)
        {
            pnlSubsystemContainer.Controls.Clear();
            pnlSubsystemContainer.Controls.Add(new Subsystems.JudgesDictionarySubsystem()
            { Dock = DockStyle.Fill });
        }
    }
}