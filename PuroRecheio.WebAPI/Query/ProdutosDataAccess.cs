using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace PuroRecheio.WebAPI.Infra
{
    public interface IProdutosDataAccess 
    {
        Task<IEnumerable<ProdutosViewModel>> RecuperarProdutos();
    }

    public sealed class ProdutosDataAccess : IProdutosDataAccess
    {
        public async Task<IEnumerable<ProdutosViewModel>> RecuperarProdutos()
        {
            const string sql = @"SELECT  Sabor, 
                                         Tamanho, 
                                         Imagem, 
                                         Preco AS Valor 
                                 FROM Produtos (NOLOCK)";

            using(var connection = new SqlConnection("Data Source = purorecheio.database.windows.net; Initial Catalog = Info; User Id = vitor; Password = D&Arol8w@99R2;"))
            {
                try
                {
                    await connection.OpenAsync();
                    var resultado = await connection.QueryAsync<ProdutosViewModel>(sql);
                    if (resultado == null || !resultado.Any())
                        return new List<ProdutosViewModel>();
                    return resultado;
                } catch (Exception ex)
                {
                    return new List<ProdutosViewModel>();
                }
                finally
                {
                    connection.Close();
                }
            }
        }
    }
}
