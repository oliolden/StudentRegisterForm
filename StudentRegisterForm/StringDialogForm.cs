using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegisterForm {
    public partial class StringDialogForm : Form {
        public string returnString;
        public StringDialogForm(string title, string placeholder) {
            InitializeComponent();
            Text = title;
            input.PlaceholderText = placeholder;
        }

        private void CancelButton_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void confirmButton_Click(object sender, EventArgs e) {
            returnString = input.Text;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
