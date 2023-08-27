using IoC.DI.WinForm.Sample.Contracts;
using IoC.DI.WinForm.Sample.Core.Helpers;
using Microsoft.Extensions.Configuration;
using Serilog;
using Serilog.Core;
using Serilog.Events;
using System;
using System.Diagnostics;
using System.Threading;

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
            TimerHelper.Start(async () =>
            {
                var result = await _employeeService.GetEmployeesAsync(50);
                GC_Employees.DataSource = result.Data;
            });
            TimerHelper.Stop();

            Log.Information("Completed request in {elapsed} seconds.", TimerHelper.GetResultInSeconds());
        }
    }
}