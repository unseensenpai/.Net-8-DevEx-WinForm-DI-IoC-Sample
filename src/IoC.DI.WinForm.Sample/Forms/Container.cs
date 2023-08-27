using IoC.DI.WinForm.Sample.Forms;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace IoC.DI.WinForm.Sample
{
    public partial class Container : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private readonly IServiceProvider _serviceProvider;
        public Container(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
        }

        private void BBI_SubForm_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var subForm = _serviceProvider.GetRequiredService<SubForm>();
            subForm.MdiParent = this;
            subForm.Show();
        }
    }
}
