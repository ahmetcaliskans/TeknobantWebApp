﻿using Core.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            /*UserName*/
            RuleFor(u => u.UserName).NotEmpty().WithMessage("Kullanıcı Kodu Boş Olamaz !");
            RuleFor(u => u.UserName).MinimumLength(3).WithMessage("Kullanıcı Kodu En Az {MinLength} Karakter Olmalı !");
            RuleFor(u => u.UserName).MaximumLength(30).WithMessage("Kullanıcı Kodu En Fazla {MaxLength} Karakter Olmalı !");

            /*FirstName*/
            RuleFor(u => u.FirstName).NotEmpty().WithMessage("Kullanıcı Adı Boş Olamaz !");
            RuleFor(u => u.FirstName).MinimumLength(2).WithMessage("Kullanıcı Adı En Az {MinLength} Karakter Olmalı !");
            RuleFor(u => u.FirstName).MaximumLength(70).WithMessage("Kullanıcı Adı En Fazla {MaxLength} Karakter Olmalı !");

            /*LastName*/
            RuleFor(u => u.LastName).MaximumLength(100).WithMessage("Kullanıcı Adı En Fazla {MaxLength} Karakter Olmalı !");

            /*Title*/
            RuleFor(u => u.Title).MaximumLength(150).WithMessage("Kullanıcı Ünvanı En Fazla {MaxLength} Karakter Olmalı !");

        }
    }
}
