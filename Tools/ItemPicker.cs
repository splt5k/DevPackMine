﻿// Decompiled with JetBrains decompiler
// Type: DevPackMine.Tools.ItemPicker
// Assembly: DevPackMine, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6B9BC8BF-B510-4945-A515-04135CC0F4A4
// Assembly location: C:\Users\NTServer\Desktop\DevPackMine\DevPackMine\DevPackMine.exe

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DevPackMine.Tools
{
  public class ItemPicker : Form
  {
    public List<string> MenuList = new List<string>();
    public List<string> MenuListSearch = new List<string>();
    private DatabaseHandle databaseHandle = new DatabaseHandle(); //dethunter12 add
    private string Host = SkillEditor.connection.ReadSettings("Host"); //dethunter12 add
    private string User = SkillEditor.connection.ReadSettings("User"); //dethunter12 add
    private string Password = SkillEditor.connection.ReadSettings("Password"); //dethunter12 add
    private string Database = SkillEditor.connection.ReadSettings("Database"); //dethunter12 add
    public string[] menuArray = new string[2] //dethunter12 add
    {
      "a_index",
      "a_name_usa"
    };
    public int ItemIndex = -1;
    private IContainer components = (IContainer) null;
    private ListBox listBox1;
    private GroupBox groupBox1;
    private TextBox textBox1;
    private GroupBox groupBox2;
    private Button button2;
    private Button button1;
    private Button button3;
    private GroupBox groupBox3;
    private PictureBox pictureBox1;
    private TextBox textBox3;
    private CheckedListBox ClbSort;
    private GroupBox groupBox4;
    private TextBox textBox2;
    public string mSortJob = "-1";

    public ItemPicker()
    {
            InitializeComponent();
    }
private void LoadStartup()
        {
         ClbSort.Items.AddRange(new object[8]
 {
         "-1 - All",
         "1 - Titan",
         "2 - Knight",
         "4 - Healer",
         "264 - Mage",
         "144 - Rogue",
         "32 - Sorcerer",
         "64 - NightShadow"
 });
        }
    private void ItemPicker_Load(object sender, EventArgs e)
    {
            LoadStartup(); //dethunter12 add
            MenuList.Clear();
      for (int index = 0; index < IconList.List.Count<ticon>(); ++index)
                MenuList.Add("" + IconList.List[index].ItemID.ToString() + " - " + IconList.List[index].Name.ToString());
            listBox1.DataSource = (object)MenuList;
    }

    public bool SearchString(string s)
    {
      return s.ToUpper().Contains(textBox1.Text.ToUpper());
    }

    private int GetID()
    {
      int result = -1;
      int.TryParse(listBox1.Text.Split(' ')[0], out result);
      return result;
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {
            MenuListSearch = MenuList.FindAll(new Predicate<string>(SearchString));
            listBox1.DataSource = (object)MenuListSearch;
    }

    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
      int ItemID = GetID();
      if (ItemID == -1)
        return;
      ticon ticon = IconList.List.Find((Predicate<ticon>) (p => p.ItemID.Equals(ItemID)));
      if (ticon == null)
        return;
            ItemIndex = ticon.ItemID;
            textBox2.Text = ticon.Name;
            textBox3.Text = ticon.Desc;
            pictureBox1.Image = (Image) new DatabaseHandle().IconFast(ticon.ItemID);
    }

    private void button1_Click(object sender, EventArgs e)
    {
            DialogResult = DialogResult.OK;
    }

    private void button2_Click(object sender, EventArgs e)
    {
            ItemIndex = -1;

            DialogResult = DialogResult.OK;
    }

    private void button3_Click(object sender, EventArgs e)
    {
            Close();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && components != null)
                components.Dispose();
      base.Dispose(disposing);
    }
    public int GetIndexByComboBox(string comboBox) //dethunter12 add
    {
      try
      {
        return Convert.ToInt32(comboBox.Split(' ')[0]);
      }
      catch
      {
        return 0;
      }
    }
     private void LoadListBox() //dethunter12 add
    {
            listBox1.SelectedIndex = -1;
            MenuList.Clear();
      string Query = "SELECT a_index, a_name_usa FROM t_item WHERE a_job_flag ='" + mSortJob + "' ORDER BY a_index;"; //basic database record
      if (mSortJob == "-1")
        Query = "SELECT a_index, a_name_usa FROM t_item ORDER BY a_index;";
            listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArray, Host, User, Password, Database, Query);
      for (int index = 0; index < listBox1.Items.Count; ++index)
                MenuList.Add(listBox1.Items[index].ToString());
            listBox1.DataSource = MenuList;
            listBox1.SelectedIndex = -1;
    }

    private void InitializeComponent()
    {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemPicker));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ClbSort = new System.Windows.Forms.CheckedListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(205, 303);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(465, 52);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(6, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(450, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Location = new System.Drawing.Point(12, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(226, 363);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Items";
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(165, 328);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(46, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Close";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(104, 328);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "None";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(6, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Pick";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Location = new System.Drawing.Point(244, 70);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(233, 132);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Preview";
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Location = new System.Drawing.Point(62, 45);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(162, 68);
            this.textBox3.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(62, 19);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(162, 20);
            this.textBox2.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(6, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // ClbSort
            // 
            this.ClbSort.BackColor = System.Drawing.SystemColors.Control;
            this.ClbSort.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ClbSort.CheckOnClick = true;
            this.ClbSort.FormattingEnabled = true;
            this.ClbSort.Location = new System.Drawing.Point(6, 19);
            this.ClbSort.MultiColumn = true;
            this.ClbSort.Name = "ClbSort";
            this.ClbSort.Size = new System.Drawing.Size(221, 135);
            this.ClbSort.TabIndex = 4;
            this.ClbSort.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.ClbSort_ItemCheck);
            this.ClbSort.SelectedIndexChanged += new System.EventHandler(this.ClbSort_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ClbSort);
            this.groupBox4.Location = new System.Drawing.Point(244, 208);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(233, 158);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sort";
            // 
            // ItemPicker
            // 
            this.ClientSize = new System.Drawing.Size(483, 445);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            
            this.MaximizeBox = false;
            this.Name = "ItemPicker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Item Picker";
            this.Load += new System.EventHandler(this.ItemPicker_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

    }

        private void ClbSort_SelectedIndexChanged(object sender, EventArgs e) //dethunter12 add
        {
            string str = GetIndexByComboBox(ClbSort.Text).ToString(); //get number from combobox

            mSortJob = str; // set sort job equal to number from combobox
            if (ClbSort.Text == "1")

                LoadListBox(); //reloads the list box with the value selected
        }

        private void ClbSort_ItemCheck(object sender, ItemCheckEventArgs e) //dethunter12 add
        {
            if (e.NewValue == CheckState.Checked && ClbSort.CheckedItems.Count > 0) //checks if the checked item count is greater than 0
            {
                ClbSort.ItemCheck -= ClbSort_ItemCheck;
                ClbSort.SetItemChecked(ClbSort.CheckedIndices[0], false);
                ClbSort.ItemCheck += ClbSort_ItemCheck;
            }
            string str = GetIndexByComboBox(ClbSort.Text).ToString();
            mSortJob = str;
            LoadListBox();
        }
    }
}
