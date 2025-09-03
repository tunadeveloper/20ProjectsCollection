using _5_DapperNorthwindProject.DTOs.CategoryRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_DapperNorthwindProject.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        public Task CreateCategoryDto(CreateCategoryDto createCategoryDto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteCategoryDto(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ResultCategoryDto>> GetAllCategoryAsync()
        {
            throw new NotImplementedException();
        }

        public Task<GetByIdCategoryDto> GetByIdCategoryAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateCategoryDto(UpdateCategoryDto updateCategoryDto)
        {
            throw new NotImplementedException();
        }
    }
}
