
namespace PatternsPractise.Forms
{
    partial class TEST
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.addedGenresLabel = new System.Windows.Forms.Label();
            this.addGenreButton = new System.Windows.Forms.Button();
            this.addGenreTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.addDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.addDateOfRelease = new System.Windows.Forms.TextBox();
            this.addPriceTextBox = new System.Windows.Forms.TextBox();
            this.addPublisherTextBox = new System.Windows.Forms.TextBox();
            this.addDeveloperTextBox = new System.Windows.Forms.TextBox();
            this.addNameTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gameGridView = new System.Windows.Forms.DataGridView();
            this.gameId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gameName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gameDeveloper = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gamePublisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gamePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gameDateOfRelease = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gameDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gameGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(41)))));
            this.addButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(633, 167);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(100, 23);
            this.addButton.TabIndex = 49;
            this.addButton.Text = "Добавить игру";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // addedGenresLabel
            // 
            this.addedGenresLabel.AutoSize = true;
            this.addedGenresLabel.ForeColor = System.Drawing.Color.White;
            this.addedGenresLabel.Location = new System.Drawing.Point(377, 114);
            this.addedGenresLabel.MaximumSize = new System.Drawing.Size(0, 50);
            this.addedGenresLabel.Name = "addedGenresLabel";
            this.addedGenresLabel.Size = new System.Drawing.Size(130, 15);
            this.addedGenresLabel.TabIndex = 47;
            this.addedGenresLabel.Text = "Добавленные жанры: ";
            // 
            // addGenreButton
            // 
            this.addGenreButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(41)))));
            this.addGenreButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addGenreButton.FlatAppearance.BorderSize = 0;
            this.addGenreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addGenreButton.ForeColor = System.Drawing.Color.White;
            this.addGenreButton.Location = new System.Drawing.Point(421, 80);
            this.addGenreButton.Name = "addGenreButton";
            this.addGenreButton.Size = new System.Drawing.Size(100, 23);
            this.addGenreButton.TabIndex = 46;
            this.addGenreButton.Text = "Добавить жанр";
            this.addGenreButton.UseVisualStyleBackColor = false;
            this.addGenreButton.Click += new System.EventHandler(this.addGenreButton_Click);
            // 
            // addGenreTextBox
            // 
            this.addGenreTextBox.Location = new System.Drawing.Point(421, 48);
            this.addGenreTextBox.Name = "addGenreTextBox";
            this.addGenreTextBox.Size = new System.Drawing.Size(100, 23);
            this.addGenreTextBox.TabIndex = 45;
            this.addGenreTextBox.Text = "Genre1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(377, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 15);
            this.label7.TabIndex = 44;
            this.label7.Text = "Жанр:";
            // 
            // addDescriptionTextBox
            // 
            this.addDescriptionTextBox.Location = new System.Drawing.Point(67, 214);
            this.addDescriptionTextBox.Multiline = true;
            this.addDescriptionTextBox.Name = "addDescriptionTextBox";
            this.addDescriptionTextBox.Size = new System.Drawing.Size(666, 25);
            this.addDescriptionTextBox.TabIndex = 43;
            this.addDescriptionTextBox.Text = "TestDescr";
            // 
            // addDateOfRelease
            // 
            this.addDateOfRelease.Location = new System.Drawing.Point(185, 164);
            this.addDateOfRelease.Name = "addDateOfRelease";
            this.addDateOfRelease.Size = new System.Drawing.Size(179, 23);
            this.addDateOfRelease.TabIndex = 42;
            this.addDateOfRelease.Text = "2021.01.01";
            // 
            // addPriceTextBox
            // 
            this.addPriceTextBox.Location = new System.Drawing.Point(185, 135);
            this.addPriceTextBox.Name = "addPriceTextBox";
            this.addPriceTextBox.Size = new System.Drawing.Size(179, 23);
            this.addPriceTextBox.TabIndex = 41;
            this.addPriceTextBox.Text = "1";
            // 
            // addPublisherTextBox
            // 
            this.addPublisherTextBox.Location = new System.Drawing.Point(185, 106);
            this.addPublisherTextBox.Name = "addPublisherTextBox";
            this.addPublisherTextBox.Size = new System.Drawing.Size(179, 23);
            this.addPublisherTextBox.TabIndex = 40;
            this.addPublisherTextBox.Text = "TestPub";
            // 
            // addDeveloperTextBox
            // 
            this.addDeveloperTextBox.Location = new System.Drawing.Point(185, 77);
            this.addDeveloperTextBox.Name = "addDeveloperTextBox";
            this.addDeveloperTextBox.Size = new System.Drawing.Size(179, 23);
            this.addDeveloperTextBox.TabIndex = 39;
            this.addDeveloperTextBox.Text = "Testdev";
            // 
            // addNameTextBox
            // 
            this.addNameTextBox.Location = new System.Drawing.Point(185, 48);
            this.addNameTextBox.Name = "addNameTextBox";
            this.addNameTextBox.Size = new System.Drawing.Size(179, 23);
            this.addNameTextBox.TabIndex = 38;
            this.addNameTextBox.Text = "TestName";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(67, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 15);
            this.label6.TabIndex = 37;
            this.label6.Text = "Описание:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(67, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 15);
            this.label5.TabIndex = 36;
            this.label5.Text = "Дата выхода:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(67, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 35;
            this.label4.Text = "Цена:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(67, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 34;
            this.label3.Text = "Издатель:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(67, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 33;
            this.label2.Text = "Разработчик:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(67, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 15);
            this.label8.TabIndex = 32;
            this.label8.Text = "Название:";
            // 
            // gameGridView
            // 
            this.gameGridView.AllowUserToAddRows = false;
            this.gameGridView.AllowUserToDeleteRows = false;
            this.gameGridView.AllowUserToResizeColumns = false;
            this.gameGridView.AllowUserToResizeRows = false;
            this.gameGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gameGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gameGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gameGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(57)))), ((int)(((byte)(75)))));
            this.gameGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gameGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(57)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3, 6, 3, 6);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(57)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gameGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gameGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gameGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gameId,
            this.gameName,
            this.gameDeveloper,
            this.gamePublisher,
            this.gamePrice,
            this.gameDateOfRelease,
            this.gameDescription});
            this.gameGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(57)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(3, 6, 3, 6);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(57)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gameGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.gameGridView.EnableHeadersVisualStyles = false;
            this.gameGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(71)))), ((int)(((byte)(86)))));
            this.gameGridView.Location = new System.Drawing.Point(27, 245);
            this.gameGridView.MultiSelect = false;
            this.gameGridView.Name = "gameGridView";
            this.gameGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gameGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(32)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gameGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gameGridView.RowHeadersVisible = false;
            this.gameGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gameGridView.RowTemplate.Height = 25;
            this.gameGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gameGridView.Size = new System.Drawing.Size(746, 391);
            this.gameGridView.TabIndex = 50;
            // 
            // gameId
            // 
            this.gameId.DataPropertyName = "GameId";
            this.gameId.HeaderText = "Код";
            this.gameId.Name = "gameId";
            this.gameId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.gameId.Visible = false;
            // 
            // gameName
            // 
            this.gameName.DataPropertyName = "GameName";
            this.gameName.HeaderText = "Название";
            this.gameName.Name = "gameName";
            this.gameName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // gameDeveloper
            // 
            this.gameDeveloper.DataPropertyName = "GameDeveloper";
            this.gameDeveloper.HeaderText = "Разработчик";
            this.gameDeveloper.Name = "gameDeveloper";
            this.gameDeveloper.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // gamePublisher
            // 
            this.gamePublisher.DataPropertyName = "GamePublisher";
            this.gamePublisher.HeaderText = "Издатель";
            this.gamePublisher.Name = "gamePublisher";
            this.gamePublisher.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // gamePrice
            // 
            this.gamePrice.DataPropertyName = "GamePrice";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.gamePrice.DefaultCellStyle = dataGridViewCellStyle2;
            this.gamePrice.HeaderText = "Цена";
            this.gamePrice.Name = "gamePrice";
            this.gamePrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // gameDateOfRelease
            // 
            this.gameDateOfRelease.DataPropertyName = "DateOfRelease";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.gameDateOfRelease.DefaultCellStyle = dataGridViewCellStyle3;
            this.gameDateOfRelease.HeaderText = "Дата выхода";
            this.gameDateOfRelease.Name = "gameDateOfRelease";
            this.gameDateOfRelease.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // gameDescription
            // 
            this.gameDescription.DataPropertyName = "GameDescription";
            this.gameDescription.HeaderText = "Описание";
            this.gameDescription.Name = "gameDescription";
            this.gameDescription.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.gameDescription.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(407, 164);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 51;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(41)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(513, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 52;
            this.button1.Text = "Удалить игру";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TEST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 648);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.gameGridView);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.addedGenresLabel);
            this.Controls.Add(this.addGenreButton);
            this.Controls.Add(this.addGenreTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.addDescriptionTextBox);
            this.Controls.Add(this.addDateOfRelease);
            this.Controls.Add(this.addPriceTextBox);
            this.Controls.Add(this.addPublisherTextBox);
            this.Controls.Add(this.addDeveloperTextBox);
            this.Controls.Add(this.addNameTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Name = "TEST";
            this.Text = "TEST";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TEST_FormClosing);
            this.Load += new System.EventHandler(this.TEST_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gameGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label addedGenresLabel;
        private System.Windows.Forms.Button addGenreButton;
        private System.Windows.Forms.TextBox addGenreTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox addDescriptionTextBox;
        private System.Windows.Forms.TextBox addDateOfRelease;
        private System.Windows.Forms.TextBox addPriceTextBox;
        private System.Windows.Forms.TextBox addPublisherTextBox;
        private System.Windows.Forms.TextBox addDeveloperTextBox;
        private System.Windows.Forms.TextBox addNameTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView gameGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn gameId;
        private System.Windows.Forms.DataGridViewTextBoxColumn gameName;
        private System.Windows.Forms.DataGridViewTextBoxColumn gameDeveloper;
        private System.Windows.Forms.DataGridViewTextBoxColumn gamePublisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn gamePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn gameDateOfRelease;
        private System.Windows.Forms.DataGridViewTextBoxColumn gameDescription;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}