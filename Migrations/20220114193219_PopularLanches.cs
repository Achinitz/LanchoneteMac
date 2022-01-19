using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanchesMac.Migrations
{
    public partial class PopularLanches : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Lanche (CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImagemThumbnailUrl,ImagemUrl,IsLanchePrefirido,Nome,Preco) "+
            "VALUES (1,'Pão, hambúrguer, ovo, presunto, queijo e batata palha','Delicioso Pão de Hamburguer com ovo frito; presunto e queijo de primeira qualidade acompanhado com batata palha',1,'https://caldobom.com.br/uploads/hambuguer-acad8a41a06c709c7b009bed1a8881c91601327910.jpg'" +
            ",'https://s2.glbimg.com/SMJqmqMEbiE2z7qm0nEIQBY-Sqg=/e.glbimg.com/og/ed/f/original/2019/02/05/haburguer-veggie.jpg'" +
            ",0,'Cheese Salada', 15.50)");
            migrationBuilder.Sql("INSERT INTO Lanche (CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImagemThumbnailUrl,ImagemUrl,IsLanchePrefirido,Nome,Preco) "+
            "VALUES (1,'Pão, hambúrguer grão de bico, presunto vegano, queijo vegano e batata palha','Delicioso Pão de Hamburguer vegano; presunto e queijo de primeira qualidade acompanhado com batata palha',1,'https://caldobom.com.br/uploads/hambuguer-acad8a41a06c709c7b009bed1a8881c91601327910.jpg'" +
            ",'https://s2.glbimg.com/SMJqmqMEbiE2z7qm0nEIQBY-Sqg=/e.glbimg.com/og/ed/f/original/2019/02/05/haburguer-veggie.jpg'" +
            ",0,'Cheese Salada', 15.50)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Lanche");
        }
    }
}
