select 
u.name,
balance = sum(amount)
from users u 
right join transactions t on u.account = t.account
group by name
having sum(amount) > 10000