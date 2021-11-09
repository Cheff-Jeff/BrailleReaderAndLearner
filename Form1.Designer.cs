
namespace BrailleReader {
    partial class SelectComForm {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.ports = new System.Windows.Forms.ListView();
            this.selectLbl = new System.Windows.Forms.Label();
            this.selectBtn = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.learnerBtn = new System.Windows.Forms.RadioButton();
            this.readerBtn = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ports
            // 
            this.ports.HideSelection = false;
            this.ports.Location = new System.Drawing.Point(12, 27);
            this.ports.Name = "ports";
            this.ports.Size = new System.Drawing.Size(193, 100);
            this.ports.TabIndex = 0;
            this.ports.UseCompatibleStateImageBehavior = false;
            this.ports.ItemMouseHover += new System.Windows.Forms.ListViewItemMouseHoverEventHandler(this.ports_ItemMouseHover);
            this.ports.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.ports_ItemSelectionChanged);
            this.ports.SelectedIndexChanged += new System.EventHandler(this.ports_SelectedIndexChanged);
            this.ports.MouseEnter += new System.EventHandler(this.ports_MouseEnter);
            // 
            // selectLbl
            // 
            this.selectLbl.AutoSize = true;
            this.selectLbl.Location = new System.Drawing.Point(12, 9);
            this.selectLbl.Name = "selectLbl";
            this.selectLbl.Size = new System.Drawing.Size(147, 15);
            this.selectLbl.TabIndex = 1;
            this.selectLbl.Text = "Selecteer uw Braille Reader";
            // 
            // selectBtn
            // 
            this.selectBtn.Location = new System.Drawing.Point(211, 133);
            this.selectBtn.Name = "selectBtn";
            this.selectBtn.Size = new System.Drawing.Size(75, 23);
            this.selectBtn.TabIndex = 2;
            this.selectBtn.Text = "Selecteer";
            this.selectBtn.UseVisualStyleBackColor = true;
            this.selectBtn.Click += new System.EventHandler(this.selectBtn_Click);
            this.selectBtn.MouseEnter += new System.EventHandler(this.selectBtn_MouseEnter);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(130, 133);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(75, 23);
            this.refreshBtn.TabIndex = 3;
            this.refreshBtn.Text = "Ververs";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            this.refreshBtn.MouseEnter += new System.EventHandler(this.refreshBtn_MouseEnter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.learnerBtn);
            this.groupBox1.Controls.Add(this.readerBtn);
            this.groupBox1.Location = new System.Drawing.Point(211, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(75, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // learnerBtn
            // 
            this.learnerBtn.AutoSize = true;
            this.learnerBtn.Location = new System.Drawing.Point(0, 31);
            this.learnerBtn.Name = "learnerBtn";
            this.learnerBtn.Size = new System.Drawing.Size(64, 19);
            this.learnerBtn.TabIndex = 1;
            this.learnerBtn.TabStop = true;
            this.learnerBtn.Text = "Learner";
            this.learnerBtn.UseVisualStyleBackColor = true;
            this.learnerBtn.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            this.learnerBtn.MouseEnter += new System.EventHandler(this.learnerBtn_MouseEnter);
            // 
            // readerBtn
            // 
            this.readerBtn.AutoSize = true;
            this.readerBtn.Location = new System.Drawing.Point(1, 5);
            this.readerBtn.Name = "readerBtn";
            this.readerBtn.Size = new System.Drawing.Size(61, 19);
            this.readerBtn.TabIndex = 0;
            this.readerBtn.TabStop = true;
            this.readerBtn.Text = "Reader";
            this.readerBtn.UseVisualStyleBackColor = true;
            this.readerBtn.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            this.readerBtn.MouseEnter += new System.EventHandler(this.readerBtn_MouseEnter);
            // 
            // SelectComForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 166);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.selectBtn);
            this.Controls.Add(this.selectLbl);
            this.Controls.Add(this.ports);
            this.Name = "SelectComForm";
            this.Text = "Selecteer Braille Reader";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ports;
        private System.Windows.Forms.Label selectLbl;
        private System.Windows.Forms.Button selectBtn;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton readerBtn;
        private System.Windows.Forms.RadioButton learnerBtn;
    }
}

