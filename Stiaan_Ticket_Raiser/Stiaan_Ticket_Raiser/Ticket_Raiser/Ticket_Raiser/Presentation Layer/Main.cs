using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ticket_Raiser.Data_Layer;

namespace Ticket_Raiser.Presentation_Layer
{
    public partial class Main : Form
    {
        
        public Main()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            DataHandler dataHandler = new DataHandler();
            dataHandler.mainReload(dgvNewTickets, dgvCompletedTickets);
        }

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataHandler dataHandler = new DataHandler();
            if (e.ColumnIndex == 5 && e.RowIndex >= 0)
            {

                //MessageBox.Show("Button clicked in row " + e.RowIndex);

                string path = @"CompletedTickets.txt";
                List<string> arr = new List<string>();

                DataGridViewRow clickedRow = dgvNewTickets.Rows[e.RowIndex];

                arr.Add(clickedRow.Cells["Ticket_ID"].Value.ToString());
                arr.Add(clickedRow.Cells["Name1"].Value.ToString());
                arr.Add(clickedRow.Cells["Surname1"].Value.ToString());
                arr.Add(clickedRow.Cells["Description1"].Value.ToString());
                arr.Add(clickedRow.Cells["Balance1"].Value.ToString());
                
                dataHandler.AddTickets(path, arr);
                dataHandler.deleteFromFile(@"NewTickets.txt", clickedRow.Cells["Ticket_ID"].Value.ToString());
                dataHandler.mainReload(dgvNewTickets, dgvCompletedTickets);
            }
        }

        

        private void button7_Click(object sender, EventArgs e)
        {
            AddnewUser  addnewUser = new AddnewUser();
            addnewUser.Show();
        }

        private void dgvCompletedTickets_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
