namespace Parser_v0._2
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
            this.txtLink = new System.Windows.Forms.TextBox();
            this.btnParse = new System.Windows.Forms.Button();
            this.lbInfo = new System.Windows.Forms.ListBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtLink
            // 
            this.txtLink.Location = new System.Drawing.Point(184, 23);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(828, 32);
            this.txtLink.TabIndex = 7;
            // 
            // btnParse
            // 
            this.btnParse.Location = new System.Drawing.Point(783, 80);
            this.btnParse.Name = "btnParse";
            this.btnParse.Size = new System.Drawing.Size(229, 32);
            this.btnParse.TabIndex = 2;
            this.btnParse.Text = "Recieve results";
            this.btnParse.UseVisualStyleBackColor = true;
            this.btnParse.Click += new System.EventHandler(this.btnParse_Click);
            // 
            // lbInfo
            // 
            this.lbInfo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbInfo.FormattingEnabled = true;
            this.lbInfo.ItemHeight = 21;
            this.lbInfo.Location = new System.Drawing.Point(25, 127);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.ScrollAlwaysVisible = true;
            this.lbInfo.Size = new System.Drawing.Size(580, 340);
            this.lbInfo.TabIndex = 3;
            this.lbInfo.SelectedIndexChanged += new System.EventHandler(this.lbInfo_SelectedIndexChanged);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(715, 435);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(297, 32);
            this.txtResult.TabIndex = 4;
            this.txtResult.TextChanged += new System.EventHandler(this.txtResult_TextChanged);
            // 
            // btnClear
            // 
            this.btnClear.Enabled = false;
            this.btnClear.Location = new System.Drawing.Point(783, 127);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(229, 32);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear results";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "Input link:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 521);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.btnParse);
            this.Controls.Add(this.txtLink);
            this.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.Button btnParse;
        private System.Windows.Forms.ListBox lbInfo;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label1;
    }
}

