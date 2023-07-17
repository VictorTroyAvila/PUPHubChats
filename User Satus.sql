CREATE DATABASE USERSTATUS; 

CREATE TABLE UserStatus(
BlockMember VARCHAR(150) NOT NULL,
MuteMember VARCHAR(150) NOT NULL,
ArchiveMember VARCHAR(150) NOT NULL,
ComposeNewMessage VARCHAR(150) NOT NULL,
AttachFiles VARCHAR(150) NOT NULL,
DeleteConvo VARCHAR(150) NOT NULL,
RestrictMembers VARCHAR(150) NOT NULL
)

ALTER TABLE UserStatus
ADD ViewStatus VARCHAR(150);

SELECT * FROM UserStatus;