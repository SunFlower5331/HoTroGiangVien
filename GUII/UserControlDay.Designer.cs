namespace GUII
{
    partial class UserControlDay
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.idday = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // idday
            // 
            this.idday.AutoSize = true;
            this.idday.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idday.Location = new System.Drawing.Point(14, 9);
            this.idday.Name = "idday";
            this.idday.Size = new System.Drawing.Size(23, 16);
            this.idday.TabIndex = 0;
            this.idday.Text = "00";
            // 
            // UserControlDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.idday);
            this.Name = "UserControlDay";
            this.Size = new System.Drawing.Size(90, 45);
            this.Load += new System.EventHandler(this.UserControlDay_Load);
            this.Click += new System.EventHandler(this.UserControlDay_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label idday;
    }
}
