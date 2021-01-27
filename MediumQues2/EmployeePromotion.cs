using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediumQues2
{
    class EmployeePromotion
    {
        Dictionary<int,Employee> employees = new Dictionary<int, Employee>();
        public void EmployeeDetails()
        {
            int input = 1;
            
            List<Employee> employeeList = new List<Employee>();
            try
            {
                while (input == 1)
                {
                    Employee employeeClassObject = new Employee();
                    employeeClassObject.TakeEmployeeDetailsFromUser();
                    employees.Add(employeeClassObject.Id, employeeClassObject);
                    Console.WriteLine("To continue entering employee details enter 1, to exit enter 0");
                    input = Convert.ToInt32(Console.ReadLine());
                }
                foreach(var employeeDictObject in employees)
                {
                    employeeList.Add(employeeDictObject.Value);
                }
                
                if (input == 0)
                {
                    SortAndPrintEmployees(employeeList);
                    PrintEmployee(employeeList);
                }
                else
                {
                    Console.WriteLine("Please Enter 1 or 0 only !! Thank You");
                    EmployeeDetails();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Sorry !! An error has occured !!");
                Console.WriteLine(e);
                EmployeeDetails();
            }
        }
        public void SortAndPrintEmployees(List<Employee> employeeListToSort)
        {
            employeeListToSort.Sort();
            try
            {
                Console.WriteLine("The sorted employee list ");
                foreach (var employeeListObjectToSort in employeeListToSort)
                {
                    Console.WriteLine(employeeListObjectToSort);
                }
            }catch(Exception e)
            {
                Console.WriteLine($"Sorry !! An error has occured !!");
                Console.WriteLine(e);
            }
        }
        public void PrintEmployee(List<Employee> employeeListToFilter)
        {
            int employeeIdToDisplayEmplyeeObject;
            try
            {
                Console.WriteLine("Please enter the employee ID");
                employeeIdToDisplayEmplyeeObject = Convert.ToInt32(Console.ReadLine());
                if (employees.ContainsKey(employeeIdToDisplayEmplyeeObject))
                {
                    var filteredResult = from empListToFilter in employeeListToFilter where empListToFilter.Id == employeeIdToDisplayEmplyeeObject select empListToFilter;
                    foreach (var filteredEmployeeListObject in filteredResult)
                    {
                        Console.WriteLine(filteredEmployeeListObject);
                    }
                }
                else
                {
                    Console.WriteLine("Please Enter a valid ID");
                    
                }
            }catch(Exception e)
            {
                Console.WriteLine($"Sorry !! An error has occured !!");
                Console.WriteLine(e);
                
            }
        }
    }
}
