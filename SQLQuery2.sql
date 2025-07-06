-- 1. Veritaban� olu�tur
CREATE DATABASE OtoparkDB;
GO

USE OtoparkDB;
GO

-- 2. Ara�lar tablosu
CREATE TABLE Araclar
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Plaka NVARCHAR(15) NOT NULL UNIQUE,
    GirisTarihi DATETIME NOT NULL DEFAULT GETDATE(),
    CikisTarihi DATETIME NULL,
    Durum BIT NOT NULL DEFAULT 1 -- 1=parkta, 0=��kt�
);
GO

-- 3. �cret Tarifesi tablosu (iste�e ba�l�)
CREATE TABLE UcretTarifesi
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    SaatlikUcret DECIMAL(10,2) NOT NULL
);
GO

-- 4. �cret tarifesi i�in �rnek veri (saatlik 20 TL)
INSERT INTO UcretTarifesi (SaatlikUcret) VALUES (20.00);
GO

-- 5. �rnek ara� giri�i
INSERT INTO Araclar (Plaka, GirisTarihi, Durum) VALUES ('34ABC123', GETDATE(), 1);
GO
