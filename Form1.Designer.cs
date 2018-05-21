namespace TimeoutBeater
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.processesBox = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(343, 371);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Restore Defaults";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // processesBox
            // 
            this.processesBox.FormattingEnabled = true;
            this.processesBox.Location = new System.Drawing.Point(165, 358);
            this.processesBox.Name = "processesBox";
            this.processesBox.Size = new System.Drawing.Size(120, 94);
            this.processesBox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AccessibleDescription = "Settings";
            this.AccessibleName = "Settings";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 486);
            this.Controls.Add(this.processesBox);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Settings";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckedListBox processesBox;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

