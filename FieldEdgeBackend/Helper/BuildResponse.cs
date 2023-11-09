using FieldEdgeBackend.Model;
using System.Net;

namespace FieldEdgeBackend.Helper
{
    public class BuildResponse
    {

        public static Response DoThis(object data, string msg,HttpStatusCode statusCode)
        {
            return new Response{ StatusCode= statusCode,StatusMessage= msg,Data =data };

        }
    }
}
