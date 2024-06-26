﻿using MicroservicesECommerce.ProductApi.DTOs;
using MicroservicesECommerce.ProductApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace MicroservicesECommerce.ProductApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductsController : ControllerBase
{
    private readonly IProductService _productService;

    public ProductsController(IProductService productService)
    {
        _productService = productService;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<ProductDTO>>> Get()
    {
        var productsDto = await _productService.GetProducts();

        if (productsDto is null)
            return NotFound("Produtos não encontrados");

        return Ok(productsDto);
    }

    [HttpGet("{id:int}", Name = "GetProduct")]
    public async Task<ActionResult<ProductDTO>> Get(int id)
    {
        var productDto = await _productService.GetProductById(id);
        if (productDto is null)
            return NotFound("Produto não encontrado");

        return Ok(productDto);
    }

    [HttpPost]
    public async Task<ActionResult> Post([FromBody] ProductDTO productDto)
    {
        if (productDto is null)
            return BadRequest("Dados inválidos");

        await _productService.AddProduct(productDto);

        return new CreatedAtRouteResult("GetProduct", new { id = productDto.Id }, productDto);
    }

    [HttpPut]
    public async Task<ActionResult> Put([FromBody] ProductDTO productDto)
    {

        if (productDto is null)
            return BadRequest();

        await _productService.UpdateProduct(productDto);

        return Ok(productDto);
    }

    [HttpDelete("{id:int}")]
    public async Task<ActionResult> Delete(int id)
    {
        var productDto = await _productService.GetProductById(id);
        if (productDto is null)
            return NotFound("Produto não encontrado");

        await _productService.RemoveProduct(id);

        return Ok(productDto);
    }
}
