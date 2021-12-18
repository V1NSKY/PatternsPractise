
namespace PatternsPractise.Forms
{
    partial class ReplicationTestForm
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
            this.testButton = new System.Windows.Forms.Button();
            this.writeNumberTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // testButton
            // 
            this.testButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(41)))));
            this.testButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.testButton.FlatAppearance.BorderSize = 0;
            this.testButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.testButton.ForeColor = System.Drawing.Color.White;
            this.testButton.Location = new System.Drawing.Point(12, 41);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(189, 23);
            this.testButton.TabIndex = 28;
            this.testButton.Text = "Тест";
            this.testButton.UseVisualStyleBackColor = false;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            // 
            // writeNumberTextBox
            // 
            this.writeNumberTextBox.Location = new System.Drawing.Point(12, 12);
            this.writeNumberTextBox.Name = "writeNumberTextBox";
            this.writeNumberTextBox.Size = new System.Drawing.Size(189, 23);
            this.writeNumberTextBox.TabIndex = 51;
            // 
            // ReplicationTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(32)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(213, 180);
            this.Controls.Add(this.writeNumberTextBox);
            this.Controls.Add(this.testButton);
            this.Name = "ReplicationTestForm";
            this.ShowIcon = false;
            this.Text = "Репликация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button testButton;
        private System.Windows.Forms.TextBox writeNumberTextBox;
    }
}