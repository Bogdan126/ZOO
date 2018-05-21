namespace ZOO
{
    partial class Zoomain
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
            this.zooDataSet = new ZOO.ZooDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.TablesList = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AdvancedOptions = new System.Windows.Forms.Button();
            this.SimpleOptions = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TableListAdv = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.FindButtonAdv = new System.Windows.Forms.Button();
            this.FindButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.InsertData = new System.Windows.Forms.Button();
            this.TableInsertList = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.InsertButton = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Button_Delete = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TableDeleteList = new System.Windows.Forms.ListBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.zooDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // zooDataSet
            // 
            this.zooDataSet.DataSetName = "ZooDataSet";
            this.zooDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista Tabel";
            // 
            // TablesList
            // 
            this.TablesList.FormattingEnabled = true;
            this.TablesList.Location = new System.Drawing.Point(6, 127);
            this.TablesList.Name = "TablesList";
            this.TablesList.Size = new System.Drawing.Size(116, 186);
            this.TablesList.TabIndex = 1;
            this.TablesList.SelectedValueChanged += new System.EventHandler(this.TablesList_SelectedValueChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(152, 127);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 243);
            this.dataGridView1.TabIndex = 2;
            // 
            // AdvancedOptions
            // 
            this.AdvancedOptions.ForeColor = System.Drawing.Color.Red;
            this.AdvancedOptions.Location = new System.Drawing.Point(157, 37);
            this.AdvancedOptions.Name = "AdvancedOptions";
            this.AdvancedOptions.Size = new System.Drawing.Size(145, 50);
            this.AdvancedOptions.TabIndex = 3;
            this.AdvancedOptions.Text = "Wyszukiwanie zaawansowane";
            this.AdvancedOptions.UseVisualStyleBackColor = true;
            this.AdvancedOptions.Click += new System.EventHandler(this.AdvancedOptions_Click);
            // 
            // SimpleOptions
            // 
            this.SimpleOptions.Enabled = false;
            this.SimpleOptions.ForeColor = System.Drawing.Color.Red;
            this.SimpleOptions.Location = new System.Drawing.Point(6, 37);
            this.SimpleOptions.Name = "SimpleOptions";
            this.SimpleOptions.Size = new System.Drawing.Size(145, 50);
            this.SimpleOptions.TabIndex = 4;
            this.SimpleOptions.Text = "Wyszukiwanie proste";
            this.SimpleOptions.UseVisualStyleBackColor = true;
            this.SimpleOptions.Click += new System.EventHandler(this.SimpleOptions_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(3, 373);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Wyszukiwanie zaawansowane:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(3, 415);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Wyszukaj w tabeli:";
            // 
            // TableListAdv
            // 
            this.TableListAdv.Enabled = false;
            this.TableListAdv.FormattingEnabled = true;
            this.TableListAdv.Location = new System.Drawing.Point(6, 438);
            this.TableListAdv.Name = "TableListAdv";
            this.TableListAdv.Size = new System.Drawing.Size(116, 186);
            this.TableListAdv.TabIndex = 7;
            this.TableListAdv.SelectedValueChanged += new System.EventHandler(this.TableListAdv_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(134, 438);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Gdzie:";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(177, 435);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(116, 20);
            this.textBox1.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Location = new System.Drawing.Point(174, 458);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "np. \"Imię = \'Adam\'\"";
            // 
            // FindButtonAdv
            // 
            this.FindButtonAdv.Enabled = false;
            this.FindButtonAdv.Location = new System.Drawing.Point(177, 492);
            this.FindButtonAdv.Name = "FindButtonAdv";
            this.FindButtonAdv.Size = new System.Drawing.Size(116, 51);
            this.FindButtonAdv.TabIndex = 11;
            this.FindButtonAdv.Text = "Wyszukaj";
            this.FindButtonAdv.UseVisualStyleBackColor = true;
            this.FindButtonAdv.Click += new System.EventHandler(this.FindButtonAdv_Click);
            // 
            // FindButton
            // 
            this.FindButton.Enabled = false;
            this.FindButton.Location = new System.Drawing.Point(6, 319);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(116, 51);
            this.FindButton.TabIndex = 12;
            this.FindButton.Text = "Wyszukaj";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(305, 373);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(210, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Wprowadzanie nowych danych: ";
            // 
            // InsertData
            // 
            this.InsertData.Enabled = false;
            this.InsertData.Location = new System.Drawing.Point(458, 492);
            this.InsertData.Name = "InsertData";
            this.InsertData.Size = new System.Drawing.Size(112, 51);
            this.InsertData.TabIndex = 14;
            this.InsertData.Text = "Wprowadź dane";
            this.InsertData.UseVisualStyleBackColor = true;
            this.InsertData.Click += new System.EventHandler(this.InsertData_Click);
            // 
            // TableInsertList
            // 
            this.TableInsertList.Enabled = false;
            this.TableInsertList.FormattingEnabled = true;
            this.TableInsertList.Location = new System.Drawing.Point(308, 438);
            this.TableInsertList.Name = "TableInsertList";
            this.TableInsertList.Size = new System.Drawing.Size(128, 186);
            this.TableInsertList.TabIndex = 15;
            this.TableInsertList.SelectedValueChanged += new System.EventHandler(this.TableInsertList_SelectedValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.Location = new System.Drawing.Point(305, 415);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Wprowadź dane do tabeli:";
            // 
            // InsertButton
            // 
            this.InsertButton.ForeColor = System.Drawing.Color.Red;
            this.InsertButton.Location = new System.Drawing.Point(308, 37);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(141, 50);
            this.InsertButton.TabIndex = 17;
            this.InsertButton.Text = "Wprowadzanie nowych danych";
            this.InsertButton.UseVisualStyleBackColor = true;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(458, 438);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(112, 20);
            this.textBox2.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Enabled = false;
            this.label8.Location = new System.Drawing.Point(455, 415);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Wartości do przypisania: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Enabled = false;
            this.label9.Location = new System.Drawing.Point(455, 461);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "np. \'Bogdan\', \'Nowak\'";
            // 
            // Button_Delete
            // 
            this.Button_Delete.ForeColor = System.Drawing.Color.Red;
            this.Button_Delete.Location = new System.Drawing.Point(458, 37);
            this.Button_Delete.Name = "Button_Delete";
            this.Button_Delete.Size = new System.Drawing.Size(135, 50);
            this.Button_Delete.TabIndex = 21;
            this.Button_Delete.Text = "Usuwanie danych";
            this.Button_Delete.UseVisualStyleBackColor = true;
            this.Button_Delete.Click += new System.EventHandler(this.Button_Delete_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Enabled = false;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.Location = new System.Drawing.Point(606, 373);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 17);
            this.label10.TabIndex = 22;
            this.label10.Text = "Usuwanie danych: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Enabled = false;
            this.label11.Location = new System.Drawing.Point(606, 415);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Usuń wpis z tabeli:";
            // 
            // TableDeleteList
            // 
            this.TableDeleteList.Enabled = false;
            this.TableDeleteList.FormattingEnabled = true;
            this.TableDeleteList.Location = new System.Drawing.Point(609, 438);
            this.TableDeleteList.Name = "TableDeleteList";
            this.TableDeleteList.Size = new System.Drawing.Size(128, 186);
            this.TableDeleteList.TabIndex = 24;
            this.TableDeleteList.SelectedValueChanged += new System.EventHandler(this.TableDeleteList_SelectedValueChanged);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Enabled = false;
            this.DeleteButton.Location = new System.Drawing.Point(755, 492);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(112, 51);
            this.DeleteButton.TabIndex = 25;
            this.DeleteButton.Text = "Usuń wpis";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(756, 438);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(111, 20);
            this.textBox3.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Enabled = false;
            this.label12.Location = new System.Drawing.Point(753, 415);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Warunek:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Enabled = false;
            this.label13.Location = new System.Drawing.Point(753, 461);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "np. Kie_ID = 6";
            // 
            // Zoomain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 657);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.TableDeleteList);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Button_Delete);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.InsertButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TableInsertList);
            this.Controls.Add(this.InsertData);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.FindButton);
            this.Controls.Add(this.FindButtonAdv);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TableListAdv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SimpleOptions);
            this.Controls.Add(this.AdvancedOptions);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TablesList);
            this.Controls.Add(this.label1);
            this.Name = "Zoomain";
            this.Text = "Zoo app";
            this.Load += new System.EventHandler(this.Zoomain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zooDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZooDataSet zooDataSet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox TablesList;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AdvancedOptions;
        private System.Windows.Forms.Button SimpleOptions;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox TableListAdv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button FindButtonAdv;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button InsertData;
        private System.Windows.Forms.ListBox TableInsertList;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Button_Delete;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox TableDeleteList;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}

