using BooksEverywhere.Application.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Application.Features.Subsidiaries.Commands.CreateSubsidiary
{
    public class CreateSubsidiaryCommandResponse: BaseResponse
    {
        public CreateSubsidiaryCommandResponse(): base()
        {

        }

        public CreateSubsidiaryDto Subsidiary { get; set; }
    }
}
