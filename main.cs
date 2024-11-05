using System;

public enum Education
{
    Specialist,
    Bachelor,
    SecondEducation
}

public class Person
{
    private string firstName;
    private string lastName;
    private DateTime birthDate;

    public Person(string firstName, string lastName, DateTime birthDate)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.birthDate = birthDate;
    }

    public Person()
    {
        this.firstName = "None";
        this.lastName = "None";
        this.birthDate = DateTime.MinValue;
    }

    public string FirstName
    {
        get {return firstName;}
        set {firstName = value;}
    }

    public string LastName
    {
        get {return lastName;}
        set {lastName = value;}
    }

    public string BirthDate
    {
        get {retutn birthDate;}
        set {birthDate = value;}
    }

    public int BitrhYear
    {
        get {return birthDate.Year;}
        set {birthDate = new DateTime(value, birthDate.Month, birthDate.Day);}
    }

    public override string ToString()
    {
        return $"Name: {firstName}, Last name: {lastName}, BirthDate {birthDate.ToShortDateString()}";
    }

    public virtual string ToShortString()
    {
        return $"{firstName} {lastName}"
    }
}