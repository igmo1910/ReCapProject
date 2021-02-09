
namespace FormsUI
{
    partial class Form1
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
            this.menuStripCars = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemCarOperations = new System.Windows.Forms.ToolStripMenuItem();
            this.arabaEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arabaGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arabaSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemBrandOperations = new System.Windows.Forms.ToolStripMenuItem();
            this.markaEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.markaGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.markaSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemColorOperations = new System.Windows.Forms.ToolStripMenuItem();
            this.addColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renkSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripCars.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripCars
            // 
            this.menuStripCars.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemCarOperations,
            this.toolStripMenuItemBrandOperations,
            this.toolStripMenuItemColorOperations});
            this.menuStripCars.Location = new System.Drawing.Point(0, 0);
            this.menuStripCars.Name = "menuStripCars";
            this.menuStripCars.Size = new System.Drawing.Size(800, 24);
            this.menuStripCars.TabIndex = 0;
            this.menuStripCars.Text = "Arabalar";
            // 
            // toolStripMenuItemCarOperations
            // 
            this.toolStripMenuItemCarOperations.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arabaEkleToolStripMenuItem,
            this.arabaGüncelleToolStripMenuItem,
            this.arabaSilToolStripMenuItem});
            this.toolStripMenuItemCarOperations.Name = "toolStripMenuItemCarOperations";
            this.toolStripMenuItemCarOperations.Size = new System.Drawing.Size(97, 20);
            this.toolStripMenuItemCarOperations.Text = "Araba İşlemleri";
            // 
            // arabaEkleToolStripMenuItem
            // 
            this.arabaEkleToolStripMenuItem.Name = "arabaEkleToolStripMenuItem";
            this.arabaEkleToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.arabaEkleToolStripMenuItem.Text = "Araba Ekle";
            // 
            // arabaGüncelleToolStripMenuItem
            // 
            this.arabaGüncelleToolStripMenuItem.Name = "arabaGüncelleToolStripMenuItem";
            this.arabaGüncelleToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.arabaGüncelleToolStripMenuItem.Text = "Araba Güncelle";
            // 
            // arabaSilToolStripMenuItem
            // 
            this.arabaSilToolStripMenuItem.Name = "arabaSilToolStripMenuItem";
            this.arabaSilToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.arabaSilToolStripMenuItem.Text = "Araba Sil";
            // 
            // toolStripMenuItemBrandOperations
            // 
            this.toolStripMenuItemBrandOperations.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.markaEkleToolStripMenuItem,
            this.markaGüncelleToolStripMenuItem,
            this.markaSilToolStripMenuItem});
            this.toolStripMenuItemBrandOperations.Name = "toolStripMenuItemBrandOperations";
            this.toolStripMenuItemBrandOperations.Size = new System.Drawing.Size(99, 20);
            this.toolStripMenuItemBrandOperations.Text = "Marka İşlemleri";
            // 
            // markaEkleToolStripMenuItem
            // 
            this.markaEkleToolStripMenuItem.Name = "markaEkleToolStripMenuItem";
            this.markaEkleToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.markaEkleToolStripMenuItem.Text = "Marka Ekle";
            // 
            // markaGüncelleToolStripMenuItem
            // 
            this.markaGüncelleToolStripMenuItem.Name = "markaGüncelleToolStripMenuItem";
            this.markaGüncelleToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.markaGüncelleToolStripMenuItem.Text = "Marka Güncelle";
            // 
            // markaSilToolStripMenuItem
            // 
            this.markaSilToolStripMenuItem.Name = "markaSilToolStripMenuItem";
            this.markaSilToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.markaSilToolStripMenuItem.Text = "Marka Sil";
            // 
            // toolStripMenuItemColorOperations
            // 
            this.toolStripMenuItemColorOperations.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addColorToolStripMenuItem,
            this.updateColorToolStripMenuItem,
            this.renkSilToolStripMenuItem});
            this.toolStripMenuItemColorOperations.Name = "toolStripMenuItemColorOperations";
            this.toolStripMenuItemColorOperations.Size = new System.Drawing.Size(92, 20);
            this.toolStripMenuItemColorOperations.Text = "Renk İşlemleri";
            // 
            // addColorToolStripMenuItem
            // 
            this.addColorToolStripMenuItem.Name = "addColorToolStripMenuItem";
            this.addColorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addColorToolStripMenuItem.Text = "Renk Ekle";
            this.addColorToolStripMenuItem.Click += new System.EventHandler(this.addColorToolStripMenuItem_Click);
            // 
            // updateColorToolStripMenuItem
            // 
            this.updateColorToolStripMenuItem.Name = "updateColorToolStripMenuItem";
            this.updateColorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.updateColorToolStripMenuItem.Text = "Renk Güncelle";
            // 
            // renkSilToolStripMenuItem
            // 
            this.renkSilToolStripMenuItem.Name = "renkSilToolStripMenuItem";
            this.renkSilToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.renkSilToolStripMenuItem.Text = "Renk Sil";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStripCars);
            this.MainMenuStrip = this.menuStripCars;
            this.Name = "Form1";
            this.Text = "ReCapProject";
            this.menuStripCars.ResumeLayout(false);
            this.menuStripCars.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripCars;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCarOperations;
        private System.Windows.Forms.ToolStripMenuItem arabaEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arabaGüncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arabaSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemBrandOperations;
        private System.Windows.Forms.ToolStripMenuItem markaEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem markaGüncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem markaSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemColorOperations;
        private System.Windows.Forms.ToolStripMenuItem addColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renkSilToolStripMenuItem;
    }
}

