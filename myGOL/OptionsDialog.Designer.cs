namespace myGOL
{
    partial class OptionsDialog
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
            this.aButtonOK = new System.Windows.Forms.Button();
            this.aButtonCancel = new System.Windows.Forms.Button();
            this.aTabControl = new System.Windows.Forms.TabControl();
            this.aTabPageGeneral = new System.Windows.Forms.TabPage();
            this.aUpDownHeight = new System.Windows.Forms.NumericUpDown();
            this.aUpDownWidth = new System.Windows.Forms.NumericUpDown();
            this.aUpDownTime = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.aTabPageView = new System.Windows.Forms.TabPage();
            this.aButtonReset = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.aButtonLiveCellColor = new System.Windows.Forms.Button();
            this.aButtonBackgroundColor = new System.Windows.Forms.Button();
            this.aButtonGridColor = new System.Windows.Forms.Button();
            this.aTabPageAdvanced = new System.Windows.Forms.TabPage();
            this.aGroupBoxBoundary = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.aRadioButtonFinite = new System.Windows.Forms.RadioButton();
            this.aRadioButtonToroidal = new System.Windows.Forms.RadioButton();
            this.aTabControl.SuspendLayout();
            this.aTabPageGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aUpDownHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aUpDownWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aUpDownTime)).BeginInit();
            this.aTabPageView.SuspendLayout();
            this.aTabPageAdvanced.SuspendLayout();
            this.aGroupBoxBoundary.SuspendLayout();
            this.SuspendLayout();
            // 
            // aButtonOK
            // 
            this.aButtonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.aButtonOK.Location = new System.Drawing.Point(78, 238);
            this.aButtonOK.Name = "aButtonOK";
            this.aButtonOK.Size = new System.Drawing.Size(75, 23);
            this.aButtonOK.TabIndex = 0;
            this.aButtonOK.Text = "OK";
            this.aButtonOK.UseVisualStyleBackColor = true;
            // 
            // aButtonCancel
            // 
            this.aButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.aButtonCancel.Location = new System.Drawing.Point(159, 238);
            this.aButtonCancel.Name = "aButtonCancel";
            this.aButtonCancel.Size = new System.Drawing.Size(75, 23);
            this.aButtonCancel.TabIndex = 1;
            this.aButtonCancel.Text = "Cancel";
            this.aButtonCancel.UseVisualStyleBackColor = true;
            // 
            // aTabControl
            // 
            this.aTabControl.Controls.Add(this.aTabPageGeneral);
            this.aTabControl.Controls.Add(this.aTabPageView);
            this.aTabControl.Controls.Add(this.aTabPageAdvanced);
            this.aTabControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.aTabControl.Location = new System.Drawing.Point(0, 0);
            this.aTabControl.Name = "aTabControl";
            this.aTabControl.SelectedIndex = 0;
            this.aTabControl.Size = new System.Drawing.Size(330, 232);
            this.aTabControl.TabIndex = 2;
            // 
            // aTabPageGeneral
            // 
            this.aTabPageGeneral.Controls.Add(this.aUpDownHeight);
            this.aTabPageGeneral.Controls.Add(this.aUpDownWidth);
            this.aTabPageGeneral.Controls.Add(this.aUpDownTime);
            this.aTabPageGeneral.Controls.Add(this.label3);
            this.aTabPageGeneral.Controls.Add(this.label2);
            this.aTabPageGeneral.Controls.Add(this.label1);
            this.aTabPageGeneral.Location = new System.Drawing.Point(4, 22);
            this.aTabPageGeneral.Name = "aTabPageGeneral";
            this.aTabPageGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.aTabPageGeneral.Size = new System.Drawing.Size(322, 206);
            this.aTabPageGeneral.TabIndex = 0;
            this.aTabPageGeneral.Text = "General";
            this.aTabPageGeneral.UseVisualStyleBackColor = true;
            // 
            // aUpDownHeight
            // 
            this.aUpDownHeight.Location = new System.Drawing.Point(196, 93);
            this.aUpDownHeight.Name = "aUpDownHeight";
            this.aUpDownHeight.Size = new System.Drawing.Size(70, 20);
            this.aUpDownHeight.TabIndex = 5;
            // 
            // aUpDownWidth
            // 
            this.aUpDownWidth.Location = new System.Drawing.Point(196, 58);
            this.aUpDownWidth.Name = "aUpDownWidth";
            this.aUpDownWidth.Size = new System.Drawing.Size(70, 20);
            this.aUpDownWidth.TabIndex = 4;
            // 
            // aUpDownTime
            // 
            this.aUpDownTime.Location = new System.Drawing.Point(196, 18);
            this.aUpDownTime.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.aUpDownTime.Name = "aUpDownTime";
            this.aUpDownTime.Size = new System.Drawing.Size(70, 20);
            this.aUpDownTime.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Height of Universe in Cells";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Width of Universe in Cells";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Timer Interval in Milliseconds";
            // 
            // aTabPageView
            // 
            this.aTabPageView.Controls.Add(this.aButtonReset);
            this.aTabPageView.Controls.Add(this.label7);
            this.aTabPageView.Controls.Add(this.label6);
            this.aTabPageView.Controls.Add(this.label4);
            this.aTabPageView.Controls.Add(this.aButtonLiveCellColor);
            this.aTabPageView.Controls.Add(this.aButtonBackgroundColor);
            this.aTabPageView.Controls.Add(this.aButtonGridColor);
            this.aTabPageView.Location = new System.Drawing.Point(4, 22);
            this.aTabPageView.Name = "aTabPageView";
            this.aTabPageView.Padding = new System.Windows.Forms.Padding(3);
            this.aTabPageView.Size = new System.Drawing.Size(322, 206);
            this.aTabPageView.TabIndex = 1;
            this.aTabPageView.Text = "View";
            this.aTabPageView.UseVisualStyleBackColor = true;
            // 
            // aButtonReset
            // 
            this.aButtonReset.Location = new System.Drawing.Point(8, 177);
            this.aButtonReset.Name = "aButtonReset";
            this.aButtonReset.Size = new System.Drawing.Size(75, 23);
            this.aButtonReset.TabIndex = 8;
            this.aButtonReset.Text = "Reset";
            this.aButtonReset.UseVisualStyleBackColor = true;
            this.aButtonReset.Click += new System.EventHandler(this.aButtonReset_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(114, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Live Cell Color";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(114, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Background Color";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(114, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Grid Color";
            // 
            // aButtonLiveCellColor
            // 
            this.aButtonLiveCellColor.Location = new System.Drawing.Point(74, 89);
            this.aButtonLiveCellColor.Name = "aButtonLiveCellColor";
            this.aButtonLiveCellColor.Size = new System.Drawing.Size(34, 23);
            this.aButtonLiveCellColor.TabIndex = 3;
            this.aButtonLiveCellColor.UseVisualStyleBackColor = true;
            this.aButtonLiveCellColor.Click += new System.EventHandler(this.aButtonLiveCellColor_Click);
            // 
            // aButtonBackgroundColor
            // 
            this.aButtonBackgroundColor.Location = new System.Drawing.Point(74, 60);
            this.aButtonBackgroundColor.Name = "aButtonBackgroundColor";
            this.aButtonBackgroundColor.Size = new System.Drawing.Size(34, 23);
            this.aButtonBackgroundColor.TabIndex = 2;
            this.aButtonBackgroundColor.UseVisualStyleBackColor = true;
            this.aButtonBackgroundColor.Click += new System.EventHandler(this.aButtonBackgroundColor_Click);
            // 
            // aButtonGridColor
            // 
            this.aButtonGridColor.Location = new System.Drawing.Point(74, 31);
            this.aButtonGridColor.Name = "aButtonGridColor";
            this.aButtonGridColor.Size = new System.Drawing.Size(34, 23);
            this.aButtonGridColor.TabIndex = 0;
            this.aButtonGridColor.UseVisualStyleBackColor = true;
            this.aButtonGridColor.Click += new System.EventHandler(this.aButtonGridColor_Click);
            // 
            // aTabPageAdvanced
            // 
            this.aTabPageAdvanced.Controls.Add(this.aGroupBoxBoundary);
            this.aTabPageAdvanced.Location = new System.Drawing.Point(4, 22);
            this.aTabPageAdvanced.Name = "aTabPageAdvanced";
            this.aTabPageAdvanced.Size = new System.Drawing.Size(322, 206);
            this.aTabPageAdvanced.TabIndex = 2;
            this.aTabPageAdvanced.Text = "Advanced";
            this.aTabPageAdvanced.UseVisualStyleBackColor = true;
            // 
            // aGroupBoxBoundary
            // 
            this.aGroupBoxBoundary.Controls.Add(this.label10);
            this.aGroupBoxBoundary.Controls.Add(this.label9);
            this.aGroupBoxBoundary.Controls.Add(this.label8);
            this.aGroupBoxBoundary.Controls.Add(this.label5);
            this.aGroupBoxBoundary.Controls.Add(this.aRadioButtonFinite);
            this.aGroupBoxBoundary.Controls.Add(this.aRadioButtonToroidal);
            this.aGroupBoxBoundary.Location = new System.Drawing.Point(59, 56);
            this.aGroupBoxBoundary.Name = "aGroupBoxBoundary";
            this.aGroupBoxBoundary.Size = new System.Drawing.Size(200, 100);
            this.aGroupBoxBoundary.TabIndex = 0;
            this.aGroupBoxBoundary.TabStop = false;
            this.aGroupBoxBoundary.Text = "Boundary Type";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(95, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "current cells";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(95, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "type may erase";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(95, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Changing boundary";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(95, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Warning!";
            // 
            // aRadioButtonFinite
            // 
            this.aRadioButtonFinite.AutoSize = true;
            this.aRadioButtonFinite.Checked = true;
            this.aRadioButtonFinite.Location = new System.Drawing.Point(6, 51);
            this.aRadioButtonFinite.Name = "aRadioButtonFinite";
            this.aRadioButtonFinite.Size = new System.Drawing.Size(50, 17);
            this.aRadioButtonFinite.TabIndex = 1;
            this.aRadioButtonFinite.TabStop = true;
            this.aRadioButtonFinite.Text = "Finite";
            this.aRadioButtonFinite.UseVisualStyleBackColor = true;
            this.aRadioButtonFinite.CheckedChanged += new System.EventHandler(this.aRadioButtonFinite_CheckedChanged);
            // 
            // aRadioButtonToroidal
            // 
            this.aRadioButtonToroidal.AutoSize = true;
            this.aRadioButtonToroidal.Location = new System.Drawing.Point(6, 19);
            this.aRadioButtonToroidal.Name = "aRadioButtonToroidal";
            this.aRadioButtonToroidal.Size = new System.Drawing.Size(63, 17);
            this.aRadioButtonToroidal.TabIndex = 0;
            this.aRadioButtonToroidal.Text = "Toroidal";
            this.aRadioButtonToroidal.UseVisualStyleBackColor = true;
            // 
            // OptionsDialog
            // 
            this.AcceptButton = this.aButtonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.aButtonCancel;
            this.ClientSize = new System.Drawing.Size(330, 266);
            this.Controls.Add(this.aTabControl);
            this.Controls.Add(this.aButtonCancel);
            this.Controls.Add(this.aButtonOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionsDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.aTabControl.ResumeLayout(false);
            this.aTabPageGeneral.ResumeLayout(false);
            this.aTabPageGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aUpDownHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aUpDownWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aUpDownTime)).EndInit();
            this.aTabPageView.ResumeLayout(false);
            this.aTabPageView.PerformLayout();
            this.aTabPageAdvanced.ResumeLayout(false);
            this.aGroupBoxBoundary.ResumeLayout(false);
            this.aGroupBoxBoundary.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button aButtonOK;
        private System.Windows.Forms.Button aButtonCancel;
        private System.Windows.Forms.TabControl aTabControl;
        private System.Windows.Forms.TabPage aTabPageGeneral;
        private System.Windows.Forms.NumericUpDown aUpDownHeight;
        private System.Windows.Forms.NumericUpDown aUpDownWidth;
        private System.Windows.Forms.NumericUpDown aUpDownTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage aTabPageView;
        private System.Windows.Forms.Button aButtonReset;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button aButtonLiveCellColor;
        private System.Windows.Forms.Button aButtonBackgroundColor;
        private System.Windows.Forms.Button aButtonGridColor;
        private System.Windows.Forms.TabPage aTabPageAdvanced;
        private System.Windows.Forms.GroupBox aGroupBoxBoundary;
        private System.Windows.Forms.RadioButton aRadioButtonFinite;
        private System.Windows.Forms.RadioButton aRadioButtonToroidal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
    }
}