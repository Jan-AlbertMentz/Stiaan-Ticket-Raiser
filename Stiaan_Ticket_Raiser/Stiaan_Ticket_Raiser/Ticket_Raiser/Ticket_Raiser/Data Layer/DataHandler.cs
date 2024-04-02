using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ticket_Raiser.Presentation_Layer;

namespace Ticket_Raiser.Data_Layer
{
    internal class DataHandler : Main
    {

        public void AddTickets(string path, List<string> arr)
        {
            string final = "";
            using (StreamWriter writer = new StreamWriter(path, true))
            {

                foreach (string line in arr)
                {
                    final = final + ',' + line;
                    
                }
                final = final.Remove(0,1);
                writer.WriteLine(final);

                

            }
            MessageBox.Show("Ticket Added Successfully");

        }

        public void AddCompleteTickets(string path, string text)
        {            
            using (StreamWriter writer = new StreamWriter(path, true))
            {                             
                writer.WriteLine(text);
            }
            MessageBox.Show("Ticket Added Successfully");

        }

        public void AddNeedsYourAttention(string path, string text)
        {
            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.WriteLine(text);
            }
            MessageBox.Show("Ticket Added Successfully");

        }

        public void deleteFromFile(string path, string index)
        {

            try
            {
                List<string> lines = new List<string>(File.ReadAllLines(path));

                for (int i = 0; i < lines.Count; i++)
                {
                    if (lines[i][0].ToString() == index)
                    {
                        if (lines.Count == 1)
                        {
                            lines.Clear();
                            File.WriteAllLines(path, lines);
                        }
                        else
                        {
                            lines.RemoveAt(i);
                        }
                    }
                }
                File.WriteAllLines(path, lines);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting lines: " + ex.Message);
            }
        }

        public void mainReload( DataGridView dgv1, DataGridView dgv2)
        {
            
            dgv1.Rows.Clear(); // Clear existing rows
            dgv2.Rows.Clear();
            

            try
            {
                using (StreamReader reader = new StreamReader(@"NewTickets.txt"))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        line = line.Replace("False", string.Empty);
                        line = line + "Complete";

                        string[] parts = line.Split(',');

                        dgv1.Rows.Add(parts);
                    }
                }

                using (StreamReader reader = new StreamReader(@"CompletedTickets.txt"))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        line = line.Replace("False", string.Empty);


                        string[] parts = line.Split(',');

                        dgv2.Rows.Add(parts);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading the file: " + ex.Message);
            }

         
        }
    }
}
