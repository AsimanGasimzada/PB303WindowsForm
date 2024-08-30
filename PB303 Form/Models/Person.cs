namespace PB303_Form.Models;

public class Person
{
    public int Id { get; set; }
    private static int _id = 0;
    public string Fullname{ get; set; }
    public int Age{ get; set; }

    public Person(string fullname,int age)
    {
        Id = ++_id;
        Fullname = fullname;
        Age = age;

    }

    public override string ToString()
    {
        return $"{Id} {Fullname} {Age}";
    }
}
