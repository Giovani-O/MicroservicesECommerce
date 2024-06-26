﻿using AutoMapper;
using MicroservicesECommerce.ProductApi.DTOs;
using MicroservicesECommerce.ProductApi.Models;
using MicroservicesECommerce.ProductApi.Repositories;

namespace MicroservicesECommerce.ProductApi.Services;

public class CategoryService : ICategoryService
{
    private readonly ICategoryRepository _categoryRepository;
    private readonly IMapper _mapper;

    public CategoryService(ICategoryRepository categoryRepository, IMapper mapper)
    {
        _categoryRepository = categoryRepository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<CategoryDTO>> GetCategories()
    {
        var categoriesEntity = await _categoryRepository.GetAll();
        return _mapper.Map<IEnumerable<CategoryDTO>>(categoriesEntity);
    }

    public async Task<IEnumerable<CategoryDTO>> GetCategoriesProducts()
    {
        var categoriesEntity = await _categoryRepository.GetCategoriesProducts();
        return _mapper.Map<IEnumerable<CategoryDTO>>(categoriesEntity);
    }

    public async Task<CategoryDTO> GetCategoryById(int id)
    {
        var categoryEntity = await _categoryRepository.GetById(id);
        return _mapper.Map<CategoryDTO>(categoryEntity);
    }

    public async Task AddCategory(CategoryDTO categoryDTO)
    {
        var categoryEntity = _mapper.Map<Category>(categoryDTO);
        await _categoryRepository.Create(categoryEntity);
        categoryDTO.CategoryId = categoryEntity.CategoryId;
    }

    public async Task UpdateCategory(CategoryDTO categoryDTO)
    {
        var categoryEntity = _mapper.Map<Category>(categoryDTO);
        await _categoryRepository.Update(categoryEntity);
    }

    public async Task RemoveCategory(int id)
    {
        var categoryEntity = _categoryRepository.GetById(id);
        await _categoryRepository.Delete(categoryEntity.Id);
    }
}
