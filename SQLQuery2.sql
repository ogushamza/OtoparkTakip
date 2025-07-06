-- 1. Veritabaný oluþtur
CREATE DATABASE OtoparkDB;
GO

USE OtoparkDB;
GO

-- 2. Araçlar tablosu
CREATE TABLE Araclar
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Plaka NVARCHAR(15) NOT NULL UNIQUE,
    GirisTarihi DATETIME NOT NULL DEFAULT GETDATE(),
    CikisTarihi DATETIME NULL,
    Durum BIT NOT NULL DEFAULT 1 -- 1=parkta, 0=çýktý
);
GO

-- 3. Ücret Tarifesi tablosu (isteðe baðlý)
CREATE TABLE UcretTarifesi
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    SaatlikUcret DECIMAL(10,2) NOT NULL
);
GO

-- 4. Ücret tarifesi için örnek veri (saatlik 20 TL)
INSERT INTO UcretTarifesi (SaatlikUcret) VALUES (20.00);
GO

-- 5. Örnek araç giriþi
INSERT INTO Araclar (Plaka, GirisTarihi, Durum) VALUES ('34ABC123', GETDATE(), 1);
GO
