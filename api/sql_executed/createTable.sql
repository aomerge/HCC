-- Crear la base de datos si no existe
IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'HCC')
BEGIN
    CREATE DATABASE HCC;
END;
GO

-- Usar la base de datos
USE HCC;
GO

-- Crear la tabla Tb_HccMesas si no existe
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Tb_HccMesas')
BEGIN
    CREATE TABLE Tb_HccMesas (
        mes_id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
        mes_nombre NVARCHAR(50) NOT NULL,
        mes_estatus TINYINT NOT NULL
    );
END;
GO

-- Crear la tabla Tb_HccCatEstatusOrden si no existe
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Tb_HccCatEstatusOrden')
BEGIN
    CREATE TABLE Tb_HccCatEstatusOrden (
        catord_id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
        catord_nombre NVARCHAR(50) NOT NULL,
        catord_estatus TINYINT NOT NULL
    );
END;
GO

-- Crear la tabla Tb_HccAlmacen si no existe
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Tb_HccAlmacen')
BEGIN
    CREATE TABLE Tb_HccAlmacen (
        alm_id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
        alm_fecha_actualizacion DATE NOT NULL,
        alm_estatus TINYINT NOT NULL
    );
END;
GO

-- Crear la tabla Tb_HccOrdenes si no existe
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Tb_HccOrdenes')
BEGIN
    CREATE TABLE Tb_HccOrdenes (
        ord_id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
        mes_id INT NOT NULL,
        catord_id INT NOT NULL,
        ord_fecha_inicio DATE NOT NULL,
        ord_estatus TINYINT NOT NULL,
        CONSTRAINT FK_Tb_HccOrdenes_mes_id FOREIGN KEY (mes_id) REFERENCES Tb_HccMesas(mes_id),
        CONSTRAINT FK_Tb_HccOrdenes_catord_id FOREIGN KEY (catord_id) REFERENCES Tb_HccCatEstatusOrden(catord_id)
    );
END;
GO

-- Crear la tabla Tb_HccProductos si no existe
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Tb_HccProductos')
BEGIN
    CREATE TABLE Tb_HccProductos (
        pro_id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
        alm_id INT NOT NULL,
        pro_nombre NVARCHAR(50) NOT NULL,
        pro_descripcion NVARCHAR(100) NOT NULL,
        pro_precio DECIMAL(10,2) NOT NULL,
        pro_estatus TINYINT NOT NULL,
        CONSTRAINT FK_Tb_HccProductos_alm_id FOREIGN KEY (alm_id) REFERENCES Tb_HccAlmacen(alm_id)
    );
END;
GO

-- Crear la tabla Tb_HccOrdenesDetalle si no existe
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Tb_HccOrdenesDetalle')
BEGIN
    CREATE TABLE Tb_HccOrdenesDetalle (
        ordet_id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
        ord_id INT NOT NULL,
        pro_id INT NOT NULL,
        orddet_cantidad SMALLINT NOT NULL,
        ordet_estatus TINYINT NOT NULL,
        CONSTRAINT FK_Tb_HccOrdenesDetalle_ord_id FOREIGN KEY (ord_id) REFERENCES Tb_HccOrdenes(ord_id),
        CONSTRAINT FK_Tb_HccOrdenesDetalle_pro_id FOREIGN KEY (pro_id) REFERENCES Tb_HccProductos(pro_id)
    );
END;
GO

 
