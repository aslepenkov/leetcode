/* Write your T-SQL query statement below */

select s.employee_id 
from Employees e
RIGHT join Salaries s on e.employee_id  = s.employee_id 
where e.name is null

union all

select e.employee_id 
from Employees e
left join Salaries s on e.employee_id  = s.employee_id 
where s.employee_id is null
order by employee_id asc


