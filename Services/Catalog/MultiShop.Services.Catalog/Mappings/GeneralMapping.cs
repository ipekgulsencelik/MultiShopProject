﻿using AutoMapper;
using MultiShop.Services.Catalog.DTOs.CategoryDTOs;
using MultiShop.Services.Catalog.DTOs.ProductDetailDTOs;
using MultiShop.Services.Catalog.DTOs.ProductDTOs;
using MultiShop.Services.Catalog.DTOs.ProductImageDTOs;
using MultiShop.Services.Catalog.Entities;

namespace MultiShop.Services.Catalog.Mappings
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<Category, ResultCategoryDTO>().ReverseMap();
            CreateMap<Category, CreateCategoryDTO>().ReverseMap();
            CreateMap<Category, UpdateCategoryDTO>().ReverseMap();
            CreateMap<Category, GetByIdCategoryDTO>().ReverseMap();

            CreateMap<Product, ResultProductDTO>().ReverseMap();
            CreateMap<Product, CreateProductDTO>().ReverseMap();
            CreateMap<Product, UpdateProductDTO>().ReverseMap();
            CreateMap<Product, GetByIdProductDTO>().ReverseMap();

            CreateMap<ProductDetail, ResultProductDetailDTO>().ReverseMap();
            CreateMap<ProductDetail, CreateProductDetailDTO>().ReverseMap();
            CreateMap<ProductDetail, UpdateProductDetailDTO>().ReverseMap();
            CreateMap<ProductDetail, GetByIdProductDetailDTO>().ReverseMap();

            CreateMap<ProductImage, ResultProductImageDTO>().ReverseMap();
            CreateMap<ProductImage, CreateProductImageDTO>().ReverseMap();
            CreateMap<ProductImage, UpdateProductImageDTO>().ReverseMap();
            CreateMap<ProductImage, GetByIdProductImageDTO>().ReverseMap();
        }
    }
}