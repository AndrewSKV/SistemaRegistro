# SistemaRegistro

LA RUTA DE LA BASE DE DATOS ESTÁ EN EL ARCHIVO DatabaseManager.CS POR FAVOR CAMBIARLA SI SE EJECUTA EN OTRO PC, LA BASE DE DATOS ES SQLITE.
ESTE ES EL CREATE STATEMENT DE LA TABLA NECESARIA PARA CORRER EL PROGRAMA: 

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
