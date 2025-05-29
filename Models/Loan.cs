using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LibraryAPI.Models;

public partial class Loan
{
    [Key]
    [Column("LoanID")]
    public int LoanId { get; set; }

    [Column("BookID")]
    public int? BookId { get; set; }

    [Column("MemberID")]
    public int? MemberId { get; set; }

    public DateOnly? LoanDate { get; set; }

    public DateOnly? ReturnDate { get; set; }

    [ForeignKey("BookId")]
    [InverseProperty("Loans")]
    public virtual Book? Book { get; set; }

    [ForeignKey("MemberId")]
    [InverseProperty("Loans")]
    public virtual Member? Member { get; set; }
}
