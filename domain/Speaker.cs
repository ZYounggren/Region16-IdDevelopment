using System.ComponentModel.DataAnnotations;

namespace domain;

public class Speaker
{
    [Key]
    public int SpeakerId {get; set;}
    string? FirstName {get; set;}
    string? LastName {get; set;}
    string? MailAddress {get; set;}
    string? PrimaryPhoneNumber {get; set;}
    string? EmailAddress {get; set;}
    public string? JobTitle {get; set;}
    public Session? Session {get; set;}
}