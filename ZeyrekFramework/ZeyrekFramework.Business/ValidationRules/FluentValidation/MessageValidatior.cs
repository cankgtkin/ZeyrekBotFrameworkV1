using FluentValidation;
using ZeyrekFramework.Entities.Concrete;

namespace ZeyrekFramework.Business.ValidationRules.FluentValidation
{
    public class MessageValidatior : AbstractValidator<Message>
    {
        public MessageValidatior()
        {
            //RuleFor(p => p.Id).NotEmpty();
            //RuleFor(p => p.CreateTime).NotEmpty();
            //RuleFor(p => p.ReferenceId).GreaterThan(0);
            //RuleFor(p => p.ReferenceTypeId).NotEmpty();
            //RuleFor(p => p.Sender).Length(2, 20);
            //RuleFor(p => p.SenderType).GreaterThan(20).When(p => p.CategoryId == 1);
            // RuleFor(p => p.ProductName).Must(StartWithA);
        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
