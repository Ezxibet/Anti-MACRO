using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using TestLoader.Classes;
using Testloader.Classes;

namespace TestLoader
{
	// Token: 0x02000005 RID: 5
	public partial class Loader : Form
	{
		// Token: 0x0600000B RID: 11 RVA: 0x00002122 File Offset: 0x00000322
		public Loader()
		{
			this.InitializeComponent();
			Utils.InitializeHashList();
			ProcessFinder.FindByHash(Utils.HashList);
			AutoProcessDetector.Start();
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002151 File Offset: 0x00000351
		private void Loader_Load(object sender, EventArgs e)
		{
			this.InitializeComponent();
			Utils.InitializeHashList();
			ProcessFinder.FindByHash(Utils.HashList);
			AutoProcessDetector.Start();
		}
	}
}
