using ExploreSV.BusinessLogic.DTOs;
using ExploreSV.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploreSV.BusinessLogic.UseCases.Categories.Queries.GetCategories;

public record GetCategoriesQuery() : IRequest<List<CategoryResponse>>;
