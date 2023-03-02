namespace GUI
{
    partial class QuestionAnswerWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuestionAnswerWindow));
            this.theme = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.quest = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.a_1 = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.a_2 = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.a_3 = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.ans_1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ans_2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ans_3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.Score_lbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.team_1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.p_1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.team_2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.p_2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.team_3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.p_3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.team_4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.p_4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.team_5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.p_5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.time = new System.Windows.Forms.ToolStripStatusLabel();
            this.t_time = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.StatusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // theme
            // 
            this.theme.AutoSize = false;
            this.theme.BackColor = System.Drawing.Color.Transparent;
            this.theme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.theme.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.theme.Location = new System.Drawing.Point(0, 0);
            this.theme.Name = "theme";
            this.theme.Size = new System.Drawing.Size(1153, 36);
            this.theme.TabIndex = 0;
            this.theme.Text = "Тема вопроса";
            this.theme.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // quest
            // 
            this.quest.AutoSize = false;
            this.quest.BackColor = System.Drawing.Color.Transparent;
            this.quest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quest.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quest.Location = new System.Drawing.Point(0, 0);
            this.quest.Name = "quest";
            this.quest.Size = new System.Drawing.Size(1153, 141);
            this.quest.TabIndex = 0;
            this.quest.Text = "Вопрос";
            this.quest.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.quest.Click += new System.EventHandler(this.quest_Click);
            // 
            // a_1
            // 
            this.a_1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(145)))), ((int)(((byte)(230)))));
            this.a_1.CheckedState.BorderThickness = 0;
            this.a_1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(145)))), ((int)(((byte)(230)))));
            this.a_1.CheckedState.InnerColor = System.Drawing.Color.White;
            this.a_1.Location = new System.Drawing.Point(3, 192);
            this.a_1.Name = "a_1";
            this.a_1.Size = new System.Drawing.Size(36, 36);
            this.a_1.TabIndex = 1;
            this.a_1.Text = "guna2CustomRadioButton1";
            this.a_1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.a_1.UncheckedState.BorderThickness = 2;
            this.a_1.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.a_1.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.a_1.CheckedChanged += new System.EventHandler(this.a_1_CheckedChanged);
            // 
            // a_2
            // 
            this.a_2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.a_2.CheckedState.BorderThickness = 0;
            this.a_2.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.a_2.CheckedState.InnerColor = System.Drawing.Color.White;
            this.a_2.Location = new System.Drawing.Point(3, 302);
            this.a_2.Name = "a_2";
            this.a_2.Size = new System.Drawing.Size(36, 36);
            this.a_2.TabIndex = 1;
            this.a_2.Text = "guna2CustomRadioButton1";
            this.a_2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.a_2.UncheckedState.BorderThickness = 2;
            this.a_2.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.a_2.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.a_2.CheckedChanged += new System.EventHandler(this.a_1_CheckedChanged);
            // 
            // a_3
            // 
            this.a_3.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.a_3.CheckedState.BorderThickness = 0;
            this.a_3.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.a_3.CheckedState.InnerColor = System.Drawing.Color.White;
            this.a_3.Location = new System.Drawing.Point(3, 412);
            this.a_3.Name = "a_3";
            this.a_3.Size = new System.Drawing.Size(36, 36);
            this.a_3.TabIndex = 1;
            this.a_3.Text = "guna2CustomRadioButton1";
            this.a_3.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.a_3.UncheckedState.BorderThickness = 2;
            this.a_3.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.a_3.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.a_3.CheckedChanged += new System.EventHandler(this.a_1_CheckedChanged);
            // 
            // ans_1
            // 
            this.ans_1.AutoSize = false;
            this.ans_1.BackColor = System.Drawing.Color.Transparent;
            this.ans_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ans_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ans_1.Location = new System.Drawing.Point(0, 0);
            this.ans_1.Name = "ans_1";
            this.ans_1.Size = new System.Drawing.Size(1153, 104);
            this.ans_1.TabIndex = 0;
            this.ans_1.Text = "Ответ 1";
            this.ans_1.Resize += new System.EventHandler(this.ans_1_Resize);
            // 
            // ans_2
            // 
            this.ans_2.AutoSize = false;
            this.ans_2.BackColor = System.Drawing.Color.Transparent;
            this.ans_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ans_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ans_2.Location = new System.Drawing.Point(0, 0);
            this.ans_2.Name = "ans_2";
            this.ans_2.Size = new System.Drawing.Size(1153, 104);
            this.ans_2.TabIndex = 0;
            this.ans_2.Text = "Ответ 2";
            // 
            // ans_3
            // 
            this.ans_3.AutoSize = false;
            this.ans_3.BackColor = System.Drawing.Color.Transparent;
            this.ans_3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ans_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ans_3.Location = new System.Drawing.Point(0, 0);
            this.ans_3.Name = "ans_3";
            this.ans_3.Size = new System.Drawing.Size(1153, 104);
            this.ans_3.TabIndex = 0;
            this.ans_3.Text = "Ответ 3";
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BorderRadius = 62;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(145)))), ((int)(((byte)(230)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI Semibold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(55, 522);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(1153, 126);
            this.guna2Button1.TabIndex = 2;
            this.guna2Button1.Text = "Ответить!";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.125397F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 91.75188F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.122723F));
            this.tableLayoutPanel1.Controls.Add(this.guna2Button1, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.a_1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.a_3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.a_2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.52964F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.47036F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 131F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1264, 651);
            this.tableLayoutPanel1.TabIndex = 3;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.quest);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(55, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1153, 141);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.theme);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(55, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1153, 36);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ans_1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(55, 192);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1153, 104);
            this.panel3.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.ans_2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(55, 302);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1153, 104);
            this.panel4.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.ans_3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(55, 412);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1153, 104);
            this.panel5.TabIndex = 7;
            // 
            // StatusBar
            // 
            this.StatusBar.BackColor = System.Drawing.Color.White;
            this.StatusBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.StatusBar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Score_lbl,
            this.team_1,
            this.p_1,
            this.team_2,
            this.p_2,
            this.team_3,
            this.p_3,
            this.team_4,
            this.p_4,
            this.team_5,
            this.p_5,
            this.time,
            this.t_time});
            this.StatusBar.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.StatusBar.Location = new System.Drawing.Point(0, 651);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.StatusBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StatusBar.Size = new System.Drawing.Size(1264, 30);
            this.StatusBar.SizingGrip = false;
            this.StatusBar.Stretch = false;
            this.StatusBar.TabIndex = 6;
            this.StatusBar.Text = "statusStrip1";
            this.StatusBar.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.StatusBar_ItemClicked);
            // 
            // Score_lbl
            // 
            this.Score_lbl.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.Score_lbl.BorderStyle = System.Windows.Forms.Border3DStyle.Bump;
            this.Score_lbl.Name = "Score_lbl";
            this.Score_lbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Score_lbl.Size = new System.Drawing.Size(58, 25);
            this.Score_lbl.Text = "Счёт: ";
            // 
            // team_1
            // 
            this.team_1.BackColor = System.Drawing.Color.Transparent;
            this.team_1.Name = "team_1";
            this.team_1.Size = new System.Drawing.Size(103, 21);
            this.team_1.Text = "Команда 1 -";
            // 
            // p_1
            // 
            this.p_1.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.p_1.BorderStyle = System.Windows.Forms.Border3DStyle.Bump;
            this.p_1.Name = "p_1";
            this.p_1.Size = new System.Drawing.Size(23, 25);
            this.p_1.Text = "0";
            // 
            // team_2
            // 
            this.team_2.BackColor = System.Drawing.Color.Transparent;
            this.team_2.Name = "team_2";
            this.team_2.Size = new System.Drawing.Size(103, 21);
            this.team_2.Text = "Команда 2 -";
            // 
            // p_2
            // 
            this.p_2.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.p_2.BorderStyle = System.Windows.Forms.Border3DStyle.Bump;
            this.p_2.Name = "p_2";
            this.p_2.Size = new System.Drawing.Size(23, 25);
            this.p_2.Text = "0";
            // 
            // team_3
            // 
            this.team_3.BackColor = System.Drawing.Color.Transparent;
            this.team_3.Name = "team_3";
            this.team_3.Size = new System.Drawing.Size(103, 21);
            this.team_3.Text = "Команда 3 -";
            // 
            // p_3
            // 
            this.p_3.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.p_3.BorderStyle = System.Windows.Forms.Border3DStyle.Bump;
            this.p_3.Name = "p_3";
            this.p_3.Size = new System.Drawing.Size(23, 25);
            this.p_3.Text = "0";
            // 
            // team_4
            // 
            this.team_4.BackColor = System.Drawing.Color.Transparent;
            this.team_4.Name = "team_4";
            this.team_4.Size = new System.Drawing.Size(103, 21);
            this.team_4.Text = "Команда 4 -";
            // 
            // p_4
            // 
            this.p_4.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.p_4.BorderStyle = System.Windows.Forms.Border3DStyle.Bump;
            this.p_4.Name = "p_4";
            this.p_4.Size = new System.Drawing.Size(23, 25);
            this.p_4.Text = "0";
            // 
            // team_5
            // 
            this.team_5.BackColor = System.Drawing.Color.Transparent;
            this.team_5.Name = "team_5";
            this.team_5.Size = new System.Drawing.Size(107, 21);
            this.team_5.Text = "Команда 5 - ";
            // 
            // p_5
            // 
            this.p_5.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.p_5.BorderStyle = System.Windows.Forms.Border3DStyle.Bump;
            this.p_5.Name = "p_5";
            this.p_5.Size = new System.Drawing.Size(23, 25);
            this.p_5.Text = "0";
            // 
            // time
            // 
            this.time.BackColor = System.Drawing.Color.Transparent;
            this.time.Name = "time";
            this.time.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.time.Size = new System.Drawing.Size(216, 21);
            this.time.Text = "Оставшееся время ответа:";
            // 
            // t_time
            // 
            this.t_time.Name = "t_time";
            this.t_time.Size = new System.Drawing.Size(50, 21);
            this.t_time.Text = "00:00";
            // 
            // QuestionAnswerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(255)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.StatusBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "QuestionAnswerWindow";
            this.Text = "Своя игра!";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QuestionAnswerWindow_FormClosing);
            this.Load += new System.EventHandler(this.QuestionAnswerWindow_Load_1);
            this.SizeChanged += new System.EventHandler(this.QuestionAnswerWindow_SizeChanged);
            this.Resize += new System.EventHandler(this.QuestionAnswerWindow_Resize);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.StatusBar.ResumeLayout(false);
            this.StatusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel theme;
        private Guna.UI2.WinForms.Guna2HtmlLabel quest;
        private Guna.UI2.WinForms.Guna2CustomRadioButton a_1;
        private Guna.UI2.WinForms.Guna2CustomRadioButton a_2;
        private Guna.UI2.WinForms.Guna2CustomRadioButton a_3;
        private Guna.UI2.WinForms.Guna2HtmlLabel ans_1;
        private Guna.UI2.WinForms.Guna2HtmlLabel ans_2;
        private Guna.UI2.WinForms.Guna2HtmlLabel ans_3;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.StatusStrip StatusBar;
        private System.Windows.Forms.ToolStripStatusLabel Score_lbl;
        private System.Windows.Forms.ToolStripStatusLabel team_1;
        private System.Windows.Forms.ToolStripStatusLabel p_1;
        private System.Windows.Forms.ToolStripStatusLabel team_2;
        private System.Windows.Forms.ToolStripStatusLabel p_2;
        private System.Windows.Forms.ToolStripStatusLabel team_3;
        private System.Windows.Forms.ToolStripStatusLabel p_3;
        private System.Windows.Forms.ToolStripStatusLabel team_4;
        private System.Windows.Forms.ToolStripStatusLabel p_4;
        private System.Windows.Forms.ToolStripStatusLabel team_5;
        private System.Windows.Forms.ToolStripStatusLabel p_5;
        private System.Windows.Forms.ToolStripStatusLabel time;
        private System.Windows.Forms.ToolStripStatusLabel t_time;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
    }
}