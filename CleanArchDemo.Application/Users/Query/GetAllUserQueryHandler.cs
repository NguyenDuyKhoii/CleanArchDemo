using AutoMapper;
using CleanArchDemo.Application.DTOs;
using CleanArchDemo.Application.Interface;
using MediatR;

namespace CleanArchDemo.Application.Users.Query
{
    public class GetAllUserQueryHandler : IRequestHandler<GetAllUserQuery, List<UserDTO>>
    {
        private readonly IRepository _repository;
        private readonly IMapper _mapper;

        public GetAllUserQueryHandler(IRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<UserDTO>> Handle(GetAllUserQuery request, CancellationToken cancellationToken)
        {
            var users = await _repository.GetAllUser(); 
            return _mapper.Map<List<UserDTO>>(users);
        }
    }
}
