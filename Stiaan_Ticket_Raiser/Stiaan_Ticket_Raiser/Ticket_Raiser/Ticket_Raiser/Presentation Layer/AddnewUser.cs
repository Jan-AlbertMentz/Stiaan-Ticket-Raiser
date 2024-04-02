using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ticket_Raiser.Data_Layer;

namespace Ticket_Raiser.Presentation_Layer
{
    public partial class AddnewUser : Form
    {
        public AddnewUser()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
         
            string description;
            float balance;
            bool completed;
            string personName;
            string personSurname;
            int id;

            id = int.Parse(edtID.Text);
            personName = edtName.Text;
            personSurname = edtSurname.Text;
            description = edtDescription.Text;
            balance = float.Parse(edtBalance.Text);
            completed = false;

            string path = @"NewTickets.txt";
            List<string> arr = new List<string>();

            arr.Add(id.ToString());
            arr.Add(personName);
            arr.Add(personSurname);
            arr.Add(description);
            arr.Add(balance.ToString());
            arr.Add(completed.ToString());

            DataHandler dataHandler = new DataHandler();

            dataHandler.AddTickets(path, arr);

            this.Close();

        }
    }
}
