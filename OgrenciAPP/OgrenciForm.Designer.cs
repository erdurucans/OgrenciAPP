namespace OgrenciAPP
{
    partial class OgrenciForm
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
            this.lbl_Aciklama = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Aciklama
            // 
            this.lbl_Aciklama.AutoSize = true;
            this.lbl_Aciklama.Location = new System.Drawing.Point(365, 170);
            this.lbl_Aciklama.Name = "lbl_Aciklama";
            this.lbl_Aciklama.Size = new System.Drawing.Size(112, 13);
            this.lbl_Aciklama.TabIndex = 0;
            this.lbl_Aciklama.Text = "Bu Form alt bir formdur";
            // 
            // OgrenciForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Aciklama);
            this.Name = "OgrenciForm";
            this.Text = "OgrenciForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Aciklama;
    }
}