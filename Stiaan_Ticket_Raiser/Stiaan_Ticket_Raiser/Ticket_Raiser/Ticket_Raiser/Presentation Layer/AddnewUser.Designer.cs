namespace Ticket_Raiser.Presentation_Layer
{
    partial class AddnewUser
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
            this.edtName = new System.Windows.Forms.TextBox();
            this.edtSurname = new System.Windows.Forms.TextBox();
            this.edtDescription = new System.Windows.Forms.TextBox();
            this.edtBalance = new System.Windows.Forms.TextBox();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.edtID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // edtName
            // 
            this.edtName.Location = new System.Drawing.Point(131, 130);
            this.edtName.Name = "edtName";
            this.edtName.Size = new System.Drawing.Size(312, 20);
            this.edtName.TabIndex = 1;
            // 
            // edtSurname
            // 
            this.edtSurname.Location = new System.Drawing.Point(131, 187);
            this.edtSurname.Name = "edtSurname";
            this.edtSurname.Size = new System.Drawing.Size(312, 20);
            this.edtSurname.TabIndex = 2;
            // 
            // edtDescription
            // 
            this.edtDescription.Location = new System.Drawing.Point(131, 245);
            this.edtDescription.Name = "edtDescription";
            this.edtDescription.Size = new System.Drawing.Size(312, 20);
            this.edtDescription.TabIndex = 3;
            // 
            // edtBalance
            // 
            this.edtBalance.Location = new System.Drawing.Point(131, 294);
            this.edtBalance.Name = "edtBalance";
            this.edtBalance.Size = new System.Drawing.Size(312, 20);
            this.edtBalance.TabIndex = 4;
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.Location = new System.Drawing.Point(368, 337);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(75, 23);
            this.btnAddPerson.TabIndex = 5;
            this.btnAddPerson.Text = "Add Person";
            this.btnAddPerson.UseVisualStyleBackColor = true;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Surname";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Balance";
            // 
            // edtID
            // 
            this.edtID.Location = new System.Drawing.Point(131, 82);
            this.edtID.Name = "edtID";
            this.edtID.Size = new System.Drawing.Size(312, 20);
            this.edtID.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "ID";
            // 
            // AddnewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(494, 533);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.edtID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddPerson);
            this.Controls.Add(this.edtBalance);
            this.Controls.Add(this.edtDescription);
            this.Controls.Add(this.edtSurname);
            this.Controls.Add(this.edtName);
            this.Name = "AddnewUser";
            this.Text = "AddnewUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox edtName;
        private System.Windows.Forms.TextBox edtSurname;
        private System.Windows.Forms.TextBox edtDescription;
        private System.Windows.Forms.TextBox edtBalance;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox edtID;
        private System.Windows.Forms.Label label5;
    }
}