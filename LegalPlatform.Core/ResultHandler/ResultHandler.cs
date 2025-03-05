using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace GraduationProjectStore.Core.ResultHandlers
{
    public class ResultHandler
    {
        public Result<T> Created<T>(object _meta = null, string _message = null)
        {
            return new Result<T>()
            {
                StatusCode = HttpStatusCode.Created,
                Message = _message ?? "Created",
                Successed = true,
                Error = null
            };
        }

        public Result<T> NotFound<T>(string _message)
        {
            return new Result<T>
            {
                StatusCode = HttpStatusCode.NotFound,
                Message = _message ?? "Not Found",
                Successed = false,
            };
        }
        public Result<T> OK<T>(T _data = null, object _meta = null, string _message = null)
            where T : class
        {
            return new Result<T>()
            {
                Data = _data,
                Successed = true,
                StatusCode = HttpStatusCode.OK,
                Message = _message ?? "Success",
                Meta = _meta

            };
        }
        public Result<T> BadRequest<T>(string _message = null)
        {
            return new Result<T>()
            {
                Message = _message ?? "Bad Request",
                Successed = false,
                StatusCode = HttpStatusCode.BadRequest,
            };
        }

        public Result<T> UnprocessableEntity<T>(string _message)
        {
            return new Result<T>()
            {
                Successed = false,
                StatusCode = HttpStatusCode.UnprocessableEntity,
            };
        }
    }
}