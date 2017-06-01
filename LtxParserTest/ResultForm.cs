using LtxParser;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LtxParserTest
{
    public partial class ResultForm : Form
    {
        public ResultForm(Config config)
        {
            InitializeComponent();
            foreach (Section section in config.Sections)
            {
                List<TreeNode> nodes = new List<TreeNode>();
                foreach (string field in section.Fields)
                {
                    nodes.Add(new TreeNode(string.Format("{0}: {1}", field, section[field])));
                }
                TreeNode node = new TreeNode(section.Name, nodes.ToArray());
                treeView1.Nodes.Add(node);
            }
        }
    }
}
