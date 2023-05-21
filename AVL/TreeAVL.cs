using System.Windows.Forms;

namespace AVL
{
    public class TreeAVL
    {
        private Node _root;
        private bool _changedTree;

        public TreeAVL()
        {
            _changedTree = true;
        }

        public void Insert(int value)
        {
            if (IsEmpty())
            {
                _root = new Node();
            }
            _root = _root.Insert(value, out _);
        }

        public bool Remove(int value)
        {
            _root = _root.Remove(value, out _, out bool isValueFound);
            return isValueFound;
        }

        public void Clear()
        {
            _root = null;
        }

        public void Show(TreeView treeView)
        {
            if (!_changedTree)
            {
                _changedTree = true;
            }

            treeView.Nodes.Clear();
            if (!IsEmpty())
            {
                _root.Show(treeView);
                treeView.ExpandAll();
            }          
        }

        public bool IsEmpty()
        {
            return _root == null;
        }
    }
}
