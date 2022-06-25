using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace Application.Services.Queries.GetCategories
{
    public class GetCategoriesQuery : IRequest<List<GetCategoriesViewModel>>
    {
        //Trigger do GetCategoriesQueryHandler                
    }
}