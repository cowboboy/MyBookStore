namespace MyBookStore.Views
{
    partial class AuthorView
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageAuthors = new System.Windows.Forms.TabPage();
            this.tabPageAuthor = new System.Windows.Forms.TabPage();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.tabControl.SuspendLayout();
            this.tabPageAuthors.SuspendLayout();
            this.tabPageAuthor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageAuthors);
            this.tabControl.Controls.Add(this.tabPageAuthor);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(800, 450);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageAuthors
            // 
            this.tabPageAuthors.Controls.Add(this.buttonDelete);
            this.tabPageAuthors.Controls.Add(this.buttonEdit);
            this.tabPageAuthors.Controls.Add(this.buttonAdd);
            this.tabPageAuthors.Controls.Add(this.buttonSearch);
            this.tabPageAuthors.Controls.Add(this.txtSearch);
            this.tabPageAuthors.Controls.Add(this.dataGridView);
            this.tabPageAuthors.Location = new System.Drawing.Point(4, 29);
            this.tabPageAuthors.Name = "tabPageAuthors";
            this.tabPageAuthors.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAuthors.Size = new System.Drawing.Size(792, 417);
            this.tabPageAuthors.TabIndex = 0;
            this.tabPageAuthors.Text = "Авторы";
            this.tabPageAuthors.UseVisualStyleBackColor = true;
            // 
            // tabPageAuthor
            // 
            this.tabPageAuthor.Controls.Add(this.txtName);
            this.tabPageAuthor.Controls.Add(this.txtId);
            this.tabPageAuthor.Controls.Add(this.buttonCancel);
            this.tabPageAuthor.Controls.Add(this.buttonSave);
            this.tabPageAuthor.Controls.Add(this.label2);
            this.tabPageAuthor.Controls.Add(this.label1);
            this.tabPageAuthor.Location = new System.Drawing.Point(4, 29);
            this.tabPageAuthor.Name = "tabPageAuthor";
            this.tabPageAuthor.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAuthor.Size = new System.Drawing.Size(792, 417);
            this.tabPageAuthor.TabIndex = 1;
            this.tabPageAuthor.Text = "Автор";
            this.tabPageAuthor.UseVisualStyleBackColor = true;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(31, 54);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 29;
            this.dataGridView.Size = new System.Drawing.Size(628, 355);
            this.dataGridView.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(31, 21);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(528, 27);
            this.txtSearch.TabIndex = 1;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(565, 21);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(94, 29);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "Найти";
            this.buttonSearch.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(675, 54);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(94, 29);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(675, 89);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(94, 29);
            this.buttonEdit.TabIndex = 4;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(675, 124);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(94, 29);
            this.buttonDelete.TabIndex = 5;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Имя:";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(261, 159);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(94, 29);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(395, 159);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(94, 29);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(35, 51);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(125, 27);
            this.txtId.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(35, 104);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(369, 27);
            this.txtName.TabIndex = 5;
            // 
            // AuthorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl);
            this.Name = "AuthorView";
            this.Text = "AuthorView";
            this.tabControl.ResumeLayout(false);
            this.tabPageAuthors.ResumeLayout(false);
            this.tabPageAuthors.PerformLayout();
            this.tabPageAuthor.ResumeLayout(false);
            this.tabPageAuthor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl;
        private TabPage tabPageAuthors;
        private Button buttonDelete;
        private Button buttonEdit;
        private Button buttonAdd;
        private Button buttonSearch;
        private TextBox txtSearch;
        private DataGridView dataGridView;
        private TabPage tabPageAuthor;
        private TextBox txtName;
        private TextBox txtId;
        private Button buttonCancel;
        private Button buttonSave;
        private Label label2;
        private Label label1;
    }
}