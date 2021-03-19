
namespace WindowsFormsEdit
{
    partial class FormReplace
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
            this.btnReplace = new System.Windows.Forms.Button();
            this.tbAfter = new System.Windows.Forms.TextBox();
            this.tbBefore = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnReplace
            // 
            this.btnReplace.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnReplace.Location = new System.Drawing.Point(190, 49);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(75, 23);
            this.btnReplace.TabIndex = 1;
            this.btnReplace.Text = "바꾸기";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // tbAfter
            // 
            this.tbAfter.Location = new System.Drawing.Point(12, 51);
            this.tbAfter.Name = "tbAfter";
            this.tbAfter.Size = new System.Drawing.Size(145, 21);
            this.tbAfter.TabIndex = 0;
            this.tbAfter.Text = "바꿀 내용";
            // 
            // tbBefore
            // 
            this.tbBefore.Location = new System.Drawing.Point(12, 12);
            this.tbBefore.Name = "tbBefore";
            this.tbBefore.Size = new System.Drawing.Size(145, 21);
            this.tbBefore.TabIndex = 0;
            this.tbBefore.Text = "찾을 내용";
            // 
            // FormReplace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 92);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.tbBefore);
            this.Controls.Add(this.tbAfter);
            this.Name = "FormReplace";
            this.Text = "FormReplace";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.TextBox tbAfter;
        private System.Windows.Forms.TextBox tbBefore;
    }
}