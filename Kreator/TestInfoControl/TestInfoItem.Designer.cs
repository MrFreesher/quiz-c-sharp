namespace Kreator.TestInfoControl {
    partial class TestInfoItem {
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
            this.testTitleLabel = new System.Windows.Forms.Label();
            this.testAuthorLabel = new System.Windows.Forms.Label();
            this.testDescriptionLabel = new System.Windows.Forms.Label();
            this.testTitleInput = new System.Windows.Forms.TextBox();
            this.testAuthorInput = new System.Windows.Forms.TextBox();
            this.testDescriptionInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // testTitleLabel
            // 
            this.testTitleLabel.AutoSize = true;
            this.testTitleLabel.Location = new System.Drawing.Point(16, 23);
            this.testTitleLabel.Name = "testTitleLabel";
            this.testTitleLabel.Size = new System.Drawing.Size(58, 13);
            this.testTitleLabel.TabIndex = 0;
            this.testTitleLabel.Text = "Tytuł testu";
            // 
            // testAuthorLabel
            // 
            this.testAuthorLabel.AutoSize = true;
            this.testAuthorLabel.Location = new System.Drawing.Point(16, 65);
            this.testAuthorLabel.Name = "testAuthorLabel";
            this.testAuthorLabel.Size = new System.Drawing.Size(58, 13);
            this.testAuthorLabel.TabIndex = 1;
            this.testAuthorLabel.Text = "Autor testu";
            // 
            // testDescriptionLabel
            // 
            this.testDescriptionLabel.AutoSize = true;
            this.testDescriptionLabel.Location = new System.Drawing.Point(20, 103);
            this.testDescriptionLabel.Name = "testDescriptionLabel";
            this.testDescriptionLabel.Size = new System.Drawing.Size(54, 13);
            this.testDescriptionLabel.TabIndex = 2;
            this.testDescriptionLabel.Text = "Opis testu";
            // 
            // testTitleInput
            // 
            this.testTitleInput.Location = new System.Drawing.Point(120, 15);
            this.testTitleInput.Name = "testTitleInput";
            this.testTitleInput.Size = new System.Drawing.Size(246, 20);
            this.testTitleInput.TabIndex = 3;
            // 
            // testAuthorInput
            // 
            this.testAuthorInput.Location = new System.Drawing.Point(120, 57);
            this.testAuthorInput.Name = "testAuthorInput";
            this.testAuthorInput.Size = new System.Drawing.Size(246, 20);
            this.testAuthorInput.TabIndex = 4;
            // 
            // testDescriptionInput
            // 
            this.testDescriptionInput.Location = new System.Drawing.Point(120, 100);
            this.testDescriptionInput.Multiline = true;
            this.testDescriptionInput.Name = "testDescriptionInput";
            this.testDescriptionInput.Size = new System.Drawing.Size(246, 37);
            this.testDescriptionInput.TabIndex = 5;
            // 
            // TestInfoItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.testDescriptionInput);
            this.Controls.Add(this.testAuthorInput);
            this.Controls.Add(this.testTitleInput);
            this.Controls.Add(this.testDescriptionLabel);
            this.Controls.Add(this.testAuthorLabel);
            this.Controls.Add(this.testTitleLabel);
            this.Name = "TestInfoItem";
            this.Size = new System.Drawing.Size(400, 300);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label testTitleLabel;
        private System.Windows.Forms.Label testAuthorLabel;
        private System.Windows.Forms.Label testDescriptionLabel;
        private System.Windows.Forms.TextBox testTitleInput;
        private System.Windows.Forms.TextBox testAuthorInput;
        private System.Windows.Forms.TextBox testDescriptionInput;
    }
}
