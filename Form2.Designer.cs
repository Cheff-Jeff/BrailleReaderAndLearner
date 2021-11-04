
namespace BrailleReader {
    partial class Form2 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.input = new System.Windows.Forms.TextBox();
            this.readerBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(12, 12);
            this.input.Multiline = true;
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(287, 143);
            this.input.TabIndex = 0;
            // 
            // readerBtn
            // 
            this.readerBtn.Location = new System.Drawing.Point(12, 161);
            this.readerBtn.Name = "readerBtn";
            this.readerBtn.Size = new System.Drawing.Size(75, 23);
            this.readerBtn.TabIndex = 1;
            this.readerBtn.Text = "Lees voor";
            this.readerBtn.UseVisualStyleBackColor = true;
            this.readerBtn.Click += new System.EventHandler(this.readerBtn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 201);
            this.Controls.Add(this.readerBtn);
            this.Controls.Add(this.input);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Button readerBtn;
    }
}