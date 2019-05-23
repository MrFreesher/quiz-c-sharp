namespace Kreator
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.controlContainer = new System.Windows.Forms.Panel();
            this.addTestInfoBtn = new System.Windows.Forms.Button();
            this.addQuestionBtn = new System.Windows.Forms.Button();
            this.endTestBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // controlContainer
            // 
            this.controlContainer.Location = new System.Drawing.Point(11, 13);
            this.controlContainer.Name = "controlContainer";
            this.controlContainer.Size = new System.Drawing.Size(461, 440);
            this.controlContainer.TabIndex = 0;
            // 
            // addTestInfoBtn
            // 
            this.addTestInfoBtn.Location = new System.Drawing.Point(13, 475);
            this.addTestInfoBtn.Name = "addTestInfoBtn";
            this.addTestInfoBtn.Size = new System.Drawing.Size(100, 23);
            this.addTestInfoBtn.TabIndex = 1;
            this.addTestInfoBtn.Text = "Dodaj test";
            this.addTestInfoBtn.UseVisualStyleBackColor = true;
            this.addTestInfoBtn.Click += AddTestInfoBtn_Click;
            // 
            // addQuestionBtn
            // 
            this.addQuestionBtn.Location = new System.Drawing.Point(186, 475);
            this.addQuestionBtn.Name = "addQuestionBtn";
            this.addQuestionBtn.Size = new System.Drawing.Size(100, 23);
            this.addQuestionBtn.TabIndex = 2;
            this.addQuestionBtn.Text = "Dodaj pytanie";
            this.addQuestionBtn.UseVisualStyleBackColor = true;
            this.addQuestionBtn.Click += AddQuestionBtn_Click;
            // 
            // endTestBtn
            // 
            this.endTestBtn.Location = new System.Drawing.Point(357, 475);
            this.endTestBtn.Name = "endTestBtn";
            this.endTestBtn.Size = new System.Drawing.Size(100, 23);
            this.endTestBtn.TabIndex = 3;
            this.endTestBtn.Text = "Zakończ test";
            this.endTestBtn.UseVisualStyleBackColor = true;
            this.endTestBtn.Click += EndCreatingTestBtn_Click;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 517);
            this.Controls.Add(this.endTestBtn);
            this.Controls.Add(this.addQuestionBtn);
            this.Controls.Add(this.addTestInfoBtn);
            this.Controls.Add(this.controlContainer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel controlContainer;
        private System.Windows.Forms.Button addTestInfoBtn;
        private System.Windows.Forms.Button addQuestionBtn;
        private System.Windows.Forms.Button endTestBtn;
    }
}

