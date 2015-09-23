using System;

public abstract class Employee: IPayable, IComparable
{
    //To make employee IComparable
    public int CompareTo(Object obj)
    {
        if (obj == null) return 1;
        Employee empCompare = obj as Employee;
        if (empCompare != null)
            return empCompare.Earnings().CompareTo(this.Earnings());
        else
            throw new ArgumentException("Object is not Employee");
    }
    // read-only property that gets employee's first name
    public string FirstName { get; private set; }

    // read-only property that gets employee's last name
    public string LastName { get; private set; }

    // read-only property that gets employee's social security number
    public string SocialSecurityNumber { get; private set; }

    // three-parameter constructor
    public Employee(string first, string last, string ssn)
    {
        FirstName = first;
        LastName = last;
        SocialSecurityNumber = ssn;
    } // end three-parameter Employee constructor

    // return string representation of Employee object, using properties
    public override string ToString()
    {
        return string.Format("{0} {1}\nsocial security number: {2}",
           FirstName, LastName, SocialSecurityNumber);
    } // end method ToString

    //abstract method to be implemented by subclasses
    public abstract decimal Earnings();

    //IPayable interface implementation
    public decimal GetPaymentAmount()
    {
        return Earnings();
    }

} // end abstract class Employee
