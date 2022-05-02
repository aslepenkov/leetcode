SELECT today.Id 
FROM Weather today
INNER JOIN Weather y
ON today.RecordDate = DATEADD(d, 1, y.RecordDate)
WHERE today.Temperature > y.Temperature