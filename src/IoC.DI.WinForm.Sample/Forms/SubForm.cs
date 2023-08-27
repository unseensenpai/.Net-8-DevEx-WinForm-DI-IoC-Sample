using IoC.DI.WinForm.Sample.Contracts;
using Microsoft.Extensions.Configuration;

namespace IoC.DI.WinForm.Sample.Forms
{
    public partial class SubForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        readonly IConfiguration _configuration;
        readonly IEmployeeService _employeeService;
        public SubForm(IConfiguration configuration, IEmployeeService employeeService)
        {
            InitializeComponent();
            _configuration = configuration;
            _employeeService = employeeService;
        }

        private void BBI_AddEmployee_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void BBI_GetEmployees_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}