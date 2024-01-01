using EfExtensions.Items.Model;

namespace HomeManager.Data.Models.General;

public class Household : DbItem<string>
{
	public string Name { get; set; }
	
	public string Address { get; set; }
	
	
}