using System;

namespace ClassesAndObjects;

public class Program
{
    static void Main()
    {
        // instantiate many objects with diffrent names
        Person personOne = new Person("Giovanny", "Hernandez");
        Person personTwo = new Person("Name1", "LastName1");
        Person personThree = new Person("Name2", "LastName2");
        Person personFour = new Person("Name3", "LastName3");
        Person personFive = new Person("Name4", "LastName4");
        Person personSix = new Person("Name5", "LastName5");
        Person personSeven = new Person("Name6", "LastName6");
        Person personEight = new Person("Name7", "LastName7");
        Person personNine = new Person("Name8", "LastName8");

        // store them manually in an array 
        // usually these are not store with an array
        // but because we've only cover arrays this is sort of the same process when storing objects
        // usually they're store in databases along with many more properties than just a name and lastName
        // usually you don't store them manually, you'll have the logic on methods that'll do it for you. 
        Person[] arrayOfPeople = new Person[9]
        {
            personOne,
            personTwo,
            personThree,
            personFour,
            personFive,
            personSix,
            personSeven,
            personEight,
            personNine
        };

        // print
        for (int i = 0; i < arrayOfPeople.Length; i++)
        {
            Console.WriteLine(arrayOfPeople[i]);
        }
    }
}
