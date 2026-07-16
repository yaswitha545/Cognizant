-- Create database
CREATE DATABASE RankingDB;

-- Select database
USE RankingDB;


-- Create Products table
CREATE TABLE Products (
    ProductID INT PRIMARY KEY,
    ProductName VARCHAR(50),
    Category VARCHAR(50),
    Price DECIMAL(10,2)
);


-- Insert data
INSERT INTO Products VALUES
(1, 'Laptop', 'Electronics', 80000),
(2, 'Mobile', 'Electronics', 50000),
(3, 'Tablet', 'Electronics', 50000),
(4, 'Headphones', 'Electronics', 5000),
(5, 'TV', 'Electronics', 70000),

(6, 'Shirt', 'Clothing', 2000),
(7, 'Jacket', 'Clothing', 5000),
(8, 'Jeans', 'Clothing', 3000),
(9, 'Shoes', 'Clothing', 5000),
(10, 'Cap', 'Clothing', 1000),

(11, 'Sofa', 'Furniture', 40000),
(12, 'Chair', 'Furniture', 10000),
(13, 'Table', 'Furniture', 15000),
(14, 'Bed', 'Furniture', 40000),
(15, 'Cupboard', 'Furniture', 25000);


-- ROW_NUMBER(), RANK(), DENSE_RANK()
SELECT 
    ProductName,
    Category,
    Price,

    ROW_NUMBER() OVER(
        PARTITION BY Category 
        ORDER BY Price DESC
    ) AS Row_Number_Rank,

    RANK() OVER(
        PARTITION BY Category 
        ORDER BY Price DESC
    ) AS Rank_Value,

    DENSE_RANK() OVER(
        PARTITION BY Category 
        ORDER BY Price DESC
    ) AS Dense_Rank_Value

FROM Products;


-- Top 3 expensive products in each category
SELECT *
FROM
(
    SELECT 
        ProductName,
        Category,
        Price,
        DENSE_RANK() OVER(
            PARTITION BY Category
            ORDER BY Price DESC
        ) AS PriceRank
    FROM Products
) AS RankedProducts
WHERE PriceRank <= 3;
