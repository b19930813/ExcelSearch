namespace company
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txt_excelPath = new System.Windows.Forms.TextBox();
            this.btn_readExcel = new System.Windows.Forms.Button();
            this.txt_result = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_manafacturer = new System.Windows.Forms.TextBox();
            this.btn_final = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "EXCEL路徑:";
            // 
            // txt_excelPath
            // 
            this.txt_excelPath.Location = new System.Drawing.Point(97, 25);
            this.txt_excelPath.Name = "txt_excelPath";
            this.txt_excelPath.Size = new System.Drawing.Size(335, 22);
            this.txt_excelPath.TabIndex = 1;
            // 
            // btn_readExcel
            // 
            this.btn_readExcel.Location = new System.Drawing.Point(438, 24);
            this.btn_readExcel.Name = "btn_readExcel";
            this.btn_readExcel.Size = new System.Drawing.Size(23, 23);
            this.btn_readExcel.TabIndex = 2;
            this.btn_readExcel.Text = "...";
            this.btn_readExcel.UseVisualStyleBackColor = true;
            this.btn_readExcel.Click += new System.EventHandler(this.btn_readExcel_Click);
            // 
            // txt_result
            // 
            this.txt_result.Location = new System.Drawing.Point(24, 159);
            this.txt_result.Multiline = true;
            this.txt_result.Name = "txt_result";
            this.txt_result.Size = new System.Drawing.Size(437, 304);
            this.txt_result.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 470);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(437, 26);
            this.button1.TabIndex = 4;
            this.button1.Text = "清除log";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(346, 21);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 5;
            this.btn_search.Text = "搜尋";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_manafacturer);
            this.groupBox1.Controls.Add(this.btn_search);
            this.groupBox1.Location = new System.Drawing.Point(34, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(427, 60);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "搜尋製造商";
            // 
            // txt_manafacturer
            // 
            this.txt_manafacturer.Location = new System.Drawing.Point(6, 21);
            this.txt_manafacturer.Name = "txt_manafacturer";
            this.txt_manafacturer.Size = new System.Drawing.Size(334, 22);
            this.txt_manafacturer.TabIndex = 6;
            // 
            // btn_final
            // 
            this.btn_final.Location = new System.Drawing.Point(333, 120);
            this.btn_final.Name = "btn_final";
            this.btn_final.Size = new System.Drawing.Size(122, 23);
            this.btn_final.TabIndex = 7;
            this.btn_final.Text = "全部搜尋&產生Excel";
            this.btn_final.UseVisualStyleBackColor = true;
            this.btn_final.Click += new System.EventHandler(this.btn_final_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 507);
            this.Controls.Add(this.btn_final);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_result);
            this.Controls.Add(this.btn_readExcel);
            this.Controls.Add(this.txt_excelPath);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_excelPath;
        private System.Windows.Forms.Button btn_readExcel;
        private System.Windows.Forms.TextBox txt_result;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_manafacturer;
        private System.Windows.Forms.Button btn_final;
    }
}

