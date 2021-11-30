
namespace PatternsPractise.Forms
{
    partial class MigrateForm
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
            this.migrateButton = new System.Windows.Forms.Button();
            this.mySqlMongoRadioButton = new System.Windows.Forms.RadioButton();
            this.mongoMySqlRadioButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // migrateButton
            // 
            this.migrateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(41)))));
            this.migrateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.migrateButton.FlatAppearance.BorderSize = 0;
            this.migrateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.migrateButton.ForeColor = System.Drawing.Color.White;
            this.migrateButton.Location = new System.Drawing.Point(27, 71);
            this.migrateButton.Name = "migrateButton";
            this.migrateButton.Size = new System.Drawing.Size(100, 23);
            this.migrateButton.TabIndex = 27;
            this.migrateButton.Text = "Миграция";
            this.migrateButton.UseVisualStyleBackColor = false;
            this.migrateButton.Click += new System.EventHandler(this.migrateButton_Click);
            // 
            // mySqlMongoRadioButton
            // 
            this.mySqlMongoRadioButton.AutoSize = true;
            this.mySqlMongoRadioButton.ForeColor = System.Drawing.Color.White;
            this.mySqlMongoRadioButton.Location = new System.Drawing.Point(12, 12);
            this.mySqlMongoRadioButton.Name = "mySqlMongoRadioButton";
            this.mySqlMongoRadioButton.Size = new System.Drawing.Size(136, 19);
            this.mySqlMongoRadioButton.TabIndex = 28;
            this.mySqlMongoRadioButton.TabStop = true;
            this.mySqlMongoRadioButton.Text = "MySQL -> MongoDB";
            this.mySqlMongoRadioButton.UseVisualStyleBackColor = true;
            // 
            // mongoMySqlRadioButton
            // 
            this.mongoMySqlRadioButton.AutoSize = true;
            this.mongoMySqlRadioButton.ForeColor = System.Drawing.Color.White;
            this.mongoMySqlRadioButton.Location = new System.Drawing.Point(12, 37);
            this.mongoMySqlRadioButton.Name = "mongoMySqlRadioButton";
            this.mongoMySqlRadioButton.Size = new System.Drawing.Size(139, 19);
            this.mongoMySqlRadioButton.TabIndex = 29;
            this.mongoMySqlRadioButton.TabStop = true;
            this.mongoMySqlRadioButton.Text = "MongoDB  -> MySQL";
            this.mongoMySqlRadioButton.UseVisualStyleBackColor = true;
            // 
            // MigrateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(32)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(161, 107);
            this.Controls.Add(this.mongoMySqlRadioButton);
            this.Controls.Add(this.mySqlMongoRadioButton);
            this.Controls.Add(this.migrateButton);
            this.Name = "MigrateForm";
            this.ShowIcon = false;
            this.Text = "Миграция";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button migrateButton;
        private System.Windows.Forms.RadioButton mySqlMongoRadioButton;
        private System.Windows.Forms.RadioButton mongoMySqlRadioButton;
    }
}