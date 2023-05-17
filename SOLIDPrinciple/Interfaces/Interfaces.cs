using SOLIDPrinciple.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciple.Interfaces
{
    #region Dipendancy Inversion (DIP)

    public interface IEmployee
    {
        void Add(EmployeeModel employee);
        decimal GetSallary();
    }

    #endregion
    //Liskov substitution (LSP)
    public interface IManagement
    {
        bool ConfirmPersonnelInput();
        bool ConfirmPersonnelOutput();
    }

    #region "ISP"
    public interface IPercentage
    {
        decimal GetPercentage();
    }
    public interface IEmployeeCVReader
    {
        decimal GetEmployeeCV();
    }
    public interface IEmployeePhotoChanger
    {
        bool updateEmployeePhoto();
    } 
    #endregion
}
