/* Write your T-SQL query statement below */
select id = author_id
from Views
where author_id = viewer_id
group by author_id, viewer_id
having count(*) >= 1 
order by author_id asc