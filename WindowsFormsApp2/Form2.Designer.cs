namespace WindowsFormsApp2
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.CheckPass2 = new System.Windows.Forms.CheckBox();
            this.Regbut = new System.Windows.Forms.Button();
            this.Pasfield2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Pasfield = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Regfield = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.Back);
            this.panel1.Controls.Add(this.CheckPass2);
            this.panel1.Controls.Add(this.Regbut);
            this.panel1.Controls.Add(this.Pasfield2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Pasfield);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Regfield);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(363, 380);
            this.panel1.TabIndex = 0;
            // 
            // CheckPass2
            // 
            this.CheckPass2.Location = new System.Drawing.Point(205, 178);
            this.CheckPass2.Name = "CheckPass2";
            this.CheckPass2.Size = new System.Drawing.Size(133, 37);
            this.CheckPass2.TabIndex = 7;
            this.CheckPass2.Text = "Показать пароль";
            this.CheckPass2.UseVisualStyleBackColor = true;
            this.CheckPass2.CheckedChanged += new System.EventHandler(this.CheckPass2_CheckedChanged);
            // 
            // Regbut
            // 
            this.Regbut.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Regbut.Location = new System.Drawing.Point(36, 306);
            this.Regbut.Name = "Regbut";
            this.Regbut.Size = new System.Drawing.Size(118, 37);
            this.Regbut.TabIndex = 6;
            this.Regbut.Text = "Регистрация";
            this.Regbut.UseVisualStyleBackColor = true;
            this.Regbut.Click += new System.EventHandler(this.Regbut_Click);
            // 
            // Pasfield2
            // 
            this.Pasfield2.Location = new System.Drawing.Point(36, 257);
            this.Pasfield2.Multiline = true;
            this.Pasfield2.Name = "Pasfield2";
            this.Pasfield2.PasswordChar = '*';
            this.Pasfield2.Size = new System.Drawing.Size(118, 28);
            this.Pasfield2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(36, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "Подтверждение пароля";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pasfield
            // 
            this.Pasfield.Location = new System.Drawing.Point(36, 178);
            this.Pasfield.Multiline = true;
            this.Pasfield.Name = "Pasfield";
            this.Pasfield.PasswordChar = '*';
            this.Pasfield.Size = new System.Drawing.Size(118, 28);
            this.Pasfield.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(36, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Пароль";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Regfield
            // 
            this.Regfield.Location = new System.Drawing.Point(36, 100);
            this.Regfield.Multiline = true;
            this.Regfield.Name = "Regfield";
            this.Regfield.Size = new System.Drawing.Size(118, 28);
            this.Regfield.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(36, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Логин";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back.Location = new System.Drawing.Point(205, 306);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(118, 37);
            this.Back.TabIndex = 8;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 380);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.ShowIcon = false;
            this.Text = "Регистрация";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Regbut;
        private System.Windows.Forms.TextBox Pasfield2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Pasfield;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Regfield;
        private System.Windows.Forms.CheckBox CheckPass2;
        private System.Windows.Forms.Button Back;
    }
}