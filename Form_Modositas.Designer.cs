namespace WindowsFormsAppLogin
{
    partial class Form_Modositas
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_modositas = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown_modositasar = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_modositasraktarKeszlet = new System.Windows.Forms.NumericUpDown();
            this.textBox_modositastermeknev = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_modositastermekid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox_termekmodositas = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_modositasar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_modositasraktarKeszlet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_modositas);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numericUpDown_modositasar);
            this.groupBox1.Controls.Add(this.numericUpDown_modositasraktarKeszlet);
            this.groupBox1.Controls.Add(this.textBox_modositastermeknev);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_modositastermekid);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(254, 64);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(489, 373);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kiválasztott termék";
            // 
            // button_modositas
            // 
            this.button_modositas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_modositas.Location = new System.Drawing.Point(21, 281);
            this.button_modositas.Margin = new System.Windows.Forms.Padding(4);
            this.button_modositas.Name = "button_modositas";
            this.button_modositas.Size = new System.Drawing.Size(380, 59);
            this.button_modositas.TabIndex = 8;
            this.button_modositas.Text = "Módosítás";
            this.button_modositas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_modositas.UseVisualStyleBackColor = true;
            this.button_modositas.Click += new System.EventHandler(this.button_modositas_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(17, 175);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Raktár készlet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(17, 126);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Egységár";
            // 
            // numericUpDown_modositasar
            // 
            this.numericUpDown_modositasar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDown_modositasar.Location = new System.Drawing.Point(199, 123);
            this.numericUpDown_modositasar.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown_modositasar.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown_modositasar.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_modositasar.Name = "numericUpDown_modositasar";
            this.numericUpDown_modositasar.Size = new System.Drawing.Size(160, 30);
            this.numericUpDown_modositasar.TabIndex = 4;
            this.numericUpDown_modositasar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_modositasar.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown_modositasraktarKeszlet
            // 
            this.numericUpDown_modositasraktarKeszlet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDown_modositasraktarKeszlet.Location = new System.Drawing.Point(199, 172);
            this.numericUpDown_modositasraktarKeszlet.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown_modositasraktarKeszlet.Name = "numericUpDown_modositasraktarKeszlet";
            this.numericUpDown_modositasraktarKeszlet.Size = new System.Drawing.Size(160, 30);
            this.numericUpDown_modositasraktarKeszlet.TabIndex = 4;
            this.numericUpDown_modositasraktarKeszlet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_modositastermeknev
            // 
            this.textBox_modositastermeknev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_modositastermeknev.Location = new System.Drawing.Point(199, 74);
            this.textBox_modositastermeknev.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_modositastermeknev.Name = "textBox_modositastermeknev";
            this.textBox_modositastermeknev.Size = new System.Drawing.Size(201, 30);
            this.textBox_modositastermeknev.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(17, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Terméknév";
            // 
            // textBox_modositastermekid
            // 
            this.textBox_modositastermekid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_modositastermekid.Location = new System.Drawing.Point(199, 25);
            this.textBox_modositastermekid.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_modositastermekid.Name = "textBox_modositastermekid";
            this.textBox_modositastermekid.ReadOnly = true;
            this.textBox_modositastermekid.Size = new System.Drawing.Size(119, 30);
            this.textBox_modositastermekid.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(17, 28);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Termék azonosító";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(388, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "Termék modosítás";
            // 
            // listBox_termekmodositas
            // 
            this.listBox_termekmodositas.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox_termekmodositas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBox_termekmodositas.FormattingEnabled = true;
            this.listBox_termekmodositas.ItemHeight = 29;
            this.listBox_termekmodositas.Location = new System.Drawing.Point(0, 0);
            this.listBox_termekmodositas.Margin = new System.Windows.Forms.Padding(4);
            this.listBox_termekmodositas.Name = "listBox_termekmodositas";
            this.listBox_termekmodositas.Size = new System.Drawing.Size(200, 450);
            this.listBox_termekmodositas.TabIndex = 7;
            this.listBox_termekmodositas.SelectedIndexChanged += new System.EventHandler(this.listBox_termekmodositas_SelectedIndexChanged);
            // 
            // Form_Modositas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox_termekmodositas);
            this.Name = "Form_Modositas";
            this.Text = "Form_Modositas";
            this.Load += new System.EventHandler(this.Form_Modositas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_modositasar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_modositasraktarKeszlet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_modositas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown_modositasar;
        private System.Windows.Forms.NumericUpDown numericUpDown_modositasraktarKeszlet;
        private System.Windows.Forms.TextBox textBox_modositastermeknev;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_modositastermekid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox_termekmodositas;
    }
}