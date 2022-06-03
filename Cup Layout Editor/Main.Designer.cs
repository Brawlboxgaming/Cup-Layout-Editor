namespace CupLayoutEditor
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.RightArrow = new System.Windows.Forms.Button();
            this.LeftArrow = new System.Windows.Forms.Button();
            this.cupCount = new System.Windows.Forms.NumericUpDown();
            this.cupCountLabel = new System.Windows.Forms.Label();
            this.cupPanel1 = new System.Windows.Forms.Panel();
            this.cup1Track4 = new System.Windows.Forms.ComboBox();
            this.cup1Track3 = new System.Windows.Forms.ComboBox();
            this.cup1Track2 = new System.Windows.Forms.ComboBox();
            this.cup1Track1 = new System.Windows.Forms.ComboBox();
            this.cup1Label = new System.Windows.Forms.Label();
            this.cupPanel2 = new System.Windows.Forms.Panel();
            this.cup2Track4 = new System.Windows.Forms.ComboBox();
            this.cup2Track3 = new System.Windows.Forms.ComboBox();
            this.cup2Track2 = new System.Windows.Forms.ComboBox();
            this.cup2Track1 = new System.Windows.Forms.ComboBox();
            this.cup2Label = new System.Windows.Forms.Label();
            this.cupPanel3 = new System.Windows.Forms.Panel();
            this.cup3Track4 = new System.Windows.Forms.ComboBox();
            this.cup3Track3 = new System.Windows.Forms.ComboBox();
            this.cup3Track2 = new System.Windows.Forms.ComboBox();
            this.cup3Track1 = new System.Windows.Forms.ComboBox();
            this.cup3Label = new System.Windows.Forms.Label();
            this.cupPanel4 = new System.Windows.Forms.Panel();
            this.cup4Track4 = new System.Windows.Forms.ComboBox();
            this.cup4Track3 = new System.Windows.Forms.ComboBox();
            this.cup4Track2 = new System.Windows.Forms.ComboBox();
            this.cup4Track1 = new System.Windows.Forms.ComboBox();
            this.cup4Label = new System.Windows.Forms.Label();
            this.cupPanel5 = new System.Windows.Forms.Panel();
            this.cup5Track4 = new System.Windows.Forms.ComboBox();
            this.cup5Track3 = new System.Windows.Forms.ComboBox();
            this.cup5Track2 = new System.Windows.Forms.ComboBox();
            this.cup5Track1 = new System.Windows.Forms.ComboBox();
            this.cup5Label = new System.Windows.Forms.Label();
            this.cupPanel6 = new System.Windows.Forms.Panel();
            this.cup6Track4 = new System.Windows.Forms.ComboBox();
            this.cup6Track3 = new System.Windows.Forms.ComboBox();
            this.cup6Track2 = new System.Windows.Forms.ComboBox();
            this.cup6Track1 = new System.Windows.Forms.ComboBox();
            this.cup6Label = new System.Windows.Forms.Label();
            this.import = new System.Windows.Forms.Button();
            this.export = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cupCount)).BeginInit();
            this.cupPanel1.SuspendLayout();
            this.cupPanel2.SuspendLayout();
            this.cupPanel3.SuspendLayout();
            this.cupPanel4.SuspendLayout();
            this.cupPanel5.SuspendLayout();
            this.cupPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // RightArrow
            // 
            this.RightArrow.Location = new System.Drawing.Point(606, 12);
            this.RightArrow.Name = "RightArrow";
            this.RightArrow.Size = new System.Drawing.Size(29, 334);
            this.RightArrow.TabIndex = 112;
            this.RightArrow.Text = ">";
            this.RightArrow.UseVisualStyleBackColor = true;
            this.RightArrow.Click += new System.EventHandler(this.RightArrow_Click);
            // 
            // LeftArrow
            // 
            this.LeftArrow.Location = new System.Drawing.Point(12, 12);
            this.LeftArrow.Name = "LeftArrow";
            this.LeftArrow.Size = new System.Drawing.Size(29, 334);
            this.LeftArrow.TabIndex = 113;
            this.LeftArrow.Text = "<";
            this.LeftArrow.UseVisualStyleBackColor = true;
            this.LeftArrow.Click += new System.EventHandler(this.LeftArrow_Click);
            // 
            // cupCount
            // 
            this.cupCount.Location = new System.Drawing.Point(47, 365);
            this.cupCount.Maximum = new decimal(new int[] {
            54,
            0,
            0,
            0});
            this.cupCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cupCount.Name = "cupCount";
            this.cupCount.Size = new System.Drawing.Size(54, 20);
            this.cupCount.TabIndex = 115;
            this.cupCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cupCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cupCount.ValueChanged += new System.EventHandler(this.cupCount_ValueChanged);
            // 
            // cupCountLabel
            // 
            this.cupCountLabel.AutoSize = true;
            this.cupCountLabel.Location = new System.Drawing.Point(46, 349);
            this.cupCountLabel.Name = "cupCountLabel";
            this.cupCountLabel.Size = new System.Drawing.Size(57, 13);
            this.cupCountLabel.TabIndex = 114;
            this.cupCountLabel.Text = "Cup Count";
            this.cupCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cupPanel1
            // 
            this.cupPanel1.AutoSize = true;
            this.cupPanel1.BackColor = System.Drawing.Color.Transparent;
            this.cupPanel1.Controls.Add(this.cup1Track4);
            this.cupPanel1.Controls.Add(this.cup1Track3);
            this.cupPanel1.Controls.Add(this.cup1Track2);
            this.cupPanel1.Controls.Add(this.cup1Track1);
            this.cupPanel1.Controls.Add(this.cup1Label);
            this.cupPanel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.cupPanel1.Location = new System.Drawing.Point(47, 12);
            this.cupPanel1.Name = "cupPanel1";
            this.cupPanel1.Size = new System.Drawing.Size(182, 164);
            this.cupPanel1.TabIndex = 117;
            this.cupPanel1.Tag = "cup";
            // 
            // cup1Track4
            // 
            this.cup1Track4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cup1Track4.FormattingEnabled = true;
            this.cup1Track4.Location = new System.Drawing.Point(3, 115);
            this.cup1Track4.Name = "cup1Track4";
            this.cup1Track4.Size = new System.Drawing.Size(176, 21);
            this.cup1Track4.TabIndex = 102;
            // 
            // cup1Track3
            // 
            this.cup1Track3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cup1Track3.FormattingEnabled = true;
            this.cup1Track3.Location = new System.Drawing.Point(3, 88);
            this.cup1Track3.Name = "cup1Track3";
            this.cup1Track3.Size = new System.Drawing.Size(176, 21);
            this.cup1Track3.TabIndex = 101;
            // 
            // cup1Track2
            // 
            this.cup1Track2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cup1Track2.FormattingEnabled = true;
            this.cup1Track2.Location = new System.Drawing.Point(3, 61);
            this.cup1Track2.Name = "cup1Track2";
            this.cup1Track2.Size = new System.Drawing.Size(176, 21);
            this.cup1Track2.TabIndex = 100;
            // 
            // cup1Track1
            // 
            this.cup1Track1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cup1Track1.FormattingEnabled = true;
            this.cup1Track1.Location = new System.Drawing.Point(3, 34);
            this.cup1Track1.Name = "cup1Track1";
            this.cup1Track1.Size = new System.Drawing.Size(176, 21);
            this.cup1Track1.TabIndex = 99;
            // 
            // cup1Label
            // 
            this.cup1Label.AutoSize = true;
            this.cup1Label.Location = new System.Drawing.Point(71, 9);
            this.cup1Label.Name = "cup1Label";
            this.cup1Label.Size = new System.Drawing.Size(35, 13);
            this.cup1Label.TabIndex = 98;
            this.cup1Label.Tag = "cup1";
            this.cup1Label.Text = "Cup 1";
            // 
            // cupPanel2
            // 
            this.cupPanel2.AutoSize = true;
            this.cupPanel2.BackColor = System.Drawing.Color.Transparent;
            this.cupPanel2.Controls.Add(this.cup2Track4);
            this.cupPanel2.Controls.Add(this.cup2Track3);
            this.cupPanel2.Controls.Add(this.cup2Track2);
            this.cupPanel2.Controls.Add(this.cup2Track1);
            this.cupPanel2.Controls.Add(this.cup2Label);
            this.cupPanel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.cupPanel2.Location = new System.Drawing.Point(232, 12);
            this.cupPanel2.Name = "cupPanel2";
            this.cupPanel2.Size = new System.Drawing.Size(182, 164);
            this.cupPanel2.TabIndex = 118;
            this.cupPanel2.Tag = "cup";
            // 
            // cup2Track4
            // 
            this.cup2Track4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cup2Track4.FormattingEnabled = true;
            this.cup2Track4.Location = new System.Drawing.Point(3, 115);
            this.cup2Track4.Name = "cup2Track4";
            this.cup2Track4.Size = new System.Drawing.Size(176, 21);
            this.cup2Track4.TabIndex = 102;
            // 
            // cup2Track3
            // 
            this.cup2Track3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cup2Track3.FormattingEnabled = true;
            this.cup2Track3.Location = new System.Drawing.Point(3, 88);
            this.cup2Track3.Name = "cup2Track3";
            this.cup2Track3.Size = new System.Drawing.Size(176, 21);
            this.cup2Track3.TabIndex = 101;
            // 
            // cup2Track2
            // 
            this.cup2Track2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cup2Track2.FormattingEnabled = true;
            this.cup2Track2.Location = new System.Drawing.Point(3, 61);
            this.cup2Track2.Name = "cup2Track2";
            this.cup2Track2.Size = new System.Drawing.Size(176, 21);
            this.cup2Track2.TabIndex = 100;
            // 
            // cup2Track1
            // 
            this.cup2Track1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cup2Track1.FormattingEnabled = true;
            this.cup2Track1.Location = new System.Drawing.Point(3, 34);
            this.cup2Track1.Name = "cup2Track1";
            this.cup2Track1.Size = new System.Drawing.Size(176, 21);
            this.cup2Track1.TabIndex = 99;
            // 
            // cup2Label
            // 
            this.cup2Label.AutoSize = true;
            this.cup2Label.Location = new System.Drawing.Point(71, 9);
            this.cup2Label.Name = "cup2Label";
            this.cup2Label.Size = new System.Drawing.Size(35, 13);
            this.cup2Label.TabIndex = 98;
            this.cup2Label.Tag = "cup2";
            this.cup2Label.Text = "Cup 2";
            // 
            // cupPanel3
            // 
            this.cupPanel3.AutoSize = true;
            this.cupPanel3.BackColor = System.Drawing.Color.Transparent;
            this.cupPanel3.Controls.Add(this.cup3Track4);
            this.cupPanel3.Controls.Add(this.cup3Track3);
            this.cupPanel3.Controls.Add(this.cup3Track2);
            this.cupPanel3.Controls.Add(this.cup3Track1);
            this.cupPanel3.Controls.Add(this.cup3Label);
            this.cupPanel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.cupPanel3.Location = new System.Drawing.Point(417, 12);
            this.cupPanel3.Name = "cupPanel3";
            this.cupPanel3.Size = new System.Drawing.Size(182, 164);
            this.cupPanel3.TabIndex = 119;
            this.cupPanel3.Tag = "cup";
            // 
            // cup3Track4
            // 
            this.cup3Track4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cup3Track4.FormattingEnabled = true;
            this.cup3Track4.Location = new System.Drawing.Point(3, 115);
            this.cup3Track4.Name = "cup3Track4";
            this.cup3Track4.Size = new System.Drawing.Size(176, 21);
            this.cup3Track4.TabIndex = 102;
            // 
            // cup3Track3
            // 
            this.cup3Track3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cup3Track3.FormattingEnabled = true;
            this.cup3Track3.Location = new System.Drawing.Point(3, 88);
            this.cup3Track3.Name = "cup3Track3";
            this.cup3Track3.Size = new System.Drawing.Size(176, 21);
            this.cup3Track3.TabIndex = 101;
            // 
            // cup3Track2
            // 
            this.cup3Track2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cup3Track2.FormattingEnabled = true;
            this.cup3Track2.Location = new System.Drawing.Point(3, 61);
            this.cup3Track2.Name = "cup3Track2";
            this.cup3Track2.Size = new System.Drawing.Size(176, 21);
            this.cup3Track2.TabIndex = 100;
            // 
            // cup3Track1
            // 
            this.cup3Track1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cup3Track1.FormattingEnabled = true;
            this.cup3Track1.Location = new System.Drawing.Point(3, 34);
            this.cup3Track1.Name = "cup3Track1";
            this.cup3Track1.Size = new System.Drawing.Size(176, 21);
            this.cup3Track1.TabIndex = 99;
            // 
            // cup3Label
            // 
            this.cup3Label.AutoSize = true;
            this.cup3Label.Location = new System.Drawing.Point(71, 9);
            this.cup3Label.Name = "cup3Label";
            this.cup3Label.Size = new System.Drawing.Size(35, 13);
            this.cup3Label.TabIndex = 98;
            this.cup3Label.Tag = "cup3";
            this.cup3Label.Text = "Cup 3";
            // 
            // cupPanel4
            // 
            this.cupPanel4.AutoSize = true;
            this.cupPanel4.BackColor = System.Drawing.Color.Transparent;
            this.cupPanel4.Controls.Add(this.cup4Track4);
            this.cupPanel4.Controls.Add(this.cup4Track3);
            this.cupPanel4.Controls.Add(this.cup4Track2);
            this.cupPanel4.Controls.Add(this.cup4Track1);
            this.cupPanel4.Controls.Add(this.cup4Label);
            this.cupPanel4.Cursor = System.Windows.Forms.Cursors.Default;
            this.cupPanel4.Location = new System.Drawing.Point(47, 182);
            this.cupPanel4.Name = "cupPanel4";
            this.cupPanel4.Size = new System.Drawing.Size(182, 164);
            this.cupPanel4.TabIndex = 120;
            this.cupPanel4.Tag = "cup";
            // 
            // cup4Track4
            // 
            this.cup4Track4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cup4Track4.FormattingEnabled = true;
            this.cup4Track4.Location = new System.Drawing.Point(3, 115);
            this.cup4Track4.Name = "cup4Track4";
            this.cup4Track4.Size = new System.Drawing.Size(176, 21);
            this.cup4Track4.TabIndex = 102;
            // 
            // cup4Track3
            // 
            this.cup4Track3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cup4Track3.FormattingEnabled = true;
            this.cup4Track3.Location = new System.Drawing.Point(3, 88);
            this.cup4Track3.Name = "cup4Track3";
            this.cup4Track3.Size = new System.Drawing.Size(176, 21);
            this.cup4Track3.TabIndex = 101;
            // 
            // cup4Track2
            // 
            this.cup4Track2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cup4Track2.FormattingEnabled = true;
            this.cup4Track2.Location = new System.Drawing.Point(3, 61);
            this.cup4Track2.Name = "cup4Track2";
            this.cup4Track2.Size = new System.Drawing.Size(176, 21);
            this.cup4Track2.TabIndex = 100;
            // 
            // cup4Track1
            // 
            this.cup4Track1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cup4Track1.FormattingEnabled = true;
            this.cup4Track1.Location = new System.Drawing.Point(3, 34);
            this.cup4Track1.Name = "cup4Track1";
            this.cup4Track1.Size = new System.Drawing.Size(176, 21);
            this.cup4Track1.TabIndex = 99;
            // 
            // cup4Label
            // 
            this.cup4Label.AutoSize = true;
            this.cup4Label.Location = new System.Drawing.Point(71, 9);
            this.cup4Label.Name = "cup4Label";
            this.cup4Label.Size = new System.Drawing.Size(35, 13);
            this.cup4Label.TabIndex = 98;
            this.cup4Label.Tag = "cup4";
            this.cup4Label.Text = "Cup 4";
            // 
            // cupPanel5
            // 
            this.cupPanel5.AutoSize = true;
            this.cupPanel5.BackColor = System.Drawing.Color.Transparent;
            this.cupPanel5.Controls.Add(this.cup5Track4);
            this.cupPanel5.Controls.Add(this.cup5Track3);
            this.cupPanel5.Controls.Add(this.cup5Track2);
            this.cupPanel5.Controls.Add(this.cup5Track1);
            this.cupPanel5.Controls.Add(this.cup5Label);
            this.cupPanel5.Cursor = System.Windows.Forms.Cursors.Default;
            this.cupPanel5.Location = new System.Drawing.Point(232, 182);
            this.cupPanel5.Name = "cupPanel5";
            this.cupPanel5.Size = new System.Drawing.Size(182, 164);
            this.cupPanel5.TabIndex = 121;
            this.cupPanel5.Tag = "cup";
            // 
            // cup5Track4
            // 
            this.cup5Track4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cup5Track4.FormattingEnabled = true;
            this.cup5Track4.Location = new System.Drawing.Point(3, 115);
            this.cup5Track4.Name = "cup5Track4";
            this.cup5Track4.Size = new System.Drawing.Size(176, 21);
            this.cup5Track4.TabIndex = 102;
            // 
            // cup5Track3
            // 
            this.cup5Track3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cup5Track3.FormattingEnabled = true;
            this.cup5Track3.Location = new System.Drawing.Point(3, 88);
            this.cup5Track3.Name = "cup5Track3";
            this.cup5Track3.Size = new System.Drawing.Size(176, 21);
            this.cup5Track3.TabIndex = 101;
            // 
            // cup5Track2
            // 
            this.cup5Track2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cup5Track2.FormattingEnabled = true;
            this.cup5Track2.Location = new System.Drawing.Point(3, 61);
            this.cup5Track2.Name = "cup5Track2";
            this.cup5Track2.Size = new System.Drawing.Size(176, 21);
            this.cup5Track2.TabIndex = 100;
            // 
            // cup5Track1
            // 
            this.cup5Track1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cup5Track1.FormattingEnabled = true;
            this.cup5Track1.Location = new System.Drawing.Point(3, 34);
            this.cup5Track1.Name = "cup5Track1";
            this.cup5Track1.Size = new System.Drawing.Size(176, 21);
            this.cup5Track1.TabIndex = 99;
            // 
            // cup5Label
            // 
            this.cup5Label.AutoSize = true;
            this.cup5Label.Location = new System.Drawing.Point(71, 9);
            this.cup5Label.Name = "cup5Label";
            this.cup5Label.Size = new System.Drawing.Size(35, 13);
            this.cup5Label.TabIndex = 98;
            this.cup5Label.Tag = "cup5";
            this.cup5Label.Text = "Cup 5";
            // 
            // cupPanel6
            // 
            this.cupPanel6.AutoSize = true;
            this.cupPanel6.BackColor = System.Drawing.Color.Transparent;
            this.cupPanel6.Controls.Add(this.cup6Track4);
            this.cupPanel6.Controls.Add(this.cup6Track3);
            this.cupPanel6.Controls.Add(this.cup6Track2);
            this.cupPanel6.Controls.Add(this.cup6Track1);
            this.cupPanel6.Controls.Add(this.cup6Label);
            this.cupPanel6.Cursor = System.Windows.Forms.Cursors.Default;
            this.cupPanel6.Location = new System.Drawing.Point(417, 182);
            this.cupPanel6.Name = "cupPanel6";
            this.cupPanel6.Size = new System.Drawing.Size(182, 164);
            this.cupPanel6.TabIndex = 122;
            this.cupPanel6.Tag = "cup";
            // 
            // cup6Track4
            // 
            this.cup6Track4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cup6Track4.FormattingEnabled = true;
            this.cup6Track4.Location = new System.Drawing.Point(3, 115);
            this.cup6Track4.Name = "cup6Track4";
            this.cup6Track4.Size = new System.Drawing.Size(176, 21);
            this.cup6Track4.TabIndex = 102;
            // 
            // cup6Track3
            // 
            this.cup6Track3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cup6Track3.FormattingEnabled = true;
            this.cup6Track3.Location = new System.Drawing.Point(3, 88);
            this.cup6Track3.Name = "cup6Track3";
            this.cup6Track3.Size = new System.Drawing.Size(176, 21);
            this.cup6Track3.TabIndex = 101;
            // 
            // cup6Track2
            // 
            this.cup6Track2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cup6Track2.FormattingEnabled = true;
            this.cup6Track2.Location = new System.Drawing.Point(3, 61);
            this.cup6Track2.Name = "cup6Track2";
            this.cup6Track2.Size = new System.Drawing.Size(176, 21);
            this.cup6Track2.TabIndex = 100;
            // 
            // cup6Track1
            // 
            this.cup6Track1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cup6Track1.FormattingEnabled = true;
            this.cup6Track1.Location = new System.Drawing.Point(3, 34);
            this.cup6Track1.Name = "cup6Track1";
            this.cup6Track1.Size = new System.Drawing.Size(176, 21);
            this.cup6Track1.TabIndex = 99;
            // 
            // cup6Label
            // 
            this.cup6Label.AutoSize = true;
            this.cup6Label.Location = new System.Drawing.Point(71, 9);
            this.cup6Label.Name = "cup6Label";
            this.cup6Label.Size = new System.Drawing.Size(35, 13);
            this.cup6Label.TabIndex = 98;
            this.cup6Label.Tag = "cup6";
            this.cup6Label.Text = "Cup 6";
            // 
            // import
            // 
            this.import.Location = new System.Drawing.Point(440, 362);
            this.import.Name = "import";
            this.import.Size = new System.Drawing.Size(75, 23);
            this.import.TabIndex = 124;
            this.import.Text = "Import";
            this.import.UseVisualStyleBackColor = true;
            this.import.Click += new System.EventHandler(this.import_Click);
            // 
            // export
            // 
            this.export.Location = new System.Drawing.Point(521, 362);
            this.export.Name = "export";
            this.export.Size = new System.Drawing.Size(75, 23);
            this.export.TabIndex = 123;
            this.export.Text = "Export";
            this.export.UseVisualStyleBackColor = true;
            this.export.Click += new System.EventHandler(this.export_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 392);
            this.Controls.Add(this.import);
            this.Controls.Add(this.export);
            this.Controls.Add(this.cupPanel6);
            this.Controls.Add(this.cupPanel5);
            this.Controls.Add(this.cupPanel4);
            this.Controls.Add(this.cupPanel3);
            this.Controls.Add(this.cupPanel2);
            this.Controls.Add(this.cupPanel1);
            this.Controls.Add(this.cupCount);
            this.Controls.Add(this.cupCountLabel);
            this.Controls.Add(this.LeftArrow);
            this.Controls.Add(this.RightArrow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Cup Layout Editor";
            ((System.ComponentModel.ISupportInitialize)(this.cupCount)).EndInit();
            this.cupPanel1.ResumeLayout(false);
            this.cupPanel1.PerformLayout();
            this.cupPanel2.ResumeLayout(false);
            this.cupPanel2.PerformLayout();
            this.cupPanel3.ResumeLayout(false);
            this.cupPanel3.PerformLayout();
            this.cupPanel4.ResumeLayout(false);
            this.cupPanel4.PerformLayout();
            this.cupPanel5.ResumeLayout(false);
            this.cupPanel5.PerformLayout();
            this.cupPanel6.ResumeLayout(false);
            this.cupPanel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RightArrow;
        private System.Windows.Forms.Button LeftArrow;
        private System.Windows.Forms.NumericUpDown cupCount;
        private System.Windows.Forms.Label cupCountLabel;
        private System.Windows.Forms.Panel cupPanel1;
        private System.Windows.Forms.ComboBox cup1Track4;
        private System.Windows.Forms.ComboBox cup1Track3;
        private System.Windows.Forms.ComboBox cup1Track2;
        private System.Windows.Forms.ComboBox cup1Track1;
        private System.Windows.Forms.Label cup1Label;
        private System.Windows.Forms.Panel cupPanel2;
        private System.Windows.Forms.ComboBox cup2Track4;
        private System.Windows.Forms.ComboBox cup2Track3;
        private System.Windows.Forms.ComboBox cup2Track2;
        private System.Windows.Forms.ComboBox cup2Track1;
        private System.Windows.Forms.Label cup2Label;
        private System.Windows.Forms.Panel cupPanel3;
        private System.Windows.Forms.ComboBox cup3Track4;
        private System.Windows.Forms.ComboBox cup3Track3;
        private System.Windows.Forms.ComboBox cup3Track2;
        private System.Windows.Forms.ComboBox cup3Track1;
        private System.Windows.Forms.Label cup3Label;
        private System.Windows.Forms.Panel cupPanel4;
        private System.Windows.Forms.ComboBox cup4Track4;
        private System.Windows.Forms.ComboBox cup4Track3;
        private System.Windows.Forms.ComboBox cup4Track2;
        private System.Windows.Forms.ComboBox cup4Track1;
        private System.Windows.Forms.Label cup4Label;
        private System.Windows.Forms.Panel cupPanel5;
        private System.Windows.Forms.ComboBox cup5Track4;
        private System.Windows.Forms.ComboBox cup5Track3;
        private System.Windows.Forms.ComboBox cup5Track2;
        private System.Windows.Forms.ComboBox cup5Track1;
        private System.Windows.Forms.Label cup5Label;
        private System.Windows.Forms.Panel cupPanel6;
        private System.Windows.Forms.ComboBox cup6Track4;
        private System.Windows.Forms.ComboBox cup6Track3;
        private System.Windows.Forms.ComboBox cup6Track2;
        private System.Windows.Forms.ComboBox cup6Track1;
        private System.Windows.Forms.Label cup6Label;
        private System.Windows.Forms.Button import;
        private System.Windows.Forms.Button export;
    }
}

