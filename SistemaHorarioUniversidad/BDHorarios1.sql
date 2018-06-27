create database HorariosI
use HorariosI
create table Facultad
(
IdFacultad varchar(30) not null primary key,
Descripcion varchar(50)
)
create table Ciclo
(
IdCiclo varchar(5) not null primary key ,
fecha_inicio date,
fecha_fin date
)
create table Escuela
(
IdEscuela int identity(001,1) primary key,
Descripcion varchar(30) ,
IdFacultad varchar(30) not null foreign key(IdFacultad) references Facultad(IdFacultad)
)
create table Curso
(
IdCurso int not null primary key,
Descripcion varchar(30),
IdEscuela int foreign key(IdEscuela) references  Escuela(IdEscuela),
IdCiclo varchar(5) foreign key(IdCiclo) references Ciclo(IdCiclo)
)
create table Plan_Estudio
(
IdPlan int identity(001,1) not null primary key,
Descripcion varchar(30),
IdCurso int not null foreign key (IdCurso) references Curso(IdCurso),
)
create table Descrip_Pabellon
(
IdDescripPabellon varchar(5) not null primary key,
Descripcion varchar(30)
)
create table Pabellon
(
IdPabellon varchar(2) not null primary key,
Capacidad_total_Pabellon int,
Fecha_Registro date,
IdDescripPabellon varchar(5) not null foreign key (IdDescripPabellon) references Descrip_Pabellon(IdDescripPabellon)
)
create table Aula
(
IdAula varchar(6) not null primary key,
Descripcion varchar(30),
Capacidad_Aula int ,
IdPabellon varchar(2) foreign key (IdPabellon) references Pabellon(IdPabellon),
Id_tipo_aula varchar(6) foreign key (Id_tipo_aula) references tipo_aula(id_tipo_aula) 
)
create table Tipo_Docente
(
IdTipoDocente int not null primary key,
Descripcion varchar(30)
)
create table Grado_Docente
(
IdGrado varchar(30) not null primary key,
Descripcion varchar(30)
)

create table Docente
(
IdCodigo int not null primary Key,
nombre varchar(50) not null,
apellido varchar(50) not null,
DNI varchar(8) not null unique,
Estado_Servicio varchar(50) not null,
correo varchar(50) not null,
Fecha_Nacimiento date not null,
Celular int not null,
Direccion varchar(200) not null,
IdTipoDocente int not null foreign key(IdTipoDocente) references Tipo_Docente(IdTipoDocente),
IdGrado varchar(30) not null foreign key(IdGrado) references Grado_Docente(IdGrado),
IdFacultad varchar(30) not null foreign key(IdFacultad) references Facultad(IdFacultad),
sexo bit,
IdAula varchar(6) not null foreign key(IdAula) references Aula(IdAula)
)

create table usuario
(
id varchar (10) not null primary key,
contraseña varchar (10)not null
)

create table tipo_aula
(
id_tipo_aula varchar (6)not null primary key,
descripcion varchar(30)
)
create table hora
(
idhora varchar(6)not null primary key,
descripcion varchar(30),
Hora_inicio date,
Hora_fin date
)
create table fecha
(
idfecha varchar(6)not null primary key,
descripcion varchar(30),
fecha_inicio date,
fecha_fin date
)
create table dia
(
iddia varchar(6) not null primary key,
descripcion varchar(30)
)

create table capacidad
(
idcapacidad varchar (6) not null primary key,
descripcion varchar (30),
cantidad int
)

create table clasificacion
(
idclasificacion varchar (6) not null primary key,
descripcion varchar (30),
tipo char (30)
)

create table semestre
(
idsemestre varchar (6) not null primary key,
descripcion varchar (30)
)

create table seccion
(
idseccion varchar (6) not null primary key,
descripcion varchar (30)
)

create table recuperaciones
(
idrecuperaciones varchar(6) not null primary key,
descripcion varchar(30),
fk_IdFecha varchar(6) not null foreign key(fk_IdFecha) references fecha(idfecha),
fk_d_Aula varchar(6) not null foreign key(fk_d_aula) references Aula(IdAula),
IdHora varchar(6) not null foreign key(IdHora) references hora(idhora),
IdDia varchar(6) not null foreign key(IdDia) references dia(iddia),
IdCapacidad varchar(6) not null foreign key(IdCapacidad) references capacidad(idcapacidad),
IdClasificacion varchar(6) not null foreign key(IdClasificacion) references clasificacion(idclasificacion),
IdSeccion varchar(6) not null foreign key(IdSeccion) references seccion(idseccion),
IdEscuela int identity(001,1) not null foreign key(IdEscuela) references Escuela(IdEscuela),
Fk_idcurso integer not null foreign key(Fk_idcurso) references Curso(IdCurso)
)

insert into usuario values('S00001',70663242)

insert into usuario values('admi','admi')


