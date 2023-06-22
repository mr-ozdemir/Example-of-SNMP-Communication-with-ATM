namespace BoardController
{
    partial class Board
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Board));
            this.CloseAllBut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.ConnectBut = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TimeBox = new System.Windows.Forms.ComboBox();
            this.M1Open = new System.Windows.Forms.Button();
            this.M1Close = new System.Windows.Forms.Button();
            this.M2Close = new System.Windows.Forms.Button();
            this.M2Open = new System.Windows.Forms.Button();
            this.Alarm = new System.Windows.Forms.Button();
            this.Led = new System.Windows.Forms.Button();
            this.Selenoid = new System.Windows.Forms.Button();
            this.Role4 = new System.Windows.Forms.Button();
            this.DissConnectBut = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Control = new System.Windows.Forms.TabPage();
            this.Testing = new System.Windows.Forms.TabPage();
            this.TestM2OP = new System.Windows.Forms.Button();
            this.TestM2CLO = new System.Windows.Forms.Button();
            this.TestM1CLO = new System.Windows.Forms.Button();
            this.TestM1OP = new System.Windows.Forms.Button();
            this.CloseAllBut2 = new System.Windows.Forms.Button();
            this.CloseTestLab = new System.Windows.Forms.Label();
            this.OpenTestLab = new System.Windows.Forms.Label();
            this.FinishBut = new System.Windows.Forms.Button();
            this.StartBut = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TestQuantityBox = new System.Windows.Forms.ComboBox();
            this.StandbyTimeBox = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.Control.SuspendLayout();
            this.Testing.SuspendLayout();
            this.SuspendLayout();
            // 
            // CloseAllBut
            // 
            this.CloseAllBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.CloseAllBut, "CloseAllBut");
            this.CloseAllBut.Name = "CloseAllBut";
            this.CloseAllBut.UseVisualStyleBackColor = false;
            this.CloseAllBut.Click += new System.EventHandler(this.CloseAll_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // textBox2
            // 
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.Name = "textBox2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // textBox3
            // 
            resources.ApplyResources(this.textBox3, "textBox3");
            this.textBox3.Name = "textBox3";
            // 
            // ConnectBut
            // 
            resources.ApplyResources(this.ConnectBut, "ConnectBut");
            this.ConnectBut.Name = "ConnectBut";
            this.ConnectBut.UseVisualStyleBackColor = true;
            this.ConnectBut.Click += new System.EventHandler(this.Connect_Click);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // TimeBox
            // 
            this.TimeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TimeBox.FormattingEnabled = true;
            this.TimeBox.Items.AddRange(new object[] {
            resources.GetString("TimeBox.Items"),
            resources.GetString("TimeBox.Items1"),
            resources.GetString("TimeBox.Items2"),
            resources.GetString("TimeBox.Items3"),
            resources.GetString("TimeBox.Items4"),
            resources.GetString("TimeBox.Items5"),
            resources.GetString("TimeBox.Items6"),
            resources.GetString("TimeBox.Items7"),
            resources.GetString("TimeBox.Items8"),
            resources.GetString("TimeBox.Items9"),
            resources.GetString("TimeBox.Items10"),
            resources.GetString("TimeBox.Items11")});
            resources.ApplyResources(this.TimeBox, "TimeBox");
            this.TimeBox.Name = "TimeBox";
            this.TimeBox.SelectedIndexChanged += new System.EventHandler(this.TimeBox_SelectedIndexChanged);
            // 
            // M1Open
            // 
            resources.ApplyResources(this.M1Open, "M1Open");
            this.M1Open.Name = "M1Open";
            this.M1Open.UseVisualStyleBackColor = true;
            this.M1Open.Click += new System.EventHandler(this.M1open_Click);
            // 
            // M1Close
            // 
            resources.ApplyResources(this.M1Close, "M1Close");
            this.M1Close.Name = "M1Close";
            this.M1Close.UseVisualStyleBackColor = true;
            this.M1Close.Click += new System.EventHandler(this.M1close_Click);
            // 
            // M2Close
            // 
            resources.ApplyResources(this.M2Close, "M2Close");
            this.M2Close.Name = "M2Close";
            this.M2Close.UseVisualStyleBackColor = true;
            this.M2Close.Click += new System.EventHandler(this.M2Close_Click);
            // 
            // M2Open
            // 
            resources.ApplyResources(this.M2Open, "M2Open");
            this.M2Open.Name = "M2Open";
            this.M2Open.UseVisualStyleBackColor = true;
            this.M2Open.Click += new System.EventHandler(this.M2Open_Click);
            // 
            // Alarm
            // 
            resources.ApplyResources(this.Alarm, "Alarm");
            this.Alarm.Name = "Alarm";
            this.Alarm.UseVisualStyleBackColor = true;
            this.Alarm.Click += new System.EventHandler(this.Alarm_Click);
            // 
            // Led
            // 
            resources.ApplyResources(this.Led, "Led");
            this.Led.Name = "Led";
            this.Led.UseVisualStyleBackColor = true;
            this.Led.Click += new System.EventHandler(this.Led_Click);
            // 
            // Selenoid
            // 
            resources.ApplyResources(this.Selenoid, "Selenoid");
            this.Selenoid.Name = "Selenoid";
            this.Selenoid.UseVisualStyleBackColor = true;
            this.Selenoid.Click += new System.EventHandler(this.Selenoid_Click);
            // 
            // Role4
            // 
            resources.ApplyResources(this.Role4, "Role4");
            this.Role4.Name = "Role4";
            this.Role4.UseVisualStyleBackColor = true;
            this.Role4.Click += new System.EventHandler(this.Role4_Click);
            // 
            // DissConnectBut
            // 
            resources.ApplyResources(this.DissConnectBut, "DissConnectBut");
            this.DissConnectBut.Name = "DissConnectBut";
            this.DissConnectBut.UseVisualStyleBackColor = true;
            this.DissConnectBut.Click += new System.EventHandler(this.button3_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Control);
            this.tabControl1.Controls.Add(this.Testing);
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // Control
            // 
            this.Control.BackColor = System.Drawing.SystemColors.Control;
            this.Control.Controls.Add(this.Alarm);
            this.Control.Controls.Add(this.DissConnectBut);
            this.Control.Controls.Add(this.CloseAllBut);
            this.Control.Controls.Add(this.Role4);
            this.Control.Controls.Add(this.label1);
            this.Control.Controls.Add(this.Selenoid);
            this.Control.Controls.Add(this.label2);
            this.Control.Controls.Add(this.Led);
            this.Control.Controls.Add(this.textBox1);
            this.Control.Controls.Add(this.textBox2);
            this.Control.Controls.Add(this.M2Open);
            this.Control.Controls.Add(this.label3);
            this.Control.Controls.Add(this.M2Close);
            this.Control.Controls.Add(this.textBox3);
            this.Control.Controls.Add(this.M1Close);
            this.Control.Controls.Add(this.ConnectBut);
            this.Control.Controls.Add(this.M1Open);
            this.Control.Controls.Add(this.label4);
            this.Control.Controls.Add(this.TimeBox);
            resources.ApplyResources(this.Control, "Control");
            this.Control.Name = "Control";
            // 
            // Testing
            // 
            this.Testing.BackColor = System.Drawing.SystemColors.Control;
            this.Testing.Controls.Add(this.TestM2OP);
            this.Testing.Controls.Add(this.TestM2CLO);
            this.Testing.Controls.Add(this.TestM1CLO);
            this.Testing.Controls.Add(this.TestM1OP);
            this.Testing.Controls.Add(this.CloseAllBut2);
            this.Testing.Controls.Add(this.CloseTestLab);
            this.Testing.Controls.Add(this.OpenTestLab);
            this.Testing.Controls.Add(this.FinishBut);
            this.Testing.Controls.Add(this.StartBut);
            this.Testing.Controls.Add(this.label6);
            this.Testing.Controls.Add(this.label5);
            this.Testing.Controls.Add(this.TestQuantityBox);
            this.Testing.Controls.Add(this.StandbyTimeBox);
            resources.ApplyResources(this.Testing, "Testing");
            this.Testing.Name = "Testing";
            // 
            // TestM2OP
            // 
            resources.ApplyResources(this.TestM2OP, "TestM2OP");
            this.TestM2OP.Name = "TestM2OP";
            this.TestM2OP.UseVisualStyleBackColor = true;
            this.TestM2OP.Click += new System.EventHandler(this.TestM2OP_Click);
            // 
            // TestM2CLO
            // 
            resources.ApplyResources(this.TestM2CLO, "TestM2CLO");
            this.TestM2CLO.Name = "TestM2CLO";
            this.TestM2CLO.UseVisualStyleBackColor = true;
            this.TestM2CLO.Click += new System.EventHandler(this.TestM2CLO_Click);
            // 
            // TestM1CLO
            // 
            resources.ApplyResources(this.TestM1CLO, "TestM1CLO");
            this.TestM1CLO.Name = "TestM1CLO";
            this.TestM1CLO.UseVisualStyleBackColor = true;
            this.TestM1CLO.Click += new System.EventHandler(this.TestM1CLO_Click);
            // 
            // TestM1OP
            // 
            resources.ApplyResources(this.TestM1OP, "TestM1OP");
            this.TestM1OP.Name = "TestM1OP";
            this.TestM1OP.UseVisualStyleBackColor = true;
            this.TestM1OP.Click += new System.EventHandler(this.TestM1OP_Click);
            // 
            // CloseAllBut2
            // 
            this.CloseAllBut2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.CloseAllBut2, "CloseAllBut2");
            this.CloseAllBut2.Name = "CloseAllBut2";
            this.CloseAllBut2.UseVisualStyleBackColor = false;
            this.CloseAllBut2.Click += new System.EventHandler(this.CloseAllBut2_Click);
            // 
            // CloseTestLab
            // 
            resources.ApplyResources(this.CloseTestLab, "CloseTestLab");
            this.CloseTestLab.Name = "CloseTestLab";
            // 
            // OpenTestLab
            // 
            resources.ApplyResources(this.OpenTestLab, "OpenTestLab");
            this.OpenTestLab.Name = "OpenTestLab";
            // 
            // FinishBut
            // 
            resources.ApplyResources(this.FinishBut, "FinishBut");
            this.FinishBut.Name = "FinishBut";
            this.FinishBut.UseVisualStyleBackColor = true;
            this.FinishBut.Click += new System.EventHandler(this.FinishBut_Click);
            // 
            // StartBut
            // 
            resources.ApplyResources(this.StartBut, "StartBut");
            this.StartBut.Name = "StartBut";
            this.StartBut.UseVisualStyleBackColor = true;
            this.StartBut.Click += new System.EventHandler(this.StartBut_Click);
            // 
            // label6
            // 
            this.label6.AllowDrop = true;
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label5
            // 
            this.label5.AllowDrop = true;
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // TestQuantityBox
            // 
            this.TestQuantityBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.TestQuantityBox, "TestQuantityBox");
            this.TestQuantityBox.FormattingEnabled = true;
            this.TestQuantityBox.Items.AddRange(new object[] {
            resources.GetString("TestQuantityBox.Items"),
            resources.GetString("TestQuantityBox.Items1"),
            resources.GetString("TestQuantityBox.Items2"),
            resources.GetString("TestQuantityBox.Items3"),
            resources.GetString("TestQuantityBox.Items4"),
            resources.GetString("TestQuantityBox.Items5"),
            resources.GetString("TestQuantityBox.Items6")});
            this.TestQuantityBox.Name = "TestQuantityBox";
            this.TestQuantityBox.SelectedIndexChanged += new System.EventHandler(this.TestQuantityBox_SelectedIndexChanged);
            // 
            // StandbyTimeBox
            // 
            this.StandbyTimeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.StandbyTimeBox, "StandbyTimeBox");
            this.StandbyTimeBox.FormattingEnabled = true;
            this.StandbyTimeBox.Items.AddRange(new object[] {
            resources.GetString("StandbyTimeBox.Items"),
            resources.GetString("StandbyTimeBox.Items1"),
            resources.GetString("StandbyTimeBox.Items2"),
            resources.GetString("StandbyTimeBox.Items3"),
            resources.GetString("StandbyTimeBox.Items4"),
            resources.GetString("StandbyTimeBox.Items5"),
            resources.GetString("StandbyTimeBox.Items6"),
            resources.GetString("StandbyTimeBox.Items7"),
            resources.GetString("StandbyTimeBox.Items8"),
            resources.GetString("StandbyTimeBox.Items9"),
            resources.GetString("StandbyTimeBox.Items10")});
            this.StandbyTimeBox.Name = "StandbyTimeBox";
            this.StandbyTimeBox.SelectedIndexChanged += new System.EventHandler(this.StandbyTimeBox_SelectedIndexChanged);
            // 
            // Board
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "Board";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Board_FormClosing);
            this.Load += new System.EventHandler(this.Board_Load);
            this.tabControl1.ResumeLayout(false);
            this.Control.ResumeLayout(false);
            this.Control.PerformLayout();
            this.Testing.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CloseAllBut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button ConnectBut;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox TimeBox;
        private System.Windows.Forms.Button M1Open;
        private System.Windows.Forms.Button M1Close;
        private System.Windows.Forms.Button M2Close;
        private System.Windows.Forms.Button M2Open;
        private System.Windows.Forms.Button Alarm;
        private System.Windows.Forms.Button Led;
        private System.Windows.Forms.Button Selenoid;
        private System.Windows.Forms.Button Role4;
        private System.Windows.Forms.Button DissConnectBut;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Control;
        private System.Windows.Forms.Button FinishBut;
        private System.Windows.Forms.Button StartBut;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox TestQuantityBox;
        private System.Windows.Forms.ComboBox StandbyTimeBox;
        private System.Windows.Forms.TabPage Testing;
        private System.Windows.Forms.Label OpenTestLab;
        private System.Windows.Forms.Label CloseTestLab;
        private System.Windows.Forms.Button CloseAllBut2;
        private System.Windows.Forms.Button TestM2OP;
        private System.Windows.Forms.Button TestM2CLO;
        private System.Windows.Forms.Button TestM1CLO;
        private System.Windows.Forms.Button TestM1OP;
    }
}

