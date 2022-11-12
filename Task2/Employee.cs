public class Employee
{
    int _id;
    string _firstName;
    string _lastName;
    int _salary;
    public Employee(int id, string firstName, string lastName, int salary)
    {
        _id = id;
        _firstName = firstName;
        _lastName = lastName;
        _salary = salary;
    }
    public int GetId(){
        return _id;
    }
    public string GetFirstName(){
        return _firstName;
    }
    public string GetLastName(){
        return _lastName;
    }
    public string GetName(){
        return $"{_firstName} {_lastName}";
    }
    public int GetSalary(){
        return _salary;
    }
    public void SetSalary(int salary){
        _salary = salary;
    }
    public int GetAnnualSalary(){
        return 12*_salary;
    }
    public int RaiseSalary(int percent){
        int raise = _salary*(100+percent)/100;
        _salary = raise;
        return _salary;
    }
    public override string ToString()
    {
        return $"Employee[id={_id}, name = {GetName()}, salary = {_salary}]";
    }
}