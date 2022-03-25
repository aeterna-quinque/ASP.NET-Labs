using MvcCreditAppEF.Models;
using System.Linq;

namespace MvcCreditAppEF.Data
{
    public class CreditsDbInitializer
    {
        public static void Initialize(CreditContext context)
        {
            if (!context.Credits.Any())
            {
                context.Credits.AddRange(
                    new Credit
                    {
                        Head = "Ипотечный кредит",
                        Period = 10,
                        Sum = 1000000,
                        Percent = 15
                    },
                    new Credit
                    {
                        Head = "Образовательный кредит",
                        Period = 7,
                        Sum = 300000,
                        Percent = 10
                    },
                    new Credit
                    {
                        Head = "Потребительский кредит",
                        Period = 5,
                        Sum = 500000,
                        Percent = 19
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
