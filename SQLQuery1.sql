CREATE TABLE [dbo].[Locations] (
	[LocationId] int IDENTITY(1,1) NOT NULL,
	[LocationName] nvarchar(50) NOT NULL,
	[LocationAddress] nvarchar(max) NOT NULL,
	[LocationLatitude] NUMERIC(10, 8) NOT NULL,
	[LocationLongitude] NUMERIC(11, 8) NOT NULL,
	PRIMARY KEY (LocationId),
	CONSTRAINT CK_Latitude CHECK (LocationLatitude >= -90 AND LocationLatitude <= 90),
	CONSTRAINT CK_Longtitude CHECK (LocationLongitude >= -180 AND LocationLongitude <=180)
);
GO

CREATE TABLE [dbo].[Trainers] (
	[TrainerId] int IDENTITY(1,1) NOT NULL,
	[TrainerName] nvarchar(50) NOT NULL,
	[TrainerSpecialisation] nvarchar(max),
	PRIMARY KEY (TrainerId)
);
GO

CREATE TABLE [dbo].[Courses] (
	[CourseId] int IDENTITY(1,1) NOT NULL,
	[CourseName] nvarchar(50) NOT NULL,
	[CourseDescription] nvarchar(max) NOT NULL,
	[CourseCategory] nvarchar(50) NOT NULL,
	[LocationId] int NOT NULL,
	[TrainerId] int NOT NULL,
	PRIMARY KEY (CourseId),
	FOREIGN KEY (LocationId) REFERENCES Locations(LocationId),
	FOREIGN KEY (TrainerId) REFERENCES Trainers(TrainerId)
);
GO

CREATE TABLE [dbo].[Bookings] (
	[BookingId] int IDENTITY(1,1) NOT NULL,
	[BookingDate] date NOT NULL,
	[CourseId] int NOT NULL,
	[UserId] nvarchar(max) NOT NULL,
	PRIMARY KEY (BookingId),
	FOREIGN KEY (CourseId) REFERENCES Courses(CourseId)
);
GO
