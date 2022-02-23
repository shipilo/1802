using System;
using System.IO;
using System.Windows.Forms;

namespace _1802
{
    public partial class Form1 : Form
    {
        private string path;

        public Form1()
        {
            InitializeComponent();
            tvGroups.Nodes[0].Expand();
        }

        private void bOpenBrowser_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this.Location.X, this.Location.Y, this.Size.Width, this.Size.Height);
            form2.Show();
        }

        private void tvGroups_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node == tvGroups.Nodes[0].Nodes[0])
            {
                path = "121.txt";
                LoadData();
            }
            else if (e.Node == tvGroups.Nodes[0].Nodes[1])
            {
                path = "122.txt";
                LoadData();
            }
        }

        public void LoadData()
        {
            if (path != null)
            {
                dgvTable.Rows.Clear();
                StreamReader sr = new StreamReader(path);
                string[] lines = sr.ReadToEnd().Trim().Split(Convert.ToChar("\n"));
                foreach (string line in lines)
                {
                    dgvTable.Rows.Add(line.Trim().Split());
                }
                sr.Close();
            }
        }

        private void dgvTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (path != null)
            {
                Form3 form3 = new Form3(path, e.RowIndex, this);
                form3.Show();
            }
        }
    }
}
