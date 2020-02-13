DROP TABLE IF EXISTS [wage],[wage_range],[salary],[salary_range],[hierarchy],
                     [employee_performance_factors],[employee_performance_review], 
                     [merit_guidelines], [employee_performance_projection],
                     [performance_factors], [performance_rating], 
                     [employee_contact], [employee_current_position], 
                     [employee_position], [department],[employee];


-- ************************************** [employee]

CREATE TABLE [employee]
(
    [emp_id] varchar(50) NOT NULL ,
    [fname] varchar(50) NOT NULL ,
    [lname] varchar(50) NOT NULL ,


    CONSTRAINT [PK_employee] PRIMARY KEY CLUSTERED ([emp_id] ASC)
);
GO


-- ************************************** [department]

CREATE TABLE [department]
(
    [dep_id] varchar(50) NOT NULL ,
    [dep_name] varchar(50) NOT NULL ,


    CONSTRAINT [PK_department] PRIMARY KEY CLUSTERED ([dep_id] ASC)
);
GO



-- ************************************** [employee_position]

CREATE TABLE [employee_position]
(
    [pos_id] varchar(50) NOT NULL ,
    [pos_title] varchar(50) NOT NULL ,
    [pos_level] int NULL ,
    [pos_desc] varchar(50) NOT NULL ,


    CONSTRAINT [PK_employee_position] PRIMARY KEY CLUSTERED ([pos_id] ASC)
);
GO


-- ************************************** [employee_current_position]

CREATE TABLE [employee_current_position]
(
    [curr_pos_id] varchar(50) NOT NULL ,
    [emp_id] varchar(50) NOT NULL ,
    [pos_id] varchar(50) NOT NULL ,
    [emp_date] date NOT NULL ,
    [dep_id] varchar(50) NOT NULL ,


    CONSTRAINT [PK_employee_current_position] PRIMARY KEY CLUSTERED ([curr_pos_id] ASC),
    CONSTRAINT [FK_176] FOREIGN KEY ([dep_id])  REFERENCES [department]([dep_id]),
    CONSTRAINT [FK_59] FOREIGN KEY ([emp_id])  REFERENCES [employee]([emp_id]),
    CONSTRAINT [FK_62] FOREIGN KEY ([pos_id])  REFERENCES [employee_position]([pos_id])
);
GO


CREATE NONCLUSTERED INDEX [fkIdx_176] ON [employee_current_position] 
 (
  [dep_id] ASC
 )

GO

CREATE NONCLUSTERED INDEX [fkIdx_59] ON [employee_current_position] 
 (
  [emp_id] ASC
 )

GO

CREATE NONCLUSTERED INDEX [fkIdx_62] ON [employee_current_position] 
 (
  [pos_id] ASC
 )

GO




-- ************************************** [employee_contact]

CREATE TABLE [employee_contact]
(
    [contact_id] int NOT NULL ,
    [street_add1] varchar(50) NOT NULL ,
    [street_add2] varchar(50) NOT NULL ,
    [zipcode] varchar(50) NOT NULL ,
    [city] varchar(50) NOT NULL ,
    [state] varchar(50) NOT NULL ,
    [country] varchar(50) NOT NULL ,
    [phone_home] varchar(50) NULL ,
    [phone_cell] varchar(50) NOT NULL ,
    [emp_id] varchar(50) NOT NULL ,


    CONSTRAINT [PK_Employee_contact] PRIMARY KEY CLUSTERED ([contact_id] ASC),
    CONSTRAINT [FK_80] FOREIGN KEY ([emp_id])  REFERENCES [employee]([emp_id])
);
GO


CREATE NONCLUSTERED INDEX [fkIdx_80] ON [employee_contact] 
 (
  [emp_id] ASC
 )

GO




-- ************************************** [performance_rating]

CREATE TABLE [performance_rating]
(
    [rating_id] varchar(50) NOT NULL ,
    [rating_name] varchar(50) NOT NULL ,
    [rating_desc] varchar(50) NOT NULL ,


    CONSTRAINT [PK_performance_rating] PRIMARY KEY CLUSTERED ([rating_id] ASC)
);
GO




-- ************************************** [performance_factors]

CREATE TABLE [performance_factors]
(
    [per_fact_id] varchar(50) NOT NULL ,
    [factor_name] varchar(50) NOT NULL ,
    [factor_dimesions] varchar(500) NOT NULL ,
    [factor_category] varchar(50) NOT NULL ,


    CONSTRAINT [PK_performance_factors] PRIMARY KEY CLUSTERED ([per_fact_id] ASC)
);
GO



-- ************************************** [employee_performance_projection]

CREATE TABLE [employee_performance_projection]
(
    [fut_pr_id] int NOT NULL ,
    [emp_id] varchar(50) NOT NULL ,
    [proj_pr_rating_id] varchar(50) NOT NULL ,
    [proj_date] date NOT NULL ,


    CONSTRAINT [PK_future_pr_schedule] PRIMARY KEY CLUSTERED ([fut_pr_id] ASC),
    CONSTRAINT [FK_100] FOREIGN KEY ([proj_pr_rating_id])  REFERENCES [performance_rating]([rating_id]),
    CONSTRAINT [FK_97] FOREIGN KEY ([emp_id])  REFERENCES [employee]([emp_id])
);
GO


CREATE NONCLUSTERED INDEX [fkIdx_100] ON [employee_performance_projection] 
 (
  [proj_pr_rating_id] ASC
 )

GO

CREATE NONCLUSTERED INDEX [fkIdx_97] ON [employee_performance_projection] 
 (
  [emp_id] ASC
 )

GO




-- ************************************** [merit_guidelines]

CREATE TABLE [merit_guidelines]
(
    [merit_id] varchar(50) NOT NULL ,
    [raise_min] decimal(18,0) NOT NULL ,
    [raise_max] decimal(18,0) NOT NULL ,
    [raise_target] decimal(18,0) NOT NULL ,


    CONSTRAINT [PK_merit_guidelines] PRIMARY KEY CLUSTERED ([merit_id] ASC)
);
GO


-- ************************************** [employee_performance_review]

CREATE TABLE [employee_performance_review]
(
    [emp_pr_id] int NOT NULL ,
    [rating_id] varchar(50) NOT NULL ,
    [pr_date] date NOT NULL ,
    [emp_id] varchar(50) NOT NULL ,
    [performance_results] varchar(500) NOT NULL ,
    [performance_feedback] varchar(500) NOT NULL ,
    [merit_id] varchar(50) NOT NULL ,


    CONSTRAINT [PK_employee_performance_review] PRIMARY KEY CLUSTERED ([emp_pr_id] ASC),
    CONSTRAINT [FK_169] FOREIGN KEY ([merit_id])  REFERENCES [merit_guidelines]([merit_id]),
    CONSTRAINT [FK_85] FOREIGN KEY ([rating_id])  REFERENCES [performance_rating]([rating_id]),
    CONSTRAINT [FK_91] FOREIGN KEY ([emp_id])  REFERENCES [employee]([emp_id])
);
GO


CREATE NONCLUSTERED INDEX [fkIdx_169] ON [employee_performance_review] 
 (
  [merit_id] ASC
 )

GO

CREATE NONCLUSTERED INDEX [fkIdx_85] ON [employee_performance_review] 
 (
  [rating_id] ASC
 )

GO

CREATE NONCLUSTERED INDEX [fkIdx_91] ON [employee_performance_review] 
 (
  [emp_id] ASC
 )

GO





-- ************************************** [employee_performance_factors]

CREATE TABLE [employee_performance_factors]
(
    [emp_pf_id] int NOT NULL ,
    [emp_pr_id] int NOT NULL ,
    [per_fact_id] varchar(50) NOT NULL ,
    [rating_id] varchar(50) NOT NULL ,


    CONSTRAINT [PK_employee_performance_factors] PRIMARY KEY CLUSTERED ([emp_pf_id] ASC),
    CONSTRAINT [FK_144] FOREIGN KEY ([emp_pr_id])  REFERENCES [employee_performance_review]([emp_pr_id]),
    CONSTRAINT [FK_154] FOREIGN KEY ([per_fact_id])  REFERENCES [performance_factors]([per_fact_id]),
    CONSTRAINT [FK_157] FOREIGN KEY ([rating_id])  REFERENCES [performance_rating]([rating_id])
);
GO


CREATE NONCLUSTERED INDEX [fkIdx_144] ON [employee_performance_factors] 
 (
  [emp_pr_id] ASC
 )

GO

CREATE NONCLUSTERED INDEX [fkIdx_154] ON [employee_performance_factors] 
 (
  [per_fact_id] ASC
 )

GO

CREATE NONCLUSTERED INDEX [fkIdx_157] ON [employee_performance_factors] 
 (
  [rating_id] ASC
 )

GO




-- ************************************** [hierarchy]

CREATE TABLE [hierarchy]
(
    [hierarchy_id] int NOT NULL ,
    [superior_id] varchar(50) NOT NULL ,
    [subordinate_id] varchar(50) NOT NULL ,
    [relationship_type] varchar(50) NOT NULL ,


    CONSTRAINT [PK_hierarchy] PRIMARY KEY CLUSTERED ([hierarchy_id] ASC),
    CONSTRAINT [FK_120] FOREIGN KEY ([superior_id])  REFERENCES [employee]([emp_id]),
    CONSTRAINT [FK_123] FOREIGN KEY ([subordinate_id])  REFERENCES [employee]([emp_id])
);
GO


CREATE NONCLUSTERED INDEX [fkIdx_120] ON [hierarchy] 
 (
  [superior_id] ASC
 )

GO

CREATE NONCLUSTERED INDEX [fkIdx_123] ON [hierarchy] 
 (
  [subordinate_id] ASC
 )

GO



-- ************************************** [salary_range]

CREATE TABLE [salary_range]
(
    [range_id] varchar(50) NOT NULL ,
    [pos_id] varchar(50) NOT NULL ,
    [min] decimal(18,0) NOT NULL ,
    [max] decimal(18,0) NOT NULL ,
    [create_date] date NOT NULL ,


    CONSTRAINT [PK_salary_range] PRIMARY KEY CLUSTERED ([range_id] ASC),
    CONSTRAINT [FK_30] FOREIGN KEY ([pos_id])  REFERENCES [employee_position]([pos_id])
);
GO


CREATE NONCLUSTERED INDEX [fkIdx_30] ON [salary_range] 
 (
  [pos_id] ASC
 )

GO






-- ************************************** [salary]

CREATE TABLE [salary]
(
    [salary_id] varchar(50) NOT NULL ,
    [salary_date] date NOT NULL ,
    [salary_amount] decimal(18,0) NOT NULL ,
    [curr_pos_id] varchar(50) NOT NULL ,


    CONSTRAINT [PK_salary] PRIMARY KEY CLUSTERED ([salary_id] ASC),
    CONSTRAINT [FK_67] FOREIGN KEY ([curr_pos_id])  REFERENCES [employee_current_position]([curr_pos_id])
);
GO


CREATE NONCLUSTERED INDEX [fkIdx_67] ON [salary] 
 (
  [curr_pos_id] ASC
 )

GO




-- ************************************** [wage_range]

CREATE TABLE [wage_range]
(
    [wage_rang_id] varchar(50) NOT NULL ,
    [min] decimal(18,0) NOT NULL ,
    [max] decimal(18,0) NOT NULL ,
    [create_dt] date NOT NULL ,
    [pos_id] varchar(50) NOT NULL ,


    CONSTRAINT [PK_wage_range] PRIMARY KEY CLUSTERED ([wage_rang_id] ASC),
    CONSTRAINT [FK_114] FOREIGN KEY ([pos_id])  REFERENCES [employee_position]([pos_id])
);
GO


CREATE NONCLUSTERED INDEX [fkIdx_114] ON [wage_range] 
 (
  [pos_id] ASC
 )

GO




-- ************************************** [wage]

CREATE TABLE [wage]
(
    [wage_id] varchar(50) NOT NULL ,
    [hours_per_week] decimal(18,0) NOT NULL ,
    [pay_frequency] varchar(50) NOT NULL ,
    [curr_pos_id] varchar(50) NOT NULL ,


    CONSTRAINT [PK_wage] PRIMARY KEY CLUSTERED ([wage_id] ASC),
    CONSTRAINT [FK_111] FOREIGN KEY ([curr_pos_id])  REFERENCES [employee_current_position]([curr_pos_id])
);
GO


CREATE NONCLUSTERED INDEX [fkIdx_111] ON [wage] 
 (
  [curr_pos_id] ASC
 )

GO
