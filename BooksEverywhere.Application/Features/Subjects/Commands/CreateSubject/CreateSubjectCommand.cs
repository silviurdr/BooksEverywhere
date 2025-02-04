﻿using BooksEverywhere.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Application.Features.Subjects.Commands.CreateSubject
{
    public class CreateSubjectCommand: IRequest<int>
    {
        public string Name { get; set; }
    }
}
