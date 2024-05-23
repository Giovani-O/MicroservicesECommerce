using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MicroservicesECommerce.ProductApi.Migrations
{
    public partial class SeedProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Products (Name, Price, Description, Stock, ImageUrl, CategoryId) VALUES ('Macbook Air M3', 8999.99, 'Macbook com chip M3', 200, 'macbookm3.jpg', 1)");
            migrationBuilder.Sql("INSERT INTO Products (Name, Price, Description, Stock, ImageUrl, CategoryId) VALUES ('iPhone 14 Pro', 7599.99, 'iPhone 14 Pro com 128GB', 150, 'iphone14pro.jpg', 1)");
            migrationBuilder.Sql("INSERT INTO Products (Name, Price, Description, Stock, ImageUrl, CategoryId) VALUES ('Apple Watch Series 8', 2999.99, 'Apple Watch Series 8', 300, 'applewatchs8.jpg', 2)");
            migrationBuilder.Sql("INSERT INTO Products (Name, Price, Description, Stock, ImageUrl, CategoryId) VALUES ('Samsung Galaxy S22', 6999.99, 'Samsung Galaxy S22 com 128GB', 120, 'galaxys22.jpg', 1)");
            migrationBuilder.Sql("INSERT INTO Products (Name, Price, Description, Stock, ImageUrl, CategoryId) VALUES ('Google Pixel 6', 5999.99, 'Google Pixel 6 com 128GB', 100, 'pixel6.jpg', 1)");
            migrationBuilder.Sql("INSERT INTO Products (Name, Price, Description, Stock, ImageUrl, CategoryId) VALUES ('Microsoft Surface Pro 7', 4999.99, 'Microsoft Surface Pro 7', 50, 'surfacepro7.jpg', 1)");
            migrationBuilder.Sql("INSERT INTO Products (Name, Price, Description, Stock, ImageUrl, CategoryId) VALUES ('Sony WH-1000XM4', 1499.99, 'Headphones Sony WH-1000XM4', 200, 'sonywh1000xm4.jpg', 2)");
            migrationBuilder.Sql("INSERT INTO Products (Name, Price, Description, Stock, ImageUrl, CategoryId) VALUES ('Amazon Echo Dot', 399.99, 'Amazon Echo Dot 4ª geração', 500, 'echodot4.jpg', 1)");
            migrationBuilder.Sql("INSERT INTO Products (Name, Price, Description, Stock, ImageUrl, CategoryId) VALUES ('iPad Pro 11', 8299.99, 'iPad Pro 11 polegadas', 80, 'ipadpro11.jpg', 1)");
            migrationBuilder.Sql("INSERT INTO Products (Name, Price, Description, Stock, ImageUrl, CategoryId) VALUES ('Fitbit Charge 5', 999.99, 'Fitbit Charge 5', 250, 'fitbitcharge5.jpg', 2)");
            migrationBuilder.Sql("INSERT INTO Products (Name, Price, Description, Stock, ImageUrl, CategoryId) VALUES ('Dell XPS 13', 9799.99, 'Dell XPS 13', 60, 'dellxps13.jpg', 1)");
            migrationBuilder.Sql("INSERT INTO Products (Name, Price, Description, Stock, ImageUrl, CategoryId) VALUES ('Oculus Quest 2', 2999.99, 'Oculus Quest 2', 150, 'oculusquest2.jpg', 1)");
            migrationBuilder.Sql("INSERT INTO Products (Name, Price, Description, Stock, ImageUrl, CategoryId) VALUES ('Garmin Forerunner 945', 3299.99, 'Garmin Forerunner 945', 180, 'garminforerunner945.jpg', 2)");
            migrationBuilder.Sql("INSERT INTO Products (Name, Price, Description, Stock, ImageUrl, CategoryId) VALUES ('HP Spectre x360', 8499.99, 'HP Spectre x360', 70, 'hpspectrex360.jpg', 1)");
            migrationBuilder.Sql("INSERT INTO Products (Name, Price, Description, Stock, ImageUrl, CategoryId) VALUES ('Sony Alpha a7 III', 12499.99, 'Câmera Sony Alpha a7 III', 30, 'sonya7iii.jpg', 1)");
            migrationBuilder.Sql("INSERT INTO Products (Name, Price, Description, Stock, ImageUrl, CategoryId) VALUES ('JBL Flip 6', 599.99, 'Caixa de som JBL Flip 6', 400, 'jblflip6.jpg', 1)");
            migrationBuilder.Sql("INSERT INTO Products (Name, Price, Description, Stock, ImageUrl, CategoryId) VALUES ('Apple AirPods Pro', 2199.99, 'Apple AirPods Pro', 300, 'airpodspro.jpg', 2)");
            migrationBuilder.Sql("INSERT INTO Products (Name, Price, Description, Stock, ImageUrl, CategoryId) VALUES ('Lenovo ThinkPad X1 Carbon', 10999.99, 'Lenovo ThinkPad X1 Carbon', 45, 'thinkpadx1carbon.jpg', 1)");
            migrationBuilder.Sql("INSERT INTO Products (Name, Price, Description, Stock, ImageUrl, CategoryId) VALUES ('GoPro HERO10', 4299.99, 'GoPro HERO10', 90, 'goprohero10.jpg', 1)");
            migrationBuilder.Sql("INSERT INTO Products (Name, Price, Description, Stock, ImageUrl, CategoryId) VALUES ('Samsung Galaxy Watch 4', 1999.99, 'Samsung Galaxy Watch 4', 220, 'galaxywatch4.jpg', 2)");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Products");
        }
    }
}
