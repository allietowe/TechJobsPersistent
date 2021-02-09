--Part 1
Jobs
id: int, name: longtext, employerId: int
--Part 2
SELECT name FROM Employers WHERE location = 'St. Louis City';
--Part 3
SELECT distinct(name), description FROM skills left join jobskills on jobskills.JobId is not null  where skills.id = jobskills.SkillId order by name asc;
