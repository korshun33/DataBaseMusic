namespace DataBaseMusic
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelmelom = new System.Windows.Forms.Label();
            this.labelsearch = new System.Windows.Forms.Label();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelspis = new System.Windows.Forms.Label();
            this.buttonalb = new System.Windows.Forms.Button();
            this.buttonclear = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelmelom
            // 
            this.labelmelom.AutoSize = true;
            this.labelmelom.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelmelom.Location = new System.Drawing.Point(244, 19);
            this.labelmelom.Name = "labelmelom";
            this.labelmelom.Size = new System.Drawing.Size(374, 46);
            this.labelmelom.TabIndex = 0;
            this.labelmelom.Text = "БАЗА МЕЛОМАНА";
            // 
            // labelsearch
            // 
            this.labelsearch.AutoSize = true;
            this.labelsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.labelsearch.Location = new System.Drawing.Point(123, 78);
            this.labelsearch.Name = "labelsearch";
            this.labelsearch.Size = new System.Drawing.Size(74, 25);
            this.labelsearch.TabIndex = 1;
            this.labelsearch.Text = "Поиск:";
            // 
            // textBox_search
            // 
            this.textBox_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBox_search.Location = new System.Drawing.Point(203, 73);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(455, 30);
            this.textBox_search.TabIndex = 2;
            this.textBox_search.TextChanged += new System.EventHandler(this.textBox_search_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(203, 169);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(455, 289);
            this.dataGridView1.TabIndex = 3;
            // 
            // labelspis
            // 
            this.labelspis.AutoSize = true;
            this.labelspis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelspis.Location = new System.Drawing.Point(200, 149);
            this.labelspis.Name = "labelspis";
            this.labelspis.Size = new System.Drawing.Size(59, 17);
            this.labelspis.TabIndex = 4;
            this.labelspis.Text = "Список:";
            // 
            // buttonalb
            // 
            this.buttonalb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.buttonalb.Location = new System.Drawing.Point(720, 426);
            this.buttonalb.Name = "buttonalb";
            this.buttonalb.Size = new System.Drawing.Size(132, 32);
            this.buttonalb.TabIndex = 5;
            this.buttonalb.Text = "АЛЬБОМЫ";
            this.buttonalb.UseVisualStyleBackColor = true;
            this.buttonalb.Click += new System.EventHandler(this.buttonalb_Click);
            // 
            // buttonclear
            // 
            this.buttonclear.Location = new System.Drawing.Point(676, 78);
            this.buttonclear.Name = "buttonclear";
            this.buttonclear.Size = new System.Drawing.Size(75, 23);
            this.buttonclear.TabIndex = 6;
            this.buttonclear.Text = "очистить";
            this.buttonclear.UseVisualStyleBackColor = true;
            this.buttonclear.Click += new System.EventHandler(this.buttonclear_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(676, 169);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "обновить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 481);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonclear);
            this.Controls.Add(this.buttonalb);
            this.Controls.Add(this.labelspis);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox_search);
            this.Controls.Add(this.labelsearch);
            this.Controls.Add(this.labelmelom);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelmelom;
        private System.Windows.Forms.Label labelsearch;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelspis;
        private System.Windows.Forms.Button buttonalb;
        private System.Windows.Forms.Button buttonclear;
        private System.Windows.Forms.Button button2;
    }
}

