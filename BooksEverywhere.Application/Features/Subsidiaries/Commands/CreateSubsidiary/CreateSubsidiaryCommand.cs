﻿using BooksEverywhere.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Application.Features.Subsidiaries.Commands.CreateSubsidiary
{
    public class CreateSubsidiaryCommand: IRequest<int>
    {
        public int LibraryId { get; set; }
    }
}
