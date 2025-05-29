using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LibraryAPI.Models;

public partial class Book
{
    [Key]
    [Column("BookID")]
    public int BookId { get; set; }

    [StringLength(100)]
    public string? Title { get; set; }

    [Column("AuthorID")]
    public int? AuthorId { get; set; }

    [Column("ISBN")]
    [StringLength(20)]
    public string? Isbn { get; set; }

    public int? PublishedYear { get; set; }

    [ForeignKey("AuthorId")]
    [InverseProperty("Books")]
    public virtual Author? Author { get; set; }

    [InverseProperty("Book")]
    public virtual ICollection<Loan> Loans { get; set; } = new List<Loan>();
}
