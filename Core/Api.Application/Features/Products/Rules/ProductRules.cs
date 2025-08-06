using Api.Application.Bases;
using Api.Application.Features.Products.Exceptions;
using Api.Domain.Entities;

namespace Api.Application.Features.Products.Rules
{
    public class ProductRules:BaseRules
    {
        public Task ProductTitleMustBeUnique(IList<Product> products,string requestTitle)
        {
            if(products.Any(x=>x.Title == requestTitle)) throw new ProductTitleMustBeUniqueException();
            return Task.CompletedTask;
        }
    }
}
