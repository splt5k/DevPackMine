// Decompiled with JetBrains decompiler
// Type: DevPackMine.Tools.MemoryWorker.RewardEditor
// Assembly: DevPackMine, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6B9BC8BF-B510-4945-A515-04135CC0F4A4
// Assembly location: C:\Users\NTServer\Desktop\DevPackMine\DevPackMine\DevPackMine.exe

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DevPackMine.Tools.MemoryWorker
{
  public class RewardEditor : Form
  {
    private IContainer components = (IContainer) null;
    private MenuStrip menuStrip1;
    private ToolStripMenuItem fileToolStripMenuItem;
    private ToolStripMenuItem importFromDatabaseToolStripMenuItem;
    private ToolStripMenuItem saveToolStripMenuItem;
    private ToolStripMenuItem extraToolStripMenuItem;
    private GroupBox groupBox2;
    private Button btnDelete;
    private Button btnCopy;
    private ListBox listBox1;
    private GroupBox groupBox1;
    private TextBox textBox1;
    private GroupBox groupBox4;
    private DataGridView dgItems;
    private ToolStrip toolStrip2;
    private ToolStripButton btnDeleteSelected;
    private ToolStripSeparator toolStripSeparator1;
    private ToolStripButton btnAddItems;
    private ToolStripSeparator toolStripSeparator6;
    private ToolStripButton toolStripButton1;
    private DataGridViewImageColumn Icon;
    private DataGridViewTextBoxColumn PrimaryKey;
    private DataGridViewTextBoxColumn RewardID;
    private DataGridViewTextBoxColumn Type;
    private DataGridViewTextBoxColumn ItemID;
    private DataGridViewTextBoxColumn Value1;
    private DataGridViewTextBoxColumn Value2;
    private DataGridViewTextBoxColumn Value3;
    private DataGridViewTextBoxColumn JobFlag;
    private DataGridViewTextBoxColumn MinLevel;
    private DataGridViewTextBoxColumn MaxLevel;
    private DataGridViewTextBoxColumn Prob;
    private TextBox txtID;
    private TextBox txtName;
    private ComboBox cbRandType;
    private Label label1;
    private Label label2;
    private Label label3;
    private Button button1;
    private DatabaseHandle databaseHandle = new DatabaseHandle();

    public RewardEditor()
    {
            InitializeComponent();
    }

    private void importFromDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
    {
      new LoadFromDatabase().treward_Import();
            MakeList();
    }

    public void MakeList()
    {
      List<string> stringList = new List<string>();
      List<treward_head> all = AllLists.treward_head_MenuData.FindAll((p => p.desc.ToLower().Contains(textBox1.Text.ToLower())));
      for (int index = 0; index < all.Count<treward_head>(); ++index)
        stringList.Add(all[index].idx.ToString() + " - " + all[index].desc.ToString());
            listBox1.Items.Clear();
            listBox1.Items.AddRange(stringList.ToArray());
    }

    private int GetID()
    {
      int result = -1;
      int.TryParse(listBox1.Text.Split(' ')[0], out result);
      return result;
    }

    private void saveToolStripMenuItem_Click(object sender, EventArgs e)
    {
    }

    private void RewardEditor_Load(object sender, EventArgs e)
    {
      mySQL.SetConnection();
      new LoadFromDatabase().treward_Import();
      MakeList();
      listBox1.SelectedIndex = 0;
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {
            MakeList();
    }

    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
      int ID = GetID();
      if (ID == -1)
        return;

      treward_head trewardHead = AllLists.treward_head_MenuData.Find(p => p.idx.Equals(ID));
      if (trewardHead == null)
          return;

      treward_data[] trewardData = AllLists.treward_data_MenuData.FindAll((p => p.RewardID.Equals(ID))).ToArray();
      if (trewardData == null)
        return;

      txtID.Text = trewardHead.idx.ToString();
      txtName.Text = trewardHead.desc.ToString();
      cbRandType.SelectedIndex = trewardHead.randtype;


      FillGrid(trewardData);

    }

    private void LoadDataGrid()
    {
    }

    private void FillGrid(treward_data[] items)
    {
            dgItems.Rows.Clear();
      foreach (treward_data trewardData in items)
          dgItems.Rows.Add(databaseHandle.IconFast(trewardData.ItemID), trewardData.PrimaryKey, trewardData.RewardID, trewardData.Type, trewardData.ItemID, trewardData.Value1, trewardData.Value2, trewardData.Value3, trewardData.JobFlag, trewardData.MinLevel, trewardData.MaxLevel, trewardData.Prob);
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && components != null)
                components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importFromDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgItems = new System.Windows.Forms.DataGridView();
            this.Icon = new System.Windows.Forms.DataGridViewImageColumn();
            this.PrimaryKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RewardID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JobFlag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MinLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnDeleteSelected = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAddItems = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cbRandType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgItems)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.extraToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1003, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importFromDatabaseToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // importFromDatabaseToolStripMenuItem
            // 
            this.importFromDatabaseToolStripMenuItem.Name = "importFromDatabaseToolStripMenuItem";
            this.importFromDatabaseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.importFromDatabaseToolStripMenuItem.Text = "Load from Database";
            this.importFromDatabaseToolStripMenuItem.Click += new System.EventHandler(this.importFromDatabaseToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // extraToolStripMenuItem
            // 
            this.extraToolStripMenuItem.Enabled = false;
            this.extraToolStripMenuItem.Name = "extraToolStripMenuItem";
            this.extraToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.extraToolStripMenuItem.Text = "Extra";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnCopy);
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Location = new System.Drawing.Point(12, 84);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(256, 426);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mob list";
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(142, 396);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(108, 24);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnCopy
            // 
            this.btnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopy.Location = new System.Drawing.Point(6, 396);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(130, 24);
            this.btnCopy.TabIndex = 2;
            this.btnCopy.Text = "New";
            this.btnCopy.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(244, 368);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 51);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(6, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(244, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.dgItems);
            this.groupBox4.Controls.Add(this.toolStrip2);
            this.groupBox4.Location = new System.Drawing.Point(274, 84);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(718, 387);
            this.groupBox4.TabIndex = 26;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Rewards";
            // 
            // dgItems
            // 
            this.dgItems.AllowUserToAddRows = false;
            this.dgItems.AllowUserToDeleteRows = false;
            this.dgItems.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Icon,
            this.PrimaryKey,
            this.RewardID,
            this.Type,
            this.ItemID,
            this.Value1,
            this.Value2,
            this.Value3,
            this.JobFlag,
            this.MinLevel,
            this.MaxLevel,
            this.Prob});
            this.dgItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgItems.EnableHeadersVisualStyles = false;
            this.dgItems.Location = new System.Drawing.Point(3, 16);
            this.dgItems.Name = "dgItems";
            this.dgItems.RowHeadersVisible = false;
            this.dgItems.RowTemplate.Height = 32;
            this.dgItems.Size = new System.Drawing.Size(712, 343);
            this.dgItems.TabIndex = 0;
            // 
            // Icon
            // 
            this.Icon.HeaderText = "";
            this.Icon.Name = "Icon";
            this.Icon.Width = 32;
            // 
            // PrimaryKey
            // 
            this.PrimaryKey.HeaderText = "PrimaryKey";
            this.PrimaryKey.Name = "PrimaryKey";
            this.PrimaryKey.Width = 60;
            // 
            // RewardID
            // 
            this.RewardID.HeaderText = "RewardID";
            this.RewardID.Name = "RewardID";
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            // 
            // ItemID
            // 
            this.ItemID.HeaderText = "ItemID";
            this.ItemID.Name = "ItemID";
            // 
            // Value1
            // 
            this.Value1.HeaderText = "Value1";
            this.Value1.Name = "Value1";
            // 
            // Value2
            // 
            this.Value2.HeaderText = "Value2";
            this.Value2.Name = "Value2";
            // 
            // Value3
            // 
            this.Value3.HeaderText = "Value3";
            this.Value3.Name = "Value3";
            // 
            // JobFlag
            // 
            this.JobFlag.HeaderText = "JobFlag";
            this.JobFlag.Name = "JobFlag";
            // 
            // MinLevel
            // 
            this.MinLevel.HeaderText = "MinLevel";
            this.MinLevel.Name = "MinLevel";
            // 
            // MaxLevel
            // 
            this.MaxLevel.HeaderText = "MaxLevel";
            this.MaxLevel.Name = "MaxLevel";
            // 
            // Prob
            // 
            this.Prob.HeaderText = "Prob";
            this.Prob.Name = "Prob";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDeleteSelected,
            this.toolStripSeparator1,
            this.btnAddItems,
            this.toolStripSeparator6,
            this.toolStripButton1});
            this.toolStrip2.Location = new System.Drawing.Point(3, 359);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(712, 25);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btnDeleteSelected
            // 
            this.btnDeleteSelected.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnDeleteSelected.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteSelected.Name = "btnDeleteSelected";
            this.btnDeleteSelected.Size = new System.Drawing.Size(62, 22);
            this.btnDeleteSelected.Text = "Save Item";
            this.btnDeleteSelected.Click += new System.EventHandler(this.btnDeleteSelected_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnAddItems
            // 
            this.btnAddItems.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnAddItems.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddItems.Name = "btnAddItems";
            this.btnAddItems.Size = new System.Drawing.Size(60, 22);
            this.btnAddItems.Text = "Add Item";
            this.btnAddItems.Click += new System.EventHandler(this.btnAddItems_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(91, 22);
            this.toolStripButton1.Text = "Delete Selected";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(298, 46);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(60, 20);
            this.txtID.TabIndex = 27;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(414, 45);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(266, 20);
            this.txtName.TabIndex = 27;
            // 
            // cbRandType
            // 
            this.cbRandType.FormattingEnabled = true;
            this.cbRandType.Items.AddRange(new object[] {
            "0 Multi",
            "1 Once-Random",
            "2 Once-Select"});
            this.cbRandType.Location = new System.Drawing.Point(763, 45);
            this.cbRandType.Name = "cbRandType";
            this.cbRandType.Size = new System.Drawing.Size(121, 21);
            this.cbRandType.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(274, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(370, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Descr:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(694, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Rand Type:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(890, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RewardEditor
            // 
            this.ClientSize = new System.Drawing.Size(1003, 522);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbRandType);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "RewardEditor";
            this.Text = "RewardEditor";
            this.Load += new System.EventHandler(this.RewardEditor_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgItems)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    private void button1_Click(object sender, EventArgs e)
    {

    }

    private void btnDeleteSelected_Click(object sender, EventArgs e)
    {

    }

    private void btnAddItems_Click(object sender, EventArgs e)
    {

    }

    private void toolStripButton1_Click(object sender, EventArgs e)
    {

    }
  }
}
