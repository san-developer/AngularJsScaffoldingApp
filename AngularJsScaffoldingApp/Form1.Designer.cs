namespace AngularJsScaffoldingApp
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
            this.btnScaffold = new System.Windows.Forms.Button();
            this.txtProjectPath = new System.Windows.Forms.TextBox();
            this.lblProjectPath = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnScaffold
            // 
            this.btnScaffold.Location = new System.Drawing.Point(222, 248);
            this.btnScaffold.Name = "btnScaffold";
            this.btnScaffold.Size = new System.Drawing.Size(124, 38);
            this.btnScaffold.TabIndex = 0;
            this.btnScaffold.Text = "Create New Website";
            this.btnScaffold.UseVisualStyleBackColor = true;
            this.btnScaffold.Click += new System.EventHandler(this.btnScaffold_Click);
            // 
            // txtProjectPath
            // 
            this.txtProjectPath.Location = new System.Drawing.Point(222, 40);
            this.txtProjectPath.Name = "txtProjectPath";
            this.txtProjectPath.Size = new System.Drawing.Size(245, 20);
            this.txtProjectPath.TabIndex = 1;
            this.txtProjectPath.Text = "D:\\san\\testtemp";
            // 
            // lblProjectPath
            // 
            this.lblProjectPath.AutoSize = true;
            this.lblProjectPath.Location = new System.Drawing.Point(63, 47);
            this.lblProjectPath.Name = "lblProjectPath";
            this.lblProjectPath.Size = new System.Drawing.Size(65, 13);
            this.lblProjectPath.TabIndex = 2;
            this.lblProjectPath.Text = "Project Path";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 411);
            this.Controls.Add(this.lblProjectPath);
            this.Controls.Add(this.txtProjectPath);
            this.Controls.Add(this.btnScaffold);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnScaffold;
        private System.Windows.Forms.TextBox txtProjectPath;
        private System.Windows.Forms.Label lblProjectPath;
    }
}

