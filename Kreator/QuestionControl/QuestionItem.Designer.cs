namespace Kreator.QuestionControl {
    partial class QuestionItem {
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
            this.quesitonContentLabel = new System.Windows.Forms.Label();
            this.questionContentInput = new System.Windows.Forms.TextBox();
            this.addAnswerItemBtn = new System.Windows.Forms.Button();
            this.answersContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // quesitonContentLabel
            // 
            this.quesitonContentLabel.AutoSize = true;
            this.quesitonContentLabel.Location = new System.Drawing.Point(4, 4);
            this.quesitonContentLabel.Name = "quesitonContentLabel";
            this.quesitonContentLabel.Size = new System.Drawing.Size(71, 13);
            this.quesitonContentLabel.TabIndex = 0;
            this.quesitonContentLabel.Text = "Treść pytania";
            // 
            // questionContentInput
            // 
            this.questionContentInput.Location = new System.Drawing.Point(7, 21);
            this.questionContentInput.Multiline = true;
            this.questionContentInput.Name = "questionContentInput";
            this.questionContentInput.Size = new System.Drawing.Size(319, 54);
            this.questionContentInput.TabIndex = 1;
            // 
            // addAnswerItemBtn
            // 
            this.addAnswerItemBtn.Location = new System.Drawing.Point(343, 21);
            this.addAnswerItemBtn.Name = "addAnswerItemBtn";
            this.addAnswerItemBtn.Size = new System.Drawing.Size(95, 54);
            this.addAnswerItemBtn.TabIndex = 2;
            this.addAnswerItemBtn.Text = "Dodaj odpowiedź";
            this.addAnswerItemBtn.UseVisualStyleBackColor = true;
            // 
            // answersContainer
            // 
            this.answersContainer.AutoScroll = true;
            this.answersContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.answersContainer.Location = new System.Drawing.Point(7, 82);
            this.answersContainer.Name = "answersContainer";
            this.answersContainer.Size = new System.Drawing.Size(431, 305);
            this.answersContainer.TabIndex = 3;
            // 
            // QuestionItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.answersContainer);
            this.Controls.Add(this.addAnswerItemBtn);
            this.Controls.Add(this.questionContentInput);
            this.Controls.Add(this.quesitonContentLabel);
            this.Name = "QuestionItem";
            this.Size = new System.Drawing.Size(450, 400);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label quesitonContentLabel;
        private System.Windows.Forms.TextBox questionContentInput;
        private System.Windows.Forms.Button addAnswerItemBtn;
        private System.Windows.Forms.FlowLayoutPanel answersContainer;
    }
}
