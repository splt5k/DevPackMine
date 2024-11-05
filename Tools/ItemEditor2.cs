// Decompiled with JetBrains decompiler
// Type: DevPackMine.Tools.ItemEditor2
// Assembly: DevPackMine, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6B9BC8BF-B510-4945-A515-04135CC0F4A4
// Assembly location: C:\Users\NTServer\Desktop\DevPackMine\DevPackMine\DevPackMine.exe

using MySql.Data.MySqlClient;
using SlimDX;
using SlimDX.Direct3D9;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;



namespace DevPackMine.Tools
{

    public class ItemEditor2 : Form
    {
        public static Connection connection = new Connection();
        private int w = 0;
        private int a = 0;
        private string Host = ItemEditor2.connection.ReadSettings("Host");
        private string User = ItemEditor2.connection.ReadSettings("User");
        private string Password = ItemEditor2.connection.ReadSettings("Password");
        private string Database = ItemEditor2.connection.ReadSettings("Database");
        private string language = ItemEditor2.connection.ReadSettings("Language");//dethunter12 test
        private DatabaseHandle databaseHandle = new DatabaseHandle();
        public string rowName = "a_index";
        public string[] menuArray = new string[2]
        {
      "a_index",
      "a_name"
        };
        //dethunter12 language strings 4/11/2018
        public string[] menuArrayGER = new string[2]
           {
      "a_index",
      "a_name_ger"
           };
        public string[] menuArrayPOL = new string[2]
                {
      "a_index",
      "a_name_pld"
                };
        public string[] menuArrayBRA = new string[2]
                   {
      "a_index",
      "a_name_brz"
                   };
        public string[] menuArrayRUS = new string[2]
                   {
      "a_index",
      "a_name_rus"
                   };
        public string[] menuArrayFRA = new string[2]
                   {
      "a_index",
      "a_name_frc"
                   };
        public string[] menuArrayESP = new string[2]
                   {
      "a_index",
      "a_name_spn"
                   };
        public string[] menuArrayMEX = new string[2]
                   {
      "a_index",
      "a_name_mex"
                   };
        public string[] menuArrayTHA = new string[2]
                   {
      "a_index",
      "a_name_thai"
                   };
        public string[] menuArrayITA = new string[2]
                   {
      "a_index",
      "a_name_ita"
                   };
        public string[] menuArrayUSA = new string[2]
                   {
      "a_index",
      "a_name_usa"
                   };
        private string namee; //dethunter12 stringfrom lang modify
        public string adescr = "";
        public string aname = ""; //dehtunter12 add
        private Label label8;
        private Label lblLang;
        private GroupBox gbFortune;
        private Button button8;
        private Button button6;
        private DataGridView dataGridView1;
        private Button button7;
        public string descrr;
        public string StringFromLanguage() //dethunter12 4/11/2018
        {

            if (language == "GER")
            {
                namee = "a_name_ger";
                return namee;

            }
            else if (language == "POL")
            {
                namee = "a_name_pld";
                return namee;

            }
            else if (language == "BRA")
            {
                namee = "a_name_brz";
                return namee;
            }
            else if (language == "RUS")
            {
                namee = "a_name_rus";
                return namee;
            }
            else if (language == "FRA")
            {
                namee = "a_name_frc";
                return namee;
            }
            else if (language == "ESP")
            {
                namee = "a_name_spn";
                return namee;
            }
            else if (language == "MEX")
            {
                namee = "a_name_mex";
                return namee;
            }
            else if (language == "THA")
            {
                namee = "a_name_thai";
                return namee;
            }
            else if (language == "ITA")
            {
                namee = "a_name_ita";
                return namee;
            }
            else if (language == "USA")
            {
                namee = "a_name_usa";
                return namee;
            }
            else
            {
                return null;
            }
        }
        public string DescrFromLanguage() //dethunter12 4/11/2018
        {

            if (language == "GER")
            {
                descrr = "a_descr_ger";
                return descrr;

            }
            else if (language == "POL")
            {
                descrr = "a_descr_pld";
                return descrr;

            }
            else if (language == "BRA")
            {
                descrr = "a_descr_brz";
                return descrr;
            }
            else if (language == "RUS")
            {
                descrr = "a_descr_rus";
                return descrr;
            }
            else if (language == "FRA")
            {
                descrr = "a_descr_frc";
                return descrr;
            }
            else if (language == "ESP")
            {
                descrr = "a_descr_spn";
                return descrr;
            }
            else if (language == "MEX")
            {
                descrr = "a_descr_mex";
                return descrr;
            }
            else if (language == "THA")
            {
                descrr = "a_descr_thai";
                return descrr;
            }
            else if (language == "ITA")
            {
                descrr = "a_descr_ita";
                return descrr;
            }
            else if (language == "USA")
            {
                descrr = "a_descr_usa";
                return descrr;
            }
            else
            {
                return null;
            }
        }
        public string[] menuArray2 = new string[2]
        {
      "a_type",
      "a_name"
        };
        public string[] menuArray3 = new string[1] { "a_level" };
        public string[] SearchMenu = new string[2]
        {
      "a_index",
      "a_name"
        };
        public string mSortJob = "-1";
        public string mSortJob2 = "-1";
        public string _SortAboveLevel = "-1";
        private string Episode = ItemEditor2.connection.ReadSettings("Episode");
        public System.Collections.Generic.List<string> MenuList = new System.Collections.Generic.List<string>();
        public System.Collections.Generic.List<string> MenuListSearch = new System.Collections.Generic.List<string>();
        public string flagBuilderType = "items"; //dethunter12 add
        public long flagBig; //dethunter12 add
        public int flagSmall; //dethunter12 add
        public float _UpDown = -1f;
        private ASCIIEncoding _Enc = new ASCIIEncoding();
        public string _ClientPath = ItemEditor2.connection.ReadSettings("ClientPath");
        public bool _ComboBoxPurpleLocked = false;
        private ExportLodHandle exportLodHandle = new ExportLodHandle();
        private IContainer components = (IContainer)null;
        public System.Collections.Generic.List<string> List;
        public System.Collections.Generic.List<string> List2;
        public System.Collections.Generic.List<string> List3;
        public System.Collections.Generic.List<string> List4;
        public System.Collections.Generic.List<string> List5;
        public System.Collections.Generic.List<string> List6;
        public System.Collections.Generic.List<string> List7;
        public System.Collections.Generic.List<string> List8;
        public System.Collections.Generic.List<string> List9;
        public System.Collections.Generic.List<string> List10;
        public string name;
        public int index;
        public string test2;
        public Direct3D _Direct3D;
        public Device _Device;
        public float _Zoom;
        public float _LeftRight;
        public float _Rotation;
        public System.Collections.Generic.List<tMesh> _Models;
        public System.Collections.Generic.List<string> lArrayLevel;
        public string varf5;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileExportToolStripMenuItem;
        private ToolStripMenuItem exportlodToolStripMenuItem;
        private GroupBox groupBox3;
        private Button button3;
        private Button button1;
        private ListBox listBox1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Button button2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label2;
        private TextBox textBox4;
        private Label label4;
        private Label label6;
        private TextBox textBox1;
        private Label label5;
        private Label label1;
        private TextBox textBox5;
        private TextBox textBox6;
        private GroupBox groupBox4;
        private TextBox textBox15;
        private Label label15;
        private TextBox textBox10;
        private Label label11;
        private Label label14;
        private TextBox textBox11;
        private TextBox textBox14;
        private Label label12;
        private Label label13;
        private TextBox textBox13;
        private Label label9;
        private Label label10;
        private TextBox textBox9;
        private TextBox textBox7;
        private GroupBox groupBox6;
        private TextBox textBox19;
        private Label label19;
        private TextBox textBox16;
        private Label label16;
        private Label label18;
        private TextBox textBox17;
        private TextBox textBox18;
        private Label label17;
        private Label label20;
        private TextBox textBox20;
        private TextBox textBox21;
        private Label label21;
        private TextBox textBox28;
        private Label label28;
        private TextBox textBox27;
        private Label label27;
        private TextBox textBox26;
        private Label label26;
        private TextBox textBox25;
        private Label label25;
        private TextBox textBox24;
        private Label label24;
        private TextBox textBox23;
        private Label label23;
        private Label label22;
        private TextBox textBox31;
        private Label label31;
        private TextBox textBox30;
        private Label label30;
        private TextBox textBox29;
        private Label label29;
        private TextBox textBox41;
        private Label label41;
        private TextBox textBox40;
        private Label label40;
        private TextBox textBox39;
        private Label label39;
        private TextBox textBox38;
        private Label label38;
        private TextBox textBox37;
        private Label label37;
        private TextBox textBox36;
        private Label label36;
        private TextBox textBox35;
        private Label label35;
        private TextBox textBox34;
        private Label label34;
        private TextBox textBox33;
        private Label label33;
        private TextBox textBox32;
        private Label label32;
        private GroupBox groupBox8;
        private TextBox textBox43;
        private Label label43;
        private TextBox textBox42;
        private Label label42;
        private TextBox textBox45;
        private Label label45;
        private TextBox textBox44;
        private Label label44;
        private TextBox textBox46;
        private Label label46;
        private Label label47;
        private TextBox textBox47;
        private GroupBox groupBox9;
        private Label label50;
        private TextBox textBox50;
        private Label label49;
        private TextBox textBox49;
        private Label label48;
        private TextBox textBox48;
        private PictureBox pictureBox1;
        private GroupBox groupBox10;
        private TextBox textBox55;
        private Label label55;
        private TextBox textBox54;
        private Label label54;
        private TextBox textBox53;
        private Label label53;
        private TextBox textBox52;
        private Label label52;
        private GroupBox groupBox11;
        private TextBox textBox57;
        private Label label56;
        private Label label57;
        private TextBox textBox56;
        private TextBox textBox58;
        private Label label58;
        private GroupBox groupBox13;
        private TextBox textBox68;
        private Label label68;
        private TextBox textBox67;
        private Label label67;
        private TextBox textBox66;
        private Label label66;
        private TextBox textBox65;
        private Label label65;
        private TextBox textBox64;
        private Label label64;
        private TextBox textBox63;
        private Label label63;
        private TextBox textBox62;
        private Label label62;
        private TextBox textBox61;
        private Label label61;
        private TextBox textBox60;
        private Label label60;
        private TextBox textBox69;
        private Label label69;
        private TextBox textBox79;
        private Label label79;
        private TextBox textBox78;
        private Label label78;
        private TextBox textBox77;
        private Label label77;
        private TextBox textBox76;
        private Label label76;
        private TextBox textBox75;
        private Label label75;
        private TextBox textBox74;
        private Label label74;
        private TextBox textBox73;
        private Label label73;
        private TextBox textBox72;
        private Label label72;
        private TextBox textBox71;
        private Label label71;
        private TextBox textBox70;
        private Label label70;
        private GroupBox groupBox14;
        private Label label80;
        private TextBox textBox80;
        private Label label82;
        private TextBox textBox82;
        private Label label81;
        private TextBox textBox81;
        private GroupBox groupBox16;
        private Label label92;
        private TextBox textBox92;
        private Label label91;
        private TextBox textBox91;
        private ComboBox comboBox1;
        private ComboBox comboBox4;
        private ComboBox comboBox2;
        private TextBox textBox90;
        private Label label90;
        private TextBox textBox89;
        private Label label89;
        private TextBox textBox88;
        private Label label88;
        private TextBox textBox87;
        private Label label87;
        private TextBox textBox86;
        private Label label86;
        private TextBox textBox85;
        private Label label85;
        private Button button4;
        private ToolStripMenuItem exportStrItemlodToolStripMenuItem;
        private CheckedListBox checkedListBox1;
        private TextBox textBox22;
        private CheckBox checkBox1;
        private TextBox textBox8;
        private GroupBox groupBox7;
        private GroupBox groupBox17;
        private ComboBox comboBox3;
        private Label label95;
        private Label label96;
        private Label label97;
        private Label label98;
        private Label label99;
        private ComboBox comboBox5;
        private ComboBox comboBox6;
        private ComboBox comboBox7;
        private ComboBox comboBox8;
        private ComboBox comboBox9;
        private ComboBox comboBox14;
        private Label label104;
        private ComboBox comboBox13;
        private Label label103;
        private Label label102;
        private Label label101;
        private Label label100;
        private ComboBox comboBox12;
        private ComboBox comboBox11;
        private ComboBox comboBox10;
        private ComboBox comboBox15;
        private ComboBox comboBox16;
        private ComboBox comboBox17;
        private ComboBox comboBox18;
        private ComboBox comboBox19;
        private ComboBox comboBox20;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox3;
        private ToolTip toolTip1;
        private ComboBox comboBox21;
        private ComboBox comboBox22;
        private ComboBox comboBox23;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private PictureBox pictureBox10;
        private PictureBox pictureBox11;
        private PictureBox pictureBox12;
        public PictureBox pictureBox13;
        public PictureBox pictureBox14;
        public PictureBox pictureBox15;
        public PictureBox pictureBox16;
        public PictureBox pictureBox17;
        public PictureBox pictureBox18;
        public PictureBox pictureBox19;
        public PictureBox pictureBox20;
        public PictureBox pictureBox21;
        public PictureBox pictureBox22;
        public CheckedListBox clbFlagTest;
        private GroupBox groupBox18;
        private GroupBox groupBox19;
        private TextBox textBox12;
        private Label label7;
        private GroupBox groupBox5;
        private CheckedListBox checkedListBox2;
        private TextBox textBox93;
        private TextBox textBox94;
        private Label label93;
        private Label label94;
        private TextBox textBox84;
        private Label label84;
        private TextBox textBox83;
        private Label label83;
        private TextBox textBox51;
        private TextBox textBox59;
        private Label label51;
        private Label label59;
        private Label label105;
        private ToolStripMenuItem massEditToolStripMenuItem;
        private ToolStripMenuItem v;
        private ToolStripMenuItem massUpdateSealsToolStripMenuItem;
        private ComboBox CbSubType6;
        private ComboBox CbSubType5;
        private ComboBox CbSubType7;
        private ComboBox CbSubType4;
        private ComboBox CbSubtype3;
        private ComboBox CbSubtype2;
        private ComboBox CbSubtype1;
        private ToolStripMenuItem exportSmclodToolStripMenuItem;
        private ToolStripMenuItem exportToolStripMenuItem;
        private ToolTip toolTip2;
        private ToolTip toolTip3;
        private ToolTip toolTip4;
        private ToolTip toolTip5;
        private ToolTip toolTip6;
        private ToolTip toolTip7;
        private ToolTip toolTip8;
        private ToolTip toolTip9;
        private ToolTip toolTip10;
        private PictureBox pictureBox2;
        private TextBox textBox95;
        public static string OpenedFile; //dethunter12 add
        private Button btnPercent2Add;
        private Button btnPercent1Add;
        private Button btnPercentAdd;
        private TextBox TbPercent2;
        private TextBox TbPercent1;
        private TextBox TbPercent;
        private Label label108;
        private Label label107;
        private Label label106;
        private ComboBox comboBox25;
        private ComboBox comboBox24;
        private GroupBox groupBox15;
        private PictureBox pictureBox25;
        private PictureBox pictureBox24;
        private GroupBox groupBox21;
        private Label label109;
        private GroupBox groupBox23;
        private GroupBox groupBox22;
        private ComboBox comboBox26;
        private Button button5;
        private GroupBox groupBox12;
        public CheckedListBox ClbItemFlag;
        string tmpPath = "Data\\";

        public ItemEditor2()
        {
            InitializeComponent();
        }

        public ItemEditor2(string text)
        {
            Text = text;
        }

        private void LoadListBox()
        {
            listBox1.SelectedIndex = -1;
            MenuList.Clear();
            namee = StringFromLanguage(); //dethunter12 modify language
      
            string Query = "SELECT a_index, " + namee +" " + "FROM" + " t_item WHERE a_job_flag ='" + mSortJob + "' ORDER BY a_index;";
            if (mSortJob == "-1")
                Query = "SELECT a_index, " + namee +" "+ "FROM" + " " +  "t_item ORDER BY a_index;";
            if (_SortAboveLevel != "-1")
                Query = "SELECT a_index, " + namee + " " + "FROM t_item WHERE a_level >= " + _SortAboveLevel + ";";
            if (language == "GER")
            {
                listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArrayGER, Host, User, Password, Database, Query);
            }
            else if (language == "POL")
            {
                listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArrayPOL, Host, User, Password, Database, Query);
            }
            else if (language == "BRA")
            {
                listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArrayBRA, Host, User, Password, Database, Query);
            }
            else if (language == "RUS")
            {
                listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArrayRUS, Host, User, Password, Database, Query);
            }
            else if (language == "FRA")
            {
                listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArrayFRA, Host, User, Password, Database, Query);
            }
            else if (language == "ESP")
            {
                listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArrayESP, Host, User, Password, Database, Query);
            }
            else if (language == "MEX")
            {
                listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArrayMEX, Host, User, Password, Database, Query);
            }
            else if (language == "THA")
            {
                listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArrayTHA, Host, User, Password, Database, Query);
            }
            else if (language == "ITA")
            {
                listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArrayITA, Host, User, Password, Database, Query);
            }
            else if (language == "USA")
            {
                listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArrayUSA, Host, User, Password, Database, Query);
            }
            else
            {
                listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArray, Host, User, Password, Database, Query);
            }
           // listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArray, Host, User, Password, Database, Query);
            for (int index = 0; index < listBox1.Items.Count; ++index)
                MenuList.Add(listBox1.Items[index].ToString());
            listBox1.DataSource = MenuList;
            listBox1.SelectedIndex = -1;
        }

        public void SearchList(string searchString)
        {
            searchString = searchString.Replace("\\", "\\\\").Replace("'", "\\'");
            string lower = searchString.ToLower();
            string upper = searchString.ToUpper();
            string str = "";
            if (searchString.Length > 1)
                str = char.ToUpper(searchString[0]).ToString() + searchString.Substring(1);
            //dethunter12 4/11/2018 language add
            if (language == "GER")
            {
                //search the list box with german
                listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArrayGER, Host, User, Password, Database, "select a_index, a_name_ger from t_item WHERE a_name_ger LIKE '%" + searchString + "%'" + " OR a_index LIKE '%" + searchString + "%'" + " OR a_name_ger LIKE '%" + lower + "%' OR a_index  LIKE '%" + lower + "%'" + " OR a_name_ger LIKE '%" + upper + "%' OR a_index LIKE '%" + upper + "%'" + " OR a_name_ger LIKE '%" + str + "%' OR a_index LIKE '%" + str + "%'" + " ORDER BY a_index;");

            }
            else if (language == "POL")
            {
                listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArrayPOL, Host, User, Password, Database, "select a_index, a_name_pld from t_item WHERE a_name_pld LIKE '%" + searchString + "%'" + " OR a_index LIKE '%" + searchString + "%'" + " OR a_name_pld LIKE '%" + lower + "%' OR a_index  LIKE '%" + lower + "%'" + " OR a_name_pld LIKE '%" + upper + "%' OR a_index LIKE '%" + upper + "%'" + " OR a_name_pld LIKE '%" + str + "%' OR a_index LIKE '%" + str + "%'" + " ORDER BY a_index;");

            }
            else if (language == "BRA")
            {
                listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArrayBRA, Host, User, Password, Database, "select a_index, a_name_brz from t_item WHERE a_name_brz LIKE '%" + searchString + "%'" + " OR a_index LIKE '%" + searchString + "%'" + " OR a_name_brz LIKE '%" + lower + "%' OR a_index  LIKE '%" + lower + "%'" + " OR a_name_brz LIKE '%" + upper + "%' OR a_index LIKE '%" + upper + "%'" + " OR a_name_brz LIKE '%" + str + "%' OR a_index LIKE '%" + str + "%'" + " ORDER BY a_index;");

            }
            else if (language == "RUS")
            {
                listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArrayRUS, Host, User, Password, Database, "select a_index, a_name_rus from t_item WHERE a_name_rus LIKE '%" + searchString + "%'" + " OR a_index LIKE '%" + searchString + "%'" + " OR a_name_rus LIKE '%" + lower + "%' OR a_index  LIKE '%" + lower + "%'" + " OR a_name_rus LIKE '%" + upper + "%' OR a_index LIKE '%" + upper + "%'" + " OR a_name_rus LIKE '%" + str + "%' OR a_index LIKE '%" + str + "%'" + " ORDER BY a_index;");

            }
            else if (language == "FRA")
            {
                listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArrayFRA, Host, User, Password, Database, "select a_index, a_name_frc from t_item WHERE a_name_frc LIKE '%" + searchString + "%'" + " OR a_index LIKE '%" + searchString + "%'" + " OR a_name_frc LIKE '%" + lower + "%' OR a_index  LIKE '%" + lower + "%'" + " OR a_name_frc LIKE '%" + upper + "%' OR a_index LIKE '%" + upper + "%'" + " OR a_name_frc LIKE '%" + str + "%' OR a_index LIKE '%" + str + "%'" + " ORDER BY a_index;");

            }
            else if (language == "ESP")
            {
                listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArrayESP, Host, User, Password, Database, "select a_index, a_name_spn from t_item WHERE a_name_spn LIKE '%" + searchString + "%'" + " OR a_index LIKE '%" + searchString + "%'" + " OR a_name_spn LIKE '%" + lower + "%' OR a_index  LIKE '%" + lower + "%'" + " OR a_name_spn LIKE '%" + upper + "%' OR a_index LIKE '%" + upper + "%'" + " OR a_name_spn LIKE '%" + str + "%' OR a_index LIKE '%" + str + "%'" + " ORDER BY a_index;");

            }
            else if (language == "MEX")
            {
                listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArrayMEX, Host, User, Password, Database, "select a_index, a_name_mex from t_item WHERE a_name_mex LIKE '%" + searchString + "%'" + " OR a_index LIKE '%" + searchString + "%'" + " OR a_name_mex LIKE '%" + lower + "%' OR a_index  LIKE '%" + lower + "%'" + " OR a_name_mex LIKE '%" + upper + "%' OR a_index LIKE '%" + upper + "%'" + " OR a_name_mex LIKE '%" + str + "%' OR a_index LIKE '%" + str + "%'" + " ORDER BY a_index;");

            }
            else if (language == "THA")
            {
                listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArrayTHA, Host, User, Password, Database, "select a_index, a_name_thai from t_item WHERE a_name_thai LIKE '%" + searchString + "%'" + " OR a_index LIKE '%" + searchString + "%'" + " OR a_name_thai LIKE '%" + lower + "%' OR a_index  LIKE '%" + lower + "%'" + " OR a_name_thai LIKE '%" + upper + "%' OR a_index LIKE '%" + upper + "%'" + " OR a_name_thai LIKE '%" + str + "%' OR a_index LIKE '%" + str + "%'" + " ORDER BY a_index;");

            }
            else if (language == "ITA")
            {
                listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArrayITA, Host, User, Password, Database, "select a_index, a_name_ita from t_item WHERE a_name_ita LIKE '%" + searchString + "%'" + " OR a_index LIKE '%" + searchString + "%'" + " OR a_name_ita LIKE '%" + lower + "%' OR a_index  LIKE '%" + lower + "%'" + " OR a_name_ita LIKE '%" + upper + "%' OR a_index LIKE '%" + upper + "%'" + " OR a_name_ita LIKE '%" + str + "%' OR a_index LIKE '%" + str + "%'" + " ORDER BY a_index;");

            }
            else if (language == "USA")
            {
                listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArrayUSA, Host, User, Password, Database, "select a_index, a_name_usa from t_item WHERE a_name_usa LIKE '%" + searchString + "%'" + " OR a_index LIKE '%" + searchString + "%'" + " OR a_name_usa LIKE '%" + lower + "%' OR a_index  LIKE '%" + lower + "%'" + " OR a_name_usa LIKE '%" + upper + "%' OR a_index LIKE '%" + upper + "%'" + " OR a_name_usa LIKE '%" + str + "%' OR a_index LIKE '%" + str + "%'" + " ORDER BY a_index;");

            }
            else // if none of these do default search a_name
            {
                listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArray, Host, User, Password, Database, "select a_index, a_name from t_item WHERE a_name LIKE '%" + searchString + "%'" + " OR a_index LIKE '%" + searchString + "%'" + " OR a_name LIKE '%" + lower + "%' OR a_index  LIKE '%" + lower + "%'" + " OR a_name LIKE '%" + upper + "%' OR a_index LIKE '%" + upper + "%'" + " OR a_name LIKE '%" + str + "%' OR a_index LIKE '%" + str + "%'" + " ORDER BY a_index;");

            }
        }

        private void Exporter_Item_Load(object sender, EventArgs e)
        {
            InitializeDevice();
            LoadStartUp();
            LoadLangAtStartup(); //dethunter12 add
            SelectBoxes();
            LoadListBox();
            //  LoadMisc();
        }

        public void SelectBoxes()
        {
            checkBox1.Checked = textBox4.Text == "1";
            int num1 = comboBox1.FindString(textBox2.Text);
            int num2 = comboBox2.FindString(textBox3.Text);
            int num3 = comboBox4.FindString(textBox9.Text);
            //dethunter12 selected id = number
            int num4 = CbSubtype1.FindString(textBox3.Text);
            int num5 = CbSubtype2.FindString(textBox3.Text);
            int num6 = CbSubtype3.FindString(textBox3.Text);
            int num7 = CbSubType4.FindString(textBox3.Text);
            int num8 = CbSubType5.FindString(textBox3.Text);
            int num9 = CbSubType6.FindString(textBox3.Text);
            int num10 = CbSubType7.FindString(textBox3.Text);
            int num11 = comboBox24.FindString(textBox91.Text);
            int num12 = comboBox25.FindString(textBox92.Text);
            int num13 = comboBox26.FindString(textBox92.Text);
            comboBox1.SelectedIndex = num1;
            comboBox2.SelectedIndex = num2;
            comboBox4.SelectedIndex = num3;
            //id ==  num selected index
            CbSubtype1.SelectedIndex = num4;
            CbSubtype2.SelectedIndex = num5;
            CbSubtype3.SelectedIndex = num6;
            CbSubType4.SelectedIndex = num7;
            CbSubType5.SelectedIndex = num8;
            CbSubType6.SelectedIndex = num9;
            CbSubType7.SelectedIndex = num10;
            comboBox24.SelectedIndex = num11;
            comboBox25.SelectedIndex = num12;
            comboBox26.SelectedIndex = num13;
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

        private void LoadLangAtStartup() //dethunter12 add 
        {
            if (language == "GER")
            {
                fileExportToolStripMenuItem.Text = "Datei Export"; // File Export
                v.Text = "Masse aktualisieren"; //Mysql-Mass Update
                massUpdateSealsToolStripMenuItem.Text = "Masse aktualisieren Dichtungen";// Mysql-Mass Update Seals
                groupBox5.Text = "Suche"; //search
                groupBox3.Text = "Artikel"; //items
                groupBox1.Text = "Basic"; //basic
                groupBox6.Text = "Min- und Max-Level"; //min and max level
                groupBox16.Text = "RvR"; //RvR
                groupBox9.Text = "Symbol"; //icon
                groupBox11.Text = "häufige seltene Möglichkeit"; //common rareoption
                groupBox2.Text = "Charakter"; //Character
                groupBox14.Text = "Artikel Spezialeffekte"; //Item Special Effects
                groupBox15.Text = "Stapel und Preis"; //Stack and Prize
                groupBox4.Text = "Optionen"; //Options
                groupBox19.Text = "Reformvariante"; // Reform variation
                groupBox21.Text = "Klasse"; //Class
                groupBox10.Text = "Einstellungen"; //Random Settings
                groupBox22.Text = "Sonstiges"; //Misc
                groupBox23.Text = "Quest Auslöser Info";// Quest Trigger Info
                //groupBox20.Text = "3D-Ansicht"; //3d View
                //SecondPage Crafting
                groupBox8.Text = "Basteln Fertigkeit Anforderung"; //Crafting Skill Requirement
                groupBox7.Text = "Artikel Basteln"; //Item Crafting
                //Rare&Purple&Fortune
                groupBox13.Text = "Selten Optionen"; //Rare Options
                groupBox17.Text = "Lila Artikel "; //Purple Items
                lblLang.Text = "German";
            }
            else if (language == "FRA")
            {
                v.Text = "mise à jour massive"; //Mysql-Mass Update
                fileExportToolStripMenuItem.Text = "Exportation de fichier"; // File Export
                massUpdateSealsToolStripMenuItem.Text = "joints de mise à jour massifs";// Mysql-Mass Update Seals
                groupBox5.Text = "chercher"; //search
                groupBox3.Text = "articles"; //items
                groupBox1.Text = "de base"; //basic
                groupBox6.Text = "Min et Max"; //min and max level
                groupBox16.Text = "RvR"; //RvR
                groupBox9.Text = "Icône"; //icon
                groupBox11.Text = "option rare commune"; //common rareoption
                groupBox2.Text = "personnage"; //Character
                groupBox14.Text = "Effets spéciaux d'article"; //Item Special Effects
                groupBox15.Text = "Pile et prix"; //Stack and Prize
                groupBox4.Text = "Options"; //Options
                groupBox19.Text = "variation de la réforme"; // Reform variation
                groupBox21.Text = "Classe"; //Class
                groupBox10.Text = "Paramètres aléatoires"; //Random Settings
                groupBox22.Text = "Divers"; //Misc
                groupBox23.Text = "quête déclencheur Info";// Quest Trigger Info
                //groupBox20.Text = "Vue 3D"; //3d View
                //SecondPage Crafting
                groupBox8.Text = "Compétence d'artisanat"; //Crafting Skill Requirement
                groupBox7.Text = "Artisanat d'article"; //Item Crafting
                //Rare&Purple&Fortune
                groupBox13.Text = "Option rare"; //Rare Options
                groupBox17.Text = "Articles violets"; //Purple Items
                lblLang.Text = "French";
            }

            else if (language == "ITA")
            {
                v.Text = "mise à jour massive"; //Mysql-Mass Update
                fileExportToolStripMenuItem.Text = "Exportation de fichier"; // File Export
                massUpdateSealsToolStripMenuItem.Text = "joints de mise à jour massifs";// Mysql-Mass Update Seals
                groupBox5.Text = "chercher"; //search
                groupBox3.Text = "articles"; //items
                groupBox1.Text = "de base"; //basic
                groupBox6.Text = "Min et Max"; //min and max level
                groupBox16.Text = "RvR"; //RvR
                groupBox9.Text = "Icône"; //icon
                groupBox11.Text = "option rare commune"; //common rareoption
                groupBox2.Text = "personnage"; //Character
                groupBox14.Text = "Effets spéciaux d'article"; //Item Special Effects
                groupBox15.Text = "Pile et prix"; //Stack and Prize
                groupBox4.Text = "Options"; //Options
                groupBox19.Text = "variation de la réforme"; // Reform variation
                groupBox21.Text = "Classe"; //Class
                groupBox10.Text = "Paramètres aléatoires"; //Random Settings
                groupBox22.Text = "Divers"; //Misc
                groupBox23.Text = "quête déclencheur Info";// Quest Trigger Info
                //groupBox20.Text = "Vue 3D"; //3d View
                //SecondPage Crafting
                groupBox8.Text = "Compétence d'artisanat"; //Crafting Skill Requirement
                groupBox7.Text = "Artisanat d'article"; //Item Crafting
                //Rare&Purple&Fortune
                groupBox13.Text = "Option rare"; //Rare Options
                groupBox17.Text = "Articles violets"; //Purple Items
                lblLang.Text = "Italian";
            }

            else if (language == "RUS")
            {
                v.Text = "mise à jour massive"; //Mysql-Mass Update
                fileExportToolStripMenuItem.Text = "Exportation de fichier"; // File Export
                massUpdateSealsToolStripMenuItem.Text = "joints de mise à jour massifs";// Mysql-Mass Update Seals
                groupBox5.Text = "chercher"; //search
                groupBox3.Text = "articles"; //items
                groupBox1.Text = "de base"; //basic
                groupBox6.Text = "Min et Max"; //min and max level
                groupBox16.Text = "RvR"; //RvR
                groupBox9.Text = "Icône"; //icon
                groupBox11.Text = "option rare commune"; //common rareoption
                groupBox2.Text = "personnage"; //Character
                groupBox14.Text = "Effets spéciaux d'article"; //Item Special Effects
                groupBox15.Text = "Pile et prix"; //Stack and Prize
                groupBox4.Text = "Options"; //Options
                groupBox19.Text = "variation de la réforme"; // Reform variation
                groupBox21.Text = "Classe"; //Class
                groupBox10.Text = "Paramètres aléatoires"; //Random Settings
                groupBox22.Text = "Divers"; //Misc
                groupBox23.Text = "quête déclencheur Info";// Quest Trigger Info
                //groupBox20.Text = "Vue 3D"; //3d View
                //SecondPage Crafting
                groupBox8.Text = "Compétence d'artisanat"; //Crafting Skill Requirement
                groupBox7.Text = "Artisanat d'article"; //Item Crafting
                //Rare&Purple&Fortune
                groupBox13.Text = "Option rare"; //Rare Options
                groupBox17.Text = "Articles violets"; //Purple Items
                lblLang.Text = "Russian";
            }

            else if (language == "THA")
            {
                v.Text = "mise à jour massive"; //Mysql-Mass Update
                fileExportToolStripMenuItem.Text = "Exportation de fichier"; // File Export
                massUpdateSealsToolStripMenuItem.Text = "joints de mise à jour massifs";// Mysql-Mass Update Seals
                groupBox5.Text = "chercher"; //search
                groupBox3.Text = "articles"; //items
                groupBox1.Text = "de base"; //basic
                groupBox6.Text = "Min et Max"; //min and max level
                groupBox16.Text = "RvR"; //RvR
                groupBox9.Text = "Icône"; //icon
                groupBox11.Text = "option rare commune"; //common rareoption
                groupBox2.Text = "personnage"; //Character
                groupBox14.Text = "Effets spéciaux d'article"; //Item Special Effects
                groupBox15.Text = "Pile et prix"; //Stack and Prize
                groupBox4.Text = "Options"; //Options
                groupBox19.Text = "variation de la réforme"; // Reform variation
                groupBox21.Text = "Classe"; //Class
                groupBox10.Text = "Paramètres aléatoires"; //Random Settings
                groupBox22.Text = "Divers"; //Misc
                groupBox23.Text = "quête déclencheur Info";// Quest Trigger Info
                //groupBox20.Text = "Vue 3D"; //3d View
                //SecondPage Crafting
                groupBox8.Text = "Compétence d'artisanat"; //Crafting Skill Requirement
                groupBox7.Text = "Artisanat d'article"; //Item Crafting
                //Rare&Purple&Fortune
                groupBox13.Text = "Option rare"; //Rare Options
                groupBox17.Text = "Articles violets"; //Purple Items
                lblLang.Text = "Thai";
            }

            else if (language == "POL")
            {
                v.Text = "mise à jour massive"; //Mysql-Mass Update
                fileExportToolStripMenuItem.Text = "Exportation de fichier"; // File Export
                massUpdateSealsToolStripMenuItem.Text = "joints de mise à jour massifs";// Mysql-Mass Update Seals
                groupBox5.Text = "chercher"; //search
                groupBox3.Text = "articles"; //items
                groupBox1.Text = "de base"; //basic
                groupBox6.Text = "Min et Max"; //min and max level
                groupBox16.Text = "RvR"; //RvR
                groupBox9.Text = "Icône"; //icon
                groupBox11.Text = "option rare commune"; //common rareoption
                groupBox2.Text = "personnage"; //Character
                groupBox14.Text = "Effets spéciaux d'article"; //Item Special Effects
                groupBox15.Text = "Pile et prix"; //Stack and Prize
                groupBox4.Text = "Options"; //Options
                groupBox19.Text = "variation de la réforme"; // Reform variation
                groupBox21.Text = "Classe"; //Class
                groupBox10.Text = "Paramètres aléatoires"; //Random Settings
                groupBox22.Text = "Divers"; //Misc
                groupBox23.Text = "quête déclencheur Info";// Quest Trigger Info
                //groupBox20.Text = "Vue 3D"; //3d View
                //SecondPage Crafting
                groupBox8.Text = "Compétence d'artisanat"; //Crafting Skill Requirement
                groupBox7.Text = "Artisanat d'article"; //Item Crafting
                //Rare&Purple&Fortune
                groupBox13.Text = "Option rare"; //Rare Options
                groupBox17.Text = "Articles violets"; //Purple Items
                lblLang.Text = "Polish";
            }

            else if (language == "ESP")
            {
                v.Text = "mise à jour massive"; //Mysql-Mass Update
                fileExportToolStripMenuItem.Text = "Exportation de fichier"; // File Export
                massUpdateSealsToolStripMenuItem.Text = "joints de mise à jour massifs";// Mysql-Mass Update Seals
                groupBox5.Text = "chercher"; //search
                groupBox3.Text = "articles"; //items
                groupBox1.Text = "de base"; //basic
                groupBox6.Text = "Min et Max"; //min and max level
                groupBox16.Text = "RvR"; //RvR
                groupBox9.Text = "Icône"; //icon
                groupBox11.Text = "option rare commune"; //common rareoption
                groupBox2.Text = "personnage"; //Character
                groupBox14.Text = "Effets spéciaux d'article"; //Item Special Effects
                groupBox15.Text = "Pile et prix"; //Stack and Prize
                groupBox4.Text = "Options"; //Options
                groupBox19.Text = "variation de la réforme"; // Reform variation
                groupBox21.Text = "Classe"; //Class
                groupBox10.Text = "Paramètres aléatoires"; //Random Settings
                groupBox22.Text = "Divers"; //Misc
                groupBox23.Text = "quête déclencheur Info";// Quest Trigger Info
                //groupBox20.Text = "Vue 3D"; //3d View
                //SecondPage Crafting
                groupBox8.Text = "Compétence d'artisanat"; //Crafting Skill Requirement
                groupBox7.Text = "Artisanat d'article"; //Item Crafting
                //Rare&Purple&Fortune
                groupBox13.Text = "Option rare"; //Rare Options
                groupBox17.Text = "Articles violets"; //Purple Items
                lblLang.Text = "Spanish";
            }

            else if (language == "BRA")
            {
                v.Text = "mise à jour massive"; //Mysql-Mass Update
                fileExportToolStripMenuItem.Text = "Exportation de fichier"; // File Export
                massUpdateSealsToolStripMenuItem.Text = "joints de mise à jour massifs";// Mysql-Mass Update Seals
                groupBox5.Text = "chercher"; //search
                groupBox3.Text = "articles"; //items
                groupBox1.Text = "de base"; //basic
                groupBox6.Text = "Min et Max"; //min and max level
                groupBox16.Text = "RvR"; //RvR
                groupBox9.Text = "Icône"; //icon
                groupBox11.Text = "option rare commune"; //common rareoption
                groupBox2.Text = "personnage"; //Character
                groupBox14.Text = "Effets spéciaux d'article"; //Item Special Effects
                groupBox15.Text = "Pile et prix"; //Stack and Prize
                groupBox4.Text = "Options"; //Options
                groupBox19.Text = "variation de la réforme"; // Reform variation
                groupBox21.Text = "Classe"; //Class
                groupBox10.Text = "Paramètres aléatoires"; //Random Settings
                groupBox22.Text = "Divers"; //Misc
                groupBox23.Text = "quête déclencheur Info";// Quest Trigger Info
                //groupBox20.Text = "Vue 3D"; //3d View
                //SecondPage Crafting
                groupBox8.Text = "Compétence d'artisanat"; //Crafting Skill Requirement
                groupBox7.Text = "Artisanat d'article"; //Item Crafting
                //Rare&Purple&Fortune
                groupBox13.Text = "Option rare"; //Rare Options
                groupBox17.Text = "Articles violets"; //Purple Items
                lblLang.Text = "Brasilian";
            }
            else if (language == "MEX")
            {
                lblLang.Text = "Mex";
            }

            else if (language == "USA")
            {
                lblLang.Text = "English";
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ComboBoxPurpleLocked = true;
            if (listBox1.SelectedIndex != -1)
                comboBox1.BackColor = Color.White; //dethunter12 add/ Resets the  color upon click on another index.
            comboBox2.BackColor = Color.White; //dethunter12 add
            comboBox4.BackColor = Color.White; //dethunter12 add
            CbSubtype1.BackColor = Color.White; //dethunter12 add
            CbSubtype2.BackColor = Color.White; //dethunter12 add
            CbSubtype3.BackColor = Color.White; //dethunter12 add
            CbSubType4.BackColor = Color.White; //dethunter12 add
            CbSubType5.BackColor = Color.White; //dethunter12 add
            CbSubType6.BackColor = Color.White; //dethunter12 add
            CbSubType7.BackColor = Color.White; //dethunter12 add
            textBox1.Text = GetIndex().ToString();
            ClearComboBoxPurple();
            ResetTextBoxBackground();
            ResetComboBoxPurpleBg();
            ClearComboBoxPurple2();
            string Query = " select a_index , a_type_idx , a_subtype_idx , a_enable , a_name , a_descr , a_job_flag , a_flag , a_wearing , a_num_0 , a_num_1 , a_num_2, a_num_3 , a_num_4 , a_level , a_level2 , a_weight , a_price , a_max_use , a_drop_prob_10 , a_need_item0 , a_need_item1 , a_need_item2 , a_need_item3 , a_need_item4 , a_need_item5 , a_need_item6 , a_need_item7 , a_need_item8 , a_need_item9 , a_need_item_count0 , a_need_item_count1 , a_need_item_count2 , a_need_item_count3 , a_need_item_count4 , a_need_item_count5 , a_need_item_count6 , a_need_item_count7 , a_need_item_count8 , a_need_item_count9 , a_need_sskill , a_need_sskill_level , a_need_sskill2 , a_need_sskill_level2 , a_zone_flag , a_file_smc , a_texture_id , a_texture_row , a_texture_col , b_todo_delete , a_set_0 , a_set_1 , a_set_2 , a_set_3 , a_set_4 , a_set , a_grade , a_fame , a_rare_index_0 , a_rare_index_1 , a_rare_index_2 , a_rare_index_3 , a_rare_index_4 , a_rare_index_5 , a_rare_index_6 , a_rare_index_7 , a_rare_index_8 , a_rare_index_9 , a_rare_prob_0 , a_rare_prob_1 , a_rare_prob_2 , a_rare_prob_3 , a_rare_prob_4 , a_rare_prob_5 , a_rare_prob_6 , a_rare_prob_7 , a_rare_prob_8 , a_rare_prob_9 , a_effect_name, a_attack_effect_name, a_damage_effect_name, a_quest_trigger_count , a_quest_trigger_ids , a_origin_variation1 , a_origin_variation2 , a_origin_variation3 , a_origin_variation4 , a_origin_variation5 , a_origin_variation6 , a_rvr_value , a_rvr_grade , a_durability , a_castle_war, a_name_frc, a_name_ita, a_name_usa, a_name_rus,  a_name_thai, a_name_pld, a_name_spn, a_name_brz, a_name_ger, a_descr_frc, a_descr_ita, a_descr_usa, a_descr_rus, a_descr_thai, a_descr_pld, a_descr_spn, a_descr_brz, a_descr_ger, a_name_mex, a_descr_mex from t_item WHERE a_index ='" + textBox1.Text + "';"; //dethunter12 4/11/2018 lang edit
            string[] rows = new string[113]
            {
        "a_index",//0
        "a_type_idx", //1
        "a_subtype_idx", //2
        "a_enable", //3
        "a_name", //4
        "a_descr", //5
        "a_job_flag", //6
        "a_flag", //7
        "a_wearing", //8
        "a_num_0", //9
        "a_num_1", //10
        "a_num_2",//11
        "a_num_3",//12
        "a_num_4",//13
        "a_level",//14
        "a_level2",//15
        "a_weight",//16
        "a_price",//17
        "a_max_use",//18
        "a_drop_prob_10",//19
        "a_need_item0",//20
        "a_need_item1",//21
        "a_need_item2",//22
        "a_need_item3",//23
        "a_need_item4",//24
        "a_need_item5",//25
        "a_need_item6",//26
        "a_need_item7",//27
        "a_need_item8",//28
        "a_need_item9",//29
        "a_need_item_count0",//30
        "a_need_item_count1",//31
        "a_need_item_count2",//32
        "a_need_item_count3",//33
        "a_need_item_count4",//34
        "a_need_item_count5",//35
        "a_need_item_count6",//36
        "a_need_item_count7",//37
        "a_need_item_count8",//38
        "a_need_item_count9",//39
        "a_need_sskill",//40
        "a_need_sskill_level",//41
        "a_need_sskill2",//42
        "a_need_sskill_level2",//43
        "a_zone_flag",//44
        "a_file_smc",//45
        "a_texture_id",//46
        "a_texture_row",//47
        "a_texture_col",//48
        "b_todo_delete",//49
        "a_set_0",//50
        "a_set_1",//51
        "a_set_2",//52
        "a_set_3",//53
        "a_set_4",//54
        "a_set",//55
        "a_grade",//56
        "a_fame",//57
        "a_rare_index_0",//58
        "a_rare_index_1",//59
        "a_rare_index_2",//60
        "a_rare_index_3",//61
        "a_rare_index_4",//62
        "a_rare_index_5",//63
        "a_rare_index_6",//64
        "a_rare_index_7",//65
        "a_rare_index_8",//66
        "a_rare_index_9",//67
        "a_rare_prob_0",//68
        "a_rare_prob_1",//69
        "a_rare_prob_2",//70
        "a_rare_prob_3",//71
        "a_rare_prob_4",//72
        "a_rare_prob_5",//73
        "a_rare_prob_6",//74
        "a_rare_prob_7",//75
        "a_rare_prob_8",//76
        "a_rare_prob_9",//77
        "a_effect_name",
        "a_attack_effect_name",
        "a_damage_effect_name",
        "a_quest_trigger_count",
        "a_quest_trigger_ids",
        "a_origin_variation1",
        "a_origin_variation2",
        "a_origin_variation3",
        "a_origin_variation4",
        "a_origin_variation5",
        "a_origin_variation6",
        "a_rvr_value",
        "a_rvr_grade",
        "a_durability",
        "a_castle_war", //92
        //select language name-desc
        "a_name_frc",//93
        "a_name_ita",//94
        "a_name_usa",//95
        "a_name_rus",//96
        "a_name_thai",//97
        "a_name_pld",//98
        "a_name_spn",//99
        "a_name_brz",//100
        "a_name_ger",//101
        //desc 9-17 total count = 9
        "a_descr_frc",//102
        "a_descr_ita",//103
        "a_descr_usa",//104
        "a_descr_rus",//105
        "a_descr_thai",//106
        "a_descr_pld",//107
        "a_descr_spn",//108
        "a_descr_brz",//109
        "a_descr_ger",//110
        "a_name_mex", //111
        "a_descr_mex" //112
      };
           
            Query.Replace("'", "\\'").Replace("\\", "\\\\").Replace("'", "\\'");
            string[] strArray = databaseHandle.SelectMySqlReturnArray(Host, User, Password, Database, Query, rows);
           /* if ( File.Exists(_ClientPath + strArray[45])) //chk3D removed
            {
                Console.WriteLine("Create Model > " + _ClientPath + strArray[45]);
                MakeLCModels(_ClientPath + strArray[45]);
            }*/
            textBox1.Text = strArray[0];
            textBox2.Text = strArray[1];
            textBox3.Text = strArray[2];
            textBox4.Text = strArray[3];
            textBox5.Text = strArray[4];
            //dethunter12 4/11/2018 language add
            if (language == "FRA")
            {
                textBox5.Text = strArray[93]; //name
                textBox6.Text = strArray[102]; //descr 
            }
            else if (language == "USA")
            {
                textBox5.Text = strArray[95];
                textBox6.Text = strArray[104];
            }
            else if (language == "ITA")
            {
                textBox5.Text = strArray[94];
                textBox6.Text = strArray[103];
            }
            else if (language == "RUS")
            {
                textBox5.Text = strArray[96];
                textBox6.Text = strArray[105];
            }
            else if (language == "THA")
            {
                textBox5.Text = strArray[97];
                textBox6.Text = strArray[106];
            }
            else if (language == "POL")
            {
                textBox5.Text = strArray[98];
                textBox6.Text = strArray[107];
            }
            else if (language == "ESP")
            {
                textBox5.Text = strArray[99];
                textBox6.Text = strArray[108];
            }
            else if (language == "BRA")
            {
                textBox5.Text = strArray[100];
                textBox6.Text = strArray[109];
            }
            else if (language == "GER")
            {
                textBox5.Text = strArray[101];
                textBox6.Text = strArray[110];
            }
            else if (language == "MEX")
            {
                textBox5.Text = strArray[111];
                textBox6.Text = strArray[112];
            }
            else if (language != "GER" && language != "POL" && language != "BRA" && language != "RUS" && language != "FRA" && language != "ESP" && language != "MEX" && language != "THA" && language != "ITA" && language != "USA") //if language isnt any of the supported language lists then use default a_name 
            {
                textBox5.Text = strArray[4];//name
                textBox6.Text = strArray[5];//desc
            }
          //  textBox6.Text = strArray[5];
            textBox7.Text = strArray[6];
            textBox8.Text = strArray[7];
            textBox9.Text = strArray[8];
            textBox10.Text = strArray[9];
            textBox11.Text = strArray[10];
            textBox13.Text = strArray[11];
            textBox14.Text = strArray[12];
            textBox15.Text = strArray[13];
            textBox16.Text = strArray[14];
            textBox17.Text = strArray[15];
            textBox18.Text = strArray[16];
            textBox19.Text = strArray[17];
            textBox20.Text = strArray[18];
            textBox21.Text = strArray[19];
            textBox22.Text = strArray[20];
            textBox23.Text = strArray[21];
            textBox24.Text = strArray[22];
            textBox25.Text = strArray[23];
            textBox26.Text = strArray[24];
            textBox27.Text = strArray[25];
            textBox28.Text = strArray[26];
            textBox29.Text = strArray[27];
            textBox30.Text = strArray[28];
            textBox31.Text = strArray[29];
            textBox32.Text = strArray[30];
            textBox33.Text = strArray[31];
            textBox34.Text = strArray[32];
            textBox35.Text = strArray[33];
            textBox36.Text = strArray[34];
            textBox37.Text = strArray[35];
            textBox38.Text = strArray[36];
            textBox39.Text = strArray[37];
            textBox40.Text = strArray[38];
            textBox41.Text = strArray[39];
            textBox42.Text = strArray[40];
            textBox43.Text = strArray[41];
            textBox44.Text = strArray[42];
            textBox45.Text = strArray[43];
            textBox46.Text = strArray[44];
            textBox47.Text = strArray[45];
            textBox48.Text = strArray[46];
            textBox49.Text = strArray[47];
            textBox50.Text = strArray[48];
            textBox51.Text = strArray[49];
            textBox52.Text = strArray[50];
            textBox53.Text = strArray[51];
            textBox54.Text = strArray[52];
            textBox55.Text = strArray[53];
            textBox56.Text = strArray[54];
            textBox57.Text = strArray[55];
            textBox58.Text = strArray[56];
            textBox59.Text = strArray[57];
            textBox60.Text = strArray[58];
            textBox61.Text = strArray[59];
            textBox62.Text = strArray[60];
            textBox63.Text = strArray[61];
            textBox64.Text = strArray[62];
            textBox65.Text = strArray[63];
            textBox66.Text = strArray[64];
            textBox67.Text = strArray[65];
            textBox68.Text = strArray[66];
            textBox69.Text = strArray[67];
            textBox70.Text = strArray[68];
            textBox71.Text = strArray[69];
            textBox72.Text = strArray[70];
            textBox73.Text = strArray[71];
            textBox74.Text = strArray[72];
            textBox75.Text = strArray[73];
            textBox76.Text = strArray[74];
            textBox77.Text = strArray[75];
            textBox78.Text = strArray[76];
            textBox79.Text = strArray[77];
            textBox80.Text = strArray[78];
            textBox81.Text = strArray[79];
            textBox82.Text = strArray[80];
            textBox83.Text = strArray[81];
            textBox84.Text = strArray[82];
            textBox85.Text = strArray[83];
            textBox86.Text = strArray[84];
            textBox87.Text = strArray[85];
            textBox88.Text = strArray[86];
            textBox89.Text = strArray[87];
            textBox90.Text = strArray[88];
            textBox91.Text = strArray[89];
            textBox92.Text = strArray[90];
            textBox93.Text = strArray[91];
            textBox94.Text = strArray[92];
            SelectBoxes();
            int int32 = Convert.ToInt32(strArray[6]);
            if (Episode == "EP4")
                ShowFlagLong1(Convert.ToInt64(strArray[7])); //dethunter12 add
            else
                ShowFlag(Convert.ToInt32(strArray[7]));
            ShowJobFlag(int32);
            // LoadMisc();
            try
            {
                pictureBox1.Image = (Image)databaseHandle.IconItem(int.Parse(textBox48.Text), int.Parse(textBox49.Text), int.Parse(textBox50.Text));
            }
            catch
            {
            }
            long int64 = Convert.ToInt64(strArray[7]);
            if (FlagCheck(int64, 19) && !FlagCheck(int64, 26))
            {
                comboBox5.SelectedIndex = int.Parse(textBox61.Text);
                comboBox6.SelectedIndex = int.Parse(textBox62.Text);
                comboBox7.SelectedIndex = int.Parse(textBox63.Text);
                comboBox8.SelectedIndex = int.Parse(textBox64.Text);
                comboBox9.SelectedIndex = int.Parse(textBox65.Text);
                comboBox10.SelectedIndex = int.Parse(textBox66.Text);
                SetSelectedComboBoxPurple2();
            }
            _ComboBoxPurpleLocked = false;
        }

        public bool FlagCheck(long Flag, int CheckFlag)
        {
            return (Flag & (long)(1 << CheckFlag)) > 0L;
        }

        /*private void SelectBoxes()
        {
                comboBox2.SelectedIndex = comboBox2.FindString(textBox3.Text);
        }*/

        private void button2_Click(object sender, EventArgs e)
        {
            descrr = DescrFromLanguage(); // description 
            namee = StringFromLanguage(); // language name (to simplify the query without having to add alot of if elseif)
            string str1 = "UPDATE t_item SET " + "a_type_idx = '" + textBox2.Text + "', " + "a_subtype_idx = '" + textBox3.Text + "', " + "a_enable = '" + textBox4.Text + "', ";
            string str2 = textBox5.Text.Replace("'", "\\'").Replace("\"", "\\\"");
            string str3 = textBox6.Text.Replace("'", "\\'").Replace("\"", "\\\"");
            //
            databaseHandle.SendQueryMySql(Host, User, Password, Database, str1 + "a_name = '" + str2 + "', " + namee + "=" +  " " + "'" + str2 + "', " + "a_descr = '" + str3 + "', " + descrr + "='" + str3 + "', " + "a_job_flag = '" + textBox7.Text + "', " + "a_flag = '" + textBox8.Text + "', " + "a_wearing = '" + textBox9.Text + "', " + "a_num_0 = '" + textBox10.Text + "', " + "a_num_1 = '" + textBox11.Text + "', " + "a_num_2 = '" + textBox13.Text + "', " + "a_num_3 = '" + textBox14.Text + "', " + "a_num_4 = '" + textBox15.Text + "', " + "a_level = '" + textBox16.Text + "', " + "a_level2 = '" + textBox17.Text + "', " + "a_weight = '" + textBox18.Text + "', " + "a_price = '" + textBox19.Text + "', " + "a_max_use = '" + textBox20.Text + "', " + "a_drop_prob_10 = '" + textBox21.Text + "', " + "a_need_item0 = '" + textBox22.Text + "', " + "a_need_item1 = '" + textBox23.Text + "', " + "a_need_item2 = '" + textBox24.Text + "', " + "a_need_item3 = '" + textBox25.Text + "', " + "a_need_item4 = '" + textBox26.Text + "', " + "a_need_item5 = '" + textBox27.Text + "', " + "a_need_item6 = '" + textBox28.Text + "', " + "a_need_item7 = '" + textBox29.Text + "', " + "a_need_item8 = '" + textBox30.Text + "', " + "a_need_item9 = '" + textBox31.Text + "', " + "a_need_item_count0 = '" + textBox32.Text + "', " + "a_need_item_count1 = '" + textBox33.Text + "', " + "a_need_item_count2 = '" + textBox34.Text + "', " + "a_need_item_count3 = '" + textBox35.Text + "', " + "a_need_item_count4 = '" + textBox36.Text + "', " + "a_need_item_count5 = '" + textBox37.Text + "', " + "a_need_item_count6 = '" + textBox38.Text + "', " + "a_need_item_count7 = '" + textBox39.Text + "', " + "a_need_item_count8 = '" + textBox40.Text + "', " + "a_need_item_count9 = '" + textBox41.Text + "', " + "a_need_sskill = '" + textBox42.Text + "', " + "a_need_sskill_level = '" + textBox43.Text + "', " + "a_need_sskill2 = '" + textBox44.Text + "', " + "a_need_sskill_level2 = '" + textBox45.Text + "', " + "a_zone_flag = '" + textBox46.Text + "', " + "a_file_smc = '" + textBox47.Text.Replace("'", "\\'").Replace("\\", "\\\\").Replace("'", "\\'") + "', " + "a_texture_id = '" + textBox48.Text + "', " + "a_texture_row = '" + textBox49.Text + "', " + "a_texture_col = '" + textBox50.Text + "', " + "b_todo_delete = '" + textBox51.Text + "', " + "a_set_0 = '" + textBox52.Text + "', " + "a_set_1 = '" + textBox53.Text + "', " + "a_set_2 = '" + textBox54.Text + "', " + "a_set_3 = '" + textBox55.Text + "', " + "a_set_4 = '" + textBox56.Text + "', " + "a_set = '" + textBox57.Text + "', " + "a_grade = '" + textBox58.Text + "', " + "a_fame = '" + textBox59.Text + "', " + "a_rare_index_0 = '" + textBox60.Text + "', " + "a_rare_index_1 = '" + textBox61.Text + "', " + "a_rare_index_2 = '" + textBox62.Text + "', " + "a_rare_index_3 = '" + textBox63.Text + "', " + "a_rare_index_4 = '" + textBox64.Text + "', " + "a_rare_index_5 = '" + textBox65.Text + "', " + "a_rare_index_6 = '" + textBox66.Text + "', " + "a_rare_index_7 = '" + textBox67.Text + "', " + "a_rare_index_8 = '" + textBox68.Text + "', " + "a_rare_index_9 = '" + textBox69.Text + "', " + "a_rare_prob_0 = '" + textBox70.Text + "', " + "a_rare_prob_1 = '" + textBox71.Text + "', " + "a_rare_prob_2 = '" + textBox72.Text + "', " + "a_rare_prob_3 = '" + textBox73.Text + "', " + "a_rare_prob_4 = '" + textBox74.Text + "', " + "a_rare_prob_5 = '" + textBox75.Text + "', " + "a_rare_prob_6 = '" + textBox76.Text + "', " + "a_rare_prob_7 = '" + textBox77.Text + "', " + "a_rare_prob_8 = '" + textBox78.Text + "', " + "a_rare_prob_9 = '" + textBox79.Text + "', " + "a_effect_name = '" + textBox80.Text + "', " + "a_attack_effect_name = '" + textBox81.Text + "', " + "a_damage_effect_name = '" + textBox82.Text + "', " + "a_quest_trigger_count = '" + textBox83.Text + "', " + "a_quest_trigger_ids = '" + textBox84.Text + "', " + "a_origin_variation1 = '" + textBox85.Text + "', " + "a_origin_variation2 = '" + textBox86.Text + "', " + "a_origin_variation3 = '" + textBox87.Text + "', " + "a_origin_variation4 = '" + textBox88.Text + "', " + "a_origin_variation5 = '" + textBox89.Text + "', " + "a_origin_variation6 = '" + textBox90.Text + "', " + "a_rvr_value = '" + textBox91.Text + "', " + "a_rvr_grade = '" + textBox92.Text + "', " + "a_durability = '" + textBox93.Text + "', " + "a_castle_war = '" + textBox94.Text + "' " + "WHERE a_index = '" + textBox1.Text + "'");
            int selectedIndex = listBox1.SelectedIndex;
            if (textBox12.Text != "")
                SearchList(textBox12.Text);
            else
                LoadListBox();
            listBox1.SelectedIndex = selectedIndex;
            int num4 = (int)new CustomMessage("Done :)").ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            databaseHandle.SendQueryMySql(Host, User, Password, Database, "INSERT INTO t_item DEFAULT VALUES");
            LoadListBox();
            listBox1.SelectedIndex = listBox1.Items.Count - 1;
            textBox4.Text = "1";
            textBox46.Text = "1023";
            checkBox1.Checked = true;
            checkBox1.BackColor = Color.Lime;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBox1.SelectedIndex;
            databaseHandle.SendQueryMySql(Host, User, Password, Database, "DELETE FROM t_item WHERE a_index = '" + textBox1.Text + "'");
            LoadListBox();
            listBox1.SelectedIndex = selectedIndex - 1;
            int num2 = (int)new CustomMessage("Deleted :O").ShowDialog();
        }

        private void exportlodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //exportLodHandle.ExportItemAll_V4();
            string text1 = "item";
            string text2 = "path_ship";
            string text3 = IconList.language.ToLower();
            Process.Start(new ProcessStartInfo()
            {
                FileName = "ExportLod.exe",
                Arguments = " -h " + Host + " -d " + Database + " -u " + User + " -p " + Password + " -k " + text2 + " -l " + text3 + " -t " + text1
            });
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox4.Text = "1";
                checkBox1.BackColor = Color.Lime;
            }
            else
            {
                textBox4.Text = "0";
                checkBox1.BackColor = Color.Red;
            }
        }

        private void LoadStartUp()
        {
            string str1 = "SELECT * FROM t_option ORDER BY a_index";
            MySqlConnection mySqlConnection = new MySqlConnection("datasource=" + Host + ";port=3306;username=" + User + ";password=" + Password + ";database=" + Database);
            MySqlCommand command = mySqlConnection.CreateCommand();
            command.CommandText = str1;
            mySqlConnection.Open();
            MySqlDataReader mySqlDataReader = command.ExecuteReader();
            while (mySqlDataReader.Read())
            {
                int ordinal1 = mySqlDataReader.GetOrdinal("a_index");
                mySqlDataReader.GetString(ordinal1);
                int ordinal2 = mySqlDataReader.GetOrdinal("a_type");
                string str2 = mySqlDataReader.GetString(ordinal2);
                int ordinal3 = mySqlDataReader.GetOrdinal("a_name");
                string str3 = mySqlDataReader.GetString(ordinal3);
                string str4 = str2 + " - " + str3;
                comboBox3.Items.Add(str4);
                comboBox5.Items.Add(str4);
                comboBox6.Items.Add(str4);
                comboBox7.Items.Add(str4);
                comboBox8.Items.Add(str4);
                comboBox9.Items.Add(str4);
                comboBox10.Items.Add(str4);
                comboBox11.Items.Add(str4);
                comboBox12.Items.Add(str4);
                comboBox13.Items.Add(str4);
            }
            mySqlConnection.Close();
            checkedListBox1.Items.AddRange(new object[11]
      {
         "Titan",
         "Knight",
         "Healer",
         "Mage",
         "Rogue",
         "Sorcerer",
         "NS",
         "Ex-Rogue",
         "Ex-Mage",
         "P1 Pet",
         "P2 Pet"
      });
            checkedListBox2.Items.AddRange(new object[9]
      {
         "Titan",
         "Knight",
         "Healer",
         "Mage",
         "Rogue",
         "Sorcerer",
         "NS",
         "Ex-Rogue",
         "Ex-Mage"
      });
            if (Episode == "EP4")
                clbFlagTest.Items.AddRange(new object[64]
        {
           "Count",
           "Drop",
           "Upgrade",
           "Exchange",
           "Trade",
           "Not Delete",
           "Made",
           "Mix",
           "Cash",
           "Lord",
           "No Stash",
           "Change",
           "Composite",
           "Duplication",
           "lent",
           "Rare",
           "ABS",
           "Not Reform",
           "ZoneMove Del",
           "Origin",
           "Trigger",
           "Raid Special",
           "Quest",
           "Box",
           "Not TradeAgent",
           "Durability",
           "Costume2",
           "Socket",
           "Seller",
           "Castillan",
           "LetsParty",
           "Non-RVR",
           "Quest Give",
           "Toggle",
           "Compose",
           "NotSingle",
           "Invisible Custom",
           "37 ",
           "38 ",
           "39 ",
           "40 ",
           "41 ",
           "42 ",
           "43 ",
           "44 ",
           "45 ",
           "46 ",
           "47 ",
           "48 ",
           "49 ",
           "50 ",
           "51 ",
           "52 ",
           "53 ",
           "54 ",
           "55 ",
           "56 ",
           "57 ",
           "58 ",
           "59 ",
           "60 ",
           "61 ",
           "62 ",
           "63 "
        });
            ClbItemFlag.Items.AddRange(new object[64] //dethunter12 test item flag move
        {
           "Count",
           "Drop",
           "Upgrade",
           "Exchange",
           "Trade",
           "Not Delete",
           "Made",
           "Mix",
           "Cash",
           "Lord",
           "No Stash",
           "Change",
           "Composite",
           "Duplication",
           "lent",
           "Rare",
           "ABS",
           "Not Reform",
           "ZoneMove Del",
           "Origin",
           "Trigger",
           "Raid Special",
           "Quest",
           "Box",
           "Not TradeAgent",
           "Durability",
           "Costume2",
           "Socket",
           "Seller",
           "Castillan",
           "LetsParty",
           "Non-RVR",
           "Quest Give",
           "Toggle",
           "Compose",
           "NotSingle",
           "Invisible Custom",
           "37 ",
           "38 ",
           "39 ",
           "40 ",
           "41 ",
           "42 ",
           "43 ",
           "44 ",
           "45 ",
           "46 ",
           "47 ",
           "48 ",
           "49 ",
           "50 ",
           "51 ",
           "52 ",
           "53 ",
           "54 ",
           "55 ",
           "56 ",
           "57 ",
           "58 ",
           "59 ",
           "60 ",
           "61 ",
           "62 ",
           "63 "
        });

            comboBox1.Items.AddRange(new object[8]
      {
         "0 - Weapons",
         "1 - Armor",
         "2 - Books, Scrolls",
         "3 - Shot",
         "4 - Quest, Event, Upgrade",
         "5 - Accesoires, Pets",
         "6 - Potions",
         "Unknown"
      });
            comboBox4.Items.AddRange(new object[13]
      {
         "-1 - None",
         "0 - Hood Slot",
         "1 - Shirt Slot",
         "2 - Weapon Slot",
         "3 - Pants Slot",
         "4 - Shield Slot",
         "5 - Gloves Slot",
         "6 - Boots Slot",
         "7 - Accesoire Slot",
         "8 - Accesoire Slot",
         "9 - Accesoire Slot",
         "10 - Pet Slot",
         "11 - Wing Slot"
      });

            comboBox24.Items.AddRange(new object[3] //dethunter12 add
     {
         "0 - None",
         "1 - KAILUX",
         "2 - DEALERMOON"
     });

            comboBox25.Items.AddRange(new object[9] //dethunter12 add
     {
         "1 - SQUIRE",
         "2 - KNIGHT",
         "3 - GENTOR",
         "4 - HONORISE",
         "5 - BARONE",
         "6 - VISCONTE",
         "7 - CONTE",
         "8 - BARONE",
         "9 - MARQUISE"
     });

            comboBox26.Items.AddRange(new object[5] //dethunter12 add
     {
         "1 - NEOPTYE",
         "2 - ZELATOR",
         "3 - THEORICUS",
         "4 - PHILOSOPHUS",
         "5 - ADEPTUS"
     });

            comboBox2.Items.AddRange(new object[16] //dethunter12 add
      {
         "0 - Single Sword",
         "1 - X-Bow",
         "2 - Staff",
         "3 - Big Sword",
         "4 - Axe",
         "5 - Wand",
         "6 - Bow",
         "7 - Dagger",
         "8 - Hammer",
         "9 - Knife",
         "10 - Energy Collector",
         "11 - Dual Swords",
         "12 - Scepter",
         "13 - Scythe",
         "14 - Fallarm",
         "15 - NS Weapon"
      });
            CbSubtype1.Items.AddRange(new object[8] //dethunter12 add
 {
         "0 - Helm",
         "1 - Shirt",
         "2 - Pants",
         "3 - Gloves",
         "4 - Boots",
         "5 - Shield",
         "6 - Wing",
         "7 - Complete Costume"
 });
            CbSubtype2.Items.AddRange(new object[35] //dethunter12 add
 {
         "0 - Teleporting",
         "1 - Production Manual",
         "2 - Crafting Manual",
         "3 - Box",
         "4 - Potion Manual",
         "5 - Transformation Scrolls",
         "6 - Quest Scrolls",
         "7 - Changing Stuff",
         "8 - Mob Summoning",
         "9 - Boxes and Monstercombo",
         "10 - Attack Scrolls",
         "11 - Titles",
         "12 - Reward Package",
         "13 - Jumping Potion",
         "14 - Extend Character Slot",
         "15 - Server Trans",
         "16 - Remote Express",
         "17 - Jewel Pocket",
         "18 - Chaos Jewel Pocket",
         "19 - Cash Inventory",
         "20 - Pet Stash",
         "21 - GPS",
         "22 - Holy Water",
         "23 - Protect PVP",
         "24 - CASH_TICKET",
         "25 - statpt_remain_200",
         "26 - statpt_remain_500",
         "27 - CASH_COLOR",
         "28 - CASH_COLOR1",
         "29 - CASH_COLOR2",
         "30 - CASH_COLOR3",
         "31 - CASH_COLOR4",
         "32 - CASH_COLOR5",
         "33 - CASH_COLOR6",
         "34 - CASH_COLOR7"
 });
            CbSubtype3.Items.AddRange(new object[3] //dethunter12 add
 {
         "0 - Item Bullet Attack",
         "1 - Item Bullet Mana",
         "2 - Item Bullet Arrow",
 });
            CbSubType4.Items.AddRange(new object[25] //dethunter12 add
{
         "0 - Quest Items",
         "1 - Event",
         "2 - SkillUp",
         "3 - Upgrade Stuff",
         "4 - Materials & Skillbooks",
         "5 - Gold",
         "6 - Materials 1",
         "7 - Materials 2",
         "8 - Bloodseal Items",
         "9 - Powder",
         "10 - Event Items 1",
         "11 - Castle Siege Concentration",
         "12 - Castle Siege Powder",
         "13 - Castle Siege Stone",
         "14 - [P2] Target",
         "15 - Quest Trigger",
         "16 - Socket Jewel",
         "17 - Socket Upgrading",
         "18 - Socket Creation",
         "19 - Monster Mercenary",
         "20 - Guild Mark",
         "21 - Reformer",
         "22 - Chaos jewel",
         "23 - Function",
         "24 - RvR Jewel"
});
            CbSubType5.Items.AddRange(new object[9] //dethunter12 add
{
         "0 - Accesoires Charm",
         "1 - Accesoires Magic Stone",
         "2 - Accesoires Light Stone",
         "3 - Accesoires Earing",
         "4 - Accesoires Ring",
         "5 - Accesoires Necklace",
         "6 - P1 Pet",
         "7 - P2 Pet",
         "8 - Artifact"
});
            CbSubType6.Items.AddRange(new object[14] //dethunter12 add
{
         "0 - Antidotes / Cures",
         "1 - HP Heal Potions",
         "2 - MP Heal Potions",
         "3 - HP+MP Heal Potions",
         "4 - HP, MP, Attack Boost",
         "5 - Steroids",
         "6 - Minerals",
         "7 - Tears",
         "8 - Exp Crystals",
         "9 - NPC Scroll",
         "10 - HP Recovery Speed Potions",
         "11 - MP Recovery Speed Potions",
         "12 - [P2] Heal Items",
         "13 - [P2] SpeedUp"
});
            CbSubType7.Items.AddRange(new object[1] //dethunter12 add
{
         "-1 - Unkown"
});
        }

        public static string[] SubTypes(int Type)
        {
            System.Collections.Generic.List<string> stringList = new System.Collections.Generic.List<string>();
            switch (Type)
            {
                case 0:
                    stringList.Add("0 - Single Sword");
                    stringList.Add("1 - X-Bow");
                    stringList.Add("2 - Staff");
                    stringList.Add("3 - Big Sword");
                    stringList.Add("4 - Axe");
                    stringList.Add("5 - Wand");
                    stringList.Add("6 - Bow");
                    stringList.Add("7 - Dagger");
                    stringList.Add("8 - Hammer");
                    stringList.Add("9 - Knife");
                    stringList.Add("10 - Energy Collector");
                    stringList.Add("11 - Dual Swords");
                    stringList.Add("12 - Scepter");
                    stringList.Add("13 - Scythe");
                    stringList.Add("14 - Fallarm");
                    stringList.Add("15 - NS Weapon");
                    break;
                case 1:
                    stringList.Add("0 - Helm");
                    stringList.Add("1 - Shirt");
                    stringList.Add("2 - Pants");
                    stringList.Add("3 - Gloves");
                    stringList.Add("4 - Boots");
                    stringList.Add("5 - Shield");
                    stringList.Add("6 - Wing");
                    stringList.Add("7 - Complete Costume");
                    break;
                case 2:
                    stringList.Add("0 - Teleporting");
                    stringList.Add("1 - Production Manual");
                    stringList.Add("2 - Crafting Manual");
                    stringList.Add("3 - Box");
                    stringList.Add("4 - Potion Manual");
                    stringList.Add("5 - Transformation Scrolls");
                    stringList.Add("6 - Quest Scrolls");
                    stringList.Add("7 - Changing Stuff");
                    stringList.Add("8 - Mob Summoning");
                    stringList.Add("9 - Boxes and Monstercombo");
                    stringList.Add("10 - Attack Scrolls");
                    stringList.Add("11 - Titles");
                    stringList.Add("12 - Reward Package");
                    stringList.Add("13 - Jumping Potion");
                    stringList.Add("14 - Extend Character Slot");
                    stringList.Add("15 - Server Trans");
                    stringList.Add("16 - Remote Express");
                    stringList.Add("17 - Jewel Pocket");
                    stringList.Add("18 - Chaos Jewel Pocket");
                    stringList.Add("19 - Cash Inventory");
                    stringList.Add("20 - Pet Stash");
                    stringList.Add("21 - GPS");
                    stringList.Add("22 - Holy Water");
                    stringList.Add("23 - Protect PVP");
                    break;
                case 3:
                    stringList.Add("0 - Item Bullet Attack");
                    stringList.Add("1 - Item Bullet Mana");
                    stringList.Add("2 - Item Bullet Arrow");
                    break;
                case 4:
                    stringList.Add("0 - Quest Items");
                    stringList.Add("1 - Event");
                    stringList.Add("2 - SkillUp");
                    stringList.Add("3 - Upgrade Stuff");
                    stringList.Add("4 - Materials & Skillbooks");
                    stringList.Add("5 - Gold");
                    stringList.Add("6 - Materials 1");
                    stringList.Add("7 - Materials 2");
                    stringList.Add("8 - Bloodseal Items");
                    stringList.Add("9 - Powder");
                    stringList.Add("10 - Event Items 1");
                    stringList.Add("11 - Castle Siege Concentration");
                    stringList.Add("12 - Castle Siege Powder");
                    stringList.Add("13 - Castle Siege Stone");
                    stringList.Add("14 - [P2] Target");
                    stringList.Add("15 - Quest Trigger");
                    stringList.Add("16 - Socket Jewel");
                    stringList.Add("17 - Socket Upgrading");
                    stringList.Add("18 - Socket Creation");
                    stringList.Add("19 - Monster Mercenary");
                    stringList.Add("20 - Guild Mark");
                    stringList.Add("21 - Reformer");
                    stringList.Add("22 - Chaos jewel");
                    stringList.Add("23 - Function");
                    stringList.Add("23 - RvR Jewel");
                    break;
                case 5:
                    stringList.Add("0 - Accesoires Charm");
                    stringList.Add("1 - Accesoires Magic Stone");
                    stringList.Add("2 - Accesoires Light Stone");
                    stringList.Add("3 - Accesoires Earing");
                    stringList.Add("4 - Accesoires Ring");
                    stringList.Add("5 - Accesoires Necklace");
                    stringList.Add("6 - P1 Pet");
                    stringList.Add("7 - P2 Pet");
                    stringList.Add("8 - Artifact");
                    break;
                case 6:
                    stringList.Add("0 - Antidotes / Cures");
                    stringList.Add("1 - HP Heal Potions");
                    stringList.Add("2 - MP Heal Potions");
                    stringList.Add("3 - HP+MP Heal Potions");
                    stringList.Add("4 - HP, MP, Attack Boost");
                    stringList.Add("5 - Steroids");
                    stringList.Add("6 - Minerals");
                    stringList.Add("7 - Tears");
                    stringList.Add("8 - Exp Crystals");
                    stringList.Add("9 - NPC Scroll");
                    stringList.Add("10 - HP Recovery Speed Potions");
                    stringList.Add("11 - MP Recovery Speed Potions");
                    stringList.Add("12 - [P2] Heal Items");
                    stringList.Add("13 - [P2] SpeedUp");
                    break;
                default:
                    stringList.Add("-1 - Unknown");
                    break;
            }
            return stringList.ToArray();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // comboBox2.Items.Clear();
            // comboBox2.Items.AddRange((object[]) ItemEditor2.SubTypes(comboBox1.SelectedIndex));
            textBox2.Text = comboBox1.SelectedIndex.ToString();
            if (textBox2.Text == "-1")
            {
                CbSubType7.Visible = true;
                comboBox2.Visible = false;
                CbSubtype1.Visible = false;
                CbSubtype2.Visible = false;
                CbSubtype3.Visible = false;
                CbSubType4.Visible = false;
                CbSubType5.Visible = false;
                CbSubType6.Visible = false;
            }
            else if (textBox2.Text == "0")
            {
                CbSubType7.Visible = false;
                comboBox2.Visible = true;
                CbSubtype1.Visible = false;
                CbSubtype2.Visible = false;
                CbSubtype3.Visible = false;
                CbSubType4.Visible = false;
                CbSubType5.Visible = false;
                CbSubType6.Visible = false;
            }

            else if (textBox2.Text == "1")
            {
                CbSubType7.Visible = false;
                comboBox2.Visible = false;
                CbSubtype1.Visible = true;
                CbSubtype2.Visible = false;
                CbSubtype3.Visible = false;
                CbSubType4.Visible = false;
                CbSubType5.Visible = false;
                CbSubType6.Visible = false;
            }

            else if (textBox2.Text == "2")
            {
                CbSubType7.Visible = false;
                comboBox2.Visible = false;
                CbSubtype1.Visible = false;
                CbSubtype2.Visible = true;
                CbSubtype3.Visible = false;
                CbSubType4.Visible = false;
                CbSubType5.Visible = false;
                CbSubType6.Visible = false;
            }

            else if (textBox2.Text == "3")
            {
                CbSubType7.Visible = false;
                comboBox2.Visible = false;
                CbSubtype1.Visible = false;
                CbSubtype2.Visible = false;
                CbSubtype3.Visible = true;
                CbSubType4.Visible = false;
                CbSubType5.Visible = false;
                CbSubType6.Visible = false;
            }

            else if (textBox2.Text == "4")
            {
                CbSubType7.Visible = false;
                comboBox2.Visible = false;
                CbSubtype1.Visible = false;
                CbSubtype2.Visible = false;
                CbSubtype3.Visible = false;
                CbSubType4.Visible = true;
                CbSubType5.Visible = false;
                CbSubType6.Visible = false;
            }

            else if (textBox2.Text == "5")
            {
                CbSubType7.Visible = false;
                comboBox2.Visible = false;
                CbSubtype1.Visible = false;
                CbSubtype2.Visible = false;
                CbSubtype3.Visible = false;
                CbSubType4.Visible = false;
                CbSubType5.Visible = true;
                CbSubType6.Visible = false;
            }

            else if (textBox2.Text == "6")
            {
                CbSubType7.Visible = false;
                comboBox2.Visible = false;
                CbSubtype1.Visible = false;
                CbSubtype2.Visible = false;
                CbSubtype3.Visible = false;
                CbSubType4.Visible = false;
                CbSubType5.Visible = false;
                CbSubType6.Visible = true;
            }
            // LoadMisc();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
            {
                textBox3.Text = GetIndexByComboBox(comboBox2.Text).ToString();
            }

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox9.Text = GetIndexByComboBox(comboBox4.Text).ToString();
        }

        public bool SearchString(string s)
        {
            return s.ToUpper().Contains(textBox12.Text.ToUpper());
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            MenuListSearch = MenuList.FindAll(new Predicate<string>(SearchString));
            listBox1.DataSource = MenuListSearch;
        }

        private void SetFlag(long flag, CheckedListBox clbFlagTest)
        {
            for (int index = 0; index < 64; ++index)
                clbFlagTest.SetItemChecked(index, (flag & 1L << index) > 0L);
        }

        private long GetFlag(CheckedListBox clbFlagTest)
        {
            long num = 0;
            for (int index = 0; index < clbFlagTest.Items.Count; ++index)
            {
                if (clbFlagTest.GetItemChecked(index))
                    num += 1L << index;
            }
            return num;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
        }

        private void ShowJobFlag(int flag)
        {
            for (int index = 0; index < checkedListBox1.Items.Count; ++index)
                checkedListBox1.SetItemChecked(index, (flag & 1 << index) > 0);
        }
        private void ShowFlagLong(long flag)
        {
            for (int index = 0; index < 64; ++index)
                clbFlagTest.SetItemChecked(index, (flag & 1L << index) > 0L);
        }

        private void ShowFlagLong1(long flag) //dethunter12 add
        {
            for (int index = 0; index < 64; ++index)
            ClbItemFlag.SetItemChecked(index, (flag & 1L << index) > 0L); //dethunter12 add
        }

        private void ShowFlag(int flag)
        {
            for (int index = 0; index < clbFlagTest.Items.Count; ++index)
                clbFlagTest.SetItemChecked(index, (flag & 1 << index) > 0);
            for (int index = 0; index < ClbItemFlag.Items.Count; ++index)
                ClbItemFlag.SetItemChecked(index, (flag & 1L << index) > 0L); //dethunter12 add
        }

        private void button4_Click(object sender, EventArgs e)
        {
            databaseHandle.SendQueryMySql(Host, User, Password, Database, "DROP TABLE IF EXISTS tempTable;" + "CREATE TEMPORARY TABLE tempTable ENGINE=MEMORY SELECT * FROM t_item WHERE a_index=" + textBox1.Text + ";" + "SELECT a_index FROM tempTable;" + "UPDATE tempTable SET a_index=(SELECT a_index from t_item ORDER BY a_index DESC LIMIT 1)+1; " + "SELECT a_index FROM tempTable;" + "INSERT INTO t_item SELECT * FROM tempTable;");
            LoadListBox();
            listBox1.SelectedIndex = listBox1.Items.Count - 1;
            int num5 = (int)new CustomMessage("Copying Complete").ShowDialog();
        }

        private void exportStrItemlodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exportLodHandle.ExportString_V4("strItem");
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int num = 0;
            for (int index = 0; index < checkedListBox1.Items.Count; ++index)
            {
                if (checkedListBox1.GetItemChecked(index))
                    num += 1 << index;
            }
            textBox7.Text = num.ToString();
        }

        private void clbFlagTest_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            long num = 0;
            for (int index = 0; index < clbFlagTest.Items.Count; ++index)
            {
                if (clbFlagTest.GetItemChecked(index))
                    num += 1L << index;
            }
            textBox8.Text = num.ToString();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox60.Text = comboBox3.SelectedIndex.ToString();
            List = databaseHandle.SelectMySqlExplodedReturnList(menuArray3, Host, User, Password, Database, "select * from t_option WHERE a_type = '" + textBox60.Text + "' ORDER BY a_index;");
            comboBox14.DataSource = null;
            comboBox14.Items.Clear();
            comboBox14.DataSource = List;
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox61.Text = comboBox5.SelectedIndex.ToString();
            List2 = databaseHandle.SelectMySqlExplodedReturnList(menuArray3, Host, User, Password, Database, "select * from t_option WHERE a_type = '" + textBox61.Text + "' ORDER BY a_index;");
            comboBox15.DataSource = null;
            comboBox15.Items.Clear();
            comboBox15.DataSource = List2;
            if (!(textBox61.Text != "-1"))
                return;
            comboBox15.SelectedIndex = Convert.ToInt32(textBox71.Text) - 1;
        }

        private void SetSelectedComboBoxPurple2()
        {
            if (textBox61.Text != "-1")
                comboBox15.SelectedIndex = Convert.ToInt32(textBox71.Text) - 1;
            if (textBox62.Text != "-1")
                comboBox16.SelectedIndex = Convert.ToInt32(textBox72.Text) - 1;
            if (textBox63.Text != "-1")
                comboBox17.SelectedIndex = Convert.ToInt32(textBox73.Text) - 1;
            if (textBox64.Text != "-1")
                comboBox18.SelectedIndex = Convert.ToInt32(textBox74.Text) - 1;
            if (textBox65.Text != "-1")
                comboBox19.SelectedIndex = Convert.ToInt32(textBox75.Text) - 1;
            if (!(textBox66.Text != "-1"))
                return;
            comboBox20.SelectedIndex = Convert.ToInt32(textBox76.Text) - 1;
        }

        private void ClearComboBoxPurple2()
        {
            comboBox15.SelectedIndex = -1;
            comboBox16.SelectedIndex = -1;
            comboBox17.SelectedIndex = -1;
            comboBox18.SelectedIndex = -1;
            comboBox19.SelectedIndex = -1;
            comboBox20.SelectedIndex = -1;
        }

        private void ClearComboBoxPurple()
        {
            comboBox3.SelectedIndex = -1; //dethunter12 add
            comboBox5.SelectedIndex = -1;
            comboBox6.SelectedIndex = -1;
            comboBox7.SelectedIndex = -1;
            comboBox8.SelectedIndex = -1;
            comboBox9.SelectedIndex = -1;
            comboBox10.SelectedIndex = -1;
            comboBox11.SelectedIndex = -1; //dethunter12 add
            comboBox12.SelectedIndex = -1; //dethunter12 add
            comboBox13.SelectedIndex = -1; //dethunter12 add


        }

        private void ResetComboBoxPurpleBg() //dethunter12 add
        {
            comboBox3.BackColor = Color.White;
            comboBox5.BackColor = Color.White;
            comboBox6.BackColor = Color.White;
            comboBox7.BackColor = Color.White;
            comboBox8.BackColor = Color.White;
            comboBox9.BackColor = Color.White;
            comboBox10.BackColor = Color.White;
            comboBox11.BackColor = Color.White;
            comboBox12.BackColor = Color.White;
            comboBox13.BackColor = Color.White;

        }

        private void ResetTextBoxBackground() //dethunter12 add
        {
            //basic
            textBox1.BackColor = Color.White;
            textBox46.BackColor = Color.White;
            textBox5.BackColor = Color.White;
            textBox6.BackColor = Color.White;
            textBox47.BackColor = Color.White;
            //icon
            textBox48.BackColor = Color.White;
            textBox49.BackColor = Color.White;
            textBox50.BackColor = Color.White;
            //Stats
            textBox16.BackColor = Color.White;
            textBox17.BackColor = Color.White;
            textBox18.BackColor = Color.White;
            textBox19.BackColor = Color.White;
            textBox21.BackColor = Color.White;
            //Common Rare Option
            textBox57.BackColor = Color.White;
            textBox58.BackColor = Color.White;
            //RvR
            textBox91.BackColor = Color.White;
            textBox92.BackColor = Color.White;
            comboBox24.BackColor = Color.White;
            comboBox25.BackColor = Color.White;
            comboBox26.BackColor = Color.White;
            //Item Special Effects
            textBox80.BackColor = Color.White;
            textBox81.BackColor = Color.White;
            textBox82.BackColor = Color.White;
            //option 
            textBox10.BackColor = Color.White;
            textBox11.BackColor = Color.White;
            textBox13.BackColor = Color.White;
            textBox14.BackColor = Color.White;
            textBox15.BackColor = Color.White;
            //random settings
            textBox52.BackColor = Color.White;
            textBox53.BackColor = Color.White;
            textBox54.BackColor = Color.White;
            textBox55.BackColor = Color.White;
            textBox56.BackColor = Color.White;
            //origin
            textBox85.BackColor = Color.White;
            textBox86.BackColor = Color.White;
            textBox87.BackColor = Color.White;
            textBox88.BackColor = Color.White;
            textBox89.BackColor = Color.White;
            textBox90.BackColor = Color.White;
            //misc
            textBox59.BackColor = Color.White;
            textBox51.BackColor = Color.White;
            textBox94.BackColor = Color.White;
            textBox93.BackColor = Color.White;
            textBox83.BackColor = Color.White;
            textBox84.BackColor = Color.White;
            //character
            textBox2.BackColor = Color.White;
            textBox3.BackColor = Color.White;
            textBox7.BackColor = Color.White;
            textBox9.BackColor = Color.White;
            textBox8.BackColor = Color.White;
            textBox20.BackColor = Color.White;
            //crafting
            textBox42.BackColor = Color.White;
            textBox43.BackColor = Color.White;
            textBox44.BackColor = Color.White;
            textBox45.BackColor = Color.White;
            //itemcrafting
            textBox22.BackColor = Color.White;
            textBox23.BackColor = Color.White;
            textBox24.BackColor = Color.White;
            textBox25.BackColor = Color.White;
            textBox26.BackColor = Color.White;
            textBox32.BackColor = Color.White;
            textBox33.BackColor = Color.White;
            textBox34.BackColor = Color.White;
            textBox35.BackColor = Color.White;
            textBox36.BackColor = Color.White;
            textBox27.BackColor = Color.White;
            textBox28.BackColor = Color.White;
            textBox29.BackColor = Color.White;
            textBox30.BackColor = Color.White;
            textBox31.BackColor = Color.White;
            textBox37.BackColor = Color.White;
            textBox38.BackColor = Color.White;
            textBox39.BackColor = Color.White;
            textBox40.BackColor = Color.White;
            textBox41.BackColor = Color.White;
            //rareoption
            textBox60.BackColor = Color.White;
            textBox61.BackColor = Color.White;
            textBox62.BackColor = Color.White;
            textBox63.BackColor = Color.White;
            textBox64.BackColor = Color.White;
            textBox65.BackColor = Color.White;
            textBox66.BackColor = Color.White;
            textBox67.BackColor = Color.White;
            textBox68.BackColor = Color.White;
            textBox69.BackColor = Color.White;
            textBox70.BackColor = Color.White;
            textBox71.BackColor = Color.White;
            textBox72.BackColor = Color.White;
            textBox73.BackColor = Color.White;
            textBox74.BackColor = Color.White;
            textBox75.BackColor = Color.White;
            textBox76.BackColor = Color.White;
            textBox77.BackColor = Color.White;
            textBox78.BackColor = Color.White;
            textBox79.BackColor = Color.White;
        }

        private void comboBox14_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox70.Text = comboBox14.SelectedIndex.ToString();
        }

        private void comboBox15_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_ComboBoxPurpleLocked)
                return;
            textBox71.Text = (comboBox15.SelectedIndex + 1).ToString();
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox62.Text = comboBox6.SelectedIndex.ToString();
            List3 = databaseHandle.SelectMySqlExplodedReturnList(menuArray3, Host, User, Password, Database, "select * from t_option WHERE a_type = '" + textBox62.Text + "' ORDER BY a_index;");
            comboBox16.DataSource = null;
            comboBox16.Items.Clear();
            comboBox16.DataSource = List3;
          //  if (!(textBox62.Text != "-1"))
            //    return;
           // comboBox16.SelectedIndex = Convert.ToInt32(textBox72.Text);
        }

        private void comboBox16_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_ComboBoxPurpleLocked)
                return;
            textBox72.Text = (comboBox16.SelectedIndex + 1).ToString();
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox63.Text = comboBox7.SelectedIndex.ToString();
            List4 = databaseHandle.SelectMySqlExplodedReturnList(menuArray3, Host, User, Password, Database, "select * from t_option WHERE a_type = '" + textBox63.Text + "' ORDER BY a_index;");
            comboBox17.DataSource = null;
            comboBox17.Items.Clear();
            comboBox17.DataSource = List4;
          //  if (!(textBox63.Text != "-1"))
          //      return;
           // comboBox17.SelectedIndex = Convert.ToInt32(textBox73.Text);
        }

        private void comboBox17_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_ComboBoxPurpleLocked)
                return;
            textBox73.Text = (comboBox17.SelectedIndex + 1).ToString();
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox64.Text = comboBox8.SelectedIndex.ToString();
            List5 = databaseHandle.SelectMySqlExplodedReturnList(menuArray3, Host, User, Password, Database, "select * from t_option WHERE a_type = '" + textBox64.Text + "' ORDER BY a_index;");
            comboBox18.DataSource = null;
            comboBox18.Items.Clear();
            comboBox18.DataSource = List5;
           // if (!(textBox64.Text != "-1"))
           //     return;
           // comboBox18.SelectedIndex = Convert.ToInt32(textBox74.Text);
        }

        private void comboBox18_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_ComboBoxPurpleLocked)
                return;
            textBox74.Text = (comboBox18.SelectedIndex + 1).ToString();
        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox65.Text = comboBox9.SelectedIndex.ToString();
            List6 = databaseHandle.SelectMySqlExplodedReturnList(menuArray3, Host, User, Password, Database, "select * from t_option WHERE a_type = '" + textBox65.Text + "' ORDER BY a_index;");
            comboBox19.DataSource = null;
            comboBox19.Items.Clear();
            comboBox19.DataSource = List6;
         //   if (!(textBox65.Text != "-1"))
           //     return;
           // comboBox19.SelectedIndex = Convert.ToInt32(textBox75.Text);
        }

        private void comboBox19_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_ComboBoxPurpleLocked)
                return;
            textBox75.Text = (comboBox19.SelectedIndex + 1).ToString();
        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox66.Text = comboBox10.SelectedIndex.ToString();
            List7 = databaseHandle.SelectMySqlExplodedReturnList(menuArray3, Host, User, Password, Database, "select * from t_option WHERE a_type = '" + textBox66.Text + "' ORDER BY a_index;");
            comboBox20.DataSource = null;
            comboBox20.Items.Clear();
            comboBox20.DataSource = List7;
           // if (!(textBox66.Text != "-1"))
           //     return;
          //  comboBox20.SelectedIndex = Convert.ToInt32(textBox76.Text);
        }

        private void comboBox20_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_ComboBoxPurpleLocked)
                return;
            textBox76.Text = (comboBox20.SelectedIndex + 1).ToString();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            IconPickerItem iconPickerItem = new IconPickerItem();
            iconPickerItem.OldItemBtnSelect = Convert.ToInt32(textBox48.Text);
            if (iconPickerItem.ShowDialog() != DialogResult.OK)
                return;
            textBox48.Text = iconPickerItem.TexID.ToString();
            textBox49.Text = iconPickerItem.TexColumn.ToString();
            textBox50.Text = iconPickerItem.TexRow.ToString();
            databaseHandle.SendQueryMySql(Host, User, Password, Database, "UPDATE t_item SET " + "a_texture_id = '" + textBox48.Text + "', " + "a_texture_row = '" + textBox50.Text + "', " + "a_texture_col = '" + textBox49.Text + "' " + "WHERE a_index = '" + textBox1.Text + "'");
            int selectedIndex = listBox1.SelectedIndex;
            if (textBox12.Text != "")
                SearchList(textBox12.Text);
            else
                LoadListBox();
            listBox1.SelectedIndex = selectedIndex;
        }

        private void comboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox67.Text = comboBox11.SelectedIndex.ToString();
            List8 = databaseHandle.SelectMySqlExplodedReturnList(menuArray3, Host, User, Password, Database, "select * from t_option WHERE a_type = '" + textBox67.Text + "' ORDER BY a_index;");
            comboBox21.DataSource = null;
            comboBox21.Items.Clear();
            comboBox21.DataSource = List8;
        }

        private void comboBox21_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox77.Text = comboBox21.SelectedIndex.ToString();
        }

        private void comboBox12_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox68.Text = comboBox12.SelectedIndex.ToString();
            List9 = databaseHandle.SelectMySqlExplodedReturnList(menuArray3, Host, User, Password, Database, "select * from t_option WHERE a_type = '" + textBox68.Text + "' ORDER BY a_index;");
            comboBox22.DataSource = null;
            comboBox22.Items.Clear();
            comboBox22.DataSource = List9;
        }

        private void comboBox22_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox78.Text = comboBox22.SelectedIndex.ToString();
        }

        private void comboBox13_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox69.Text = comboBox13.SelectedIndex.ToString();
            List10 = databaseHandle.SelectMySqlExplodedReturnList(menuArray3, Host, User, Password, Database, "select * from t_option WHERE a_type = '" + textBox69.Text + "' ORDER BY a_index;");
            comboBox23.DataSource = null;
            comboBox23.Items.Clear();
            comboBox23.DataSource = List10;
        }

        private void comboBox23_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox79.Text = comboBox23.SelectedIndex.ToString();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ItemPicker itemPicker = new ItemPicker();
            if (itemPicker.ShowDialog() != DialogResult.OK)
                return;
            textBox22.Text = itemPicker.ItemIndex.ToString();
        }

        private void pictureBox3_MouseMove_1(object sender, MouseEventArgs e)
        {
            pictureBox3.Size = new Size(26, 26);
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Size = new Size(22, 22);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ItemPicker itemPicker = new ItemPicker();
            if (itemPicker.ShowDialog() != DialogResult.OK)
                return;
            textBox23.Text = itemPicker.ItemIndex.ToString();
        }

        private void pictureBox4_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox4.Size = new Size(26, 26);
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Size = new Size(22, 22);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            ItemPicker itemPicker = new ItemPicker();
            if (itemPicker.ShowDialog() != DialogResult.OK)
                return;
            textBox24.Text = itemPicker.ItemIndex.ToString();
        }

        private void pictureBox5_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox5.Size = new Size(26, 26);
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.Size = new Size(22, 22);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            ItemPicker itemPicker = new ItemPicker();
            if (itemPicker.ShowDialog() != DialogResult.OK)
                return;
            textBox25.Text = itemPicker.ItemIndex.ToString();
        }

        private void pictureBox6_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox6.Size = new Size(26, 26);
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.Size = new Size(22, 22);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            ItemPicker itemPicker = new ItemPicker();
            if (itemPicker.ShowDialog() != DialogResult.OK)
                return;
            textBox26.Text = itemPicker.ItemIndex.ToString();
        }

        private void pictureBox7_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox7.Size = new Size(26, 26);
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            pictureBox7.Size = new Size(22, 22);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            ItemPicker itemPicker = new ItemPicker();
            if (itemPicker.ShowDialog() != DialogResult.OK)
                return;
            textBox27.Text = itemPicker.ItemIndex.ToString();
        }

        private void pictureBox8_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox8.Size = new Size(26, 26);
        }

        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
            pictureBox8.Size = new Size(22, 22);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            ItemPicker itemPicker = new ItemPicker();
            if (itemPicker.ShowDialog() != DialogResult.OK)
                return;
            textBox28.Text = itemPicker.ItemIndex.ToString();
        }

        private void pictureBox9_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox9.Size = new Size(26, 26);
        }

        private void pictureBox9_MouseLeave(object sender, EventArgs e)
        {
            pictureBox9.Size = new Size(22, 22);
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            ItemPicker itemPicker = new ItemPicker();
            if (itemPicker.ShowDialog() != DialogResult.OK)
                return;
            textBox29.Text = itemPicker.ItemIndex.ToString();
        }

        private void pictureBox10_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox10.Size = new Size(26, 26);
        }

        private void pictureBox10_MouseLeave(object sender, EventArgs e)
        {
            pictureBox10.Size = new Size(22, 22);
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            ItemPicker itemPicker = new ItemPicker();
            if (itemPicker.ShowDialog() != DialogResult.OK)
                return;
            textBox30.Text = itemPicker.ItemIndex.ToString();
        }

        private void pictureBox11_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox11.Size = new Size(26, 26);
        }

        private void pictureBox11_MouseLeave(object sender, EventArgs e)
        {
            pictureBox11.Size = new Size(22, 22);
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            ItemPicker itemPicker = new ItemPicker();
            if (itemPicker.ShowDialog() != DialogResult.OK)
                return;
            textBox31.Text = itemPicker.ItemIndex.ToString();
        }

        private void pictureBox12_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox12.Size = new Size(26, 26);
        }

        private void pictureBox12_MouseLeave(object sender, EventArgs e)
        {
            pictureBox12.Size = new Size(22, 22);
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            RareOptSearch rareOptSearch = new RareOptSearch();
            if (rareOptSearch.ShowDialog() != DialogResult.OK)
                return;
            textBox60.Text = rareOptSearch.varf3;
        }

        private void pictureBox13_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox13.Size = new Size(26, 26);
        }

        private void pictureBox13_MouseLeave(object sender, EventArgs e)
        {
            pictureBox13.Size = new Size(22, 22);
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            RareOptSearch rareOptSearch = new RareOptSearch();
            if (rareOptSearch.ShowDialog() != DialogResult.OK)
                return;
            textBox61.Text = rareOptSearch.varf3;
        }

        private void pictureBox14_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox14.Size = new Size(26, 26);
        }

        private void pictureBox14_MouseLeave(object sender, EventArgs e)
        {
            pictureBox14.Size = new Size(22, 22);
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            RareOptSearch rareOptSearch = new RareOptSearch();
            if (rareOptSearch.ShowDialog() != DialogResult.OK)
                return;
            textBox62.Text = rareOptSearch.varf3;
        }

        private void pictureBox15_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox15.Size = new Size(26, 26);
        }

        private void pictureBox15_MouseLeave(object sender, EventArgs e)
        {
            pictureBox15.Size = new Size(22, 22);
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            RareOptSearch rareOptSearch = new RareOptSearch();
            if (rareOptSearch.ShowDialog() != DialogResult.OK)
                return;
            textBox63.Text = rareOptSearch.varf3;
        }

        private void pictureBox16_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox16.Size = new Size(26, 26);
        }

        private void pictureBox16_MouseLeave(object sender, EventArgs e)
        {
            pictureBox16.Size = new Size(22, 22);
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            RareOptSearch rareOptSearch = new RareOptSearch();
            if (rareOptSearch.ShowDialog() != DialogResult.OK)
                return;
            textBox64.Text = rareOptSearch.varf3;
        }

        private void pictureBox17_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox17.Size = new Size(26, 26);
        }

        private void pictureBox17_MouseLeave(object sender, EventArgs e)
        {
            pictureBox17.Size = new Size(22, 22);
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            RareOptSearch rareOptSearch = new RareOptSearch();
            if (rareOptSearch.ShowDialog() != DialogResult.OK)
                return;
            textBox65.Text = rareOptSearch.varf3;
        }

        private void pictureBox18_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox18.Size = new Size(26, 26);
        }

        private void pictureBox18_MouseLeave(object sender, EventArgs e)
        {
            pictureBox18.Size = new Size(22, 22);
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            RareOptSearch rareOptSearch = new RareOptSearch();
            if (rareOptSearch.ShowDialog() != DialogResult.OK)
                return;
            textBox66.Text = rareOptSearch.varf3;
        }

        private void pictureBox19_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox19.Size = new Size(26, 26);
        }

        private void pictureBox19_MouseLeave(object sender, EventArgs e)
        {
            pictureBox19.Size = new Size(22, 22);
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(textBox67.Text) <= 134) //dethunter12 add
            {
                RareOptSearch rareOptSearch = new RareOptSearch();
                if (rareOptSearch.ShowDialog() != DialogResult.OK)
                    return;
                textBox67.Text = rareOptSearch.varf3;
            }
            else if(Int32.Parse(textBox67.Text) >= 134) //dethunter12 add
            {
                SkillPicker skillPicker = new SkillPicker();
                if (skillPicker.ShowDialog() != DialogResult.OK)
                    return;
                textBox67.Text = skillPicker.SkillIndex.ToString();
            }
        }

        private void pictureBox20_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox20.Size = new Size(26, 26);
        }

        private void pictureBox20_MouseLeave(object sender, EventArgs e)
        {
            pictureBox20.Size = new Size(22, 22);
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            RareOptSearch rareOptSearch = new RareOptSearch();
            if (rareOptSearch.ShowDialog() != DialogResult.OK)
                return;
            textBox68.Text = rareOptSearch.varf3;
        }

        private void pictureBox21_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox21.Size = new Size(26, 26);
        }

        private void pictureBox21_MouseLeave(object sender, EventArgs e)
        {
            pictureBox21.Size = new Size(22, 22);
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            RareOptSearch rareOptSearch = new RareOptSearch();
            if (rareOptSearch.ShowDialog() != DialogResult.OK)
                return;
            textBox69.Text = rareOptSearch.varf3;
        }

        private void pictureBox22_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox22.Size = new Size(26, 26);
        }

        private void pictureBox22_MouseLeave(object sender, EventArgs e)
        {
            pictureBox22.Size = new Size(22, 22);
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            FlagBuilder flagBuilder = new FlagBuilder();
            if (Episode == "EP4")
            {
                flagBuilder.flagBig = Convert.ToInt64(textBox8.Text);
                if (flagBuilder.ShowDialog() != DialogResult.OK)
                    return;
                textBox8.Text = flagBuilder.flagBig.ToString();
            }
            else
            {
                flagBuilder.flagSmall = Convert.ToInt32(textBox8.Text);
                if (flagBuilder.ShowDialog() != DialogResult.OK)
                    return;
                textBox8.Text = flagBuilder.flagSmall.ToString();
            }
        }



        private void comboBox24_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBox25_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            for (int index = 0; index < checkedListBox2.Items.Count; ++index)
            {
                if (checkedListBox2.GetItemChecked(index))
                {
                    num1 += 1 << index;
                    ++num2;
                }
            }
            mSortJob = num1.ToString();
            if (num2 == 0)
                mSortJob = "-1";
            LoadListBox();
        }

        private void InitializeDevice()
        {
           /* _Direct3D = new Direct3D();
            Direct3D direct3D = _Direct3D;
            int adapter = 0;
            int num1 = 1;
            IntPtr handle1 = Handle;
            int num2 = 32;
            PresentParameters[] presentParametersArray = new PresentParameters[1];
            int index = 0;
            PresentParameters presentParameters = new PresentParameters();
            presentParameters.SwapEffect = SwapEffect.Discard;
            IntPtr handle2 = panel3DView.Handle;
            presentParameters.DeviceWindowHandle = handle2;
            int num3 = 1;
            presentParameters.Windowed = num3 != 0;
            int width = panel3DView.Width;
            presentParameters.BackBufferWidth = width;
            int height = panel3DView.Height;
            presentParameters.BackBufferHeight = height;
            int num4 = 21;
            presentParameters.BackBufferFormat = (SlimDX.Direct3D9.Format)num4;
            presentParametersArray[index] = presentParameters;
            _Device = new Device(direct3D, adapter, (DeviceType)num1, handle1, (CreateFlags)num2, presentParametersArray);
            _Device.SetRenderState<Cull>(RenderState.CullMode, Cull.None);
            _Device.SetRenderState<FillMode>(RenderState.FillMode, FillMode.Solid);
            _Device.SetRenderState(RenderState.Lighting, false);
            CameraPositioning();*/
        }

      /*  private void CameraPositioning()
        {
            _Device.SetTransform(TransformState.Projection, Matrix.PerspectiveFovLH(100f, 1f, 1f, 450f));
            _Device.SetTransform(TransformState.View, Matrix.LookAtLH(new Vector3(0.0f, 0.0f, -5f), new Vector3(0.0f, 0.0f, 0.0f), new Vector3(0.0f, 1f, 0.0f)));
            _Device.SetTransform(TransformState.World, Matrix.RotationYawPitchRoll(0.0f, 0.0f, 0.0f));
        }*/

       /* private void Render()
        {
            _Device.Viewport = new Viewport(0, 0, panel3DView.Width, panel3DView.Height);
            _Device.Clear(ClearFlags.ZBuffer | ClearFlags.Target, new Color4(Color.FromKnownColor(KnownColor.Control)), 1f, 0);
            _Device.BeginScene();
            _Device.SetTransform(TransformState.View, Matrix.LookAtLH(new Vector3(0.0f, 0.0f, _Zoom), new Vector3(_LeftRight, _UpDown, 0.0f), new Vector3(0.0f, 1f, 0.0f)));
            _Device.SetTransform(TransformState.World, Matrix.RotationYawPitchRoll(_Rotation, 3.1f, 0.0f));
            if (_Models != null && (uint)_Models.Count<tMesh>() > 0U)
            {
                for (int index = 0; index < _Models.Count<tMesh>(); ++index)
                {
                    if (_Models[index].TexData != null)
                        _Device.SetTexture(0, (BaseTexture)_Models[index].TexData);
                    for (int subset = 0; subset < 1000; ++subset)
                        _Models[index].MeshData.DrawSubset(subset);
                }
            }
            _Device.EndScene();
            _Device.Present();
            _Rotation = _Rotation - 0.03f;
        }

        private SlimDX.Direct3D9.Format ConvFormat(texFormat tFormat)
        {
            SlimDX.Direct3D9.Format format = SlimDX.Direct3D9.Format.Unknown;
            switch (tFormat)
            {
                case texFormat.RGB:
                    return SlimDX.Direct3D9.Format.R8G8B8;
                case texFormat.ARGB:
                    return SlimDX.Direct3D9.Format.A8R8G8B8;
                case texFormat.DXT1:
                    return SlimDX.Direct3D9.Format.Dxt1;
                case texFormat.DXT3:
                    return SlimDX.Direct3D9.Format.Dxt3;
                default:
                    return format;
            }
        }

        private Texture BuildTexture(byte[] imageData, SlimDX.Direct3D9.Format imageFormat, int width, int height)
        {
            if (imageFormat == SlimDX.Direct3D9.Format.R8G8B8)
            {
                MemoryStream memoryStream;
                using (memoryStream = new MemoryStream())
                {
                    Tex.makeRGB8(imageData, width, height).Save((Stream)memoryStream, ImageFormat.Bmp);
                    memoryStream.Write(imageData, 0, imageData.Length);
                    memoryStream.Position = 0L;
                    return Texture.FromStream(_Device, (Stream)memoryStream, width, height, 0, Usage.SoftwareProcessing, SlimDX.Direct3D9.Format.A8B8G8R8, Pool.Default, Filter.None, Filter.None, 0);
                }
            }
            else if (imageFormat == SlimDX.Direct3D9.Format.A8R8G8B8)
            {
                MemoryStream memoryStream;
                using (memoryStream = new MemoryStream())
                {
                    Tex.makeRGB(imageData, width, height).Save((Stream)memoryStream, ImageFormat.Bmp);
                    memoryStream.Write(imageData, 0, imageData.Length);
                    memoryStream.Position = 0L;
                    return Texture.FromStream(_Device, (Stream)memoryStream, width, height, 0, Usage.SoftwareProcessing, SlimDX.Direct3D9.Format.A8B8G8R8, Pool.Default, Filter.None, Filter.None, 0);
                }
            }
            else
            {
                Texture texture = new Texture(_Device, width, height, 0, Usage.None, imageFormat, Pool.Managed);
                using (Stream data = (Stream)texture.LockRectangle(0, LockFlags.None).Data)
                {
                    data.Write(imageData, 0, ((IEnumerable<byte>)imageData).Count<byte>());
                    texture.UnlockRectangle(0);
                }
                return texture;
            }
        }

        private Texture GetTextureFromFile(string FileName)
        {
            Texture texture = (Texture)null;
            if (File.Exists(FileName))
            {
                Tex.ReadFile(FileName);
                SlimDX.Direct3D9.Format imageFormat = ConvFormat(Tex.GetFormat());
                texture = BuildTexture(Tex.lcTex.imageData[0], imageFormat, (int)Tex.lcTex.Header.Width, (int)Tex.lcTex.Header.Height);
            }
            return texture;
        }*/

       /* private void MakeLCModels(string SMCFile)
        {
            System.Collections.Generic.List<float> source1 = new System.Collections.Generic.List<float>();
            System.Collections.Generic.List<float> source2 = new System.Collections.Generic.List<float>();
            System.Collections.Generic.List<float> source3 = new System.Collections.Generic.List<float>();
            System.Collections.Generic.List<float> floatList1 = new System.Collections.Generic.List<float>();
            System.Collections.Generic.List<float> floatList2 = new System.Collections.Generic.List<float>();
            System.Collections.Generic.List<float> floatList3 = new System.Collections.Generic.List<float>();
            _Models = new System.Collections.Generic.List<tMesh>();
            try
            {
                System.Collections.Generic.List<smcMesh> source4 = SMCReader.ReadFile(SMCFile);
                for (int index1 = 0; index1 < source4.Count<smcMesh>(); ++index1)
                {
                    if (LCMeshReader.ReadFile(source4[index1].FileName))
                    {
                        tMeshContainer pMesh = LCMeshReader.pMesh;
                        source1.Add(((IEnumerable<tVertex3f>)pMesh.Vertices).Max<tVertex3f>((Func<tVertex3f, float>)(p => p.X)));
                        source2.Add(((IEnumerable<tVertex3f>)pMesh.Vertices).Max<tVertex3f>((Func<tVertex3f, float>)(p => p.Y)));
                        source3.Add(((IEnumerable<tVertex3f>)pMesh.Vertices).Max<tVertex3f>((Func<tVertex3f, float>)(p => p.Z)));
                        floatList1.Add(((IEnumerable<tVertex3f>)pMesh.Vertices).Min<tVertex3f>((Func<tVertex3f, float>)(p => p.X)));
                        floatList2.Add(((IEnumerable<tVertex3f>)pMesh.Vertices).Min<tVertex3f>((Func<tVertex3f, float>)(p => p.Y)));
                        floatList3.Add(((IEnumerable<tVertex3f>)pMesh.Vertices).Min<tVertex3f>((Func<tVertex3f, float>)(p => p.Z)));
                        for (int index2 = 0; index2 < ((IEnumerable<tMeshObject>)pMesh.Objects).Count<tMeshObject>(); ++index2)
                        {
                            int toVert = (int)pMesh.Objects[index2].ToVert;
                            int faceCount = (int)pMesh.Objects[index2].FaceCount;
                            short[] faces = pMesh.Objects[index2].GetFaces();
                            CustomVertex.PositionNormalTextured[] data = new CustomVertex.PositionNormalTextured[toVert];
                            int fromVert = (int)pMesh.Objects[index2].FromVert;
                            for (int index3 = 0; (long)index3 < (long)pMesh.Objects[index2].ToVert; ++index3)
                            {
                                data[index3].Position = new Vector3(pMesh.Vertices[fromVert].X, pMesh.Vertices[fromVert].Y, pMesh.Vertices[fromVert].Z);
                                data[index3].Normal = new Vector3(pMesh.Normals[fromVert].X, pMesh.Normals[fromVert].Y, pMesh.Normals[fromVert].Z);
                                try
                                {
                                    data[index3].Texture = new Vector2(pMesh.UVMaps[0].Coords[fromVert].U, pMesh.UVMaps[0].Coords[fromVert].V);
                                }
                                catch
                                {
                                    data[index3].Texture = new Vector2(0.0f, 0.0f);
                                }
                                ++fromVert;
                            }
                            VertexBuffer vertexBuffer = new VertexBuffer(_Device, ((IEnumerable<CustomVertex.PositionNormalTextured>)data).Count<CustomVertex.PositionNormalTextured>() * 32, Usage.None, VertexFormat.PositionNormal | VertexFormat.Texture1, Pool.Default);
                            Mesh mesh = new Mesh(_Device, ((IEnumerable<short>)faces).Count<short>() / 3, ((IEnumerable<CustomVertex.PositionNormalTextured>)data).Count<CustomVertex.PositionNormalTextured>(), MeshFlags.Managed, VertexFormat.PositionNormal | VertexFormat.Texture1);
                            DataStream dataStream1;
                            using (dataStream1 = mesh.VertexBuffer.Lock(0, ((IEnumerable<CustomVertex.PositionNormalTextured>)data).Count<CustomVertex.PositionNormalTextured>() * 32, LockFlags.None))
                            {
                                dataStream1.WriteRange<CustomVertex.PositionNormalTextured>(data);
                                mesh.VertexBuffer.Unlock();
                            }
                            DataStream dataStream2;
                            using (dataStream2 = mesh.IndexBuffer.Lock(0, ((IEnumerable<short>)faces).Count<short>() * 2, LockFlags.None))
                            {
                                dataStream2.WriteRange<short>(faces);
                                mesh.IndexBuffer.Unlock();
                            }
                            if ((uint)((IEnumerable<tMeshJointWeights>)pMesh.Weights).Count<tMeshJointWeights>() > 0U)
                            {
                                string[] strArray = new string[((IEnumerable<tMeshJointWeights>)pMesh.Weights).Count<tMeshJointWeights>()];
                                System.Collections.Generic.List<int>[] intListArray = new System.Collections.Generic.List<int>[((IEnumerable<tMeshJointWeights>)pMesh.Weights).Count<tMeshJointWeights>()];
                                System.Collections.Generic.List<float>[] floatListArray = new System.Collections.Generic.List<float>[((IEnumerable<tMeshJointWeights>)pMesh.Weights).Count<tMeshJointWeights>()];
                                for (int index3 = 0; index3 < ((IEnumerable<tMeshJointWeights>)pMesh.Weights).Count<tMeshJointWeights>(); ++index3)
                                {
                                    strArray[index3] = _Enc.GetString(pMesh.Weights[index3].JointName);
                                    intListArray[index3] = new System.Collections.Generic.List<int>();
                                    floatListArray[index3] = new System.Collections.Generic.List<float>();
                                    for (int index4 = 0; index4 < ((IEnumerable<tMeshWeightsMap>)pMesh.Weights[index3].WeightsMap).Count<tMeshWeightsMap>(); ++index4)
                                    {
                                        intListArray[index3].Add(pMesh.Weights[index3].WeightsMap[index4].Index);
                                        floatListArray[index3].Add(pMesh.Weights[index3].WeightsMap[index4].Weight);
                                    }
                                }
                                mesh.SkinInfo = new SkinInfo(((IEnumerable<CustomVertex.PositionNormalTextured>)data).Count<CustomVertex.PositionNormalTextured>(), VertexFormat.PositionNormal | VertexFormat.Texture1, (int)pMesh.HeaderInfo.JointCount);
                                for (int bone = 0; bone < ((IEnumerable<System.Collections.Generic.List<int>>)intListArray).Count<System.Collections.Generic.List<int>>(); ++bone)
                                {
                                    mesh.SkinInfo.SetBoneName(bone, strArray[bone]);
                                    mesh.SkinInfo.SetBoneInfluence(bone, intListArray[bone].ToArray(), floatListArray[bone].ToArray());
                                }
                            }
                            mesh.GenerateAdjacency(0.5f);
                            mesh.ComputeNormals();
                            Texture texture = (Texture)null;
                            string objName = _Enc.GetString(pMesh.Objects[index2].Textures[0].InternalName);
                            int index5 = source4[index1].Object.FindIndex((Predicate<smcObject>)(x => x.Name.Equals(objName)));
                            if (index5 != -1)
                                texture = GetTextureFromFile(source4[index1].Object[index5].Texture);
                            _Models.Add(new tMesh(mesh, texture));
                        }
                    }
                }
            }
            catch
            {
            }
            try
            {
                _Zoom = ((IEnumerable<float>)new float[3]
        {
          source1.Max(),
          source2.Max(),
          source3.Max()
        }).Max() * 3f;
            }
            catch
            {
            }
            slideZoom.Value = (int)_Zoom * 100;
        }*/

      /*  private void timer1_Tick(object sender, EventArgs e)
        {
            Render();
        }*/

        private void textBox95_TextChanged(object sender, EventArgs e)
        {
            _SortAboveLevel = textBox95.Text;
            LoadListBox();
        }

        private void button27_Click(object sender, EventArgs e)
        {
        }

        private void textBox70_TextChanged(object sender, EventArgs e)
        {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemEditor2));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileExportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportlodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportStrItemlodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportSmclodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.massEditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.v = new System.Windows.Forms.ToolStripMenuItem();
            this.massUpdateSealsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.ClbItemFlag = new System.Windows.Forms.CheckedListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.groupBox23 = new System.Windows.Forms.GroupBox();
            this.label84 = new System.Windows.Forms.Label();
            this.textBox84 = new System.Windows.Forms.TextBox();
            this.label83 = new System.Windows.Forms.Label();
            this.textBox83 = new System.Windows.Forms.TextBox();
            this.groupBox22 = new System.Windows.Forms.GroupBox();
            this.textBox51 = new System.Windows.Forms.TextBox();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.label51 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.textBox94 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label94 = new System.Windows.Forms.Label();
            this.groupBox21 = new System.Windows.Forms.GroupBox();
            this.label109 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.pictureBox25 = new System.Windows.Forms.PictureBox();
            this.pictureBox24 = new System.Windows.Forms.PictureBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox19 = new System.Windows.Forms.GroupBox();
            this.textBox90 = new System.Windows.Forms.TextBox();
            this.label90 = new System.Windows.Forms.Label();
            this.textBox85 = new System.Windows.Forms.TextBox();
            this.label85 = new System.Windows.Forms.Label();
            this.textBox89 = new System.Windows.Forms.TextBox();
            this.label89 = new System.Windows.Forms.Label();
            this.textBox86 = new System.Windows.Forms.TextBox();
            this.label86 = new System.Windows.Forms.Label();
            this.textBox88 = new System.Windows.Forms.TextBox();
            this.label88 = new System.Windows.Forms.Label();
            this.textBox87 = new System.Windows.Forms.TextBox();
            this.label87 = new System.Windows.Forms.Label();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.comboBox26 = new System.Windows.Forms.ComboBox();
            this.comboBox25 = new System.Windows.Forms.ComboBox();
            this.comboBox24 = new System.Windows.Forms.ComboBox();
            this.label92 = new System.Windows.Forms.Label();
            this.textBox92 = new System.Windows.Forms.TextBox();
            this.label91 = new System.Windows.Forms.Label();
            this.textBox91 = new System.Windows.Forms.TextBox();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.label82 = new System.Windows.Forms.Label();
            this.textBox82 = new System.Windows.Forms.TextBox();
            this.label81 = new System.Windows.Forms.Label();
            this.textBox81 = new System.Windows.Forms.TextBox();
            this.label80 = new System.Windows.Forms.Label();
            this.textBox80 = new System.Windows.Forms.TextBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox50 = new System.Windows.Forms.TextBox();
            this.label50 = new System.Windows.Forms.Label();
            this.textBox48 = new System.Windows.Forms.TextBox();
            this.label48 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.textBox49 = new System.Windows.Forms.TextBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.textBox58 = new System.Windows.Forms.TextBox();
            this.label58 = new System.Windows.Forms.Label();
            this.textBox57 = new System.Windows.Forms.TextBox();
            this.label57 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label93 = new System.Windows.Forms.Label();
            this.textBox93 = new System.Windows.Forms.TextBox();
            this.label59 = new System.Windows.Forms.Label();
            this.textBox59 = new System.Windows.Forms.TextBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.textBox55 = new System.Windows.Forms.TextBox();
            this.label56 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.textBox54 = new System.Windows.Forms.TextBox();
            this.textBox56 = new System.Windows.Forms.TextBox();
            this.label54 = new System.Windows.Forms.Label();
            this.textBox53 = new System.Windows.Forms.TextBox();
            this.label53 = new System.Windows.Forms.Label();
            this.textBox52 = new System.Windows.Forms.TextBox();
            this.label52 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnPercent2Add = new System.Windows.Forms.Button();
            this.btnPercent1Add = new System.Windows.Forms.Button();
            this.btnPercentAdd = new System.Windows.Forms.Button();
            this.TbPercent2 = new System.Windows.Forms.TextBox();
            this.TbPercent1 = new System.Windows.Forms.TextBox();
            this.TbPercent = new System.Windows.Forms.TextBox();
            this.label108 = new System.Windows.Forms.Label();
            this.label107 = new System.Windows.Forms.Label();
            this.label106 = new System.Windows.Forms.Label();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CbSubType6 = new System.Windows.Forms.ComboBox();
            this.CbSubType5 = new System.Windows.Forms.ComboBox();
            this.CbSubType7 = new System.Windows.Forms.ComboBox();
            this.CbSubType4 = new System.Windows.Forms.ComboBox();
            this.CbSubtype3 = new System.Windows.Forms.ComboBox();
            this.CbSubtype2 = new System.Windows.Forms.ComboBox();
            this.CbSubtype1 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label47 = new System.Windows.Forms.Label();
            this.textBox46 = new System.Windows.Forms.TextBox();
            this.textBox47 = new System.Windows.Forms.TextBox();
            this.label46 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.textBox36 = new System.Windows.Forms.TextBox();
            this.textBox27 = new System.Windows.Forms.TextBox();
            this.textBox39 = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.textBox31 = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.textBox26 = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.textBox40 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.textBox28 = new System.Windows.Forms.TextBox();
            this.textBox33 = new System.Windows.Forms.TextBox();
            this.textBox38 = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.textBox34 = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.textBox41 = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.textBox29 = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.textBox25 = new System.Windows.Forms.TextBox();
            this.textBox32 = new System.Windows.Forms.TextBox();
            this.textBox37 = new System.Windows.Forms.TextBox();
            this.textBox35 = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.textBox30 = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.textBox24 = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.textBox45 = new System.Windows.Forms.TextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.textBox44 = new System.Windows.Forms.TextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.textBox43 = new System.Windows.Forms.TextBox();
            this.label43 = new System.Windows.Forms.Label();
            this.textBox42 = new System.Windows.Forms.TextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.comboBox23 = new System.Windows.Forms.ComboBox();
            this.comboBox22 = new System.Windows.Forms.ComboBox();
            this.comboBox21 = new System.Windows.Forms.ComboBox();
            this.comboBox20 = new System.Windows.Forms.ComboBox();
            this.comboBox19 = new System.Windows.Forms.ComboBox();
            this.comboBox18 = new System.Windows.Forms.ComboBox();
            this.comboBox17 = new System.Windows.Forms.ComboBox();
            this.comboBox16 = new System.Windows.Forms.ComboBox();
            this.comboBox15 = new System.Windows.Forms.ComboBox();
            this.comboBox14 = new System.Windows.Forms.ComboBox();
            this.label104 = new System.Windows.Forms.Label();
            this.comboBox13 = new System.Windows.Forms.ComboBox();
            this.label103 = new System.Windows.Forms.Label();
            this.label102 = new System.Windows.Forms.Label();
            this.label101 = new System.Windows.Forms.Label();
            this.label100 = new System.Windows.Forms.Label();
            this.comboBox12 = new System.Windows.Forms.ComboBox();
            this.comboBox11 = new System.Windows.Forms.ComboBox();
            this.comboBox10 = new System.Windows.Forms.ComboBox();
            this.comboBox9 = new System.Windows.Forms.ComboBox();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.label99 = new System.Windows.Forms.Label();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.label98 = new System.Windows.Forms.Label();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.label97 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label96 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label95 = new System.Windows.Forms.Label();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.pictureBox22 = new System.Windows.Forms.PictureBox();
            this.pictureBox21 = new System.Windows.Forms.PictureBox();
            this.pictureBox20 = new System.Windows.Forms.PictureBox();
            this.pictureBox19 = new System.Windows.Forms.PictureBox();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.textBox79 = new System.Windows.Forms.TextBox();
            this.label79 = new System.Windows.Forms.Label();
            this.textBox78 = new System.Windows.Forms.TextBox();
            this.label78 = new System.Windows.Forms.Label();
            this.textBox77 = new System.Windows.Forms.TextBox();
            this.label77 = new System.Windows.Forms.Label();
            this.textBox76 = new System.Windows.Forms.TextBox();
            this.label76 = new System.Windows.Forms.Label();
            this.textBox75 = new System.Windows.Forms.TextBox();
            this.label75 = new System.Windows.Forms.Label();
            this.textBox74 = new System.Windows.Forms.TextBox();
            this.label74 = new System.Windows.Forms.Label();
            this.textBox73 = new System.Windows.Forms.TextBox();
            this.label73 = new System.Windows.Forms.Label();
            this.textBox72 = new System.Windows.Forms.TextBox();
            this.label72 = new System.Windows.Forms.Label();
            this.textBox71 = new System.Windows.Forms.TextBox();
            this.label71 = new System.Windows.Forms.Label();
            this.textBox70 = new System.Windows.Forms.TextBox();
            this.label70 = new System.Windows.Forms.Label();
            this.textBox69 = new System.Windows.Forms.TextBox();
            this.label69 = new System.Windows.Forms.Label();
            this.textBox68 = new System.Windows.Forms.TextBox();
            this.label68 = new System.Windows.Forms.Label();
            this.textBox67 = new System.Windows.Forms.TextBox();
            this.label67 = new System.Windows.Forms.Label();
            this.textBox66 = new System.Windows.Forms.TextBox();
            this.label66 = new System.Windows.Forms.Label();
            this.textBox65 = new System.Windows.Forms.TextBox();
            this.label65 = new System.Windows.Forms.Label();
            this.textBox64 = new System.Windows.Forms.TextBox();
            this.label64 = new System.Windows.Forms.Label();
            this.textBox63 = new System.Windows.Forms.TextBox();
            this.label63 = new System.Windows.Forms.Label();
            this.textBox62 = new System.Windows.Forms.TextBox();
            this.label62 = new System.Windows.Forms.Label();
            this.textBox61 = new System.Windows.Forms.TextBox();
            this.label61 = new System.Windows.Forms.Label();
            this.textBox60 = new System.Windows.Forms.TextBox();
            this.label60 = new System.Windows.Forms.Label();
            this.clbFlagTest = new System.Windows.Forms.CheckedListBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox18 = new System.Windows.Forms.GroupBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label105 = new System.Windows.Forms.Label();
            this.textBox95 = new System.Windows.Forms.TextBox();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip5 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip6 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip7 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip8 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip9 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip10 = new System.Windows.Forms.ToolTip(this.components);
            this.button5 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lblLang = new System.Windows.Forms.Label();
            this.gbFortune = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox23.SuspendLayout();
            this.groupBox22.SuspendLayout();
            this.groupBox21.SuspendLayout();
            this.groupBox15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).BeginInit();
            this.groupBox19.SuspendLayout();
            this.groupBox16.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox11.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox8.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox17.SuspendLayout();
            this.groupBox13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            this.groupBox18.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.gbFortune.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowMerge = false;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileExportToolStripMenuItem,
            this.massEditToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1232, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileExportToolStripMenuItem
            // 
            this.fileExportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportlodToolStripMenuItem,
            this.exportStrItemlodToolStripMenuItem,
            this.exportSmclodToolStripMenuItem,
            this.exportToolStripMenuItem});
            this.fileExportToolStripMenuItem.Name = "fileExportToolStripMenuItem";
            this.fileExportToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.fileExportToolStripMenuItem.Text = "File Export";
            // 
            // exportlodToolStripMenuItem
            // 
            this.exportlodToolStripMenuItem.Name = "exportlodToolStripMenuItem";
            this.exportlodToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.exportlodToolStripMenuItem.Text = "Export itemAll.lod";
            this.exportlodToolStripMenuItem.Click += new System.EventHandler(this.exportlodToolStripMenuItem_Click);
            // 
            // exportStrItemlodToolStripMenuItem
            // 
            this.exportStrItemlodToolStripMenuItem.Name = "exportStrItemlodToolStripMenuItem";
            this.exportStrItemlodToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.exportStrItemlodToolStripMenuItem.Text = "Export strItem.lod";
            this.exportStrItemlodToolStripMenuItem.Click += new System.EventHandler(this.exportStrItemlodToolStripMenuItem_Click);
            // 
            // exportSmclodToolStripMenuItem
            // 
            this.exportSmclodToolStripMenuItem.Enabled = false;
            this.exportSmclodToolStripMenuItem.Name = "exportSmclodToolStripMenuItem";
            this.exportSmclodToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.exportSmclodToolStripMenuItem.Text = "Export smc.lod";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Enabled = false;
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.exportToolStripMenuItem.Text = "Export itemFortune.lod";
            // 
            // massEditToolStripMenuItem
            // 
            this.massEditToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.v,
            this.massUpdateSealsToolStripMenuItem});
            this.massEditToolStripMenuItem.Name = "massEditToolStripMenuItem";
            this.massEditToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.massEditToolStripMenuItem.Text = "MYSQL";
            // 
            // v
            // 
            this.v.Name = "v";
            this.v.Size = new System.Drawing.Size(171, 22);
            this.v.Text = "Mass Update";
            this.v.Click += new System.EventHandler(this.massEditToolStripMenuItem1_Click);
            // 
            // massUpdateSealsToolStripMenuItem
            // 
            this.massUpdateSealsToolStripMenuItem.Name = "massUpdateSealsToolStripMenuItem";
            this.massUpdateSealsToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.massUpdateSealsToolStripMenuItem.Text = "Mass Update Seals";
            this.massUpdateSealsToolStripMenuItem.Click += new System.EventHandler(this.massUpdateSealsToolStripMenuItem_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.listBox1);
            this.groupBox3.Location = new System.Drawing.Point(12, 168);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(265, 535);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Items";
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(91, 501);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(91, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "Copy to new";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(188, 501);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Delete Item";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(10, 501);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add Item";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(253, 459);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(283, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(947, 636);
            this.tabControl1.TabIndex = 33;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.groupBox12);
            this.tabPage1.Controls.Add(this.groupBox23);
            this.tabPage1.Controls.Add(this.groupBox22);
            this.tabPage1.Controls.Add(this.groupBox21);
            this.tabPage1.Controls.Add(this.groupBox15);
            this.tabPage1.Controls.Add(this.groupBox19);
            this.tabPage1.Controls.Add(this.groupBox16);
            this.tabPage1.Controls.Add(this.groupBox14);
            this.tabPage1.Controls.Add(this.groupBox9);
            this.tabPage1.Controls.Add(this.groupBox11);
            this.tabPage1.Controls.Add(this.groupBox6);
            this.tabPage1.Controls.Add(this.groupBox10);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(939, 610);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Basic";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.ClbItemFlag);
            this.groupBox12.Controls.Add(this.label9);
            this.groupBox12.Controls.Add(this.textBox8);
            this.groupBox12.Location = new System.Drawing.Point(620, 9);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(315, 597);
            this.groupBox12.TabIndex = 61;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "ItemFlag";
            // 
            // ClbItemFlag
            // 
            this.ClbItemFlag.BackColor = System.Drawing.SystemColors.Control;
            this.ClbItemFlag.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ClbItemFlag.CheckOnClick = true;
            this.ClbItemFlag.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClbItemFlag.FormattingEnabled = true;
            this.ClbItemFlag.IntegralHeight = false;
            this.ClbItemFlag.Location = new System.Drawing.Point(6, 20);
            this.ClbItemFlag.MultiColumn = true;
            this.ClbItemFlag.Name = "ClbItemFlag";
            this.ClbItemFlag.Size = new System.Drawing.Size(300, 539);
            this.ClbItemFlag.TabIndex = 0;
            this.ClbItemFlag.SelectedIndexChanged += new System.EventHandler(this.ClbItemFlag_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(40, 573);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "Flag:";
            // 
            // textBox8
            // 
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox8.Location = new System.Drawing.Point(88, 570);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(114, 20);
            this.textBox8.TabIndex = 14;
            this.textBox8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox8_KeyPress);
            // 
            // groupBox23
            // 
            this.groupBox23.Controls.Add(this.label84);
            this.groupBox23.Controls.Add(this.textBox84);
            this.groupBox23.Controls.Add(this.label83);
            this.groupBox23.Controls.Add(this.textBox83);
            this.groupBox23.Location = new System.Drawing.Point(325, 132);
            this.groupBox23.Name = "groupBox23";
            this.groupBox23.Size = new System.Drawing.Size(289, 41);
            this.groupBox23.TabIndex = 60;
            this.groupBox23.TabStop = false;
            this.groupBox23.Text = "Quest Trigger Info";
            // 
            // label84
            // 
            this.label84.AutoSize = true;
            this.label84.Location = new System.Drawing.Point(28, 21);
            this.label84.Name = "label84";
            this.label84.Size = new System.Drawing.Size(26, 13);
            this.label84.TabIndex = 54;
            this.label84.Text = "IDs:";
            // 
            // textBox84
            // 
            this.textBox84.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox84.Location = new System.Drawing.Point(60, 17);
            this.textBox84.Name = "textBox84";
            this.textBox84.Size = new System.Drawing.Size(68, 20);
            this.textBox84.TabIndex = 53;
            this.textBox84.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox84_KeyPress);
            // 
            // label83
            // 
            this.label83.AutoSize = true;
            this.label83.Location = new System.Drawing.Point(134, 19);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(38, 13);
            this.label83.TabIndex = 52;
            this.label83.Text = "Count:";
            // 
            // textBox83
            // 
            this.textBox83.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox83.Location = new System.Drawing.Point(178, 16);
            this.textBox83.Name = "textBox83";
            this.textBox83.Size = new System.Drawing.Size(68, 20);
            this.textBox83.TabIndex = 51;
            this.textBox83.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox83_KeyPress);
            // 
            // groupBox22
            // 
            this.groupBox22.Controls.Add(this.textBox51);
            this.groupBox22.Controls.Add(this.textBox21);
            this.groupBox22.Controls.Add(this.label51);
            this.groupBox22.Controls.Add(this.label21);
            this.groupBox22.Controls.Add(this.textBox20);
            this.groupBox22.Controls.Add(this.textBox94);
            this.groupBox22.Controls.Add(this.label20);
            this.groupBox22.Controls.Add(this.label94);
            this.groupBox22.Location = new System.Drawing.Point(328, 175);
            this.groupBox22.Name = "groupBox22";
            this.groupBox22.Size = new System.Drawing.Size(286, 68);
            this.groupBox22.TabIndex = 59;
            this.groupBox22.TabStop = false;
            this.groupBox22.Text = "Misc";
            // 
            // textBox51
            // 
            this.textBox51.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox51.Location = new System.Drawing.Point(162, 45);
            this.textBox51.Name = "textBox51";
            this.textBox51.Size = new System.Drawing.Size(44, 20);
            this.textBox51.TabIndex = 42;
            this.textBox51.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox51_KeyUp);
            // 
            // textBox21
            // 
            this.textBox21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox21.Location = new System.Drawing.Point(62, 43);
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(41, 20);
            this.textBox21.TabIndex = 34;
            this.textBox21.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox21_KeyPress);
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(122, 50);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(13, 13);
            this.label51.TabIndex = 43;
            this.label51.Text = "?";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(9, 48);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(57, 13);
            this.label21.TabIndex = 35;
            this.label21.Text = "Drop prob:";
            // 
            // textBox20
            // 
            this.textBox20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox20.Location = new System.Drawing.Point(161, 15);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(44, 20);
            this.textBox20.TabIndex = 33;
            this.textBox20.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox20_KeyPress);
            // 
            // textBox94
            // 
            this.textBox94.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox94.Location = new System.Drawing.Point(51, 17);
            this.textBox94.Name = "textBox94";
            this.textBox94.Size = new System.Drawing.Size(51, 20);
            this.textBox94.TabIndex = 55;
            this.textBox94.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox94_KeyPress);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(110, 17);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(49, 13);
            this.label20.TabIndex = 34;
            this.label20.Text = "MaxUse:";
            // 
            // label94
            // 
            this.label94.AutoSize = true;
            this.label94.Location = new System.Drawing.Point(11, 19);
            this.label94.Name = "label94";
            this.label94.Size = new System.Drawing.Size(39, 13);
            this.label94.TabIndex = 56;
            this.label94.Text = "Castle:";
            // 
            // groupBox21
            // 
            this.groupBox21.Controls.Add(this.label109);
            this.groupBox21.Controls.Add(this.checkedListBox1);
            this.groupBox21.Controls.Add(this.textBox7);
            this.groupBox21.Location = new System.Drawing.Point(478, 241);
            this.groupBox21.Name = "groupBox21";
            this.groupBox21.Size = new System.Drawing.Size(136, 209);
            this.groupBox21.TabIndex = 58;
            this.groupBox21.TabStop = false;
            this.groupBox21.Text = "Class";
            // 
            // label109
            // 
            this.label109.AutoSize = true;
            this.label109.Location = new System.Drawing.Point(7, 186);
            this.label109.Name = "label109";
            this.label109.Size = new System.Drawing.Size(34, 13);
            this.label109.TabIndex = 40;
            this.label109.Text = "Total:";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListBox1.BackColor = System.Drawing.SystemColors.Control;
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.ColumnWidth = 105;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.IntegralHeight = false;
            this.checkedListBox1.Location = new System.Drawing.Point(12, 12);
            this.checkedListBox1.MultiColumn = true;
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(101, 171);
            this.checkedListBox1.TabIndex = 39;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            this.checkedListBox1.SelectedValueChanged += new System.EventHandler(this.checkedListBox1_SelectedValueChanged);
            // 
            // textBox7
            // 
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox7.Location = new System.Drawing.Point(47, 184);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(55, 20);
            this.textBox7.TabIndex = 12;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.pictureBox25);
            this.groupBox15.Controls.Add(this.pictureBox24);
            this.groupBox15.Controls.Add(this.textBox18);
            this.groupBox15.Controls.Add(this.textBox19);
            this.groupBox15.Controls.Add(this.label19);
            this.groupBox15.Controls.Add(this.label18);
            this.groupBox15.Location = new System.Drawing.Point(227, 347);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(131, 110);
            this.groupBox15.TabIndex = 57;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "Stack and Price";
            // 
            // pictureBox25
            // 
            this.pictureBox25.BackgroundImage = global::DevPackMine.Properties.Resources.gold1;
            this.pictureBox25.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox25.Location = new System.Drawing.Point(41, 75);
            this.pictureBox25.Name = "pictureBox25";
            this.pictureBox25.Size = new System.Drawing.Size(20, 20);
            this.pictureBox25.TabIndex = 59;
            this.pictureBox25.TabStop = false;
            // 
            // pictureBox24
            // 
            this.pictureBox24.BackgroundImage = global::DevPackMine.Properties.Resources.stack;
            this.pictureBox24.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox24.Location = new System.Drawing.Point(41, 32);
            this.pictureBox24.Name = "pictureBox24";
            this.pictureBox24.Size = new System.Drawing.Size(20, 20);
            this.pictureBox24.TabIndex = 58;
            this.pictureBox24.TabStop = false;
            // 
            // textBox18
            // 
            this.textBox18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox18.Location = new System.Drawing.Point(63, 31);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(63, 20);
            this.textBox18.TabIndex = 29;
            this.textBox18.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox18_KeyPress);
            this.textBox18.MouseHover += new System.EventHandler(this.textBox18_MouseHover);
            // 
            // textBox19
            // 
            this.textBox19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox19.Location = new System.Drawing.Point(63, 75);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(63, 20);
            this.textBox19.TabIndex = 31;
            this.textBox19.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox19_KeyPress);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 77);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(34, 13);
            this.label19.TabIndex = 32;
            this.label19.Text = "Price:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(5, 33);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(38, 13);
            this.label18.TabIndex = 30;
            this.label18.Text = "Stack:";
            // 
            // groupBox19
            // 
            this.groupBox19.Controls.Add(this.textBox90);
            this.groupBox19.Controls.Add(this.label90);
            this.groupBox19.Controls.Add(this.textBox85);
            this.groupBox19.Controls.Add(this.label85);
            this.groupBox19.Controls.Add(this.textBox89);
            this.groupBox19.Controls.Add(this.label89);
            this.groupBox19.Controls.Add(this.textBox86);
            this.groupBox19.Controls.Add(this.label86);
            this.groupBox19.Controls.Add(this.textBox88);
            this.groupBox19.Controls.Add(this.label88);
            this.groupBox19.Controls.Add(this.textBox87);
            this.groupBox19.Controls.Add(this.label87);
            this.groupBox19.Location = new System.Drawing.Point(374, 350);
            this.groupBox19.Name = "groupBox19";
            this.groupBox19.Size = new System.Drawing.Size(104, 100);
            this.groupBox19.TabIndex = 54;
            this.groupBox19.TabStop = false;
            this.groupBox19.Text = "Reform Variation";
            // 
            // textBox90
            // 
            this.textBox90.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox90.Location = new System.Drawing.Point(71, 73);
            this.textBox90.Name = "textBox90";
            this.textBox90.Size = new System.Drawing.Size(19, 20);
            this.textBox90.TabIndex = 52;
            this.textBox90.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox90_KeyPress);
            this.textBox90.MouseHover += new System.EventHandler(this.textBox90_MouseHover);
            // 
            // label90
            // 
            this.label90.AutoSize = true;
            this.label90.Location = new System.Drawing.Point(51, 75);
            this.label90.Name = "label90";
            this.label90.Size = new System.Drawing.Size(13, 13);
            this.label90.TabIndex = 53;
            this.label90.Text = "6";
            // 
            // textBox85
            // 
            this.textBox85.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox85.Location = new System.Drawing.Point(24, 19);
            this.textBox85.Name = "textBox85";
            this.textBox85.Size = new System.Drawing.Size(19, 20);
            this.textBox85.TabIndex = 42;
            this.textBox85.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox85_KeyPress);
            this.textBox85.MouseHover += new System.EventHandler(this.textBox85_MouseHover);
            // 
            // label85
            // 
            this.label85.AutoSize = true;
            this.label85.Location = new System.Drawing.Point(5, 22);
            this.label85.Name = "label85";
            this.label85.Size = new System.Drawing.Size(13, 13);
            this.label85.TabIndex = 43;
            this.label85.Text = "1";
            // 
            // textBox89
            // 
            this.textBox89.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox89.Location = new System.Drawing.Point(71, 46);
            this.textBox89.Name = "textBox89";
            this.textBox89.Size = new System.Drawing.Size(19, 20);
            this.textBox89.TabIndex = 50;
            this.textBox89.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox89_KeyPress);
            this.textBox89.MouseHover += new System.EventHandler(this.textBox89_MouseHover);
            // 
            // label89
            // 
            this.label89.AutoSize = true;
            this.label89.Location = new System.Drawing.Point(51, 48);
            this.label89.Name = "label89";
            this.label89.Size = new System.Drawing.Size(13, 13);
            this.label89.TabIndex = 51;
            this.label89.Text = "5";
            // 
            // textBox86
            // 
            this.textBox86.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox86.Location = new System.Drawing.Point(24, 48);
            this.textBox86.Name = "textBox86";
            this.textBox86.Size = new System.Drawing.Size(19, 20);
            this.textBox86.TabIndex = 44;
            this.textBox86.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox86_KeyPress);
            this.textBox86.MouseHover += new System.EventHandler(this.textBox86_MouseHover);
            // 
            // label86
            // 
            this.label86.AutoSize = true;
            this.label86.Location = new System.Drawing.Point(5, 48);
            this.label86.Name = "label86";
            this.label86.Size = new System.Drawing.Size(13, 13);
            this.label86.TabIndex = 45;
            this.label86.Text = "2";
            // 
            // textBox88
            // 
            this.textBox88.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox88.Location = new System.Drawing.Point(71, 19);
            this.textBox88.Name = "textBox88";
            this.textBox88.Size = new System.Drawing.Size(19, 20);
            this.textBox88.TabIndex = 48;
            this.textBox88.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox88_KeyPress);
            this.textBox88.MouseHover += new System.EventHandler(this.textBox88_MouseHover);
            // 
            // label88
            // 
            this.label88.AutoSize = true;
            this.label88.Location = new System.Drawing.Point(52, 22);
            this.label88.Name = "label88";
            this.label88.Size = new System.Drawing.Size(13, 13);
            this.label88.TabIndex = 49;
            this.label88.Text = "4";
            // 
            // textBox87
            // 
            this.textBox87.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox87.Location = new System.Drawing.Point(24, 74);
            this.textBox87.Name = "textBox87";
            this.textBox87.Size = new System.Drawing.Size(19, 20);
            this.textBox87.TabIndex = 46;
            this.textBox87.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox87_KeyPress);
            this.textBox87.MouseHover += new System.EventHandler(this.textBox87_MouseHover);
            // 
            // label87
            // 
            this.label87.AutoSize = true;
            this.label87.Location = new System.Drawing.Point(5, 75);
            this.label87.Name = "label87";
            this.label87.Size = new System.Drawing.Size(13, 13);
            this.label87.TabIndex = 47;
            this.label87.Text = "3";
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.comboBox26);
            this.groupBox16.Controls.Add(this.comboBox25);
            this.groupBox16.Controls.Add(this.comboBox24);
            this.groupBox16.Controls.Add(this.label92);
            this.groupBox16.Controls.Add(this.textBox92);
            this.groupBox16.Controls.Add(this.label91);
            this.groupBox16.Controls.Add(this.textBox91);
            this.groupBox16.Location = new System.Drawing.Point(8, 350);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(209, 74);
            this.groupBox16.TabIndex = 53;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "RvR";
            // 
            // comboBox26
            // 
            this.comboBox26.FormattingEnabled = true;
            this.comboBox26.Location = new System.Drawing.Point(55, 45);
            this.comboBox26.Name = "comboBox26";
            this.comboBox26.Size = new System.Drawing.Size(102, 21);
            this.comboBox26.TabIndex = 61;
            this.comboBox26.SelectedIndexChanged += new System.EventHandler(this.comboBox26_SelectedIndexChanged);
            this.comboBox26.SelectionChangeCommitted += new System.EventHandler(this.comboBox26_SelectionChangeCommitted);
            // 
            // comboBox25
            // 
            this.comboBox25.FormattingEnabled = true;
            this.comboBox25.Location = new System.Drawing.Point(55, 45);
            this.comboBox25.Name = "comboBox25";
            this.comboBox25.Size = new System.Drawing.Size(102, 21);
            this.comboBox25.TabIndex = 60;
            this.comboBox25.SelectedIndexChanged += new System.EventHandler(this.comboBox25_SelectedIndexChanged_1);
            this.comboBox25.SelectionChangeCommitted += new System.EventHandler(this.comboBox25_SelectionChangeCommitted);
            // 
            // comboBox24
            // 
            this.comboBox24.FormattingEnabled = true;
            this.comboBox24.Location = new System.Drawing.Point(55, 17);
            this.comboBox24.Name = "comboBox24";
            this.comboBox24.Size = new System.Drawing.Size(102, 21);
            this.comboBox24.TabIndex = 59;
            this.comboBox24.SelectedIndexChanged += new System.EventHandler(this.comboBox24_SelectedIndexChanged_1);
            this.comboBox24.SelectionChangeCommitted += new System.EventHandler(this.comboBox24_SelectionChangeCommitted);
            // 
            // label92
            // 
            this.label92.AutoSize = true;
            this.label92.Location = new System.Drawing.Point(13, 48);
            this.label92.Name = "label92";
            this.label92.Size = new System.Drawing.Size(39, 13);
            this.label92.TabIndex = 58;
            this.label92.Text = "Grade:";
            // 
            // textBox92
            // 
            this.textBox92.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox92.Location = new System.Drawing.Point(172, 45);
            this.textBox92.Name = "textBox92";
            this.textBox92.Size = new System.Drawing.Size(31, 20);
            this.textBox92.TabIndex = 57;
            this.textBox92.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox92_KeyPress);
            // 
            // label91
            // 
            this.label91.AutoSize = true;
            this.label91.Location = new System.Drawing.Point(13, 19);
            this.label91.Name = "label91";
            this.label91.Size = new System.Drawing.Size(37, 13);
            this.label91.TabIndex = 56;
            this.label91.Text = "Value:";
            // 
            // textBox91
            // 
            this.textBox91.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox91.Location = new System.Drawing.Point(172, 17);
            this.textBox91.Name = "textBox91";
            this.textBox91.Size = new System.Drawing.Size(31, 20);
            this.textBox91.TabIndex = 55;
            this.textBox91.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox91_KeyPress);
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.label82);
            this.groupBox14.Controls.Add(this.textBox82);
            this.groupBox14.Controls.Add(this.label81);
            this.groupBox14.Controls.Add(this.textBox81);
            this.groupBox14.Controls.Add(this.label80);
            this.groupBox14.Controls.Add(this.textBox80);
            this.groupBox14.Location = new System.Drawing.Point(227, 241);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(249, 100);
            this.groupBox14.TabIndex = 52;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Item Special Effects";
            // 
            // label82
            // 
            this.label82.AutoSize = true;
            this.label82.Location = new System.Drawing.Point(7, 76);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(50, 13);
            this.label82.TabIndex = 58;
            this.label82.Text = "Damage:";
            // 
            // textBox82
            // 
            this.textBox82.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox82.Location = new System.Drawing.Point(67, 74);
            this.textBox82.Name = "textBox82";
            this.textBox82.Size = new System.Drawing.Size(178, 20);
            this.textBox82.TabIndex = 57;
            this.textBox82.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox82_KeyPress);
            // 
            // label81
            // 
            this.label81.AutoSize = true;
            this.label81.Location = new System.Drawing.Point(14, 50);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(41, 13);
            this.label81.TabIndex = 56;
            this.label81.Text = "Attack:";
            // 
            // textBox81
            // 
            this.textBox81.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox81.Location = new System.Drawing.Point(67, 46);
            this.textBox81.Name = "textBox81";
            this.textBox81.Size = new System.Drawing.Size(178, 20);
            this.textBox81.TabIndex = 55;
            this.textBox81.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox81_KeyPress);
            // 
            // label80
            // 
            this.label80.AutoSize = true;
            this.label80.Location = new System.Drawing.Point(14, 23);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(43, 13);
            this.label80.TabIndex = 54;
            this.label80.Text = "Normal:";
            // 
            // textBox80
            // 
            this.textBox80.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox80.Location = new System.Drawing.Point(67, 19);
            this.textBox80.Name = "textBox80";
            this.textBox80.Size = new System.Drawing.Size(178, 20);
            this.textBox80.TabIndex = 53;
            this.textBox80.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox80_KeyPress);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.linkLabel1);
            this.groupBox9.Controls.Add(this.pictureBox1);
            this.groupBox9.Controls.Add(this.textBox50);
            this.groupBox9.Controls.Add(this.label50);
            this.groupBox9.Controls.Add(this.textBox48);
            this.groupBox9.Controls.Add(this.label48);
            this.groupBox9.Controls.Add(this.label49);
            this.groupBox9.Controls.Add(this.textBox49);
            this.groupBox9.Location = new System.Drawing.Point(14, 430);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(201, 100);
            this.groupBox9.TabIndex = 40;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Icon";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Blue;
            this.linkLabel1.Location = new System.Drawing.Point(117, 75);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(61, 13);
            this.linkLabel1.TabIndex = 96;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Icon Picker";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Location = new System.Drawing.Point(127, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 95;
            this.pictureBox1.TabStop = false;
            // 
            // textBox50
            // 
            this.textBox50.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox50.Location = new System.Drawing.Point(59, 74);
            this.textBox50.Name = "textBox50";
            this.textBox50.Size = new System.Drawing.Size(37, 20);
            this.textBox50.TabIndex = 38;
            this.textBox50.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox50_KeyPress);
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(11, 76);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(25, 13);
            this.label50.TabIndex = 39;
            this.label50.Text = "Col:";
            // 
            // textBox48
            // 
            this.textBox48.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox48.Location = new System.Drawing.Point(59, 20);
            this.textBox48.Name = "textBox48";
            this.textBox48.Size = new System.Drawing.Size(37, 20);
            this.textBox48.TabIndex = 34;
            this.textBox48.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox48_KeyPress);
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(11, 22);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(21, 13);
            this.label48.TabIndex = 35;
            this.label48.Text = "ID:";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(11, 48);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(32, 13);
            this.label49.TabIndex = 37;
            this.label49.Text = "Row:";
            // 
            // textBox49
            // 
            this.textBox49.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox49.Location = new System.Drawing.Point(59, 46);
            this.textBox49.Name = "textBox49";
            this.textBox49.Size = new System.Drawing.Size(37, 20);
            this.textBox49.TabIndex = 36;
            this.textBox49.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox49_KeyPress);
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.textBox58);
            this.groupBox11.Controls.Add(this.label58);
            this.groupBox11.Controls.Add(this.textBox57);
            this.groupBox11.Controls.Add(this.label57);
            this.groupBox11.Location = new System.Drawing.Point(6, 536);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(209, 66);
            this.groupBox11.TabIndex = 48;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Common RareOption";
            // 
            // textBox58
            // 
            this.textBox58.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox58.Location = new System.Drawing.Point(148, 28);
            this.textBox58.Name = "textBox58";
            this.textBox58.Size = new System.Drawing.Size(53, 20);
            this.textBox58.TabIndex = 49;
            this.textBox58.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox58_KeyPress);
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(105, 32);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(33, 13);
            this.label58.TabIndex = 50;
            this.label58.Text = "Rate:";
            // 
            // textBox57
            // 
            this.textBox57.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox57.Location = new System.Drawing.Point(43, 30);
            this.textBox57.Name = "textBox57";
            this.textBox57.Size = new System.Drawing.Size(53, 20);
            this.textBox57.TabIndex = 46;
            this.textBox57.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox57_KeyPress);
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(6, 32);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(21, 13);
            this.label57.TabIndex = 47;
            this.label57.Text = "ID:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.textBox16);
            this.groupBox6.Controls.Add(this.label16);
            this.groupBox6.Controls.Add(this.textBox17);
            this.groupBox6.Controls.Add(this.label17);
            this.groupBox6.Controls.Add(this.label93);
            this.groupBox6.Controls.Add(this.textBox93);
            this.groupBox6.Controls.Add(this.label59);
            this.groupBox6.Controls.Add(this.textBox59);
            this.groupBox6.Location = new System.Drawing.Point(2, 242);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(213, 99);
            this.groupBox6.TabIndex = 33;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Min And Max Level";
            // 
            // textBox16
            // 
            this.textBox16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox16.Location = new System.Drawing.Point(40, 25);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(50, 20);
            this.textBox16.TabIndex = 25;
            this.textBox16.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox16_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(5, 28);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(27, 13);
            this.label16.TabIndex = 26;
            this.label16.Text = "Min:";
            // 
            // textBox17
            // 
            this.textBox17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox17.Location = new System.Drawing.Point(147, 24);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(46, 20);
            this.textBox17.TabIndex = 27;
            this.textBox17.TextChanged += new System.EventHandler(this.textBox17_TextChanged);
            this.textBox17.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox17_KeyPress);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(104, 27);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(30, 13);
            this.label17.TabIndex = 28;
            this.label17.Text = "Max:";
            // 
            // label93
            // 
            this.label93.AutoSize = true;
            this.label93.Location = new System.Drawing.Point(5, 68);
            this.label93.Name = "label93";
            this.label93.Size = new System.Drawing.Size(33, 13);
            this.label93.TabIndex = 60;
            this.label93.Text = "Dura:";
            // 
            // textBox93
            // 
            this.textBox93.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox93.Location = new System.Drawing.Point(40, 65);
            this.textBox93.Name = "textBox93";
            this.textBox93.Size = new System.Drawing.Size(51, 20);
            this.textBox93.TabIndex = 59;
            this.textBox93.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox93_KeyPress);
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(107, 66);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(36, 13);
            this.label59.TabIndex = 50;
            this.label59.Text = "Fame:";
            // 
            // textBox59
            // 
            this.textBox59.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox59.Location = new System.Drawing.Point(147, 66);
            this.textBox59.Name = "textBox59";
            this.textBox59.Size = new System.Drawing.Size(45, 20);
            this.textBox59.TabIndex = 49;
            this.textBox59.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox59_KeyUp);
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.textBox55);
            this.groupBox10.Controls.Add(this.label56);
            this.groupBox10.Controls.Add(this.label55);
            this.groupBox10.Controls.Add(this.textBox54);
            this.groupBox10.Controls.Add(this.textBox56);
            this.groupBox10.Controls.Add(this.label54);
            this.groupBox10.Controls.Add(this.textBox53);
            this.groupBox10.Controls.Add(this.label53);
            this.groupBox10.Controls.Add(this.textBox52);
            this.groupBox10.Controls.Add(this.label52);
            this.groupBox10.Location = new System.Drawing.Point(495, 456);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(119, 146);
            this.groupBox10.TabIndex = 41;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Random Settings";
            // 
            // textBox55
            // 
            this.textBox55.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox55.Location = new System.Drawing.Point(56, 97);
            this.textBox55.Name = "textBox55";
            this.textBox55.Size = new System.Drawing.Size(53, 20);
            this.textBox55.TabIndex = 50;
            this.textBox55.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox55_KeyPress);
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(10, 125);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(32, 13);
            this.label56.TabIndex = 45;
            this.label56.Text = "Set4:";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(10, 99);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(32, 13);
            this.label55.TabIndex = 51;
            this.label55.Text = "Set3:";
            // 
            // textBox54
            // 
            this.textBox54.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox54.Location = new System.Drawing.Point(56, 71);
            this.textBox54.Name = "textBox54";
            this.textBox54.Size = new System.Drawing.Size(53, 20);
            this.textBox54.TabIndex = 48;
            this.textBox54.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox54_KeyPress);
            // 
            // textBox56
            // 
            this.textBox56.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox56.Location = new System.Drawing.Point(56, 123);
            this.textBox56.Name = "textBox56";
            this.textBox56.Size = new System.Drawing.Size(53, 20);
            this.textBox56.TabIndex = 44;
            this.textBox56.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox56_KeyPress);
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(10, 73);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(32, 13);
            this.label54.TabIndex = 49;
            this.label54.Text = "Set2:";
            // 
            // textBox53
            // 
            this.textBox53.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox53.Location = new System.Drawing.Point(56, 45);
            this.textBox53.Name = "textBox53";
            this.textBox53.Size = new System.Drawing.Size(53, 20);
            this.textBox53.TabIndex = 46;
            this.textBox53.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox53_KeyPress);
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(10, 47);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(32, 13);
            this.label53.TabIndex = 47;
            this.label53.Text = "Set1:";
            // 
            // textBox52
            // 
            this.textBox52.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox52.Location = new System.Drawing.Point(56, 19);
            this.textBox52.Name = "textBox52";
            this.textBox52.Size = new System.Drawing.Size(53, 20);
            this.textBox52.TabIndex = 44;
            this.textBox52.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox52_KeyPress);
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(10, 21);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(32, 13);
            this.label52.TabIndex = 45;
            this.label52.Text = "Set0:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnPercent2Add);
            this.groupBox4.Controls.Add(this.btnPercent1Add);
            this.groupBox4.Controls.Add(this.btnPercentAdd);
            this.groupBox4.Controls.Add(this.TbPercent2);
            this.groupBox4.Controls.Add(this.TbPercent1);
            this.groupBox4.Controls.Add(this.TbPercent);
            this.groupBox4.Controls.Add(this.label108);
            this.groupBox4.Controls.Add(this.label107);
            this.groupBox4.Controls.Add(this.label106);
            this.groupBox4.Controls.Add(this.textBox15);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.textBox10);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.textBox11);
            this.groupBox4.Controls.Add(this.textBox14);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.textBox13);
            this.groupBox4.Location = new System.Drawing.Point(227, 456);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(255, 146);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Options";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // btnPercent2Add
            // 
            this.btnPercent2Add.Location = new System.Drawing.Point(131, 73);
            this.btnPercent2Add.Name = "btnPercent2Add";
            this.btnPercent2Add.Size = new System.Drawing.Size(19, 20);
            this.btnPercent2Add.TabIndex = 32;
            this.btnPercent2Add.Text = "+";
            this.toolTip1.SetToolTip(this.btnPercent2Add, "Add Percent");
            this.btnPercent2Add.UseVisualStyleBackColor = true;
            this.btnPercent2Add.Click += new System.EventHandler(this.btnPercent2Add_Click);
            // 
            // btnPercent1Add
            // 
            this.btnPercent1Add.Location = new System.Drawing.Point(131, 47);
            this.btnPercent1Add.Name = "btnPercent1Add";
            this.btnPercent1Add.Size = new System.Drawing.Size(19, 20);
            this.btnPercent1Add.TabIndex = 31;
            this.btnPercent1Add.Text = "+";
            this.toolTip1.SetToolTip(this.btnPercent1Add, "Add Percent");
            this.btnPercent1Add.UseVisualStyleBackColor = true;
            this.btnPercent1Add.Click += new System.EventHandler(this.btnPercent1Add_Click);
            // 
            // btnPercentAdd
            // 
            this.btnPercentAdd.Location = new System.Drawing.Point(131, 19);
            this.btnPercentAdd.Name = "btnPercentAdd";
            this.btnPercentAdd.Size = new System.Drawing.Size(19, 20);
            this.btnPercentAdd.TabIndex = 30;
            this.btnPercentAdd.Text = "+";
            this.toolTip1.SetToolTip(this.btnPercentAdd, "Add Percent");
            this.btnPercentAdd.UseVisualStyleBackColor = true;
            this.btnPercentAdd.Click += new System.EventHandler(this.btnPercentAdd_Click);
            // 
            // TbPercent2
            // 
            this.TbPercent2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbPercent2.Location = new System.Drawing.Point(157, 72);
            this.TbPercent2.Name = "TbPercent2";
            this.TbPercent2.Size = new System.Drawing.Size(53, 20);
            this.TbPercent2.TabIndex = 29;
            // 
            // TbPercent1
            // 
            this.TbPercent1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbPercent1.Location = new System.Drawing.Point(157, 46);
            this.TbPercent1.Name = "TbPercent1";
            this.TbPercent1.Size = new System.Drawing.Size(53, 20);
            this.TbPercent1.TabIndex = 28;
            // 
            // TbPercent
            // 
            this.TbPercent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbPercent.Location = new System.Drawing.Point(157, 20);
            this.TbPercent.Name = "TbPercent";
            this.TbPercent.Size = new System.Drawing.Size(53, 20);
            this.TbPercent.TabIndex = 27;
            // 
            // label108
            // 
            this.label108.AutoSize = true;
            this.label108.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label108.Location = new System.Drawing.Point(218, 75);
            this.label108.Name = "label108";
            this.label108.Size = new System.Drawing.Size(14, 15);
            this.label108.TabIndex = 26;
            this.label108.Text = "%";
            // 
            // label107
            // 
            this.label107.AutoSize = true;
            this.label107.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label107.Location = new System.Drawing.Point(217, 49);
            this.label107.Name = "label107";
            this.label107.Size = new System.Drawing.Size(14, 15);
            this.label107.TabIndex = 25;
            this.label107.Text = "%";
            // 
            // label106
            // 
            this.label106.AutoSize = true;
            this.label106.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label106.Location = new System.Drawing.Point(216, 22);
            this.label106.Name = "label106";
            this.label106.Size = new System.Drawing.Size(14, 15);
            this.label106.TabIndex = 24;
            this.label106.Text = "%";
            // 
            // textBox15
            // 
            this.textBox15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox15.Location = new System.Drawing.Point(65, 124);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(53, 20);
            this.textBox15.TabIndex = 22;
            this.textBox15.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox15_KeyPress);
            this.textBox15.MouseHover += new System.EventHandler(this.textBox15_MouseHover);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 126);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 13);
            this.label15.TabIndex = 23;
            this.label15.Text = "Num4:";
            // 
            // textBox10
            // 
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox10.Location = new System.Drawing.Point(65, 20);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(53, 20);
            this.textBox10.TabIndex = 14;
            this.textBox10.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox10_KeyPress);
            this.textBox10.MouseHover += new System.EventHandler(this.textBox10_MouseHover);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Num0:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 100);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 13);
            this.label14.TabIndex = 21;
            this.label14.Text = "Num3:";
            // 
            // textBox11
            // 
            this.textBox11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox11.Location = new System.Drawing.Point(65, 46);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(53, 20);
            this.textBox11.TabIndex = 16;
            this.textBox11.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox11_KeyPress);
            this.textBox11.MouseHover += new System.EventHandler(this.textBox11_MouseHover);
            // 
            // textBox14
            // 
            this.textBox14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox14.Location = new System.Drawing.Point(65, 98);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(53, 20);
            this.textBox14.TabIndex = 20;
            this.textBox14.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox14_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Num1:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 74);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "Num2:";
            // 
            // textBox13
            // 
            this.textBox13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox13.Location = new System.Drawing.Point(65, 72);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(53, 20);
            this.textBox13.TabIndex = 18;
            this.textBox13.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox13_KeyPress);
            this.textBox13.MouseHover += new System.EventHandler(this.textBox13_MouseHover);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CbSubType6);
            this.groupBox2.Controls.Add(this.CbSubType5);
            this.groupBox2.Controls.Add(this.CbSubType7);
            this.groupBox2.Controls.Add(this.CbSubType4);
            this.groupBox2.Controls.Add(this.CbSubtype3);
            this.groupBox2.Controls.Add(this.CbSubtype2);
            this.groupBox2.Controls.Add(this.CbSubtype1);
            this.groupBox2.Controls.Add(this.comboBox4);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox9);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(323, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(291, 120);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Character";
            // 
            // CbSubType6
            // 
            this.CbSubType6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CbSubType6.FormattingEnabled = true;
            this.CbSubType6.Location = new System.Drawing.Point(70, 54);
            this.CbSubType6.Name = "CbSubType6";
            this.CbSubType6.Size = new System.Drawing.Size(173, 21);
            this.CbSubType6.TabIndex = 48;
            this.CbSubType6.SelectedIndexChanged += new System.EventHandler(this.CbSubType6_SelectedIndexChanged);
            this.CbSubType6.SelectionChangeCommitted += new System.EventHandler(this.CbSubType6_SelectionChangeCommitted);
            // 
            // CbSubType5
            // 
            this.CbSubType5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CbSubType5.FormattingEnabled = true;
            this.CbSubType5.Location = new System.Drawing.Point(70, 54);
            this.CbSubType5.Name = "CbSubType5";
            this.CbSubType5.Size = new System.Drawing.Size(173, 21);
            this.CbSubType5.TabIndex = 47;
            this.CbSubType5.SelectedIndexChanged += new System.EventHandler(this.CbSubType5_SelectedIndexChanged);
            this.CbSubType5.SelectionChangeCommitted += new System.EventHandler(this.CbSubType5_SelectionChangeCommitted);
            // 
            // CbSubType7
            // 
            this.CbSubType7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CbSubType7.FormattingEnabled = true;
            this.CbSubType7.Location = new System.Drawing.Point(70, 54);
            this.CbSubType7.Name = "CbSubType7";
            this.CbSubType7.Size = new System.Drawing.Size(173, 21);
            this.CbSubType7.TabIndex = 46;
            this.CbSubType7.SelectedIndexChanged += new System.EventHandler(this.CbSubType7_SelectedIndexChanged);
            this.CbSubType7.SelectionChangeCommitted += new System.EventHandler(this.CbSubType7_SelectionChangeCommitted);
            // 
            // CbSubType4
            // 
            this.CbSubType4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CbSubType4.FormattingEnabled = true;
            this.CbSubType4.Location = new System.Drawing.Point(70, 54);
            this.CbSubType4.Name = "CbSubType4";
            this.CbSubType4.Size = new System.Drawing.Size(173, 21);
            this.CbSubType4.TabIndex = 45;
            this.CbSubType4.SelectedIndexChanged += new System.EventHandler(this.CbSubType4_SelectedIndexChanged);
            this.CbSubType4.SelectionChangeCommitted += new System.EventHandler(this.CbSubType4_SelectionChangeCommitted);
            // 
            // CbSubtype3
            // 
            this.CbSubtype3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CbSubtype3.FormattingEnabled = true;
            this.CbSubtype3.Location = new System.Drawing.Point(70, 54);
            this.CbSubtype3.Name = "CbSubtype3";
            this.CbSubtype3.Size = new System.Drawing.Size(173, 21);
            this.CbSubtype3.TabIndex = 44;
            this.CbSubtype3.SelectedIndexChanged += new System.EventHandler(this.CbSubtype3_SelectedIndexChanged);
            this.CbSubtype3.SelectionChangeCommitted += new System.EventHandler(this.CbSubtype3_SelectionChangeCommitted);
            // 
            // CbSubtype2
            // 
            this.CbSubtype2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CbSubtype2.FormattingEnabled = true;
            this.CbSubtype2.Location = new System.Drawing.Point(70, 54);
            this.CbSubtype2.Name = "CbSubtype2";
            this.CbSubtype2.Size = new System.Drawing.Size(173, 21);
            this.CbSubtype2.TabIndex = 43;
            this.CbSubtype2.SelectedIndexChanged += new System.EventHandler(this.CbSubtype2_SelectedIndexChanged);
            this.CbSubtype2.SelectionChangeCommitted += new System.EventHandler(this.CbSubtype2_SelectionChangeCommitted);
            // 
            // CbSubtype1
            // 
            this.CbSubtype1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CbSubtype1.FormattingEnabled = true;
            this.CbSubtype1.Location = new System.Drawing.Point(70, 54);
            this.CbSubtype1.Name = "CbSubtype1";
            this.CbSubtype1.Size = new System.Drawing.Size(173, 21);
            this.CbSubtype1.TabIndex = 42;
            this.CbSubtype1.SelectedIndexChanged += new System.EventHandler(this.CbSubtype1_SelectedIndexChanged);
            this.CbSubtype1.SelectionChangeCommitted += new System.EventHandler(this.CbSubtype1_SelectionChangeCommitted);
            // 
            // comboBox4
            // 
            this.comboBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(70, 86);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(173, 21);
            this.comboBox4.TabIndex = 38;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            this.comboBox4.SelectionChangeCommitted += new System.EventHandler(this.comboBox4_SelectionChangeCommitted);
            // 
            // comboBox2
            // 
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(70, 54);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(173, 21);
            this.comboBox2.TabIndex = 36;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            this.comboBox2.SelectionChangeCommitted += new System.EventHandler(this.comboBox2_SelectionChangeCommitted);
            // 
            // comboBox1
            // 
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(70, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(173, 21);
            this.comboBox1.TabIndex = 35;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Wearing:";
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(255, 22);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(30, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox9
            // 
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox9.Location = new System.Drawing.Point(255, 87);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(30, 20);
            this.textBox9.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "SubType:";
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Location = new System.Drawing.Point(255, 56);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(30, 20);
            this.textBox3.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Type:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.label47);
            this.groupBox1.Controls.Add(this.textBox46);
            this.groupBox1.Controls.Add(this.textBox47);
            this.groupBox1.Controls.Add(this.label46);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 229);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Basic";
            // 
            // pictureBox2
            // 
            //this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(286, 198);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(16, 20);
            this.pictureBox2.TabIndex = 36;
            this.pictureBox2.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox2, "View SMC info");
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseClick);
            // 
            // checkBox1
            // 
            this.checkBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Location = new System.Drawing.Point(14, 18);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(296, 17);
            this.checkBox1.TabIndex = 35;
            this.checkBox1.Text = "Enable";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(11, 200);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(33, 13);
            this.label47.TabIndex = 35;
            this.label47.Text = "SMC:";
            // 
            // textBox46
            // 
            this.textBox46.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox46.Location = new System.Drawing.Point(238, 39);
            this.textBox46.Name = "textBox46";
            this.textBox46.Size = new System.Drawing.Size(48, 20);
            this.textBox46.TabIndex = 34;
            this.textBox46.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox46_KeyPress);
            // 
            // textBox47
            // 
            this.textBox47.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox47.Location = new System.Drawing.Point(55, 198);
            this.textBox47.Name = "textBox47";
            this.textBox47.Size = new System.Drawing.Size(231, 20);
            this.textBox47.TabIndex = 34;
            this.textBox47.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox47_KeyPress);
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(175, 41);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(55, 13);
            this.label46.TabIndex = 35;
            this.label46.Text = "ZoneFlag:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Desc:";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(55, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(63, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Index:";
            // 
            // textBox5
            // 
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox5.Location = new System.Drawing.Point(55, 65);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(231, 20);
            this.textBox5.TabIndex = 5;
            this.textBox5.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox5_KeyDown);
            // 
            // textBox6
            // 
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox6.Location = new System.Drawing.Point(56, 91);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(230, 101);
            this.textBox6.TabIndex = 6;
            this.textBox6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox6_KeyPress);
            // 
            // tabPage2
            // 
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Controls.Add(this.groupBox7);
            this.tabPage2.Controls.Add(this.groupBox8);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(939, 610);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Crafting";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.pictureBox12);
            this.groupBox7.Controls.Add(this.pictureBox11);
            this.groupBox7.Controls.Add(this.pictureBox10);
            this.groupBox7.Controls.Add(this.pictureBox9);
            this.groupBox7.Controls.Add(this.pictureBox8);
            this.groupBox7.Controls.Add(this.pictureBox7);
            this.groupBox7.Controls.Add(this.pictureBox6);
            this.groupBox7.Controls.Add(this.pictureBox5);
            this.groupBox7.Controls.Add(this.pictureBox4);
            this.groupBox7.Controls.Add(this.pictureBox3);
            this.groupBox7.Controls.Add(this.textBox36);
            this.groupBox7.Controls.Add(this.textBox27);
            this.groupBox7.Controls.Add(this.textBox39);
            this.groupBox7.Controls.Add(this.label40);
            this.groupBox7.Controls.Add(this.textBox31);
            this.groupBox7.Controls.Add(this.label28);
            this.groupBox7.Controls.Add(this.textBox26);
            this.groupBox7.Controls.Add(this.label27);
            this.groupBox7.Controls.Add(this.label39);
            this.groupBox7.Controls.Add(this.label34);
            this.groupBox7.Controls.Add(this.textBox40);
            this.groupBox7.Controls.Add(this.label22);
            this.groupBox7.Controls.Add(this.textBox28);
            this.groupBox7.Controls.Add(this.textBox33);
            this.groupBox7.Controls.Add(this.textBox38);
            this.groupBox7.Controls.Add(this.label41);
            this.groupBox7.Controls.Add(this.textBox34);
            this.groupBox7.Controls.Add(this.label29);
            this.groupBox7.Controls.Add(this.textBox22);
            this.groupBox7.Controls.Add(this.label26);
            this.groupBox7.Controls.Add(this.label33);
            this.groupBox7.Controls.Add(this.label38);
            this.groupBox7.Controls.Add(this.textBox41);
            this.groupBox7.Controls.Add(this.label35);
            this.groupBox7.Controls.Add(this.textBox29);
            this.groupBox7.Controls.Add(this.label23);
            this.groupBox7.Controls.Add(this.textBox25);
            this.groupBox7.Controls.Add(this.textBox32);
            this.groupBox7.Controls.Add(this.textBox37);
            this.groupBox7.Controls.Add(this.textBox35);
            this.groupBox7.Controls.Add(this.label30);
            this.groupBox7.Controls.Add(this.textBox23);
            this.groupBox7.Controls.Add(this.label25);
            this.groupBox7.Controls.Add(this.label32);
            this.groupBox7.Controls.Add(this.label37);
            this.groupBox7.Controls.Add(this.label36);
            this.groupBox7.Controls.Add(this.textBox30);
            this.groupBox7.Controls.Add(this.label24);
            this.groupBox7.Controls.Add(this.textBox24);
            this.groupBox7.Controls.Add(this.label31);
            this.groupBox7.Location = new System.Drawing.Point(6, 90);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(733, 176);
            this.groupBox7.TabIndex = 41;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Item Crafting";
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox12.Location = new System.Drawing.Point(447, 129);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(22, 22);
            this.pictureBox12.TabIndex = 94;
            this.pictureBox12.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox12, "Search Item");
            this.pictureBox12.Click += new System.EventHandler(this.pictureBox12_Click);
            this.pictureBox12.MouseLeave += new System.EventHandler(this.pictureBox12_MouseLeave);
            this.pictureBox12.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox12_MouseMove);
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox11.Location = new System.Drawing.Point(447, 103);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(22, 22);
            this.pictureBox11.TabIndex = 93;
            this.pictureBox11.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox11, "Search Item");
            this.pictureBox11.Click += new System.EventHandler(this.pictureBox11_Click);
            this.pictureBox11.MouseLeave += new System.EventHandler(this.pictureBox11_MouseLeave);
            this.pictureBox11.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox11_MouseMove);
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox10.Location = new System.Drawing.Point(447, 77);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(22, 22);
            this.pictureBox10.TabIndex = 92;
            this.pictureBox10.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox10, "Search Item");
            this.pictureBox10.Click += new System.EventHandler(this.pictureBox10_Click);
            this.pictureBox10.MouseLeave += new System.EventHandler(this.pictureBox10_MouseLeave);
            this.pictureBox10.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox10_MouseMove);
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox9.Location = new System.Drawing.Point(447, 51);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(22, 22);
            this.pictureBox9.TabIndex = 91;
            this.pictureBox9.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox9, "Search Item");
            this.pictureBox9.Click += new System.EventHandler(this.pictureBox9_Click);
            this.pictureBox9.MouseLeave += new System.EventHandler(this.pictureBox9_MouseLeave);
            this.pictureBox9.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox9_MouseMove);
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox8.Location = new System.Drawing.Point(447, 25);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(22, 22);
            this.pictureBox8.TabIndex = 90;
            this.pictureBox8.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox8, "Search Item");
            this.pictureBox8.Click += new System.EventHandler(this.pictureBox8_Click);
            this.pictureBox8.MouseLeave += new System.EventHandler(this.pictureBox8_MouseLeave);
            this.pictureBox8.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox8_MouseMove);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackgroundImage = global::DevPackMine.Properties.Resources.oie_transparent;
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox7.Location = new System.Drawing.Point(143, 129);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(22, 22);
            this.pictureBox7.TabIndex = 89;
            this.pictureBox7.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox7, "Search Item");
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            this.pictureBox7.MouseLeave += new System.EventHandler(this.pictureBox7_MouseLeave);
            this.pictureBox7.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox7_MouseMove);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = global::DevPackMine.Properties.Resources.oie_transparent;
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.Location = new System.Drawing.Point(143, 103);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(22, 22);
            this.pictureBox6.TabIndex = 88;
            this.pictureBox6.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox6, "Search Item");
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            this.pictureBox6.MouseLeave += new System.EventHandler(this.pictureBox6_MouseLeave);
            this.pictureBox6.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox6_MouseMove);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = global::DevPackMine.Properties.Resources.oie_transparent;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(143, 77);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(22, 22);
            this.pictureBox5.TabIndex = 87;
            this.pictureBox5.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox5, "Search Item");
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            this.pictureBox5.MouseLeave += new System.EventHandler(this.pictureBox5_MouseLeave);
            this.pictureBox5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox5_MouseMove);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::DevPackMine.Properties.Resources.oie_transparent;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(143, 51);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(22, 22);
            this.pictureBox4.TabIndex = 86;
            this.pictureBox4.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox4, "Search Item");
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            this.pictureBox4.MouseLeave += new System.EventHandler(this.pictureBox4_MouseLeave);
            this.pictureBox4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox4_MouseMove);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::DevPackMine.Properties.Resources.oie_transparent;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(143, 25);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(22, 22);
            this.pictureBox3.TabIndex = 42;
            this.pictureBox3.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox3, "Search Item");
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            this.pictureBox3.MouseLeave += new System.EventHandler(this.pictureBox3_MouseLeave);
            this.pictureBox3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseMove_1);
            // 
            // textBox36
            // 
            this.textBox36.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox36.Location = new System.Drawing.Point(249, 130);
            this.textBox36.Name = "textBox36";
            this.textBox36.Size = new System.Drawing.Size(40, 20);
            this.textBox36.TabIndex = 66;
            this.textBox36.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox36_KeyPress);
            // 
            // textBox27
            // 
            this.textBox27.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox27.Location = new System.Drawing.Point(380, 26);
            this.textBox27.Name = "textBox27";
            this.textBox27.Size = new System.Drawing.Size(61, 20);
            this.textBox27.TabIndex = 48;
            this.textBox27.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox27_KeyPress);
            // 
            // textBox39
            // 
            this.textBox39.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox39.Location = new System.Drawing.Point(544, 78);
            this.textBox39.Name = "textBox39";
            this.textBox39.Size = new System.Drawing.Size(40, 20);
            this.textBox39.TabIndex = 72;
            this.textBox39.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox39_KeyPress);
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(480, 106);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(46, 13);
            this.label40.TabIndex = 75;
            this.label40.Text = "Amount:";
            // 
            // textBox31
            // 
            this.textBox31.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox31.Location = new System.Drawing.Point(380, 130);
            this.textBox31.Name = "textBox31";
            this.textBox31.Size = new System.Drawing.Size(61, 20);
            this.textBox31.TabIndex = 56;
            this.textBox31.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox31_KeyPress);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(320, 54);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(44, 13);
            this.label28.TabIndex = 51;
            this.label28.Text = "Item ID:";
            // 
            // textBox26
            // 
            this.textBox26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox26.Location = new System.Drawing.Point(76, 130);
            this.textBox26.Name = "textBox26";
            this.textBox26.Size = new System.Drawing.Size(61, 20);
            this.textBox26.TabIndex = 46;
            this.textBox26.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox26_KeyPress);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(320, 28);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(44, 13);
            this.label27.TabIndex = 49;
            this.label27.Text = "Item ID:";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(480, 80);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(46, 13);
            this.label39.TabIndex = 73;
            this.label39.Text = "Amount:";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(187, 80);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(46, 13);
            this.label34.TabIndex = 63;
            this.label34.Text = "Amount:";
            // 
            // textBox40
            // 
            this.textBox40.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox40.Location = new System.Drawing.Point(544, 104);
            this.textBox40.Name = "textBox40";
            this.textBox40.Size = new System.Drawing.Size(40, 20);
            this.textBox40.TabIndex = 74;
            this.textBox40.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox40_KeyPress);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(18, 28);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(44, 13);
            this.label22.TabIndex = 39;
            this.label22.Text = "Item ID:";
            // 
            // textBox28
            // 
            this.textBox28.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox28.Location = new System.Drawing.Point(380, 52);
            this.textBox28.Name = "textBox28";
            this.textBox28.Size = new System.Drawing.Size(61, 20);
            this.textBox28.TabIndex = 50;
            this.textBox28.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox28_KeyPress);
            // 
            // textBox33
            // 
            this.textBox33.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox33.Location = new System.Drawing.Point(249, 52);
            this.textBox33.Name = "textBox33";
            this.textBox33.Size = new System.Drawing.Size(40, 20);
            this.textBox33.TabIndex = 60;
            this.textBox33.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox33_KeyPress);
            // 
            // textBox38
            // 
            this.textBox38.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox38.Location = new System.Drawing.Point(544, 52);
            this.textBox38.Name = "textBox38";
            this.textBox38.Size = new System.Drawing.Size(40, 20);
            this.textBox38.TabIndex = 70;
            this.textBox38.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox38_KeyPress);
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(480, 132);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(46, 13);
            this.label41.TabIndex = 77;
            this.label41.Text = "Amount:";
            // 
            // textBox34
            // 
            this.textBox34.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox34.Location = new System.Drawing.Point(249, 78);
            this.textBox34.Name = "textBox34";
            this.textBox34.Size = new System.Drawing.Size(40, 20);
            this.textBox34.TabIndex = 62;
            this.textBox34.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox34_KeyPress);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(320, 80);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(44, 13);
            this.label29.TabIndex = 53;
            this.label29.Text = "Item ID:";
            // 
            // textBox22
            // 
            this.textBox22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox22.Location = new System.Drawing.Point(76, 26);
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new System.Drawing.Size(61, 20);
            this.textBox22.TabIndex = 38;
            this.textBox22.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox22_KeyPress);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(18, 132);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(44, 13);
            this.label26.TabIndex = 47;
            this.label26.Text = "Item ID:";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(187, 54);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(46, 13);
            this.label33.TabIndex = 61;
            this.label33.Text = "Amount:";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(480, 54);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(46, 13);
            this.label38.TabIndex = 71;
            this.label38.Text = "Amount:";
            // 
            // textBox41
            // 
            this.textBox41.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox41.Location = new System.Drawing.Point(544, 130);
            this.textBox41.Name = "textBox41";
            this.textBox41.Size = new System.Drawing.Size(40, 20);
            this.textBox41.TabIndex = 76;
            this.textBox41.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox41_KeyPress);
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(187, 106);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(46, 13);
            this.label35.TabIndex = 65;
            this.label35.Text = "Amount:";
            // 
            // textBox29
            // 
            this.textBox29.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox29.Location = new System.Drawing.Point(380, 78);
            this.textBox29.Name = "textBox29";
            this.textBox29.Size = new System.Drawing.Size(61, 20);
            this.textBox29.TabIndex = 52;
            this.textBox29.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox29_KeyPress);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(18, 54);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(44, 13);
            this.label23.TabIndex = 41;
            this.label23.Text = "Item ID:";
            // 
            // textBox25
            // 
            this.textBox25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox25.Location = new System.Drawing.Point(76, 104);
            this.textBox25.Name = "textBox25";
            this.textBox25.Size = new System.Drawing.Size(61, 20);
            this.textBox25.TabIndex = 44;
            this.textBox25.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox25_KeyPress);
            // 
            // textBox32
            // 
            this.textBox32.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox32.Location = new System.Drawing.Point(249, 26);
            this.textBox32.Name = "textBox32";
            this.textBox32.Size = new System.Drawing.Size(40, 20);
            this.textBox32.TabIndex = 58;
            this.textBox32.TextChanged += new System.EventHandler(this.textBox17_TextChanged);
            this.textBox32.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox32_KeyPress);
            // 
            // textBox37
            // 
            this.textBox37.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox37.Location = new System.Drawing.Point(544, 26);
            this.textBox37.Name = "textBox37";
            this.textBox37.Size = new System.Drawing.Size(40, 20);
            this.textBox37.TabIndex = 68;
            this.textBox37.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox37_KeyPress);
            // 
            // textBox35
            // 
            this.textBox35.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox35.Location = new System.Drawing.Point(249, 104);
            this.textBox35.Name = "textBox35";
            this.textBox35.Size = new System.Drawing.Size(40, 20);
            this.textBox35.TabIndex = 64;
            this.textBox35.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox35_KeyPress);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(320, 106);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(44, 13);
            this.label30.TabIndex = 55;
            this.label30.Text = "Item ID:";
            // 
            // textBox23
            // 
            this.textBox23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox23.Location = new System.Drawing.Point(76, 52);
            this.textBox23.Name = "textBox23";
            this.textBox23.Size = new System.Drawing.Size(61, 20);
            this.textBox23.TabIndex = 40;
            this.textBox23.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox23_KeyPress);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(18, 106);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(44, 13);
            this.label25.TabIndex = 45;
            this.label25.Text = "Item ID:";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(187, 28);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(46, 13);
            this.label32.TabIndex = 59;
            this.label32.Text = "Amount:";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(480, 28);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(46, 13);
            this.label37.TabIndex = 69;
            this.label37.Text = "Amount:";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(187, 132);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(46, 13);
            this.label36.TabIndex = 67;
            this.label36.Text = "Amount:";
            // 
            // textBox30
            // 
            this.textBox30.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox30.Location = new System.Drawing.Point(380, 104);
            this.textBox30.Name = "textBox30";
            this.textBox30.Size = new System.Drawing.Size(61, 20);
            this.textBox30.TabIndex = 54;
            this.textBox30.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox30_KeyPress);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(18, 80);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(44, 13);
            this.label24.TabIndex = 43;
            this.label24.Text = "Item ID:";
            // 
            // textBox24
            // 
            this.textBox24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox24.Location = new System.Drawing.Point(76, 78);
            this.textBox24.Name = "textBox24";
            this.textBox24.Size = new System.Drawing.Size(61, 20);
            this.textBox24.TabIndex = 42;
            this.textBox24.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox24_KeyPress);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(320, 132);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(44, 13);
            this.label31.TabIndex = 57;
            this.label31.Text = "Item ID:";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.textBox45);
            this.groupBox8.Controls.Add(this.label45);
            this.groupBox8.Controls.Add(this.textBox44);
            this.groupBox8.Controls.Add(this.label44);
            this.groupBox8.Controls.Add(this.textBox43);
            this.groupBox8.Controls.Add(this.label43);
            this.groupBox8.Controls.Add(this.textBox42);
            this.groupBox8.Controls.Add(this.label42);
            this.groupBox8.Location = new System.Drawing.Point(6, 6);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(232, 78);
            this.groupBox8.TabIndex = 39;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Crafting Skill Requirement";
            // 
            // textBox45
            // 
            this.textBox45.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox45.Location = new System.Drawing.Point(178, 50);
            this.textBox45.Name = "textBox45";
            this.textBox45.Size = new System.Drawing.Size(40, 20);
            this.textBox45.TabIndex = 84;
            this.textBox45.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox45_KeyPress);
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(114, 52);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(58, 13);
            this.label45.TabIndex = 85;
            this.label45.Text = "Skill Level:";
            // 
            // textBox44
            // 
            this.textBox44.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox44.Location = new System.Drawing.Point(52, 50);
            this.textBox44.Name = "textBox44";
            this.textBox44.Size = new System.Drawing.Size(40, 20);
            this.textBox44.TabIndex = 82;
            this.textBox44.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox44_KeyPress);
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(6, 52);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(43, 13);
            this.label44.TabIndex = 83;
            this.label44.Text = "Skill ID:";
            // 
            // textBox43
            // 
            this.textBox43.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox43.Location = new System.Drawing.Point(178, 24);
            this.textBox43.Name = "textBox43";
            this.textBox43.Size = new System.Drawing.Size(40, 20);
            this.textBox43.TabIndex = 80;
            this.textBox43.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox43_KeyPress);
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(114, 26);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(58, 13);
            this.label43.TabIndex = 81;
            this.label43.Text = "Skill Level:";
            // 
            // textBox42
            // 
            this.textBox42.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox42.Location = new System.Drawing.Point(52, 24);
            this.textBox42.Name = "textBox42";
            this.textBox42.Size = new System.Drawing.Size(40, 20);
            this.textBox42.TabIndex = 78;
            this.textBox42.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox42_KeyPress);
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(6, 26);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(43, 13);
            this.label42.TabIndex = 79;
            this.label42.Text = "Skill ID:";
            // 
            // tabPage3
            // 
            this.tabPage3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage3.Controls.Add(this.gbFortune);
            this.tabPage3.Controls.Add(this.groupBox17);
            this.tabPage3.Controls.Add(this.groupBox13);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(939, 610);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Rare & Purple & Fortune ";
            // 
            // groupBox17
            // 
            this.groupBox17.Controls.Add(this.comboBox23);
            this.groupBox17.Controls.Add(this.comboBox22);
            this.groupBox17.Controls.Add(this.comboBox21);
            this.groupBox17.Controls.Add(this.comboBox20);
            this.groupBox17.Controls.Add(this.comboBox19);
            this.groupBox17.Controls.Add(this.comboBox18);
            this.groupBox17.Controls.Add(this.comboBox17);
            this.groupBox17.Controls.Add(this.comboBox16);
            this.groupBox17.Controls.Add(this.comboBox15);
            this.groupBox17.Controls.Add(this.comboBox14);
            this.groupBox17.Controls.Add(this.label104);
            this.groupBox17.Controls.Add(this.comboBox13);
            this.groupBox17.Controls.Add(this.label103);
            this.groupBox17.Controls.Add(this.label102);
            this.groupBox17.Controls.Add(this.label101);
            this.groupBox17.Controls.Add(this.label100);
            this.groupBox17.Controls.Add(this.comboBox12);
            this.groupBox17.Controls.Add(this.comboBox11);
            this.groupBox17.Controls.Add(this.comboBox10);
            this.groupBox17.Controls.Add(this.comboBox9);
            this.groupBox17.Controls.Add(this.comboBox8);
            this.groupBox17.Controls.Add(this.label99);
            this.groupBox17.Controls.Add(this.comboBox7);
            this.groupBox17.Controls.Add(this.label98);
            this.groupBox17.Controls.Add(this.comboBox6);
            this.groupBox17.Controls.Add(this.label97);
            this.groupBox17.Controls.Add(this.comboBox5);
            this.groupBox17.Controls.Add(this.label96);
            this.groupBox17.Controls.Add(this.comboBox3);
            this.groupBox17.Controls.Add(this.label95);
            this.groupBox17.Location = new System.Drawing.Point(288, 2);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Size = new System.Drawing.Size(388, 295);
            this.groupBox17.TabIndex = 1;
            this.groupBox17.TabStop = false;
            this.groupBox17.Text = "Purple Items";
            // 
            // comboBox23
            // 
            this.comboBox23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox23.FormattingEnabled = true;
            this.comboBox23.Location = new System.Drawing.Point(275, 261);
            this.comboBox23.Name = "comboBox23";
            this.comboBox23.Size = new System.Drawing.Size(109, 21);
            this.comboBox23.TabIndex = 37;
            this.comboBox23.SelectedIndexChanged += new System.EventHandler(this.comboBox23_SelectedIndexChanged);
            // 
            // comboBox22
            // 
            this.comboBox22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox22.FormattingEnabled = true;
            this.comboBox22.Location = new System.Drawing.Point(275, 234);
            this.comboBox22.Name = "comboBox22";
            this.comboBox22.Size = new System.Drawing.Size(109, 21);
            this.comboBox22.TabIndex = 36;
            this.comboBox22.SelectedIndexChanged += new System.EventHandler(this.comboBox22_SelectedIndexChanged);
            // 
            // comboBox21
            // 
            this.comboBox21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox21.FormattingEnabled = true;
            this.comboBox21.Location = new System.Drawing.Point(275, 207);
            this.comboBox21.Name = "comboBox21";
            this.comboBox21.Size = new System.Drawing.Size(109, 21);
            this.comboBox21.TabIndex = 35;
            this.comboBox21.SelectedIndexChanged += new System.EventHandler(this.comboBox21_SelectedIndexChanged);
            // 
            // comboBox20
            // 
            this.comboBox20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox20.FormattingEnabled = true;
            this.comboBox20.Location = new System.Drawing.Point(275, 180);
            this.comboBox20.Name = "comboBox20";
            this.comboBox20.Size = new System.Drawing.Size(109, 21);
            this.comboBox20.TabIndex = 34;
            this.comboBox20.SelectedIndexChanged += new System.EventHandler(this.comboBox20_SelectedIndexChanged);
            // 
            // comboBox19
            // 
            this.comboBox19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox19.FormattingEnabled = true;
            this.comboBox19.Location = new System.Drawing.Point(275, 153);
            this.comboBox19.Name = "comboBox19";
            this.comboBox19.Size = new System.Drawing.Size(109, 21);
            this.comboBox19.TabIndex = 33;
            this.comboBox19.SelectedIndexChanged += new System.EventHandler(this.comboBox19_SelectedIndexChanged);
            // 
            // comboBox18
            // 
            this.comboBox18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox18.FormattingEnabled = true;
            this.comboBox18.Location = new System.Drawing.Point(275, 126);
            this.comboBox18.Name = "comboBox18";
            this.comboBox18.Size = new System.Drawing.Size(109, 21);
            this.comboBox18.TabIndex = 32;
            this.comboBox18.SelectedIndexChanged += new System.EventHandler(this.comboBox18_SelectedIndexChanged);
            // 
            // comboBox17
            // 
            this.comboBox17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox17.FormattingEnabled = true;
            this.comboBox17.Location = new System.Drawing.Point(275, 99);
            this.comboBox17.Name = "comboBox17";
            this.comboBox17.Size = new System.Drawing.Size(109, 21);
            this.comboBox17.TabIndex = 31;
            this.comboBox17.SelectedIndexChanged += new System.EventHandler(this.comboBox17_SelectedIndexChanged);
            // 
            // comboBox16
            // 
            this.comboBox16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox16.FormattingEnabled = true;
            this.comboBox16.Location = new System.Drawing.Point(275, 72);
            this.comboBox16.Name = "comboBox16";
            this.comboBox16.Size = new System.Drawing.Size(109, 21);
            this.comboBox16.TabIndex = 30;
            this.comboBox16.SelectedIndexChanged += new System.EventHandler(this.comboBox16_SelectedIndexChanged);
            // 
            // comboBox15
            // 
            this.comboBox15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox15.FormattingEnabled = true;
            this.comboBox15.Location = new System.Drawing.Point(275, 45);
            this.comboBox15.Name = "comboBox15";
            this.comboBox15.Size = new System.Drawing.Size(109, 21);
            this.comboBox15.TabIndex = 29;
            this.comboBox15.SelectedIndexChanged += new System.EventHandler(this.comboBox15_SelectedIndexChanged);
            // 
            // comboBox14
            // 
            this.comboBox14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox14.FormattingEnabled = true;
            this.comboBox14.Location = new System.Drawing.Point(275, 18);
            this.comboBox14.Name = "comboBox14";
            this.comboBox14.Size = new System.Drawing.Size(109, 21);
            this.comboBox14.TabIndex = 28;
            this.comboBox14.SelectedIndexChanged += new System.EventHandler(this.comboBox14_SelectedIndexChanged);
            // 
            // label104
            // 
            this.label104.AutoSize = true;
            this.label104.Location = new System.Drawing.Point(5, 264);
            this.label104.Name = "label104";
            this.label104.Size = new System.Drawing.Size(40, 13);
            this.label104.TabIndex = 27;
            this.label104.Text = "Seal 9:";
            // 
            // comboBox13
            // 
            this.comboBox13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox13.FormattingEnabled = true;
            this.comboBox13.Location = new System.Drawing.Point(51, 261);
            this.comboBox13.Name = "comboBox13";
            this.comboBox13.Size = new System.Drawing.Size(217, 21);
            this.comboBox13.TabIndex = 26;
            this.comboBox13.SelectedIndexChanged += new System.EventHandler(this.comboBox13_SelectedIndexChanged);
            this.comboBox13.SelectionChangeCommitted += new System.EventHandler(this.comboBox13_SelectionChangeCommitted);
            // 
            // label103
            // 
            this.label103.AutoSize = true;
            this.label103.Location = new System.Drawing.Point(5, 237);
            this.label103.Name = "label103";
            this.label103.Size = new System.Drawing.Size(40, 13);
            this.label103.TabIndex = 25;
            this.label103.Text = "Seal 8:";
            // 
            // label102
            // 
            this.label102.AutoSize = true;
            this.label102.Location = new System.Drawing.Point(5, 211);
            this.label102.Name = "label102";
            this.label102.Size = new System.Drawing.Size(40, 13);
            this.label102.TabIndex = 24;
            this.label102.Text = "Seal 7:";
            // 
            // label101
            // 
            this.label101.AutoSize = true;
            this.label101.Location = new System.Drawing.Point(5, 184);
            this.label101.Name = "label101";
            this.label101.Size = new System.Drawing.Size(40, 13);
            this.label101.TabIndex = 23;
            this.label101.Text = "Seal 6:";
            // 
            // label100
            // 
            this.label100.AutoSize = true;
            this.label100.Location = new System.Drawing.Point(5, 156);
            this.label100.Name = "label100";
            this.label100.Size = new System.Drawing.Size(40, 13);
            this.label100.TabIndex = 22;
            this.label100.Text = "Seal 5:";
            // 
            // comboBox12
            // 
            this.comboBox12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox12.FormattingEnabled = true;
            this.comboBox12.Location = new System.Drawing.Point(51, 234);
            this.comboBox12.Name = "comboBox12";
            this.comboBox12.Size = new System.Drawing.Size(217, 21);
            this.comboBox12.TabIndex = 21;
            this.comboBox12.SelectedIndexChanged += new System.EventHandler(this.comboBox12_SelectedIndexChanged);
            this.comboBox12.SelectionChangeCommitted += new System.EventHandler(this.comboBox12_SelectionChangeCommitted);
            // 
            // comboBox11
            // 
            this.comboBox11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox11.FormattingEnabled = true;
            this.comboBox11.Location = new System.Drawing.Point(51, 207);
            this.comboBox11.Name = "comboBox11";
            this.comboBox11.Size = new System.Drawing.Size(217, 21);
            this.comboBox11.TabIndex = 20;
            this.comboBox11.SelectedIndexChanged += new System.EventHandler(this.comboBox11_SelectedIndexChanged);
            this.comboBox11.SelectionChangeCommitted += new System.EventHandler(this.comboBox11_SelectionChangeCommitted);
            // 
            // comboBox10
            // 
            this.comboBox10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox10.FormattingEnabled = true;
            this.comboBox10.Location = new System.Drawing.Point(51, 180);
            this.comboBox10.Name = "comboBox10";
            this.comboBox10.Size = new System.Drawing.Size(217, 21);
            this.comboBox10.TabIndex = 19;
            this.comboBox10.SelectedIndexChanged += new System.EventHandler(this.comboBox10_SelectedIndexChanged);
            this.comboBox10.SelectionChangeCommitted += new System.EventHandler(this.comboBox10_SelectionChangeCommitted);
            // 
            // comboBox9
            // 
            this.comboBox9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox9.FormattingEnabled = true;
            this.comboBox9.Location = new System.Drawing.Point(51, 153);
            this.comboBox9.Name = "comboBox9";
            this.comboBox9.Size = new System.Drawing.Size(217, 21);
            this.comboBox9.TabIndex = 18;
            this.comboBox9.SelectedIndexChanged += new System.EventHandler(this.comboBox9_SelectedIndexChanged);
            this.comboBox9.SelectionChangeCommitted += new System.EventHandler(this.comboBox9_SelectionChangeCommitted);
            // 
            // comboBox8
            // 
            this.comboBox8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Location = new System.Drawing.Point(51, 126);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(217, 21);
            this.comboBox8.TabIndex = 17;
            this.comboBox8.SelectedIndexChanged += new System.EventHandler(this.comboBox8_SelectedIndexChanged);
            this.comboBox8.SelectionChangeCommitted += new System.EventHandler(this.comboBox8_SelectionChangeCommitted);
            // 
            // label99
            // 
            this.label99.AutoSize = true;
            this.label99.Location = new System.Drawing.Point(5, 128);
            this.label99.Name = "label99";
            this.label99.Size = new System.Drawing.Size(40, 13);
            this.label99.TabIndex = 16;
            this.label99.Text = "Seal 4:";
            // 
            // comboBox7
            // 
            this.comboBox7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Location = new System.Drawing.Point(51, 99);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(217, 21);
            this.comboBox7.TabIndex = 13;
            this.comboBox7.SelectedIndexChanged += new System.EventHandler(this.comboBox7_SelectedIndexChanged);
            this.comboBox7.SelectionChangeCommitted += new System.EventHandler(this.comboBox7_SelectionChangeCommitted);
            // 
            // label98
            // 
            this.label98.AutoSize = true;
            this.label98.Location = new System.Drawing.Point(5, 101);
            this.label98.Name = "label98";
            this.label98.Size = new System.Drawing.Size(40, 13);
            this.label98.TabIndex = 12;
            this.label98.Text = "Seal 3:";
            // 
            // comboBox6
            // 
            this.comboBox6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(51, 72);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(217, 21);
            this.comboBox6.TabIndex = 9;
            this.comboBox6.SelectedIndexChanged += new System.EventHandler(this.comboBox6_SelectedIndexChanged);
            this.comboBox6.SelectionChangeCommitted += new System.EventHandler(this.comboBox6_SelectionChangeCommitted);
            // 
            // label97
            // 
            this.label97.AutoSize = true;
            this.label97.Location = new System.Drawing.Point(5, 76);
            this.label97.Name = "label97";
            this.label97.Size = new System.Drawing.Size(40, 13);
            this.label97.TabIndex = 8;
            this.label97.Text = "Seal 2:";
            // 
            // comboBox5
            // 
            this.comboBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(51, 45);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(217, 21);
            this.comboBox5.TabIndex = 5;
            this.comboBox5.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            this.comboBox5.SelectionChangeCommitted += new System.EventHandler(this.comboBox5_SelectionChangeCommitted);
            // 
            // label96
            // 
            this.label96.AutoSize = true;
            this.label96.Location = new System.Drawing.Point(5, 49);
            this.label96.Name = "label96";
            this.label96.Size = new System.Drawing.Size(40, 13);
            this.label96.TabIndex = 4;
            this.label96.Text = "Seal 1:";
            // 
            // comboBox3
            // 
            this.comboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(51, 18);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(217, 21);
            this.comboBox3.TabIndex = 1;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            this.comboBox3.SelectionChangeCommitted += new System.EventHandler(this.comboBox3_SelectionChangeCommitted);
            // 
            // label95
            // 
            this.label95.AutoSize = true;
            this.label95.Location = new System.Drawing.Point(5, 21);
            this.label95.Name = "label95";
            this.label95.Size = new System.Drawing.Size(40, 13);
            this.label95.TabIndex = 0;
            this.label95.Text = "Seal 0:";
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.pictureBox22);
            this.groupBox13.Controls.Add(this.pictureBox21);
            this.groupBox13.Controls.Add(this.pictureBox20);
            this.groupBox13.Controls.Add(this.pictureBox19);
            this.groupBox13.Controls.Add(this.pictureBox18);
            this.groupBox13.Controls.Add(this.pictureBox17);
            this.groupBox13.Controls.Add(this.pictureBox16);
            this.groupBox13.Controls.Add(this.pictureBox15);
            this.groupBox13.Controls.Add(this.pictureBox14);
            this.groupBox13.Controls.Add(this.pictureBox13);
            this.groupBox13.Controls.Add(this.textBox79);
            this.groupBox13.Controls.Add(this.label79);
            this.groupBox13.Controls.Add(this.textBox78);
            this.groupBox13.Controls.Add(this.label78);
            this.groupBox13.Controls.Add(this.textBox77);
            this.groupBox13.Controls.Add(this.label77);
            this.groupBox13.Controls.Add(this.textBox76);
            this.groupBox13.Controls.Add(this.label76);
            this.groupBox13.Controls.Add(this.textBox75);
            this.groupBox13.Controls.Add(this.label75);
            this.groupBox13.Controls.Add(this.textBox74);
            this.groupBox13.Controls.Add(this.label74);
            this.groupBox13.Controls.Add(this.textBox73);
            this.groupBox13.Controls.Add(this.label73);
            this.groupBox13.Controls.Add(this.textBox72);
            this.groupBox13.Controls.Add(this.label72);
            this.groupBox13.Controls.Add(this.textBox71);
            this.groupBox13.Controls.Add(this.label71);
            this.groupBox13.Controls.Add(this.textBox70);
            this.groupBox13.Controls.Add(this.label70);
            this.groupBox13.Controls.Add(this.textBox69);
            this.groupBox13.Controls.Add(this.label69);
            this.groupBox13.Controls.Add(this.textBox68);
            this.groupBox13.Controls.Add(this.label68);
            this.groupBox13.Controls.Add(this.textBox67);
            this.groupBox13.Controls.Add(this.label67);
            this.groupBox13.Controls.Add(this.textBox66);
            this.groupBox13.Controls.Add(this.label66);
            this.groupBox13.Controls.Add(this.textBox65);
            this.groupBox13.Controls.Add(this.label65);
            this.groupBox13.Controls.Add(this.textBox64);
            this.groupBox13.Controls.Add(this.label64);
            this.groupBox13.Controls.Add(this.textBox63);
            this.groupBox13.Controls.Add(this.label63);
            this.groupBox13.Controls.Add(this.textBox62);
            this.groupBox13.Controls.Add(this.label62);
            this.groupBox13.Controls.Add(this.textBox61);
            this.groupBox13.Controls.Add(this.label61);
            this.groupBox13.Controls.Add(this.textBox60);
            this.groupBox13.Controls.Add(this.label60);
            this.groupBox13.Location = new System.Drawing.Point(3, 3);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(281, 295);
            this.groupBox13.TabIndex = 0;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Rare Options";
            // 
            // pictureBox22
            // 
            this.pictureBox22.BackgroundImage = global::DevPackMine.Properties.Resources.oie_transparent;
            this.pictureBox22.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox22.Location = new System.Drawing.Point(135, 254);
            this.pictureBox22.Name = "pictureBox22";
            this.pictureBox22.Size = new System.Drawing.Size(22, 22);
            this.pictureBox22.TabIndex = 99;
            this.pictureBox22.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox22, "Search Option");
            this.pictureBox22.Click += new System.EventHandler(this.pictureBox22_Click);
            this.pictureBox22.MouseLeave += new System.EventHandler(this.pictureBox22_MouseLeave);
            this.pictureBox22.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox22_MouseMove);
            // 
            // pictureBox21
            // 
            this.pictureBox21.BackgroundImage = global::DevPackMine.Properties.Resources.oie_transparent;
            this.pictureBox21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox21.Location = new System.Drawing.Point(135, 228);
            this.pictureBox21.Name = "pictureBox21";
            this.pictureBox21.Size = new System.Drawing.Size(22, 22);
            this.pictureBox21.TabIndex = 98;
            this.pictureBox21.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox21, "Search Option");
            this.pictureBox21.Click += new System.EventHandler(this.pictureBox21_Click);
            this.pictureBox21.MouseLeave += new System.EventHandler(this.pictureBox21_MouseLeave);
            this.pictureBox21.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox21_MouseMove);
            // 
            // pictureBox20
            // 
            this.pictureBox20.BackgroundImage = global::DevPackMine.Properties.Resources.oie_transparent;
            this.pictureBox20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox20.Location = new System.Drawing.Point(135, 202);
            this.pictureBox20.Name = "pictureBox20";
            this.pictureBox20.Size = new System.Drawing.Size(22, 22);
            this.pictureBox20.TabIndex = 97;
            this.pictureBox20.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox20, "Search Option");
            this.pictureBox20.Click += new System.EventHandler(this.pictureBox20_Click);
            this.pictureBox20.MouseLeave += new System.EventHandler(this.pictureBox20_MouseLeave);
            this.pictureBox20.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox20_MouseMove);
            // 
            // pictureBox19
            // 
            this.pictureBox19.BackgroundImage = global::DevPackMine.Properties.Resources.oie_transparent;
            this.pictureBox19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox19.Location = new System.Drawing.Point(135, 175);
            this.pictureBox19.Name = "pictureBox19";
            this.pictureBox19.Size = new System.Drawing.Size(22, 22);
            this.pictureBox19.TabIndex = 96;
            this.pictureBox19.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox19, "Search Option");
            this.pictureBox19.Click += new System.EventHandler(this.pictureBox19_Click);
            this.pictureBox19.MouseLeave += new System.EventHandler(this.pictureBox19_MouseLeave);
            this.pictureBox19.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox19_MouseMove);
            // 
            // pictureBox18
            // 
            this.pictureBox18.BackgroundImage = global::DevPackMine.Properties.Resources.oie_transparent;
            this.pictureBox18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox18.Location = new System.Drawing.Point(135, 149);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.Size = new System.Drawing.Size(22, 22);
            this.pictureBox18.TabIndex = 95;
            this.pictureBox18.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox18, "Search Option");
            this.pictureBox18.Click += new System.EventHandler(this.pictureBox18_Click);
            this.pictureBox18.MouseLeave += new System.EventHandler(this.pictureBox18_MouseLeave);
            this.pictureBox18.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox18_MouseMove);
            // 
            // pictureBox17
            // 
            this.pictureBox17.BackgroundImage = global::DevPackMine.Properties.Resources.oie_transparent;
            this.pictureBox17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox17.Location = new System.Drawing.Point(135, 123);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(22, 22);
            this.pictureBox17.TabIndex = 94;
            this.pictureBox17.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox17, "Search Option");
            this.pictureBox17.Click += new System.EventHandler(this.pictureBox17_Click);
            this.pictureBox17.MouseLeave += new System.EventHandler(this.pictureBox17_MouseLeave);
            this.pictureBox17.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox17_MouseMove);
            // 
            // pictureBox16
            // 
            this.pictureBox16.BackgroundImage = global::DevPackMine.Properties.Resources.oie_transparent;
            this.pictureBox16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox16.Location = new System.Drawing.Point(135, 97);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(22, 22);
            this.pictureBox16.TabIndex = 93;
            this.pictureBox16.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox16, "Search Option");
            this.pictureBox16.Click += new System.EventHandler(this.pictureBox16_Click);
            this.pictureBox16.MouseLeave += new System.EventHandler(this.pictureBox16_MouseLeave);
            this.pictureBox16.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox16_MouseMove);
            // 
            // pictureBox15
            // 
            this.pictureBox15.BackgroundImage = global::DevPackMine.Properties.Resources.oie_transparent;
            this.pictureBox15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox15.Location = new System.Drawing.Point(135, 71);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(22, 22);
            this.pictureBox15.TabIndex = 92;
            this.pictureBox15.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox15, "Search Option");
            this.pictureBox15.Click += new System.EventHandler(this.pictureBox15_Click);
            this.pictureBox15.MouseLeave += new System.EventHandler(this.pictureBox15_MouseLeave);
            this.pictureBox15.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox15_MouseMove);
            // 
            // pictureBox14
            // 
            this.pictureBox14.BackgroundImage = global::DevPackMine.Properties.Resources.oie_transparent;
            this.pictureBox14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox14.Location = new System.Drawing.Point(135, 45);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(22, 22);
            this.pictureBox14.TabIndex = 91;
            this.pictureBox14.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox14, "Search Option");
            this.pictureBox14.Click += new System.EventHandler(this.pictureBox14_Click);
            this.pictureBox14.MouseLeave += new System.EventHandler(this.pictureBox14_MouseLeave);
            this.pictureBox14.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox14_MouseMove);
            // 
            // pictureBox13
            // 
            this.pictureBox13.BackgroundImage = global::DevPackMine.Properties.Resources.oie_transparent;
            this.pictureBox13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox13.Location = new System.Drawing.Point(135, 19);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(22, 22);
            this.pictureBox13.TabIndex = 90;
            this.pictureBox13.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox13, "Search Option");
            this.pictureBox13.Click += new System.EventHandler(this.pictureBox13_Click);
            this.pictureBox13.MouseLeave += new System.EventHandler(this.pictureBox13_MouseLeave);
            this.pictureBox13.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox13_MouseMove);
            // 
            // textBox79
            // 
            this.textBox79.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox79.Location = new System.Drawing.Point(217, 257);
            this.textBox79.Name = "textBox79";
            this.textBox79.Size = new System.Drawing.Size(61, 20);
            this.textBox79.TabIndex = 78;
            this.textBox79.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox79_KeyPress);
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.Location = new System.Drawing.Point(164, 259);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(47, 13);
            this.label79.TabIndex = 79;
            this.label79.Text = "Chance:";
            // 
            // textBox78
            // 
            this.textBox78.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox78.Location = new System.Drawing.Point(217, 231);
            this.textBox78.Name = "textBox78";
            this.textBox78.Size = new System.Drawing.Size(61, 20);
            this.textBox78.TabIndex = 76;
            this.textBox78.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox78_KeyPress);
            // 
            // label78
            // 
            this.label78.AutoSize = true;
            this.label78.Location = new System.Drawing.Point(164, 233);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(47, 13);
            this.label78.TabIndex = 77;
            this.label78.Text = "Chance:";
            // 
            // textBox77
            // 
            this.textBox77.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox77.Location = new System.Drawing.Point(217, 205);
            this.textBox77.Name = "textBox77";
            this.textBox77.Size = new System.Drawing.Size(61, 20);
            this.textBox77.TabIndex = 74;
            this.textBox77.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox77_KeyPress);
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.label77.Location = new System.Drawing.Point(164, 207);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(47, 13);
            this.label77.TabIndex = 75;
            this.label77.Text = "Chance:";
            // 
            // textBox76
            // 
            this.textBox76.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox76.Location = new System.Drawing.Point(217, 179);
            this.textBox76.Name = "textBox76";
            this.textBox76.Size = new System.Drawing.Size(61, 20);
            this.textBox76.TabIndex = 72;
            this.textBox76.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox76_KeyPress);
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.Location = new System.Drawing.Point(164, 181);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(47, 13);
            this.label76.TabIndex = 73;
            this.label76.Text = "Chance:";
            // 
            // textBox75
            // 
            this.textBox75.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox75.Location = new System.Drawing.Point(217, 153);
            this.textBox75.Name = "textBox75";
            this.textBox75.Size = new System.Drawing.Size(61, 20);
            this.textBox75.TabIndex = 70;
            this.textBox75.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox75_KeyPress);
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.Location = new System.Drawing.Point(164, 155);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(47, 13);
            this.label75.TabIndex = 71;
            this.label75.Text = "Chance:";
            // 
            // textBox74
            // 
            this.textBox74.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox74.Location = new System.Drawing.Point(217, 126);
            this.textBox74.Name = "textBox74";
            this.textBox74.Size = new System.Drawing.Size(61, 20);
            this.textBox74.TabIndex = 68;
            this.textBox74.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox74_KeyPress);
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.Location = new System.Drawing.Point(164, 128);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(47, 13);
            this.label74.TabIndex = 69;
            this.label74.Text = "Chance:";
            // 
            // textBox73
            // 
            this.textBox73.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox73.Location = new System.Drawing.Point(217, 98);
            this.textBox73.Name = "textBox73";
            this.textBox73.Size = new System.Drawing.Size(61, 20);
            this.textBox73.TabIndex = 66;
            this.textBox73.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox73_KeyPress);
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.Location = new System.Drawing.Point(164, 100);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(47, 13);
            this.label73.TabIndex = 67;
            this.label73.Text = "Chance:";
            // 
            // textBox72
            // 
            this.textBox72.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox72.Location = new System.Drawing.Point(217, 72);
            this.textBox72.Name = "textBox72";
            this.textBox72.Size = new System.Drawing.Size(61, 20);
            this.textBox72.TabIndex = 64;
            this.textBox72.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox72_KeyPress);
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.Location = new System.Drawing.Point(164, 74);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(47, 13);
            this.label72.TabIndex = 65;
            this.label72.Text = "Chance:";
            // 
            // textBox71
            // 
            this.textBox71.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox71.Location = new System.Drawing.Point(217, 46);
            this.textBox71.Name = "textBox71";
            this.textBox71.Size = new System.Drawing.Size(61, 20);
            this.textBox71.TabIndex = 62;
            this.textBox71.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox71_KeyPress);
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Location = new System.Drawing.Point(164, 48);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(47, 13);
            this.label71.TabIndex = 63;
            this.label71.Text = "Chance:";
            // 
            // textBox70
            // 
            this.textBox70.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox70.Location = new System.Drawing.Point(217, 20);
            this.textBox70.Name = "textBox70";
            this.textBox70.Size = new System.Drawing.Size(61, 20);
            this.textBox70.TabIndex = 60;
            this.textBox70.TextChanged += new System.EventHandler(this.textBox70_TextChanged);
            this.textBox70.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox70_KeyPress);
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Location = new System.Drawing.Point(164, 22);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(47, 13);
            this.label70.TabIndex = 61;
            this.label70.Text = "Chance:";
            // 
            // textBox69
            // 
            this.textBox69.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox69.Location = new System.Drawing.Point(68, 255);
            this.textBox69.Name = "textBox69";
            this.textBox69.Size = new System.Drawing.Size(61, 20);
            this.textBox69.TabIndex = 58;
            this.textBox69.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox69_KeyPress);
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Location = new System.Drawing.Point(15, 257);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(47, 13);
            this.label69.TabIndex = 59;
            this.label69.Text = "Option9:";
            // 
            // textBox68
            // 
            this.textBox68.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox68.Location = new System.Drawing.Point(68, 229);
            this.textBox68.Name = "textBox68";
            this.textBox68.Size = new System.Drawing.Size(61, 20);
            this.textBox68.TabIndex = 56;
            this.textBox68.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox68_KeyPress);
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Location = new System.Drawing.Point(15, 231);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(47, 13);
            this.label68.TabIndex = 57;
            this.label68.Text = "Option8:";
            // 
            // textBox67
            // 
            this.textBox67.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox67.Location = new System.Drawing.Point(68, 203);
            this.textBox67.Name = "textBox67";
            this.textBox67.Size = new System.Drawing.Size(61, 20);
            this.textBox67.TabIndex = 54;
            this.textBox67.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox67_KeyPress);
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Location = new System.Drawing.Point(15, 205);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(47, 13);
            this.label67.TabIndex = 55;
            this.label67.Text = "Option7:";
            // 
            // textBox66
            // 
            this.textBox66.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox66.Location = new System.Drawing.Point(68, 177);
            this.textBox66.Name = "textBox66";
            this.textBox66.Size = new System.Drawing.Size(61, 20);
            this.textBox66.TabIndex = 52;
            this.textBox66.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox66_KeyPress);
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Location = new System.Drawing.Point(15, 179);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(47, 13);
            this.label66.TabIndex = 53;
            this.label66.Text = "Option6:";
            // 
            // textBox65
            // 
            this.textBox65.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox65.Location = new System.Drawing.Point(68, 151);
            this.textBox65.Name = "textBox65";
            this.textBox65.Size = new System.Drawing.Size(61, 20);
            this.textBox65.TabIndex = 50;
            this.textBox65.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox65_KeyPress);
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Location = new System.Drawing.Point(15, 153);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(47, 13);
            this.label65.TabIndex = 51;
            this.label65.Text = "Option5:";
            // 
            // textBox64
            // 
            this.textBox64.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox64.Location = new System.Drawing.Point(68, 124);
            this.textBox64.Name = "textBox64";
            this.textBox64.Size = new System.Drawing.Size(61, 20);
            this.textBox64.TabIndex = 48;
            this.textBox64.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox64_KeyPress);
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Location = new System.Drawing.Point(15, 126);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(47, 13);
            this.label64.TabIndex = 49;
            this.label64.Text = "Option4:";
            // 
            // textBox63
            // 
            this.textBox63.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox63.Location = new System.Drawing.Point(68, 98);
            this.textBox63.Name = "textBox63";
            this.textBox63.Size = new System.Drawing.Size(61, 20);
            this.textBox63.TabIndex = 46;
            this.textBox63.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox63_KeyPress);
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Location = new System.Drawing.Point(15, 100);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(47, 13);
            this.label63.TabIndex = 47;
            this.label63.Text = "Option3:";
            // 
            // textBox62
            // 
            this.textBox62.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox62.Location = new System.Drawing.Point(68, 72);
            this.textBox62.Name = "textBox62";
            this.textBox62.Size = new System.Drawing.Size(61, 20);
            this.textBox62.TabIndex = 44;
            this.textBox62.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox62_KeyPress);
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Location = new System.Drawing.Point(15, 74);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(47, 13);
            this.label62.TabIndex = 45;
            this.label62.Text = "Option2:";
            // 
            // textBox61
            // 
            this.textBox61.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox61.Location = new System.Drawing.Point(68, 46);
            this.textBox61.Name = "textBox61";
            this.textBox61.Size = new System.Drawing.Size(61, 20);
            this.textBox61.TabIndex = 42;
            this.textBox61.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox61_KeyPress);
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(15, 48);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(47, 13);
            this.label61.TabIndex = 43;
            this.label61.Text = "Option1:";
            // 
            // textBox60
            // 
            this.textBox60.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox60.Location = new System.Drawing.Point(68, 20);
            this.textBox60.Name = "textBox60";
            this.textBox60.Size = new System.Drawing.Size(61, 20);
            this.textBox60.TabIndex = 40;
            this.textBox60.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox60_KeyPress);
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(15, 22);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(47, 13);
            this.label60.TabIndex = 41;
            this.label60.Text = "Option0:";
            // 
            // clbFlagTest
            // 
            this.clbFlagTest.BackColor = System.Drawing.SystemColors.Control;
            this.clbFlagTest.CheckOnClick = true;
            this.clbFlagTest.Location = new System.Drawing.Point(6, 17);
            this.clbFlagTest.MultiColumn = true;
            this.clbFlagTest.Name = "clbFlagTest";
            this.clbFlagTest.Size = new System.Drawing.Size(246, 574);
            this.clbFlagTest.TabIndex = 15;
            this.clbFlagTest.SelectedIndexChanged += new System.EventHandler(this.clbFlagTest_SelectedIndexChanged_1);
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Location = new System.Drawing.Point(589, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(31, 20);
            this.textBox4.TabIndex = 4;
            this.textBox4.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(540, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Enable:";
            this.label4.Visible = false;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(1126, 669);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 34;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.Tag = "";
            this.toolTip1.ToolTipTitle = "Information";
            // 
            // groupBox18
            // 
            this.groupBox18.Controls.Add(this.clbFlagTest);
            this.groupBox18.Location = new System.Drawing.Point(1249, 42);
            this.groupBox18.Name = "groupBox18";
            this.groupBox18.Size = new System.Drawing.Size(260, 617);
            this.groupBox18.TabIndex = 35;
            this.groupBox18.TabStop = false;
            this.groupBox18.Text = "Flag Builder";
            this.groupBox18.Visible = false;
            // 
            // textBox12
            // 
            this.textBox12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox12.Location = new System.Drawing.Point(43, 19);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(216, 20);
            this.textBox12.TabIndex = 20;
            this.textBox12.TextChanged += new System.EventHandler(this.textBox12_TextChanged);
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
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label105);
            this.groupBox5.Controls.Add(this.textBox95);
            this.groupBox5.Controls.Add(this.checkedListBox2);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.textBox12);
            this.groupBox5.Location = new System.Drawing.Point(12, 27);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(265, 135);
            this.groupBox5.TabIndex = 32;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Search";
            // 
            // label105
            // 
            this.label105.AutoSize = true;
            this.label105.Location = new System.Drawing.Point(6, 108);
            this.label105.Name = "label105";
            this.label105.Size = new System.Drawing.Size(102, 13);
            this.label105.TabIndex = 44;
            this.label105.Text = "Search above level:";
            // 
            // textBox95
            // 
            this.textBox95.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox95.Location = new System.Drawing.Point(114, 105);
            this.textBox95.Name = "textBox95";
            this.textBox95.Size = new System.Drawing.Size(42, 20);
            this.textBox95.TabIndex = 43;
            this.textBox95.TextChanged += new System.EventHandler(this.textBox95_TextChanged);
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkedListBox2.BackColor = System.Drawing.SystemColors.Control;
            this.checkedListBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox2.CheckOnClick = true;
            this.checkedListBox2.ColumnWidth = 70;
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.IntegralHeight = false;
            this.checkedListBox2.Location = new System.Drawing.Point(9, 48);
            this.checkedListBox2.MultiColumn = true;
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(250, 52);
            this.checkedListBox2.TabIndex = 42;
            this.checkedListBox2.SelectedIndexChanged += new System.EventHandler(this.checkedListBox2_SelectedIndexChanged);
            // 
            // toolTip2
            // 
            this.toolTip2.Tag = "";
            this.toolTip2.ToolTipTitle = "Information";
            // 
            // toolTip3
            // 
            this.toolTip3.Tag = "";
            this.toolTip3.ToolTipTitle = "Information";
            // 
            // toolTip4
            // 
            this.toolTip4.Tag = "";
            this.toolTip4.ToolTipTitle = "Information";
            // 
            // toolTip5
            // 
            this.toolTip5.Tag = "";
            this.toolTip5.ToolTipTitle = "Information";
            // 
            // toolTip6
            // 
            this.toolTip6.Tag = "";
            this.toolTip6.ToolTipTitle = "Information";
            // 
            // toolTip7
            // 
            this.toolTip7.Tag = "";
            this.toolTip7.ToolTipTitle = "Information";
            // 
            // toolTip8
            // 
            this.toolTip8.Tag = "";
            this.toolTip8.ToolTipTitle = "Information";
            // 
            // toolTip9
            // 
            this.toolTip9.Tag = "";
            this.toolTip9.ToolTipTitle = "Information";
            // 
            // toolTip10
            // 
            this.toolTip10.Tag = "";
            this.toolTip10.ToolTipTitle = "Information";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(361, 670);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 36;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(962, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 16);
            this.label8.TabIndex = 37;
            this.label8.Text = "Current Language is :";
            // 
            // lblLang
            // 
            this.lblLang.AutoSize = true;
            this.lblLang.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblLang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLang.ForeColor = System.Drawing.Color.Chartreuse;
            this.lblLang.Location = new System.Drawing.Point(1116, 4);
            this.lblLang.Name = "lblLang";
            this.lblLang.Size = new System.Drawing.Size(0, 16);
            this.lblLang.TabIndex = 38;
            // 
            // gbFortune
            // 
            this.gbFortune.Controls.Add(this.button8);
            this.gbFortune.Controls.Add(this.button6);
            this.gbFortune.Controls.Add(this.dataGridView1);
            this.gbFortune.Controls.Add(this.button7);
            this.gbFortune.Location = new System.Drawing.Point(682, 2);
            this.gbFortune.Name = "gbFortune";
            this.gbFortune.Size = new System.Drawing.Size(251, 603);
            this.gbFortune.TabIndex = 2;
            this.gbFortune.TabStop = false;
            this.gbFortune.Text = "Fortune";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(245, 552);
            this.dataGridView1.TabIndex = 0;
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(94, 576);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(65, 23);
            this.button6.TabIndex = 8;
            this.button6.Text = "Copy to new";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(198, 576);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(49, 23);
            this.button7.TabIndex = 7;
            this.button7.Text = "Delete Item";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(16, 576);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(49, 23);
            this.button8.TabIndex = 6;
            this.button8.Text = "Add Item";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // ItemEditor2
            // 
            this.ClientSize = new System.Drawing.Size(1232, 708);
            this.Controls.Add(this.lblLang);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.groupBox18);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.menuStrip1);
            
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "ItemEditor2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Item Editor EP4";
            this.Load += new System.EventHandler(this.Exporter_Item_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox23.ResumeLayout(false);
            this.groupBox23.PerformLayout();
            this.groupBox22.ResumeLayout(false);
            this.groupBox22.PerformLayout();
            this.groupBox21.ResumeLayout(false);
            this.groupBox21.PerformLayout();
            this.groupBox15.ResumeLayout(false);
            this.groupBox15.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).EndInit();
            this.groupBox19.ResumeLayout(false);
            this.groupBox19.PerformLayout();
            this.groupBox16.ResumeLayout(false);
            this.groupBox16.PerformLayout();
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox17.ResumeLayout(false);
            this.groupBox17.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            this.groupBox18.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.gbFortune.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void massEditToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MassEdit m = new MassEdit(); //dethunter12 add
            m.ShowDialog(); //dethunter12 add
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboBox1.BackColor = Color.Pink; //dethunter12 add
            textBox2.BackColor = Color.Pink; //dethunter12 add
        }

        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboBox2.BackColor = Color.Pink; //dethunter12 add
            textBox3.BackColor = Color.Pink; //dethunter12 add
        }

        private void comboBox4_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboBox4.BackColor = Color.Pink; //dethunter12 add
            textBox9.BackColor = Color.Pink;
        }

        private void comboBox3_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboBox3.BackColor = Color.Pink; //dethunter12 add
        }

        private void comboBox5_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboBox5.BackColor = Color.Pink; //dethunter12 add
        }

        private void comboBox6_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboBox6.BackColor = Color.Pink; //dethunter12 add
        }

        private void comboBox7_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboBox7.BackColor = Color.Pink; //dethunter12 add
        }

        private void comboBox8_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboBox8.BackColor = Color.Pink; //dethunter12 add
        }

        private void comboBox9_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboBox9.BackColor = Color.Pink; //dethunter12 add
        }

        private void comboBox10_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboBox10.BackColor = Color.Pink; //dethunter12 add
        }

        private void comboBox11_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboBox11.BackColor = Color.Pink; //dethunter12 add
        }

        private void comboBox12_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboBox12.BackColor = Color.Pink; //dethunter12 add
        }

        private void comboBox13_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboBox13.BackColor = Color.Pink; //dethunter12 add
        }

        private void massUpdateSealsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MassEditSeals ma = new MassEditSeals(); //dethunter12 add
            ma.ShowDialog(); //dethunter12 add
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox8.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox20_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox20.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox1.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox46_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox46.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
            textBox5.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox6.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox47_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox47.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox48_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox48.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox49_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox49.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox50_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox50.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox16_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox16.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox18_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox18.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox19_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox19.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox57_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox57.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox58_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox58.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox91_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox91.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox92_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox92.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox10.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox11.BackColor = Color.Pink; //dethunter12 add 
        }

        private void textBox13_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox13.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox14_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox14.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox15_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox15.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox52_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox52.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox53_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox53.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox54_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox54.BackColor = Color.Pink; //dethunter12 add 
        }

        private void textBox55_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox55.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox56_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox56.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox85_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox85.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox86_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox86.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox87_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox87.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox88_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox88.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox89_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox89.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox90_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox90.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox17_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox17.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox21_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox21.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox17.Text, "[^0-9]")) //checks the textbox text for matching case 0-9
            {
                MessageBox.Show("Please enter only numbers.");
                textBox17.Text = textBox17.Text.Remove(textBox17.Text.Length - 1); //if 0-9 isnt found remove the length
            }
        }

        private void textBox80_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox80.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox81_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox81.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox82_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox82.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox59_KeyUp(object sender, KeyEventArgs e)
        {
            textBox59.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox51_KeyUp(object sender, KeyEventArgs e)
        {
            textBox51.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox94_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox94.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox93_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox93.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox83_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox83.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox84_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox84.BackColor = Color.Pink; //dethunter12 add
        }

        private void checkedListBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            textBox7.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox60_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox60.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox61_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox61.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox62_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox62.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox63_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox63.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox64_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox64.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox65_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox65.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox66_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox66.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox67_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox67.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox68_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox68.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox69_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox69.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox70_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox70.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox71_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox71.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox72_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox72.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox73_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox73.BackColor = Color.Pink; //dethunter12
        }

        private void textBox74_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox74.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox75_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox75.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox76_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox76.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox77_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox77.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox78_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox78.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox79_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox79.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox42_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox42.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox44_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox44.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox43_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox43.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox45_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox45.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox22_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox22.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox23_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox23.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox24_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox24.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox25_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox25.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox26_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox26.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox32_TextChanged(object sender, EventArgs e)
        {
            textBox32.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox33_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox33.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox34_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox34.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox35_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox35.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox36_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox36.BackColor = Color.Pink; //dethunter12
        }

        private void textBox27_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox27.BackColor = Color.Pink; //dethunter12
        }

        private void textBox28_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox28.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox29_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox29.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox30_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox30.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox31_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox31.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox37_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox37.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox38_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox38.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox39_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox39.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox40_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox40.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox41_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox41.BackColor = Color.Pink; //dethunter12 add 
        }

        private void CbSubtype1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "1") //dethunter12 add
            {
                textBox3.Text = GetIndexByComboBox(CbSubtype1.Text).ToString();
            }
        }

        private void CbSubtype1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CbSubtype1.BackColor = Color.Pink; //dethunter12 add
            textBox3.BackColor = Color.Pink; //dethunter12 add
        }

        private void CbSubtype2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "2") //dethunter12 add
            {
                textBox3.Text = GetIndexByComboBox(CbSubtype2.Text).ToString();
            }
        }

        private void CbSubtype2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CbSubtype2.BackColor = Color.Pink; //dethunter12 add
            textBox3.BackColor = Color.Pink; //dethunter12 add
        }

        private void CbSubtype3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "3") //dethunter12 add
            {
                textBox3.Text = GetIndexByComboBox(CbSubtype3.Text).ToString();
            }
        }

        private void CbSubtype3_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CbSubtype3.BackColor = Color.Pink; //dethunter12 add
            textBox3.BackColor = Color.Pink; //dethunter12 add
        }

        private void CbSubType4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "4") //dethunter12 add
            {
                textBox3.Text = GetIndexByComboBox(CbSubType4.Text).ToString();
            }
        }

        private void CbSubType4_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CbSubType4.BackColor = Color.Pink; //dethunter12 add
            textBox3.BackColor = Color.Pink; //dethunter12 add
        }

        private void CbSubType5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "5") //dethunter12 add
            {
                textBox3.Text = GetIndexByComboBox(CbSubType5.Text).ToString();
            }
        }

        private void CbSubType5_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CbSubType5.BackColor = Color.Pink; //dethunter12 add
            textBox3.BackColor = Color.Pink; //dethunter12 add
        }

        private void CbSubType6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "6") //dethunter12 add 
            {
                textBox3.Text = GetIndexByComboBox(CbSubType6.Text).ToString();
            }
        }

        private void CbSubType6_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CbSubType6.BackColor = Color.Pink; //dethunter12 add
            textBox3.BackColor = Color.Pink; //dethunter12 add
        }

        private void CbSubType7_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "-1") //dethunter12 add
            {
                textBox3.Text = GetIndexByComboBox(CbSubType7.Text).ToString();
            }
        }

        private void CbSubType7_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CbSubType7.BackColor = Color.Pink; //dethunter12 add
            textBox3.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox32_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox32.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox15_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(textBox15, "Costume Duration in Days"); //dethunter12 add
        }

        private void textBox18_MouseHover(object sender, EventArgs e)
        {
            toolTip2.SetToolTip(textBox18, "Stack Size"); //dethunter12 add
        }

        private void textBox85_MouseHover(object sender, EventArgs e)
        {
            toolTip3.SetToolTip(textBox85, "Reform Rate"); //dethunter12 add
        }

        private void textBox86_MouseHover(object sender, EventArgs e)
        {
            toolTip4.SetToolTip(textBox86, "Reform Rate"); //dethunter12 add
        }

        private void textBox87_MouseHover(object sender, EventArgs e)
        {
            toolTip5.SetToolTip(textBox87, "Reform Rate"); //dethunter12 add
        }

        private void textBox88_MouseHover(object sender, EventArgs e)
        {
            toolTip6.SetToolTip(textBox88, "Reform Rate"); //dethunter12 add
        }

        private void textBox89_MouseHover(object sender, EventArgs e)
        {
            toolTip7.SetToolTip(textBox89, "Reform Rate"); //dethunter12 add
        }

        private void textBox90_MouseHover(object sender, EventArgs e)
        {
            toolTip8.SetToolTip(textBox90, "Reform Rate"); //dethunter12 add
        }

        private void textBox10_MouseHover(object sender, EventArgs e)
        {
            if (textBox2.Text == "1")
            {
                toolTip9.SetToolTip(textBox10, "Physical Defense"); //dethunter12 add
            }

            else if (textBox2.Text == "0")
            {
                toolTip9.SetToolTip(textBox10, " Physical Attack"); //dethunter12 add
            }
            else if (textBox2.Text == "6")
            {
                toolTip9.SetToolTip(textBox10, " Skill ID"); //dethunter12 add
            }
            else if (textBox2.Text == "2" && textBox3.Text == "13")
            {
                toolTip9.SetToolTip(textBox10, "Level"); //dethunter12 add
            }
            else if (textBox2.Text == "2" && textBox3.Text == "12")
            {
                toolTip9.SetToolTip(textBox10, "Reward Index"); //dethunter12 add
            }
        }

        private void textBox11_MouseHover(object sender, EventArgs e)
        {
            if (textBox2.Text == "1")
            {
                toolTip9.SetToolTip(textBox11, "Magical Defense"); //dethunter12 add
            }
            else if (textBox2.Text == "0")
            {
                toolTip9.SetToolTip(textBox11, " Magical Attack"); //dethunter12 add
            }
            else if (textBox2.Text == "6")
            {
                toolTip9.SetToolTip(textBox11, " Skill Level"); //dethunter12 add
            }
            else if (textBox2.Text == "2" && textBox3.Text == "13")
            {
                toolTip9.SetToolTip(textBox11, "Reward Index"); //dethunter12 add
            }
        }

        private void textBox13_MouseHover(object sender, EventArgs e)
        {
            if (textBox2.Text == "1")
            {
                toolTip9.SetToolTip(textBox13, "Flight Speed"); //dethunter12 add
            }
            else if (textBox2.Text == "0")
            {
                toolTip9.SetToolTip(textBox13, "Attack Speed"); //dethunter12 add
            }
        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e) //dethunter12 add
        {
            string str = Path.GetDirectoryName(_ClientPath).Replace("Data", "").Replace("data", "") + "\\" + textBox47.Text;
            if (File.Exists(str))
                new TextEditor(str).Show();
            else
                new CustomMessage("File not found").Show();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void btnPercentAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int result1 = 0; //Dethunter12 add (wizatek code)
                float result2 = 0.0f;
                
                if (!int.TryParse(textBox10.Text, out result1) || !float.TryParse(TbPercent.Text.Replace('.', ','), out result2))
                    return;
                this.textBox10.Text = ((int)(result1 / 100f * (double)result2) + result1).ToString();


            }
            catch (Exception ex) { }
            
        }

        private void btnPercent1Add_Click(object sender, EventArgs e)
        {
            try
            {
                int result1 = 0; //Dethunter12 add (wizatek code)
                float result2 = 0.0f;

                if (!int.TryParse(textBox11.Text, out result1) || !float.TryParse(TbPercent1.Text.Replace('.', ','), out result2))
                    return;
                this.textBox11.Text = ((int)(result1 / 100f * (double)result2) + result1).ToString();
            }
            catch (Exception ex) { }
        }

        private void btnPercent2Add_Click(object sender, EventArgs e)
        {
            try
            {
                int result1 = 0; //Dethunter12 add (wizatek code)
                float result2 = 0.0f;
                
                if (!int.TryParse(textBox13.Text, out result1) || !float.TryParse(TbPercent2.Text.Replace('.', ','), out result2))
                    return;
                this.textBox13.Text = ((int)(result1 / 100f * (double)result2) + result1).ToString();
            }
            catch (Exception ex) { }
        }

        private void comboBox24_SelectedIndexChanged_1(object sender, EventArgs e) //dethunter12 adjust
        {
            textBox91.Text = comboBox24.SelectedIndex.ToString();
            if (textBox91.Text == "1")
            {
                comboBox25.Visible = true;
                comboBox26.Visible = false;
            }
            else if (textBox91.Text == "2")
            {
                comboBox25.Visible = false;
                comboBox26.Visible = true;
            }
        }

        private void comboBox25_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (textBox91.Text == "1")
            {
                textBox92.Text = GetIndexByComboBox(comboBox25.Text).ToString(); //dethunter12  add
            }
        }

        private void comboBox24_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboBox24.BackColor = Color.Pink; //dethunter12 add
            textBox91.BackColor = Color.Pink;
        }

        private void comboBox25_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboBox25.BackColor = Color.Pink; //dethunter12 add
            textBox92.BackColor = Color.Pink;
        }

        private void comboBox26_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (textBox91.Text == "2")
            {
                textBox92.Text = GetIndexByComboBox(comboBox26.Text).ToString(); //dethunter12  add
            }
            
        }

        private void comboBox26_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboBox26.BackColor = Color.Pink; //dethunter12 add
            textBox92.BackColor = Color.Pink;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(language);
        }

        private void ClbItemFlag_SelectedIndexChanged(object sender, EventArgs e)
        {
            long num = 0;
            for (int index = 0; index < ClbItemFlag.Items.Count; ++index)
            {
                if (ClbItemFlag.GetItemChecked(index))
                    num += 1L << index;
            }
            textBox8.Text = num.ToString();
            if (flagBuilderType == "items")
            {
                if (Episode == "EP4")
                    flagBig = num;
                else
                    flagSmall = Convert.ToInt32(num);
            }
            else
                flagSmall = Convert.ToInt32(num);
        }
    }
    
}
