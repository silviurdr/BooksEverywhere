using BooksEverywhere.Application.Responses;
using BooksEverywhere.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Application.Features.Subjects.Commands.CreateSubject
{
    public class CreateSubjectCommandResponse: BaseResponse
    {
        public CreateSubjectCommandResponse(): base()
        {

        }

        public CreateSubjectDto Subject { get; set; }
    }
}
