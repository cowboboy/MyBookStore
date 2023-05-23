namespace MyBookStore.Views
{
    partial class BookView
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
            this.tabPageBookList = new System.Windows.Forms.TabPage();
            this.tabPageBookDetail = new System.Windows.Forms.TabPage();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxAuthor = new System.Windows.Forms.ComboBox();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.upDownQuantity = new System.Windows.Forms.NumericUpDown();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabPageBookList.SuspendLayout();
            this.tabPageBookDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageBookList);
            this.tabControl.Controls.Add(this.tabPageBookDetail);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(800, 450);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageBookList
            // 
            this.tabPageBookList.Controls.Add(this.buttonDelete);
            this.tabPageBookList.Controls.Add(this.buttonEdit);
            this.tabPageBookList.Controls.Add(this.buttonAdd);
            this.tabPageBookList.Controls.Add(this.buttonSearch);
            this.tabPageBookList.Controls.Add(this.txtSearch);
            this.tabPageBookList.Controls.Add(this.dataGridView);
            this.tabPageBookList.Location = new System.Drawing.Point(4, 29);
            this.tabPageBookList.Name = "tabPageBookList";
            this.tabPageBookList.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBookList.Size = new System.Drawing.Size(792, 417);
            this.tabPageBookList.TabIndex = 0;
            this.tabPageBookList.Text = "Книги";
            this.tabPageBookList.UseVisualStyleBackColor = true;
            // 
            // tabPageBookDetail
            // 
            this.tabPageBookDetail.Controls.Add(this.buttonCancel);
            this.tabPageBookDetail.Controls.Add(this.buttonSave);
            this.tabPageBookDetail.Controls.Add(this.label7);
            this.tabPageBookDetail.Controls.Add(this.txtDescription);
            this.tabPageBookDetail.Controls.Add(this.upDownQuantity);
            this.tabPageBookDetail.Controls.Add(this.txtPrice);
            this.tabPageBookDetail.Controls.Add(this.comboBoxCategory);
            this.tabPageBookDetail.Controls.Add(this.comboBoxAuthor);
            this.tabPageBookDetail.Controls.Add(this.label6);
            this.tabPageBookDetail.Controls.Add(this.label5);
            this.tabPageBookDetail.Controls.Add(this.label4);
            this.tabPageBookDetail.Controls.Add(this.label3);
            this.tabPageBookDetail.Controls.Add(this.label2);
            this.tabPageBookDetail.Controls.Add(this.txtTitle);
            this.tabPageBookDetail.Controls.Add(this.label1);
            this.tabPageBookDetail.Controls.Add(this.txtId);
            this.tabPageBookDetail.Location = new System.Drawing.Point(4, 29);
            this.tabPageBookDetail.Name = "tabPageBookDetail";
            this.tabPageBookDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBookDetail.Size = new System.Drawing.Size(792, 417);
            this.tabPageBookDetail.TabIndex = 1;
            this.tabPageBookDetail.Text = "Книга";
            this.tabPageBookDetail.UseVisualStyleBackColor = true;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(26, 56);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 29;
            this.dataGridView.Size = new System.Drawing.Size(627, 341);
            this.dataGridView.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(26, 23);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(527, 27);
            this.txtSearch.TabIndex = 1;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(559, 23);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(94, 29);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "Найти";
            this.buttonSearch.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(676, 56);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(94, 29);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(676, 91);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(94, 29);
            this.buttonEdit.TabIndex = 4;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(676, 126);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(94, 29);
            this.buttonDelete.TabIndex = 5;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(29, 39);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(125, 27);
            this.txtId.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID:";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(29, 92);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(721, 27);
            this.txtTitle.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Название:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Автор:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(186, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Жанр:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(346, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Цена:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(487, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Количество:";
            // 
            // comboBoxAuthor
            // 
            this.comboBoxAuthor.FormattingEnabled = true;
            this.comboBoxAuthor.Location = new System.Drawing.Point(29, 145);
            this.comboBoxAuthor.Name = "comboBoxAuthor";
            this.comboBoxAuthor.Size = new System.Drawing.Size(151, 28);
            this.comboBoxAuthor.TabIndex = 8;
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(186, 145);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(151, 28);
            this.comboBoxCategory.TabIndex = 9;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(346, 145);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(125, 27);
            this.txtPrice.TabIndex = 10;
            // 
            // upDownQuantity
            // 
            this.upDownQuantity.Location = new System.Drawing.Point(487, 145);
            this.upDownQuantity.Name = "upDownQuantity";
            this.upDownQuantity.Size = new System.Drawing.Size(150, 27);
            this.upDownQuantity.TabIndex = 11;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(29, 197);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(721, 147);
            this.txtDescription.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Описание:";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(260, 362);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(94, 29);
            this.buttonSave.TabIndex = 14;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(377, 362);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(94, 29);
            this.buttonCancel.TabIndex = 15;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // BookView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl);
            this.Name = "BookView";
            this.Text = "BookView";
            this.tabControl.ResumeLayout(false);
            this.tabPageBookList.ResumeLayout(false);
            this.tabPageBookList.PerformLayout();
            this.tabPageBookDetail.ResumeLayout(false);
            this.tabPageBookDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownQuantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl;
        private TabPage tabPageBookList;
        private Button buttonDelete;
        private Button buttonEdit;
        private Button buttonAdd;
        private Button buttonSearch;
        private TextBox txtSearch;
        private DataGridView dataGridView;
        private TabPage tabPageBookDetail;
        private Label label2;
        private TextBox txtTitle;
        private Label label1;
        private TextBox txtId;
        private NumericUpDown upDownQuantity;
        private TextBox txtPrice;
        private ComboBox comboBoxCategory;
        private ComboBox comboBoxAuthor;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button buttonCancel;
        private Button buttonSave;
        private Label label7;
        private TextBox txtDescription;
    }
}