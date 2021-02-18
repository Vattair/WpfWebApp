DROP TABLE IF EXISTS "Users";
DROP TABLE IF EXISTS "UserDetails";
DROP TABLE IF EXISTS "PostCategory";
DROP TABLE IF EXISTS "Post";

CREATE TABLE "Users" (
	"UserID" INTEGER PRIMARY KEY,
	"UserName" nvarchar (20) NOT NULL
);
CREATE TABLE "UserDetails" (
	"UserID" "int" NOT NULL ,
	"LastName" nvarchar (20) NOT NULL ,
	"FirstName" nvarchar (10) NOT NULL ,
	CONSTRAINT "FK_Users_ID" FOREIGN KEY 
	(
		"UserID"
	) REFERENCES "Users" (
		"UserID"
	)
);
CREATE TABLE "PostCategory" (
	"CategoryID" INTEGER PRIMARY KEY,
	"Category" nvarchar (15) NOT NULL
);
CREATE TABLE "Post"(
	"PostID" INTEGER PRIMARY KEY,
	"CategoryID" "int" NOT NULL ,
	"UserID" "int" NOT NULL ,
	"Content" TEXT,
	CONSTRAINT "FK_Category_ID" FOREIGN KEY 
	(
		"CategoryID"
	) REFERENCES "PostCategory" (
		"CategoryID"
	),
	CONSTRAINT "FK_Users_ID" FOREIGN KEY 
	(
		"UserID"
	) REFERENCES "Users" (
		"UserID"
	)
);

INSERT INTO "PostCategory"
VALUES
(1,'Technologia'),
(2,'Sport'),
(3,'Polityka'),
(4,'Pogoda');
INSERT INTO "Users" VALUES (1,'Admin');
INSERT INTO "UserDetails" VALUES (1,'Kamil','Karlinski');
INSERT INTO "Post" VALUES (1,4,1,'Przelotne opady śniegu');