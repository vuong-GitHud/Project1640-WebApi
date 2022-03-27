using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1640.Dto.Common
{
    public class ApiResultError <T> : ApiResult<T>
    {
        public string[] ValidationErrors { get; set; }
        public ApiResultError()
        {
        }
        public ApiResultError(string message)
        {
            IsSuccessed = false;
            Message = message;
        }
        public ApiResultError(string[] validationErrors)
        {
            IsSuccessed = false;
            ValidationErrors = validationErrors;
        }
    }
}
