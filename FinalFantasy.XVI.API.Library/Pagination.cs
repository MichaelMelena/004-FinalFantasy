namespace FinalFantasy.XIV.API.Models;

public class Pagination
{
	public int Page { get; set; }

	public int? PageNext { get; set; }

	public int? PagePrev { get; set; }

	public int PageTotal { get; set; }

	public int ResultsPerPage { get; set; }

	public int ResultsTotal { get; set; }

}
