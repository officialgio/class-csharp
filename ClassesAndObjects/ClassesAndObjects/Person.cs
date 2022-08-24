using System;
using System.Xml.Linq;

namespace ClassesAndObjects;

public class Person
{
	// properties
	public string FirstName { get; set; }
	public string LastName { get; set; }

	// constructor that takes a FirstName and LastName
	public Person(string firstName, string lastName)
	{
		FirstName = firstName;
		LastName = lastName;
	}

    public override string ToString()
    {
		return $"Person[Name: {FirstName}, LastName: {LastName}]" ;
    }
}
