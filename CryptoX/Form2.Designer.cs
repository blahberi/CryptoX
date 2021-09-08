
namespace encryptor_CS_X
{
    partial class LoadKeyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadKeyForm));
            this.txbKey = new System.Windows.Forms.TextBox();
            this.lblPaste = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbKey
            // 
            this.txbKey.Location = new System.Drawing.Point(12, 23);
            this.txbKey.Name = "txbKey";
            this.txbKey.Size = new System.Drawing.Size(456, 20);
            this.txbKey.TabIndex = 0;
            this.txbKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbKey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbKey_KeyDown);
            // 
            // lblPaste
            // 
            this.lblPaste.AutoSize = true;
            this.lblPaste.Location = new System.Drawing.Point(200, 7);
            this.lblPaste.Name = "lblPaste";
            this.lblPaste.Size = new System.Drawing.Size(81, 13);
            this.lblPaste.TabIndex = 1;
            this.lblPaste.Text = "Paste key here:";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(203, 49);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // LoadKeyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 88);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.lblPaste);
            this.Controls.Add(this.txbKey);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoadKeyForm";
            this.Text = "Load Key";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbKey;
        private System.Windows.Forms.Label lblPaste;
        private System.Windows.Forms.Button btnLoad;
    }
}