namespace ASM2_DATA
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label23 = new Label();
            cbBookAuthor = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvBooks = new DataGridView();
            dtpBookPublishingDate = new DateTimePicker();
            cbBookPublisher = new ComboBox();
            cbBookCategory = new ComboBox();
            txtBookName = new TextBox();
            txtBookID = new TextBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            tabPage2 = new TabPage();
            dtpBorrowerDOB = new DateTimePicker();
            dgvBorrowers = new DataGridView();
            txtBorrowerEmail = new TextBox();
            txtBorrowerPhone = new TextBox();
            txtBorrowerAddress = new TextBox();
            txtBorrowerName = new TextBox();
            txtBorrowerID = new TextBox();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            tabPage3 = new TabPage();
            label22 = new Label();
            dgvTickets = new DataGridView();
            button12 = new Button();
            button11 = new Button();
            button10 = new Button();
            button9 = new Button();
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
            label16 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBorrowers).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTickets).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163, true);
            tabControl1.Location = new Point(3, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(927, 696);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label23);
            tabPage1.Controls.Add(cbBookAuthor);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(dgvBooks);
            tabPage1.Controls.Add(dtpBookPublishingDate);
            tabPage1.Controls.Add(cbBookPublisher);
            tabPage1.Controls.Add(cbBookCategory);
            tabPage1.Controls.Add(txtBookName);
            tabPage1.Controls.Add(txtBookID);
            tabPage1.Controls.Add(button4);
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(button1);
            tabPage1.ForeColor = SystemColors.ActiveCaptionText;
            tabPage1.Location = new Point(4, 37);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(919, 655);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Manage Book";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label23.Location = new Point(104, 271);
            label23.Name = "label23";
            label23.Size = new Size(66, 23);
            label23.TabIndex = 19;
            label23.Text = "Author";
            // 
            // cbBookAuthor
            // 
            cbBookAuthor.FormattingEnabled = true;
            cbBookAuthor.Location = new Point(191, 270);
            cbBookAuthor.Name = "cbBookAuthor";
            cbBookAuthor.Size = new Size(223, 36);
            cbBookAuthor.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label7.Location = new Point(420, 205);
            label7.Name = "label7";
            label7.Size = new Size(137, 23);
            label7.TabIndex = 16;
            label7.Text = "Publishing Date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label6.Location = new Point(420, 127);
            label6.Name = "label6";
            label6.Size = new Size(84, 23);
            label6.TabIndex = 15;
            label6.Text = "Publisher";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label5.Location = new Point(101, 337);
            label5.Name = "label5";
            label5.Size = new Size(84, 23);
            label5.TabIndex = 14;
            label5.Text = "Category";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label4.Location = new Point(104, 199);
            label4.Name = "label4";
            label4.Size = new Size(57, 23);
            label4.TabIndex = 13;
            label4.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label3.Location = new Point(103, 127);
            label3.Name = "label3";
            label3.Size = new Size(28, 23);
            label3.TabIndex = 12;
            label3.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label2.Location = new Point(371, 422);
            label2.Name = "label2";
            label2.Size = new Size(186, 38);
            label2.TabIndex = 11;
            label2.Text = "List of Books";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(317, 41);
            label1.Name = "label1";
            label1.Size = new Size(268, 38);
            label1.TabIndex = 10;
            label1.Text = "Book Management";
            // 
            // dgvBooks
            // 
            dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBooks.Location = new Point(0, 480);
            dgvBooks.Name = "dgvBooks";
            dgvBooks.RowHeadersWidth = 51;
            dgvBooks.Size = new Size(919, 188);
            dgvBooks.TabIndex = 9;
            dgvBooks.CellContentClick += dgvBooks_CellContentClick;
            // 
            // dtpBookPublishingDate
            // 
            dtpBookPublishingDate.Location = new Point(601, 199);
            dtpBookPublishingDate.Name = "dtpBookPublishingDate";
            dtpBookPublishingDate.Size = new Size(223, 34);
            dtpBookPublishingDate.TabIndex = 8;
            // 
            // cbBookPublisher
            // 
            cbBookPublisher.FormattingEnabled = true;
            cbBookPublisher.Location = new Point(601, 127);
            cbBookPublisher.Name = "cbBookPublisher";
            cbBookPublisher.Size = new Size(223, 36);
            cbBookPublisher.TabIndex = 7;
            // 
            // cbBookCategory
            // 
            cbBookCategory.FormattingEnabled = true;
            cbBookCategory.Location = new Point(191, 332);
            cbBookCategory.Name = "cbBookCategory";
            cbBookCategory.Size = new Size(223, 36);
            cbBookCategory.TabIndex = 6;
            // 
            // txtBookName
            // 
            txtBookName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtBookName.Location = new Point(191, 195);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(223, 27);
            txtBookName.TabIndex = 5;
            // 
            // txtBookID
            // 
            txtBookID.Location = new Point(191, 128);
            txtBookID.Name = "txtBookID";
            txtBookID.Size = new Size(223, 34);
            txtBookID.TabIndex = 4;
            txtBookID.TextChanged += txtBookID_TextChanged;
            // 
            // button4
            // 
            button4.Location = new Point(676, 373);
            button4.Name = "button4";
            button4.Size = new Size(94, 46);
            button4.TabIndex = 3;
            button4.Text = "Clear Date";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(518, 373);
            button3.Name = "button3";
            button3.Size = new Size(94, 46);
            button3.TabIndex = 2;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(676, 289);
            button2.Name = "button2";
            button2.Size = new Size(94, 41);
            button2.TabIndex = 1;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(518, 289);
            button1.Name = "button1";
            button1.Size = new Size(94, 41);
            button1.TabIndex = 0;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dtpBorrowerDOB);
            tabPage2.Controls.Add(dgvBorrowers);
            tabPage2.Controls.Add(txtBorrowerEmail);
            tabPage2.Controls.Add(txtBorrowerPhone);
            tabPage2.Controls.Add(txtBorrowerAddress);
            tabPage2.Controls.Add(txtBorrowerName);
            tabPage2.Controls.Add(txtBorrowerID);
            tabPage2.Controls.Add(button8);
            tabPage2.Controls.Add(button7);
            tabPage2.Controls.Add(button6);
            tabPage2.Controls.Add(button5);
            tabPage2.Controls.Add(label15);
            tabPage2.Controls.Add(label14);
            tabPage2.Controls.Add(label13);
            tabPage2.Controls.Add(label12);
            tabPage2.Controls.Add(label11);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(label8);
            tabPage2.ForeColor = SystemColors.ActiveCaptionText;
            tabPage2.Location = new Point(4, 37);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(919, 655);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Manage Borrower";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dtpBorrowerDOB
            // 
            dtpBorrowerDOB.Location = new Point(535, 202);
            dtpBorrowerDOB.Name = "dtpBorrowerDOB";
            dtpBorrowerDOB.Size = new Size(224, 34);
            dtpBorrowerDOB.TabIndex = 18;
            // 
            // dgvBorrowers
            // 
            dgvBorrowers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBorrowers.Location = new Point(0, 463);
            dgvBorrowers.Name = "dgvBorrowers";
            dgvBorrowers.RowHeadersWidth = 51;
            dgvBorrowers.Size = new Size(919, 188);
            dgvBorrowers.TabIndex = 17;
            dgvBorrowers.CellContentClick += dgvBorrowers_CellContentClick;
            // 
            // txtBorrowerEmail
            // 
            txtBorrowerEmail.Location = new Point(535, 131);
            txtBorrowerEmail.Name = "txtBorrowerEmail";
            txtBorrowerEmail.Size = new Size(224, 34);
            txtBorrowerEmail.TabIndex = 16;
            // 
            // txtBorrowerPhone
            // 
            txtBorrowerPhone.Location = new Point(191, 343);
            txtBorrowerPhone.Name = "txtBorrowerPhone";
            txtBorrowerPhone.Size = new Size(223, 34);
            txtBorrowerPhone.TabIndex = 15;
            // 
            // txtBorrowerAddress
            // 
            txtBorrowerAddress.Location = new Point(191, 279);
            txtBorrowerAddress.Name = "txtBorrowerAddress";
            txtBorrowerAddress.Size = new Size(223, 34);
            txtBorrowerAddress.TabIndex = 14;
            // 
            // txtBorrowerName
            // 
            txtBorrowerName.Location = new Point(191, 202);
            txtBorrowerName.Name = "txtBorrowerName";
            txtBorrowerName.Size = new Size(223, 34);
            txtBorrowerName.TabIndex = 13;
            // 
            // txtBorrowerID
            // 
            txtBorrowerID.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtBorrowerID.Location = new Point(191, 128);
            txtBorrowerID.Name = "txtBorrowerID";
            txtBorrowerID.Size = new Size(223, 27);
            txtBorrowerID.TabIndex = 12;
            // 
            // button8
            // 
            button8.Location = new Point(653, 343);
            button8.Name = "button8";
            button8.Size = new Size(94, 34);
            button8.TabIndex = 11;
            button8.Text = "Clear Data";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.Location = new Point(514, 343);
            button7.Name = "button7";
            button7.Size = new Size(94, 34);
            button7.TabIndex = 10;
            button7.Text = "Delete";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.Location = new Point(653, 279);
            button6.Name = "button6";
            button6.Size = new Size(94, 38);
            button6.TabIndex = 9;
            button6.Text = "Update";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Location = new Point(514, 278);
            button5.Name = "button5";
            button5.Size = new Size(94, 35);
            button5.TabIndex = 8;
            button5.Text = "Add";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label15.Location = new Point(447, 202);
            label15.Name = "label15";
            label15.Size = new Size(47, 23);
            label15.TabIndex = 7;
            label15.Text = "DOB";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label14.Location = new Point(447, 131);
            label14.Name = "label14";
            label14.Size = new Size(54, 23);
            label14.TabIndex = 6;
            label14.Text = "Email";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label13.Location = new Point(103, 352);
            label13.Name = "label13";
            label13.Size = new Size(59, 23);
            label13.TabIndex = 5;
            label13.Text = "Phone";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label12.Location = new Point(103, 282);
            label12.Name = "label12";
            label12.Size = new Size(74, 23);
            label12.TabIndex = 4;
            label12.Text = "Address";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label11.Location = new Point(103, 205);
            label11.Name = "label11";
            label11.Size = new Size(57, 23);
            label11.TabIndex = 3;
            label11.Text = "Name";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label10.Location = new Point(103, 131);
            label10.Name = "label10";
            label10.Size = new Size(28, 23);
            label10.TabIndex = 2;
            label10.Text = "ID";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label9.Location = new Point(319, 395);
            label9.Name = "label9";
            label9.Size = new Size(228, 38);
            label9.TabIndex = 1;
            label9.Text = "List of Borrower";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label8.Location = new Point(307, 55);
            label8.Name = "label8";
            label8.Size = new Size(321, 38);
            label8.TabIndex = 0;
            label8.Text = "Borrower management";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label22);
            tabPage3.Controls.Add(dgvTickets);
            tabPage3.Controls.Add(button12);
            tabPage3.Controls.Add(button11);
            tabPage3.Controls.Add(button10);
            tabPage3.Controls.Add(button9);
            tabPage3.Controls.Add(dtpReturnDate);
            tabPage3.Controls.Add(dtpBorrowDate);
            tabPage3.Controls.Add(cbTicketBorrower);
            tabPage3.Controls.Add(cbTicketBook);
            tabPage3.Controls.Add(txtTicketID);
            tabPage3.Controls.Add(label21);
            tabPage3.Controls.Add(label20);
            tabPage3.Controls.Add(label19);
            tabPage3.Controls.Add(label18);
            tabPage3.Controls.Add(label17);
            tabPage3.Controls.Add(label16);
            tabPage3.ForeColor = SystemColors.ActiveCaptionText;
            tabPage3.Location = new Point(4, 37);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(919, 655);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Manage Ticket";
            tabPage3.UseVisualStyleBackColor = true;
            tabPage3.Click += tabPage3_Click;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label22.Location = new Point(103, 132);
            label22.Name = "label22";
            label22.Size = new Size(28, 23);
            label22.TabIndex = 16;
            label22.Text = "ID";
            // 
            // dgvTickets
            // 
            dgvTickets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTickets.Location = new Point(0, 469);
            dgvTickets.Name = "dgvTickets";
            dgvTickets.RowHeadersWidth = 51;
            dgvTickets.Size = new Size(919, 188);
            dgvTickets.TabIndex = 15;
            dgvTickets.CellContentClick += dgvTickets_CellContentClick;
            // 
            // button12
            // 
            button12.Location = new Point(679, 331);
            button12.Name = "button12";
            button12.Size = new Size(94, 46);
            button12.TabIndex = 14;
            button12.Text = "Clear Date";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // button11
            // 
            button11.Location = new Point(530, 331);
            button11.Name = "button11";
            button11.Size = new Size(94, 46);
            button11.TabIndex = 13;
            button11.Text = "Delete";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // button10
            // 
            button10.Location = new Point(679, 271);
            button10.Name = "button10";
            button10.Size = new Size(94, 37);
            button10.TabIndex = 12;
            button10.Text = "Update";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button9
            // 
            button9.Location = new Point(530, 271);
            button9.Name = "button9";
            button9.Size = new Size(94, 37);
            button9.TabIndex = 11;
            button9.Text = "Add";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // dtpReturnDate
            // 
            dtpReturnDate.Location = new Point(609, 202);
            dtpReturnDate.Name = "dtpReturnDate";
            dtpReturnDate.Size = new Size(250, 34);
            dtpReturnDate.TabIndex = 10;
            // 
            // dtpBorrowDate
            // 
            dtpBorrowDate.Location = new Point(609, 127);
            dtpBorrowDate.Name = "dtpBorrowDate";
            dtpBorrowDate.Size = new Size(250, 34);
            dtpBorrowDate.TabIndex = 9;
            // 
            // cbTicketBorrower
            // 
            cbTicketBorrower.FormattingEnabled = true;
            cbTicketBorrower.Location = new Point(203, 277);
            cbTicketBorrower.Name = "cbTicketBorrower";
            cbTicketBorrower.Size = new Size(215, 36);
            cbTicketBorrower.TabIndex = 8;
            // 
            // cbTicketBook
            // 
            cbTicketBook.FormattingEnabled = true;
            cbTicketBook.Location = new Point(203, 199);
            cbTicketBook.Name = "cbTicketBook";
            cbTicketBook.Size = new Size(215, 36);
            cbTicketBook.TabIndex = 7;
            // 
            // txtTicketID
            // 
            txtTicketID.Location = new Point(203, 120);
            txtTicketID.Name = "txtTicketID";
            txtTicketID.Size = new Size(215, 34);
            txtTicketID.TabIndex = 6;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label21.Location = new Point(475, 206);
            label21.Name = "label21";
            label21.Size = new Size(107, 23);
            label21.TabIndex = 5;
            label21.Text = "Return Date";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label20.Location = new Point(475, 130);
            label20.Name = "label20";
            label20.Size = new Size(128, 23);
            label20.TabIndex = 4;
            label20.Text = "Borrower Data";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label19.Location = new Point(103, 285);
            label19.Name = "label19";
            label19.Size = new Size(85, 23);
            label19.TabIndex = 3;
            label19.Text = "Borrower";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label18.Location = new Point(103, 202);
            label18.Name = "label18";
            label18.Size = new Size(51, 23);
            label18.TabIndex = 2;
            label18.Text = "Book";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label17.Location = new Point(350, 404);
            label17.Name = "label17";
            label17.Size = new Size(185, 38);
            label17.TabIndex = 1;
            label17.Text = "List of Ticket";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label16.Location = new Point(312, 40);
            label16.Name = "label16";
            label16.Size = new Size(270, 38);
            label16.TabIndex = 0;
            label16.Text = "Ticket Managenent";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(931, 695);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBorrowers).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTickets).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox txtBookName;
        private TextBox txtBookID;
        private DataGridView dgvBooks;
        private DateTimePicker dtpBookPublishingDate;
        private ComboBox cbBookPublisher;
        private ComboBox cbBookCategory;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtBorrowerName;
        private TextBox txtBorrowerID;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private DateTimePicker dtpBorrowerDOB;
        private DataGridView dgvBorrowers;
        private TextBox txtBorrowerEmail;
        private TextBox txtBorrowerPhone;
        private TextBox txtBorrowerAddress;
        private DataGridView dgvTickets;
        private Button button12;
        private Button button11;
        private Button button10;
        private Button button9;
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
        private Label label16;
        private Label label22;
        private ComboBox cbBookAuthor;
        private Label label23;
    }
}
