using IoC.DI.WinForm.Sample.Contracts;
using IoC.DI.WinForm.Sample.Surrogates;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace IoC.DI.WinForm.Sample.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IConfiguration _configuration;
        private readonly IHttpClientFactory _httpClientFactory;
        public EmployeeService(IConfiguration configuration, IHttpClientFactory httpClientFactory)
        {
            _configuration = configuration;
            _httpClientFactory = httpClientFactory;
        }
        public bool TestEmployeeService()
            => _configuration.GetValue<bool>("TestValue");

        public async Task<BaseDataResponse<IEnumerable<EmployeeResponseDto>>> GetEmployeesAsync(int count)
        {
            var httpClient = _httpClientFactory.CreateClient("localhost");
            HttpRequestMessage request = new(HttpMethod.Get, new Uri($"{httpClient.BaseAddress}Employee/GetEmployees?count={count}"));
            var httpResponse = await httpClient.SendAsync(request);
            var result = await httpResponse.Content.ReadFromJsonAsync<BaseDataResponse<IEnumerable<EmployeeResponseDto>>>();
            if (result is not null)
            {
                return result;
            }
            else
            {
                return new BaseDataResponse<IEnumerable<EmployeeResponseDto>>()
                {
                    IsSuccess = false,
                    Message = "An Error Occurred On Api Level",
                    Data = Enumerable.Empty<EmployeeResponseDto>()
                };
            }
        }
    }
}
