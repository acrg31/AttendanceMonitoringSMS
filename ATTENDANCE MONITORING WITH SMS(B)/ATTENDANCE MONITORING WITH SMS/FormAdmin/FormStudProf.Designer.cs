namespace LUBANG_ATTENDANCE.FormAdmin
{
    partial class FormStudProf
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStudProf));
            this.btnSubmit = new FontAwesome.Sharp.IconButton();
            this.pictureBoxQrcode = new FontAwesome.Sharp.IconPictureBox();
            this.btnBrowse = new FontAwesome.Sharp.IconButton();
            this.textqrImageFileName = new System.Windows.Forms.TextBox();
            this.textBoxUserID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQrcode)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnSubmit.IconColor = System.Drawing.Color.Black;
            this.btnSubmit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSubmit.IconSize = 30;
            this.btnSubmit.Location = new System.Drawing.Point(300, 337);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 37);
            this.btnSubmit.TabIndex = 52;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // pictureBoxQrcode
            // 
            this.pictureBoxQrcode.BackColor = System.Drawing.Color.White;
            this.pictureBoxQrcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxQrcode.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBoxQrcode.IconChar = FontAwesome.Sharp.IconChar.Image;
            this.pictureBoxQrcode.IconColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBoxQrcode.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pictureBoxQrcode.IconSize = 319;
            this.pictureBoxQrcode.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxQrcode.Name = "pictureBoxQrcode";
            this.pictureBoxQrcode.Size = new System.Drawing.Size(388, 319);
            this.pictureBoxQrcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxQrcode.TabIndex = 51;
            this.pictureBoxQrcode.TabStop = false;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.IconChar = FontAwesome.Sharp.IconChar.Image;
            this.btnBrowse.IconColor = System.Drawing.Color.Black;
            this.btnBrowse.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBrowse.IconSize = 30;
            this.btnBrowse.Location = new System.Drawing.Point(12, 337);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(265, 37);
            this.btnBrowse.TabIndex = 50;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // textqrImageFileName
            // 
            this.textqrImageFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textqrImageFileName.Location = new System.Drawing.Point(640, 134);
            this.textqrImageFileName.Name = "textqrImageFileName";
            this.textqrImageFileName.ReadOnly = true;
            this.textqrImageFileName.Size = new System.Drawing.Size(206, 26);
            this.textqrImageFileName.TabIndex = 49;
            // 
            // textBoxUserID
            // 
            this.textBoxUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserID.Location = new System.Drawing.Point(640, 102);
            this.textBoxUserID.Name = "textBoxUserID";
            this.textBoxUserID.ReadOnly = true;
            this.textBoxUserID.Size = new System.Drawing.Size(210, 26);
            this.textBoxUserID.TabIndex = 48;
            // 
            // FormStudProf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 388);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.pictureBoxQrcode);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.textqrImageFileName);
            this.Controls.Add(this.textBoxUserID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormStudProf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PROFILE IMAGE";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQrcode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnSubmit;
        private FontAwesome.Sharp.IconPictureBox pictureBoxQrcode;
        private FontAwesome.Sharp.IconButton btnBrowse;
        private System.Windows.Forms.TextBox textqrImageFileName;
        private System.Windows.Forms.TextBox textBoxUserID;
    }
}