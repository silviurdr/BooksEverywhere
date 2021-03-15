using BooksEverywhere.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Application.Features.Subsidiaries.Queries.GetSubsidiariesList
{
    public class SubsidiariesListVm
    {
        public int Id { get; set; }
        public LibraryInfo LibraryInfo { get; set; }
        public int LibraryId { get; set; }
    }
}
