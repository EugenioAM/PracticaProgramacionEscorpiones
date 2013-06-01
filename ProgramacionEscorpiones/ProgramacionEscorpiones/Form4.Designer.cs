namespace ProgramacionEscorpiones
{
    partial class Form4
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
            this.textBoxNuevoAlias = new System.Windows.Forms.TextBox();
            this.textBoxPw = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxNuevoAlias
            // 
            this.textBoxNuevoAlias.Location = new System.Drawing.Point(43, 66);
            this.textBoxNuevoAlias.Name = "textBoxNuevoAlias";
            this.textBoxNuevoAlias.Size = new System.Drawing.Size(187, 20);
            this.textBoxNuevoAlias.TabIndex = 0;
            this.textBoxNuevoAlias.Text = "Nuevo Alias";
            this.textBoxNuevoAlias.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxNuevoAlias.Click += new System.EventHandler(this.textBox1_click);
            // 
            // textBoxPw
            // 
            this.textBoxPw.Location = new System.Drawing.Point(43, 118);
            this.textBoxPw.Name = "textBoxPw";
            this.textBoxPw.Size = new System.Drawing.Size(187, 20);
            this.textBoxPw.TabIndex = 1;
            this.textBoxPw.Text = "Contraseña";
            this.textBoxPw.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPw.Click += new System.EventHandler(this.textBox2_click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(102, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cambiar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(26, 24);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(43, 92);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Confirmar Alias";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click_1);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 197);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxPw);
            this.Controls.Add(this.textBoxNuevoAlias);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNuevoAlias;
        private System.Windows.Forms.TextBox textBoxPw;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
    }
}