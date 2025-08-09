namespace myCsharpSqlProject
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.ageText = new System.Windows.Forms.TextBox();
            this.IDtext = new System.Windows.Forms.TextBox();
            this.nameText = new System.Windows.Forms.TextBox();
            this.surnameText = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.femaleRadio = new System.Windows.Forms.RadioButton();
            this.maleRadio = new System.Windows.Forms.RadioButton();
            this.phoneNumber = new System.Windows.Forms.TextBox();
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ageText
            // 
            this.ageText.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageText.Location = new System.Drawing.Point(200, 187);
            this.ageText.Name = "ageText";
            this.ageText.Size = new System.Drawing.Size(100, 30);
            this.ageText.TabIndex = 6;
            // 
            // IDtext
            // 
            this.IDtext.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDtext.Location = new System.Drawing.Point(200, 32);
            this.IDtext.Name = "IDtext";
            this.IDtext.Size = new System.Drawing.Size(246, 30);
            this.IDtext.TabIndex = 7;
            // 
            // nameText
            // 
            this.nameText.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameText.Location = new System.Drawing.Point(200, 86);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(246, 30);
            this.nameText.TabIndex = 8;
            // 
            // surnameText
            // 
            this.surnameText.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surnameText.Location = new System.Drawing.Point(200, 134);
            this.surnameText.Name = "surnameText";
            this.surnameText.Size = new System.Drawing.Size(246, 30);
            this.surnameText.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(686, 32);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(246, 30);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(35, 302);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1000, 350);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // femaleRadio
            // 
            this.femaleRadio.AutoSize = true;
            this.femaleRadio.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.femaleRadio.Location = new System.Drawing.Point(329, 233);
            this.femaleRadio.Name = "femaleRadio";
            this.femaleRadio.Size = new System.Drawing.Size(85, 27);
            this.femaleRadio.TabIndex = 12;
            this.femaleRadio.TabStop = true;
            this.femaleRadio.Text = "Female";
            this.femaleRadio.UseVisualStyleBackColor = true;
            // 
            // maleRadio
            // 
            this.maleRadio.AutoSize = true;
            this.maleRadio.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maleRadio.Location = new System.Drawing.Point(200, 233);
            this.maleRadio.Name = "maleRadio";
            this.maleRadio.Size = new System.Drawing.Size(68, 27);
            this.maleRadio.TabIndex = 13;
            this.maleRadio.TabStop = true;
            this.maleRadio.Text = "Male";
            this.maleRadio.UseVisualStyleBackColor = true;
            // 
            // phoneNumber
            // 
            this.phoneNumber.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumber.Location = new System.Drawing.Point(686, 89);
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.Size = new System.Drawing.Size(246, 30);
            this.phoneNumber.TabIndex = 15;
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.SystemColors.ControlDark;
            this.update.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.update.FlatAppearance.BorderSize = 3;
            this.update.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.update.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.update.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.update.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.ForeColor = System.Drawing.Color.Red;
            this.update.Location = new System.Drawing.Point(842, 210);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(150, 50);
            this.update.TabIndex = 16;
            this.update.Text = "UPDATE";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.SystemColors.ControlDark;
            this.delete.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.delete.FlatAppearance.BorderSize = 3;
            this.delete.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.delete.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.ForeColor = System.Drawing.Color.Red;
            this.delete.Location = new System.Drawing.Point(686, 210);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(150, 50);
            this.delete.TabIndex = 17;
            this.delete.Text = "DELETE";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.SystemColors.ControlDark;
            this.add.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.add.FlatAppearance.BorderSize = 3;
            this.add.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.add.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.ForeColor = System.Drawing.Color.Red;
            this.add.Location = new System.Drawing.Point(530, 210);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(150, 50);
            this.add.TabIndex = 18;
            this.add.Text = "ADD";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(78, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 23);
            this.label8.TabIndex = 19;
            this.label8.Text = "Surname";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(543, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 23);
            this.label9.TabIndex = 20;
            this.label9.Text = "Phone Number";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(78, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 23);
            this.label10.TabIndex = 21;
            this.label10.Text = "Customer ID";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(78, 89);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 23);
            this.label11.TabIndex = 22;
            this.label11.Text = "Name";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(78, 190);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 23);
            this.label12.TabIndex = 23;
            this.label12.Text = "Age";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(543, 39);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(114, 23);
            this.label13.TabIndex = 24;
            this.label13.Text = "Birthday Date";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(78, 235);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 23);
            this.label14.TabIndex = 25;
            this.label14.Text = "Gender";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1072, 673);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.add);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.phoneNumber);
            this.Controls.Add(this.maleRadio);
            this.Controls.Add(this.femaleRadio);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.surnameText);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.IDtext);
            this.Controls.Add(this.ageText);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox ageText;
        private System.Windows.Forms.TextBox IDtext;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.TextBox surnameText;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton femaleRadio;
        private System.Windows.Forms.RadioButton maleRadio;
        private System.Windows.Forms.TextBox phoneNumber;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}

