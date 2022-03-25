using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MvcCreditAppEF.Models
{
    public class Credit
    {
        public virtual int CreditId { get; set; }
        
        [Required]
        [DisplayName("Тип кредита")]
        public virtual string Head { get; set; }

        [Required]
        [DisplayName("Период")]
        public virtual int Period { get; set; }

        [Required]
        [DisplayName("Сумма")]
        public virtual int Sum { get; set; }

        [Required]
        [DisplayName("Процент")]
        public virtual int Percent { get; set; }
    }
}
