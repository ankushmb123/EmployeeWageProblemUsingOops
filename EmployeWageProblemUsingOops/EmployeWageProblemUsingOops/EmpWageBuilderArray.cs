
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeWageProblemUsingOops
{       /// <summary>
        /// interface for ComputeEmpWage
        /// </summary>
    interface IComputeEmpWage
    {
        //  interface method of AddCompany( with body)
        void AddCompany(string companyName, int wagePerHour, int maxWorkingDays, int maxWorkingHours);
        //  interface method of ComputeMonthlyWage( with body)
        int ComputeMonthlyWage(CompanyEmpWage company);
        // interface method (does not have a body)
        void DisplayCompanyWages();
    }
}