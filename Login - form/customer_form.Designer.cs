﻿namespace Login___form
{
    partial class customer_form
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
            this.button_gback = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.addbtn = new System.Windows.Forms.Button();
            this.userdataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.userdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // button_gback
            // 
            this.button_gback.Location = new System.Drawing.Point(689, 21);
            this.button_gback.Name = "button_gback";
            this.button_gback.Size = new System.Drawing.Size(87, 27);
            this.button_gback.TabIndex = 4;
            this.button_gback.Text = "Go Back";
            this.button_gback.UseVisualStyleBackColor = true;
            this.button_gback.Click += new System.EventHandler(this.button_logout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(316, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 42);
            this.label1.TabIndex = 7;
            this.label1.Text = "Customer";
            // 
            // addbtn
            // 
            this.addbtn.Location = new System.Drawing.Point(41, 66);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(69, 34);
            this.addbtn.TabIndex = 8;
            this.addbtn.Text = "+  Add";
            this.addbtn.UseVisualStyleBackColor = true;
            // 
            // userdataGridView
            // 
            this.userdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userdataGridView.Location = new System.Drawing.Point(41, 120);
            this.userdataGridView.Name = "userdataGridView";
            this.userdataGridView.Size = new System.Drawing.Size(735, 208);
            this.userdataGridView.TabIndex = 9;
            // 
            // customer_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userdataGridView);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_gback);
            this.Name = "customer_form";
            this.Text = "customer_form";
            ((System.ComponentModel.ISupportInitialize)(this.userdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_gback;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.DataGridView userdataGridView;
    }
}