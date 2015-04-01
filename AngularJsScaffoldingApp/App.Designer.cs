namespace AngularJsScaffoldingApp
{
    partial class ScaffoldAngularJsApp
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
            this.txtProjectPath = new System.Windows.Forms.TextBox();
            this.lblProjectPath = new System.Windows.Forms.Label();
            this.tbControl = new System.Windows.Forms.TabControl();
            this.tbNewWebsite = new System.Windows.Forms.TabPage();
            this.btnScaffold = new System.Windows.Forms.Button();
            this.tbAddComponent = new System.Windows.Forms.TabPage();
            this.btnAddComponent = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtComponentName = new System.Windows.Forms.TextBox();
            this.tbControl.SuspendLayout();
            this.tbNewWebsite.SuspendLayout();
            this.tbAddComponent.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtProjectPath
            // 
            this.txtProjectPath.Location = new System.Drawing.Point(222, 12);
            this.txtProjectPath.Name = "txtProjectPath";
            this.txtProjectPath.Size = new System.Drawing.Size(245, 20);
            this.txtProjectPath.TabIndex = 1;
            this.txtProjectPath.Text = "D:\\san\\testtemp";
            // 
            // lblProjectPath
            // 
            this.lblProjectPath.AutoSize = true;
            this.lblProjectPath.Location = new System.Drawing.Point(141, 15);
            this.lblProjectPath.Name = "lblProjectPath";
            this.lblProjectPath.Size = new System.Drawing.Size(65, 13);
            this.lblProjectPath.TabIndex = 2;
            this.lblProjectPath.Text = "Project Path";
            // 
            // tbControl
            // 
            this.tbControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbControl.Controls.Add(this.tbNewWebsite);
            this.tbControl.Controls.Add(this.tbAddComponent);
            this.tbControl.Location = new System.Drawing.Point(1, 45);
            this.tbControl.Name = "tbControl";
            this.tbControl.SelectedIndex = 0;
            this.tbControl.Size = new System.Drawing.Size(529, 322);
            this.tbControl.TabIndex = 3;
            // 
            // tbNewWebsite
            // 
            this.tbNewWebsite.Controls.Add(this.btnScaffold);
            this.tbNewWebsite.Location = new System.Drawing.Point(4, 22);
            this.tbNewWebsite.Name = "tbNewWebsite";
            this.tbNewWebsite.Padding = new System.Windows.Forms.Padding(3);
            this.tbNewWebsite.Size = new System.Drawing.Size(521, 296);
            this.tbNewWebsite.TabIndex = 0;
            this.tbNewWebsite.Text = "New Website";
            this.tbNewWebsite.UseVisualStyleBackColor = true;
            // 
            // btnScaffold
            // 
            this.btnScaffold.Location = new System.Drawing.Point(182, 134);
            this.btnScaffold.Name = "btnScaffold";
            this.btnScaffold.Size = new System.Drawing.Size(124, 38);
            this.btnScaffold.TabIndex = 0;
            this.btnScaffold.Text = "Create New Website";
            this.btnScaffold.UseVisualStyleBackColor = true;
            this.btnScaffold.Click += new System.EventHandler(this.btnScaffold_Click);
            // 
            // tbAddComponent
            // 
            this.tbAddComponent.Controls.Add(this.txtComponentName);
            this.tbAddComponent.Controls.Add(this.label1);
            this.tbAddComponent.Controls.Add(this.btnAddComponent);
            this.tbAddComponent.Location = new System.Drawing.Point(4, 22);
            this.tbAddComponent.Name = "tbAddComponent";
            this.tbAddComponent.Padding = new System.Windows.Forms.Padding(3);
            this.tbAddComponent.Size = new System.Drawing.Size(521, 296);
            this.tbAddComponent.TabIndex = 1;
            this.tbAddComponent.Text = "Add Component";
            this.tbAddComponent.UseVisualStyleBackColor = true;
            // 
            // btnAddComponent
            // 
            this.btnAddComponent.Location = new System.Drawing.Point(181, 152);
            this.btnAddComponent.Name = "btnAddComponent";
            this.btnAddComponent.Size = new System.Drawing.Size(119, 42);
            this.btnAddComponent.TabIndex = 4;
            this.btnAddComponent.Text = "Add Component";
            this.btnAddComponent.UseVisualStyleBackColor = true;
            this.btnAddComponent.Click += new System.EventHandler(this.btnAddComponent_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter Component Name";
            // 
            // txtComponentName
            // 
            this.txtComponentName.Location = new System.Drawing.Point(181, 42);
            this.txtComponentName.Name = "txtComponentName";
            this.txtComponentName.Size = new System.Drawing.Size(198, 20);
            this.txtComponentName.TabIndex = 6;
            this.txtComponentName.Text = "Courses";
            // 
            // ScaffoldAngularJsApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 373);
            this.Controls.Add(this.tbControl);
            this.Controls.Add(this.lblProjectPath);
            this.Controls.Add(this.txtProjectPath);
            this.Name = "ScaffoldAngularJsApp";
            this.Text = "Scaffold AngularJs App";
            this.tbControl.ResumeLayout(false);
            this.tbNewWebsite.ResumeLayout(false);
            this.tbAddComponent.ResumeLayout(false);
            this.tbAddComponent.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtProjectPath;
        private System.Windows.Forms.Label lblProjectPath;
        private System.Windows.Forms.TabControl tbControl;
        private System.Windows.Forms.TabPage tbAddComponent;
        private System.Windows.Forms.TabPage tbNewWebsite;
        private System.Windows.Forms.Button btnScaffold;
        private System.Windows.Forms.Button btnAddComponent;
        private System.Windows.Forms.TextBox txtComponentName;
        private System.Windows.Forms.Label label1;
    }
}

