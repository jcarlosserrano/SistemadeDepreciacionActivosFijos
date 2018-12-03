namespace DEPRECIACION2._0
{
    partial class DEPRECIACION
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
            System.Windows.Forms.Label idRegistroLabel;
            System.Windows.Forms.Label idPersonalLabel;
            System.Windows.Forms.Label idUbicacionLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            idRegistroLabel = new System.Windows.Forms.Label();
            idPersonalLabel = new System.Windows.Forms.Label();
            idUbicacionLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // idRegistroLabel
            // 
            idRegistroLabel.AutoSize = true;
            idRegistroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idRegistroLabel.Location = new System.Drawing.Point(107, 64);
            idRegistroLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            idRegistroLabel.Name = "idRegistroLabel";
            idRegistroLabel.Size = new System.Drawing.Size(844, 29);
            idRegistroLabel.TabIndex = 53;
            idRegistroLabel.Text = "CALCULO DE ACTUALIZACION Y DEPRECIACION DE ACTIVOS FIJOS";
            // 
            // idPersonalLabel
            // 
            idPersonalLabel.AutoSize = true;
            idPersonalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idPersonalLabel.Location = new System.Drawing.Point(272, 114);
            idPersonalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            idPersonalLabel.Name = "idPersonalLabel";
            idPersonalLabel.Size = new System.Drawing.Size(224, 25);
            idPersonalLabel.TabIndex = 56;
            idPersonalLabel.Text = "PERIODO DEL 01/01/";
            // 
            // idUbicacionLabel
            // 
            idUbicacionLabel.AutoSize = true;
            idUbicacionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idUbicacionLabel.Location = new System.Drawing.Point(491, 114);
            idUbicacionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            idUbicacionLabel.Name = "idUbicacionLabel";
            idUbicacionLabel.Size = new System.Drawing.Size(72, 25);
            idUbicacionLabel.TabIndex = 57;
            idUbicacionLabel.Text = "AAAA";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 364);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1002, 428);
            this.dataGridView1.TabIndex = 61;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(571, 114);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(107, 25);
            label1.TabIndex = 62;
            label1.Text = "AL 31/12/";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(675, 114);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(72, 25);
            label2.TabIndex = 63;
            label2.Text = "AAAA";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(434, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 50);
            this.button1.TabIndex = 64;
            this.button1.Text = "ACTUALIZAR";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(650, 184);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(124, 25);
            label3.TabIndex = 65;
            label3.Text = "UFV Inicial:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(659, 232);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(115, 25);
            label4.TabIndex = 66;
            label4.Text = "UFV Final:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(781, 188);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(136, 22);
            this.textBox1.TabIndex = 67;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(781, 235);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(136, 22);
            this.textBox2.TabIndex = 68;
            // 
            // DEPRECIACION
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 865);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(label4);
            this.Controls.Add(label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(idRegistroLabel);
            this.Controls.Add(idPersonalLabel);
            this.Controls.Add(idUbicacionLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DEPRECIACION";
            this.Text = "DEPRECIACION";
            this.Load += new System.EventHandler(this.DEPRECIACION_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}