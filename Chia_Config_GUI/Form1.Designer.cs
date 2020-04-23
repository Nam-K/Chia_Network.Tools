namespace Chia_Config_GUI
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.logsFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBoxLogsPath = new System.Windows.Forms.ToolStripTextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBoxLogNot = new System.Windows.Forms.CheckBox();
            this.checkBoxLogAll = new System.Windows.Forms.CheckBox();
            this.checkBoxLogFarmer = new System.Windows.Forms.CheckBox();
            this.checkBoxLogHarvester = new System.Windows.Forms.CheckBox();
            this.checkBoxLogFullNode = new System.Windows.Forms.CheckBox();
            this.checkBoxLogWallet = new System.Windows.Forms.CheckBox();
            this.checkBoxLogTimelord = new System.Windows.Forms.CheckBox();
            this.listBoxLogs = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelLogDate = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(874, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logsFolderToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(62, 22);
            this.toolStripDropDownButton1.Text = "Options";
            // 
            // logsFolderToolStripMenuItem
            // 
            this.logsFolderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBoxLogsPath});
            this.logsFolderToolStripMenuItem.Name = "logsFolderToolStripMenuItem";
            this.logsFolderToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.logsFolderToolStripMenuItem.Text = "Logs Folder";
            // 
            // toolStripTextBoxLogsPath
            // 
            this.toolStripTextBoxLogsPath.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBoxLogsPath.HideSelection = false;
            this.toolStripTextBoxLogsPath.Name = "toolStripTextBoxLogsPath";
            this.toolStripTextBoxLogsPath.ReadOnly = true;
            this.toolStripTextBoxLogsPath.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBoxLogsPath.Text = "Logs folder path";
            this.toolStripTextBoxLogsPath.DoubleClick += new System.EventHandler(this.ToolStripTextBoxLogsPath_DoubleClick);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(866, 481);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Chia logs";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.listBoxLogs, 0, 1);
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(857, 469);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.labelLogDate);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.checkBoxLogNot);
            this.groupBox1.Controls.Add(this.checkBoxLogAll);
            this.groupBox1.Controls.Add(this.checkBoxLogFarmer);
            this.groupBox1.Controls.Add(this.checkBoxLogHarvester);
            this.groupBox1.Controls.Add(this.checkBoxLogFullNode);
            this.groupBox1.Controls.Add(this.checkBoxLogWallet);
            this.groupBox1.Controls.Add(this.checkBoxLogTimelord);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.MaximumSize = new System.Drawing.Size(0, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(851, 46);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filters";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(642, 21);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(54, 18);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "auto";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "10s",
            "20s",
            "30s",
            "45s",
            "1mn",
            "1.5mn",
            "2mn",
            "5mn",
            "10mn",
            "15mn",
            "30mn",
            "45mn",
            "1h"});
            this.comboBox1.Location = new System.Drawing.Point(702, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(72, 22);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(563, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBoxLogNot
            // 
            this.checkBoxLogNot.AutoSize = true;
            this.checkBoxLogNot.Location = new System.Drawing.Point(59, 21);
            this.checkBoxLogNot.Name = "checkBoxLogNot";
            this.checkBoxLogNot.Size = new System.Drawing.Size(47, 18);
            this.checkBoxLogNot.TabIndex = 1;
            this.checkBoxLogNot.Text = "NOT";
            this.checkBoxLogNot.UseVisualStyleBackColor = true;
            // 
            // checkBoxLogAll
            // 
            this.checkBoxLogAll.AutoSize = true;
            this.checkBoxLogAll.Checked = true;
            this.checkBoxLogAll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxLogAll.Location = new System.Drawing.Point(6, 21);
            this.checkBoxLogAll.Name = "checkBoxLogAll";
            this.checkBoxLogAll.Size = new System.Drawing.Size(47, 18);
            this.checkBoxLogAll.TabIndex = 1;
            this.checkBoxLogAll.Text = "All";
            this.checkBoxLogAll.UseVisualStyleBackColor = true;
            // 
            // checkBoxLogFarmer
            // 
            this.checkBoxLogFarmer.AutoSize = true;
            this.checkBoxLogFarmer.Location = new System.Drawing.Point(130, 21);
            this.checkBoxLogFarmer.Name = "checkBoxLogFarmer";
            this.checkBoxLogFarmer.Size = new System.Drawing.Size(68, 18);
            this.checkBoxLogFarmer.TabIndex = 1;
            this.checkBoxLogFarmer.Text = "Farmer";
            this.checkBoxLogFarmer.UseVisualStyleBackColor = true;
            // 
            // checkBoxLogHarvester
            // 
            this.checkBoxLogHarvester.AutoSize = true;
            this.checkBoxLogHarvester.Location = new System.Drawing.Point(204, 21);
            this.checkBoxLogHarvester.Name = "checkBoxLogHarvester";
            this.checkBoxLogHarvester.Size = new System.Drawing.Size(89, 18);
            this.checkBoxLogHarvester.TabIndex = 1;
            this.checkBoxLogHarvester.Text = "Harvester";
            this.checkBoxLogHarvester.UseVisualStyleBackColor = true;
            // 
            // checkBoxLogFullNode
            // 
            this.checkBoxLogFullNode.AutoSize = true;
            this.checkBoxLogFullNode.Location = new System.Drawing.Point(299, 21);
            this.checkBoxLogFullNode.Name = "checkBoxLogFullNode";
            this.checkBoxLogFullNode.Size = new System.Drawing.Size(82, 18);
            this.checkBoxLogFullNode.TabIndex = 1;
            this.checkBoxLogFullNode.Text = "FullNode";
            this.checkBoxLogFullNode.UseVisualStyleBackColor = true;
            // 
            // checkBoxLogWallet
            // 
            this.checkBoxLogWallet.AutoSize = true;
            this.checkBoxLogWallet.Location = new System.Drawing.Point(387, 21);
            this.checkBoxLogWallet.Name = "checkBoxLogWallet";
            this.checkBoxLogWallet.Size = new System.Drawing.Size(68, 18);
            this.checkBoxLogWallet.TabIndex = 1;
            this.checkBoxLogWallet.Text = "Wallet";
            this.checkBoxLogWallet.UseVisualStyleBackColor = true;
            // 
            // checkBoxLogTimelord
            // 
            this.checkBoxLogTimelord.AutoSize = true;
            this.checkBoxLogTimelord.Location = new System.Drawing.Point(461, 21);
            this.checkBoxLogTimelord.Name = "checkBoxLogTimelord";
            this.checkBoxLogTimelord.Size = new System.Drawing.Size(82, 18);
            this.checkBoxLogTimelord.TabIndex = 1;
            this.checkBoxLogTimelord.Text = "Timelord";
            this.checkBoxLogTimelord.UseVisualStyleBackColor = true;
            // 
            // listBoxLogs
            // 
            this.listBoxLogs.BackColor = System.Drawing.SystemColors.Desktop;
            this.listBoxLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxLogs.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxLogs.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.listBoxLogs.FormattingEnabled = true;
            this.listBoxLogs.HorizontalScrollbar = true;
            this.listBoxLogs.ItemHeight = 14;
            this.listBoxLogs.Items.AddRange(new object[] {
            "listBoxLogs"});
            this.listBoxLogs.Location = new System.Drawing.Point(3, 55);
            this.listBoxLogs.Name = "listBoxLogs";
            this.listBoxLogs.ScrollAlwaysVisible = true;
            this.listBoxLogs.Size = new System.Drawing.Size(851, 411);
            this.listBoxLogs.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(874, 508);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.ForestGreen;
            this.tabPage2.BackgroundImage = global::Chia_Config_GUI.Properties.Resources.Salvia_hispanica_jd_alp_0;
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(866, 481);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "later";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "./conf/config.yaml   configuration tool";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "./conf/keys.yaml   configuration tool";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(273, 14);
            this.label3.TabIndex = 0;
            this.label3.Text = "./conf/plots.yaml   configuration tool";
            // 
            // labelLogDate
            // 
            this.labelLogDate.AutoSize = true;
            this.labelLogDate.Location = new System.Drawing.Point(780, 22);
            this.labelLogDate.Name = "labelLogDate";
            this.labelLogDate.Size = new System.Drawing.Size(28, 14);
            this.labelLogDate.TabIndex = 5;
            this.labelLogDate.Text = "now";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 531);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Configuration Interface for Chia Network";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem logsFolderToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBoxLogNot;
        private System.Windows.Forms.CheckBox checkBoxLogAll;
        private System.Windows.Forms.CheckBox checkBoxLogFarmer;
        private System.Windows.Forms.CheckBox checkBoxLogHarvester;
        private System.Windows.Forms.CheckBox checkBoxLogFullNode;
        private System.Windows.Forms.CheckBox checkBoxLogWallet;
        private System.Windows.Forms.CheckBox checkBoxLogTimelord;
        private System.Windows.Forms.ListBox listBoxLogs;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxLogsPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelLogDate;
    }
}

