using System.Net;
using System.Xml;

namespace FieldEdgeBackend.Model
{
    public class Response
    {

        public HttpStatusCode StatusCode { get; set; }

        public string StatusMessage { get; set; }

        public object Data { get; set; }
    }
}
