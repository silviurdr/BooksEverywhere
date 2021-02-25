using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Application.Features.Subsidiaries.Commands.UpdateSubsidiary
{
    public class UpdateSubsidiaryCommand: IRequest
    {
        public int Id { get; set; }
    }
}
