using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeoutBeater
{

    public enum KeyPresses
    {
        ESCAPE,
        BACKSPACE,
        DELETE,
        RETURN,
        TAB,
        ARROWDOWN,
        F1,
        F2,
        F3,
        F4,
        F5,
        F6,
        F7,
        F8,
        F9,
        F10,
        F11,
        F12,       
        W
    };

    public partial class Form1 : Form
    {
        public DataGridView dataGridView2 = new DataGridView();
        public BindingSource bindingSource1 = new BindingSource();

        public Form1()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(Fields_Load);
        }         
       
        private void Fields_Load(object sender, System.EventArgs e)
        {
            ProcessNameTextBox.Text = Properties.Settings.Default.Name;
            //var processKeyPress = Properties.Settings.Default.ProcessKeyPress;
            ProcessEnabledCheckBox.Checked = Properties.Settings.Default.ProcessEnabled;                            
        }       
       

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveSettings();
        }

        public void SaveSettings()
        {
            Properties.Settings.Default.Name = this.ProcessNameTextBox.Text;
            //Properties.Settings.Default.ProcessKeyPress = TimeoutBeater.Program.processKeyPress;
            Properties.Settings.Default.ProcessEnabled = this.ProcessEnabledCheckBox.Checked;
            Properties.Settings.Default.Save();
            this.Close();
        }
    }
}
