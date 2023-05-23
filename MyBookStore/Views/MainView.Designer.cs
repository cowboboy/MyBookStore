namespace MyBookStore.Views
{
    partial class MainView
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonAuthors = new System.Windows.Forms.Button();
            this.buttonCategories = new System.Windows.Forms.Button();
            this.buttonBooks = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.buttonLogin);
            this.panel1.Controls.Add(this.buttonAuthors);
            this.panel1.Controls.Add(this.buttonCategories);
            this.panel1.Controls.Add(this.buttonBooks);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(193, 450);
            this.panel1.TabIndex = 0;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(29, 270);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(110, 29);
            this.buttonLogin.TabIndex = 3;
            this.buttonLogin.Text = "Авторизация";
            this.buttonLogin.UseVisualStyleBackColor = true;
            // 
            // buttonAuthors
            // 
            this.buttonAuthors.Location = new System.Drawing.Point(29, 223);
            this.buttonAuthors.Name = "buttonAuthors";
            this.buttonAuthors.Size = new System.Drawing.Size(110, 29);
            this.buttonAuthors.TabIndex = 2;
            this.buttonAuthors.Text = "Авторы";
            this.buttonAuthors.UseVisualStyleBackColor = true;
            // 
            // buttonCategories
            // 
            this.buttonCategories.Location = new System.Drawing.Point(29, 179);
            this.buttonCategories.Name = "buttonCategories";
            this.buttonCategories.Size = new System.Drawing.Size(110, 29);
            this.buttonCategories.TabIndex = 1;
            this.buttonCategories.Text = "Жанры";
            this.buttonCategories.UseVisualStyleBackColor = true;
            // 
            // buttonBooks
            // 
            this.buttonBooks.Location = new System.Drawing.Point(29, 132);
            this.buttonBooks.Name = "buttonBooks";
            this.buttonBooks.Size = new System.Drawing.Size(110, 29);
            this.buttonBooks.TabIndex = 0;
            this.buttonBooks.Text = "Книги";
            this.buttonBooks.UseVisualStyleBackColor = true;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 450);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "MainView";
            this.Text = "MainView";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button buttonLogin;
        private Button buttonAuthors;
        private Button buttonCategories;
        private Button buttonBooks;
    }
}