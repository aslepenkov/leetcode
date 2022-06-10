/* Write your T-SQL query statement below */
select u.name, travelled_distance = ISNULL (sum(r.distance),0)
from users u
left join rides r on u.id = r.user_id
group by u.name
order by 2 desc, 1