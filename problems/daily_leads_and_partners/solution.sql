/* Write your T-SQL query statement below */
select date_id, make_name, unique_leads = count (distinct lead_id ),  unique_partners = count (distinct partner_id )
from DailySales
group by make_name, date_id
