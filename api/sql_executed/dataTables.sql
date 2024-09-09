-- Usar la base de datos HCC
USE HCC;
GO

-- Insertar datos en Tb_HccMesas
INSERT INTO Tb_HccMesas (mes_nombre, mes_estatus)
VALUES
('Mesa 1', 1),
('Mesa 2', 1),
('Mesa 3', 1),
('Mesa 4', 0),  -- Ejemplo de mesa no disponible
('Mesa 5', 1);
GO

-- Insertar datos en Tb_HccCatEstatusOrden
INSERT INTO Tb_HccCatEstatusOrden (catord_nombre, catord_estatus)
VALUES
('En Proceso', 1),
('Completada', 1),
('Cancelada', 0),
('Pendiente', 1);
GO

-- Insertar datos en Tb_HccAlmacen
INSERT INTO Tb_HccAlmacen (alm_fecha_actualizacion, alm_estatus)
VALUES
('2024-09-01', 1),
('2024-09-02', 1),
('2024-09-03', 1);
GO

-- Insertar datos en Tb_HccProductos
INSERT INTO Tb_HccProductos (alm_id, pro_nombre, pro_descripcion, pro_precio, pro_estatus)
VALUES
(1, 'Producto 1', 'Descripción del producto 1', 150.00, 1),
(1, 'Producto 2', 'Descripción del producto 2', 200.00, 1),
(2, 'Producto 3', 'Descripción del producto 3', 250.00, 1),
(2, 'Producto 4', 'Descripción del producto 4', 300.00, 0),  -- Ejemplo de producto no disponible
(3, 'Producto 5', 'Descripción del producto 5', 350.00, 1);
GO

-- Insertar datos en Tb_HccOrdenes
INSERT INTO Tb_HccOrdenes (mes_id, catord_id, ord_fecha_inicio, ord_estatus)
VALUES
(1, 1, '2024-09-01', 1),
(2, 2, '2024-09-02', 1),
(3, 1, '2024-09-03', 0),
(4, 3, '2024-09-04', 1),
(5, 4, '2024-09-05', 1);
GO

-- Insertar datos en Tb_HccOrdenesDetalle
INSERT INTO Tb_HccOrdenesDetalle (ord_id, pro_id, orddet_cantidad, ordet_estatus)
VALUES
(1, 1, 2, 1),
(1, 2, 1, 1),
(2, 3, 3, 1),
(3, 4, 2, 0),
(4, 5, 4, 1);
GO
