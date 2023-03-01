
namespace Projekt
{
    partial class strona_glowna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(strona_glowna));
            this.login_btn = new System.Windows.Forms.Button();
            this.wypoz_btn = new System.Windows.Forms.Button();
            this.clear_btn = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.TextBox();
            this.author = new System.Windows.Forms.TextBox();
            this.category = new System.Windows.Forms.ComboBox();
            this.kategorieBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.daneDataSet = new Projekt.DaneDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.kategorieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kategorieTableAdapter = new Projekt.DaneDataSetTableAdapters.KategorieTableAdapter();
            this.zalogowanylabel = new System.Windows.Forms.Label();
            this.search_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.kategorieBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daneDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // login_btn
            // 
            this.login_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.login_btn.Location = new System.Drawing.Point(24, 76);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(109, 28);
            this.login_btn.TabIndex = 3;
            this.login_btn.Text = "Wyloguj";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // wypoz_btn
            // 
            this.wypoz_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.wypoz_btn.Location = new System.Drawing.Point(24, 42);
            this.wypoz_btn.Name = "wypoz_btn";
            this.wypoz_btn.Size = new System.Drawing.Size(109, 28);
            this.wypoz_btn.TabIndex = 4;
            this.wypoz_btn.Text = "Wypożyczenia";
            this.wypoz_btn.UseVisualStyleBackColor = true;
            this.wypoz_btn.Click += new System.EventHandler(this.wypoz_btn_Click);
            // 
            // clear_btn
            // 
            this.clear_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.clear_btn.Location = new System.Drawing.Point(662, 130);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(115, 28);
            this.clear_btn.TabIndex = 5;
            this.clear_btn.Text = "Czyść filtry";
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(662, 24);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(115, 20);
            this.title.TabIndex = 6;
            // 
            // author
            // 
            this.author.Location = new System.Drawing.Point(662, 50);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(115, 20);
            this.author.TabIndex = 7;
            // 
            // category
            // 
            this.category.DataSource = this.kategorieBindingSource1;
            this.category.DisplayMember = "nazwa";
            this.category.FormattingEnabled = true;
            this.category.Location = new System.Drawing.Point(662, 76);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(115, 21);
            this.category.TabIndex = 8;
            // 
            // kategorieBindingSource1
            // 
            this.kategorieBindingSource1.DataMember = "Kategorie";
            this.kategorieBindingSource1.DataSource = this.daneDataSet;
            // 
            // daneDataSet
            // 
            this.daneDataSet.DataSetName = "DaneDataSet";
            this.daneDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(613, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tytuł:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(610, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Autor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(583, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Kategoria:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(177, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(358, 189);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // kategorieBindingSource
            // 
            this.kategorieBindingSource.DataMember = "Kategorie";
            this.kategorieBindingSource.DataSource = this.daneDataSet;
            // 
            // kategorieTableAdapter
            // 
            this.kategorieTableAdapter.ClearBeforeFill = true;
            // 
            // zalogowanylabel
            // 
            this.zalogowanylabel.AutoSize = true;
            this.zalogowanylabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.zalogowanylabel.Location = new System.Drawing.Point(19, 9);
            this.zalogowanylabel.Name = "zalogowanylabel";
            this.zalogowanylabel.Size = new System.Drawing.Size(70, 26);
            this.zalogowanylabel.TabIndex = 14;
            this.zalogowanylabel.Text = "label4";
            // 
            // search_btn
            // 
            this.search_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.search_btn.Location = new System.Drawing.Point(541, 130);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(109, 28);
            this.search_btn.TabIndex = 28;
            this.search_btn.Text = "Szukaj";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 198);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(753, 241);
            this.dataGridView1.TabIndex = 29;
            // 
            // strona_glowna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.zalogowanylabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.category);
            this.Controls.Add(this.author);
            this.Controls.Add(this.title);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.wypoz_btn);
            this.Controls.Add(this.login_btn);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.kategorieBindingSource, "nazwa", true));
            this.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kategorieBindingSource, "nazwa", true));
            this.Name = "strona_glowna";
            this.Text = "Strona Główna";
            this.Load += new System.EventHandler(this.strona_glowna_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kategorieBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daneDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Button wypoz_btn;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.TextBox author;
        private System.Windows.Forms.ComboBox category;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DaneDataSet daneDataSet;
        private System.Windows.Forms.BindingSource kategorieBindingSource;
        private DaneDataSetTableAdapters.KategorieTableAdapter kategorieTableAdapter;
        private System.Windows.Forms.BindingSource kategorieBindingSource1;
        private System.Windows.Forms.Label zalogowanylabel;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}