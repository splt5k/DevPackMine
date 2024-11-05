// Decompiled with JetBrains decompiler
// Type: DevPackMine.Tools.MobEditor
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
  public class MobEditor : Form
  {
    public static Connection connection = new Connection();
    private string Host = MobEditor.connection.ReadSettings("Host");
    private string User = MobEditor.connection.ReadSettings("User");
    private string Password = MobEditor.connection.ReadSettings("Password");
    private string Database = MobEditor.connection.ReadSettings("Database");
    private string language = MobEditor.connection.ReadSettings("Language");//dethunter12 language selection
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
        private Label label42;
        private Label lblLang;
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

        //dethunter12 language string end 4/11/2018
        public float _UpDown = -1f;
    private ASCIIEncoding _Enc = new ASCIIEncoding();
    public string _ClientPath = MobEditor.connection.ReadSettings("ClientPath");
    private IContainer components = (IContainer) null;
    public string name;
    public int index;
    public Direct3D _Direct3D;
    public Device _Device;
    public float _Zoom;
    public float _LeftRight;
    public float _Rotation;
    public List<tMesh> _Models;
    private MenuStrip menuStrip1;
    private GroupBox groupBox3;
    private Button button3;
    private Button button1;
    private ListBox listBox1;
    private GroupBox groupBox5;
    private Label label7;
    private TabControl tabControl1;
    private TabPage tabPage1;
    private TabPage tabPage2;
    private Button button2;
    private ToolStripMenuItem exportMobAlllodToolStripMenuItem;
    private GroupBox groupBox1;
    private Label label3;
    private Label label2;
    private Label label5;
    private TextBox textBox200;
    private TextBox textBox3;
    private TextBox textBox2;
    private TextBox textBox4;
    private TextBox textBox5;
    private Label label4;
    private TextBox textBox6;
    private Label label6;
    private TextBox textBox7;
    private Label label8;
    private Label label9;
    private TextBox textBox9;
    private TextBox textBox8;
    private Label label10;
    private TextBox textBox10;
    private Label label11;
    private TextBox textBox14;
    private Label label15;
    private TextBox textBox16;
    private Label label17;
    private GroupBox groupBox7;
    private TextBox textBox22;
    private Label label23;
    private TextBox textBox19;
    private Label label22;
    private TextBox textBox20;
    private Label label21;
    private TextBox textBox21;
    private Label label20;
    private GroupBox groupBox8;
    private TextBox textBox24;
    private Label label25;
    private TextBox textBox23;
    private Label label24;
    private GroupBox groupBox9;
    private Label label27;
    private Label label26;
    private TextBox textBox25;
    private TextBox textBox26;
    private Label label28;
    private TextBox textBox27;
    private Label label29;
    private TextBox textBox28;
    private TextBox textBox29;
    private Label label31;
    private TextBox textBox30;
    private Label label30;
    private TextBox textBox31;
    private ComboBox comboBox1;
    private TextBox textBox32;
    private Label label32;
    private Label label33;
    private GroupBox groupBox10;
    private TextBox textBox34;
    private Label label35;
    private TextBox textBox33;
    private Label label34;
    private TextBox textBox35;
    private Label label37;
    private TextBox textBox36;
    private Label label36;
    private TextBox textBox1;
    private Label label1;
    private GroupBox groupBox2;
    private Label label41;
    private Label label40;
    private Label label39;
    private Label label38;
    private TextBox textBox40;
    private TextBox textBox37;
    private TextBox textBox39;
    private TextBox textBox38;
    private TabPage tabPage4;
    private TextBox textBox60;
    private TextBox textBox59;
    private TextBox textBox58;
    private TextBox textBox57;
    private TextBox textBox56;
    private TextBox textBox55;
    private TextBox textBox54;
    private TextBox textBox53;
    private TextBox textBox52;
    private TextBox textBox51;
    private TextBox textBox50;
    private TextBox textBox49;
    private TextBox textBox48;
    private TextBox textBox47;
    private TextBox textBox46;
    private TextBox textBox45;
    private TextBox textBox44;
    private TextBox textBox43;
    private TextBox textBox42;
    private TextBox textBox41;
    private TextBox textBox61;
    private TextBox textBox78;
    private TextBox textBox77;
    private TextBox textBox76;
    private TextBox textBox75;
    private TextBox textBox74;
    private TextBox textBox73;
    private TextBox textBox72;
    private TextBox textBox71;
    private TextBox textBox70;
    private TextBox textBox69;
    private TextBox textBox68;
    private TextBox textBox67;
    private TextBox textBox66;
    private TextBox textBox65;
    private TextBox textBox64;
    private TextBox textBox63;
    private TextBox textBox62;
    private TextBox textBox80;
    private TextBox textBox79;
    private TextBox textBox81;
    private TextBox textBox82;
    private GroupBox groupBox11;
    private Label label46;
    private Label label45;
    private Label label44;
    private TextBox textBox83;
    private GroupBox groupBox12;
    private Label label51;
    private Label label50;
    private Label label49;
    private Label label48;
    private Label label47;
    private TextBox textBox88;
    private TextBox textBox84;
    private TextBox textBox87;
    private TextBox textBox85;
    private TextBox textBox86;
    private Label label52;
    private TextBox textBox89;
    private GroupBox groupBox13;
    private Label label53;
    private TextBox textBox97;
    private TextBox textBox96;
    private TextBox textBox95;
    private TextBox textBox94;
    private TextBox textBox93;
    private TextBox textBox92;
    private TextBox textBox91;
    private TextBox textBox90;
    private Label label54;
    private Label label55;
    private Label label57;
    private Label label56;
    private Label label58;
    private Label label59;
    private Label label60;
    private TextBox textBox98;
    private Label label61;
    private GroupBox groupBox16;
    private Label label73;
    private ComboBox comboBox2;
    private TextBox textBox110;
    private Label label75;
    private TextBox textBox112;
    private Label label74;
    private TextBox textBox111;
    private TextBox textBox114;
    private Label label76;
    private TextBox textBox113;
    private TextBox textBox115;
    private Label label78;
    private Label label77;
    private TabPage tabPage6;
    private TextBox textBox117;
    private TextBox textBox116;
    private Label label80;
    private Label label79;
    private TextBox textBox118;
    private Label label81;
    private Label label82;
    private TextBox textBox119;
    private TextBox textBox121;
    private Label label83;
    private TextBox textBox120;
    private Label label84;
    private Label label85;
    private TextBox textBox123;
    private TextBox textBox122;
    private Label label86;
    private Label label88;
    private TextBox textBox125;
    private TextBox textBox124;
    private Label label87;
    private Label label89;
    private TextBox textBox126;
    private Label label93;
    private TextBox textBox130;
    private Label label92;
    private TextBox textBox129;
    private Label label91;
    private TextBox textBox128;
    private Label label90;
    private TextBox textBox127;
    private TabPage tabPage7;
    private TextBox textBox141;
    private TextBox textBox140;
    private TextBox textBox139;
    private TextBox textBox138;
    private TextBox textBox137;
    private TextBox textBox136;
    private TextBox textBox135;
    private TextBox textBox134;
    private TextBox textBox133;
    private TextBox textBox132;
    private TextBox textBox131;
    private TextBox textBox150;
    private TextBox textBox149;
    private TextBox textBox148;
    private TextBox textBox147;
    private TextBox textBox146;
    private TextBox textBox145;
    private TextBox textBox144;
    private TextBox textBox143;
    private TextBox textBox142;
    private TextBox textBox170;
    private TextBox textBox169;
    private TextBox textBox168;
    private TextBox textBox167;
    private TextBox textBox166;
    private TextBox textBox165;
    private TextBox textBox164;
    private TextBox textBox163;
    private TextBox textBox162;
    private TextBox textBox161;
    private TextBox textBox160;
    private TextBox textBox159;
    private TextBox textBox158;
    private TextBox textBox157;
    private TextBox textBox156;
    private TextBox textBox155;
    private TextBox textBox154;
    private TextBox textBox153;
    private TextBox textBox152;
    private TextBox textBox151;
    private GroupBox groupBox17;
    private TextBox textBox174;
    private TextBox textBox173;
    private Label label137;
    private Label label136;
    private TextBox textBox176;
    private Label label139;
    private TextBox textBox175;
    private Label label138;
    private TextBox textBox172;
    private Label label135;
    private TextBox textBox171;
    private Label label134;
    private GroupBox groupBox6;
    private Label label16;
    private TextBox textBox15;
    private Label label14;
    private TextBox textBox13;
    private GroupBox groupBox4;
    private Label label18;
    private Label label13;
    private TextBox textBox11;
    private TextBox textBox17;
    private Label label12;
    private TextBox textBox12;
    private Label label62;
    private TextBox textBox99;
    private Label label19;
    private TextBox textBox18;
    private ToolStripMenuItem exportMobAlllodToolStripMenuItem1;
    private ToolStripMenuItem strNpcNamelodToolStripMenuItem;
    private GroupBox groupBox18;
    private DataGridView dataGridView1;
    private GroupBox groupBox19;
    private DataGridViewImageColumn Column5;
    private DataGridViewTextBoxColumn Column6;
    private DataGridViewTextBoxColumn Column7;
    private DataGridViewTextBoxColumn Column8;
    private DataGridView dataGridView2;
    private DataGridViewTextBoxColumn Column4;
    private DataGridViewTextBoxColumn Column3;
    private DataGridViewTextBoxColumn Column2;
    private DataGridViewImageColumn Column1;
    private PictureBox pictureBox23;
    private PictureBox pictureBox1;
    private GroupBox groupBox15;
    private Label label70;
    private Label label69;
    private TextBox textBox107;
    private TextBox textBox106;
    private TextBox textBox105;
    private Label label68;
    private GroupBox groupBox14;
    private Label label72;
    private TextBox textBox109;
    private Label label71;
    private TextBox textBox108;
    private TextBox textBox104;
    private TextBox textBox103;
    private TextBox textBox102;
    private TextBox textBox101;
    private TextBox textBox100;
    private Label label67;
    private Label label63;
    private Label label66;
    private Label label64;
    private Label label65;
    private GroupBox groupBox20;
    private CheckBox chk3D;
    private TrackBar slideLeftRight;
    private TrackBar slideUpDown;
    private TrackBar slideZoom;
    private Panel panel3DView;
    private BackgroundWorker backgroundWorker1;
    private Timer timer1;
        private TabPage tabPage3;
        private TabPage tabPage5;
        private TabPage tabPage8;
        private Button BtnAniAttack2;
        private Button btnAniIdle2;
        private Button btnAniRun;
        private Button btnAniDie;
        private Button BtnAniAttack1;
        private Button BtnAniDam;
        private Button BtnAniWalk;
        private Button BtnAniIdle;
        private Button BtnReadSmc;
        private ToolStripMenuItem mYSQLToolStripMenuItem;
        private ToolStripMenuItem massEditToolStripMenuItem;
        private Button button4;

    public MobEditor()
    {
            InitializeComponent();
    }

    private void LoadListBox()
    {
            //dethunter12 add 4/11/2018 language  on load listbox depending on the language selected  from config file.
            if (language == "GER")
            {
                listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArrayGER, Host, User, Password, Database, "select a_index, a_name_ger from t_npc ORDER BY a_index;");
            }
            else if (language == "POL")
            {
                listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArrayPOL, Host, User, Password, Database, "select a_index, a_name_pld from t_npc ORDER BY a_index;");
            }
            else if (language == "BRA")
            {
                listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArrayBRA, Host, User, Password, Database, "select a_index, a_name_brz from t_npc ORDER BY a_index;");
            }
            else if (language == "RUS")
            {
                listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArrayRUS, Host, User, Password, Database, "select a_index, a_name_rus from t_npc ORDER BY a_index;");
            }
            else if (language == "FRA")
            {
                listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArrayFRA, Host, User, Password, Database, "select a_index, a_name_frc from t_npc ORDER BY a_index;");
            }
            else if (language == "ESP")
            {
                listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArrayESP, Host, User, Password, Database, "select a_index, a_name_spn from t_npc ORDER BY a_index;");
            }
            else if (language == "MEX")
            {
                listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArrayMEX, Host, User, Password, Database, "select a_index, a_name_mex from t_npc ORDER BY a_index;");
            }
            else if (language == "THA")
            {
                listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArrayTHA, Host, User, Password, Database, "select a_index, a_name_thai from t_npc ORDER BY a_index;");
            }
            else if (language == "ITA")
            {
                listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArrayITA, Host, User, Password, Database, "select a_index, a_name_ita from t_npc ORDER BY a_index;");
            }
            else if (language == "USA")
            {
                listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArrayUSA, Host, User, Password, Database, "select a_index, a_name_usa from t_npc ORDER BY a_index;");
            }
            //dethunter12 add 4/11/2018 language  on load listbox depending on the language selected  from config file.
            else

            {
                listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArray, Host, User, Password, Database, "select a_index, a_name from t_npc ORDER BY a_index;");
            }
    }

        private void AniFind(object sender, EventArgs e)
        {
            
            string str1 = Path.GetDirectoryName(_ClientPath).Replace("Data", "").Replace("data", ""); //dethunter12 adjust
           
            if (File.Exists(str1 + "\\" + textBox89.Text)) //dethunter12 adjust
            {
                foreach (string readAllLine in File.ReadAllLines(str1 + "\\" + textBox89.Text)) //dethunter12 adjust
                {
                    if (readAllLine.Contains("ANIMSET"))
                    {
                        string str2 = str1 + "\\" + readAllLine.Split('"')[1];
                        if (File.Exists(str2))
                        {
                            Animation_Picker animation_Picker = (Animation_Picker)null;
                            switch ((sender as Button).Name)
                            {
                                case "BtnAniAttack1":
                                    animation_Picker = new Animation_Picker(str2, "Attack");
                                    break;
                                case "BtnAniAttack2":
                                    animation_Picker = new Animation_Picker(str2, "Attack2");
                                    break;
                                case "BtnAniDam":
                                    animation_Picker = new Animation_Picker(str2, "Damage");
                                    break;
                                case "btnAniDie":
                                    animation_Picker = new Animation_Picker(str2, "Die");
                                    break;
                                case "BtnAniIdle":
                                    animation_Picker = new Animation_Picker(str2, "Idle");
                                    break;
                                case "btnAniIdle2":
                                    animation_Picker = new Animation_Picker(str2, "Idle2");
                                    break;
                                case "btnAniRun":
                                    animation_Picker = new Animation_Picker(str2, "Run");
                                    break;
                                case "BtnAniWalk":
                                    animation_Picker = new Animation_Picker(str2, "Walk");
                                    break;
                                default:
                                    int num = (int)MessageBox.Show("Not found : " + (sender as Button).Name);
                                    break;
                            }
                            if (animation_Picker.ShowDialog() == DialogResult.OK)
                            {
                                switch ((sender as Button).Name)
                                {
                                    case "BtnAniAttack1":
                                        this.textBox93.Text = animation_Picker.Animation;
                                        continue;
                                    case "BtnAniAttack2":
                                        this.textBox97.Text = animation_Picker.Animation;
                                        continue;
                                    case "BtnAniDam":
                                        this.textBox92.Text = animation_Picker.Animation;
                                        continue;
                                    case "btnAniDie":
                                        this.textBox94.Text = animation_Picker.Animation;
                                        continue;
                                    case "BtnAniIdle":
                                        this.textBox91.Text = animation_Picker.Animation;
                                        continue;
                                    case "btnAniIdle2":
                                        this.textBox96.Text = animation_Picker.Animation;
                                        continue;
                                    case "btnAniRun":
                                        this.textBox95.Text = animation_Picker.Animation;
                                        continue;
                                    case "BtnAniWalk":
                                        this.textBox90.Text = animation_Picker.Animation;
                                        continue;
                                    default:
                                        continue;
                                }
                            }
                        }
                        else
                        {
                            int num4 = (int)new CustomMessage("Not Found :" +str2).ShowDialog(); //dethunter12 add
                            
                        }
                    }
                }
            }
            else
                new CustomMessage("SMC File not found").Show();
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
                listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArrayGER, Host, User, Password, Database, "select a_index, a_name_ger from t_npc WHERE a_name_ger LIKE '%" + searchString + "%'" + " OR a_index LIKE '%" + searchString + "%'" + " OR a_name_ger LIKE '%" + lower + "%' OR a_index  LIKE '%" + lower + "%'" + " OR a_name_ger LIKE '%" + upper + "%' OR a_index LIKE '%" + upper + "%'" + " OR a_name_ger LIKE '%" + str + "%' OR a_index LIKE '%" + str + "%'" + " ORDER BY a_index;");

            }
            else if (language == "POL")
            {
                listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArrayPOL, Host, User, Password, Database, "select a_index, a_name_pld from t_npc WHERE a_name_pld LIKE '%" + searchString + "%'" + " OR a_index LIKE '%" + searchString + "%'" + " OR a_name_pld LIKE '%" + lower + "%' OR a_index  LIKE '%" + lower + "%'" + " OR a_name_pld LIKE '%" + upper + "%' OR a_index LIKE '%" + upper + "%'" + " OR a_name_pld LIKE '%" + str + "%' OR a_index LIKE '%" + str + "%'" + " ORDER BY a_index;");

            }
            else if (language == "BRA")
            {
                listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArrayBRA, Host, User, Password, Database, "select a_index, a_name_brz from t_npc WHERE a_name_brz LIKE '%" + searchString + "%'" + " OR a_index LIKE '%" + searchString + "%'" + " OR a_name_brz LIKE '%" + lower + "%' OR a_index  LIKE '%" + lower + "%'" + " OR a_name_brz LIKE '%" + upper + "%' OR a_index LIKE '%" + upper + "%'" + " OR a_name_brz LIKE '%" + str + "%' OR a_index LIKE '%" + str + "%'" + " ORDER BY a_index;");

            }
            else if (language == "RUS")
            {
                listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArrayRUS, Host, User, Password, Database, "select a_index, a_name_rus from t_npc WHERE a_name_rus LIKE '%" + searchString + "%'" + " OR a_index LIKE '%" + searchString + "%'" + " OR a_name_rus LIKE '%" + lower + "%' OR a_index  LIKE '%" + lower + "%'" + " OR a_name_rus LIKE '%" + upper + "%' OR a_index LIKE '%" + upper + "%'" + " OR a_name_rus LIKE '%" + str + "%' OR a_index LIKE '%" + str + "%'" + " ORDER BY a_index;");

            }
            else if (language == "FRA")
            {
                listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArrayFRA, Host, User, Password, Database, "select a_index, a_name_frc from t_npc WHERE a_name_frc LIKE '%" + searchString + "%'" + " OR a_index LIKE '%" + searchString + "%'" + " OR a_name_frc LIKE '%" + lower + "%' OR a_index  LIKE '%" + lower + "%'" + " OR a_name_frc LIKE '%" + upper + "%' OR a_index LIKE '%" + upper + "%'" + " OR a_name_frc LIKE '%" + str + "%' OR a_index LIKE '%" + str + "%'" + " ORDER BY a_index;");

            }
            else if (language == "ESP")
            {
                listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArrayESP, Host, User, Password, Database, "select a_index, a_name_spn from t_npc WHERE a_name_spn LIKE '%" + searchString + "%'" + " OR a_index LIKE '%" + searchString + "%'" + " OR a_name_spn LIKE '%" + lower + "%' OR a_index  LIKE '%" + lower + "%'" + " OR a_name_spn LIKE '%" + upper + "%' OR a_index LIKE '%" + upper + "%'" + " OR a_name_spn LIKE '%" + str + "%' OR a_index LIKE '%" + str + "%'" + " ORDER BY a_index;");

            }
            else if (language == "MEX")
            {
                listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArrayMEX, Host, User, Password, Database, "select a_index, a_name_mex from t_npc WHERE a_name_mex LIKE '%" + searchString + "%'" + " OR a_index LIKE '%" + searchString + "%'" + " OR a_name_mex LIKE '%" + lower + "%' OR a_index  LIKE '%" + lower + "%'" + " OR a_name_mex LIKE '%" + upper + "%' OR a_index LIKE '%" + upper + "%'" + " OR a_name_mex LIKE '%" + str + "%' OR a_index LIKE '%" + str + "%'" + " ORDER BY a_index;");

            }
            else if (language == "THA")
            {
                listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArrayTHA, Host, User, Password, Database, "select a_index, a_name_thai from t_npc WHERE a_name_thai LIKE '%" + searchString + "%'" + " OR a_index LIKE '%" + searchString + "%'" + " OR a_name_thai LIKE '%" + lower + "%' OR a_index  LIKE '%" + lower + "%'" + " OR a_name_thai LIKE '%" + upper + "%' OR a_index LIKE '%" + upper + "%'" + " OR a_name_thai LIKE '%" + str + "%' OR a_index LIKE '%" + str + "%'" + " ORDER BY a_index;");

            }
            else if (language == "ITA")
            {
                listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArrayITA, Host, User, Password, Database, "select a_index, a_name_ita from t_npc WHERE a_name_ita LIKE '%" + searchString + "%'" + " OR a_index LIKE '%" + searchString + "%'" + " OR a_name_ita LIKE '%" + lower + "%' OR a_index  LIKE '%" + lower + "%'" + " OR a_name_ita LIKE '%" + upper + "%' OR a_index LIKE '%" + upper + "%'" + " OR a_name_ita LIKE '%" + str + "%' OR a_index LIKE '%" + str + "%'" + " ORDER BY a_index;");

            }
            else if (language == "USA")
            {
                listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArrayUSA, Host, User, Password, Database, "select a_index, a_name_usa from t_npc WHERE a_name_usa LIKE '%" + searchString + "%'" + " OR a_index LIKE '%" + searchString + "%'" + " OR a_name_usa LIKE '%" + lower + "%' OR a_index  LIKE '%" + lower + "%'" + " OR a_name_usa LIKE '%" + upper + "%' OR a_index LIKE '%" + upper + "%'" + " OR a_name_usa LIKE '%" + str + "%' OR a_index LIKE '%" + str + "%'" + " ORDER BY a_index;");

            }
            else // if none of these do default search a_name
            {
                listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArray, Host, User, Password, Database, "select a_index, a_name from t_npc WHERE a_name LIKE '%" + searchString + "%'" + " OR a_index LIKE '%" + searchString + "%'" + " OR a_name LIKE '%" + lower + "%' OR a_index  LIKE '%" + lower + "%'" + " OR a_name LIKE '%" + upper + "%' OR a_index LIKE '%" + upper + "%'" + " OR a_name LIKE '%" + str + "%' OR a_index LIKE '%" + str + "%'" + " ORDER BY a_index;");

            }
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

    public int GetItemIndex()
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
                textBox1.Text = GetIndex().ToString();
      string Query = " select a_index , a_enable , a_name , a_descr , a_level , a_family , a_skillmaster , a_flag , a_flag1 , a_state_flag , a_exp , a_prize , a_sight , a_size , a_move_area , a_attack_area , a_skill_point , a_sskill_master , a_str , a_dex , a_int , a_con , a_attack , a_magic , a_defense , a_resist , a_attacklevel , a_defenselevel , a_hp , a_mp , a_attackType , a_attackSpeed , a_recover_hp , a_recover_mp , a_walk_speed , a_run_speed , a_skill0 , a_skill1 , a_skill2 , a_skill3 , a_item_0 , a_item_1 , a_item_2 , a_item_3 , a_item_4 , a_item_5 , a_item_6 , a_item_7 , a_item_8 , a_item_9 , a_item_10 , a_item_11 , a_item_12 , a_item_13 , a_item_14 , a_item_15 , a_item_16 , a_item_17 , a_item_18 , a_item_19 , a_item_percent_0 , a_item_percent_1 , a_item_percent_2 , a_item_percent_3 , a_item_percent_4 , a_item_percent_5 , a_item_percent_6 , a_item_percent_7 , a_item_percent_8 , a_item_percent_9 , a_item_percent_10 , a_item_percent_11 , a_item_percent_12 , a_item_percent_13 , a_item_percent_14 , a_item_percent_15 , a_item_percent_16 , a_item_percent_17 , a_item_percent_18 , a_item_percent_19 , a_minplus , a_maxplus , a_probplus , a_product0 , a_product1 , a_product2 , a_product3 , a_product4 , a_file_smc , a_motion_walk , a_motion_idle , a_motion_dam , a_motion_attack , a_motion_die , a_motion_run , a_motion_idle2 , a_motion_attack2 , a_scale , a_attribute , a_fireDelayCount , a_fireDelay0 , a_fireDelay1 , a_fireDelay2 , a_fireDelay3 , a_fireEffect0 , a_fireEffect1 , a_fireEffect2 , a_fireObject , a_fireSpeed , a_aitype , a_aiflag , a_aileader_flag , a_ai_summonHp , a_aileader_idx , a_aileader_count , a_crafting_category , a_productIndex , a_hit , a_dodge, a_magicavoid , a_job_attribute , a_npc_choice_trigger_count , a_npc_choice_trigger_ids , a_npc_kill_trigger_count , a_npc_kill_trigger_ids , a_createprob , a_socketprob_0 , a_socketprob_1 , a_socketprob_2 , a_socketprob_3 , a_jewel_0 , a_jewel_1 , a_jewel_2 , a_jewel_3 , a_jewel_4 , a_jewel_5 , a_jewel_6 , a_jewel_7 , a_jewel_8 , a_jewel_9 , a_jewel_10 , a_jewel_11 , a_jewel_12 , a_jewel_13 , a_jewel_14 , a_jewel_15 , a_jewel_16 , a_jewel_17 , a_jewel_18 , a_jewel_19 , a_jewel_percent_0 , a_jewel_percent_1 , a_jewel_percent_2 , a_jewel_percent_3 , a_jewel_percent_4 , a_jewel_percent_5 , a_jewel_percent_6 , a_jewel_percent_7 , a_jewel_percent_8 , a_jewel_percent_9 , a_jewel_percent_10 , a_jewel_percent_11 , a_jewel_percent_12 , a_jewel_percent_13 , a_jewel_percent_14 , a_jewel_percent_15 , a_jewel_percent_16 , a_jewel_percent_17 , a_jewel_percent_18 , a_jewel_percent_19 , a_zone_flag , a_extra_flag , a_rvr_value , a_rvr_grade , a_bound , a_lifetime, a_name_frc, a_name_ita, a_name_usa, a_name_rus,  a_name_thai, a_name_pld, a_name_spn, a_name_brz, a_name_ger, a_descr_frc, a_descr_ita, a_descr_usa, a_descr_rus, a_descr_thai, a_descr_pld, a_descr_spn, a_descr_brz, a_descr_ger, a_name_mex, a_descr_mex  from t_npc WHERE a_index ='" + textBox1.Text + "';";
       //dethunter12 modify query language test seperate
      
            string[] rows = new string[196]//dethunter12 modify test 
      {
        "a_index",
        "a_enable",
        "a_name",
        "a_descr",
        "a_level",
        "a_family",
        "a_skillmaster",
        "a_flag",
        "a_flag1",
        "a_state_flag",
        "a_exp",
        "a_prize",
        "a_sight",
        "a_size",
        "a_move_area",
        "a_attack_area",
        "a_skill_point",
        "a_sskill_master",
        "a_str",
        "a_dex",
        "a_int",
        "a_con",
        "a_attack",
        "a_magic",
        "a_defense",
        "a_resist",
        "a_attacklevel",
        "a_defenselevel",
        "a_hp",
        "a_mp",
        "a_attackType",
        "a_attackSpeed",
        "a_recover_hp",
        "a_recover_mp",
        "a_walk_speed",
        "a_run_speed",
        "a_skill0",
        "a_skill1",
        "a_skill2",
        "a_skill3",
        "a_item_0",
        "a_item_1",
        "a_item_2",
        "a_item_3",
        "a_item_4",
        "a_item_5",
        "a_item_6",
        "a_item_7",
        "a_item_8",
        "a_item_9",
        "a_item_10",
        "a_item_11",
        "a_item_12",
        "a_item_13",
        "a_item_14",
        "a_item_15",
        "a_item_16",
        "a_item_17",
        "a_item_18",
        "a_item_19",
        "a_item_percent_0",
        "a_item_percent_1",
        "a_item_percent_2",
        "a_item_percent_3",
        "a_item_percent_4",
        "a_item_percent_5",
        "a_item_percent_6",
        "a_item_percent_7",
        "a_item_percent_8",
        "a_item_percent_9",
        "a_item_percent_10",
        "a_item_percent_11",
        "a_item_percent_12",
        "a_item_percent_13",
        "a_item_percent_14",
        "a_item_percent_15",
        "a_item_percent_16",
        "a_item_percent_17",
        "a_item_percent_18",
        "a_item_percent_19",
        "a_minplus",
        "a_maxplus",
        "a_probplus",
        "a_product0",
        "a_product1",
        "a_product2",
        "a_product3",
        "a_product4",
        "a_file_smc",
        "a_motion_walk",
        "a_motion_idle",
        "a_motion_dam",
        "a_motion_attack",
        "a_motion_die",
        "a_motion_run",
        "a_motion_idle2",
        "a_motion_attack2",
        "a_scale",
        "a_attribute",
        "a_fireDelayCount",
        "a_fireDelay0",
        "a_fireDelay1",
        "a_fireDelay2",
        "a_fireDelay3",
        "a_fireEffect0",
        "a_fireEffect1",
        "a_fireEffect2",
        "a_fireObject",
        "a_fireSpeed",
        "a_aitype",
        "a_aiflag",
        "a_aileader_flag",
        "a_ai_summonHp",
        "a_aileader_idx",
        "a_aileader_count",
        "a_crafting_category",
        "a_productIndex",
        "a_hit",
        "a_dodge",
        "a_magicavoid",
        "a_job_attribute",
        "a_npc_choice_trigger_count",
        "a_npc_choice_trigger_ids",
        "a_npc_kill_trigger_count",
        "a_npc_kill_trigger_ids",
        "a_createprob",
        "a_socketprob_0",
        "a_socketprob_1",
        "a_socketprob_2",
        "a_socketprob_3",
        "a_jewel_0",
        "a_jewel_1",
        "a_jewel_2",
        "a_jewel_3",
        "a_jewel_4",
        "a_jewel_5",
        "a_jewel_6",
        "a_jewel_7",
        "a_jewel_8",
        "a_jewel_9",
        "a_jewel_10",
        "a_jewel_11",
        "a_jewel_12",
        "a_jewel_13",
        "a_jewel_14",
        "a_jewel_15",
        "a_jewel_16",
        "a_jewel_17",
        "a_jewel_18",
        "a_jewel_19",
        "a_jewel_percent_0",
        "a_jewel_percent_1",
        "a_jewel_percent_2",
        "a_jewel_percent_3",
        "a_jewel_percent_4",
        "a_jewel_percent_5",
        "a_jewel_percent_6",
        "a_jewel_percent_7",
        "a_jewel_percent_8",
        "a_jewel_percent_9",
        "a_jewel_percent_10",
        "a_jewel_percent_11",
        "a_jewel_percent_12",
        "a_jewel_percent_13",
        "a_jewel_percent_14",
        "a_jewel_percent_15",
        "a_jewel_percent_16",
        "a_jewel_percent_17",
        "a_jewel_percent_18",
        "a_jewel_percent_19",
        "a_zone_flag",
        "a_extra_flag",
        "a_rvr_value",
        "a_rvr_grade",
        "a_bound",
        "a_lifetime",
        //select language name-desc
        "a_name_frc",//176
        "a_name_ita",//177
        "a_name_usa",//178
        "a_name_rus",//179
        "a_name_thai",//180
        "a_name_pld",//181
        "a_name_spn",//182
        "a_name_brz",//183
        "a_name_ger",//184
        //desc 9-17 total count = 9
        "a_descr_frc",//185
        "a_descr_ita",//186
        "a_descr_usa",//187
        "a_descr_rus",//188
        "a_descr_thai",//189
        "a_descr_pld",//190
        "a_descr_spn",//191
        "a_descr_brz",//192
        "a_descr_ger",//193
        "a_name_mex", //194
        "a_descr_mex" //195
      };
            //select language name-desc
      
            //select language
            Query.Replace("'", "\\'").Replace("\\", "\\\\").Replace("'", "\\'");
      string[] strArray = databaseHandle.SelectMySqlReturnArray(Host, User, Password, Database, Query, rows);
  
            if (chk3D.Checked && File.Exists(_ClientPath + strArray[88]))
      {
        Console.WriteLine("Create Model > " + _ClientPath + strArray[88]);
                MakeLCModels(_ClientPath + strArray[88]);
      }
            textBox1.Text = strArray[0];
            textBox2.Text = strArray[1];
            //dethunter12 language pull from Array 
            // to change the name /description depending on the language selected 
            if (language == "FRA")
            {
                textBox3.Text = strArray[176]; //name
                textBox4.Text = strArray[185]; //descr 
            }
            else if (language == "USA")
            {
                textBox3.Text = strArray[178];
                textBox4.Text = strArray[187];
            }
            else if (language == "ITA")
            {
                textBox3.Text = strArray[177];
                textBox4.Text = strArray[186];
            }
            else if (language == "RUS")
            {
                textBox3.Text = strArray[179];
                textBox4.Text = strArray[188];
            }
            else if (language == "THA")
            {
                textBox3.Text = strArray[180];
                textBox4.Text = strArray[189];
            }
            else if (language == "POL")
            {
                textBox3.Text = strArray[181];
                textBox4.Text = strArray[190];
            }
            else if (language == "ESP")
            {
                textBox3.Text = strArray[182];
                textBox4.Text = strArray[191];
            }
            else if (language == "BRA")
            {
                textBox3.Text = strArray[183];
                textBox4.Text = strArray[192];
            }
            else if (language == "GER")
            {
                textBox3.Text = strArray[184];
                textBox4.Text = strArray[193];
            }
            else if (language == "MEX")
            {
                textBox3.Text = strArray[194];
                textBox4.Text = strArray[195];
            }
            else if (language != "GER" && language != "POL" && language != "BRA" && language != "RUS" && language != "FRA" && language != "ESP" && language != "MEX" && language != "THA" && language != "ITA" && language != "USA") //if language isnt any of the supported language lists then use default a_name 
            {
                textBox3.Text = strArray[2];//name
                 textBox4.Text = strArray[3];//desc
            }

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
            textBox94.Text = strArray[93];
            textBox95.Text = strArray[94];
            textBox96.Text = strArray[95];
            textBox97.Text = strArray[96];
            textBox98.Text = strArray[97];
            textBox99.Text = strArray[98];
            textBox100.Text = strArray[99];
            textBox101.Text = strArray[100];
            textBox102.Text = strArray[101];
            textBox103.Text = strArray[102];
            textBox104.Text = strArray[103];
            textBox105.Text = strArray[104];
            textBox106.Text = strArray[105];
            textBox107.Text = strArray[106];
            textBox108.Text = strArray[107];
            textBox109.Text = strArray[108];
            textBox110.Text = strArray[109];
            textBox111.Text = strArray[110];
            textBox112.Text = strArray[111];
            textBox113.Text = strArray[112];
            textBox114.Text = strArray[113];
            textBox115.Text = strArray[114];
            textBox116.Text = strArray[115];
            textBox117.Text = strArray[116];
            textBox118.Text = strArray[117];
            textBox119.Text = strArray[118];
            textBox120.Text = strArray[119];
            textBox121.Text = strArray[120];
            textBox122.Text = strArray[121];
            textBox123.Text = strArray[122];
            textBox124.Text = strArray[123];
            textBox125.Text = strArray[124];
            textBox126.Text = strArray[125];
            textBox127.Text = strArray[126];
            textBox128.Text = strArray[(int) sbyte.MaxValue];
            textBox129.Text = strArray[128];
            textBox130.Text = strArray[129];
            textBox131.Text = strArray[130];
            textBox132.Text = strArray[131];
            textBox133.Text = strArray[132];
            textBox134.Text = strArray[133];
            textBox135.Text = strArray[134];
            textBox136.Text = strArray[135];
            textBox137.Text = strArray[136];
            textBox138.Text = strArray[137];
            textBox139.Text = strArray[138];
            textBox140.Text = strArray[139];
            textBox141.Text = strArray[140];
            textBox142.Text = strArray[141];
            textBox143.Text = strArray[142];
            textBox144.Text = strArray[143];
            textBox145.Text = strArray[144];
            textBox146.Text = strArray[145];
            textBox147.Text = strArray[146];
            textBox148.Text = strArray[147];
            textBox149.Text = strArray[148];
            textBox150.Text = strArray[149];
            textBox151.Text = strArray[150];
            textBox152.Text = strArray[151];
            textBox153.Text = strArray[152];
            textBox154.Text = strArray[153];
            textBox155.Text = strArray[154];
            textBox156.Text = strArray[155];
            textBox157.Text = strArray[156];
            textBox158.Text = strArray[157];
            textBox159.Text = strArray[158];
            textBox160.Text = strArray[159];
            textBox161.Text = strArray[160];
            textBox162.Text = strArray[161];
            textBox163.Text = strArray[162];
            textBox164.Text = strArray[163];
            textBox165.Text = strArray[164];
            textBox166.Text = strArray[165];
            textBox167.Text = strArray[166];
            textBox168.Text = strArray[167];
            textBox169.Text = strArray[168];
            textBox170.Text = strArray[169];
            textBox171.Text = strArray[170];
            textBox172.Text = strArray[171];
            textBox173.Text = strArray[172];
            textBox174.Text = strArray[173];
            textBox175.Text = strArray[174];
            textBox176.Text = strArray[175];
            SelectBoxes();
            LoadDG();
            LoadDG2();
    }

    public void LoadDG()
    {
            dataGridView1.Rows.Clear();
      string str1 = "SELECT * FROM t_npc WHERE a_index ='" + textBox1.Text + "'";
      string[] strArray = new string[2]
      {
        "a_index",
        "a_name"
      };
      MySqlConnection mySqlConnection = new MySqlConnection("datasource=" + Host + ";port=3306;username=" + User + ";password=" + Password + ";database=" + Database);
      MySqlCommand command = mySqlConnection.CreateCommand();
      command.CommandText = str1;
      mySqlConnection.Open();
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (mySqlDataReader.Read())
      {
        int ordinal1 = mySqlDataReader.GetOrdinal("a_item_0");
        int ordinal2 = mySqlDataReader.GetOrdinal("a_item_percent_0");
        int ordinal3 = mySqlDataReader.GetOrdinal("a_item_1");
        int ordinal4 = mySqlDataReader.GetOrdinal("a_item_percent_1");
        int ordinal5 = mySqlDataReader.GetOrdinal("a_item_2");
        int ordinal6 = mySqlDataReader.GetOrdinal("a_item_percent_2");
        int ordinal7 = mySqlDataReader.GetOrdinal("a_item_3");
        int ordinal8 = mySqlDataReader.GetOrdinal("a_item_percent_3");
        int ordinal9 = mySqlDataReader.GetOrdinal("a_item_4");
        int ordinal10 = mySqlDataReader.GetOrdinal("a_item_percent_4");
        int ordinal11 = mySqlDataReader.GetOrdinal("a_item_5");
        int ordinal12 = mySqlDataReader.GetOrdinal("a_item_percent_5");
        int ordinal13 = mySqlDataReader.GetOrdinal("a_item_6");
        int ordinal14 = mySqlDataReader.GetOrdinal("a_item_percent_6");
        int ordinal15 = mySqlDataReader.GetOrdinal("a_item_7");
        int ordinal16 = mySqlDataReader.GetOrdinal("a_item_percent_7");
        int ordinal17 = mySqlDataReader.GetOrdinal("a_item_8");
        int ordinal18 = mySqlDataReader.GetOrdinal("a_item_percent_8");
        int ordinal19 = mySqlDataReader.GetOrdinal("a_item_9");
        int ordinal20 = mySqlDataReader.GetOrdinal("a_item_percent_9");
        int ordinal21 = mySqlDataReader.GetOrdinal("a_item_10");
        int ordinal22 = mySqlDataReader.GetOrdinal("a_item_percent_10");
        int ordinal23 = mySqlDataReader.GetOrdinal("a_item_11");
        int ordinal24 = mySqlDataReader.GetOrdinal("a_item_percent_11");
        int ordinal25 = mySqlDataReader.GetOrdinal("a_item_12");
        int ordinal26 = mySqlDataReader.GetOrdinal("a_item_percent_12");
        int ordinal27 = mySqlDataReader.GetOrdinal("a_item_13");
        int ordinal28 = mySqlDataReader.GetOrdinal("a_item_percent_13");
        int ordinal29 = mySqlDataReader.GetOrdinal("a_item_14");
        int ordinal30 = mySqlDataReader.GetOrdinal("a_item_percent_14");
        int ordinal31 = mySqlDataReader.GetOrdinal("a_item_15");
        int ordinal32 = mySqlDataReader.GetOrdinal("a_item_percent_15");
        int ordinal33 = mySqlDataReader.GetOrdinal("a_item_16");
        int ordinal34 = mySqlDataReader.GetOrdinal("a_item_percent_16");
        int ordinal35 = mySqlDataReader.GetOrdinal("a_item_17");
        int ordinal36 = mySqlDataReader.GetOrdinal("a_item_percent_17");
        int ordinal37 = mySqlDataReader.GetOrdinal("a_item_18");
        int ordinal38 = mySqlDataReader.GetOrdinal("a_item_percent_18");
        int ordinal39 = mySqlDataReader.GetOrdinal("a_item_19");
        int ordinal40 = mySqlDataReader.GetOrdinal("a_item_percent_19");
        string str2 = mySqlDataReader.GetString(ordinal1);
        string str3 = mySqlDataReader.GetString(ordinal2);
        string str4 = mySqlDataReader.GetString(ordinal3);
        string str5 = mySqlDataReader.GetString(ordinal4);
        string str6 = mySqlDataReader.GetString(ordinal5);
        string str7 = mySqlDataReader.GetString(ordinal6);
        string str8 = mySqlDataReader.GetString(ordinal7);
        string str9 = mySqlDataReader.GetString(ordinal8);
        string str10 = mySqlDataReader.GetString(ordinal9);
        string str11 = mySqlDataReader.GetString(ordinal10);
        string str12 = mySqlDataReader.GetString(ordinal11);
        string str13 = mySqlDataReader.GetString(ordinal12);
        string str14 = mySqlDataReader.GetString(ordinal13);
        string str15 = mySqlDataReader.GetString(ordinal14);
        string str16 = mySqlDataReader.GetString(ordinal15);
        string str17 = mySqlDataReader.GetString(ordinal16);
        string str18 = mySqlDataReader.GetString(ordinal17);
        string str19 = mySqlDataReader.GetString(ordinal18);
        string str20 = mySqlDataReader.GetString(ordinal19);
        string str21 = mySqlDataReader.GetString(ordinal20);
        string str22 = mySqlDataReader.GetString(ordinal21);
        string str23 = mySqlDataReader.GetString(ordinal22);
        string str24 = mySqlDataReader.GetString(ordinal23);
        string str25 = mySqlDataReader.GetString(ordinal24);
        string str26 = mySqlDataReader.GetString(ordinal25);
        string str27 = mySqlDataReader.GetString(ordinal26);
        string str28 = mySqlDataReader.GetString(ordinal27);
        string str29 = mySqlDataReader.GetString(ordinal28);
        string str30 = mySqlDataReader.GetString(ordinal29);
        string str31 = mySqlDataReader.GetString(ordinal30);
        string str32 = mySqlDataReader.GetString(ordinal31);
        string str33 = mySqlDataReader.GetString(ordinal32);
        string str34 = mySqlDataReader.GetString(ordinal33);
        string str35 = mySqlDataReader.GetString(ordinal34);
        string str36 = mySqlDataReader.GetString(ordinal35);
        string str37 = mySqlDataReader.GetString(ordinal36);
        string str38 = mySqlDataReader.GetString(ordinal37);
        string str39 = mySqlDataReader.GetString(ordinal38);
        string str40 = mySqlDataReader.GetString(ordinal39);
        string str41 = mySqlDataReader.GetString(ordinal40);
        Bitmap bitmap1 = databaseHandle.IconFast(Convert.ToInt32(str2));
        string str42 = databaseHandle.ItemNameFast(Convert.ToInt32(str2));
        Bitmap bitmap2 = databaseHandle.IconFast(Convert.ToInt32(str4));
        string str43 = databaseHandle.ItemNameFast(Convert.ToInt32(str4));
        Bitmap bitmap3 = databaseHandle.IconFast(Convert.ToInt32(str6));
        string str44 = databaseHandle.ItemNameFast(Convert.ToInt32(str6));
        Bitmap bitmap4 = databaseHandle.IconFast(Convert.ToInt32(str8));
        string str45 = databaseHandle.ItemNameFast(Convert.ToInt32(str8));
        Bitmap bitmap5 = databaseHandle.IconFast(Convert.ToInt32(str10));
        string str46 = databaseHandle.ItemNameFast(Convert.ToInt32(str10));
        Bitmap bitmap6 = databaseHandle.IconFast(Convert.ToInt32(str12));
        string str47 = databaseHandle.ItemNameFast(Convert.ToInt32(str12));
        Bitmap bitmap7 = databaseHandle.IconFast(Convert.ToInt32(str14));
        string str48 = databaseHandle.ItemNameFast(Convert.ToInt32(str14));
        Bitmap bitmap8 = databaseHandle.IconFast(Convert.ToInt32(str16));
        string str49 = databaseHandle.ItemNameFast(Convert.ToInt32(str16));
        Bitmap bitmap9 = databaseHandle.IconFast(Convert.ToInt32(str18));
        string str50 = databaseHandle.ItemNameFast(Convert.ToInt32(str18));
        Bitmap bitmap10 = databaseHandle.IconFast(Convert.ToInt32(str20));
        string str51 = databaseHandle.ItemNameFast(Convert.ToInt32(str20));
        Bitmap bitmap11 = databaseHandle.IconFast(Convert.ToInt32(str22));
        string str52 = databaseHandle.ItemNameFast(Convert.ToInt32(str22));
        Bitmap bitmap12 = databaseHandle.IconFast(Convert.ToInt32(str24));
        string str53 = databaseHandle.ItemNameFast(Convert.ToInt32(str24));
        Bitmap bitmap13 = databaseHandle.IconFast(Convert.ToInt32(str26));
        string str54 = databaseHandle.ItemNameFast(Convert.ToInt32(str26));
        Bitmap bitmap14 = databaseHandle.IconFast(Convert.ToInt32(str28));
        string str55 = databaseHandle.ItemNameFast(Convert.ToInt32(str28));
        Bitmap bitmap15 = databaseHandle.IconFast(Convert.ToInt32(str30));
        string str56 = databaseHandle.ItemNameFast(Convert.ToInt32(str30));
        Bitmap bitmap16 = databaseHandle.IconFast(Convert.ToInt32(str32));
        string str57 = databaseHandle.ItemNameFast(Convert.ToInt32(str32));
        Bitmap bitmap17 = databaseHandle.IconFast(Convert.ToInt32(str34));
        string str58 = databaseHandle.ItemNameFast(Convert.ToInt32(str34));
        Bitmap bitmap18 = databaseHandle.IconFast(Convert.ToInt32(str36));
        string str59 = databaseHandle.ItemNameFast(Convert.ToInt32(str36));
        Bitmap bitmap19 = databaseHandle.IconFast(Convert.ToInt32(str38));
        string str60 = databaseHandle.ItemNameFast(Convert.ToInt32(str38));
        Bitmap bitmap20 = databaseHandle.IconFast(Convert.ToInt32(str40));
        string str61 = databaseHandle.ItemNameFast(Convert.ToInt32(str40));
                dataGridView1.Rows.Add( bitmap1,  str2,  str42,  str3);
                dataGridView1.Rows.Add( bitmap2,  str4,  str43,  str5);
                dataGridView1.Rows.Add( bitmap3,  str6,  str44,  str7);
                dataGridView1.Rows.Add( bitmap4,  str8,  str45,  str9);
                dataGridView1.Rows.Add( bitmap5,  str10,  str46,  str11);
                dataGridView1.Rows.Add( bitmap6,  str12,  str47,  str13);
                dataGridView1.Rows.Add( bitmap7,  str14,  str48,  str15);
                dataGridView1.Rows.Add( bitmap8,  str16,  str49,  str17);
                dataGridView1.Rows.Add( bitmap9,  str18,  str50,  str19);
                dataGridView1.Rows.Add( bitmap10,  str20,  str51,  str21);
                dataGridView1.Rows.Add( bitmap11,  str22,  str52,  str23);
                dataGridView1.Rows.Add( bitmap12,  str24,  str53,  str25);
                dataGridView1.Rows.Add( bitmap13,  str26,  str54,  str27);
                dataGridView1.Rows.Add( bitmap14,  str28,  str55,  str29);
                dataGridView1.Rows.Add( bitmap15,  str30,  str56,  str31);
                dataGridView1.Rows.Add( bitmap16,  str32,  str57,  str33);
                dataGridView1.Rows.Add( bitmap17,  str34,  str58,  str35);
                dataGridView1.Rows.Add( bitmap18,  str36,  str59,  str37);
                dataGridView1.Rows.Add( bitmap19,  str38,  str60,  str39);
                dataGridView1.Rows.Add( bitmap20,  str40,  str61,  str41);
      }
      mySqlConnection.Close();
    }

    public void LoadDG2()
    {
            dataGridView2.Rows.Clear();
      string str1 = "SELECT * FROM t_npc WHERE a_index ='" + textBox1.Text + "'";
      string[] strArray = new string[2]
      {
        "a_index",
        "a_name"
      };
      MySqlConnection mySqlConnection = new MySqlConnection("datasource=" + Host + ";port=3306;username=" + User + ";password=" + Password + ";database=" + Database);
      MySqlCommand command = mySqlConnection.CreateCommand();
      command.CommandText = str1;
      mySqlConnection.Open();
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (mySqlDataReader.Read())
      {
        int ordinal1 = mySqlDataReader.GetOrdinal("a_jewel_0");
        int ordinal2 = mySqlDataReader.GetOrdinal("a_jewel_percent_0");
        int ordinal3 = mySqlDataReader.GetOrdinal("a_jewel_1");
        int ordinal4 = mySqlDataReader.GetOrdinal("a_jewel_percent_1");
        int ordinal5 = mySqlDataReader.GetOrdinal("a_jewel_2");
        int ordinal6 = mySqlDataReader.GetOrdinal("a_jewel_percent_2");
        int ordinal7 = mySqlDataReader.GetOrdinal("a_jewel_3");
        int ordinal8 = mySqlDataReader.GetOrdinal("a_jewel_percent_3");
        int ordinal9 = mySqlDataReader.GetOrdinal("a_jewel_4");
        int ordinal10 = mySqlDataReader.GetOrdinal("a_jewel_percent_4");
        int ordinal11 = mySqlDataReader.GetOrdinal("a_jewel_5");
        int ordinal12 = mySqlDataReader.GetOrdinal("a_jewel_percent_5");
        int ordinal13 = mySqlDataReader.GetOrdinal("a_jewel_6");
        int ordinal14 = mySqlDataReader.GetOrdinal("a_jewel_percent_6");
        int ordinal15 = mySqlDataReader.GetOrdinal("a_jewel_7");
        int ordinal16 = mySqlDataReader.GetOrdinal("a_jewel_percent_7");
        int ordinal17 = mySqlDataReader.GetOrdinal("a_jewel_8");
        int ordinal18 = mySqlDataReader.GetOrdinal("a_jewel_percent_8");
        int ordinal19 = mySqlDataReader.GetOrdinal("a_jewel_9");
        int ordinal20 = mySqlDataReader.GetOrdinal("a_jewel_percent_9");
        int ordinal21 = mySqlDataReader.GetOrdinal("a_jewel_10");
        int ordinal22 = mySqlDataReader.GetOrdinal("a_jewel_percent_10");
        int ordinal23 = mySqlDataReader.GetOrdinal("a_jewel_11");
        int ordinal24 = mySqlDataReader.GetOrdinal("a_jewel_percent_11");
        int ordinal25 = mySqlDataReader.GetOrdinal("a_jewel_12");
        int ordinal26 = mySqlDataReader.GetOrdinal("a_jewel_percent_12");
        int ordinal27 = mySqlDataReader.GetOrdinal("a_jewel_13");
        int ordinal28 = mySqlDataReader.GetOrdinal("a_jewel_percent_13");
        int ordinal29 = mySqlDataReader.GetOrdinal("a_jewel_14");
        int ordinal30 = mySqlDataReader.GetOrdinal("a_jewel_percent_14");
        int ordinal31 = mySqlDataReader.GetOrdinal("a_jewel_15");
        int ordinal32 = mySqlDataReader.GetOrdinal("a_jewel_percent_15");
        int ordinal33 = mySqlDataReader.GetOrdinal("a_jewel_16");
        int ordinal34 = mySqlDataReader.GetOrdinal("a_jewel_percent_16");
        int ordinal35 = mySqlDataReader.GetOrdinal("a_jewel_17");
        int ordinal36 = mySqlDataReader.GetOrdinal("a_jewel_percent_17");
        int ordinal37 = mySqlDataReader.GetOrdinal("a_jewel_18");
        int ordinal38 = mySqlDataReader.GetOrdinal("a_jewel_percent_18");
        int ordinal39 = mySqlDataReader.GetOrdinal("a_jewel_19");
        int ordinal40 = mySqlDataReader.GetOrdinal("a_jewel_percent_19");
        string str2 = mySqlDataReader.GetString(ordinal1);
        string str3 = mySqlDataReader.GetString(ordinal2);
        string str4 = mySqlDataReader.GetString(ordinal3);
        string str5 = mySqlDataReader.GetString(ordinal4);
        string str6 = mySqlDataReader.GetString(ordinal5);
        string str7 = mySqlDataReader.GetString(ordinal6);
        string str8 = mySqlDataReader.GetString(ordinal7);
        string str9 = mySqlDataReader.GetString(ordinal8);
        string str10 = mySqlDataReader.GetString(ordinal9);
        string str11 = mySqlDataReader.GetString(ordinal10);
        string str12 = mySqlDataReader.GetString(ordinal11);
        string str13 = mySqlDataReader.GetString(ordinal12);
        string str14 = mySqlDataReader.GetString(ordinal13);
        string str15 = mySqlDataReader.GetString(ordinal14);
        string str16 = mySqlDataReader.GetString(ordinal15);
        string str17 = mySqlDataReader.GetString(ordinal16);
        string str18 = mySqlDataReader.GetString(ordinal17);
        string str19 = mySqlDataReader.GetString(ordinal18);
        string str20 = mySqlDataReader.GetString(ordinal19);
        string str21 = mySqlDataReader.GetString(ordinal20);
        string str22 = mySqlDataReader.GetString(ordinal21);
        string str23 = mySqlDataReader.GetString(ordinal22);
        string str24 = mySqlDataReader.GetString(ordinal23);
        string str25 = mySqlDataReader.GetString(ordinal24);
        string str26 = mySqlDataReader.GetString(ordinal25);
        string str27 = mySqlDataReader.GetString(ordinal26);
        string str28 = mySqlDataReader.GetString(ordinal27);
        string str29 = mySqlDataReader.GetString(ordinal28);
        string str30 = mySqlDataReader.GetString(ordinal29);
        string str31 = mySqlDataReader.GetString(ordinal30);
        string str32 = mySqlDataReader.GetString(ordinal31);
        string str33 = mySqlDataReader.GetString(ordinal32);
        string str34 = mySqlDataReader.GetString(ordinal33);
        string str35 = mySqlDataReader.GetString(ordinal34);
        string str36 = mySqlDataReader.GetString(ordinal35);
        string str37 = mySqlDataReader.GetString(ordinal36);
        string str38 = mySqlDataReader.GetString(ordinal37);
        string str39 = mySqlDataReader.GetString(ordinal38);
        string str40 = mySqlDataReader.GetString(ordinal39);
        string str41 = mySqlDataReader.GetString(ordinal40);
        Bitmap bitmap1 = databaseHandle.IconFast(Convert.ToInt32(str2));
        string str42 = databaseHandle.ItemNameFast(Convert.ToInt32(str2));
        Bitmap bitmap2 = databaseHandle.IconFast(Convert.ToInt32(str4));
        string str43 = databaseHandle.ItemNameFast(Convert.ToInt32(str4));
        Bitmap bitmap3 = databaseHandle.IconFast(Convert.ToInt32(str6));
        string str44 = databaseHandle.ItemNameFast(Convert.ToInt32(str6));
        Bitmap bitmap4 = databaseHandle.IconFast(Convert.ToInt32(str8));
        string str45 = databaseHandle.ItemNameFast(Convert.ToInt32(str8));
        Bitmap bitmap5 = databaseHandle.IconFast(Convert.ToInt32(str10));
        string str46 = databaseHandle.ItemNameFast(Convert.ToInt32(str10));
        Bitmap bitmap6 = databaseHandle.IconFast(Convert.ToInt32(str12));
        string str47 = databaseHandle.ItemNameFast(Convert.ToInt32(str12));
        Bitmap bitmap7 = databaseHandle.IconFast(Convert.ToInt32(str14));
        string str48 = databaseHandle.ItemNameFast(Convert.ToInt32(str14));
        Bitmap bitmap8 = databaseHandle.IconFast(Convert.ToInt32(str16));
        string str49 = databaseHandle.ItemNameFast(Convert.ToInt32(str16));
        Bitmap bitmap9 = databaseHandle.IconFast(Convert.ToInt32(str18));
        string str50 = databaseHandle.ItemNameFast(Convert.ToInt32(str18));
        Bitmap bitmap10 = databaseHandle.IconFast(Convert.ToInt32(str20));
        string str51 = databaseHandle.ItemNameFast(Convert.ToInt32(str20));
        Bitmap bitmap11 = databaseHandle.IconFast(Convert.ToInt32(str22));
        string str52 = databaseHandle.ItemNameFast(Convert.ToInt32(str22));
        Bitmap bitmap12 = databaseHandle.IconFast(Convert.ToInt32(str24));
        string str53 = databaseHandle.ItemNameFast(Convert.ToInt32(str24));
        Bitmap bitmap13 = databaseHandle.IconFast(Convert.ToInt32(str26));
        string str54 = databaseHandle.ItemNameFast(Convert.ToInt32(str26));
        Bitmap bitmap14 = databaseHandle.IconFast(Convert.ToInt32(str28));
        string str55 = databaseHandle.ItemNameFast(Convert.ToInt32(str28));
        Bitmap bitmap15 = databaseHandle.IconFast(Convert.ToInt32(str30));
        string str56 = databaseHandle.ItemNameFast(Convert.ToInt32(str30));
        Bitmap bitmap16 = databaseHandle.IconFast(Convert.ToInt32(str32));
        string str57 = databaseHandle.ItemNameFast(Convert.ToInt32(str32));
        Bitmap bitmap17 = databaseHandle.IconFast(Convert.ToInt32(str34));
        string str58 = databaseHandle.ItemNameFast(Convert.ToInt32(str34));
        Bitmap bitmap18 = databaseHandle.IconFast(Convert.ToInt32(str36));
        string str59 = databaseHandle.ItemNameFast(Convert.ToInt32(str36));
        Bitmap bitmap19 = databaseHandle.IconFast(Convert.ToInt32(str38));
        string str60 = databaseHandle.ItemNameFast(Convert.ToInt32(str38));
        Bitmap bitmap20 = databaseHandle.IconFast(Convert.ToInt32(str40));
        string str61 = databaseHandle.ItemNameFast(Convert.ToInt32(str40));
                dataGridView2.Rows.Add( bitmap1,  str2,  str42,  str3);
                dataGridView2.Rows.Add( bitmap2,  str4,  str43,  str5);
                dataGridView2.Rows.Add( bitmap3,  str6,  str44,  str7);
                dataGridView2.Rows.Add( bitmap4,  str8,  str45,  str9);
                dataGridView2.Rows.Add( bitmap5,  str10,  str46,  str11);
                dataGridView2.Rows.Add( bitmap6,  str12,  str47,  str13);
                dataGridView2.Rows.Add( bitmap7,  str14,  str48,  str15);
                dataGridView2.Rows.Add( bitmap8,  str16,  str49,  str17);
                dataGridView2.Rows.Add( bitmap9,  str18,  str50,  str19);
                dataGridView2.Rows.Add( bitmap10,  str20,  str51,  str21);
                dataGridView2.Rows.Add( bitmap11,  str22,  str52,  str23);
                dataGridView2.Rows.Add( bitmap12,  str24,  str53,  str25);
                dataGridView2.Rows.Add( bitmap13,  str26,  str54,  str27);
                dataGridView2.Rows.Add( bitmap14,  str28,  str55,  str29);
                dataGridView2.Rows.Add( bitmap15,  str30,  str56,  str31);
                dataGridView2.Rows.Add( bitmap16,  str32,  str57,  str33);
                dataGridView2.Rows.Add( bitmap17,  str34,  str58,  str35);
                dataGridView2.Rows.Add( bitmap18,  str36,  str59,  str37);
                dataGridView2.Rows.Add( bitmap19,  str38,  str60,  str39);
                dataGridView2.Rows.Add( bitmap20,  str40,  str61,  str41);
      }
      mySqlConnection.Close();
    }

    private void SelectBoxes()
    {
      int num1 = comboBox1.FindString(textBox31.Text);
      int num2 = comboBox2.FindString(textBox110.Text);
            comboBox1.SelectedIndex = num1;
            comboBox2.SelectedIndex = num2;
    }

        private void button2_Click(object sender, EventArgs e)
        {
            string aname = StringFromLanguage(); //dethunter12 language a_name_
            string adescr = DescrFromLanguage(); //dethunter12 language a_descr
            databaseHandle.SendQueryMySql(Host, User, Password, Database, "UPDATE t_npc SET " + "a_index = '" + textBox1.Text + "', " + "a_enable = '" + textBox2.Text + "', " + aname + "=" + "'" + textBox3.Text.Replace("'", "\\'").Replace("\"", "\\\"") + "', "  + adescr + "=" + "'" + textBox4.Text.Replace("'", "\\'").Replace("\"", "\\\"") + "', " + "a_level = '" + textBox5.Text + "', " + "a_family = '" + textBox6.Text + "', " + "a_skillmaster = '" + textBox7.Text + "', " + "a_flag = '" + textBox8.Text + "', " + "a_flag1 = '" + textBox9.Text + "', " + "a_state_flag = '" + textBox10.Text + "', " + "a_exp = '" + textBox11.Text + "', " + "a_prize = '" + textBox12.Text + "', " + "a_sight = '" + textBox13.Text + "', " + "a_size = '" + textBox14.Text + "', " + "a_move_area = '" + textBox15.Text + "', " + "a_attack_area = '" + textBox16.Text + "', " + "a_skill_point = '" + textBox17.Text + "', " + "a_sskill_master = '" + textBox18.Text + "', " + "a_str = '" + textBox19.Text + "', " + "a_dex = '" + textBox20.Text + "', " + "a_int = '" + textBox21.Text + "', " + "a_con = '" + textBox22.Text + "', " + "a_attack = '" + textBox23.Text + "', " + "a_magic = '" + textBox24.Text + "', " + "a_defense = '" + textBox25.Text + "', " + "a_resist = '" + textBox26.Text + "', " + "a_attacklevel = '" + textBox27.Text + "', " + "a_defenselevel = '" + textBox28.Text + "', " + "a_hp = '" + textBox29.Text + "', " + "a_mp = '" + textBox30.Text + "', " + "a_attackType = '" + textBox31.Text + "', " + "a_attackSpeed = '" + textBox32.Text + "', " + "a_recover_hp = '" + textBox33.Text + "', " + "a_recover_mp = '" + textBox34.Text + "', " + "a_walk_speed = '" + textBox35.Text + "', " + "a_run_speed = '" + textBox36.Text + "', " + "a_skill0 = '" + textBox37.Text + "', " + "a_skill1 = '" + textBox38.Text + "', " + "a_skill2 = '" + textBox39.Text + "', " + "a_skill3 = '" + textBox40.Text + "', " + "a_item_0 = '" + textBox41.Text + "', " + "a_item_1 = '" + textBox42.Text + "', " + "a_item_2 = '" + textBox43.Text + "', " + "a_item_3 = '" + textBox44.Text + "', " + "a_item_4 = '" + textBox45.Text + "', " + "a_item_5 = '" + textBox46.Text + "', " + "a_item_6 = '" + textBox47.Text + "', " + "a_item_7 = '" + textBox48.Text + "', " + "a_item_8 = '" + textBox49.Text + "', " + "a_item_9 = '" + textBox50.Text + "', " + "a_item_10 = '" + textBox51.Text + "', " + "a_item_11 = '" + textBox52.Text + "', " + "a_item_12 = '" + textBox53.Text + "', " + "a_item_13 = '" + textBox54.Text + "', " + "a_item_14 = '" + textBox55.Text + "', " + "a_item_15 = '" + textBox56.Text + "', " + "a_item_16 = '" + textBox57.Text + "', " + "a_item_17 = '" + textBox58.Text + "', " + "a_item_18 = '" + textBox59.Text + "', " + "a_item_19 = '" + textBox60.Text + "', " + "a_item_percent_0 = '" + textBox61.Text + "', " + "a_item_percent_1 = '" + textBox62.Text + "', " + "a_item_percent_2 = '" + textBox63.Text + "', " + "a_item_percent_3 = '" + textBox64.Text + "', " + "a_item_percent_4 = '" + textBox65.Text + "', " + "a_item_percent_5 = '" + textBox66.Text + "', " + "a_item_percent_6 = '" + textBox67.Text + "', " + "a_item_percent_7 = '" + textBox68.Text + "', " + "a_item_percent_8 = '" + textBox69.Text + "', " + "a_item_percent_9 = '" + textBox70.Text + "', " + "a_item_percent_10 = '" + textBox71.Text + "', " + "a_item_percent_11 = '" + textBox72.Text + "', " + "a_item_percent_12 = '" + textBox73.Text + "', " + "a_item_percent_13 = '" + textBox74.Text + "', " + "a_item_percent_14 = '" + textBox75.Text + "', " + "a_item_percent_15 = '" + textBox76.Text + "', " + "a_item_percent_16 = '" + textBox77.Text + "', " + "a_item_percent_17 = '" + textBox78.Text + "', " + "a_item_percent_18 = '" + textBox79.Text + "', " + "a_item_percent_19 = '" + textBox80.Text + "', " + "a_minplus = '" + textBox81.Text + "', " + "a_maxplus = '" + textBox82.Text + "', " + "a_probplus = '" + textBox83.Text + "', " + "a_product0 = '" + textBox84.Text + "', " + "a_product1 = '" + textBox85.Text + "', " + "a_product2 = '" + textBox86.Text + "', " + "a_product3 = '" + textBox87.Text + "', " + "a_product4 = '" + textBox88.Text + "', " + "a_file_smc = '" + textBox89.Text.Replace("'", "\\'").Replace("\\", "\\\\").Replace("'", "\\'") + "', " + "a_motion_walk = '" + textBox90.Text.Replace("'", "\\'").Replace("\"", "\\\"") + "', " + "a_motion_idle = '" + textBox91.Text.Replace("'", "\\'").Replace("\"", "\\\"") + "', " + "a_motion_dam = '" + textBox92.Text.Replace("'", "\\'").Replace("\"", "\\\"") + "', " + "a_motion_attack = '" + textBox93.Text.Replace("'", "\\'").Replace("\"", "\\\"") + "', " + "a_motion_die = '" + textBox94.Text.Replace("'", "\\'").Replace("\"", "\\\"") + "', " + "a_motion_run = '" + textBox95.Text.Replace("'", "\\'").Replace("\"", "\\\"") + "', " + "a_motion_idle2 = '" + textBox96.Text.Replace("'", "\\'").Replace("\"", "\\\"") + "', " + "a_motion_attack2 = '" + textBox97.Text.Replace("'", "\\'").Replace("\"", "\\\"") + "', " + "a_scale = '" + textBox98.Text + "', " + "a_attribute = '" + textBox99.Text + "', " + "a_fireDelayCount = '" + textBox100.Text + "', " + "a_fireDelay0 = '" + textBox101.Text + "', " + "a_fireDelay1 = '" + textBox102.Text + "', " + "a_fireDelay2 = '" + textBox103.Text + "', " + "a_fireDelay3 = '" + textBox104.Text + "', " + "a_fireEffect0 = '" + textBox105.Text + "', " + "a_fireEffect1 = '" + textBox106.Text + "', " + "a_fireEffect2 = '" + textBox107.Text + "', " + "a_fireObject = '" + textBox108.Text + "', " + "a_fireSpeed = '" + textBox109.Text + "', " + "a_aitype = '" + textBox110.Text + "', " + "a_aiflag = '" + textBox111.Text + "', " + "a_aileader_flag = '" + textBox112.Text + "', " + "a_ai_summonHp = '" + textBox113.Text + "', " + "a_aileader_idx = '" + textBox114.Text + "', " + "a_aileader_count = '" + textBox115.Text + "', " + "a_crafting_category = '" + textBox116.Text + "', " + "a_productIndex = '" + textBox117.Text + "', " + "a_hit = '" + textBox118.Text + "', " + "a_dodge = '" + textBox119.Text + "', " + "a_magicavoid = '" + textBox120.Text + "', " + "a_job_attribute = '" + textBox121.Text + "', " + "a_npc_choice_trigger_count = '" + textBox122.Text + "', " + "a_npc_choice_trigger_ids = '" + textBox123.Text + "', " + "a_npc_kill_trigger_count = '" + textBox124.Text + "', " + "a_npc_kill_trigger_ids = '" + textBox125.Text + "', " + "a_createprob = '" + textBox126.Text + "', " + "a_socketprob_0 = '" + textBox127.Text + "', " + "a_socketprob_1 = '" + textBox128.Text + "', " + "a_socketprob_2 = '" + textBox129.Text + "', " + "a_socketprob_3 = '" + textBox130.Text + "', " + "a_jewel_0 = '" + textBox131.Text + "', " + "a_jewel_1 = '" + textBox132.Text + "', " + "a_jewel_2 = '" + textBox133.Text + "', " + "a_jewel_3 = '" + textBox134.Text + "', " + "a_jewel_4 = '" + textBox135.Text + "', " + "a_jewel_5 = '" + textBox136.Text + "', " + "a_jewel_6 = '" + textBox137.Text + "', " + "a_jewel_7 = '" + textBox138.Text + "', " + "a_jewel_8 = '" + textBox139.Text + "', " + "a_jewel_9 = '" + textBox140.Text + "', " + "a_jewel_10 = '" + textBox141.Text + "', " + "a_jewel_11 = '" + textBox142.Text + "', " + "a_jewel_12 = '" + textBox143.Text + "', " + "a_jewel_13 = '" + textBox144.Text + "', " + "a_jewel_14 = '" + textBox145.Text + "', " + "a_jewel_15 = '" + textBox146.Text + "', " + "a_jewel_16 = '" + textBox147.Text + "', " + "a_jewel_17 = '" + textBox148.Text + "', " + "a_jewel_18 = '" + textBox149.Text + "', " + "a_jewel_19 = '" + textBox150.Text + "', " + "a_jewel_percent_0 = '" + textBox151.Text + "', " + "a_jewel_percent_1 = '" + textBox152.Text + "', " + "a_jewel_percent_2 = '" + textBox153.Text + "', " + "a_jewel_percent_3 = '" + textBox154.Text + "', " + "a_jewel_percent_4 = '" + textBox155.Text + "', " + "a_jewel_percent_5 = '" + textBox156.Text + "', " + "a_jewel_percent_6 = '" + textBox157.Text + "', " + "a_jewel_percent_7 = '" + textBox158.Text + "', " + "a_jewel_percent_8 = '" + textBox159.Text + "', " + "a_jewel_percent_9 = '" + textBox160.Text + "', " + "a_jewel_percent_10 = '" + textBox161.Text + "', " + "a_jewel_percent_11 = '" + textBox162.Text + "', " + "a_jewel_percent_12 = '" + textBox163.Text + "', " + "a_jewel_percent_13 = '" + textBox164.Text + "', " + "a_jewel_percent_14 = '" + textBox165.Text + "', " + "a_jewel_percent_15 = '" + textBox166.Text + "', " + "a_jewel_percent_16 = '" + textBox167.Text + "', " + "a_jewel_percent_17 = '" + textBox168.Text + "', " + "a_jewel_percent_18 = '" + textBox169.Text + "', " + "a_jewel_percent_19 = '" + textBox170.Text + "' " + "WHERE a_index = '" + textBox1.Text + "'"); //dethunter12 test
      int selectedIndex = listBox1.SelectedIndex;
      int num4 = (int)new CustomMessage("Done :)").ShowDialog();
      if (textBox200.Text != "")
                SearchList(textBox200.Text);
      else
                LoadListBox();
            listBox1.SelectedIndex = selectedIndex;
    }

    private void button1_Click(object sender, EventArgs e)
    {
            databaseHandle.SendQueryMySql(Host, User, Password, Database, "INSERT INTO t_npc DEFAULT VALUES");
            LoadListBox();
            listBox1.SelectedIndex = listBox1.Items.Count - 1;
            textBox2.Text = "1";
    }

    private void button3_Click(object sender, EventArgs e)
    {
      int selectedIndex = listBox1.SelectedIndex;
            databaseHandle.SendQueryMySql(Host, User, Password, Database, "DELETE FROM t_npc WHERE a_index = '" + textBox1.Text + "'");
            LoadListBox();
            listBox1.SelectedIndex = selectedIndex - 1;
            int num4 = (int)new CustomMessage("Deleted :O").ShowDialog();
        }

    private void textBox150_TextChanged(object sender, EventArgs e)
    {
            //dethunter12 4/11/2018 text change field check
            if (language == "GER")
            {
                listBox1.DataSource = databaseHandle.SearchList(textBox200.Text, menuArrayGER, "t_npc");
            }
            else if (language == "POL")
            {
                listBox1.DataSource = databaseHandle.SearchList(textBox200.Text, menuArrayPOL, "t_npc");
            }
            else if (language == "BRA")
            {
                listBox1.DataSource = databaseHandle.SearchList(textBox200.Text, menuArrayBRA, "t_npc");
            }
            else if (language == "RUS")
            {
                listBox1.DataSource = databaseHandle.SearchList(textBox200.Text, menuArrayRUS, "t_npc");
            }
            else if (language == "FRA")
            {
                listBox1.DataSource = databaseHandle.SearchList(textBox200.Text, menuArrayFRA, "t_npc");
            }
            else if (language == "ESP")
            {
                listBox1.DataSource = databaseHandle.SearchList(textBox200.Text, menuArrayESP, "t_npc");
            }
            else if (language == "MEX")
            {
                listBox1.DataSource = databaseHandle.SearchList(textBox200.Text, menuArrayMEX, "t_npc");
            }
            else if (language == "THA")
            {
                listBox1.DataSource = databaseHandle.SearchList(textBox200.Text, menuArrayTHA, "t_npc");
            }
            else if (language == "ITA")
            {
                listBox1.DataSource = databaseHandle.SearchList(textBox200.Text, menuArrayITA, "t_npc");
            }
            else if (language == "USA")
            {
                listBox1.DataSource = databaseHandle.SearchList(textBox200.Text, menuArrayUSA, "t_npc");
            }
            else // none of the previous
            {
                listBox1.DataSource = databaseHandle.SearchList(textBox200.Text, menuArray, "t_npc");
            }

    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
            textBox31.Text = GetIndexByComboBox(comboBox1.Text).ToString();
    }

    private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
    {
            textBox110.Text = GetIndexByComboBox(comboBox2.Text).ToString();
    }

    private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void LoadLangAtStartup()
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
        } //dethunter12 4/12/2018 add
    private void MobEditor_Load(object sender, EventArgs e)
    {
            InitializeDevice();
            LoadDG();
            LoadDG2();
            LoadListBox();
            SelectBoxes();
            LoadLangAtStartup(); //dethunter12 4/12/2018 add
        }

    private void TransferDataGridToTextBox()
    {
            textBox41.Text = Convert.ToString(dataGridView1.Rows[0].Cells["Column2"].Value);
            dataGridView1.Rows[0].Cells["Column1"].Value = databaseHandle.IconFast(Convert.ToInt32(textBox41.Text));
            dataGridView1.Rows[0].Cells["Column3"].Value = databaseHandle.ItemNameFast(Convert.ToInt32(textBox41.Text));
            textBox42.Text = Convert.ToString(dataGridView1.Rows[1].Cells["Column2"].Value);
            dataGridView1.Rows[1].Cells["Column1"].Value = databaseHandle.IconFast(Convert.ToInt32(textBox42.Text));
            dataGridView1.Rows[1].Cells["Column3"].Value = databaseHandle.ItemNameFast(Convert.ToInt32(textBox42.Text));
            textBox43.Text = Convert.ToString(dataGridView1.Rows[2].Cells["Column2"].Value);
            dataGridView1.Rows[2].Cells["Column1"].Value = databaseHandle.IconFast(Convert.ToInt32(textBox43.Text));
            dataGridView1.Rows[2].Cells["Column3"].Value = databaseHandle.ItemNameFast(Convert.ToInt32(textBox43.Text));
            textBox44.Text = Convert.ToString(dataGridView1.Rows[3].Cells["Column2"].Value);
            dataGridView1.Rows[3].Cells["Column1"].Value = databaseHandle.IconFast(Convert.ToInt32(textBox44.Text));
            dataGridView1.Rows[3].Cells["Column3"].Value = databaseHandle.ItemNameFast(Convert.ToInt32(textBox44.Text));
            textBox45.Text = Convert.ToString(dataGridView1.Rows[4].Cells["Column2"].Value);
            dataGridView1.Rows[4].Cells["Column1"].Value = databaseHandle.IconFast(Convert.ToInt32(textBox45.Text));
            dataGridView1.Rows[4].Cells["Column3"].Value = databaseHandle.ItemNameFast(Convert.ToInt32(textBox45.Text));
            textBox46.Text = Convert.ToString(dataGridView1.Rows[5].Cells["Column2"].Value);
            dataGridView1.Rows[5].Cells["Column1"].Value = databaseHandle.IconFast(Convert.ToInt32(textBox46.Text));
            dataGridView1.Rows[5].Cells["Column3"].Value = databaseHandle.ItemNameFast(Convert.ToInt32(textBox46.Text));
            textBox47.Text = Convert.ToString(dataGridView1.Rows[6].Cells["Column2"].Value);
            dataGridView1.Rows[6].Cells["Column1"].Value = databaseHandle.IconFast(Convert.ToInt32(textBox47.Text));
            dataGridView1.Rows[6].Cells["Column3"].Value = databaseHandle.ItemNameFast(Convert.ToInt32(textBox47.Text));
            textBox48.Text = Convert.ToString(dataGridView1.Rows[7].Cells["Column2"].Value);
            dataGridView1.Rows[7].Cells["Column1"].Value = databaseHandle.IconFast(Convert.ToInt32(textBox48.Text));
            dataGridView1.Rows[7].Cells["Column3"].Value = databaseHandle.ItemNameFast(Convert.ToInt32(textBox48.Text));
            textBox49.Text = Convert.ToString(dataGridView1.Rows[8].Cells["Column2"].Value);
            dataGridView1.Rows[8].Cells["Column1"].Value = databaseHandle.IconFast(Convert.ToInt32(textBox49.Text));
            dataGridView1.Rows[8].Cells["Column3"].Value = databaseHandle.ItemNameFast(Convert.ToInt32(textBox49.Text));
            textBox50.Text = Convert.ToString(dataGridView1.Rows[9].Cells["Column2"].Value);
            dataGridView1.Rows[9].Cells["Column1"].Value = databaseHandle.IconFast(Convert.ToInt32(textBox50.Text));
            dataGridView1.Rows[9].Cells["Column3"].Value = databaseHandle.ItemNameFast(Convert.ToInt32(textBox50.Text));
            textBox51.Text = Convert.ToString(dataGridView1.Rows[10].Cells["Column2"].Value);
            dataGridView1.Rows[10].Cells["Column1"].Value = databaseHandle.IconFast(Convert.ToInt32(textBox51.Text));
            dataGridView1.Rows[10].Cells["Column3"].Value = databaseHandle.ItemNameFast(Convert.ToInt32(textBox51.Text));
            textBox52.Text = Convert.ToString(dataGridView1.Rows[11].Cells["Column2"].Value);
            dataGridView1.Rows[11].Cells["Column1"].Value = databaseHandle.IconFast(Convert.ToInt32(textBox52.Text));
            dataGridView1.Rows[11].Cells["Column3"].Value = databaseHandle.ItemNameFast(Convert.ToInt32(textBox52.Text));
            textBox53.Text = Convert.ToString(dataGridView1.Rows[12].Cells["Column2"].Value);
            dataGridView1.Rows[12].Cells["Column1"].Value = databaseHandle.IconFast(Convert.ToInt32(textBox53.Text));
            dataGridView1.Rows[12].Cells["Column3"].Value = databaseHandle.ItemNameFast(Convert.ToInt32(textBox53.Text));
            textBox54.Text = Convert.ToString(dataGridView1.Rows[13].Cells["Column2"].Value);
            dataGridView1.Rows[13].Cells["Column1"].Value = databaseHandle.IconFast(Convert.ToInt32(textBox54.Text));
            dataGridView1.Rows[13].Cells["Column3"].Value = databaseHandle.ItemNameFast(Convert.ToInt32(textBox54.Text));
            textBox55.Text = Convert.ToString(dataGridView1.Rows[14].Cells["Column2"].Value);
            dataGridView1.Rows[14].Cells["Column1"].Value = databaseHandle.IconFast(Convert.ToInt32(textBox55.Text));
            dataGridView1.Rows[14].Cells["Column3"].Value = databaseHandle.ItemNameFast(Convert.ToInt32(textBox55.Text));
            textBox56.Text = Convert.ToString(dataGridView1.Rows[15].Cells["Column2"].Value);
            dataGridView1.Rows[15].Cells["Column1"].Value = databaseHandle.IconFast(Convert.ToInt32(textBox56.Text));
            dataGridView1.Rows[15].Cells["Column3"].Value = databaseHandle.ItemNameFast(Convert.ToInt32(textBox56.Text));
            textBox57.Text = Convert.ToString(dataGridView1.Rows[16].Cells["Column2"].Value);
            dataGridView1.Rows[16].Cells["Column1"].Value = databaseHandle.IconFast(Convert.ToInt32(textBox57.Text));
            dataGridView1.Rows[16].Cells["Column3"].Value = databaseHandle.ItemNameFast(Convert.ToInt32(textBox57.Text));
            textBox58.Text = Convert.ToString(dataGridView1.Rows[17].Cells["Column2"].Value);
            dataGridView1.Rows[17].Cells["Column1"].Value = databaseHandle.IconFast(Convert.ToInt32(textBox58.Text));
            dataGridView1.Rows[17].Cells["Column3"].Value = databaseHandle.ItemNameFast(Convert.ToInt32(textBox58.Text));
            textBox59.Text = Convert.ToString(dataGridView1.Rows[18].Cells["Column2"].Value);
            dataGridView1.Rows[18].Cells["Column1"].Value = databaseHandle.IconFast(Convert.ToInt32(textBox59.Text));
            dataGridView1.Rows[18].Cells["Column3"].Value = databaseHandle.ItemNameFast(Convert.ToInt32(textBox59.Text));
            textBox60.Text = Convert.ToString(dataGridView1.Rows[19].Cells["Column2"].Value);
            dataGridView1.Rows[19].Cells["Column1"].Value = databaseHandle.IconFast(Convert.ToInt32(textBox60.Text));
            dataGridView1.Rows[19].Cells["Column3"].Value = databaseHandle.ItemNameFast(Convert.ToInt32(textBox60.Text));
            textBox61.Text = Convert.ToString(dataGridView1.Rows[0].Cells["Column4"].Value);
            textBox62.Text = Convert.ToString(dataGridView1.Rows[1].Cells["Column4"].Value);
            textBox63.Text = Convert.ToString(dataGridView1.Rows[2].Cells["Column4"].Value);
            textBox64.Text = Convert.ToString(dataGridView1.Rows[3].Cells["Column4"].Value);
            textBox65.Text = Convert.ToString(dataGridView1.Rows[4].Cells["Column4"].Value);
            textBox66.Text = Convert.ToString(dataGridView1.Rows[5].Cells["Column4"].Value);
            textBox67.Text = Convert.ToString(dataGridView1.Rows[6].Cells["Column4"].Value);
            textBox68.Text = Convert.ToString(dataGridView1.Rows[7].Cells["Column4"].Value);
            textBox69.Text = Convert.ToString(dataGridView1.Rows[8].Cells["Column4"].Value);
            textBox70.Text = Convert.ToString(dataGridView1.Rows[9].Cells["Column4"].Value);
            textBox71.Text = Convert.ToString(dataGridView1.Rows[10].Cells["Column4"].Value);
            textBox72.Text = Convert.ToString(dataGridView1.Rows[11].Cells["Column4"].Value);
            textBox73.Text = Convert.ToString(dataGridView1.Rows[12].Cells["Column4"].Value);
            textBox74.Text = Convert.ToString(dataGridView1.Rows[13].Cells["Column4"].Value);
            textBox75.Text = Convert.ToString(dataGridView1.Rows[14].Cells["Column4"].Value);
            textBox76.Text = Convert.ToString(dataGridView1.Rows[15].Cells["Column4"].Value);
            textBox77.Text = Convert.ToString(dataGridView1.Rows[16].Cells["Column4"].Value);
            textBox78.Text = Convert.ToString(dataGridView1.Rows[17].Cells["Column4"].Value);
            textBox79.Text = Convert.ToString(dataGridView1.Rows[18].Cells["Column4"].Value);
            textBox80.Text = Convert.ToString(dataGridView1.Rows[19].Cells["Column4"].Value);
    }

    private void dataGridView1_RowLeave(object sender, DataGridViewCellEventArgs e)
    {
    }

    private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
    {
            TransferDataGridToTextBox();
    }

    private void TransferDataGrid2ToTextBox()
    {
            textBox131.Text = Convert.ToString(dataGridView2.Rows[0].Cells["Column6"].Value);
            dataGridView2.Rows[0].Cells["Column5"].Value = databaseHandle.IconFast(Convert.ToInt32(textBox131.Text));
            dataGridView2.Rows[0].Cells["Column7"].Value = databaseHandle.ItemNameFast(Convert.ToInt32(textBox131.Text));
            textBox132.Text = Convert.ToString(dataGridView2.Rows[1].Cells["Column6"].Value);
            dataGridView2.Rows[1].Cells["Column5"].Value = databaseHandle.IconFast(Convert.ToInt32(textBox132.Text));
            dataGridView2.Rows[1].Cells["Column7"].Value = databaseHandle.ItemNameFast(Convert.ToInt32(textBox132.Text));
            textBox151.Text = Convert.ToString(dataGridView2.Rows[0].Cells["Column8"].Value);
            textBox152.Text = Convert.ToString(dataGridView2.Rows[1].Cells["Column8"].Value);
    }

    private void dataGridView2_CellEndEdit_1(object sender, DataGridViewCellEventArgs e)
    {
            TransferDataGrid2ToTextBox();
    }

    private void pictureBox23_Click(object sender, EventArgs e)
    {
      FlagBuilder flagBuilder = new FlagBuilder();
      flagBuilder.flagSmall = Convert.ToInt32(textBox8.Text);
      flagBuilder.flagBuilderType = "npcs";
      if (flagBuilder.ShowDialog() != DialogResult.OK)
        return;
            textBox8.Text = flagBuilder.flagSmall.ToString();
    }

    private void pictureBox1_Click(object sender, EventArgs e)
    {
      FlagBuilder flagBuilder = new FlagBuilder();
      flagBuilder.flagSmall = Convert.ToInt32(textBox9.Text);
      flagBuilder.flagBuilderType = "npcs1";
      if (flagBuilder.ShowDialog() != DialogResult.OK)
        return;
            textBox9.Text = flagBuilder.flagSmall.ToString();
    }

    private void InitializeDevice()
    {
            _Direct3D = new Direct3D();
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
      presentParameters.BackBufferFormat = (SlimDX.Direct3D9.Format) num4;
      presentParametersArray[index] = presentParameters;
            _Device = new Device(direct3D, adapter, (DeviceType) num1, handle1, (CreateFlags) num2, presentParametersArray);
            _Device.SetRenderState<Cull>(RenderState.CullMode, Cull.None);
            _Device.SetRenderState<FillMode>(RenderState.FillMode, FillMode.Solid);
            _Device.SetRenderState(RenderState.Lighting, false);
            CameraPositioning();
    }

    private void CameraPositioning()
    {
            _Device.SetTransform(TransformState.Projection, Matrix.PerspectiveFovLH(100f, 1f, 1f, 450f));
            _Device.SetTransform(TransformState.View, Matrix.LookAtLH(new Vector3(0.0f, 0.0f, -5f), new Vector3(0.0f, 0.0f, 0.0f), new Vector3(0.0f, 1f, 0.0f)));
            _Device.SetTransform(TransformState.World, Matrix.RotationYawPitchRoll(0.0f, 0.0f, 0.0f));
    }

    private void Render()
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
          Tex.makeRGB8(imageData, width, height).Save((Stream) memoryStream, ImageFormat.Bmp);
          memoryStream.Write(imageData, 0, imageData.Length);
          memoryStream.Position = 0L;
          return Texture.FromStream(_Device, (Stream) memoryStream, width, height, 0, Usage.SoftwareProcessing, SlimDX.Direct3D9.Format.A8B8G8R8, Pool.Default, Filter.None, Filter.None, 0);
        }
      }
      else if (imageFormat == SlimDX.Direct3D9.Format.A8R8G8B8)
      {
        MemoryStream memoryStream;
        using (memoryStream = new MemoryStream())
        {
          Tex.makeRGB(imageData, width, height).Save((Stream) memoryStream, ImageFormat.Bmp);
          memoryStream.Write(imageData, 0, imageData.Length);
          memoryStream.Position = 0L;
          return Texture.FromStream(_Device, (Stream) memoryStream, width, height, 0, Usage.SoftwareProcessing, SlimDX.Direct3D9.Format.A8B8G8R8, Pool.Default, Filter.None, Filter.None, 0);
        }
      }
      else
      {
        Texture texture = new Texture(_Device, width, height, 0, Usage.None, imageFormat, Pool.Managed);
        using (Stream data = (Stream) texture.LockRectangle(0, LockFlags.None).Data)
        {
          data.Write(imageData, 0, ((IEnumerable<byte>) imageData).Count<byte>());
          texture.UnlockRectangle(0);
        }
        return texture;
      }
    }

    private Texture GetTextureFromFile(string FileName)
    {
      Texture texture = (Texture) null;
      if (File.Exists(FileName))
      {
        Tex.ReadFile(FileName);
        SlimDX.Direct3D9.Format imageFormat = ConvFormat(Tex.GetFormat());
        texture = BuildTexture(Tex.lcTex.imageData[0], imageFormat, (int) Tex.lcTex.Header.Width, (int) Tex.lcTex.Header.Height);
      }
      return texture;
    }

    private void MakeLCModels(string SMCFile)
    {
      List<float> source1 = new List<float>();
      List<float> source2 = new List<float>();
      List<float> source3 = new List<float>();
      List<float> floatList1 = new List<float>();
      List<float> floatList2 = new List<float>();
      List<float> floatList3 = new List<float>();
            _Models = new List<tMesh>();
      try
      {
        List<smcMesh> source4 = SMCReader.ReadFile(SMCFile);
        for (int index1 = 0; index1 < source4.Count<smcMesh>(); ++index1)
        {
          if (LCMeshReader.ReadFile(source4[index1].FileName))
          {
            tMeshContainer pMesh = LCMeshReader.pMesh;
            source1.Add(((IEnumerable<tVertex3f>) pMesh.Vertices).Max<tVertex3f>((Func<tVertex3f, float>) (p => p.X)));
            source2.Add(((IEnumerable<tVertex3f>) pMesh.Vertices).Max<tVertex3f>((Func<tVertex3f, float>) (p => p.Y)));
            source3.Add(((IEnumerable<tVertex3f>) pMesh.Vertices).Max<tVertex3f>((Func<tVertex3f, float>) (p => p.Z)));
            floatList1.Add(((IEnumerable<tVertex3f>) pMesh.Vertices).Min<tVertex3f>((Func<tVertex3f, float>) (p => p.X)));
            floatList2.Add(((IEnumerable<tVertex3f>) pMesh.Vertices).Min<tVertex3f>((Func<tVertex3f, float>) (p => p.Y)));
            floatList3.Add(((IEnumerable<tVertex3f>) pMesh.Vertices).Min<tVertex3f>((Func<tVertex3f, float>) (p => p.Z)));
            for (int index2 = 0; index2 < ((IEnumerable<tMeshObject>) pMesh.Objects).Count<tMeshObject>(); ++index2)
            {
              int toVert = (int) pMesh.Objects[index2].ToVert;
              int faceCount = (int) pMesh.Objects[index2].FaceCount;
              short[] faces = pMesh.Objects[index2].GetFaces();
              CustomVertex.PositionNormalTextured[] data = new CustomVertex.PositionNormalTextured[toVert];
              int fromVert = (int) pMesh.Objects[index2].FromVert;
              for (int index3 = 0; (long) index3 < (long) pMesh.Objects[index2].ToVert; ++index3)
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
              VertexBuffer vertexBuffer = new VertexBuffer(_Device, ((IEnumerable<CustomVertex.PositionNormalTextured>) data).Count<CustomVertex.PositionNormalTextured>() * 32, Usage.None, VertexFormat.PositionNormal | VertexFormat.Texture1, Pool.Default);
              Mesh mesh = new Mesh(_Device, ((IEnumerable<short>) faces).Count<short>() / 3, ((IEnumerable<CustomVertex.PositionNormalTextured>) data).Count<CustomVertex.PositionNormalTextured>(), MeshFlags.Managed, VertexFormat.PositionNormal | VertexFormat.Texture1);
              DataStream dataStream1;
              using (dataStream1 = mesh.VertexBuffer.Lock(0, ((IEnumerable<CustomVertex.PositionNormalTextured>) data).Count<CustomVertex.PositionNormalTextured>() * 32, LockFlags.None))
              {
                dataStream1.WriteRange<CustomVertex.PositionNormalTextured>(data);
                mesh.VertexBuffer.Unlock();
              }
              DataStream dataStream2;
              using (dataStream2 = mesh.IndexBuffer.Lock(0, ((IEnumerable<short>) faces).Count<short>() * 2, LockFlags.None))
              {
                dataStream2.WriteRange<short>(faces);
                mesh.IndexBuffer.Unlock();
              }
              if ((uint) ((IEnumerable<tMeshJointWeights>) pMesh.Weights).Count<tMeshJointWeights>() > 0U)
              {
                string[] strArray = new string[((IEnumerable<tMeshJointWeights>) pMesh.Weights).Count<tMeshJointWeights>()];
                List<int>[] intListArray = new List<int>[((IEnumerable<tMeshJointWeights>) pMesh.Weights).Count<tMeshJointWeights>()];
                List<float>[] floatListArray = new List<float>[((IEnumerable<tMeshJointWeights>) pMesh.Weights).Count<tMeshJointWeights>()];
                for (int index3 = 0; index3 < ((IEnumerable<tMeshJointWeights>) pMesh.Weights).Count<tMeshJointWeights>(); ++index3)
                {
                  strArray[index3] = _Enc.GetString(pMesh.Weights[index3].JointName);
                  intListArray[index3] = new List<int>();
                  floatListArray[index3] = new List<float>();
                  for (int index4 = 0; index4 < ((IEnumerable<tMeshWeightsMap>) pMesh.Weights[index3].WeightsMap).Count<tMeshWeightsMap>(); ++index4)
                  {
                    intListArray[index3].Add(pMesh.Weights[index3].WeightsMap[index4].Index);
                    floatListArray[index3].Add(pMesh.Weights[index3].WeightsMap[index4].Weight);
                  }
                }
                mesh.SkinInfo = new SkinInfo(((IEnumerable<CustomVertex.PositionNormalTextured>) data).Count<CustomVertex.PositionNormalTextured>(), VertexFormat.PositionNormal | VertexFormat.Texture1, (int) pMesh.HeaderInfo.JointCount);
                for (int bone = 0; bone < ((IEnumerable<List<int>>) intListArray).Count<List<int>>(); ++bone)
                {
                  mesh.SkinInfo.SetBoneName(bone, strArray[bone]);
                  mesh.SkinInfo.SetBoneInfluence(bone, intListArray[bone].ToArray(), floatListArray[bone].ToArray());
                }
              }
              mesh.GenerateAdjacency(0.5f);
              mesh.ComputeNormals();
              Texture texture = (Texture) null;
              string objName = _Enc.GetString(pMesh.Objects[index2].Textures[0].InternalName);
              int index5 = source4[index1].Object.FindIndex((Predicate<smcObject>) (x => x.Name.Equals(objName)));
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
                _Zoom = ((IEnumerable<float>) new float[3]
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
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
            Render();
    }

        private void slideZoom_Scroll(object sender, EventArgs e)
        {
            _Zoom = (float)slideZoom.Value / 100f;
        }

        private void slideUpDown_Scroll(object sender, EventArgs e)
        {
            _UpDown = (float)slideUpDown.Value / 1000f;
        }

        private void slideLeftRight_Scroll(object sender, EventArgs e)
        {
            _LeftRight = (float)slideLeftRight.Value / 1000f;
        }

        private void button4_Click(object sender, EventArgs e)
    {
            databaseHandle.SendQueryMySql(Host, User, Password, Database, "DROP TABLE IF EXISTS tempTable;" + "CREATE TEMPORARY TABLE tempTable ENGINE=MEMORY SELECT * FROM t_npc WHERE a_index=" + textBox1.Text + ";" + "SELECT a_index FROM tempTable;" + "UPDATE tempTable SET a_index=(SELECT a_index from t_npc ORDER BY a_index DESC LIMIT 1)+1; " + "SELECT a_index FROM tempTable;" + "INSERT INTO t_npc SELECT * FROM tempTable;");
            LoadListBox();
            listBox1.SelectedIndex = listBox1.Items.Count - 1;
    }

    private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exportMobAlllodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportMobAlllodToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.strNpcNamelodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mYSQLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.massEditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBox200 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox20 = new System.Windows.Forms.GroupBox();
            this.chk3D = new System.Windows.Forms.CheckBox();
            this.slideLeftRight = new System.Windows.Forms.TrackBar();
            this.slideUpDown = new System.Windows.Forms.TrackBar();
            this.slideZoom = new System.Windows.Forms.TrackBar();
            this.panel3DView = new System.Windows.Forms.Panel();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.label70 = new System.Windows.Forms.Label();
            this.label69 = new System.Windows.Forms.Label();
            this.textBox107 = new System.Windows.Forms.TextBox();
            this.textBox106 = new System.Windows.Forms.TextBox();
            this.textBox105 = new System.Windows.Forms.TextBox();
            this.label68 = new System.Windows.Forms.Label();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.label72 = new System.Windows.Forms.Label();
            this.textBox109 = new System.Windows.Forms.TextBox();
            this.label71 = new System.Windows.Forms.Label();
            this.textBox108 = new System.Windows.Forms.TextBox();
            this.textBox104 = new System.Windows.Forms.TextBox();
            this.textBox103 = new System.Windows.Forms.TextBox();
            this.textBox102 = new System.Windows.Forms.TextBox();
            this.textBox101 = new System.Windows.Forms.TextBox();
            this.textBox100 = new System.Windows.Forms.TextBox();
            this.label67 = new System.Windows.Forms.Label();
            this.label63 = new System.Windows.Forms.Label();
            this.label66 = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.label65 = new System.Windows.Forms.Label();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.textBox174 = new System.Windows.Forms.TextBox();
            this.textBox173 = new System.Windows.Forms.TextBox();
            this.label137 = new System.Windows.Forms.Label();
            this.label136 = new System.Windows.Forms.Label();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.BtnAniAttack2 = new System.Windows.Forms.Button();
            this.btnAniIdle2 = new System.Windows.Forms.Button();
            this.btnAniRun = new System.Windows.Forms.Button();
            this.btnAniDie = new System.Windows.Forms.Button();
            this.BtnAniAttack1 = new System.Windows.Forms.Button();
            this.BtnAniDam = new System.Windows.Forms.Button();
            this.BtnAniWalk = new System.Windows.Forms.Button();
            this.BtnAniIdle = new System.Windows.Forms.Button();
            this.label60 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.textBox97 = new System.Windows.Forms.TextBox();
            this.textBox96 = new System.Windows.Forms.TextBox();
            this.textBox95 = new System.Windows.Forms.TextBox();
            this.textBox94 = new System.Windows.Forms.TextBox();
            this.textBox93 = new System.Windows.Forms.TextBox();
            this.textBox92 = new System.Windows.Forms.TextBox();
            this.textBox91 = new System.Windows.Forms.TextBox();
            this.textBox90 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnReadSmc = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox23 = new System.Windows.Forms.PictureBox();
            this.textBox98 = new System.Windows.Forms.TextBox();
            this.label61 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.textBox89 = new System.Windows.Forms.TextBox();
            this.textBox30 = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox29 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox36 = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.textBox32 = new System.Windows.Forms.TextBox();
            this.textBox35 = new System.Windows.Forms.TextBox();
            this.textBox31 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.textBox115 = new System.Windows.Forms.TextBox();
            this.label78 = new System.Windows.Forms.Label();
            this.label77 = new System.Windows.Forms.Label();
            this.textBox114 = new System.Windows.Forms.TextBox();
            this.label76 = new System.Windows.Forms.Label();
            this.textBox113 = new System.Windows.Forms.TextBox();
            this.label75 = new System.Windows.Forms.Label();
            this.textBox112 = new System.Windows.Forms.TextBox();
            this.label74 = new System.Windows.Forms.Label();
            this.textBox111 = new System.Windows.Forms.TextBox();
            this.label73 = new System.Windows.Forms.Label();
            this.textBox110 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.label51 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.textBox88 = new System.Windows.Forms.TextBox();
            this.textBox84 = new System.Windows.Forms.TextBox();
            this.textBox87 = new System.Windows.Forms.TextBox();
            this.textBox85 = new System.Windows.Forms.TextBox();
            this.textBox86 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label41 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.textBox40 = new System.Windows.Forms.TextBox();
            this.textBox37 = new System.Windows.Forms.TextBox();
            this.textBox39 = new System.Windows.Forms.TextBox();
            this.textBox38 = new System.Windows.Forms.TextBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.textBox34 = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.textBox33 = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.label84 = new System.Windows.Forms.Label();
            this.textBox121 = new System.Windows.Forms.TextBox();
            this.label83 = new System.Windows.Forms.Label();
            this.textBox120 = new System.Windows.Forms.TextBox();
            this.label82 = new System.Windows.Forms.Label();
            this.textBox119 = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.textBox28 = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.textBox25 = new System.Windows.Forms.TextBox();
            this.textBox26 = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label81 = new System.Windows.Forms.Label();
            this.textBox118 = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.textBox27 = new System.Windows.Forms.TextBox();
            this.textBox24 = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.textBox60 = new System.Windows.Forms.TextBox();
            this.textBox53 = new System.Windows.Forms.TextBox();
            this.textBox80 = new System.Windows.Forms.TextBox();
            this.textBox52 = new System.Windows.Forms.TextBox();
            this.textBox79 = new System.Windows.Forms.TextBox();
            this.textBox51 = new System.Windows.Forms.TextBox();
            this.textBox50 = new System.Windows.Forms.TextBox();
            this.textBox54 = new System.Windows.Forms.TextBox();
            this.textBox78 = new System.Windows.Forms.TextBox();
            this.textBox55 = new System.Windows.Forms.TextBox();
            this.textBox61 = new System.Windows.Forms.TextBox();
            this.textBox56 = new System.Windows.Forms.TextBox();
            this.textBox41 = new System.Windows.Forms.TextBox();
            this.textBox57 = new System.Windows.Forms.TextBox();
            this.textBox77 = new System.Windows.Forms.TextBox();
            this.textBox59 = new System.Windows.Forms.TextBox();
            this.groupBox18 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox58 = new System.Windows.Forms.TextBox();
            this.textBox42 = new System.Windows.Forms.TextBox();
            this.textBox76 = new System.Windows.Forms.TextBox();
            this.textBox43 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox75 = new System.Windows.Forms.TextBox();
            this.textBox44 = new System.Windows.Forms.TextBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.label46 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.textBox83 = new System.Windows.Forms.TextBox();
            this.textBox82 = new System.Windows.Forms.TextBox();
            this.textBox81 = new System.Windows.Forms.TextBox();
            this.textBox45 = new System.Windows.Forms.TextBox();
            this.textBox74 = new System.Windows.Forms.TextBox();
            this.textBox70 = new System.Windows.Forms.TextBox();
            this.textBox46 = new System.Windows.Forms.TextBox();
            this.textBox73 = new System.Windows.Forms.TextBox();
            this.textBox47 = new System.Windows.Forms.TextBox();
            this.textBox69 = new System.Windows.Forms.TextBox();
            this.textBox71 = new System.Windows.Forms.TextBox();
            this.textBox48 = new System.Windows.Forms.TextBox();
            this.textBox66 = new System.Windows.Forms.TextBox();
            this.textBox49 = new System.Windows.Forms.TextBox();
            this.textBox72 = new System.Windows.Forms.TextBox();
            this.textBox63 = new System.Windows.Forms.TextBox();
            this.textBox64 = new System.Windows.Forms.TextBox();
            this.textBox67 = new System.Windows.Forms.TextBox();
            this.textBox68 = new System.Windows.Forms.TextBox();
            this.textBox62 = new System.Windows.Forms.TextBox();
            this.textBox65 = new System.Windows.Forms.TextBox();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.groupBox19 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox170 = new System.Windows.Forms.TextBox();
            this.textBox169 = new System.Windows.Forms.TextBox();
            this.textBox168 = new System.Windows.Forms.TextBox();
            this.textBox167 = new System.Windows.Forms.TextBox();
            this.textBox166 = new System.Windows.Forms.TextBox();
            this.textBox165 = new System.Windows.Forms.TextBox();
            this.textBox164 = new System.Windows.Forms.TextBox();
            this.textBox163 = new System.Windows.Forms.TextBox();
            this.textBox162 = new System.Windows.Forms.TextBox();
            this.textBox161 = new System.Windows.Forms.TextBox();
            this.textBox160 = new System.Windows.Forms.TextBox();
            this.textBox159 = new System.Windows.Forms.TextBox();
            this.textBox158 = new System.Windows.Forms.TextBox();
            this.textBox157 = new System.Windows.Forms.TextBox();
            this.textBox156 = new System.Windows.Forms.TextBox();
            this.textBox155 = new System.Windows.Forms.TextBox();
            this.textBox154 = new System.Windows.Forms.TextBox();
            this.textBox153 = new System.Windows.Forms.TextBox();
            this.textBox152 = new System.Windows.Forms.TextBox();
            this.textBox151 = new System.Windows.Forms.TextBox();
            this.textBox150 = new System.Windows.Forms.TextBox();
            this.textBox149 = new System.Windows.Forms.TextBox();
            this.textBox148 = new System.Windows.Forms.TextBox();
            this.textBox147 = new System.Windows.Forms.TextBox();
            this.textBox146 = new System.Windows.Forms.TextBox();
            this.textBox145 = new System.Windows.Forms.TextBox();
            this.textBox144 = new System.Windows.Forms.TextBox();
            this.textBox143 = new System.Windows.Forms.TextBox();
            this.textBox142 = new System.Windows.Forms.TextBox();
            this.textBox141 = new System.Windows.Forms.TextBox();
            this.textBox140 = new System.Windows.Forms.TextBox();
            this.textBox139 = new System.Windows.Forms.TextBox();
            this.textBox138 = new System.Windows.Forms.TextBox();
            this.textBox137 = new System.Windows.Forms.TextBox();
            this.textBox136 = new System.Windows.Forms.TextBox();
            this.textBox135 = new System.Windows.Forms.TextBox();
            this.textBox134 = new System.Windows.Forms.TextBox();
            this.textBox133 = new System.Windows.Forms.TextBox();
            this.textBox132 = new System.Windows.Forms.TextBox();
            this.textBox131 = new System.Windows.Forms.TextBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.label62 = new System.Windows.Forms.Label();
            this.textBox99 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.textBox176 = new System.Windows.Forms.TextBox();
            this.label139 = new System.Windows.Forms.Label();
            this.textBox175 = new System.Windows.Forms.TextBox();
            this.label138 = new System.Windows.Forms.Label();
            this.textBox172 = new System.Windows.Forms.TextBox();
            this.label135 = new System.Windows.Forms.Label();
            this.textBox171 = new System.Windows.Forms.TextBox();
            this.label134 = new System.Windows.Forms.Label();
            this.label93 = new System.Windows.Forms.Label();
            this.textBox130 = new System.Windows.Forms.TextBox();
            this.label92 = new System.Windows.Forms.Label();
            this.textBox129 = new System.Windows.Forms.TextBox();
            this.label91 = new System.Windows.Forms.Label();
            this.textBox128 = new System.Windows.Forms.TextBox();
            this.label90 = new System.Windows.Forms.Label();
            this.textBox127 = new System.Windows.Forms.TextBox();
            this.label89 = new System.Windows.Forms.Label();
            this.textBox126 = new System.Windows.Forms.TextBox();
            this.label88 = new System.Windows.Forms.Label();
            this.textBox125 = new System.Windows.Forms.TextBox();
            this.textBox124 = new System.Windows.Forms.TextBox();
            this.label87 = new System.Windows.Forms.Label();
            this.label86 = new System.Windows.Forms.Label();
            this.label85 = new System.Windows.Forms.Label();
            this.textBox123 = new System.Windows.Forms.TextBox();
            this.textBox122 = new System.Windows.Forms.TextBox();
            this.label80 = new System.Windows.Forms.Label();
            this.label79 = new System.Windows.Forms.Label();
            this.textBox117 = new System.Windows.Forms.TextBox();
            this.textBox116 = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label42 = new System.Windows.Forms.Label();
            this.lblLang = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox20.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slideLeftRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slideUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slideZoom)).BeginInit();
            this.groupBox15.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.groupBox17.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox16.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox18.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.groupBox19.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage6.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowMerge = false;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportMobAlllodToolStripMenuItem,
            this.mYSQLToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1076, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exportMobAlllodToolStripMenuItem
            // 
            this.exportMobAlllodToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportMobAlllodToolStripMenuItem1,
            this.strNpcNamelodToolStripMenuItem});
            this.exportMobAlllodToolStripMenuItem.Name = "exportMobAlllodToolStripMenuItem";
            this.exportMobAlllodToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.exportMobAlllodToolStripMenuItem.Text = "File Export";
            // 
            // exportMobAlllodToolStripMenuItem1
            // 
            this.exportMobAlllodToolStripMenuItem1.Name = "exportMobAlllodToolStripMenuItem1";
            this.exportMobAlllodToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.exportMobAlllodToolStripMenuItem1.Text = "Export mobAll.lod";
            this.exportMobAlllodToolStripMenuItem1.Click += new System.EventHandler(this.exportMobAlllodToolStripMenuItem1_Click);
            // 
            // strNpcNamelodToolStripMenuItem
            // 
            this.strNpcNamelodToolStripMenuItem.Name = "strNpcNamelodToolStripMenuItem";
            this.strNpcNamelodToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.strNpcNamelodToolStripMenuItem.Text = "StrNpcName.lod";
            // 
            // mYSQLToolStripMenuItem
            // 
            this.mYSQLToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.massEditToolStripMenuItem});
            this.mYSQLToolStripMenuItem.Name = "mYSQLToolStripMenuItem";
            this.mYSQLToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.mYSQLToolStripMenuItem.Text = "MYSQL";
            // 
            // massEditToolStripMenuItem
            // 
            this.massEditToolStripMenuItem.Name = "massEditToolStripMenuItem";
            this.massEditToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.massEditToolStripMenuItem.Text = "Mass Edit";
            this.massEditToolStripMenuItem.Click += new System.EventHandler(this.massEditToolStripMenuItem_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.listBox1);
            this.groupBox3.Location = new System.Drawing.Point(12, 82);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(265, 610);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Monster";
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(97, 568);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(66, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "Copy";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(169, 568);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(6, 568);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(253, 537);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBox200);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Location = new System.Drawing.Point(12, 27);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(265, 49);
            this.groupBox5.TabIndex = 32;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Search";
            // 
            // textBox200
            // 
            this.textBox200.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox200.Location = new System.Drawing.Point(43, 19);
            this.textBox200.Name = "textBox200";
            this.textBox200.Size = new System.Drawing.Size(216, 20);
            this.textBox200.TabIndex = 14;
            this.textBox200.TextChanged += new System.EventHandler(this.textBox150_TextChanged);
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage8);
            this.tabControl1.Location = new System.Drawing.Point(283, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(782, 636);
            this.tabControl1.TabIndex = 33;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.groupBox20);
            this.tabPage1.Controls.Add(this.groupBox15);
            this.tabPage1.Controls.Add(this.groupBox14);
            this.tabPage1.Controls.Add(this.groupBox17);
            this.tabPage1.Controls.Add(this.groupBox13);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.textBox6);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.textBox10);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(774, 610);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Basic";
            // 
            // groupBox20
            // 
            this.groupBox20.Controls.Add(this.chk3D);
            this.groupBox20.Controls.Add(this.slideLeftRight);
            this.groupBox20.Controls.Add(this.slideUpDown);
            this.groupBox20.Controls.Add(this.slideZoom);
            this.groupBox20.Controls.Add(this.panel3DView);
            this.groupBox20.Location = new System.Drawing.Point(479, 275);
            this.groupBox20.Name = "groupBox20";
            this.groupBox20.Size = new System.Drawing.Size(279, 313);
            this.groupBox20.TabIndex = 52;
            this.groupBox20.TabStop = false;
            this.groupBox20.Text = "3D View";
            // 
            // chk3D
            // 
            this.chk3D.AutoSize = true;
            this.chk3D.Checked = true;
            this.chk3D.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk3D.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chk3D.Location = new System.Drawing.Point(180, 0);
            this.chk3D.Name = "chk3D";
            this.chk3D.Size = new System.Drawing.Size(99, 17);
            this.chk3D.TabIndex = 38;
            this.chk3D.Text = "Enable 3D View";
            this.chk3D.UseVisualStyleBackColor = true;
            // 
            // slideLeftRight
            // 
            this.slideLeftRight.AutoSize = false;
            this.slideLeftRight.Location = new System.Drawing.Point(188, 284);
            this.slideLeftRight.Maximum = 10000;
            this.slideLeftRight.Minimum = -10000;
            this.slideLeftRight.Name = "slideLeftRight";
            this.slideLeftRight.Size = new System.Drawing.Size(85, 25);
            this.slideLeftRight.TabIndex = 3;
            this.slideLeftRight.TickStyle = System.Windows.Forms.TickStyle.None;
            this.slideLeftRight.Scroll += new System.EventHandler(this.slideLeftRight_Scroll);
            // 
            // slideUpDown
            // 
            this.slideUpDown.AutoSize = false;
            this.slideUpDown.Location = new System.Drawing.Point(95, 284);
            this.slideUpDown.Maximum = 10000;
            this.slideUpDown.Minimum = -10000;
            this.slideUpDown.Name = "slideUpDown";
            this.slideUpDown.Size = new System.Drawing.Size(85, 25);
            this.slideUpDown.TabIndex = 2;
            this.slideUpDown.TickStyle = System.Windows.Forms.TickStyle.None;
            this.slideUpDown.Scroll += new System.EventHandler(this.slideUpDown_Scroll);
            // 
            // slideZoom
            // 
            this.slideZoom.AutoSize = false;
            this.slideZoom.Location = new System.Drawing.Point(7, 284);
            this.slideZoom.Maximum = 10000;
            this.slideZoom.Minimum = -10000;
            this.slideZoom.Name = "slideZoom";
            this.slideZoom.Size = new System.Drawing.Size(85, 25);
            this.slideZoom.TabIndex = 1;
            this.slideZoom.TickStyle = System.Windows.Forms.TickStyle.None;
            this.slideZoom.Scroll += new System.EventHandler(this.slideZoom_Scroll);
            // 
            // panel3DView
            // 
            this.panel3DView.Location = new System.Drawing.Point(7, 20);
            this.panel3DView.Name = "panel3DView";
            this.panel3DView.Size = new System.Drawing.Size(266, 258);
            this.panel3DView.TabIndex = 0;
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.label70);
            this.groupBox15.Controls.Add(this.label69);
            this.groupBox15.Controls.Add(this.textBox107);
            this.groupBox15.Controls.Add(this.textBox106);
            this.groupBox15.Controls.Add(this.textBox105);
            this.groupBox15.Controls.Add(this.label68);
            this.groupBox15.Location = new System.Drawing.Point(253, 433);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(220, 155);
            this.groupBox15.TabIndex = 51;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "Effect";
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Location = new System.Drawing.Point(10, 70);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(47, 13);
            this.label70.TabIndex = 58;
            this.label70.Text = "Effect 1:";
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Location = new System.Drawing.Point(10, 98);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(47, 13);
            this.label69.TabIndex = 57;
            this.label69.Text = "Effect 2:";
            // 
            // textBox107
            // 
            this.textBox107.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox107.Location = new System.Drawing.Point(84, 96);
            this.textBox107.Name = "textBox107";
            this.textBox107.Size = new System.Drawing.Size(121, 20);
            this.textBox107.TabIndex = 56;
            // 
            // textBox106
            // 
            this.textBox106.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox106.Location = new System.Drawing.Point(84, 63);
            this.textBox106.Name = "textBox106";
            this.textBox106.Size = new System.Drawing.Size(121, 20);
            this.textBox106.TabIndex = 55;
            // 
            // textBox105
            // 
            this.textBox105.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox105.Location = new System.Drawing.Point(84, 28);
            this.textBox105.Name = "textBox105";
            this.textBox105.Size = new System.Drawing.Size(121, 20);
            this.textBox105.TabIndex = 54;
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Location = new System.Drawing.Point(10, 30);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(47, 13);
            this.label68.TabIndex = 49;
            this.label68.Text = "Effect 0:";
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.label72);
            this.groupBox14.Controls.Add(this.textBox109);
            this.groupBox14.Controls.Add(this.label71);
            this.groupBox14.Controls.Add(this.textBox108);
            this.groupBox14.Controls.Add(this.textBox104);
            this.groupBox14.Controls.Add(this.textBox103);
            this.groupBox14.Controls.Add(this.textBox102);
            this.groupBox14.Controls.Add(this.textBox101);
            this.groupBox14.Controls.Add(this.textBox100);
            this.groupBox14.Controls.Add(this.label67);
            this.groupBox14.Controls.Add(this.label63);
            this.groupBox14.Controls.Add(this.label66);
            this.groupBox14.Controls.Add(this.label64);
            this.groupBox14.Controls.Add(this.label65);
            this.groupBox14.Location = new System.Drawing.Point(253, 194);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(220, 233);
            this.groupBox14.TabIndex = 50;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Fire";
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.Location = new System.Drawing.Point(10, 201);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(41, 13);
            this.label72.TabIndex = 57;
            this.label72.Text = "Speed:";
            // 
            // textBox109
            // 
            this.textBox109.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox109.Location = new System.Drawing.Point(84, 198);
            this.textBox109.Name = "textBox109";
            this.textBox109.Size = new System.Drawing.Size(121, 20);
            this.textBox109.TabIndex = 56;
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Location = new System.Drawing.Point(10, 173);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(41, 13);
            this.label71.TabIndex = 55;
            this.label71.Text = "Object:";
            // 
            // textBox108
            // 
            this.textBox108.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox108.Location = new System.Drawing.Point(84, 169);
            this.textBox108.Name = "textBox108";
            this.textBox108.Size = new System.Drawing.Size(121, 20);
            this.textBox108.TabIndex = 54;
            // 
            // textBox104
            // 
            this.textBox104.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox104.Location = new System.Drawing.Point(84, 140);
            this.textBox104.Name = "textBox104";
            this.textBox104.Size = new System.Drawing.Size(121, 20);
            this.textBox104.TabIndex = 53;
            // 
            // textBox103
            // 
            this.textBox103.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox103.Location = new System.Drawing.Point(84, 111);
            this.textBox103.Name = "textBox103";
            this.textBox103.Size = new System.Drawing.Size(121, 20);
            this.textBox103.TabIndex = 52;
            // 
            // textBox102
            // 
            this.textBox102.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox102.Location = new System.Drawing.Point(84, 82);
            this.textBox102.Name = "textBox102";
            this.textBox102.Size = new System.Drawing.Size(121, 20);
            this.textBox102.TabIndex = 51;
            // 
            // textBox101
            // 
            this.textBox101.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox101.Location = new System.Drawing.Point(84, 52);
            this.textBox101.Name = "textBox101";
            this.textBox101.Size = new System.Drawing.Size(121, 20);
            this.textBox101.TabIndex = 50;
            // 
            // textBox100
            // 
            this.textBox100.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox100.Location = new System.Drawing.Point(84, 22);
            this.textBox100.Name = "textBox100";
            this.textBox100.Size = new System.Drawing.Size(121, 20);
            this.textBox100.TabIndex = 43;
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Location = new System.Drawing.Point(10, 144);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(46, 13);
            this.label67.TabIndex = 48;
            this.label67.Text = "Delay 3:";
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Location = new System.Drawing.Point(10, 26);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(68, 13);
            this.label63.TabIndex = 44;
            this.label63.Text = "Delay Count:";
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Location = new System.Drawing.Point(10, 115);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(46, 13);
            this.label66.TabIndex = 47;
            this.label66.Text = "Delay 2:";
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Location = new System.Drawing.Point(10, 56);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(46, 13);
            this.label64.TabIndex = 45;
            this.label64.Text = "Delay 0:";
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Location = new System.Drawing.Point(10, 86);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(46, 13);
            this.label65.TabIndex = 46;
            this.label65.Text = "Delay 1:";
            // 
            // groupBox17
            // 
            this.groupBox17.Controls.Add(this.textBox174);
            this.groupBox17.Controls.Add(this.textBox173);
            this.groupBox17.Controls.Add(this.label137);
            this.groupBox17.Controls.Add(this.label136);
            this.groupBox17.Location = new System.Drawing.Point(7, 452);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Size = new System.Drawing.Size(240, 95);
            this.groupBox17.TabIndex = 24;
            this.groupBox17.TabStop = false;
            this.groupBox17.Text = "RvR";
            // 
            // textBox174
            // 
            this.textBox174.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox174.Location = new System.Drawing.Point(72, 53);
            this.textBox174.Name = "textBox174";
            this.textBox174.Size = new System.Drawing.Size(159, 20);
            this.textBox174.TabIndex = 27;
            // 
            // textBox173
            // 
            this.textBox173.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox173.Location = new System.Drawing.Point(72, 28);
            this.textBox173.Name = "textBox173";
            this.textBox173.Size = new System.Drawing.Size(159, 20);
            this.textBox173.TabIndex = 26;
            // 
            // label137
            // 
            this.label137.AutoSize = true;
            this.label137.Location = new System.Drawing.Point(12, 55);
            this.label137.Name = "label137";
            this.label137.Size = new System.Drawing.Size(64, 13);
            this.label137.TabIndex = 1;
            this.label137.Text = "RvR Grade:";
            // 
            // label136
            // 
            this.label136.AutoSize = true;
            this.label136.Location = new System.Drawing.Point(12, 30);
            this.label136.Name = "label136";
            this.label136.Size = new System.Drawing.Size(62, 13);
            this.label136.TabIndex = 0;
            this.label136.Text = "RvR Value:";
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.BtnAniAttack2);
            this.groupBox13.Controls.Add(this.btnAniIdle2);
            this.groupBox13.Controls.Add(this.btnAniRun);
            this.groupBox13.Controls.Add(this.btnAniDie);
            this.groupBox13.Controls.Add(this.BtnAniAttack1);
            this.groupBox13.Controls.Add(this.BtnAniDam);
            this.groupBox13.Controls.Add(this.BtnAniWalk);
            this.groupBox13.Controls.Add(this.BtnAniIdle);
            this.groupBox13.Controls.Add(this.label60);
            this.groupBox13.Controls.Add(this.label59);
            this.groupBox13.Controls.Add(this.label58);
            this.groupBox13.Controls.Add(this.label57);
            this.groupBox13.Controls.Add(this.label56);
            this.groupBox13.Controls.Add(this.label55);
            this.groupBox13.Controls.Add(this.label54);
            this.groupBox13.Controls.Add(this.label53);
            this.groupBox13.Controls.Add(this.textBox97);
            this.groupBox13.Controls.Add(this.textBox96);
            this.groupBox13.Controls.Add(this.textBox95);
            this.groupBox13.Controls.Add(this.textBox94);
            this.groupBox13.Controls.Add(this.textBox93);
            this.groupBox13.Controls.Add(this.textBox92);
            this.groupBox13.Controls.Add(this.textBox91);
            this.groupBox13.Controls.Add(this.textBox90);
            this.groupBox13.Location = new System.Drawing.Point(7, 194);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(240, 252);
            this.groupBox13.TabIndex = 23;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Animations";
            // 
            // BtnAniAttack2
            // 
            this.BtnAniAttack2.BackColor = System.Drawing.SystemColors.Control;
            this.BtnAniAttack2.BackgroundImage = global::DevPackMine.Properties.Resources.search;
            this.BtnAniAttack2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAniAttack2.FlatAppearance.BorderSize = 0;
            this.BtnAniAttack2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAniAttack2.Location = new System.Drawing.Point(209, 206);
            this.BtnAniAttack2.Name = "BtnAniAttack2";
            this.BtnAniAttack2.Size = new System.Drawing.Size(20, 20);
            this.BtnAniAttack2.TabIndex = 70;
            this.BtnAniAttack2.UseVisualStyleBackColor = true;
            this.BtnAniAttack2.Click += new System.EventHandler(this.AniFind);
            // 
            // btnAniIdle2
            // 
            this.btnAniIdle2.BackColor = System.Drawing.SystemColors.Control;
            this.btnAniIdle2.BackgroundImage = global::DevPackMine.Properties.Resources.search;
            this.btnAniIdle2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAniIdle2.FlatAppearance.BorderSize = 0;
            this.btnAniIdle2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAniIdle2.Location = new System.Drawing.Point(209, 181);
            this.btnAniIdle2.Name = "btnAniIdle2";
            this.btnAniIdle2.Size = new System.Drawing.Size(20, 20);
            this.btnAniIdle2.TabIndex = 69;
            this.btnAniIdle2.UseVisualStyleBackColor = true;
            this.btnAniIdle2.Click += new System.EventHandler(this.AniFind);
            // 
            // btnAniRun
            // 
            this.btnAniRun.BackColor = System.Drawing.SystemColors.Control;
            this.btnAniRun.BackgroundImage = global::DevPackMine.Properties.Resources.search;
            this.btnAniRun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAniRun.FlatAppearance.BorderSize = 0;
            this.btnAniRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAniRun.Location = new System.Drawing.Point(210, 158);
            this.btnAniRun.Name = "btnAniRun";
            this.btnAniRun.Size = new System.Drawing.Size(20, 20);
            this.btnAniRun.TabIndex = 68;
            this.btnAniRun.UseVisualStyleBackColor = true;
            this.btnAniRun.Click += new System.EventHandler(this.AniFind);
            // 
            // btnAniDie
            // 
            this.btnAniDie.BackColor = System.Drawing.SystemColors.Control;
            this.btnAniDie.BackgroundImage = global::DevPackMine.Properties.Resources.search;
            this.btnAniDie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAniDie.FlatAppearance.BorderSize = 0;
            this.btnAniDie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAniDie.Location = new System.Drawing.Point(210, 129);
            this.btnAniDie.Name = "btnAniDie";
            this.btnAniDie.Size = new System.Drawing.Size(20, 20);
            this.btnAniDie.TabIndex = 67;
            this.btnAniDie.UseVisualStyleBackColor = true;
            this.btnAniDie.Click += new System.EventHandler(this.AniFind);
            // 
            // BtnAniAttack1
            // 
            this.BtnAniAttack1.BackColor = System.Drawing.SystemColors.Control;
            this.BtnAniAttack1.BackgroundImage = global::DevPackMine.Properties.Resources.search;
            this.BtnAniAttack1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAniAttack1.FlatAppearance.BorderSize = 0;
            this.BtnAniAttack1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAniAttack1.Location = new System.Drawing.Point(210, 103);
            this.BtnAniAttack1.Name = "BtnAniAttack1";
            this.BtnAniAttack1.Size = new System.Drawing.Size(20, 20);
            this.BtnAniAttack1.TabIndex = 66;
            this.BtnAniAttack1.UseVisualStyleBackColor = true;
            this.BtnAniAttack1.Click += new System.EventHandler(this.AniFind);
            // 
            // BtnAniDam
            // 
            this.BtnAniDam.BackColor = System.Drawing.SystemColors.Control;
            this.BtnAniDam.BackgroundImage = global::DevPackMine.Properties.Resources.search;
            this.BtnAniDam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAniDam.FlatAppearance.BorderSize = 0;
            this.BtnAniDam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAniDam.Location = new System.Drawing.Point(210, 79);
            this.BtnAniDam.Name = "BtnAniDam";
            this.BtnAniDam.Size = new System.Drawing.Size(20, 20);
            this.BtnAniDam.TabIndex = 65;
            this.BtnAniDam.UseVisualStyleBackColor = true;
            this.BtnAniDam.Click += new System.EventHandler(this.AniFind);
            // 
            // BtnAniWalk
            // 
            this.BtnAniWalk.BackColor = System.Drawing.SystemColors.Control;
            this.BtnAniWalk.BackgroundImage = global::DevPackMine.Properties.Resources.search;
            this.BtnAniWalk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAniWalk.FlatAppearance.BorderSize = 0;
            this.BtnAniWalk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAniWalk.Location = new System.Drawing.Point(210, 52);
            this.BtnAniWalk.Name = "BtnAniWalk";
            this.BtnAniWalk.Size = new System.Drawing.Size(20, 20);
            this.BtnAniWalk.TabIndex = 64;
            this.BtnAniWalk.UseVisualStyleBackColor = true;
            this.BtnAniWalk.Click += new System.EventHandler(this.AniFind);
            // 
            // BtnAniIdle
            // 
            this.BtnAniIdle.BackColor = System.Drawing.SystemColors.Control;
            this.BtnAniIdle.BackgroundImage = global::DevPackMine.Properties.Resources.search;
            this.BtnAniIdle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAniIdle.FlatAppearance.BorderSize = 0;
            this.BtnAniIdle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAniIdle.Location = new System.Drawing.Point(210, 24);
            this.BtnAniIdle.Name = "BtnAniIdle";
            this.BtnAniIdle.Size = new System.Drawing.Size(20, 20);
            this.BtnAniIdle.TabIndex = 63;
            this.BtnAniIdle.UseVisualStyleBackColor = true;
            this.BtnAniIdle.Click += new System.EventHandler(this.AniFind);
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(8, 210);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(50, 13);
            this.label60.TabIndex = 62;
            this.label60.Text = "Attack 2:";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(8, 184);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(36, 13);
            this.label59.TabIndex = 61;
            this.label59.Text = "Idle 2:";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(8, 158);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(30, 13);
            this.label58.TabIndex = 60;
            this.label58.Text = "Run:";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(8, 132);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(26, 13);
            this.label57.TabIndex = 59;
            this.label57.Text = "Die:";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(8, 106);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(41, 13);
            this.label56.TabIndex = 58;
            this.label56.Text = "Attack:";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(8, 81);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(50, 13);
            this.label55.TabIndex = 57;
            this.label55.Text = "Damage:";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(8, 55);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(35, 13);
            this.label54.TabIndex = 56;
            this.label54.Text = "Walk:";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(8, 28);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(27, 13);
            this.label53.TabIndex = 40;
            this.label53.Text = "Idle:";
            // 
            // textBox97
            // 
            this.textBox97.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox97.Location = new System.Drawing.Point(60, 207);
            this.textBox97.Name = "textBox97";
            this.textBox97.Size = new System.Drawing.Size(144, 20);
            this.textBox97.TabIndex = 55;
            // 
            // textBox96
            // 
            this.textBox96.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox96.Location = new System.Drawing.Point(60, 181);
            this.textBox96.Name = "textBox96";
            this.textBox96.Size = new System.Drawing.Size(144, 20);
            this.textBox96.TabIndex = 54;
            // 
            // textBox95
            // 
            this.textBox95.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox95.Location = new System.Drawing.Point(60, 155);
            this.textBox95.Name = "textBox95";
            this.textBox95.Size = new System.Drawing.Size(144, 20);
            this.textBox95.TabIndex = 53;
            // 
            // textBox94
            // 
            this.textBox94.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox94.Location = new System.Drawing.Point(60, 129);
            this.textBox94.Name = "textBox94";
            this.textBox94.Size = new System.Drawing.Size(144, 20);
            this.textBox94.TabIndex = 52;
            // 
            // textBox93
            // 
            this.textBox93.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox93.Location = new System.Drawing.Point(60, 103);
            this.textBox93.Name = "textBox93";
            this.textBox93.Size = new System.Drawing.Size(144, 20);
            this.textBox93.TabIndex = 51;
            // 
            // textBox92
            // 
            this.textBox92.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox92.Location = new System.Drawing.Point(60, 77);
            this.textBox92.Name = "textBox92";
            this.textBox92.Size = new System.Drawing.Size(144, 20);
            this.textBox92.TabIndex = 50;
            // 
            // textBox91
            // 
            this.textBox91.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox91.Location = new System.Drawing.Point(60, 25);
            this.textBox91.Name = "textBox91";
            this.textBox91.Size = new System.Drawing.Size(144, 20);
            this.textBox91.TabIndex = 49;
            // 
            // textBox90
            // 
            this.textBox90.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox90.Location = new System.Drawing.Point(60, 51);
            this.textBox90.Name = "textBox90";
            this.textBox90.Size = new System.Drawing.Size(144, 20);
            this.textBox90.TabIndex = 48;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 553);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "State Flag:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 582);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Family:";
            // 
            // textBox6
            // 
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox6.Location = new System.Drawing.Point(81, 576);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(64, 20);
            this.textBox6.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnReadSmc);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.pictureBox23);
            this.groupBox1.Controls.Add(this.textBox98);
            this.groupBox1.Controls.Add(this.label61);
            this.groupBox1.Controls.Add(this.label52);
            this.groupBox1.Controls.Add(this.textBox89);
            this.groupBox1.Controls.Add(this.textBox30);
            this.groupBox1.Controls.Add(this.label30);
            this.groupBox1.Controls.Add(this.textBox9);
            this.groupBox1.Controls.Add(this.textBox29);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label31);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label37);
            this.groupBox1.Controls.Add(this.textBox8);
            this.groupBox1.Controls.Add(this.label32);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBox36);
            this.groupBox1.Controls.Add(this.label33);
            this.groupBox1.Controls.Add(this.label36);
            this.groupBox1.Controls.Add(this.textBox32);
            this.groupBox1.Controls.Add(this.textBox35);
            this.groupBox1.Controls.Add(this.textBox31);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.textBox16);
            this.groupBox1.Controls.Add(this.textBox14);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(7, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(751, 182);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Basic";
            // 
            // BtnReadSmc
            // 
            this.BtnReadSmc.BackColor = System.Drawing.SystemColors.Control;
            this.BtnReadSmc.BackgroundImage = global::DevPackMine.Properties.Resources.search;
            this.BtnReadSmc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnReadSmc.FlatAppearance.BorderSize = 0;
            this.BtnReadSmc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReadSmc.Location = new System.Drawing.Point(728, 137);
            this.BtnReadSmc.Name = "BtnReadSmc";
            this.BtnReadSmc.Size = new System.Drawing.Size(20, 20);
            this.BtnReadSmc.TabIndex = 71;
            this.BtnReadSmc.UseVisualStyleBackColor = true;
            this.BtnReadSmc.Click += new System.EventHandler(this.BtnReadSmc_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::DevPackMine.Properties.Resources.Flag;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(561, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(19, 24);
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "a";
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox23
            // 
            this.pictureBox23.BackgroundImage = global::DevPackMine.Properties.Resources.Flag;
            this.pictureBox23.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox23.Location = new System.Drawing.Point(561, 46);
            this.pictureBox23.Name = "pictureBox23";
            this.pictureBox23.Size = new System.Drawing.Size(19, 24);
            this.pictureBox23.TabIndex = 42;
            this.pictureBox23.TabStop = false;
            this.pictureBox23.Tag = "a";
            this.pictureBox23.Click += new System.EventHandler(this.pictureBox23_Click);
            // 
            // textBox98
            // 
            this.textBox98.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox98.Location = new System.Drawing.Point(491, 105);
            this.textBox98.Name = "textBox98";
            this.textBox98.Size = new System.Drawing.Size(64, 20);
            this.textBox98.TabIndex = 41;
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(426, 109);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(37, 13);
            this.label61.TabIndex = 40;
            this.label61.Text = "Scale:";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(425, 141);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(33, 13);
            this.label52.TabIndex = 39;
            this.label52.Text = "SMC:";
            // 
            // textBox89
            // 
            this.textBox89.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox89.Location = new System.Drawing.Point(464, 137);
            this.textBox89.Name = "textBox89";
            this.textBox89.Size = new System.Drawing.Size(263, 20);
            this.textBox89.TabIndex = 38;
            // 
            // textBox30
            // 
            this.textBox30.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox30.Location = new System.Drawing.Point(612, 18);
            this.textBox30.Name = "textBox30";
            this.textBox30.Size = new System.Drawing.Size(64, 20);
            this.textBox30.TabIndex = 25;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(424, 22);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(25, 13);
            this.label30.TabIndex = 24;
            this.label30.Text = "HP:";
            // 
            // textBox9
            // 
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox9.Location = new System.Drawing.Point(491, 77);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(64, 20);
            this.textBox9.TabIndex = 12;
            // 
            // textBox29
            // 
            this.textBox29.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox29.Location = new System.Drawing.Point(491, 18);
            this.textBox29.Name = "textBox29";
            this.textBox29.Size = new System.Drawing.Size(64, 20);
            this.textBox29.TabIndex = 23;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(82, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(49, 20);
            this.textBox1.TabIndex = 36;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(424, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Flag 2:";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(580, 22);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(26, 13);
            this.label31.TabIndex = 26;
            this.label31.Text = "MP:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "ID:";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(161, 117);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(67, 13);
            this.label37.TabIndex = 26;
            this.label37.Text = "Run  Speed:";
            // 
            // textBox8
            // 
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox8.Location = new System.Drawing.Point(491, 48);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(64, 20);
            this.textBox8.TabIndex = 11;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(7, 88);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(75, 13);
            this.label32.TabIndex = 24;
            this.label32.Text = "Attack Speed:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(424, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Flag 1:";
            // 
            // textBox36
            // 
            this.textBox36.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox36.Location = new System.Drawing.Point(234, 113);
            this.textBox36.Name = "textBox36";
            this.textBox36.Size = new System.Drawing.Size(55, 20);
            this.textBox36.TabIndex = 25;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(7, 145);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(68, 13);
            this.label33.TabIndex = 27;
            this.label33.Text = "Attack Type:";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(7, 117);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(69, 13);
            this.label36.TabIndex = 24;
            this.label36.Text = "Walk Speed:";
            // 
            // textBox32
            // 
            this.textBox32.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox32.Location = new System.Drawing.Point(82, 85);
            this.textBox32.Name = "textBox32";
            this.textBox32.Size = new System.Drawing.Size(49, 20);
            this.textBox32.TabIndex = 23;
            // 
            // textBox35
            // 
            this.textBox35.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox35.Location = new System.Drawing.Point(82, 113);
            this.textBox35.Name = "textBox35";
            this.textBox35.Size = new System.Drawing.Size(49, 20);
            this.textBox35.TabIndex = 23;
            // 
            // textBox31
            // 
            this.textBox31.Location = new System.Drawing.Point(51, 162);
            this.textBox31.Name = "textBox31";
            this.textBox31.Size = new System.Drawing.Size(21, 20);
            this.textBox31.TabIndex = 23;
            this.textBox31.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "0 - Melee",
            "1 - Ranged",
            "2 - Magic",
            "3 - None"});
            this.comboBox1.Location = new System.Drawing.Point(82, 141);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(73, 21);
            this.comboBox1.TabIndex = 24;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(161, 88);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(66, 13);
            this.label17.TabIndex = 24;
            this.label17.Text = "Attack Area:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(578, 109);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(30, 13);
            this.label15.TabIndex = 23;
            this.label15.Text = "Size:";
            // 
            // textBox16
            // 
            this.textBox16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox16.Location = new System.Drawing.Point(234, 85);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(55, 20);
            this.textBox16.TabIndex = 23;
            // 
            // textBox14
            // 
            this.textBox14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox14.Location = new System.Drawing.Point(612, 105);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(64, 20);
            this.textBox14.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(161, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Skill Master:";
            // 
            // textBox7
            // 
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox7.Location = new System.Drawing.Point(234, 140);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(55, 20);
            this.textBox7.TabIndex = 18;
            // 
            // textBox5
            // 
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox5.Location = new System.Drawing.Point(234, 56);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(55, 20);
            this.textBox5.TabIndex = 16;
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Location = new System.Drawing.Point(82, 20);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(207, 20);
            this.textBox3.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(161, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Level:";
            // 
            // textBox10
            // 
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox10.Location = new System.Drawing.Point(80, 550);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(64, 20);
            this.textBox10.TabIndex = 16;
            // 
            // tabPage2
            // 
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Controls.Add(this.groupBox16);
            this.tabPage2.Controls.Add(this.groupBox12);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox10);
            this.tabPage2.Controls.Add(this.groupBox9);
            this.tabPage2.Controls.Add(this.groupBox8);
            this.tabPage2.Controls.Add(this.groupBox7);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(774, 610);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Strength";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label16);
            this.groupBox6.Controls.Add(this.textBox15);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.textBox13);
            this.groupBox6.Location = new System.Drawing.Point(6, 360);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(200, 89);
            this.groupBox6.TabIndex = 61;
            this.groupBox6.TabStop = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 27);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 13);
            this.label16.TabIndex = 24;
            this.label16.Text = "Move Area:";
            // 
            // textBox15
            // 
            this.textBox15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox15.Location = new System.Drawing.Point(80, 22);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(91, 20);
            this.textBox15.TabIndex = 23;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 55);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 13);
            this.label14.TabIndex = 22;
            this.label14.Text = "Sight:";
            // 
            // textBox13
            // 
            this.textBox13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox13.Location = new System.Drawing.Point(80, 53);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(91, 20);
            this.textBox13.TabIndex = 21;
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.textBox115);
            this.groupBox16.Controls.Add(this.label78);
            this.groupBox16.Controls.Add(this.label77);
            this.groupBox16.Controls.Add(this.textBox114);
            this.groupBox16.Controls.Add(this.label76);
            this.groupBox16.Controls.Add(this.textBox113);
            this.groupBox16.Controls.Add(this.label75);
            this.groupBox16.Controls.Add(this.textBox112);
            this.groupBox16.Controls.Add(this.label74);
            this.groupBox16.Controls.Add(this.textBox111);
            this.groupBox16.Controls.Add(this.label73);
            this.groupBox16.Controls.Add(this.textBox110);
            this.groupBox16.Controls.Add(this.comboBox2);
            this.groupBox16.Location = new System.Drawing.Point(212, 252);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(242, 200);
            this.groupBox16.TabIndex = 60;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "Al";
            // 
            // textBox115
            // 
            this.textBox115.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox115.Location = new System.Drawing.Point(82, 160);
            this.textBox115.Name = "textBox115";
            this.textBox115.Size = new System.Drawing.Size(136, 20);
            this.textBox115.TabIndex = 68;
            // 
            // label78
            // 
            this.label78.AutoSize = true;
            this.label78.Location = new System.Drawing.Point(5, 164);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(74, 13);
            this.label78.TabIndex = 67;
            this.label78.Text = "Leader Count:";
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.label77.Location = new System.Drawing.Point(5, 138);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(64, 13);
            this.label77.TabIndex = 66;
            this.label77.Text = "Leader IDX:";
            // 
            // textBox114
            // 
            this.textBox114.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox114.Location = new System.Drawing.Point(82, 134);
            this.textBox114.Name = "textBox114";
            this.textBox114.Size = new System.Drawing.Size(136, 20);
            this.textBox114.TabIndex = 65;
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.Location = new System.Drawing.Point(5, 112);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(66, 13);
            this.label76.TabIndex = 64;
            this.label76.Text = "Summon HP";
            // 
            // textBox113
            // 
            this.textBox113.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox113.Location = new System.Drawing.Point(82, 108);
            this.textBox113.Name = "textBox113";
            this.textBox113.Size = new System.Drawing.Size(136, 20);
            this.textBox113.TabIndex = 63;
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.Location = new System.Drawing.Point(5, 86);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(66, 13);
            this.label75.TabIndex = 62;
            this.label75.Text = "Leader Flag:";
            // 
            // textBox112
            // 
            this.textBox112.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox112.Location = new System.Drawing.Point(82, 82);
            this.textBox112.Name = "textBox112";
            this.textBox112.Size = new System.Drawing.Size(136, 20);
            this.textBox112.TabIndex = 61;
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.Location = new System.Drawing.Point(5, 63);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(30, 13);
            this.label74.TabIndex = 60;
            this.label74.Text = "Flag:";
            // 
            // textBox111
            // 
            this.textBox111.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox111.Location = new System.Drawing.Point(82, 56);
            this.textBox111.Name = "textBox111";
            this.textBox111.Size = new System.Drawing.Size(136, 20);
            this.textBox111.TabIndex = 41;
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.Location = new System.Drawing.Point(5, 33);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(43, 13);
            this.label73.TabIndex = 1;
            this.label73.Text = "Al Type";
            // 
            // textBox110
            // 
            this.textBox110.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox110.Location = new System.Drawing.Point(222, 28);
            this.textBox110.Name = "textBox110";
            this.textBox110.Size = new System.Drawing.Size(14, 20);
            this.textBox110.TabIndex = 59;
            this.textBox110.Visible = false;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "0 - NPC Normal",
            "1 - NPC Tanker",
            "2 - NPC Damage Dealer",
            "3 - NPC Healer"});
            this.comboBox2.Location = new System.Drawing.Point(59, 29);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(159, 21);
            this.comboBox2.TabIndex = 0;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.label51);
            this.groupBox12.Controls.Add(this.label50);
            this.groupBox12.Controls.Add(this.label49);
            this.groupBox12.Controls.Add(this.label48);
            this.groupBox12.Controls.Add(this.label47);
            this.groupBox12.Controls.Add(this.textBox88);
            this.groupBox12.Controls.Add(this.textBox84);
            this.groupBox12.Controls.Add(this.textBox87);
            this.groupBox12.Controls.Add(this.textBox85);
            this.groupBox12.Controls.Add(this.textBox86);
            this.groupBox12.Location = new System.Drawing.Point(6, 158);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(200, 193);
            this.groupBox12.TabIndex = 45;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Product";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(5, 166);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(56, 13);
            this.label51.TabIndex = 32;
            this.label51.Text = "Product 5:";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(5, 132);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(56, 13);
            this.label50.TabIndex = 31;
            this.label50.Text = "Product 4:";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(5, 98);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(56, 13);
            this.label49.TabIndex = 30;
            this.label49.Text = "Product 3:";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(5, 64);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(56, 13);
            this.label48.TabIndex = 29;
            this.label48.Text = "Product 1:";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(5, 30);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(56, 13);
            this.label47.TabIndex = 28;
            this.label47.Text = "Product 0:";
            // 
            // textBox88
            // 
            this.textBox88.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox88.Location = new System.Drawing.Point(76, 162);
            this.textBox88.Name = "textBox88";
            this.textBox88.Size = new System.Drawing.Size(64, 20);
            this.textBox88.TabIndex = 27;
            // 
            // textBox84
            // 
            this.textBox84.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox84.Location = new System.Drawing.Point(76, 26);
            this.textBox84.Name = "textBox84";
            this.textBox84.Size = new System.Drawing.Size(64, 20);
            this.textBox84.TabIndex = 23;
            // 
            // textBox87
            // 
            this.textBox87.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox87.Location = new System.Drawing.Point(76, 128);
            this.textBox87.Name = "textBox87";
            this.textBox87.Size = new System.Drawing.Size(64, 20);
            this.textBox87.TabIndex = 26;
            // 
            // textBox85
            // 
            this.textBox85.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox85.Location = new System.Drawing.Point(76, 60);
            this.textBox85.Name = "textBox85";
            this.textBox85.Size = new System.Drawing.Size(64, 20);
            this.textBox85.TabIndex = 24;
            // 
            // textBox86
            // 
            this.textBox86.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox86.Location = new System.Drawing.Point(76, 94);
            this.textBox86.Name = "textBox86";
            this.textBox86.Size = new System.Drawing.Size(64, 20);
            this.textBox86.TabIndex = 25;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.label41);
            this.groupBox2.Controls.Add(this.label40);
            this.groupBox2.Controls.Add(this.label39);
            this.groupBox2.Controls.Add(this.label38);
            this.groupBox2.Controls.Add(this.textBox40);
            this.groupBox2.Controls.Add(this.textBox37);
            this.groupBox2.Controls.Add(this.textBox39);
            this.groupBox2.Controls.Add(this.textBox38);
            this.groupBox2.Location = new System.Drawing.Point(2, 462);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 144);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Skills";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(10, 107);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(30, 13);
            this.label41.TabIndex = 47;
            this.label41.Text = "ID 3:";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(10, 81);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(30, 13);
            this.label40.TabIndex = 46;
            this.label40.Text = "ID 2:";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(10, 57);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(30, 13);
            this.label39.TabIndex = 45;
            this.label39.Text = "ID 1:";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(10, 30);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(30, 13);
            this.label38.TabIndex = 44;
            this.label38.Text = "ID 0:";
            // 
            // textBox40
            // 
            this.textBox40.Location = new System.Drawing.Point(56, 104);
            this.textBox40.Name = "textBox40";
            this.textBox40.Size = new System.Drawing.Size(138, 20);
            this.textBox40.TabIndex = 43;
            // 
            // textBox37
            // 
            this.textBox37.Location = new System.Drawing.Point(56, 27);
            this.textBox37.Name = "textBox37";
            this.textBox37.Size = new System.Drawing.Size(138, 20);
            this.textBox37.TabIndex = 40;
            // 
            // textBox39
            // 
            this.textBox39.Location = new System.Drawing.Point(56, 78);
            this.textBox39.Name = "textBox39";
            this.textBox39.Size = new System.Drawing.Size(138, 20);
            this.textBox39.TabIndex = 42;
            // 
            // textBox38
            // 
            this.textBox38.Location = new System.Drawing.Point(56, 52);
            this.textBox38.Name = "textBox38";
            this.textBox38.Size = new System.Drawing.Size(138, 20);
            this.textBox38.TabIndex = 41;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.textBox34);
            this.groupBox10.Controls.Add(this.label35);
            this.groupBox10.Controls.Add(this.textBox33);
            this.groupBox10.Controls.Add(this.label34);
            this.groupBox10.Location = new System.Drawing.Point(458, 256);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(157, 100);
            this.groupBox10.TabIndex = 39;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Recover HP,MP per second";
            // 
            // textBox34
            // 
            this.textBox34.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox34.Location = new System.Drawing.Point(39, 59);
            this.textBox34.Name = "textBox34";
            this.textBox34.Size = new System.Drawing.Size(100, 20);
            this.textBox34.TabIndex = 37;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(9, 65);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(26, 13);
            this.label35.TabIndex = 38;
            this.label35.Text = "MP:";
            // 
            // textBox33
            // 
            this.textBox33.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox33.Location = new System.Drawing.Point(39, 33);
            this.textBox33.Name = "textBox33";
            this.textBox33.Size = new System.Drawing.Size(100, 20);
            this.textBox33.TabIndex = 35;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(9, 38);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(25, 13);
            this.label34.TabIndex = 36;
            this.label34.Text = "HP:";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.label84);
            this.groupBox9.Controls.Add(this.textBox121);
            this.groupBox9.Controls.Add(this.label83);
            this.groupBox9.Controls.Add(this.textBox120);
            this.groupBox9.Controls.Add(this.label82);
            this.groupBox9.Controls.Add(this.textBox119);
            this.groupBox9.Controls.Add(this.label29);
            this.groupBox9.Controls.Add(this.textBox28);
            this.groupBox9.Controls.Add(this.label27);
            this.groupBox9.Controls.Add(this.label26);
            this.groupBox9.Controls.Add(this.textBox25);
            this.groupBox9.Controls.Add(this.textBox26);
            this.groupBox9.Location = new System.Drawing.Point(212, 6);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(200, 243);
            this.groupBox9.TabIndex = 34;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Defense";
            // 
            // label84
            // 
            this.label84.AutoSize = true;
            this.label84.Location = new System.Drawing.Point(8, 179);
            this.label84.Name = "label84";
            this.label84.Size = new System.Drawing.Size(69, 13);
            this.label84.TabIndex = 68;
            this.label84.Text = "Job Attribute:";
            // 
            // textBox121
            // 
            this.textBox121.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox121.Location = new System.Drawing.Point(80, 175);
            this.textBox121.Name = "textBox121";
            this.textBox121.Size = new System.Drawing.Size(100, 20);
            this.textBox121.TabIndex = 67;
            // 
            // label83
            // 
            this.label83.AutoSize = true;
            this.label83.Location = new System.Drawing.Point(8, 148);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(66, 13);
            this.label83.TabIndex = 66;
            this.label83.Text = "Magic Avoid";
            // 
            // textBox120
            // 
            this.textBox120.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox120.Location = new System.Drawing.Point(80, 144);
            this.textBox120.Name = "textBox120";
            this.textBox120.Size = new System.Drawing.Size(100, 20);
            this.textBox120.TabIndex = 65;
            // 
            // label82
            // 
            this.label82.AutoSize = true;
            this.label82.Location = new System.Drawing.Point(11, 117);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(42, 13);
            this.label82.TabIndex = 64;
            this.label82.Text = "Ddoge:";
            // 
            // textBox119
            // 
            this.textBox119.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox119.Location = new System.Drawing.Point(80, 113);
            this.textBox119.Name = "textBox119";
            this.textBox119.Size = new System.Drawing.Size(100, 20);
            this.textBox119.TabIndex = 63;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(11, 26);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(36, 13);
            this.label29.TabIndex = 40;
            this.label29.Text = "Level:";
            // 
            // textBox28
            // 
            this.textBox28.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox28.Location = new System.Drawing.Point(80, 22);
            this.textBox28.Name = "textBox28";
            this.textBox28.Size = new System.Drawing.Size(75, 20);
            this.textBox28.TabIndex = 37;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(11, 86);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(63, 13);
            this.label27.TabIndex = 38;
            this.label27.Text = "Resistence:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(11, 55);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(50, 13);
            this.label26.TabIndex = 37;
            this.label26.Text = "Defense:";
            // 
            // textBox25
            // 
            this.textBox25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox25.Location = new System.Drawing.Point(80, 51);
            this.textBox25.Name = "textBox25";
            this.textBox25.Size = new System.Drawing.Size(100, 20);
            this.textBox25.TabIndex = 35;
            // 
            // textBox26
            // 
            this.textBox26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox26.Location = new System.Drawing.Point(80, 82);
            this.textBox26.Name = "textBox26";
            this.textBox26.Size = new System.Drawing.Size(100, 20);
            this.textBox26.TabIndex = 36;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label81);
            this.groupBox8.Controls.Add(this.textBox118);
            this.groupBox8.Controls.Add(this.label28);
            this.groupBox8.Controls.Add(this.textBox27);
            this.groupBox8.Controls.Add(this.textBox24);
            this.groupBox8.Controls.Add(this.label25);
            this.groupBox8.Controls.Add(this.textBox23);
            this.groupBox8.Controls.Add(this.label24);
            this.groupBox8.Location = new System.Drawing.Point(6, 6);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(200, 149);
            this.groupBox8.TabIndex = 33;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Attack";
            // 
            // label81
            // 
            this.label81.AutoSize = true;
            this.label81.Location = new System.Drawing.Point(13, 117);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(23, 13);
            this.label81.TabIndex = 62;
            this.label81.Text = "Hit:";
            // 
            // textBox118
            // 
            this.textBox118.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox118.Location = new System.Drawing.Point(55, 113);
            this.textBox118.Name = "textBox118";
            this.textBox118.Size = new System.Drawing.Size(100, 20);
            this.textBox118.TabIndex = 61;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(13, 26);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(36, 13);
            this.label28.TabIndex = 39;
            this.label28.Text = "Level:";
            // 
            // textBox27
            // 
            this.textBox27.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox27.Location = new System.Drawing.Point(55, 22);
            this.textBox27.Name = "textBox27";
            this.textBox27.Size = new System.Drawing.Size(75, 20);
            this.textBox27.TabIndex = 35;
            // 
            // textBox24
            // 
            this.textBox24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox24.Location = new System.Drawing.Point(55, 82);
            this.textBox24.Name = "textBox24";
            this.textBox24.Size = new System.Drawing.Size(100, 20);
            this.textBox24.TabIndex = 24;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(8, 86);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(39, 13);
            this.label25.TabIndex = 28;
            this.label25.Text = "Magic:";
            // 
            // textBox23
            // 
            this.textBox23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox23.Location = new System.Drawing.Point(55, 51);
            this.textBox23.Name = "textBox23";
            this.textBox23.Size = new System.Drawing.Size(100, 20);
            this.textBox23.TabIndex = 23;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(8, 55);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(41, 13);
            this.label24.TabIndex = 25;
            this.label24.Text = "Attack:";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.textBox22);
            this.groupBox7.Controls.Add(this.label23);
            this.groupBox7.Controls.Add(this.textBox19);
            this.groupBox7.Controls.Add(this.label22);
            this.groupBox7.Controls.Add(this.textBox20);
            this.groupBox7.Controls.Add(this.label21);
            this.groupBox7.Controls.Add(this.textBox21);
            this.groupBox7.Controls.Add(this.label20);
            this.groupBox7.Location = new System.Drawing.Point(415, 6);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(169, 243);
            this.groupBox7.TabIndex = 32;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "StatPoints";
            // 
            // textBox22
            // 
            this.textBox22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox22.Location = new System.Drawing.Point(88, 112);
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new System.Drawing.Size(61, 20);
            this.textBox22.TabIndex = 26;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(19, 116);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(65, 13);
            this.label23.TabIndex = 30;
            this.label23.Text = "Constitution:";
            // 
            // textBox19
            // 
            this.textBox19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox19.Location = new System.Drawing.Point(88, 22);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(61, 20);
            this.textBox19.TabIndex = 23;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(18, 86);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(64, 13);
            this.label22.TabIndex = 29;
            this.label22.Text = "Intelligence:";
            // 
            // textBox20
            // 
            this.textBox20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox20.Location = new System.Drawing.Point(88, 52);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(61, 20);
            this.textBox20.TabIndex = 24;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(19, 56);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(51, 13);
            this.label21.TabIndex = 28;
            this.label21.Text = "Dexterity:";
            // 
            // textBox21
            // 
            this.textBox21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox21.Location = new System.Drawing.Point(88, 82);
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(61, 20);
            this.textBox21.TabIndex = 25;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(19, 26);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(50, 13);
            this.label20.TabIndex = 27;
            this.label20.Text = "Strenght:";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage4.Controls.Add(this.textBox60);
            this.tabPage4.Controls.Add(this.textBox53);
            this.tabPage4.Controls.Add(this.textBox80);
            this.tabPage4.Controls.Add(this.textBox52);
            this.tabPage4.Controls.Add(this.textBox79);
            this.tabPage4.Controls.Add(this.textBox51);
            this.tabPage4.Controls.Add(this.textBox50);
            this.tabPage4.Controls.Add(this.textBox54);
            this.tabPage4.Controls.Add(this.textBox78);
            this.tabPage4.Controls.Add(this.textBox55);
            this.tabPage4.Controls.Add(this.textBox61);
            this.tabPage4.Controls.Add(this.textBox56);
            this.tabPage4.Controls.Add(this.textBox41);
            this.tabPage4.Controls.Add(this.textBox57);
            this.tabPage4.Controls.Add(this.textBox77);
            this.tabPage4.Controls.Add(this.textBox59);
            this.tabPage4.Controls.Add(this.groupBox18);
            this.tabPage4.Controls.Add(this.textBox58);
            this.tabPage4.Controls.Add(this.textBox42);
            this.tabPage4.Controls.Add(this.textBox76);
            this.tabPage4.Controls.Add(this.textBox43);
            this.tabPage4.Controls.Add(this.groupBox4);
            this.tabPage4.Controls.Add(this.textBox75);
            this.tabPage4.Controls.Add(this.textBox44);
            this.tabPage4.Controls.Add(this.groupBox11);
            this.tabPage4.Controls.Add(this.textBox45);
            this.tabPage4.Controls.Add(this.textBox74);
            this.tabPage4.Controls.Add(this.textBox70);
            this.tabPage4.Controls.Add(this.textBox46);
            this.tabPage4.Controls.Add(this.textBox73);
            this.tabPage4.Controls.Add(this.textBox47);
            this.tabPage4.Controls.Add(this.textBox69);
            this.tabPage4.Controls.Add(this.textBox71);
            this.tabPage4.Controls.Add(this.textBox48);
            this.tabPage4.Controls.Add(this.textBox66);
            this.tabPage4.Controls.Add(this.textBox49);
            this.tabPage4.Controls.Add(this.textBox72);
            this.tabPage4.Controls.Add(this.textBox63);
            this.tabPage4.Controls.Add(this.textBox64);
            this.tabPage4.Controls.Add(this.textBox67);
            this.tabPage4.Controls.Add(this.textBox68);
            this.tabPage4.Controls.Add(this.textBox62);
            this.tabPage4.Controls.Add(this.textBox65);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(774, 610);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Drop List";
            // 
            // textBox60
            // 
            this.textBox60.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox60.Location = new System.Drawing.Point(586, 569);
            this.textBox60.Name = "textBox60";
            this.textBox60.Size = new System.Drawing.Size(29, 20);
            this.textBox60.TabIndex = 73;
            this.textBox60.Visible = false;
            // 
            // textBox53
            // 
            this.textBox53.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox53.Location = new System.Drawing.Point(586, 368);
            this.textBox53.Name = "textBox53";
            this.textBox53.Size = new System.Drawing.Size(29, 20);
            this.textBox53.TabIndex = 66;
            this.textBox53.Visible = false;
            // 
            // textBox80
            // 
            this.textBox80.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox80.Location = new System.Drawing.Point(485, 570);
            this.textBox80.Name = "textBox80";
            this.textBox80.Size = new System.Drawing.Size(39, 20);
            this.textBox80.TabIndex = 95;
            this.textBox80.Visible = false;
            // 
            // textBox52
            // 
            this.textBox52.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox52.Location = new System.Drawing.Point(587, 340);
            this.textBox52.Name = "textBox52";
            this.textBox52.Size = new System.Drawing.Size(28, 20);
            this.textBox52.TabIndex = 65;
            this.textBox52.Visible = false;
            // 
            // textBox79
            // 
            this.textBox79.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox79.Location = new System.Drawing.Point(485, 540);
            this.textBox79.Name = "textBox79";
            this.textBox79.Size = new System.Drawing.Size(39, 20);
            this.textBox79.TabIndex = 94;
            this.textBox79.Visible = false;
            // 
            // textBox51
            // 
            this.textBox51.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox51.Location = new System.Drawing.Point(587, 313);
            this.textBox51.Name = "textBox51";
            this.textBox51.Size = new System.Drawing.Size(28, 20);
            this.textBox51.TabIndex = 64;
            this.textBox51.Visible = false;
            // 
            // textBox50
            // 
            this.textBox50.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox50.Location = new System.Drawing.Point(545, 569);
            this.textBox50.Name = "textBox50";
            this.textBox50.Size = new System.Drawing.Size(35, 20);
            this.textBox50.TabIndex = 63;
            this.textBox50.Visible = false;
            // 
            // textBox54
            // 
            this.textBox54.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox54.Location = new System.Drawing.Point(586, 397);
            this.textBox54.Name = "textBox54";
            this.textBox54.Size = new System.Drawing.Size(29, 20);
            this.textBox54.TabIndex = 67;
            this.textBox54.Visible = false;
            // 
            // textBox78
            // 
            this.textBox78.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox78.Location = new System.Drawing.Point(485, 512);
            this.textBox78.Name = "textBox78";
            this.textBox78.Size = new System.Drawing.Size(39, 20);
            this.textBox78.TabIndex = 93;
            this.textBox78.Visible = false;
            // 
            // textBox55
            // 
            this.textBox55.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox55.Location = new System.Drawing.Point(586, 426);
            this.textBox55.Name = "textBox55";
            this.textBox55.Size = new System.Drawing.Size(29, 20);
            this.textBox55.TabIndex = 68;
            this.textBox55.Visible = false;
            // 
            // textBox61
            // 
            this.textBox61.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox61.Location = new System.Drawing.Point(431, 311);
            this.textBox61.Name = "textBox61";
            this.textBox61.Size = new System.Drawing.Size(45, 20);
            this.textBox61.TabIndex = 75;
            this.textBox61.Visible = false;
            // 
            // textBox56
            // 
            this.textBox56.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox56.Location = new System.Drawing.Point(586, 454);
            this.textBox56.Name = "textBox56";
            this.textBox56.Size = new System.Drawing.Size(29, 20);
            this.textBox56.TabIndex = 69;
            this.textBox56.Visible = false;
            // 
            // textBox41
            // 
            this.textBox41.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox41.Location = new System.Drawing.Point(545, 313);
            this.textBox41.Name = "textBox41";
            this.textBox41.Size = new System.Drawing.Size(35, 20);
            this.textBox41.TabIndex = 54;
            this.textBox41.Visible = false;
            // 
            // textBox57
            // 
            this.textBox57.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox57.Location = new System.Drawing.Point(586, 483);
            this.textBox57.Name = "textBox57";
            this.textBox57.Size = new System.Drawing.Size(29, 20);
            this.textBox57.TabIndex = 70;
            this.textBox57.Visible = false;
            // 
            // textBox77
            // 
            this.textBox77.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox77.Location = new System.Drawing.Point(485, 483);
            this.textBox77.Name = "textBox77";
            this.textBox77.Size = new System.Drawing.Size(39, 20);
            this.textBox77.TabIndex = 92;
            this.textBox77.Visible = false;
            // 
            // textBox59
            // 
            this.textBox59.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox59.Location = new System.Drawing.Point(586, 541);
            this.textBox59.Name = "textBox59";
            this.textBox59.Size = new System.Drawing.Size(29, 20);
            this.textBox59.TabIndex = 72;
            this.textBox59.Visible = false;
            // 
            // groupBox18
            // 
            this.groupBox18.Controls.Add(this.dataGridView1);
            this.groupBox18.Location = new System.Drawing.Point(6, 6);
            this.groupBox18.Name = "groupBox18";
            this.groupBox18.Size = new System.Drawing.Size(410, 598);
            this.groupBox18.TabIndex = 100;
            this.groupBox18.TabStop = false;
            this.groupBox18.Text = "Drop Items";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 32;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(404, 579);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowLeave);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.Width = 32;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ID";
            this.Column2.Name = "Column2";
            this.Column2.Width = 50;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Name";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 200;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Droprate";
            this.Column4.Name = "Column4";
            this.Column4.Width = 110;
            // 
            // textBox58
            // 
            this.textBox58.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox58.Location = new System.Drawing.Point(586, 513);
            this.textBox58.Name = "textBox58";
            this.textBox58.Size = new System.Drawing.Size(29, 20);
            this.textBox58.TabIndex = 71;
            this.textBox58.Visible = false;
            // 
            // textBox42
            // 
            this.textBox42.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox42.Location = new System.Drawing.Point(545, 339);
            this.textBox42.Name = "textBox42";
            this.textBox42.Size = new System.Drawing.Size(35, 20);
            this.textBox42.TabIndex = 55;
            this.textBox42.Visible = false;
            // 
            // textBox76
            // 
            this.textBox76.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox76.Location = new System.Drawing.Point(485, 454);
            this.textBox76.Name = "textBox76";
            this.textBox76.Size = new System.Drawing.Size(39, 20);
            this.textBox76.TabIndex = 91;
            this.textBox76.Visible = false;
            // 
            // textBox43
            // 
            this.textBox43.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox43.Location = new System.Drawing.Point(545, 368);
            this.textBox43.Name = "textBox43";
            this.textBox43.Size = new System.Drawing.Size(35, 20);
            this.textBox43.TabIndex = 56;
            this.textBox43.Visible = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.textBox11);
            this.groupBox4.Controls.Add(this.textBox17);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.textBox12);
            this.groupBox4.Location = new System.Drawing.Point(422, 29);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(195, 138);
            this.groupBox4.TabIndex = 99;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Prize";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(8, 60);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(56, 13);
            this.label18.TabIndex = 25;
            this.label18.Text = "Skill Point:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 87);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "Gold Coin:";
            // 
            // textBox11
            // 
            this.textBox11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox11.Location = new System.Drawing.Point(83, 28);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(100, 20);
            this.textBox11.TabIndex = 16;
            // 
            // textBox17
            // 
            this.textBox17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox17.Location = new System.Drawing.Point(83, 55);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(100, 20);
            this.textBox17.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Experience:";
            // 
            // textBox12
            // 
            this.textBox12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox12.Location = new System.Drawing.Point(83, 82);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(100, 20);
            this.textBox12.TabIndex = 17;
            // 
            // textBox75
            // 
            this.textBox75.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox75.Location = new System.Drawing.Point(485, 425);
            this.textBox75.Name = "textBox75";
            this.textBox75.Size = new System.Drawing.Size(39, 20);
            this.textBox75.TabIndex = 90;
            this.textBox75.Visible = false;
            // 
            // textBox44
            // 
            this.textBox44.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox44.Location = new System.Drawing.Point(545, 397);
            this.textBox44.Name = "textBox44";
            this.textBox44.Size = new System.Drawing.Size(35, 20);
            this.textBox44.TabIndex = 57;
            this.textBox44.Visible = false;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.label46);
            this.groupBox11.Controls.Add(this.label45);
            this.groupBox11.Controls.Add(this.label44);
            this.groupBox11.Controls.Add(this.textBox83);
            this.groupBox11.Controls.Add(this.textBox82);
            this.groupBox11.Controls.Add(this.textBox81);
            this.groupBox11.Location = new System.Drawing.Point(422, 176);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(195, 117);
            this.groupBox11.TabIndex = 98;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Drops";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(13, 81);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(55, 13);
            this.label46.TabIndex = 101;
            this.label46.Text = "Prob Plus:";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(13, 54);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(53, 13);
            this.label45.TabIndex = 100;
            this.label45.Text = "Max Plus:";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(13, 28);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(50, 13);
            this.label44.TabIndex = 99;
            this.label44.Text = "Min Plus:";
            // 
            // textBox83
            // 
            this.textBox83.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox83.Location = new System.Drawing.Point(70, 77);
            this.textBox83.Name = "textBox83";
            this.textBox83.Size = new System.Drawing.Size(100, 20);
            this.textBox83.TabIndex = 98;
            // 
            // textBox82
            // 
            this.textBox82.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox82.Location = new System.Drawing.Point(70, 51);
            this.textBox82.Name = "textBox82";
            this.textBox82.Size = new System.Drawing.Size(100, 20);
            this.textBox82.TabIndex = 97;
            // 
            // textBox81
            // 
            this.textBox81.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox81.Location = new System.Drawing.Point(70, 25);
            this.textBox81.Name = "textBox81";
            this.textBox81.Size = new System.Drawing.Size(100, 20);
            this.textBox81.TabIndex = 96;
            // 
            // textBox45
            // 
            this.textBox45.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox45.Location = new System.Drawing.Point(545, 426);
            this.textBox45.Name = "textBox45";
            this.textBox45.Size = new System.Drawing.Size(35, 20);
            this.textBox45.TabIndex = 58;
            this.textBox45.Visible = false;
            // 
            // textBox74
            // 
            this.textBox74.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox74.Location = new System.Drawing.Point(485, 397);
            this.textBox74.Name = "textBox74";
            this.textBox74.Size = new System.Drawing.Size(39, 20);
            this.textBox74.TabIndex = 89;
            this.textBox74.Visible = false;
            // 
            // textBox70
            // 
            this.textBox70.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox70.Location = new System.Drawing.Point(431, 571);
            this.textBox70.Name = "textBox70";
            this.textBox70.Size = new System.Drawing.Size(45, 20);
            this.textBox70.TabIndex = 84;
            this.textBox70.Visible = false;
            // 
            // textBox46
            // 
            this.textBox46.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox46.Location = new System.Drawing.Point(545, 455);
            this.textBox46.Name = "textBox46";
            this.textBox46.Size = new System.Drawing.Size(35, 20);
            this.textBox46.TabIndex = 59;
            this.textBox46.Visible = false;
            // 
            // textBox73
            // 
            this.textBox73.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox73.Location = new System.Drawing.Point(485, 368);
            this.textBox73.Name = "textBox73";
            this.textBox73.Size = new System.Drawing.Size(39, 20);
            this.textBox73.TabIndex = 87;
            this.textBox73.Visible = false;
            // 
            // textBox47
            // 
            this.textBox47.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox47.Location = new System.Drawing.Point(545, 484);
            this.textBox47.Name = "textBox47";
            this.textBox47.Size = new System.Drawing.Size(35, 20);
            this.textBox47.TabIndex = 60;
            this.textBox47.Visible = false;
            // 
            // textBox69
            // 
            this.textBox69.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox69.Location = new System.Drawing.Point(431, 542);
            this.textBox69.Name = "textBox69";
            this.textBox69.Size = new System.Drawing.Size(45, 20);
            this.textBox69.TabIndex = 83;
            this.textBox69.Visible = false;
            // 
            // textBox71
            // 
            this.textBox71.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox71.Location = new System.Drawing.Point(485, 310);
            this.textBox71.Name = "textBox71";
            this.textBox71.Size = new System.Drawing.Size(39, 20);
            this.textBox71.TabIndex = 85;
            this.textBox71.Visible = false;
            // 
            // textBox48
            // 
            this.textBox48.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox48.Location = new System.Drawing.Point(545, 513);
            this.textBox48.Name = "textBox48";
            this.textBox48.Size = new System.Drawing.Size(35, 20);
            this.textBox48.TabIndex = 61;
            this.textBox48.Visible = false;
            // 
            // textBox66
            // 
            this.textBox66.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox66.Location = new System.Drawing.Point(431, 455);
            this.textBox66.Name = "textBox66";
            this.textBox66.Size = new System.Drawing.Size(45, 20);
            this.textBox66.TabIndex = 80;
            this.textBox66.Visible = false;
            // 
            // textBox49
            // 
            this.textBox49.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox49.Location = new System.Drawing.Point(545, 542);
            this.textBox49.Name = "textBox49";
            this.textBox49.Size = new System.Drawing.Size(35, 20);
            this.textBox49.TabIndex = 62;
            this.textBox49.Visible = false;
            // 
            // textBox72
            // 
            this.textBox72.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox72.Location = new System.Drawing.Point(485, 340);
            this.textBox72.Name = "textBox72";
            this.textBox72.Size = new System.Drawing.Size(39, 20);
            this.textBox72.TabIndex = 86;
            this.textBox72.Visible = false;
            // 
            // textBox63
            // 
            this.textBox63.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox63.Location = new System.Drawing.Point(431, 368);
            this.textBox63.Name = "textBox63";
            this.textBox63.Size = new System.Drawing.Size(45, 20);
            this.textBox63.TabIndex = 77;
            this.textBox63.Visible = false;
            // 
            // textBox64
            // 
            this.textBox64.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox64.Location = new System.Drawing.Point(431, 397);
            this.textBox64.Name = "textBox64";
            this.textBox64.Size = new System.Drawing.Size(45, 20);
            this.textBox64.TabIndex = 78;
            this.textBox64.Visible = false;
            // 
            // textBox67
            // 
            this.textBox67.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox67.Location = new System.Drawing.Point(431, 484);
            this.textBox67.Name = "textBox67";
            this.textBox67.Size = new System.Drawing.Size(45, 20);
            this.textBox67.TabIndex = 81;
            this.textBox67.Visible = false;
            // 
            // textBox68
            // 
            this.textBox68.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox68.Location = new System.Drawing.Point(431, 513);
            this.textBox68.Name = "textBox68";
            this.textBox68.Size = new System.Drawing.Size(45, 20);
            this.textBox68.TabIndex = 82;
            this.textBox68.Visible = false;
            // 
            // textBox62
            // 
            this.textBox62.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox62.Location = new System.Drawing.Point(431, 340);
            this.textBox62.Name = "textBox62";
            this.textBox62.Size = new System.Drawing.Size(45, 20);
            this.textBox62.TabIndex = 76;
            this.textBox62.Visible = false;
            // 
            // textBox65
            // 
            this.textBox65.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox65.Location = new System.Drawing.Point(431, 426);
            this.textBox65.Name = "textBox65";
            this.textBox65.Size = new System.Drawing.Size(45, 20);
            this.textBox65.TabIndex = 79;
            this.textBox65.Visible = false;
            // 
            // tabPage7
            // 
            this.tabPage7.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage7.Controls.Add(this.groupBox19);
            this.tabPage7.Controls.Add(this.textBox170);
            this.tabPage7.Controls.Add(this.textBox169);
            this.tabPage7.Controls.Add(this.textBox168);
            this.tabPage7.Controls.Add(this.textBox167);
            this.tabPage7.Controls.Add(this.textBox166);
            this.tabPage7.Controls.Add(this.textBox165);
            this.tabPage7.Controls.Add(this.textBox164);
            this.tabPage7.Controls.Add(this.textBox163);
            this.tabPage7.Controls.Add(this.textBox162);
            this.tabPage7.Controls.Add(this.textBox161);
            this.tabPage7.Controls.Add(this.textBox160);
            this.tabPage7.Controls.Add(this.textBox159);
            this.tabPage7.Controls.Add(this.textBox158);
            this.tabPage7.Controls.Add(this.textBox157);
            this.tabPage7.Controls.Add(this.textBox156);
            this.tabPage7.Controls.Add(this.textBox155);
            this.tabPage7.Controls.Add(this.textBox154);
            this.tabPage7.Controls.Add(this.textBox153);
            this.tabPage7.Controls.Add(this.textBox152);
            this.tabPage7.Controls.Add(this.textBox151);
            this.tabPage7.Controls.Add(this.textBox150);
            this.tabPage7.Controls.Add(this.textBox149);
            this.tabPage7.Controls.Add(this.textBox148);
            this.tabPage7.Controls.Add(this.textBox147);
            this.tabPage7.Controls.Add(this.textBox146);
            this.tabPage7.Controls.Add(this.textBox145);
            this.tabPage7.Controls.Add(this.textBox144);
            this.tabPage7.Controls.Add(this.textBox143);
            this.tabPage7.Controls.Add(this.textBox142);
            this.tabPage7.Controls.Add(this.textBox141);
            this.tabPage7.Controls.Add(this.textBox140);
            this.tabPage7.Controls.Add(this.textBox139);
            this.tabPage7.Controls.Add(this.textBox138);
            this.tabPage7.Controls.Add(this.textBox137);
            this.tabPage7.Controls.Add(this.textBox136);
            this.tabPage7.Controls.Add(this.textBox135);
            this.tabPage7.Controls.Add(this.textBox134);
            this.tabPage7.Controls.Add(this.textBox133);
            this.tabPage7.Controls.Add(this.textBox132);
            this.tabPage7.Controls.Add(this.textBox131);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(774, 610);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Jewels Drop";
            // 
            // groupBox19
            // 
            this.groupBox19.Controls.Add(this.dataGridView2);
            this.groupBox19.Location = new System.Drawing.Point(6, 6);
            this.groupBox19.Name = "groupBox19";
            this.groupBox19.Size = new System.Drawing.Size(410, 598);
            this.groupBox19.TabIndex = 80;
            this.groupBox19.TabStop = false;
            this.groupBox19.Text = "Jewels Drop";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.Location = new System.Drawing.Point(3, 16);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowTemplate.Height = 32;
            this.dataGridView2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView2.Size = new System.Drawing.Size(404, 579);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dataGridView2.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellEndEdit_1);
            // 
            // Column5
            // 
            this.Column5.HeaderText = "";
            this.Column5.Name = "Column5";
            this.Column5.Width = 32;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "ID";
            this.Column6.Name = "Column6";
            this.Column6.Width = 50;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Name";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 200;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Droprate";
            this.Column8.Name = "Column8";
            this.Column8.Width = 110;
            // 
            // textBox170
            // 
            this.textBox170.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox170.Location = new System.Drawing.Point(581, 569);
            this.textBox170.Name = "textBox170";
            this.textBox170.Size = new System.Drawing.Size(29, 20);
            this.textBox170.TabIndex = 79;
            this.textBox170.Visible = false;
            // 
            // textBox169
            // 
            this.textBox169.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox169.Location = new System.Drawing.Point(581, 543);
            this.textBox169.Name = "textBox169";
            this.textBox169.Size = new System.Drawing.Size(29, 20);
            this.textBox169.TabIndex = 78;
            this.textBox169.Visible = false;
            // 
            // textBox168
            // 
            this.textBox168.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox168.Location = new System.Drawing.Point(581, 517);
            this.textBox168.Name = "textBox168";
            this.textBox168.Size = new System.Drawing.Size(29, 20);
            this.textBox168.TabIndex = 77;
            this.textBox168.Visible = false;
            // 
            // textBox167
            // 
            this.textBox167.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox167.Location = new System.Drawing.Point(581, 491);
            this.textBox167.Name = "textBox167";
            this.textBox167.Size = new System.Drawing.Size(29, 20);
            this.textBox167.TabIndex = 76;
            this.textBox167.Visible = false;
            // 
            // textBox166
            // 
            this.textBox166.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox166.Location = new System.Drawing.Point(581, 465);
            this.textBox166.Name = "textBox166";
            this.textBox166.Size = new System.Drawing.Size(29, 20);
            this.textBox166.TabIndex = 75;
            this.textBox166.Visible = false;
            // 
            // textBox165
            // 
            this.textBox165.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox165.Location = new System.Drawing.Point(581, 439);
            this.textBox165.Name = "textBox165";
            this.textBox165.Size = new System.Drawing.Size(29, 20);
            this.textBox165.TabIndex = 74;
            this.textBox165.Visible = false;
            // 
            // textBox164
            // 
            this.textBox164.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox164.Location = new System.Drawing.Point(581, 413);
            this.textBox164.Name = "textBox164";
            this.textBox164.Size = new System.Drawing.Size(29, 20);
            this.textBox164.TabIndex = 73;
            this.textBox164.Visible = false;
            // 
            // textBox163
            // 
            this.textBox163.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox163.Location = new System.Drawing.Point(581, 385);
            this.textBox163.Name = "textBox163";
            this.textBox163.Size = new System.Drawing.Size(29, 20);
            this.textBox163.TabIndex = 72;
            this.textBox163.Visible = false;
            // 
            // textBox162
            // 
            this.textBox162.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox162.Location = new System.Drawing.Point(581, 359);
            this.textBox162.Name = "textBox162";
            this.textBox162.Size = new System.Drawing.Size(29, 20);
            this.textBox162.TabIndex = 71;
            this.textBox162.Visible = false;
            // 
            // textBox161
            // 
            this.textBox161.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox161.Location = new System.Drawing.Point(581, 333);
            this.textBox161.Name = "textBox161";
            this.textBox161.Size = new System.Drawing.Size(29, 20);
            this.textBox161.TabIndex = 70;
            this.textBox161.Visible = false;
            // 
            // textBox160
            // 
            this.textBox160.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox160.Location = new System.Drawing.Point(546, 569);
            this.textBox160.Name = "textBox160";
            this.textBox160.Size = new System.Drawing.Size(29, 20);
            this.textBox160.TabIndex = 69;
            this.textBox160.Visible = false;
            // 
            // textBox159
            // 
            this.textBox159.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox159.Location = new System.Drawing.Point(546, 542);
            this.textBox159.Name = "textBox159";
            this.textBox159.Size = new System.Drawing.Size(29, 20);
            this.textBox159.TabIndex = 68;
            this.textBox159.Visible = false;
            // 
            // textBox158
            // 
            this.textBox158.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox158.Location = new System.Drawing.Point(546, 516);
            this.textBox158.Name = "textBox158";
            this.textBox158.Size = new System.Drawing.Size(29, 20);
            this.textBox158.TabIndex = 67;
            this.textBox158.Visible = false;
            // 
            // textBox157
            // 
            this.textBox157.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox157.Location = new System.Drawing.Point(546, 486);
            this.textBox157.Name = "textBox157";
            this.textBox157.Size = new System.Drawing.Size(29, 20);
            this.textBox157.TabIndex = 66;
            this.textBox157.Visible = false;
            // 
            // textBox156
            // 
            this.textBox156.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox156.Location = new System.Drawing.Point(546, 460);
            this.textBox156.Name = "textBox156";
            this.textBox156.Size = new System.Drawing.Size(29, 20);
            this.textBox156.TabIndex = 65;
            this.textBox156.Visible = false;
            // 
            // textBox155
            // 
            this.textBox155.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox155.Location = new System.Drawing.Point(546, 434);
            this.textBox155.Name = "textBox155";
            this.textBox155.Size = new System.Drawing.Size(29, 20);
            this.textBox155.TabIndex = 64;
            this.textBox155.Visible = false;
            // 
            // textBox154
            // 
            this.textBox154.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox154.Location = new System.Drawing.Point(546, 407);
            this.textBox154.Name = "textBox154";
            this.textBox154.Size = new System.Drawing.Size(29, 20);
            this.textBox154.TabIndex = 63;
            this.textBox154.Visible = false;
            // 
            // textBox153
            // 
            this.textBox153.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox153.Location = new System.Drawing.Point(546, 381);
            this.textBox153.Name = "textBox153";
            this.textBox153.Size = new System.Drawing.Size(29, 20);
            this.textBox153.TabIndex = 62;
            this.textBox153.Visible = false;
            // 
            // textBox152
            // 
            this.textBox152.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox152.Location = new System.Drawing.Point(546, 354);
            this.textBox152.Name = "textBox152";
            this.textBox152.Size = new System.Drawing.Size(29, 20);
            this.textBox152.TabIndex = 61;
            this.textBox152.Visible = false;
            // 
            // textBox151
            // 
            this.textBox151.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox151.Location = new System.Drawing.Point(546, 329);
            this.textBox151.Name = "textBox151";
            this.textBox151.Size = new System.Drawing.Size(29, 20);
            this.textBox151.TabIndex = 60;
            this.textBox151.Visible = false;
            // 
            // textBox150
            // 
            this.textBox150.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox150.Location = new System.Drawing.Point(581, 239);
            this.textBox150.Name = "textBox150";
            this.textBox150.Size = new System.Drawing.Size(24, 20);
            this.textBox150.TabIndex = 39;
            this.textBox150.Visible = false;
            // 
            // textBox149
            // 
            this.textBox149.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox149.Location = new System.Drawing.Point(581, 213);
            this.textBox149.Name = "textBox149";
            this.textBox149.Size = new System.Drawing.Size(24, 20);
            this.textBox149.TabIndex = 38;
            this.textBox149.Visible = false;
            // 
            // textBox148
            // 
            this.textBox148.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox148.Location = new System.Drawing.Point(581, 187);
            this.textBox148.Name = "textBox148";
            this.textBox148.Size = new System.Drawing.Size(24, 20);
            this.textBox148.TabIndex = 37;
            this.textBox148.Visible = false;
            // 
            // textBox147
            // 
            this.textBox147.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox147.Location = new System.Drawing.Point(581, 161);
            this.textBox147.Name = "textBox147";
            this.textBox147.Size = new System.Drawing.Size(24, 20);
            this.textBox147.TabIndex = 36;
            this.textBox147.Visible = false;
            // 
            // textBox146
            // 
            this.textBox146.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox146.Location = new System.Drawing.Point(581, 135);
            this.textBox146.Name = "textBox146";
            this.textBox146.Size = new System.Drawing.Size(24, 20);
            this.textBox146.TabIndex = 35;
            this.textBox146.Visible = false;
            // 
            // textBox145
            // 
            this.textBox145.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox145.Location = new System.Drawing.Point(581, 109);
            this.textBox145.Name = "textBox145";
            this.textBox145.Size = new System.Drawing.Size(24, 20);
            this.textBox145.TabIndex = 34;
            this.textBox145.Visible = false;
            // 
            // textBox144
            // 
            this.textBox144.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox144.Location = new System.Drawing.Point(581, 83);
            this.textBox144.Name = "textBox144";
            this.textBox144.Size = new System.Drawing.Size(24, 20);
            this.textBox144.TabIndex = 33;
            this.textBox144.Visible = false;
            // 
            // textBox143
            // 
            this.textBox143.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox143.Location = new System.Drawing.Point(581, 57);
            this.textBox143.Name = "textBox143";
            this.textBox143.Size = new System.Drawing.Size(24, 20);
            this.textBox143.TabIndex = 32;
            this.textBox143.Visible = false;
            // 
            // textBox142
            // 
            this.textBox142.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox142.Location = new System.Drawing.Point(581, 31);
            this.textBox142.Name = "textBox142";
            this.textBox142.Size = new System.Drawing.Size(24, 20);
            this.textBox142.TabIndex = 31;
            this.textBox142.Visible = false;
            // 
            // textBox141
            // 
            this.textBox141.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox141.Location = new System.Drawing.Point(581, 5);
            this.textBox141.Name = "textBox141";
            this.textBox141.Size = new System.Drawing.Size(24, 20);
            this.textBox141.TabIndex = 21;
            this.textBox141.Visible = false;
            // 
            // textBox140
            // 
            this.textBox140.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox140.Location = new System.Drawing.Point(551, 239);
            this.textBox140.Name = "textBox140";
            this.textBox140.Size = new System.Drawing.Size(24, 20);
            this.textBox140.TabIndex = 20;
            this.textBox140.Visible = false;
            // 
            // textBox139
            // 
            this.textBox139.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox139.Location = new System.Drawing.Point(551, 213);
            this.textBox139.Name = "textBox139";
            this.textBox139.Size = new System.Drawing.Size(24, 20);
            this.textBox139.TabIndex = 19;
            this.textBox139.Visible = false;
            // 
            // textBox138
            // 
            this.textBox138.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox138.Location = new System.Drawing.Point(551, 187);
            this.textBox138.Name = "textBox138";
            this.textBox138.Size = new System.Drawing.Size(24, 20);
            this.textBox138.TabIndex = 18;
            this.textBox138.Visible = false;
            // 
            // textBox137
            // 
            this.textBox137.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox137.Location = new System.Drawing.Point(551, 161);
            this.textBox137.Name = "textBox137";
            this.textBox137.Size = new System.Drawing.Size(24, 20);
            this.textBox137.TabIndex = 17;
            this.textBox137.Visible = false;
            // 
            // textBox136
            // 
            this.textBox136.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox136.Location = new System.Drawing.Point(551, 135);
            this.textBox136.Name = "textBox136";
            this.textBox136.Size = new System.Drawing.Size(24, 20);
            this.textBox136.TabIndex = 16;
            this.textBox136.Visible = false;
            // 
            // textBox135
            // 
            this.textBox135.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox135.Location = new System.Drawing.Point(551, 109);
            this.textBox135.Name = "textBox135";
            this.textBox135.Size = new System.Drawing.Size(24, 20);
            this.textBox135.TabIndex = 15;
            this.textBox135.Visible = false;
            // 
            // textBox134
            // 
            this.textBox134.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox134.Location = new System.Drawing.Point(551, 83);
            this.textBox134.Name = "textBox134";
            this.textBox134.Size = new System.Drawing.Size(24, 20);
            this.textBox134.TabIndex = 14;
            this.textBox134.Visible = false;
            // 
            // textBox133
            // 
            this.textBox133.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox133.Location = new System.Drawing.Point(551, 57);
            this.textBox133.Name = "textBox133";
            this.textBox133.Size = new System.Drawing.Size(24, 20);
            this.textBox133.TabIndex = 13;
            this.textBox133.Visible = false;
            // 
            // textBox132
            // 
            this.textBox132.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox132.Location = new System.Drawing.Point(551, 31);
            this.textBox132.Name = "textBox132";
            this.textBox132.Size = new System.Drawing.Size(24, 20);
            this.textBox132.TabIndex = 12;
            this.textBox132.Visible = false;
            // 
            // textBox131
            // 
            this.textBox131.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox131.Location = new System.Drawing.Point(551, 4);
            this.textBox131.Name = "textBox131";
            this.textBox131.Size = new System.Drawing.Size(24, 20);
            this.textBox131.TabIndex = 11;
            this.textBox131.Visible = false;
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage6.Controls.Add(this.label62);
            this.tabPage6.Controls.Add(this.textBox99);
            this.tabPage6.Controls.Add(this.label19);
            this.tabPage6.Controls.Add(this.textBox18);
            this.tabPage6.Controls.Add(this.textBox176);
            this.tabPage6.Controls.Add(this.label139);
            this.tabPage6.Controls.Add(this.textBox175);
            this.tabPage6.Controls.Add(this.label138);
            this.tabPage6.Controls.Add(this.textBox172);
            this.tabPage6.Controls.Add(this.label135);
            this.tabPage6.Controls.Add(this.textBox171);
            this.tabPage6.Controls.Add(this.label134);
            this.tabPage6.Controls.Add(this.label93);
            this.tabPage6.Controls.Add(this.textBox130);
            this.tabPage6.Controls.Add(this.label92);
            this.tabPage6.Controls.Add(this.textBox129);
            this.tabPage6.Controls.Add(this.label91);
            this.tabPage6.Controls.Add(this.textBox128);
            this.tabPage6.Controls.Add(this.label90);
            this.tabPage6.Controls.Add(this.textBox127);
            this.tabPage6.Controls.Add(this.label89);
            this.tabPage6.Controls.Add(this.textBox126);
            this.tabPage6.Controls.Add(this.label88);
            this.tabPage6.Controls.Add(this.textBox125);
            this.tabPage6.Controls.Add(this.textBox124);
            this.tabPage6.Controls.Add(this.label87);
            this.tabPage6.Controls.Add(this.label86);
            this.tabPage6.Controls.Add(this.label85);
            this.tabPage6.Controls.Add(this.textBox123);
            this.tabPage6.Controls.Add(this.textBox122);
            this.tabPage6.Controls.Add(this.label80);
            this.tabPage6.Controls.Add(this.label79);
            this.tabPage6.Controls.Add(this.textBox117);
            this.tabPage6.Controls.Add(this.textBox116);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(774, 610);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "No Idea";
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Location = new System.Drawing.Point(391, 528);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(60, 13);
            this.label62.TabIndex = 100;
            this.label62.Text = "a_attribute:";
            // 
            // textBox99
            // 
            this.textBox99.BackColor = System.Drawing.Color.Red;
            this.textBox99.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox99.Location = new System.Drawing.Point(472, 526);
            this.textBox99.Name = "textBox99";
            this.textBox99.Size = new System.Drawing.Size(100, 20);
            this.textBox99.TabIndex = 99;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(391, 568);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(75, 13);
            this.label19.TabIndex = 98;
            this.label19.Text = "a_sskillmaster:";
            // 
            // textBox18
            // 
            this.textBox18.BackColor = System.Drawing.Color.Red;
            this.textBox18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox18.Location = new System.Drawing.Point(472, 561);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(100, 20);
            this.textBox18.TabIndex = 97;
            // 
            // textBox176
            // 
            this.textBox176.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox176.Location = new System.Drawing.Point(82, 437);
            this.textBox176.Name = "textBox176";
            this.textBox176.Size = new System.Drawing.Size(80, 20);
            this.textBox176.TabIndex = 96;
            // 
            // label139
            // 
            this.label139.AutoSize = true;
            this.label139.Location = new System.Drawing.Point(16, 439);
            this.label139.Name = "label139";
            this.label139.Size = new System.Drawing.Size(57, 13);
            this.label139.TabIndex = 95;
            this.label139.Text = "a_life_time";
            // 
            // textBox175
            // 
            this.textBox175.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox175.Location = new System.Drawing.Point(82, 395);
            this.textBox175.Name = "textBox175";
            this.textBox175.Size = new System.Drawing.Size(80, 20);
            this.textBox175.TabIndex = 94;
            // 
            // label138
            // 
            this.label138.AutoSize = true;
            this.label138.Location = new System.Drawing.Point(27, 397);
            this.label138.Name = "label138";
            this.label138.Size = new System.Drawing.Size(49, 13);
            this.label138.TabIndex = 93;
            this.label138.Text = "a_bound";
            // 
            // textBox172
            // 
            this.textBox172.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox172.Location = new System.Drawing.Point(123, 320);
            this.textBox172.Name = "textBox172";
            this.textBox172.Size = new System.Drawing.Size(80, 20);
            this.textBox172.TabIndex = 92;
            // 
            // label135
            // 
            this.label135.AutoSize = true;
            this.label135.Location = new System.Drawing.Point(16, 327);
            this.label135.Name = "label135";
            this.label135.Size = new System.Drawing.Size(65, 13);
            this.label135.TabIndex = 91;
            this.label135.Text = "a_extra_flag";
            // 
            // textBox171
            // 
            this.textBox171.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox171.Location = new System.Drawing.Point(123, 281);
            this.textBox171.Name = "textBox171";
            this.textBox171.Size = new System.Drawing.Size(80, 20);
            this.textBox171.TabIndex = 90;
            // 
            // label134
            // 
            this.label134.AutoSize = true;
            this.label134.Location = new System.Drawing.Point(16, 288);
            this.label134.Name = "label134";
            this.label134.Size = new System.Drawing.Size(65, 13);
            this.label134.TabIndex = 89;
            this.label134.Text = "a_zone_flag";
            // 
            // label93
            // 
            this.label93.AutoSize = true;
            this.label93.Location = new System.Drawing.Point(16, 195);
            this.label93.Name = "label93";
            this.label93.Size = new System.Drawing.Size(84, 13);
            this.label93.TabIndex = 88;
            this.label93.Text = "a_socketprob_3";
            // 
            // textBox130
            // 
            this.textBox130.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox130.Location = new System.Drawing.Point(123, 188);
            this.textBox130.Name = "textBox130";
            this.textBox130.Size = new System.Drawing.Size(80, 20);
            this.textBox130.TabIndex = 87;
            // 
            // label92
            // 
            this.label92.AutoSize = true;
            this.label92.Location = new System.Drawing.Point(16, 163);
            this.label92.Name = "label92";
            this.label92.Size = new System.Drawing.Size(84, 13);
            this.label92.TabIndex = 86;
            this.label92.Text = "a_socketprob_2";
            // 
            // textBox129
            // 
            this.textBox129.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox129.Location = new System.Drawing.Point(123, 156);
            this.textBox129.Name = "textBox129";
            this.textBox129.Size = new System.Drawing.Size(80, 20);
            this.textBox129.TabIndex = 85;
            // 
            // label91
            // 
            this.label91.AutoSize = true;
            this.label91.Location = new System.Drawing.Point(16, 132);
            this.label91.Name = "label91";
            this.label91.Size = new System.Drawing.Size(84, 13);
            this.label91.TabIndex = 84;
            this.label91.Text = "a_socketprob_1";
            // 
            // textBox128
            // 
            this.textBox128.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox128.Location = new System.Drawing.Point(123, 125);
            this.textBox128.Name = "textBox128";
            this.textBox128.Size = new System.Drawing.Size(80, 20);
            this.textBox128.TabIndex = 83;
            // 
            // label90
            // 
            this.label90.AutoSize = true;
            this.label90.Location = new System.Drawing.Point(16, 103);
            this.label90.Name = "label90";
            this.label90.Size = new System.Drawing.Size(84, 13);
            this.label90.TabIndex = 82;
            this.label90.Text = "a_socketprob_0";
            // 
            // textBox127
            // 
            this.textBox127.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox127.Location = new System.Drawing.Point(123, 96);
            this.textBox127.Name = "textBox127";
            this.textBox127.Size = new System.Drawing.Size(80, 20);
            this.textBox127.TabIndex = 81;
            // 
            // label89
            // 
            this.label89.AutoSize = true;
            this.label89.Location = new System.Drawing.Point(16, 72);
            this.label89.Name = "label89";
            this.label89.Size = new System.Drawing.Size(73, 13);
            this.label89.TabIndex = 80;
            this.label89.Text = "a_createprob:";
            // 
            // textBox126
            // 
            this.textBox126.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox126.Location = new System.Drawing.Point(123, 70);
            this.textBox126.Name = "textBox126";
            this.textBox126.Size = new System.Drawing.Size(80, 20);
            this.textBox126.TabIndex = 79;
            // 
            // label88
            // 
            this.label88.AutoSize = true;
            this.label88.Location = new System.Drawing.Point(365, 93);
            this.label88.Name = "label88";
            this.label88.Size = new System.Drawing.Size(109, 13);
            this.label88.TabIndex = 78;
            this.label88.Text = "a_npc_kill_trigger_ids";
            // 
            // textBox125
            // 
            this.textBox125.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox125.Location = new System.Drawing.Point(511, 90);
            this.textBox125.Name = "textBox125";
            this.textBox125.Size = new System.Drawing.Size(100, 20);
            this.textBox125.TabIndex = 77;
            // 
            // textBox124
            // 
            this.textBox124.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox124.Location = new System.Drawing.Point(511, 62);
            this.textBox124.Name = "textBox124";
            this.textBox124.Size = new System.Drawing.Size(100, 20);
            this.textBox124.TabIndex = 76;
            // 
            // label87
            // 
            this.label87.AutoSize = true;
            this.label87.Location = new System.Drawing.Point(365, 65);
            this.label87.Name = "label87";
            this.label87.Size = new System.Drawing.Size(123, 13);
            this.label87.TabIndex = 75;
            this.label87.Text = "a_npc_kill_trigger_count";
            // 
            // label86
            // 
            this.label86.AutoSize = true;
            this.label86.Location = new System.Drawing.Point(365, 41);
            this.label86.Name = "label86";
            this.label86.Size = new System.Drawing.Size(129, 13);
            this.label86.TabIndex = 74;
            this.label86.Text = "a_npc_choice_trigger_ids";
            // 
            // label85
            // 
            this.label85.AutoSize = true;
            this.label85.Location = new System.Drawing.Point(365, 17);
            this.label85.Name = "label85";
            this.label85.Size = new System.Drawing.Size(143, 13);
            this.label85.TabIndex = 73;
            this.label85.Text = "a_npc_choice_trigger_count";
            // 
            // textBox123
            // 
            this.textBox123.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox123.Location = new System.Drawing.Point(511, 36);
            this.textBox123.Name = "textBox123";
            this.textBox123.Size = new System.Drawing.Size(100, 20);
            this.textBox123.TabIndex = 72;
            // 
            // textBox122
            // 
            this.textBox122.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox122.Location = new System.Drawing.Point(511, 10);
            this.textBox122.Name = "textBox122";
            this.textBox122.Size = new System.Drawing.Size(100, 20);
            this.textBox122.TabIndex = 71;
            // 
            // label80
            // 
            this.label80.AutoSize = true;
            this.label80.Location = new System.Drawing.Point(16, 45);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(84, 13);
            this.label80.TabIndex = 46;
            this.label80.Text = "a_productIndex:";
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.Location = new System.Drawing.Point(16, 19);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(104, 13);
            this.label79.TabIndex = 45;
            this.label79.Text = "a_crafting_category:";
            // 
            // textBox117
            // 
            this.textBox117.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox117.Location = new System.Drawing.Point(123, 41);
            this.textBox117.Name = "textBox117";
            this.textBox117.Size = new System.Drawing.Size(80, 20);
            this.textBox117.TabIndex = 41;
            // 
            // textBox116
            // 
            this.textBox116.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox116.Location = new System.Drawing.Point(123, 15);
            this.textBox116.Name = "textBox116";
            this.textBox116.Size = new System.Drawing.Size(80, 20);
            this.textBox116.TabIndex = 40;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(774, 610);
            this.tabPage3.TabIndex = 7;
            this.tabPage3.Text = "Drop Raid";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(774, 610);
            this.tabPage5.TabIndex = 8;
            this.tabPage5.Text = "Drop All";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage8
            // 
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(774, 610);
            this.tabPage8.TabIndex = 9;
            this.tabPage8.Text = "Drop Job";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(961, 669);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 34;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Location = new System.Drawing.Point(783, 2);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(48, 19);
            this.textBox4.TabIndex = 18;
            this.textBox4.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(642, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Enable:";
            this.label2.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(691, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(44, 20);
            this.textBox2.TabIndex = 18;
            this.textBox2.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(742, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Descr:";
            this.label4.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label42.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.Location = new System.Drawing.Point(836, 3);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(153, 16);
            this.label42.TabIndex = 38;
            this.label42.Text = "Current Language is :";
            // 
            // lblLang
            // 
            this.lblLang.AutoSize = true;
            this.lblLang.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblLang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLang.ForeColor = System.Drawing.Color.Chartreuse;
            this.lblLang.Location = new System.Drawing.Point(992, 5);
            this.lblLang.Name = "lblLang";
            this.lblLang.Size = new System.Drawing.Size(0, 16);
            this.lblLang.TabIndex = 39;
            // 
            // MobEditor
            // 
            this.ClientSize = new System.Drawing.Size(1076, 704);
            this.Controls.Add(this.lblLang);
            this.Controls.Add(this.label42);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MobEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MobAll EP4";
            this.Load += new System.EventHandler(this.MobEditor_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox20.ResumeLayout(false);
            this.groupBox20.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slideLeftRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slideUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slideZoom)).EndInit();
            this.groupBox15.ResumeLayout(false);
            this.groupBox15.PerformLayout();
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            this.groupBox17.ResumeLayout(false);
            this.groupBox17.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox16.ResumeLayout(false);
            this.groupBox16.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.groupBox18.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.groupBox19.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

        private void BtnReadSmc_Click(object sender, EventArgs e)
        {
            string str = Path.GetDirectoryName(_ClientPath).Replace("Data", "").Replace("data", "") + "\\" + textBox89.Text;
            if (File.Exists(str))
                new TextEditor(str).Show();
            else
                new CustomMessage("File not found").Show();
        }

        private void massEditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MobMassEdit m = new MobMassEdit(); //dethunter12 add
            m.ShowDialog(); //dethunter12 add
        }

        private void exportMobAlllodToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string text1 = "npc";
            string text2 = "path_ship";
            string text3 = IconList.language.ToLower();
            Process.Start(new ProcessStartInfo()
            {
                FileName = "ExportLod.exe",
                Arguments = " -h " + Host + " -d " + Database + " -u " + User + " -p " + Password + " -k " + text2 + " -l " + text3 + " -t " + text1
            });
        }
    }
}
