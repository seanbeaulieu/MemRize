using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MemRize
{
    public partial class AddVocabForm : Form
    {
        public AddVocabForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Capture the data and set public properties
            Term = txtTerm.Text;
            Definition = txtDefinition.Text;

            // Close this form
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void AddVocabForm_Load(object sender, EventArgs e)
        {

        }
    }
}
