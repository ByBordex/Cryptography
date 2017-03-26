using CipherMethods;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
    namespace App
    {
        public partial class Form1 : Form
        {

            private IEnumerable<string> methodName = new string[] { "Caesar", "Vigenere", "Base64" };
            public Func<string, string, bool, string> CipherMethod;

            public Form1()
            {
                InitializeComponent();
            }

            private void Form1_Load(object sender, EventArgs e)
            {
                cbMethod.DropDownStyle = ComboBoxStyle.DropDownList;
                methodName = methodName.OrderBy(x => x);
                methodName.ToList().ForEach(x => cbMethod.Items.Add(x));
                cbMethod.SelectedIndex = methodName.ToList().IndexOf("Caesar");
            }


            //Encrypt button.
            private void EncryptButton_Click(object sender, EventArgs e)
            {
                if (txtInput.Text.Count() == 0 || txtKey.Text.Count() == 0)
                {
                    MessageBox.Show("Input/Key field empty");
                    return;
                }
                var input = txtInput.Text;
                var key = txtKey.Text;
                txtOutput.Text = txtOutput.Text = CipherMethod(input, key, false);
            }
            //Decrypt button.
            private void DecryptButton_Click(object sender, EventArgs e)
            {
                if (txtInput.Text.Count() == 0 || txtKey.Text.Count() == 0)
                {
                    MessageBox.Show("Input/Key field empty");
                    return;
                }
                var input = txtInput.Text;
                var key = txtKey.Text;
                txtOutput.Text = CipherMethod(input, key, false);
            }

            private void cbMethod_SelectedIndexChanged(object sender, EventArgs e)
            {
                int index = cbMethod.SelectedIndex;
                txtInput.Focus();
                txtInput.Text = "";
                txtInput.Enabled = true;
                if (index == methodName.ToList().IndexOf("Vigenere"))
                {
                    CipherMethod = Vigenere.vigenere;
                }
                else if (index == methodName.ToList().IndexOf("Caesar"))
                {
                    CipherMethod = Caesar.caesar;
                }
                else if (index == methodName.ToList().IndexOf("Base64"))
                {
                    txtInput.Text = "0";
                    txtInput.Enabled = false;
                    CipherMethod = Base64.base64;
                }

            }

            private void label1_Click(object sender, EventArgs e)
            {

            }

            private void openToolStripMenuItem_Click(object sender, EventArgs e)
            {
                OpenFileDialog fileDialog = new OpenFileDialog();
                fileDialog.Multiselect = false;
                fileDialog.Filter = "Text Files (.txt)|*.txt|All Files (*.*)|*.*";

                // Process input if the user clicked OK.
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Open the selected file to read.
                    var fileStream = fileDialog.OpenFile();
                    var reader = new StreamReader(fileStream);
                    txtInput.Text = reader.ReadToEnd();
                    reader.Close();
                    fileStream.Close();
                }
            }

            private void saveToolStripMenuItem_Click(object sender, EventArgs e)
            {
                var fileDialog = new SaveFileDialog();

                fileDialog.Filter = "Text Files (.txt)|*.txt|All Files (*.*)|*.*";

                // Process input if the user clicked OK.
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Open the selected file to read.
                    var fileStream = fileDialog.OpenFile();
                    var writer = new StreamWriter(fileStream);
                    writer.Write(txtOutput.Text);
                    writer.Close();
                    fileStream.Close();
                }
            }

            private void lblKey_Click(object sender, EventArgs e)
            {

            }

            private void txtKey_TextChanged(object sender, EventArgs e)
            {

            }
        }
    }
