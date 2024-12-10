namespace BinaryTree
{
    public partial class Form1 : Form
    {
        BinaryTree tree = new BinaryTree();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtValue.Text, out int value))
            {
                tree.Add(value);
                ActualizarTreeView();
                lblResult.Text = $"Value {value} correct add.";
            }
            else
                MessageBox.Show("Enter a valid number.");

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtValue.Text, out int value))
            {
                bool found = tree.Search(value);
                lblResult.Text = found
                    ? $"Value {value} found in the tree."
                    : $"Value {value} not found.";
            }
            else
                MessageBox.Show("Enter a valid number.");
        }


        private void btnEliminate_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtValue.Text, out int value))
            {
                tree.Eliminate(value);
                ActualizarTreeView();
                lblResult.Text = $"Value {value} correctly eliminated (if any).";
            }
            else
                MessageBox.Show("Enter a valid number.");
        }
        private void ActualizarTreeView()
        {
            treeView.Nodes.Clear();
            if (tree.Root != null)
                MostrarNodos(tree.Root, treeView.Nodes);
            treeView.ExpandAll();
        }

        private void MostrarNodos(Node nodo, TreeNodeCollection nodoPadre)
        {
            if (nodo == null)
                return;

            TreeNode newNode = new TreeNode(nodo.Value.ToString());
            nodoPadre.Add(newNode);

            MostrarNodos(nodo.Left, newNode.Nodes);
            MostrarNodos(nodo.Right, newNode.Nodes);
        }
    }
}
