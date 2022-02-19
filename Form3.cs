using System;
using System.IO;
using System.Windows.Forms;

namespace _1802
{
    public partial class Form3 : Form
    {
        private bool textChanged;
        private string path;
        private int index;
        private string[] data;
        private Form1 parent;

        public Form3(string path, int index, Form1 parent)
        {
            InitializeComponent();
            textChanged = false;
            this.path = path;
            this.index = index;
            this.parent = parent;
            try
            {
                StreamReader sr = new StreamReader(path);
                data = sr.ReadToEnd().Trim().Split(Convert.ToChar("\n"));
                sr.Close();
                string[] line = data[index].Trim().Split();
                tbName.Text = line[0];
                tbAge.Text = line[1];
                tbDescr.Text = line[2];
                cbDropOut.Checked = Convert.ToBoolean(line[3]);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            textChanged = true;
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            if (textChanged)
            {
                StreamWriter sw = new StreamWriter(path);
                data[index] = tbName.Text + " " + tbAge.Text + " " + tbDescr.Text + " " + cbDropOut.Checked.ToString();
                sw.Write(String.Join("\n", data));
                sw.Close();
            }
            parent.LoadData();
            this.Close();
        }
    }
}
