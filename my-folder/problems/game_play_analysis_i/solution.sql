/* Write your T-SQL query statement below */
SELECT player_id, first_login = MIN(event_date)
FROM Activity
GROUP BY player_id