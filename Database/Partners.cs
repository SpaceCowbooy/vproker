using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace vproker.Models
{
	[Table(nameof(Partners))]
	public partial class Partners
	{
		public string ID { get; set; }

		[Required(ErrorMessage = "������� ������������ ��������")]
		[Display(Name = "������������")]
		public string Name { get; set; }

		[Required(ErrorMessage = "������� ������ ������")]
		[Display(Name = "����������� ������")]
		public float Discount { get; set; }
		public Partners()
		{
			ID = Guid.NewGuid().ToString();
		}

		public Partners(string name, float discount)
		{
			ID = Guid.NewGuid().ToString();
			Name = name;
			Discount = discount;
		}
	}
}
