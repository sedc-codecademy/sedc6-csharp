namespace TasksDemo
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
            this.UrlTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GoButton = new System.Windows.Forms.Button();
            this.ContentRichTextBox = new System.Windows.Forms.RichTextBox();
            this.HitCountLabel = new System.Windows.Forms.Label();
            this.HitCountButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UrlTextBox
            // 
            this.UrlTextBox.Location = new System.Drawing.Point(70, 30);
            this.UrlTextBox.Name = "UrlTextBox";
            this.UrlTextBox.Size = new System.Drawing.Size(296, 20);
            this.UrlTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Url";
            // 
            // GoButton
            // 
            this.GoButton.Location = new System.Drawing.Point(387, 28);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(75, 23);
            this.GoButton.TabIndex = 2;
            this.GoButton.Text = "GO";
            this.GoButton.UseVisualStyleBackColor = true;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // ContentRichTextBox
            // 
            this.ContentRichTextBox.Location = new System.Drawing.Point(12, 73);
            this.ContentRichTextBox.Name = "ContentRichTextBox";
            this.ContentRichTextBox.Size = new System.Drawing.Size(955, 406);
            this.ContentRichTextBox.TabIndex = 3;
            this.ContentRichTextBox.Text = "";
            // 
            // HitCountLabel
            // 
            this.HitCountLabel.AutoSize = true;
            this.HitCountLabel.Location = new System.Drawing.Point(849, 33);
            this.HitCountLabel.Name = "HitCountLabel";
            this.HitCountLabel.Size = new System.Drawing.Size(35, 13);
            this.HitCountLabel.TabIndex = 4;
            this.HitCountLabel.Text = "Count";
            // 
            // HitCountButton
            // 
            this.HitCountButton.Location = new System.Drawing.Point(719, 33);
            this.HitCountButton.Name = "HitCountButton";
            this.HitCountButton.Size = new System.Drawing.Size(75, 23);
            this.HitCountButton.TabIndex = 5;
            this.HitCountButton.Text = "Hit!";
            this.HitCountButton.UseVisualStyleBackColor = true;
            this.HitCountButton.Click += new System.EventHandler(this.HitCountButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 491);
            this.Controls.Add(this.HitCountButton);
            this.Controls.Add(this.HitCountLabel);
            this.Controls.Add(this.ContentRichTextBox);
            this.Controls.Add(this.GoButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UrlTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UrlTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button GoButton;
        private System.Windows.Forms.RichTextBox ContentRichTextBox;
        private System.Windows.Forms.Label HitCountLabel;
        private System.Windows.Forms.Button HitCountButton;
    }
}

