USE [master]
GO
/****** Object:  Database [dbCabeleireiro]    Script Date: 28/01/2018 11:57:23 ******/
CREATE DATABASE [dbCabeleireiro]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'dbCabeleireiro', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLSERVER14\MSSQL\DATA\dbCabeleireiro.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'dbCabeleireiro_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLSERVER14\MSSQL\DATA\dbCabeleireiro_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [dbCabeleireiro] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [dbCabeleireiro].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [dbCabeleireiro] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [dbCabeleireiro] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [dbCabeleireiro] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [dbCabeleireiro] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [dbCabeleireiro] SET ARITHABORT OFF 
GO
ALTER DATABASE [dbCabeleireiro] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [dbCabeleireiro] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [dbCabeleireiro] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [dbCabeleireiro] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [dbCabeleireiro] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [dbCabeleireiro] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [dbCabeleireiro] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [dbCabeleireiro] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [dbCabeleireiro] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [dbCabeleireiro] SET  DISABLE_BROKER 
GO
ALTER DATABASE [dbCabeleireiro] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [dbCabeleireiro] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [dbCabeleireiro] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [dbCabeleireiro] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [dbCabeleireiro] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [dbCabeleireiro] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [dbCabeleireiro] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [dbCabeleireiro] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [dbCabeleireiro] SET  MULTI_USER 
GO
ALTER DATABASE [dbCabeleireiro] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [dbCabeleireiro] SET DB_CHAINING OFF 
GO
ALTER DATABASE [dbCabeleireiro] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [dbCabeleireiro] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [dbCabeleireiro] SET DELAYED_DURABILITY = DISABLED 
GO
USE [dbCabeleireiro]
GO
/****** Object:  Table [dbo].[tblAgenda]    Script Date: 28/01/2018 11:57:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblAgenda](
	[IdAgendamento] [int] IDENTITY(1,1) NOT NULL,
	[IdCliente] [int] NOT NULL,
	[Data] [date] NOT NULL,
	[Atendido] [bit] NOT NULL,
	[AgendadoEm] [date] NOT NULL,
 CONSTRAINT [PK_tblAgenda] PRIMARY KEY CLUSTERED 
(
	[IdAgendamento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblAgendaServicos]    Script Date: 28/01/2018 11:57:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblAgendaServicos](
	[IdAgendaServicos] [int] IDENTITY(1,1) NOT NULL,
	[IdAgendamento] [int] NOT NULL,
	[IdServico] [int] NOT NULL,
 CONSTRAINT [PK_tblAgendaServicos] PRIMARY KEY CLUSTERED 
(
	[IdAgendaServicos] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblCliente]    Script Date: 28/01/2018 11:57:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblCliente](
	[IdCliente] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](100) NOT NULL,
 CONSTRAINT [PK_tblCliente] PRIMARY KEY CLUSTERED 
(
	[IdCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblContato]    Script Date: 28/01/2018 11:57:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblContato](
	[IdContato] [int] IDENTITY(1,1) NOT NULL,
	[IdCliente] [int] NOT NULL,
	[Telefone] [varchar](14) NOT NULL,
 CONSTRAINT [PK_tblContato] PRIMARY KEY CLUSTERED 
(
	[IdContato] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblServicos]    Script Date: 28/01/2018 11:57:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblServicos](
	[IdServico] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] [varchar](100) NOT NULL,
	[Valor] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_tblServicos] PRIMARY KEY CLUSTERED 
(
	[IdServico] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  View [dbo].[uvwClienteVisualizar]    Script Date: 28/01/2018 11:57:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[uvwClienteVisualizar]
	
as

select cli.IdCliente, cli.Nome, con.Telefone from tblCliente cli right join tblContato con on cli.IdCliente = con.IdCliente;
GO
ALTER TABLE [dbo].[tblAgenda]  WITH CHECK ADD  CONSTRAINT [FK_tblAgenda_tblCliente] FOREIGN KEY([IdCliente])
REFERENCES [dbo].[tblCliente] ([IdCliente])
GO
ALTER TABLE [dbo].[tblAgenda] CHECK CONSTRAINT [FK_tblAgenda_tblCliente]
GO
ALTER TABLE [dbo].[tblAgendaServicos]  WITH CHECK ADD  CONSTRAINT [FK_tblAgendaServicos_tblAgenda] FOREIGN KEY([IdAgendamento])
REFERENCES [dbo].[tblAgenda] ([IdAgendamento])
GO
ALTER TABLE [dbo].[tblAgendaServicos] CHECK CONSTRAINT [FK_tblAgendaServicos_tblAgenda]
GO
ALTER TABLE [dbo].[tblAgendaServicos]  WITH CHECK ADD  CONSTRAINT [FK_tblAgendaServicos_tblServicos] FOREIGN KEY([IdServico])
REFERENCES [dbo].[tblServicos] ([IdServico])
GO
ALTER TABLE [dbo].[tblAgendaServicos] CHECK CONSTRAINT [FK_tblAgendaServicos_tblServicos]
GO
ALTER TABLE [dbo].[tblContato]  WITH CHECK ADD  CONSTRAINT [FK_tblContato_tblCliente] FOREIGN KEY([IdCliente])
REFERENCES [dbo].[tblCliente] ([IdCliente])
GO
ALTER TABLE [dbo].[tblContato] CHECK CONSTRAINT [FK_tblContato_tblCliente]
GO
/****** Object:  StoredProcedure [dbo].[uspAgendaAlterar]    Script Date: 28/01/2018 11:57:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[uspAgendaAlterar]
	@IdAgendamento int,
	@Data date,
	@Atendido bit,
	@IdServico int
as
begin
	begin try
		begin tran
		
			update tblAgenda set Data = @Data, Atendido = @Atendido where IdAgendamento = @IdAgendamento;
			update tblAgendaServicos set IdServico = @IdServico where IdAgendamento = @IdAgendamento;

			select @IdAgendamento as Retorno;

		commit tran
	end try
	begin catch
		rollback tran
		select ERROR_MESSAGE() as Retorno;
	end catch
end	
GO
/****** Object:  StoredProcedure [dbo].[uspAgendaExcluir]    Script Date: 28/01/2018 11:57:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[uspAgendaExcluir]
	@IdAgendamento int
as 
begin
	begin try
		begin tran
			delete from tblAgendaServicos where IdAgendamento = @IdAgendamento;
			delete from tblAgenda where IdAgendamento = @IdAgendamento;

			select @IdAgendamento as Retorno;
		commit tran
	end try
	begin catch
		rollback tran
		select ERROR_MESSAGE() as Retorno;
	end catch
end
GO
/****** Object:  StoredProcedure [dbo].[uspClienteInserir]    Script Date: 28/01/2018 11:57:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[uspClienteInserir]
	@Nome varchar(100),
	@Telefone varchar(14)
as
begin
	begin try
		begin tran

			if(exists(select cli.Nome, con.Telefone from tblCliente cli join tblContato con 
						on cli.IdCliente = con.IdCliente where cli.Nome = @Nome and con.Telefone = @Telefone))
						raiserror('Cliente já cadastrado', 14, 1)
					
			declare @IdPessoa int
			
			insert into tblCliente (Nome) values (@Nome);

			set @IdPessoa = @@IDENTITY;

			insert into tblContato (IdCliente, Telefone) values (@IdPessoa, @Telefone);

			select @IdPessoa as Retorno;

		commit tran
	end try
	begin catch
		rollback tran
		select ERROR_MESSAGE() as Retorno;
	end catch
end
GO
/****** Object:  StoredProcedure [dbo].[uspClienteInserirNovoContato]    Script Date: 28/01/2018 11:57:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[uspClienteInserirNovoContato]
	@IdCliente int,
	@Telefone varchar(14)
as
begin
	begin try
		begin tran

			if(exists(select IdCliente, Telefone from tblContato where IdCliente = @IdCliente and Telefone = @Telefone))
				raiserror('Telefone já foi cadastrado', 14, 1);

			insert into tblContato (IdCliente, Telefone) values (@IdCliente, @Telefone);

			select @IdCliente as Retorno;

		commit tran
	end try
	begin catch
		rollback tran
		select ERROR_MESSAGE() as Retorno;
	end catch
end
GO
/****** Object:  StoredProcedure [dbo].[uspServicoAgendar]    Script Date: 28/01/2018 11:57:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[uspServicoAgendar]
	@IdCliente int,
	@Data date,
	@IdServico int
as
begin
	begin try
		begin tran
			
			if(exists(select ag.IdCliente, ags.IdServico from tblAgenda ag join tblAgendaServicos ags on ag.IdAgendamento = ags.IdAgendamento 
							where ag.IdCliente = @IdCliente and ags.IdServico = @IdServico))
				raiserror ('Agendamento já realizado', 14,1);

			declare @IdAg as int;
			
			insert into tblAgenda (IdCliente, Data, Atendido, AgendadoEm) values (@IdCliente, @Data, 0, getdate());

			set @IdAg = @@IDENTITY;

			insert into tblAgendaServicos (IdAgendamento, IdServico) values (@IdAg, @IdServico);

			select @IdAg as Retorno;

		commit tran
	end try
	begin catch
		rollback tran
		select ERROR_MESSAGE() as Retorno;
	end catch
end
GO
USE [master]
GO
ALTER DATABASE [dbCabeleireiro] SET  READ_WRITE 
GO
