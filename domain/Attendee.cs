using System.ComponentModel.DataAnnotations;
 
 namespace domain;

public class Attendee : Person
{
    [Key]
    public int AttendeeId {get; set;}
    public int Grade {get; set;}
    public string? Gender {get; set;}
    public string? Ethnicity {get; set;}
    public Session? FirstSession {get; set;}
    public Session? SecondSession {get; set;}
}