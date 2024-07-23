using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC.ViewModels;

namespace MVC.Controllers;

public static class PaginationController
{
    public static PaginationViewModel setPagination(int itemsCount , int page , int size)
    {
        PaginationViewModel pagination = new PaginationViewModel();


        pagination.NumberOfPages = (int)Math.Ceiling((double)itemsCount / size);
        pagination.Size = size;
        pagination.CurrentPage = page;
        pagination.NextPage = ((page + 1) > pagination.NumberOfPages) ? 1 : page + 1;
        pagination.PrevousePage = ((page - 1) <= 0) ? pagination.NumberOfPages : page - 1;
        pagination.Pages = new List<int>();
        for (int i = 1; i <= pagination.NumberOfPages; i++) { pagination.Pages.Add(i); }
        return pagination;
    }
}
