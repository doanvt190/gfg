using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ASM2_DATA
{
    public partial class Form2 : Form
    {
        SqlConnection conn;
        public Form2()
        {
            InitializeComponent();
            conn = new SqlConnection("server = ĐOÀN; database = LibraryManagement1; integrated security = true");
        }
        public Form2(string username)
        {
            InitializeComponent();
            conn = new SqlConnection("server = ĐOÀN; database = LibraryManagement1; integrated security = true");
            MessageBox.Show("Welcome " + username);
        }
        public void GetAuthors()
        {
            string query = "select author_id, author_name from Authors";
            DataTable table = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
            dataAdapter.Fill(table);
            cbBookAuthor.DataSource = table;
            cbBookAuthor.DisplayMember = "author_name";
            cbBookAuthor.ValueMember = "author_id";
        }

        public void GetCategories()
        {
            string query = "select category_id, category_name from Categories";
            DataTable table = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
            dataAdapter.Fill(table);
            cbBookCategory.DataSource = table;
            cbBookCategory.DisplayMember = "category_name";
            cbBookCategory.ValueMember = "category_id";
        }

        public void GetPublishers()
        {
            string query = "select publisher_id, publisher_name from Publishers";
            DataTable table = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
            dataAdapter.Fill(table);
            cbBookPublisher.DataSource = table;
            cbBookPublisher.DisplayMember = "publisher_name";
            cbBookPublisher.ValueMember = "publisher_id";
        }

        public void GetBooks()
        {
            string query = "select book_id, book_name from Books";
            DataTable table = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
            dataAdapter.Fill(table);
            cbTicketBook.DataSource = table;
            cbTicketBook.DisplayMember = "book_name";
            cbTicketBook.ValueMember = "book_id";
        }
        public void GetBorrowers()
        {
            string query = "select borrower_id, borrower_name from Borrowers";
            DataTable table = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
            dataAdapter.Fill(table);
            cbTicketBorrower.DataSource = table;
            cbTicketBorrower.DisplayMember = "borrower_name";
            cbTicketBorrower.ValueMember = "borrower_id";
        }

        public void FillDataBooks()
        {
            string query = "select * from Books";
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, conn);
            sqlDataAdapter.Fill(dataTable);
            dgvBooks.DataSource = dataTable;
        }

        public void ClearDataBooks()
        {
            txtBookID.Text = "";
            txtBookName.Text = "";
            cbBookAuthor.Text = "";
            cbBookCategory.Text = "";
            cbBookPublisher.Text = "";
        }

        public void FillDataTickets()
        {
            string query = "select * from Tickets";
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, conn);
            sqlDataAdapter.Fill(dataTable);
            dgvTickets.DataSource = dataTable;
        }

        public void ClearDataTickets()
        {
            txtTicketID.Text = "";
            cbTicketBook.Text = "";
            cbTicketBorrower.Text = "";
        }





        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            GetAuthors();
            GetCategories();
            GetPublishers();
            GetBooks();
            GetBorrowers();
            FillDataTickets();
            FillDataBooks();
        }

        private void dgvBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvBooks.Rows[e.RowIndex];
                txtBookID.Text = row.Cells["book_id"].Value.ToString();
                txtBookName.Text = row.Cells["book name"].Value.ToString();
                cbBookAuthor.SelectedValue = row.Cells["author_id"].Value.ToString();
                cbBookCategory.SelectedValue = row.Cells["category_id"].Value.ToString();
                cbBookPublisher.SelectedValue = row.Cells["publisher_id"].Value.ToString();
                dtpBookPublishingDate.Value = (DateTime)row.Cells["publishing_date"].Value;
            }
        }

        private void dgvTickets_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvTickets.Rows[e.RowIndex];
                txtTicketID.Text = row.Cells["ticket_id"].Value.ToString();
                cbTicketBook.SelectedValue = row.Cells["book_id"].Value.ToString();
                cbTicketBorrower.SelectedValue = row.Cells["borrower_id"].Value.ToString();
                dtpBorrowDate.Value = (DateTime)row.Cells["borrow_date"].Value;
                dtpReturnDate.Value = (DateTime)row.Cells["return_date"].Value;
            }
        }

        
        
    }
}
