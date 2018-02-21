namespace myGOL
{
    partial class RandomizeBySeed
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
            this.label1 = new System.Windows.Forms.Label();
            this.aUpDownSeedNum = new System.Windows.Forms.NumericUpDown();
            this.aButtonRandomize = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.aUpDownSeedNum)).BeginInit();
            this.SuspendLayout();
            // 
            // aButtonOK
            // 
            this.aButtonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.aButtonOK.Location = new System.Drawing.Point(72, 64);
            this.aButtonOK.Name = "aButtonOK";
            this.aButtonOK.Size = new System.Drawing.Size(75, 23);
            this.aButtonOK.TabIndex = 0;
            this.aButtonOK.Text = "OK";
            this.aButtonOK.UseVisualStyleBackColor = true;
            // 
            // aButtonCancel
            // 
            this.aButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.aButtonCancel.Location = new System.Drawing.Point(153, 64);
            this.aButtonCancel.Name = "aButtonCancel";
            this.aButtonCancel.Size = new System.Drawing.Size(75, 23);
            this.aButtonCancel.TabIndex = 1;
            this.aButtonCancel.Text = "Cancel";
            this.aButtonCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seed";
            // 
            // aUpDownSeedNum
            // 
            this.aUpDownSeedNum.Location = new System.Drawing.Point(95, 27);
            this.aUpDownSeedNum.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.aUpDownSeedNum.Name = "aUpDownSeedNum";
            this.aUpDownSeedNum.Size = new System.Drawing.Size(99, 20);
            this.aUpDownSeedNum.TabIndex = 3;
            this.aUpDownSeedNum.ValueChanged += new System.EventHandler(this.aUpDownSeedNum_ValueChanged);
            // 
            // aButtonRandomize
            // 
            this.aButtonRandomize.Location = new System.Drawing.Point(200, 24);
            this.aButtonRandomize.Name = "aButtonRandomize";
            this.aButtonRandomize.Size = new System.Drawing.Size(75, 23);
            this.aButtonRandomize.TabIndex = 4;
            this.aButtonRandomize.Text = "Randomize";
            this.aButtonRandomize.UseVisualStyleBackColor = true;
            this.aButtonRandomize.Click += new System.EventHandler(this.aButtonRandomize_Click);
            // 
            // RandomizeBySeed
            // 
            this.AcceptButton = this.aButtonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.aButtonCancel;
            this.ClientSize = new System.Drawing.Size(326, 96);
            this.Controls.Add(this.aButtonRandomize);
            this.Controls.Add(this.aUpDownSeedNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aButtonCancel);
            this.Controls.Add(this.aButtonOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RandomizeBySeed";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.aUpDownSeedNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button aButtonOK;
        private System.Windows.Forms.Button aButtonCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown aUpDownSeedNum;
        private System.Windows.Forms.Button aButtonRandomize;
    }
}