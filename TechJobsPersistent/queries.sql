--Part 1
-- 4 ways to show the same info
explain jobs;
describe jobs;
show fields from jobs;
show columns from jobs;
-- simplest way i can see to get just columns and their data types
select column_name, data_type from information_schema.columns
where table_name = 'jobs';

--Part 2
select name from employers
where location = 'st. louis city';

--Part 3
select Name, Description from skills
where id in (select skillid from jobskills)
order by Name;
