/* Write your T-SQL query statement below */

select 
user_id, 
name = concat(left(upper(name),1), right(lower(name),len(name)-1)) 
from users
order by user_id