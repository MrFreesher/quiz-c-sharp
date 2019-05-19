namespace Kreator.AnswerItem {
    partial class AnswerItem {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.answerContentLabel = new System.Windows.Forms.Label();
            this.answerPointLabel = new System.Windows.Forms.Label();
            this.answerContentInput = new System.Windows.Forms.TextBox();
            this.answerPointInput = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.answerPointInput)).BeginInit();
            this.SuspendLayout();
            // 
            // answerContentLabel
            // 
            this.answerContentLabel.AutoSize = true;
            this.answerContentLabel.Location = new System.Drawing.Point(4, 4);
            this.answerContentLabel.Name = "answerContentLabel";
            this.answerContentLabel.Size = new System.Drawing.Size(90, 13);
            this.answerContentLabel.TabIndex = 0;
            this.answerContentLabel.Text = "Treść odpowiedzi";
            // 
            // answerPointLabel
            // 
            this.answerPointLabel.AutoSize = true;
            this.answerPointLabel.Location = new System.Drawing.Point(311, 4);
            this.answerPointLabel.Name = "answerPointLabel";
            this.answerPointLabel.Size = new System.Drawing.Size(40, 13);
            this.answerPointLabel.TabIndex = 1;
            this.answerPointLabel.Text = "Punkty";
            // 
            // answerContentInput
            // 
            this.answerContentInput.Location = new System.Drawing.Point(4, 21);
            this.answerContentInput.Multiline = true;
            this.answerContentInput.Name = "answerContentInput";
            this.answerContentInput.Size = new System.Drawing.Size(280, 63);
            this.answerContentInput.TabIndex = 2;
            // 
            // answerPointInput
            // 
            this.answerPointInput.Location = new System.Drawing.Point(314, 37);
            this.answerPointInput.Name = "answerPointInput";
            this.answerPointInput.Size = new System.Drawing.Size(76, 20);
            this.answerPointInput.TabIndex = 3;
            // 
            // AnswerItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.answerPointInput);
            this.Controls.Add(this.answerContentInput);
            this.Controls.Add(this.answerPointLabel);
            this.Controls.Add(this.answerContentLabel);
            this.Name = "AnswerItem";
            this.Size = new System.Drawing.Size(400, 100);
            ((System.ComponentModel.ISupportInitialize)(this.answerPointInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label answerContentLabel;
        private System.Windows.Forms.Label answerPointLabel;
        private System.Windows.Forms.TextBox answerContentInput;
        private System.Windows.Forms.NumericUpDown answerPointInput;
    }
}
