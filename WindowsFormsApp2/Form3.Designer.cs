namespace WindowsFormsApp2
{
    partial class Perevod
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Trans = new System.Windows.Forms.Button();
            this.Polsk = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Infix = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.olods;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.Save);
            this.panel1.Controls.Add(this.Trans);
            this.panel1.Controls.Add(this.Polsk);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Infix);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(406, 446);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(290, 377);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 43);
            this.button1.TabIndex = 6;
            this.button1.Text = "Закрыть программу";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(138, 377);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(126, 43);
            this.Save.TabIndex = 5;
            this.Save.Text = "Сохранить результат";
            this.Save.UseVisualStyleBackColor = true;

            // 
            // Trans
            // 
            this.Trans.Location = new System.Drawing.Point(138, 173);
            this.Trans.Name = "Trans";
            this.Trans.Size = new System.Drawing.Size(126, 49);
            this.Trans.TabIndex = 4;
            this.Trans.Text = "Перевести";
            this.Trans.UseVisualStyleBackColor = true;
            // 
            // Polsk
            // 
            this.Polsk.Location = new System.Drawing.Point(72, 324);
            this.Polsk.Multiline = true;
            this.Polsk.Name = "Polsk";
            this.Polsk.ReadOnly = true;
            this.Polsk.Size = new System.Drawing.Size(262, 29);
            this.Polsk.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(74, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ваше выражение в Польской записи";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Infix
            // 
            this.Infix.Location = new System.Drawing.Point(72, 76);
            this.Infix.Multiline = true;
            this.Infix.Name = "Infix";
            this.Infix.Size = new System.Drawing.Size(262, 29);
            this.Infix.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(74, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Напишите ваше выражение для перевода";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 446);
            this.Controls.Add(this.panel1);
            this.Name = "Form3";
            this.ShowIcon = false;
            this.Text = "Перевод в Польскую запись";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Polsk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Infix;
        private System.Windows.Forms.Button Trans;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button button1;
    }
}