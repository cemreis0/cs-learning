using System;

public class Student
{
	public Student()
	{
        GuidId = Guid.NewGuid();
        Id = GuidId.ToString();
	}
    private Guid GuidId { get; set; }
    public String Id { get; set; }
    public string Name { get; set; }
    public string ZodiacSign { get; init; }
    public float CalculateGPA()
    {
        return 4.0F;
    }
    public bool canGraduate()
    {
        return true;
    }
}
