// Decompiled with JetBrains decompiler
// Type: DevPackMine.Tools.ItemCollection
// Assembly: DevPackMine, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6B9BC8BF-B510-4945-A515-04135CC0F4A4
// Assembly location: C:\Users\NTServer\Desktop\DevPackMine\DevPackMine\DevPackMine.exe
using MySql.Data.MySqlClient; //dethunter12 add
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DevPackMine.Tools
{
  public class ItemCollection : Form
  {
    public static Connection connection = new Connection();
    public string Host = ItemCollection.connection.ReadSettings("Host");
    public string User = ItemCollection.connection.ReadSettings("User");
    public string Password = ItemCollection.connection.ReadSettings("Password");
    public string Database = ItemCollection.connection.ReadSettings("Database");
    private DatabaseHandle databaseHandle = new DatabaseHandle();
    public string[] _needType = new string[6];
    public string[] menuArray = new string[2]
    {
      "a_theme",
      "a_theme_string"
    };
    public string[] SearchMenu = new string[2]
    {
      "a_theme",
      "a_theme_string"
    };
    public List<string> MenuList = new List<string>();
    public List<string> MenuListSearch = new List<string>();
    private IContainer components = (IContainer) null;
    public int _index;
    public string _enable;
    public string _category;
    public string _texFileID;
    public string _texRow;
    public string _texCol;
    public string _resultType;
    private GroupBox groupBox5;
    private Label label7;
    private TextBox textBox1;
    private GroupBox groupBox3;
    private Button btnCopy;
    private Button btnDelete;
    private Button btnAdd;
    private ListBox listBox1;
    private Button button2;
    private GroupBox groupBox1;
    private Label label6;
    private TextBox textBox2;
    private Label label5;
    private Label label1;
    private TextBox textBox3;
    private TextBox textBox4;
    private GroupBox groupBox2;
    private GroupBox groupBox4;
    private Label label4;
    private CheckBox checkBox1;
    private ComboBox comboBox1;
    private GroupBox groupBox7;
    private Button btnSave;
    private PictureBox pictureBox1;
    private LinkLabel linkLabel1;
    private GroupBox groupBox6;
    private TextBox textBox6;
    private ComboBox comboBox2;
    private TextBox textBox5;
    private Label label2;
    private Label label8;
    private Label label3;
    private GroupBox groupBox8;
    private TextBox textBox7;
    private ComboBox comboBox3;
    private TextBox textBox8;
    private Label label9;
    private Label label10;
    private Label label11;
    private GroupBox groupBox12;
    private TextBox textBox15;
    private ComboBox comboBox7;
    private TextBox textBox16;
    private Label label21;
    private Label label22;
    private Label label23;
    private GroupBox groupBox11;
    private TextBox textBox13;
    private ComboBox comboBox6;
    private TextBox textBox14;
    private Label label18;
    private Label label19;
    private Label label20;
    private GroupBox groupBox10;
    private TextBox textBox11;
    private ComboBox comboBox5;
    private TextBox textBox12;
    private Label label15;
    private Label label16;
    private Label label17;
    private GroupBox groupBox9;
    private TextBox textBox9;
    private ComboBox comboBox4;
    private TextBox textBox10;
    private Label label12;
    private Label label13;
    private Label label14;
    private TextBox textBox17;
    private ComboBox comboBox8;
    private TextBox textBox18;
    private Label label26;
    private Label label24;
    private Label label25;
    private PictureBox pictureBox6;
    private PictureBox pictureBox5;
    private PictureBox pictureBox4;
    private PictureBox pictureBox3;
    private PictureBox pictureBox2;
    private PictureBox pictureBox7;
    private PictureBox pictureBox8;
        private TextBox tbResultType;
        private Label lblResultType;
        private TextBox tbNeed6;
        private TextBox tbNeed5;
        private TextBox tbNeed4;
        private TextBox tbNeed3;
        private TextBox tbNeed2;
        private TextBox tbNeed1;
        private TextBox tbCategory;
        private ToolTip toolTip1;

    public ItemCollection()
    {
            InitializeComponent();
    }

    private void ItemCollection_Load(object sender, EventArgs e)
    {
            LoadStartUpCombo(); //loads the statrtup combo on form  load 
            LoadListBox();
            SelectBoxes(); //dethunter12 add
    }

    public int GetIndexByComboBox(string comboBox)
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

    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
            if (listBox1.SelectedIndex != -1)
                textBox2.Text = GetIndex().ToString();
      string[] strArray = databaseHandle.SelectMySqlReturnArray(Host, User, Password, Database, "SELECT * FROM t_item_collection WHERE a_theme = '" + textBox2.Text + "';", new string[29]
      {
        "a_theme",
        "a_category",
        "a_theme_string",
        "a_desc_string",
        "a_enable",
        "a_id",
        "a_row",
        "a_col",
        "a_need1_type",
        "a_need1_index",
        "a_need1_num",
        "a_need2_type",
        "a_need2_index",
        "a_need2_num",
        "a_need3_type",
        "a_need3_index",
        "a_need3_num",
        "a_need4_type",
        "a_need4_index",
        "a_need4_num",
        "a_need5_type",
        "a_need5_index",
        "a_need5_num",
        "a_need6_type",
        "a_need6_index",
        "a_need6_num",
        "a_result_type",
        "a_result_index",
        "a_result_num"
      });
            textBox2.Text = strArray[0];
            textBox3.Text = strArray[2];
            textBox4.Text = strArray[3];
            _enable = strArray[4];
            _category = strArray[1];
            _texFileID = strArray[5];
            _texRow = strArray[6];
            _texCol = strArray[7];
            tbNeed1.Text = strArray[8]; //dethunter12 add
            textBox6.Text = strArray[9];
            textBox5.Text = strArray[10];
            tbNeed2.Text = strArray[11]; //dethunter12 add
            textBox8.Text = strArray[12];
            textBox7.Text = strArray[13];
            tbNeed3.Text = strArray[14]; //dethunter12 add
            textBox10.Text = strArray[15];
            textBox9.Text = strArray[16];
            tbNeed4.Text = strArray[17]; //dethunter12 add
            textBox12.Text = strArray[18];
            textBox11.Text = strArray[19];
           tbNeed5.Text = strArray[20]; //dethunter12 add
            textBox14.Text = strArray[21];
            textBox13.Text = strArray[22];
            tbNeed6.Text = strArray[23]; //dethunter12 add
            textBox16.Text = strArray[24];
            textBox15.Text = strArray[25];
            tbResultType.Text = strArray[26]; //dethunter12 add
            textBox18.Text = strArray[27];
            textBox17.Text = strArray[28];
            tbCategory.Text = strArray[1];
            SelectBoxes(); //dethunter12 add Note* if you dont add this the form loads the listbox incorrectly 
            SetPublicValues();
            SetIcons();
    }

    private void SetPublicValues()
    {
            if (_enable == "1")
            {
                checkBox1.Checked = true;
                checkBox1.BackColor = Color.Lime; //dethunter12 add
            }
            else
            {
                checkBox1.Checked = false;
                checkBox1.BackColor = Color.Red; //dethunter12 add
            }
    }

    private void LoadListBox()
    {
            MenuList.Clear();
            listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArray, Host, User, Password, Database, "SELECT a_theme, a_theme_string FROM t_item_collection ORDER BY a_theme;");
      for (int index = 0; index < listBox1.Items.Count; ++index)
                MenuList.Add(listBox1.Items[index].ToString());
            listBox1.DataSource = MenuList;
    }

    public int GetIndex()
    {
      try
      {
        return Convert.ToInt32(listBox1.Text.Split(' ')[0]);
      }
      catch
      {
        return 0;
      }
    }

    public bool SearchString(string s)
    {
      return s.ToUpper().Contains(textBox1.Text.ToUpper());
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {
            MenuListSearch = MenuList.FindAll(new Predicate<string>(SearchString));
            listBox1.DataSource = MenuListSearch;
    }

    private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      IconPickerItemCollection pickerItemCollection = new IconPickerItemCollection();
      pickerItemCollection.OldItemBtnSelect = 1;
      if (pickerItemCollection.ShowDialog() != DialogResult.OK)
        return;
            _texFileID = pickerItemCollection.TexID.ToString();
            _texCol = pickerItemCollection.TexColumn.ToString();
            _texRow = pickerItemCollection.TexRow.ToString();
            SetIcons();
    }

    private void SetIcons()
    {
            if (tbNeed1.Text == "2") //dethunter12 add wrote 0 Where the the needtype  is 2 (theme subtype)
                {
                pictureBox1.Image = (Image)databaseHandle.IconItemCollection(int.Parse(_texFileID), int.Parse(_texRow), int.Parse(_texCol));
                pictureBox2.Image = (Image)databaseHandle.IconFast(Convert.ToInt32(0));
                pictureBox3.Image = (Image)databaseHandle.IconFast(Convert.ToInt32(textBox8.Text));
                pictureBox4.Image = (Image)databaseHandle.IconFast(Convert.ToInt32(textBox10.Text));
                pictureBox5.Image = (Image)databaseHandle.IconFast(Convert.ToInt32(textBox12.Text));
                pictureBox6.Image = (Image)databaseHandle.IconFast(Convert.ToInt32(textBox14.Text));
                pictureBox7.Image = (Image)databaseHandle.IconFast(Convert.ToInt32(textBox16.Text));
                pictureBox8.Image = (Image)databaseHandle.IconFast(Convert.ToInt32(textBox18.Text));
            }
            else if (tbNeed2.Text == "2") //dethunter12 add
            {
                pictureBox1.Image = (Image)databaseHandle.IconItemCollection(int.Parse(_texFileID), int.Parse(_texRow), int.Parse(_texCol));
                pictureBox2.Image = (Image)databaseHandle.IconFast(Convert.ToInt32(textBox6.Text));
                pictureBox3.Image = (Image)databaseHandle.IconFast(Convert.ToInt32(0));
                pictureBox4.Image = (Image)databaseHandle.IconFast(Convert.ToInt32(textBox10.Text));
                pictureBox5.Image = (Image)databaseHandle.IconFast(Convert.ToInt32(textBox12.Text));
                pictureBox6.Image = (Image)databaseHandle.IconFast(Convert.ToInt32(textBox14.Text));
                pictureBox7.Image = (Image)databaseHandle.IconFast(Convert.ToInt32(textBox16.Text));
                pictureBox8.Image = (Image)databaseHandle.IconFast(Convert.ToInt32(textBox18.Text));
            }
            else if (tbNeed3.Text == "2") //dethunter12 add
            {
                pictureBox1.Image = (Image)databaseHandle.IconItemCollection(int.Parse(_texFileID), int.Parse(_texRow), int.Parse(_texCol));
                pictureBox2.Image = (Image)databaseHandle.IconFast(Convert.ToInt32(textBox6.Text));
                pictureBox3.Image = (Image)databaseHandle.IconFast(Convert.ToInt32(textBox8.Text));
                pictureBox4.Image = (Image)databaseHandle.IconFast(Convert.ToInt32(0));
                pictureBox5.Image = (Image)databaseHandle.IconFast(Convert.ToInt32(textBox12.Text));
                pictureBox6.Image = (Image)databaseHandle.IconFast(Convert.ToInt32(textBox14.Text));
                pictureBox7.Image = (Image)databaseHandle.IconFast(Convert.ToInt32(textBox16.Text));
                pictureBox8.Image = (Image)databaseHandle.IconFast(Convert.ToInt32(textBox18.Text));
            }
            else if (tbNeed4.Text == "2") //dethunter12 add
            {
                pictureBox1.Image = (Image)databaseHandle.IconItemCollection(int.Parse(_texFileID), int.Parse(_texRow), int.Parse(_texCol));
                pictureBox2.Image = (Image)databaseHandle.IconFast(Convert.ToInt32(textBox6.Text));
                pictureBox3.Image = (Image)databaseHandle.IconFast(Convert.ToInt32(textBox8.Text));
                pictureBox4.Image = (Image)databaseHandle.IconFast(Convert.ToInt32(textBox10.Text));
                pictureBox5.Image = (Image)databaseHandle.IconFast(Convert.ToInt32(0));
                pictureBox6.Image = (Image)databaseHandle.IconFast(Convert.ToInt32(textBox14.Text));
                pictureBox7.Image = (Image)databaseHandle.IconFast(Convert.ToInt32(textBox16.Text));
                pictureBox8.Image = (Image)databaseHandle.IconFast(Convert.ToInt32(textBox18.Text));
            }
            else if (tbNeed5.Text == "2") //dethunter12 add
            {
                pictureBox1.Image = (Image)databaseHandle.IconItemCollection(int.Parse(_texFileID), int.Parse(_texRow), int.Parse(_texCol));
                pictureBox2.Image = (Image)databaseHandle.IconFast(Convert.ToInt32(textBox6.Text));
                pictureBox3.Image = (Image)databaseHandle.IconFast(Convert.ToInt32(textBox8.Text));
                pictureBox4.Image = (Image)databaseHandle.IconFast(Convert.ToInt32(textBox10.Text));
                pictureBox5.Image = (Image)databaseHandle.IconFast(Convert.ToInt32(textBox12.Text));
                pictureBox6.Image = (Image)databaseHandle.IconFast(Convert.ToInt32(0));
                pictureBox7.Image = (Image)databaseHandle.IconFast(Convert.ToInt32(textBox16.Text));
                pictureBox8.Image = (Image)databaseHandle.IconFast(Convert.ToInt32(textBox18.Text));
            }
            else if (tbNeed6.Text == "2") //dethunter12 add
            {
                pictureBox1.Image = (Image)databaseHandle.IconItemCollection(int.Parse(_texFileID), int.Parse(_texRow), int.Parse(_texCol));
                pictureBox2.Image = (Image)databaseHandle.IconFast(Convert.ToInt32(textBox6.Text));
                pictureBox3.Image = (Image)databaseHandle.IconFast(Convert.ToInt32(textBox8.Text));
                pictureBox4.Image = (Image)databaseHandle.IconFast(Convert.ToInt32(textBox10.Text));
                pictureBox5.Image = (Image)databaseHandle.IconFast(Convert.ToInt32(textBox12.Text));
                pictureBox6.Image = (Image)databaseHandle.IconFast(Convert.ToInt32(textBox14.Text));
                pictureBox7.Image = (Image)databaseHandle.IconFast(Convert.ToInt32(0));
                pictureBox8.Image = (Image)databaseHandle.IconFast(Convert.ToInt32(textBox18.Text));
            }
            else //dethunter12 add
            {
                pictureBox1.Image = (Image)databaseHandle.IconItemCollection(int.Parse(_texFileID), int.Parse(_texRow), int.Parse(_texCol));
                pictureBox2.Image = (Image)databaseHandle.IconFast(Convert.ToInt32(textBox6.Text));
                pictureBox3.Image = (Image)databaseHandle.IconFast(Convert.ToInt32(textBox8.Text));
                pictureBox4.Image = (Image)databaseHandle.IconFast(Convert.ToInt32(textBox10.Text));
                pictureBox5.Image = (Image)databaseHandle.IconFast(Convert.ToInt32(textBox12.Text));
                pictureBox6.Image = (Image)databaseHandle.IconFast(Convert.ToInt32(textBox14.Text));
                pictureBox7.Image = (Image)databaseHandle.IconFast(Convert.ToInt32(textBox16.Text));
                pictureBox8.Image = (Image)databaseHandle.IconFast(Convert.ToInt32(textBox18.Text));
            }
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && components != null)
                components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemCollection));
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.tbNeed6 = new System.Windows.Forms.TextBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.tbNeed5 = new System.Windows.Forms.TextBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.tbNeed4 = new System.Windows.Forms.TextBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.tbNeed3 = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.tbNeed2 = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.tbNeed1 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbCategory = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tbResultType = new System.Windows.Forms.TextBox();
            this.lblResultType = new System.Windows.Forms.Label();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.groupBox11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.groupBox10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.textBox1);
            this.groupBox5.Location = new System.Drawing.Point(12, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(265, 49);
            this.groupBox5.TabIndex = 33;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Search";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Text:";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(53, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(206, 20);
            this.textBox1.TabIndex = 20;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCopy);
            this.groupBox3.Controls.Add(this.btnDelete);
            this.groupBox3.Controls.Add(this.btnAdd);
            this.groupBox3.Controls.Add(this.listBox1);
            this.groupBox3.Location = new System.Drawing.Point(12, 67);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(265, 467);
            this.groupBox3.TabIndex = 34;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Items";
            // 
            // btnCopy
            // 
            this.btnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopy.Location = new System.Drawing.Point(94, 434);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(70, 23);
            this.btnCopy.TabIndex = 5;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(170, 434);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(86, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(3, 434);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(253, 407);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(947, 597);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 35;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Location = new System.Drawing.Point(283, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 166);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Basic";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(134, 20);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(59, 17);
            this.checkBox1.TabIndex = 41;
            this.checkBox1.Text = "Enable";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Desc:";
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(67, 19);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(51, 20);
            this.textBox2.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Index:";
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Location = new System.Drawing.Point(67, 45);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(242, 20);
            this.textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Location = new System.Drawing.Point(67, 71);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(242, 83);
            this.textBox4.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox12);
            this.groupBox2.Controls.Add(this.groupBox11);
            this.groupBox2.Controls.Add(this.groupBox10);
            this.groupBox2.Controls.Add(this.groupBox9);
            this.groupBox2.Controls.Add(this.groupBox8);
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Location = new System.Drawing.Point(283, 184);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(610, 252);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Need Items";
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.tbNeed6);
            this.groupBox12.Controls.Add(this.pictureBox7);
            this.groupBox12.Controls.Add(this.textBox15);
            this.groupBox12.Controls.Add(this.comboBox7);
            this.groupBox12.Controls.Add(this.textBox16);
            this.groupBox12.Controls.Add(this.label21);
            this.groupBox12.Controls.Add(this.label22);
            this.groupBox12.Controls.Add(this.label23);
            this.groupBox12.Location = new System.Drawing.Point(354, 132);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(168, 107);
            this.groupBox12.TabIndex = 7;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Need 6";
            // 
            // tbNeed6
            // 
            this.tbNeed6.Location = new System.Drawing.Point(132, 20);
            this.tbNeed6.Name = "tbNeed6";
            this.tbNeed6.Size = new System.Drawing.Size(31, 20);
            this.tbNeed6.TabIndex = 104;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox7.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox7.Location = new System.Drawing.Point(98, 62);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(32, 32);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 100;
            this.pictureBox7.TabStop = false;
            // 
            // textBox15
            // 
            this.textBox15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox15.Location = new System.Drawing.Point(46, 74);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(46, 20);
            this.textBox15.TabIndex = 5;
            // 
            // comboBox7
            // 
            this.comboBox7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Location = new System.Drawing.Point(46, 19);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(85, 21);
            this.comboBox7.TabIndex = 0;
            this.comboBox7.SelectedIndexChanged += new System.EventHandler(this.comboBox7_SelectedIndexChanged);
            // 
            // textBox16
            // 
            this.textBox16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox16.Location = new System.Drawing.Point(46, 46);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(46, 20);
            this.textBox16.TabIndex = 4;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 21);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(34, 13);
            this.label21.TabIndex = 1;
            this.label21.Text = "Type:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 76);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(38, 13);
            this.label22.TabIndex = 3;
            this.label22.Text = "Count:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(6, 47);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(36, 13);
            this.label23.TabIndex = 2;
            this.label23.Text = "Index:";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.tbNeed5);
            this.groupBox11.Controls.Add(this.pictureBox6);
            this.groupBox11.Controls.Add(this.textBox13);
            this.groupBox11.Controls.Add(this.comboBox6);
            this.groupBox11.Controls.Add(this.textBox14);
            this.groupBox11.Controls.Add(this.label18);
            this.groupBox11.Controls.Add(this.label19);
            this.groupBox11.Controls.Add(this.label20);
            this.groupBox11.Location = new System.Drawing.Point(184, 132);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(168, 107);
            this.groupBox11.TabIndex = 10;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Need 5";
            // 
            // tbNeed5
            // 
            this.tbNeed5.Location = new System.Drawing.Point(132, 20);
            this.tbNeed5.Name = "tbNeed5";
            this.tbNeed5.Size = new System.Drawing.Size(31, 20);
            this.tbNeed5.TabIndex = 103;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox6.Location = new System.Drawing.Point(99, 62);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(32, 32);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 102;
            this.pictureBox6.TabStop = false;
            // 
            // textBox13
            // 
            this.textBox13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox13.Location = new System.Drawing.Point(46, 74);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(46, 20);
            this.textBox13.TabIndex = 5;
            // 
            // comboBox6
            // 
            this.comboBox6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(46, 19);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(85, 21);
            this.comboBox6.TabIndex = 0;
            this.comboBox6.SelectedIndexChanged += new System.EventHandler(this.comboBox6_SelectedIndexChanged);
            // 
            // textBox14
            // 
            this.textBox14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox14.Location = new System.Drawing.Point(46, 45);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(46, 20);
            this.textBox14.TabIndex = 4;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 21);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(34, 13);
            this.label18.TabIndex = 1;
            this.label18.Text = "Type:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 76);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(38, 13);
            this.label19.TabIndex = 3;
            this.label19.Text = "Count:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 47);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(36, 13);
            this.label20.TabIndex = 2;
            this.label20.Text = "Index:";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.tbNeed4);
            this.groupBox10.Controls.Add(this.pictureBox5);
            this.groupBox10.Controls.Add(this.textBox11);
            this.groupBox10.Controls.Add(this.comboBox5);
            this.groupBox10.Controls.Add(this.textBox12);
            this.groupBox10.Controls.Add(this.label15);
            this.groupBox10.Controls.Add(this.label16);
            this.groupBox10.Controls.Add(this.label17);
            this.groupBox10.Location = new System.Drawing.Point(14, 132);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(168, 107);
            this.groupBox10.TabIndex = 9;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Need 4";
            // 
            // tbNeed4
            // 
            this.tbNeed4.Location = new System.Drawing.Point(133, 20);
            this.tbNeed4.Name = "tbNeed4";
            this.tbNeed4.Size = new System.Drawing.Size(31, 20);
            this.tbNeed4.TabIndex = 102;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox5.Location = new System.Drawing.Point(103, 62);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(32, 32);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 101;
            this.pictureBox5.TabStop = false;
            // 
            // textBox11
            // 
            this.textBox11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox11.Location = new System.Drawing.Point(46, 74);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(46, 20);
            this.textBox11.TabIndex = 5;
            // 
            // comboBox5
            // 
            this.comboBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(46, 19);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(85, 21);
            this.comboBox5.TabIndex = 0;
            this.comboBox5.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // textBox12
            // 
            this.textBox12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox12.Location = new System.Drawing.Point(45, 45);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(46, 20);
            this.textBox12.TabIndex = 4;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 21);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 13);
            this.label15.TabIndex = 1;
            this.label15.Text = "Type:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 76);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(38, 13);
            this.label16.TabIndex = 3;
            this.label16.Text = "Count:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 47);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(36, 13);
            this.label17.TabIndex = 2;
            this.label17.Text = "Index:";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.tbNeed3);
            this.groupBox9.Controls.Add(this.pictureBox4);
            this.groupBox9.Controls.Add(this.textBox9);
            this.groupBox9.Controls.Add(this.comboBox4);
            this.groupBox9.Controls.Add(this.textBox10);
            this.groupBox9.Controls.Add(this.label12);
            this.groupBox9.Controls.Add(this.label13);
            this.groupBox9.Controls.Add(this.label14);
            this.groupBox9.Location = new System.Drawing.Point(356, 19);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(168, 107);
            this.groupBox9.TabIndex = 8;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Need 3";
            // 
            // tbNeed3
            // 
            this.tbNeed3.Location = new System.Drawing.Point(131, 19);
            this.tbNeed3.Name = "tbNeed3";
            this.tbNeed3.Size = new System.Drawing.Size(31, 20);
            this.tbNeed3.TabIndex = 103;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox4.Location = new System.Drawing.Point(98, 62);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 100;
            this.pictureBox4.TabStop = false;
            // 
            // textBox9
            // 
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox9.Location = new System.Drawing.Point(46, 74);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(46, 20);
            this.textBox9.TabIndex = 5;
            // 
            // comboBox4
            // 
            this.comboBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(46, 19);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(85, 21);
            this.comboBox4.TabIndex = 0;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // textBox10
            // 
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox10.Location = new System.Drawing.Point(46, 45);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(46, 20);
            this.textBox10.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Type:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 76);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "Count:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 47);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(36, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "Index:";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.tbNeed2);
            this.groupBox8.Controls.Add(this.pictureBox3);
            this.groupBox8.Controls.Add(this.textBox7);
            this.groupBox8.Controls.Add(this.comboBox3);
            this.groupBox8.Controls.Add(this.textBox8);
            this.groupBox8.Controls.Add(this.label9);
            this.groupBox8.Controls.Add(this.label10);
            this.groupBox8.Controls.Add(this.label11);
            this.groupBox8.Location = new System.Drawing.Point(185, 19);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(168, 107);
            this.groupBox8.TabIndex = 7;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Need 2";
            // 
            // tbNeed2
            // 
            this.tbNeed2.Location = new System.Drawing.Point(131, 19);
            this.tbNeed2.Name = "tbNeed2";
            this.tbNeed2.Size = new System.Drawing.Size(31, 20);
            this.tbNeed2.TabIndex = 102;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox3.Location = new System.Drawing.Point(99, 62);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 100;
            this.pictureBox3.TabStop = false;
            // 
            // textBox7
            // 
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox7.Location = new System.Drawing.Point(46, 74);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(46, 20);
            this.textBox7.TabIndex = 5;
            // 
            // comboBox3
            // 
            this.comboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(46, 19);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(85, 21);
            this.comboBox3.TabIndex = 0;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // textBox8
            // 
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox8.Location = new System.Drawing.Point(46, 45);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(46, 20);
            this.textBox8.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Type:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Count:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Index:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.tbNeed1);
            this.groupBox6.Controls.Add(this.pictureBox2);
            this.groupBox6.Controls.Add(this.textBox6);
            this.groupBox6.Controls.Add(this.comboBox2);
            this.groupBox6.Controls.Add(this.textBox5);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Location = new System.Drawing.Point(14, 19);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(168, 107);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Need 1";
            // 
            // tbNeed1
            // 
            this.tbNeed1.Location = new System.Drawing.Point(133, 20);
            this.tbNeed1.Name = "tbNeed1";
            this.tbNeed1.Size = new System.Drawing.Size(31, 20);
            this.tbNeed1.TabIndex = 101;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox2.Location = new System.Drawing.Point(99, 62);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 99;
            this.pictureBox2.TabStop = false;
            // 
            // textBox6
            // 
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox6.Location = new System.Drawing.Point(46, 45);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(45, 20);
            this.textBox6.TabIndex = 5;
            // 
            // comboBox2
            // 
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(46, 19);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(85, 21);
            this.comboBox2.TabIndex = 0;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // textBox5
            // 
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox5.Location = new System.Drawing.Point(46, 74);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(45, 20);
            this.textBox5.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Type:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Count:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Index:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tbCategory);
            this.groupBox4.Controls.Add(this.comboBox1);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(604, 86);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(299, 49);
            this.groupBox4.TabIndex = 40;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Category";
            // 
            // tbCategory
            // 
            this.tbCategory.Location = new System.Drawing.Point(255, 17);
            this.tbCategory.Name = "tbCategory";
            this.tbCategory.Size = new System.Drawing.Size(43, 20);
            this.tbCategory.TabIndex = 104;
            // 
            // comboBox1
            // 
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(64, 16);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(186, 21);
            this.comboBox1.TabIndex = 40;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Category:";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.pictureBox8);
            this.groupBox7.Controls.Add(this.textBox17);
            this.groupBox7.Controls.Add(this.comboBox8);
            this.groupBox7.Controls.Add(this.textBox18);
            this.groupBox7.Controls.Add(this.label26);
            this.groupBox7.Controls.Add(this.label24);
            this.groupBox7.Controls.Add(this.label25);
            this.groupBox7.Location = new System.Drawing.Point(283, 442);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(473, 53);
            this.groupBox7.TabIndex = 42;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Result";
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox8.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox8.Location = new System.Drawing.Point(435, 13);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(32, 32);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 101;
            this.pictureBox8.TabStop = false;
            // 
            // textBox17
            // 
            this.textBox17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox17.Location = new System.Drawing.Point(321, 20);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(85, 20);
            this.textBox17.TabIndex = 5;
            // 
            // comboBox8
            // 
            this.comboBox8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Location = new System.Drawing.Point(46, 19);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(85, 21);
            this.comboBox8.TabIndex = 0;
            this.comboBox8.SelectedIndexChanged += new System.EventHandler(this.comboBox8_SelectedIndexChanged);
            // 
            // textBox18
            // 
            this.textBox18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox18.Location = new System.Drawing.Point(179, 19);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(85, 20);
            this.textBox18.TabIndex = 4;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(137, 22);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(36, 13);
            this.label26.TabIndex = 2;
            this.label26.Text = "Index:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(6, 21);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(34, 13);
            this.label24.TabIndex = 1;
            this.label24.Text = "Type:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(277, 22);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(38, 13);
            this.label25.TabIndex = 3;
            this.label25.Text = "Count:";
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(669, 501);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Blue;
            this.linkLabel1.Location = new System.Drawing.Point(665, 57);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(61, 13);
            this.linkLabel1.TabIndex = 98;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Icon Picker";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Location = new System.Drawing.Point(604, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 96;
            this.pictureBox1.TabStop = false;
            // 
            // tbResultType
            // 
            this.tbResultType.Location = new System.Drawing.Point(341, 503);
            this.tbResultType.Name = "tbResultType";
            this.tbResultType.Size = new System.Drawing.Size(73, 20);
            this.tbResultType.TabIndex = 99;
            // 
            // lblResultType
            // 
            this.lblResultType.AutoSize = true;
            this.lblResultType.Location = new System.Drawing.Point(292, 507);
            this.lblResultType.Name = "lblResultType";
            this.lblResultType.Size = new System.Drawing.Size(44, 13);
            this.lblResultType.TabIndex = 100;
            this.lblResultType.Text = "ResultT";
            // 
            // ItemCollection
            // 
            this.ClientSize = new System.Drawing.Size(905, 551);
            this.Controls.Add(this.lblResultType);
            this.Controls.Add(this.tbResultType);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox5);
            
            this.Name = "ItemCollection";
            this.Text = "ItemCollection";
            this.Load += new System.EventHandler(this.ItemCollection_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

        private void LoadStartUpCombo() //initialize a startup load for the combo box strings
        {
            comboBox1.Items.AddRange(new object[4] //newobject  is a way to count the amount of objects or "values" you have in the collection 
      {
         "1 - The greatest hero", //displays the combo box on form as these values 
         "2 - The alchemy of all creation",
         "3 - The richest trader",
         "4 - The courageous adventurer"
      });
            comboBox2.Items.AddRange(new object[3] //combo box 2-7 are Need Theme
      {
         "0 - NONE",
         "1 - ITEM",
         "2 - THEME"
      });
            comboBox3.Items.AddRange(new object[3]
    {
         "0 - NONE",
         "1 - ITEM",
         "2 - THEME"
      });
            comboBox4.Items.AddRange(new object[3]
     {
         "0 - NONE",
         "1 - ITEM",
         "2 - THEME"
      });
            comboBox5.Items.AddRange(new object[3]
     {
         "0 - NONE",
         "1 - ITEM",
         "2 - THEME"
      });
            comboBox6.Items.AddRange(new object[3]
      {
         "0 - NONE",
         "1 - ITEM",
         "2 - THEME"
      });
            comboBox7.Items.AddRange(new object[3]
    {
         "0 - NONE",
         "1 - ITEM",
         "2 - THEME"
      });
            comboBox8.Items.AddRange(new object[4] //result combo box strings
      {
         "1 - ITEM",
         "2 - GOLD",
         "3 - EXP",
         "4 - SP"
      });

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbCategory.Text = GetIndexByComboBox(comboBox1.Text).ToString(); //dethunter12 add
        }

        private void SelectBoxes() //dethunter12 add
        {
            int num1 = comboBox1.FindString(tbCategory.Text); //dethunter12 add
            int num2 = comboBox2.FindString(tbNeed1.Text); //dethunter12 add
            int num3 = comboBox3.FindString(tbNeed2.Text); //dethunter12 add
            int num4 = comboBox4.FindString(tbNeed3.Text); //dethunter12 add
            int num5 = comboBox5.FindString(tbNeed4.Text); //dethunter12 add
            int num6 = comboBox6.FindString(tbNeed5.Text); //dethunter12 add
            int num7 = comboBox7.FindString(tbNeed6.Text); //dethunter12 add
            int num8 = comboBox8.FindString(tbResultType.Text); //dethunter12 add
            comboBox1.SelectedIndex = num1; //dethunter12 add
            comboBox2.SelectedIndex = num2; //dethunter12 add
            comboBox3.SelectedIndex = num3; //dethunter12 add
            comboBox4.SelectedIndex = num4; //dethunter12 add
            comboBox5.SelectedIndex = num5; //dethunter12 add
            comboBox6.SelectedIndex = num6; //dethunter12 add
            comboBox7.SelectedIndex = num7; //dethunter12 add
            comboBox8.SelectedIndex = num8; //dethunter12 add
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboBox1.BackColor = Color.Pink; //dethunter12 add
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbNeed1.Text = GetIndexByComboBox(comboBox2.Text).ToString(); //dethunter12 add
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbNeed2.Text = GetIndexByComboBox(comboBox3.Text).ToString(); //dethunter12 add
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbNeed3.Text = GetIndexByComboBox(comboBox4.Text).ToString(); //dethunter12 add
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbNeed4.Text = GetIndexByComboBox(comboBox5.Text).ToString(); //dethunter12 add
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbNeed5.Text = GetIndexByComboBox(comboBox6.Text).ToString(); //dethunter12 add
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbNeed6.Text = GetIndexByComboBox(comboBox7.Text).ToString(); //dethunter12 add
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbResultType.Text = GetIndexByComboBox(comboBox8.Text).ToString(); //dethunter12 add
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string str9 = "UPDATE t_item_collection SET " + "a_theme = '" + textBox2.Text + "', " + "category = '" + tbCategory.Text + "', ";
            string str10 = textBox3.Text.Replace("'", "\\'").Replace("\"", "\\\"");
            string QueryUpdate = str9 + "a_name = '" + str10 + "', " + "a_maxlevel = '" + textBox3.Text + "'," + "a_damagetype = '" + textBox6.Text + "'," + "a_hittype = '" + textBox7.Text + "'," + "a_attribute = '" + textBox8.Text + "'," + "a_psp = '" + textBox9.Text + "'," + "a_ptp = '" + textBox10.Text + "'," + "a_hsp = '" + textBox11.Text + "'," + "a_htp = '" + textBox12.Text + "'," + "a_togle = '" + textBox13.Text + "'" + " WHERE a_index = '" + textBox1.Text + "'";
            databaseHandle.SendQueryMySql(Host, User, Password, Database, QueryUpdate); //dethunter12 add
            Console.WriteLine(QueryUpdate); //dethunter12 add
            int selectedIndex = listBox1.SelectedIndex;
            if (textBox1.Text != "") //dethunter12 add
                MenuListSearch = MenuList.FindAll(new Predicate<string>(SearchString));
            else
                LoadListBox();
            listBox1.SelectedIndex = selectedIndex;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            databaseHandle.SendQueryMySql(Host, User, Password, Database, "INSERT INTO t_item_collection DEFAULT VALUES");
            LoadListBox();
            listBox1.SelectedIndex = listBox1.Items.Count - 1;
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            databaseHandle.SendQueryMySql(Host, User, Password, Database, "DROP TABLE IF EXISTS tempTable;" + "CREATE TEMPORARY TABLE tempTable ENGINE=MEMORY SELECT * FROM t_item_collection WHERE a_theme=" + textBox2.Text + ";" + "SELECT a_theme FROM tempTable;" + "UPDATE tempTable SET a_theme=(SELECT a_theme from t_item_collection ORDER BY a_theme DESC LIMIT 1)+1; " + "SELECT a_theme FROM tempTable;" + "INSERT INTO t_item_collection SELECT * FROM tempTable;");
            LoadListBox();
            listBox1.SelectedIndex = listBox1.Items.Count - 1;
        }

        private void btnDelete_Click(object sender, EventArgs e) //dethunter12 add
        {
            int selectedIndex = listBox1.SelectedIndex;
            databaseHandle.SendQueryMySql(Host, User, Password, Database, "DELETE FROM t_item_collection WHERE a_theme = '" + textBox2.Text + "'");
            LoadListBox();
            listBox1.SelectedIndex = selectedIndex - 1;
        }
    }
}
