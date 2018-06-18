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
            this.ProcessEnabledCheckBox = new System.Windows.Forms.CheckBox();
            this.ProcessNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProcessEnabledCheckBox
            // 
            this.ProcessEnabledCheckBox.AutoSize = true;
            this.ProcessEnabledCheckBox.Location = new System.Drawing.Point(145, 19);
            this.ProcessEnabledCheckBox.Name = "ProcessEnabledCheckBox";
            this.ProcessEnabledCheckBox.Size = new System.Drawing.Size(65, 17);
            this.ProcessEnabledCheckBox.TabIndex = 0;
            this.ProcessEnabledCheckBox.Text = "Enabled";
            this.ProcessEnabledCheckBox.UseVisualStyleBackColor = true;
            // 
            // ProcessNameTextBox
            // 
            this.ProcessNameTextBox.Location = new System.Drawing.Point(9, 16);
            this.ProcessNameTextBox.Name = "ProcessNameTextBox";
            this.ProcessNameTextBox.Size = new System.Drawing.Size(93, 20);
            this.ProcessNameTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 18);
            this.label2.MaximumSize = new System.Drawing.Size(220, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "This application will receive a keypress every 5 mins to prevent it from logging " +
    "you out.";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(95, 129);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(65, 27);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(166, 129);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(65, 28);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ProcessNameTextBox);
            this.groupBox1.Controls.Add(this.ProcessEnabledCheckBox);
            this.groupBox1.Location = new System.Drawing.Point(15, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 51);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Process Name";
            // 
            // Form1
            // 
            this.AccessibleDescription = "Settings";
            this.AccessibleName = "Settings";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 180);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Settings";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion        
        private System.Windows.Forms.CheckBox ProcessEnabledCheckBox;
        private System.Windows.Forms.TextBox ProcessNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

