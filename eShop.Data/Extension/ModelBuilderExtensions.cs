using eShop.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Data.Extension
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            //data seeding
            modelBuilder.Entity<AppConfig>().HasData(
                new AppConfig() { Key = "HomeTitle", Value = "This is home page of eShop" },
                 new AppConfig() { Key = "HomeKeyword", Value = "This is keyword of eShop" },
                  new AppConfig() { Key = "HomeDescription", Value = "This is description of eShop" }
                );

            modelBuilder.Entity<Language>().HasData(
                new Language() { Id = "vi-VN", Name = "Tiếng Việt" },
                new Language() { Id = "en-US", Name = "English" }
                );

            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id = 1,
                    IsshowOnHome = true,
                    ParentId = null,
                    SortOrder = 1,
                    Status = Enum.Status.Active,

                },
                 new Category()
                 {
                     Id = 2,
                     IsshowOnHome = true,
                     ParentId = null,
                     SortOrder = 2,
                     Status = Enum.Status.Active,

                 }
                );

            modelBuilder.Entity<CategoryTranslation>().HasData(
                        new CategoryTranslation() { Id = 1, CategoryId = 1, Name = "Áo Nam", LanguageId = "vi-VN", SeoAlias = "ao-nam", SeoDescription = "Sản phẩm thời trang áo nam", SeoTitle = "Sản phẩm thời trang áo nam" },
                        new CategoryTranslation() { Id = 2, CategoryId = 1, Name = "Men Shirt", LanguageId = "en-US", SeoAlias = "men-shirt", SeoDescription = "The shirts for men", SeoTitle = "The shirts for men" },
                        new CategoryTranslation() { Id = 3, CategoryId = 2, Name = "Áo Nữ", LanguageId = "vi-VN", SeoAlias = "ao-nu", SeoDescription = "Sản phẩm thời trang áo nữ", SeoTitle = "Sản phẩm thời trang áo nữ" },
                        new CategoryTranslation() { Id = 4, CategoryId = 2, Name = "Women Shirt", LanguageId = "en-US", SeoAlias = "women-shirt", SeoDescription = "The shirts for women", SeoTitle = "The shirts for women" }
                );

            modelBuilder.Entity<Product>().HasData(
               new Product()
               {
                   Id=1,
                   DateCreate = DateTime.Now,
                   OriginalPrice = 100000,
                   Price = 200000,
                   Stock = 0,
                   ViewCount = 0,
                 
               }

               );

            modelBuilder.Entity<ProductTranslation>().HasData(
                        new ProductTranslation() {Id=1,ProductId=1, Name = "Áo Nam", LanguageId = "vi-VN", SeoAlias = "ao-nam", SeoDescription = "Sản phẩm thời trang áo nam", SeoTitle = "Sản phẩm thời trang áo nam", Details = "Mô tả sản phẩm", Description = "" }
                );

            modelBuilder.Entity<ProductInCategory>().HasData(
                new ProductInCategory() { CategoryId = 1, ProductId = 1 }
                ) ;
        }
    }
}
