using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MvcCreditAppEF.Models
{
    public class Bid
    {
        public virtual int BidId { get; set; }

        [Required]
        [DisplayName("Имя заявителя")]
        public virtual string Name { get; set; }

        [Required]
        [DisplayName("Название кредита")]
        public virtual string CreditHead { get; set; }

        [DisplayName("Дата подачи заявки")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "s{0:dd/MM/yy}")]
        public virtual DateTime BidDate { get; set; }
    }
}
