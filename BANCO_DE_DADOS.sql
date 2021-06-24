create database bd_loja;
use bd_loja;

create table tb_cliente(
tb_cliente_id integer not null primary key auto_increment,
tb_cliente_nome varchar(128) not null,
tb_cliente_tel varchar(16) not null,
tb_cliente_email varchar(64) not null
);

-- tabela fornecedor
create table tb_fornecedores(
tb_fornecedores_id int primary key auto_increment,
tb_fornecedores_nome varchar(100),
tb_fornecedores_cnpj varchar(100),
tb_fornecedores_email varchar(200),
tb_fornecedores_telefone varchar(30),
tb_fornecedores_celular varchar(30),
tb_fornecedores_cep varchar(100),
tb_fornecedores_endereco varchar(255),
tb_fornecedores_numero int,
tb_fornecedores_complemento varchar(200),
tb_fornecedores_bairro varchar(100),
tb_fornecedores_cidade varchar(100),
tb_fornecedores_estado varchar(2)
);

-- tabela funcionarios
create table tb_funcionarios(
tb_funcionarios_id int primary key auto_increment,
tb_funcionarios_nome varchar(100),
tb_funcionarios_rg varchar(30),
tb_funcionarios_cpf varchar(20),
tb_funcionarios_email varchar(200),
tb_funcionarios_senha varchar(10),
tb_funcionarios_cargo varchar(100),
tb_funcionarios_nivel_acesso varchar(50),
tb_funcionarios_telefone varchar(30),
tb_funcionarios_celular varchar(30),
tb_funcionarios_cep varchar(100),
tb_funcionarios_endereco varchar(255),
tb_funcionarios_numero int,
tb_funcionarios_complemento varchar(200),
tb_funcionarios_bairro varchar(100),
tb_funcionarios_cidade varchar(100),
tb_funcionarios_estado varchar(2)
);

-- Comando para consultar dados de uma tabela
select * from tb_cliente;

-- Comando para inserir um dado (Cadastrar dados)
insert into tb_cliente (tb_cliente_nome, tb_cliente_tel, tb_cliente_email)
					values('Caio Malheiros', '(11)12321-1232', 'md.Caio@yahoo.com.br');
                    
create table tb_usuarios(
id int primary key auto_increment,
nome varchar(100),
email varchar(100),
senha varchar(20)
);
                    
insert into tb_usuarios (nome,
email,
senha)
values('Juvenal', 'juvenal@gmail.com', 'etec123');

insert into tb_usuarios (nome,
email,
senha)
values('Maria', 'maria@gmail.com', 'etec123');

insert into tb_usuarios (nome,
email,
senha)
values('Louise', 'lou@gmail.com', 'etec123');

insert into tb_usuarios (nome,
email,
senha)
values('Iara', 'iaracsales12@gmail.com', 'etec123');

select * from tb_usuarios where email = 'lou@gmail.com' and senha = 'etec123';


