namespace BinaryTree
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            treeView = new TreeView();
            btnAdd = new Button();
            txtValue = new TextBox();
            label1 = new Label();
            btnEliminate = new Button();
            btnSearch = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // treeView
            // 
            treeView.Location = new Point(219, 59);
            treeView.Name = "treeView";
            treeView.Size = new Size(275, 212);
            treeView.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(138, 94);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtValue
            // 
            txtValue.Location = new Point(113, 59);
            txtValue.Name = "txtValue";
            txtValue.Size = new Size(100, 23);
            txtValue.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 59);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 3;
            label1.Text = "Enter a number";
            // 
            // btnEliminate
            // 
            btnEliminate.Location = new Point(138, 152);
            btnEliminate.Name = "btnEliminate";
            btnEliminate.Size = new Size(75, 23);
            btnEliminate.TabIndex = 4;
            btnEliminate.Text = "Eliminate";
            btnEliminate.UseVisualStyleBackColor = true;
            btnEliminate.Click += btnEliminate_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(138, 123);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(78, 199);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(38, 15);
            lblResult.TabIndex = 6;
            lblResult.Text = "label2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResult);
            Controls.Add(btnSearch);
            Controls.Add(btnEliminate);
            Controls.Add(label1);
            Controls.Add(txtValue);
            Controls.Add(btnAdd);
            Controls.Add(treeView);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView treeView;
        private Button btnAdd;
        private TextBox txtValue;
        private Label label1;
        private Button btnEliminate;
        private Button btnSearch;
        private Label lblResult;
    }
}
