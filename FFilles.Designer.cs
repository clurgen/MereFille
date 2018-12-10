namespace mere
{
    partial class FFilles
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
            this.tbChangeNom = new System.Windows.Forms.TextBox();
            this.btnChanger = new System.Windows.Forms.Button();
            this.btnMaMere = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "je change de nom:";
            // 
            // tbChangeNom
            // 
            this.tbChangeNom.Location = new System.Drawing.Point(113, 43);
            this.tbChangeNom.Name = "tbChangeNom";
            this.tbChangeNom.Size = new System.Drawing.Size(120, 20);
            this.tbChangeNom.TabIndex = 1;
            // 
            // btnChanger
            // 
            this.btnChanger.Location = new System.Drawing.Point(239, 43);
            this.btnChanger.Name = "btnChanger";
            this.btnChanger.Size = new System.Drawing.Size(75, 23);
            this.btnChanger.TabIndex = 2;
            this.btnChanger.Text = "Changer";
            this.btnChanger.UseVisualStyleBackColor = true;
            // 
            // btnMaMere
            // 
            this.btnMaMere.Location = new System.Drawing.Point(121, 80);
            this.btnMaMere.Name = "btnMaMere";
            this.btnMaMere.Size = new System.Drawing.Size(75, 23);
            this.btnMaMere.TabIndex = 3;
            this.btnMaMere.Text = "Ma Mere";
            this.btnMaMere.UseVisualStyleBackColor = true;
            // 
            // FFilles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 131);
            this.Controls.Add(this.btnMaMere);
            this.Controls.Add(this.btnChanger);
            this.Controls.Add(this.tbChangeNom);
            this.Controls.Add(this.label1);
            this.Name = "FFilles";
            this.Text = "FFilles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbChangeNom;
        private System.Windows.Forms.Button btnChanger;
        private System.Windows.Forms.Button btnMaMere;
    }
}