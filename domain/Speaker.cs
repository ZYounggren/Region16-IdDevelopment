using System.ComponentModel.DataAnnotations;

namespace domain;

public class Speaker : Person
{
    [Key]
    public int SpeakerId {get; set;}
    public string? JobTitle {get; set;}
    public Session? Session {get; set;}
}