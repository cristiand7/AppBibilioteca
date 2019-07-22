
Create schema [Backend.db]

create table [Backend.db].[Autor] (
    Id varchar(50) primary key,
    Nombres varchar(100),
    Apellidos varchar(100),
    FechaNacimiento Datetime     
);

create table [Backend.db].[Categoria] (
    Id varchar(50) primary key,
    Nombre varchar(100),
    Descripcion varchar(100)
);

  
create table [Backend.db].[Libro] (
    Id varchar(50) primary key,
    Nombre varchar(50) not null ,
    AutorId varchar(50) not null,
    ISBN varchar(50)
);

create table  [Backend.db].[LibroCategorias] (
    Id varchar(50) primary key,
    LibroId varchar(50),
    CategoriaId varchar(50),
);

