namespace anexinet_exercise
{
    partial class Form3
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
            this.string_1_txt = new System.Windows.Forms.TextBox();
            this.string_2_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.process_btn = new System.Windows.Forms.Button();
            this.result_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // string_1_txt
            // 
            this.string_1_txt.Location = new System.Drawing.Point(12, 38);
            this.string_1_txt.Name = "string_1_txt";
            this.string_1_txt.Size = new System.Drawing.Size(206, 20);
            this.string_1_txt.TabIndex = 0;
            // 
            // string_2_txt
            // 
            this.string_2_txt.Location = new System.Drawing.Point(12, 91);
            this.string_2_txt.Name = "string_2_txt";
            this.string_2_txt.Size = new System.Drawing.Size(206, 20);
            this.string_2_txt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "String 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "String 2";
            // 
            // process_btn
            // 
            this.process_btn.Location = new System.Drawing.Point(65, 140);
            this.process_btn.Name = "process_btn";
            this.process_btn.Size = new System.Drawing.Size(96, 23);
            this.process_btn.TabIndex = 4;
            this.process_btn.Text = "Process";
            this.process_btn.UseVisualStyleBackColor = true;
            this.process_btn.Click += new System.EventHandler(this.process_btn_Click);
            // 
            // result_txt
            // 
            this.result_txt.Location = new System.Drawing.Point(15, 219);
            this.result_txt.Name = "result_txt";
            this.result_txt.ReadOnly = true;
            this.result_txt.Size = new System.Drawing.Size(203, 20);
            this.result_txt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Result";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 324);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.result_txt);
            this.Controls.Add(this.process_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.string_2_txt);
            this.Controls.Add(this.string_1_txt);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox string_1_txt;
        private System.Windows.Forms.TextBox string_2_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button process_btn;
        private System.Windows.Forms.TextBox result_txt;
        private System.Windows.Forms.Label label3;
    }
}