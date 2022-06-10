/* Write your T-SQL query statement below */
select user_id, last_stamp = MAX(time_stamp)
from Logins
where YEAR(time_stamp) = 2020
group by user_id
