namespace ViRGO.Net.Cad.Base
{
    partial class ModalForm
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
            this.lbl_Close = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.lbl_minimize = new System.Windows.Forms.Label();
            this.lbl_caption = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Close
            // 
            this.lbl_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Close.AutoSize = true;
            this.lbl_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Close.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_Close.Location = new System.Drawing.Point(635, 5);
            this.lbl_Close.Name = "lbl_Close";
            this.lbl_Close.Size = new System.Drawing.Size(16, 16);
            this.lbl_Close.TabIndex = 11;
            this.lbl_Close.Text = "X";
            this.lbl_Close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Close.Click += new System.EventHandler(this.lbl_Close_Click);
            this.lbl_Close.MouseLeave += new System.EventHandler(this.lbl_Close_MouseLeave);
            this.lbl_Close.MouseHover += new System.EventHandler(this.lbl_Close_MouseHover);
            // 
            // logo
            // 
            this.logo.BackgroundImage = Properties.Resources.cozci_text;
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logo.Location = new System.Drawing.Point(2, 3);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(64, 18);
            this.logo.TabIndex = 12;
            this.logo.TabStop = false;
            // 
            // lbl_minimize
            // 
            this.lbl_minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_minimize.AutoSize = true;
            this.lbl_minimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_minimize.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_minimize.Location = new System.Drawing.Point(615, 2);
            this.lbl_minimize.Name = "lbl_minimize";
            this.lbl_minimize.Size = new System.Drawing.Size(15, 16);
            this.lbl_minimize.TabIndex = 13;
            this.lbl_minimize.Text = "_";
            this.lbl_minimize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_minimize.Visible = false;
            this.lbl_minimize.Click += new System.EventHandler(this.lbl_minimize_Click);
            this.lbl_minimize.MouseLeave += new System.EventHandler(this.lbl_minimize_MouseLeave);
            this.lbl_minimize.MouseHover += new System.EventHandler(this.lbl_minimize_MouseHover);
            // 
            // lbl_caption
            // 
            this.lbl_caption.AutoSize = true;
            this.lbl_caption.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_caption.Location = new System.Drawing.Point(72, 5);
            this.lbl_caption.Name = "lbl_caption";
            this.lbl_caption.Size = new System.Drawing.Size(49, 14);
            this.lbl_caption.TabIndex = 15;
            this.lbl_caption.Text = "Caption";
            // 
            // ModalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(68)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(655, 394);
            this.Controls.Add(this.lbl_caption);
            this.Controls.Add(this.lbl_minimize);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.lbl_Close);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModalForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ModalForm";
            this.Load += new System.EventHandler(this.ModalForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ModalForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ModalForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ModalForm_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Close;
        private System.Windows.Forms.PictureBox logo;
        public System.Windows.Forms.Label lbl_minimize;
        public System.Windows.Forms.Label lbl_caption;
    }
}