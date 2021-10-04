using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Shared.Utils
{
    public enum HttpType
    {
        Post,
        Get,
        Put
    }

    public enum StatusCodeEnum : int
    {
        NotFound = 404,
        BadRequest = 400,
        Ok = 200,
        Created = 201,
        NoContent = 204,
        Unauthorized = 401,
        Forbid = 403,
        Error = 500,
    }
}
