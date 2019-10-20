namespace anexinet_exercise
{
    partial class Form6
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
            this.claculate_btn = new System.Windows.Forms.Button();
            this.points_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // claculate_btn
            // 
            this.claculate_btn.Location = new System.Drawing.Point(64, 86);
            this.claculate_btn.Name = "claculate_btn";
            this.claculate_btn.Size = new System.Drawing.Size(75, 23);
            this.claculate_btn.TabIndex = 0;
            this.claculate_btn.Text = "Calculate";
            this.claculate_btn.UseVisualStyleBackColor = true;
            this.claculate_btn.Click += new System.EventHandler(this.claculate_btn_Click);
            // 
            // points_txt
            // 
            this.points_txt.Location = new System.Drawing.Point(15, 39);
            this.points_txt.Name = "points_txt";
            this.points_txt.Size = new System.Drawing.Size(180, 20);
            this.points_txt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Points";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 137);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.points_txt);
            this.Controls.Add(this.claculate_btn);
            this.Name = "Form6";
            this.Text = "Form6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button claculate_btn;
        private System.Windows.Forms.TextBox points_txt;
        private System.Windows.Forms.Label label1;
    }
}