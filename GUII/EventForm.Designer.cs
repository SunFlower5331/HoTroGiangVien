namespace GUII
{
    partial class EventForm
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
            this.btsave = new System.Windows.Forms.Button();
            this.ev = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.txtevent = new System.Windows.Forms.TextBox();
            this.txtdate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btsave
            // 
            this.btsave.Location = new System.Drawing.Point(317, 209);
            this.btsave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btsave.Name = "btsave";
            this.btsave.Size = new System.Drawing.Size(100, 28);
            this.btsave.TabIndex = 9;
            this.btsave.Text = "Save";
            this.btsave.UseVisualStyleBackColor = true;
            this.btsave.Click += new System.EventHandler(this.btsave_Click);
            // 
            // ev
            // 
            this.ev.AutoSize = true;
            this.ev.Location = new System.Drawing.Point(63, 122);
            this.ev.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ev.Name = "ev";
            this.ev.Size = new System.Drawing.Size(41, 16);
            this.ev.TabIndex = 8;
            this.ev.Text = "Event";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Location = new System.Drawing.Point(63, 42);
            this.date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(36, 16);
            this.date.TabIndex = 7;
            this.date.Text = "Date";
            // 
            // txtevent
            // 
            this.txtevent.Font = new System.Drawing.Font("MS PGothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtevent.Location = new System.Drawing.Point(63, 153);
            this.txtevent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtevent.Name = "txtevent";
            this.txtevent.Size = new System.Drawing.Size(353, 27);
            this.txtevent.TabIndex = 6;
            // 
            // txtdate
            // 
            this.txtdate.Font = new System.Drawing.Font("MS PGothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdate.Location = new System.Drawing.Point(63, 65);
            this.txtdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(353, 27);
            this.txtdate.TabIndex = 5;
            // 
            // EventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 283);
            this.Controls.Add(this.btsave);
            this.Controls.Add(this.ev);
            this.Controls.Add(this.date);
            this.Controls.Add(this.txtevent);
            this.Controls.Add(this.txtdate);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EventForm";
            this.Text = "EventForm";
            this.Load += new System.EventHandler(this.EventForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btsave;
        private System.Windows.Forms.Label ev;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.TextBox txtevent;
        private System.Windows.Forms.TextBox txtdate;
    }
}