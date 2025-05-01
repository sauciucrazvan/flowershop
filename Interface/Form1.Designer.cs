namespace Interface
{
    partial class Form1
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
            this.flowershop_details = new System.Windows.Forms.Label();
            this.btnShowEmployees = new System.Windows.Forms.Button();
            this.btnShowStock = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddFlower = new System.Windows.Forms.Button();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.flowershop_name = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowershop_details
            // 
            this.flowershop_details.AutoSize = true;
            this.flowershop_details.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.flowershop_details.Location = new System.Drawing.Point(17, 41);
            this.flowershop_details.Name = "flowershop_details";
            this.flowershop_details.Size = new System.Drawing.Size(141, 20);
            this.flowershop_details.TabIndex = 0;
            this.flowershop_details.Text = "flowershop_details";
            // 
            // btnShowEmployees
            // 
            this.btnShowEmployees.Location = new System.Drawing.Point(21, 105);
            this.btnShowEmployees.Name = "btnShowEmployees";
            this.btnShowEmployees.Size = new System.Drawing.Size(200, 49);
            this.btnShowEmployees.TabIndex = 1;
            this.btnShowEmployees.Text = "Show Employees";
            this.btnShowEmployees.UseVisualStyleBackColor = true;
            this.btnShowEmployees.Click += new System.EventHandler(this.btnShowEmployees_Click);
            // 
            // btnShowStock
            // 
            this.btnShowStock.Location = new System.Drawing.Point(21, 160);
            this.btnShowStock.Name = "btnShowStock";
            this.btnShowStock.Size = new System.Drawing.Size(200, 49);
            this.btnShowStock.TabIndex = 3;
            this.btnShowStock.Text = "Show Stock";
            this.btnShowStock.UseVisualStyleBackColor = true;
            this.btnShowStock.Click += new System.EventHandler(this.btnShowStock_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.btnAddFlower);
            this.groupBox1.Controls.Add(this.btnAddEmployee);
            this.groupBox1.Controls.Add(this.flowershop_name);
            this.groupBox1.Controls.Add(this.btnShowEmployees);
            this.groupBox1.Controls.Add(this.btnShowStock);
            this.groupBox1.Controls.Add(this.flowershop_details);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 425);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnAddFlower
            // 
            this.btnAddFlower.Location = new System.Drawing.Point(21, 270);
            this.btnAddFlower.Name = "btnAddFlower";
            this.btnAddFlower.Size = new System.Drawing.Size(200, 49);
            this.btnAddFlower.TabIndex = 6;
            this.btnAddFlower.Text = "Add Flower";
            this.btnAddFlower.UseVisualStyleBackColor = true;
            this.btnAddFlower.Click += new System.EventHandler(this.btnAddFlower_Click);
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Location = new System.Drawing.Point(21, 215);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(200, 49);
            this.btnAddEmployee.TabIndex = 5;
            this.btnAddEmployee.Text = "Add Employee";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // flowershop_name
            // 
            this.flowershop_name.AutoSize = true;
            this.flowershop_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.flowershop_name.Location = new System.Drawing.Point(17, 0);
            this.flowershop_name.Name = "flowershop_name";
            this.flowershop_name.Size = new System.Drawing.Size(135, 20);
            this.flowershop_name.TabIndex = 4;
            this.flowershop_name.Text = "flowershop_name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(266, 447);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Flowershop!";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label flowershop_details;
        private System.Windows.Forms.Button btnShowEmployees;
        private System.Windows.Forms.Button btnShowStock;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label flowershop_name;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Button btnAddFlower;
    }
}

