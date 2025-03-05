using System.Net;

namespace GraduationProjectStore.Core.ResultHandlers
{
    public class Result<T>
    {
        public T Data { set; get; }
        public object Meta { set; get; }
        public string Message { set; get; }
        public bool Successed { set; get; }
        public List<string> Error { set; get; }
        public HttpStatusCode StatusCode { set; get; }

        public Result() { }
        public Result(string _message)
        {
            this.Message = _message;
            this.Successed = false;
        }

        public Result(T data, string _message)
        {
            this.Data = data;
            this.Message = _message;
        }

        public Result(T data, string _message, object _meta)
        {
            this.Meta = _meta;
            this.Data = data;
            this.Message = _message;
        }
    }
}
