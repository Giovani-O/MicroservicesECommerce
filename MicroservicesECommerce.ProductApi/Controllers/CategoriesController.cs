﻿using MicroservicesECommerce.ProductApi.DTOs;
using MicroservicesECommerce.ProductApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MicroservicesECommerce.ProductApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CategoriesController : ControllerBase
{
    private readonly ICategoryService _categoryService;

    public CategoriesController(ICategoryService categoryService)
    {
        _categoryService = categoryService;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<CategoryDTO>>> Get()
    {
        var categoriesDto = await _categoryService.GetCategories();

        if (categoriesDto is null) 
            return NotFound("Categorias não encontradas");

        return Ok(categoriesDto);
    }

    [HttpGet("GetCategoriesProducts")]
    public async Task<ActionResult<IEnumerable<CategoryDTO>>> GetCategoriesProducts()
    {
        var categoriesDto = await _categoryService.GetCategoriesProducts();

        if (categoriesDto is null)
            return NotFound("Categorias não encontradas");

        return Ok(categoriesDto);
    }

    [HttpGet("{id:int}", Name = "GetCategory")]
    public async Task<ActionResult<CategoryDTO>> Get(int id)
    {
        var categoryDto = await _categoryService.GetCategoryById(id);
        if (categoryDto is null)
            return NotFound("Categoria não encontrada");

        return Ok(categoryDto);
    }

    [HttpPost]
    public async Task<ActionResult> Post([FromBody] CategoryDTO categoryDto)
    {
        if (categoryDto is null)
            return BadRequest("Dados inválidos");

        await _categoryService.AddCategory(categoryDto);

        return new CreatedAtRouteResult("GetCategory", new { id = categoryDto.CategoryId }, categoryDto);
    }

    [HttpPut("{id:int}")]
    public async Task<ActionResult> Put(int id, [FromBody] CategoryDTO categoryDto)
    {
        if (id != categoryDto.CategoryId)
            return BadRequest();

        if (categoryDto is null)
            return BadRequest();

        await _categoryService.UpdateCategory(categoryDto);

        return Ok(categoryDto);
    }

    [HttpDelete("{id:int}")]
    public async Task<ActionResult> Delete(int id)
    {
        var categoryDto = await _categoryService.GetCategoryById(id);
        if (categoryDto is null)
            return NotFound("Categoria não encontrada");

        await _categoryService.RemoveCategory(id);

        return Ok(categoryDto);
    }
}
