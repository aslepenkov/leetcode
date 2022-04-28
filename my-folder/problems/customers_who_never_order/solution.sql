/* Write your T-SQL query statement below */
select Customers = c.name
from customers c
left join orders o on o.customerId = c.id
where o.id is null