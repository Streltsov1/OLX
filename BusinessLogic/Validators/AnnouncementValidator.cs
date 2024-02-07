using DataAccess.Data.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Validators
{
    public class AnnouncementValidator : AbstractValidator<Announcement>
    {
        public AnnouncementValidator()
        {
           RuleFor(x => x.Price)
                .NotEmpty()
                .GreaterThanOrEqualTo(0);

            RuleFor(x => x.Description)
                .Length(10, 4000);

            RuleFor(x => x.Title)
                .NotEmpty()
                .MinimumLength(2)
                .Matches(@"[A-Z].*").WithMessage("{PropertyName} must starts with uppercase letter.");

            RuleFor(x => x.CategoryId)
                .NotEmpty();

            RuleFor(x => x.CityId)
                .NotEmpty();
            RuleFor(x => x.SellerName)
                .NotEmpty();
        }
    }
}
