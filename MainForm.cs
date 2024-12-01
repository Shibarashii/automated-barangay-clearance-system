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

        public MainForm()
        {
            InitializeComponent();

            if (!File.Exists(Main.databasePath))
            {
                GoogleSheets.FetchDataAndInsert();
            }
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
        }

        private void GoogleFormsButton_CheckedChanged(object sender, EventArgs e)
        {
            if (GoogleFormsButton.Checked)
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
            if (HistoryButton.Checked)
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
    }
}
