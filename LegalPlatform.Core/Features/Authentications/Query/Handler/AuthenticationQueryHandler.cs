using AutoMapper;
using GraduationProjectStore.Core.Feature.Authentications.Query.Request;
using GraduationProjectStore.Core.ResultHandlers;
using GraduationProjectStore.Service.Abstraction.Security;
using LegalPlatform.Infrastructure.Domain.Entity.Security;
using MediatR;

namespace GraduationProjectStore.Core.Feature.Authentications.Query.Handler
{
    public class AuthenticationQueryHandler :
        ResultHandler ,
        IRequestHandler<GetUserByUsernameQuery, Result<LegalUser>> ,
        IRequestHandler<GetAllUserQuery, Result<ICollection<LegalUser>>> 
    {
        private readonly IAuthenticationService _authenticationService;
        private readonly IMapper _mapper;
        public AuthenticationQueryHandler(IMapper mapper, IAuthenticationService authenticationService)
        {
            this._mapper = mapper;
            this._authenticationService = authenticationService;
        }

        public async Task<Result<LegalUser>> Handle
            (GetUserByUsernameQuery request, CancellationToken cancellationToken)
        {
            if(request.Username == null)
                return BadRequest<LegalUser>(_message: "Username Is Null");

            var user = await _authenticationService.GetUserByNameAsync(request.Username);
            if (user == null)
                return NotFound<LegalUser>(_message:"User Not Found");

            return OK<LegalUser>(_data:user);
        }

        public async Task<Result<ICollection<LegalUser>>> Handle
            (GetAllUserQuery request, CancellationToken cancellationToken)
        {
            var users = await _authenticationService.GetAllAsync();
            if(users == null)
                return NotFound<ICollection<LegalUser>>(_message:"App Not Has User Yet");

            return OK<ICollection<LegalUser>>(_data:users,$"App Has [{users.Count()}] User");
        }
    }
}
