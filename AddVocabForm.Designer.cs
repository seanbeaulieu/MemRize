namespace MemRize
{
    partial class AddVocabForm
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
            this.termTextBox = new System.Windows.Forms.TextBox();
            this.defTextBox = new System.Windows.Forms.TextBox();
            this.btnEnterVocab = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // termTextBox
            // 
            this.termTextBox.Location = new System.Drawing.Point(253, 182);
            this.termTextBox.Name = "termTextBox";
            this.termTextBox.Size = new System.Drawing.Size(100, 20);
            this.termTextBox.TabIndex = 0;
            this.termTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // defTextBox
            // 
            this.defTextBox.Location = new System.Drawing.Point(406, 182);
            this.defTextBox.Name = "defTextBox";
            this.defTextBox.Size = new System.Drawing.Size(100, 20);
            this.defTextBox.TabIndex = 1;
            // 
            // btnEnterVocab
            // 
            this.btnEnterVocab.Location = new System.Drawing.Point(310, 224);
            this.btnEnterVocab.Name = "btnEnterVocab";
            this.btnEnterVocab.Size = new System.Drawing.Size(144, 56);
            this.btnEnterVocab.TabIndex = 2;
            this.btnEnterVocab.Text = "Enter Vocabulary";
            this.btnEnterVocab.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(285, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Term:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(430, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Definition:";
            // 
            // AddVocabForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEnterVocab);
            this.Controls.Add(this.defTextBox);
            this.Controls.Add(this.termTextBox);
            this.Name = "AddVocabForm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.AddVocabForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox termTextBox;
        private System.Windows.Forms.TextBox defTextBox;
        private System.Windows.Forms.Button btnEnterVocab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}