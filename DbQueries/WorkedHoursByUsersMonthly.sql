--users contributed most on bugs this month
select u.Username, sum(t.CurrentWorktime) Worked from Users u
join Tickets t on u.ID = t.Assignee_ID
where t.ModifiedOn between N'2016-12-01' and N'2017-01-01'
group by u.Username,t.CurrentWorkTime
order by sum(t.CurrentWorkTime)


--Users that worked on most bugs in this month
select u.Username, count(*) [Count] from Users u
join Tickets t on u.ID = t.Assignee_ID
where t.ModifiedOn between N'2016-12-01' and N'2017-01-01'
and t.Type = 0
group by u.Username
order by count(*)


--Created tickets by user
select u.Username, count(*) [Count]  from Users u
join Tickets t on u.ID = t.Assigner_ID
where t.CreatedOn between N'2016-12-01' and N'2017-01-01'
group by u.Username
order by count(*)

--contribution to project by user
declare @userID int
set @userId = 1232
select u.Username, p.Name, sum(tick.CurrentWorkTime) SpentTime from Users u 
join TeamUsers tu on u.ID = tu.User_ID
join Teams t on t.ID = tu.Team_ID
join ProjectTeams pt on pt.Team_ID = t.ID	
join Projects p on pt.Project_ID = p.ID
join Tickets tick on tick.Project_ID = p.ID
where u.ID = @userID
and t.ModifiedOn between N'2016-12-01' and N'2017-01-01'
group by u.Username, p.Name, tick.CurrentWorkTime


