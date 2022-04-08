using System.ComponentModel.DataAnnotations;

namespace domain;

public class StudentAdvisor : Person
{
    [Key]
    public int StudentAdvisorId {get; set;}
}