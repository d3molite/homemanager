using EfExtensions.Items.Model;
using HomeManager.Data.Enum;

namespace HomeManager.Data.Models.Utility;

public class Meter : DbItem<string>
{
	public string HouseholdId { get; set; }
	
	public MeterType MeterType { get; set; }
	
}