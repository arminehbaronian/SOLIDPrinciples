using SOLIDPrinciple.Entity;
using SOLIDPrinciple.Interfaces;

namespace SOLIDPrinciple
{
    public class EmployeeBase:IEmployee
    {
        public FileLogger fileLogger;
        public EmployeeModel _employee { get; set; }
        public EmployeeBase()
        {
            fileLogger= new FileLogger();
            _employee= new EmployeeModel();
        }
        public void Add(EmployeeModel employee)
        {
            _employee = employee;
            try
            {
                //Add customer to databse

            }
            catch(Exception e) { 
                //Single Responsibility principle
                fileLogger.Log(e.ToString()); }
        }

        //Open/Close Principle (OCP)
        public virtual decimal GetSallary()
        {
            return _employee.SallaryBase * _employee.Hours;
    
        }


    }


    public class Manager : EmployeeBase ,IManagement, IEmployeeCVReader, IEmployeePhotoChanger
    {
        public Manager():base() { }

        public bool ConfirmPersonnelInput()
        {
            throw new NotImplementedException();
        }

        public bool ConfirmPersonnelOutput()
        {
            throw new NotImplementedException();
        }

        public decimal GetEmployeeCV()
        {
            throw new NotImplementedException();
        }

        public override decimal GetSallary()
        {
            return _employee.SallaryBase*3*_employee.Hours;
        }

        public bool updateEmployeePhoto()
        {
            throw new NotImplementedException();
        }
    }

    public class SuperViser:EmployeeBase, IEmployeeCVReader
    {
        public SuperViser() : base() { }

        public decimal GetEmployeeCV()
        {
            throw new NotImplementedException();
        }

        public override decimal GetSallary()
        {
            return _employee.SallaryBase * _employee.Hours;
        }
    }

    public class Employee:EmployeeBase, IPercentage
    {
        public Employee() : base() { }

        public decimal GetPercentage()
        {
            throw new NotImplementedException();
        }

        public override decimal GetSallary()
        {
            return _employee.SallaryBase  * _employee.Hours;
        }
    }

  

    public class OuterCalss
    {
        //LSP
        IManagement _management = new Manager();
        IEmployee _employee;

        //DIP
        public OuterCalss(IEmployee employee) {
            _employee = employee;
        }
    }
}