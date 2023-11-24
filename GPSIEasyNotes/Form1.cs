using MaterialSkin;
using MaterialSkin.Controls;


namespace GPSIEasyNotes

{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            tabControl1.DrawItem += tabControl1_DrawItem;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabControl tabControl = (TabControl)sender;
            foreach (TabPage tabPage in tabControl.TabPages)
            {
                tabPage.BackColor = SystemColors.Control;
                tabPage.ForeColor = SystemColors.ControlText;
            }
            TabPage selectedTabPage = tabControl.SelectedTab;
            selectedTabPage.BackColor = Color.White;
        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            TabControl tabControl = (TabControl)sender;
            Graphics g = e.Graphics;

            // Get the tab header's bounds
            Rectangle tabBounds = tabControl.GetTabRect(e.Index);

            // Clear the tab header area with the system's default color
            g.FillRectangle(SystemBrushes.Control, tabBounds);

            // Check if the tab is selected
            bool isSelected = (e.State & DrawItemState.Selected) == DrawItemState.Selected;

            // Highlight the selected tab header with a different color
            if (isSelected)
            {
                using (SolidBrush highlightBrush = new SolidBrush(Color.White)) // Change the color as needed
                {
                    g.FillRectangle(highlightBrush, tabBounds);
                }
            }

            // Draw the tab text
            string tabText = tabControl.TabPages[e.Index].Text;
            Font tabFont = tabControl.Font;

            using (StringFormat sf = new StringFormat())
            {
                sf.Alignment = StringAlignment.Center;
                sf.LineAlignment = StringAlignment.Center;

                g.DrawString(tabText, tabFont, Brushes.Black, tabBounds, sf);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Font labelFont = new Font("Microsoft Sans Serif", 12);
            callerLabel.Font = labelFont;
            companyLabel.Font = labelFont;
            snLabel.Font = labelFont;
            issueLabel.Font = labelFont;
            resolutionLabel.Font = labelFont;
        }
    }
}