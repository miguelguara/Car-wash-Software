create table Clientes
(
ID int primary key identity (1,1),
Nome varchar(200) not null,
CPF varchar (50) not null,
Endereco varchar(300) not null
)
create table Veiculos
(
Placa varchar(30) primary key,
Modelo_Carro varchar(200)not null
ID int identity(1,1)
)

create table Limpezas
(
ID int primary key identity(1,1) not null,
PlacaCarro varchar(30) references Veiculos(Placa) not null,
IDCliente int references Clientes(ID) not null,
Valor_Limpeza decimal(18,2) not null,
HorarioAgendado Datetime not null,
DiaAgendado Datetime not null
)

create table Usuario
(
ID int identity primary key,
Username varchar(50) not null,
senha varchar(20) not null
)


