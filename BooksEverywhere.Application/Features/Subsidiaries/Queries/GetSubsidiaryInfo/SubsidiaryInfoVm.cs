using BooksEverywhere.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Application.Features.Subsidiaries.Queries.GetSubsidiaryInfo
{
    public class SubsidiaryInfoVm
    {
        public int Id { get; set; }
        public LibraryInfo LibraryInfo { get; set; }
    }
}
