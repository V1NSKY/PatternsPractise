
namespace PatternsPractise.Forms
{
    partial class DBTypeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.applyButton = new System.Windows.Forms.Button();
            this.mySQLRadioButton = new System.Windows.Forms.RadioButton();
            this.mongoDBRadioButton = new System.Windows.Forms.RadioButton();
            this.testButton = new System.Windows.Forms.Button();
            this.migrateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите тип БД";
            // 
            // applyButton
            // 
            this.applyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(41)))));
            this.applyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.applyButton.FlatAppearance.BorderSize = 0;
            this.applyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.applyButton.ForeColor = System.Drawing.Color.White;
            this.applyButton.Location = new System.Drawing.Point(25, 90);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(100, 50);
            this.applyButton.TabIndex = 22;
            this.applyButton.Text = "Применить";
            this.applyButton.UseVisualStyleBackColor = false;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // mySQLRadioButton
            // 
            this.mySQLRadioButton.AutoSize = true;
            this.mySQLRadioButton.ForeColor = System.Drawing.Color.White;
            this.mySQLRadioButton.Location = new System.Drawing.Point(25, 36);
            this.mySQLRadioButton.Name = "mySQLRadioButton";
            this.mySQLRadioButton.Size = new System.Drawing.Size(63, 19);
            this.mySQLRadioButton.TabIndex = 23;
            this.mySQLRadioButton.TabStop = true;
            this.mySQLRadioButton.Text = "MySQL";
            this.mySQLRadioButton.UseVisualStyleBackColor = true;
            // 
            // mongoDBRadioButton
            // 
            this.mongoDBRadioButton.AutoSize = true;
            this.mongoDBRadioButton.ForeColor = System.Drawing.Color.White;
            this.mongoDBRadioButton.Location = new System.Drawing.Point(25, 61);
            this.mongoDBRadioButton.Name = "mongoDBRadioButton";
            this.mongoDBRadioButton.Size = new System.Drawing.Size(79, 19);
            this.mongoDBRadioButton.TabIndex = 24;
            this.mongoDBRadioButton.TabStop = true;
            this.mongoDBRadioButton.Text = "MongoDB";
            this.mongoDBRadioButton.UseVisualStyleBackColor = true;
            // 
            // testButton
            // 
            this.testButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(41)))));
            this.testButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.testButton.FlatAppearance.BorderSize = 0;
            this.testButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.testButton.ForeColor = System.Drawing.Color.White;
            this.testButton.Location = new System.Drawing.Point(25, 146);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(100, 23);
            this.testButton.TabIndex = 25;
            this.testButton.Text = "Тест";
            this.testButton.UseVisualStyleBackColor = false;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            // 
            // migrateButton
            // 
            this.migrateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(41)))));
            this.migrateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.migrateButton.FlatAppearance.BorderSize = 0;
            this.migrateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.migrateButton.ForeColor = System.Drawing.Color.White;
            this.migrateButton.Location = new System.Drawing.Point(25, 175);
            this.migrateButton.Name = "migrateButton";
            this.migrateButton.Size = new System.Drawing.Size(100, 23);
            this.migrateButton.TabIndex = 26;
            this.migrateButton.Text = "Миграция";
            this.migrateButton.UseVisualStyleBackColor = false;
            this.migrateButton.Click += new System.EventHandler(this.migrateButton_Click);
            // 
            // DBTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(32)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(153, 207);
            this.Controls.Add(this.migrateButton);
            this.Controls.Add(this.testButton);
            this.Controls.Add(this.mongoDBRadioButton);
            this.Controls.Add(this.mySQLRadioButton);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DBTypeForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Тип базы данных";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.RadioButton mySQLRadioButton;
        private System.Windows.Forms.RadioButton mongoDBRadioButton;
        private System.Windows.Forms.Button testButton;
        private System.Windows.Forms.Button migrateButton;
    }
}