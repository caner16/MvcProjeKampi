﻿using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CategoryValidator:AbstractValidator<Category>
    {
        public CategoryValidator()
        {
             RuleFor(x=>x.CategoryName).NotEmpty().WithMessage("Kategori Adını boş geçemezsiniz"); 
             RuleFor(x=>x.CategoryDescription).NotEmpty().WithMessage("Açıklamayı Boş Geçemezsiniz");
            RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("Lütfen En AZ 3 karakter girişi yapın");
            RuleFor(x => x.CategoryName).MaximumLength(20).WithMessage("Lütfen 20 karakterden fazla değer ğirişi yapmayın");
        }
    }
}
