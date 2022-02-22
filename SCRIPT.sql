IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Produto]') AND type in (N'U'))
DROP TABLE [dbo].[Produto]
GO

CREATE TABLE [dbo].[Produto](
	[IDProduto] [bigint] NOT NULL,
	[Descricao] [nvarchar](100) NULL,
	[Categoria] [tinyint] NULL,
	[Preco] [decimal] NULL,
	[DataRegisto] [datetime] NULL,
	[Stock] [int],
 CONSTRAINT [PK_Produto] PRIMARY KEY CLUSTERED 
(
	[IDProduto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EliminarProduto]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[EliminarProduto]
GO

CREATE Procedure [dbo].[EliminarProduto]
@IDProduto bigint
AS
Begin

    Delete from [Produto]
    Where [IDProduto]=@IDProduto

end

GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ObterProduto]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[ObterProduto]
GO

CREATE Procedure [dbo].[ObterProduto]
@IDProduto bigint
As 
Begin

	Select * From [Produto] Where [IDProduto]=@IDProduto
End


GO


IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ListarProduto]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[ListarProduto]
GO

CREATE Procedure [dbo].[ListarProduto]
As 
Begin

	Select * From Produto
End

GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GravarProduto]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[GravarProduto]
GO

CREATE Procedure [dbo].[GravarProduto]
@IDProduto bigint,
@Descricao nvarchar(100),
@Categoria tinyint,
@Preco decimal,
@DataRegisto datetime,
@Stock int
As 
Begin

Begin Transaction
   
 IF (Select Count(*) From [Produto] Where [IDProduto]=@IDProduto)=0
      Begin
         Insert Into [Produto] ([IDProduto], [Descricao], [Categoria], [Preco], [DataRegisto], [Stock])
         Values (@IDProduto, @Descricao, @Categoria, @Preco, @DataRegisto, @Stock)
      End
 Else
     Begin
        Update [Produto]
		Set [Descricao]=@Descricao,
			[Categoria]=@Categoria,
			[Preco]=@Preco,
			[DataRegisto]=@DataRegisto,
			[Stock]=@Stock
			
         Where [IDProduto]=@IDProduto
      End
 
      If @@error <>0
            Begin
               Rollback transaction
            End
      Else
            Begin
               Commit Transaction
            End
End

GO

