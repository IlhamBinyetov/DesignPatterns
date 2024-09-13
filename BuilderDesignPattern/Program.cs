

using BuilderDesignPattern.Method_2;

var eb = new EndPointBuilder("https://localhost/");

eb.Append("api").Append("v1").Append("user").AppendParams("id","5");

var url = eb.Build();

Console.WriteLine(url);



EmployeeM2 GenerateEmployee(string fullName, string emailAddress, int empType)
{
    IEmployeeBuilderM2 employeeBuilder;
    if (empType == 0)
        employeeBuilder = new InternalEmployeeBuilder();
    else
        employeeBuilder = new ExternalEmployeeBuilder();

    employeeBuilder.SetFullName(fullName);
    employeeBuilder.SetEmailAddress(emailAddress);

    return employeeBuilder.BuildEmployee();
}
