using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Api.Application.Bases;

namespace Api.Application.Features.Products.Exceptions
{
    internal class ProductTitleMustBeUniqueException:BaseException
    {
        public ProductTitleMustBeUniqueException() : base("Ürün Başlığı Benzersiz Olmalı!") { }
    }
}
