namespace RutaLimpiaBackend.Core.Application.Wrappers
{
    public class Response<T> //api standarized responses
    {
        public bool Succeeded { get; set; }
        public string? Message { get; set; }
        public List<string>? Errors { get; set; }
        public T? Data { get; set; }

        public Response() { }

        // successfull response
        public Response(T data, string? message = null)
        {
            Succeeded = true;
            Message = message;
            Data = data;
        }

        // failed response
        public Response(string message)
        {
            Succeeded = false;
            Message = message;
        }
    }
}
