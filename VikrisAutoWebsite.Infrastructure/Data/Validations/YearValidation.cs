using System.ComponentModel.DataAnnotations;

namespace VikrisAutoWebsite.Infrastructure.Validations
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    public class YearValidation : RangeAttribute
    {
        public YearValidation(int minimum) : base(minimum, DateTime.Now.Year)
        {
        }
    }
}
