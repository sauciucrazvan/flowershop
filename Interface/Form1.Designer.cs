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
            this.btnShowStock = new System.Windows.Forms.Button();
            this.btnShowEmployees = new System.Windows.Forms.Button();
            this.flowershop_name = new System.Windows.Forms.Label();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnAddFlower = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowershop_details
            // 
            this.flowershop_details.AutoSize = true;
            this.flowershop_details.ForeColor = System.Drawing.Color.Black;
            this.flowershop_details.Location = new System.Drawing.Point(178, 258);
            this.flowershop_details.Name = "flowershop_details";
            this.flowershop_details.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flowershop_details.Size = new System.Drawing.Size(141, 20);
            this.flowershop_details.TabIndex = 0;
            this.flowershop_details.Text = "flowershop_details";
            this.flowershop_details.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnShowStock
            // 
            this.btnShowStock.Location = new System.Drawing.Point(412, 151);
            this.btnShowStock.Name = "btnShowStock";
            this.btnShowStock.Size = new System.Drawing.Size(200, 49);
            this.btnShowStock.TabIndex = 3;
            this.btnShowStock.Text = "Show Stock";
            this.btnShowStock.UseVisualStyleBackColor = true;
            this.btnShowStock.Click += new System.EventHandler(this.btnShowStock_Click);
            // 
            // btnShowEmployees
            // 
            this.btnShowEmployees.Location = new System.Drawing.Point(618, 151);
            this.btnShowEmployees.Name = "btnShowEmployees";
            this.btnShowEmployees.Size = new System.Drawing.Size(200, 49);
            this.btnShowEmployees.TabIndex = 1;
            this.btnShowEmployees.Text = "Show Employees";
            this.btnShowEmployees.UseVisualStyleBackColor = true;
            this.btnShowEmployees.Click += new System.EventHandler(this.btnShowEmployees_Click);
            // 
            // flowershop_name
            // 
            this.flowershop_name.AutoSize = true;
            this.flowershop_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowershop_name.ForeColor = System.Drawing.Color.Fuchsia;
            this.flowershop_name.Location = new System.Drawing.Point(407, 111);
            this.flowershop_name.Name = "flowershop_name";
            this.flowershop_name.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flowershop_name.Size = new System.Drawing.Size(270, 37);
            this.flowershop_name.TabIndex = 4;
            this.flowershop_name.Text = "flowershop_name";
            this.flowershop_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Location = new System.Drawing.Point(201, 354);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(200, 49);
            this.btnAddEmployee.TabIndex = 5;
            this.btnAddEmployee.Text = "Add Employee";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // btnAddFlower
            // 
            this.btnAddFlower.Location = new System.Drawing.Point(412, 354);
            this.btnAddFlower.Name = "btnAddFlower";
            this.btnAddFlower.Size = new System.Drawing.Size(200, 49);
            this.btnAddFlower.TabIndex = 6;
            this.btnAddFlower.Text = "Add Flower";
            this.btnAddFlower.UseVisualStyleBackColor = true;
            this.btnAddFlower.Click += new System.EventHandler(this.btnAddFlower_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(412, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 49);
            this.button1.TabIndex = 7;
            this.button1.Text = "Search Employee";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(618, 206);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 49);
            this.button2.TabIndex = 8;
            this.button2.Text = "Search Flower";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(618, 354);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 49);
            this.button3.TabIndex = 9;
            this.button3.Text = "Update Flowers";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnAddFlower);
            this.groupBox1.Controls.Add(this.btnAddEmployee);
            this.groupBox1.Controls.Add(this.flowershop_name);
            this.groupBox1.Controls.Add(this.btnShowEmployees);
            this.groupBox1.Controls.Add(this.btnShowStock);
            this.groupBox1.Controls.Add(this.flowershop_details);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(974, 506);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Interface.Properties.Resources.Screenshot_2025_05_06_111920;
            this.pictureBox1.Location = new System.Drawing.Point(182, 111);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(219, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(197, 331);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(222, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Manage the flowershop\'s data";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(998, 531);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Flowershop!";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label flowershop_details;
        private System.Windows.Forms.Button btnShowStock;
        private System.Windows.Forms.Button btnShowEmployees;
        private System.Windows.Forms.Label flowershop_name;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Button btnAddFlower;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

