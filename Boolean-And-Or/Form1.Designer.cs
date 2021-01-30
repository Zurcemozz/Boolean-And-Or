
namespace Boolean_And_Or
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
            this.picoff1 = new System.Windows.Forms.PictureBox();
            this.chkBox1 = new System.Windows.Forms.CheckBox();
            this.chkBox2 = new System.Windows.Forms.CheckBox();
            this.picOn1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picResult = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.picOn2 = new System.Windows.Forms.PictureBox();
            this.picOff2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Or_on1 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.Or_On = new System.Windows.Forms.PictureBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picoff1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOn1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOn2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOff2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Or_on1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Or_On)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // picoff1
            // 
            this.picoff1.Image = global::Boolean_And_Or.Properties.Resources.off;
            this.picoff1.Location = new System.Drawing.Point(58, 95);
            this.picoff1.Name = "picoff1";
            this.picoff1.Size = new System.Drawing.Size(110, 166);
            this.picoff1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picoff1.TabIndex = 4;
            this.picoff1.TabStop = false;
            this.picoff1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // chkBox1
            // 
            this.chkBox1.AutoSize = true;
            this.chkBox1.Location = new System.Drawing.Point(81, 281);
            this.chkBox1.Name = "chkBox1";
            this.chkBox1.Size = new System.Drawing.Size(52, 40);
            this.chkBox1.TabIndex = 5;
            this.chkBox1.Text = "A";
            this.chkBox1.UseVisualStyleBackColor = true;
            this.chkBox1.CheckedChanged += new System.EventHandler(this.chkBox1_CheckedChanged);
            // 
            // chkBox2
            // 
            this.chkBox2.AutoSize = true;
            this.chkBox2.Location = new System.Drawing.Point(326, 281);
            this.chkBox2.Name = "chkBox2";
            this.chkBox2.Size = new System.Drawing.Size(51, 40);
            this.chkBox2.TabIndex = 6;
            this.chkBox2.Text = "B";
            this.chkBox2.UseVisualStyleBackColor = true;
            this.chkBox2.CheckedChanged += new System.EventHandler(this.chkBox2_CheckedChanged);
            // 
            // picOn1
            // 
            this.picOn1.Image = global::Boolean_And_Or.Properties.Resources.on;
            this.picOn1.Location = new System.Drawing.Point(24, 95);
            this.picOn1.Name = "picOn1";
            this.picOn1.Size = new System.Drawing.Size(185, 166);
            this.picOn1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOn1.TabIndex = 7;
            this.picOn1.TabStop = false;
            this.picOn1.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.picResult);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.picOn2);
            this.groupBox1.Controls.Add(this.picOff2);
            this.groupBox1.Controls.Add(this.chkBox2);
            this.groupBox1.Controls.Add(this.picOn1);
            this.groupBox1.Controls.Add(this.chkBox1);
            this.groupBox1.Controls.Add(this.picoff1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(509, 750);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "AND";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // picResult
            // 
            this.picResult.Image = global::Boolean_And_Or.Properties.Resources.on;
            this.picResult.Location = new System.Drawing.Point(157, 465);
            this.picResult.Name = "picResult";
            this.picResult.Size = new System.Drawing.Size(167, 166);
            this.picResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picResult.TabIndex = 12;
            this.picResult.TabStop = false;
            this.picResult.Visible = false;
            this.picResult.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Boolean_And_Or.Properties.Resources.off;
            this.pictureBox2.Location = new System.Drawing.Point(173, 465);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(110, 166);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // picOn2
            // 
            this.picOn2.Image = global::Boolean_And_Or.Properties.Resources.on;
            this.picOn2.Location = new System.Drawing.Point(266, 95);
            this.picOn2.Name = "picOn2";
            this.picOn2.Size = new System.Drawing.Size(167, 166);
            this.picOn2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOn2.TabIndex = 10;
            this.picOn2.TabStop = false;
            this.picOn2.Visible = false;
            this.picOn2.Click += new System.EventHandler(this.picOn2_Click);
            // 
            // picOff2
            // 
            this.picOff2.Image = global::Boolean_And_Or.Properties.Resources.off;
            this.picOff2.Location = new System.Drawing.Point(292, 95);
            this.picOff2.Name = "picOff2";
            this.picOff2.Size = new System.Drawing.Size(110, 166);
            this.picOff2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOff2.TabIndex = 9;
            this.picOff2.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(146, 364);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 59);
            this.button1.TabIndex = 13;
            this.button1.Text = "OUTPUT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.pictureBox3);
            this.groupBox2.Controls.Add(this.Or_on1);
            this.groupBox2.Controls.Add(this.pictureBox5);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.Or_On);
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.pictureBox7);
            this.groupBox2.Location = new System.Drawing.Point(527, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(509, 750);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "OR";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(148, 364);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(192, 59);
            this.button2.TabIndex = 13;
            this.button2.Text = "OUTPUT";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Boolean_And_Or.Properties.Resources.on;
            this.pictureBox1.Location = new System.Drawing.Point(157, 465);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 166);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Boolean_And_Or.Properties.Resources.off;
            this.pictureBox3.Location = new System.Drawing.Point(173, 465);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(110, 166);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // Or_on1
            // 
            this.Or_on1.Image = global::Boolean_And_Or.Properties.Resources.on;
            this.Or_on1.Location = new System.Drawing.Point(268, 95);
            this.Or_on1.Name = "Or_on1";
            this.Or_on1.Size = new System.Drawing.Size(167, 166);
            this.Or_on1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Or_on1.TabIndex = 10;
            this.Or_on1.TabStop = false;
            this.Or_on1.Visible = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Boolean_And_Or.Properties.Resources.off;
            this.pictureBox5.Location = new System.Drawing.Point(292, 95);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(110, 166);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 9;
            this.pictureBox5.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(326, 281);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(51, 40);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "B";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Or_On
            // 
            this.Or_On.Image = global::Boolean_And_Or.Properties.Resources.on;
            this.Or_On.Location = new System.Drawing.Point(26, 95);
            this.Or_On.Name = "Or_On";
            this.Or_On.Size = new System.Drawing.Size(185, 166);
            this.Or_On.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Or_On.TabIndex = 7;
            this.Or_On.TabStop = false;
            this.Or_On.Visible = false;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(81, 281);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(52, 40);
            this.checkBox2.TabIndex = 5;
            this.checkBox2.Text = "A";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Boolean_And_Or.Properties.Resources.off;
            this.pictureBox7.Location = new System.Drawing.Point(58, 95);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(110, 166);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 4;
            this.pictureBox7.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1057, 767);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BOOLEAN LOGIC AND - OR";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picoff1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOn1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOn2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOff2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Or_on1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Or_On)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox picoff1;
        private System.Windows.Forms.CheckBox chkBox1;
        private System.Windows.Forms.CheckBox chkBox2;
        private System.Windows.Forms.PictureBox picOn1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox picOn2;
        private System.Windows.Forms.PictureBox picOff2;
        private System.Windows.Forms.PictureBox picResult;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox Or_on1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.PictureBox Or_On;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.PictureBox pictureBox7;
    }
}

