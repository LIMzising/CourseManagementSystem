CREATE TABLE [dbo].[Ratings] (
	[RatingId] int IDENTITY(1,1) NOT NULL,
	[RatingScore] int NOT NULL,
	[CourseId] int NOT NULL,
	PRIMARY KEY (RatingId),
	FOREIGN KEY (CourseId) REFERENCES Courses(CourseId)
);
GO
