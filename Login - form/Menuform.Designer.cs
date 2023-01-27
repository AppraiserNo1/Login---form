namespace Login___form
{
    partial class Menuform
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
            this.button_product = new System.Windows.Forms.Button();
            this.button_user = new System.Windows.Forms.Button();
            this.button_customer = new System.Windows.Forms.Button();
            this.button_logout = new System.Windows.Forms.Button();
            this.dbnametxt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_product
            // 
            this.button_product.Location = new System.Drawing.Point(134, 153);
            this.button_product.Name = "button_product";
            this.button_product.Size = new System.Drawing.Size(145, 70);
            this.button_product.TabIndex = 0;
            this.button_product.Text = "Product";
            this.button_product.UseVisualStyleBackColor = true;
            this.button_product.Click += new System.EventHandler(this.button_product_Click);
            // 
            // button_user
            // 
            this.button_user.Location = new System.Drawing.Point(312, 153);
            this.button_user.Name = "button_user";
            this.button_user.Size = new System.Drawing.Size(145, 70);
            this.button_user.TabIndex = 1;
            this.button_user.Text = "User";
            this.button_user.UseVisualStyleBackColor = true;
            this.button_user.Click += new System.EventHandler(this.button_user_Click);
            // 
            // button_customer
            // 
            this.button_customer.Location = new System.Drawing.Point(487, 153);
            this.button_customer.Name = "button_customer";
            this.button_customer.Size = new System.Drawing.Size(145, 70);
            this.button_customer.TabIndex = 2;
            this.button_customer.Text = "Customer";
            this.button_customer.UseVisualStyleBackColor = true;
            this.button_customer.Click += new System.EventHandler(this.button_customer_Click);
            // 
            // button_logout
            // 
            this.button_logout.Location = new System.Drawing.Point(701, 18);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(87, 27);
            this.button_logout.TabIndex = 3;
            this.button_logout.Text = "Log Out";
            this.button_logout.UseVisualStyleBackColor = true;
            this.button_logout.Click += new System.EventHandler(this.button_back_Click);
            // 
            // dbnametxt
            // 
            this.dbnametxt.AutoSize = true;
            this.dbnametxt.Location = new System.Drawing.Point(649, 25);
            this.dbnametxt.Name = "dbnametxt";
            this.dbnametxt.Size = new System.Drawing.Size(35, 13);
            this.dbnametxt.TabIndex = 4;
            this.dbnametxt.Text = "label1";
            this.dbnametxt.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(602, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name :";
            // 
            // Menuform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dbnametxt);
            this.Controls.Add(this.button_logout);
            this.Controls.Add(this.button_customer);
            this.Controls.Add(this.button_user);
            this.Controls.Add(this.button_product);
            this.Name = "Menuform";
            this.Text = "Menuform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_product;
        private System.Windows.Forms.Button button_user;
        private System.Windows.Forms.Button button_customer;
        private System.Windows.Forms.Button button_logout;
        private System.Windows.Forms.Label dbnametxt;
        private System.Windows.Forms.Label label2;
    }
}