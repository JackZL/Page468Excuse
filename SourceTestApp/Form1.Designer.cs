namespace SourceTestApp
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.IntensityButton = new System.Windows.Forms.ToolStripButton();
            this.StandardizeButton = new System.Windows.Forms.ToolStripButton();
            this.ShiftTestButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.StatusGroup = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.DomSTD = new System.Windows.Forms.Label();
            this.DomDate = new System.Windows.Forms.DateTimePicker();
            this.DomLabel = new System.Windows.Forms.Label();
            this.HigMegResult = new System.Windows.Forms.Label();
            this.LabelHighMeg = new System.Windows.Forms.Label();
            this.DecayConstantResult = new System.Windows.Forms.Label();
            this.LabelDecay = new System.Windows.Forms.Label();
            this.SerialNumberResult = new System.Windows.Forms.Label();
            this.LabelSerial = new System.Windows.Forms.Label();
            this.PartCombo = new System.Windows.Forms.ComboBox();
            this.PartNo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TestResultLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RatioResultLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.toolStrip1.SuspendLayout();
            this.StatusGroup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.IntensityButton,
            this.StandardizeButton,
            this.ShiftTestButton,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.printToolStripButton,
            this.toolStripSeparator,
            this.helpToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(454, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // IntensityButton
            // 
            this.IntensityButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.IntensityButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.IntensityButton.Image = ((System.Drawing.Image)(resources.GetObject("IntensityButton.Image")));
            this.IntensityButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.IntensityButton.Name = "IntensityButton";
            this.IntensityButton.Size = new System.Drawing.Size(85, 24);
            this.IntensityButton.Text = "Intensity test";
            this.IntensityButton.Click += new System.EventHandler(this.IntensityButton_Click);
            // 
            // StandardizeButton
            // 
            this.StandardizeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.StandardizeButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.StandardizeButton.Image = ((System.Drawing.Image)(resources.GetObject("StandardizeButton.Image")));
            this.StandardizeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.StandardizeButton.Name = "StandardizeButton";
            this.StandardizeButton.Size = new System.Drawing.Size(77, 24);
            this.StandardizeButton.Text = "Standardize";
            // 
            // ShiftTestButton
            // 
            this.ShiftTestButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ShiftTestButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ShiftTestButton.Image = ((System.Drawing.Image)(resources.GetObject("ShiftTestButton.Image")));
            this.ShiftTestButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ShiftTestButton.Name = "ShiftTestButton";
            this.ShiftTestButton.Size = new System.Drawing.Size(64, 24);
            this.ShiftTestButton.Text = "Shift Test";
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(24, 24);
            this.openToolStripButton.Text = "&Open";
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(24, 24);
            this.saveToolStripButton.Text = "&Save";
            // 
            // printToolStripButton
            // 
            this.printToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripButton.Image")));
            this.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripButton.Name = "printToolStripButton";
            this.printToolStripButton.Size = new System.Drawing.Size(24, 24);
            this.printToolStripButton.Text = "&Print";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(24, 24);
            this.helpToolStripButton.Text = "He&lp";
            // 
            // StatusGroup
            // 
            this.StatusGroup.Controls.Add(this.dateTimePicker1);
            this.StatusGroup.Controls.Add(this.DomSTD);
            this.StatusGroup.Controls.Add(this.DomDate);
            this.StatusGroup.Controls.Add(this.DomLabel);
            this.StatusGroup.Controls.Add(this.HigMegResult);
            this.StatusGroup.Controls.Add(this.LabelHighMeg);
            this.StatusGroup.Controls.Add(this.DecayConstantResult);
            this.StatusGroup.Controls.Add(this.LabelDecay);
            this.StatusGroup.Controls.Add(this.SerialNumberResult);
            this.StatusGroup.Controls.Add(this.LabelSerial);
            this.StatusGroup.Controls.Add(this.PartCombo);
            this.StatusGroup.Controls.Add(this.PartNo);
            this.StatusGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.StatusGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusGroup.Location = new System.Drawing.Point(0, 27);
            this.StatusGroup.Name = "StatusGroup";
            this.StatusGroup.Size = new System.Drawing.Size(454, 221);
            this.StatusGroup.TabIndex = 1;
            this.StatusGroup.TabStop = false;
            this.StatusGroup.Text = "Status";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(16, 170);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(150, 21);
            this.dateTimePicker1.TabIndex = 11;
            this.dateTimePicker1.Value = new System.DateTime(2016, 11, 1, 16, 12, 26, 0);
            // 
            // DomSTD
            // 
            this.DomSTD.AutoSize = true;
            this.DomSTD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DomSTD.Location = new System.Drawing.Point(13, 145);
            this.DomSTD.Name = "DomSTD";
            this.DomSTD.Size = new System.Drawing.Size(189, 15);
            this.DomSTD.TabIndex = 10;
            this.DomSTD.Text = "DOM of Standard 标准源制造日期";
            // 
            // DomDate
            // 
            this.DomDate.Location = new System.Drawing.Point(16, 105);
            this.DomDate.Name = "DomDate";
            this.DomDate.Size = new System.Drawing.Size(150, 21);
            this.DomDate.TabIndex = 9;
            // 
            // DomLabel
            // 
            this.DomLabel.AutoSize = true;
            this.DomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DomLabel.Location = new System.Drawing.Point(13, 80);
            this.DomLabel.Name = "DomLabel";
            this.DomLabel.Size = new System.Drawing.Size(154, 15);
            this.DomLabel.TabIndex = 8;
            this.DomLabel.Text = "DOM of Source 源制造日期";
            // 
            // HigMegResult
            // 
            this.HigMegResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HigMegResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HigMegResult.Location = new System.Drawing.Point(267, 170);
            this.HigMegResult.Name = "HigMegResult";
            this.HigMegResult.Size = new System.Drawing.Size(150, 21);
            this.HigMegResult.TabIndex = 7;
            this.HigMegResult.Text = " ";
            // 
            // LabelHighMeg
            // 
            this.LabelHighMeg.AutoSize = true;
            this.LabelHighMeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHighMeg.Location = new System.Drawing.Point(267, 145);
            this.LabelHighMeg.Name = "LabelHighMeg";
            this.LabelHighMeg.Size = new System.Drawing.Size(156, 15);
            this.LabelHighMeg.TabIndex = 6;
            this.LabelHighMeg.Text = "High Meg Setting 阻值设定:";
            // 
            // DecayConstantResult
            // 
            this.DecayConstantResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DecayConstantResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DecayConstantResult.Location = new System.Drawing.Point(267, 105);
            this.DecayConstantResult.Name = "DecayConstantResult";
            this.DecayConstantResult.Size = new System.Drawing.Size(150, 21);
            this.DecayConstantResult.TabIndex = 5;
            this.DecayConstantResult.Text = " ";
            // 
            // LabelDecay
            // 
            this.LabelDecay.AutoSize = true;
            this.LabelDecay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDecay.Location = new System.Drawing.Point(264, 80);
            this.LabelDecay.Name = "LabelDecay";
            this.LabelDecay.Size = new System.Drawing.Size(146, 15);
            this.LabelDecay.TabIndex = 4;
            this.LabelDecay.Text = "Decay Constant 衰减系数:";
            // 
            // SerialNumberResult
            // 
            this.SerialNumberResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SerialNumberResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SerialNumberResult.Location = new System.Drawing.Point(267, 45);
            this.SerialNumberResult.Name = "SerialNumberResult";
            this.SerialNumberResult.Size = new System.Drawing.Size(150, 21);
            this.SerialNumberResult.TabIndex = 3;
            this.SerialNumberResult.Text = " ";
            // 
            // LabelSerial
            // 
            this.LabelSerial.AutoSize = true;
            this.LabelSerial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSerial.Location = new System.Drawing.Point(267, 19);
            this.LabelSerial.Name = "LabelSerial";
            this.LabelSerial.Size = new System.Drawing.Size(100, 15);
            this.LabelSerial.TabIndex = 2;
            this.LabelSerial.Text = "Serial No. 序列号";
            // 
            // PartCombo
            // 
            this.PartCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartCombo.FormattingEnabled = true;
            this.PartCombo.Location = new System.Drawing.Point(16, 45);
            this.PartCombo.Name = "PartCombo";
            this.PartCombo.Size = new System.Drawing.Size(150, 23);
            this.PartCombo.TabIndex = 1;
            this.PartCombo.SelectedIndexChanged += new System.EventHandler(this.PartCombo_SelectedIndexChanged);
            // 
            // PartNo
            // 
            this.PartNo.AutoSize = true;
            this.PartNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartNo.Location = new System.Drawing.Point(13, 20);
            this.PartNo.Name = "PartNo";
            this.PartNo.Size = new System.Drawing.Size(95, 15);
            this.PartNo.TabIndex = 0;
            this.PartNo.Text = "*Part No. 零件号";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TestResultLabel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.RatioResultLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 248);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(454, 96);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Test Result";
            // 
            // TestResultLabel
            // 
            this.TestResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TestResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestResultLabel.Location = new System.Drawing.Point(267, 54);
            this.TestResultLabel.Name = "TestResultLabel";
            this.TestResultLabel.Size = new System.Drawing.Size(150, 21);
            this.TestResultLabel.TabIndex = 14;
            this.TestResultLabel.Text = " ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(267, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Test Result 测试结果";
            // 
            // RatioResultLabel
            // 
            this.RatioResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.RatioResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RatioResultLabel.Location = new System.Drawing.Point(16, 54);
            this.RatioResultLabel.Name = "RatioResultLabel";
            this.RatioResultLabel.Size = new System.Drawing.Size(150, 21);
            this.RatioResultLabel.TabIndex = 12;
            this.RatioResultLabel.Text = " ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ratio 比例系数";
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 344);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(454, 93);
            this.listBox1.TabIndex = 3;
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 300;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 437);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.StatusGroup);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.StatusGroup.ResumeLayout(false);
            this.StatusGroup.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton IntensityButton;
        private System.Windows.Forms.ToolStripButton StandardizeButton;
        private System.Windows.Forms.ToolStripButton ShiftTestButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton printToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.GroupBox StatusGroup;
        private System.Windows.Forms.Label SerialNumberResult;
        private System.Windows.Forms.Label LabelSerial;
        private System.Windows.Forms.ComboBox PartCombo;
        private System.Windows.Forms.Label PartNo;
        private System.Windows.Forms.Label HigMegResult;
        private System.Windows.Forms.Label LabelHighMeg;
        private System.Windows.Forms.Label DecayConstantResult;
        private System.Windows.Forms.Label LabelDecay;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label DomSTD;
        private System.Windows.Forms.DateTimePicker DomDate;
        private System.Windows.Forms.Label DomLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TestResultLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label RatioResultLabel;
        private System.Windows.Forms.ListBox listBox1;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

