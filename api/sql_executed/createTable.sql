CREATE TABLE IF NOT EXISTS `Tb_HccOrdenes` (
    ord_id INT AUTO_INCREMENT PRIMARY KEY NOT NULL,
    mes_id INT NOT NULL,
    catord_id INT NOT NULL,
    ord_fecha_inicio DATE NOT NULL,
    ord_estatus TINYINT NOT NULL,

    FOREIGN KEY (mes_id) REFERENCES Tb_HccMesas(mes_id),
    FOREIGN KEY (catord_id) REFERENCES Tb_HccCatEstatusOrden(catord_nombre)
);

CREATE TABLE IF NOT EXISTS `Tb_HccOrdenesDetalle` (
    ordet_id INT AUTO_INCREMENT PRIMARY KEY NOT NULL,
    ord_id INT NOT NULL,
    pro_id INT NOT NULL,
    orddet_cantidad SMALLINT NOT NULL,
    ordet_estatus TINYINT NOT NULL,

    FOREIGN KEY (ord_id) REFERENCES Tb_HccOrdenes(ord_id),
    FOREIGN KEY (pro_id) REFERENCES Tb_HccProductos(pro_id)
);

CREATE TABLE IF NOT EXISTS `Tb_HccCatEstatusOrden` (
    catord_id INT AUTO_INCREMENT PRIMARY KEY NOT NULL,
    catord_nombre varchar(50) NOT NULL,
    catord_estatus TINYINT NOT NULL
);

CREATE TABLE IF NOT EXISTS `Tb_HccMesas` (
    mes_id INT AUTO_INCREMENT PRIMARY KEY NOT NULL,
    mes_ INT AUTO_INCREMENT PRIMARY KEY NOT NULL,
    mes_nombre varchar(50) NOT NULL,
    mes_estatus TINYINT NOT NULL
);

CREATE TABLE IF NOT EXISTS `Tb_HccProductos` (
    pro_id INT AUTO_INCREMENT PRIMARY KEY NOT NULL,
    alm_id INT NOT NULL,
    pro_nombre varchar(50) NOT NULL,
    pro_descripcion varchar(100) NOT NULL,
    pro_precio DECIMAL(10,2) NOT NULL,
    pro_estatus TINYINT NOT NULL,

    FOREIGN KEY (alm_id) REFERENCES Tb_HccAlmacen(alm_id)
);

CREATE TABLE IF NOT EXISTS `Tb_HccAlmacen` (
    alm_id INT AUTO_INCREMENT PRIMARY KEY NOT NULL,
    alm_fecha_actualizacion DATE NOT NULL,
    alm_estatus TINYINT NOT NULL
);

 
