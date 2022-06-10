/* Write your T-SQL query statement below */
select p.firstName, p.lastName, a.city, a.state 
from Person p
join Address a on a.personId = p.personId
union
select firstName, lastName, city = null, state = null 
from Person 
where personId not in (select personId from Address)