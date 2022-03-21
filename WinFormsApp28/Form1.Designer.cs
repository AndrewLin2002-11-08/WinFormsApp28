namespace WinFormsApp28
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
            this.listBoxkoleksi = new System.Windows.Forms.ListBox();
            this.checkBoxaktif = new System.Windows.Forms.CheckBox();
            this.labelkoleksi = new System.Windows.Forms.Label();
            this.labeloutput = new System.Windows.Forms.Label();
            this.labelhalo = new System.Windows.Forms.Label();
            this.radioButtonwarnabiru = new System.Windows.Forms.RadioButton();
            this.radioButtonwarnamerah = new System.Windows.Forms.RadioButton();
            this.labeldata = new System.Windows.Forms.Label();
            this.labelsetting = new System.Windows.Forms.Label();
            this.buttonclear = new System.Windows.Forms.Button();
            this.buttonadd = new System.Windows.Forms.Button();
            this.textBoxinput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBoxkoleksi
            // 
            this.listBoxkoleksi.FormattingEnabled = true;
            this.listBoxkoleksi.ItemHeight = 25;
            this.listBoxkoleksi.Location = new System.Drawing.Point(57, 123);
            this.listBoxkoleksi.Name = "listBoxkoleksi";
            this.listBoxkoleksi.Size = new System.Drawing.Size(244, 304);
            this.listBoxkoleksi.TabIndex = 37;
            this.listBoxkoleksi.Tag = "";
            this.listBoxkoleksi.SelectedIndexChanged += new System.EventHandler(this.listBoxkoleksi_SelectedIndexChanged);
            // 
            // checkBoxaktif
            // 
            this.checkBoxaktif.AutoSize = true;
            this.checkBoxaktif.Location = new System.Drawing.Point(579, 82);
            this.checkBoxaktif.Name = "checkBoxaktif";
            this.checkBoxaktif.Size = new System.Drawing.Size(75, 29);
            this.checkBoxaktif.TabIndex = 36;
            this.checkBoxaktif.Text = "Aktif";
            this.checkBoxaktif.UseVisualStyleBackColor = true;
            this.checkBoxaktif.CheckedChanged += new System.EventHandler(this.checkBoxaktif_CheckedChanged);
            // 
            // labelkoleksi
            // 
            this.labelkoleksi.AutoSize = true;
            this.labelkoleksi.Location = new System.Drawing.Point(57, 83);
            this.labelkoleksi.Name = "labelkoleksi";
            this.labelkoleksi.Size = new System.Drawing.Size(71, 25);
            this.labelkoleksi.TabIndex = 35;
            this.labelkoleksi.Text = "Koleksi:";
            // 
            // labeloutput
            // 
            this.labeloutput.AutoSize = true;
            this.labeloutput.Location = new System.Drawing.Point(487, 190);
            this.labeloutput.Name = "labeloutput";
            this.labeloutput.Size = new System.Drawing.Size(73, 25);
            this.labeloutput.TabIndex = 34;
            this.labeloutput.Text = "Output:";
            // 
            // labelhalo
            // 
            this.labelhalo.AutoSize = true;
            this.labelhalo.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelhalo.Location = new System.Drawing.Point(515, 253);
            this.labelhalo.Name = "labelhalo";
            this.labelhalo.Size = new System.Drawing.Size(184, 74);
            this.labelhalo.TabIndex = 33;
            this.labelhalo.Text = "HALO";
            // 
            // radioButtonwarnabiru
            // 
            this.radioButtonwarnabiru.AutoSize = true;
            this.radioButtonwarnabiru.Location = new System.Drawing.Point(552, 158);
            this.radioButtonwarnabiru.Name = "radioButtonwarnabiru";
            this.radioButtonwarnabiru.Size = new System.Drawing.Size(122, 29);
            this.radioButtonwarnabiru.TabIndex = 32;
            this.radioButtonwarnabiru.TabStop = true;
            this.radioButtonwarnabiru.Text = "Warna Biru";
            this.radioButtonwarnabiru.UseVisualStyleBackColor = true;
            this.radioButtonwarnabiru.CheckedChanged += new System.EventHandler(this.radioButtonwarnabiru_CheckedChanged);
            // 
            // radioButtonwarnamerah
            // 
            this.radioButtonwarnamerah.AutoSize = true;
            this.radioButtonwarnamerah.Location = new System.Drawing.Point(552, 123);
            this.radioButtonwarnamerah.Name = "radioButtonwarnamerah";
            this.radioButtonwarnamerah.Size = new System.Drawing.Size(142, 29);
            this.radioButtonwarnamerah.TabIndex = 31;
            this.radioButtonwarnamerah.TabStop = true;
            this.radioButtonwarnamerah.Text = "Warna Merah";
            this.radioButtonwarnamerah.UseVisualStyleBackColor = true;
            this.radioButtonwarnamerah.CheckedChanged += new System.EventHandler(this.radioButtonwarnamerah_CheckedChanged);
            // 
            // labeldata
            // 
            this.labeldata.AutoSize = true;
            this.labeldata.Location = new System.Drawing.Point(57, 21);
            this.labeldata.Name = "labeldata";
            this.labeldata.Size = new System.Drawing.Size(53, 25);
            this.labeldata.TabIndex = 30;
            this.labeldata.Text = "Data:";
            // 
            // labelsetting
            // 
            this.labelsetting.AutoSize = true;
            this.labelsetting.Location = new System.Drawing.Point(492, 83);
            this.labelsetting.Name = "labelsetting";
            this.labelsetting.Size = new System.Drawing.Size(72, 25);
            this.labelsetting.TabIndex = 29;
            this.labelsetting.Text = "Setting:";
            // 
            // buttonclear
            // 
            this.buttonclear.Location = new System.Drawing.Point(476, 395);
            this.buttonclear.Name = "buttonclear";
            this.buttonclear.Size = new System.Drawing.Size(267, 34);
            this.buttonclear.TabIndex = 28;
            this.buttonclear.Text = "Clear";
            this.buttonclear.UseVisualStyleBackColor = true;
            this.buttonclear.Click += new System.EventHandler(this.buttonclear_Click);
            // 
            // buttonadd
            // 
            this.buttonadd.Location = new System.Drawing.Point(592, 21);
            this.buttonadd.Name = "buttonadd";
            this.buttonadd.Size = new System.Drawing.Size(112, 34);
            this.buttonadd.TabIndex = 27;
            this.buttonadd.Tag = "";
            this.buttonadd.Text = "Add";
            this.buttonadd.UseVisualStyleBackColor = true;
            this.buttonadd.Click += new System.EventHandler(this.buttonadd_Click);
            // 
            // textBoxinput
            // 
            this.textBoxinput.Location = new System.Drawing.Point(122, 21);
            this.textBoxinput.Name = "textBoxinput";
            this.textBoxinput.Size = new System.Drawing.Size(429, 31);
            this.textBoxinput.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxkoleksi);
            this.Controls.Add(this.checkBoxaktif);
            this.Controls.Add(this.labelkoleksi);
            this.Controls.Add(this.labeloutput);
            this.Controls.Add(this.labelhalo);
            this.Controls.Add(this.radioButtonwarnabiru);
            this.Controls.Add(this.radioButtonwarnamerah);
            this.Controls.Add(this.labeldata);
            this.Controls.Add(this.labelsetting);
            this.Controls.Add(this.buttonclear);
            this.Controls.Add(this.buttonadd);
            this.Controls.Add(this.textBoxinput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxkoleksi;
        private System.Windows.Forms.CheckBox checkBoxaktif;
        private System.Windows.Forms.Label labelkoleksi;
        private System.Windows.Forms.Label labeloutput;
        private System.Windows.Forms.Label labelhalo;
        private System.Windows.Forms.RadioButton radioButtonwarnabiru;
        private System.Windows.Forms.RadioButton radioButtonwarnamerah;
        private System.Windows.Forms.Label labeldata;
        private System.Windows.Forms.Label labelsetting;
        private System.Windows.Forms.Button buttonclear;
        private System.Windows.Forms.Button buttonadd;
        private System.Windows.Forms.TextBox textBoxinput;
    }
}
