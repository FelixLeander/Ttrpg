using DnD.Data;
using System.Security.Cryptography;

namespace MonsterTracker;

public partial class MainWindow : Form
{
    public MainWindow() => InitializeComponent();

    private void MainWindow_Load(object sender, EventArgs e)
    {
        var data = new List<string>()
        {
             "aaaaaaaaaaaaa",
             "bbb",
             "ccc",
             "ddd",
             "eee"
        };

        foreach (var item in data)
            tableLayoutPanelStats.Controls.Add(CreateValueControls(item, true));

    }

    private void AddUnit_Click(object sender, EventArgs e)
    {
    }

    private void SettingsToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }

    private Control CreateValueControls(string labelName, bool useNumeric = false)
    {
        var tableLayoutPanel = new TableLayoutPanel
        {
            ColumnCount = 3,
            RowCount = 3,
            AutoSize = true
        };

        Control control = useNumeric
            ? new NumericUpDown() { DecimalPlaces = 0, }
            : new TextBox();
        tableLayoutPanel.Controls.Add(control, 1, 0);

        var label = new Label { Text = labelName, Size = new Size(100, 15), TextAlign = ContentAlignment.MiddleRight };
        tableLayoutPanel.Controls.Add(label, 0, 0);

        var button = new Button() { Text = "C", AutoSize = true, AutoSizeMode = AutoSizeMode.GrowAndShrink };
        tableLayoutPanel.Controls.Add(button, 2, 0);

        return tableLayoutPanel;
    }
}