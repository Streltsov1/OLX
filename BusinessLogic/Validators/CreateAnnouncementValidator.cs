﻿using BusinessLogic.DTOs;
using FluentValidation;


namespace BusinessLogic.Validators
{
    public class CreateAnnouncementValidator : AbstractValidator<CreateAnnouncementModel>
    {
        public CreateAnnouncementValidator()
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
