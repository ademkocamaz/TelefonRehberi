namespace TelefonRehberi.UI
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
            this.dataGridView_Customers = new System.Windows.Forms.DataGridView();
            this.groupBox_Add = new System.Windows.Forms.GroupBox();
            this.button_Add = new System.Windows.Forms.Button();
            this.label_Add_Phone2 = new System.Windows.Forms.Label();
            this.label_Add_Phone1 = new System.Windows.Forms.Label();
            this.label_Add_LastName = new System.Windows.Forms.Label();
            this.label_Add_Name = new System.Windows.Forms.Label();
            this.label_Add_Title = new System.Windows.Forms.Label();
            this.textBox_Add_Phone2 = new System.Windows.Forms.TextBox();
            this.textBox_Add_Phone1 = new System.Windows.Forms.TextBox();
            this.textBox_Add_LastName = new System.Windows.Forms.TextBox();
            this.textBox_Add_Name = new System.Windows.Forms.TextBox();
            this.textBox_Add_Title = new System.Windows.Forms.TextBox();
            this.groupBox_Update = new System.Windows.Forms.GroupBox();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.label_Update_Phone2 = new System.Windows.Forms.Label();
            this.label_Update_Phone1 = new System.Windows.Forms.Label();
            this.label_Update_LastName = new System.Windows.Forms.Label();
            this.label_Update_Name = new System.Windows.Forms.Label();
            this.label_Update_Title = new System.Windows.Forms.Label();
            this.textBox_Update_Phone2 = new System.Windows.Forms.TextBox();
            this.textBox_Update_Phone1 = new System.Windows.Forms.TextBox();
            this.textBox_Update_LastName = new System.Windows.Forms.TextBox();
            this.textBox_Update_Name = new System.Windows.Forms.TextBox();
            this.textBox_Update_Title = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TITLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LASTNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PHONE1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PHONE2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Customers)).BeginInit();
            this.groupBox_Add.SuspendLayout();
            this.groupBox_Update.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_Customers
            // 
            this.dataGridView_Customers.AllowUserToResizeColumns = false;
            this.dataGridView_Customers.AllowUserToResizeRows = false;
            this.dataGridView_Customers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Customers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Customers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Customers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.TITLE,
            this.NAME,
            this.LASTNAME,
            this.PHONE1,
            this.PHONE2});
            this.dataGridView_Customers.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_Customers.Name = "dataGridView_Customers";
            this.dataGridView_Customers.RowHeadersVisible = false;
            this.dataGridView_Customers.RowHeadersWidth = 51;
            this.dataGridView_Customers.RowTemplate.Height = 24;
            this.dataGridView_Customers.Size = new System.Drawing.Size(982, 403);
            this.dataGridView_Customers.TabIndex = 1;
            this.dataGridView_Customers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Customers_CellClick);
            // 
            // groupBox_Add
            // 
            this.groupBox_Add.Controls.Add(this.button_Add);
            this.groupBox_Add.Controls.Add(this.label_Add_Phone2);
            this.groupBox_Add.Controls.Add(this.label_Add_Phone1);
            this.groupBox_Add.Controls.Add(this.label_Add_LastName);
            this.groupBox_Add.Controls.Add(this.label_Add_Name);
            this.groupBox_Add.Controls.Add(this.label_Add_Title);
            this.groupBox_Add.Controls.Add(this.textBox_Add_Phone2);
            this.groupBox_Add.Controls.Add(this.textBox_Add_Phone1);
            this.groupBox_Add.Controls.Add(this.textBox_Add_LastName);
            this.groupBox_Add.Controls.Add(this.textBox_Add_Name);
            this.groupBox_Add.Controls.Add(this.textBox_Add_Title);
            this.groupBox_Add.Location = new System.Drawing.Point(12, 421);
            this.groupBox_Add.Name = "groupBox_Add";
            this.groupBox_Add.Size = new System.Drawing.Size(351, 221);
            this.groupBox_Add.TabIndex = 0;
            this.groupBox_Add.TabStop = false;
            this.groupBox_Add.Text = "Ekle";
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(270, 167);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(75, 23);
            this.button_Add.TabIndex = 10;
            this.button_Add.Text = "Ekle";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // label_Add_Phone2
            // 
            this.label_Add_Phone2.AutoSize = true;
            this.label_Add_Phone2.Location = new System.Drawing.Point(6, 142);
            this.label_Add_Phone2.Name = "label_Add_Phone2";
            this.label_Add_Phone2.Size = new System.Drawing.Size(63, 16);
            this.label_Add_Phone2.TabIndex = 8;
            this.label_Add_Phone2.Text = "Telefon 2";
            // 
            // label_Add_Phone1
            // 
            this.label_Add_Phone1.AutoSize = true;
            this.label_Add_Phone1.Location = new System.Drawing.Point(6, 114);
            this.label_Add_Phone1.Name = "label_Add_Phone1";
            this.label_Add_Phone1.Size = new System.Drawing.Size(63, 16);
            this.label_Add_Phone1.TabIndex = 6;
            this.label_Add_Phone1.Text = "Telefon 1";
            // 
            // label_Add_LastName
            // 
            this.label_Add_LastName.AutoSize = true;
            this.label_Add_LastName.Location = new System.Drawing.Point(6, 86);
            this.label_Add_LastName.Name = "label_Add_LastName";
            this.label_Add_LastName.Size = new System.Drawing.Size(50, 16);
            this.label_Add_LastName.TabIndex = 4;
            this.label_Add_LastName.Text = "Soyadı";
            // 
            // label_Add_Name
            // 
            this.label_Add_Name.AutoSize = true;
            this.label_Add_Name.Location = new System.Drawing.Point(6, 58);
            this.label_Add_Name.Name = "label_Add_Name";
            this.label_Add_Name.Size = new System.Drawing.Size(27, 16);
            this.label_Add_Name.TabIndex = 2;
            this.label_Add_Name.Text = "Adı";
            // 
            // label_Add_Title
            // 
            this.label_Add_Title.AutoSize = true;
            this.label_Add_Title.Location = new System.Drawing.Point(6, 30);
            this.label_Add_Title.Name = "label_Add_Title";
            this.label_Add_Title.Size = new System.Drawing.Size(46, 16);
            this.label_Add_Title.TabIndex = 0;
            this.label_Add_Title.Text = "Ünvan";
            // 
            // textBox_Add_Phone2
            // 
            this.textBox_Add_Phone2.Location = new System.Drawing.Point(120, 139);
            this.textBox_Add_Phone2.Name = "textBox_Add_Phone2";
            this.textBox_Add_Phone2.Size = new System.Drawing.Size(225, 22);
            this.textBox_Add_Phone2.TabIndex = 9;
            // 
            // textBox_Add_Phone1
            // 
            this.textBox_Add_Phone1.Location = new System.Drawing.Point(120, 111);
            this.textBox_Add_Phone1.Name = "textBox_Add_Phone1";
            this.textBox_Add_Phone1.Size = new System.Drawing.Size(225, 22);
            this.textBox_Add_Phone1.TabIndex = 7;
            // 
            // textBox_Add_LastName
            // 
            this.textBox_Add_LastName.Location = new System.Drawing.Point(120, 83);
            this.textBox_Add_LastName.Name = "textBox_Add_LastName";
            this.textBox_Add_LastName.Size = new System.Drawing.Size(225, 22);
            this.textBox_Add_LastName.TabIndex = 5;
            // 
            // textBox_Add_Name
            // 
            this.textBox_Add_Name.Location = new System.Drawing.Point(120, 55);
            this.textBox_Add_Name.Name = "textBox_Add_Name";
            this.textBox_Add_Name.Size = new System.Drawing.Size(225, 22);
            this.textBox_Add_Name.TabIndex = 3;
            // 
            // textBox_Add_Title
            // 
            this.textBox_Add_Title.Location = new System.Drawing.Point(120, 27);
            this.textBox_Add_Title.Name = "textBox_Add_Title";
            this.textBox_Add_Title.Size = new System.Drawing.Size(225, 22);
            this.textBox_Add_Title.TabIndex = 1;
            // 
            // groupBox_Update
            // 
            this.groupBox_Update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_Update.Controls.Add(this.button_Delete);
            this.groupBox_Update.Controls.Add(this.button_Update);
            this.groupBox_Update.Controls.Add(this.label_Update_Phone2);
            this.groupBox_Update.Controls.Add(this.label_Update_Phone1);
            this.groupBox_Update.Controls.Add(this.label_Update_LastName);
            this.groupBox_Update.Controls.Add(this.label_Update_Name);
            this.groupBox_Update.Controls.Add(this.label_Update_Title);
            this.groupBox_Update.Controls.Add(this.textBox_Update_Phone2);
            this.groupBox_Update.Controls.Add(this.textBox_Update_Phone1);
            this.groupBox_Update.Controls.Add(this.textBox_Update_LastName);
            this.groupBox_Update.Controls.Add(this.textBox_Update_Name);
            this.groupBox_Update.Controls.Add(this.textBox_Update_Title);
            this.groupBox_Update.Location = new System.Drawing.Point(643, 421);
            this.groupBox_Update.Name = "groupBox_Update";
            this.groupBox_Update.Size = new System.Drawing.Size(351, 221);
            this.groupBox_Update.TabIndex = 0;
            this.groupBox_Update.TabStop = false;
            this.groupBox_Update.Text = "Güncelle";
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(120, 167);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(75, 23);
            this.button_Delete.TabIndex = 10;
            this.button_Delete.Text = "Sil";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Update
            // 
            this.button_Update.Location = new System.Drawing.Point(270, 167);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(75, 23);
            this.button_Update.TabIndex = 11;
            this.button_Update.Text = "Güncelle";
            this.button_Update.UseVisualStyleBackColor = true;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // label_Update_Phone2
            // 
            this.label_Update_Phone2.AutoSize = true;
            this.label_Update_Phone2.Location = new System.Drawing.Point(6, 142);
            this.label_Update_Phone2.Name = "label_Update_Phone2";
            this.label_Update_Phone2.Size = new System.Drawing.Size(63, 16);
            this.label_Update_Phone2.TabIndex = 8;
            this.label_Update_Phone2.Text = "Telefon 2";
            // 
            // label_Update_Phone1
            // 
            this.label_Update_Phone1.AutoSize = true;
            this.label_Update_Phone1.Location = new System.Drawing.Point(6, 114);
            this.label_Update_Phone1.Name = "label_Update_Phone1";
            this.label_Update_Phone1.Size = new System.Drawing.Size(63, 16);
            this.label_Update_Phone1.TabIndex = 6;
            this.label_Update_Phone1.Text = "Telefon 1";
            // 
            // label_Update_LastName
            // 
            this.label_Update_LastName.AutoSize = true;
            this.label_Update_LastName.Location = new System.Drawing.Point(6, 86);
            this.label_Update_LastName.Name = "label_Update_LastName";
            this.label_Update_LastName.Size = new System.Drawing.Size(50, 16);
            this.label_Update_LastName.TabIndex = 4;
            this.label_Update_LastName.Text = "Soyadı";
            // 
            // label_Update_Name
            // 
            this.label_Update_Name.AutoSize = true;
            this.label_Update_Name.Location = new System.Drawing.Point(6, 58);
            this.label_Update_Name.Name = "label_Update_Name";
            this.label_Update_Name.Size = new System.Drawing.Size(27, 16);
            this.label_Update_Name.TabIndex = 2;
            this.label_Update_Name.Text = "Adı";
            // 
            // label_Update_Title
            // 
            this.label_Update_Title.AutoSize = true;
            this.label_Update_Title.Location = new System.Drawing.Point(6, 30);
            this.label_Update_Title.Name = "label_Update_Title";
            this.label_Update_Title.Size = new System.Drawing.Size(46, 16);
            this.label_Update_Title.TabIndex = 0;
            this.label_Update_Title.Text = "Ünvan";
            // 
            // textBox_Update_Phone2
            // 
            this.textBox_Update_Phone2.Location = new System.Drawing.Point(120, 139);
            this.textBox_Update_Phone2.Name = "textBox_Update_Phone2";
            this.textBox_Update_Phone2.Size = new System.Drawing.Size(225, 22);
            this.textBox_Update_Phone2.TabIndex = 9;
            // 
            // textBox_Update_Phone1
            // 
            this.textBox_Update_Phone1.Location = new System.Drawing.Point(120, 111);
            this.textBox_Update_Phone1.Name = "textBox_Update_Phone1";
            this.textBox_Update_Phone1.Size = new System.Drawing.Size(225, 22);
            this.textBox_Update_Phone1.TabIndex = 7;
            // 
            // textBox_Update_LastName
            // 
            this.textBox_Update_LastName.Location = new System.Drawing.Point(120, 83);
            this.textBox_Update_LastName.Name = "textBox_Update_LastName";
            this.textBox_Update_LastName.Size = new System.Drawing.Size(225, 22);
            this.textBox_Update_LastName.TabIndex = 5;
            // 
            // textBox_Update_Name
            // 
            this.textBox_Update_Name.Location = new System.Drawing.Point(120, 55);
            this.textBox_Update_Name.Name = "textBox_Update_Name";
            this.textBox_Update_Name.Size = new System.Drawing.Size(225, 22);
            this.textBox_Update_Name.TabIndex = 3;
            // 
            // textBox_Update_Title
            // 
            this.textBox_Update_Title.Location = new System.Drawing.Point(120, 27);
            this.textBox_Update_Title.Name = "textBox_Update_Title";
            this.textBox_Update_Title.Size = new System.Drawing.Size(225, 22);
            this.textBox_Update_Title.TabIndex = 1;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // TITLE
            // 
            this.TITLE.DataPropertyName = "TITLE";
            this.TITLE.HeaderText = "Ünvan";
            this.TITLE.MinimumWidth = 6;
            this.TITLE.Name = "TITLE";
            // 
            // NAME
            // 
            this.NAME.DataPropertyName = "NAME";
            this.NAME.HeaderText = "Adı";
            this.NAME.MinimumWidth = 6;
            this.NAME.Name = "NAME";
            // 
            // LASTNAME
            // 
            this.LASTNAME.DataPropertyName = "LASTNAME";
            this.LASTNAME.HeaderText = "Soyadı";
            this.LASTNAME.MinimumWidth = 6;
            this.LASTNAME.Name = "LASTNAME";
            // 
            // PHONE1
            // 
            this.PHONE1.DataPropertyName = "PHONE1";
            this.PHONE1.HeaderText = "Telefon 1";
            this.PHONE1.MinimumWidth = 6;
            this.PHONE1.Name = "PHONE1";
            // 
            // PHONE2
            // 
            this.PHONE2.DataPropertyName = "PHONE2";
            this.PHONE2.HeaderText = "Telefon 2";
            this.PHONE2.MinimumWidth = 6;
            this.PHONE2.Name = "PHONE2";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 723);
            this.Controls.Add(this.groupBox_Update);
            this.Controls.Add(this.groupBox_Add);
            this.Controls.Add(this.dataGridView_Customers);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Telefon Rehberi";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Customers)).EndInit();
            this.groupBox_Add.ResumeLayout(false);
            this.groupBox_Add.PerformLayout();
            this.groupBox_Update.ResumeLayout(false);
            this.groupBox_Update.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Customers;
        private System.Windows.Forms.GroupBox groupBox_Add;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Label label_Add_Phone2;
        private System.Windows.Forms.Label label_Add_Phone1;
        private System.Windows.Forms.Label label_Add_LastName;
        private System.Windows.Forms.Label label_Add_Name;
        private System.Windows.Forms.Label label_Add_Title;
        private System.Windows.Forms.TextBox textBox_Add_Phone2;
        private System.Windows.Forms.TextBox textBox_Add_Phone1;
        private System.Windows.Forms.TextBox textBox_Add_LastName;
        private System.Windows.Forms.TextBox textBox_Add_Name;
        private System.Windows.Forms.TextBox textBox_Add_Title;
        private System.Windows.Forms.GroupBox groupBox_Update;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Label label_Update_Phone2;
        private System.Windows.Forms.Label label_Update_Phone1;
        private System.Windows.Forms.Label label_Update_LastName;
        private System.Windows.Forms.Label label_Update_Name;
        private System.Windows.Forms.Label label_Update_Title;
        private System.Windows.Forms.TextBox textBox_Update_Phone2;
        private System.Windows.Forms.TextBox textBox_Update_Phone1;
        private System.Windows.Forms.TextBox textBox_Update_LastName;
        private System.Windows.Forms.TextBox textBox_Update_Name;
        private System.Windows.Forms.TextBox textBox_Update_Title;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TITLE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn LASTNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn PHONE1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PHONE2;
    }
}