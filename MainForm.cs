using System;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using Barangay_Clearance_System.User_Controls;
using System.IO;

namespace Barangay_Clearance_System
{
    public partial class MainForm : KryptonForm
    {
        public static ClearanceTab clearanceTab;
        public static GoogleFormsTab googleFormsTab;
        public static HistoryTab historyTab;
        public static AboutTab aboutTab;
        public static SettingsTab settingsTab;

        public MainForm()
        {
            InitializeComponent();
            SettingsTab.GenerateRecoveryCode();
            
            FormClosed += (s, args) => Application.Exit(); // Para magclose lahat ng forms pag clinose to
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Google Forms Tab
            googleFormsTab = new GoogleFormsTab()
            {
                Location = new Point(221, 79),
                Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right,
            };
            Controls.Add(googleFormsTab);

            // Index Tab
            clearanceTab = new ClearanceTab()
            {
                Location = new Point(221, 79),
                Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right,
            };
            clearanceTab.Hide();
            Controls.Add(clearanceTab);

            // History Tab
            historyTab = new HistoryTab()
            {
                Location = new Point(221, 79),
                Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right,
            };
            historyTab.Hide();
            Controls.Add(historyTab);

            aboutTab = new AboutTab()
            {
                Location = new Point(221, 79),
                Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right,
            };
            aboutTab.Hide();
            Controls.Add(aboutTab);

            settingsTab = new SettingsTab()
            {
                Location = new Point(221, 79),
                Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right,
            };
            settingsTab.Hide();
            Controls.Add(settingsTab);
        }

        private void RecordsButton_CheckedChanged(object sender, EventArgs e)
        {
            if (FormResponsesButton.Checked)
            {
                googleFormsTab.Show();
                return;
            }
            googleFormsTab.Hide();
        }

        private void BarangayClearanceButton_CheckedChanged(object sender, EventArgs e)
        {
            if (BarangayClearanceButton.Checked)
            {
                clearanceTab.Show();
                return;
            }
            clearanceTab.Hide();
        }

        private void HistoryButton_CheckedChanged(object sender, EventArgs e)
        {
            if (RecordsButton.Checked)
            {
                historyTab.Show();
                return;
            }
            historyTab.Hide();
        }

        private void AboutButton_CheckedChanged(object sender, EventArgs e)
        {
            if (AboutButton.Checked)
            {
                aboutTab.Show();
                return;
            }
            aboutTab.Hide();
        }

        private void SettingsButton_CheckedChanged(object sender, EventArgs e)
        {
            if (SettingsButton.Checked) 
            {
                settingsTab.Show();
                return;
            }
            settingsTab.Hide();
        }
    }
}
