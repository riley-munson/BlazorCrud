using System.Runtime.CompilerServices;

namespace BlazorCrud.Mappers
{
	public static class EmployeeMapper
	{
		public static Employee ToEmployee(this EmployeeDto dto)
		{
			return new Employee
			{
				Department = dto.Department,
				FirstName = dto.FirstName,
				LastName = dto.LastName,
				Email = dto.Email,
				HireDate = dto.HireDate,
				LeaveDate = dto.LeaveDate,
				IsExecutive = dto.IsExecutive,
				IsManager = dto.IsManager,
				IsTerminated = dto.IsTerminated,
				Title = dto.Title
			};
		}

		public static EmployeeDto ToEmployeeDto(this Employee employee)
		{
			return new EmployeeDto
			{
				Department = employee.Department,
				FirstName = employee.FirstName,
				LastName = employee.LastName,
				Email = employee.Email,
				HireDate = employee.HireDate,
				LeaveDate = employee.LeaveDate,
				IsExecutive = employee.IsExecutive,
				IsManager = employee.IsManager,
				IsTerminated = employee.IsTerminated,
				Title = employee.Title
			};
		}
	}
}
