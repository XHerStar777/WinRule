namespace WRule
{
	partial class LeftRule
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.SuspendLayout();
			// 
			// LeftRule
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(145)))), ((int)(((byte)(0)))));
			this.ClientSize = new System.Drawing.Size(74, 470);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.Name = "LeftRule";
			this.Opacity = 0.5D;
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LeftRuleFormClosed);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.LeftRulePaint);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LeftRuleKeyPress);
			this.ResumeLayout(false);

		}
	}
}
