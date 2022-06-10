/* Write your T-SQL query statement below */

select 
product_id, 
store, 
price
from (
    select product_id, 'store1' as store, price = store1 from products
    union 
    select product_id, 'store2' as store, price = store2 from products
    union 
    select product_id, 'store3' as store, price = store3 from products    
) p
where price is not null



