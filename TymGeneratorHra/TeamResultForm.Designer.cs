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
            listTymu = new ListBox();
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
            // listTymu
            // 
            listTymu.BackColor = SystemColors.ScrollBar;
            listTymu.FormattingEnabled = true;
            listTymu.Location = new Point(185, 83);
            listTymu.Name = "listTymu";
            listTymu.Size = new Size(253, 444);
            listTymu.TabIndex = 3;
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
            // 
            // TeamResultForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(647, 730);
            Controls.Add(btnClose);
            Controls.Add(listTymu);
            Controls.Add(lblVysledneTymy);
            DoubleBuffered = true;
            Name = "TeamResultForm";
            Text = "TeamResultForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblVysledneTymy;
        private ListBox listTymu;
        private Button btnClose;
    }
}