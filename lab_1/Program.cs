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

    public DateTime BirthDate
    {
        get {return birthDate;}
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
        return $"{firstName} {lastName}";
    }
}

public class Exam
{
    public string Subject {get; set;}
    public int Grade {get; set;}
    public DateTime Date {get; set;}

    public Exam(string subject, int grade, DateTime date)
    {
        Subject = subject;
        Grade = grade;
        Date = date;
    }

    public override string ToString()
    {
        return $"Subject: {Subject}, Grade: {Grade}, Date: {Date.ToShortDateString()}";
    }
}

public class Student
{
    private Person person;
    private Education education;
    private int groupNumber;
    private List<Exam> exams;

    public Student(Person person, Education education, int groupNumber)
    {
        this.person = person;
        this.education = education;
        this.groupNumber = groupNumber;
        this.exams = new List<Exam>();
    }

    public Person PersonInfo
    {
        get {return person;}
        set {person = value;}
    }

    public Education EducationForm
    {
        get {return education;}
        set {education = value;}
    }

    public int GroupNumber
    {
        get {return groupNumber;}
        set {groupNumber = value;}
    }

    public List<Exam> Exams
    {
        get {return exams;}
        set {exams = value;}
    }

    public double AverageGrade
    {
        get
        {
            if (exams.Count == 0) return 0.0;
            
            double sum = 0.0;
            foreach (var exam in exams)
            {
                sum += exam.Grade;
            }
            return sum / exams.Count;
        }
    }

    public bool isEducation(Education educationForm)
    {
        return education == educationForm;
    }

    public void addExam(params Exam[] exam)
    {
        exams.AddRange(exam);
    }

    public override string ToString()
    {
        string examsInfo = "";
        foreach (var exam in exams)
        {
            examsInfo += exam.ToString() + "\n";
        }
        return $"Student: {person}\nEducation: {education}, Group: {groupNumber}, Average Grade: {AverageGrade}\nExams:\n{examsInfo}";    
    }

    public virtual string ToShortString()
    {
        return $"Student: {person}\nEducation: {education}\nGroup: {groupNumber}, Average Grade: {AverageGrade}";
    }
}