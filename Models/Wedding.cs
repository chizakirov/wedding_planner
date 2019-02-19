using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace wedding_planner.Models
{
  public class Wedding
  {
    [Key]
    public int WeddingId {get; set;}

    [Required]
    [MinLength(2, ErrorMessage = "Wedder One must be at least 2 characters long")]
    public string WedderOne {get; set;}

    [Required]
    [MinLength(2, ErrorMessage = "Wedder Two must be at least 2 characters long")]
    public string WedderTwo {get; set;}

    [Required]
    public DateTime Date {get; set;}

    [Required]
    public string Address {get; set;}
    public DateTime CreatedAt {get;set;} = DateTime.Now;
    public DateTime UpdatedAt {get;set;} = DateTime.Now;
    
    [ForeignKey("UserId")]
    public int UserId {get; set;}
    public User MyCreator {get;set;}

    public List<RSVP> MyGuests {get; set;}
    public Wedding(){
    }
  }
}