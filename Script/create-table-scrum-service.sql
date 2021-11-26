use Scrumdb;
CREATE TABLE PeriodSprint(  
    Id int not null  AUTO_INCREMENT,
    Project varchar(255) NOT NULL  ,
    StartDate int not null ,
    EndDate int not null ,
    SprintStatus int comment '0 begin, 1 done, 2 backlog',
    CONSTRAINT PK_PeriodSprint
    PRIMARY key(Id)
) default charset utf8 comment 'period sprint';

use Scrumdb;
CREATE TABLE SprintPlanning(  
    Id int not null AUTO_INCREMENT,
    IssueKey varchar(255) not null comment'ref pKey in jiradb.jiradbIssue',
    IssueStatus varchar(60) COMMENT 'ref jiradb.issuesatus.pName',
    Assignee varchar(255) COMMENT'ref jiradb.jiraissue.Assignee',
    TimeEstimate decimal(19,0) COMMENT'ref jiradb.issue.TIMEESTIMATE',
    WorkFlow_Id decimal(19,0) COMMENT'ref jiradb.issue.WORKFLOW_ID',
    PeriodSprint_Id int not null COMMENT'ref ScrumDb.PeriodSprint.Id',
    CONSTRAINT PK_SprintPlanning
    PRIMARY key(Id)
) default charset utf8 comment 'Sprint Planning';

use Scrumdb;
CREATE TABLE SprintBackLog(  
    Id int not null AUTO_INCREMENT,
    IssueKey varchar(255) not null comment'ref pKey in jiradb.jiradbIssue',
    IssueStatus varchar(60) COMMENT 'ref jiradb.issuesatus.pName',
    Assignee varchar(255) COMMENT'ref jiradb.jiraissue.Assignee',
    TimeEstimate decimal(19,0) COMMENT'ref jiradb.issue.TIMEESTIMATE',
    WorkFlow_Id decimal(19,0) COMMENT'ref jiradb.issue.WORKFLOW_ID',
    PeriodSprint_Id int not null COMMENT'ref ScrumDb.PeriodSprint.Id',
    CONSTRAINT PK_SprintBackLog
    PRIMARY key(Id)
) default charset utf8 comment 'Sprint BackLog';

use Scrumdb;
CREATE TABLE ProductBackLog(  
    Id int not null AUTO_INCREMENT,
    IssueKey varchar(255) not null comment'ref pKey in jiradb.jiradbIssue',
    IssueStatus varchar(60) COMMENT 'ref jiradb.issuesatus.pName',
    Assignee varchar(255) COMMENT'ref jiradb.jiraissue.Assignee',
    TimeEstimate decimal(19,0) COMMENT'ref jiradb.issue.TIMEESTIMATE',
    WorkFlow_Id decimal(19,0) COMMENT'ref jiradb.issue.WORKFLOW_ID',
    PeriodSprint_Id int not null COMMENT'ref ScrumDb.PeriodSprint.Id',
    CONSTRAINT PK_ProductBackLog
    PRIMARY key(Id)
) default charset utf8 comment 'Product BackLog';

use Scrumdb;
CREATE TABLE SprintDaily(  
    Id int not null AUTO_INCREMENT,
    IssueKey varchar(255) not null comment'ref pKey in jiradb.jiradbIssue',
    IssueStatus varchar(60) COMMENT 'ref jiradb.issuesatus.pName',
    Assignee varchar(255) COMMENT'ref jiradb.jiraissue.Assignee',
    TimeEstimate decimal(19,0) COMMENT'ref jiradb.issue.TIMEESTIMATE',
    TimeBonus decimal(19,0) COMMENT'time bonus is success issue',
    ReasonIssue_Id int not null COMMENT 'ref ScrumDb.ReasonIssue.Id',
    WorkFlow_Id decimal(19,0) COMMENT'ref jiradb.issue.WORKFLOW_ID',
    PeriodSprint_Id int not null COMMENT'ref ScrumDb.PeriodSprint.Id',
    CONSTRAINT PK_SprintDaily
    PRIMARY key(Id)
) default charset utf8 comment 'Sprint Daily';

--bo xung bang nguyen nhan them thoi gian de hoan thanh issue
--SprintDaily co danh trong so anh huong...
--Sprint Review
--. Sprint Restrospective