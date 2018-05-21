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
            this.Load += new System.EventHandler(EnumsAndComboBox_Load);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (TimeoutBeater.Program.enabled)
            {
                TimeoutBeater.Program.enabled = false;
            } else
            {
                TimeoutBeater.Program.enabled = true;
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EnumsAndComboBox_Load(object sender, System.EventArgs e)
        {
            // Add data to the List
            var processNames = Properties.Settings.Default.ProcessNames;
            var processKeyPresses = Properties.Settings.Default.ProcessKeyPresses;
            var processEnabled = Properties.Settings.Default.ProcessEnabled;

            for (int i = 0; i < processNames.Count; ++i)
            {
                var processName = processNames[i];
                var keyPress = processKeyPresses[i];
                var isEnabled = processEnabled[i] == "true";
                //bindingSource1.Add(new Process(processName, TimeoutBeater.KeyPresses.F5 , isEnabled));
                bindingSource1.Add(new Process(processName, isEnabled));
            }
           
            // Initialize the DataGridView.
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.AutoSize = true;
            dataGridView2.DataSource = bindingSource1;

            

            // Initialize and add a text box column.
            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Name";
            column.Name = "ProcName";
            dataGridView2.Columns.Add(column);
                       
            //dataGridView2.Columns.Add(CreateComboBoxWithEnums());         
            
            // Initialize and add a checkbox column. 
            column = new DataGridViewCheckBoxColumn();
            column.DataPropertyName = "Enabled";
            column.Name = "Enabled";
            dataGridView2.Columns.Add(column);

            // Initialize the form.
            this.Controls.Add(dataGridView2);
            this.AutoSize = true;
            this.Text = "DataGridView object binding demo";
        }

        DataGridViewComboBoxColumn CreateComboBoxWithEnums()
        {            
            DataGridViewComboBoxColumn combo = new DataGridViewComboBoxColumn();
            combo.DataSource = Enum.GetValues(typeof(KeyPresses));
            combo.DataPropertyName = "KeyPress";
            combo.Name = "KeyPress";
            return combo;            
        }

        #region "business object"
        private class Process
        {
            private string myName;            
           // private string myKeyPress;
            private bool isEnabled;

           // public Process(string name,string keyPress, bool enabled)
            public Process(string name, bool enabled)
            {
                myName = name;
                //myKeyPress = keyPress;
                isEnabled = enabled;
            }

            public Process()
            {
                myName = "<enter name>";
               // myKeyPress = KeyPress.F5;                
                isEnabled = true;
            }

            public string Name
            {
                get
                {
                    return myName;
                }

                set
                {
                    myName = value;
                }
            }

            public bool IsEnabled
            {
                get
                {
                    return IsEnabled;
                }
                set
                {
                    IsEnabled = value;
                }
            }
            /*
            public string KeyPress
            {
                get
                {
                    return myKeyPress;
                }
                set
                {
                    myKeyPress = value;
                }
            }
            */
        }
        #endregion

    }
}
