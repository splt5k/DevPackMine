// Decompiled with JetBrains decompiler
// Type: DevPackMine.Tools.MemoryWorker.MobEditor
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
  public class MobEditor : Form
  {
    private IContainer components = (IContainer) null;
    private MenuStrip menuStrip1;
    private ToolStripMenuItem fileToolStripMenuItem;
    private ToolStripMenuItem importFromDatabaseToolStripMenuItem;
    private ToolStripMenuItem saveToolStripMenuItem;
    private ToolStripMenuItem exportToolStripMenuItem;
    private ToolStripMenuItem moballlodToolStripMenuItem;
    private ToolStripMenuItem strToolStripMenuItem;
    private ToolStripMenuItem extraToolStripMenuItem;
    private GroupBox groupBox1;
    private GroupBox groupBox2;
    private ListBox listBox1;
    private StatusStrip statusStrip1;
    private Button btnDelete;
    private Button btnCopy;
    private TextBox textBox1;
    private TabControl tabControl1;
    private TabPage tabPage1;
    private TabPage tabPage2;
    private Button btnSave;
    private GroupBox groupBox3;
    private Label label1;
    private TextBox txtIndex;
    private CheckBox checkBoxEnable;
    private TextBox txtName;
    private Label label2;
    private GroupBox groupBox4;
    private TextBox txtFamily;
    private TextBox txtskillmaster;
    private TextBox txtFlag;
    private TextBox txtFlag1;
    private Label label3;
    private Label label4;
    private Label label6;
    private Label label5;
    private GroupBox groupBox5;
    private TextBox txtStateFlag;
    private Label label7;
    private Label label9;
    private TextBox txtExp;
    private Label label8;
    private TextBox txtLevel;
    private Label label10;
    private TextBox txtGold;
    private Label label13;
    private TextBox txtSize;
    private Label label11;
    private TextBox txtSight;
    private Label label12;
    private TextBox txtSkillPoint;
    private Label label14;
    private Label label15;
    private TextBox txtAttackArea;
    private TextBox txtMoveArea;
    private Label label16;
    private Label label17;
    private TextBox txtRunSpeed;
    private TextBox txtWalkSpeed;
    private GroupBox groupBox6;
    private TabPage tabPage3;
    private TabPage tabPage4;
    private TabPage tabPage5;
    private Label label18;
    private Label label21;
    private Label label20;
    private Label label19;
    private Label label22;
    private TextBox txtAttack;
    private Label label23;
    private TextBox txtMagic;
    private Label label25;
    private TextBox txtResist;
    private Label label24;
    private TextBox txtDefense;
    private GroupBox groupBox7;
    private GroupBox groupBox8;
    private GroupBox groupBox9;
    private TextBox txtDefenseLevel;
    private TextBox txtAttackLevel;
    private Label label26;
    private Label label27;
    private TextBox txtMP;
    private Label label28;
    private Label label29;
    private TextBox txtHP;
    private GroupBox groupBox10;
    private Label label30;
    private Label label31;
    private TextBox txtRecoverHP;
    private TextBox txtRecoverMP;
    private GroupBox groupBox11;
    private Label label33;
    private TextBox txtSkill1;
    private Label label32;
    private TextBox txtSkill0;
    private Label label34;
    private TextBox txtSkill3;
    private Label label35;
    private TextBox txtSkill2;
    private TabPage tabPage6;
    private GroupBox groupBox12;
    private TextBox txtMagicAvoid;
    private TextBox txtHit;
    private Label label36;
    private Label label37;
    private TextBox txtJobAttribute;
    private Label label38;
    private Label label39;
    private TextBox txtDodge;
    private TabPage tabPage7;
    private GroupBox groupBox13;
    private TextBox txtAttackType;
    private Label label40;
    private TextBox txtAttackSpeed;
    private Label label41;
    private Label label42;
    private TextBox txtsskillmaster;
    private NumericUpDown txtStr;
    private NumericUpDown txtDex;
    private NumericUpDown txtInt;
    private NumericUpDown txtCon;
    private ToolStripProgressBar toolStripProgressBar1;
    private ToolStripStatusLabel toolStripStatusLabel1;
    private PictureBox pictureBox23;
    private PictureBox pictureBox1;

    public MobEditor()
    {
            InitializeComponent();
    }

    private void importFromDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
    {
      new LoadFromDatabase().tnpc_Import();
            MakeList();
            checkListEmpty();
    }

    public void MakeList()
    {
      List<string> stringList = new List<string>();
      List<tnpc> all = AllLists.tnpc_MenuData.FindAll((Predicate<tnpc>) (p => p.name.ToLower().Contains(textBox1.Text.ToLower())));
      for (int index = 0; index < all.Count<tnpc>(); ++index)
        stringList.Add(all[index].index.ToString() + " - " + all[index].name.ToString());
            listBox1.Items.Clear();
            listBox1.Items.AddRange((object[]) stringList.ToArray());
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      mySQL.SetConnection();
            checkListEmpty();
    }

    private void checkListEmpty()
    {
      if (AllLists.tnpc_MenuData.Count<tnpc>() == 0)
      {
                saveToolStripMenuItem.Enabled = false;
                tabControl1.Enabled = false;
      }
      else
      {
                saveToolStripMenuItem.Enabled = true;
                tabControl1.Enabled = true;
      }
    }

    private int GetID()
    {
      int result = -1;
      int.TryParse(listBox1.Text.Split(' ')[0], out result);
      return result;
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
      int NpcID = GetID();
      if (NpcID == -1)
        return;
      tnpc tnpc = AllLists.tnpc_MenuData.Find((Predicate<tnpc>) (p => p.index.Equals(NpcID)));
      tnpc.name = Convert.ToString(txtName.Text);
      tnpc.family = Convert.ToInt32(txtFamily.Text);
      tnpc.skillmaster = Convert.ToInt32(txtskillmaster.Text);
      tnpc.flag = Convert.ToInt32(txtFlag.Text);
      tnpc.flag1 = Convert.ToInt32(txtFlag1.Text);
      tnpc.stateflag = Convert.ToInt32(txtStateFlag.Text);
      tnpc.level = Convert.ToInt32(txtLevel.Text);
      tnpc.exp = Convert.ToInt32(txtExp.Text);
      tnpc.prize = Convert.ToInt32(txtGold.Text);
      tnpc.sight = Convert.ToInt32(txtSight.Text);
      tnpc.size = Convert.ToSingle(txtSize.Text);
      tnpc.movearea = Convert.ToInt32(txtMoveArea.Text);
      tnpc.attackarea = Convert.ToSingle(txtAttackArea.Text);
      tnpc.skillpoint = Convert.ToInt32(txtSkillPoint.Text);
      tnpc.sskillmaster = Convert.ToInt32(txtsskillmaster.Text);
      tnpc.str = Convert.ToInt32(txtStr.Value);
      tnpc.dex = Convert.ToInt32(txtDex.Value);
      tnpc.INT = Convert.ToInt32(txtInt.Value);
      tnpc.con = Convert.ToInt32(txtCon.Value);
      tnpc.attack = Convert.ToInt32(txtAttack.Text);
      tnpc.magic = Convert.ToInt32(txtMagic.Text);
      tnpc.defense = Convert.ToInt32(txtDefense.Text);
      tnpc.resist = Convert.ToInt32(txtResist.Text);
      tnpc.attacklevel = Convert.ToInt32(txtAttackLevel.Text);
      tnpc.defenselevel = Convert.ToInt32(txtDefenseLevel.Text);
      tnpc.hp = Convert.ToInt32(txtHP.Text);
      tnpc.mp = Convert.ToInt32(txtMP.Text);
      tnpc.attacktype = Convert.ToInt32(txtAttackType.Text);
      tnpc.attackspeed = Convert.ToInt32(txtAttackSpeed.Text);
      tnpc.recoverhp = Convert.ToInt32(txtRecoverHP.Text);
      tnpc.recovermp = Convert.ToInt32(txtRecoverMP.Text);
      tnpc.walkspeed = (float) Convert.ToInt32(txtWalkSpeed.Text);
      tnpc.runspeed = (float) Convert.ToInt32(txtRunSpeed.Text);
      tnpc.skill0 = Convert.ToString(txtSkill0.Text);
      tnpc.skill1 = Convert.ToString(txtSkill1.Text);
      tnpc.skill2 = Convert.ToString(txtSkill2.Text);
      tnpc.skill3 = Convert.ToString(txtSkill3.Text);
      tnpc.dodge = Convert.ToInt32(txtDodge.Text);
      tnpc.magicavoid = Convert.ToInt32(txtMagicAvoid.Text);
      tnpc.hit = Convert.ToInt32(txtHit.Text);
      tnpc.jobattribute = Convert.ToInt32(txtJobAttribute.Text);
    }

    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
      int NpcID = GetID();
      if (NpcID == -1)
        return;
      tnpc tnpc = AllLists.tnpc_MenuData.Find((Predicate<tnpc>) (p => p.index.Equals(NpcID)));
      if (tnpc == null)
        return;
            CheckParameter(tnpc.enable);
            txtIndex.Text = tnpc.index.ToString();
            txtName.Text = tnpc.name.ToString();
            checkBoxEnable.Checked = tnpc.enable == 1;
            txtFamily.Text = tnpc.family.ToString();
            txtskillmaster.Text = tnpc.skillmaster.ToString();
            txtFlag.Text = tnpc.flag.ToString();
            txtFlag1.Text = tnpc.flag1.ToString();
            txtStateFlag.Text = tnpc.stateflag.ToString();
            txtLevel.Text = tnpc.level.ToString();
            txtExp.Text = tnpc.exp.ToString();
            txtGold.Text = tnpc.prize.ToString();
            txtSight.Text = tnpc.sight.ToString();
            txtSize.Text = tnpc.size.ToString();
            txtMoveArea.Text = tnpc.movearea.ToString();
            txtAttackArea.Text = tnpc.attackarea.ToString();
            txtSkillPoint.Text = tnpc.skillpoint.ToString();
            txtsskillmaster.Text = tnpc.sskillmaster.ToString();
            txtStr.Text = tnpc.str.ToString();
            txtDex.Text = tnpc.dex.ToString();
            txtInt.Text = tnpc.INT.ToString();
            txtCon.Text = tnpc.con.ToString();
            txtAttack.Text = tnpc.attack.ToString();
            txtMagic.Text = tnpc.magic.ToString();
            txtDefense.Text = tnpc.defense.ToString();
            txtResist.Text = tnpc.resist.ToString();
            txtAttackLevel.Text = tnpc.attacklevel.ToString();
            txtDefenseLevel.Text = tnpc.defenselevel.ToString();
            txtHP.Text = tnpc.hp.ToString();
            txtMP.Text = tnpc.mp.ToString();
            txtAttackType.Text = tnpc.attacktype.ToString();
            txtAttackSpeed.Text = tnpc.attackspeed.ToString();
            txtRecoverHP.Text = tnpc.recoverhp.ToString();
            txtRecoverMP.Text = tnpc.recovermp.ToString();
            txtWalkSpeed.Text = tnpc.walkspeed.ToString();
            txtRunSpeed.Text = tnpc.runspeed.ToString();
            txtSkill0.Text = tnpc.skill0.ToString();
            txtSkill1.Text = tnpc.skill1.ToString();
            txtSkill2.Text = tnpc.skill2.ToString();
            txtSkill3.Text = tnpc.skill3.ToString();
            txtDodge.Text = tnpc.dodge.ToString();
            txtMagicAvoid.Text = tnpc.magicavoid.ToString();
            txtHit.Text = tnpc.hit.ToString();
            txtJobAttribute.Text = tnpc.jobattribute.ToString();
    }

    private void CheckParameter(int checkbox)
    {
      if (checkbox == 1)
                checkBoxEnable.BackColor = Color.Lime;
      else
                checkBoxEnable.BackColor = Color.Red;
    }

    private void saveToolStripMenuItem_Click(object sender, EventArgs e)
    {
      mySQL.UpdateQuery("DELETE FROM t_npc");
      int num = AllLists.tnpc_MenuData.Count<tnpc>();
            toolStripProgressBar1.Visible = true;
      for (int index = 0; index < AllLists.tnpc_MenuData.Count<tnpc>(); ++index)
      {
        DatabaseUpdate.tnpc_Update(AllLists.tnpc_MenuData[index]);
                toolStripProgressBar1.Value = 100 * (index + 1) / num;
      }
            toolStripProgressBar1.Value = 0;
            toolStripProgressBar1.Visible = false;
    }

    private void moballlodToolStripMenuItem_Click(object sender, EventArgs e)
    {
      new ExportLodHandle().ExportMobAll_V4();
    }

    private void strToolStripMenuItem_Click(object sender, EventArgs e)
    {
    }

    private void btnCopy_Click(object sender, EventArgs e)
    {
      int NpcID = GetID();
      if (NpcID == -1)
        return;
      tnpc tnpc = AllLists.tnpc_MenuData.Find((Predicate<tnpc>) (p => p.index == NpcID)).Clone();
      tnpc.index = AllLists.tnpc_MenuData.Max<tnpc>((Func<tnpc, int>) (p => p.index)) + 1;
      tnpc.name += " (copy)";
      AllLists.tnpc_MenuData.Add(tnpc);
      string str = tnpc.index.ToString() + " - " + tnpc.name.ToString();
      AllLists.tnpc_Menu.Add(str);
            listBox1.Items.Add( str);
            listBox1.SelectedIndex = listBox1.Items.Count - 1;
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {
            MakeList();
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
      int NpcID = GetID();
      if (NpcID == -1)
        return;
      string text = listBox1.Text;
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
      AllLists.tnpc_Menu.Remove(text);
      AllLists.tnpc_MenuData.RemoveAll((Predicate<tnpc>) (p => p.index == NpcID));
    }

    private void pictureBox23_Click(object sender, EventArgs e)
    {
      FlagBuilder flagBuilder = new FlagBuilder();
      flagBuilder.flagSmall = Convert.ToInt32(txtFlag.Text);
      flagBuilder.flagBuilderType = "npcs";
      if (flagBuilder.ShowDialog() != DialogResult.OK)
        return;
            txtFlag.Text = flagBuilder.flagSmall.ToString();
    }

    private void pictureBox1_Click(object sender, EventArgs e)
    {
      FlagBuilder flagBuilder = new FlagBuilder();
      flagBuilder.flagSmall = Convert.ToInt32(txtFlag1.Text);
      flagBuilder.flagBuilderType = "npcs";
      if (flagBuilder.ShowDialog() != DialogResult.OK)
        return;
            txtFlag1.Text = flagBuilder.flagSmall.ToString();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && components != null)
                components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (MobEditor));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            importFromDatabaseToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            exportToolStripMenuItem = new ToolStripMenuItem();
            moballlodToolStripMenuItem = new ToolStripMenuItem();
            strToolStripMenuItem = new ToolStripMenuItem();
            extraToolStripMenuItem = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            groupBox2 = new GroupBox();
            btnDelete = new Button();
            btnCopy = new Button();
            listBox1 = new ListBox();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripProgressBar1 = new ToolStripProgressBar();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            groupBox6 = new GroupBox();
            groupBox13 = new GroupBox();
            txtAttackType = new TextBox();
            label40 = new Label();
            txtAttackSpeed = new TextBox();
            label41 = new Label();
            groupBox12 = new GroupBox();
            txtMagicAvoid = new TextBox();
            txtHit = new TextBox();
            label36 = new Label();
            label37 = new Label();
            txtJobAttribute = new TextBox();
            label38 = new Label();
            label39 = new Label();
            txtDodge = new TextBox();
            groupBox11 = new GroupBox();
            label34 = new Label();
            label33 = new Label();
            txtSkill3 = new TextBox();
            label35 = new Label();
            txtSkill1 = new TextBox();
            txtSkill2 = new TextBox();
            label32 = new Label();
            txtSkill0 = new TextBox();
            groupBox10 = new GroupBox();
            label30 = new Label();
            label31 = new Label();
            txtRecoverHP = new TextBox();
            txtRecoverMP = new TextBox();
            label26 = new Label();
            label29 = new Label();
            txtHP = new TextBox();
            txtMP = new TextBox();
            groupBox9 = new GroupBox();
            txtDefenseLevel = new TextBox();
            txtAttackLevel = new TextBox();
            label27 = new Label();
            label28 = new Label();
            groupBox8 = new GroupBox();
            txtMagic = new TextBox();
            txtAttack = new TextBox();
            label25 = new Label();
            label22 = new Label();
            txtResist = new TextBox();
            label23 = new Label();
            label24 = new Label();
            txtDefense = new TextBox();
            groupBox7 = new GroupBox();
            txtCon = new NumericUpDown();
            txtInt = new NumericUpDown();
            txtDex = new NumericUpDown();
            txtStr = new NumericUpDown();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            groupBox5 = new GroupBox();
            label16 = new Label();
            label17 = new Label();
            txtRunSpeed = new TextBox();
            txtWalkSpeed = new TextBox();
            label14 = new Label();
            label15 = new Label();
            txtAttackArea = new TextBox();
            txtMoveArea = new TextBox();
            groupBox4 = new GroupBox();
            pictureBox1 = new PictureBox();
            pictureBox23 = new PictureBox();
            label7 = new Label();
            txtStateFlag = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtFlag1 = new TextBox();
            txtFlag = new TextBox();
            txtskillmaster = new TextBox();
            txtFamily = new TextBox();
            groupBox3 = new GroupBox();
            label42 = new Label();
            txtsskillmaster = new TextBox();
            label13 = new Label();
            txtSize = new TextBox();
            label11 = new Label();
            txtSight = new TextBox();
            label12 = new Label();
            txtSkillPoint = new TextBox();
            label10 = new Label();
            txtGold = new TextBox();
            label9 = new Label();
            txtExp = new TextBox();
            label8 = new Label();
            txtLevel = new TextBox();
            txtName = new TextBox();
            label2 = new Label();
            checkBoxEnable = new CheckBox();
            txtIndex = new TextBox();
            label1 = new Label();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            tabPage5 = new TabPage();
            tabPage6 = new TabPage();
            tabPage7 = new TabPage();
            btnSave = new Button();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            statusStrip1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox13.SuspendLayout();
            groupBox12.SuspendLayout();
            groupBox11.SuspendLayout();
            groupBox10.SuspendLayout();
            groupBox9.SuspendLayout();
            groupBox8.SuspendLayout();
            groupBox7.SuspendLayout();
            txtCon.BeginInit();
            txtInt.BeginInit();
            txtDex.BeginInit();
            txtStr.BeginInit();
            groupBox5.SuspendLayout();
            groupBox4.SuspendLayout();
      ((ISupportInitialize)pictureBox1).BeginInit();
      ((ISupportInitialize)pictureBox23).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            menuStrip1.BackColor = SystemColors.ControlLightLight;
            menuStrip1.BackgroundImageLayout = ImageLayout.None;
            menuStrip1.Font = new Font("Segoe UI", 9f);
            menuStrip1.GripStyle = ToolStripGripStyle.Visible;
            menuStrip1.Items.AddRange(new ToolStripItem[2]
      {
        (ToolStripItem) fileToolStripMenuItem,
        (ToolStripItem) extraToolStripMenuItem
      });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(970, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[3]
      {
        (ToolStripItem) importFromDatabaseToolStripMenuItem,
        (ToolStripItem) saveToolStripMenuItem,
        (ToolStripItem) exportToolStripMenuItem
      });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            importFromDatabaseToolStripMenuItem.Name = "importFromDatabaseToolStripMenuItem";
            importFromDatabaseToolStripMenuItem.Size = new Size(180, 22);
            importFromDatabaseToolStripMenuItem.Text = "Load from Database";
            importFromDatabaseToolStripMenuItem.Click += new EventHandler(importFromDatabaseToolStripMenuItem_Click);
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(180, 22);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += new EventHandler(saveToolStripMenuItem_Click);
            exportToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[2]
      {
        (ToolStripItem) moballlodToolStripMenuItem,
        (ToolStripItem) strToolStripMenuItem
      });
            exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            exportToolStripMenuItem.Size = new Size(180, 22);
            exportToolStripMenuItem.Text = "Export";
            moballlodToolStripMenuItem.Name = "moballlodToolStripMenuItem";
            moballlodToolStripMenuItem.Size = new Size(178, 22);
            moballlodToolStripMenuItem.Text = "mobAll.lod";
            moballlodToolStripMenuItem.Click += new EventHandler(moballlodToolStripMenuItem_Click);
            strToolStripMenuItem.Enabled = false;
            strToolStripMenuItem.Name = "strToolStripMenuItem";
            strToolStripMenuItem.Size = new Size(178, 22);
            strToolStripMenuItem.Text = "strNpcName_us.lod";
            strToolStripMenuItem.Click += new EventHandler(strToolStripMenuItem_Click);
            extraToolStripMenuItem.Enabled = false;
            extraToolStripMenuItem.Name = "extraToolStripMenuItem";
            extraToolStripMenuItem.Size = new Size(44, 20);
            extraToolStripMenuItem.Text = "Extra";
            groupBox1.Controls.Add((Control)textBox1);
            groupBox1.Location = new Point(12, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(256, 51);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search";
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(6, 19);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(244, 20);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += new EventHandler(textBox1_TextChanged);
            groupBox2.Controls.Add((Control)btnDelete);
            groupBox2.Controls.Add((Control)btnCopy);
            groupBox2.Controls.Add((Control)listBox1);
            groupBox2.Location = new Point(12, 84);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(256, 493);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Mob list";
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Location = new Point(142, 464);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(108, 23);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += new EventHandler(btnDelete_Click);
            btnCopy.FlatStyle = FlatStyle.Flat;
            btnCopy.Location = new Point(6, 464);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(130, 23);
            btnCopy.TabIndex = 2;
            btnCopy.Text = "New Copy";
            btnCopy.UseVisualStyleBackColor = true;
            btnCopy.Click += new EventHandler(btnCopy_Click);
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(6, 19);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(244, 433);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += new EventHandler(listBox1_SelectedIndexChanged);
            statusStrip1.Items.AddRange(new ToolStripItem[2]
      {
        (ToolStripItem) toolStripStatusLabel1,
        (ToolStripItem) toolStripProgressBar1
      });
            statusStrip1.Location = new Point(0, 580);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(970, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(39, 17);
            toolStripStatusLabel1.Text = "Status";
            toolStripProgressBar1.Margin = new Padding(5);
            toolStripProgressBar1.Name = "toolStripProgressBar1";
            toolStripProgressBar1.Size = new Size(100, 15);
            toolStripProgressBar1.Step = 1;
            toolStripProgressBar1.Visible = false;
            tabControl1.Controls.Add((Control)tabPage1);
            tabControl1.Controls.Add((Control)tabPage2);
            tabControl1.Controls.Add((Control)tabPage3);
            tabControl1.Controls.Add((Control)tabPage4);
            tabControl1.Controls.Add((Control)tabPage5);
            tabControl1.Controls.Add((Control)tabPage6);
            tabControl1.Controls.Add((Control)tabPage7);
            tabControl1.Enabled = false;
            tabControl1.Location = new Point(274, 27);
            tabControl1.Name = "tabControl1";
            tabControl1.Padding = new Point(25, 3);
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(674, 509);
            tabControl1.TabIndex = 4;
            tabPage1.BorderStyle = BorderStyle.FixedSingle;
            tabPage1.Controls.Add((Control)groupBox6);
            tabPage1.Controls.Add((Control)groupBox5);
            tabPage1.Controls.Add((Control)groupBox4);
            tabPage1.Controls.Add((Control)groupBox3);
            tabPage1.Location = new Point(4, 22);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(666, 483);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Main";
            tabPage1.UseVisualStyleBackColor = true;
            groupBox6.Controls.Add((Control)groupBox13);
            groupBox6.Controls.Add((Control)groupBox12);
            groupBox6.Controls.Add((Control)groupBox11);
            groupBox6.Controls.Add((Control)groupBox10);
            groupBox6.Controls.Add((Control)groupBox9);
            groupBox6.Controls.Add((Control)groupBox8);
            groupBox6.Controls.Add((Control)groupBox7);
            groupBox6.Location = new Point(6, 190);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(652, 285);
            groupBox6.TabIndex = 3;
            groupBox6.TabStop = false;
            groupBox6.Text = "Strength / Skills";
            groupBox13.Controls.Add((Control)txtAttackType);
            groupBox13.Controls.Add((Control)label40);
            groupBox13.Controls.Add((Control)txtAttackSpeed);
            groupBox13.Controls.Add((Control)label41);
            groupBox13.Location = new Point(190, 152);
            groupBox13.Name = "groupBox13";
            groupBox13.Size = new Size(131, 74);
            groupBox13.TabIndex = 42;
            groupBox13.TabStop = false;
            groupBox13.Text = "Attack";
            txtAttackType.BorderStyle = BorderStyle.FixedSingle;
            txtAttackType.Location = new Point(76, 16);
            txtAttackType.Name = "txtAttackType";
            txtAttackType.Size = new Size(44, 20);
            txtAttackType.TabIndex = 21;
            label40.AutoSize = true;
            label40.Location = new Point(6, 20);
            label40.Name = "label40";
            label40.Size = new Size(65, 13);
            label40.TabIndex = 20;
            label40.Text = "AttackType:";
            txtAttackSpeed.BorderStyle = BorderStyle.FixedSingle;
            txtAttackSpeed.Location = new Point(76, 42);
            txtAttackSpeed.Name = "txtAttackSpeed";
            txtAttackSpeed.Size = new Size(44, 20);
            txtAttackSpeed.TabIndex = 23;
            label41.AutoSize = true;
            label41.Location = new Point(6, 46);
            label41.Name = "label41";
            label41.Size = new Size(72, 13);
            label41.TabIndex = 22;
            label41.Text = "AttackSpeed:";
            groupBox12.Controls.Add((Control)txtMagicAvoid);
            groupBox12.Controls.Add((Control)txtHit);
            groupBox12.Controls.Add((Control)label36);
            groupBox12.Controls.Add((Control)label37);
            groupBox12.Controls.Add((Control)txtJobAttribute);
            groupBox12.Controls.Add((Control)label38);
            groupBox12.Controls.Add((Control)label39);
            groupBox12.Controls.Add((Control)txtDodge);
            groupBox12.Location = new Point(324, 101);
            groupBox12.Name = "groupBox12";
            groupBox12.Size = new Size(322, 73);
            groupBox12.TabIndex = 41;
            groupBox12.TabStop = false;
            groupBox12.Text = "Attribute";
            txtMagicAvoid.BorderStyle = BorderStyle.FixedSingle;
            txtMagicAvoid.Location = new Point(246, 16);
            txtMagicAvoid.Name = "txtMagicAvoid";
            txtMagicAvoid.Size = new Size(70, 20);
            txtMagicAvoid.TabIndex = 31;
            txtHit.BorderStyle = BorderStyle.FixedSingle;
            txtHit.Location = new Point(84, 16);
            txtHit.Name = "txtHit";
            txtHit.Size = new Size(70, 20);
            txtHit.TabIndex = 29;
            label36.AutoSize = true;
            label36.Location = new Point(176, 45);
            label36.Name = "label36";
            label36.Size = new Size(66, 13);
            label36.TabIndex = 34;
            label36.Text = "JobAttribute:";
            label37.AutoSize = true;
            label37.Location = new Point(14, 20);
            label37.Name = "label37";
            label37.Size = new Size(23, 13);
            label37.TabIndex = 28;
            label37.Text = "Hit:";
            txtJobAttribute.BorderStyle = BorderStyle.FixedSingle;
            txtJobAttribute.Location = new Point(246, 41);
            txtJobAttribute.Name = "txtJobAttribute";
            txtJobAttribute.Size = new Size(70, 20);
            txtJobAttribute.TabIndex = 35;
            label38.AutoSize = true;
            label38.Location = new Point(176, 20);
            label38.Name = "label38";
            label38.Size = new Size(66, 13);
            label38.TabIndex = 30;
            label38.Text = "MagicAvoid:";
            label39.AutoSize = true;
            label39.Location = new Point(14, 43);
            label39.Name = "label39";
            label39.Size = new Size(42, 13);
            label39.TabIndex = 32;
            label39.Text = "Dodge:";
            txtDodge.BorderStyle = BorderStyle.FixedSingle;
            txtDodge.Location = new Point(84, 39);
            txtDodge.Name = "txtDodge";
            txtDodge.Size = new Size(70, 20);
            txtDodge.TabIndex = 33;
            groupBox11.Controls.Add((Control)label34);
            groupBox11.Controls.Add((Control)label33);
            groupBox11.Controls.Add((Control)txtSkill3);
            groupBox11.Controls.Add((Control)label35);
            groupBox11.Controls.Add((Control)txtSkill1);
            groupBox11.Controls.Add((Control)txtSkill2);
            groupBox11.Controls.Add((Control)label32);
            groupBox11.Controls.Add((Control)txtSkill0);
            groupBox11.Location = new Point(324, 180);
            groupBox11.Name = "groupBox11";
            groupBox11.Size = new Size(322, 76);
            groupBox11.TabIndex = 40;
            groupBox11.TabStop = false;
            groupBox11.Text = "Skills";
            label34.AutoSize = true;
            label34.Location = new Point(163, 52);
            label34.Name = "label34";
            label34.Size = new Size(32, 13);
            label34.TabIndex = 44;
            label34.Text = "Skill3";
            label33.AutoSize = true;
            label33.Location = new Point(10, 52);
            label33.Name = "label33";
            label33.Size = new Size(32, 13);
            label33.TabIndex = 40;
            label33.Text = "Skill1";
            txtSkill3.BorderStyle = BorderStyle.FixedSingle;
            txtSkill3.Location = new Point(216, 50);
            txtSkill3.Name = "txtSkill3";
            txtSkill3.Size = new Size(88, 20);
            txtSkill3.TabIndex = 45;
            label35.AutoSize = true;
            label35.Location = new Point(164, 28);
            label35.Name = "label35";
            label35.Size = new Size(35, 13);
            label35.TabIndex = 42;
            label35.Text = "Skill2:";
            txtSkill1.BorderStyle = BorderStyle.FixedSingle;
            txtSkill1.Location = new Point(53, 50);
            txtSkill1.Name = "txtSkill1";
            txtSkill1.Size = new Size(88, 20);
            txtSkill1.TabIndex = 41;
            txtSkill2.BorderStyle = BorderStyle.FixedSingle;
            txtSkill2.Location = new Point(215, 24);
            txtSkill2.Name = "txtSkill2";
            txtSkill2.Size = new Size(88, 20);
            txtSkill2.TabIndex = 43;
            label32.AutoSize = true;
            label32.Location = new Point(7, 28);
            label32.Name = "label32";
            label32.Size = new Size(35, 13);
            label32.TabIndex = 38;
            label32.Text = "Skill0:";
            txtSkill0.BorderStyle = BorderStyle.FixedSingle;
            txtSkill0.Location = new Point(53, 26);
            txtSkill0.Name = "txtSkill0";
            txtSkill0.Size = new Size(88, 20);
            txtSkill0.TabIndex = 39;
            groupBox10.Controls.Add((Control)label30);
            groupBox10.Controls.Add((Control)label31);
            groupBox10.Controls.Add((Control)txtRecoverHP);
            groupBox10.Controls.Add((Control)txtRecoverMP);
            groupBox10.Controls.Add((Control)label26);
            groupBox10.Controls.Add((Control)label29);
            groupBox10.Controls.Add((Control)txtHP);
            groupBox10.Controls.Add((Control)txtMP);
            groupBox10.Location = new Point(6, 101);
            groupBox10.Name = "groupBox10";
            groupBox10.Size = new Size(174, (int) sbyte.MaxValue);
            groupBox10.TabIndex = 39;
            groupBox10.TabStop = false;
            groupBox10.Text = "Health / Mana";
            label30.AutoSize = true;
            label30.Location = new Point(13, 105);
            label30.Name = "label30";
            label30.Size = new Size(54, 13);
            label30.TabIndex = 38;
            label30.Text = "ManaReg";
            label31.AutoSize = true;
            label31.Location = new Point(13, 79);
            label31.Name = "label31";
            label31.Size = new Size(61, 13);
            label31.TabIndex = 36;
            label31.Text = "HealthReg:";
            txtRecoverHP.BorderStyle = BorderStyle.FixedSingle;
            txtRecoverHP.Location = new Point(80, 75);
            txtRecoverHP.Name = "txtRecoverHP";
            txtRecoverHP.Size = new Size(88, 20);
            txtRecoverHP.TabIndex = 37;
            txtRecoverMP.BorderStyle = BorderStyle.FixedSingle;
            txtRecoverMP.Location = new Point(80, 101);
            txtRecoverMP.Name = "txtRecoverMP";
            txtRecoverMP.Size = new Size(88, 20);
            txtRecoverMP.TabIndex = 39;
            label26.AutoSize = true;
            label26.Location = new Point(13, 51);
            label26.Name = "label26";
            label26.Size = new Size(37, 13);
            label26.TabIndex = 34;
            label26.Text = "Mana:";
            label29.AutoSize = true;
            label29.Location = new Point(13, 25);
            label29.Name = "label29";
            label29.Size = new Size(41, 13);
            label29.TabIndex = 32;
            label29.Text = "Health:";
            txtHP.BorderStyle = BorderStyle.FixedSingle;
            txtHP.Location = new Point(61, 21);
            txtHP.Name = "txtHP";
            txtHP.Size = new Size(107, 20);
            txtHP.TabIndex = 33;
            txtMP.BorderStyle = BorderStyle.FixedSingle;
            txtMP.Location = new Point(61, 47);
            txtMP.Name = "txtMP";
            txtMP.Size = new Size(107, 20);
            txtMP.TabIndex = 35;
            groupBox9.Controls.Add((Control)txtDefenseLevel);
            groupBox9.Controls.Add((Control)txtAttackLevel);
            groupBox9.Controls.Add((Control)label27);
            groupBox9.Controls.Add((Control)label28);
            groupBox9.Location = new Point(6, 19);
            groupBox9.Name = "groupBox9";
            groupBox9.Size = new Size(175, 76);
            groupBox9.TabIndex = 38;
            groupBox9.TabStop = false;
            groupBox9.Text = "Level";
            txtDefenseLevel.BorderStyle = BorderStyle.FixedSingle;
            txtDefenseLevel.Location = new Point(117, 44);
            txtDefenseLevel.Name = "txtDefenseLevel";
            txtDefenseLevel.Size = new Size(52, 20);
            txtDefenseLevel.TabIndex = 31;
            txtAttackLevel.BorderStyle = BorderStyle.FixedSingle;
            txtAttackLevel.Location = new Point(117, 18);
            txtAttackLevel.Name = "txtAttackLevel";
            txtAttackLevel.Size = new Size(52, 20);
            txtAttackLevel.TabIndex = 29;
            label27.AutoSize = true;
            label27.Location = new Point(14, 20);
            label27.Name = "label27";
            label27.Size = new Size(67, 13);
            label27.TabIndex = 28;
            label27.Text = "AttackLevel:";
            label28.AutoSize = true;
            label28.Location = new Point(14, 48);
            label28.Name = "label28";
            label28.Size = new Size(76, 13);
            label28.TabIndex = 30;
            label28.Text = "DefenseLevel:";
            groupBox8.Controls.Add((Control)txtMagic);
            groupBox8.Controls.Add((Control)txtAttack);
            groupBox8.Controls.Add((Control)label25);
            groupBox8.Controls.Add((Control)label22);
            groupBox8.Controls.Add((Control)txtResist);
            groupBox8.Controls.Add((Control)label23);
            groupBox8.Controls.Add((Control)label24);
            groupBox8.Controls.Add((Control)txtDefense);
            groupBox8.Location = new Point(324, 19);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(322, 73);
            groupBox8.TabIndex = 37;
            groupBox8.TabStop = false;
            groupBox8.Text = "Stats";
            txtMagic.BorderStyle = BorderStyle.FixedSingle;
            txtMagic.Location = new Point(246, 16);
            txtMagic.Name = "txtMagic";
            txtMagic.Size = new Size(70, 20);
            txtMagic.TabIndex = 31;
            txtAttack.BorderStyle = BorderStyle.FixedSingle;
            txtAttack.Location = new Point(84, 16);
            txtAttack.Name = "txtAttack";
            txtAttack.Size = new Size(70, 20);
            txtAttack.TabIndex = 29;
            label25.AutoSize = true;
            label25.Location = new Point(176, 45);
            label25.Name = "label25";
            label25.Size = new Size(39, 13);
            label25.TabIndex = 34;
            label25.Text = "Resist:";
            label22.AutoSize = true;
            label22.Location = new Point(14, 20);
            label22.Name = "label22";
            label22.Size = new Size(41, 13);
            label22.TabIndex = 28;
            label22.Text = "Attack:";
            txtResist.BorderStyle = BorderStyle.FixedSingle;
            txtResist.Location = new Point(246, 41);
            txtResist.Name = "txtResist";
            txtResist.Size = new Size(70, 20);
            txtResist.TabIndex = 35;
            label23.AutoSize = true;
            label23.Location = new Point(176, 20);
            label23.Name = "label23";
            label23.Size = new Size(39, 13);
            label23.TabIndex = 30;
            label23.Text = "Magic:";
            label24.AutoSize = true;
            label24.Location = new Point(14, 43);
            label24.Name = "label24";
            label24.Size = new Size(50, 13);
            label24.TabIndex = 32;
            label24.Text = "Defense:";
            txtDefense.BorderStyle = BorderStyle.FixedSingle;
            txtDefense.Location = new Point(84, 39);
            txtDefense.Name = "txtDefense";
            txtDefense.Size = new Size(70, 20);
            txtDefense.TabIndex = 33;
            groupBox7.Controls.Add((Control)txtCon);
            groupBox7.Controls.Add((Control)txtInt);
            groupBox7.Controls.Add((Control)txtDex);
            groupBox7.Controls.Add((Control)txtStr);
            groupBox7.Controls.Add((Control)label18);
            groupBox7.Controls.Add((Control)label19);
            groupBox7.Controls.Add((Control)label20);
            groupBox7.Controls.Add((Control)label21);
            groupBox7.Location = new Point(187, 19);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(131, (int) sbyte.MaxValue);
            groupBox7.TabIndex = 36;
            groupBox7.TabStop = false;
            groupBox7.Text = "Basic Stats";
            txtCon.Increment = new Decimal(new int[4]
      {
        10,
        0,
        0,
        0
      });
            txtCon.Location = new Point(72, 95);
            txtCon.Maximum = new Decimal(new int[4]
      {
        100000,
        0,
        0,
        0
      });
            txtCon.Name = "txtCon";
            txtCon.Size = new Size(53, 20);
            txtCon.TabIndex = 46;
            txtInt.Increment = new Decimal(new int[4]
      {
        10,
        0,
        0,
        0
      });
            txtInt.Location = new Point(72, 70);
            txtInt.Maximum = new Decimal(new int[4]
      {
        100000,
        0,
        0,
        0
      });
            txtInt.Name = "txtInt";
            txtInt.Size = new Size(53, 20);
            txtInt.TabIndex = 45;
            txtDex.Increment = new Decimal(new int[4]
      {
        10,
        0,
        0,
        0
      });
            txtDex.Location = new Point(72, 44);
            txtDex.Maximum = new Decimal(new int[4]
      {
        100000,
        0,
        0,
        0
      });
            txtDex.Name = "txtDex";
            txtDex.Size = new Size(53, 20);
            txtDex.TabIndex = 44;
            txtStr.Increment = new Decimal(new int[4]
      {
        10,
        0,
        0,
        0
      });
            txtStr.Location = new Point(72, 16);
            txtStr.Maximum = new Decimal(new int[4]
      {
        100000,
        0,
        0,
        0
      });
            txtStr.Name = "txtStr";
            txtStr.Size = new Size(51, 20);
            txtStr.TabIndex = 43;
            label18.AutoSize = true;
            label18.Location = new Point(6, 20);
            label18.Name = "label18";
            label18.Size = new Size(50, 13);
            label18.TabIndex = 20;
            label18.Text = "Strength:";
            label19.AutoSize = true;
            label19.Location = new Point(6, 46);
            label19.Name = "label19";
            label19.Size = new Size(48, 13);
            label19.TabIndex = 22;
            label19.Text = "Dexterity";
            label20.AutoSize = true;
            label20.Location = new Point(6, 72);
            label20.Name = "label20";
            label20.Size = new Size(64, 13);
            label20.TabIndex = 24;
            label20.Text = "Intelligence:";
            label21.AutoSize = true;
            label21.Location = new Point(6, 98);
            label21.Name = "label21";
            label21.Size = new Size(65, 13);
            label21.TabIndex = 26;
            label21.Text = "Constitution:";
            groupBox5.Controls.Add((Control)label16);
            groupBox5.Controls.Add((Control)label17);
            groupBox5.Controls.Add((Control)txtRunSpeed);
            groupBox5.Controls.Add((Control)txtWalkSpeed);
            groupBox5.Controls.Add((Control)label14);
            groupBox5.Controls.Add((Control)label15);
            groupBox5.Controls.Add((Control)txtAttackArea);
            groupBox5.Controls.Add((Control)txtMoveArea);
            groupBox5.Location = new Point(333, 107);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(325, 77);
            groupBox5.TabIndex = 2;
            groupBox5.TabStop = false;
            groupBox5.Text = "Move";
            label16.AutoSize = true;
            label16.Location = new Point(154, 49);
            label16.Name = "label16";
            label16.Size = new Size(61, 13);
            label16.TabIndex = 23;
            label16.Text = "RunSpeed:";
            label17.AutoSize = true;
            label17.Location = new Point(6, 49);
            label17.Name = "label17";
            label17.Size = new Size(66, 13);
            label17.TabIndex = 22;
            label17.Text = "WalkSpeed:";
            txtRunSpeed.BorderStyle = BorderStyle.FixedSingle;
            txtRunSpeed.Location = new Point(223, 47);
            txtRunSpeed.Name = "txtRunSpeed";
            txtRunSpeed.Size = new Size(69, 20);
            txtRunSpeed.TabIndex = 21;
            txtWalkSpeed.BorderStyle = BorderStyle.FixedSingle;
            txtWalkSpeed.Location = new Point(75, 47);
            txtWalkSpeed.Name = "txtWalkSpeed";
            txtWalkSpeed.Size = new Size(54, 20);
            txtWalkSpeed.TabIndex = 20;
            label14.AutoSize = true;
            label14.Location = new Point(154, 23);
            label14.Name = "label14";
            label14.Size = new Size(63, 13);
            label14.TabIndex = 19;
            label14.Text = "AttackArea:";
            label15.AutoSize = true;
            label15.Location = new Point(6, 23);
            label15.Name = "label15";
            label15.Size = new Size(59, 13);
            label15.TabIndex = 18;
            label15.Text = "MoveArea:";
            txtAttackArea.BorderStyle = BorderStyle.FixedSingle;
            txtAttackArea.Location = new Point(223, 21);
            txtAttackArea.Name = "txtAttackArea";
            txtAttackArea.Size = new Size(69, 20);
            txtAttackArea.TabIndex = 17;
            txtMoveArea.BorderStyle = BorderStyle.FixedSingle;
            txtMoveArea.Location = new Point(75, 21);
            txtMoveArea.Name = "txtMoveArea";
            txtMoveArea.Size = new Size(54, 20);
            txtMoveArea.TabIndex = 16;
            groupBox4.Controls.Add((Control)pictureBox1);
            groupBox4.Controls.Add((Control)pictureBox23);
            groupBox4.Controls.Add((Control)label7);
            groupBox4.Controls.Add((Control)txtStateFlag);
            groupBox4.Controls.Add((Control)label6);
            groupBox4.Controls.Add((Control)label5);
            groupBox4.Controls.Add((Control)label4);
            groupBox4.Controls.Add((Control)label3);
            groupBox4.Controls.Add((Control)txtFlag1);
            groupBox4.Controls.Add((Control)txtFlag);
            groupBox4.Controls.Add((Control)txtskillmaster);
            groupBox4.Controls.Add((Control)txtFamily);
            groupBox4.Location = new Point(333, 6);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(325, 95);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "State";
            //      this.pictureBox1.BackgroundImage = (Image) componentResourceManager.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Location = new Point(298, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(17, 20);
            pictureBox1.TabIndex = 44;
            pictureBox1.TabStop = false;
            pictureBox1.Tag =  "a";
            pictureBox1.Click += new EventHandler(pictureBox1_Click);
            //  this.pictureBox23.BackgroundImage = (Image) componentResourceManager.GetObject("pictureBox23.BackgroundImage");
            pictureBox23.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox23.Cursor = Cursors.Hand;
            pictureBox23.Location = new Point(298, 66);
            pictureBox23.Name = "pictureBox23";
            pictureBox23.Size = new Size(17, 20);
            pictureBox23.TabIndex = 43;
            pictureBox23.TabStop = false;
            pictureBox23.Tag =  "a";
            pictureBox23.Click += new EventHandler(pictureBox23_Click);
            label7.AutoSize = true;
            label7.Location = new Point(154, 16);
            label7.Name = "label7";
            label7.Size = new Size(55, 13);
            label7.TabIndex = 17;
            label7.Text = "StateFlag:";
            txtStateFlag.BorderStyle = BorderStyle.FixedSingle;
            txtStateFlag.Location = new Point(223, 14);
            txtStateFlag.Name = "txtStateFlag";
            txtStateFlag.Size = new Size(69, 20);
            txtStateFlag.TabIndex = 16;
            label6.AutoSize = true;
            label6.Location = new Point(154, 42);
            label6.Name = "label6";
            label6.Size = new Size(36, 13);
            label6.TabIndex = 15;
            label6.Text = "Flag1:";
            label5.AutoSize = true;
            label5.Location = new Point(6, 68);
            label5.Name = "label5";
            label5.Size = new Size(30, 13);
            label5.TabIndex = 14;
            label5.Text = "Flag:";
            label4.AutoSize = true;
            label4.Location = new Point(6, 42);
            label4.Name = "label4";
            label4.Size = new Size(60, 13);
            label4.TabIndex = 13;
            label4.Text = "Skillmaster:";
            label3.AutoSize = true;
            label3.Location = new Point(6, 16);
            label3.Name = "label3";
            label3.Size = new Size(39, 13);
            label3.TabIndex = 9;
            label3.Text = "Family:";
            txtFlag1.BorderStyle = BorderStyle.FixedSingle;
            txtFlag1.Location = new Point(223, 40);
            txtFlag1.Name = "txtFlag1";
            txtFlag1.Size = new Size(69, 20);
            txtFlag1.TabIndex = 12;
            txtFlag.BorderStyle = BorderStyle.FixedSingle;
            txtFlag.Location = new Point(75, 66);
            txtFlag.Name = "txtFlag";
            txtFlag.Size = new Size(217, 20);
            txtFlag.TabIndex = 11;
            txtskillmaster.BorderStyle = BorderStyle.FixedSingle;
            txtskillmaster.Location = new Point(75, 40);
            txtskillmaster.Name = "txtskillmaster";
            txtskillmaster.Size = new Size(54, 20);
            txtskillmaster.TabIndex = 10;
            txtFamily.BorderStyle = BorderStyle.FixedSingle;
            txtFamily.Location = new Point(75, 14);
            txtFamily.Name = "txtFamily";
            txtFamily.Size = new Size(54, 20);
            txtFamily.TabIndex = 9;
            groupBox3.Controls.Add((Control)label42);
            groupBox3.Controls.Add((Control)txtsskillmaster);
            groupBox3.Controls.Add((Control)label13);
            groupBox3.Controls.Add((Control)txtSize);
            groupBox3.Controls.Add((Control)label11);
            groupBox3.Controls.Add((Control)txtSight);
            groupBox3.Controls.Add((Control)label12);
            groupBox3.Controls.Add((Control)txtSkillPoint);
            groupBox3.Controls.Add((Control)label10);
            groupBox3.Controls.Add((Control)txtGold);
            groupBox3.Controls.Add((Control)label9);
            groupBox3.Controls.Add((Control)txtExp);
            groupBox3.Controls.Add((Control)label8);
            groupBox3.Controls.Add((Control)txtLevel);
            groupBox3.Controls.Add((Control)txtName);
            groupBox3.Controls.Add((Control)label2);
            groupBox3.Controls.Add((Control)checkBoxEnable);
            groupBox3.Controls.Add((Control)txtIndex);
            groupBox3.Controls.Add((Control)label1);
            groupBox3.Location = new Point(6, 6);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(321, 178);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Basic";
            label42.AutoSize = true;
            label42.Location = new Point(7, 148);
            label42.Name = "label42";
            label42.Size = new Size(68, 13);
            label42.TabIndex = 22;
            label42.Text = "SSkillMaster:";
            txtsskillmaster.BorderStyle = BorderStyle.FixedSingle;
            txtsskillmaster.Location = new Point(81, 144);
            txtsskillmaster.Name = "txtsskillmaster";
            txtsskillmaster.Size = new Size(87, 20);
            txtsskillmaster.TabIndex = 23;
            label13.AutoSize = true;
            label13.Location = new Point(180, 122);
            label13.Name = "label13";
            label13.Size = new Size(30, 13);
            label13.TabIndex = 20;
            label13.Text = "Size:";
            txtSize.BorderStyle = BorderStyle.FixedSingle;
            txtSize.Location = new Point(218, 118);
            txtSize.Name = "txtSize";
            txtSize.Size = new Size(97, 20);
            txtSize.TabIndex = 21;
            label11.AutoSize = true;
            label11.Location = new Point(7, 122);
            label11.Name = "label11";
            label11.Size = new Size(34, 13);
            label11.TabIndex = 18;
            label11.Text = "Sight:";
            txtSight.BorderStyle = BorderStyle.FixedSingle;
            txtSight.Location = new Point(81, 118);
            txtSight.Name = "txtSight";
            txtSight.Size = new Size(87, 20);
            txtSight.TabIndex = 19;
            label12.AutoSize = true;
            label12.Location = new Point(7, 94);
            label12.Name = "label12";
            label12.Size = new Size(53, 13);
            label12.TabIndex = 16;
            label12.Text = "SkillPoint:";
            txtSkillPoint.BorderStyle = BorderStyle.FixedSingle;
            txtSkillPoint.Location = new Point(81, 92);
            txtSkillPoint.Name = "txtSkillPoint";
            txtSkillPoint.Size = new Size(87, 20);
            txtSkillPoint.TabIndex = 17;
            label10.AutoSize = true;
            label10.Location = new Point(180, 70);
            label10.Name = "label10";
            label10.Size = new Size(32, 13);
            label10.TabIndex = 14;
            label10.Text = "Gold:";
            txtGold.BorderStyle = BorderStyle.FixedSingle;
            txtGold.Location = new Point(218, 66);
            txtGold.Name = "txtGold";
            txtGold.Size = new Size(97, 20);
            txtGold.TabIndex = 15;
            label9.AutoSize = true;
            label9.Location = new Point(7, 68);
            label9.Name = "label9";
            label9.Size = new Size(31, 13);
            label9.TabIndex = 12;
            label9.Text = "EXP:";
            txtExp.BorderStyle = BorderStyle.FixedSingle;
            txtExp.Location = new Point(81, 66);
            txtExp.Name = "txtExp";
            txtExp.Size = new Size(87, 20);
            txtExp.TabIndex = 13;
            label8.AutoSize = true;
            label8.Location = new Point(140, 16);
            label8.Name = "label8";
            label8.Size = new Size(36, 13);
            label8.TabIndex = 10;
            label8.Text = "Level:";
            txtLevel.BorderStyle = BorderStyle.FixedSingle;
            txtLevel.Location = new Point(182, 14);
            txtLevel.Name = "txtLevel";
            txtLevel.Size = new Size(45, 20);
            txtLevel.TabIndex = 11;
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Location = new Point(81, 40);
            txtName.Name = "txtName";
            txtName.Size = new Size(234, 20);
            txtName.TabIndex = 8;
            label2.AutoSize = true;
            label2.Location = new Point(7, 42);
            label2.Name = "label2";
            label2.Size = new Size(38, 13);
            label2.TabIndex = 7;
            label2.Text = "Name:";
            checkBoxEnable.AutoSize = true;
            checkBoxEnable.FlatStyle = FlatStyle.Flat;
            checkBoxEnable.Location = new Point(259, 14);
            checkBoxEnable.Name = "checkBoxEnable";
            checkBoxEnable.Size = new Size(56, 17);
            checkBoxEnable.TabIndex = 6;
            checkBoxEnable.Text = "Enable";
            checkBoxEnable.UseVisualStyleBackColor = true;
            txtIndex.BorderStyle = BorderStyle.FixedSingle;
            txtIndex.Location = new Point(81, 14);
            txtIndex.Name = "txtIndex";
            txtIndex.Size = new Size(44, 20);
            txtIndex.TabIndex = 5;
            label1.AutoSize = true;
            label1.Location = new Point(6, 16);
            label1.Name = "label1";
            label1.Size = new Size(36, 13);
            label1.TabIndex = 0;
            label1.Text = "Index:";
            tabPage2.BorderStyle = BorderStyle.FixedSingle;
            tabPage2.Cursor = Cursors.Default;
            tabPage2.Location = new Point(4, 22);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(666, 483);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Drop";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage3.BorderStyle = BorderStyle.FixedSingle;
            tabPage3.Location = new Point(4, 22);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(666, 483);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "JewelDrop";
            tabPage3.UseVisualStyleBackColor = true;
            tabPage4.BorderStyle = BorderStyle.FixedSingle;
            tabPage4.Location = new Point(4, 22);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(666, 483);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Motion";
            tabPage4.UseVisualStyleBackColor = true;
            tabPage5.BorderStyle = BorderStyle.FixedSingle;
            tabPage5.Location = new Point(4, 22);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(666, 483);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Effect";
            tabPage5.UseVisualStyleBackColor = true;
            tabPage6.BorderStyle = BorderStyle.FixedSingle;
            tabPage6.Location = new Point(4, 22);
            tabPage6.Name = "tabPage6";
            tabPage6.Size = new Size(666, 483);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "P2 Control";
            tabPage6.UseVisualStyleBackColor = true;
            tabPage7.BorderStyle = BorderStyle.FixedSingle;
            tabPage7.Location = new Point(4, 22);
            tabPage7.Name = "tabPage7";
            tabPage7.Size = new Size(666, 483);
            tabPage7.TabIndex = 6;
            tabPage7.Text = "Misc";
            tabPage7.UseVisualStyleBackColor = true;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Location = new Point(862, 548);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(82, 23);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += new EventHandler(btnSave_Click);
            AutoScaleDimensions = new SizeF(6f, 13f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(970, 602);
            Controls.Add((Control)btnSave);
            Controls.Add((Control)tabControl1);
            Controls.Add((Control)statusStrip1);
            Controls.Add((Control)groupBox2);
            Controls.Add((Control)groupBox1);
            Controls.Add((Control)menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MobEditor";
            Text = "[Beta]Ultimate MobEditor for Episode 4 by DamonA";
            Load += new EventHandler(Form1_Load);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            groupBox13.ResumeLayout(false);
            groupBox13.PerformLayout();
            groupBox12.ResumeLayout(false);
            groupBox12.PerformLayout();
            groupBox11.ResumeLayout(false);
            groupBox11.PerformLayout();
            groupBox10.ResumeLayout(false);
            groupBox10.PerformLayout();
            groupBox9.ResumeLayout(false);
            groupBox9.PerformLayout();
            groupBox8.ResumeLayout(false);
            groupBox8.PerformLayout();
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            txtCon.EndInit();
            txtInt.EndInit();
            txtDex.EndInit();
            txtStr.EndInit();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
      ((ISupportInitialize)pictureBox1).EndInit();
      ((ISupportInitialize)pictureBox23).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
    }
  }
}
