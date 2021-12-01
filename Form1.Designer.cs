
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
            this.idInput = new System.Windows.Forms.TextBox();
            this.linkInput = new System.Windows.Forms.TextBox();
            this.urlLabel = new System.Windows.Forms.LinkLabel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // idInput
            // 
            this.idInput.Location = new System.Drawing.Point(12, 12);
            this.idInput.Name = "idInput";
            this.idInput.Size = new System.Drawing.Size(70, 20);
            this.idInput.TabIndex = 0;
            this.idInput.Text = "ID Input";
            this.idInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.idInput_KeyPress);
            // 
            // linkInput
            // 
            this.linkInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkInput.Location = new System.Drawing.Point(182, 12);
            this.linkInput.Name = "linkInput";
            this.linkInput.Size = new System.Drawing.Size(70, 20);
            this.linkInput.TabIndex = 1;
            this.linkInput.Text = "Link Input";
            this.linkInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.linkInput_KeyPress);
            // 
            // urlLabel
            // 
            this.urlLabel.AutoSize = true;
            this.urlLabel.Location = new System.Drawing.Point(9, 35);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(47, 13);
            this.urlLabel.TabIndex = 4;
            this.urlLabel.TabStop = true;
            this.urlLabel.Text = "link here";
            this.urlLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 51);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(126, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Auto-open in browser";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 74);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.urlLabel);
            this.Controls.Add(this.linkInput);
            this.Controls.Add(this.idInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox idInput;
        private System.Windows.Forms.TextBox linkInput;
        private System.Windows.Forms.LinkLabel urlLabel;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

