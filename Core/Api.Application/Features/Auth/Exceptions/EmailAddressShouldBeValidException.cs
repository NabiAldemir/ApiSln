using Api.Application.Bases;

namespace Api.Application.Features.Auth.Exceptions
{
    public class EmailAddressShouldBeValidException : BaseException
    {
        public EmailAddressShouldBeValidException() : base("Email Adresi Mevcut Değil!") { }
    }
}
