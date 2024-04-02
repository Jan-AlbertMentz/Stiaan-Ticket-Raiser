namespace Ticket_Raiser.Presentation_Layer
{
    partial class Main
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvNewTickets = new System.Windows.Forms.DataGridView();
            this.Ticket_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Balance1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Complete1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button7 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvCompletedTickets = new System.Windows.Forms.DataGridView();
            this.CompleteID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompleteName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompleteSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompleteDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompleteBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNewTickets)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompletedTickets)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 1281);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Fuchsia;
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ticket Raiser";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dgvNewTickets);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(266, 132);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(628, 1116);
            this.panel2.TabIndex = 2;
            // 
            // dgvNewTickets
            // 
            this.dgvNewTickets.AccessibleName = "dgvNewTicketsGlobal";
            this.dgvNewTickets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNewTickets.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvNewTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNewTickets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ticket_ID,
            this.Name1,
            this.Surname1,
            this.Description1,
            this.Balance1,
            this.Complete1});
            this.dgvNewTickets.Location = new System.Drawing.Point(16, 84);
            this.dgvNewTickets.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvNewTickets.Name = "dgvNewTickets";
            this.dgvNewTickets.RowHeadersWidth = 51;
            this.dgvNewTickets.Size = new System.Drawing.Size(594, 1007);
            this.dgvNewTickets.TabIndex = 8;
            this.dgvNewTickets.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Ticket_ID
            // 
            this.Ticket_ID.HeaderText = "Ticket ID";
            this.Ticket_ID.MinimumWidth = 6;
            this.Ticket_ID.Name = "Ticket_ID";
            // 
            // Name1
            // 
            this.Name1.HeaderText = "Name";
            this.Name1.MinimumWidth = 6;
            this.Name1.Name = "Name1";
            // 
            // Surname1
            // 
            this.Surname1.HeaderText = "Surname";
            this.Surname1.MinimumWidth = 6;
            this.Surname1.Name = "Surname1";
            // 
            // Description1
            // 
            this.Description1.HeaderText = "Description";
            this.Description1.MinimumWidth = 6;
            this.Description1.Name = "Description1";
            // 
            // Balance1
            // 
            this.Balance1.HeaderText = "Balance";
            this.Balance1.MinimumWidth = 6;
            this.Balance1.Name = "Balance1";
            // 
            // Complete1
            // 
            this.Complete1.HeaderText = "Complete";
            this.Complete1.MinimumWidth = 6;
            this.Complete1.Name = "Complete1";
            this.Complete1.Text = "Complete";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(433, 27);
            this.button7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(177, 41);
            this.button7.TabIndex = 7;
            this.button7.Text = "Add New User";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(9, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "New People";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(9, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 36);
            this.label3.TabIndex = 5;
            this.label3.Text = "Completed";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.dgvCompletedTickets);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(902, 132);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(502, 1116);
            this.panel3.TabIndex = 9;
            // 
            // dgvCompletedTickets
            // 
            this.dgvCompletedTickets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCompletedTickets.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvCompletedTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompletedTickets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CompleteID,
            this.CompleteName,
            this.CompleteSurname,
            this.CompleteDescription,
            this.CompleteBalance});
            this.dgvCompletedTickets.Location = new System.Drawing.Point(15, 84);
            this.dgvCompletedTickets.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvCompletedTickets.Name = "dgvCompletedTickets";
            this.dgvCompletedTickets.RowHeadersWidth = 51;
            this.dgvCompletedTickets.Size = new System.Drawing.Size(469, 1007);
            this.dgvCompletedTickets.TabIndex = 9;
            this.dgvCompletedTickets.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCompletedTickets_CellContentClick);
            // 
            // CompleteID
            // 
            this.CompleteID.HeaderText = "Ticket ID";
            this.CompleteID.MinimumWidth = 6;
            this.CompleteID.Name = "CompleteID";
            // 
            // CompleteName
            // 
            this.CompleteName.HeaderText = "Name";
            this.CompleteName.MinimumWidth = 6;
            this.CompleteName.Name = "CompleteName";
            // 
            // CompleteSurname
            // 
            this.CompleteSurname.HeaderText = "Surname";
            this.CompleteSurname.MinimumWidth = 6;
            this.CompleteSurname.Name = "CompleteSurname";
            // 
            // CompleteDescription
            // 
            this.CompleteDescription.HeaderText = "Description";
            this.CompleteDescription.MinimumWidth = 6;
            this.CompleteDescription.Name = "CompleteDescription";
            // 
            // CompleteBalance
            // 
            this.CompleteBalance.HeaderText = "Balance";
            this.CompleteBalance.MinimumWidth = 6;
            this.CompleteBalance.Name = "CompleteBalance";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(1412, 132);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(499, 1116);
            this.panel4.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dataGridView1.Location = new System.Drawing.Point(15, 84);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(469, 1007);
            this.dataGridView1.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Ticket ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Surname";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Description";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Balance";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(9, 26);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(405, 36);
            this.label4.TabIndex = 5;
            this.label4.Text = "NEEDS YOUR ATTENTION!!";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Main";
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNewTickets)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompletedTickets)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.DataGridView dgvNewTickets;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ticket_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Balance1;
        private System.Windows.Forms.DataGridViewButtonColumn Complete1;
        private System.Windows.Forms.DataGridView dgvCompletedTickets;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompleteID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompleteName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompleteSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompleteDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompleteBalance;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label label4;
    }
}