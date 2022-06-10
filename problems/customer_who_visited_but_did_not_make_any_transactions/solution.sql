/* Write your T-SQL query statement below */
SELECT 
	v.customer_id, 
	count_no_trans = COUNT(*)
FROM visits v 
LEFT JOIN transactions AS t ON v.visit_id = t.visit_id 
WHERE t.transaction_id IS NULL
GROUP BY v.customer_id