CREATE TABLE Encargado (
  idusuario VARCHAR(100)  NOT NULL  ,
  nombre VARCHAR(25)    ,
  Contraseña VARCHAR(100)    ,
  esEmpleado VARCHAR(25)      ,
PRIMARY KEY(idusuario));
GO




CREATE TABLE Departamento (
  nombreDepartamento VARCHAR(100)  NOT NULL    ,
PRIMARY KEY(nombreDepartamento));
GO




CREATE TABLE gastos (
  idgastos INTEGER  NOT NULL   IDENTITY ,
  detalle VARCHAR(600)    ,
  valor INTEGER    ,
  fecha DATE      ,
PRIMARY KEY(idgastos));
GO




CREATE TABLE PeriodoPrueba (
  idPeriodoPrueba INTEGER  NOT NULL   IDENTITY ,
  fechaFinal DATE      ,
PRIMARY KEY(idPeriodoPrueba));
GO




CREATE TABLE Movimientos (
  idMovimientos INTEGER  NOT NULL   IDENTITY ,
  fecha DATE    ,
  Contrato VARCHAR(200)    ,
  valor INTEGER    ,
  meses INTEGER    ,
  TipoMov VARCHAR(200)    ,
  descuento INTEGER      ,
PRIMARY KEY(idMovimientos));
GO




CREATE TABLE Cliente (
  Cedula VARCHAR(200)  NOT NULL  ,
  Nombre VARCHAR(90)    ,
  Telefono VARCHAR(90)    ,
  direccion VARCHAR(150)    ,
  Ciudad VARCHAR(90)    ,
  Depto VARCHAR(50)    ,
  contratos INTEGER    ,
  vigentes INTEGER      ,
PRIMARY KEY(Cedula));
GO




CREATE TABLE CajaMenor (
  idCaja INTEGER  NOT NULL   IDENTITY ,
  fecha DATE    ,
  capitalInicial INT    ,
  capitalAnterior INT    ,
  capital INT    ,
  contratosResueltos INTEGER    ,
  utilidadesResueltos INTEGER    ,
  prorrogas INTEGER    ,
  ventas INTEGER    ,
  utilidadesVentas INTEGER    ,
  otrosIngresos INTEGER    ,
  Pagos INTEGER    ,
  TotalIngresos INTEGER    ,
  Compras INTEGER    ,
  Gastos INTEGER    ,
  OtrosGastos INTEGER    ,
  consignaciones INTEGER    ,
  TotalEgresos INTEGER      ,
PRIMARY KEY(idCaja));
GO




CREATE TABLE CajaDiaria (
  idCajaDiaria INTEGER  NOT NULL   IDENTITY ,
  ValorEncaja INTEGER    ,
  Intereses INTEGER    ,
  pago INTEGER      ,
PRIMARY KEY(idCajaDiaria));
GO




CREATE TABLE Producto (
  idProducto INTEGER  NOT NULL   IDENTITY ,
  nombreDepartamento VARCHAR(100)  NOT NULL  ,
  nombreProducto VARCHAR(150)    ,
  valor INTEGER    ,
  cantidad INTEGER    ,
  estado VARCHAR(60)    ,
  peso VARCHAR(50)      ,
PRIMARY KEY(idProducto)  ,
  FOREIGN KEY(nombreDepartamento)
    REFERENCES Departamento(nombreDepartamento));
GO


CREATE INDEX Producto_FKIndex1 ON Producto (nombreDepartamento);
GO


CREATE INDEX IFK_Rel_12 ON Producto (nombreDepartamento);
GO


CREATE TABLE ingresos (
  idingresos INTEGER  NOT NULL   IDENTITY ,
  idusuario VARCHAR(100)  NOT NULL  ,
  hora VARCHAR(100)    ,
  fecha DATE      ,
PRIMARY KEY(idingresos)  ,
  FOREIGN KEY(idusuario)
    REFERENCES Encargado(idusuario));
GO


CREATE INDEX ingresos_FKIndex1 ON ingresos (idusuario);
GO


CREATE INDEX IFK_Rel_04 ON ingresos (idusuario);
GO


CREATE TABLE Venta (
  idVenta INTEGER  NOT NULL   IDENTITY ,
  idusuario VARCHAR(100)  NOT NULL  ,
  Cedula VARCHAR(200)  NOT NULL  ,
  idProducto INTEGER  NOT NULL  ,
  fecha DATE    ,
  valor INTEGER    ,
  cant INTEGER    ,
  postValor INTEGER      ,
PRIMARY KEY(idVenta)      ,
  FOREIGN KEY(idProducto)
    REFERENCES Producto(idProducto),
  FOREIGN KEY(Cedula)
    REFERENCES Cliente(Cedula),
  FOREIGN KEY(idusuario)
    REFERENCES Encargado(idusuario));
GO


CREATE INDEX Venta_FKIndex1 ON Venta (idProducto);
GO
CREATE INDEX Venta_FKIndex2 ON Venta (Cedula);
GO
CREATE INDEX Venta_FKIndex3 ON Venta (idusuario);
GO


CREATE INDEX IFK_Rel_02 ON Venta (idProducto);
GO
CREATE INDEX IFK_Rel_09 ON Venta (Cedula);
GO
CREATE INDEX IFK_Rel_14 ON Venta (idusuario);
GO


CREATE TABLE Compra (
  idCompra INTEGER  NOT NULL   IDENTITY ,
  idusuario VARCHAR(100)  NOT NULL  ,
  Cedula VARCHAR(200)  NOT NULL  ,
  idProducto INTEGER  NOT NULL  ,
  fecha DATE    ,
  valorUnitario INTEGER    ,
  cantidad INTEGER    ,
  valorVenta INTEGER    ,
  postValor INTEGER      ,
PRIMARY KEY(idCompra)      ,
  FOREIGN KEY(idProducto)
    REFERENCES Producto(idProducto),
  FOREIGN KEY(Cedula)
    REFERENCES Cliente(Cedula),
  FOREIGN KEY(idusuario)
    REFERENCES Encargado(idusuario));
GO


CREATE INDEX Compra_FKIndex1 ON Compra (idProducto);
GO
CREATE INDEX Compra_FKIndex2 ON Compra (Cedula);
GO
CREATE INDEX Compra_FKIndex3 ON Compra (idusuario);
GO


CREATE INDEX IFK_Rel_03 ON Compra (idProducto);
GO
CREATE INDEX IFK_Rel_10 ON Compra (Cedula);
GO
CREATE INDEX IFK_Rel_13 ON Compra (idusuario);
GO


CREATE TABLE Contrato (
  idContrato INTEGER  NOT NULL   IDENTITY ,
  idusuario VARCHAR(100)  NOT NULL  ,
  Cedula VARCHAR(200)  NOT NULL  ,
  idProducto INTEGER  NOT NULL  ,
  fechaInicio DATE    ,
  estado VARCHAR(100)    ,
  valor INTEGER    ,
  detalle VARCHAR(600)    ,
  Observacion VARCHAR(600)    ,
  prologa INTEGER    ,
  plazoMeses INTEGER    ,
  fechaFinal DATE    ,
  prologaTotal INTEGER    ,
  postValor INTEGER      ,
PRIMARY KEY(idContrato)      ,
  FOREIGN KEY(idProducto)
    REFERENCES Producto(idProducto),
  FOREIGN KEY(Cedula)
    REFERENCES Cliente(Cedula),
  FOREIGN KEY(idusuario)
    REFERENCES Encargado(idusuario));
GO


CREATE INDEX Empeno_FKIndex1 ON Contrato (idProducto);
GO
CREATE INDEX Empeno_FKIndex2 ON Contrato (Cedula);
GO
CREATE INDEX Contrato_FKIndex3 ON Contrato (idusuario);
GO


CREATE INDEX IFK_Rel_05 ON Contrato (idProducto);
GO
CREATE INDEX IFK_Rel_06 ON Contrato (Cedula);
GO
CREATE INDEX IFK_Rel_12 ON Contrato (idusuario);
GO


CREATE TABLE Comentario (
  idComentario INTEGER  NOT NULL   IDENTITY ,
  idContrato INTEGER  NOT NULL  ,
  Texto VARCHAR(600)      ,
PRIMARY KEY(idComentario)  ,
  FOREIGN KEY(idContrato)
    REFERENCES Contrato(idContrato));
GO


CREATE INDEX Comentario_FKIndex1 ON Comentario (idContrato);
GO


CREATE INDEX IFK_Rel_11 ON Comentario (idContrato);
GO


CREATE TABLE Prorroga (
  idProrroga INTEGER  NOT NULL   IDENTITY ,
  Encargado_idusuario VARCHAR(100)  NOT NULL  ,
  idContrato INTEGER  NOT NULL  ,
  fechaProrroga DATE    ,
  mesesapagar INTEGER    ,
  ValorTotal INTEGER    ,
  valorAumentado INTEGER      ,
PRIMARY KEY(idProrroga)    ,
  FOREIGN KEY(idContrato)
    REFERENCES Contrato(idContrato),
  FOREIGN KEY(Encargado_idusuario)
    REFERENCES Encargado(idusuario));
GO


CREATE INDEX Prorroga_FKIndex1 ON Prorroga (idContrato);
GO
CREATE INDEX Prorroga_FKIndex2 ON Prorroga (Encargado_idusuario);
GO


CREATE INDEX IFK_Rel_08 ON Prorroga (idContrato);
GO
CREATE INDEX IFK_Rel_16 ON Prorroga (Encargado_idusuario);
GO


CREATE TABLE pago (
  idpago INTEGER  NOT NULL   IDENTITY ,
  idusuario VARCHAR(100)  NOT NULL  ,
  idContrato INTEGER  NOT NULL  ,
  fechaPago DATE    ,
  valor INTEGER    ,
  mesPago VARCHAR(150)      ,
PRIMARY KEY(idpago)    ,
  FOREIGN KEY(idContrato)
    REFERENCES Contrato(idContrato),
  FOREIGN KEY(idusuario)
    REFERENCES Encargado(idusuario));
GO


CREATE INDEX pago_FKIndex1 ON pago (idContrato);
GO
CREATE INDEX pago_FKIndex2 ON pago (idusuario);
GO


CREATE INDEX IFK_Rel_07 ON pago (idContrato);
GO
CREATE INDEX IFK_Rel_15 ON pago (idusuario);
GO


