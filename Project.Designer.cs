namespace PR6
{
    partial class Project
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Project));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Book = new System.Windows.Forms.ToolStripMenuItem();
            this.close = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.info = new System.Windows.Forms.ToolStripMenuItem();
            this.calculation = new System.Windows.Forms.GroupBox();
            this.radioButtonLuxe3 = new System.Windows.Forms.RadioButton();
            this.radioButtonLuxe2 = new System.Windows.Forms.RadioButton();
            this.radioButtonLuxe1 = new System.Windows.Forms.RadioButton();
            this.radioButtonRoom3 = new System.Windows.Forms.RadioButton();
            this.radioButtonRoom2 = new System.Windows.Forms.RadioButton();
            this.radioButtonRoom1 = new System.Windows.Forms.RadioButton();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.totalCost = new System.Windows.Forms.Label();
            this.textBoxTotalCost = new System.Windows.Forms.TextBox();
            this.btnBook = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.bookingTimeEnd = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.bookingTimeStart = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.calculation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.NavajoWhite;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(662, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Book,
            this.close});
            this.файлToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.файлToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(50, 21);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // Book
            // 
            this.Book.BackColor = System.Drawing.Color.NavajoWhite;
            this.Book.Name = "Book";
            this.Book.Size = new System.Drawing.Size(180, 22);
            this.Book.Text = "Забронировать";
            this.Book.Click += new System.EventHandler(this.Book_Click);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.NavajoWhite;
            this.close.ForeColor = System.Drawing.Color.Black;
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(180, 22);
            this.close.Text = "Выход";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.info});
            this.справкаToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.справкаToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(70, 21);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // info
            // 
            this.info.BackColor = System.Drawing.Color.NavajoWhite;
            this.info.ForeColor = System.Drawing.Color.Black;
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(180, 22);
            this.info.Text = "О программе";
            this.info.Click += new System.EventHandler(this.info_Click);
            // 
            // calculation
            // 
            this.calculation.BackColor = System.Drawing.Color.AntiqueWhite;
            this.calculation.Controls.Add(this.radioButtonLuxe3);
            this.calculation.Controls.Add(this.radioButtonLuxe2);
            this.calculation.Controls.Add(this.radioButtonLuxe1);
            this.calculation.Controls.Add(this.radioButtonRoom3);
            this.calculation.Controls.Add(this.radioButtonRoom2);
            this.calculation.Controls.Add(this.radioButtonRoom1);
            this.calculation.Controls.Add(this.pictureBox6);
            this.calculation.Controls.Add(this.pictureBox5);
            this.calculation.Controls.Add(this.pictureBox4);
            this.calculation.Controls.Add(this.pictureBox3);
            this.calculation.Controls.Add(this.pictureBox2);
            this.calculation.Controls.Add(this.pictureBox1);
            this.calculation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calculation.Location = new System.Drawing.Point(0, 28);
            this.calculation.Name = "calculation";
            this.calculation.Size = new System.Drawing.Size(660, 361);
            this.calculation.TabIndex = 1;
            this.calculation.TabStop = false;
            this.calculation.Text = "Выбор номера:";
            // 
            // radioButtonLuxe3
            // 
            this.radioButtonLuxe3.AutoSize = true;
            this.radioButtonLuxe3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonLuxe3.Location = new System.Drawing.Point(317, 274);
            this.radioButtonLuxe3.Name = "radioButtonLuxe3";
            this.radioButtonLuxe3.Size = new System.Drawing.Size(122, 20);
            this.radioButtonLuxe3.TabIndex = 40;
            this.radioButtonLuxe3.TabStop = true;
            this.radioButtonLuxe3.Text = "Номер 3 (Люкс)";
            this.radioButtonLuxe3.UseVisualStyleBackColor = true;
            // 
            // radioButtonLuxe2
            // 
            this.radioButtonLuxe2.AutoSize = true;
            this.radioButtonLuxe2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonLuxe2.Location = new System.Drawing.Point(317, 164);
            this.radioButtonLuxe2.Name = "radioButtonLuxe2";
            this.radioButtonLuxe2.Size = new System.Drawing.Size(122, 20);
            this.radioButtonLuxe2.TabIndex = 39;
            this.radioButtonLuxe2.TabStop = true;
            this.radioButtonLuxe2.Text = "Номер 2 (Люкс)";
            this.radioButtonLuxe2.UseVisualStyleBackColor = true;
            // 
            // radioButtonLuxe1
            // 
            this.radioButtonLuxe1.AutoSize = true;
            this.radioButtonLuxe1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonLuxe1.Location = new System.Drawing.Point(317, 60);
            this.radioButtonLuxe1.Name = "radioButtonLuxe1";
            this.radioButtonLuxe1.Size = new System.Drawing.Size(122, 20);
            this.radioButtonLuxe1.TabIndex = 38;
            this.radioButtonLuxe1.TabStop = true;
            this.radioButtonLuxe1.Text = "Номер 1 (Люкс)";
            this.radioButtonLuxe1.UseVisualStyleBackColor = true;
            // 
            // radioButtonRoom3
            // 
            this.radioButtonRoom3.AutoSize = true;
            this.radioButtonRoom3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonRoom3.Location = new System.Drawing.Point(20, 274);
            this.radioButtonRoom3.Name = "radioButtonRoom3";
            this.radioButtonRoom3.Size = new System.Drawing.Size(78, 20);
            this.radioButtonRoom3.TabIndex = 37;
            this.radioButtonRoom3.TabStop = true;
            this.radioButtonRoom3.Text = "Номер 3";
            this.radioButtonRoom3.UseVisualStyleBackColor = true;
            // 
            // radioButtonRoom2
            // 
            this.radioButtonRoom2.AutoSize = true;
            this.radioButtonRoom2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonRoom2.Location = new System.Drawing.Point(20, 164);
            this.radioButtonRoom2.Name = "radioButtonRoom2";
            this.radioButtonRoom2.Size = new System.Drawing.Size(78, 20);
            this.radioButtonRoom2.TabIndex = 36;
            this.radioButtonRoom2.TabStop = true;
            this.radioButtonRoom2.Text = "Номер 2";
            this.radioButtonRoom2.UseVisualStyleBackColor = true;
            // 
            // radioButtonRoom1
            // 
            this.radioButtonRoom1.AutoSize = true;
            this.radioButtonRoom1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonRoom1.Location = new System.Drawing.Point(20, 60);
            this.radioButtonRoom1.Name = "radioButtonRoom1";
            this.radioButtonRoom1.Size = new System.Drawing.Size(78, 20);
            this.radioButtonRoom1.TabIndex = 35;
            this.radioButtonRoom1.TabStop = true;
            this.radioButtonRoom1.Text = "Номер 1";
            this.radioButtonRoom1.UseVisualStyleBackColor = true;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::PR6.Properties.Resources._6;
            this.pictureBox6.Location = new System.Drawing.Point(456, 238);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(180, 102);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 34;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::PR6.Properties.Resources._5;
            this.pictureBox5.Location = new System.Drawing.Point(456, 130);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(180, 102);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 32;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::PR6.Properties.Resources._4;
            this.pictureBox4.Location = new System.Drawing.Point(456, 22);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(180, 102);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 31;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::PR6.Properties.Resources._3;
            this.pictureBox3.Location = new System.Drawing.Point(113, 238);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(180, 102);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 30;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PR6.Properties.Resources._2;
            this.pictureBox2.Location = new System.Drawing.Point(113, 130);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(180, 102);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PR6.Properties.Resources._1;
            this.pictureBox1.Location = new System.Drawing.Point(113, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // totalCost
            // 
            this.totalCost.AutoSize = true;
            this.totalCost.Location = new System.Drawing.Point(6, 40);
            this.totalCost.Name = "totalCost";
            this.totalCost.Size = new System.Drawing.Size(123, 16);
            this.totalCost.TabIndex = 21;
            this.totalCost.Text = "Общая стоимость:";
            // 
            // textBoxTotalCost
            // 
            this.textBoxTotalCost.BackColor = System.Drawing.Color.White;
            this.textBoxTotalCost.Cursor = System.Windows.Forms.Cursors.No;
            this.textBoxTotalCost.ForeColor = System.Drawing.Color.Black;
            this.textBoxTotalCost.Location = new System.Drawing.Point(135, 37);
            this.textBoxTotalCost.Name = "textBoxTotalCost";
            this.textBoxTotalCost.ReadOnly = true;
            this.textBoxTotalCost.Size = new System.Drawing.Size(158, 22);
            this.textBoxTotalCost.TabIndex = 20;
            // 
            // btnBook
            // 
            this.btnBook.BackColor = System.Drawing.Color.White;
            this.btnBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBook.ForeColor = System.Drawing.Color.Black;
            this.btnBook.Location = new System.Drawing.Point(390, 471);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(129, 34);
            this.btnBook.TabIndex = 19;
            this.btnBook.Text = "Забронировать";
            this.btnBook.UseVisualStyleBackColor = false;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(525, 471);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(129, 34);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "Выход";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePicker2.Location = new System.Drawing.Point(175, 54);
            this.dateTimePicker2.MaxDate = new System.DateTime(2024, 12, 31, 9, 2, 0, 0);
            this.dateTimePicker2.MinDate = new System.DateTime(2024, 5, 28, 9, 2, 0, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(158, 22);
            this.dateTimePicker2.TabIndex = 17;
            this.dateTimePicker2.Value = new System.DateTime(2024, 5, 28, 9, 2, 0, 0);
            // 
            // bookingTimeEnd
            // 
            this.bookingTimeEnd.AutoSize = true;
            this.bookingTimeEnd.Location = new System.Drawing.Point(4, 57);
            this.bookingTimeEnd.Name = "bookingTimeEnd";
            this.bookingTimeEnd.Size = new System.Drawing.Size(168, 16);
            this.bookingTimeEnd.TabIndex = 16;
            this.bookingTimeEnd.Text = "Время бронирования до:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.White;
            this.dateTimePicker1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePicker1.Location = new System.Drawing.Point(175, 23);
            this.dateTimePicker1.MaxDate = new System.DateTime(2024, 12, 31, 9, 2, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2024, 5, 28, 9, 2, 48, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(158, 22);
            this.dateTimePicker1.TabIndex = 15;
            this.dateTimePicker1.Value = new System.DateTime(2024, 5, 28, 9, 2, 48, 0);
            // 
            // bookingTimeStart
            // 
            this.bookingTimeStart.AutoSize = true;
            this.bookingTimeStart.Location = new System.Drawing.Point(4, 26);
            this.bookingTimeStart.Name = "bookingTimeStart";
            this.bookingTimeStart.Size = new System.Drawing.Size(159, 16);
            this.bookingTimeStart.TabIndex = 13;
            this.bookingTimeStart.Text = "Время бронирования с:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Cornsilk;
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.bookingTimeEnd);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.bookingTimeStart);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(0, 380);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 85);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Дата бронирования:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.groupBox2.Controls.Add(this.textBoxTotalCost);
            this.groupBox2.Controls.Add(this.totalCost);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(351, 380);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(309, 85);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Стоимость проживания:";
            // 
            // Project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(662, 518);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.calculation);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.btnClose);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(678, 557);
            this.MinimumSize = new System.Drawing.Size(678, 557);
            this.Name = "Project";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Хостел <<Топовая койка>>";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.calculation.ResumeLayout(false);
            this.calculation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.GroupBox calculation;
        private System.Windows.Forms.Label bookingTimeStart;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label bookingTimeEnd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label totalCost;
        private System.Windows.Forms.TextBox textBoxTotalCost;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem close;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem info;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.RadioButton radioButtonRoom1;
        private System.Windows.Forms.RadioButton radioButtonLuxe1;
        private System.Windows.Forms.RadioButton radioButtonRoom3;
        private System.Windows.Forms.RadioButton radioButtonRoom2;
        private System.Windows.Forms.RadioButton radioButtonLuxe2;
        private System.Windows.Forms.RadioButton radioButtonLuxe3;
        private System.Windows.Forms.ToolStripMenuItem Book;
    }
}

