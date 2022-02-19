
namespace _1802
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("09-121");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("09-122");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Меню", new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode11});
            this.scMain = new System.Windows.Forms.SplitContainer();
            this.scTop = new System.Windows.Forms.SplitContainer();
            this.tvGroups = new System.Windows.Forms.TreeView();
            this.pbPicture = new System.Windows.Forms.PictureBox();
            this.dgvTable = new System.Windows.Forms.DataGridView();
            this.columnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDescr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bOpenBrowser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.Panel2.SuspendLayout();
            this.scMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scTop)).BeginInit();
            this.scTop.Panel1.SuspendLayout();
            this.scTop.Panel2.SuspendLayout();
            this.scTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).BeginInit();
            this.SuspendLayout();
            // 
            // scMain
            // 
            this.scMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scMain.Location = new System.Drawing.Point(0, 40);
            this.scMain.Name = "scMain";
            this.scMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scMain.Panel1
            // 
            this.scMain.Panel1.Controls.Add(this.scTop);
            // 
            // scMain.Panel2
            // 
            this.scMain.Panel2.Controls.Add(this.dgvTable);
            this.scMain.Size = new System.Drawing.Size(852, 601);
            this.scMain.SplitterDistance = 266;
            this.scMain.TabIndex = 0;
            // 
            // scTop
            // 
            this.scTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scTop.Location = new System.Drawing.Point(0, 0);
            this.scTop.Name = "scTop";
            // 
            // scTop.Panel1
            // 
            this.scTop.Panel1.Controls.Add(this.tvGroups);
            // 
            // scTop.Panel2
            // 
            this.scTop.Panel2.Controls.Add(this.pbPicture);
            this.scTop.Size = new System.Drawing.Size(852, 266);
            this.scTop.SplitterDistance = 411;
            this.scTop.TabIndex = 0;
            // 
            // tvGroups
            // 
            this.tvGroups.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.84615F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tvGroups.FullRowSelect = true;
            this.tvGroups.Location = new System.Drawing.Point(0, 0);
            this.tvGroups.Name = "tvGroups";
            treeNode10.Name = "node1";
            treeNode10.Text = "09-121";
            treeNode11.Name = "node2";
            treeNode11.Text = "09-122";
            treeNode12.Name = "nodeMenu";
            treeNode12.Text = "Меню";
            this.tvGroups.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode12});
            this.tvGroups.Size = new System.Drawing.Size(411, 266);
            this.tvGroups.TabIndex = 1;
            this.tvGroups.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvGroups_AfterSelect);
            // 
            // pbPicture
            // 
            this.pbPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbPicture.Image = global::_1802.Properties.Resources.AW6NoHksQD0;
            this.pbPicture.Location = new System.Drawing.Point(0, 0);
            this.pbPicture.Name = "pbPicture";
            this.pbPicture.Size = new System.Drawing.Size(437, 266);
            this.pbPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPicture.TabIndex = 0;
            this.pbPicture.TabStop = false;
            // 
            // dgvTable
            // 
            this.dgvTable.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnName,
            this.columnAge,
            this.columnDescr});
            this.dgvTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTable.Location = new System.Drawing.Point(0, 0);
            this.dgvTable.Name = "dgvTable";
            this.dgvTable.RowHeadersWidth = 56;
            this.dgvTable.RowTemplate.Height = 24;
            this.dgvTable.Size = new System.Drawing.Size(852, 331);
            this.dgvTable.TabIndex = 0;
            this.dgvTable.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTable_CellDoubleClick);
            // 
            // columnName
            // 
            this.columnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnName.HeaderText = "Имя";
            this.columnName.MinimumWidth = 7;
            this.columnName.Name = "columnName";
            this.columnName.ReadOnly = true;
            // 
            // columnAge
            // 
            this.columnAge.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnAge.HeaderText = "Возраст";
            this.columnAge.MinimumWidth = 7;
            this.columnAge.Name = "columnAge";
            this.columnAge.ReadOnly = true;
            // 
            // columnDescr
            // 
            this.columnDescr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnDescr.HeaderText = "Описание";
            this.columnDescr.MinimumWidth = 7;
            this.columnDescr.Name = "columnDescr";
            this.columnDescr.ReadOnly = true;
            // 
            // bOpenBrowser
            // 
            this.bOpenBrowser.Location = new System.Drawing.Point(13, 11);
            this.bOpenBrowser.Name = "bOpenBrowser";
            this.bOpenBrowser.Size = new System.Drawing.Size(137, 23);
            this.bOpenBrowser.TabIndex = 0;
            this.bOpenBrowser.Text = "Открыть браузер";
            this.bOpenBrowser.UseVisualStyleBackColor = true;
            this.bOpenBrowser.Click += new System.EventHandler(this.bOpenBrowser_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(852, 641);
            this.Controls.Add(this.bOpenBrowser);
            this.Controls.Add(this.scMain);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Title";
            this.scMain.Panel1.ResumeLayout(false);
            this.scMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
            this.scMain.ResumeLayout(false);
            this.scTop.Panel1.ResumeLayout(false);
            this.scTop.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scTop)).EndInit();
            this.scTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer scMain;
        private System.Windows.Forms.SplitContainer scTop;
        private System.Windows.Forms.TreeView tvGroups;
        private System.Windows.Forms.PictureBox pbPicture;
        private System.Windows.Forms.DataGridView dgvTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDescr;
        private System.Windows.Forms.Button bOpenBrowser;
    }
}

