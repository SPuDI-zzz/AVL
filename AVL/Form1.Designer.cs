namespace AVL
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.treeViewWas = new System.Windows.Forms.TreeView();
            this.treeViewBecome = new System.Windows.Forms.TreeView();
            this.textBoxInsert = new System.Windows.Forms.TextBox();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.textBoxRemove = new System.Windows.Forms.TextBox();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonInsertRandom = new System.Windows.Forms.Button();
            this.textBoxInsertRandom = new System.Windows.Forms.TextBox();
            this.labelWas = new System.Windows.Forms.Label();
            this.labelBecome = new System.Windows.Forms.Label();
            this.labelInsert = new System.Windows.Forms.Label();
            this.labelRemove = new System.Windows.Forms.Label();
            this.labelClear = new System.Windows.Forms.Label();
            this.labelInsertRandom = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // treeViewWas
            // 
            this.treeViewWas.Location = new System.Drawing.Point(12, 25);
            this.treeViewWas.Name = "treeViewWas";
            this.treeViewWas.Size = new System.Drawing.Size(328, 413);
            this.treeViewWas.TabIndex = 0;
            // 
            // treeViewBecome
            // 
            this.treeViewBecome.Location = new System.Drawing.Point(346, 25);
            this.treeViewBecome.Name = "treeViewBecome";
            this.treeViewBecome.Size = new System.Drawing.Size(328, 413);
            this.treeViewBecome.TabIndex = 1;
            // 
            // textBoxInsert
            // 
            this.textBoxInsert.Location = new System.Drawing.Point(680, 41);
            this.textBoxInsert.Name = "textBoxInsert";
            this.textBoxInsert.Size = new System.Drawing.Size(100, 20);
            this.textBoxInsert.TabIndex = 2;
            this.textBoxInsert.Click += new System.EventHandler(this.textBoxInsert_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(786, 41);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(75, 23);
            this.buttonInsert.TabIndex = 3;
            this.buttonInsert.Text = "Insert";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // textBoxRemove
            // 
            this.textBoxRemove.Location = new System.Drawing.Point(680, 83);
            this.textBoxRemove.Name = "textBoxRemove";
            this.textBoxRemove.Size = new System.Drawing.Size(100, 20);
            this.textBoxRemove.TabIndex = 4;
            this.textBoxRemove.Click += new System.EventHandler(this.textBoxRemove_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(786, 83);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(75, 23);
            this.buttonRemove.TabIndex = 5;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(680, 122);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 6;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonInsertRandom
            // 
            this.buttonInsertRandom.Location = new System.Drawing.Point(786, 164);
            this.buttonInsertRandom.Name = "buttonInsertRandom";
            this.buttonInsertRandom.Size = new System.Drawing.Size(75, 23);
            this.buttonInsertRandom.TabIndex = 7;
            this.buttonInsertRandom.Text = "InsertRandom";
            this.buttonInsertRandom.UseVisualStyleBackColor = true;
            this.buttonInsertRandom.Click += new System.EventHandler(this.buttonInsertRandom_Click);
            // 
            // textBoxInsertRandom
            // 
            this.textBoxInsertRandom.Location = new System.Drawing.Point(680, 164);
            this.textBoxInsertRandom.Name = "textBoxInsertRandom";
            this.textBoxInsertRandom.Size = new System.Drawing.Size(100, 20);
            this.textBoxInsertRandom.TabIndex = 8;
            this.textBoxInsertRandom.Click += new System.EventHandler(this.textBoxInsertRandom_Click);
            // 
            // labelWas
            // 
            this.labelWas.AutoSize = true;
            this.labelWas.Location = new System.Drawing.Point(9, 9);
            this.labelWas.Name = "labelWas";
            this.labelWas.Size = new System.Drawing.Size(119, 13);
            this.labelWas.TabIndex = 9;
            this.labelWas.Text = "Вывод АВЛ-дерева до";
            // 
            // labelBecome
            // 
            this.labelBecome.AutoSize = true;
            this.labelBecome.Location = new System.Drawing.Point(343, 9);
            this.labelBecome.Name = "labelBecome";
            this.labelBecome.Size = new System.Drawing.Size(137, 13);
            this.labelBecome.TabIndex = 10;
            this.labelBecome.Text = "Вывод АВЛ-дерева после";
            // 
            // labelInsert
            // 
            this.labelInsert.AutoSize = true;
            this.labelInsert.Location = new System.Drawing.Point(680, 25);
            this.labelInsert.Name = "labelInsert";
            this.labelInsert.Size = new System.Drawing.Size(164, 13);
            this.labelInsert.TabIndex = 11;
            this.labelInsert.Text = "Введите значение для вставки";
            // 
            // labelRemove
            // 
            this.labelRemove.AutoSize = true;
            this.labelRemove.Location = new System.Drawing.Point(680, 67);
            this.labelRemove.Name = "labelRemove";
            this.labelRemove.Size = new System.Drawing.Size(170, 13);
            this.labelRemove.TabIndex = 12;
            this.labelRemove.Text = "Введите значение для удаления";
            // 
            // labelClear
            // 
            this.labelClear.AutoSize = true;
            this.labelClear.Location = new System.Drawing.Point(680, 106);
            this.labelClear.Name = "labelClear";
            this.labelClear.Size = new System.Drawing.Size(75, 13);
            this.labelClear.TabIndex = 13;
            this.labelClear.Text = "Очистить всё";
            // 
            // labelInsertRandom
            // 
            this.labelInsertRandom.AutoSize = true;
            this.labelInsertRandom.Location = new System.Drawing.Point(677, 148);
            this.labelInsertRandom.Name = "labelInsertRandom";
            this.labelInsertRandom.Size = new System.Drawing.Size(281, 13);
            this.labelInsertRandom.TabIndex = 14;
            this.labelInsertRandom.Text = "Введите количество случайных значений для вставки";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 450);
            this.Controls.Add(this.labelInsertRandom);
            this.Controls.Add(this.labelClear);
            this.Controls.Add(this.labelRemove);
            this.Controls.Add(this.labelInsert);
            this.Controls.Add(this.labelBecome);
            this.Controls.Add(this.labelWas);
            this.Controls.Add(this.textBoxInsertRandom);
            this.Controls.Add(this.buttonInsertRandom);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.textBoxRemove);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.textBoxInsert);
            this.Controls.Add(this.treeViewBecome);
            this.Controls.Add(this.treeViewWas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewWas;
        private System.Windows.Forms.TreeView treeViewBecome;
        private System.Windows.Forms.TextBox textBoxInsert;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.TextBox textBoxRemove;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonInsertRandom;
        private System.Windows.Forms.TextBox textBoxInsertRandom;
        private System.Windows.Forms.Label labelWas;
        private System.Windows.Forms.Label labelBecome;
        private System.Windows.Forms.Label labelInsert;
        private System.Windows.Forms.Label labelRemove;
        private System.Windows.Forms.Label labelClear;
        private System.Windows.Forms.Label labelInsertRandom;
    }
}

