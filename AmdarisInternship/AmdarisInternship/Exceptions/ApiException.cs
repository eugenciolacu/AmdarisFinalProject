﻿using System;
using System.Net;

namespace AmdarisInternship.API.Exceptions
{
    public class ApiException : Exception
    {
        public HttpStatusCode Code { get; }

        public ApiException(HttpStatusCode code, string message) : base (message)
        {
            Code = code;
        }
    }
}
