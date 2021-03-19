
namespace WindowsFormsGraph
{
    partial class DrawOption
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbX = new System.Windows.Forms.TextBox();
            this.btnSet = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbY = new System.Windows.Forms.TextBox();
            this.tbInt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "원의 가로";
            // 
            // tbX
            // 
            this.tbX.Location = new System.Drawing.Point(96, 17);
            this.tbX.Name = "tbX";
            this.tbX.Size = new System.Drawing.Size(100, 21);
            this.tbX.TabIndex = 1;
            // 
            // btnSet
            // 
            this.btnSet.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSet.Location = new System.Drawing.Point(202, 15);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(75, 23);
            this.btnSet.TabIndex = 2;
            this.btnSet.Text = "설정";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "원의 세로";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "선굵기";
            // 
            // tbY
            // 
            this.tbY.Location = new System.Drawing.Point(96, 44);
            this.tbY.Name = "tbY";
            this.tbY.Size = new System.Drawing.Size(100, 21);
            this.tbY.TabIndex = 1;
            // 
            // tbInt
            // 
            this.tbInt.Location = new System.Drawing.Point(96, 71);
            this.tbInt.Name = "tbInt";
            this.tbInt.Size = new System.Drawing.Size(100, 21);
            this.tbInt.TabIndex = 1;
            // 
            // DrawOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 121);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbInt);
            this.Controls.Add(this.tbY);
            this.Controls.Add(this.tbX);
            this.Controls.Add(this.label1);
            this.Name = "DrawOption";
            this.Text = "DrawOption";
            this.Load += new System.EventHandler(this.DrawOption_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbX;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbY;
        private System.Windows.Forms.TextBox tbInt;
    }
}