using _5_DapperNorthwindProject.DTOs.CategoryRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_DapperNorthwindProject.Repositories
{
    public interface ICategoryRepository
    {
        Task<List<ResultCategoryDto>> GetAllCategoryAsync();
        Task CreateCategoryDto(CreateCategoryDto createCategoryDto);
        Task UpdateCategoryDto(UpdateCategoryDto updateCategoryDto);
        Task DeleteCategoryDto(int id);
        Task<GetByIdCategoryDto> GetByIdCategoryAsync(int id);
    }
    
}
