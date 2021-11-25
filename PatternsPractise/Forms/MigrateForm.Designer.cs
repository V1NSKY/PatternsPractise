
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
            this.SuspendLayout();
            // 
            // migrateButton
            // 
            this.migrateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(41)))));
            this.migrateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.migrateButton.FlatAppearance.BorderSize = 0;
            this.migrateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.migrateButton.ForeColor = System.Drawing.Color.White;
            this.migrateButton.Location = new System.Drawing.Point(110, 72);
            this.migrateButton.Name = "migrateButton";
            this.migrateButton.Size = new System.Drawing.Size(100, 23);
            this.migrateButton.TabIndex = 27;
            this.migrateButton.Text = "Миграция";
            this.migrateButton.UseVisualStyleBackColor = false;
            this.migrateButton.Click += new System.EventHandler(this.migrateButton_Click);
            // 
            // MigrateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(32)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(330, 195);
            this.Controls.Add(this.migrateButton);
            this.Name = "MigrateForm";
            this.ShowIcon = false;
            this.Text = "Миграция";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button migrateButton;
    }
}