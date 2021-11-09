
namespace BrailleReader {
    partial class Form3 {
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
            this.alfabet = new System.Windows.Forms.Button();
            this.Mak = new System.Windows.Forms.RadioButton();
            this.Gem = new System.Windows.Forms.RadioButton();
            this.Moe = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // alfabet
            // 
            this.alfabet.Location = new System.Drawing.Point(87, 130);
            this.alfabet.Name = "alfabet";
            this.alfabet.Size = new System.Drawing.Size(105, 23);
            this.alfabet.TabIndex = 1;
            this.alfabet.Text = "Leer alfabet";
            this.alfabet.UseVisualStyleBackColor = true;
            this.alfabet.Click += new System.EventHandler(this.alfabet_Click);
            // 
            // Mak
            // 
            this.Mak.AutoSize = true;
            this.Mak.Location = new System.Drawing.Point(100, 26);
            this.Mak.Name = "Mak";
            this.Mak.Size = new System.Drawing.Size(75, 19);
            this.Mak.TabIndex = 3;
            this.Mak.TabStop = true;
            this.Mak.Text = "Makkelijk";
            this.Mak.UseVisualStyleBackColor = true;
            this.Mak.CheckedChanged += new System.EventHandler(this.Mak_CheckedChanged);
            // 
            // Gem
            // 
            this.Gem.AutoSize = true;
            this.Gem.Location = new System.Drawing.Point(100, 51);
            this.Gem.Name = "Gem";
            this.Gem.Size = new System.Drawing.Size(83, 19);
            this.Gem.TabIndex = 4;
            this.Gem.TabStop = true;
            this.Gem.Text = "Gemiddeld";
            this.Gem.UseVisualStyleBackColor = true;
            this.Gem.CheckedChanged += new System.EventHandler(this.Gem_CheckedChanged);
            // 
            // Moe
            // 
            this.Moe.AutoSize = true;
            this.Moe.Location = new System.Drawing.Point(100, 76);
            this.Moe.Name = "Moe";
            this.Moe.Size = new System.Drawing.Size(67, 19);
            this.Moe.TabIndex = 5;
            this.Moe.TabStop = true;
            this.Moe.Text = "Moeilijk";
            this.Moe.UseVisualStyleBackColor = true;
            this.Moe.CheckedChanged += new System.EventHandler(this.Moe_CheckedChanged);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 201);
            this.Controls.Add(this.Moe);
            this.Controls.Add(this.Gem);
            this.Controls.Add(this.Mak);
            this.Controls.Add(this.alfabet);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button alfabet;
        private System.Windows.Forms.RadioButton Mak;
        private System.Windows.Forms.RadioButton Gem;
        private System.Windows.Forms.RadioButton Moe;
    }
}