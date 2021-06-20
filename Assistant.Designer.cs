
namespace Diplom
{
    partial class Assistant
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
            this.Delete = new System.Windows.Forms.Button();
            this.Dobavut = new System.Windows.Forms.Button();
            this.BD = new System.Windows.Forms.Button();
            this.Vuvod_BD = new System.Windows.Forms.DataGridView();
            this.Exit = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vurobnik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Vuvod_BD)).BeginInit();
            this.SuspendLayout();
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Delete.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.ForeColor = System.Drawing.Color.Yellow;
            this.Delete.Location = new System.Drawing.Point(468, 178);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(151, 42);
            this.Delete.TabIndex = 9;
            this.Delete.Text = "Видалити";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            this.Delete.MouseEnter += new System.EventHandler(this.Delete_MouseEnter);
            this.Delete.MouseLeave += new System.EventHandler(this.Delete_MouseLeave);
            // 
            // Dobavut
            // 
            this.Dobavut.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Dobavut.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dobavut.ForeColor = System.Drawing.Color.Yellow;
            this.Dobavut.Location = new System.Drawing.Point(468, 69);
            this.Dobavut.Name = "Dobavut";
            this.Dobavut.Size = new System.Drawing.Size(151, 42);
            this.Dobavut.TabIndex = 7;
            this.Dobavut.Text = "Добавить БД";
            this.Dobavut.UseVisualStyleBackColor = false;
            this.Dobavut.Click += new System.EventHandler(this.Dobavut_Click);
            this.Dobavut.MouseEnter += new System.EventHandler(this.Dobavut_MouseEnter);
            this.Dobavut.MouseLeave += new System.EventHandler(this.Dobavut_MouseLeave);
            // 
            // BD
            // 
            this.BD.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BD.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BD.ForeColor = System.Drawing.Color.Yellow;
            this.BD.Location = new System.Drawing.Point(468, 12);
            this.BD.Name = "BD";
            this.BD.Size = new System.Drawing.Size(151, 42);
            this.BD.TabIndex = 6;
            this.BD.Text = "Загрузка БД";
            this.BD.UseVisualStyleBackColor = false;
            this.BD.Click += new System.EventHandler(this.BD_Click);
            this.BD.MouseEnter += new System.EventHandler(this.BD_MouseEnter);
            this.BD.MouseLeave += new System.EventHandler(this.BD_MouseLeave);
            // 
            // Vuvod_BD
            // 
            this.Vuvod_BD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Vuvod_BD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nik,
            this.vurobnik,
            this.cina});
            this.Vuvod_BD.Location = new System.Drawing.Point(12, 12);
            this.Vuvod_BD.Name = "Vuvod_BD";
            this.Vuvod_BD.Size = new System.Drawing.Size(438, 199);
            this.Vuvod_BD.TabIndex = 5;
            // 
            // Exit
            // 
            this.Exit.AutoSize = true;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.Location = new System.Drawing.Point(625, 12);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(21, 20);
            this.Exit.TabIndex = 15;
            this.Exit.Text = "X";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            this.Exit.MouseEnter += new System.EventHandler(this.Exit_MouseEnter);
            this.Exit.MouseLeave += new System.EventHandler(this.Exit_MouseLeave);
            // 
            // ID
            // 
            this.ID.HeaderText = "id";
            this.ID.Name = "ID";
            // 
            // Nik
            // 
            this.Nik.HeaderText = "Назва";
            this.Nik.Name = "Nik";
            // 
            // vurobnik
            // 
            this.vurobnik.HeaderText = "Виробнік";
            this.vurobnik.Name = "vurobnik";
            // 
            // cina
            // 
            this.cina.HeaderText = "ціна";
            this.cina.Name = "cina";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(468, 126);
            this.textBoxID.Multiline = true;
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(151, 33);
            this.textBoxID.TabIndex = 16;
            // 
            // Assistant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(689, 236);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Dobavut);
            this.Controls.Add(this.BD);
            this.Controls.Add(this.Vuvod_BD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Assistant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assistant";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Assistant_MouseDown);
            
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Assistant_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.Vuvod_BD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Dobavut;
        private System.Windows.Forms.Button BD;
        private System.Windows.Forms.DataGridView Vuvod_BD;
        private System.Windows.Forms.Label Exit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nik;
        private System.Windows.Forms.DataGridViewTextBoxColumn vurobnik;
        private System.Windows.Forms.DataGridViewTextBoxColumn cina;
        private System.Windows.Forms.TextBox textBoxID;
    }
}