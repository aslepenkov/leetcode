SELECT 
    A.user_id 'buyer_id',
    A.join_date,
    orders_in_2019 = ISNULL(SUM(CASE WHEN YEAR(B.order_date) = '2019' THEN 1 ELSE 0 END),0) 
FROM Users A
LEFT JOIN Orders B
ON A.user_id = B.buyer_id
GROUP BY A.user_id, A.join_date