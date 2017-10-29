namespace SA45Group3CA2
{
    partial class Home
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
            this.Rental = new System.Windows.Forms.Button();
            this.Return = new System.Windows.Forms.Button();
            this.Enquiry = new System.Windows.Forms.Button();
            this.ManageCustomer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Rental
            // 
            this.Rental.Location = new System.Drawing.Point(110, 389);
            this.Rental.Name = "Rental";
            this.Rental.Size = new System.Drawing.Size(75, 21);
            this.Rental.TabIndex = 0;
            this.Rental.Text = "Rental";
            this.Rental.UseVisualStyleBackColor = true;
            this.Rental.Click += new System.EventHandler(this.Rental_Click);
            // 
            // Return
            // 
            this.Return.Location = new System.Drawing.Point(265, 388);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(75, 21);
            this.Return.TabIndex = 1;
            this.Return.Text = "Return";
            this.Return.UseVisualStyleBackColor = true;
            this.Return.Click += new System.EventHandler(this.Return_Click);
            // 
            // Enquiry
            // 
            this.Enquiry.Location = new System.Drawing.Point(464, 389);
            this.Enquiry.Name = "Enquiry";
            this.Enquiry.Size = new System.Drawing.Size(75, 21);
            this.Enquiry.TabIndex = 2;
            this.Enquiry.Text = "Enquiry";
            this.Enquiry.UseVisualStyleBackColor = true;
            this.Enquiry.Click += new System.EventHandler(this.Enquiry_Click);
            // 
            // ManageCustomer
            // 
            this.ManageCustomer.Location = new System.Drawing.Point(536, 103);
            this.ManageCustomer.Name = "ManageCustomer";
            this.ManageCustomer.Size = new System.Drawing.Size(119, 23);
            this.ManageCustomer.TabIndex = 3;
            this.ManageCustomer.Text = "ManageCustomer";
            this.ManageCustomer.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 510);
            this.Controls.Add(this.ManageCustomer);
            this.Controls.Add(this.Enquiry);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.Rental);
            this.Name = "Home";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Rental;
        private System.Windows.Forms.Button Return;
        private System.Windows.Forms.Button Enquiry;
        private System.Windows.Forms.Button ManageCustomer;
    }
}

