using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibraryControlView
{
    public partial class ControlTreeView : UserControl
    {
        private List<String> _parentNodes;


        private TreeNode _selectedNode;

        [Category("Спецификация"), Description("Выбранный индекс")]
        public int SelectedIndex
        {
            get => treeView.SelectedNode.Index;
        }

        [Category("Спецификация"), Description("Выбранный узел")]
        public TreeNode SelectedTreeNode
        {
            get => _selectedNode;
            set
            {
                _selectedNode = value;
                treeView.SelectedNode = value;
            }
        }

        public ControlTreeView()
        {
            InitializeComponent();
            _parentNodes = new List<string>();
        }

        public void AddNodes(List<Node> nodes)
        {
            treeView.Nodes.Clear();
            foreach (var node in nodes)
            {
                var treeNode = new TreeNode(node.Value);
                treeView.Nodes.Add(treeNode);
                AddSubNodes(treeNode, node.Nodes);
            }
        }

        public void AddSubNodes(TreeNode parentNode, List<Node> nodes)
        {
            foreach (var node in nodes)
            {
                var treeNode = new TreeNode(node.Value);
                AddSubNodes(treeNode, node.Nodes);
                parentNode.Nodes.Add(treeNode);
            }  
        }

        public int AddParentNode(string name)
        {
            var idx = _parentNodes.Count;
            _parentNodes.Add(name);
            treeView.Nodes.Add(name);
            return idx;
        }


        public void AddValue(int parentNodeIndex, string value)
        {
            treeView.Nodes[parentNodeIndex].Nodes.Add(value);
        }

    }
}
