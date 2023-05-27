using System;
using System.Windows.Forms;

namespace CourtDecisionsDictionary.View
{
    public partial class ContentManagerForm : UserControl
    {
        public ContentManagerForm()
        {
            InitializeComponent();
        }

        private void btnNewDecision_Click(object sender, EventArgs e)
        {
            Model.Document.CurrentDocument = null;

            pnlSubsystemContainer.Controls.Clear();
            pnlSubsystemContainer.Controls.Add(new Subsystems.NewDecisionPanel()
            { Dock = DockStyle.Fill });
        }
        private void btnDecisionsCatalogue_Click(object sender, EventArgs e)
        {
            pnlSubsystemContainer.Controls.Clear();
            pnlSubsystemContainer.Controls.Add(new Subsystems.DeisionsCatalogueSubsystem()
            { Dock = DockStyle.Fill });
        }
        private void btnLawArticlesDictionary_Click(object sender, EventArgs e)
        {
            pnlSubsystemContainer.Controls.Clear();
            pnlSubsystemContainer.Controls.Add(new Subsystems.LawArticlesDictionarySubsystem()
            { Dock = DockStyle.Fill });
        }
    }
}