# SistemaRegistro

LA RUTA DE LA BASE DE DATOS ES <bin\Debug\net6.0-windows\SistemaRegistro.db>
SI NO ENCUENTRA EL ARCHIVO .db, ESTOS SON LOS CREATE STATEMENT DE LAS TABLAS NECESARIAS PARA CORRER EL PROGRAMA: 

CREATE TABLE "Personas" (
	"Documento"	TEXT NOT NULL,
	"PrimerNombre"	TEXT NOT NULL,
	"SegundoNombre"	TEXT,
	"PrimerApellido"	TEXT NOT NULL,
	"SegundoApellido"	TEXT,
	"Telefono"	INTEGER,
	"Correo"	TEXT,
	"Direccion"	TEXT NOT NULL,
	"Edad"	INTEGER NOT NULL,
	"Genero"	TEXT NOT NULL,
	PRIMARY KEY("Documento")
)

CREATE TABLE "Roles" (
	"IDRol"	TEXT NOT NULL,
	"Rol"	TEXT NOT NULL,
	PRIMARY KEY("IDRol")
)

CREATE TABLE "Usuarios" (
	"ID"	INTEGER NOT NULL,
	"User"	TEXT NOT NULL,
	"Password"	TEXT NOT NULL,
	PRIMARY KEY("ID" AUTOINCREMENT)
)

CREATE TABLE "UsuariosRoles" (
	"IDUser"	INTEGER NOT NULL,
	"IDRol"	TEXT NOT NULL,
	FOREIGN KEY("IDRol") REFERENCES "Roles"("IDRol"),
	FOREIGN KEY("IDUser") REFERENCES "Usuarios"("ID")
)

CREATE VIEW VistaUsuariosConRoles AS
SELECT U.User, U.Password, R.IDRol
FROM Usuarios U
INNER JOIN UsuariosRoles UR ON U.ID = UR.IDUser
INNER JOIN Roles R ON UR.IDRol = R.IDRol


