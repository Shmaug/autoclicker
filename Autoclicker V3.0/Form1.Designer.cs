namespace Autoclicker_V3._0
{
    partial class Autoclicker
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
            this._start = new System.Windows.Forms.Button();
            this._stop = new System.Windows.Forms.Button();
            this._testclicks = new System.Windows.Forms.TextBox();
            this._test = new System.Windows.Forms.Button();
            this._spd = new System.Windows.Forms.NumericUpDown();
            this._spdlabel = new System.Windows.Forms.Label();
            this._clicks = new System.Windows.Forms.NumericUpDown();
            this._clickslabel = new System.Windows.Forms.Label();
            this._timer = new System.Windows.Forms.Timer(this.components);
            this._status = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._startKey = new System.Windows.Forms.ComboBox();
            this._stopKey = new System.Windows.Forms.ComboBox();
            this._rehook = new System.Windows.Forms.Button();
            this.textMode = new System.Windows.Forms.CheckBox();
            this.textToSpam = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this._spd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._clicks)).BeginInit();
            this.SuspendLayout();
            // 
            // _start
            // 
            this._start.Location = new System.Drawing.Point(12, 12);
            this._start.Name = "_start";
            this._start.Size = new System.Drawing.Size(75, 73);
            this._start.TabIndex = 0;
            this._start.Text = "Start (U)";
            this._start.UseVisualStyleBackColor = true;
            this._start.Click += new System.EventHandler(this._start_Click);
            // 
            // _stop
            // 
            this._stop.Location = new System.Drawing.Point(12, 91);
            this._stop.Name = "_stop";
            this._stop.Size = new System.Drawing.Size(75, 73);
            this._stop.TabIndex = 1;
            this._stop.Text = "Stop (I)";
            this._stop.UseVisualStyleBackColor = true;
            this._stop.Click += new System.EventHandler(this._stop_Click);
            // 
            // _testclicks
            // 
            this._testclicks.Location = new System.Drawing.Point(232, 13);
            this._testclicks.Name = "_testclicks";
            this._testclicks.ReadOnly = true;
            this._testclicks.Size = new System.Drawing.Size(34, 20);
            this._testclicks.TabIndex = 2;
            // 
            // _test
            // 
            this._test.Location = new System.Drawing.Point(153, 10);
            this._test.Name = "_test";
            this._test.Size = new System.Drawing.Size(75, 23);
            this._test.TabIndex = 4;
            this._test.Text = "Test click";
            this._test.UseVisualStyleBackColor = true;
            this._test.Click += new System.EventHandler(this._test_Click);
            // 
            // _spd
            // 
            this._spd.Location = new System.Drawing.Point(203, 151);
            this._spd.Name = "_spd";
            this._spd.Size = new System.Drawing.Size(70, 20);
            this._spd.TabIndex = 5;
            this._spd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._spd.ValueChanged += new System.EventHandler(this._spd_ValueChanged);
            // 
            // _spdlabel
            // 
            this._spdlabel.AutoSize = true;
            this._spdlabel.Location = new System.Drawing.Point(139, 153);
            this._spdlabel.Name = "_spdlabel";
            this._spdlabel.Size = new System.Drawing.Size(58, 13);
            this._spdlabel.TabIndex = 6;
            this._spdlabel.Text = "Click delay";
            // 
            // _clicks
            // 
            this._clicks.Location = new System.Drawing.Point(203, 120);
            this._clicks.Name = "_clicks";
            this._clicks.Size = new System.Drawing.Size(70, 20);
            this._clicks.TabIndex = 7;
            this._clicks.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._clicks.ValueChanged += new System.EventHandler(this._clicks_ValueChanged);
            // 
            // _clickslabel
            // 
            this._clickslabel.AutoSize = true;
            this._clickslabel.Location = new System.Drawing.Point(115, 122);
            this._clickslabel.Name = "_clickslabel";
            this._clickslabel.Size = new System.Drawing.Size(82, 13);
            this._clickslabel.TabIndex = 8;
            this._clickslabel.Text = "Clicks per frame";
            // 
            // _timer
            // 
            this._timer.Interval = 1;
            this._timer.Tick += new System.EventHandler(this._timer_Tick);
            // 
            // _status
            // 
            this._status.AutoSize = true;
            this._status.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._status.Location = new System.Drawing.Point(93, 6);
            this._status.Name = "_status";
            this._status.Size = new System.Drawing.Size(40, 25);
            this._status.TabIndex = 9;
            this._status.Text = "Off";
            this._status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Start key:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Stop key:";
            // 
            // _startKey
            // 
            this._startKey.FormattingEnabled = true;
            this._startKey.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this._startKey.Location = new System.Drawing.Point(235, 66);
            this._startKey.Name = "_startKey";
            this._startKey.Size = new System.Drawing.Size(33, 21);
            this._startKey.TabIndex = 12;
            this._startKey.SelectedIndexChanged += new System.EventHandler(this._startKey_SelectedIndexChanged);
            // 
            // _stopKey
            // 
            this._stopKey.FormattingEnabled = true;
            this._stopKey.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this._stopKey.Location = new System.Drawing.Point(234, 88);
            this._stopKey.Name = "_stopKey";
            this._stopKey.Size = new System.Drawing.Size(33, 21);
            this._stopKey.TabIndex = 13;
            this._stopKey.SelectedIndexChanged += new System.EventHandler(this._stopKey_SelectedIndexChanged);
            // 
            // _rehook
            // 
            this._rehook.Location = new System.Drawing.Point(93, 66);
            this._rehook.Name = "_rehook";
            this._rehook.Size = new System.Drawing.Size(75, 43);
            this._rehook.TabIndex = 14;
            this._rehook.Text = "Re-hook proc";
            this._rehook.UseVisualStyleBackColor = true;
            this._rehook.Click += new System.EventHandler(this._rehook_Click);
            // 
            // textMode
            // 
            this.textMode.AutoSize = true;
            this.textMode.Location = new System.Drawing.Point(94, 43);
            this.textMode.Name = "textMode";
            this.textMode.Size = new System.Drawing.Size(76, 17);
            this.textMode.TabIndex = 15;
            this.textMode.Text = "Spam text:";
            this.textMode.UseVisualStyleBackColor = true;
            // 
            // textToSpam
            // 
            this.textToSpam.Location = new System.Drawing.Point(169, 40);
            this.textToSpam.Name = "textToSpam";
            this.textToSpam.Size = new System.Drawing.Size(97, 20);
            this.textToSpam.TabIndex = 16;
            // 
            // Autoclicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 178);
            this.Controls.Add(this.textToSpam);
            this.Controls.Add(this.textMode);
            this.Controls.Add(this._rehook);
            this.Controls.Add(this._stopKey);
            this.Controls.Add(this._startKey);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._status);
            this.Controls.Add(this._clickslabel);
            this.Controls.Add(this._clicks);
            this.Controls.Add(this._spdlabel);
            this.Controls.Add(this._spd);
            this.Controls.Add(this._test);
            this.Controls.Add(this._testclicks);
            this.Controls.Add(this._stop);
            this.Controls.Add(this._start);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Autoclicker";
            this.Opacity = 0D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Autoclicker V3.0";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Autoclicker_Load);
            ((System.ComponentModel.ISupportInitialize)(this._spd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._clicks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _start;
        private System.Windows.Forms.Button _stop;
        private System.Windows.Forms.TextBox _testclicks;
        private System.Windows.Forms.Button _test;
        private System.Windows.Forms.NumericUpDown _spd;
        private System.Windows.Forms.Label _spdlabel;
        private System.Windows.Forms.NumericUpDown _clicks;
        private System.Windows.Forms.Label _clickslabel;
        private System.Windows.Forms.Timer _timer;
        private System.Windows.Forms.Label _status;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox _startKey;
        private System.Windows.Forms.ComboBox _stopKey;
        private System.Windows.Forms.Button _rehook;
        private System.Windows.Forms.CheckBox textMode;
        private System.Windows.Forms.TextBox textToSpam;
    }
}

