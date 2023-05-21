using System;
using System.Windows.Forms;

namespace AVL
{
    public partial class MainForm : Form
    {
        TreeAVL treeAVL;
        public MainForm()
        {
            InitializeComponent();
            treeAVL = new TreeAVL();
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxInsert.Text, out int value))
            {
                textBoxInsert.Clear();
                MessageBox.Show("Некорректное значение");
                return;
            }

            treeAVL.Show(treeViewWas);
            treeAVL.Insert(value);
            treeAVL.Show(treeViewBecome);
            
            textBoxInsert.Clear();
            textBoxInsert.Focus();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (treeAVL.IsEmpty())
            {
                MessageBox.Show("Пустое АВЛ-дерево");
                textBoxRemove.Clear();
                textBoxRemove.Focus();
                return;
            }

            if (!int.TryParse(textBoxRemove.Text, out int value))
            {
                textBoxRemove.Clear();
                MessageBox.Show("Некорректное значение");
                return;
            }

            treeAVL.Show(treeViewWas);
            if (!treeAVL.Remove(value))
                MessageBox.Show("Такое значение отсутствует в АВЛ-дереве");
            treeAVL.Show(treeViewBecome);

            textBoxRemove.Clear();
            textBoxRemove.Focus();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            treeAVL.Clear();
            treeViewWas.Nodes.Clear();
            treeViewBecome.Nodes.Clear();
            textBoxInsert.Clear();
            textBoxRemove.Clear();
            textBoxInsert.Focus();
        }

        private void buttonInsertRandom_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxInsertRandom.Text, out int value))
            {
                textBoxRemove.Clear();
                MessageBox.Show("Некорректное значение");
                return;
            }

            int maxCount;
            Random random = new Random();
            treeAVL.Show(treeViewWas);
            if (value > 10000)
                maxCount = 10000;
            else
                maxCount = value;
            for (int i = 0; i < maxCount; i++)            
                treeAVL.Insert(random.Next(value));            
            treeAVL.Show(treeViewBecome);
        }

        private void textBoxInsert_Click(object sender, EventArgs e)
        {
            textBoxRemove.Clear();
            textBoxInsertRandom.Clear();
        }

        private void textBoxRemove_Click(object sender, EventArgs e)
        {
            textBoxInsert.Clear();
            textBoxInsertRandom.Clear();
        }

        private void textBoxInsertRandom_Click(object sender, EventArgs e)
        {
            textBoxInsert.Clear();
            textBoxRemove.Clear();
        }
    }
}
