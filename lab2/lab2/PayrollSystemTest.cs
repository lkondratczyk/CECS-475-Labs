///////////////////////////////////////////////////////////////////////////////
//
//  CECS 475 Lab 2
//
//  Lyndon Kondratczyk
//
//  9/14/15
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections;

public class PayrollSystemTest
{
    public static void Main(string[] args)
    {
        // create derived class objects
        SalariedEmployee salariedEmployee =
           new SalariedEmployee("John", "Smith", "111-11-1111", 800.00M);
        HourlyEmployee hourlyEmployee =
           new HourlyEmployee("Karen", "Price",
           "222-22-2222", 16.75M, 40.0M);
        CommissionEmployee commissionEmployee =
           new CommissionEmployee("Sue", "Jones",
           "333-33-3333", 10000.00M, .06M);
        BasePlusCommissionEmployee basePlusCommissionEmployee =
           new BasePlusCommissionEmployee("Bob", "Lewis",
           "444-44-4444", 5000.00M, .04M, 300.00M);

        Console.WriteLine("Employees processed individually:\n");

        Console.WriteLine("{0}\nearned: {1:C}\n",
           salariedEmployee, salariedEmployee.Earnings());
        Console.WriteLine("{0}\nearned: {1:C}\n",
           hourlyEmployee, hourlyEmployee.Earnings());
        Console.WriteLine("{0}\nearned: {1:C}\n",
           commissionEmployee, commissionEmployee.Earnings());
        Console.WriteLine("{0}\nearned: {1:C}\n",
           basePlusCommissionEmployee,
           basePlusCommissionEmployee.Earnings());

        // create four-element Employee array
        Employee[] employees = new Employee[4];

        // initialize array with Employees of derived types
        employees[0] = salariedEmployee;
        employees[1] = hourlyEmployee;
        employees[2] = commissionEmployee;
        employees[3] = basePlusCommissionEmployee;

        Console.WriteLine("Employees processed polymorphically:\n");

        // generically process each element in array employees
        processEmployees(employees);

        // get type name of each object in employees array
        for (int j = 0; j < employees.Length; j++)
            Console.WriteLine("Employee {0} is a {1}", j,
               employees[j].GetType());

        Console.WriteLine("\nEMPLOYEES PROCESSED BY IPAYABLE\n");

        //Create IPayable array
        IPayable[] payableObjects = new IPayable[8];
        payableObjects[0] = new SalariedEmployee(
                "John", "Smith", "111-11-1111", 700M);
        payableObjects[1] = new SalariedEmployee(
                "Antonio", "Smith", "555-55-5555", 800M);
        payableObjects[2] = new SalariedEmployee(
                "Victor", "Smith", "444-44-4444", 600M);
        payableObjects[3] = new HourlyEmployee(
                "Karen", "Price", "222-22-2222", 16.75M, 40M);
        payableObjects[4] = new HourlyEmployee(
                "Ruben", "Zamora", "666-66-6666", 20.00M, 40M);
        payableObjects[5] = new CommissionEmployee(
                "Sue", "Jones", "333-33-3333", 10000M, .06M);
        payableObjects[6] = new BasePlusCommissionEmployee(
                "Bob", "Lewis", "777-77-7777", 5000M, .04M, 300M);
        payableObjects[7] = new BasePlusCommissionEmployee(
                "Lee", "Duarte", "888-88-888", 5000M, .04M, 300M);

        // generically process each element in array employees
        processEmployees(payableObjects);

        //bubble sort and pointer
        Console.WriteLine("\nIPAYABLES SORTED BY SSN:\n");
        BubbleSort(payableObjects, SSNAscending);
        foreach (Employee currentEmployee in payableObjects)
        {
            Console.WriteLine(currentEmployee); // invokes ToString
            Console.WriteLine(
               "earned {0:C}\n", currentEmployee.Earnings());
        } // end foreach

        //IComparer
        Console.WriteLine("\nIPAYABLES SORTED BY LAST NAME ASCENDING\n");
        ArrayList comparerSample = new ArrayList();
        //populate ArrayList for IComparer and IComprable
        foreach (IPayable currentPayable in payableObjects)
        {
            comparerSample.Add(currentPayable);
        }//end foreach
        IComparer lastAscend = new SortLastNAscending();
        comparerSample.Sort(lastAscend);
        foreach (Employee currentEmployee in comparerSample)
        {
            Console.WriteLine(currentEmployee); // invokes ToString
            Console.WriteLine(
               "earned {0:C}\n", currentEmployee.Earnings());
        } // end foreach

        //IComparable implementation
        Console.WriteLine("\nIPAYABLES SORTED BY SALARY DESCEDNING\n");
        comparerSample.Sort();
        foreach (Employee currentEmployee in comparerSample)
        {
            Console.WriteLine(currentEmployee); // invokes ToString
            Console.WriteLine(
               "earned {0:C}\n", currentEmployee.Earnings());
        } // end foreach
    } // end Main

    // generically process each element in array employees
    public static void processEmployees(IPayable[] employees)
    {
        foreach (IPayable currentEmployee in employees)
        {
            Console.WriteLine(currentEmployee); // invokes ToString
            // determine whether element is a BasePlusCommissionEmployee
            if (currentEmployee is BasePlusCommissionEmployee)
            {
                // downcast Employee reference to 
                // BasePlusCommissionEmployee reference
                BasePlusCommissionEmployee employee =
                   (BasePlusCommissionEmployee)currentEmployee;

                employee.BaseSalary *= 1.10M;
                Console.WriteLine(
                   "new base salary with 10% increase is: {0:C}",
                   employee.BaseSalary);
            } // end if
            Console.WriteLine(
               "earned {0:C}\n", currentEmployee.GetPaymentAmount());
        } // end foreach
    }//end method


    //delegate for pointer to function
    public delegate int Sort(IPayable e1, IPayable e2);

    //Function pointer to Sort function
    public static int SSNAscending(IPayable e1, IPayable e2)
    {
        return ((Employee)e1).SocialSecurityNumber.CompareTo(
                ((Employee)e2).SocialSecurityNumber);
    }//end function

    /*
        Simple Bubble sort using pointer to function for chosing to sort 
        by SSN ascending
    */
    public static void BubbleSort(IPayable[] employees, Sort sort)
    {
        for(int i = employees.Length; i > 0; i--)
        {
            for (int j = 1; j < i; j++)
            {
                IPayable temp = employees[j - 1];
                //use pointer to function
                if((sort(employees[j], employees[j - 1]) < 1)){
                    //swap
                    employees[j - 1] = employees[j];
                    employees[j] = temp;
                }//end if
            }//end for
        }//end for
    }//end function

    /*
        IComparer for sorting by last name ascending
    */
    public class SortLastNAscending : IComparer
    {
        int IComparer.Compare(Object e1, Object e2)
        {
            return (((Employee)e1).LastName.CompareTo(((Employee)e2).LastName));
        }
    }
} // end class PayrollSystemTest

