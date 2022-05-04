
namespace LibraryManagementSystem
{
    partial class FormBooks
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.buttonBookAdd = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonBookDelete = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonShowAll = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textBoxISBN = new System.Windows.Forms.TextBox();
            this.textBoxAuthorName = new System.Windows.Forms.TextBox();
            this.textBoxAuthorSurname = new System.Windows.Forms.TextBox();
            this.textBoxBookTypeCode = new System.Windows.Forms.TextBox();
            this.textBoxBookName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonBookBorrowtheBook = new System.Windows.Forms.Button();
            this.dateTimePickerBorrowDate = new System.Windows.Forms.DateTimePicker();
            this.textBoxBorrower = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonReturnTheBook = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.labelReturnFee = new System.Windows.Forms.Label();
            this.labelReturnDelayFee = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridViewBooks = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.textBoxISBN);
            this.groupBox1.Controls.Add(this.textBoxAuthorName);
            this.groupBox1.Controls.Add(this.textBoxAuthorSurname);
            this.groupBox1.Controls.Add(this.textBoxBookTypeCode);
            this.groupBox1.Controls.Add(this.textBoxBookName);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.labelID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(683, 379);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.buttonBookAdd);
            this.groupBox6.Controls.Add(this.button2);
            this.groupBox6.Controls.Add(this.buttonBookDelete);
            this.groupBox6.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox6.Location = new System.Drawing.Point(10, 234);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(310, 136);
            this.groupBox6.TabIndex = 19;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Registry Editing Procedures";
            // 
            // buttonBookAdd
            // 
            this.buttonBookAdd.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonBookAdd.Location = new System.Drawing.Point(113, 45);
            this.buttonBookAdd.Name = "buttonBookAdd";
            this.buttonBookAdd.Size = new System.Drawing.Size(87, 63);
            this.buttonBookAdd.TabIndex = 12;
            this.buttonBookAdd.Text = "Book Add";
            this.buttonBookAdd.UseVisualStyleBackColor = true;
            this.buttonBookAdd.Click += new System.EventHandler(this.buttonBookAdd_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(1, 45);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 63);
            this.button2.TabIndex = 13;
            this.button2.Text = "Book Information Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonBookDelete
            // 
            this.buttonBookDelete.AccessibleName = " ";
            this.buttonBookDelete.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonBookDelete.Location = new System.Drawing.Point(217, 45);
            this.buttonBookDelete.Name = "buttonBookDelete";
            this.buttonBookDelete.Size = new System.Drawing.Size(93, 63);
            this.buttonBookDelete.TabIndex = 17;
            this.buttonBookDelete.Text = "Book Delete";
            this.buttonBookDelete.UseVisualStyleBackColor = true;
            this.buttonBookDelete.Click += new System.EventHandler(this.buttonBookDelete_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.buttonSearch);
            this.groupBox5.Controls.Add(this.buttonShowAll);
            this.groupBox5.Controls.Add(this.buttonDelete);
            this.groupBox5.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox5.Location = new System.Drawing.Point(326, 234);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(351, 136);
            this.groupBox5.TabIndex = 18;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Book Search";
            // 
            // buttonSearch
            // 
            this.buttonSearch.AccessibleName = " ";
            this.buttonSearch.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSearch.Location = new System.Drawing.Point(124, 45);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(93, 63);
            this.buttonSearch.TabIndex = 15;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonShowAll
            // 
            this.buttonShowAll.AccessibleName = " ";
            this.buttonShowAll.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonShowAll.Location = new System.Drawing.Point(239, 45);
            this.buttonShowAll.Name = "buttonShowAll";
            this.buttonShowAll.Size = new System.Drawing.Size(93, 63);
            this.buttonShowAll.TabIndex = 16;
            this.buttonShowAll.Text = "Show All of Them";
            this.buttonShowAll.UseVisualStyleBackColor = true;
            this.buttonShowAll.Click += new System.EventHandler(this.buttonShowAll_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.AccessibleName = " ";
            this.buttonDelete.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDelete.Location = new System.Drawing.Point(16, 45);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(90, 63);
            this.buttonDelete.TabIndex = 14;
            this.buttonDelete.Text = "Clean";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // textBoxISBN
            // 
            this.textBoxISBN.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxISBN.Location = new System.Drawing.Point(167, 168);
            this.textBoxISBN.Name = "textBoxISBN";
            this.textBoxISBN.Size = new System.Drawing.Size(233, 27);
            this.textBoxISBN.TabIndex = 11;
            // 
            // textBoxAuthorName
            // 
            this.textBoxAuthorName.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxAuthorName.Location = new System.Drawing.Point(167, 104);
            this.textBoxAuthorName.Name = "textBoxAuthorName";
            this.textBoxAuthorName.Size = new System.Drawing.Size(233, 27);
            this.textBoxAuthorName.TabIndex = 10;
            // 
            // textBoxAuthorSurname
            // 
            this.textBoxAuthorSurname.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxAuthorSurname.Location = new System.Drawing.Point(167, 137);
            this.textBoxAuthorSurname.Name = "textBoxAuthorSurname";
            this.textBoxAuthorSurname.Size = new System.Drawing.Size(233, 27);
            this.textBoxAuthorSurname.TabIndex = 9;
            // 
            // textBoxBookTypeCode
            // 
            this.textBoxBookTypeCode.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxBookTypeCode.Location = new System.Drawing.Point(167, 201);
            this.textBoxBookTypeCode.Name = "textBoxBookTypeCode";
            this.textBoxBookTypeCode.Size = new System.Drawing.Size(233, 27);
            this.textBoxBookTypeCode.TabIndex = 8;
            // 
            // textBoxBookName
            // 
            this.textBoxBookName.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxBookName.Location = new System.Drawing.Point(167, 62);
            this.textBoxBookName.Name = "textBoxBookName";
            this.textBoxBookName.Size = new System.Drawing.Size(233, 27);
            this.textBoxBookName.TabIndex = 7;
            this.textBoxBookName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(6, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "Author Surname :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(6, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "ISBN :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(6, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Book Type Code :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(6, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Book Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(6, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Author Name :";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(254, 32);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(17, 23);
            this.labelID.TabIndex = 1;
            this.labelID.Text = "-";
            this.labelID.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book ID :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonBookBorrowtheBook);
            this.groupBox2.Controls.Add(this.dateTimePickerBorrowDate);
            this.groupBox2.Controls.Add(this.textBoxBorrower);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(712, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(257, 379);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Borrowing Book";
            // 
            // buttonBookBorrowtheBook
            // 
            this.buttonBookBorrowtheBook.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonBookBorrowtheBook.Location = new System.Drawing.Point(77, 137);
            this.buttonBookBorrowtheBook.Name = "buttonBookBorrowtheBook";
            this.buttonBookBorrowtheBook.Size = new System.Drawing.Size(114, 47);
            this.buttonBookBorrowtheBook.TabIndex = 17;
            this.buttonBookBorrowtheBook.Text = "Borrow the Book";
            this.buttonBookBorrowtheBook.UseVisualStyleBackColor = true;
            this.buttonBookBorrowtheBook.Click += new System.EventHandler(this.buttonBookBorrowtheBook_Click);
            // 
            // dateTimePickerBorrowDate
            // 
            this.dateTimePickerBorrowDate.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerBorrowDate.Location = new System.Drawing.Point(106, 82);
            this.dateTimePickerBorrowDate.Name = "dateTimePickerBorrowDate";
            this.dateTimePickerBorrowDate.Size = new System.Drawing.Size(126, 23);
            this.dateTimePickerBorrowDate.TabIndex = 10;
            // 
            // textBoxBorrower
            // 
            this.textBoxBorrower.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxBorrower.Location = new System.Drawing.Point(106, 36);
            this.textBoxBorrower.Name = "textBoxBorrower";
            this.textBoxBorrower.Size = new System.Drawing.Size(145, 27);
            this.textBoxBorrower.TabIndex = 9;
            this.textBoxBorrower.TextChanged += new System.EventHandler(this.textBoxBorrower_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(6, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 21);
            this.label9.TabIndex = 5;
            this.label9.Text = "Borrower :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(6, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 21);
            this.label8.TabIndex = 4;
            this.label8.Text = "Date :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonReturnTheBook);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.labelReturnFee);
            this.groupBox3.Controls.Add(this.labelReturnDelayFee);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(985, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(253, 379);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Book Return";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // buttonReturnTheBook
            // 
            this.buttonReturnTheBook.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonReturnTheBook.Location = new System.Drawing.Point(68, 192);
            this.buttonReturnTheBook.Name = "buttonReturnTheBook";
            this.buttonReturnTheBook.Size = new System.Drawing.Size(114, 47);
            this.buttonReturnTheBook.TabIndex = 16;
            this.buttonReturnTheBook.Text = "Return the Book";
            this.buttonReturnTheBook.UseVisualStyleBackColor = true;
            this.buttonReturnTheBook.Click += new System.EventHandler(this.buttonReturnTheBook_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(228, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 21);
            this.label11.TabIndex = 15;
            this.label11.Text = "$";
            // 
            // labelReturnFee
            // 
            this.labelReturnFee.AutoSize = true;
            this.labelReturnFee.Font = new System.Drawing.Font("Century", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelReturnFee.Location = new System.Drawing.Point(172, 34);
            this.labelReturnFee.Name = "labelReturnFee";
            this.labelReturnFee.Size = new System.Drawing.Size(19, 21);
            this.labelReturnFee.TabIndex = 14;
            this.labelReturnFee.Text = "0";
            // 
            // labelReturnDelayFee
            // 
            this.labelReturnDelayFee.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelReturnDelayFee.Location = new System.Drawing.Point(68, 109);
            this.labelReturnDelayFee.Name = "labelReturnDelayFee";
            this.labelReturnDelayFee.Size = new System.Drawing.Size(114, 47);
            this.labelReturnDelayFee.TabIndex = 13;
            this.labelReturnDelayFee.Text = "Delay Fee Calculate";
            this.labelReturnDelayFee.UseVisualStyleBackColor = true;
            this.labelReturnDelayFee.Click += new System.EventHandler(this.buttonButtonDelayFeeCalculate_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(6, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(160, 21);
            this.label10.TabIndex = 6;
            this.label10.Text = "Return Delay Fee :";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridViewBooks);
            this.groupBox4.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox4.Location = new System.Drawing.Point(19, 406);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1219, 197);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Book  List";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // dataGridViewBooks
            // 
            this.dataGridViewBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewBooks.Location = new System.Drawing.Point(3, 18);
            this.dataGridViewBooks.Name = "dataGridViewBooks";
            this.dataGridViewBooks.RowTemplate.Height = 25;
            this.dataGridViewBooks.Size = new System.Drawing.Size(1213, 176);
            this.dataGridViewBooks.TabIndex = 0;
            this.dataGridViewBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBooks_CellClick);
            // 
            // FormBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1248, 615);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "FormBooks";
            this.Text = "YK Library";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormBooks_FormClosed);
            this.Load += new System.EventHandler(this.FormBooks_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxBookName;
        private System.Windows.Forms.TextBox textBoxISBN;
        private System.Windows.Forms.TextBox textBoxAuthorName;
        private System.Windows.Forms.TextBox textBoxAuthorSurname;
        private System.Windows.Forms.TextBox textBoxBookTypeCode;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonBookAdd;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridViewBooks;
        private System.Windows.Forms.Button buttonBookBorrowtheBook;
        private System.Windows.Forms.DateTimePicker dateTimePickerBorrowDate;
        private System.Windows.Forms.TextBox textBoxBorrower;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonReturnTheBook;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelReturnFee;
        private System.Windows.Forms.Button labelReturnDelayFee;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonShowAll;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonBookDelete;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
    }
}