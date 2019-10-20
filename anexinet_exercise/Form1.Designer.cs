namespace anexinet_exercise
{
    partial class Form1
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
            this.exercise_1_btn = new System.Windows.Forms.Button();
            this.exercise_2_btn = new System.Windows.Forms.Button();
            this.exercise_3_btn = new System.Windows.Forms.Button();
            this.exercise_4_btn = new System.Windows.Forms.Button();
            this.exercise_5_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exercise_1_btn
            // 
            this.exercise_1_btn.Location = new System.Drawing.Point(30, 24);
            this.exercise_1_btn.Name = "exercise_1_btn";
            this.exercise_1_btn.Size = new System.Drawing.Size(165, 29);
            this.exercise_1_btn.TabIndex = 0;
            this.exercise_1_btn.Text = "Date Exercise";
            this.exercise_1_btn.UseVisualStyleBackColor = true;
            this.exercise_1_btn.Click += new System.EventHandler(this.exercise_1_btn_Click);
            // 
            // exercise_2_btn
            // 
            this.exercise_2_btn.Location = new System.Drawing.Point(30, 74);
            this.exercise_2_btn.Name = "exercise_2_btn";
            this.exercise_2_btn.Size = new System.Drawing.Size(165, 27);
            this.exercise_2_btn.TabIndex = 1;
            this.exercise_2_btn.Text = "Chars Repeated Exercise";
            this.exercise_2_btn.UseVisualStyleBackColor = true;
            this.exercise_2_btn.Click += new System.EventHandler(this.exercise_2_btn_Click);
            // 
            // exercise_3_btn
            // 
            this.exercise_3_btn.Location = new System.Drawing.Point(30, 124);
            this.exercise_3_btn.Name = "exercise_3_btn";
            this.exercise_3_btn.Size = new System.Drawing.Size(165, 27);
            this.exercise_3_btn.TabIndex = 2;
            this.exercise_3_btn.Text = "Count Chars Exercise";
            this.exercise_3_btn.UseVisualStyleBackColor = true;
            this.exercise_3_btn.Click += new System.EventHandler(this.exercise_3_btn_Click);
            // 
            // exercise_4_btn
            // 
            this.exercise_4_btn.Location = new System.Drawing.Point(30, 174);
            this.exercise_4_btn.Name = "exercise_4_btn";
            this.exercise_4_btn.Size = new System.Drawing.Size(165, 27);
            this.exercise_4_btn.TabIndex = 3;
            this.exercise_4_btn.Text = "Sintax Exercise";
            this.exercise_4_btn.UseVisualStyleBackColor = true;
            this.exercise_4_btn.Click += new System.EventHandler(this.exercise_4_btn_Click);
            // 
            // exercise_5_btn
            // 
            this.exercise_5_btn.Location = new System.Drawing.Point(30, 223);
            this.exercise_5_btn.Name = "exercise_5_btn";
            this.exercise_5_btn.Size = new System.Drawing.Size(165, 26);
            this.exercise_5_btn.TabIndex = 4;
            this.exercise_5_btn.Text = "Area Exercise";
            this.exercise_5_btn.UseVisualStyleBackColor = true;
            this.exercise_5_btn.Click += new System.EventHandler(this.exercise_5_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 274);
            this.Controls.Add(this.exercise_5_btn);
            this.Controls.Add(this.exercise_4_btn);
            this.Controls.Add(this.exercise_3_btn);
            this.Controls.Add(this.exercise_2_btn);
            this.Controls.Add(this.exercise_1_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exercise_1_btn;
        private System.Windows.Forms.Button exercise_2_btn;
        private System.Windows.Forms.Button exercise_3_btn;
        private System.Windows.Forms.Button exercise_4_btn;
        private System.Windows.Forms.Button exercise_5_btn;
    }
}

