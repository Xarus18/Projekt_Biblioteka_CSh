
namespace Projekt
{
    partial class strona_glowna_guest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(strona_glowna_guest));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.category = new System.Windows.Forms.ComboBox();
            this.author = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.TextBox();
            this.clear_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.login_btn = new System.Windows.Forms.Button();
            this.search_btn = new System.Windows.Forms.Button();
            this.daneDataSet = new Projekt.DaneDataSet();
            this.kategorieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kategorieTableAdapter = new Projekt.DaneDataSetTableAdapters.KategorieTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.zalogowanylabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daneDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(179, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(358, 189);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(585, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Kategoria:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(612, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Autor:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(615, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Tytuł:";
            // 
            // category
            // 
            this.category.DataSource = this.kategorieBindingSource;
            this.category.DisplayMember = "nazwa";
            this.category.FormattingEnabled = true;
            this.category.Location = new System.Drawing.Point(664, 75);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(115, 21);
            this.category.TabIndex = 19;
            // 
            // author
            // 
            this.author.Location = new System.Drawing.Point(664, 49);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(115, 20);
            this.author.TabIndex = 18;
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(664, 23);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(115, 20);
            this.title.TabIndex = 17;
            // 
            // clear_btn
            // 
            this.clear_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.clear_btn.Location = new System.Drawing.Point(664, 129);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(115, 28);
            this.clear_btn.TabIndex = 16;
            this.clear_btn.Text = "Czyść filtry";
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.exit_btn.Location = new System.Drawing.Point(26, 49);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(109, 28);
            this.exit_btn.TabIndex = 14;
            this.exit_btn.Text = "Wyjdź";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // login_btn
            // 
            this.login_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.login_btn.Location = new System.Drawing.Point(26, 86);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(109, 28);
            this.login_btn.TabIndex = 25;
            this.login_btn.Text = "Zaloguj";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // search_btn
            // 
            this.search_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.search_btn.Location = new System.Drawing.Point(543, 129);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(109, 28);
            this.search_btn.TabIndex = 27;
            this.search_btn.Text = "Szukaj";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // daneDataSet
            // 
            this.daneDataSet.DataSetName = "DaneDataSet";
            this.daneDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 197);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(753, 241);
            this.dataGridView1.TabIndex = 28;
            // 
            // zalogowanylabel
            // 
            this.zalogowanylabel.AutoSize = true;
            this.zalogowanylabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.zalogowanylabel.Location = new System.Drawing.Point(21, 9);
            this.zalogowanylabel.Name = "zalogowanylabel";
            this.zalogowanylabel.Size = new System.Drawing.Size(70, 26);
            this.zalogowanylabel.TabIndex = 29;
            this.zalogowanylabel.Text = "label4";
            // 
            // strona_glowna_guest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.zalogowanylabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.category);
            this.Controls.Add(this.author);
            this.Controls.Add(this.title);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.exit_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "strona_glowna_guest";
            this.Text = "Strona Główna";
            this.Load += new System.EventHandler(this.strona_glowna_guest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daneDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox category;
        private System.Windows.Forms.TextBox author;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Button search_btn;
        private DaneDataSet daneDataSet;
        private System.Windows.Forms.BindingSource kategorieBindingSource;
        private DaneDataSetTableAdapters.KategorieTableAdapter kategorieTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label zalogowanylabel;
    }
}