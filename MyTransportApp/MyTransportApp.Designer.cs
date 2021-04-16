
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
            this.VerbindungSuchenButton = new System.Windows.Forms.Button();
            this.VerbindungenGridView = new System.Windows.Forms.DataGridView();
            this.Startort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zielort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Abfahrt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ankunft = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dauer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Plattform = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VerbindungGroupBox = new System.Windows.Forms.GroupBox();
            this.AbfahrtstafelGroupBox = new System.Windows.Forms.GroupBox();
            this.AbfahrtstafelGridView = new System.Windows.Forms.DataGridView();
            this.StartortAbfahrtstafelTextBox = new System.Windows.Forms.TextBox();
            this.VerbindungSuchenAbfahrtstafelButton = new System.Windows.Forms.Button();
            this.StartortAbfahrtstafelLabel = new System.Windows.Forms.Label();
            this.ZielortAbfahrtstafel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AbfahrtAbfahrtstafel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.VerbindungenGridView)).BeginInit();
            this.VerbindungGroupBox.SuspendLayout();
            this.AbfahrtstafelGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AbfahrtstafelGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // StartortTextBox
            // 
            this.StartortTextBox.Location = new System.Drawing.Point(21, 50);
            this.StartortTextBox.Name = "StartortTextBox";
            this.StartortTextBox.Size = new System.Drawing.Size(274, 22);
            this.StartortTextBox.TabIndex = 0;
            // 
            // StartortLabel
            // 
            this.StartortLabel.AutoSize = true;
            this.StartortLabel.Location = new System.Drawing.Point(18, 26);
            this.StartortLabel.Name = "StartortLabel";
            this.StartortLabel.Size = new System.Drawing.Size(55, 17);
            this.StartortLabel.TabIndex = 2;
            this.StartortLabel.Text = "Startort";
            // 
            // ZielortLabel
            // 
            this.ZielortLabel.AutoSize = true;
            this.ZielortLabel.Location = new System.Drawing.Point(328, 26);
            this.ZielortLabel.Name = "ZielortLabel";
            this.ZielortLabel.Size = new System.Drawing.Size(48, 17);
            this.ZielortLabel.TabIndex = 3;
            this.ZielortLabel.Text = "Zielort";
            // 
            // ZielortTextBox
            // 
            this.ZielortTextBox.Location = new System.Drawing.Point(331, 50);
            this.ZielortTextBox.Name = "ZielortTextBox";
            this.ZielortTextBox.Size = new System.Drawing.Size(274, 22);
            this.ZielortTextBox.TabIndex = 4;
            // 
            // VerbindungSuchenButton
            // 
            this.VerbindungSuchenButton.Location = new System.Drawing.Point(21, 88);
            this.VerbindungSuchenButton.Name = "VerbindungSuchenButton";
            this.VerbindungSuchenButton.Size = new System.Drawing.Size(584, 29);
            this.VerbindungSuchenButton.TabIndex = 5;
            this.VerbindungSuchenButton.Text = "Verbindung suchen";
            this.VerbindungSuchenButton.UseVisualStyleBackColor = true;
            this.VerbindungSuchenButton.Click += new System.EventHandler(this.VerbindungSuchenButton_Click);
            // 
            // VerbindungenGridView
            // 
            this.VerbindungenGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VerbindungenGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Startort,
            this.Zielort,
            this.Abfahrt,
            this.Ankunft,
            this.Dauer,
            this.Plattform});
            this.VerbindungenGridView.Location = new System.Drawing.Point(21, 131);
            this.VerbindungenGridView.Name = "VerbindungenGridView";
            this.VerbindungenGridView.RowHeadersVisible = false;
            this.VerbindungenGridView.RowHeadersWidth = 51;
            this.VerbindungenGridView.RowTemplate.Height = 24;
            this.VerbindungenGridView.Size = new System.Drawing.Size(753, 171);
            this.VerbindungenGridView.TabIndex = 6;
            // 
            // Startort
            // 
            this.Startort.HeaderText = "Startort";
            this.Startort.MinimumWidth = 6;
            this.Startort.Name = "Startort";
            this.Startort.ReadOnly = true;
            this.Startort.Width = 125;
            // 
            // Zielort
            // 
            this.Zielort.HeaderText = "Zielort";
            this.Zielort.MinimumWidth = 6;
            this.Zielort.Name = "Zielort";
            this.Zielort.ReadOnly = true;
            this.Zielort.Width = 125;
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
            // Plattform
            // 
            this.Plattform.HeaderText = "Plattform";
            this.Plattform.MinimumWidth = 6;
            this.Plattform.Name = "Plattform";
            this.Plattform.ReadOnly = true;
            this.Plattform.Width = 125;
            // 
            // VerbindungGroupBox
            // 
            this.VerbindungGroupBox.Controls.Add(this.VerbindungenGridView);
            this.VerbindungGroupBox.Controls.Add(this.StartortTextBox);
            this.VerbindungGroupBox.Controls.Add(this.VerbindungSuchenButton);
            this.VerbindungGroupBox.Controls.Add(this.StartortLabel);
            this.VerbindungGroupBox.Controls.Add(this.ZielortTextBox);
            this.VerbindungGroupBox.Controls.Add(this.ZielortLabel);
            this.VerbindungGroupBox.Location = new System.Drawing.Point(12, 12);
            this.VerbindungGroupBox.Name = "VerbindungGroupBox";
            this.VerbindungGroupBox.Size = new System.Drawing.Size(787, 317);
            this.VerbindungGroupBox.TabIndex = 7;
            this.VerbindungGroupBox.TabStop = false;
            this.VerbindungGroupBox.Text = "Verbindung suchen";
            // 
            // AbfahrtstafelGroupBox
            // 
            this.AbfahrtstafelGroupBox.Controls.Add(this.AbfahrtstafelGridView);
            this.AbfahrtstafelGroupBox.Controls.Add(this.StartortAbfahrtstafelTextBox);
            this.AbfahrtstafelGroupBox.Controls.Add(this.VerbindungSuchenAbfahrtstafelButton);
            this.AbfahrtstafelGroupBox.Controls.Add(this.StartortAbfahrtstafelLabel);
            this.AbfahrtstafelGroupBox.Location = new System.Drawing.Point(12, 351);
            this.AbfahrtstafelGroupBox.Name = "AbfahrtstafelGroupBox";
            this.AbfahrtstafelGroupBox.Size = new System.Drawing.Size(316, 317);
            this.AbfahrtstafelGroupBox.TabIndex = 8;
            this.AbfahrtstafelGroupBox.TabStop = false;
            this.AbfahrtstafelGroupBox.Text = "Abfahrtstafel";
            // 
            // AbfahrtstafelGridView
            // 
            this.AbfahrtstafelGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AbfahrtstafelGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ZielortAbfahrtstafel,
            this.AbfahrtAbfahrtstafel});
            this.AbfahrtstafelGridView.Location = new System.Drawing.Point(21, 131);
            this.AbfahrtstafelGridView.Name = "AbfahrtstafelGridView";
            this.AbfahrtstafelGridView.RowHeadersVisible = false;
            this.AbfahrtstafelGridView.RowHeadersWidth = 51;
            this.AbfahrtstafelGridView.RowTemplate.Height = 24;
            this.AbfahrtstafelGridView.Size = new System.Drawing.Size(280, 171);
            this.AbfahrtstafelGridView.TabIndex = 6;
            // 
            // StartortAbfahrtstafelTextBox
            // 
            this.StartortAbfahrtstafelTextBox.Location = new System.Drawing.Point(21, 46);
            this.StartortAbfahrtstafelTextBox.Name = "StartortAbfahrtstafelTextBox";
            this.StartortAbfahrtstafelTextBox.Size = new System.Drawing.Size(280, 22);
            this.StartortAbfahrtstafelTextBox.TabIndex = 0;
            // 
            // VerbindungSuchenAbfahrtstafelButton
            // 
            this.VerbindungSuchenAbfahrtstafelButton.Location = new System.Drawing.Point(21, 88);
            this.VerbindungSuchenAbfahrtstafelButton.Name = "VerbindungSuchenAbfahrtstafelButton";
            this.VerbindungSuchenAbfahrtstafelButton.Size = new System.Drawing.Size(280, 29);
            this.VerbindungSuchenAbfahrtstafelButton.TabIndex = 5;
            this.VerbindungSuchenAbfahrtstafelButton.Text = "Verbindung suchen";
            this.VerbindungSuchenAbfahrtstafelButton.UseVisualStyleBackColor = true;
            this.VerbindungSuchenAbfahrtstafelButton.Click += new System.EventHandler(this.VerbindungSuchenAbfahrtstafelButton_Click);
            // 
            // StartortAbfahrtstafelLabel
            // 
            this.StartortAbfahrtstafelLabel.AutoSize = true;
            this.StartortAbfahrtstafelLabel.Location = new System.Drawing.Point(18, 26);
            this.StartortAbfahrtstafelLabel.Name = "StartortAbfahrtstafelLabel";
            this.StartortAbfahrtstafelLabel.Size = new System.Drawing.Size(55, 17);
            this.StartortAbfahrtstafelLabel.TabIndex = 2;
            this.StartortAbfahrtstafelLabel.Text = "Startort";
            // 
            // ZielortAbfahrtstafel
            // 
            this.ZielortAbfahrtstafel.HeaderText = "Zielort";
            this.ZielortAbfahrtstafel.MinimumWidth = 6;
            this.ZielortAbfahrtstafel.Name = "ZielortAbfahrtstafel";
            this.ZielortAbfahrtstafel.ReadOnly = true;
            this.ZielortAbfahrtstafel.Width = 150;
            // 
            // AbfahrtAbfahrtstafel
            // 
            this.AbfahrtAbfahrtstafel.HeaderText = "Abfahrt";
            this.AbfahrtAbfahrtstafel.MinimumWidth = 6;
            this.AbfahrtAbfahrtstafel.Name = "AbfahrtAbfahrtstafel";
            this.AbfahrtAbfahrtstafel.ReadOnly = true;
            this.AbfahrtAbfahrtstafel.Width = 125;
            // 
            // MyTransportApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 767);
            this.Controls.Add(this.AbfahrtstafelGroupBox);
            this.Controls.Add(this.VerbindungGroupBox);
            this.Name = "MyTransportApp";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.VerbindungenGridView)).EndInit();
            this.VerbindungGroupBox.ResumeLayout(false);
            this.VerbindungGroupBox.PerformLayout();
            this.AbfahrtstafelGroupBox.ResumeLayout(false);
            this.AbfahrtstafelGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AbfahrtstafelGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox StartortTextBox;
        private System.Windows.Forms.Label StartortLabel;
        private System.Windows.Forms.Label ZielortLabel;
        private System.Windows.Forms.TextBox ZielortTextBox;
        private System.Windows.Forms.Button VerbindungSuchenButton;
        private System.Windows.Forms.DataGridView VerbindungenGridView;
        private System.Windows.Forms.GroupBox VerbindungGroupBox;
        private System.Windows.Forms.GroupBox AbfahrtstafelGroupBox;
        private System.Windows.Forms.DataGridView AbfahrtstafelGridView;
        private System.Windows.Forms.TextBox StartortAbfahrtstafelTextBox;
        private System.Windows.Forms.Button VerbindungSuchenAbfahrtstafelButton;
        private System.Windows.Forms.Label StartortAbfahrtstafelLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Startort;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zielort;
        private System.Windows.Forms.DataGridViewTextBoxColumn Abfahrt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ankunft;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dauer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Plattform;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZielortAbfahrtstafel;
        private System.Windows.Forms.DataGridViewTextBoxColumn AbfahrtAbfahrtstafel;
    }
}

