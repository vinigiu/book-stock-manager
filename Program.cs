class Program {
    static void Main(string[] args) {
        Console.WriteLine("## PROGRAMA DO CONTROLE DE ESTOQUE DE LIVROS ##");
        Console.WriteLine("## Desenvolvido por Vinícius Giuseppe Guida ##");

        int option = 0;

        List<Book> listBook = new List<Book>();

        do {
            option = Menu.Execute();

            if (option == 0) {
                Console.WriteLine("\nAté a próxima!");
                break;
            };

            switch (option) {
                case 1:
                    StockSystem.RegisterProduct(listBook);
                    break;
                case 2:
                    StockSystem.ListProducts(listBook);
                    break;
                case 3:
                    StockSystem.RemoveBook(listBook);
                    break;
                case 4:
                    StockSystem.StockIn(listBook);
                    break;
                case 5:
                    StockSystem.StockOut(listBook);
                    break;
            }
        } while (option != 0);
    }
}
