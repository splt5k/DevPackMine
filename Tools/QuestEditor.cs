// Decompiled with JetBrains decompiler
// Type: DevPackMine.Tools.QuestEditor
// Assembly: DevPackMine, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6B9BC8BF-B510-4945-A515-04135CC0F4A4
// Assembly location: C:\Users\NTServer\Desktop\DevPackMine\DevPackMine\DevPackMine.exe

using MySql.Data.MySqlClient;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace DevPackMine.Tools
{
    public class QuestEditor : Form
    {
        public static Connection connection = new Connection();
        private string Host = QuestEditor.connection.ReadSettings("Host");
        private string User = QuestEditor.connection.ReadSettings("User");
        private string Password = QuestEditor.connection.ReadSettings("Password");
        private string Database = QuestEditor.connection.ReadSettings("Database");
        private DatabaseHandle databaseHandle = new DatabaseHandle();
        public string rowName = "a_index";
        public string[] menuArray = new string[2]
        {
      "a_index",
      "a_name"
        };

        //dethunter12 4/11/2018 language system
        private string language = ItemEditor2.connection.ReadSettings("Language");//dethunter12 test
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
        public string adesc = "";
        public string aname = ""; //dehtunter12 add
        public string desc;
        public string adesc2 = "";
        public string adesc3 = "";
        public string desc2;
        private Label label112;
        private Label label111;
        private Label label110;
        private Label label113;
        private Label lblLang;
        private ComboBox CbRvRGrade;
        private ComboBox CbRvrType;
        private ComboBox CbRvRGrade1;
        private Button BtnCopy;
        private PictureBox PbPItem5;
        private PictureBox PbPItem4;
        private PictureBox PbPItem3;
        private PictureBox PbPItem2;
        private PictureBox PbPItem1;
        private PictureBox PbItem7;
        private PictureBox PbItem6;
        private PictureBox PbItem5;
        private PictureBox PbItem4;
        private PictureBox PbItem3;
        private PictureBox PbItem2;
        private PictureBox PbItem1;
        private PictureBox PbCond1;
        private PictureBox PbCond2;
        private PictureBox PbCond3;
        private TextBox tbItemDesc5;
        private TextBox tbItemDesc4;
        private TextBox tbItemDesc3;
        private TextBox tbItemDesc2;
        private TextBox tbItemDesc1;
        private TextBox TbPrize2ItemDesc1;
        private TextBox TbPrize2ItemDesc2;
        private TextBox TbPrize2ItemDesc3;
        private TextBox TbPrize2ItemDesc4;
        private TextBox TbPrize2ItemDesc5;
        private TextBox TbPrize2ItemDesc6;
        private TextBox TbPrize2ItemDesc7;
        public string desc3;
        private TextBox TbObj1;
        private TextBox TbObj2;
        private TextBox TbObj3;
        private TextBox TbObjNpc3;
        private PictureBox PbNpcID3;
        private TextBox TbObjNpc2;
        private PictureBox PbNpcID2;
        private TextBox TbObjNpc1;
        private PictureBox PbNpcID1;
        private TextBox TbObj1Npc3;
        private PictureBox PbObj1NpcID3;
        private TextBox TbObj1Npc2;
        private PictureBox PbObj1NpcID2;
        private TextBox TbObj1Npc1;
        private PictureBox PbObj1NpcID1;
        private Label label116;
        private TextBox TbObj2Npc3;
        private PictureBox PbObj2NpcID3;
        private TextBox TbObj2Npc2;
        private PictureBox PbObj2NpcID2;
        private TextBox TbObj2Npc1;
        private PictureBox PbObj2NpcID1;
        private Label label115;
        private Label label114;
        private Label label118;
        private Label label117;
        private TextBox TbEndNpcName;
        private TextBox TbStartNpcName;
        private PictureBox PbItemNeed5;
        private PictureBox PbItemNeed4;
        private PictureBox PbItemNeed3;
        private PictureBox PbItemNeed2;
        private PictureBox PbItemNeed1;
        private TextBox TbNeedName5;
        private TextBox TbNeedName4;
        private TextBox TbNeedName3;
        private TextBox TbNeedName2;
        private TextBox TbNeedName1;
        private PictureBox PbEndNPCItem;
        private PictureBox PbStartItemNPC;
        private Label label119;
        private PictureBox pictureBox1;
        private Label label120;
        private Label label121;
        private PictureBox pictureBox2;
        private Label label122;
        private PictureBox pictureBox3;
        public string nameholder1; //dethunter12 test
        
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
                desc = "a_desc_ger";
                return desc;

            }
            else if (language == "POL")
            {
                desc = "a_desc_pld";
                return desc;

            }
            else if (language == "BRA")
            {
                desc = "a_desc_brz";
                return desc;
            }
            else if (language == "RUS")
            {
                desc = "a_desc_rus";
                return desc;
            }
            else if (language == "FRA")
            {
                desc = "a_desc_frc";
                return desc;
            }
            else if (language == "ESP")
            {
                desc = "a_desc_spn";
                return desc;
            }
            else if (language == "MEX")
            {
                desc = "a_desc_mex";
                return desc;
            }
            else if (language == "THA")
            {
                desc = "a_desc_thai";
                return desc;
            }
            else if (language == "ITA")
            {
                desc = "a_desc_ita";
                return desc;
            }
            else if (language == "USA")
            {
                desc = "a_desc_usa";
                return desc;
            }
            else
            {
                return null;
            }
        }
        public string Descr2FromLanguage() //dethunter12 4/11/2018
        {

            if (language == "GER")
            {
                desc2 = "a_desc2_ger";
                return desc2;

            }
            else if (language == "POL")
            {
                desc2 = "a_desc2_pld";
                return desc2;

            }
            else if (language == "BRA")
            {
                desc2 = "a_desc2_brz";
                return desc2;
            }
            else if (language == "RUS")
            {
                desc2 = "a_desc2_rus";
                return desc2;
            }
            else if (language == "FRA")
            {
                desc2 = "a_desc2_frc";
                return desc2;
            }
            else if (language == "ESP")
            {
                desc2 = "a_desc2_spn";
                return desc2;
            }
            else if (language == "MEX")
            {
                desc2 = "a_desc2_mex";
                return desc2;
            }
            else if (language == "THA")
            {
                desc2 = "a_desc2_thai";
                return desc2;
            }
            else if (language == "ITA")
            {
                desc2 = "a_desc2_ita";
                return desc2;
            }
            else if (language == "USA")
            {
                desc2 = "a_desc2_usa";
                return desc2;
            }
            else
            {
                return null;
            }
        }
        public string Descr3FromLanguage() //dethunter12 4/11/2018
        {

            if (language == "GER")
            {
                desc3 = "a_desc3_ger";
                return desc3;

            }
            else if (language == "POL")
            {
                desc3 = "a_desc3_pld";
                return desc3;

            }
            else if (language == "BRA")
            {
                desc3 = "a_desc3_brz";
                return desc3;
            }
            else if (language == "RUS")
            {
                desc3 = "a_desc3_rus";
                return desc3;
            }
            else if (language == "FRA")
            {
                desc3 = "a_desc3_frc";
                return desc3;
            }
            else if (language == "ESP")
            {
                desc3 = "a_desc3_spn";
                return desc3;
            }
            else if (language == "MEX")
            {
                desc3 = "a_desc3_mex";
                return desc3;
            }
            else if (language == "THA")
            {
                desc3 = "a_desc3_thai";
                return desc3;
            }
            else if (language == "ITA")
            {
                desc3 = "a_desc3_ita";
                return desc3;
            }
            else if (language == "USA")
            {
                desc3 = "a_desc3_usa";
                return desc3;
            }
            else
            {
                return null;
            }
        }
        //dethunter12 4/11/2018 language system end
        private ExportLodHandle exportLodhandle = new ExportLodHandle();
        private IContainer components = (IContainer)null;
        public string name;
        public int index;
        public string test2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileExportToolStripMenuItem;
        private GroupBox groupBox3;
        private Button button3;
        private Button button1;
        private ListBox listBox1;
        private GroupBox groupBox5;
        private Label label7;
        private TextBox textBox12;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TextBox textBox2;
        private Label label3;
        private Label label2;
        private Label label6;
        private TextBox textBox1;
        private Label label5;
        private Label label1;
        private TextBox textBox6;
        private TextBox textBox10;
        private Label label11;
        private Label label12;
        private Label label13;
        private TextBox textBox13;
        private Label label10;
        private Label label46;
        private Label label47;
        private Label label54;
        private Label label52;
        private Label label59;
        private TabPage tabPage6;
        private TextBox textBox5;
        private GroupBox groupBox1;
        private TextBox textBox21;
        private Label label85;
        private Label label93;
        private TextBox textBox20;
        private TextBox textBox23;
        private Label label22;
        private TextBox textBox22;
        private Label label23;
        private GroupBox groupBox4;
        private TextBox textBox19;
        private TextBox textBox17;
        private Label label14;
        private Label label92;
        private TextBox textBox16;
        private Label label91;
        private Label label18;
        private TextBox textBox18;
        private TextBox textBox14;
        private Label label15;
        private Label label16;
        private Label label4;
        private TextBox textBox24;
        private TextBox textBox25;
        private Label label37;
        private TextBox textBox44;
        private Label label38;
        private Label label39;
        private Label label40;
        private TextBox textBox45;
        private TextBox textBox46;
        private TextBox textBox47;
        private Label label32;
        private TextBox textBox39;
        private Label label33;
        private Label label35;
        private Label label36;
        private TextBox textBox40;
        private TextBox textBox42;
        private TextBox textBox43;
        private Label label34;
        private TextBox textBox41;
        private GroupBox groupBox6;
        private Label label17;
        private Label label19;
        private Label label20;
        private Label label26;
        private TextBox textBox32;
        private Label label27;
        private TextBox textBox31;
        private Label label28;
        private Label label25;
        private TextBox textBox33;
        private Label label24;
        private TextBox textBox34;
        private Label label21;
        private TextBox textBox35;
        private Label label29;
        private Label label30;
        private Label label31;
        private TextBox textBox36;
        private TextBox textBox37;
        private TextBox textBox38;
        private TextBox textBox48;
        private TextBox textBox54;
        private TextBox textBox55;
        private TextBox textBox56;
        private TextBox textBox57;
        private TextBox textBox58;
        private Label label48;
        private Label label49;
        private Label label50;
        private Label label51;
        private Label label53;
        private Label label45;
        private Label label44;
        private Label label43;
        private Label label42;
        private Label label41;
        private TextBox textBox59;
        private TextBox textBox60;
        private TextBox textBox61;
        private TextBox textBox62;
        private TextBox textBox63;
        private Label label60;
        private Label label58;
        private Label label57;
        private Label label56;
        private Label label55;
        private Label label96;
        private Label label95;
        private Label label104;
        private TextBox textBox104;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private GroupBox groupBox9;
        private ComboBox comboBox3;
        private GroupBox groupBox10;
        private ComboBox comboBox4;
        private Label label98;
        private GroupBox groupBox11;
        private ComboBox comboBox5;
        private Button button6;
        private Button button5;
        private TabControl tabControl2;
        private TabPage tabPage2;
        private TabPage tabPage4;
        private TabPage tabPage3;
        private TabPage tabPage5;
        private ComboBox comboBox6;
        private GroupBox groupBox2;
        private ComboBox comboBox7;
        private GroupBox groupBox12;
        private ComboBox comboBox8;
        private TabControl tabControl3;
        private TabPage tabPage8;
        private TabPage tabPage9;
        private ComboBox comboBox13;
        private ComboBox comboBox12;
        private ComboBox comboBox11;
        private ComboBox comboBox10;
        private ComboBox comboBox9;
        private TextBox textBox86;
        private TextBox textBox87;
        private TextBox textBox92;
        private Label label83;
        private Label label90;
        private Label label84;
        private Label label89;
        private TextBox textBox88;
        private Label label88;
        private TextBox textBox89;
        private Label label87;
        private TextBox textBox90;
        private Label label86;
        private TextBox textBox91;
        private TextBox textBox72;
        private TextBox textBox73;
        private Label label69;
        private Label label70;
        private TextBox textBox74;
        private TextBox textBox75;
        private TextBox textBox76;
        private TextBox textBox77;
        private TextBox textBox78;
        private Label label71;
        private Label label72;
        private Label label73;
        private Label label74;
        private Label label75;
        private TextBox textBox79;
        private TextBox textBox80;
        private Label label76;
        private Label label77;
        private TextBox textBox81;
        private TextBox textBox82;
        private TextBox textBox83;
        private TextBox textBox84;
        private TextBox textBox85;
        private Label label78;
        private Label label79;
        private Label label80;
        private Label label81;
        private Label label82;
        private ComboBox comboBox20;
        private ComboBox comboBox19;
        private ComboBox comboBox18;
        private ComboBox comboBox17;
        private ComboBox comboBox16;
        private ComboBox comboBox15;
        private ComboBox comboBox14;
        private Label label67;
        private Label label68;
        private Label label66;
        private Label label65;
        private Label label64;
        private Label label63;
        private Label label62;
        private ComboBox comboBox22;
        private ComboBox comboBox21;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox7;
        private TextBox textBox11;
        private TextBox textBox9;
        private TextBox textBox98;
        private Label label106;
        private Label label105;
        private Label label107;
        private Label label108;
        private Label label109;
        private TextBox textBox15;
        private TextBox textBox28;
        private TextBox textBox29;
        private TextBox textBox30;
        private TextBox textBox53;
        private TextBox textBox52;
        private TextBox textBox51;
        private TextBox textBox50;
        private TextBox textBox49;
        private TextBox textBox65;
        private TextBox textBox66;
        private TextBox textBox67;
        private TextBox textBox71;
        private TextBox textBox68;
        private TextBox textBox70;
        private TextBox textBox69;
        private TextBox textBox93;
        private Label label94;
        private TextBox textBox64;
        private Label label61;
        private Button button7;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox3;
        private RichTextBox richTextBox2;
        public TextBox textBox8;
        private TabPage tabPage7;
        private GroupBox groupBox7;
        private TextBox textBox103;
        private Label label103;
        private TextBox textBox102;
        private Label label102;
        private Label label99;
        private TextBox textBox100;
        private TextBox textBox97;
        private Label label97;
        private TextBox textBox101;
        private Label label101;
        private TextBox textBox99;
        private Label label100;
        private GroupBox groupBox8;
        private Label label8;
        private Label label9;
        private TextBox textBox26;
        private TextBox textBox27;
        private ToolStripMenuItem exportToolStripMenuItem;
        private ToolStripMenuItem exportStrQuestToolStripMenuItem;

        public QuestEditor()
        {
            InitializeComponent();
        }

        private void LoadListBox()
        {
            //dethunter12 4/11/2018 language system
            if (language == "GER")
            {
                listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArrayGER, Host, User, Password, Database, "select a_index, a_name_ger from t_quest ORDER BY a_index;");
            }
            else if (language == "POL")
            {
                listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArrayPOL, Host, User, Password, Database, "select a_index, a_name_pld from t_quest ORDER BY a_index;");
            }
            else if (language == "BRA")
            {
                listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArrayBRA, Host, User, Password, Database, "select a_index, a_name_brz from t_quest ORDER BY a_index;");
            }
            else if (language == "RUS")
            {
                listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArrayRUS, Host, User, Password, Database, "select a_index, a_name_rus from t_quest ORDER BY a_index;");
            }
            else if (language == "FRA")
            {
                listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArrayFRA, Host, User, Password, Database, "select a_index, a_name_frc from t_quest ORDER BY a_index;");
            }
            else if (language == "ESP")
            {
                listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArrayESP, Host, User, Password, Database, "select a_index, a_name_spn from t_quest ORDER BY a_index;");
            }
            else if (language == "MEX")
            {
                listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArrayMEX, Host, User, Password, Database, "select a_index, a_name_mex from t_quest ORDER BY a_index;");
            }
            else if (language == "THA")
            {
                listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArrayTHA, Host, User, Password, Database, "select a_index, a_name_thai from t_quest ORDER BY a_index;");
            }
            else if (language == "ITA")
            {
                listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArrayITA, Host, User, Password, Database, "select a_index, a_name_ita from t_quest ORDER BY a_index;");
            }
            else if (language == "USA")
            {
                listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArrayUSA, Host, User, Password, Database, "select a_index, a_name_usa from t_quest ORDER BY a_index;");
            }
            //dethunter12 4/11/2018 language end
            else
            {
                listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArray, Host, User, Password, Database, "select a_index, a_name from t_quest ORDER BY a_index;");
            }
        }

        public void SearchList(string searchString)
        {
            searchString = searchString.Replace("\\", "\\\\").Replace("'", "\\'");
            string lower = searchString.ToLower();
            string upper = searchString.ToUpper();
            string str = "";
            if (searchString.Length > 1)
                str = char.ToUpper(searchString[0]).ToString() + searchString.Substring(1);
            //search paramater change language 4/11/2018 dethunter12
            if (language == "GER")
            {
                //search the list box with german
                listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArrayGER, Host, User, Password, Database, "select a_index, a_name_ger from t_quest WHERE a_name_ger LIKE '%" + searchString + "%'" + " OR a_index LIKE '%" + searchString + "%'" + " OR a_name_ger LIKE '%" + lower + "%' OR a_index  LIKE '%" + lower + "%'" + " OR a_name_ger LIKE '%" + upper + "%' OR a_index LIKE '%" + upper + "%'" + " OR a_name_ger LIKE '%" + str + "%' OR a_index LIKE '%" + str + "%'" + " ORDER BY a_index;");

            }
            else if (language == "POL")
            {
                listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArrayPOL, Host, User, Password, Database, "select a_index, a_name_pld from t_quest WHERE a_name_pld LIKE '%" + searchString + "%'" + " OR a_index LIKE '%" + searchString + "%'" + " OR a_name_pld LIKE '%" + lower + "%' OR a_index  LIKE '%" + lower + "%'" + " OR a_name_pld LIKE '%" + upper + "%' OR a_index LIKE '%" + upper + "%'" + " OR a_name_pld LIKE '%" + str + "%' OR a_index LIKE '%" + str + "%'" + " ORDER BY a_index;");

            }
            else if (language == "BRA")
            {
                listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArrayBRA, Host, User, Password, Database, "select a_index, a_name_brz from t_quest WHERE a_name_brz LIKE '%" + searchString + "%'" + " OR a_index LIKE '%" + searchString + "%'" + " OR a_name_brz LIKE '%" + lower + "%' OR a_index  LIKE '%" + lower + "%'" + " OR a_name_brz LIKE '%" + upper + "%' OR a_index LIKE '%" + upper + "%'" + " OR a_name_brz LIKE '%" + str + "%' OR a_index LIKE '%" + str + "%'" + " ORDER BY a_index;");

            }
            else if (language == "RUS")
            {
                listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArrayRUS, Host, User, Password, Database, "select a_index, a_name_rus from t_quest WHERE a_name_rus LIKE '%" + searchString + "%'" + " OR a_index LIKE '%" + searchString + "%'" + " OR a_name_rus LIKE '%" + lower + "%' OR a_index  LIKE '%" + lower + "%'" + " OR a_name_rus LIKE '%" + upper + "%' OR a_index LIKE '%" + upper + "%'" + " OR a_name_rus LIKE '%" + str + "%' OR a_index LIKE '%" + str + "%'" + " ORDER BY a_index;");

            }
            else if (language == "FRA")
            {
                listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArrayFRA, Host, User, Password, Database, "select a_index, a_name_frc from t_quest WHERE a_name_frc LIKE '%" + searchString + "%'" + " OR a_index LIKE '%" + searchString + "%'" + " OR a_name_frc LIKE '%" + lower + "%' OR a_index  LIKE '%" + lower + "%'" + " OR a_name_frc LIKE '%" + upper + "%' OR a_index LIKE '%" + upper + "%'" + " OR a_name_frc LIKE '%" + str + "%' OR a_index LIKE '%" + str + "%'" + " ORDER BY a_index;");

            }
            else if (language == "ESP")
            {
                listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArrayESP, Host, User, Password, Database, "select a_index, a_name_spn from t_quest WHERE a_name_spn LIKE '%" + searchString + "%'" + " OR a_index LIKE '%" + searchString + "%'" + " OR a_name_spn LIKE '%" + lower + "%' OR a_index  LIKE '%" + lower + "%'" + " OR a_name_spn LIKE '%" + upper + "%' OR a_index LIKE '%" + upper + "%'" + " OR a_name_spn LIKE '%" + str + "%' OR a_index LIKE '%" + str + "%'" + " ORDER BY a_index;");

            }
            else if (language == "MEX")
            {
                listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArrayMEX, Host, User, Password, Database, "select a_index, a_name_mex from t_quest WHERE a_name_mex LIKE '%" + searchString + "%'" + " OR a_index LIKE '%" + searchString + "%'" + " OR a_name_mex LIKE '%" + lower + "%' OR a_index  LIKE '%" + lower + "%'" + " OR a_name_mex LIKE '%" + upper + "%' OR a_index LIKE '%" + upper + "%'" + " OR a_name_mex LIKE '%" + str + "%' OR a_index LIKE '%" + str + "%'" + " ORDER BY a_index;");

            }
            else if (language == "THA")
            {
                listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArrayTHA, Host, User, Password, Database, "select a_index, a_name_thai from t_quest WHERE a_name_thai LIKE '%" + searchString + "%'" + " OR a_index LIKE '%" + searchString + "%'" + " OR a_name_thai LIKE '%" + lower + "%' OR a_index  LIKE '%" + lower + "%'" + " OR a_name_thai LIKE '%" + upper + "%' OR a_index LIKE '%" + upper + "%'" + " OR a_name_thai LIKE '%" + str + "%' OR a_index LIKE '%" + str + "%'" + " ORDER BY a_index;");

            }
            else if (language == "ITA")
            {
                listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArrayITA, Host, User, Password, Database, "select a_index, a_name_ita from t_quest WHERE a_name_ita LIKE '%" + searchString + "%'" + " OR a_index LIKE '%" + searchString + "%'" + " OR a_name_ita LIKE '%" + lower + "%' OR a_index  LIKE '%" + lower + "%'" + " OR a_name_ita LIKE '%" + upper + "%' OR a_index LIKE '%" + upper + "%'" + " OR a_name_ita LIKE '%" + str + "%' OR a_index LIKE '%" + str + "%'" + " ORDER BY a_index;");

            }
            else if (language == "USA")
            {
                listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArrayUSA, Host, User, Password, Database, "select a_index, a_name_usa from t_quest WHERE a_name_usa LIKE '%" + searchString + "%'" + " OR a_index LIKE '%" + searchString + "%'" + " OR a_name_usa LIKE '%" + lower + "%' OR a_index  LIKE '%" + lower + "%'" + " OR a_name_usa LIKE '%" + upper + "%' OR a_index LIKE '%" + upper + "%'" + " OR a_name_usa LIKE '%" + str + "%' OR a_index LIKE '%" + str + "%'" + " ORDER BY a_index;");

            }
            else // if none of these do default search a_name
            {
                listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArray, Host, User, Password, Database, "select a_index, a_name from t_quest WHERE a_name LIKE '%" + searchString + "%'" + " OR a_index LIKE '%" + searchString + "%'" + " OR a_name LIKE '%" + lower + "%' OR a_index  LIKE '%" + lower + "%'" + " OR a_name LIKE '%" + upper + "%' OR a_index LIKE '%" + upper + "%'" + " OR a_name LIKE '%" + str + "%' OR a_index LIKE '%" + str + "%'" + " ORDER BY a_index;");

            }
        }
        private void LoadLangAtStartup() //dethunter12 4/12/2018 add
        {
            if (language == "GER")
            {
                lblLang.Text = "German";
            }
            else if (language == "POL")
            {
                lblLang.Text = "Polish";
            }
            else if (language == "BRA")
            {
                lblLang.Text = "Brasilian";
            }
            else if (language == "RUS")
            {
                lblLang.Text = "Russian";
            }
            else if (language == "FRA")
            {
                lblLang.Text = "French";
            }
            else if (language == "ESP")
            {
                lblLang.Text = "Spanish";
            }
            else if (language == "MEX")
            {
                lblLang.Text = "Mex";
            }
            else if (language == "THA")
            {
                lblLang.Text = "Thai";
            }
            else if (language == "ITA")
            {
                lblLang.Text = "Italian";
            }
            else if (language == "USA")
            {
                lblLang.Text = "English";
            }
            else
            {
                lblLang.Text = "";
            }
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            LoadListBox();
            LoadStartUp();
            SelectBoxes();
            LoadLangAtStartup(); //dethunter12 language 4/12/2018

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



        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            tbItemDesc1.Text = ""; //dethunter12 add 6/14/2018
            tbItemDesc2.Text = ""; //dethunter12 add 6/14/2018
            tbItemDesc3.Text = ""; //dethunter12 add 6/14/2018
            tbItemDesc4.Text = ""; //dethunter12 add 6/14/2018
            tbItemDesc5.Text = ""; //dethunter12 add 6/14/2018
            TbPrize2ItemDesc1.Text = ""; //dethunter12 add 6/14/2018
            TbPrize2ItemDesc2.Text = ""; //dethunter12 add 6/14/2018 
            TbPrize2ItemDesc3.Text = ""; //dethunter12 add 6/14/2018
            TbPrize2ItemDesc4.Text = ""; //dethunter12 add 6/14/2018
            TbPrize2ItemDesc5.Text = ""; //dethunter12 add 6/14/2018
            TbPrize2ItemDesc6.Text = ""; //dethunter12 add 6/14/2018
            TbPrize2ItemDesc7.Text = ""; //dethunter12 add 6/14/2018
            TbObj1.Text = ""; //dethunter12 add 6/14/2018
            TbObj2.Text = ""; //dethunter12 add 6/14/2018
            TbObj3.Text = ""; //dethunter12 add 6/14/2018
            TbObjNpc1.Text = ""; //dethunter12 add 6/14/2018
            TbObjNpc2.Text = ""; //dethunter12 add 6/14/2018
            TbObjNpc3.Text = ""; //dethunter12 add 6/14/2018
            TbObj1Npc1.Text = ""; //dethunter12 add 6/14/2018
            TbObj1Npc2.Text = ""; //dethunter12 add 6/14/2018
            TbObj1Npc3.Text = ""; //dethunter12 add 6/14/2018
            TbObj2Npc1.Text = ""; //dethunter12 add 6/14/2018
            TbObj2Npc2.Text = ""; //dethunter12 add 6/14/2018
            TbObj2Npc3.Text = ""; //dethunter12 add 6/14/2018
            TbStartNpcName.Text = ""; //dethunter12 add 6/14/2018
            TbEndNpcName.Text = ""; //dethunter12 add 6/14/2018
            TbNeedName1.Text = ""; //dethunter12 add 6/14/2018
            TbNeedName2.Text = ""; //dethunter12 add 6/14/2018
            TbNeedName3.Text = ""; //dethunter12 add 6/14/2018
            TbNeedName4.Text = ""; //dethunter12 add 6/14/2018
            TbNeedName5.Text = ""; //dethunter12 add 6/14/2018
            textBox2.BackColor = Color.White;
            textBox2.BackColor = Color.White;
            textBox5.BackColor = Color.White;
            textBox6.BackColor = Color.White;
            textBox8.BackColor = Color.White;
            textBox10.BackColor = Color.White;
            textBox12.BackColor = Color.White;
            textBox13.BackColor = Color.White;
            textBox14.BackColor = Color.White;
            textBox16.BackColor = Color.White;
            textBox17.BackColor = Color.White;
            textBox18.BackColor = Color.White;
            textBox19.BackColor = Color.White;
            textBox20.BackColor = Color.White;
            textBox21.BackColor = Color.White;
            textBox22.BackColor = Color.White;
            textBox23.BackColor = Color.White;
            textBox24.BackColor = Color.White;
            textBox25.BackColor = Color.White;
            textBox26.BackColor = Color.White;
            textBox27.BackColor = Color.White;
            textBox31.BackColor = Color.White;
            textBox32.BackColor = Color.White;
            textBox33.BackColor = Color.White;
            textBox34.BackColor = Color.White;
            textBox35.BackColor = Color.White;
            textBox36.BackColor = Color.White;
            textBox37.BackColor = Color.White;
            textBox38.BackColor = Color.White;
            textBox39.BackColor = Color.White;
            textBox40.BackColor = Color.White;
            textBox41.BackColor = Color.White;
            textBox42.BackColor = Color.White;
            textBox43.BackColor = Color.White;
            textBox44.BackColor = Color.White;
            textBox45.BackColor = Color.White;
            textBox46.BackColor = Color.White;
            textBox47.BackColor = Color.White;
            textBox48.BackColor = Color.White;
            textBox54.BackColor = Color.White;
            textBox55.BackColor = Color.White;
            textBox56.BackColor = Color.White;
            textBox57.BackColor = Color.White;
            textBox58.BackColor = Color.White;
            textBox59.BackColor = Color.White;
            textBox60.BackColor = Color.White;
            textBox61.BackColor = Color.White;
            textBox62.BackColor = Color.White;
            textBox63.BackColor = Color.White;
            textBox64.BackColor = Color.White;
            textBox72.BackColor = Color.White;
            textBox73.BackColor = Color.White;
            textBox74.BackColor = Color.White;
            textBox75.BackColor = Color.White;
            textBox76.BackColor = Color.White;
            textBox77.BackColor = Color.White;
            textBox78.BackColor = Color.White;
            textBox79.BackColor = Color.White;
            textBox80.BackColor = Color.White;
            textBox81.BackColor = Color.White;
            textBox82.BackColor = Color.White;
            textBox83.BackColor = Color.White;
            textBox84.BackColor = Color.White;
            textBox85.BackColor = Color.White;
            textBox86.BackColor = Color.White;
            textBox87.BackColor = Color.White;
            textBox88.BackColor = Color.White;
            textBox89.BackColor = Color.White;
            textBox90.BackColor = Color.White;
            textBox91.BackColor = Color.White;
            textBox92.BackColor = Color.White;
            textBox93.BackColor = Color.White;
            richTextBox1.BackColor = Color.White;
            richTextBox2.BackColor = Color.White;
            richTextBox3.BackColor = Color.White;
            textBox97.BackColor = Color.White;
            textBox99.BackColor = Color.White;
            textBox100.BackColor = Color.White;
            textBox101.BackColor = Color.White;
            textBox102.BackColor = Color.White;
            textBox103.BackColor = Color.White;
            textBox104.BackColor = Color.White;
            comboBox1.BackColor = Color.White;
            comboBox2.BackColor = Color.White;
            comboBox3.BackColor = Color.White;
            comboBox4.BackColor = Color.White;
            comboBox5.BackColor = Color.White;
            comboBox6.BackColor = Color.White;
            comboBox7.BackColor = Color.White;
            comboBox8.BackColor = Color.White;
            comboBox9.BackColor = Color.White;
            comboBox10.BackColor = Color.White;
            comboBox11.BackColor = Color.White;
            comboBox12.BackColor = Color.White;
            comboBox13.BackColor = Color.White;
            comboBox14.BackColor = Color.White;
            comboBox15.BackColor = Color.White;
            comboBox16.BackColor = Color.White;
            comboBox17.BackColor = Color.White;
            comboBox18.BackColor = Color.White;
            comboBox19.BackColor = Color.White;
            comboBox20.BackColor = Color.White;
            comboBox21.BackColor = Color.White;
            comboBox22.BackColor = Color.White;
            textBox1.Text = GetIndex().ToString();
            string Query = " select a_index , a_name , a_type1 , a_type2 , a_enable , a_prequest_num , a_start_type , a_start_data , a_start_npc_zone_num , a_prize_npc , a_prize_npc_zone_num , a_need_exp , a_need_min_level , a_need_max_level , a_need_job , a_need_item0 , a_need_item1 , a_need_item2 , a_need_item3 , a_need_item4 , a_need_item_count0 , a_need_item_count1 , a_need_item_count2 , a_need_item_count3 , a_need_item_count4 , a_need_rvr_type , a_need_rvr_grade , a_condition0_type , a_condition1_type , a_condition2_type , a_condition0_index , a_condition1_index , a_condition2_index , a_condition0_num , a_condition1_num , a_condition2_num , a_condition0_data0 , a_condition0_data1 , a_condition0_data2 , a_condition0_data3 , a_condition1_data0 , a_condition1_data1 , a_condition1_data2 , a_condition1_data3 , a_condition2_data0 , a_condition2_data1 , a_condition2_data2 , a_condition2_data3 , a_prize_type0 , a_prize_type1 , a_prize_type2 , a_prize_type3 , a_prize_type4 , a_prize_index0 , a_prize_index1 , a_prize_index2 , a_prize_index3 , a_prize_index4 , a_prize_data0 , a_prize_data1 , a_prize_data2 , a_prize_data3 , a_prize_data4 , a_option_prize , a_opt_prize_type0 , a_opt_prize_type1 , a_opt_prize_type2 , a_opt_prize_type3 , a_opt_prize_type4 , a_opt_prize_type5 , a_opt_prize_type6 , a_opt_prize_index0 , a_opt_prize_index1 , a_opt_prize_index2 , a_opt_prize_index3 , a_opt_prize_index4 , a_opt_prize_index5 a_opt_prize_index5 , a_opt_prize_index6 , a_opt_prize_data0 , a_opt_prize_data1 , a_opt_prize_data2 , a_opt_prize_data3 , a_opt_prize_data4 , a_opt_prize_data5 , a_opt_prize_data6 , a_opt_prize_plus0 , a_opt_prize_plus1 , a_opt_prize_plus2 , a_opt_prize_plus3 , a_opt_prize_plus4 , a_opt_prize_plus5 , a_opt_prize_plus6 , a_only_opt_prize , a_desc_usa , a_desc2_usa , a_desc3_usa , a_failvalue , a_partyscale , a_start_give_item , a_start_give_kindcount , a_start_give_numcount , a_start_trigger_id , a_quest_flag, a_name_ger, a_desc_ger, a_desc2_ger, a_desc3_ger, a_name_rus, a_desc_rus, a_desc2_rus, a_desc3_rus, a_name_thai, a_desc_thai, a_desc2_thai, a_desc3_thai, a_name_frc, a_desc_frc, a_desc2_frc, a_desc3_frc, a_name_mex, a_desc_mex, a_desc2_mex, a_desc3_mex, a_name_brz, a_desc_brz, a_desc2_brz, a_desc3_brz, a_name_spn, a_desc_spn, a_desc2_spn, a_desc3_spn, a_name_ita, a_desc_ita, a_desc2_ita, a_desc3_ita, a_name_pld, a_desc_pld, a_desc2_pld, a_desc3_pld, a_name_usa from t_quest WHERE a_index ='" + textBox1.Text + "';"; //dethunter12 4/11/2018 lang select modify
            string[] rows = new string[140]
            {
        "a_index", //0
        "a_name", //1
        "a_type1", //2
        "a_type2",//3
        "a_enable",//4
        "a_prequest_num",//5
        "a_start_type",//6
        "a_start_data",//7
        "a_start_npc_zone_num",//8
        "a_prize_npc",//9
        "a_prize_npc_zone_num",//10
        "a_need_exp",//11
        "a_need_min_level",//12
        "a_need_max_level",//13
        "a_need_job",//14
        "a_need_item0",//15
        "a_need_item1",//16
        "a_need_item2",//17
        "a_need_item3",//18
        "a_need_item4",//19
        "a_need_item_count0",//20
        "a_need_item_count1",//21
        "a_need_item_count2",//22
        "a_need_item_count3",//23
        "a_need_item_count4",//24
        "a_need_rvr_type",//25
        "a_need_rvr_grade",//26
        "a_condition0_type",//27
        "a_condition1_type",//28
        "a_condition2_type",//29
        "a_condition0_index",//30
        "a_condition1_index",//31
        "a_condition2_index",//32
        "a_condition0_num",//33
        "a_condition1_num",//34
        "a_condition2_num",//35
        "a_condition0_data0",//36
        "a_condition0_data1",//37
        "a_condition0_data2",//38
        "a_condition0_data3",//39
        "a_condition1_data0",//40
        "a_condition1_data1",//41
        "a_condition1_data2",//42
        "a_condition1_data3",//43
        "a_condition2_data0",//44
        "a_condition2_data1",//45
        "a_condition2_data2",//46
        "a_condition2_data3",//47
        "a_prize_type0",//48
        "a_prize_type1",//49
        "a_prize_type2",//50
        "a_prize_type3",//51
        "a_prize_type4",//52
        "a_prize_index0",//53
        "a_prize_index1",//54
        "a_prize_index2",//55
        "a_prize_index3",//56
        "a_prize_index4",//57
        "a_prize_data0",//58
        "a_prize_data1",//59
        "a_prize_data2",//60
        "a_prize_data3",//61
        "a_prize_data4",//62
        "a_option_prize",//63
        "a_opt_prize_type0",//64
        "a_opt_prize_type1",//65
        "a_opt_prize_type2",//66
        "a_opt_prize_type3",//67
        "a_opt_prize_type4",//68
        "a_opt_prize_type5",//69
        "a_opt_prize_type6",//70
        "a_opt_prize_index0",//71
        "a_opt_prize_index1",//72
        "a_opt_prize_index2",//73
        "a_opt_prize_index3",//74
        "a_opt_prize_index4",//75
        "a_opt_prize_index5",//76
        "a_opt_prize_index6",//77
        "a_opt_prize_data0",//78
        "a_opt_prize_data1",//79
        "a_opt_prize_data2",//80
        "a_opt_prize_data3",//81
        "a_opt_prize_data4",//82
        "a_opt_prize_data5",//83
        "a_opt_prize_data6",//84
        "a_opt_prize_plus0",//85
        "a_opt_prize_plus1",//86
        "a_opt_prize_plus2",//87
        "a_opt_prize_plus3",//88
        "a_opt_prize_plus4",//89
        "a_opt_prize_plus5",//90
        "a_opt_prize_plus6",//91
        "a_only_opt_prize",//92
        "a_desc_usa", //93
        "a_desc2_usa",//94
        "a_desc3_usa",//95
        "a_failvalue",//96
        "a_partyscale",//97
        "a_start_give_item",//98
        "a_start_give_kindcount",//99
        "a_start_give_numcount",//100
        "a_start_trigger_id",//101
        "a_quest_flag",//102
        //dethunter12 4/11/2018 lang select
        "a_name_ger",//103
        "a_desc_ger",//104
        "a_desc2_ger",//105
        "a_desc3_ger",//106
        "a_name_rus",//107
        "a_desc_rus",//108
        "a_desc2_rus",//109
        "a_desc3_rus",//110
        "a_name_thai",//111
        "a_desc_thai",//112
         "a_desc2_thai",//113
         "a_desc3_thai",//114
         "a_name_frc",//115
         "a_desc_frc",//116
        "a_desc2_frc",//117
         "a_desc3_frc",//118
         "a_name_mex",//119
         "a_desc_mex",//120
         "a_desc2_mex",//121
         "a_desc3_mex",//122
         "a_name_brz",//123
         "a_desc_brz",//124
         "a_desc2_brz",//125
        "a_desc3_brz",//126
        "a_name_spn",//127
        "a_desc_spn",//128
         "a_desc2_spn",//129
        "a_desc3_spn",//130
         "a_name_ita",//131
         "a_desc_ita",//132
         "a_desc2_ita",//133
         "a_desc3_ita",//134
          "a_name_pld",//135
        "a_desc_pld",//136
         "a_desc2_pld",//137
         "a_desc3_pld",//138
          "a_name_usa" //139
            };
            Query.Replace("'", "\\'").Replace("\\", "\\\\").Replace("'", "\\'");
            string[] strArray = databaseHandle.SelectMySqlReturnArray(Host, User, Password, Database, Query, rows);
            textBox1.Text = strArray[0];
            //textBox2.Text = strArray[1];
            textBox3.Text = strArray[2];
            textBox4.Text = strArray[3];
            textBox5.Text = strArray[4];
            textBox6.Text = strArray[5];
            textBox7.Text = strArray[6];
            textBox8.Text = strArray[7];
            textBox9.Text = strArray[8];
            textBox10.Text = strArray[9];
            textBox11.Text = strArray[10];
            textBox12.Text = strArray[11];
            textBox13.Text = strArray[12];
            textBox14.Text = strArray[13];
            textBox15.Text = strArray[14];
            textBox16.Text = strArray[15];
            textBox17.Text = strArray[16];
            textBox18.Text = strArray[17];
            textBox19.Text = strArray[18];
            textBox20.Text = strArray[19];
            textBox21.Text = strArray[20];
            textBox22.Text = strArray[21];
            textBox23.Text = strArray[22];
            textBox24.Text = strArray[23];
            textBox25.Text = strArray[24];
            textBox26.Text = strArray[25];
            textBox27.Text = strArray[26];
            textBox28.Text = strArray[27];
            textBox29.Text = strArray[28];
            textBox30.Text = strArray[29];
            textBox31.Text = strArray[30];
            textBox32.Text = strArray[31];
            textBox33.Text = strArray[32];
            textBox34.Text = strArray[33];
            textBox35.Text = strArray[34];
            textBox36.Text = strArray[35];
            textBox37.Text = strArray[36];
            textBox38.Text = strArray[37];
            textBox39.Text = strArray[38];
            textBox40.Text = strArray[39];
            textBox41.Text = strArray[40];
            textBox42.Text = strArray[41];
            textBox43.Text = strArray[42];
            textBox44.Text = strArray[43];
            textBox45.Text = strArray[44];
            textBox46.Text = strArray[45];
            textBox47.Text = strArray[46];
            textBox48.Text = strArray[47];
            textBox49.Text = strArray[48];
            textBox50.Text = strArray[49];
            textBox51.Text = strArray[50];
            textBox52.Text = strArray[51];
            textBox53.Text = strArray[52];
            textBox54.Text = strArray[53];
            textBox55.Text = strArray[54];
            textBox56.Text = strArray[55];
            textBox57.Text = strArray[56];
            textBox58.Text = strArray[57];
            textBox59.Text = strArray[58];
            textBox60.Text = strArray[59];
            textBox61.Text = strArray[60];
            textBox62.Text = strArray[61];
            textBox63.Text = strArray[62];
            textBox64.Text = strArray[63];
            textBox65.Text = strArray[64];
            textBox66.Text = strArray[65];
            textBox67.Text = strArray[66];
            textBox68.Text = strArray[67];
            textBox69.Text = strArray[68];
            textBox70.Text = strArray[69];
            textBox71.Text = strArray[70];
            textBox72.Text = strArray[71];
            textBox73.Text = strArray[72];
            textBox74.Text = strArray[73];
            textBox75.Text = strArray[74];
            textBox76.Text = strArray[75];
            textBox77.Text = strArray[76];
            textBox78.Text = strArray[77];
            textBox79.Text = strArray[78];
            textBox80.Text = strArray[79];
            textBox81.Text = strArray[80];
            textBox82.Text = strArray[81];
            textBox83.Text = strArray[82];
            textBox84.Text = strArray[83];
            textBox85.Text = strArray[84];
            textBox86.Text = strArray[85];
            textBox87.Text = strArray[86];
            textBox88.Text = strArray[87];
            textBox89.Text = strArray[88];
            textBox90.Text = strArray[89];
            textBox91.Text = strArray[90];
            textBox92.Text = strArray[91];
            textBox93.Text = strArray[92];
            //dethunter12 4/11/2018 language system
            if (language == "FRA")
            {
                textBox2.Text = strArray[115]; //name
                richTextBox1.Text = strArray[116];//desc
                richTextBox2.Text = strArray[117];///desc2
                richTextBox3.Text = strArray[118];///desc3
            }
            else if (language == "USA")
            {
                textBox2.Text = strArray[139];
                richTextBox1.Text = strArray[93];
                richTextBox2.Text = strArray[94];
                richTextBox3.Text = strArray[95];
            }
            else if (language == "ITA")
            {
                textBox2.Text = strArray[131];
                richTextBox1.Text = strArray[132];
                richTextBox2.Text = strArray[133];
                richTextBox3.Text = strArray[134];
            }
            else if (language == "RUS")
            {
                textBox2.Text = strArray[107];
                richTextBox1.Text = strArray[108];
                richTextBox2.Text = strArray[109];
                richTextBox3.Text = strArray[110];
            }
            else if (language == "THA")
            {
                textBox2.Text = strArray[111];
                richTextBox1.Text = strArray[112];
                richTextBox2.Text = strArray[113];
                richTextBox3.Text = strArray[114];
            }
            else if (language == "POL")
            {
                textBox2.Text = strArray[135];
                richTextBox1.Text = strArray[136];
                richTextBox2.Text = strArray[137];
                richTextBox3.Text = strArray[138];
            }
            else if (language == "ESP")
            {
                textBox2.Text = strArray[127];
                richTextBox1.Text = strArray[128];
                richTextBox2.Text = strArray[129];
                richTextBox3.Text = strArray[130];
            }
            else if (language == "BRA")
            {
                textBox2.Text = strArray[123];
                richTextBox1.Text = strArray[124];
                richTextBox2.Text = strArray[125];
                richTextBox3.Text = strArray[126];
            }
            else if (language == "GER")
            {
                textBox2.Text = strArray[103];
                richTextBox1.Text = strArray[104];
                richTextBox2.Text = strArray[105];
                richTextBox3.Text = strArray[106];
            }
            else if (language == "MEX")
            {
                textBox2.Text = strArray[119];
                richTextBox1.Text = strArray[120];
                richTextBox2.Text = strArray[121];
                richTextBox3.Text = strArray[122];
            }
            else if (language != "GER" && language != "POL" && language != "BRA" && language != "RUS" && language != "FRA" && language != "ESP" && language != "MEX" && language != "THA" && language != "ITA" && language != "USA") //if language isnt any of the supported language lists then use default a_name 
            {
                textBox2.Text = strArray[1];
                richTextBox1.Text = strArray[93];
                richTextBox2.Text = strArray[94];
                richTextBox3.Text = strArray[95];
            }
            // richTextBox1.Text = strArray[93];
            // richTextBox2.Text = strArray[94];
            //richTextBox3.Text = strArray[95];

            textBox97.Text = strArray[96];
            textBox98.Text = strArray[97];
            textBox99.Text = strArray[98];
            textBox100.Text = strArray[99];
            textBox101.Text = strArray[100];
            textBox102.Text = strArray[101];
            textBox103.Text = strArray[102];
            SelectMobItemNames(); //dethunter12 add 6/14/2018
            SelectBoxes();
           
    }
        private void SelectMobItemNames()
        {
            if (textBox72.Text != "0") // if value is not empty load the name from itemnamefast according to textbox value
            {
                TbPrize2ItemDesc1.Text = databaseHandle.ItemNameFast(Convert.ToInt32(textBox72.Text)); //dethunter12 add 6/14/2018
            }
            if (textBox73.Text != "0")
            {
                TbPrize2ItemDesc2.Text = databaseHandle.ItemNameFast(Convert.ToInt32(textBox73.Text)); //dethunter12 add 6/14/2018
            }
            if (textBox74.Text != "0")
            {
                TbPrize2ItemDesc3.Text = databaseHandle.ItemNameFast(Convert.ToInt32(textBox74.Text)); //dethunter12 add 6/14/2018
            }
            if (textBox75.Text != "0")
            {
                TbPrize2ItemDesc4.Text = databaseHandle.ItemNameFast(Convert.ToInt32(textBox75.Text)); //dethunter12 add 6/14/2018
            }
            if (textBox76.Text != "0")
            {
                TbPrize2ItemDesc5.Text = databaseHandle.ItemNameFast(Convert.ToInt32(textBox76.Text)); //dethunter12 add 6/14/2018
            }
            if (textBox77.Text != "0")
            {
                TbPrize2ItemDesc6.Text = databaseHandle.ItemNameFast(Convert.ToInt32(textBox77.Text)); //dethunter12 add 6/14/2018
            }
            if (textBox78.Text != "0")
            {
                TbPrize2ItemDesc7.Text = databaseHandle.ItemNameFast(Convert.ToInt32(textBox78.Text)); //dethunter12 add 6/14/2018
            }
            if (textBox54.Text != "0")
            {
                tbItemDesc1.Text = databaseHandle.ItemNameFast(Convert.ToInt32(textBox54.Text)); //dethunter12 add 6/14/2018
            }
            if (textBox55.Text != "0")
            {
                tbItemDesc2.Text = databaseHandle.ItemNameFast(Convert.ToInt32(textBox55.Text)); //dethunter12 add 6/14/2018
            }
            if (textBox56.Text != "0")
            {
                tbItemDesc3.Text = databaseHandle.ItemNameFast(Convert.ToInt32(textBox56.Text)); //dethunter12 add 6/14/2018
            }
            if (textBox57.Text != "0")
            {
                tbItemDesc4.Text = databaseHandle.ItemNameFast(Convert.ToInt32(textBox57.Text)); //dethunter12 add 6/14/2018
            }
            if (textBox58.Text != "0")
            {
                tbItemDesc5.Text = databaseHandle.ItemNameFast(Convert.ToInt32(textBox58.Text)); //dethunter12 add 6/14/2018
            }
            if (textBox31.Text != "0" && textBox28.Text != "0" && textBox28.Text != "3" && textBox28.Text != "4" && textBox28.Text != "6" && textBox28.Text != "7" && textBox28.Text != "8" || textBox28.Text == "1" || textBox28.Text == "2" || textBox28.Text == "5") //if textbox isnt 0 and type textbox isnt 0,3,4,6,7 (non-item types) or textbox is (itemtypes) then pull the name
            {
                
                TbObj1.Text = databaseHandle.ItemNameFast(Convert.ToInt32(textBox31.Text)); //dethunter12 add 6/14/2018
                TbObj1.ForeColor = Color.RoyalBlue;
            }
            if (textBox32.Text != "0" && textBox29.Text != "0" && textBox29.Text != "3" && textBox29.Text != "4" && textBox29.Text != "6" && textBox29.Text != "7" && textBox29.Text != "8" || textBox29.Text == "1" || textBox29.Text == "2" || textBox29.Text == "5") //if textbox isnt 0 and type textbox isnt 0,3,4,6,7 (non-item types) or textbox is (itemtypes) then pull the name
            {
                TbObj2.Text = databaseHandle.ItemNameFast(Convert.ToInt32(textBox32.Text)); //dethunter12 add 6/14/2018
                TbObj2.ForeColor = Color.RoyalBlue;
            }
            if (textBox33.Text != "0" && textBox30.Text != "0" && textBox30.Text != "3" && textBox30.Text != "4" && textBox30.Text != "6" && textBox30.Text != "7" && textBox30.Text != "8" || textBox30.Text == "1" || textBox30.Text == "2" || textBox30.Text == "5") //if textbox isnt 0 and type textbox isnt 0,3,4,6,7 (non-item types) or textbox is (itemtypes) then pull the name
            {
                TbObj3.Text = databaseHandle.ItemNameFast(Convert.ToInt32(textBox33.Text)); //dethunter12 add 6/14/2018
                TbObj3.ForeColor = Color.RoyalBlue;
            }
            if (textBox31.Text != "0" && textBox28.Text == "0")
            {
                TbObj1.Text = databaseHandle.MobNameFast(Convert.ToInt32(textBox31.Text)); //dethunter12 add 6/14/2018
                TbObj1.ForeColor = Color.Red;
            }
            if (textBox32.Text != "0" && textBox29.Text == "0")
            {
                TbObj2.Text = databaseHandle.MobNameFast(Convert.ToInt32(textBox32.Text)); //dethunter12 add 6/14/2018
                TbObj2.ForeColor = Color.Red;
            }
            if (textBox33.Text != "0" && textBox30.Text == "0")
            {
                TbObj3.Text = databaseHandle.MobNameFast(Convert.ToInt32(textBox33.Text)); //dethunter12 add 6/14/2018
                TbObj3.ForeColor = Color.Red;
            }
            if (textBox45.Text != "0") //dethunter12 add 6/14/2018
            {
                TbObjNpc1.Text = databaseHandle.MobNameFast(Convert.ToInt32(textBox45.Text));
            }
            if (textBox46.Text != "0") //dethunter12 add 6/14/2018
            {
                TbObjNpc2.Text = databaseHandle.MobNameFast(Convert.ToInt32(textBox46.Text));
            }
            if (textBox47.Text != "0") //dethunter12 add 6/14/2018
            {
                TbObjNpc3.Text = databaseHandle.MobNameFast(Convert.ToInt32(textBox47.Text));
            }
            if (textBox37.Text != "0") //dethunter12 add 6/14/2018
            {
                TbObj1Npc1.Text = databaseHandle.MobNameFast(Convert.ToInt32(textBox37.Text));
            }
            if (textBox38.Text != "0") //dethunter12 add 6/14/2018
            {
                TbObj1Npc2.Text = databaseHandle.MobNameFast(Convert.ToInt32(textBox38.Text));
            }
            if (textBox39.Text != "0") //dethunter12 add 6/14/2018
            {
                TbObj1Npc3.Text = databaseHandle.MobNameFast(Convert.ToInt32(textBox39.Text));
            }
            if (textBox41.Text != "0") //dethunter12 add 6/14/2018
            {
                TbObj2Npc1.Text = databaseHandle.MobNameFast(Convert.ToInt32(textBox41.Text));
            }
            if (textBox42.Text != "0") //dethunter12 add 6/14/2018
            {
                TbObj2Npc2.Text = databaseHandle.MobNameFast(Convert.ToInt32(textBox42.Text));
            }
            if (textBox43.Text != "0") //dethunter12 add 6/14/2018
            {
                TbObj2Npc3.Text = databaseHandle.MobNameFast(Convert.ToInt32(textBox43.Text));
            }
            if (textBox7.Text == "0" && textBox8.Text != "0" && textBox8.Text !="-1")
            {
                TbStartNpcName.Text = databaseHandle.MobNameFast(Convert.ToInt32(textBox8.Text)); //dethunter12 add 6/14/2018
                TbStartNpcName.ForeColor = Color.LimeGreen;
            }
            if (textBox10.Text != "0" && textBox10.Text != "-1")
            {
                TbEndNpcName.Text = databaseHandle.MobNameFast(Convert.ToInt32(textBox10.Text)); //dethunter12 add 6/14/2018
            }
            
            if (textBox7.Text == "1")
            {
                TbStartNpcName.Text = databaseHandle.ItemNameFast(Convert.ToInt32(textBox8.Text)); //dethunter12 add 6/14/2018
                TbStartNpcName.ForeColor = Color.RoyalBlue;
            }


            if (textBox16.Text != "-1")
            {
                TbNeedName1.Text = databaseHandle.ItemNameFast(Convert.ToInt32(textBox16.Text)); //dethunter12 add 6/14/2018
            }
            if (textBox17.Text != "-1")
            {
                TbNeedName2.Text = databaseHandle.ItemNameFast(Convert.ToInt32(textBox17.Text)); //dethunter12 add 6/14/2018
            }
            if (textBox18.Text != "-1")
            {
                TbNeedName3.Text = databaseHandle.ItemNameFast(Convert.ToInt32(textBox18.Text)); //dethunter12 add 6/14/2018
            }
            if (textBox19.Text != "-1")
            {
                TbNeedName4.Text = databaseHandle.ItemNameFast(Convert.ToInt32(textBox19.Text)); //dethunter12 add 6/14/2018
            }
            if (textBox20.Text != "-1")
            {
                TbNeedName5.Text = databaseHandle.ItemNameFast(Convert.ToInt32(textBox20.Text)); //dethunter12 add 6/14/2018
            }
        } //dethunter12 add 6/14/2018
        private void SelectBoxes()
    {
      int num1 = comboBox1.FindString(textBox3.Text);
      int num2 = comboBox2.FindString(textBox4.Text);
      int num3 = comboBox5.FindString(textBox7.Text);
      int num4 = comboBox21.FindString(textBox9.Text);
      int num5 = comboBox22.FindString(textBox9.Text);
      int num6 = comboBox4.FindString(textBox98.Text);
      int num7 = comboBox3.FindString(textBox15.Text);
      int num8 = comboBox6.FindString(textBox28.Text);
      int num9 = comboBox7.FindString(textBox29.Text);
      int num10 = comboBox8.FindString(textBox30.Text);
      int num11 = comboBox9.FindString(textBox49.Text);
      int num12 = comboBox10.FindString(textBox50.Text);
      int num13 = comboBox11.FindString(textBox51.Text);
      int num14 = comboBox12.FindString(textBox52.Text);
      int num15 = comboBox13.FindString(textBox53.Text);
      int num16 = comboBox14.FindString(textBox65.Text);
      int num17 = comboBox15.FindString(textBox66.Text);
      int num18 = comboBox16.FindString(textBox67.Text);
      int num19 = comboBox17.FindString(textBox68.Text);
      int num20 = comboBox18.FindString(textBox69.Text);
      int num21 = comboBox19.FindString(textBox70.Text);
      int num22 = comboBox20.FindString(textBox71.Text);
      int num23 = CbRvrType.FindString(textBox26.Text); //dethunter12 add 6/11/2018
      int num24 = CbRvRGrade.FindString(textBox27.Text); //dethunter12 add 6/11/2018
      int num25 = CbRvRGrade1.FindString(textBox27.Text); //dethunter12 add 6/11/2018
            comboBox1.SelectedIndex = num1;
            comboBox2.SelectedIndex = num2;
            comboBox5.SelectedIndex = num3;
            comboBox21.SelectedIndex = num4;
            comboBox22.SelectedIndex = num5;
            comboBox4.SelectedIndex = num6;
            comboBox3.SelectedIndex = num7;
            comboBox6.SelectedIndex = num8;
            comboBox7.SelectedIndex = num9;
            comboBox8.SelectedIndex = num10;
            comboBox9.SelectedIndex = num11;
            comboBox10.SelectedIndex = num12;
            comboBox11.SelectedIndex = num13;
            comboBox12.SelectedIndex = num14;
            comboBox13.SelectedIndex = num15;
            comboBox14.SelectedIndex = num16;
            comboBox15.SelectedIndex = num17;
            comboBox16.SelectedIndex = num18;
            comboBox17.SelectedIndex = num19;
            comboBox18.SelectedIndex = num20;
            comboBox19.SelectedIndex = num21;
            comboBox20.SelectedIndex = num22;
            CbRvrType.SelectedIndex = num23; //dethunter12 add 6/11/2018
            CbRvRGrade.SelectedIndex = num24; //dethunter12 add 6/11/2018
            CbRvRGrade1.SelectedIndex = num25; //dethunter12 add 6/11/2018
    }

    private void button2_Click(object sender, EventArgs e)
    {
      string str1 = "UPDATE t_quest SET " + "a_index = '" + textBox1.Text + "', ";
      string str2 = textBox2.Text.Replace("'", "\\'").Replace("\"", "\\\"");
      string str3 = str1 + "a_name = '" + str2 + "', " + "a_name_usa = '" + str2 + "', " + "a_type1 = '" + textBox3.Text + "', " + "a_type2 = '" + textBox4.Text + "', " + "a_enable = '" + textBox5.Text + "', " + "a_prequest_num = '" + textBox6.Text + "', " + "a_start_type = '" + textBox7.Text + "', " + "a_start_data = '" + textBox8.Text + "', " + "a_start_npc_zone_num = '" + textBox9.Text + "', " + "a_prize_npc = '" + textBox10.Text + "', " + "a_prize_npc_zone_num = '" + textBox11.Text + "', " + "a_need_exp = '" + textBox12.Text + "', " + "a_need_min_level = '" + textBox13.Text + "', " + "a_need_max_level = '" + textBox14.Text + "', " + "a_need_job = '" + textBox15.Text + "', " + "a_need_item0 = '" + textBox16.Text + "', " + "a_need_item1 = '" + textBox17.Text + "', " + "a_need_item2 = '" + textBox18.Text + "', " + "a_need_item3 = '" + textBox19.Text + "', " + "a_need_item4 = '" + textBox20.Text + "', " + "a_need_item_count0 = '" + textBox21.Text + "', " + "a_need_item_count1 = '" + textBox22.Text + "', " + "a_need_item_count2 = '" + textBox23.Text + "', " + "a_need_item_count3 = '" + textBox24.Text + "', " + "a_need_item_count4 = '" + textBox25.Text + "', " + "a_need_rvr_type = '" + textBox26.Text + "', " + "a_need_rvr_grade = '" + textBox27.Text + "', " + "a_condition0_type = '" + textBox28.Text + "', " + "a_condition1_type = '" + textBox29.Text + "', " + "a_condition2_type = '" + textBox30.Text + "', " + "a_condition0_index = '" + textBox31.Text + "', " + "a_condition1_index = '" + textBox32.Text + "', " + "a_condition2_index = '" + textBox33.Text + "', " + "a_condition0_num = '" + textBox34.Text + "', " + "a_condition1_num = '" + textBox35.Text + "', " + "a_condition2_num = '" + textBox36.Text + "', " + "a_condition0_data0 = '" + textBox37.Text + "', " + "a_condition0_data1 = '" + textBox38.Text + "', " + "a_condition0_data2 = '" + textBox39.Text + "', " + "a_condition0_data3 = '" + textBox40.Text + "', " + "a_condition1_data0 = '" + textBox41.Text + "', " + "a_condition1_data1 = '" + textBox42.Text + "', " + "a_condition1_data2 = '" + textBox43.Text + "', " + "a_condition1_data3 = '" + textBox44.Text + "', " + "a_condition2_data0 = '" + textBox45.Text + "', " + "a_condition2_data1 = '" + textBox46.Text + "', " + "a_condition2_data2 = '" + textBox47.Text + "', " + "a_condition2_data3 = '" + textBox48.Text + "', " + "a_prize_type0 = '" + textBox49.Text + "', " + "a_prize_type1 = '" + textBox50.Text + "', " + "a_prize_type2 = '" + textBox51.Text + "', " + "a_prize_type3 = '" + textBox52.Text + "', " + "a_prize_type4 = '" + textBox53.Text + "', " + "a_prize_index0 = '" + textBox54.Text + "', " + "a_prize_index1 = '" + textBox55.Text + "', " + "a_prize_index2 = '" + textBox56.Text + "', " + "a_prize_index3 = '" + textBox57.Text + "', " + "a_prize_index4 = '" + textBox58.Text + "', " + "a_prize_data0 = '" + textBox59.Text + "', " + "a_prize_data1 = '" + textBox60.Text + "', " + "a_prize_data2 = '" + textBox61.Text + "', " + "a_prize_data3 = '" + textBox62.Text + "', " + "a_prize_data4 = '" + textBox63.Text + "', " + "a_option_prize = '" + textBox64.Text + "', " + "a_opt_prize_type0 = '" + textBox65.Text + "', " + "a_opt_prize_type1 = '" + textBox66.Text + "', " + "a_opt_prize_type2 = '" + textBox67.Text + "', " + "a_opt_prize_type3 = '" + textBox68.Text + "', " + "a_opt_prize_type4 = '" + textBox69.Text + "', " + "a_opt_prize_type5 = '" + textBox70.Text + "', " + "a_opt_prize_type6 = '" + textBox71.Text + "', " + "a_opt_prize_index0 = '" + textBox72.Text + "', " + "a_opt_prize_index1 = '" + textBox73.Text + "', " + "a_opt_prize_index2 = '" + textBox74.Text + "', " + "a_opt_prize_index3 = '" + textBox75.Text + "', " + "a_opt_prize_index4 = '" + textBox76.Text + "', " + "a_opt_prize_index5 = '" + textBox77.Text + "', " + "a_opt_prize_index6 = '" + textBox78.Text + "', " + "a_opt_prize_data0 = '" + textBox79.Text + "', " + "a_opt_prize_data1 = '" + textBox80.Text + "', " + "a_opt_prize_data2 = '" + textBox81.Text + "', " + "a_opt_prize_data3 = '" + textBox82.Text + "', " + "a_opt_prize_data4 = '" + textBox83.Text + "', " + "a_opt_prize_data5 = '" + textBox84.Text + "', " + "a_opt_prize_data6 = '" + textBox85.Text + "', " + "a_opt_prize_plus0 = '" + textBox86.Text + "', " + "a_opt_prize_plus1 = '" + textBox87.Text + "', " + "a_opt_prize_plus2 = '" + textBox88.Text + "', " + "a_opt_prize_plus3 = '" + textBox89.Text + "', " + "a_opt_prize_plus4 = '" + textBox90.Text + "', " + "a_opt_prize_plus5 = '" + textBox91.Text + "', " + "a_opt_prize_plus6 = '" + textBox92.Text + "', " + "a_only_opt_prize = '" + textBox93.Text + "', ";
      string str4 = richTextBox1.Text.Replace("'", "\\'").Replace("\"", "\\\"");
      string str5 = richTextBox2.Text.Replace("'", "\\'").Replace("\"", "\\\"");
      string str6 = richTextBox3.Text.Replace("'", "\\'").Replace("\"", "\\\"");
            databaseHandle.SendQueryMySql(Host, User, Password, Database, str3 + "a_desc_usa = '" + str4 + "', " + "a_desc2_usa = '" + str5 + "', " + "a_desc3_usa = '" + str6 + "', " + "a_desc_usa = '" + str4 + "', " + "a_desc2_usa = '" + str5 + "', " + "a_desc3_usa = '" + str6 + "', " + "a_failvalue = '" + textBox97.Text + "', " + "a_partyscale = '" + textBox98.Text + "', " + "a_start_give_item = '" + textBox99.Text + "', " + "a_start_give_kindcount = '" + textBox100.Text + "', " + "a_start_give_numcount = '" + textBox101.Text + "', " + "a_start_trigger_id = '" + textBox102.Text + "', " + "a_quest_flag = '" + textBox103.Text + "' " + "WHERE a_index = '" + textBox1.Text + "'");
      int selectedIndex = listBox1.SelectedIndex;
      if (textBox104.Text != "")
                SearchList(textBox104.Text);
      else
                LoadListBox();
            listBox1.SelectedIndex = selectedIndex;
            textBox2.BackColor = Color.White;
            textBox2.BackColor = Color.White;
            textBox5.BackColor = Color.White;
            textBox6.BackColor = Color.White;
            textBox8.BackColor = Color.White;
            textBox10.BackColor = Color.White;
            textBox12.BackColor = Color.White;
            textBox13.BackColor = Color.White;
            textBox14.BackColor = Color.White;
            textBox16.BackColor = Color.White;
            textBox17.BackColor = Color.White;
            textBox18.BackColor = Color.White;
            textBox19.BackColor = Color.White;
            textBox20.BackColor = Color.White;
            textBox21.BackColor = Color.White;
            textBox22.BackColor = Color.White;
            textBox23.BackColor = Color.White;
            textBox24.BackColor = Color.White;
            textBox25.BackColor = Color.White;
            textBox26.BackColor = Color.White;
            textBox27.BackColor = Color.White;
            textBox31.BackColor = Color.White;
            textBox32.BackColor = Color.White;
            textBox33.BackColor = Color.White;
            textBox34.BackColor = Color.White;
            textBox35.BackColor = Color.White;
            textBox36.BackColor = Color.White;
            textBox37.BackColor = Color.White;
            textBox38.BackColor = Color.White;
            textBox39.BackColor = Color.White;
            textBox40.BackColor = Color.White;
            textBox41.BackColor = Color.White;
            textBox42.BackColor = Color.White;
            textBox43.BackColor = Color.White;
            textBox44.BackColor = Color.White;
            textBox45.BackColor = Color.White;
            textBox46.BackColor = Color.White;
            textBox47.BackColor = Color.White;
            textBox48.BackColor = Color.White;
            textBox54.BackColor = Color.White;
            textBox55.BackColor = Color.White;
            textBox56.BackColor = Color.White;
            textBox57.BackColor = Color.White;
            textBox58.BackColor = Color.White;
            textBox59.BackColor = Color.White;
            textBox60.BackColor = Color.White;
            textBox61.BackColor = Color.White;
            textBox62.BackColor = Color.White;
            textBox63.BackColor = Color.White;
            textBox64.BackColor = Color.White;
            textBox72.BackColor = Color.White;
            textBox73.BackColor = Color.White;
            textBox74.BackColor = Color.White;
            textBox75.BackColor = Color.White;
            textBox76.BackColor = Color.White;
            textBox77.BackColor = Color.White;
            textBox78.BackColor = Color.White;
            textBox79.BackColor = Color.White;
            textBox80.BackColor = Color.White;
            textBox81.BackColor = Color.White;
            textBox82.BackColor = Color.White;
            textBox83.BackColor = Color.White;
            textBox84.BackColor = Color.White;
            textBox85.BackColor = Color.White;
            textBox86.BackColor = Color.White;
            textBox87.BackColor = Color.White;
            textBox88.BackColor = Color.White;
            textBox89.BackColor = Color.White;
            textBox90.BackColor = Color.White;
            textBox91.BackColor = Color.White;
            textBox92.BackColor = Color.White;
            textBox93.BackColor = Color.White;
            richTextBox1.BackColor = Color.White;
            richTextBox2.BackColor = Color.White;
            richTextBox3.BackColor = Color.White;
            textBox97.BackColor = Color.White;
            textBox99.BackColor = Color.White;
            textBox100.BackColor = Color.White;
            textBox101.BackColor = Color.White;
            textBox102.BackColor = Color.White;
            textBox103.BackColor = Color.White;
            textBox104.BackColor = Color.White;
            comboBox1.BackColor = Color.White;
            comboBox2.BackColor = Color.White;
            comboBox3.BackColor = Color.White;
            comboBox4.BackColor = Color.White;
            comboBox5.BackColor = Color.White;
            comboBox6.BackColor = Color.White;
            comboBox7.BackColor = Color.White;
            comboBox8.BackColor = Color.White;
            comboBox9.BackColor = Color.White;
            comboBox10.BackColor = Color.White;
            comboBox11.BackColor = Color.White;
            comboBox12.BackColor = Color.White;
            comboBox13.BackColor = Color.White;
            comboBox14.BackColor = Color.White;
            comboBox15.BackColor = Color.White;
            comboBox16.BackColor = Color.White;
            comboBox17.BackColor = Color.White;
            comboBox18.BackColor = Color.White;
            comboBox19.BackColor = Color.White;
            comboBox20.BackColor = Color.White;
            comboBox21.BackColor = Color.White;
            comboBox22.BackColor = Color.White;
    }

    private void button1_Click(object sender, EventArgs e)
    {
      string Query = "INSERT INTO t_quest DEFAULT VALUES";
            databaseHandle.SendQueryMySql(Host, User, Password, Database, Query);
      Console.WriteLine(Query);
            LoadListBox();
            listBox1.SelectedIndex = listBox1.Items.Count - 1;
            textBox5.Text = "1";

        }

    private void button3_Click(object sender, EventArgs e)
    {
      int selectedIndex = listBox1.SelectedIndex;
      string Query = "DELETE FROM t_quest WHERE a_index = '" + textBox1.Text + "'";
            databaseHandle.SendQueryMySql(Host, User, Password, Database, Query);
      Console.WriteLine(Query);
            LoadListBox();
            listBox1.SelectedIndex = selectedIndex - 1;
            int num4 = (int)new CustomMessage("Deleted :O").ShowDialog();
        }

    private void LoadStartUp()
    {
            comboBox1.Items.AddRange(new object[13]
      {
         "0 - Repeat",
         "1 - Collection",
         "2 - Delivery",
         "3 - Defeat",
         "4 - Save",
         "5 - Mining Experience",
         "6 - Gathering Experience",
         "7 - Charge Experience",
         "8 - Process Experience",
         "9 - Make Experience",
         "10 - Tutorial",
         "11 - PK",
         "12 - Search"
      });
            comboBox2.Items.AddRange(new object[6]
      {
         "0 - Can do only once",
         "1 - Repeat unlimited times",
         "2 - Once a day",
         "3 - [Unknown 3]",
         "4 - [Unknown 4]",
         "5 - [Unknown 5]"
      });
            comboBox3.Items.AddRange(new object[10]
      {
         "-1  All",
         "0 - Titan",
         "1 - Knight",
         "2 - Healer",
         "3 - Mage",
         "4 - Rogue",
         "5 - Sorcerer",
         "6 - Night Shadow",
         "7 - Ex-Rogue",
         "8 - ArchMage"
      });
            comboBox4.Items.AddRange(new object[3]
      {
         "0 - Personal",
         "1 - Party",
         "2 - Battle Group"
      });
            comboBox5.Items.AddRange(new object[4]
      {
         "0 - NPC",
         "1 - Item",
         "2 - Level",
         "3 - Area"
      }); //dethunter12 adjust combobox6-8
            comboBox6.Items.AddRange(new object[10]
      {
          "-1",
         "0 - Kill Mob",
         "1 - Collect Item",
         "2 - Have Item",
         "3 - PC",
         "4 - Area",
         "5 - Item Use",
         "6 - Trigger",
         "7 - Castle Dratan",
         "8 - Castle Merac",
      });
            comboBox7.Items.AddRange(new object[10]
      {
         "-1",
         "0 - Kill Mob",
         "1 - Collect Item",
         "2 - Have Item",
         "3 - PC",
         "4 - Area",
         "5 - Item Use",
         "6 - Trigger",
         "7 - Castle Dratan",
         "8 - Castle Merac",
      });
            comboBox8.Items.AddRange(new object[10]
      {
         "-1",
         "0 - Kill Mob",
         "1 - Collect Item",
         "2 - Have Item",
         "3 - PC",
         "4 - Area",
         "5 - Item Use",
         "6 - Trigger",
         "7 - Castle Dratan",
         "8 - Castle Merac",
      });
            comboBox9.Items.AddRange(new object[9]
      {
        "-1",
         "0 - Item",
         "1 - Gold ",
         "2 - Exp",
         "3 - SP",
         "4 - Skill",
         "5 - Special Skill",
         "6 - Stat Point",
         "7 - RVRPOINT"
      }); //dethunter12 adjust combo Box 9 -19
            comboBox10.Items.AddRange(new object[9] 
      {
         "-1",
         "0 - Item",
         "1 - Gold ",
         "2 - Exp",
         "3 - SP",
         "4 - Skill",
         "5 - Special Skill",
         "6 - Stat Point",
         "7 - RVRPOINT"
      });
            comboBox11.Items.AddRange(new object[9]
      {
        "-1",
         "0 - Item",
         "1 - Gold ",
         "2 - Exp",
         "3 - SP",
         "4 - Skill",
         "5 - Special Skill",
         "6 - Stat Point",
         "7 - RVRPOINT"
      });
            comboBox12.Items.AddRange(new object[9]
      {
        "-1",
         "0 - Item",
         "1 - Gold ",
         "2 - Exp",
         "3 - SP",
         "4 - Skill",
         "5 - Special Skill",
         "6 - Stat Point",
         "7 - RVRPOINT"
      });
            comboBox13.Items.AddRange(new object[9]
      {
        "-1",
         "0 - Item",
         "1 - Gold ",
         "2 - Exp",
         "3 - SP",
         "4 - Skill",
         "5 - Special Skill",
         "6 - Stat Point",
         "7 - RVRPOINT"
      });
            comboBox14.Items.AddRange(new object[9]
      {
        "-1",
         "0 - Item",
         "1 - Gold ",
         "2 - Exp",
         "3 - SP",
         "4 - Skill",
         "5 - Special Skill",
         "6 - Stat Point",
         "7 - RVRPOINT"
      });
            comboBox15.Items.AddRange(new object[9]
      {
         "-1",
         "0 - Item",
         "1 - Gold ",
         "2 - Exp",
         "3 - SP",
         "4 - Skill",
         "5 - Special Skill",
         "6 - Stat Point",
         "7 - RVRPOINT"
      });
            comboBox16.Items.AddRange(new object[9]
      {
         "-1",
         "0 - Item",
         "1 - Gold ",
         "2 - Exp",
         "3 - SP",
         "4 - Skill",
         "5 - Special Skill",
         "6 - Stat Point",
         "7 - RVRPOINT"
      });
            comboBox17.Items.AddRange(new object[9]
      {
        "-1",
         "0 - Item",
         "1 - Gold ",
         "2 - Exp",
         "3 - SP",
         "4 - Skill",
         "5 - Special Skill",
         "6 - Stat Point",
         "7 - RVRPOINT"
      });
            comboBox18.Items.AddRange(new object[9]
      {
        "-1",
         "0 - Item",
         "1 - Gold ",
         "2 - Exp",
         "3 - SP",
         "4 - Skill",
         "5 - Special Skill",
         "6 - Stat Point",
         "7 - RVRPOINT"
      });
            comboBox19.Items.AddRange(new object[9]
      {
        "-1",
         "0 - Item",
         "1 - Gold ",
         "2 - Exp",
         "3 - SP",
         "4 - Skill",
         "5 - Special Skill",
         "6 - Stat Point",
         "7 - RVRPOINT"
      });
            comboBox20.Items.AddRange(new object[9]
      {
         "-1",
         "0 - Item",
         "1 - Gold ",
         "2 - Exp",
         "3 - SP",
         "4 - Skill",
         "5 - Special Skill",
         "6 - Stat Point",
         "7 - RVRPOINT"
      });

            CbRvrType.Items.AddRange(new object[3] //dethunter12 add
     {
         "0 - None",
         "1 - KAILUX",
         "2 - DEALERMOON"
     });

            CbRvRGrade.Items.AddRange(new object[9] //dethunter12 add
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

            CbRvRGrade1.Items.AddRange(new object[5] //dethunter12 add
     {
         "1 - NEOPTYE",
         "2 - ZELATOR",
         "3 - THEORICUS",
         "4 - PHILOSOPHUS",
         "5 - ADEPTUS"
     });
        }

    private void exportStrItemlodToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      int num = (int) MessageBox.Show("Comming Soon");
    }

    private void fileExportToolStripMenuItem_Click(object sender, EventArgs e)
    {
    }

    private void textBox104_TextChanged(object sender, EventArgs e)
    {
            //dethunter12 5/5/2018 language system
            if (language == "GER")
            {
                listBox1.DataSource = databaseHandle.SearchList(textBox104.Text, menuArrayGER, "t_quest");
            }
            else if (language == "POL")
            {
                listBox1.DataSource = databaseHandle.SearchList(textBox104.Text, menuArrayPOL, "t_quest");
            }
            else if (language == "BRA")
            {
                listBox1.DataSource = databaseHandle.SearchList(textBox104.Text, menuArrayBRA, "t_quest");
            }
            else if (language == "RUS")
            {
                listBox1.DataSource = databaseHandle.SearchList(textBox104.Text, menuArrayRUS, "t_quest");
            }
            else if (language == "FRA")
            {
                listBox1.DataSource = databaseHandle.SearchList(textBox104.Text, menuArrayFRA, "t_quest");
            }
            else if (language == "ESP")
            {
                listBox1.DataSource = databaseHandle.SearchList(textBox104.Text, menuArrayESP, "t_quest");
            }
            else if (language == "MEX")
            {
                listBox1.DataSource = databaseHandle.SearchList(textBox104.Text, menuArrayMEX, "t_quest");
            }
            else if (language == "THA")
            {
                listBox1.DataSource = databaseHandle.SearchList(textBox104.Text, menuArrayTHA, "t_quest");
            }
            else if (language == "ITA")
            {
                listBox1.DataSource = databaseHandle.SearchList(textBox104.Text, menuArrayITA, "t_quest");
            }
            else if (language == "USA")
            {
                listBox1.DataSource = databaseHandle.SearchList(textBox104.Text, menuArrayUSA, "t_quest");
            }
            else
            {
                listBox1.DataSource = databaseHandle.SearchList(textBox104.Text, menuArray, "t_quest");
            }
            //dethunter12 5/5/2018 language end
    }

    private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
    {
      int num1 = (int) MessageBox.Show("Quest Editor by kravens, THANKS to DamonA for help with all!", "Created by:");
      int num2 = (int) MessageBox.Show("If you wanna more tools contact with kravens. Skype: Choke1996", "Information");
    }

    private void getAlFromDBToolStripMenuItem_Click(object sender, EventArgs e)
    {
    }

    private void button5_Click(object sender, EventArgs e)
    {
      int num = (int) MessageBox.Show("ID Map where quest Start.", "Help");
    }

    private void button6_Click(object sender, EventArgs e)
    {
      int num = (int) MessageBox.Show("ID Map where quest End.", "Help");
    }

    private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
    {
            textBox4.Text = GetIndexByComboBox(comboBox2.Text).ToString();
    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
            textBox3.Text = GetIndexByComboBox(comboBox1.Text).ToString();
    }

    private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
    {
            textBox15.Text = GetIndexByComboBox(comboBox3.Text).ToString();
    }

    private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
    {
            textBox98.Text = GetIndexByComboBox(comboBox4.Text).ToString();
    }

    private void comboBox21_SelectedIndexChanged(object sender, EventArgs e)
    {
            textBox9.Text = GetIndexByComboBox(comboBox21.Text).ToString();
    }

    private void comboBox22_SelectedIndexChanged(object sender, EventArgs e)
    {
            textBox11.Text = GetIndexByComboBox(comboBox22.Text).ToString();
    }

    private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
    {
            textBox7.Text = GetIndexByComboBox(comboBox5.Text).ToString();
    }

    private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
    {
            textBox28.Text = GetIndexByComboBox(comboBox6.Text).ToString();
    }

    private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
    {
            textBox29.Text = GetIndexByComboBox(comboBox7.Text).ToString();
    }

    private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
    {
            textBox30.Text = GetIndexByComboBox(comboBox8.Text).ToString();
    }

    private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
    {
            textBox49.Text = GetIndexByComboBox(comboBox9.Text).ToString();
    }

    private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
    {
            textBox50.Text = GetIndexByComboBox(comboBox10.Text).ToString();
    }

    private void comboBox11_SelectedIndexChanged(object sender, EventArgs e)
    {
            textBox51.Text = GetIndexByComboBox(comboBox11.Text).ToString();
    }

    private void comboBox12_SelectedIndexChanged(object sender, EventArgs e)
    {
            textBox52.Text = GetIndexByComboBox(comboBox12.Text).ToString();
    }

    private void comboBox13_SelectedIndexChanged_1(object sender, EventArgs e)
    {
            textBox53.Text = GetIndexByComboBox(comboBox13.Text).ToString();
    }

    private void comboBox14_SelectedIndexChanged(object sender, EventArgs e)
    {
            textBox65.Text = GetIndexByComboBox(comboBox14.Text).ToString();
    }

    private void comboBox15_SelectedIndexChanged(object sender, EventArgs e)
    {
            textBox66.Text = GetIndexByComboBox(comboBox15.Text).ToString();
    }

    private void comboBox16_SelectedIndexChanged(object sender, EventArgs e)
    {
            textBox67.Text = GetIndexByComboBox(comboBox16.Text).ToString();
    }

    private void comboBox17_SelectedIndexChanged(object sender, EventArgs e)
    {
            textBox68.Text = GetIndexByComboBox(comboBox17.Text).ToString();
    }

    private void comboBox18_SelectedIndexChanged(object sender, EventArgs e)
    {
            textBox69.Text = GetIndexByComboBox(comboBox18.Text).ToString();
    }

    private void comboBox19_SelectedIndexChanged(object sender, EventArgs e)
    {
            textBox70.Text = GetIndexByComboBox(comboBox19.Text).ToString();
    }

    private void comboBox20_SelectedIndexChanged(object sender, EventArgs e)
    {
            textBox71.Text = GetIndexByComboBox(comboBox20.Text).ToString();
    }

    private void button7_Click(object sender, EventArgs e)
    {
            //dethunter12 language i
            namee = StringFromLanguage();
            desc = DescrFromLanguage();
            desc2 = Descr2FromLanguage();
            desc3 = Descr3FromLanguage();
      string str1 = "UPDATE t_quest SET " + "a_index = '" + textBox1.Text + "', ";
      string str2 = textBox2.Text.Replace("'", "\\'").Replace("\"", "\\\"");
      string str3 = str1 + "a_name = '" + str2 + "', " + namee + "=" + " " + "'" + str2 + "', " + "a_type1 = '" + textBox3.Text + "', " + "a_type2 = '" + textBox4.Text + "', " + "a_enable = '" + textBox5.Text + "', " + "a_prequest_num = '" + textBox6.Text + "', " + "a_start_type = '" + textBox7.Text + "', " + "a_start_data = '" + textBox8.Text + "', " + "a_start_npc_zone_num = '" + textBox9.Text + "', " + "a_prize_npc = '" + textBox10.Text + "', " + "a_prize_npc_zone_num = '" + textBox11.Text + "', " + "a_need_exp = '" + textBox12.Text + "', " + "a_need_min_level = '" + textBox13.Text + "', " + "a_need_max_level = '" + textBox14.Text + "', " + "a_need_job = '" + textBox15.Text + "', " + "a_need_item0 = '" + textBox16.Text + "', " + "a_need_item1 = '" + textBox17.Text + "', " + "a_need_item2 = '" + textBox18.Text + "', " + "a_need_item3 = '" + textBox19.Text + "', " + "a_need_item4 = '" + textBox20.Text + "', " + "a_need_item_count0 = '" + textBox21.Text + "', " + "a_need_item_count1 = '" + textBox22.Text + "', " + "a_need_item_count2 = '" + textBox23.Text + "', " + "a_need_item_count3 = '" + textBox24.Text + "', " + "a_need_item_count4 = '" + textBox25.Text + "', " + "a_need_rvr_type = '" + textBox26.Text + "', " + "a_need_rvr_grade = '" + textBox27.Text + "', " + "a_condition0_type = '" + textBox28.Text + "', " + "a_condition1_type = '" + textBox29.Text + "', " + "a_condition2_type = '" + textBox30.Text + "', " + "a_condition0_index = '" + textBox31.Text + "', " + "a_condition1_index = '" + textBox32.Text + "', " + "a_condition2_index = '" + textBox33.Text + "', " + "a_condition0_num = '" + textBox34.Text + "', " + "a_condition1_num = '" + textBox35.Text + "', " + "a_condition2_num = '" + textBox36.Text + "', " + "a_condition0_data0 = '" + textBox37.Text + "', " + "a_condition0_data1 = '" + textBox38.Text + "', " + "a_condition0_data2 = '" + textBox39.Text + "', " + "a_condition0_data3 = '" + textBox40.Text + "', " + "a_condition1_data0 = '" + textBox41.Text + "', " + "a_condition1_data1 = '" + textBox42.Text + "', " + "a_condition1_data2 = '" + textBox43.Text + "', " + "a_condition1_data3 = '" + textBox44.Text + "', " + "a_condition2_data0 = '" + textBox45.Text + "', " + "a_condition2_data1 = '" + textBox46.Text + "', " + "a_condition2_data2 = '" + textBox47.Text + "', " + "a_condition2_data3 = '" + textBox48.Text + "', " + "a_prize_type0 = '" + textBox49.Text + "', " + "a_prize_type1 = '" + textBox50.Text + "', " + "a_prize_type2 = '" + textBox51.Text + "', " + "a_prize_type3 = '" + textBox52.Text + "', " + "a_prize_type4 = '" + textBox53.Text + "', " + "a_prize_index0 = '" + textBox54.Text + "', " + "a_prize_index1 = '" + textBox55.Text + "', " + "a_prize_index2 = '" + textBox56.Text + "', " + "a_prize_index3 = '" + textBox57.Text + "', " + "a_prize_index4 = '" + textBox58.Text + "', " + "a_prize_data0 = '" + textBox59.Text + "', " + "a_prize_data1 = '" + textBox60.Text + "', " + "a_prize_data2 = '" + textBox61.Text + "', " + "a_prize_data3 = '" + textBox62.Text + "', " + "a_prize_data4 = '" + textBox63.Text + "', " + "a_option_prize = '" + textBox64.Text + "', " + "a_opt_prize_type0 = '" + textBox65.Text + "', " + "a_opt_prize_type1 = '" + textBox66.Text + "', " + "a_opt_prize_type2 = '" + textBox67.Text + "', " + "a_opt_prize_type3 = '" + textBox68.Text + "', " + "a_opt_prize_type4 = '" + textBox69.Text + "', " + "a_opt_prize_type5 = '" + textBox70.Text + "', " + "a_opt_prize_type6 = '" + textBox71.Text + "', " + "a_opt_prize_index0 = '" + textBox72.Text + "', " + "a_opt_prize_index1 = '" + textBox73.Text + "', " + "a_opt_prize_index2 = '" + textBox74.Text + "', " + "a_opt_prize_index3 = '" + textBox75.Text + "', " + "a_opt_prize_index4 = '" + textBox76.Text + "', " + "a_opt_prize_index5 = '" + textBox77.Text + "', " + "a_opt_prize_index6 = '" + textBox78.Text + "', " + "a_opt_prize_data0 = '" + textBox79.Text + "', " + "a_opt_prize_data1 = '" + textBox80.Text + "', " + "a_opt_prize_data2 = '" + textBox81.Text + "', " + "a_opt_prize_data3 = '" + textBox82.Text + "', " + "a_opt_prize_data4 = '" + textBox83.Text + "', " + "a_opt_prize_data5 = '" + textBox84.Text + "', " + "a_opt_prize_data6 = '" + textBox85.Text + "', " + "a_opt_prize_plus0 = '" + textBox86.Text + "', " + "a_opt_prize_plus1 = '" + textBox87.Text + "', " + "a_opt_prize_plus2 = '" + textBox88.Text + "', " + "a_opt_prize_plus3 = '" + textBox89.Text + "', " + "a_opt_prize_plus4 = '" + textBox90.Text + "', " + "a_opt_prize_plus5 = '" + textBox91.Text + "', " + "a_opt_prize_plus6 = '" + textBox92.Text + "', " + "a_only_opt_prize = '" + textBox93.Text + "', ";
      string str4 = richTextBox1.Text.Replace("'", "\\'").Replace("\"", "\\\"");
      string str5 = richTextBox2.Text.Replace("'", "\\'").Replace("\"", "\\\"");
      string str6 = richTextBox3.Text.Replace("'", "\\'").Replace("\"", "\\\"");
      string Query = str3 + "a_desc = '" + str4 + "', " + "a_desc2 = '" + str5 + "', " + "a_desc3 = '" + str6 + "', " + desc + "=" + " " + "'" + str4 + "', " + desc2 + "=" + " " + "'" + str5 + "', " + desc3 + "=" + " " + "'" + str6 + "', " + "a_failvalue = '" + textBox97.Text + "', " + "a_partyscale = '" + textBox98.Text + "', " + "a_start_give_item = '" + textBox99.Text + "', " + "a_start_give_kindcount = '" + textBox100.Text + "', " + "a_start_give_numcount = '" + textBox101.Text + "', " + "a_start_trigger_id = '" + textBox102.Text + "', " + "a_quest_flag = '" + textBox103.Text + "' " + "WHERE a_index = '" + textBox1.Text + "'";
      databaseHandle.SendQueryMySql(Host, User, Password, Database, Query);
      Console.WriteLine(Query);
      int selectedIndex = listBox1.SelectedIndex;
      if (textBox104.Text != "")
                SearchList(textBox104.Text);
      else
                LoadListBox();
            listBox1.SelectedIndex = selectedIndex;
            textBox2.BackColor = Color.White;
            textBox2.BackColor = Color.White;
            textBox5.BackColor = Color.White;
            textBox6.BackColor = Color.White;
            textBox8.BackColor = Color.White;
            textBox10.BackColor = Color.White;
            textBox12.BackColor = Color.White;
            textBox13.BackColor = Color.White;
            textBox14.BackColor = Color.White;
            textBox16.BackColor = Color.White;
            textBox17.BackColor = Color.White;
            textBox18.BackColor = Color.White;
            textBox19.BackColor = Color.White;
            textBox20.BackColor = Color.White;
            textBox21.BackColor = Color.White;
            textBox22.BackColor = Color.White;
            textBox23.BackColor = Color.White;
            textBox24.BackColor = Color.White;
            textBox25.BackColor = Color.White;
            textBox26.BackColor = Color.White;
            textBox27.BackColor = Color.White;
            textBox31.BackColor = Color.White;
            textBox32.BackColor = Color.White;
            textBox33.BackColor = Color.White;
            textBox34.BackColor = Color.White;
            textBox35.BackColor = Color.White;
            textBox36.BackColor = Color.White;
            textBox37.BackColor = Color.White;
            textBox38.BackColor = Color.White;
            textBox39.BackColor = Color.White;
            textBox40.BackColor = Color.White;
            textBox41.BackColor = Color.White;
            textBox42.BackColor = Color.White;
            textBox43.BackColor = Color.White;
            textBox44.BackColor = Color.White;
            textBox45.BackColor = Color.White;
            textBox46.BackColor = Color.White;
            textBox47.BackColor = Color.White;
            textBox48.BackColor = Color.White;
            textBox54.BackColor = Color.White;
            textBox55.BackColor = Color.White;
            textBox56.BackColor = Color.White;
            textBox57.BackColor = Color.White;
            textBox58.BackColor = Color.White;
            textBox59.BackColor = Color.White;
            textBox60.BackColor = Color.White;
            textBox61.BackColor = Color.White;
            textBox62.BackColor = Color.White;
            textBox63.BackColor = Color.White;
            textBox64.BackColor = Color.White;
            textBox72.BackColor = Color.White;
            textBox73.BackColor = Color.White;
            textBox74.BackColor = Color.White;
            textBox75.BackColor = Color.White;
            textBox76.BackColor = Color.White;
            textBox77.BackColor = Color.White;
            textBox78.BackColor = Color.White;
            textBox79.BackColor = Color.White;
            textBox80.BackColor = Color.White;
            textBox81.BackColor = Color.White;
            textBox82.BackColor = Color.White;
            textBox83.BackColor = Color.White;
            textBox84.BackColor = Color.White;
            textBox85.BackColor = Color.White;
            textBox86.BackColor = Color.White;
            textBox87.BackColor = Color.White;
            textBox88.BackColor = Color.White;
            textBox89.BackColor = Color.White;
            textBox90.BackColor = Color.White;
            textBox91.BackColor = Color.White;
            textBox92.BackColor = Color.White;
            textBox93.BackColor = Color.White;
            richTextBox1.BackColor = Color.White;
            richTextBox2.BackColor = Color.White;
            richTextBox3.BackColor = Color.White;
            textBox97.BackColor = Color.White;
            textBox99.BackColor = Color.White;
            textBox100.BackColor = Color.White;
            textBox101.BackColor = Color.White;
            textBox102.BackColor = Color.White;
            textBox103.BackColor = Color.White;
            textBox104.BackColor = Color.White;
            comboBox1.BackColor = Color.White;
            comboBox2.BackColor = Color.White;
            comboBox3.BackColor = Color.White;
            comboBox4.BackColor = Color.White;
            comboBox5.BackColor = Color.White;
            comboBox6.BackColor = Color.White;
            comboBox7.BackColor = Color.White;
            comboBox8.BackColor = Color.White;
            comboBox9.BackColor = Color.White;
            comboBox10.BackColor = Color.White;
            comboBox11.BackColor = Color.White;
            comboBox12.BackColor = Color.White;
            comboBox13.BackColor = Color.White;
            comboBox14.BackColor = Color.White;
            comboBox15.BackColor = Color.White;
            comboBox16.BackColor = Color.White;
            comboBox17.BackColor = Color.White;
            comboBox18.BackColor = Color.White;
            comboBox19.BackColor = Color.White;
            comboBox20.BackColor = Color.White;
            comboBox21.BackColor = Color.White;
            comboBox22.BackColor = Color.White;
            int num4 = (int)new CustomMessage("Done :)").ShowDialog();
        }

    private void textBox2_KeyDown(object sender, KeyEventArgs e)
    {
            textBox2.BackColor = Color.LightSteelBlue;
    }

    private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
    {
            richTextBox1.BackColor = Color.LightBlue;
    }

    private void richTextBox2_KeyPress(object sender, KeyPressEventArgs e)
    {
            richTextBox2.BackColor = Color.LightBlue;
    }

    private void richTextBox3_KeyPress(object sender, KeyPressEventArgs e)
    {
            richTextBox3.BackColor = Color.LightBlue;
    }

    private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
    {
            textBox5.BackColor = Color.LightBlue;
    }

    private void textBox16_KeyPress(object sender, KeyPressEventArgs e)
    {
            textBox16.BackColor = Color.LightBlue;
    }

    private void textBox17_KeyPress(object sender, KeyPressEventArgs e)
    {
            textBox17.BackColor = Color.LightBlue;
    }

    private void textBox18_KeyPress(object sender, KeyPressEventArgs e)
    {
            textBox18.BackColor = Color.LightBlue;
    }

    private void textBox19_KeyPress(object sender, KeyPressEventArgs e)
    {
            textBox19.BackColor = Color.LightBlue;
    }

    private void textBox20_KeyPress(object sender, KeyPressEventArgs e)
    {
            textBox20.BackColor = Color.LightBlue;
    }

    private void textBox21_KeyPress(object sender, KeyPressEventArgs e)
    {
            textBox21.BackColor = Color.LightBlue;
    }

    private void textBox22_KeyPress(object sender, KeyPressEventArgs e)
    {
            textBox22.BackColor = Color.LightBlue;
    }

    private void textBox23_KeyPress(object sender, KeyPressEventArgs e)
    {
            textBox23.BackColor = Color.LightBlue;
    }

    private void textBox24_KeyPress(object sender, KeyPressEventArgs e)
    {
            textBox24.BackColor = Color.LightBlue;
    }

    private void textBox25_KeyPress(object sender, KeyPressEventArgs e)
    {
            textBox25.BackColor = Color.LightBlue;
    }

    private void textBox13_KeyPress(object sender, KeyPressEventArgs e)
    {
            textBox13.BackColor = Color.LightBlue;
    }

    private void textBox14_KeyPress(object sender, KeyPressEventArgs e)
    {
            textBox14.BackColor = Color.LightBlue;
    }

    private void textBox12_KeyPress(object sender, KeyPressEventArgs e)
    {
            textBox12.BackColor = Color.LightBlue;
    }

    private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
    {
            textBox6.BackColor = Color.LightBlue;
    }

    private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
    {
            textBox8.BackColor = Color.LightBlue;
    }

    private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
    {
            textBox10.BackColor = Color.LightBlue;
    }

    private void textBox31_KeyPress(object sender, KeyPressEventArgs e)
    {
            textBox31.BackColor = Color.LightBlue;
    }

    private void textBox34_KeyPress(object sender, KeyPressEventArgs e)
    {
            textBox34.BackColor = Color.LightBlue;
    }

    private void textBox37_KeyPress(object sender, KeyPressEventArgs e)
    {
            textBox37.BackColor = Color.LightBlue;
    }

    private void textBox38_KeyPress(object sender, KeyPressEventArgs e)
    {
            textBox38.BackColor = Color.LightBlue;
    }

    private void textBox39_KeyPress(object sender, KeyPressEventArgs e)
    {
            textBox39.BackColor = Color.LightBlue;
    }

    private void textBox40_KeyPress(object sender, KeyPressEventArgs e)
    {
            textBox40.BackColor = Color.LightBlue;
    }

    private void textBox32_KeyPress(object sender, KeyPressEventArgs e)
    {
            textBox32.BackColor = Color.LightBlue;
    }

    private void textBox35_KeyPress(object sender, KeyPressEventArgs e)
    {
            textBox35.BackColor = Color.LightBlue;
    }

    private void textBox41_KeyPress(object sender, KeyPressEventArgs e)
    {
            textBox41.BackColor = Color.LightBlue;
    }

    private void textBox42_KeyPress(object sender, KeyPressEventArgs e)
    {
            textBox42.BackColor = Color.LightBlue;
    }

    private void textBox43_KeyPress(object sender, KeyPressEventArgs e)
    {
            textBox43.BackColor = Color.LightBlue;
    }

    private void textBox44_KeyPress(object sender, KeyPressEventArgs e)
    {
            textBox44.BackColor = Color.LightBlue;
    }

    private void textBox33_KeyPress(object sender, KeyPressEventArgs e)
    {
            textBox33.BackColor = Color.LightBlue;
    }

    private void textBox36_KeyPress(object sender, KeyPressEventArgs e)
    {
            textBox36.BackColor = Color.LightBlue;
    }

    private void textBox45_KeyPress(object sender, KeyPressEventArgs e)
    {
            textBox45.BackColor = Color.LightBlue;
    }

    private void textBox46_KeyPress(object sender, KeyPressEventArgs e)
    {
            textBox46.BackColor = Color.LightBlue;
    }

    private void textBox47_KeyPress(object sender, KeyPressEventArgs e)
    {
            textBox47.BackColor = Color.LightBlue;
    }

    private void textBox48_KeyPress(object sender, KeyPressEventArgs e)
    {
            textBox48.BackColor = Color.LightBlue;
    }

    private void textBox54_KeyPress(object sender, KeyPressEventArgs e)
    {
            textBox54.BackColor = Color.LightBlue;
    }

    private void textBox55_KeyPress(object sender, KeyPressEventArgs e)
    {
            textBox55.BackColor = Color.LightBlue;
    }

    private void textBox56_KeyPress(object sender, KeyPressEventArgs e)
    {
            textBox56.BackColor = Color.LightBlue;
    }

    private void textBox57_KeyPress(object sender, KeyPressEventArgs e)
    {
            textBox57.BackColor = Color.LightBlue;
    }

    private void textBox58_KeyPress(object sender, KeyPressEventArgs e)
    {
            textBox58.BackColor = Color.LightBlue;
    }

    private void textBox59_KeyPress(object sender, KeyPressEventArgs e)
    {
            textBox59.BackColor = Color.LightBlue;
    }

    private void textBox60_KeyPress(object sender, KeyPressEventArgs e)
    {
            textBox60.BackColor = Color.LightBlue;
    }

    private void textBox61_KeyPress(object sender, KeyPressEventArgs e)
    {
            textBox61.BackColor = Color.LightBlue;
    }

    private void textBox62_KeyPress(object sender, KeyPressEventArgs e)
    {
            textBox62.BackColor = Color.LightBlue;
    }

    private void textBox63_KeyPress(object sender, KeyPressEventArgs e)
    {
            textBox63.BackColor = Color.LightBlue;
    }

    private void textBox72_KeyPress(object sender, KeyPressEventArgs e)
    {
            textBox72.BackColor = Color.LightBlue;
    }

    private void textBox73_KeyPress(object sender, KeyPressEventArgs e)
    {
            textBox73.BackColor = Color.LightBlue;
    }

    private void textBox74_KeyPress(object sender, KeyPressEventArgs e)
    {
            textBox74.BackColor = Color.LightBlue;
    }

    private void textBox75_KeyPress(object sender, KeyPressEventArgs e)
    {
            textBox75.BackColor = Color.LightBlue;
    }

    private void textBox76_KeyPress(object sender, KeyPressEventArgs e)
    {
            textBox76.BackColor = Color.LightBlue;
    }

    private void textBox77_KeyPress(object sender, KeyPressEventArgs e)
    {
            textBox77.BackColor = Color.LightBlue;
    }

    private void textBox78_KeyPress(object sender, KeyPressEventArgs e)
    {
            textBox78.BackColor = Color.LightBlue;
    }

    private void textBox79_KeyPress(object sender, KeyPressEventArgs e)
    {
            textBox79.BackColor = Color.LightBlue;
    }

    private void textBox80_KeyPress(object sender, KeyPressEventArgs e)
    {
            textBox80.BackColor = Color.LightBlue;
    }

    private void textBox81_KeyPress(object sender, KeyPressEventArgs e)
    {
            textBox81.BackColor = Color.LightBlue;
    }

    private void textBox82_KeyPress(object sender, KeyPressEventArgs e)
    {
            textBox82.BackColor = Color.LightBlue;
    }

    private void textBox83_KeyPress(object sender, KeyPressEventArgs e)
    {
            textBox83.BackColor = Color.LightBlue;
    }

    private void textBox84_KeyPress(object sender, KeyPressEventArgs e)
    {
            textBox84.BackColor = Color.LightBlue;
    }

    private void textBox85_KeyPress(object sender, KeyPressEventArgs e)
    {
            textBox85.BackColor = Color.LightBlue;
    }

    private void textBox86_KeyPress(object sender, KeyPressEventArgs e)
    {
            textBox86.BackColor = Color.LightBlue;
    }

    private void textBox87_KeyPress(object sender, KeyPressEventArgs e)
    {
            textBox87.BackColor = Color.LightBlue;
    }

    private void textBox88_KeyPress(object sender, KeyPressEventArgs e)
    {
            textBox88.BackColor = Color.LightBlue;
    }

    private void textBox89_KeyPress(object sender, KeyPressEventArgs e)
    {
            textBox89.BackColor = Color.LightBlue;
    }

    private void textBox90_KeyPress(object sender, KeyPressEventArgs e)
    {
            textBox90.BackColor = Color.LightBlue;
    }

    private void textBox91_KeyPress(object sender, KeyPressEventArgs e)
    {
            textBox91.BackColor = Color.LightBlue;
    }

    private void textBox92_KeyPress(object sender, KeyPressEventArgs e)
    {
            textBox92.BackColor = Color.LightBlue;
    }

    private void textBox64_KeyPress(object sender, KeyPressEventArgs e)
    {
            textBox64.BackColor = Color.LightBlue;
    }

    private void textBox93_KeyPress(object sender, KeyPressEventArgs e)
    {
            textBox93.BackColor = Color.LightBlue;
    }

    private void textBox102_KeyPress(object sender, KeyPressEventArgs e)
    {
            textBox102.BackColor = Color.LightBlue;
    }

    private void textBox97_KeyPress(object sender, KeyPressEventArgs e)
    {
            textBox97.BackColor = Color.LightBlue;
    }

    private void textBox103_KeyPress(object sender, KeyPressEventArgs e)
    {
            textBox103.BackColor = Color.LightBlue;
    }

    private void textBox99_KeyPress(object sender, KeyPressEventArgs e)
    {
            textBox99.BackColor = Color.LightBlue;
    }

    private void textBox26_KeyPress(object sender, KeyPressEventArgs e)
    {
            textBox26.BackColor = Color.LightBlue;
    }

    private void textBox100_KeyPress(object sender, KeyPressEventArgs e)
    {
            textBox100.BackColor = Color.LightBlue;
    }

    private void textBox27_KeyPress(object sender, KeyPressEventArgs e)
    {
            textBox27.BackColor = Color.LightBlue;
    }

    private void textBox101_KeyPress(object sender, KeyPressEventArgs e)
    {
            textBox101.BackColor = Color.LightBlue;
    }

    private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
    {
            comboBox1.BackColor = Color.LightBlue;
    }

    private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
    {
            comboBox2.BackColor = Color.LightBlue;
    }

    private void comboBox3_SelectionChangeCommitted(object sender, EventArgs e)
    {
            comboBox3.BackColor = Color.LightBlue;
    }

    private void comboBox4_SelectionChangeCommitted(object sender, EventArgs e)
    {
            comboBox4.BackColor = Color.LightBlue;
    }

    private void comboBox5_SelectionChangeCommitted(object sender, EventArgs e)
    {
            comboBox5.BackColor = Color.LightBlue;
    }

    private void comboBox6_SelectionChangeCommitted(object sender, EventArgs e)
    {
            comboBox6.BackColor = Color.LightBlue;
    }

    private void comboBox7_SelectionChangeCommitted(object sender, EventArgs e)
    {
            comboBox7.BackColor = Color.LightBlue;
    }

    private void comboBox8_SelectionChangeCommitted(object sender, EventArgs e)
    {
            comboBox8.BackColor = Color.LightBlue;
    }

    private void comboBox9_SelectionChangeCommitted(object sender, EventArgs e)
    {
            comboBox9.BackColor = Color.LightBlue;
    }

    private void comboBox10_SelectionChangeCommitted(object sender, EventArgs e)
    {
            comboBox10.BackColor = Color.LightBlue;
    }

    private void comboBox11_SelectionChangeCommitted(object sender, EventArgs e)
    {
            comboBox11.BackColor = Color.LightBlue;
    }

    private void comboBox12_SelectionChangeCommitted(object sender, EventArgs e)
    {
            comboBox12.BackColor = Color.LightBlue;
    }

    private void comboBox13_SelectionChangeCommitted(object sender, EventArgs e)
    {
            comboBox13.BackColor = Color.LightBlue;
    }

    private void comboBox14_SelectionChangeCommitted(object sender, EventArgs e)
    {
            comboBox14.BackColor = Color.LightBlue;
    }

    private void comboBox15_SelectionChangeCommitted(object sender, EventArgs e)
    {
            comboBox15.BackColor = Color.LightBlue;
    }

    private void comboBox16_SelectionChangeCommitted(object sender, EventArgs e)
    {
            comboBox16.BackColor = Color.LightBlue;
    }

    private void comboBox17_SelectionChangeCommitted(object sender, EventArgs e)
    {
            comboBox17.BackColor = Color.LightBlue;
    }

    private void comboBox18_SelectionChangeCommitted(object sender, EventArgs e)
    {
            comboBox18.BackColor = Color.LightBlue;
    }

    private void comboBox19_SelectionChangeCommitted(object sender, EventArgs e)
    {
            comboBox19.BackColor = Color.LightBlue;
    }

    private void comboBox20_SelectionChangeCommitted(object sender, EventArgs e)
    {
            comboBox20.BackColor = Color.LightBlue;
    }

    private void comboBox21_SelectionChangeCommitted(object sender, EventArgs e)
    {
            comboBox21.BackColor = Color.LightBlue;
    }

    private void comboBox22_SelectionChangeCommitted(object sender, EventArgs e)
    {
            comboBox22.BackColor = Color.LightBlue;
    }

    private void exportToolStripMenuItem_Click(object sender, EventArgs e)
    {
            //exportLodhandle.ExportQuestAll_V4();
            string text1 = "quest";
            string text2 = "path_ship";
            string text3 = IconList.language.ToLower();
            Process.Start(new ProcessStartInfo()
            {
                FileName = "ExportLod.exe",
                Arguments = " -h " + Host + " -d " + Database + " -u " + User + " -p " + Password + " -k " + text2 + " -l " + text3 + " -t " + text1
            });
        }

    private void exportStrQuestToolStripMenuItem_Click(object sender, EventArgs e)
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuestEditor));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileExportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportStrQuestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnCopy = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBox104 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.CbRvRGrade1 = new System.Windows.Forms.ComboBox();
            this.CbRvRGrade = new System.Windows.Forms.ComboBox();
            this.CbRvrType = new System.Windows.Forms.ComboBox();
            this.textBox27 = new System.Windows.Forms.TextBox();
            this.textBox26 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label109 = new System.Windows.Forms.Label();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.label108 = new System.Windows.Forms.Label();
            this.label107 = new System.Windows.Forms.Label();
            this.label106 = new System.Windows.Forms.Label();
            this.label105 = new System.Windows.Forms.Label();
            this.textBox98 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.label118 = new System.Windows.Forms.Label();
            this.label117 = new System.Windows.Forms.Label();
            this.TbEndNpcName = new System.Windows.Forms.TextBox();
            this.TbStartNpcName = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.comboBox22 = new System.Windows.Forms.ComboBox();
            this.comboBox21 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label59 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label46 = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label98 = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.label54 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.PbItemNeed5 = new System.Windows.Forms.PictureBox();
            this.PbItemNeed4 = new System.Windows.Forms.PictureBox();
            this.PbItemNeed3 = new System.Windows.Forms.PictureBox();
            this.PbItemNeed2 = new System.Windows.Forms.PictureBox();
            this.PbItemNeed1 = new System.Windows.Forms.PictureBox();
            this.TbNeedName5 = new System.Windows.Forms.TextBox();
            this.TbNeedName4 = new System.Windows.Forms.TextBox();
            this.TbNeedName3 = new System.Windows.Forms.TextBox();
            this.TbNeedName2 = new System.Windows.Forms.TextBox();
            this.TbNeedName1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox25 = new System.Windows.Forms.TextBox();
            this.textBox24 = new System.Windows.Forms.TextBox();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.label85 = new System.Windows.Forms.Label();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.label93 = new System.Windows.Forms.Label();
            this.label92 = new System.Windows.Forms.Label();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.label91 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label112 = new System.Windows.Forms.Label();
            this.label111 = new System.Windows.Forms.Label();
            this.label110 = new System.Windows.Forms.Label();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label104 = new System.Windows.Forms.Label();
            this.label96 = new System.Windows.Forms.Label();
            this.label95 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.TbObj1 = new System.Windows.Forms.TextBox();
            this.PbCond1 = new System.Windows.Forms.PictureBox();
            this.textBox28 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TbObj1Npc3 = new System.Windows.Forms.TextBox();
            this.PbObj1NpcID3 = new System.Windows.Forms.PictureBox();
            this.TbObj1Npc2 = new System.Windows.Forms.TextBox();
            this.PbObj1NpcID2 = new System.Windows.Forms.PictureBox();
            this.TbObj1Npc1 = new System.Windows.Forms.TextBox();
            this.PbObj1NpcID1 = new System.Windows.Forms.PictureBox();
            this.label116 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.textBox37 = new System.Windows.Forms.TextBox();
            this.textBox38 = new System.Windows.Forms.TextBox();
            this.textBox39 = new System.Windows.Forms.TextBox();
            this.textBox40 = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox31 = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.textBox34 = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.TbObj2 = new System.Windows.Forms.TextBox();
            this.PbCond2 = new System.Windows.Forms.PictureBox();
            this.textBox29 = new System.Windows.Forms.TextBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.TbObj2Npc3 = new System.Windows.Forms.TextBox();
            this.PbObj2NpcID3 = new System.Windows.Forms.PictureBox();
            this.TbObj2Npc2 = new System.Windows.Forms.TextBox();
            this.PbObj2NpcID2 = new System.Windows.Forms.PictureBox();
            this.TbObj2Npc1 = new System.Windows.Forms.TextBox();
            this.PbObj2NpcID1 = new System.Windows.Forms.PictureBox();
            this.label115 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.textBox44 = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.textBox41 = new System.Windows.Forms.TextBox();
            this.textBox42 = new System.Windows.Forms.TextBox();
            this.textBox43 = new System.Windows.Forms.TextBox();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox32 = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.textBox35 = new System.Windows.Forms.TextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.TbObj3 = new System.Windows.Forms.TextBox();
            this.PbCond3 = new System.Windows.Forms.PictureBox();
            this.textBox30 = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.textBox36 = new System.Windows.Forms.TextBox();
            this.textBox33 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label114 = new System.Windows.Forms.Label();
            this.TbObjNpc3 = new System.Windows.Forms.TextBox();
            this.PbNpcID3 = new System.Windows.Forms.PictureBox();
            this.TbObjNpc2 = new System.Windows.Forms.TextBox();
            this.PbNpcID2 = new System.Windows.Forms.PictureBox();
            this.TbObjNpc1 = new System.Windows.Forms.TextBox();
            this.PbNpcID1 = new System.Windows.Forms.PictureBox();
            this.textBox46 = new System.Windows.Forms.TextBox();
            this.textBox48 = new System.Windows.Forms.TextBox();
            this.textBox47 = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.textBox45 = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.tbItemDesc5 = new System.Windows.Forms.TextBox();
            this.tbItemDesc4 = new System.Windows.Forms.TextBox();
            this.tbItemDesc3 = new System.Windows.Forms.TextBox();
            this.tbItemDesc2 = new System.Windows.Forms.TextBox();
            this.tbItemDesc1 = new System.Windows.Forms.TextBox();
            this.PbPItem5 = new System.Windows.Forms.PictureBox();
            this.PbPItem4 = new System.Windows.Forms.PictureBox();
            this.PbPItem3 = new System.Windows.Forms.PictureBox();
            this.PbPItem2 = new System.Windows.Forms.PictureBox();
            this.PbPItem1 = new System.Windows.Forms.PictureBox();
            this.textBox53 = new System.Windows.Forms.TextBox();
            this.textBox52 = new System.Windows.Forms.TextBox();
            this.textBox51 = new System.Windows.Forms.TextBox();
            this.textBox50 = new System.Windows.Forms.TextBox();
            this.textBox49 = new System.Windows.Forms.TextBox();
            this.comboBox13 = new System.Windows.Forms.ComboBox();
            this.textBox59 = new System.Windows.Forms.TextBox();
            this.comboBox12 = new System.Windows.Forms.ComboBox();
            this.textBox63 = new System.Windows.Forms.TextBox();
            this.textBox60 = new System.Windows.Forms.TextBox();
            this.comboBox11 = new System.Windows.Forms.ComboBox();
            this.textBox61 = new System.Windows.Forms.TextBox();
            this.textBox58 = new System.Windows.Forms.TextBox();
            this.textBox62 = new System.Windows.Forms.TextBox();
            this.comboBox10 = new System.Windows.Forms.ComboBox();
            this.label60 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.comboBox9 = new System.Windows.Forms.ComboBox();
            this.label55 = new System.Windows.Forms.Label();
            this.textBox57 = new System.Windows.Forms.TextBox();
            this.label57 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.textBox56 = new System.Windows.Forms.TextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.textBox55 = new System.Windows.Forms.TextBox();
            this.textBox54 = new System.Windows.Forms.TextBox();
            this.label51 = new System.Windows.Forms.Label();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.TbPrize2ItemDesc1 = new System.Windows.Forms.TextBox();
            this.TbPrize2ItemDesc2 = new System.Windows.Forms.TextBox();
            this.TbPrize2ItemDesc3 = new System.Windows.Forms.TextBox();
            this.TbPrize2ItemDesc4 = new System.Windows.Forms.TextBox();
            this.TbPrize2ItemDesc5 = new System.Windows.Forms.TextBox();
            this.TbPrize2ItemDesc6 = new System.Windows.Forms.TextBox();
            this.TbPrize2ItemDesc7 = new System.Windows.Forms.TextBox();
            this.PbItem7 = new System.Windows.Forms.PictureBox();
            this.PbItem6 = new System.Windows.Forms.PictureBox();
            this.PbItem5 = new System.Windows.Forms.PictureBox();
            this.PbItem4 = new System.Windows.Forms.PictureBox();
            this.PbItem3 = new System.Windows.Forms.PictureBox();
            this.PbItem2 = new System.Windows.Forms.PictureBox();
            this.PbItem1 = new System.Windows.Forms.PictureBox();
            this.textBox93 = new System.Windows.Forms.TextBox();
            this.label94 = new System.Windows.Forms.Label();
            this.textBox64 = new System.Windows.Forms.TextBox();
            this.label61 = new System.Windows.Forms.Label();
            this.comboBox20 = new System.Windows.Forms.ComboBox();
            this.comboBox19 = new System.Windows.Forms.ComboBox();
            this.comboBox18 = new System.Windows.Forms.ComboBox();
            this.comboBox17 = new System.Windows.Forms.ComboBox();
            this.comboBox16 = new System.Windows.Forms.ComboBox();
            this.comboBox15 = new System.Windows.Forms.ComboBox();
            this.comboBox14 = new System.Windows.Forms.ComboBox();
            this.label67 = new System.Windows.Forms.Label();
            this.label68 = new System.Windows.Forms.Label();
            this.label66 = new System.Windows.Forms.Label();
            this.label65 = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.label63 = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.textBox79 = new System.Windows.Forms.TextBox();
            this.textBox80 = new System.Windows.Forms.TextBox();
            this.label76 = new System.Windows.Forms.Label();
            this.label77 = new System.Windows.Forms.Label();
            this.textBox81 = new System.Windows.Forms.TextBox();
            this.textBox82 = new System.Windows.Forms.TextBox();
            this.textBox83 = new System.Windows.Forms.TextBox();
            this.textBox84 = new System.Windows.Forms.TextBox();
            this.textBox85 = new System.Windows.Forms.TextBox();
            this.label78 = new System.Windows.Forms.Label();
            this.label79 = new System.Windows.Forms.Label();
            this.label80 = new System.Windows.Forms.Label();
            this.label81 = new System.Windows.Forms.Label();
            this.label82 = new System.Windows.Forms.Label();
            this.textBox72 = new System.Windows.Forms.TextBox();
            this.textBox73 = new System.Windows.Forms.TextBox();
            this.label69 = new System.Windows.Forms.Label();
            this.label70 = new System.Windows.Forms.Label();
            this.textBox74 = new System.Windows.Forms.TextBox();
            this.textBox75 = new System.Windows.Forms.TextBox();
            this.textBox76 = new System.Windows.Forms.TextBox();
            this.textBox77 = new System.Windows.Forms.TextBox();
            this.textBox78 = new System.Windows.Forms.TextBox();
            this.label71 = new System.Windows.Forms.Label();
            this.label72 = new System.Windows.Forms.Label();
            this.label73 = new System.Windows.Forms.Label();
            this.label74 = new System.Windows.Forms.Label();
            this.label75 = new System.Windows.Forms.Label();
            this.textBox86 = new System.Windows.Forms.TextBox();
            this.textBox87 = new System.Windows.Forms.TextBox();
            this.textBox92 = new System.Windows.Forms.TextBox();
            this.label83 = new System.Windows.Forms.Label();
            this.label90 = new System.Windows.Forms.Label();
            this.label84 = new System.Windows.Forms.Label();
            this.label89 = new System.Windows.Forms.Label();
            this.textBox88 = new System.Windows.Forms.TextBox();
            this.label88 = new System.Windows.Forms.Label();
            this.textBox89 = new System.Windows.Forms.TextBox();
            this.label87 = new System.Windows.Forms.Label();
            this.textBox90 = new System.Windows.Forms.TextBox();
            this.label86 = new System.Windows.Forms.Label();
            this.textBox91 = new System.Windows.Forms.TextBox();
            this.textBox69 = new System.Windows.Forms.TextBox();
            this.textBox70 = new System.Windows.Forms.TextBox();
            this.textBox68 = new System.Windows.Forms.TextBox();
            this.textBox65 = new System.Windows.Forms.TextBox();
            this.textBox71 = new System.Windows.Forms.TextBox();
            this.textBox67 = new System.Windows.Forms.TextBox();
            this.textBox66 = new System.Windows.Forms.TextBox();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.textBox103 = new System.Windows.Forms.TextBox();
            this.label103 = new System.Windows.Forms.Label();
            this.textBox102 = new System.Windows.Forms.TextBox();
            this.label102 = new System.Windows.Forms.Label();
            this.label99 = new System.Windows.Forms.Label();
            this.textBox100 = new System.Windows.Forms.TextBox();
            this.textBox97 = new System.Windows.Forms.TextBox();
            this.label97 = new System.Windows.Forms.Label();
            this.textBox101 = new System.Windows.Forms.TextBox();
            this.label101 = new System.Windows.Forms.Label();
            this.textBox99 = new System.Windows.Forms.TextBox();
            this.label100 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.label113 = new System.Windows.Forms.Label();
            this.lblLang = new System.Windows.Forms.Label();
            this.PbStartItemNPC = new System.Windows.Forms.PictureBox();
            this.PbEndNPCItem = new System.Windows.Forms.PictureBox();
            this.label119 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label120 = new System.Windows.Forms.Label();
            this.label121 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label122 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbItemNeed5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbItemNeed4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbItemNeed3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbItemNeed2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbItemNeed1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbCond1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbObj1NpcID3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbObj1NpcID2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbObj1NpcID1)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbCond2)).BeginInit();
            this.groupBox12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbObj2NpcID3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbObj2NpcID2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbObj2NpcID1)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbCond3)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbNpcID3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbNpcID2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbNpcID1)).BeginInit();
            this.tabPage6.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.tabPage8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbPItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbPItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbPItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbPItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbPItem1)).BeginInit();
            this.tabPage9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbItem1)).BeginInit();
            this.tabPage7.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbStartItemNPC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbEndNPCItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowMerge = false;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileExportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1056, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileExportToolStripMenuItem
            // 
            this.fileExportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem,
            this.exportStrQuestToolStripMenuItem});
            this.fileExportToolStripMenuItem.Name = "fileExportToolStripMenuItem";
            this.fileExportToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.fileExportToolStripMenuItem.Text = "File Export";
            this.fileExportToolStripMenuItem.Click += new System.EventHandler(this.fileExportToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.exportToolStripMenuItem.Text = "Export  questAll.lod";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // exportStrQuestToolStripMenuItem
            // 
            this.exportStrQuestToolStripMenuItem.Enabled = false;
            this.exportStrQuestToolStripMenuItem.Name = "exportStrQuestToolStripMenuItem";
            this.exportStrQuestToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.exportStrQuestToolStripMenuItem.Text = "Export strQuest_us.lod";
            this.exportStrQuestToolStripMenuItem.Click += new System.EventHandler(this.exportStrQuestToolStripMenuItem_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnCopy);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.listBox1);
            this.groupBox3.Location = new System.Drawing.Point(12, 82);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(265, 581);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Quest";
            // 
            // BtnCopy
            // 
            this.BtnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCopy.Location = new System.Drawing.Point(91, 546);
            this.BtnCopy.Name = "BtnCopy";
            this.BtnCopy.Size = new System.Drawing.Size(82, 23);
            this.BtnCopy.TabIndex = 5;
            this.BtnCopy.Text = "Copy";
            this.BtnCopy.UseVisualStyleBackColor = true;
            this.BtnCopy.Click += new System.EventHandler(this.BtnCopy_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(176, 546);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(83, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(6, 546);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add New";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(253, 524);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBox104);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Location = new System.Drawing.Point(12, 27);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(265, 49);
            this.groupBox5.TabIndex = 32;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Search";
            // 
            // textBox104
            // 
            this.textBox104.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox104.Location = new System.Drawing.Point(43, 19);
            this.textBox104.Name = "textBox104";
            this.textBox104.Size = new System.Drawing.Size(216, 20);
            this.textBox104.TabIndex = 83;
            this.textBox104.TextChanged += new System.EventHandler(this.textBox104_TextChanged);
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
            // textBox12
            // 
            this.textBox12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox12.Location = new System.Drawing.Point(66, 65);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(207, 20);
            this.textBox12.TabIndex = 20;
            this.textBox12.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox12_KeyPress);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Location = new System.Drawing.Point(283, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(773, 636);
            this.tabControl1.TabIndex = 33;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.groupBox8);
            this.tabPage1.Controls.Add(this.label109);
            this.tabPage1.Controls.Add(this.textBox15);
            this.tabPage1.Controls.Add(this.label108);
            this.tabPage1.Controls.Add(this.label107);
            this.tabPage1.Controls.Add(this.label106);
            this.tabPage1.Controls.Add(this.label105);
            this.tabPage1.Controls.Add(this.textBox98);
            this.tabPage1.Controls.Add(this.textBox11);
            this.tabPage1.Controls.Add(this.textBox9);
            this.tabPage1.Controls.Add(this.textBox7);
            this.tabPage1.Controls.Add(this.textBox4);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.groupBox11);
            this.tabPage1.Controls.Add(this.groupBox10);
            this.tabPage1.Controls.Add(this.groupBox9);
            this.tabPage1.Controls.Add(this.comboBox2);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(765, 610);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Basic";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.CbRvRGrade1);
            this.groupBox8.Controls.Add(this.CbRvRGrade);
            this.groupBox8.Controls.Add(this.CbRvrType);
            this.groupBox8.Controls.Add(this.textBox27);
            this.groupBox8.Controls.Add(this.textBox26);
            this.groupBox8.Controls.Add(this.label9);
            this.groupBox8.Controls.Add(this.label8);
            this.groupBox8.Location = new System.Drawing.Point(485, 427);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(260, 94);
            this.groupBox8.TabIndex = 102;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "RvR Type";
            // 
            // CbRvRGrade1
            // 
            this.CbRvRGrade1.FormattingEnabled = true;
            this.CbRvRGrade1.Location = new System.Drawing.Point(81, 57);
            this.CbRvRGrade1.Name = "CbRvRGrade1";
            this.CbRvRGrade1.Size = new System.Drawing.Size(102, 21);
            this.CbRvRGrade1.TabIndex = 240;
            this.CbRvRGrade1.SelectedIndexChanged += new System.EventHandler(this.CbRvRGrade1_SelectedIndexChanged);
            // 
            // CbRvRGrade
            // 
            this.CbRvRGrade.FormattingEnabled = true;
            this.CbRvRGrade.Location = new System.Drawing.Point(81, 57);
            this.CbRvRGrade.Name = "CbRvRGrade";
            this.CbRvRGrade.Size = new System.Drawing.Size(102, 21);
            this.CbRvRGrade.TabIndex = 239;
            this.CbRvRGrade.SelectedIndexChanged += new System.EventHandler(this.CbRvRGrade_SelectedIndexChanged);
            // 
            // CbRvrType
            // 
            this.CbRvrType.FormattingEnabled = true;
            this.CbRvrType.Location = new System.Drawing.Point(81, 29);
            this.CbRvrType.Name = "CbRvrType";
            this.CbRvrType.Size = new System.Drawing.Size(102, 21);
            this.CbRvrType.TabIndex = 238;
            this.CbRvrType.SelectedIndexChanged += new System.EventHandler(this.CbRvrType_SelectedIndexChanged);
            // 
            // textBox27
            // 
            this.textBox27.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox27.Location = new System.Drawing.Point(198, 59);
            this.textBox27.Name = "textBox27";
            this.textBox27.Size = new System.Drawing.Size(57, 20);
            this.textBox27.TabIndex = 237;
            // 
            // textBox26
            // 
            this.textBox26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox26.Location = new System.Drawing.Point(198, 29);
            this.textBox26.Name = "textBox26";
            this.textBox26.Size = new System.Drawing.Size(57, 20);
            this.textBox26.TabIndex = 236;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 235;
            this.label9.Text = "RvR Grade:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 234;
            this.label8.Text = "RvR Type:";
            // 
            // label109
            // 
            this.label109.AutoSize = true;
            this.label109.Location = new System.Drawing.Point(691, 180);
            this.label109.Name = "label109";
            this.label109.Size = new System.Drawing.Size(24, 13);
            this.label109.TabIndex = 101;
            this.label109.Text = "Job";
            this.label109.Visible = false;
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(631, 177);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(50, 20);
            this.textBox15.TabIndex = 100;
            this.textBox15.Visible = false;
            // 
            // label108
            // 
            this.label108.AutoSize = true;
            this.label108.Location = new System.Drawing.Point(692, 156);
            this.label108.Name = "label108";
            this.label108.Size = new System.Drawing.Size(39, 13);
            this.label108.TabIndex = 99;
            this.label108.Text = "QType";
            this.label108.Visible = false;
            // 
            // label107
            // 
            this.label107.AutoSize = true;
            this.label107.Location = new System.Drawing.Point(692, 79);
            this.label107.Name = "label107";
            this.label107.Size = new System.Drawing.Size(37, 13);
            this.label107.TabIndex = 98;
            this.label107.Text = "SFrom";
            this.label107.Visible = false;
            // 
            // label106
            // 
            this.label106.AutoSize = true;
            this.label106.Location = new System.Drawing.Point(692, 130);
            this.label106.Name = "label106";
            this.label106.Size = new System.Drawing.Size(28, 13);
            this.label106.TabIndex = 97;
            this.label106.Text = "Map";
            this.label106.Visible = false;
            // 
            // label105
            // 
            this.label105.AutoSize = true;
            this.label105.Location = new System.Drawing.Point(692, 104);
            this.label105.Name = "label105";
            this.label105.Size = new System.Drawing.Size(28, 13);
            this.label105.TabIndex = 96;
            this.label105.Text = "Map";
            this.label105.Visible = false;
            // 
            // textBox98
            // 
            this.textBox98.Location = new System.Drawing.Point(631, 153);
            this.textBox98.Name = "textBox98";
            this.textBox98.Size = new System.Drawing.Size(50, 20);
            this.textBox98.TabIndex = 95;
            this.textBox98.Visible = false;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(631, 127);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(50, 20);
            this.textBox11.TabIndex = 94;
            this.textBox11.Visible = false;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(631, 101);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(50, 20);
            this.textBox9.TabIndex = 93;
            this.textBox9.Visible = false;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(631, 76);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(50, 20);
            this.textBox7.TabIndex = 92;
            this.textBox7.Visible = false;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(701, 41);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(50, 20);
            this.textBox4.TabIndex = 91;
            this.textBox4.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(701, 10);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(50, 20);
            this.textBox3.TabIndex = 90;
            this.textBox3.Visible = false;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.PbEndNPCItem);
            this.groupBox11.Controls.Add(this.PbStartItemNPC);
            this.groupBox11.Controls.Add(this.label118);
            this.groupBox11.Controls.Add(this.label117);
            this.groupBox11.Controls.Add(this.TbEndNpcName);
            this.groupBox11.Controls.Add(this.TbStartNpcName);
            this.groupBox11.Controls.Add(this.button6);
            this.groupBox11.Controls.Add(this.button5);
            this.groupBox11.Controls.Add(this.comboBox22);
            this.groupBox11.Controls.Add(this.comboBox21);
            this.groupBox11.Controls.Add(this.label12);
            this.groupBox11.Controls.Add(this.comboBox5);
            this.groupBox11.Controls.Add(this.label59);
            this.groupBox11.Controls.Add(this.label47);
            this.groupBox11.Controls.Add(this.textBox10);
            this.groupBox11.Controls.Add(this.label10);
            this.groupBox11.Controls.Add(this.label11);
            this.groupBox11.Controls.Add(this.textBox8);
            this.groupBox11.Controls.Add(this.textBox6);
            this.groupBox11.Controls.Add(this.label46);
            this.groupBox11.Location = new System.Drawing.Point(338, 242);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(407, 175);
            this.groupBox11.TabIndex = 87;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Start and Finish Quest";
            // 
            // label118
            // 
            this.label118.AutoSize = true;
            this.label118.Location = new System.Drawing.Point(6, 147);
            this.label118.Name = "label118";
            this.label118.Size = new System.Drawing.Size(85, 13);
            this.label118.TabIndex = 109;
            this.label118.Text = "End NPC Name:";
            // 
            // label117
            // 
            this.label117.AutoSize = true;
            this.label117.Location = new System.Drawing.Point(6, 102);
            this.label117.Name = "label117";
            this.label117.Size = new System.Drawing.Size(88, 13);
            this.label117.TabIndex = 108;
            this.label117.Text = "Start NPC Name:";
            // 
            // TbEndNpcName
            // 
            this.TbEndNpcName.BackColor = System.Drawing.SystemColors.Menu;
            this.TbEndNpcName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbEndNpcName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbEndNpcName.ForeColor = System.Drawing.Color.LimeGreen;
            this.TbEndNpcName.Location = new System.Drawing.Point(94, 144);
            this.TbEndNpcName.Name = "TbEndNpcName";
            this.TbEndNpcName.ReadOnly = true;
            this.TbEndNpcName.Size = new System.Drawing.Size(195, 20);
            this.TbEndNpcName.TabIndex = 107;
            // 
            // TbStartNpcName
            // 
            this.TbStartNpcName.BackColor = System.Drawing.SystemColors.Menu;
            this.TbStartNpcName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbStartNpcName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbStartNpcName.ForeColor = System.Drawing.Color.LimeGreen;
            this.TbStartNpcName.Location = new System.Drawing.Point(95, 98);
            this.TbStartNpcName.Name = "TbStartNpcName";
            this.TbStartNpcName.ReadOnly = true;
            this.TbStartNpcName.Size = new System.Drawing.Size(195, 20);
            this.TbStartNpcName.TabIndex = 106;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(376, 120);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(27, 23);
            this.button6.TabIndex = 54;
            this.button6.Text = "?";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(376, 71);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(27, 23);
            this.button5.TabIndex = 53;
            this.button5.Text = "?";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // comboBox22
            // 
            this.comboBox22.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox22.FormattingEnabled = true;
            this.comboBox22.Items.AddRange(new object[] {
            "0 - Juno",
            "1 - Belfist",
            "2 - Dungeon",
            "3 - Dungeon 2",
            "4 - Dratan",
            "5 - Single Dungeon 2",
            "6 - Start Map",
            "7 - Merac",
            "8 - Guild Hall",
            "9 - Dungeon 3",
            "10 - Single Dungeon 3",
            "11 - Single Dungeon 4",
            "12 - P Dungeon 1",
            "13 - Dungeon 3 PVP",
            "14 - Room OX",
            "15 - Eghea",
            "16 - Eghea PK",
            "17 - Lust Turm 1-7",
            "18 - Lust Turm 8",
            "19 - Lust Turm 9",
            "20 - Lust Turm 10",
            "21 - Tomb",
            "22 - Monster Combo",
            "23 - Strayana",
            "24 - PK Turment",
            "25 - Cube",
            "26 - Dragsaal",
            "27 - Cave",
            "28 - Cave",
            "29 - Kristall Mine",
            "30 - Mystische Schlucht ",
            "31 - Eghea Cave",
            "32 - MoonShine",
            "33 - Chapel 1",
            "34 - Chapel 2",
            "35 - Chapel 3",
            "36 - Akan Temple",
            "37 - Triva Canyon",
            "38 - Royal Rumble PK",
            "39 - Tarian",
            "40 -  Bloodymir",
            "41 - Tarian Dungeon",
            "42 - Alber",
            "43 - Darzel",
            "44 - Extreme Streiana"});
            this.comboBox22.Location = new System.Drawing.Point(230, 120);
            this.comboBox22.Name = "comboBox22";
            this.comboBox22.Size = new System.Drawing.Size(140, 21);
            this.comboBox22.TabIndex = 52;
            this.comboBox22.SelectedIndexChanged += new System.EventHandler(this.comboBox22_SelectedIndexChanged);
            this.comboBox22.SelectionChangeCommitted += new System.EventHandler(this.comboBox22_SelectionChangeCommitted);
            // 
            // comboBox21
            // 
            this.comboBox21.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox21.FormattingEnabled = true;
            this.comboBox21.Items.AddRange(new object[] {
            "0 - Juno",
            "1 - Belfist",
            "2 - Dungeon",
            "3 - Dungeon 2",
            "4 - Dratan",
            "5 - Single Dungeon 2",
            "6 - Start Map",
            "7 - Merac",
            "8 - Guild Hall",
            "9 - Dungeon 3",
            "10 - Single Dungeon 3",
            "11 - Single Dungeon 4",
            "12 - P Dungeon 1",
            "13 - Dungeon 3 PVP",
            "14 - Room OX",
            "15 - Eghea",
            "16 - Eghea PK",
            "17 - Lust Turm 1-7",
            "18 - Lust Turm 8",
            "19 - Lust Turm 9",
            "20 - Lust Turm 10",
            "21 - Tomb",
            "22 - Monster Combo",
            "23 - Strayana",
            "24 - PK Turment",
            "25 - Cube",
            "26 - Dragsaal",
            "27 - Cave",
            "28 - Cave",
            "29 - Kristall Mine",
            "30 - Mystische Schlucht ",
            "31 - Eghea Cave",
            "32 - MoonShine",
            "33 - Chapel 1",
            "34 - Chapel 2",
            "35 - Chapel 3",
            "36 - Akan Temple",
            "37 - Triva Canyon",
            "38 - Royal Rumble PK",
            "39 - Tarian",
            "40 -  Bloodymir",
            "41 - Tarian Dungeon",
            "42 - Alber",
            "43 - Darzel",
            "44 - Extreme Streiana"});
            this.comboBox21.Location = new System.Drawing.Point(230, 71);
            this.comboBox21.Name = "comboBox21";
            this.comboBox21.Size = new System.Drawing.Size(140, 21);
            this.comboBox21.TabIndex = 51;
            this.comboBox21.SelectedIndexChanged += new System.EventHandler(this.comboBox21_SelectedIndexChanged);
            this.comboBox21.SelectionChangeCommitted += new System.EventHandler(this.comboBox21_SelectionChangeCommitted);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(164, 123);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Zone NPC:";
            // 
            // comboBox5
            // 
            this.comboBox5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(70, 29);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(64, 21);
            this.comboBox5.TabIndex = 36;
            this.comboBox5.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            this.comboBox5.SelectionChangeCommitted += new System.EventHandler(this.comboBox5_SelectionChangeCommitted);
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(164, 75);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(60, 13);
            this.label59.TabIndex = 50;
            this.label59.Text = "Zone NPC:";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(6, 34);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(58, 13);
            this.label47.TabIndex = 35;
            this.label47.Text = "Start From:";
            // 
            // textBox10
            // 
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox10.Location = new System.Drawing.Point(70, 119);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(64, 20);
            this.textBox10.TabIndex = 14;
            this.textBox10.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox10_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(146, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Need Quest ID:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 123);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "End NPC:";
            // 
            // textBox8
            // 
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox8.Location = new System.Drawing.Point(70, 73);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(64, 20);
            this.textBox8.TabIndex = 14;
            this.textBox8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox8_KeyPress);
            // 
            // textBox6
            // 
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox6.Location = new System.Drawing.Point(233, 29);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(62, 20);
            this.textBox6.TabIndex = 6;
            this.textBox6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox6_KeyPress);
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(6, 75);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(57, 13);
            this.label46.TabIndex = 35;
            this.label46.Text = "Start NPC:";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.comboBox4);
            this.groupBox10.Controls.Add(this.label98);
            this.groupBox10.Location = new System.Drawing.Point(338, 196);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(287, 40);
            this.groupBox10.TabIndex = 86;
            this.groupBox10.TabStop = false;
            // 
            // comboBox4
            // 
            this.comboBox4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(84, 13);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(189, 21);
            this.comboBox4.TabIndex = 1;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            this.comboBox4.SelectionChangeCommitted += new System.EventHandler(this.comboBox4_SelectionChangeCommitted);
            // 
            // label98
            // 
            this.label98.AutoSize = true;
            this.label98.Location = new System.Drawing.Point(13, 16);
            this.label98.Name = "label98";
            this.label98.Size = new System.Drawing.Size(65, 13);
            this.label98.TabIndex = 0;
            this.label98.Text = "Quest Type:";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.comboBox3);
            this.groupBox9.Controls.Add(this.textBox12);
            this.groupBox9.Controls.Add(this.label14);
            this.groupBox9.Controls.Add(this.label52);
            this.groupBox9.Controls.Add(this.textBox14);
            this.groupBox9.Controls.Add(this.textBox13);
            this.groupBox9.Controls.Add(this.label54);
            this.groupBox9.Controls.Add(this.label13);
            this.groupBox9.Location = new System.Drawing.Point(338, 67);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(287, 130);
            this.groupBox9.TabIndex = 85;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Character Stuff";
            // 
            // comboBox3
            // 
            this.comboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(66, 98);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 62;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            this.comboBox3.SelectionChangeCommitted += new System.EventHandler(this.comboBox3_SelectionChangeCommitted);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(27, 102);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(27, 13);
            this.label14.TabIndex = 60;
            this.label14.Text = "Job:";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(6, 34);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(56, 13);
            this.label52.TabIndex = 45;
            this.label52.Text = "Min Level:";
            // 
            // textBox14
            // 
            this.textBox14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox14.Location = new System.Drawing.Point(211, 32);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(62, 20);
            this.textBox14.TabIndex = 59;
            this.textBox14.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox14_KeyPress);
            // 
            // textBox13
            // 
            this.textBox13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox13.Location = new System.Drawing.Point(66, 32);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(62, 20);
            this.textBox13.TabIndex = 18;
            this.textBox13.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox13_KeyPress);
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(146, 34);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(59, 13);
            this.label54.TabIndex = 49;
            this.label54.Text = "Max Level:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(27, 69);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "EXP:";
            // 
            // comboBox2
            // 
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(388, 40);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(307, 21);
            this.comboBox2.TabIndex = 84;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            this.comboBox2.SelectionChangeCommitted += new System.EventHandler(this.comboBox2_SelectionChangeCommitted);
            // 
            // comboBox1
            // 
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(388, 10);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(307, 21);
            this.comboBox1.TabIndex = 83;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.PbItemNeed5);
            this.groupBox4.Controls.Add(this.PbItemNeed4);
            this.groupBox4.Controls.Add(this.PbItemNeed3);
            this.groupBox4.Controls.Add(this.PbItemNeed2);
            this.groupBox4.Controls.Add(this.PbItemNeed1);
            this.groupBox4.Controls.Add(this.TbNeedName5);
            this.groupBox4.Controls.Add(this.TbNeedName4);
            this.groupBox4.Controls.Add(this.TbNeedName3);
            this.groupBox4.Controls.Add(this.TbNeedName2);
            this.groupBox4.Controls.Add(this.TbNeedName1);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.textBox25);
            this.groupBox4.Controls.Add(this.textBox24);
            this.groupBox4.Controls.Add(this.textBox21);
            this.groupBox4.Controls.Add(this.textBox19);
            this.groupBox4.Controls.Add(this.label85);
            this.groupBox4.Controls.Add(this.textBox17);
            this.groupBox4.Controls.Add(this.label93);
            this.groupBox4.Controls.Add(this.label92);
            this.groupBox4.Controls.Add(this.textBox16);
            this.groupBox4.Controls.Add(this.textBox20);
            this.groupBox4.Controls.Add(this.label91);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.textBox23);
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Controls.Add(this.textBox18);
            this.groupBox4.Controls.Add(this.textBox22);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Location = new System.Drawing.Point(2, 427);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(480, 179);
            this.groupBox4.TabIndex = 77;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Need Items";
            // 
            // PbItemNeed5
            // 
            this.PbItemNeed5.BackgroundImage = global::DevPackMine.Properties.Resources.oie_transparent;
            this.PbItemNeed5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbItemNeed5.Location = new System.Drawing.Point(309, 149);
            this.PbItemNeed5.Name = "PbItemNeed5";
            this.PbItemNeed5.Size = new System.Drawing.Size(22, 22);
            this.PbItemNeed5.TabIndex = 115;
            this.PbItemNeed5.TabStop = false;
            this.PbItemNeed5.Click += new System.EventHandler(this.PbItemNeed5_Click);
            // 
            // PbItemNeed4
            // 
            this.PbItemNeed4.BackgroundImage = global::DevPackMine.Properties.Resources.oie_transparent;
            this.PbItemNeed4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbItemNeed4.Location = new System.Drawing.Point(308, 121);
            this.PbItemNeed4.Name = "PbItemNeed4";
            this.PbItemNeed4.Size = new System.Drawing.Size(22, 22);
            this.PbItemNeed4.TabIndex = 114;
            this.PbItemNeed4.TabStop = false;
            this.PbItemNeed4.Click += new System.EventHandler(this.PbItemNeed4_Click);
            // 
            // PbItemNeed3
            // 
            this.PbItemNeed3.BackgroundImage = global::DevPackMine.Properties.Resources.oie_transparent;
            this.PbItemNeed3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbItemNeed3.Location = new System.Drawing.Point(309, 91);
            this.PbItemNeed3.Name = "PbItemNeed3";
            this.PbItemNeed3.Size = new System.Drawing.Size(22, 22);
            this.PbItemNeed3.TabIndex = 113;
            this.PbItemNeed3.TabStop = false;
            this.PbItemNeed3.Click += new System.EventHandler(this.PbItemNeed3_Click);
            // 
            // PbItemNeed2
            // 
            this.PbItemNeed2.BackgroundImage = global::DevPackMine.Properties.Resources.oie_transparent;
            this.PbItemNeed2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbItemNeed2.Location = new System.Drawing.Point(308, 60);
            this.PbItemNeed2.Name = "PbItemNeed2";
            this.PbItemNeed2.Size = new System.Drawing.Size(22, 22);
            this.PbItemNeed2.TabIndex = 112;
            this.PbItemNeed2.TabStop = false;
            this.PbItemNeed2.Click += new System.EventHandler(this.PbItemNeed2_Click);
            // 
            // PbItemNeed1
            // 
            this.PbItemNeed1.BackgroundImage = global::DevPackMine.Properties.Resources.oie_transparent;
            this.PbItemNeed1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbItemNeed1.Location = new System.Drawing.Point(308, 30);
            this.PbItemNeed1.Name = "PbItemNeed1";
            this.PbItemNeed1.Size = new System.Drawing.Size(22, 22);
            this.PbItemNeed1.TabIndex = 111;
            this.PbItemNeed1.TabStop = false;
            this.PbItemNeed1.Click += new System.EventHandler(this.PbItemNeed1_Click);
            // 
            // TbNeedName5
            // 
            this.TbNeedName5.BackColor = System.Drawing.SystemColors.Menu;
            this.TbNeedName5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbNeedName5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.TbNeedName5.Location = new System.Drawing.Point(119, 151);
            this.TbNeedName5.Name = "TbNeedName5";
            this.TbNeedName5.ReadOnly = true;
            this.TbNeedName5.Size = new System.Drawing.Size(185, 20);
            this.TbNeedName5.TabIndex = 91;
            // 
            // TbNeedName4
            // 
            this.TbNeedName4.BackColor = System.Drawing.SystemColors.Menu;
            this.TbNeedName4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbNeedName4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.TbNeedName4.Location = new System.Drawing.Point(118, 121);
            this.TbNeedName4.Name = "TbNeedName4";
            this.TbNeedName4.ReadOnly = true;
            this.TbNeedName4.Size = new System.Drawing.Size(185, 20);
            this.TbNeedName4.TabIndex = 90;
            // 
            // TbNeedName3
            // 
            this.TbNeedName3.BackColor = System.Drawing.SystemColors.Menu;
            this.TbNeedName3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbNeedName3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.TbNeedName3.Location = new System.Drawing.Point(118, 91);
            this.TbNeedName3.Name = "TbNeedName3";
            this.TbNeedName3.ReadOnly = true;
            this.TbNeedName3.Size = new System.Drawing.Size(185, 20);
            this.TbNeedName3.TabIndex = 89;
            // 
            // TbNeedName2
            // 
            this.TbNeedName2.BackColor = System.Drawing.SystemColors.Menu;
            this.TbNeedName2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbNeedName2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.TbNeedName2.Location = new System.Drawing.Point(118, 60);
            this.TbNeedName2.Name = "TbNeedName2";
            this.TbNeedName2.ReadOnly = true;
            this.TbNeedName2.Size = new System.Drawing.Size(185, 20);
            this.TbNeedName2.TabIndex = 88;
            // 
            // TbNeedName1
            // 
            this.TbNeedName1.BackColor = System.Drawing.SystemColors.Menu;
            this.TbNeedName1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbNeedName1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.TbNeedName1.Location = new System.Drawing.Point(117, 30);
            this.TbNeedName1.Name = "TbNeedName1";
            this.TbNeedName1.ReadOnly = true;
            this.TbNeedName1.Size = new System.Drawing.Size(185, 20);
            this.TbNeedName1.TabIndex = 87;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(336, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 76;
            this.label4.Text = "Item Amount4:";
            // 
            // textBox25
            // 
            this.textBox25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox25.Location = new System.Drawing.Point(418, 151);
            this.textBox25.Name = "textBox25";
            this.textBox25.Size = new System.Drawing.Size(58, 20);
            this.textBox25.TabIndex = 80;
            this.textBox25.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox25_KeyPress);
            // 
            // textBox24
            // 
            this.textBox24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox24.Location = new System.Drawing.Point(418, 119);
            this.textBox24.Name = "textBox24";
            this.textBox24.Size = new System.Drawing.Size(58, 20);
            this.textBox24.TabIndex = 75;
            this.textBox24.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox24_KeyPress);
            // 
            // textBox21
            // 
            this.textBox21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox21.Location = new System.Drawing.Point(418, 29);
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(58, 20);
            this.textBox21.TabIndex = 72;
            this.textBox21.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox21_KeyPress);
            // 
            // textBox19
            // 
            this.textBox19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox19.Location = new System.Drawing.Point(50, 119);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(62, 20);
            this.textBox19.TabIndex = 68;
            this.textBox19.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox19_KeyPress);
            // 
            // label85
            // 
            this.label85.AutoSize = true;
            this.label85.Location = new System.Drawing.Point(336, 34);
            this.label85.Name = "label85";
            this.label85.Size = new System.Drawing.Size(75, 13);
            this.label85.TabIndex = 73;
            this.label85.Text = "Item Amount0:";
            // 
            // textBox17
            // 
            this.textBox17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox17.Location = new System.Drawing.Point(50, 59);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(62, 20);
            this.textBox17.TabIndex = 65;
            this.textBox17.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox17_KeyPress);
            // 
            // label93
            // 
            this.label93.AutoSize = true;
            this.label93.Location = new System.Drawing.Point(336, 63);
            this.label93.Name = "label93";
            this.label93.Size = new System.Drawing.Size(75, 13);
            this.label93.TabIndex = 74;
            this.label93.Text = "Item Amount1:";
            // 
            // label92
            // 
            this.label92.AutoSize = true;
            this.label92.Location = new System.Drawing.Point(2, 123);
            this.label92.Name = "label92";
            this.label92.Size = new System.Drawing.Size(44, 13);
            this.label92.TabIndex = 70;
            this.label92.Text = "Item ID:";
            // 
            // textBox16
            // 
            this.textBox16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox16.Location = new System.Drawing.Point(50, 29);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(62, 20);
            this.textBox16.TabIndex = 63;
            this.textBox16.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox16_KeyPress);
            // 
            // textBox20
            // 
            this.textBox20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox20.Location = new System.Drawing.Point(50, 151);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(62, 20);
            this.textBox20.TabIndex = 71;
            this.textBox20.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox20_KeyPress);
            // 
            // label91
            // 
            this.label91.AutoSize = true;
            this.label91.Location = new System.Drawing.Point(2, 63);
            this.label91.Name = "label91";
            this.label91.Size = new System.Drawing.Size(44, 13);
            this.label91.TabIndex = 69;
            this.label91.Text = "Item ID:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(2, 151);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(44, 13);
            this.label18.TabIndex = 67;
            this.label18.Text = "Item ID:";
            // 
            // textBox23
            // 
            this.textBox23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox23.Location = new System.Drawing.Point(418, 89);
            this.textBox23.Name = "textBox23";
            this.textBox23.Size = new System.Drawing.Size(58, 20);
            this.textBox23.TabIndex = 40;
            this.textBox23.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox23_KeyPress);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(336, 93);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(75, 13);
            this.label22.TabIndex = 39;
            this.label22.Text = "Item Amount2:";
            // 
            // textBox18
            // 
            this.textBox18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox18.Location = new System.Drawing.Point(50, 89);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(62, 20);
            this.textBox18.TabIndex = 66;
            this.textBox18.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox18_KeyPress);
            // 
            // textBox22
            // 
            this.textBox22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox22.Location = new System.Drawing.Point(418, 59);
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new System.Drawing.Size(58, 20);
            this.textBox22.TabIndex = 38;
            this.textBox22.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox22_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(2, 34);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 13);
            this.label15.TabIndex = 62;
            this.label15.Text = "Item ID:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(336, 123);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(75, 13);
            this.label23.TabIndex = 41;
            this.label23.Text = "Item Amount3:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(2, 93);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(44, 13);
            this.label16.TabIndex = 64;
            this.label16.Text = "Item ID:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label112);
            this.groupBox1.Controls.Add(this.label111);
            this.groupBox1.Controls.Add(this.label110);
            this.groupBox1.Controls.Add(this.richTextBox3);
            this.groupBox1.Controls.Add(this.richTextBox2);
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Controls.Add(this.label104);
            this.groupBox1.Controls.Add(this.label96);
            this.groupBox1.Controls.Add(this.label95);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Location = new System.Drawing.Point(4, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 415);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Basic";
            // 
            // label112
            // 
            this.label112.AutoSize = true;
            this.label112.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label112.Location = new System.Drawing.Point(7, 340);
            this.label112.Name = "label112";
            this.label112.Size = new System.Drawing.Size(48, 16);
            this.label112.TabIndex = 83;
            this.label112.Text = "Desc:";
            // 
            // label111
            // 
            this.label111.AutoSize = true;
            this.label111.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label111.Location = new System.Drawing.Point(7, 124);
            this.label111.Name = "label111";
            this.label111.Size = new System.Drawing.Size(48, 16);
            this.label111.TabIndex = 82;
            this.label111.Text = "Desc:";
            // 
            // label110
            // 
            this.label110.AutoSize = true;
            this.label110.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label110.Location = new System.Drawing.Point(3, 230);
            this.label110.Name = "label110";
            this.label110.Size = new System.Drawing.Size(48, 16);
            this.label110.TabIndex = 81;
            this.label110.Text = "Desc:";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(58, 297);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBox3.Size = new System.Drawing.Size(264, 101);
            this.richTextBox3.TabIndex = 80;
            this.richTextBox3.Text = "";
            this.richTextBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.richTextBox3_KeyPress);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(58, 190);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBox2.Size = new System.Drawing.Size(264, 101);
            this.richTextBox2.TabIndex = 79;
            this.richTextBox2.Text = "";
            this.richTextBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.richTextBox2_KeyPress);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.DetectUrls = false;
            this.richTextBox1.Location = new System.Drawing.Point(58, 83);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBox1.Size = new System.Drawing.Size(264, 101);
            this.richTextBox1.TabIndex = 78;
            this.richTextBox1.Text = "";
            this.richTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.richTextBox1_KeyPress);
            // 
            // label104
            // 
            this.label104.AutoSize = true;
            this.label104.Location = new System.Drawing.Point(11, 18);
            this.label104.Name = "label104";
            this.label104.Size = new System.Drawing.Size(43, 13);
            this.label104.TabIndex = 42;
            this.label104.Text = "Enable:";
            // 
            // label96
            // 
            this.label96.AutoSize = true;
            this.label96.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label96.Location = new System.Drawing.Point(5, 314);
            this.label96.Name = "label96";
            this.label96.Size = new System.Drawing.Size(48, 16);
            this.label96.TabIndex = 41;
            this.label96.Text = "Cond:";
            // 
            // label95
            // 
            this.label95.AutoSize = true;
            this.label95.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label95.Location = new System.Drawing.Point(-3, 207);
            this.label95.Name = "label95";
            this.label95.Size = new System.Drawing.Size(65, 16);
            this.label95.TabIndex = 40;
            this.label95.Text = "Reward:";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(58, 48);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(253, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Start:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Name:";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(260, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(51, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Index:";
            // 
            // textBox5
            // 
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox5.Location = new System.Drawing.Point(60, 16);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(35, 20);
            this.textBox5.TabIndex = 4;
            this.textBox5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox5_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(342, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Type2:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(342, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Type1:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tabControl2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(765, 610);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Condition";
            // 
            // tabControl2
            // 
            this.tabControl2.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Location = new System.Drawing.Point(3, 3);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(742, 362);
            this.tabControl2.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl2.TabIndex = 47;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.TbObj1);
            this.tabPage2.Controls.Add(this.PbCond1);
            this.tabPage2.Controls.Add(this.textBox28);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.comboBox6);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.textBox31);
            this.tabPage2.Controls.Add(this.label25);
            this.tabPage2.Controls.Add(this.textBox34);
            this.tabPage2.Controls.Add(this.label28);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(734, 333);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "Objetive 1";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // TbObj1
            // 
            this.TbObj1.BackColor = System.Drawing.SystemColors.Menu;
            this.TbObj1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbObj1.Location = new System.Drawing.Point(162, 47);
            this.TbObj1.Name = "TbObj1";
            this.TbObj1.ReadOnly = true;
            this.TbObj1.Size = new System.Drawing.Size(195, 20);
            this.TbObj1.TabIndex = 87;
            // 
            // PbCond1
            // 
            this.PbCond1.BackgroundImage = global::DevPackMine.Properties.Resources.oie_transparent;
            this.PbCond1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbCond1.Location = new System.Drawing.Point(360, 47);
            this.PbCond1.Name = "PbCond1";
            this.PbCond1.Size = new System.Drawing.Size(22, 22);
            this.PbCond1.TabIndex = 78;
            this.PbCond1.TabStop = false;
            this.PbCond1.Click += new System.EventHandler(this.PbCond1_Click);
            // 
            // textBox28
            // 
            this.textBox28.Location = new System.Drawing.Point(178, 13);
            this.textBox28.Name = "textBox28";
            this.textBox28.Size = new System.Drawing.Size(62, 20);
            this.textBox28.TabIndex = 38;
            this.textBox28.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TbObj1Npc3);
            this.groupBox2.Controls.Add(this.PbObj1NpcID3);
            this.groupBox2.Controls.Add(this.TbObj1Npc2);
            this.groupBox2.Controls.Add(this.PbObj1NpcID2);
            this.groupBox2.Controls.Add(this.TbObj1Npc1);
            this.groupBox2.Controls.Add(this.PbObj1NpcID1);
            this.groupBox2.Controls.Add(this.label116);
            this.groupBox2.Controls.Add(this.label31);
            this.groupBox2.Controls.Add(this.label29);
            this.groupBox2.Controls.Add(this.label30);
            this.groupBox2.Controls.Add(this.textBox37);
            this.groupBox2.Controls.Add(this.textBox38);
            this.groupBox2.Controls.Add(this.textBox39);
            this.groupBox2.Controls.Add(this.textBox40);
            this.groupBox2.Controls.Add(this.label34);
            this.groupBox2.Location = new System.Drawing.Point(9, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(719, 158);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "NPC Quest Item";
            // 
            // TbObj1Npc3
            // 
            this.TbObj1Npc3.BackColor = System.Drawing.SystemColors.Menu;
            this.TbObj1Npc3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbObj1Npc3.ForeColor = System.Drawing.Color.Red;
            this.TbObj1Npc3.Location = new System.Drawing.Point(172, 82);
            this.TbObj1Npc3.Name = "TbObj1Npc3";
            this.TbObj1Npc3.ReadOnly = true;
            this.TbObj1Npc3.Size = new System.Drawing.Size(195, 20);
            this.TbObj1Npc3.TabIndex = 109;
            // 
            // PbObj1NpcID3
            // 
            this.PbObj1NpcID3.BackgroundImage = global::DevPackMine.Properties.Resources.oie_transparent;
            this.PbObj1NpcID3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbObj1NpcID3.Location = new System.Drawing.Point(370, 82);
            this.PbObj1NpcID3.Name = "PbObj1NpcID3";
            this.PbObj1NpcID3.Size = new System.Drawing.Size(22, 22);
            this.PbObj1NpcID3.TabIndex = 108;
            this.PbObj1NpcID3.TabStop = false;
            this.PbObj1NpcID3.Click += new System.EventHandler(this.PbObj1NpcID3_Click);
            // 
            // TbObj1Npc2
            // 
            this.TbObj1Npc2.BackColor = System.Drawing.SystemColors.Menu;
            this.TbObj1Npc2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbObj1Npc2.ForeColor = System.Drawing.Color.Red;
            this.TbObj1Npc2.Location = new System.Drawing.Point(172, 56);
            this.TbObj1Npc2.Name = "TbObj1Npc2";
            this.TbObj1Npc2.ReadOnly = true;
            this.TbObj1Npc2.Size = new System.Drawing.Size(195, 20);
            this.TbObj1Npc2.TabIndex = 107;
            // 
            // PbObj1NpcID2
            // 
            this.PbObj1NpcID2.BackgroundImage = global::DevPackMine.Properties.Resources.oie_transparent;
            this.PbObj1NpcID2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbObj1NpcID2.Location = new System.Drawing.Point(370, 56);
            this.PbObj1NpcID2.Name = "PbObj1NpcID2";
            this.PbObj1NpcID2.Size = new System.Drawing.Size(22, 22);
            this.PbObj1NpcID2.TabIndex = 106;
            this.PbObj1NpcID2.TabStop = false;
            this.PbObj1NpcID2.Click += new System.EventHandler(this.PbObj1NpcID2_Click);
            // 
            // TbObj1Npc1
            // 
            this.TbObj1Npc1.BackColor = System.Drawing.SystemColors.Menu;
            this.TbObj1Npc1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbObj1Npc1.ForeColor = System.Drawing.Color.Red;
            this.TbObj1Npc1.Location = new System.Drawing.Point(172, 30);
            this.TbObj1Npc1.Name = "TbObj1Npc1";
            this.TbObj1Npc1.ReadOnly = true;
            this.TbObj1Npc1.Size = new System.Drawing.Size(195, 20);
            this.TbObj1Npc1.TabIndex = 105;
            // 
            // PbObj1NpcID1
            // 
            this.PbObj1NpcID1.BackgroundImage = global::DevPackMine.Properties.Resources.oie_transparent;
            this.PbObj1NpcID1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbObj1NpcID1.Location = new System.Drawing.Point(370, 30);
            this.PbObj1NpcID1.Name = "PbObj1NpcID1";
            this.PbObj1NpcID1.Size = new System.Drawing.Size(22, 22);
            this.PbObj1NpcID1.TabIndex = 104;
            this.PbObj1NpcID1.TabStop = false;
            this.PbObj1NpcID1.Click += new System.EventHandler(this.PbObj1NpcID1_Click);
            // 
            // label116
            // 
            this.label116.AutoSize = true;
            this.label116.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label116.Location = new System.Drawing.Point(205, 117);
            this.label116.Name = "label116";
            this.label116.Size = new System.Drawing.Size(105, 16);
            this.label116.TabIndex = 103;
            this.label116.Text = "10,000 = 100%";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(14, 34);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(46, 13);
            this.label31.TabIndex = 22;
            this.label31.Text = "NPC ID:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(14, 85);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(46, 13);
            this.label29.TabIndex = 24;
            this.label29.Text = "NPC ID:";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(14, 60);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(46, 13);
            this.label30.TabIndex = 23;
            this.label30.Text = "NPC ID:";
            // 
            // textBox37
            // 
            this.textBox37.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox37.Location = new System.Drawing.Point(66, 30);
            this.textBox37.Name = "textBox37";
            this.textBox37.Size = new System.Drawing.Size(100, 20);
            this.textBox37.TabIndex = 20;
            this.textBox37.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox37_KeyPress);
            // 
            // textBox38
            // 
            this.textBox38.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox38.Location = new System.Drawing.Point(66, 56);
            this.textBox38.Name = "textBox38";
            this.textBox38.Size = new System.Drawing.Size(100, 20);
            this.textBox38.TabIndex = 19;
            this.textBox38.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox38_KeyPress);
            // 
            // textBox39
            // 
            this.textBox39.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox39.Location = new System.Drawing.Point(66, 81);
            this.textBox39.Name = "textBox39";
            this.textBox39.Size = new System.Drawing.Size(100, 20);
            this.textBox39.TabIndex = 36;
            this.textBox39.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox39_KeyPress);
            // 
            // textBox40
            // 
            this.textBox40.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox40.Location = new System.Drawing.Point(99, 114);
            this.textBox40.Name = "textBox40";
            this.textBox40.Size = new System.Drawing.Size(100, 20);
            this.textBox40.TabIndex = 32;
            this.textBox40.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox40_KeyPress);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(14, 117);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(79, 13);
            this.label34.TabIndex = 29;
            this.label34.Text = "Percent to Get:";
            // 
            // comboBox6
            // 
            this.comboBox6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(46, 12);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(121, 21);
            this.comboBox6.TabIndex = 4;
            this.comboBox6.SelectedIndexChanged += new System.EventHandler(this.comboBox6_SelectedIndexChanged);
            this.comboBox6.SelectionChangeCommitted += new System.EventHandler(this.comboBox6_SelectionChangeCommitted);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 15);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(34, 13);
            this.label17.TabIndex = 3;
            this.label17.Text = "Type:";
            // 
            // textBox31
            // 
            this.textBox31.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox31.Location = new System.Drawing.Point(56, 47);
            this.textBox31.Name = "textBox31";
            this.textBox31.Size = new System.Drawing.Size(100, 20);
            this.textBox31.TabIndex = 8;
            this.textBox31.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox31_KeyPress);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(6, 50);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(44, 13);
            this.label25.TabIndex = 10;
            this.label25.Text = "Item ID:";
            // 
            // textBox34
            // 
            this.textBox34.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox34.Location = new System.Drawing.Point(440, 49);
            this.textBox34.Name = "textBox34";
            this.textBox34.Size = new System.Drawing.Size(100, 20);
            this.textBox34.TabIndex = 14;
            this.textBox34.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox34_KeyPress);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(388, 52);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(46, 13);
            this.label28.TabIndex = 16;
            this.label28.Text = "Amount:";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.TbObj2);
            this.tabPage4.Controls.Add(this.PbCond2);
            this.tabPage4.Controls.Add(this.textBox29);
            this.tabPage4.Controls.Add(this.groupBox12);
            this.tabPage4.Controls.Add(this.comboBox7);
            this.tabPage4.Controls.Add(this.label19);
            this.tabPage4.Controls.Add(this.textBox32);
            this.tabPage4.Controls.Add(this.label27);
            this.tabPage4.Controls.Add(this.label24);
            this.tabPage4.Controls.Add(this.textBox35);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(734, 333);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Objetive 2";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // TbObj2
            // 
            this.TbObj2.BackColor = System.Drawing.SystemColors.Menu;
            this.TbObj2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbObj2.Location = new System.Drawing.Point(162, 47);
            this.TbObj2.Name = "TbObj2";
            this.TbObj2.ReadOnly = true;
            this.TbObj2.Size = new System.Drawing.Size(195, 20);
            this.TbObj2.TabIndex = 88;
            // 
            // PbCond2
            // 
            this.PbCond2.BackgroundImage = global::DevPackMine.Properties.Resources.oie_transparent;
            this.PbCond2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbCond2.Location = new System.Drawing.Point(360, 47);
            this.PbCond2.Name = "PbCond2";
            this.PbCond2.Size = new System.Drawing.Size(22, 22);
            this.PbCond2.TabIndex = 78;
            this.PbCond2.TabStop = false;
            this.PbCond2.Click += new System.EventHandler(this.PbCond2_Click);
            // 
            // textBox29
            // 
            this.textBox29.Location = new System.Drawing.Point(178, 13);
            this.textBox29.Name = "textBox29";
            this.textBox29.Size = new System.Drawing.Size(62, 20);
            this.textBox29.TabIndex = 45;
            this.textBox29.Visible = false;
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.TbObj2Npc3);
            this.groupBox12.Controls.Add(this.PbObj2NpcID3);
            this.groupBox12.Controls.Add(this.TbObj2Npc2);
            this.groupBox12.Controls.Add(this.PbObj2NpcID2);
            this.groupBox12.Controls.Add(this.TbObj2Npc1);
            this.groupBox12.Controls.Add(this.PbObj2NpcID1);
            this.groupBox12.Controls.Add(this.label115);
            this.groupBox12.Controls.Add(this.label36);
            this.groupBox12.Controls.Add(this.label35);
            this.groupBox12.Controls.Add(this.label32);
            this.groupBox12.Controls.Add(this.textBox44);
            this.groupBox12.Controls.Add(this.label33);
            this.groupBox12.Controls.Add(this.textBox41);
            this.groupBox12.Controls.Add(this.textBox42);
            this.groupBox12.Controls.Add(this.textBox43);
            this.groupBox12.Location = new System.Drawing.Point(9, 87);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(719, 158);
            this.groupBox12.TabIndex = 18;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "NPC Quest Item";
            // 
            // TbObj2Npc3
            // 
            this.TbObj2Npc3.BackColor = System.Drawing.SystemColors.Menu;
            this.TbObj2Npc3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbObj2Npc3.ForeColor = System.Drawing.Color.Red;
            this.TbObj2Npc3.Location = new System.Drawing.Point(172, 82);
            this.TbObj2Npc3.Name = "TbObj2Npc3";
            this.TbObj2Npc3.ReadOnly = true;
            this.TbObj2Npc3.Size = new System.Drawing.Size(195, 20);
            this.TbObj2Npc3.TabIndex = 109;
            // 
            // PbObj2NpcID3
            // 
            this.PbObj2NpcID3.BackgroundImage = global::DevPackMine.Properties.Resources.oie_transparent;
            this.PbObj2NpcID3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbObj2NpcID3.Location = new System.Drawing.Point(370, 82);
            this.PbObj2NpcID3.Name = "PbObj2NpcID3";
            this.PbObj2NpcID3.Size = new System.Drawing.Size(22, 22);
            this.PbObj2NpcID3.TabIndex = 108;
            this.PbObj2NpcID3.TabStop = false;
            this.PbObj2NpcID3.Click += new System.EventHandler(this.PbObj2NpcID3_Click);
            // 
            // TbObj2Npc2
            // 
            this.TbObj2Npc2.BackColor = System.Drawing.SystemColors.Menu;
            this.TbObj2Npc2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbObj2Npc2.ForeColor = System.Drawing.Color.Red;
            this.TbObj2Npc2.Location = new System.Drawing.Point(172, 56);
            this.TbObj2Npc2.Name = "TbObj2Npc2";
            this.TbObj2Npc2.ReadOnly = true;
            this.TbObj2Npc2.Size = new System.Drawing.Size(195, 20);
            this.TbObj2Npc2.TabIndex = 107;
            // 
            // PbObj2NpcID2
            // 
            this.PbObj2NpcID2.BackgroundImage = global::DevPackMine.Properties.Resources.oie_transparent;
            this.PbObj2NpcID2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbObj2NpcID2.Location = new System.Drawing.Point(370, 56);
            this.PbObj2NpcID2.Name = "PbObj2NpcID2";
            this.PbObj2NpcID2.Size = new System.Drawing.Size(22, 22);
            this.PbObj2NpcID2.TabIndex = 106;
            this.PbObj2NpcID2.TabStop = false;
            this.PbObj2NpcID2.Click += new System.EventHandler(this.PbObj2NpcID2_Click);
            // 
            // TbObj2Npc1
            // 
            this.TbObj2Npc1.BackColor = System.Drawing.SystemColors.Menu;
            this.TbObj2Npc1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbObj2Npc1.ForeColor = System.Drawing.Color.Red;
            this.TbObj2Npc1.Location = new System.Drawing.Point(172, 30);
            this.TbObj2Npc1.Name = "TbObj2Npc1";
            this.TbObj2Npc1.ReadOnly = true;
            this.TbObj2Npc1.Size = new System.Drawing.Size(195, 20);
            this.TbObj2Npc1.TabIndex = 105;
            // 
            // PbObj2NpcID1
            // 
            this.PbObj2NpcID1.BackgroundImage = global::DevPackMine.Properties.Resources.oie_transparent;
            this.PbObj2NpcID1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbObj2NpcID1.Location = new System.Drawing.Point(370, 30);
            this.PbObj2NpcID1.Name = "PbObj2NpcID1";
            this.PbObj2NpcID1.Size = new System.Drawing.Size(22, 22);
            this.PbObj2NpcID1.TabIndex = 104;
            this.PbObj2NpcID1.TabStop = false;
            this.PbObj2NpcID1.Click += new System.EventHandler(this.PbObj2NpcID1_Click);
            // 
            // label115
            // 
            this.label115.AutoSize = true;
            this.label115.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label115.Location = new System.Drawing.Point(205, 117);
            this.label115.Name = "label115";
            this.label115.Size = new System.Drawing.Size(105, 16);
            this.label115.TabIndex = 103;
            this.label115.Text = "10,000 = 100%";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(14, 34);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(46, 13);
            this.label36.TabIndex = 33;
            this.label36.Text = "NPC ID:";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(14, 60);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(46, 13);
            this.label35.TabIndex = 34;
            this.label35.Text = "NPC ID:";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(14, 117);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(79, 13);
            this.label32.TabIndex = 37;
            this.label32.Text = "Percent to Get:";
            // 
            // textBox44
            // 
            this.textBox44.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox44.Location = new System.Drawing.Point(99, 114);
            this.textBox44.Name = "textBox44";
            this.textBox44.Size = new System.Drawing.Size(100, 20);
            this.textBox44.TabIndex = 44;
            this.textBox44.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox44_KeyPress);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(14, 85);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(46, 13);
            this.label33.TabIndex = 35;
            this.label33.Text = "NPC ID:";
            // 
            // textBox41
            // 
            this.textBox41.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox41.Location = new System.Drawing.Point(66, 30);
            this.textBox41.Name = "textBox41";
            this.textBox41.Size = new System.Drawing.Size(100, 20);
            this.textBox41.TabIndex = 26;
            this.textBox41.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox41_KeyPress);
            // 
            // textBox42
            // 
            this.textBox42.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox42.Location = new System.Drawing.Point(66, 56);
            this.textBox42.Name = "textBox42";
            this.textBox42.Size = new System.Drawing.Size(100, 20);
            this.textBox42.TabIndex = 31;
            this.textBox42.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox42_KeyPress);
            // 
            // textBox43
            // 
            this.textBox43.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox43.Location = new System.Drawing.Point(66, 81);
            this.textBox43.Name = "textBox43";
            this.textBox43.Size = new System.Drawing.Size(100, 20);
            this.textBox43.TabIndex = 30;
            this.textBox43.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox43_KeyPress);
            // 
            // comboBox7
            // 
            this.comboBox7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Location = new System.Drawing.Point(46, 12);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(121, 21);
            this.comboBox7.TabIndex = 5;
            this.comboBox7.SelectedIndexChanged += new System.EventHandler(this.comboBox7_SelectedIndexChanged);
            this.comboBox7.SelectionChangeCommitted += new System.EventHandler(this.comboBox7_SelectionChangeCommitted);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 15);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(34, 13);
            this.label19.TabIndex = 4;
            this.label19.Text = "Type:";
            // 
            // textBox32
            // 
            this.textBox32.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox32.Location = new System.Drawing.Point(56, 47);
            this.textBox32.Name = "textBox32";
            this.textBox32.Size = new System.Drawing.Size(100, 20);
            this.textBox32.TabIndex = 7;
            this.textBox32.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox32_KeyPress);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(388, 52);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(46, 13);
            this.label27.TabIndex = 17;
            this.label27.Text = "Amount:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(6, 50);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(44, 13);
            this.label24.TabIndex = 11;
            this.label24.Text = "Item ID:";
            // 
            // textBox35
            // 
            this.textBox35.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox35.Location = new System.Drawing.Point(440, 49);
            this.textBox35.Name = "textBox35";
            this.textBox35.Size = new System.Drawing.Size(100, 20);
            this.textBox35.TabIndex = 13;
            this.textBox35.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox35_KeyPress);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.TbObj3);
            this.tabPage5.Controls.Add(this.PbCond3);
            this.tabPage5.Controls.Add(this.textBox30);
            this.tabPage5.Controls.Add(this.label26);
            this.tabPage5.Controls.Add(this.comboBox8);
            this.tabPage5.Controls.Add(this.textBox36);
            this.tabPage5.Controls.Add(this.textBox33);
            this.tabPage5.Controls.Add(this.label21);
            this.tabPage5.Controls.Add(this.label20);
            this.tabPage5.Controls.Add(this.groupBox6);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(734, 333);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "Objetive 3";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // TbObj3
            // 
            this.TbObj3.BackColor = System.Drawing.SystemColors.Menu;
            this.TbObj3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbObj3.Location = new System.Drawing.Point(162, 47);
            this.TbObj3.Name = "TbObj3";
            this.TbObj3.ReadOnly = true;
            this.TbObj3.Size = new System.Drawing.Size(195, 20);
            this.TbObj3.TabIndex = 89;
            // 
            // PbCond3
            // 
            this.PbCond3.BackgroundImage = global::DevPackMine.Properties.Resources.oie_transparent;
            this.PbCond3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbCond3.Location = new System.Drawing.Point(360, 47);
            this.PbCond3.Name = "PbCond3";
            this.PbCond3.Size = new System.Drawing.Size(22, 22);
            this.PbCond3.TabIndex = 78;
            this.PbCond3.TabStop = false;
            this.PbCond3.Click += new System.EventHandler(this.PbCond3_Click);
            // 
            // textBox30
            // 
            this.textBox30.Location = new System.Drawing.Point(178, 13);
            this.textBox30.Name = "textBox30";
            this.textBox30.Size = new System.Drawing.Size(62, 20);
            this.textBox30.TabIndex = 46;
            this.textBox30.Visible = false;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(388, 52);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(46, 13);
            this.label26.TabIndex = 18;
            this.label26.Text = "Amount:";
            // 
            // comboBox8
            // 
            this.comboBox8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Location = new System.Drawing.Point(46, 12);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(121, 21);
            this.comboBox8.TabIndex = 7;
            this.comboBox8.SelectedIndexChanged += new System.EventHandler(this.comboBox8_SelectedIndexChanged);
            this.comboBox8.SelectionChangeCommitted += new System.EventHandler(this.comboBox8_SelectionChangeCommitted);
            // 
            // textBox36
            // 
            this.textBox36.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox36.Location = new System.Drawing.Point(440, 49);
            this.textBox36.Name = "textBox36";
            this.textBox36.Size = new System.Drawing.Size(100, 20);
            this.textBox36.TabIndex = 21;
            this.textBox36.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox36_KeyPress);
            // 
            // textBox33
            // 
            this.textBox33.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox33.Location = new System.Drawing.Point(56, 47);
            this.textBox33.Name = "textBox33";
            this.textBox33.Size = new System.Drawing.Size(100, 20);
            this.textBox33.TabIndex = 15;
            this.textBox33.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox33_KeyPress);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 50);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(44, 13);
            this.label21.TabIndex = 12;
            this.label21.Text = "Item ID:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 15);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(34, 13);
            this.label20.TabIndex = 6;
            this.label20.Text = "Type:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label114);
            this.groupBox6.Controls.Add(this.TbObjNpc3);
            this.groupBox6.Controls.Add(this.PbNpcID3);
            this.groupBox6.Controls.Add(this.TbObjNpc2);
            this.groupBox6.Controls.Add(this.PbNpcID2);
            this.groupBox6.Controls.Add(this.TbObjNpc1);
            this.groupBox6.Controls.Add(this.PbNpcID1);
            this.groupBox6.Controls.Add(this.textBox46);
            this.groupBox6.Controls.Add(this.textBox48);
            this.groupBox6.Controls.Add(this.textBox47);
            this.groupBox6.Controls.Add(this.label37);
            this.groupBox6.Controls.Add(this.textBox45);
            this.groupBox6.Controls.Add(this.label40);
            this.groupBox6.Controls.Add(this.label38);
            this.groupBox6.Controls.Add(this.label39);
            this.groupBox6.Location = new System.Drawing.Point(9, 87);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(719, 158);
            this.groupBox6.TabIndex = 25;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "NPC Quest Item";
            // 
            // label114
            // 
            this.label114.AutoSize = true;
            this.label114.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label114.Location = new System.Drawing.Point(205, 117);
            this.label114.Name = "label114";
            this.label114.Size = new System.Drawing.Size(105, 16);
            this.label114.TabIndex = 103;
            this.label114.Text = "10,000 = 100%";
            // 
            // TbObjNpc3
            // 
            this.TbObjNpc3.BackColor = System.Drawing.SystemColors.Menu;
            this.TbObjNpc3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbObjNpc3.ForeColor = System.Drawing.Color.Red;
            this.TbObjNpc3.Location = new System.Drawing.Point(172, 82);
            this.TbObjNpc3.Name = "TbObjNpc3";
            this.TbObjNpc3.ReadOnly = true;
            this.TbObjNpc3.Size = new System.Drawing.Size(195, 20);
            this.TbObjNpc3.TabIndex = 95;
            // 
            // PbNpcID3
            // 
            this.PbNpcID3.BackgroundImage = global::DevPackMine.Properties.Resources.oie_transparent;
            this.PbNpcID3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbNpcID3.Location = new System.Drawing.Point(370, 82);
            this.PbNpcID3.Name = "PbNpcID3";
            this.PbNpcID3.Size = new System.Drawing.Size(22, 22);
            this.PbNpcID3.TabIndex = 94;
            this.PbNpcID3.TabStop = false;
            this.PbNpcID3.Click += new System.EventHandler(this.PbNpcID3_Click);
            // 
            // TbObjNpc2
            // 
            this.TbObjNpc2.BackColor = System.Drawing.SystemColors.Menu;
            this.TbObjNpc2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbObjNpc2.ForeColor = System.Drawing.Color.Red;
            this.TbObjNpc2.Location = new System.Drawing.Point(172, 56);
            this.TbObjNpc2.Name = "TbObjNpc2";
            this.TbObjNpc2.ReadOnly = true;
            this.TbObjNpc2.Size = new System.Drawing.Size(195, 20);
            this.TbObjNpc2.TabIndex = 93;
            // 
            // PbNpcID2
            // 
            this.PbNpcID2.BackgroundImage = global::DevPackMine.Properties.Resources.oie_transparent;
            this.PbNpcID2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbNpcID2.Location = new System.Drawing.Point(370, 56);
            this.PbNpcID2.Name = "PbNpcID2";
            this.PbNpcID2.Size = new System.Drawing.Size(22, 22);
            this.PbNpcID2.TabIndex = 92;
            this.PbNpcID2.TabStop = false;
            this.PbNpcID2.Click += new System.EventHandler(this.PbNpcID2_Click);
            // 
            // TbObjNpc1
            // 
            this.TbObjNpc1.BackColor = System.Drawing.SystemColors.Menu;
            this.TbObjNpc1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbObjNpc1.ForeColor = System.Drawing.Color.Red;
            this.TbObjNpc1.Location = new System.Drawing.Point(172, 30);
            this.TbObjNpc1.Name = "TbObjNpc1";
            this.TbObjNpc1.ReadOnly = true;
            this.TbObjNpc1.Size = new System.Drawing.Size(195, 20);
            this.TbObjNpc1.TabIndex = 91;
            // 
            // PbNpcID1
            // 
            this.PbNpcID1.BackgroundImage = global::DevPackMine.Properties.Resources.oie_transparent;
            this.PbNpcID1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbNpcID1.Location = new System.Drawing.Point(370, 30);
            this.PbNpcID1.Name = "PbNpcID1";
            this.PbNpcID1.Size = new System.Drawing.Size(22, 22);
            this.PbNpcID1.TabIndex = 90;
            this.PbNpcID1.TabStop = false;
            this.PbNpcID1.Click += new System.EventHandler(this.PbNpcID1_Click);
            // 
            // textBox46
            // 
            this.textBox46.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox46.Location = new System.Drawing.Point(66, 56);
            this.textBox46.Name = "textBox46";
            this.textBox46.Size = new System.Drawing.Size(100, 20);
            this.textBox46.TabIndex = 39;
            this.textBox46.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox46_KeyPress);
            // 
            // textBox48
            // 
            this.textBox48.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox48.Location = new System.Drawing.Point(99, 114);
            this.textBox48.Name = "textBox48";
            this.textBox48.Size = new System.Drawing.Size(100, 20);
            this.textBox48.TabIndex = 46;
            this.textBox48.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox48_KeyPress);
            // 
            // textBox47
            // 
            this.textBox47.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox47.Location = new System.Drawing.Point(66, 81);
            this.textBox47.Name = "textBox47";
            this.textBox47.Size = new System.Drawing.Size(100, 20);
            this.textBox47.TabIndex = 38;
            this.textBox47.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox47_KeyPress);
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(14, 117);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(79, 13);
            this.label37.TabIndex = 45;
            this.label37.Text = "Percent to Get:";
            // 
            // textBox45
            // 
            this.textBox45.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox45.Location = new System.Drawing.Point(66, 30);
            this.textBox45.Name = "textBox45";
            this.textBox45.Size = new System.Drawing.Size(100, 20);
            this.textBox45.TabIndex = 40;
            this.textBox45.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox45_KeyPress);
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(14, 34);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(46, 13);
            this.label40.TabIndex = 41;
            this.label40.Text = "NPC ID:";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(14, 85);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(46, 13);
            this.label38.TabIndex = 43;
            this.label38.Text = "NPC ID:";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(14, 60);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(46, 13);
            this.label39.TabIndex = 42;
            this.label39.Text = "NPC ID:";
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage6.Controls.Add(this.tabControl3);
            this.tabPage6.Controls.Add(this.textBox69);
            this.tabPage6.Controls.Add(this.textBox70);
            this.tabPage6.Controls.Add(this.textBox68);
            this.tabPage6.Controls.Add(this.textBox65);
            this.tabPage6.Controls.Add(this.textBox71);
            this.tabPage6.Controls.Add(this.textBox67);
            this.tabPage6.Controls.Add(this.textBox66);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(765, 610);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Prize";
            // 
            // tabControl3
            // 
            this.tabControl3.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl3.Controls.Add(this.tabPage8);
            this.tabControl3.Controls.Add(this.tabPage9);
            this.tabControl3.Location = new System.Drawing.Point(3, 3);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(757, 434);
            this.tabControl3.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl3.TabIndex = 72;
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.tbItemDesc5);
            this.tabPage8.Controls.Add(this.tbItemDesc4);
            this.tabPage8.Controls.Add(this.tbItemDesc3);
            this.tabPage8.Controls.Add(this.tbItemDesc2);
            this.tabPage8.Controls.Add(this.tbItemDesc1);
            this.tabPage8.Controls.Add(this.PbPItem5);
            this.tabPage8.Controls.Add(this.PbPItem4);
            this.tabPage8.Controls.Add(this.PbPItem3);
            this.tabPage8.Controls.Add(this.PbPItem2);
            this.tabPage8.Controls.Add(this.PbPItem1);
            this.tabPage8.Controls.Add(this.textBox53);
            this.tabPage8.Controls.Add(this.textBox52);
            this.tabPage8.Controls.Add(this.textBox51);
            this.tabPage8.Controls.Add(this.textBox50);
            this.tabPage8.Controls.Add(this.textBox49);
            this.tabPage8.Controls.Add(this.comboBox13);
            this.tabPage8.Controls.Add(this.textBox59);
            this.tabPage8.Controls.Add(this.comboBox12);
            this.tabPage8.Controls.Add(this.textBox63);
            this.tabPage8.Controls.Add(this.textBox60);
            this.tabPage8.Controls.Add(this.comboBox11);
            this.tabPage8.Controls.Add(this.textBox61);
            this.tabPage8.Controls.Add(this.textBox58);
            this.tabPage8.Controls.Add(this.textBox62);
            this.tabPage8.Controls.Add(this.comboBox10);
            this.tabPage8.Controls.Add(this.label60);
            this.tabPage8.Controls.Add(this.label48);
            this.tabPage8.Controls.Add(this.label58);
            this.tabPage8.Controls.Add(this.comboBox9);
            this.tabPage8.Controls.Add(this.label55);
            this.tabPage8.Controls.Add(this.textBox57);
            this.tabPage8.Controls.Add(this.label57);
            this.tabPage8.Controls.Add(this.label45);
            this.tabPage8.Controls.Add(this.label56);
            this.tabPage8.Controls.Add(this.label44);
            this.tabPage8.Controls.Add(this.label49);
            this.tabPage8.Controls.Add(this.label43);
            this.tabPage8.Controls.Add(this.textBox56);
            this.tabPage8.Controls.Add(this.label42);
            this.tabPage8.Controls.Add(this.label41);
            this.tabPage8.Controls.Add(this.label50);
            this.tabPage8.Controls.Add(this.label53);
            this.tabPage8.Controls.Add(this.textBox55);
            this.tabPage8.Controls.Add(this.textBox54);
            this.tabPage8.Controls.Add(this.label51);
            this.tabPage8.Location = new System.Drawing.Point(4, 25);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(749, 405);
            this.tabPage8.TabIndex = 0;
            this.tabPage8.Text = "Prize 1";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // tbItemDesc5
            // 
            this.tbItemDesc5.BackColor = System.Drawing.SystemColors.Menu;
            this.tbItemDesc5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbItemDesc5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tbItemDesc5.Location = new System.Drawing.Point(333, 162);
            this.tbItemDesc5.Name = "tbItemDesc5";
            this.tbItemDesc5.ReadOnly = true;
            this.tbItemDesc5.Size = new System.Drawing.Size(185, 20);
            this.tbItemDesc5.TabIndex = 82;
            // 
            // tbItemDesc4
            // 
            this.tbItemDesc4.BackColor = System.Drawing.SystemColors.Menu;
            this.tbItemDesc4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbItemDesc4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tbItemDesc4.Location = new System.Drawing.Point(333, 125);
            this.tbItemDesc4.Name = "tbItemDesc4";
            this.tbItemDesc4.ReadOnly = true;
            this.tbItemDesc4.Size = new System.Drawing.Size(185, 20);
            this.tbItemDesc4.TabIndex = 83;
            // 
            // tbItemDesc3
            // 
            this.tbItemDesc3.BackColor = System.Drawing.SystemColors.Menu;
            this.tbItemDesc3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbItemDesc3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tbItemDesc3.Location = new System.Drawing.Point(333, 88);
            this.tbItemDesc3.Name = "tbItemDesc3";
            this.tbItemDesc3.ReadOnly = true;
            this.tbItemDesc3.Size = new System.Drawing.Size(185, 20);
            this.tbItemDesc3.TabIndex = 84;
            // 
            // tbItemDesc2
            // 
            this.tbItemDesc2.BackColor = System.Drawing.SystemColors.Menu;
            this.tbItemDesc2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbItemDesc2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tbItemDesc2.Location = new System.Drawing.Point(333, 51);
            this.tbItemDesc2.Name = "tbItemDesc2";
            this.tbItemDesc2.ReadOnly = true;
            this.tbItemDesc2.Size = new System.Drawing.Size(185, 20);
            this.tbItemDesc2.TabIndex = 85;
            // 
            // tbItemDesc1
            // 
            this.tbItemDesc1.BackColor = System.Drawing.SystemColors.Menu;
            this.tbItemDesc1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbItemDesc1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tbItemDesc1.Location = new System.Drawing.Point(333, 14);
            this.tbItemDesc1.Name = "tbItemDesc1";
            this.tbItemDesc1.ReadOnly = true;
            this.tbItemDesc1.Size = new System.Drawing.Size(185, 20);
            this.tbItemDesc1.TabIndex = 86;
            // 
            // PbPItem5
            // 
            this.PbPItem5.BackgroundImage = global::DevPackMine.Properties.Resources.oie_transparent;
            this.PbPItem5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbPItem5.Location = new System.Drawing.Point(524, 161);
            this.PbPItem5.Name = "PbPItem5";
            this.PbPItem5.Size = new System.Drawing.Size(22, 22);
            this.PbPItem5.TabIndex = 81;
            this.PbPItem5.TabStop = false;
            this.PbPItem5.Click += new System.EventHandler(this.PbPItem5_Click);
            // 
            // PbPItem4
            // 
            this.PbPItem4.BackgroundImage = global::DevPackMine.Properties.Resources.oie_transparent;
            this.PbPItem4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbPItem4.Location = new System.Drawing.Point(524, 124);
            this.PbPItem4.Name = "PbPItem4";
            this.PbPItem4.Size = new System.Drawing.Size(22, 22);
            this.PbPItem4.TabIndex = 80;
            this.PbPItem4.TabStop = false;
            this.PbPItem4.Click += new System.EventHandler(this.PbPItem4_Click);
            // 
            // PbPItem3
            // 
            this.PbPItem3.BackgroundImage = global::DevPackMine.Properties.Resources.oie_transparent;
            this.PbPItem3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbPItem3.Location = new System.Drawing.Point(524, 87);
            this.PbPItem3.Name = "PbPItem3";
            this.PbPItem3.Size = new System.Drawing.Size(22, 22);
            this.PbPItem3.TabIndex = 79;
            this.PbPItem3.TabStop = false;
            this.PbPItem3.Click += new System.EventHandler(this.PbPItem3_Click);
            // 
            // PbPItem2
            // 
            this.PbPItem2.BackgroundImage = global::DevPackMine.Properties.Resources.oie_transparent;
            this.PbPItem2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbPItem2.Location = new System.Drawing.Point(524, 50);
            this.PbPItem2.Name = "PbPItem2";
            this.PbPItem2.Size = new System.Drawing.Size(22, 22);
            this.PbPItem2.TabIndex = 78;
            this.PbPItem2.TabStop = false;
            this.PbPItem2.Click += new System.EventHandler(this.PbPItem2_Click);
            // 
            // PbPItem1
            // 
            this.PbPItem1.BackgroundImage = global::DevPackMine.Properties.Resources.oie_transparent;
            this.PbPItem1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbPItem1.Location = new System.Drawing.Point(524, 13);
            this.PbPItem1.Name = "PbPItem1";
            this.PbPItem1.Size = new System.Drawing.Size(22, 22);
            this.PbPItem1.TabIndex = 77;
            this.PbPItem1.TabStop = false;
            this.PbPItem1.Click += new System.EventHandler(this.PbPItem1_Click);
            // 
            // textBox53
            // 
            this.textBox53.Location = new System.Drawing.Point(145, 163);
            this.textBox53.Name = "textBox53";
            this.textBox53.Size = new System.Drawing.Size(56, 20);
            this.textBox53.TabIndex = 76;
            this.textBox53.Visible = false;
            // 
            // textBox52
            // 
            this.textBox52.Location = new System.Drawing.Point(145, 124);
            this.textBox52.Name = "textBox52";
            this.textBox52.Size = new System.Drawing.Size(56, 20);
            this.textBox52.TabIndex = 75;
            this.textBox52.Visible = false;
            // 
            // textBox51
            // 
            this.textBox51.Location = new System.Drawing.Point(145, 87);
            this.textBox51.Name = "textBox51";
            this.textBox51.Size = new System.Drawing.Size(56, 20);
            this.textBox51.TabIndex = 74;
            this.textBox51.Visible = false;
            // 
            // textBox50
            // 
            this.textBox50.Location = new System.Drawing.Point(145, 52);
            this.textBox50.Name = "textBox50";
            this.textBox50.Size = new System.Drawing.Size(56, 20);
            this.textBox50.TabIndex = 73;
            this.textBox50.Visible = false;
            // 
            // textBox49
            // 
            this.textBox49.Location = new System.Drawing.Point(145, 17);
            this.textBox49.Name = "textBox49";
            this.textBox49.Size = new System.Drawing.Size(56, 20);
            this.textBox49.TabIndex = 72;
            this.textBox49.Visible = false;
            // 
            // comboBox13
            // 
            this.comboBox13.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox13.FormattingEnabled = true;
            this.comboBox13.Location = new System.Drawing.Point(46, 162);
            this.comboBox13.Name = "comboBox13";
            this.comboBox13.Size = new System.Drawing.Size(91, 21);
            this.comboBox13.TabIndex = 9;
            this.comboBox13.SelectedIndexChanged += new System.EventHandler(this.comboBox13_SelectedIndexChanged_1);
            this.comboBox13.SelectionChangeCommitted += new System.EventHandler(this.comboBox13_SelectionChangeCommitted);
            // 
            // textBox59
            // 
            this.textBox59.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox59.Location = new System.Drawing.Point(605, 14);
            this.textBox59.Name = "textBox59";
            this.textBox59.Size = new System.Drawing.Size(100, 20);
            this.textBox59.TabIndex = 71;
            this.textBox59.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox59_KeyPress);
            // 
            // comboBox12
            // 
            this.comboBox12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox12.FormattingEnabled = true;
            this.comboBox12.Location = new System.Drawing.Point(46, 125);
            this.comboBox12.Name = "comboBox12";
            this.comboBox12.Size = new System.Drawing.Size(91, 21);
            this.comboBox12.TabIndex = 8;
            this.comboBox12.SelectedIndexChanged += new System.EventHandler(this.comboBox12_SelectedIndexChanged);
            this.comboBox12.SelectionChangeCommitted += new System.EventHandler(this.comboBox12_SelectionChangeCommitted);
            // 
            // textBox63
            // 
            this.textBox63.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox63.Location = new System.Drawing.Point(605, 162);
            this.textBox63.Name = "textBox63";
            this.textBox63.Size = new System.Drawing.Size(100, 20);
            this.textBox63.TabIndex = 67;
            this.textBox63.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox63_KeyPress);
            // 
            // textBox60
            // 
            this.textBox60.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox60.Location = new System.Drawing.Point(605, 51);
            this.textBox60.Name = "textBox60";
            this.textBox60.Size = new System.Drawing.Size(100, 20);
            this.textBox60.TabIndex = 70;
            this.textBox60.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox60_KeyPress);
            // 
            // comboBox11
            // 
            this.comboBox11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox11.FormattingEnabled = true;
            this.comboBox11.Location = new System.Drawing.Point(46, 88);
            this.comboBox11.Name = "comboBox11";
            this.comboBox11.Size = new System.Drawing.Size(91, 21);
            this.comboBox11.TabIndex = 7;
            this.comboBox11.SelectedIndexChanged += new System.EventHandler(this.comboBox11_SelectedIndexChanged);
            this.comboBox11.SelectionChangeCommitted += new System.EventHandler(this.comboBox11_SelectionChangeCommitted);
            // 
            // textBox61
            // 
            this.textBox61.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox61.Location = new System.Drawing.Point(605, 88);
            this.textBox61.Name = "textBox61";
            this.textBox61.Size = new System.Drawing.Size(100, 20);
            this.textBox61.TabIndex = 69;
            this.textBox61.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox61_KeyPress);
            // 
            // textBox58
            // 
            this.textBox58.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox58.Location = new System.Drawing.Point(212, 162);
            this.textBox58.Name = "textBox58";
            this.textBox58.Size = new System.Drawing.Size(100, 20);
            this.textBox58.TabIndex = 57;
            this.textBox58.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox58_KeyPress);
            // 
            // textBox62
            // 
            this.textBox62.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox62.Location = new System.Drawing.Point(605, 125);
            this.textBox62.Name = "textBox62";
            this.textBox62.Size = new System.Drawing.Size(100, 20);
            this.textBox62.TabIndex = 68;
            this.textBox62.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox62_KeyPress);
            // 
            // comboBox10
            // 
            this.comboBox10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox10.FormattingEnabled = true;
            this.comboBox10.Location = new System.Drawing.Point(46, 51);
            this.comboBox10.Name = "comboBox10";
            this.comboBox10.Size = new System.Drawing.Size(91, 21);
            this.comboBox10.TabIndex = 6;
            this.comboBox10.SelectedIndexChanged += new System.EventHandler(this.comboBox10_SelectedIndexChanged);
            this.comboBox10.SelectionChangeCommitted += new System.EventHandler(this.comboBox10_SelectionChangeCommitted);
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(553, 165);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(46, 13);
            this.label60.TabIndex = 66;
            this.label60.Text = "Amount:";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(165, 166);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(44, 13);
            this.label48.TabIndex = 56;
            this.label48.Text = "Item ID:";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(553, 128);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(46, 13);
            this.label58.TabIndex = 65;
            this.label58.Text = "Amount:";
            // 
            // comboBox9
            // 
            this.comboBox9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox9.FormattingEnabled = true;
            this.comboBox9.Location = new System.Drawing.Point(46, 14);
            this.comboBox9.Name = "comboBox9";
            this.comboBox9.Size = new System.Drawing.Size(91, 21);
            this.comboBox9.TabIndex = 5;
            this.comboBox9.SelectedIndexChanged += new System.EventHandler(this.comboBox9_SelectedIndexChanged);
            this.comboBox9.SelectionChangeCommitted += new System.EventHandler(this.comboBox9_SelectionChangeCommitted);
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(553, 18);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(46, 13);
            this.label55.TabIndex = 62;
            this.label55.Text = "Amount:";
            // 
            // textBox57
            // 
            this.textBox57.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox57.Location = new System.Drawing.Point(212, 125);
            this.textBox57.Name = "textBox57";
            this.textBox57.Size = new System.Drawing.Size(100, 20);
            this.textBox57.TabIndex = 58;
            this.textBox57.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox57_KeyPress);
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(553, 92);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(46, 13);
            this.label57.TabIndex = 64;
            this.label57.Text = "Amount:";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(6, 165);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(34, 13);
            this.label45.TabIndex = 4;
            this.label45.Text = "Type:";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(553, 55);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(46, 13);
            this.label56.TabIndex = 63;
            this.label56.Text = "Amount:";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(6, 128);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(34, 13);
            this.label44.TabIndex = 3;
            this.label44.Text = "Type:";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(165, 129);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(44, 13);
            this.label49.TabIndex = 55;
            this.label49.Text = "Item ID:";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(6, 92);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(34, 13);
            this.label43.TabIndex = 2;
            this.label43.Text = "Type:";
            // 
            // textBox56
            // 
            this.textBox56.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox56.Location = new System.Drawing.Point(212, 88);
            this.textBox56.Name = "textBox56";
            this.textBox56.Size = new System.Drawing.Size(100, 20);
            this.textBox56.TabIndex = 59;
            this.textBox56.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox56_KeyPress);
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(6, 55);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(34, 13);
            this.label42.TabIndex = 1;
            this.label42.Text = "Type:";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(6, 18);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(34, 13);
            this.label41.TabIndex = 0;
            this.label41.Text = "Type:";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(165, 93);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(44, 13);
            this.label50.TabIndex = 54;
            this.label50.Text = "Item ID:";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(165, 19);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(44, 13);
            this.label53.TabIndex = 52;
            this.label53.Text = "Item ID:";
            // 
            // textBox55
            // 
            this.textBox55.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox55.Location = new System.Drawing.Point(212, 51);
            this.textBox55.Name = "textBox55";
            this.textBox55.Size = new System.Drawing.Size(100, 20);
            this.textBox55.TabIndex = 60;
            this.textBox55.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox55_KeyPress);
            // 
            // textBox54
            // 
            this.textBox54.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox54.Location = new System.Drawing.Point(212, 14);
            this.textBox54.Name = "textBox54";
            this.textBox54.Size = new System.Drawing.Size(100, 20);
            this.textBox54.TabIndex = 61;
            this.textBox54.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox54_KeyPress);
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(165, 56);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(44, 13);
            this.label51.TabIndex = 53;
            this.label51.Text = "Item ID:";
            // 
            // tabPage9
            // 
            this.tabPage9.Controls.Add(this.TbPrize2ItemDesc1);
            this.tabPage9.Controls.Add(this.TbPrize2ItemDesc2);
            this.tabPage9.Controls.Add(this.TbPrize2ItemDesc3);
            this.tabPage9.Controls.Add(this.TbPrize2ItemDesc4);
            this.tabPage9.Controls.Add(this.TbPrize2ItemDesc5);
            this.tabPage9.Controls.Add(this.TbPrize2ItemDesc6);
            this.tabPage9.Controls.Add(this.TbPrize2ItemDesc7);
            this.tabPage9.Controls.Add(this.PbItem7);
            this.tabPage9.Controls.Add(this.PbItem6);
            this.tabPage9.Controls.Add(this.PbItem5);
            this.tabPage9.Controls.Add(this.PbItem4);
            this.tabPage9.Controls.Add(this.PbItem3);
            this.tabPage9.Controls.Add(this.PbItem2);
            this.tabPage9.Controls.Add(this.PbItem1);
            this.tabPage9.Controls.Add(this.textBox93);
            this.tabPage9.Controls.Add(this.label94);
            this.tabPage9.Controls.Add(this.textBox64);
            this.tabPage9.Controls.Add(this.label61);
            this.tabPage9.Controls.Add(this.comboBox20);
            this.tabPage9.Controls.Add(this.comboBox19);
            this.tabPage9.Controls.Add(this.comboBox18);
            this.tabPage9.Controls.Add(this.comboBox17);
            this.tabPage9.Controls.Add(this.comboBox16);
            this.tabPage9.Controls.Add(this.comboBox15);
            this.tabPage9.Controls.Add(this.comboBox14);
            this.tabPage9.Controls.Add(this.label67);
            this.tabPage9.Controls.Add(this.label68);
            this.tabPage9.Controls.Add(this.label66);
            this.tabPage9.Controls.Add(this.label65);
            this.tabPage9.Controls.Add(this.label64);
            this.tabPage9.Controls.Add(this.label63);
            this.tabPage9.Controls.Add(this.label62);
            this.tabPage9.Controls.Add(this.textBox79);
            this.tabPage9.Controls.Add(this.textBox80);
            this.tabPage9.Controls.Add(this.label76);
            this.tabPage9.Controls.Add(this.label77);
            this.tabPage9.Controls.Add(this.textBox81);
            this.tabPage9.Controls.Add(this.textBox82);
            this.tabPage9.Controls.Add(this.textBox83);
            this.tabPage9.Controls.Add(this.textBox84);
            this.tabPage9.Controls.Add(this.textBox85);
            this.tabPage9.Controls.Add(this.label78);
            this.tabPage9.Controls.Add(this.label79);
            this.tabPage9.Controls.Add(this.label80);
            this.tabPage9.Controls.Add(this.label81);
            this.tabPage9.Controls.Add(this.label82);
            this.tabPage9.Controls.Add(this.textBox72);
            this.tabPage9.Controls.Add(this.textBox73);
            this.tabPage9.Controls.Add(this.label69);
            this.tabPage9.Controls.Add(this.label70);
            this.tabPage9.Controls.Add(this.textBox74);
            this.tabPage9.Controls.Add(this.textBox75);
            this.tabPage9.Controls.Add(this.textBox76);
            this.tabPage9.Controls.Add(this.textBox77);
            this.tabPage9.Controls.Add(this.textBox78);
            this.tabPage9.Controls.Add(this.label71);
            this.tabPage9.Controls.Add(this.label72);
            this.tabPage9.Controls.Add(this.label73);
            this.tabPage9.Controls.Add(this.label74);
            this.tabPage9.Controls.Add(this.label75);
            this.tabPage9.Controls.Add(this.textBox86);
            this.tabPage9.Controls.Add(this.textBox87);
            this.tabPage9.Controls.Add(this.textBox92);
            this.tabPage9.Controls.Add(this.label83);
            this.tabPage9.Controls.Add(this.label90);
            this.tabPage9.Controls.Add(this.label84);
            this.tabPage9.Controls.Add(this.label89);
            this.tabPage9.Controls.Add(this.textBox88);
            this.tabPage9.Controls.Add(this.label88);
            this.tabPage9.Controls.Add(this.textBox89);
            this.tabPage9.Controls.Add(this.label87);
            this.tabPage9.Controls.Add(this.textBox90);
            this.tabPage9.Controls.Add(this.label86);
            this.tabPage9.Controls.Add(this.textBox91);
            this.tabPage9.Location = new System.Drawing.Point(4, 25);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage9.Size = new System.Drawing.Size(749, 405);
            this.tabPage9.TabIndex = 1;
            this.tabPage9.Text = "Prize 2";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // TbPrize2ItemDesc1
            // 
            this.TbPrize2ItemDesc1.BackColor = System.Drawing.SystemColors.Menu;
            this.TbPrize2ItemDesc1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbPrize2ItemDesc1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.TbPrize2ItemDesc1.Location = new System.Drawing.Point(254, 25);
            this.TbPrize2ItemDesc1.Name = "TbPrize2ItemDesc1";
            this.TbPrize2ItemDesc1.ReadOnly = true;
            this.TbPrize2ItemDesc1.Size = new System.Drawing.Size(168, 20);
            this.TbPrize2ItemDesc1.TabIndex = 235;
            // 
            // TbPrize2ItemDesc2
            // 
            this.TbPrize2ItemDesc2.BackColor = System.Drawing.SystemColors.Menu;
            this.TbPrize2ItemDesc2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbPrize2ItemDesc2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.TbPrize2ItemDesc2.Location = new System.Drawing.Point(254, 61);
            this.TbPrize2ItemDesc2.Name = "TbPrize2ItemDesc2";
            this.TbPrize2ItemDesc2.ReadOnly = true;
            this.TbPrize2ItemDesc2.Size = new System.Drawing.Size(168, 20);
            this.TbPrize2ItemDesc2.TabIndex = 234;
            // 
            // TbPrize2ItemDesc3
            // 
            this.TbPrize2ItemDesc3.BackColor = System.Drawing.SystemColors.Menu;
            this.TbPrize2ItemDesc3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbPrize2ItemDesc3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.TbPrize2ItemDesc3.Location = new System.Drawing.Point(254, 96);
            this.TbPrize2ItemDesc3.Name = "TbPrize2ItemDesc3";
            this.TbPrize2ItemDesc3.ReadOnly = true;
            this.TbPrize2ItemDesc3.Size = new System.Drawing.Size(168, 20);
            this.TbPrize2ItemDesc3.TabIndex = 233;
            // 
            // TbPrize2ItemDesc4
            // 
            this.TbPrize2ItemDesc4.BackColor = System.Drawing.SystemColors.Menu;
            this.TbPrize2ItemDesc4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbPrize2ItemDesc4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.TbPrize2ItemDesc4.Location = new System.Drawing.Point(254, 133);
            this.TbPrize2ItemDesc4.Name = "TbPrize2ItemDesc4";
            this.TbPrize2ItemDesc4.ReadOnly = true;
            this.TbPrize2ItemDesc4.Size = new System.Drawing.Size(168, 20);
            this.TbPrize2ItemDesc4.TabIndex = 232;
            // 
            // TbPrize2ItemDesc5
            // 
            this.TbPrize2ItemDesc5.BackColor = System.Drawing.SystemColors.Menu;
            this.TbPrize2ItemDesc5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbPrize2ItemDesc5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.TbPrize2ItemDesc5.Location = new System.Drawing.Point(254, 169);
            this.TbPrize2ItemDesc5.Name = "TbPrize2ItemDesc5";
            this.TbPrize2ItemDesc5.ReadOnly = true;
            this.TbPrize2ItemDesc5.Size = new System.Drawing.Size(168, 20);
            this.TbPrize2ItemDesc5.TabIndex = 231;
            // 
            // TbPrize2ItemDesc6
            // 
            this.TbPrize2ItemDesc6.BackColor = System.Drawing.SystemColors.Menu;
            this.TbPrize2ItemDesc6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbPrize2ItemDesc6.ForeColor = System.Drawing.Color.RoyalBlue;
            this.TbPrize2ItemDesc6.Location = new System.Drawing.Point(254, 205);
            this.TbPrize2ItemDesc6.Name = "TbPrize2ItemDesc6";
            this.TbPrize2ItemDesc6.ReadOnly = true;
            this.TbPrize2ItemDesc6.Size = new System.Drawing.Size(168, 20);
            this.TbPrize2ItemDesc6.TabIndex = 230;
            // 
            // TbPrize2ItemDesc7
            // 
            this.TbPrize2ItemDesc7.BackColor = System.Drawing.SystemColors.Menu;
            this.TbPrize2ItemDesc7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbPrize2ItemDesc7.ForeColor = System.Drawing.Color.RoyalBlue;
            this.TbPrize2ItemDesc7.Location = new System.Drawing.Point(254, 241);
            this.TbPrize2ItemDesc7.Name = "TbPrize2ItemDesc7";
            this.TbPrize2ItemDesc7.ReadOnly = true;
            this.TbPrize2ItemDesc7.Size = new System.Drawing.Size(168, 20);
            this.TbPrize2ItemDesc7.TabIndex = 229;
            // 
            // PbItem7
            // 
            this.PbItem7.BackgroundImage = global::DevPackMine.Properties.Resources.oie_transparent;
            this.PbItem7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbItem7.Location = new System.Drawing.Point(438, 241);
            this.PbItem7.Name = "PbItem7";
            this.PbItem7.Size = new System.Drawing.Size(22, 22);
            this.PbItem7.TabIndex = 228;
            this.PbItem7.TabStop = false;
            this.PbItem7.Click += new System.EventHandler(this.PbItem7_Click);
            // 
            // PbItem6
            // 
            this.PbItem6.BackgroundImage = global::DevPackMine.Properties.Resources.oie_transparent;
            this.PbItem6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbItem6.Location = new System.Drawing.Point(438, 207);
            this.PbItem6.Name = "PbItem6";
            this.PbItem6.Size = new System.Drawing.Size(22, 22);
            this.PbItem6.TabIndex = 227;
            this.PbItem6.TabStop = false;
            this.PbItem6.Click += new System.EventHandler(this.PbItem6_Click);
            // 
            // PbItem5
            // 
            this.PbItem5.BackgroundImage = global::DevPackMine.Properties.Resources.oie_transparent;
            this.PbItem5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbItem5.Location = new System.Drawing.Point(438, 170);
            this.PbItem5.Name = "PbItem5";
            this.PbItem5.Size = new System.Drawing.Size(22, 22);
            this.PbItem5.TabIndex = 226;
            this.PbItem5.TabStop = false;
            this.PbItem5.Click += new System.EventHandler(this.PbItem5_Click);
            // 
            // PbItem4
            // 
            this.PbItem4.BackgroundImage = global::DevPackMine.Properties.Resources.oie_transparent;
            this.PbItem4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbItem4.Location = new System.Drawing.Point(438, 134);
            this.PbItem4.Name = "PbItem4";
            this.PbItem4.Size = new System.Drawing.Size(22, 22);
            this.PbItem4.TabIndex = 225;
            this.PbItem4.TabStop = false;
            this.PbItem4.Click += new System.EventHandler(this.PbItem4_Click);
            // 
            // PbItem3
            // 
            this.PbItem3.BackgroundImage = global::DevPackMine.Properties.Resources.oie_transparent;
            this.PbItem3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbItem3.Location = new System.Drawing.Point(438, 98);
            this.PbItem3.Name = "PbItem3";
            this.PbItem3.Size = new System.Drawing.Size(22, 22);
            this.PbItem3.TabIndex = 224;
            this.PbItem3.TabStop = false;
            this.PbItem3.Click += new System.EventHandler(this.PbItem3_Click);
            // 
            // PbItem2
            // 
            this.PbItem2.BackgroundImage = global::DevPackMine.Properties.Resources.oie_transparent;
            this.PbItem2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbItem2.Location = new System.Drawing.Point(438, 62);
            this.PbItem2.Name = "PbItem2";
            this.PbItem2.Size = new System.Drawing.Size(22, 22);
            this.PbItem2.TabIndex = 223;
            this.PbItem2.TabStop = false;
            this.PbItem2.Click += new System.EventHandler(this.PbItem2_Click);
            // 
            // PbItem1
            // 
            this.PbItem1.BackgroundImage = global::DevPackMine.Properties.Resources.oie_transparent;
            this.PbItem1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbItem1.Location = new System.Drawing.Point(438, 25);
            this.PbItem1.Name = "PbItem1";
            this.PbItem1.Size = new System.Drawing.Size(22, 22);
            this.PbItem1.TabIndex = 222;
            this.PbItem1.TabStop = false;
            this.PbItem1.Click += new System.EventHandler(this.PbItem1_Click);
            // 
            // textBox93
            // 
            this.textBox93.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox93.Location = new System.Drawing.Point(511, 309);
            this.textBox93.Name = "textBox93";
            this.textBox93.Size = new System.Drawing.Size(100, 20);
            this.textBox93.TabIndex = 221;
            this.textBox93.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox93_KeyPress);
            // 
            // label94
            // 
            this.label94.AutoSize = true;
            this.label94.Location = new System.Drawing.Point(391, 313);
            this.label94.Name = "label94";
            this.label94.Size = new System.Drawing.Size(77, 13);
            this.label94.TabIndex = 220;
            this.label94.Text = "Only Opt Prize:";
            // 
            // textBox64
            // 
            this.textBox64.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox64.Location = new System.Drawing.Point(197, 309);
            this.textBox64.Name = "textBox64";
            this.textBox64.Size = new System.Drawing.Size(100, 20);
            this.textBox64.TabIndex = 218;
            this.textBox64.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox64_KeyPress);
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(93, 313);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(67, 13);
            this.label61.TabIndex = 219;
            this.label61.Text = "Option Prize:";
            // 
            // comboBox20
            // 
            this.comboBox20.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox20.FormattingEnabled = true;
            this.comboBox20.Location = new System.Drawing.Point(46, 243);
            this.comboBox20.Name = "comboBox20";
            this.comboBox20.Size = new System.Drawing.Size(81, 21);
            this.comboBox20.TabIndex = 207;
            this.comboBox20.SelectedIndexChanged += new System.EventHandler(this.comboBox20_SelectedIndexChanged);
            this.comboBox20.SelectionChangeCommitted += new System.EventHandler(this.comboBox20_SelectionChangeCommitted);
            // 
            // comboBox19
            // 
            this.comboBox19.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox19.FormattingEnabled = true;
            this.comboBox19.Location = new System.Drawing.Point(46, 207);
            this.comboBox19.Name = "comboBox19";
            this.comboBox19.Size = new System.Drawing.Size(81, 21);
            this.comboBox19.TabIndex = 206;
            this.comboBox19.SelectedIndexChanged += new System.EventHandler(this.comboBox19_SelectedIndexChanged);
            this.comboBox19.SelectionChangeCommitted += new System.EventHandler(this.comboBox19_SelectionChangeCommitted);
            // 
            // comboBox18
            // 
            this.comboBox18.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox18.FormattingEnabled = true;
            this.comboBox18.Location = new System.Drawing.Point(46, 171);
            this.comboBox18.Name = "comboBox18";
            this.comboBox18.Size = new System.Drawing.Size(81, 21);
            this.comboBox18.TabIndex = 205;
            this.comboBox18.SelectedIndexChanged += new System.EventHandler(this.comboBox18_SelectedIndexChanged);
            this.comboBox18.SelectionChangeCommitted += new System.EventHandler(this.comboBox18_SelectionChangeCommitted);
            // 
            // comboBox17
            // 
            this.comboBox17.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox17.FormattingEnabled = true;
            this.comboBox17.Location = new System.Drawing.Point(46, 135);
            this.comboBox17.Name = "comboBox17";
            this.comboBox17.Size = new System.Drawing.Size(81, 21);
            this.comboBox17.TabIndex = 204;
            this.comboBox17.SelectedIndexChanged += new System.EventHandler(this.comboBox17_SelectedIndexChanged);
            this.comboBox17.SelectionChangeCommitted += new System.EventHandler(this.comboBox17_SelectionChangeCommitted);
            // 
            // comboBox16
            // 
            this.comboBox16.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox16.FormattingEnabled = true;
            this.comboBox16.Location = new System.Drawing.Point(46, 98);
            this.comboBox16.Name = "comboBox16";
            this.comboBox16.Size = new System.Drawing.Size(81, 21);
            this.comboBox16.TabIndex = 203;
            this.comboBox16.SelectedIndexChanged += new System.EventHandler(this.comboBox16_SelectedIndexChanged);
            this.comboBox16.SelectionChangeCommitted += new System.EventHandler(this.comboBox16_SelectionChangeCommitted);
            // 
            // comboBox15
            // 
            this.comboBox15.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox15.FormattingEnabled = true;
            this.comboBox15.Location = new System.Drawing.Point(46, 63);
            this.comboBox15.Name = "comboBox15";
            this.comboBox15.Size = new System.Drawing.Size(81, 21);
            this.comboBox15.TabIndex = 202;
            this.comboBox15.SelectedIndexChanged += new System.EventHandler(this.comboBox15_SelectedIndexChanged);
            this.comboBox15.SelectionChangeCommitted += new System.EventHandler(this.comboBox15_SelectionChangeCommitted);
            // 
            // comboBox14
            // 
            this.comboBox14.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox14.FormattingEnabled = true;
            this.comboBox14.Location = new System.Drawing.Point(46, 27);
            this.comboBox14.Name = "comboBox14";
            this.comboBox14.Size = new System.Drawing.Size(81, 21);
            this.comboBox14.TabIndex = 201;
            this.comboBox14.SelectedIndexChanged += new System.EventHandler(this.comboBox14_SelectedIndexChanged);
            this.comboBox14.SelectionChangeCommitted += new System.EventHandler(this.comboBox14_SelectionChangeCommitted);
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Location = new System.Drawing.Point(6, 246);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(34, 13);
            this.label67.TabIndex = 200;
            this.label67.Text = "Type:";
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Location = new System.Drawing.Point(6, 210);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(34, 13);
            this.label68.TabIndex = 199;
            this.label68.Text = "Type:";
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Location = new System.Drawing.Point(6, 174);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(34, 13);
            this.label66.TabIndex = 194;
            this.label66.Text = "Type:";
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Location = new System.Drawing.Point(6, 138);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(34, 13);
            this.label65.TabIndex = 193;
            this.label65.Text = "Type:";
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Location = new System.Drawing.Point(6, 102);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(34, 13);
            this.label64.TabIndex = 192;
            this.label64.Text = "Type:";
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Location = new System.Drawing.Point(6, 66);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(34, 13);
            this.label63.TabIndex = 191;
            this.label63.Text = "Type:";
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Location = new System.Drawing.Point(6, 30);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(34, 13);
            this.label62.TabIndex = 190;
            this.label62.Text = "Type:";
            // 
            // textBox79
            // 
            this.textBox79.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox79.Location = new System.Drawing.Point(526, 27);
            this.textBox79.Name = "textBox79";
            this.textBox79.Size = new System.Drawing.Size(100, 20);
            this.textBox79.TabIndex = 188;
            this.textBox79.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox79_KeyPress);
            // 
            // textBox80
            // 
            this.textBox80.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox80.Location = new System.Drawing.Point(526, 63);
            this.textBox80.Name = "textBox80";
            this.textBox80.Size = new System.Drawing.Size(100, 20);
            this.textBox80.TabIndex = 187;
            this.textBox80.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox80_KeyPress);
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.Location = new System.Drawing.Point(472, 246);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(46, 13);
            this.label76.TabIndex = 186;
            this.label76.Text = "Amount:";
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.label77.Location = new System.Drawing.Point(472, 210);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(46, 13);
            this.label77.TabIndex = 185;
            this.label77.Text = "Amount:";
            // 
            // textBox81
            // 
            this.textBox81.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox81.Location = new System.Drawing.Point(526, 98);
            this.textBox81.Name = "textBox81";
            this.textBox81.Size = new System.Drawing.Size(100, 20);
            this.textBox81.TabIndex = 184;
            this.textBox81.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox81_KeyPress);
            // 
            // textBox82
            // 
            this.textBox82.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox82.Location = new System.Drawing.Point(526, 135);
            this.textBox82.Name = "textBox82";
            this.textBox82.Size = new System.Drawing.Size(100, 20);
            this.textBox82.TabIndex = 183;
            this.textBox82.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox82_KeyPress);
            // 
            // textBox83
            // 
            this.textBox83.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox83.Location = new System.Drawing.Point(526, 171);
            this.textBox83.Name = "textBox83";
            this.textBox83.Size = new System.Drawing.Size(100, 20);
            this.textBox83.TabIndex = 182;
            this.textBox83.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox83_KeyPress);
            // 
            // textBox84
            // 
            this.textBox84.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox84.Location = new System.Drawing.Point(526, 207);
            this.textBox84.Name = "textBox84";
            this.textBox84.Size = new System.Drawing.Size(100, 20);
            this.textBox84.TabIndex = 181;
            this.textBox84.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox84_KeyPress);
            // 
            // textBox85
            // 
            this.textBox85.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox85.Location = new System.Drawing.Point(526, 243);
            this.textBox85.Name = "textBox85";
            this.textBox85.Size = new System.Drawing.Size(100, 20);
            this.textBox85.TabIndex = 175;
            this.textBox85.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox85_KeyPress);
            // 
            // label78
            // 
            this.label78.AutoSize = true;
            this.label78.Location = new System.Drawing.Point(472, 174);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(46, 13);
            this.label78.TabIndex = 180;
            this.label78.Text = "Amount:";
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.Location = new System.Drawing.Point(472, 138);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(46, 13);
            this.label79.TabIndex = 179;
            this.label79.Text = "Amount:";
            // 
            // label80
            // 
            this.label80.AutoSize = true;
            this.label80.Location = new System.Drawing.Point(472, 102);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(46, 13);
            this.label80.TabIndex = 178;
            this.label80.Text = "Amount:";
            // 
            // label81
            // 
            this.label81.AutoSize = true;
            this.label81.Location = new System.Drawing.Point(472, 66);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(46, 13);
            this.label81.TabIndex = 177;
            this.label81.Text = "Amount:";
            // 
            // label82
            // 
            this.label82.AutoSize = true;
            this.label82.Location = new System.Drawing.Point(472, 30);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(46, 13);
            this.label82.TabIndex = 176;
            this.label82.Text = "Amount:";
            // 
            // textBox72
            // 
            this.textBox72.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox72.Location = new System.Drawing.Point(189, 27);
            this.textBox72.Name = "textBox72";
            this.textBox72.Size = new System.Drawing.Size(53, 20);
            this.textBox72.TabIndex = 174;
            this.textBox72.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox72_KeyPress);
            // 
            // textBox73
            // 
            this.textBox73.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox73.Location = new System.Drawing.Point(189, 63);
            this.textBox73.Name = "textBox73";
            this.textBox73.Size = new System.Drawing.Size(53, 20);
            this.textBox73.TabIndex = 173;
            this.textBox73.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox73_KeyPress);
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Location = new System.Drawing.Point(635, 246);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(56, 13);
            this.label69.TabIndex = 172;
            this.label69.Text = "Prize Plus:";
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Location = new System.Drawing.Point(635, 210);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(56, 13);
            this.label70.TabIndex = 171;
            this.label70.Text = "Prize Plus:";
            // 
            // textBox74
            // 
            this.textBox74.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox74.Location = new System.Drawing.Point(189, 98);
            this.textBox74.Name = "textBox74";
            this.textBox74.Size = new System.Drawing.Size(53, 20);
            this.textBox74.TabIndex = 170;
            this.textBox74.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox74_KeyPress);
            // 
            // textBox75
            // 
            this.textBox75.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox75.Location = new System.Drawing.Point(189, 135);
            this.textBox75.Name = "textBox75";
            this.textBox75.Size = new System.Drawing.Size(53, 20);
            this.textBox75.TabIndex = 169;
            this.textBox75.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox75_KeyPress);
            // 
            // textBox76
            // 
            this.textBox76.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox76.Location = new System.Drawing.Point(189, 171);
            this.textBox76.Name = "textBox76";
            this.textBox76.Size = new System.Drawing.Size(53, 20);
            this.textBox76.TabIndex = 168;
            this.textBox76.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox76_KeyPress);
            // 
            // textBox77
            // 
            this.textBox77.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox77.Location = new System.Drawing.Point(189, 207);
            this.textBox77.Name = "textBox77";
            this.textBox77.Size = new System.Drawing.Size(53, 20);
            this.textBox77.TabIndex = 167;
            this.textBox77.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox77_KeyPress);
            // 
            // textBox78
            // 
            this.textBox78.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox78.Location = new System.Drawing.Point(189, 243);
            this.textBox78.Name = "textBox78";
            this.textBox78.Size = new System.Drawing.Size(53, 20);
            this.textBox78.TabIndex = 161;
            this.textBox78.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox78_KeyPress);
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Location = new System.Drawing.Point(635, 174);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(56, 13);
            this.label71.TabIndex = 166;
            this.label71.Text = "Prize Plus:";
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.Location = new System.Drawing.Point(635, 138);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(56, 13);
            this.label72.TabIndex = 165;
            this.label72.Text = "Prize Plus:";
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.Location = new System.Drawing.Point(635, 102);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(56, 13);
            this.label73.TabIndex = 164;
            this.label73.Text = "Prize Plus:";
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.Location = new System.Drawing.Point(635, 66);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(56, 13);
            this.label74.TabIndex = 163;
            this.label74.Text = "Prize Plus:";
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.Location = new System.Drawing.Point(635, 30);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(56, 13);
            this.label75.TabIndex = 162;
            this.label75.Text = "Prize Plus:";
            // 
            // textBox86
            // 
            this.textBox86.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox86.Location = new System.Drawing.Point(700, 27);
            this.textBox86.Name = "textBox86";
            this.textBox86.Size = new System.Drawing.Size(41, 20);
            this.textBox86.TabIndex = 113;
            this.textBox86.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox86_KeyPress);
            // 
            // textBox87
            // 
            this.textBox87.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox87.Location = new System.Drawing.Point(700, 63);
            this.textBox87.Name = "textBox87";
            this.textBox87.Size = new System.Drawing.Size(41, 20);
            this.textBox87.TabIndex = 112;
            this.textBox87.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox87_KeyPress);
            // 
            // textBox92
            // 
            this.textBox92.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox92.Location = new System.Drawing.Point(700, 243);
            this.textBox92.Name = "textBox92";
            this.textBox92.Size = new System.Drawing.Size(41, 20);
            this.textBox92.TabIndex = 100;
            this.textBox92.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox92_KeyPress);
            // 
            // label83
            // 
            this.label83.AutoSize = true;
            this.label83.Location = new System.Drawing.Point(140, 246);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(44, 13);
            this.label83.TabIndex = 111;
            this.label83.Text = "Item ID:";
            // 
            // label90
            // 
            this.label90.AutoSize = true;
            this.label90.Location = new System.Drawing.Point(140, 30);
            this.label90.Name = "label90";
            this.label90.Size = new System.Drawing.Size(44, 13);
            this.label90.TabIndex = 101;
            this.label90.Text = "Item ID:";
            // 
            // label84
            // 
            this.label84.AutoSize = true;
            this.label84.Location = new System.Drawing.Point(140, 210);
            this.label84.Name = "label84";
            this.label84.Size = new System.Drawing.Size(44, 13);
            this.label84.TabIndex = 110;
            this.label84.Text = "Item ID:";
            // 
            // label89
            // 
            this.label89.AutoSize = true;
            this.label89.Location = new System.Drawing.Point(140, 66);
            this.label89.Name = "label89";
            this.label89.Size = new System.Drawing.Size(44, 13);
            this.label89.TabIndex = 102;
            this.label89.Text = "Item ID:";
            // 
            // textBox88
            // 
            this.textBox88.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox88.Location = new System.Drawing.Point(700, 98);
            this.textBox88.Name = "textBox88";
            this.textBox88.Size = new System.Drawing.Size(41, 20);
            this.textBox88.TabIndex = 109;
            this.textBox88.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox88_KeyPress);
            // 
            // label88
            // 
            this.label88.AutoSize = true;
            this.label88.Location = new System.Drawing.Point(140, 102);
            this.label88.Name = "label88";
            this.label88.Size = new System.Drawing.Size(44, 13);
            this.label88.TabIndex = 103;
            this.label88.Text = "Item ID:";
            // 
            // textBox89
            // 
            this.textBox89.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox89.Location = new System.Drawing.Point(700, 135);
            this.textBox89.Name = "textBox89";
            this.textBox89.Size = new System.Drawing.Size(41, 20);
            this.textBox89.TabIndex = 108;
            this.textBox89.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox89_KeyPress);
            // 
            // label87
            // 
            this.label87.AutoSize = true;
            this.label87.Location = new System.Drawing.Point(140, 138);
            this.label87.Name = "label87";
            this.label87.Size = new System.Drawing.Size(44, 13);
            this.label87.TabIndex = 104;
            this.label87.Text = "Item ID:";
            // 
            // textBox90
            // 
            this.textBox90.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox90.Location = new System.Drawing.Point(700, 171);
            this.textBox90.Name = "textBox90";
            this.textBox90.Size = new System.Drawing.Size(41, 20);
            this.textBox90.TabIndex = 107;
            this.textBox90.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox90_KeyPress);
            // 
            // label86
            // 
            this.label86.AutoSize = true;
            this.label86.Location = new System.Drawing.Point(140, 174);
            this.label86.Name = "label86";
            this.label86.Size = new System.Drawing.Size(44, 13);
            this.label86.TabIndex = 105;
            this.label86.Text = "Item ID:";
            // 
            // textBox91
            // 
            this.textBox91.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox91.Location = new System.Drawing.Point(700, 207);
            this.textBox91.Name = "textBox91";
            this.textBox91.Size = new System.Drawing.Size(41, 20);
            this.textBox91.TabIndex = 106;
            this.textBox91.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox91_KeyPress);
            // 
            // textBox69
            // 
            this.textBox69.Location = new System.Drawing.Point(38, 543);
            this.textBox69.Name = "textBox69";
            this.textBox69.Size = new System.Drawing.Size(41, 20);
            this.textBox69.TabIndex = 211;
            this.textBox69.Visible = false;
            // 
            // textBox70
            // 
            this.textBox70.Location = new System.Drawing.Point(85, 439);
            this.textBox70.Name = "textBox70";
            this.textBox70.Size = new System.Drawing.Size(41, 20);
            this.textBox70.TabIndex = 210;
            this.textBox70.Visible = false;
            // 
            // textBox68
            // 
            this.textBox68.Location = new System.Drawing.Point(38, 517);
            this.textBox68.Name = "textBox68";
            this.textBox68.Size = new System.Drawing.Size(41, 20);
            this.textBox68.TabIndex = 212;
            this.textBox68.Visible = false;
            // 
            // textBox65
            // 
            this.textBox65.Location = new System.Drawing.Point(38, 439);
            this.textBox65.Name = "textBox65";
            this.textBox65.Size = new System.Drawing.Size(41, 20);
            this.textBox65.TabIndex = 214;
            this.textBox65.Visible = false;
            // 
            // textBox71
            // 
            this.textBox71.Location = new System.Drawing.Point(85, 465);
            this.textBox71.Name = "textBox71";
            this.textBox71.Size = new System.Drawing.Size(41, 20);
            this.textBox71.TabIndex = 209;
            this.textBox71.Visible = false;
            // 
            // textBox67
            // 
            this.textBox67.Location = new System.Drawing.Point(38, 491);
            this.textBox67.Name = "textBox67";
            this.textBox67.Size = new System.Drawing.Size(41, 20);
            this.textBox67.TabIndex = 208;
            this.textBox67.Visible = false;
            // 
            // textBox66
            // 
            this.textBox66.Location = new System.Drawing.Point(38, 465);
            this.textBox66.Name = "textBox66";
            this.textBox66.Size = new System.Drawing.Size(41, 20);
            this.textBox66.TabIndex = 213;
            this.textBox66.Visible = false;
            // 
            // tabPage7
            // 
            this.tabPage7.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage7.Controls.Add(this.groupBox7);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(765, 610);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Other";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.textBox103);
            this.groupBox7.Controls.Add(this.label103);
            this.groupBox7.Controls.Add(this.textBox102);
            this.groupBox7.Controls.Add(this.label102);
            this.groupBox7.Controls.Add(this.label99);
            this.groupBox7.Controls.Add(this.textBox100);
            this.groupBox7.Controls.Add(this.textBox97);
            this.groupBox7.Controls.Add(this.label97);
            this.groupBox7.Controls.Add(this.textBox101);
            this.groupBox7.Controls.Add(this.label101);
            this.groupBox7.Controls.Add(this.textBox99);
            this.groupBox7.Controls.Add(this.label100);
            this.groupBox7.Location = new System.Drawing.Point(6, 6);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(389, 248);
            this.groupBox7.TabIndex = 91;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Other";
            // 
            // textBox103
            // 
            this.textBox103.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox103.Location = new System.Drawing.Point(123, 181);
            this.textBox103.Name = "textBox103";
            this.textBox103.Size = new System.Drawing.Size(83, 20);
            this.textBox103.TabIndex = 241;
            // 
            // label103
            // 
            this.label103.AutoSize = true;
            this.label103.Location = new System.Drawing.Point(7, 184);
            this.label103.Name = "label103";
            this.label103.Size = new System.Drawing.Size(61, 13);
            this.label103.TabIndex = 240;
            this.label103.Text = "Quest Flag:";
            // 
            // textBox102
            // 
            this.textBox102.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox102.Location = new System.Drawing.Point(123, 148);
            this.textBox102.Name = "textBox102";
            this.textBox102.Size = new System.Drawing.Size(83, 20);
            this.textBox102.TabIndex = 239;
            // 
            // label102
            // 
            this.label102.AutoSize = true;
            this.label102.Location = new System.Drawing.Point(7, 152);
            this.label102.Name = "label102";
            this.label102.Size = new System.Drawing.Size(82, 13);
            this.label102.TabIndex = 238;
            this.label102.Text = "Start Trigger ID:";
            // 
            // label99
            // 
            this.label99.AutoSize = true;
            this.label99.Location = new System.Drawing.Point(7, 93);
            this.label99.Name = "label99";
            this.label99.Size = new System.Drawing.Size(109, 13);
            this.label99.TabIndex = 237;
            this.label99.Text = "Start Give KindCount:";
            // 
            // textBox100
            // 
            this.textBox100.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox100.Location = new System.Drawing.Point(123, 86);
            this.textBox100.Name = "textBox100";
            this.textBox100.Size = new System.Drawing.Size(100, 20);
            this.textBox100.TabIndex = 236;
            // 
            // textBox97
            // 
            this.textBox97.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox97.Location = new System.Drawing.Point(123, 116);
            this.textBox97.Name = "textBox97";
            this.textBox97.Size = new System.Drawing.Size(100, 20);
            this.textBox97.TabIndex = 235;
            // 
            // label97
            // 
            this.label97.AutoSize = true;
            this.label97.Location = new System.Drawing.Point(7, 123);
            this.label97.Name = "label97";
            this.label97.Size = new System.Drawing.Size(56, 13);
            this.label97.TabIndex = 234;
            this.label97.Text = "Fail Value:";
            // 
            // textBox101
            // 
            this.textBox101.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox101.Location = new System.Drawing.Point(123, 56);
            this.textBox101.Name = "textBox101";
            this.textBox101.Size = new System.Drawing.Size(100, 20);
            this.textBox101.TabIndex = 221;
            // 
            // label101
            // 
            this.label101.AutoSize = true;
            this.label101.Location = new System.Drawing.Point(7, 60);
            this.label101.Name = "label101";
            this.label101.Size = new System.Drawing.Size(82, 13);
            this.label101.TabIndex = 220;
            this.label101.Text = "Start Give Num:";
            // 
            // textBox99
            // 
            this.textBox99.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox99.Location = new System.Drawing.Point(123, 25);
            this.textBox99.Name = "textBox99";
            this.textBox99.Size = new System.Drawing.Size(100, 20);
            this.textBox99.TabIndex = 219;
            // 
            // label100
            // 
            this.label100.AutoSize = true;
            this.label100.Location = new System.Drawing.Point(7, 32);
            this.label100.Name = "label100";
            this.label100.Size = new System.Drawing.Size(80, 13);
            this.label100.TabIndex = 216;
            this.label100.Text = "Start Give Item:";
            // 
            // button7
            // 
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(952, 665);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(100, 28);
            this.button7.TabIndex = 37;
            this.button7.Text = "Save";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label113
            // 
            this.label113.AutoSize = true;
            this.label113.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label113.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label113.Location = new System.Drawing.Point(784, 5);
            this.label113.Name = "label113";
            this.label113.Size = new System.Drawing.Size(154, 16);
            this.label113.TabIndex = 38;
            this.label113.Text = "Current Language is :";
            // 
            // lblLang
            // 
            this.lblLang.AutoSize = true;
            this.lblLang.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblLang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLang.ForeColor = System.Drawing.Color.Chartreuse;
            this.lblLang.Location = new System.Drawing.Point(941, 6);
            this.lblLang.Name = "lblLang";
            this.lblLang.Size = new System.Drawing.Size(0, 16);
            this.lblLang.TabIndex = 103;
            // 
            // PbStartItemNPC
            // 
            this.PbStartItemNPC.BackgroundImage = global::DevPackMine.Properties.Resources.oie_transparent;
            this.PbStartItemNPC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbStartItemNPC.Location = new System.Drawing.Point(136, 73);
            this.PbStartItemNPC.Name = "PbStartItemNPC";
            this.PbStartItemNPC.Size = new System.Drawing.Size(22, 22);
            this.PbStartItemNPC.TabIndex = 116;
            this.PbStartItemNPC.TabStop = false;
            this.PbStartItemNPC.Click += new System.EventHandler(this.PbStartItemNPC_Click);
            // 
            // PbEndNPCItem
            // 
            this.PbEndNPCItem.BackgroundImage = global::DevPackMine.Properties.Resources.oie_transparent;
            this.PbEndNPCItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbEndNPCItem.Location = new System.Drawing.Point(136, 118);
            this.PbEndNPCItem.Name = "PbEndNPCItem";
            this.PbEndNPCItem.Size = new System.Drawing.Size(22, 22);
            this.PbEndNPCItem.TabIndex = 117;
            this.PbEndNPCItem.TabStop = false;
            this.PbEndNPCItem.Click += new System.EventHandler(this.PbEndNPCItem_Click);
            // 
            // label119
            // 
            this.label119.AutoSize = true;
            this.label119.BackColor = System.Drawing.SystemColors.Control;
            this.label119.Location = new System.Drawing.Point(12, 665);
            this.label119.Name = "label119";
            this.label119.Size = new System.Drawing.Size(52, 13);
            this.label119.TabIndex = 104;
            this.label119.Text = "ColorKey:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LimeGreen;
            this.pictureBox1.Location = new System.Drawing.Point(96, 665);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 15);
            this.pictureBox1.TabIndex = 105;
            this.pictureBox1.TabStop = false;
            // 
            // label120
            // 
            this.label120.AutoSize = true;
            this.label120.BackColor = System.Drawing.SystemColors.Control;
            this.label120.Location = new System.Drawing.Point(62, 665);
            this.label120.Name = "label120";
            this.label120.Size = new System.Drawing.Size(32, 13);
            this.label120.TabIndex = 106;
            this.label120.Text = "NPC:";
            // 
            // label121
            // 
            this.label121.AutoSize = true;
            this.label121.BackColor = System.Drawing.SystemColors.Control;
            this.label121.Location = new System.Drawing.Point(118, 665);
            this.label121.Name = "label121";
            this.label121.Size = new System.Drawing.Size(34, 13);
            this.label121.TabIndex = 108;
            this.label121.Text = "MOB:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Red;
            this.pictureBox2.Location = new System.Drawing.Point(154, 665);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 15);
            this.pictureBox2.TabIndex = 107;
            this.pictureBox2.TabStop = false;
            // 
            // label122
            // 
            this.label122.AutoSize = true;
            this.label122.BackColor = System.Drawing.SystemColors.Control;
            this.label122.Location = new System.Drawing.Point(182, 665);
            this.label122.Name = "label122";
            this.label122.Size = new System.Drawing.Size(36, 13);
            this.label122.TabIndex = 110;
            this.label122.Text = "ITEM:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.RoyalBlue;
            this.pictureBox3.Location = new System.Drawing.Point(218, 665);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 15);
            this.pictureBox3.TabIndex = 109;
            this.pictureBox3.TabStop = false;
            // 
            // QuestEditor
            // 
            this.ClientSize = new System.Drawing.Size(1056, 699);
            this.Controls.Add(this.label122);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label121);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label120);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label119);
            this.Controls.Add(this.lblLang);
            this.Controls.Add(this.label113);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button7);
            
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "QuestEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quest Editor EP4";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbItemNeed5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbItemNeed4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbItemNeed3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbItemNeed2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbItemNeed1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbCond1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbObj1NpcID3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbObj1NpcID2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbObj1NpcID1)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbCond2)).EndInit();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbObj2NpcID3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbObj2NpcID2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbObj2NpcID1)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbCond3)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbNpcID3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbNpcID2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbNpcID1)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.tabControl3.ResumeLayout(false);
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbPItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbPItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbPItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbPItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbPItem1)).EndInit();
            this.tabPage9.ResumeLayout(false);
            this.tabPage9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbItem1)).EndInit();
            this.tabPage7.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbStartItemNPC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbEndNPCItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

        private void CbRvrType_SelectedIndexChanged(object sender, EventArgs e) //dethunter12 add 6/11/2018
        {
            textBox26.Text = CbRvrType.SelectedIndex.ToString();
            if (textBox26.Text == "1")
            {
                CbRvRGrade.Visible = true;
                CbRvRGrade1.Visible = false;
            }
            else if (textBox26.Text == "2")
            {
                CbRvRGrade.Visible = false;
                CbRvRGrade1.Visible = true;
            }
        }

        private void CbRvRGrade1_SelectedIndexChanged(object sender, EventArgs e) //dethunter12 add 6/11/2018
        {
            if (textBox26.Text == "2")
            {
                textBox27.Text = GetIndexByComboBox(CbRvRGrade1.Text).ToString(); //dethunter12  add
            }
        }

        private void CbRvRGrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (textBox26.Text == "2")
            {
                textBox27.Text = GetIndexByComboBox(CbRvRGrade.Text).ToString(); //dethunter12  add
            }
        }

        private void BtnCopy_Click(object sender, EventArgs e) //dethunter12 add 6/11/2018
        {
            databaseHandle.SendQueryMySql(Host, User, Password, Database, "DROP TABLE IF EXISTS tempTable;" + "CREATE TEMPORARY TABLE tempTable ENGINE=MyISAM SELECT * FROM t_quest WHERE a_index=" + textBox1.Text + ";" + "SELECT a_index FROM tempTable;" + "UPDATE tempTable SET a_index=(SELECT a_index from t_quest ORDER BY a_index DESC LIMIT 1)+1; " + "SELECT a_index FROM tempTable;" + "INSERT INTO t_quest SELECT * FROM tempTable;");
            LoadListBox();
            listBox1.SelectedIndex = listBox1.Items.Count - 1; //test
            int num5 = (int)new CustomMessage("Copying Complete").ShowDialog();
        }

        private void PbItem1_Click(object sender, EventArgs e) //dethunter12 add 6/11/2018
        {
            ItemPicker itemPicker = new ItemPicker();
            if (itemPicker.ShowDialog() != DialogResult.OK)
                return;
            textBox72.Text = itemPicker.ItemIndex.ToString();
            TbPrize2ItemDesc1.Text = databaseHandle.ItemNameFast(Convert.ToInt32(textBox72.Text)); //dethunter12 add 6/14/2018
            textBox72.BackColor = Color.LightBlue;
        }

        private void PbItem2_Click(object sender, EventArgs e) //dethunter12 add 6/11/2018
        {
            ItemPicker itemPicker = new ItemPicker();
            if (itemPicker.ShowDialog() != DialogResult.OK)
                return;
            textBox73.Text = itemPicker.ItemIndex.ToString();
            TbPrize2ItemDesc2.Text = databaseHandle.ItemNameFast(Convert.ToInt32(textBox73.Text)); //dethunter12 add 6/14/2018
            textBox73.BackColor = Color.LightBlue;
        }

        private void PbItem3_Click(object sender, EventArgs e) //dethunter12 add 6/11/2018
        {
            ItemPicker itemPicker = new ItemPicker();
            if (itemPicker.ShowDialog() != DialogResult.OK)
                return;
            textBox74.Text = itemPicker.ItemIndex.ToString();
            TbPrize2ItemDesc3.Text = databaseHandle.ItemNameFast(Convert.ToInt32(textBox74.Text)); //dethunter12 add 6/14/2018
            textBox74.BackColor = Color.LightBlue;
        }

        private void PbItem4_Click(object sender, EventArgs e) //dethunter12 add 6/11/2018
        {
            ItemPicker itemPicker = new ItemPicker();
            if (itemPicker.ShowDialog() != DialogResult.OK)
                return;
            textBox75.Text = itemPicker.ItemIndex.ToString();
            TbPrize2ItemDesc4.Text = databaseHandle.ItemNameFast(Convert.ToInt32(textBox75.Text)); //dethunter12 add 6/14/2018
            textBox75.BackColor = Color.LightBlue;
        }

        private void PbItem5_Click(object sender, EventArgs e) //dethunter12 add 6/11/2018
        {
            ItemPicker itemPicker = new ItemPicker();
            if (itemPicker.ShowDialog() != DialogResult.OK)
                return;
            textBox76.Text = itemPicker.ItemIndex.ToString();
            TbPrize2ItemDesc5.Text = databaseHandle.ItemNameFast(Convert.ToInt32(textBox76.Text)); //dethunter12 add 6/14/2018
            textBox76.BackColor = Color.LightBlue;
        }

        private void PbItem6_Click(object sender, EventArgs e) //dethunter12 add 6/11/2018
        {
            ItemPicker itemPicker = new ItemPicker();
            if (itemPicker.ShowDialog() != DialogResult.OK)
                return;
            textBox77.Text = itemPicker.ItemIndex.ToString();
            TbPrize2ItemDesc6.Text = databaseHandle.ItemNameFast(Convert.ToInt32(textBox77.Text)); //dethunter12 add 6/14/2018
            textBox77.BackColor = Color.LightBlue;
        }

        private void PbItem7_Click(object sender, EventArgs e) //dethunter12 add 6/11/2018
        {
            ItemPicker itemPicker = new ItemPicker();
            if (itemPicker.ShowDialog() != DialogResult.OK)
                return;
            textBox78.Text = itemPicker.ItemIndex.ToString();
            TbPrize2ItemDesc7.Text = databaseHandle.ItemNameFast(Convert.ToInt32(textBox78.Text)); //dethunter12 add 6/14/2018
            textBox78.BackColor = Color.LightBlue;
        }

        private void PbPItem1_Click(object sender, EventArgs e) //dethunter12 add 6/11/2018
        {
            ItemPicker itemPicker = new ItemPicker();
            if (itemPicker.ShowDialog() != DialogResult.OK)
                return;
            textBox54.Text = itemPicker.ItemIndex.ToString();
            tbItemDesc1.Text = databaseHandle.ItemNameFast(Convert.ToInt32(textBox54.Text)); //dethunter12 6/14/2018 add
            textBox54.BackColor = Color.LightBlue;
        }

        private void PbPItem2_Click(object sender, EventArgs e) //dethunter12 add 6/11/2018
        {
            ItemPicker itemPicker = new ItemPicker();
            if (itemPicker.ShowDialog() != DialogResult.OK)
                return;
            textBox55.Text = itemPicker.ItemIndex.ToString();
           tbItemDesc2.Text = databaseHandle.ItemNameFast(Convert.ToInt32(textBox55.Text)); //dethunter12 add 6/14/2018
            textBox55.BackColor = Color.LightBlue;
        }

        private void PbPItem3_Click(object sender, EventArgs e) //dethunter12 add 6/11/2018
        {
            ItemPicker itemPicker = new ItemPicker();
            if (itemPicker.ShowDialog() != DialogResult.OK)
                return;
            textBox56.Text = itemPicker.ItemIndex.ToString();
            tbItemDesc3.Text = databaseHandle.ItemNameFast(Convert.ToInt32(textBox56.Text)); //dethunter12 add 6/14/2018
            textBox56.BackColor = Color.LightBlue;
        }

        private void PbPItem4_Click(object sender, EventArgs e) //dethunter12 add 6/11/2018
        {
            ItemPicker itemPicker = new ItemPicker();
            if (itemPicker.ShowDialog() != DialogResult.OK)
                return;
            textBox57.Text = itemPicker.ItemIndex.ToString();
            tbItemDesc4.Text = databaseHandle.ItemNameFast(Convert.ToInt32(textBox57.Text)); //dethunter12 add 6/14/2018
            textBox57.BackColor = Color.LightBlue;
        }

        private void PbPItem5_Click(object sender, EventArgs e) //dethunter12 add 6/11/2018
        {
            ItemPicker itemPicker = new ItemPicker();
            if (itemPicker.ShowDialog() != DialogResult.OK)
                return;
            textBox58.Text = itemPicker.ItemIndex.ToString();
            tbItemDesc5.Text = databaseHandle.ItemNameFast(Convert.ToInt32(textBox58.Text)); //dethunter12 add 6/14/2018
            textBox58.BackColor = Color.LightBlue;
        }

        private void PbCond1_Click(object sender, EventArgs e) //dethunter12 add 6/11/2018
        {
            if (textBox28.Text == "0") //dethunter12 add 6/14/2018 conditional check if mob display mob picker else display the itempicker
            {
                MobPicker mobPicker = new MobPicker();
                if (mobPicker.ShowDialog() != DialogResult.OK)
                    return;
                textBox31.Text = mobPicker.MobIndex.ToString();
                TbObj1.Text = databaseHandle.MobNameFast(Convert.ToInt32(textBox31.Text));
                textBox31.BackColor = Color.LightBlue;
            }
            else //dethunter12 add 6/14/2018
            {
                ItemPicker itemPicker = new ItemPicker();
                if (itemPicker.ShowDialog() != DialogResult.OK)
                    return;
                textBox31.Text = itemPicker.ItemIndex.ToString();
                TbObj1.Text = databaseHandle.ItemNameFast(Convert.ToInt32(textBox31.Text)); //dethunter12 add 6/14/2018
                textBox31.BackColor = Color.LightBlue;
            }
        }

        private void PbCond2_Click(object sender, EventArgs e) //dethunter12 add 6/11/2018
        {
            if (textBox28.Text == "0") //dethunter12 add 6/14/2018
            {
                MobPicker mobPicker = new MobPicker();
                if (mobPicker.ShowDialog() != DialogResult.OK)
                    return;
                textBox32.Text = mobPicker.MobIndex.ToString();
                TbObj2.Text = databaseHandle.MobNameFast(Convert.ToInt32(textBox32.Text));
                textBox32.BackColor = Color.LightBlue;
            }
            else //dethunter12 add 6/14/2018
            {
                ItemPicker itemPicker = new ItemPicker();
                if (itemPicker.ShowDialog() != DialogResult.OK)
                    return;
                textBox32.Text = itemPicker.ItemIndex.ToString();
                TbObj2.Text = databaseHandle.ItemNameFast(Convert.ToInt32(textBox32.Text)); //dethunter12 add 6/14/2018
                textBox32.BackColor = Color.LightBlue;
            }
        }

        private void PbCond3_Click(object sender, EventArgs e) //dethunter12 add 6/11/2018
        {
            if (textBox28.Text == "0") //dethunter12 add 6/14/2018
            {
                MobPicker mobPicker = new MobPicker();
                if (mobPicker.ShowDialog() != DialogResult.OK)
                    return;
                textBox33.Text = mobPicker.MobIndex.ToString();
                TbObj3.Text = databaseHandle.MobNameFast(Convert.ToInt32(textBox33.Text));
                textBox33.BackColor = Color.LightBlue;
            }
            else //dethunter12 add 6/14/2018
            {
                ItemPicker itemPicker = new ItemPicker();
                if (itemPicker.ShowDialog() != DialogResult.OK)
                    return;
                textBox33.Text = itemPicker.ItemIndex.ToString();
                TbObj3.Text = databaseHandle.ItemNameFast(Convert.ToInt32(textBox33.Text)); //dethunter12 add 6/14/2018
                textBox33.BackColor = Color.LightBlue;
            }
        }

        private void PbNpcID1_Click(object sender, EventArgs e) //dethunter12 add 6/14/2018
        {
            MobPicker mobPicker = new MobPicker();
            if (mobPicker.ShowDialog() != DialogResult.OK)
                return;
            textBox45.Text = mobPicker.MobIndex.ToString();
            TbObjNpc1.Text = databaseHandle.MobNameFast(Convert.ToInt32(textBox45.Text));
            textBox45.BackColor = Color.LightBlue;
        }

        private void PbNpcID2_Click(object sender, EventArgs e) //dethunter12 add 6/14/2018
        {
            MobPicker mobPicker = new MobPicker();
            if (mobPicker.ShowDialog() != DialogResult.OK)
                return;
            textBox46.Text = mobPicker.MobIndex.ToString();
            TbObjNpc2.Text = databaseHandle.MobNameFast(Convert.ToInt32(textBox46.Text));
            textBox46.BackColor = Color.LightBlue;
        }

        private void PbNpcID3_Click(object sender, EventArgs e) //dethunter12 6/14/2018
        {
            MobPicker mobPicker = new MobPicker();
            if (mobPicker.ShowDialog() != DialogResult.OK)
                return;
            textBox47.Text = mobPicker.MobIndex.ToString();
            TbObjNpc3.Text = databaseHandle.MobNameFast(Convert.ToInt32(textBox47.Text));
            textBox47.BackColor = Color.LightBlue;
        }

        private void PbObj1NpcID1_Click(object sender, EventArgs e) //dethunter12 6/14/2018
        {
            MobPicker mobPicker = new MobPicker();
            if (mobPicker.ShowDialog() != DialogResult.OK)
                return;
            textBox37.Text = mobPicker.MobIndex.ToString();
            TbObj1Npc1.Text = databaseHandle.MobNameFast(Convert.ToInt32(textBox37.Text));
            textBox37.BackColor = Color.LightBlue;
        }

        private void PbObj1NpcID2_Click(object sender, EventArgs e) //dethunter12 6/14/2018
        {
            MobPicker mobPicker = new MobPicker();
            if (mobPicker.ShowDialog() != DialogResult.OK)
                return;
            textBox38.Text = mobPicker.MobIndex.ToString();
            TbObj1Npc2.Text = databaseHandle.MobNameFast(Convert.ToInt32(textBox38.Text));
            textBox38.BackColor = Color.LightBlue;
        }

        private void PbObj1NpcID3_Click(object sender, EventArgs e) //dethunter12 6/14/2018
        {
            MobPicker mobPicker = new MobPicker();
            if (mobPicker.ShowDialog() != DialogResult.OK)
                return;
            textBox39.Text = mobPicker.MobIndex.ToString();
            TbObj1Npc3.Text = databaseHandle.MobNameFast(Convert.ToInt32(textBox39.Text));
            textBox39.BackColor = Color.LightBlue;
        }

        private void PbObj2NpcID1_Click(object sender, EventArgs e) //dethunter12 6/14/2018
        {
            MobPicker mobPicker = new MobPicker();
            if (mobPicker.ShowDialog() != DialogResult.OK)
                return;
            textBox41.Text = mobPicker.MobIndex.ToString();
            TbObj2Npc1.Text = databaseHandle.MobNameFast(Convert.ToInt32(textBox41.Text));
            textBox41.BackColor = Color.LightBlue;
        }

        private void PbObj2NpcID2_Click(object sender, EventArgs e) //dethunter12 6/14/2018
        {
            MobPicker mobPicker = new MobPicker();
            if (mobPicker.ShowDialog() != DialogResult.OK)
                return;
            textBox42.Text = mobPicker.MobIndex.ToString();
            TbObj2Npc2.Text = databaseHandle.MobNameFast(Convert.ToInt32(textBox42.Text));
            textBox42.BackColor = Color.LightBlue;
        }

        private void PbObj2NpcID3_Click(object sender, EventArgs e)  //dethunter12 6/14/2018
        {
            MobPicker mobPicker = new MobPicker();
            if (mobPicker.ShowDialog() != DialogResult.OK)
                return;
            textBox43.Text = mobPicker.MobIndex.ToString();
            TbObj2Npc3.Text = databaseHandle.MobNameFast(Convert.ToInt32(textBox43.Text));
            textBox43.BackColor = Color.LightBlue;
        }

        private void PbStartItemNPC_Click(object sender, EventArgs e) //dethunter12 6/14/2018
        {
            if (textBox7.Text == "0")
            {
                MobPicker mobPicker = new MobPicker();
                if (mobPicker.ShowDialog() != DialogResult.OK)
                    return;
                textBox8.Text = mobPicker.MobIndex.ToString();
                TbEndNpcName.Text = databaseHandle.MobNameFast(Convert.ToInt32(textBox8.Text));
                textBox8.BackColor = Color.LightBlue;
            }
            else if (textBox7.Text == "1")
            {
                ItemPicker itemPicker = new ItemPicker();
                if (itemPicker.ShowDialog() != DialogResult.OK)
                    return;
                textBox8.Text = itemPicker.ItemIndex.ToString();
                TbEndNpcName.Text = databaseHandle.ItemNameFast(Convert.ToInt32(textBox8.Text)); //dethunter12 add 6/14/2018
                textBox8.BackColor = Color.LightBlue;
            }
        }

        private void PbEndNPCItem_Click(object sender, EventArgs e) //dethunter12 6/14/2018
        {
            
            MobPicker mobPicker = new MobPicker();
            if (mobPicker.ShowDialog() != DialogResult.OK)
                return;
            textBox10.Text = mobPicker.MobIndex.ToString();
            TbEndNpcName.Text = databaseHandle.MobNameFast(Convert.ToInt32(textBox10.Text));
            textBox10.BackColor = Color.LightBlue;
        }

        private void PbItemNeed1_Click(object sender, EventArgs e) //dethunter12 6/14/2018
        {
            ItemPicker itemPicker = new ItemPicker();
            if (itemPicker.ShowDialog() != DialogResult.OK)
                return;
            textBox16.Text = itemPicker.ItemIndex.ToString();
            TbNeedName1.Text = databaseHandle.ItemNameFast(Convert.ToInt32(textBox16.Text)); //dethunter12 add 6/14/2018
            textBox16.BackColor = Color.LightBlue;
        }

        private void PbItemNeed2_Click(object sender, EventArgs e) //dethunter12 6/14/2018
        {
            ItemPicker itemPicker = new ItemPicker();
            if (itemPicker.ShowDialog() != DialogResult.OK)
                return;
            textBox17.Text = itemPicker.ItemIndex.ToString();
            TbNeedName2.Text = databaseHandle.ItemNameFast(Convert.ToInt32(textBox17.Text)); //dethunter12 add 6/14/2018
            textBox17.BackColor = Color.LightBlue;
        }
         
        private void PbItemNeed3_Click(object sender, EventArgs e) //dethunter12 6/14/2018
        {
            ItemPicker itemPicker = new ItemPicker();
            if (itemPicker.ShowDialog() != DialogResult.OK)
                return;
            textBox18.Text = itemPicker.ItemIndex.ToString();
            TbNeedName3.Text = databaseHandle.ItemNameFast(Convert.ToInt32(textBox18.Text)); //dethunter12 add 6/14/2018
            textBox18.BackColor = Color.LightBlue;
        }

        private void PbItemNeed4_Click(object sender, EventArgs e) //dethunter12 6/14/2018
        {
            ItemPicker itemPicker = new ItemPicker();
            if (itemPicker.ShowDialog() != DialogResult.OK)
                return;
            textBox19.Text = itemPicker.ItemIndex.ToString();
            TbNeedName4.Text = databaseHandle.ItemNameFast(Convert.ToInt32(textBox19.Text)); //dethunter12 add 6/14/2018
            textBox19.BackColor = Color.LightBlue;
        }

        private void PbItemNeed5_Click(object sender, EventArgs e) //dethunter12 6/14/2018
        {
            ItemPicker itemPicker = new ItemPicker();
            if (itemPicker.ShowDialog() != DialogResult.OK)
                return;
            textBox20.Text = itemPicker.ItemIndex.ToString();
            TbNeedName5.Text = databaseHandle.ItemNameFast(Convert.ToInt32(textBox20.Text)); //dethunter12 add 6/14/2018
            textBox20.BackColor = Color.LightBlue;
        }
    }
}
