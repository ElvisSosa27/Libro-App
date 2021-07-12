CREATE DATABASE LibroAppDB

USE LibroAppDB

CREATE TABLE Authors
(
	id INT PRIMARY KEY IDENTITY(1,1),
	name VARCHAR(50),
	email VARCHAR(50)
)

CREATE TABLE Categories
(
	id INT PRIMARY KEY IDENTITY(1,1),
	name VARCHAR(50)
)

CREATE TABLE Publishers
(
	id INT PRIMARY KEY IDENTITY(1,1),
	name VARCHAR(50),
	phone VARCHAR(50),
	country VARCHAR(50)
)

CREATE TABLE Books
(
	id INT PRIMARY KEY IDENTITY(1,1),
	name VARCHAR(50),
	year INT,
	category VARCHAR(50),
	author VARCHAR(50),
	publisher VARCHAR(50)
)