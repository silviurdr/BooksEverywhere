using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Application.Features.Subsidiaries.Commands
{
    public class DeleteSubsidiaryCommand: IRequest
    {
        public int Id { get; set; }
    }
}
