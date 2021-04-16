using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Libraries.Core.Abstracts
{
    public interface IResult
    {
        bool Success { get; }
        string Message { get; }
    }
}