namespace TestLoader
{
	// Token: 0x02000005 RID: 5
	public partial class Loader : global::System.Windows.Forms.Form
	{
		// Token: 0x0600000D RID: 13 RVA: 0x00002174 File Offset: 0x00000374
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			bool flag2 = flag;
			if (flag2)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000021B0 File Offset: 0x000003B0
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loader));
            this.SuspendLayout();
            // 
            // Loader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(182, 132);
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Loader";
            this.Text = "antiMacro";
            this.Load += new System.EventHandler(this.Loader_Load);
            this.ResumeLayout(false);

		}

		// Token: 0x04000005 RID: 5
		private global::System.ComponentModel.IContainer components = null;
	}
}
