using System.ComponentModel.DataAnnotations;

namespace JobTracker.Models;

[SalaryRange]
public class JobApplication
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public required string Company { get; set; }
    public required string Position { get; set; }
    [Url]
    public string? JobPostingUrl { get; set; }

    public ApplicationStatus Status { get; set; } = ApplicationStatus.Applied;
    public int? ApplicationStages { get; set; } = 0;
    public DateTime AppliedDate { get; set; } = DateTime.Now;
    public DateTime? EndDate { get; set; }
	
	public int? SalaryRangeLowerBound {get;set; }
	public int? SalaryRangeUpperBound {get;set;}
    public decimal? SalaryOffer { get; set; }
}

public enum ApplicationStatus
{
    Applied,
    Interviewing,
    Offer,
    Rejected,
    Accepted
}