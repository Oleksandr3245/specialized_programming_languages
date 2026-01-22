open System

let square x = x * x
let absValue x = if x < 0 then -x else x
let maxOfTwo x y = if x > y then x else y


let rec factorial n =
    if n <= 1 then 
        1
    else 
        n * factorial (n - 1) 
let rec sumList list =
    match list with
    | [] -> 0                     
    | head :: tail -> head + sumList tail 

let functionTest nums =
    nums
    |> List.filter (fun x -> x % 2 = 0) 
    |> List.map (fun x -> x * x)       
    |> List.sum                         

[<EntryPoint>]
let main argv =
    printfn "Привіт! Це моя перша програма на функціональній мові F#."


    let num = 5
    let negNum = -10
    let a, b = 12, 8

    printfn "square %d = %d" num (square num)    
    printfn "absValue %d = %d" negNum (absValue negNum)
    printfn "maxOfTwo %d %d = %d" a b (maxOfTwo a b)

//--------------------------------//
    let fact5 = factorial 5
    printfn "factorial 5 = %d" fact5
    let list1 = [1; 2; 3]    
    printfn "Сума списку %A = %d" list1 (sumList list1)

//------------------------------//
   
    let numbers = [1 .. 10]
    
    let squares = numbers |> List.map square

    let evens = numbers |> List.filter (fun x -> x % 2 = 0)

    let totalSum = numbers |> List.sum

    printfn "Початковий список: %A" numbers
    printfn "Список квадратів: %A" squares
    printfn "Список парних чисел: %A" evens
    printfn "Сума елементів початкового списку: %d" totalSum
//-----------------------------------//
    let test1 = [1; 2; 3; 4]
    printfn "Список %A -> Сума квадратів парних: %d" test1 (functionTest test1)

    let test2 = [1; 3; 5; 7]
    printfn "Список %A -> Сума квадратів парних: %d" test2 (functionTest test2)

    0 
