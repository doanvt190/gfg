namespace ASM2_DATA
{
    partial class Form2
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            button1 = new Button();
            cbBookAuthor = new ComboBox();
            label1 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dgvBooks = new DataGridView();
            dtpBookPublishingDate = new DateTimePicker();
            cbBookPublisher = new ComboBox();
            cbBookCategory = new ComboBox();
            txtBookName = new TextBox();
            txtBookID = new TextBox();
            tabPage2 = new TabPage();
            label22 = new Label();
            dgvTickets = new DataGridView();
            dtpReturnDate = new DateTimePicker();
            dtpBorrowDate = new DateTimePicker();
            cbTicketBorrower = new ComboBox();
            cbTicketBook = new ComboBox();
            txtTicketID = new TextBox();
            label21 = new Label();
            label20 = new Label();
            label19 = new Label();
            label18 = new Label();
            label17 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTickets).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            tabControl1.Location = new Point(3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(889, 603);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(cbBookAuthor);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(dgvBooks);
            tabPage1.Controls.Add(dtpBookPublishingDate);
            tabPage1.Controls.Add(cbBookPublisher);
            tabPage1.Controls.Add(cbBookCategory);
            tabPage1.Controls.Add(txtBookName);
            tabPage1.Controls.Add(txtBookID);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(881, 570);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Book";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(518, 188);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 35;
            button1.Text = "Next";
            button1.UseVisualStyleBackColor = true;
            // 
            // cbBookAuthor
            // 
            cbBookAuthor.FormattingEnabled = true;
            cbBookAuthor.Location = new Point(170, 162);
            cbBookAuthor.Name = "cbBookAuthor";
            cbBookAuthor.Size = new Size(223, 28);
            cbBookAuthor.TabIndex = 34;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(82, 163);
            label1.Name = "label1";
            label1.Size = new Size(66, 23);
            label1.TabIndex = 33;
            label1.Text = "Author";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label7.Location = new Point(399, 93);
            label7.Name = "label7";
            label7.Size = new Size(137, 23);
            label7.TabIndex = 32;
            label7.Text = "Publishing Date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label6.Location = new Point(399, 15);
            label6.Name = "label6";
            label6.Size = new Size(84, 23);
            label6.TabIndex = 31;
            label6.Text = "Publisher";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label5.Location = new Point(82, 242);
            label5.Name = "label5";
            label5.Size = new Size(84, 23);
            label5.TabIndex = 30;
            label5.Text = "Category";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label4.Location = new Point(82, 93);
            label4.Name = "label4";
            label4.Size = new Size(57, 23);
            label4.TabIndex = 29;
            label4.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label3.Location = new Point(82, 15);
            label3.Name = "label3";
            label3.Size = new Size(28, 23);
            label3.TabIndex = 28;
            label3.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label2.Location = new Point(350, 310);
            label2.Name = "label2";
            label2.Size = new Size(186, 38);
            label2.TabIndex = 27;
            label2.Text = "List of Books";
            // 
            // dgvBooks
            // 
            dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBooks.Location = new Point(6, 368);
            dgvBooks.Name = "dgvBooks";
            dgvBooks.RowHeadersWidth = 51;
            dgvBooks.Size = new Size(872, 188);
            dgvBooks.TabIndex = 26;
            dgvBooks.CellContentClick += dgvBooks_CellContentClick;
            // 
            // dtpBookPublishingDate
            // 
            dtpBookPublishingDate.Location = new Point(580, 87);
            dtpBookPublishingDate.Name = "dtpBookPublishingDate";
            dtpBookPublishingDate.Size = new Size(223, 27);
            dtpBookPublishingDate.TabIndex = 25;
            // 
            // cbBookPublisher
            // 
            cbBookPublisher.FormattingEnabled = true;
            cbBookPublisher.Location = new Point(580, 15);
            cbBookPublisher.Name = "cbBookPublisher";
            cbBookPublisher.Size = new Size(223, 28);
            cbBookPublisher.TabIndex = 24;
            // 
            // cbBookCategory
            // 
            cbBookCategory.FormattingEnabled = true;
            cbBookCategory.Location = new Point(170, 237);
            cbBookCategory.Name = "cbBookCategory";
            cbBookCategory.Size = new Size(223, 28);
            cbBookCategory.TabIndex = 23;
            // 
            // txtBookName
            // 
            txtBookName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtBookName.Location = new Point(170, 87);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(223, 27);
            txtBookName.TabIndex = 22;
            // 
            // txtBookID
            // 
            txtBookID.Location = new Point(170, 16);
            txtBookID.Name = "txtBookID";
            txtBookID.Size = new Size(223, 27);
            txtBookID.TabIndex = 21;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label22);
            tabPage2.Controls.Add(dgvTickets);
            tabPage2.Controls.Add(dtpReturnDate);
            tabPage2.Controls.Add(dtpBorrowDate);
            tabPage2.Controls.Add(cbTicketBorrower);
            tabPage2.Controls.Add(cbTicketBook);
            tabPage2.Controls.Add(txtTicketID);
            tabPage2.Controls.Add(label21);
            tabPage2.Controls.Add(label20);
            tabPage2.Controls.Add(label19);
            tabPage2.Controls.Add(label18);
            tabPage2.Controls.Add(label17);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(881, 570);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Ticket";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label22.Location = new Point(84, 29);
            label22.Name = "label22";
            label22.Size = new Size(28, 23);
            label22.TabIndex = 32;
            label22.Text = "ID";
            // 
            // dgvTickets
            // 
            dgvTickets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTickets.Location = new Point(-19, 366);
            dgvTickets.Name = "dgvTickets";
            dgvTickets.RowHeadersWidth = 51;
            dgvTickets.Size = new Size(919, 188);
            dgvTickets.TabIndex = 31;
            dgvTickets.CellContentClick += dgvTickets_CellContentClick;
            // 
            // dtpReturnDate
            // 
            dtpReturnDate.Location = new Point(590, 99);
            dtpReturnDate.Name = "dtpReturnDate";
            dtpReturnDate.Size = new Size(250, 27);
            dtpReturnDate.TabIndex = 26;
            // 
            // dtpBorrowDate
            // 
            dtpBorrowDate.Location = new Point(590, 24);
            dtpBorrowDate.Name = "dtpBorrowDate";
            dtpBorrowDate.Size = new Size(250, 27);
            dtpBorrowDate.TabIndex = 25;
            // 
            // cbTicketBorrower
            // 
            cbTicketBorrower.FormattingEnabled = true;
            cbTicketBorrower.Location = new Point(184, 174);
            cbTicketBorrower.Name = "cbTicketBorrower";
            cbTicketBorrower.Size = new Size(215, 28);
            cbTicketBorrower.TabIndex = 24;
            // 
            // cbTicketBook
            // 
            cbTicketBook.FormattingEnabled = true;
            cbTicketBook.Location = new Point(184, 96);
            cbTicketBook.Name = "cbTicketBook";
            cbTicketBook.Size = new Size(215, 28);
            cbTicketBook.TabIndex = 23;
            // 
            // txtTicketID
            // 
            txtTicketID.Location = new Point(184, 17);
            txtTicketID.Name = "txtTicketID";
            txtTicketID.Size = new Size(215, 27);
            txtTicketID.TabIndex = 22;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label21.Location = new Point(456, 103);
            label21.Name = "label21";
            label21.Size = new Size(107, 23);
            label21.TabIndex = 21;
            label21.Text = "Return Date";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label20.Location = new Point(456, 27);
            label20.Name = "label20";
            label20.Size = new Size(128, 23);
            label20.TabIndex = 20;
            label20.Text = "Borrower Data";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label19.Location = new Point(84, 182);
            label19.Name = "label19";
            label19.Size = new Size(85, 23);
            label19.TabIndex = 19;
            label19.Text = "Borrower";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label18.Location = new Point(84, 99);
            label18.Name = "label18";
            label18.Size = new Size(51, 23);
            label18.TabIndex = 18;
            label18.Text = "Book";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label17.Location = new Point(331, 301);
            label17.Name = "label17";
            label17.Size = new Size(185, 38);
            label17.TabIndex = 17;
            label17.Text = "List of Ticket";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(889, 602);
            Controls.Add(tabControl1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTickets).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private DataGridView dgvBooks;
        private DateTimePicker dtpBookPublishingDate;
        private ComboBox cbBookPublisher;
        private ComboBox cbBookCategory;
        private TextBox txtBookName;
        private TextBox txtBookID;
        private ComboBox cbBookAuthor;
        private Label label1;
        private Label label22;
        private DataGridView dgvTickets;
        private DateTimePicker dtpReturnDate;
        private DateTimePicker dtpBorrowDate;
        private ComboBox cbTicketBorrower;
        private ComboBox cbTicketBook;
        private TextBox txtTicketID;
        private Label label21;
        private Label label20;
        private Label label19;
        private Label label18;
        private Label label17;
        private Button button1;
    }
}