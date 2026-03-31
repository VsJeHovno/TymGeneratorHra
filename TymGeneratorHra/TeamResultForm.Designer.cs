namespace TymGeneratorHra
{
    partial class TeamResultForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeamResultForm));
            lblVysledneTymy = new Label();
            listTeams = new ListBox();
            btnClose = new Button();
            SuspendLayout();
            // 
            // lblVysledneTymy
            // 
            lblVysledneTymy.AutoSize = true;
            lblVysledneTymy.BackColor = Color.Transparent;
            lblVysledneTymy.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblVysledneTymy.ForeColor = Color.Transparent;
            lblVysledneTymy.Location = new Point(185, 34);
            lblVysledneTymy.Name = "lblVysledneTymy";
            lblVysledneTymy.Size = new Size(253, 46);
            lblVysledneTymy.TabIndex = 2;
            lblVysledneTymy.Text = "Výsledné týmy";
            // 
            // listTeams
            // 
            listTeams.BackColor = SystemColors.ScrollBar;
            listTeams.FormattingEnabled = true;
            listTeams.Location = new Point(185, 83);
            listTeams.Name = "listTeams";
            listTeams.Size = new Size(253, 444);
            listTeams.TabIndex = 3;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.SteelBlue;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(185, 555);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(253, 54);
            btnClose.TabIndex = 5;
            btnClose.Text = "Zavřít";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // TeamResultForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(647, 730);
            Controls.Add(btnClose);
            Controls.Add(listTeams);
            Controls.Add(lblVysledneTymy);
            DoubleBuffered = true;
            Name = "TeamResultForm";
            Text = "TeamResultForm";
            Load += TeamResultForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblVysledneTymy;
        private ListBox listTeams;
        private Button btnClose;
    }
}