
namespace PatternsPractise
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.registerButton = new System.Windows.Forms.Button();
            this.gameGridView = new System.Windows.Forms.DataGridView();
            this.gameId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gameName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gameDeveloper = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gamePublisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gamePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gameDateOfRelease = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gameDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginInButton = new System.Windows.Forms.Button();
            this.logOutButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.userLabel = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.userRoleLabel = new System.Windows.Forms.Label();
            this.notUserLabel = new System.Windows.Forms.Label();
            this.roleLabel = new System.Windows.Forms.Label();
            this.addGameButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.SearchByNameButton = new System.Windows.Forms.Button();
            this.changeGameButton = new System.Windows.Forms.Button();
            this.addUserButton = new System.Windows.Forms.Button();
            this.gameInfoButton = new System.Windows.Forms.Button();
            this.libraryButton = new System.Windows.Forms.Button();
            this.isAddedLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.deleteGameButton = new System.Windows.Forms.Button();
            this.updateGridButton = new System.Windows.Forms.Button();
            this.changeUserButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gameGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // registerButton
            // 
            this.registerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.registerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(41)))));
            this.registerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerButton.FlatAppearance.BorderSize = 0;
            this.registerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerButton.ForeColor = System.Drawing.Color.White;
            this.registerButton.Location = new System.Drawing.Point(740, 12);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(132, 50);
            this.registerButton.TabIndex = 0;
            this.registerButton.Text = "Зарегистрироваться";
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
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
            this.gameGridView.Location = new System.Drawing.Point(126, 68);
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
            this.gameGridView.Size = new System.Drawing.Size(746, 448);
            this.gameGridView.TabIndex = 1;
            this.gameGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gameGridView_CellContentDoubleClick);
            this.gameGridView.SelectionChanged += new System.EventHandler(this.gameGridView_SelectionChanged);
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
            // loginInButton
            // 
            this.loginInButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.loginInButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(41)))));
            this.loginInButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginInButton.FlatAppearance.BorderSize = 0;
            this.loginInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginInButton.ForeColor = System.Drawing.Color.White;
            this.loginInButton.Location = new System.Drawing.Point(634, 12);
            this.loginInButton.Name = "loginInButton";
            this.loginInButton.Size = new System.Drawing.Size(100, 50);
            this.loginInButton.TabIndex = 2;
            this.loginInButton.Text = "Войти";
            this.loginInButton.UseVisualStyleBackColor = false;
            this.loginInButton.Click += new System.EventHandler(this.loginInButton_Click);
            // 
            // logOutButton
            // 
            this.logOutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logOutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(41)))));
            this.logOutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logOutButton.FlatAppearance.BorderSize = 0;
            this.logOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOutButton.ForeColor = System.Drawing.Color.White;
            this.logOutButton.Location = new System.Drawing.Point(634, 12);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(100, 50);
            this.logOutButton.TabIndex = 3;
            this.logOutButton.Text = "Выйти";
            this.logOutButton.UseVisualStyleBackColor = false;
            this.logOutButton.Visible = false;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(41)))));
            this.addButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(15, 153);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(100, 50);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Visible = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordTextBox.Location = new System.Drawing.Point(528, 27);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.PlaceholderText = "Пароль";
            this.passwordTextBox.Size = new System.Drawing.Size(100, 23);
            this.passwordTextBox.TabIndex = 5;
            // 
            // loginTextBox
            // 
            this.loginTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.loginTextBox.Location = new System.Drawing.Point(422, 27);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.PlaceholderText = "Логин";
            this.loginTextBox.Size = new System.Drawing.Size(100, 23);
            this.loginTextBox.TabIndex = 6;
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.ForeColor = System.Drawing.Color.White;
            this.userLabel.Location = new System.Drawing.Point(15, 12);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(87, 15);
            this.userLabel.TabIndex = 9;
            this.userLabel.Text = "Пользователь:";
            this.userLabel.Visible = false;
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.ForeColor = System.Drawing.Color.White;
            this.userNameLabel.Location = new System.Drawing.Point(108, 12);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.userNameLabel.Size = new System.Drawing.Size(31, 15);
            this.userNameLabel.TabIndex = 10;
            this.userNameLabel.Text = "Имя";
            this.userNameLabel.Visible = false;
            // 
            // userRoleLabel
            // 
            this.userRoleLabel.AutoSize = true;
            this.userRoleLabel.ForeColor = System.Drawing.Color.White;
            this.userRoleLabel.Location = new System.Drawing.Point(108, 35);
            this.userRoleLabel.Name = "userRoleLabel";
            this.userRoleLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.userRoleLabel.Size = new System.Drawing.Size(34, 15);
            this.userRoleLabel.TabIndex = 12;
            this.userRoleLabel.Text = "Роль";
            this.userRoleLabel.Visible = false;
            // 
            // notUserLabel
            // 
            this.notUserLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.notUserLabel.AutoSize = true;
            this.notUserLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(41)))));
            this.notUserLabel.Location = new System.Drawing.Point(445, 9);
            this.notUserLabel.Name = "notUserLabel";
            this.notUserLabel.Size = new System.Drawing.Size(166, 15);
            this.notUserLabel.TabIndex = 13;
            this.notUserLabel.Text = "Логин либо пароль неверны";
            this.notUserLabel.Visible = false;
            // 
            // roleLabel
            // 
            this.roleLabel.AutoSize = true;
            this.roleLabel.ForeColor = System.Drawing.Color.White;
            this.roleLabel.Location = new System.Drawing.Point(15, 35);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(37, 15);
            this.roleLabel.TabIndex = 14;
            this.roleLabel.Text = "Роль:";
            this.roleLabel.Visible = false;
            // 
            // addGameButton
            // 
            this.addGameButton.BackColor = System.Drawing.Color.Green;
            this.addGameButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addGameButton.FlatAppearance.BorderSize = 0;
            this.addGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addGameButton.ForeColor = System.Drawing.Color.White;
            this.addGameButton.Location = new System.Drawing.Point(15, 352);
            this.addGameButton.Name = "addGameButton";
            this.addGameButton.Size = new System.Drawing.Size(100, 50);
            this.addGameButton.TabIndex = 15;
            this.addGameButton.Text = "Добавить игру";
            this.addGameButton.UseVisualStyleBackColor = false;
            this.addGameButton.Visible = false;
            this.addGameButton.Click += new System.EventHandler(this.addGameButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(15, 209);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.PlaceholderText = "Название игры";
            this.searchTextBox.Size = new System.Drawing.Size(100, 23);
            this.searchTextBox.TabIndex = 16;
            // 
            // SearchByNameButton
            // 
            this.SearchByNameButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(41)))));
            this.SearchByNameButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchByNameButton.FlatAppearance.BorderSize = 0;
            this.SearchByNameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchByNameButton.ForeColor = System.Drawing.Color.White;
            this.SearchByNameButton.Location = new System.Drawing.Point(15, 238);
            this.SearchByNameButton.Name = "SearchByNameButton";
            this.SearchByNameButton.Size = new System.Drawing.Size(100, 23);
            this.SearchByNameButton.TabIndex = 17;
            this.SearchByNameButton.Text = "Поиск";
            this.SearchByNameButton.UseVisualStyleBackColor = false;
            this.SearchByNameButton.Click += new System.EventHandler(this.SearchByNameButton_Click);
            // 
            // changeGameButton
            // 
            this.changeGameButton.BackColor = System.Drawing.Color.Green;
            this.changeGameButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changeGameButton.FlatAppearance.BorderSize = 0;
            this.changeGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeGameButton.ForeColor = System.Drawing.Color.White;
            this.changeGameButton.Location = new System.Drawing.Point(15, 437);
            this.changeGameButton.Name = "changeGameButton";
            this.changeGameButton.Size = new System.Drawing.Size(100, 23);
            this.changeGameButton.TabIndex = 18;
            this.changeGameButton.Text = "Изменить игру";
            this.changeGameButton.UseVisualStyleBackColor = false;
            this.changeGameButton.Visible = false;
            this.changeGameButton.Click += new System.EventHandler(this.changeGameButton_Click);
            // 
            // addUserButton
            // 
            this.addUserButton.BackColor = System.Drawing.Color.Green;
            this.addUserButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addUserButton.FlatAppearance.BorderSize = 0;
            this.addUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addUserButton.ForeColor = System.Drawing.Color.White;
            this.addUserButton.Location = new System.Drawing.Point(15, 466);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(100, 50);
            this.addUserButton.TabIndex = 19;
            this.addUserButton.Text = "Добавить пользователя";
            this.addUserButton.UseVisualStyleBackColor = false;
            this.addUserButton.Visible = false;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // gameInfoButton
            // 
            this.gameInfoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(41)))));
            this.gameInfoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gameInfoButton.FlatAppearance.BorderSize = 0;
            this.gameInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gameInfoButton.ForeColor = System.Drawing.Color.White;
            this.gameInfoButton.Location = new System.Drawing.Point(15, 97);
            this.gameInfoButton.Name = "gameInfoButton";
            this.gameInfoButton.Size = new System.Drawing.Size(100, 50);
            this.gameInfoButton.TabIndex = 20;
            this.gameInfoButton.Text = "Подробнее";
            this.gameInfoButton.UseVisualStyleBackColor = false;
            this.gameInfoButton.Click += new System.EventHandler(this.gameInfoButton_Click);
            // 
            // libraryButton
            // 
            this.libraryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(41)))));
            this.libraryButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.libraryButton.FlatAppearance.BorderSize = 0;
            this.libraryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.libraryButton.ForeColor = System.Drawing.Color.White;
            this.libraryButton.Location = new System.Drawing.Point(316, 12);
            this.libraryButton.Name = "libraryButton";
            this.libraryButton.Size = new System.Drawing.Size(100, 50);
            this.libraryButton.TabIndex = 21;
            this.libraryButton.Text = "Библиотека";
            this.libraryButton.UseVisualStyleBackColor = false;
            this.libraryButton.Visible = false;
            this.libraryButton.Click += new System.EventHandler(this.libraryButton_Click);
            // 
            // isAddedLabel
            // 
            this.isAddedLabel.AutoSize = true;
            this.isAddedLabel.ForeColor = System.Drawing.Color.Green;
            this.isAddedLabel.Location = new System.Drawing.Point(439, 50);
            this.isAddedLabel.Name = "isAddedLabel";
            this.isAddedLabel.Size = new System.Drawing.Size(172, 15);
            this.isAddedLabel.TabIndex = 22;
            this.isAddedLabel.Text = "Игра добавлена в библиотеку";
            this.isAddedLabel.Visible = false;
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(41)))));
            this.clearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearButton.FlatAppearance.BorderSize = 0;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.ForeColor = System.Drawing.Color.White;
            this.clearButton.Location = new System.Drawing.Point(15, 267);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(100, 23);
            this.clearButton.TabIndex = 23;
            this.clearButton.Text = "Очистить";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Visible = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // deleteGameButton
            // 
            this.deleteGameButton.BackColor = System.Drawing.Color.Green;
            this.deleteGameButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteGameButton.FlatAppearance.BorderSize = 0;
            this.deleteGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteGameButton.ForeColor = System.Drawing.Color.White;
            this.deleteGameButton.Location = new System.Drawing.Point(15, 408);
            this.deleteGameButton.Name = "deleteGameButton";
            this.deleteGameButton.Size = new System.Drawing.Size(100, 23);
            this.deleteGameButton.TabIndex = 24;
            this.deleteGameButton.Text = "Удалить игру";
            this.deleteGameButton.UseVisualStyleBackColor = false;
            this.deleteGameButton.Visible = false;
            this.deleteGameButton.Click += new System.EventHandler(this.deleteGameButton_Click);
            // 
            // updateGridButton
            // 
            this.updateGridButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(41)))));
            this.updateGridButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateGridButton.FlatAppearance.BorderSize = 0;
            this.updateGridButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateGridButton.ForeColor = System.Drawing.Color.White;
            this.updateGridButton.Location = new System.Drawing.Point(15, 68);
            this.updateGridButton.Name = "updateGridButton";
            this.updateGridButton.Size = new System.Drawing.Size(100, 23);
            this.updateGridButton.TabIndex = 25;
            this.updateGridButton.Text = "Обновить";
            this.updateGridButton.UseVisualStyleBackColor = false;
            this.updateGridButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // changeUserButton
            // 
            this.changeUserButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(41)))));
            this.changeUserButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changeUserButton.FlatAppearance.BorderSize = 0;
            this.changeUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeUserButton.ForeColor = System.Drawing.Color.White;
            this.changeUserButton.Location = new System.Drawing.Point(15, 296);
            this.changeUserButton.Name = "changeUserButton";
            this.changeUserButton.Size = new System.Drawing.Size(100, 50);
            this.changeUserButton.TabIndex = 26;
            this.changeUserButton.Text = "Изменить пользователя";
            this.changeUserButton.UseVisualStyleBackColor = false;
            this.changeUserButton.Visible = false;
            this.changeUserButton.Click += new System.EventHandler(this.changeUserButton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(32)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(884, 528);
            this.Controls.Add(this.changeUserButton);
            this.Controls.Add(this.updateGridButton);
            this.Controls.Add(this.deleteGameButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.isAddedLabel);
            this.Controls.Add(this.libraryButton);
            this.Controls.Add(this.gameInfoButton);
            this.Controls.Add(this.addUserButton);
            this.Controls.Add(this.changeGameButton);
            this.Controls.Add(this.SearchByNameButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.addGameButton);
            this.Controls.Add(this.roleLabel);
            this.Controls.Add(this.notUserLabel);
            this.Controls.Add(this.userRoleLabel);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.loginInButton);
            this.Controls.Add(this.gameGridView);
            this.Controls.Add(this.registerButton);
            this.MinimumSize = new System.Drawing.Size(900, 567);
            this.Name = "MainMenu";
            this.ShowIcon = false;
            this.Text = "Main Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenu_FormClosing);
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gameGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.DataGridView gameGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn gameId;
        private System.Windows.Forms.DataGridViewTextBoxColumn gameName;
        private System.Windows.Forms.DataGridViewTextBoxColumn gameDeveloper;
        private System.Windows.Forms.DataGridViewTextBoxColumn gamePublisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn gamePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn gameDateOfRelease;
        private System.Windows.Forms.DataGridViewTextBoxColumn gameDescription;
        private System.Windows.Forms.Button loginInButton;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label userRoleLabel;
        private System.Windows.Forms.Label notUserLabel;
        private System.Windows.Forms.Label roleLabel;
        private System.Windows.Forms.Button addGameButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button SearchByNameButton;
        private System.Windows.Forms.Button changeGameButton;
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.Button gameInfoButton;
        private System.Windows.Forms.Button libraryButton;
        private System.Windows.Forms.Label isAddedLabel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button deleteGameButton;
        private System.Windows.Forms.Button updateGridButton;
        private System.Windows.Forms.Button changeUserButton;
    }
}

