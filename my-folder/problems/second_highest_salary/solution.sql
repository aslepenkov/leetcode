select COALESCE((select DISTINCT salary from Employee
order by salary desc
offset 1 Row
fetch next 1 row only),NULL) as SecondHighestSalary