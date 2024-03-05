public class StockSystem {
    public static void RegisterProduct(List<Book> bookList) {
        Console.WriteLine("\nInforme o nome do Livro:");
        string bookName = Console.ReadLine();

        Console.WriteLine("\nInforme o preço do Livro:");
        string bookPrice = Console.ReadLine();

        Console.WriteLine("\nInforme o autor(a) do Livro:");
        string bookAuthor = Console.ReadLine();

        Console.WriteLine("\nInforme o Gênero do Livro:");
        string bookGenre = Console.ReadLine();

        Console.WriteLine("\nInforme a quantidade de páginas do Livro:");
        string pagesNumber = Console.ReadLine();

        bookList.Add(new Book { 
            BookName = bookName, 
            BookPrice = bookPrice,
            BookAuthor = bookAuthor,
            BookGenre = bookGenre,
            PagesNumber = pagesNumber,
            BookStock = 0,
        });

        Console.WriteLine("\nLivro Adicionado!");
    }

    public static void ListProducts(List<Book> bookList) {
        if (bookList.Count > 0) {
            for (int i = 0; i < bookList.Count; i++){
                Book book = bookList[i];
                Console.WriteLine($"\n{i + 1}. {book.BookName} - Preço: R$ {book.BookPrice} - #páginas: {book.PagesNumber} - estoque: {book.BookStock}.");
            }
        } else {
            Console.WriteLine("\nSeu estoque ainda não possui registros.");
        }
    }

    public static void StockIn(List<Book> bookList) {
        Console.WriteLine("\nInforme a posição do livro:");
        int position = Convert.ToInt32(Console.ReadLine());

        if (position > 0 && position <= bookList.Count) {
            Console.WriteLine("\nInforme a quantidade de Entrada:");
            int qtd = Convert.ToInt32(Console.ReadLine());

            bookList[position - 1].BookStock = qtd;

            Console.WriteLine($"\nQuantidade do livro: {bookList[position - 1].BookName} alterada para: {bookList[position - 1].BookStock}.");
        } else {
            Console.WriteLine($"\nA posição informada não existe. Favor inserir posição de 1 até {bookList.Count}.");
        }
    }

    public static void StockOut(List<Book> bookList) {
        Console.WriteLine("\nInforme a posição do livro:");
        int position = Convert.ToInt32(Console.ReadLine());

        if (position > 0 && position <= bookList.Count) {
            Console.WriteLine("\nInforme a quantidade de Saída:");
            int qtd = Convert.ToInt32(Console.ReadLine());

            bookList[position - 1].BookStock -= qtd;

            Console.WriteLine($"\nQuantidade do livro: {bookList[position - 1].BookName} alterada para: {bookList[position - 1].BookStock}.");
        } else {
            Console.WriteLine($"\nA posição informada não existe. Favor inserir posição de 1 até {bookList.Count}.");
        }
    }

    public static void RemoveBook(List<Book> bookList) {
        Console.WriteLine("\nInforme a posição do livro a ser removido:");
        int position = Convert.ToInt32(Console.ReadLine());

        if (position > 0 && position <= bookList.Count) {
            bookList.RemoveAt(position - 1);
            Console.WriteLine($"\nLivro removido com sucesso!");
        } else {
            Console.WriteLine($"\nA posição informada não existe. Favor inserir posição de 1 até {bookList.Count}.");
        }
    }
}