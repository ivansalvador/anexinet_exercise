namespace anexinet_exercise
{
    partial class Form4
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
            this.process_btn = new System.Windows.Forms.Button();
            this.result_txt = new System.Windows.Forms.TextBox();
            this.input_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // process_btn
            // 
            this.process_btn.Location = new System.Drawing.Point(85, 84);
            this.process_btn.Name = "process_btn";
            this.process_btn.Size = new System.Drawing.Size(75, 23);
            this.process_btn.TabIndex = 0;
            this.process_btn.Text = "Process";
            this.process_btn.UseVisualStyleBackColor = true;
            this.process_btn.Click += new System.EventHandler(this.process_btn_Click);
            // 
            // result_txt
            // 
            this.result_txt.Location = new System.Drawing.Point(12, 143);
            this.result_txt.Name = "result_txt";
            this.result_txt.ReadOnly = true;
            this.result_txt.Size = new System.Drawing.Size(232, 20);
            this.result_txt.TabIndex = 1;
            // 
            // input_txt
            // 
            this.input_txt.Location = new System.Drawing.Point(12, 39);
            this.input_txt.Name = "input_txt";
            this.input_txt.Size = new System.Drawing.Size(232, 20);
            this.input_txt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "String";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Result";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 197);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.input_txt);
            this.Controls.Add(this.result_txt);
            this.Controls.Add(this.process_btn);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button process_btn;
        private System.Windows.Forms.TextBox result_txt;
        private System.Windows.Forms.TextBox input_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}