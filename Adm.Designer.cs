
namespace Diplom
{
    partial class Adm
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
            this.Vuvod_BD = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vurobnik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kilk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.Dobavut = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Label();
            this.textid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Redaktor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Idtext = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cinatext = new System.Windows.Forms.TextBox();
            this.pokypka = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Vuvod_BD)).BeginInit();
            this.SuspendLayout();
            // 
            // Vuvod_BD
            // 
            this.Vuvod_BD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Vuvod_BD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nik,
            this.Vurobnik,
            this.cina,
            this.Kilk});
            this.Vuvod_BD.Location = new System.Drawing.Point(12, 12);
            this.Vuvod_BD.Name = "Vuvod_BD";
            this.Vuvod_BD.Size = new System.Drawing.Size(518, 221);
            this.Vuvod_BD.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "id ";
            this.ID.Name = "ID";
            this.ID.Width = 80;
            // 
            // Nik
            // 
            this.Nik.HeaderText = "Назва";
            this.Nik.Name = "Nik";
            this.Nik.Width = 110;
            // 
            // Vurobnik
            // 
            this.Vurobnik.HeaderText = "Виробник";
            this.Vurobnik.Name = "Vurobnik";
            this.Vurobnik.Width = 105;
            // 
            // cina
            // 
            this.cina.HeaderText = "Ціна";
            this.cina.Name = "cina";
            this.cina.Width = 105;
            // 
            // Kilk
            // 
            this.Kilk.HeaderText = "Кількість";
            this.Kilk.Name = "Kilk";
            this.Kilk.Width = 75;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.Yellow;
            this.button1.Location = new System.Drawing.Point(536, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 82);
            this.button1.TabIndex = 1;
            this.button1.Text = "База данних";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // Dobavut
            // 
            this.Dobavut.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Dobavut.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Dobavut.ForeColor = System.Drawing.Color.Yellow;
            this.Dobavut.Location = new System.Drawing.Point(536, 122);
            this.Dobavut.Name = "Dobavut";
            this.Dobavut.Size = new System.Drawing.Size(150, 89);
            this.Dobavut.TabIndex = 2;
            this.Dobavut.Text = "Добавить БД";
            this.Dobavut.UseVisualStyleBackColor = false;
            this.Dobavut.Click += new System.EventHandler(this.Dobavut_Click);
            this.Dobavut.MouseEnter += new System.EventHandler(this.Dobavut_MouseEnter);
            this.Dobavut.MouseLeave += new System.EventHandler(this.Dobavut_MouseLeave);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Delete.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Delete.ForeColor = System.Drawing.Color.Yellow;
            this.Delete.Location = new System.Drawing.Point(12, 294);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(159, 50);
            this.Delete.TabIndex = 4;
            this.Delete.Text = "Видалити";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            this.Delete.MouseEnter += new System.EventHandler(this.Delete_MouseEnter);
            this.Delete.MouseLeave += new System.EventHandler(this.Delete_MouseLeave);
            // 
            // Exit
            // 
            this.Exit.AutoSize = true;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.Location = new System.Drawing.Point(665, 9);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(21, 20);
            this.Exit.TabIndex = 5;
            this.Exit.Text = "X";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            this.Exit.MouseEnter += new System.EventHandler(this.Exit_MouseEnter);
            this.Exit.MouseLeave += new System.EventHandler(this.Exit_MouseLeave);
            // 
            // textid
            // 
            this.textid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textid.Location = new System.Drawing.Point(40, 257);
            this.textid.Multiline = true;
            this.textid.Name = "textid";
            this.textid.Size = new System.Drawing.Size(131, 31);
            this.textid.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Id";
            // 
            // Redaktor
            // 
            this.Redaktor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Redaktor.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Redaktor.ForeColor = System.Drawing.Color.Yellow;
            this.Redaktor.Location = new System.Drawing.Point(216, 294);
            this.Redaktor.Name = "Redaktor";
            this.Redaktor.Size = new System.Drawing.Size(314, 48);
            this.Redaktor.TabIndex = 8;
            this.Redaktor.Text = "Редагування ціни";
            this.Redaktor.UseVisualStyleBackColor = false;
            this.Redaktor.Click += new System.EventHandler(this.Redaktor_Click);
            this.Redaktor.MouseEnter += new System.EventHandler(this.Redaktor_MouseEnter);
            this.Redaktor.MouseLeave += new System.EventHandler(this.Redaktor_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(184, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "Id";
            // 
            // Idtext
            // 
            this.Idtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Idtext.Location = new System.Drawing.Point(216, 257);
            this.Idtext.Multiline = true;
            this.Idtext.Name = "Idtext";
            this.Idtext.Size = new System.Drawing.Size(125, 31);
            this.Idtext.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(345, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ціна";
            // 
            // cinatext
            // 
            this.cinatext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cinatext.Location = new System.Drawing.Point(405, 257);
            this.cinatext.Multiline = true;
            this.cinatext.Name = "cinatext";
            this.cinatext.Size = new System.Drawing.Size(125, 31);
            this.cinatext.TabIndex = 11;
            // 
            // pokypka
            // 
            this.pokypka.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pokypka.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pokypka.ForeColor = System.Drawing.Color.Yellow;
            this.pokypka.Location = new System.Drawing.Point(536, 232);
            this.pokypka.Name = "pokypka";
            this.pokypka.Size = new System.Drawing.Size(150, 81);
            this.pokypka.TabIndex = 13;
            this.pokypka.Text = "Купити";
            this.pokypka.UseVisualStyleBackColor = false;
            this.pokypka.Click += new System.EventHandler(this.pokypka_Click);
            this.pokypka.MouseEnter += new System.EventHandler(this.pokypka_MouseEnter);
            this.pokypka.MouseLeave += new System.EventHandler(this.pokypka_MouseLeave);
            // 
            // Adm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(708, 363);
            this.Controls.Add(this.pokypka);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cinatext);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Idtext);
            this.Controls.Add(this.Redaktor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textid);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Dobavut);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Vuvod_BD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Adm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adm";
            this.Load += new System.EventHandler(this.Adm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Adm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Adm_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.Vuvod_BD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Vuvod_BD;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Dobavut;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Label Exit;
        private System.Windows.Forms.TextBox textid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Redaktor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Idtext;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cinatext;
        private System.Windows.Forms.Button pokypka;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nik;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vurobnik;
        private System.Windows.Forms.DataGridViewTextBoxColumn cina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kilk;
    }
}