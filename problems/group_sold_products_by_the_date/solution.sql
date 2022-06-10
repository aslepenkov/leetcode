/* Write your T-SQL query statement below */


 select 
    sell_date,
    num_sold = count(*),   
    products = STRING_AGG(product, ',') WITHIN GROUP (ORDER BY product)
    from (select distinct * from activities) a
    group by sell_date