using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraduationProjecrStore.Infrastructure.Domain.DTOs.Authentication;
using GraduationProjectStore.Core.ResultHandlers;
using MediatR;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GraduationProjectStore.Core.Feature.Authentications.Command.Request
{
    public class RegisterUserCommand : IRequest<Result<object>>
    {
        public RegisterUserCommand(RegisterDTO registerDTO)
        {
            this.RegisterDTO = registerDTO;
        }

        public RegisterDTO RegisterDTO { get; }
    }
}