using Library.Application.ViewModel;
using Library.Core.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.Queries
{
    public class GetAllBooksQuery : IRequest<ResultViewModel<List<Book>>>
    {
    }
}
