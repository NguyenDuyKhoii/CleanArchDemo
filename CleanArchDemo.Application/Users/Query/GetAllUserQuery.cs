using CleanArchDemo.Application.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchDemo.Application.Users.Query
{
    public class GetAllUserQuery : IRequest<List<UserDTO>>
    {
    }
}
