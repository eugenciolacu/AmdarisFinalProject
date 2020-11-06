using System.Net;

namespace AmdarisInternship.API.Exceptions
{
    public class EntryAlreadyExistsException : ApiException
    {
        public EntryAlreadyExistsException(string message) : base(HttpStatusCode.BadRequest, message)
        {
        }
    }
}
