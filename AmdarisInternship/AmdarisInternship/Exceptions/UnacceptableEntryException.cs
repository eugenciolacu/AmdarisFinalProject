using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace AmdarisInternship.API.Exceptions
{
    public class UnacceptableEntryException : ApiException
    {
        public UnacceptableEntryException(string message) : base(HttpStatusCode.NotFound, message)
        {
        }
    }
}
