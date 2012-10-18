namespace Guid
{
    partial class FormMain
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
            this.buttonReload = new System.Windows.Forms.Button();
            this.textBoxGuid = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonReload
            // 
            this.buttonReload.Location = new System.Drawing.Point(105, 244);
            this.buttonReload.Name = "buttonReload";
            this.buttonReload.Size = new System.Drawing.Size(75, 23);
            this.buttonReload.TabIndex = 0;
            this.buttonReload.Text = "Reload";
            this.buttonReload.UseVisualStyleBackColor = true;
            this.buttonReload.Click += new System.EventHandler(this.buttonReload_Click);
            // 
            // textBoxGuid
            // 
            this.textBoxGuid.Location = new System.Drawing.Point(5, 8);
            this.textBoxGuid.Multiline = true;
            this.textBoxGuid.Name = "textBoxGuid";
            this.textBoxGuid.Size = new System.Drawing.Size(287, 230);
            this.textBoxGuid.TabIndex = 1;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 273);
            this.Controls.Add(this.textBoxGuid);
            this.Controls.Add(this.buttonReload);
            this.Name = "FormMain";
            this.Text = "Guid - by Patware";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonReload;
        private System.Windows.Forms.TextBox textBoxGuid;
    }
}

