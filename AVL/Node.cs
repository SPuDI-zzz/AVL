using System.Windows.Forms;

namespace AVL
{
    public class Node
    {
        private int _value;
        private int _count;
        private enum TreeBalance 
        {
            LeftSubtreeGreater = -1,
            Balanced = 0,
            RightSubtreeGreater = 1
        }
        private TreeBalance _balance;
        private Node _left, _right;

        public Node() { }

        public Node Insert(int value, out bool isNeedToBalance)
        {
            if (IsEmpty())
            {
                isNeedToBalance= true;
                _value = value;
                _count = 1;
                _left = new Node();
                _right = new Node();
                return this;
            }

            if (_value > value)
            {
                _left = _left.Insert(value, out isNeedToBalance);

                if (!isNeedToBalance)                
                    return this;                

                switch (_balance)
                {
                    case TreeBalance.RightSubtreeGreater:
                        _balance = TreeBalance.Balanced;
                        isNeedToBalance = false;
                        return this;

                    case TreeBalance.Balanced:
                        _balance = TreeBalance.LeftSubtreeGreater;
                        return this;

                    case TreeBalance.LeftSubtreeGreater:
                        Node tempLeft = _left;

                        if (tempLeft._balance == TreeBalance.LeftSubtreeGreater)
                        {
                            _left = tempLeft._right;
                            tempLeft._right = this;
                            _balance = TreeBalance.Balanced;
                            isNeedToBalance = false;
                            tempLeft._balance = TreeBalance.Balanced;
                            return tempLeft;
                        }

                        Node tempLeftRight = tempLeft._right;
                        tempLeft._right = tempLeftRight._left;
                        tempLeftRight._left = tempLeft;
                        _left = tempLeftRight._right;
                        tempLeftRight._right = this;

                        if (tempLeftRight._balance == TreeBalance.RightSubtreeGreater)                        
                            tempLeft._balance = TreeBalance.LeftSubtreeGreater;                       
                        else                        
                            tempLeft._balance = TreeBalance.Balanced;
                        
                        _balance = TreeBalance.Balanced;
                        isNeedToBalance = false;
                        return tempLeftRight;

                    default: return null;
                }
            }

            if (_value < value)
            {
                _right = _right.Insert(value, out isNeedToBalance);

                if (!isNeedToBalance)                
                    return this;

                switch (_balance)
                {
                    case TreeBalance.LeftSubtreeGreater:
                        _balance = TreeBalance.Balanced;
                        isNeedToBalance = false;
                        return this;

                    case TreeBalance.Balanced:
                        _balance = TreeBalance.RightSubtreeGreater;
                        return this;

                    case TreeBalance.RightSubtreeGreater:
                        Node tempRight = _right;

                        if (tempRight._balance == TreeBalance.RightSubtreeGreater)
                        {
                            _right = tempRight._left;
                            tempRight._left = this;
                            _balance = TreeBalance.Balanced;
                            isNeedToBalance = false;
                            tempRight._balance = TreeBalance.Balanced;
                            return tempRight;
                        }

                        Node tempRightLeft = tempRight._left;
                        tempRight._left = tempRightLeft._right;
                        tempRightLeft._right = tempRight;
                        _right = tempRightLeft._left;
                        tempRightLeft._left = this;

                        if (tempRightLeft._balance == TreeBalance.LeftSubtreeGreater)                        
                            tempRight._balance = TreeBalance.RightSubtreeGreater;                        
                        else                        
                            tempRight._balance = TreeBalance.Balanced;
                        
                        _balance = TreeBalance.Balanced;
                        isNeedToBalance = false;
                        return tempRightLeft;

                    default: return null;
                }
            }

            _count++;
            isNeedToBalance = false;
            return this;
        }

        public Node Remove(int value, out bool isNeedToBalance, out bool isValueFound)
        {
            if (IsEmpty())
            {
                isValueFound = false;
                isNeedToBalance = false;
                return this;
            }

            if (_value > value)
            {
                _left = _left.Remove(value, out isNeedToBalance, out isValueFound);
                if (isNeedToBalance)
                    return BalanceLeft(ref isNeedToBalance);

                return this;
            }

            if (_value < value)
            {
                _right = _right.Remove(value, out isNeedToBalance, out isValueFound);
                if (isNeedToBalance)
                    return BalanceRight(ref isNeedToBalance);

                return this;
            }

            isValueFound = true;

            if (this._right.IsEmpty())
            {
                isNeedToBalance = true;
                return this._left;
            }

            if (this._left.IsEmpty())
            {
                isNeedToBalance = true;
                return this._right;
            }

            this._left = RemoveNode(this._left, this, out isNeedToBalance);
            if (isNeedToBalance)
                return BalanceLeft(ref isNeedToBalance);

            return this;
        }

        public void Show(TreeView treeView)
        {
            treeView.Nodes.Add(_value.ToString());
            ShowChilds(treeView.Nodes[0]);
        }

        private void ShowChilds(TreeNode treeNode)
        {
            if (!_left.IsEmpty() || !_right.IsEmpty())
            {
                if (!_left.IsEmpty())
                {
                    treeNode.Nodes.Add(_left._value.ToString());
                    _left.ShowChilds(treeNode.Nodes[0]);
                } 
                else treeNode.Nodes.Add("X");

                if (!_right.IsEmpty())
                {
                    treeNode.Nodes.Add(_right._value.ToString());
                    _right.ShowChilds(treeNode.Nodes[1]);
                }    
                else treeNode.Nodes.Add("X");
            }
        }

        private Node BalanceLeft(ref bool isNeedToBalance)
        {
            switch (_balance)
            {
                case TreeBalance.LeftSubtreeGreater:
                    _balance = TreeBalance.Balanced;
                    return this;

                case TreeBalance.Balanced:
                    _balance = TreeBalance.RightSubtreeGreater;
                    isNeedToBalance = false;
                    return this;

                case TreeBalance.RightSubtreeGreater:
                    Node tempRight = _right;

                    if (tempRight._balance == TreeBalance.Balanced ||
                        tempRight._balance == TreeBalance.RightSubtreeGreater)
                    {
                        _right = tempRight._left;
                        tempRight._left = this;

                        if (tempRight._balance == TreeBalance.Balanced)
                        {
                            _balance = TreeBalance.RightSubtreeGreater;
                            tempRight._balance = TreeBalance.LeftSubtreeGreater;
                            isNeedToBalance = false;
                            return tempRight;
                        }

                        _balance = TreeBalance.Balanced;
                        tempRight._balance = TreeBalance.Balanced;
                        return tempRight;
                    }

                    Node tempRightLeft = tempRight._left;
                    tempRight._left = tempRightLeft._right;
                    tempRightLeft._right = tempRight;
                    _right = tempRightLeft._left;
                    tempRightLeft._left = this;

                    if (tempRightLeft._balance == TreeBalance.RightSubtreeGreater)
                        _balance = TreeBalance.LeftSubtreeGreater;
                    else
                        _balance = TreeBalance.Balanced;

                    if (tempRightLeft._balance == TreeBalance.LeftSubtreeGreater)
                        tempRight._balance = TreeBalance.RightSubtreeGreater;
                    else
                        _balance = TreeBalance.Balanced;

                    tempRightLeft._balance = TreeBalance.Balanced;
                    return tempRightLeft;

                default: return null;
            }
        }

        private Node BalanceRight(ref bool isNeedToBalance)
        {
            switch (_balance)
            {
                case TreeBalance.RightSubtreeGreater:
                    _balance = TreeBalance.Balanced;
                    return this;

                case TreeBalance.Balanced:
                    _balance = TreeBalance.LeftSubtreeGreater;
                    isNeedToBalance = false;
                    return this;

                case TreeBalance.LeftSubtreeGreater:
                    Node tempLeft = _left;

                    if (tempLeft._balance == TreeBalance.LeftSubtreeGreater ||
                        tempLeft._balance == TreeBalance.Balanced)
                    {
                        _left = tempLeft._right;
                        tempLeft._right = this;

                        if (tempLeft._balance == TreeBalance.Balanced)
                        {
                            _balance = TreeBalance.LeftSubtreeGreater;
                            tempLeft._balance = TreeBalance.RightSubtreeGreater;
                            isNeedToBalance = false;
                            return tempLeft;
                        }

                        _balance = TreeBalance.Balanced;
                        tempLeft._balance = TreeBalance.Balanced;
                        return tempLeft;
                    }

                    Node tempLeftRight = tempLeft._right;
                    tempLeft._right = tempLeftRight._left;
                    tempLeftRight._left = tempLeft;
                    _left = tempLeftRight._right;
                    tempLeftRight._right = this;

                    if (tempLeftRight._balance == TreeBalance.LeftSubtreeGreater)
                        _balance = TreeBalance.RightSubtreeGreater;
                    else
                        _balance = TreeBalance.Balanced;

                    if (tempLeftRight._balance == TreeBalance.RightSubtreeGreater)
                        tempLeft._balance = TreeBalance.LeftSubtreeGreater;
                    else
                        _balance = TreeBalance.Balanced;

                    tempLeftRight._balance = TreeBalance.Balanced;
                    return tempLeftRight;

                default: return null;
            }
        }

        private Node RemoveNode(Node node, Node parentNode, out bool isNeedToBalance)
        {
            if (node._right.IsEmpty())
            {
                parentNode._value = node._value;
                parentNode._count = node._count;
                isNeedToBalance = true;
                return node._left;
            }

            node._right = RemoveNode(node._right, parentNode, out isNeedToBalance);
            if (isNeedToBalance)           
                node = node.BalanceRight(ref isNeedToBalance);     
            return node;
        }

        private bool IsEmpty() { return _count == 0; }
    }
}
