
namespace Diplom
{
    partial class Golovna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Golovna));
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Log = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Assist = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Label();
            this.NotSea = new System.Windows.Forms.Button();
            this.Sea = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(129, 129);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(147, 33);
            this.textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(129, 75);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(147, 33);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(136, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Вхід";
            // 
            // Log
            // 
            this.Log.BackColor = System.Drawing.SystemColors.ControlText;
            this.Log.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Log.ForeColor = System.Drawing.Color.Yellow;
            this.Log.Location = new System.Drawing.Point(88, 168);
            this.Log.Name = "Log";
            this.Log.Size = new System.Drawing.Size(202, 47);
            this.Log.TabIndex = 4;
            this.Log.Text = "Увійти";
            this.Log.UseVisualStyleBackColor = false;
            this.Log.Click += new System.EventHandler(this.Log_Click);
            this.Log.MouseEnter += new System.EventHandler(this.Log_MouseEnter);
            this.Log.MouseLeave += new System.EventHandler(this.Log_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(32, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 33);
            this.label2.TabIndex = 5;
            this.label2.Text = "Логін";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(32, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 33);
            this.label3.TabIndex = 6;
            this.label3.Text = "Пароль";
            // 
            // Assist
            // 
            this.Assist.BackColor = System.Drawing.SystemColors.ControlText;
            this.Assist.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Assist.ForeColor = System.Drawing.Color.Yellow;
            this.Assist.Location = new System.Drawing.Point(88, 221);
            this.Assist.Name = "Assist";
            this.Assist.Size = new System.Drawing.Size(202, 44);
            this.Assist.TabIndex = 7;
            this.Assist.Text = "Асистент";
            this.Assist.UseVisualStyleBackColor = false;
            this.Assist.Click += new System.EventHandler(this.Assist_Click);
            this.Assist.MouseEnter += new System.EventHandler(this.Assist_MouseEnter);
            this.Assist.MouseLeave += new System.EventHandler(this.Assist_MouseLeave);
            // 
            // Exit
            // 
            this.Exit.AutoSize = true;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Exit.Location = new System.Drawing.Point(307, 10);
            this.Exit.MaximumSize = new System.Drawing.Size(60, 50);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(25, 24);
            this.Exit.TabIndex = 8;
            this.Exit.Text = "X";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            this.Exit.MouseEnter += new System.EventHandler(this.Exit_MouseEnter);
            this.Exit.MouseLeave += new System.EventHandler(this.Exit_MouseLeave);
            // 
            // NotSea
            // 
            this.NotSea.BackColor = System.Drawing.Color.White;
            this.NotSea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NotSea.ForeColor = System.Drawing.SystemColors.WindowText;
            this.NotSea.Image = ((System.Drawing.Image)(resources.GetObject("NotSea.Image")));
            this.NotSea.Location = new System.Drawing.Point(236, 129);
            this.NotSea.Name = "NotSea";
            this.NotSea.Size = new System.Drawing.Size(40, 32);
            this.NotSea.TabIndex = 9;
            this.NotSea.UseVisualStyleBackColor = false;
            this.NotSea.Click += new System.EventHandler(this.NotSea_Click);
            // 
            // Sea
            // 
            this.Sea.BackColor = System.Drawing.Color.White;
            this.Sea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sea.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Sea.Image = ((System.Drawing.Image)(resources.GetObject("Sea.Image")));
            this.Sea.Location = new System.Drawing.Point(236, 130);
            this.Sea.Name = "Sea";
            this.Sea.Size = new System.Drawing.Size(40, 32);
            this.Sea.TabIndex = 10;
            this.Sea.UseVisualStyleBackColor = false;
            this.Sea.Click += new System.EventHandler(this.Sea_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(33, 7);
            this.label4.MaximumSize = new System.Drawing.Size(150, 70);
            this.label4.MinimumSize = new System.Drawing.Size(75, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 50);
            this.label4.TabIndex = 11;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Golovna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(347, 316);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Sea);
            this.Controls.Add(this.NotSea);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Assist);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Log);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Golovna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Golovna_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Golovna_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Log;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Assist;
        private System.Windows.Forms.Label Exit;
        public System.Windows.Forms.Button NotSea;
        private System.Windows.Forms.Button Sea;
        private System.Windows.Forms.Label label4;
    }
}