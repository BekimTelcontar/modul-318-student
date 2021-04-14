
namespace MyTransportApp
{
    partial class MyTransportApp
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.StartortTextBox = new System.Windows.Forms.TextBox();
            this.StartortLabel = new System.Windows.Forms.Label();
            this.ZielortLabel = new System.Windows.Forms.Label();
            this.ZielortTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Verbindung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Abfahrt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ankunft = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dauer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // StartortTextBox
            // 
            this.StartortTextBox.Location = new System.Drawing.Point(12, 75);
            this.StartortTextBox.Name = "StartortTextBox";
            this.StartortTextBox.Size = new System.Drawing.Size(149, 22);
            this.StartortTextBox.TabIndex = 0;
            // 
            // StartortLabel
            // 
            this.StartortLabel.AutoSize = true;
            this.StartortLabel.Location = new System.Drawing.Point(9, 51);
            this.StartortLabel.Name = "StartortLabel";
            this.StartortLabel.Size = new System.Drawing.Size(55, 17);
            this.StartortLabel.TabIndex = 2;
            this.StartortLabel.Text = "Startort";
            // 
            // ZielortLabel
            // 
            this.ZielortLabel.AutoSize = true;
            this.ZielortLabel.Location = new System.Drawing.Point(203, 51);
            this.ZielortLabel.Name = "ZielortLabel";
            this.ZielortLabel.Size = new System.Drawing.Size(48, 17);
            this.ZielortLabel.TabIndex = 3;
            this.ZielortLabel.Text = "Zielort";
            // 
            // ZielortTextBox
            // 
            this.ZielortTextBox.Location = new System.Drawing.Point(206, 75);
            this.ZielortTextBox.Name = "ZielortTextBox";
            this.ZielortTextBox.Size = new System.Drawing.Size(149, 22);
            this.ZielortTextBox.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(394, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Verbindung suchen";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Verbindung,
            this.Abfahrt,
            this.Ankunft,
            this.Dauer});
            this.dataGridView1.Location = new System.Drawing.Point(12, 120);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(547, 150);
            this.dataGridView1.TabIndex = 6;
            // 
            // Verbindung
            // 
            this.Verbindung.HeaderText = "Verbindung";
            this.Verbindung.MinimumWidth = 6;
            this.Verbindung.Name = "Verbindung";
            this.Verbindung.ReadOnly = true;
            this.Verbindung.Width = 125;
            // 
            // Abfahrt
            // 
            this.Abfahrt.HeaderText = "Abfahrt";
            this.Abfahrt.MinimumWidth = 6;
            this.Abfahrt.Name = "Abfahrt";
            this.Abfahrt.ReadOnly = true;
            this.Abfahrt.Width = 125;
            // 
            // Ankunft
            // 
            this.Ankunft.HeaderText = "Ankunft";
            this.Ankunft.MinimumWidth = 6;
            this.Ankunft.Name = "Ankunft";
            this.Ankunft.ReadOnly = true;
            this.Ankunft.Width = 125;
            // 
            // Dauer
            // 
            this.Dauer.HeaderText = "Dauer";
            this.Dauer.MinimumWidth = 6;
            this.Dauer.Name = "Dauer";
            this.Dauer.ReadOnly = true;
            this.Dauer.Width = 125;
            // 
            // MyTransportApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ZielortTextBox);
            this.Controls.Add(this.ZielortLabel);
            this.Controls.Add(this.StartortLabel);
            this.Controls.Add(this.StartortTextBox);
            this.Name = "MyTransportApp";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox StartortTextBox;
        private System.Windows.Forms.Label StartortLabel;
        private System.Windows.Forms.Label ZielortLabel;
        private System.Windows.Forms.TextBox ZielortTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Verbindung;
        private System.Windows.Forms.DataGridViewTextBoxColumn Abfahrt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ankunft;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dauer;
    }
}

