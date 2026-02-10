open LibraryDomain

[<EntryPoint>]
let main _ =
    printfn "Результати роботи:"

    let available = getAvailable catalog
    printfn "Можна взяти почитати: %A" (getAllTitles available)

    let progs = getByGenre Programming catalog
    printfn "Для програмістів: %A" (getAllTitles progs)

    let orwell = getByAuthor "George Orwell" catalog
    let martin = getByAuthor "Robert C. Martin" catalog
    printfn "Книги Орвелла: %A" (getAllTitles orwell)
    printfn "Книги Мартіна: %A" (getAllTitles martin)

    let progPages = totalPagesByGenre Programming catalog
    let avg = averagePages catalog

    printfn "Статистика сторінок:"
    printfn "Всього сторінок у коді: %d" progPages
    printfn "Середня товщина книги в бібліотеці: %.1f сторінок" avg

    0 