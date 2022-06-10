select ad.actor_id,ad.director_id from ActorDirector ad
group by ad.director_id,actor_id
having count(ad.actor_id)>=3;