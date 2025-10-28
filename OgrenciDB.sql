-- 1. HAFTA: OgrenciDB Veritabanı ve Users Tablosu Ekleme

IF DB_ID('OgrenciDB') IS NOT NULL
	DROP DATABASE OgrenciDB;
GO

-- Yeni veritabanı oluştur
CREATE DATABASE OgrenciDB
GO

--Veritabanı Kullan
USE OgrenciDB
GO

--Users Tablosu oluşturalım
CREATE TABLE Users(
	UserID INT IDENTITY (1,1) PRIMARY KEY,
	UserName NVARCHAR(50) NOT NULL,
	Password	 NVARCHAR(50) NOT NULL,
	FullName  NVARCHAR(100) ,
	Role	 NVARCHAR(50)			
);
GO

---öRNEK VERİLERİ EKLEYELİM

INSERT INTO Users (UserName, Password, FullName, Role)
VALUES
('admin','12345', 'Sistem Yöneticisi', 'Admin'),
('salih','abc111', 'Salih ERDURUCAN', 'Akademik'),
('ayse','123', 'Ayşe Demir', 'Öğrenci'),
('ahmet','123', 'Ahmet Çelebi', 'Öğrenci'),
('elif','123', 'Elif Çetin', 'Öğrenci'),
('mehmet','123', 'Mehmet Arslan', 'Öğrenci');
GO
