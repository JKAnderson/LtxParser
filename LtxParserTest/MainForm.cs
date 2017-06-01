using LtxParser;
using Microsoft.Win32;
using System;
using System.Windows.Forms;

namespace LtxParserTest
{
    public partial class MainForm : Form
    {
        private static readonly RegistryKey registry = Registry.CurrentUser.CreateSubKey(@"Software\LtxParserTest");

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            textBoxNormalFile.Text = (string)registry.GetValue("NormalFile", "");
            textBoxModModConfig.Text = (string)registry.GetValue("ModModConfig", "");
            textBoxModVanillaConfig.Text = (string)registry.GetValue("ModVanillaConfig", "");
            textBoxModFile.Text = (string)registry.GetValue("ModFile", "system.ltx");
            textBoxString.Text = (string)registry.GetValue("String", "");
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            registry.SetValue("NormalFile", textBoxNormalFile.Text);
            registry.SetValue("ModModConfig", textBoxModModConfig.Text);
            registry.SetValue("ModVanillaConfig", textBoxModVanillaConfig.Text);
            registry.SetValue("ModFile", textBoxModFile.Text);
            registry.SetValue("String", textBoxString.Text);
        }

        private void buttonNormalRead_Click(object sender, EventArgs e)
        {
            Config config = Config.ReadLtx(textBoxNormalFile.Text);
            using (ResultForm resultForm = new ResultForm(config))
                resultForm.ShowDialog();
        }

        private void buttonModRead_Click(object sender, EventArgs e)
        {
            Config config = Config.ReadModLtx(textBoxModModConfig.Text, textBoxModVanillaConfig.Text, textBoxModFile.Text);
            using (ResultForm resultForm = new ResultForm(config))
                resultForm.ShowDialog();
        }

        private void buttonStringRead_Click(object sender, EventArgs e)
        {
            Config config = Config.ReadCustomData(textBoxString.Text);
            using (ResultForm resultForm = new ResultForm(config))
                resultForm.ShowDialog();
        }
    }
}
