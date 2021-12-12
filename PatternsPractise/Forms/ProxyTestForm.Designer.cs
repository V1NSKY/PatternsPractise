
namespace PatternsPractise.Forms
{
    partial class ProxyTestForm
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
            this.gameGridView = new System.Windows.Forms.DataGridView();
            this.gameId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gameName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gameDeveloper = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gamePublisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gamePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gameDateOfRelease = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gameDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteGameButton = new System.Windows.Forms.Button();
            this.changeGameButton = new System.Windows.Forms.Button();
            this.addGameButton = new System.Windows.Forms.Button();
            this.roleLabel = new System.Windows.Forms.Label();
            this.userRoleLabel = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.userLabel = new System.Windows.Forms.Label();
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.logOutButton = new System.Windows.Forms.Button();
            this.loginInButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gameGridView)).BeginInit();
            this.SuspendLayout();
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
            this.gameGridView.Location = new System.Drawing.Point(288, 68);
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
            this.gameGridView.Size = new System.Drawing.Size(584, 484);
            this.gameGridView.TabIndex = 2;
            this.gameGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gameGridView_CellContentDoubleClick);
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
            // deleteGameButton
            // 
            this.deleteGameButton.BackColor = System.Drawing.Color.Green;
            this.deleteGameButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteGameButton.FlatAppearance.BorderSize = 0;
            this.deleteGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteGameButton.ForeColor = System.Drawing.Color.White;
            this.deleteGameButton.Location = new System.Drawing.Point(105, 290);
            this.deleteGameButton.Name = "deleteGameButton";
            this.deleteGameButton.Size = new System.Drawing.Size(71, 29);
            this.deleteGameButton.TabIndex = 27;
            this.deleteGameButton.Text = "Удалить игру";
            this.deleteGameButton.UseVisualStyleBackColor = false;
            this.deleteGameButton.Click += new System.EventHandler(this.deleteGameButton_Click);
            // 
            // changeGameButton
            // 
            this.changeGameButton.BackColor = System.Drawing.Color.Green;
            this.changeGameButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changeGameButton.FlatAppearance.BorderSize = 0;
            this.changeGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeGameButton.ForeColor = System.Drawing.Color.White;
            this.changeGameButton.Location = new System.Drawing.Point(197, 255);
            this.changeGameButton.Name = "changeGameButton";
            this.changeGameButton.Size = new System.Drawing.Size(71, 29);
            this.changeGameButton.TabIndex = 26;
            this.changeGameButton.Text = "Изменить игру";
            this.changeGameButton.UseVisualStyleBackColor = false;
            this.changeGameButton.Click += new System.EventHandler(this.changeGameButton_Click);
            // 
            // addGameButton
            // 
            this.addGameButton.BackColor = System.Drawing.Color.Green;
            this.addGameButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addGameButton.FlatAppearance.BorderSize = 0;
            this.addGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addGameButton.ForeColor = System.Drawing.Color.White;
            this.addGameButton.Location = new System.Drawing.Point(105, 255);
            this.addGameButton.Name = "addGameButton";
            this.addGameButton.Size = new System.Drawing.Size(71, 29);
            this.addGameButton.TabIndex = 25;
            this.addGameButton.Text = "Добавить игру";
            this.addGameButton.UseVisualStyleBackColor = false;
            this.addGameButton.Click += new System.EventHandler(this.addGameButton_Click);
            // 
            // roleLabel
            // 
            this.roleLabel.AutoSize = true;
            this.roleLabel.ForeColor = System.Drawing.Color.White;
            this.roleLabel.Location = new System.Drawing.Point(12, 35);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(37, 15);
            this.roleLabel.TabIndex = 31;
            this.roleLabel.Text = "Роль:";
            // 
            // userRoleLabel
            // 
            this.userRoleLabel.AutoSize = true;
            this.userRoleLabel.ForeColor = System.Drawing.Color.White;
            this.userRoleLabel.Location = new System.Drawing.Point(105, 35);
            this.userRoleLabel.Name = "userRoleLabel";
            this.userRoleLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.userRoleLabel.Size = new System.Drawing.Size(34, 15);
            this.userRoleLabel.TabIndex = 30;
            this.userRoleLabel.Text = "Роль";
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.ForeColor = System.Drawing.Color.White;
            this.userNameLabel.Location = new System.Drawing.Point(105, 12);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.userNameLabel.Size = new System.Drawing.Size(31, 15);
            this.userNameLabel.TabIndex = 29;
            this.userNameLabel.Text = "Имя";
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.ForeColor = System.Drawing.Color.White;
            this.userLabel.Location = new System.Drawing.Point(12, 12);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(87, 15);
            this.userLabel.TabIndex = 28;
            this.userLabel.Text = "Пользователь:";
            // 
            // addDescriptionTextBox
            // 
            this.addDescriptionTextBox.Location = new System.Drawing.Point(130, 226);
            this.addDescriptionTextBox.Multiline = true;
            this.addDescriptionTextBox.Name = "addDescriptionTextBox";
            this.addDescriptionTextBox.Size = new System.Drawing.Size(152, 23);
            this.addDescriptionTextBox.TabIndex = 55;
            // 
            // addDateOfRelease
            // 
            this.addDateOfRelease.Location = new System.Drawing.Point(130, 197);
            this.addDateOfRelease.Name = "addDateOfRelease";
            this.addDateOfRelease.Size = new System.Drawing.Size(152, 23);
            this.addDateOfRelease.TabIndex = 54;
            // 
            // addPriceTextBox
            // 
            this.addPriceTextBox.Location = new System.Drawing.Point(130, 168);
            this.addPriceTextBox.Name = "addPriceTextBox";
            this.addPriceTextBox.Size = new System.Drawing.Size(152, 23);
            this.addPriceTextBox.TabIndex = 53;
            // 
            // addPublisherTextBox
            // 
            this.addPublisherTextBox.Location = new System.Drawing.Point(130, 139);
            this.addPublisherTextBox.Name = "addPublisherTextBox";
            this.addPublisherTextBox.Size = new System.Drawing.Size(152, 23);
            this.addPublisherTextBox.TabIndex = 52;
            // 
            // addDeveloperTextBox
            // 
            this.addDeveloperTextBox.Location = new System.Drawing.Point(130, 110);
            this.addDeveloperTextBox.Name = "addDeveloperTextBox";
            this.addDeveloperTextBox.Size = new System.Drawing.Size(152, 23);
            this.addDeveloperTextBox.TabIndex = 51;
            // 
            // addNameTextBox
            // 
            this.addNameTextBox.Location = new System.Drawing.Point(130, 81);
            this.addNameTextBox.Name = "addNameTextBox";
            this.addNameTextBox.Size = new System.Drawing.Size(152, 23);
            this.addNameTextBox.TabIndex = 50;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 15);
            this.label6.TabIndex = 49;
            this.label6.Text = "Описание:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 15);
            this.label5.TabIndex = 48;
            this.label5.Text = "Дата выхода:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 47;
            this.label4.Text = "Цена:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 46;
            this.label3.Text = "Издатель:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 45;
            this.label2.Text = "Разработчик:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 44;
            this.label1.Text = "Название:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 29);
            this.button1.TabIndex = 56;
            this.button1.Text = "Очистить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // loginTextBox
            // 
            this.loginTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.loginTextBox.Location = new System.Drawing.Point(454, 27);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.PlaceholderText = "Логин";
            this.loginTextBox.Size = new System.Drawing.Size(100, 23);
            this.loginTextBox.TabIndex = 60;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordTextBox.Location = new System.Drawing.Point(560, 27);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.PlaceholderText = "Пароль";
            this.passwordTextBox.Size = new System.Drawing.Size(100, 23);
            this.passwordTextBox.TabIndex = 59;
            // 
            // logOutButton
            // 
            this.logOutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logOutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(41)))));
            this.logOutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logOutButton.FlatAppearance.BorderSize = 0;
            this.logOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOutButton.ForeColor = System.Drawing.Color.White;
            this.logOutButton.Location = new System.Drawing.Point(772, 12);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(100, 50);
            this.logOutButton.TabIndex = 58;
            this.logOutButton.Text = "Выйти";
            this.logOutButton.UseVisualStyleBackColor = false;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // loginInButton
            // 
            this.loginInButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.loginInButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(41)))));
            this.loginInButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginInButton.FlatAppearance.BorderSize = 0;
            this.loginInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginInButton.ForeColor = System.Drawing.Color.White;
            this.loginInButton.Location = new System.Drawing.Point(666, 12);
            this.loginInButton.Name = "loginInButton";
            this.loginInButton.Size = new System.Drawing.Size(100, 50);
            this.loginInButton.TabIndex = 57;
            this.loginInButton.Text = "Войти";
            this.loginInButton.UseVisualStyleBackColor = false;
            this.loginInButton.Click += new System.EventHandler(this.loginInButton_Click);
            // 
            // ProxyTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(32)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(884, 564);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.loginInButton);
            this.Controls.Add(this.button1);
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
            this.Controls.Add(this.label1);
            this.Controls.Add(this.roleLabel);
            this.Controls.Add(this.userRoleLabel);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.deleteGameButton);
            this.Controls.Add(this.changeGameButton);
            this.Controls.Add(this.addGameButton);
            this.Controls.Add(this.gameGridView);
            this.Name = "ProxyTestForm";
            this.ShowIcon = false;
            this.Text = "ProxyTestForm";
            this.Load += new System.EventHandler(this.ProxyTestForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gameGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gameGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn gameId;
        private System.Windows.Forms.DataGridViewTextBoxColumn gameName;
        private System.Windows.Forms.DataGridViewTextBoxColumn gameDeveloper;
        private System.Windows.Forms.DataGridViewTextBoxColumn gamePublisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn gamePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn gameDateOfRelease;
        private System.Windows.Forms.DataGridViewTextBoxColumn gameDescription;
        private System.Windows.Forms.Button deleteGameButton;
        private System.Windows.Forms.Button changeGameButton;
        private System.Windows.Forms.Button addGameButton;
        private System.Windows.Forms.Label roleLabel;
        private System.Windows.Forms.Label userRoleLabel;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label userLabel;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Button loginInButton;
    }
}