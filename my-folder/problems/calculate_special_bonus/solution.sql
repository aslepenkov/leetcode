/* Write your T-SQL query statement below */
select employee_id, 
bonus = case
when employee_id % 2 != 0 and name not like 'M%' then salary 
else 0
end
from Employees

