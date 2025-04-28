using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6.Models
{
	public class Order
	{
		public int Id { get; set; }
		public string Ticker { get; set; }
		public decimal Sum { get; set; }
		public int Quantity { get; set; }
		public DateTime TimeStamp { get; set; }
		public int Status { get; set; }
	}
}
