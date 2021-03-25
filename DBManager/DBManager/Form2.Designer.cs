
namespace DBManager
{
    partial class ColName
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
            this.tbColname = new System.Windows.Forms.TextBox();
            this.lbInput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbColname
            // 
            this.tbColname.Location = new System.Drawing.Point(12, 32);
            this.tbColname.Name = "tbColname";
            this.tbColname.Size = new System.Drawing.Size(206, 21);
            this.tbColname.TabIndex = 0;
            this.tbColname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbColname_KeyDown);
            // 
            // lbInput
            // 
            this.lbInput.AutoSize = true;
            this.lbInput.Location = new System.Drawing.Point(12, 9);
            this.lbInput.Name = "lbInput";
            this.lbInput.Size = new System.Drawing.Size(32, 12);
            this.lbInput.TabIndex = 1;
            this.lbInput.Text = "Input";
            // 
            // ColName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 65);
            this.Controls.Add(this.lbInput);
            this.Controls.Add(this.tbColname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ColName";
            this.Text = "Column Name";
            this.Load += new System.EventHandler(this.ColName_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbColname;
        private System.Windows.Forms.Label lbInput;
    }
}