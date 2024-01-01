using EfExtensions.Items.Model;

namespace HomeManager.Data.Models.Utility;

public class MeterReading : DbItem<string>
{
	public string MeterId { get; set; }
	
	public DateOnly MeasurementDate { get; set; }
	
	
}