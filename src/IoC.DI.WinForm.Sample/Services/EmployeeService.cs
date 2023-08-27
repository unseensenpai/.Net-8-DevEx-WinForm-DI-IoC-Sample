using IoC.DI.WinForm.Sample.Contracts;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoC.DI.WinForm.Sample.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IConfiguration _configuration;
        public EmployeeService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public bool TestEmployeeService()
            => _configuration.GetValue<bool>("TestValue");
    }
}
