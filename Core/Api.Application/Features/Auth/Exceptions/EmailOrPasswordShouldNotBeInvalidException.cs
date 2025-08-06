using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Api.Application.Bases;

namespace Api.Application.Features.Auth.Exceptions
{
    public class EmailOrPasswordShouldNotBeInvalidException:BaseException
    {
        public EmailOrPasswordShouldNotBeInvalidException() : base("Email veya Şifre hatalı!") { }
    }
}
