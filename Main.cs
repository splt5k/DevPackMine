// Decompiled with JetBrains decompiler
// Type: DevPackMine.Main
// Assembly: DevPackMine, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6B9BC8BF-B510-4945-A515-04135CC0F4A4
// Assembly location: C:\Users\NTServer\Desktop\DevPackMine\DevPackMine\DevPackMine.exe

using DevPackMine.Tools;
using DevPackMine.Tools.MemoryWorker;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DevPackMine
{
  public class Main : Form
  {
    public static Connection connection = new Connection();
    private string Host = Main.connection.ReadSettings("Host");
    private string User = Main.connection.ReadSettings("User");
    private string Password = Main.connection.ReadSettings("Password");
    private string Database = Main.connection.ReadSettings("Database");
    private string Episode = Main.connection.ReadSettings("Episode");
    private IContainer components = (IContainer) null;
    private MenuStrip menuStrip1;
    private ToolStripMenuItem reloadMemoryItemsToolStripMenuItem;
    private GroupBox groupBox1;
    private CheckedListBox checkedListBox1;
    private StatusStrip statusStrip1;
    private ToolStripStatusLabel statusLabel;
    private StatusStrip statusStrip2;
        private ToolStripMenuItem languageToolStripMenuItem;
        private ToolStripMenuItem changeLanguageToolStripMenuItem;
        private ToolStripMenuItem configToolStripMenuItem;
        private ToolStripMenuItem editConfigToolStripMenuItem;
        private ToolStripStatusLabel toolStripStatusLabel1;

    public Main()
    {
            InitializeComponent();
    }

    [DllImport("kernel32.dll", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static extern bool AllocConsole();

    private void Form1_Load(object sender, EventArgs e)
    {
        /*if (Globals.LicenceSystem) //dethunter12 remove
      {
        string[] hwid = epvp_hwid.GetHWID(new epvp_hwid().strHWID());
        if (((IEnumerable<string>) epvp_hwid.GetWhiteList()).Contains<string>(hwid[1]))
        {
                    groupBox1.Enabled = true;
                    toolStripStatusLabel1.Text = "User: " + hwid[1] + " is connected.";
        }
        else
        {
                    groupBox1.Enabled = false;
                    toolStripStatusLabel1.Text = "User: " + hwid[1] + " isn't allowed to connect.";
        }
      }*/
        statusLabel.Text = "Version: " + Globals.Version;
        checkedListBox1.Items.AddRange(new object[17]
      {
         "Catalog",
         "LuckyDraw",
         "Magic",
         "Moonstone",
         "Option",
         "Shop",
         "Title",
         "Skill",
         "ItemEditor",
         "MobEditor",
         "QuestEditor",
         "RewardViewer",
         "AffinityEditor",
         "BigPetEditor",
         "ItemCollection",
         //"SetItemEditor", //dethunter12 add
         //"MakeItemEditor", //dethunter12 add
       //"BigPetEditor NEW", //test dethunter12
       // "ExChange", //test AssasinPL
        "LevelUpGuide",//Test By AssasinPL
        "Jawel Proub",
      });

        Carregar();
     
    }

    private void Carregar()
    { 
        try
        {
            MySqlConnection mySqlConnection = new MySqlConnection("SERVER=" + Host + ";DATABASE=" + Database + ";UID=" + User + ";PASSWORD=" + Password + ";");
            mySqlConnection.Open();
            Text = Globals.Name;
            if (mySqlConnection.State == ConnectionState.Open)
                Text = Text + " [Connected to: " + Host + "]";

            IconList.SetConnection();
            NpcList.SetConnection(); //dethunter12 important!!
            IconSkill.SetConnection(); //test
            IconSkill.Import(); //test
            IconList.Import();
            NpcList.Import(); //dethunter12 important!!!
            checkedListBox1.Enabled = true;
            if (!Globals.Console)
                return;
            Main.AllocConsole();
            Console.Title = "Debug Console";
            Console.WriteLine("Console Initialized.");
        }
        catch (MySqlException ex)
        {
            int num = (int)MessageBox.Show(ex.Message);
            checkedListBox1.Enabled = false;
        }
        catch (Exception ex)
        {
            int num = (int)MessageBox.Show(ex.Message, "Unknown Exception", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            checkedListBox1.Enabled = false;
        }
        
    }

    private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
      foreach (string checkedItem in checkedListBox1.CheckedItems)
      {
        if (checkedItem == "Moonstone")
          new MoonstoneEditor().Show();
        if (checkedItem == "Skill")
          new SkillEditor().Show();
        if (checkedItem == "Catalog")
          new CatalogEditor().Show();
        if (checkedItem == "Item")
          new ItemEditor().Show();
        if (checkedItem == "Option")
          new OptionEditor().Show();
        if (checkedItem == "Shop")
          new ShopEditor().Show();
        if (checkedItem == "Title")
          new TitleEditor().Show();
        if (checkedItem == "LuckyDraw")
          new LuckyDrawBoxTool().Show();
        if (checkedItem == "Magic")
          new MagicEditor().Show();
        if (checkedItem == "ItemEditor")
          new ItemEditor2().Show();
        if (checkedItem == "MobEditor")
          new DevPackMine.Tools.MobEditor().Show();
        if (checkedItem == "MobEditor2")
          new DevPackMine.Tools.MemoryWorker.MobEditor().Show();
        if (checkedItem == "QuestEditor")
          new QuestEditor().Show();
        if (checkedItem == "RewardViewer")
          new RewardEditor().Show();
        if (checkedItem == "AffinityEditor")
          new AffinityEditor().Show();
        if (checkedItem == "BigPetEditor")
          new BigPetEditor().Show();
        if (checkedItem == "ItemCollection")
          new ItemCollection().Show();
        if (checkedItem == "SetItemEditor") //dethunter12 add
           new SetItemEditor().Show();
         if (checkedItem == "MakeItemEditor") //dethunter12 add
          new MakeItemEditor().Show();
               // if (checkedItem == "BigPetEditor")
               //  new DevPackMine.Tools.MemoryWorker.PetEditor.BigPetEditorr().Show();
                if (checkedItem == "ExChange")
                    new DevPackMine.Tools.MemoryWorker.ExChange.ExChange().Show();
                if (checkedItem == "LevelUpGuide")
                    new DevPackMine.Tools.MemoryWorker.LevelUpGuide.LevelUpGuide().Show();
                if (checkedItem == "Jawel Proub")
                    new DevPackMine.Tools.MemoryWorker.Jawel.JawelData().Show();
            }
            for (int index = 0; index < checkedListBox1.Items.Count; ++index)
                checkedListBox1.SetItemChecked(index, false);
    }

    private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
    {
      int num = (int) MessageBox.Show("This website is not operated by gamigo AG. Last Chaos, ©Barunson Games Inc., published by gamigo AG 2008, LastChaos is a protected trademark, All rights reserved.", "Information");
    }

    private void reloadMemoryItemsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      IconList.List.Clear();
      NpcList.List.Clear(); //dethunter12 important
      IconSkill.List.Clear(); //dethunter12 add
      IconList.Import();
      NpcList.Import(); //dethunter12 important
      IconSkill.Import(); //dethunter12 add
    }

    private void licenceSystemToolStripMenuItem_Click(object sender, EventArgs e)
    {
      new LicenceSystem().Show();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && components != null)
                components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.reloadMemoryItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeLanguageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.statusStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reloadMemoryItemsToolStripMenuItem,
            this.languageToolStripMenuItem,
            this.configToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(629, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // reloadMemoryItemsToolStripMenuItem
            // 
            this.reloadMemoryItemsToolStripMenuItem.Name = "reloadMemoryItemsToolStripMenuItem";
            this.reloadMemoryItemsToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.reloadMemoryItemsToolStripMenuItem.Text = "Reload Items";
            this.reloadMemoryItemsToolStripMenuItem.Click += new System.EventHandler(this.reloadMemoryItemsToolStripMenuItem_Click);
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeLanguageToolStripMenuItem});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            this.languageToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.languageToolStripMenuItem.Text = "Language";
            this.languageToolStripMenuItem.Click += new System.EventHandler(this.languageToolStripMenuItem_Click);
            // 
            // changeLanguageToolStripMenuItem
            // 
            this.changeLanguageToolStripMenuItem.Name = "changeLanguageToolStripMenuItem";
            this.changeLanguageToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.changeLanguageToolStripMenuItem.Text = "Change Language";
            this.changeLanguageToolStripMenuItem.Click += new System.EventHandler(this.changeLanguageToolStripMenuItem_Click);
            // 
            // configToolStripMenuItem
            // 
            this.configToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editConfigToolStripMenuItem});
            this.configToolStripMenuItem.Name = "configToolStripMenuItem";
            this.configToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.configToolStripMenuItem.Text = "Config";
            // 
            // editConfigToolStripMenuItem
            // 
            this.editConfigToolStripMenuItem.Name = "editConfigToolStripMenuItem";
            this.editConfigToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.editConfigToolStripMenuItem.Text = "Edit Config";
            this.editConfigToolStripMenuItem.Click += new System.EventHandler(this.editConfigToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkedListBox1);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 29);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(616, 108);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Episode 4";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.SystemColors.Control;
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBox1.Enabled = false;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(5, 22);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(5);
            this.checkedListBox1.MultiColumn = true;
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(606, 81);
            this.checkedListBox1.Sorted = true;
            this.checkedListBox1.TabIndex = 0;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 181);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(629, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(39, 17);
            this.statusLabel.Text = "Status";
            // 
            // statusStrip2
            // 
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip2.Location = new System.Drawing.Point(0, 159);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(629, 22);
            this.statusStrip2.TabIndex = 9;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel1.Text = "Status";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 203);
            this.Controls.Add(this.statusStrip2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LastChaos Tool Collection by Maskov Edit";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

        private void languageToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void changeLanguageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LangSelect langSelect = new LangSelect(); //dethunter12 add
            if (langSelect.ShowDialog() != DialogResult.OK) //dethunter12 add
                return;
        }

        private void editConfigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings(); //dethunter12 add
            if (settings.ShowDialog() != DialogResult.OK) //dethunter12 add
                return;


                Host = Main.connection.ReadSettings("Host");
                User = Main.connection.ReadSettings("User");
                Password = Main.connection.ReadSettings("Password");
                Database = Main.connection.ReadSettings("Database");
                Episode = Main.connection.ReadSettings("Episode");

            Carregar();
        }


    }
}
