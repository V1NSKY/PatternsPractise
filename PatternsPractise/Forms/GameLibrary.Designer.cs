
namespace PatternsPractise.Forms
{
    partial class GameLibrary
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gameGridView = new System.Windows.Forms.DataGridView();
            this.backButton = new System.Windows.Forms.Button();
            this.deleteGameButton = new System.Windows.Forms.Button();
            this.isDeletedLabel = new System.Windows.Forms.Label();
            this.gameId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gameName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateAdded = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoursPlayed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateLastPlayed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.game = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.dateAdded,
            this.hoursPlayed,
            this.dateLastPlayed,
            this.user,
            this.game});
            this.gameGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(57)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3, 6, 3, 6);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gameGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.gameGridView.EnableHeadersVisualStyles = false;
            this.gameGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(71)))), ((int)(((byte)(86)))));
            this.gameGridView.Location = new System.Drawing.Point(12, 73);
            this.gameGridView.MultiSelect = false;
            this.gameGridView.Name = "gameGridView";
            this.gameGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gameGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(32)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gameGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gameGridView.RowHeadersVisible = false;
            this.gameGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gameGridView.RowTemplate.Height = 25;
            this.gameGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gameGridView.Size = new System.Drawing.Size(860, 426);
            this.gameGridView.TabIndex = 2;
            // 
            // backButton
            // 
            this.backButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(41)))));
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(772, 17);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(100, 50);
            this.backButton.TabIndex = 4;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // deleteGameButton
            // 
            this.deleteGameButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteGameButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(41)))));
            this.deleteGameButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteGameButton.FlatAppearance.BorderSize = 0;
            this.deleteGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteGameButton.ForeColor = System.Drawing.Color.White;
            this.deleteGameButton.Location = new System.Drawing.Point(666, 17);
            this.deleteGameButton.Name = "deleteGameButton";
            this.deleteGameButton.Size = new System.Drawing.Size(100, 50);
            this.deleteGameButton.TabIndex = 5;
            this.deleteGameButton.Text = "Удалить";
            this.deleteGameButton.UseVisualStyleBackColor = false;
            this.deleteGameButton.Click += new System.EventHandler(this.deleteGameButton_Click);
            // 
            // isDeletedLabel
            // 
            this.isDeletedLabel.AutoSize = true;
            this.isDeletedLabel.ForeColor = System.Drawing.Color.Green;
            this.isDeletedLabel.Location = new System.Drawing.Point(12, 52);
            this.isDeletedLabel.Name = "isDeletedLabel";
            this.isDeletedLabel.Size = new System.Drawing.Size(172, 15);
            this.isDeletedLabel.TabIndex = 23;
            this.isDeletedLabel.Text = "Игра добавлена в библиотеку";
            this.isDeletedLabel.Visible = false;
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
            // dateAdded
            // 
            this.dateAdded.DataPropertyName = "DateAdded";
            this.dateAdded.HeaderText = "Дата добавления";
            this.dateAdded.Name = "dateAdded";
            this.dateAdded.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // hoursPlayed
            // 
            this.hoursPlayed.DataPropertyName = "HoursPlayed";
            this.hoursPlayed.HeaderText = "Время игры";
            this.hoursPlayed.Name = "hoursPlayed";
            this.hoursPlayed.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dateLastPlayed
            // 
            this.dateLastPlayed.DataPropertyName = "DateLastPlayed";
            this.dateLastPlayed.HeaderText = "Последний запуск";
            this.dateLastPlayed.Name = "dateLastPlayed";
            this.dateLastPlayed.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // user
            // 
            this.user.DataPropertyName = "User";
            this.user.HeaderText = "user";
            this.user.Name = "user";
            this.user.Visible = false;
            // 
            // game
            // 
            this.game.DataPropertyName = "Game";
            this.game.HeaderText = "game";
            this.game.Name = "game";
            this.game.Visible = false;
            // 
            // GameLibrary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(32)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.Controls.Add(this.isDeletedLabel);
            this.Controls.Add(this.deleteGameButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.gameGridView);
            this.Name = "GameLibrary";
            this.ShowIcon = false;
            this.Text = "Библиотека игор";
            this.Load += new System.EventHandler(this.GameLibrary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gameGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gameGridView;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button deleteGameButton;
        private System.Windows.Forms.Label isDeletedLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn gameId;
        private System.Windows.Forms.DataGridViewTextBoxColumn gameName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateAdded;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoursPlayed;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateLastPlayed;
        private System.Windows.Forms.DataGridViewTextBoxColumn user;
        private System.Windows.Forms.DataGridViewTextBoxColumn game;
    }
}