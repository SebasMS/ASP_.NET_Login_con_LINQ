CREATE DATABASE dbLoginLinq

GO
USE dbLoginLinq

GO
CREATE TABLE tblUser
(
	idU       INT IDENTITY (1,1) NOT NULL,
	userName  VARCHAR(10)        NOT NULL,
	passwordU VARCHAR(150)       NOT NULL,
	name      VARCHAR(60)        NOT NULL,
	stateU    BIT                NOT NULL,
	roleU     VARCHAR(20)        NOT NULL,
	rDate     DATETIME           NOT NULL,
)

GO
ALTER TABLE tblUser ADD CONSTRAINT pk_User PRIMARY KEY (idU)