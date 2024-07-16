namespace bibrus
{
    partial class Form12
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form12));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Klasa_4a = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Klasa_3H = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Klasa_2G = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Linen;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Klasa_4a,
            this.Klasa_3H,
            this.Klasa_2G});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(410, 237);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Klasa_4a
            // 
            this.Klasa_4a.HeaderText = "Klasa 1A";
            this.Klasa_4a.Name = "Klasa_4a";
            this.Klasa_4a.ReadOnly = true;
            // 
            // Klasa_3H
            // 
            this.Klasa_3H.HeaderText = "Klasa 3H";
            this.Klasa_3H.Name = "Klasa_3H";
            // 
            // Klasa_2G
            // 
            this.Klasa_2G.HeaderText = "Klasa 2G";
            this.Klasa_2G.Name = "Klasa_2G";
            // 
            // Form12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::bibrus.Properties.Resources.pobrany_plik;
            this.ClientSize = new System.Drawing.Size(434, 261);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form12";
            this.Text = "Form12";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewButtonColumn Klasa_4a;
        private System.Windows.Forms.DataGridViewButtonColumn Klasa_3H;
        private System.Windows.Forms.DataGridViewButtonColumn Klasa_2G;
    }
}