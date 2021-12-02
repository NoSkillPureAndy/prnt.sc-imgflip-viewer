
namespace prntsc_viewer_because_cloudflare_is_a_bitch
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
            this.IdInput = new System.Windows.Forms.TextBox();
            this.LinkInput = new System.Windows.Forms.TextBox();
            this.UrlLabel = new System.Windows.Forms.LinkLabel();
            this.BrowserCheckbox = new System.Windows.Forms.CheckBox();
            this.IdButton = new System.Windows.Forms.Button();
            this.LinkButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IdInput
            // 
            this.IdInput.Location = new System.Drawing.Point(12, 32);
            this.IdInput.Name = "IdInput";
            this.IdInput.Size = new System.Drawing.Size(70, 20);
            this.IdInput.TabIndex = 0;
            this.IdInput.Text = "ID Input";
            this.IdInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IdInput_KeyPress);
            // 
            // LinkInput
            // 
            this.LinkInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LinkInput.Location = new System.Drawing.Point(182, 32);
            this.LinkInput.Name = "LinkInput";
            this.LinkInput.Size = new System.Drawing.Size(70, 20);
            this.LinkInput.TabIndex = 1;
            this.LinkInput.Text = "Link Input";
            this.LinkInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LinkInput_KeyPress);
            // 
            // UrlLabel
            // 
            this.UrlLabel.AutoSize = true;
            this.UrlLabel.Location = new System.Drawing.Point(9, 55);
            this.UrlLabel.Name = "UrlLabel";
            this.UrlLabel.Size = new System.Drawing.Size(47, 13);
            this.UrlLabel.TabIndex = 4;
            this.UrlLabel.TabStop = true;
            this.UrlLabel.Text = "link here";
            this.UrlLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BrowserCheckbox
            // 
            this.BrowserCheckbox.AutoSize = true;
            this.BrowserCheckbox.Location = new System.Drawing.Point(12, 71);
            this.BrowserCheckbox.Name = "BrowserCheckbox";
            this.BrowserCheckbox.Size = new System.Drawing.Size(126, 17);
            this.BrowserCheckbox.TabIndex = 5;
            this.BrowserCheckbox.Text = "Auto-open in browser";
            this.BrowserCheckbox.UseVisualStyleBackColor = true;
            // 
            // IdButton
            // 
            this.IdButton.Location = new System.Drawing.Point(11, 5);
            this.IdButton.Name = "IdButton";
            this.IdButton.Size = new System.Drawing.Size(72, 22);
            this.IdButton.TabIndex = 6;
            this.IdButton.Text = "View ID";
            this.IdButton.UseVisualStyleBackColor = true;
            this.IdButton.Click += new System.EventHandler(this.IdButton_Click);
            // 
            // LinkButton
            // 
            this.LinkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LinkButton.Location = new System.Drawing.Point(181, 5);
            this.LinkButton.Name = "LinkButton";
            this.LinkButton.Size = new System.Drawing.Size(72, 22);
            this.LinkButton.TabIndex = 7;
            this.LinkButton.Text = "View Link";
            this.LinkButton.UseVisualStyleBackColor = true;
            this.LinkButton.Click += new System.EventHandler(this.LinkButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 94);
            this.Controls.Add(this.LinkButton);
            this.Controls.Add(this.IdButton);
            this.Controls.Add(this.BrowserCheckbox);
            this.Controls.Add(this.UrlLabel);
            this.Controls.Add(this.LinkInput);
            this.Controls.Add(this.IdInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IdInput;
        private System.Windows.Forms.TextBox LinkInput;
        private System.Windows.Forms.LinkLabel UrlLabel;
        private System.Windows.Forms.CheckBox BrowserCheckbox;
        private System.Windows.Forms.Button IdButton;
        private System.Windows.Forms.Button LinkButton;
    }
}

