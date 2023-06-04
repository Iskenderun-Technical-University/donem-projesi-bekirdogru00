namespace WindowsFormsApp1
{
    partial class guncellemesilme
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guncellemesilme));
            this.button1 = new System.Windows.Forms.Button();
            this.cinsiyetcb = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ücrettb = new System.Windows.Forms.TextBox();
            this.yaştb = new System.Windows.Forms.TextBox();
            this.telnotb = new System.Windows.Forms.TextBox();
            this.adsoyadtb = new System.Windows.Forms.TextBox();
            this.kayitekleDataSet = new WindowsFormsApp1.kayitekleDataSet();
            this.kangrubucb = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.kayitekleDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.kayitekleDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.kayitekleDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kayitekleDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kayitekleDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(397, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 41);
            this.button1.TabIndex = 27;
            this.button1.Text = "GÜNCELLE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cinsiyetcb
            // 
            this.cinsiyetcb.FormattingEnabled = true;
            this.cinsiyetcb.Items.AddRange(new object[] {
            "BAY",
            "BAYAN"});
            this.cinsiyetcb.Location = new System.Drawing.Point(174, 190);
            this.cinsiyetcb.Name = "cinsiyetcb";
            this.cinsiyetcb.Size = new System.Drawing.Size(121, 21);
            this.cinsiyetcb.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Himalaya", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 16);
            this.label6.TabIndex = 25;
            this.label6.Text = "AYLIK ÜCRET";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Himalaya", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "CİNSİYET";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Himalaya", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "KAN GRUBU";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Himalaya", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "YAŞ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Himalaya", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "TELEFON NUMARASI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Himalaya", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "AD SOYAD";
            // 
            // ücrettb
            // 
            this.ücrettb.Location = new System.Drawing.Point(174, 216);
            this.ücrettb.Name = "ücrettb";
            this.ücrettb.Size = new System.Drawing.Size(121, 20);
            this.ücrettb.TabIndex = 19;
            // 
            // yaştb
            // 
            this.yaştb.Location = new System.Drawing.Point(174, 135);
            this.yaştb.Name = "yaştb";
            this.yaştb.Size = new System.Drawing.Size(121, 20);
            this.yaştb.TabIndex = 17;
            // 
            // telnotb
            // 
            this.telnotb.Location = new System.Drawing.Point(174, 110);
            this.telnotb.Name = "telnotb";
            this.telnotb.Size = new System.Drawing.Size(121, 20);
            this.telnotb.TabIndex = 16;
            // 
            // adsoyadtb
            // 
            this.adsoyadtb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kayitekleDataSet, "üyeekle.adsoyad", true));
            this.adsoyadtb.Location = new System.Drawing.Point(174, 81);
            this.adsoyadtb.Name = "adsoyadtb";
            this.adsoyadtb.Size = new System.Drawing.Size(121, 20);
            this.adsoyadtb.TabIndex = 15;
            // 
            // kayitekleDataSet
            // 
            this.kayitekleDataSet.DataSetName = "kayitekleDataSet";
            this.kayitekleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kangrubucb
            // 
            this.kangrubucb.FormattingEnabled = true;
            this.kangrubucb.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-",
            "0+",
            "0-"});
            this.kangrubucb.Location = new System.Drawing.Point(174, 163);
            this.kangrubucb.Name = "kangrubucb";
            this.kangrubucb.Size = new System.Drawing.Size(121, 21);
            this.kangrubucb.TabIndex = 29;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(397, 161);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 41);
            this.button3.TabIndex = 32;
            this.button3.Text = "GERİ";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(33, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(525, 39);
            this.label7.TabIndex = 36;
            this.label7.Text = "ÜYE GÜNCELLEME VE SİLME";
            // 
            // kayitekleDataSetBindingSource
            // 
            this.kayitekleDataSetBindingSource.DataSource = this.kayitekleDataSet;
            this.kayitekleDataSetBindingSource.Position = 0;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(397, 114);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 41);
            this.button2.TabIndex = 38;
            this.button2.Text = "SİL";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // kayitekleDataSetBindingSource1
            // 
            this.kayitekleDataSetBindingSource1.DataSource = this.kayitekleDataSet;
            this.kayitekleDataSetBindingSource1.Position = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 242);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(512, 252);
            this.dataGridView1.TabIndex = 39;
           
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // guncellemesilme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(587, 506);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.kangrubucb);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cinsiyetcb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ücrettb);
            this.Controls.Add(this.yaştb);
            this.Controls.Add(this.telnotb);
            this.Controls.Add(this.adsoyadtb);
            this.Name = "guncellemesilme";
            this.Text = "guncellemesilme";
            this.Load += new System.EventHandler(this.guncellemesilme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kayitekleDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kayitekleDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kayitekleDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cinsiyetcb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ücrettb;
        private System.Windows.Forms.TextBox yaştb;
        private System.Windows.Forms.TextBox telnotb;
        private System.Windows.Forms.TextBox adsoyadtb;
        private System.Windows.Forms.ComboBox kangrubucb;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.BindingSource kayitekleDataSetBindingSource;
        private kayitekleDataSet kayitekleDataSet;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource kayitekleDataSetBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}