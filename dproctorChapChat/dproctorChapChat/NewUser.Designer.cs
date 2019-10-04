namespace dproctorChapChat
{
    partial class NewUser
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
            this.createUser = new System.Windows.Forms.TextBox();
            this.userLabel = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.resizeContainer = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // createUser
            // 
            this.createUser.Location = new System.Drawing.Point(15, 38);
            this.createUser.Name = "createUser";
            this.createUser.Size = new System.Drawing.Size(122, 20);
            this.createUser.TabIndex = 0;
            this.createUser.TextChanged += new System.EventHandler(this.theUsername_TextChanged);
            this.createUser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.theUsername_KeyDown);
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(12, 22);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(95, 13);
            this.userLabel.TabIndex = 1;
            this.userLabel.Text = "Enter a Username:";
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(143, 36);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(224, 36);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // resizeContainer
            // 
            this.resizeContainer.AutoSize = true;
            this.resizeContainer.Location = new System.Drawing.Point(3, 3);
            this.resizeContainer.Name = "resizeContainer";
            this.resizeContainer.Size = new System.Drawing.Size(349, 100);
            this.resizeContainer.TabIndex = 4;
            this.resizeContainer.TabStop = false;
            // 
            // NewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 106);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.createUser);
            this.Controls.Add(this.resizeContainer);
            this.Name = "NewUser";
            this.Text = "New User";
            this.Load += new System.EventHandler(this.Startup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox createUser;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.GroupBox resizeContainer;
    }
}