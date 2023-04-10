namespace Reports
{
    partial class Form2
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
            this.lvl1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtDes = new System.Windows.Forms.TextBox();
            this.txtRel = new System.Windows.Forms.TextBox();
            this.txtBlood = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dob = new System.Windows.Forms.DateTimePicker();
            this.female = new System.Windows.Forms.RadioButton();
            this.male = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cqjava = new System.Windows.Forms.CheckBox();
            this.cqcsharp = new System.Windows.Forms.CheckBox();
            this.cqpython = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvl1
            // 
            this.lvl1.AutoSize = true;
            this.lvl1.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvl1.Location = new System.Drawing.Point(262, 23);
            this.lvl1.Name = "lvl1";
            this.lvl1.Size = new System.Drawing.Size(274, 31);
            this.lvl1.TabIndex = 0;
            this.lvl1.Text = "Employee Entry Form";
            this.lvl1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employee Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Emloyee Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Designation";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Religion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Blood Group";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(129, 120);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(208, 22);
            this.txtName.TabIndex = 2;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(129, 152);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(208, 22);
            this.txtId.TabIndex = 2;
            this.txtId.Text = "1";
            // 
            // txtDes
            // 
            this.txtDes.Location = new System.Drawing.Point(129, 186);
            this.txtDes.Name = "txtDes";
            this.txtDes.Size = new System.Drawing.Size(208, 22);
            this.txtDes.TabIndex = 2;
            // 
            // txtRel
            // 
            this.txtRel.Location = new System.Drawing.Point(129, 221);
            this.txtRel.Name = "txtRel";
            this.txtRel.Size = new System.Drawing.Size(208, 22);
            this.txtRel.TabIndex = 2;
            // 
            // txtBlood
            // 
            this.txtBlood.Location = new System.Drawing.Point(129, 254);
            this.txtBlood.Name = "txtBlood";
            this.txtBlood.Size = new System.Drawing.Size(208, 22);
            this.txtBlood.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(211, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 33);
            this.button1.TabIndex = 3;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(338, 292);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 33);
            this.button2.TabIndex = 4;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(469, 292);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 33);
            this.button3.TabIndex = 5;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(425, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Date of Birth";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(845, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Employee Name";
            // 
            // dob
            // 
            this.dob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dob.Location = new System.Drawing.Point(528, 118);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(204, 22);
            this.dob.TabIndex = 6;
            this.dob.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged);
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.Location = new System.Drawing.Point(95, 0);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(75, 21);
            this.female.TabIndex = 7;
            this.female.TabStop = true;
            this.female.Text = "Female";
            this.female.UseVisualStyleBackColor = true;
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Location = new System.Drawing.Point(30, 0);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(59, 21);
            this.male.TabIndex = 7;
            this.male.TabStop = true;
            this.male.Text = "Male";
            this.male.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.male);
            this.groupBox1.Controls.Add(this.female);
            this.groupBox1.Location = new System.Drawing.Point(528, 155);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(204, 22);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(425, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Gender";
            // 
            // cqjava
            // 
            this.cqjava.AutoSize = true;
            this.cqjava.Location = new System.Drawing.Point(528, 191);
            this.cqjava.Name = "cqjava";
            this.cqjava.Size = new System.Drawing.Size(60, 21);
            this.cqjava.TabIndex = 9;
            this.cqjava.Text = "Java";
            this.cqjava.UseVisualStyleBackColor = true;
            this.cqjava.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // cqcsharp
            // 
            this.cqcsharp.AutoSize = true;
            this.cqcsharp.Location = new System.Drawing.Point(594, 191);
            this.cqcsharp.Name = "cqcsharp";
            this.cqcsharp.Size = new System.Drawing.Size(47, 21);
            this.cqcsharp.TabIndex = 9;
            this.cqcsharp.Text = "C#";
            this.cqcsharp.UseVisualStyleBackColor = true;
            this.cqcsharp.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // cqpython
            // 
            this.cqpython.AutoSize = true;
            this.cqpython.Location = new System.Drawing.Point(647, 191);
            this.cqpython.Name = "cqpython";
            this.cqpython.Size = new System.Drawing.Size(74, 21);
            this.cqpython.TabIndex = 9;
            this.cqpython.Text = "Python";
            this.cqpython.UseVisualStyleBackColor = true;
            this.cqpython.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(425, 191);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "Skill";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 396);
            this.Controls.Add(this.cqpython);
            this.Controls.Add(this.cqcsharp);
            this.Controls.Add(this.cqjava);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dob);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBlood);
            this.Controls.Add(this.txtRel);
            this.Controls.Add(this.txtDes);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvl1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lvl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtDes;
        private System.Windows.Forms.TextBox txtRel;
        private System.Windows.Forms.TextBox txtBlood;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dob;
        private System.Windows.Forms.RadioButton female;
        private System.Windows.Forms.RadioButton male;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox cqjava;
        private System.Windows.Forms.CheckBox cqcsharp;
        private System.Windows.Forms.CheckBox cqpython;
        private System.Windows.Forms.Label label9;
    }
}