using System;

public class Person
{
    private string name;

    public Person()
    {
        this.name = "";
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
}