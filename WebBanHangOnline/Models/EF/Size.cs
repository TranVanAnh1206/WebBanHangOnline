using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

namespace WebBanHangOnline.Models.EF
{
	public class Size
	{
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int ProductId { get; set; }

        public string ProdSize { get; set; }

        public int Quantity { get; set; }

        [ForeignKey(nameof(ProductId))] 
        public virtual Product Product { get; set; }

    }
}