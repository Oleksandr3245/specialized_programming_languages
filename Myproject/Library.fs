module LibraryDomain

type Genre = Fiction | NonFiction | Science | Historical | Programming | Other
type Status = Available | Issued | Archived

type Book = {
    Id: int
    Title: string
    Author: string
    Year: int
    Genre: Genre
    Pages: int
    Status: Status
}

let catalog = [
    { Id = 1; Title = "Кобзар"; Author = "Тарас Шевченко"; Year = 1840; Genre = Fiction; Pages = 320; Status = Available }
    { Id = 2; Title = "Мистецтво програмування"; Author = "Дональд Кнут"; Year = 1968; Genre = Programming; Pages = 650; Status = Issued }
    { Id = 3; Title = "Чистий код"; Author = "Robert C. Martin"; Year = 2008; Genre = Programming; Pages = 450; Status = Available }
    { Id = 4; Title = "1984"; Author = "George Orwell"; Year = 1949; Genre = Fiction; Pages = 328; Status = Available }
    { Id = 5; Title = "Sapiens"; Author = "Yuval Noah Harari"; Year = 2011; Genre = NonFiction; Pages = 512; Status = Issued }
    { Id = 6; Title = "Домашнє кондитерство"; Author = "Умовний автор"; Year = 2015; Genre = NonFiction; Pages = 220; Status = Available }
    { Id = 7; Title = "Історія України"; Author = "Умовний автор"; Year = 2003; Genre = Historical; Pages = 300; Status = Archived }
    { Id = 8; Title = "Алгоритми"; Author = "Cormen"; Year = 1990; Genre = Programming; Pages = 1312; Status = Available }
]

let getAvailable books = 
    books |> List.filter (fun b -> b.Status = Available)

let getByGenre genre books = 
    books |> List.filter (fun b -> b.Genre = genre)

let getByAuthor name books = 
    books |> List.filter (fun b -> b.Author.ToLower().Contains(name.ToString().ToLower()))

let getAllTitles books = 
    books |> List.map (fun b -> b.Title)

let totalPagesByGenre genre books = 
    books 
    |> List.filter (fun b -> b.Genre = genre) 
    |> List.sumBy (fun b -> b.Pages)

let averagePages books = 
    if List.isEmpty books then 0.0
    else 
        let total = books |> List.sumBy (fun b -> b.Pages)
        float total / float books.Length