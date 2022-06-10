
SELECT DISTINCT p.product_id, p.product_name
FROM Sales s
JOIN Product p ON s.product_id = p.product_id
WHERE sale_date >= '20190101' 
    and sale_date < '20190401'
    and s.product_id NOT iN 
        (SELECT product_id 
         From Sales 
         where sale_date NOT BETWEEN '20190101' and '20190401' )