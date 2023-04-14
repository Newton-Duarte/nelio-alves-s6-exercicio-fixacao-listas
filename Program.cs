namespace ExercicioFixacaoListas
{
  class Program
  {
    static void Main(string[] args)
    {
      List<Employee> employees = new List<Employee>();

      System.Console.WriteLine("Quantos funcionários serão cadastrados?");
      int employeeNumbers = int.Parse(Console.ReadLine());

      for(int i = 0; i < employeeNumbers; i++)
      {
        System.Console.WriteLine($"Employee #{i + 1}");
        System.Console.Write("Informe o id do funcionário: ");
        int employeeId = int.Parse(Console.ReadLine());

        System.Console.Write("Informe o nome do funcionário: ");
        string employeeName = Console.ReadLine();

        System.Console.Write("Informe o salário do funcionário: ");
        double employeeSalary = double.Parse(Console.ReadLine());

        employees.Add(new Employee(employeeId, employeeName, employeeSalary));

        Console.WriteLine();
      }

      PrintEmployees();

      System.Console.Write("Digite o ID do funcionário que terá o salário aumentado: ");
      int employeeIdToFind = int.Parse(Console.ReadLine());

      var findEmployee = employees.Find(employee => employee.Id == employeeIdToFind);

      if (findEmployee != null) {
        System.Console.Write("Informe a porcentagem que será aumentada no salário: ");
        double percentageToIncrease = double.Parse(Console.ReadLine());

        findEmployee.IncreaseSalary(percentageToIncrease);
      } else {
        System.Console.WriteLine("Esse ID não existe");
      }

      PrintEmployees();

      void PrintEmployees()
      {
        System.Console.WriteLine("Lista de funcionários atualizada:");
        foreach (var employee in employees)
        {
          System.Console.WriteLine(employee);
        }
      }

    }
  }
}