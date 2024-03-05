public class Menu {
    public static int Execute() {
        Console.WriteLine("\nDigite a opção desejada: \n");
        Console.WriteLine("[1] Novo");
        Console.WriteLine("[2] Listar Produtos");
        Console.WriteLine("[3] Remover Produtos");
        Console.WriteLine("[4] Entrada Estoque");
        Console.WriteLine("[5] Saída Estoque");
        Console.WriteLine("[0] Sair");
        int option = Convert.ToInt32(Console.ReadLine());

        return option;
    }
}