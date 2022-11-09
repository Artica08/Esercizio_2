namespace Esercizio_2
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
            this.btn_start = new System.Windows.Forms.Button();
            this.lbl_start = new System.Windows.Forms.Label();
            this.check_1 = new System.Windows.Forms.CheckBox();
            this.btn_reset = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_to_speech = new System.Windows.Forms.TextBox();
            this.btn_start_text = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(0, 0);
            this.btn_start.Margin = new System.Windows.Forms.Padding(4);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(100, 28);
            this.btn_start.TabIndex = 7;
            // 
            // lbl_start
            // 
            this.lbl_start.Location = new System.Drawing.Point(0, 0);
            this.lbl_start.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_start.Name = "lbl_start";
            this.lbl_start.Size = new System.Drawing.Size(133, 28);
            this.lbl_start.TabIndex = 6;
            // 
            // check_1
            // 
            this.check_1.Location = new System.Drawing.Point(0, 0);
            this.check_1.Margin = new System.Windows.Forms.Padding(4);
            this.check_1.Name = "check_1";
            this.check_1.Size = new System.Drawing.Size(139, 30);
            this.check_1.TabIndex = 5;
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(0, 0);
            this.btn_reset.Margin = new System.Windows.Forms.Padding(4);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(100, 28);
            this.btn_reset.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 28);
            this.label1.TabIndex = 0;
            // 
            // txt_to_speech
            // 
            this.txt_to_speech.Location = new System.Drawing.Point(114, 164);
            this.txt_to_speech.Margin = new System.Windows.Forms.Padding(4);
            this.txt_to_speech.Name = "txt_to_speech";
            this.txt_to_speech.Size = new System.Drawing.Size(132, 22);
            this.txt_to_speech.TabIndex = 8;
            // 
            // btn_start_text
            // 
            this.btn_start_text.Location = new System.Drawing.Point(132, 266);
            this.btn_start_text.Margin = new System.Windows.Forms.Padding(4);
            this.btn_start_text.Name = "btn_start_text";
            this.btn_start_text.Size = new System.Drawing.Size(155, 68);
            this.btn_start_text.TabIndex = 9;
            this.btn_start_text.Text = "Start Text to Speech";
            this.btn_start_text.UseVisualStyleBackColor = true;
            this.btn_start_text.Click += new System.EventHandler(this.btn_start_text_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Text to Speech";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(551, 164);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(154, 69);
            this.button3.TabIndex = 12;
            this.button3.Text = "Start Speech to Text";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(588, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Speech to Text";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(587, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_start_text);
            this.Controls.Add(this.txt_to_speech);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.check_1);
            this.Controls.Add(this.lbl_start);
            this.Controls.Add(this.btn_start);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Label lbl_start;
        private System.Windows.Forms.CheckBox check_1;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_to_speech;
        private System.Windows.Forms.Button btn_start_text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

