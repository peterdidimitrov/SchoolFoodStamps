using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMealVouchers.Data.Models
{
    public class VoucherParent
    {
        [ForeignKey(nameof(Parent))]
        public Guid ParentId { get; set; }
        public Parent Parent { get; set; } = null!;

        [ForeignKey(nameof(Voucher))]
        public Guid VoucherId { get; set; }
        public Voucher Voucher { get; set; } = null!;
    }
}
