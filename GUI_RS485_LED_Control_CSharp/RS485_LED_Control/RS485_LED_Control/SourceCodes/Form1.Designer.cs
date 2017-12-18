namespace RS485_LED_Control
{
    partial class Form1
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
            this.Button_LED_Control_D4 = new System.Windows.Forms.Button();
            this.Button_LED_Control_D5 = new System.Windows.Forms.Button();
            this.Button_LED_Control_D2 = new System.Windows.Forms.Button();
            this.Button_LED_Control_D3 = new System.Windows.Forms.Button();
            this.GroupBox_LED_Control = new System.Windows.Forms.GroupBox();
            this.Button_LED_OFF = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ComboBox_ComPort_Selection = new System.Windows.Forms.ComboBox();
            this.ComboBox_BaudRate_Sellection = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.GroupBox_LED_Control.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Button_LED_Control_D4
            // 
            this.Button_LED_Control_D4.Location = new System.Drawing.Point(6, 36);
            this.Button_LED_Control_D4.Name = "Button_LED_Control_D4";
            this.Button_LED_Control_D4.Size = new System.Drawing.Size(84, 55);
            this.Button_LED_Control_D4.TabIndex = 0;
            this.Button_LED_Control_D4.Text = "LED D4";
            this.Button_LED_Control_D4.UseVisualStyleBackColor = true;
            this.Button_LED_Control_D4.Click += new System.EventHandler(this.Button_LED_Control_D4_Click);
            // 
            // Button_LED_Control_D5
            // 
            this.Button_LED_Control_D5.Location = new System.Drawing.Point(96, 36);
            this.Button_LED_Control_D5.Name = "Button_LED_Control_D5";
            this.Button_LED_Control_D5.Size = new System.Drawing.Size(84, 55);
            this.Button_LED_Control_D5.TabIndex = 1;
            this.Button_LED_Control_D5.Text = "LED D5";
            this.Button_LED_Control_D5.UseVisualStyleBackColor = true;
            this.Button_LED_Control_D5.Click += new System.EventHandler(this.Button_LED_Control_D5_Click);
            // 
            // Button_LED_Control_D2
            // 
            this.Button_LED_Control_D2.Location = new System.Drawing.Point(186, 36);
            this.Button_LED_Control_D2.Name = "Button_LED_Control_D2";
            this.Button_LED_Control_D2.Size = new System.Drawing.Size(84, 55);
            this.Button_LED_Control_D2.TabIndex = 2;
            this.Button_LED_Control_D2.Text = "LED D2";
            this.Button_LED_Control_D2.UseVisualStyleBackColor = true;
            this.Button_LED_Control_D2.Click += new System.EventHandler(this.Button_LED_Control_D2_Click);
            // 
            // Button_LED_Control_D3
            // 
            this.Button_LED_Control_D3.Location = new System.Drawing.Point(276, 36);
            this.Button_LED_Control_D3.Name = "Button_LED_Control_D3";
            this.Button_LED_Control_D3.Size = new System.Drawing.Size(84, 55);
            this.Button_LED_Control_D3.TabIndex = 3;
            this.Button_LED_Control_D3.Text = "LED D3";
            this.Button_LED_Control_D3.UseVisualStyleBackColor = true;
            this.Button_LED_Control_D3.Click += new System.EventHandler(this.Button_LED_Control_D3_Click);
            // 
            // GroupBox_LED_Control
            // 
            this.GroupBox_LED_Control.Controls.Add(this.Button_LED_OFF);
            this.GroupBox_LED_Control.Controls.Add(this.Button_LED_Control_D4);
            this.GroupBox_LED_Control.Controls.Add(this.Button_LED_Control_D3);
            this.GroupBox_LED_Control.Controls.Add(this.Button_LED_Control_D5);
            this.GroupBox_LED_Control.Controls.Add(this.Button_LED_Control_D2);
            this.GroupBox_LED_Control.Location = new System.Drawing.Point(12, 170);
            this.GroupBox_LED_Control.Name = "GroupBox_LED_Control";
            this.GroupBox_LED_Control.Size = new System.Drawing.Size(375, 182);
            this.GroupBox_LED_Control.TabIndex = 4;
            this.GroupBox_LED_Control.TabStop = false;
            this.GroupBox_LED_Control.Text = "LED Control";
            // 
            // Button_LED_OFF
            // 
            this.Button_LED_OFF.BackColor = System.Drawing.Color.LightSalmon;
            this.Button_LED_OFF.Location = new System.Drawing.Point(6, 110);
            this.Button_LED_OFF.Name = "Button_LED_OFF";
            this.Button_LED_OFF.Size = new System.Drawing.Size(354, 55);
            this.Button_LED_OFF.TabIndex = 4;
            this.Button_LED_OFF.Text = "ALL LED OFF";
            this.Button_LED_OFF.UseVisualStyleBackColor = false;
            this.Button_LED_OFF.Click += new System.EventHandler(this.Button_LED_OFF_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.ComboBox_BaudRate_Sellection);
            this.groupBox2.Controls.Add(this.ComboBox_ComPort_Selection);
            this.groupBox2.Location = new System.Drawing.Point(12, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(369, 85);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "RS485 Settings";
            // 
            // ComboBox_ComPort_Selection
            // 
            this.ComboBox_ComPort_Selection.FormattingEnabled = true;
            this.ComboBox_ComPort_Selection.Location = new System.Drawing.Point(9, 44);
            this.ComboBox_ComPort_Selection.Name = "ComboBox_ComPort_Selection";
            this.ComboBox_ComPort_Selection.Size = new System.Drawing.Size(121, 21);
            this.ComboBox_ComPort_Selection.TabIndex = 0;
            this.ComboBox_ComPort_Selection.SelectionChangeCommitted += new System.EventHandler(this.ComboBox_ComPort_Selection_SelectionChangeCommitted);
            // 
            // ComboBox_BaudRate_Sellection
            // 
            this.ComboBox_BaudRate_Sellection.FormattingEnabled = true;
            this.ComboBox_BaudRate_Sellection.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200"});
            this.ComboBox_BaudRate_Sellection.Location = new System.Drawing.Point(233, 44);
            this.ComboBox_BaudRate_Sellection.Name = "ComboBox_BaudRate_Sellection";
            this.ComboBox_BaudRate_Sellection.Size = new System.Drawing.Size(121, 21);
            this.ComboBox_BaudRate_Sellection.TabIndex = 1;
            this.ComboBox_BaudRate_Sellection.SelectionChangeCommitted += new System.EventHandler(this.ComboBox_BaudRate_Sellection_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "COM Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Baud Rate";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(294, 28);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(87, 13);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "www.xanthium.in";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(18, 28);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(29, 13);
            this.linkLabel2.TabIndex = 7;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Help";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 363);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.GroupBox_LED_Control);
            this.Name = "Form1";
            this.Text = "RS485 LED Control";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GroupBox_LED_Control.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_LED_Control_D4;
        private System.Windows.Forms.Button Button_LED_Control_D5;
        private System.Windows.Forms.Button Button_LED_Control_D2;
        private System.Windows.Forms.Button Button_LED_Control_D3;
        private System.Windows.Forms.GroupBox GroupBox_LED_Control;
        private System.Windows.Forms.Button Button_LED_OFF;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComboBox_BaudRate_Sellection;
        private System.Windows.Forms.ComboBox ComboBox_ComPort_Selection;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}

