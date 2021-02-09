
namespace FormsUI
{
    partial class AddColor
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
            this.lblColorName = new System.Windows.Forms.Label();
            this.tbxColorName = new System.Windows.Forms.TextBox();
            this.btnSaveColorName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblColorName
            // 
            this.lblColorName.AutoSize = true;
            this.lblColorName.Location = new System.Drawing.Point(12, 15);
            this.lblColorName.Name = "lblColorName";
            this.lblColorName.Size = new System.Drawing.Size(51, 13);
            this.lblColorName.TabIndex = 0;
            this.lblColorName.Text = "Renk Adı";
            // 
            // tbxColorName
            // 
            this.tbxColorName.Location = new System.Drawing.Point(94, 12);
            this.tbxColorName.Name = "tbxColorName";
            this.tbxColorName.Size = new System.Drawing.Size(141, 20);
            this.tbxColorName.TabIndex = 3;
            // 
            // btnSaveColorName
            // 
            this.btnSaveColorName.Location = new System.Drawing.Point(160, 38);
            this.btnSaveColorName.Name = "btnSaveColorName";
            this.btnSaveColorName.Size = new System.Drawing.Size(75, 23);
            this.btnSaveColorName.TabIndex = 4;
            this.btnSaveColorName.Text = "Kaydet";
            this.btnSaveColorName.UseVisualStyleBackColor = true;
            this.btnSaveColorName.Click += new System.EventHandler(this.btnSaveColorName_Click);
            // 
            // AddColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 74);
            this.Controls.Add(this.btnSaveColorName);
            this.Controls.Add(this.tbxColorName);
            this.Controls.Add(this.lblColorName);
            this.Name = "AddColor";
            this.Text = "Renk Ekle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblColorName;
        private System.Windows.Forms.TextBox tbxColorName;
        private System.Windows.Forms.Button btnSaveColorName;
    }
}