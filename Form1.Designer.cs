namespace Schere__Stein_Papier
{
    partial class Form1
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
            BScissour = new Button();
            BStone = new Button();
            BPaper = new Button();
            labelVS = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            RESET = new Button();
            B3pt = new Button();
            B1pt = new Button();
            BMenu = new Button();
            SuspendLayout();
            // 
            // BScissour
            // 
            BScissour.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            BScissour.Location = new Point(726, 389);
            BScissour.Name = "BScissour";
            BScissour.Size = new Size(171, 135);
            BScissour.TabIndex = 0;
            BScissour.Text = "✂️";
            BScissour.UseVisualStyleBackColor = true;
            BScissour.Visible = false;
            BScissour.Click += BScissour_Click;
            // 
            // BStone
            // 
            BStone.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            BStone.Location = new Point(411, 389);
            BStone.Name = "BStone";
            BStone.Size = new Size(171, 135);
            BStone.TabIndex = 1;
            BStone.Text = "🗿";
            BStone.UseVisualStyleBackColor = true;
            BStone.Visible = false;
            BStone.Click += BStone_Click;
            // 
            // BPaper
            // 
            BPaper.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            BPaper.Location = new Point(58, 389);
            BPaper.Name = "BPaper";
            BPaper.Size = new Size(171, 135);
            BPaper.TabIndex = 2;
            BPaper.Text = "📃";
            BPaper.UseVisualStyleBackColor = true;
            BPaper.Visible = false;
            BPaper.Click += BPaper_Click;
            // 
            // labelVS
            // 
            labelVS.AutoSize = true;
            labelVS.Font = new Font("Showcard Gothic", 72F, FontStyle.Regular, GraphicsUnit.Point);
            labelVS.Location = new Point(366, 183);
            labelVS.Name = "labelVS";
            labelVS.Size = new Size(241, 177);
            labelVS.TabIndex = 3;
            labelVS.Text = "VS";
            labelVS.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 72F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(369, -8);
            label1.Name = "label1";
            label1.Size = new Size(238, 177);
            label1.TabIndex = 4;
            label1.Text = "📃";
            label1.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 72F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(369, 353);
            label2.Name = "label2";
            label2.Size = new Size(238, 177);
            label2.TabIndex = 5;
            label2.Text = "📃";
            label2.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Black", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Lime;
            label3.Location = new Point(272, 22);
            label3.Name = "label3";
            label3.Size = new Size(401, 128);
            label3.TabIndex = 6;
            label3.Text = "Winner";
            label3.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Black", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Lime;
            label4.Location = new Point(272, 382);
            label4.Name = "label4";
            label4.Size = new Size(401, 128);
            label4.TabIndex = 7;
            label4.Text = "Winner";
            label4.Visible = false;
            // 
            // RESET
            // 
            RESET.BackColor = SystemColors.ButtonFace;
            RESET.Font = new Font("Showcard Gothic", 25F, FontStyle.Bold, GraphicsUnit.Point);
            RESET.ForeColor = Color.Black;
            RESET.Location = new Point(902, 12);
            RESET.Name = "RESET";
            RESET.Size = new Size(58, 67);
            RESET.TabIndex = 9;
            RESET.Text = "🔄";
            RESET.UseVisualStyleBackColor = false;
            RESET.Visible = false;
            RESET.Click += RESET_Click;
            // 
            // B3pt
            // 
            B3pt.Font = new Font("Showcard Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point);
            B3pt.Location = new Point(508, 199);
            B3pt.Name = "B3pt";
            B3pt.Size = new Size(414, 131);
            B3pt.TabIndex = 10;
            B3pt.Text = "3pt.";
            B3pt.UseVisualStyleBackColor = true;
            B3pt.Click += B3pt_Click;
            // 
            // B1pt
            // 
            B1pt.Font = new Font("Showcard Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point);
            B1pt.Location = new Point(43, 199);
            B1pt.Name = "B1pt";
            B1pt.Size = new Size(414, 131);
            B1pt.TabIndex = 11;
            B1pt.Text = "1pt.";
            B1pt.UseVisualStyleBackColor = true;
            B1pt.Click += B1pt_Click;
            // 
            // BMenu
            // 
            BMenu.BackColor = Color.WhiteSmoke;
            BMenu.Font = new Font("Cooper Black", 14F, FontStyle.Regular, GraphicsUnit.Point);
            BMenu.Location = new Point(12, 12);
            BMenu.Name = "BMenu";
            BMenu.Size = new Size(122, 54);
            BMenu.TabIndex = 12;
            BMenu.Text = "MENU";
            BMenu.UseVisualStyleBackColor = false;
            BMenu.Visible = false;
            BMenu.Click += BMenu_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(972, 587);
            Controls.Add(BMenu);
            Controls.Add(B1pt);
            Controls.Add(B3pt);
            Controls.Add(RESET);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelVS);
            Controls.Add(BPaper);
            Controls.Add(BStone);
            Controls.Add(BScissour);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BScissour;
        private Button BStone;
        private Button BPaper;
        private Label labelVS;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button RESET;
        private Button B3pt;
        private Button B1pt;
        private Button BMenu;
    }
}