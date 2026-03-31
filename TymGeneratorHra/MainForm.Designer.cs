namespace TymGeneratorHra
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            fileToolStripMenuItem = new MenuStrip();
            novýToolStripMenuItem = new ToolStripMenuItem();
            MenuNew = new ToolStripMenuItem();
            MenuSave = new ToolStripMenuItem();
            MenuLoad = new ToolStripMenuItem();
            MenuExit = new ToolStripMenuItem();
            lblTymGenerator = new Label();
            listPlayers = new ListBox();
            panel1 = new Panel();
            btnGenerate = new Button();
            numTeams = new NumericUpDown();
            lblPocetTymu = new Label();
            btnClear = new Button();
            btnRemove = new Button();
            btnAdd = new Button();
            numSkill = new NumericUpDown();
            txtName = new TextBox();
            lblSkill = new Label();
            lblName = new Label();
            fileToolStripMenuItem.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numTeams).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSkill).BeginInit();
            SuspendLayout();
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.BackColor = Color.Transparent;
            fileToolStripMenuItem.ImageScalingSize = new Size(20, 20);
            fileToolStripMenuItem.Items.AddRange(new ToolStripItem[] { novýToolStripMenuItem });
            fileToolStripMenuItem.Location = new Point(0, 0);
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(647, 36);
            fileToolStripMenuItem.TabIndex = 0;
            fileToolStripMenuItem.Text = "menuStrip1";
            // 
            // novýToolStripMenuItem
            // 
            novýToolStripMenuItem.BackColor = Color.Transparent;
            novýToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { MenuNew, MenuSave, MenuLoad, MenuExit });
            novýToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            novýToolStripMenuItem.ForeColor = Color.White;
            novýToolStripMenuItem.Name = "novýToolStripMenuItem";
            novýToolStripMenuItem.Size = new Size(56, 32);
            novýToolStripMenuItem.Text = "File";
            // 
            // MenuNew
            // 
            MenuNew.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            MenuNew.Name = "MenuNew";
            MenuNew.Size = new Size(224, 32);
            MenuNew.Text = "Nový";
            MenuNew.Click += MenuNew_Click;
            // 
            // MenuSave
            // 
            MenuSave.Name = "MenuSave";
            MenuSave.Size = new Size(224, 32);
            MenuSave.Text = "Uložit";
            MenuSave.Click += MenuSave_Click;
            // 
            // MenuLoad
            // 
            MenuLoad.Name = "MenuLoad";
            MenuLoad.Size = new Size(224, 32);
            MenuLoad.Text = "Načíst";
            MenuLoad.Click += MenuLoad_Click;
            // 
            // MenuExit
            // 
            MenuExit.Name = "MenuExit";
            MenuExit.Size = new Size(224, 32);
            MenuExit.Text = "Konec";
            MenuExit.Click += MenuExit_Click;
            // 
            // lblTymGenerator
            // 
            lblTymGenerator.AutoSize = true;
            lblTymGenerator.BackColor = Color.Transparent;
            lblTymGenerator.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblTymGenerator.ForeColor = Color.Transparent;
            lblTymGenerator.Location = new Point(185, 34);
            lblTymGenerator.Name = "lblTymGenerator";
            lblTymGenerator.Size = new Size(273, 46);
            lblTymGenerator.TabIndex = 1;
            lblTymGenerator.Text = "Generátor týmů";
            // 
            // listPlayers
            // 
            listPlayers.BackColor = SystemColors.ScrollBar;
            listPlayers.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            listPlayers.FormattingEnabled = true;
            listPlayers.ItemHeight = 23;
            listPlayers.Location = new Point(185, 83);
            listPlayers.Name = "listPlayers";
            listPlayers.Size = new Size(279, 211);
            listPlayers.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnGenerate);
            panel1.Controls.Add(numTeams);
            panel1.Controls.Add(lblPocetTymu);
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(btnRemove);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(numSkill);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(lblSkill);
            panel1.Controls.Add(lblName);
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(185, 300);
            panel1.Name = "panel1";
            panel1.Size = new Size(279, 393);
            panel1.TabIndex = 3;
            // 
            // btnGenerate
            // 
            btnGenerate.BackColor = Color.OrangeRed;
            btnGenerate.FlatStyle = FlatStyle.Flat;
            btnGenerate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnGenerate.ForeColor = Color.White;
            btnGenerate.Location = new Point(19, 304);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(240, 54);
            btnGenerate.TabIndex = 9;
            btnGenerate.Text = "Generovat týmy";
            btnGenerate.UseVisualStyleBackColor = false;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // numTeams
            // 
            numTeams.Location = new Point(131, 257);
            numTeams.Name = "numTeams";
            numTeams.Size = new Size(128, 27);
            numTeams.TabIndex = 8;
            // 
            // lblPocetTymu
            // 
            lblPocetTymu.AutoSize = true;
            lblPocetTymu.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblPocetTymu.ForeColor = Color.Transparent;
            lblPocetTymu.Location = new Point(19, 255);
            lblPocetTymu.Name = "lblPocetTymu";
            lblPocetTymu.Size = new Size(113, 25);
            lblPocetTymu.TabIndex = 7;
            lblPocetTymu.Text = "Počet týmů:";
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.DimGray;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(145, 169);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(114, 54);
            btnClear.TabIndex = 6;
            btnClear.Text = "Reset";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.Firebrick;
            btnRemove.FlatStyle = FlatStyle.Flat;
            btnRemove.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnRemove.ForeColor = Color.White;
            btnRemove.Location = new Point(19, 169);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(114, 54);
            btnRemove.TabIndex = 5;
            btnRemove.Text = "Smazat";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.RoyalBlue;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(19, 109);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(240, 54);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Přidat";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // numSkill
            // 
            numSkill.Location = new Point(109, 55);
            numSkill.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            numSkill.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numSkill.Name = "numSkill";
            numSkill.Size = new Size(150, 27);
            numSkill.TabIndex = 3;
            numSkill.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // txtName
            // 
            txtName.Location = new Point(109, 19);
            txtName.Name = "txtName";
            txtName.Size = new Size(150, 27);
            txtName.TabIndex = 2;
            // 
            // lblSkill
            // 
            lblSkill.AutoSize = true;
            lblSkill.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblSkill.ForeColor = Color.Transparent;
            lblSkill.Location = new Point(19, 53);
            lblSkill.Name = "lblSkill";
            lblSkill.Size = new Size(52, 25);
            lblSkill.TabIndex = 1;
            lblSkill.Text = "Skill:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblName.ForeColor = Color.Transparent;
            lblName.Location = new Point(19, 18);
            lblName.Name = "lblName";
            lblName.Size = new Size(73, 25);
            lblName.TabIndex = 0;
            lblName.Text = "Jméno:";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(647, 730);
            Controls.Add(panel1);
            Controls.Add(listPlayers);
            Controls.Add(lblTymGenerator);
            Controls.Add(fileToolStripMenuItem);
            DoubleBuffered = true;
            MainMenuStrip = fileToolStripMenuItem;
            Name = "MainForm";
            Text = "MainForm";
            fileToolStripMenuItem.ResumeLayout(false);
            fileToolStripMenuItem.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numTeams).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSkill).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip fileToolStripMenuItem;
        private ToolStripMenuItem novýToolStripMenuItem;
        private ToolStripMenuItem MenuNew;
        private ToolStripMenuItem MenuSave;
        private ToolStripMenuItem MenuLoad;
        private ToolStripMenuItem MenuExit;
        private Label lblTymGenerator;
        private ListBox listPlayers;
        private Panel panel1;
        private Label lblSkill;
        private Label lblName;
        private Button btnClear;
        private Button btnRemove;
        private Button btnAdd;
        private NumericUpDown numSkill;
        private TextBox txtName;
        private Button btnGenerate;
        private NumericUpDown numTeams;
        private Label lblPocetTymu;
    }
}
