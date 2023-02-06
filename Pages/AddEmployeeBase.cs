using AutoMapper;
using EmployeeManagement.Models;
using EmployeeManagement.Web.Models;
using EmployeeManagement.Web.Services;
using Microsoft.AspNetCore.Components;

namespace EmployeeManagement.Web.Pages
{
    public class AddEmployeeBase : ComponentBase
    {
        [Inject]
        public IDepartmentService DepartmentService { get; set; }
        public List<Department> Departments { get; set; } = new List<Department>();

        [Inject]
        public IEmployeeService EmployeeService { get; set; }

        public Employee Employee { get; set; }

       // [Inject]
       // public IMapper Mapper { get; set; }

        protected async override Task OnInitializedAsync()
        {
            Departments = (await DepartmentService.GetDepartments()).ToList();
        }

        [Inject]
        public NavigationManager NavigationManager { get; set; }
        protected async Task HandleValidSubmitToAddEmployee()
        {
            //Mapper.Map(AddEmployeeModel, Employee);
            var result = await EmployeeService.CreateEmployee(Employee);

            if (result != null)
            {
                NavigationManager.NavigateTo("/");
            }
        }
    }
}
