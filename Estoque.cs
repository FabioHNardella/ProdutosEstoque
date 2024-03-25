public class Estoque
{
    private List<string> produtos = new List<string>();

    public void AddProduto(string produto)
    {
        produtos.Add(produto);
    }// end of addProdutos

    public void ExibirProdutos()
    {
        foreach (string produto in produtos)
        {
            System.Console.WriteLine(produto);
        }
    }// end of exibirProdutos

}// end of class EstoqueProdutos
