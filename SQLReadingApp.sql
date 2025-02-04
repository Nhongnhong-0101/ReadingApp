﻿create database READINGBOOK

use READINGBOOK

CREATE TABLE Users (
    UserID int PRIMARY KEY IDENTITY(1,1), 
    FullName nvarchar(200), 
    UserName nvarchar(100) NOT NULL,
    Password nvarchar(256) NOT NULL,   
    Email nvarchar(200) NOT NULL , 
	IsMale bit, 
	Dob Date,
    Avatar varchar(100),
);

create table Stories (
	StoryID int PRIMARY KEY IDENTITY (1,1),
    Image varchar(MAX),
    Title nvarchar(200),
    Description nvarchar(MAX),
    Type nvarchar(100), -- Thể loại truyện : trinh thám, ảo tưởng, ...
	Category nvarchar(50), 
    ChapterNumber int,
    Views int DEFAULT 0,
	FreeChapters int DEFAULT 0,
	Price int DEFAULT 0,
	Status nvarchar (100),
    Stars float,
    CreatedAt Datetime ,
    LastUpdateAt Datetime,
	Author nvarchar(50)
)

CREATE TABLE Chapters (
    ChapterID int PRIMARY KEY IDENTITY(1,1),
    StoryID int,                             
    ChapterNumber int,                       
    Title nvarchar(200),                     
    Content nvarchar(MAX),                   -- Nội dung của chương của truyện chữ
    CreatedAt datetime ,    -- Ngày tạo chương
    FOREIGN KEY (StoryID) REFERENCES Stories(StoryID) 
);

CREATE TABLE ChapterImages (
    ImageID int PRIMARY KEY IDENTITY(1,1),
    ChapterID int,
    ImageURL varchar(MAX),
	ImageOrder int, --stt cho hình
    FOREIGN KEY (ChapterID) REFERENCES Chapters(ChapterID)
);

CREATE TABLE ReadingProgress (
    UserID int,                              
    StoryID int,                             
    ChapterID int,                           
    Progress datetime,     -- Thời gian cập nhật tiến độ
    PRIMARY KEY (UserID, StoryID),          
    FOREIGN KEY (UserID) REFERENCES Users(UserID),
    FOREIGN KEY (StoryID) REFERENCES Stories(StoryID),
    FOREIGN KEY (ChapterID) REFERENCES Chapters(ChapterID)
);

CREATE TABLE Ratings (
    RatingID int PRIMARY KEY IDENTITY(1,1),
    UserID int,                            
    StoryID int,                          
    Rating int CHECK (Rating >= 1 AND Rating <= 5), -- Số sao (1-5)
    Comment nvarchar(MAX),                 -- Bình luận
    CreatedAt datetime ,  -- Thời gian tạo đánh giá
    FOREIGN KEY (UserID) REFERENCES Users(UserID),
    FOREIGN KEY (StoryID) REFERENCES Stories(StoryID)
);

CREATE TABLE ReadingLists (
    ListID int PRIMARY KEY IDENTITY(1,1),
    UserID int,    
    ListName nvarchar(200),               -- Tên danh sách đọc
    CreatedAt datetime DEFAULT GETDATE(), -- Thời gian tạo danh sách . mặc định là lúc thêm row mới vô 
    UpdatedAt datetime DEFAULT GETDATE(), -- Thời gian cập nhật danh sách
    FOREIGN KEY (UserID) REFERENCES Users(UserID)
);

CREATE TABLE ReadingListItems (
    ListItemID int PRIMARY KEY IDENTITY(1,1),
    ListID int,                              
    StoryID int,                            
    FOREIGN KEY (ListID) REFERENCES ReadingLists(ListID),
    FOREIGN KEY (StoryID) REFERENCES Stories(StoryID)
);

CREATE TABLE Notifications (
    NotificationID int PRIMARY KEY IDENTITY(1,1),
    Message nvarchar(MAX),
    CreatedAt datetime DEFAULT GETDATE(),
    StoryID int,
    FOREIGN KEY (StoryID) REFERENCES Stories(StoryID),
);

CREATE TABLE Paid (
    PaidID int PRIMARY KEY IDENTITY(1,1),
    StoryID int,                             
    UserID int,                       
    FOREIGN KEY (UserID) REFERENCES Users(UserID),
    FOREIGN KEY (StoryID) REFERENCES Stories(StoryID),
);

Drop database READINGBOOK

