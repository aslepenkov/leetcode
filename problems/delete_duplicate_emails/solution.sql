/* 
 Please write a DELETE statement and DO NOT write a SELECT statement.
 Write your T-SQL query statement below
 
 
delete p1
from person p1
inner join person p2 on p1.id = p2.id
where p2.email = p1.email and p2.id > p1.id
*/

WITH cte AS (
    SELECT 
        id, 
        email,
        ROW_NUMBER() OVER (
            PARTITION BY 
                email                                 
            ORDER BY id
        ) row_num
     FROM 
        person
)
DELETE FROM cte
WHERE row_num > 1;