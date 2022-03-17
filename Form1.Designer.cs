
namespace convert_wa_1
{
    partial class txt
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
            this.txt_num = new System.Windows.Forms.TextBox();
            this.lbl_words = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_num
            // 
            this.txt_num.Location = new System.Drawing.Point(328, 42);
            this.txt_num.Name = "txt_num";
            this.txt_num.Size = new System.Drawing.Size(169, 20);
            this.txt_num.TabIndex = 0;
            // 
            // lbl_words
            // 
            this.lbl_words.AutoSize = true;
            this.lbl_words.Location = new System.Drawing.Point(393, 119);
            this.lbl_words.Name = "lbl_words";
            this.lbl_words.Size = new System.Drawing.Size(35, 13);
            this.lbl_words.TabIndex = 1;
            this.lbl_words.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(379, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "convert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_words);
            this.Controls.Add(this.txt_num);
            this.Name = "txt";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_num;
        private System.Windows.Forms.Label lbl_words;
        private System.Windows.Forms.Button button1;
    }
}

