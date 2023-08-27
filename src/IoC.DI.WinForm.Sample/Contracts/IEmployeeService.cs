using IoC.DI.WinForm.Sample.Surrogates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoC.DI.WinForm.Sample.Contracts
{
    public interface IEmployeeService
    {
        public bool TestEmployeeService();
        public Task<BaseDataResponse<IEnumerable<EmployeeResponseDto>>> GetEmployeesAsync(int count);
    }
}
