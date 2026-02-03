module Homework
open System

let rec factorial n =
    if n < 0 then failwith "Число має бути невід'ємним"
    match n with
    | 0 | 1 -> 1
    | _ -> n * factorial (n - 1) 

let rec fibo n =    
    if n <= 0 then 0
    elif n = 1 then 1
    else fibo (n - 1) + fibo (n - 2)    

let buildFibs n = 
    [0 .. n-1] |> List.map fibo
/////////////////////////////////
let findMaxFold lst =
    if List.isEmpty lst then None
    else Some (List.fold max lst.[0] lst)

let processData nums =
    let sq = nums |> List.map (fun x -> x * x)
    let ev = nums |> List.filter (fun x -> x % 2 = 0)
    let sm = nums |> List.sum
    let res = ev |> List.map (fun x -> x * x) |> List.sum
    (sq, ev, sm, res)
/////
let analyzeGrades grades =
    let maxGrade = float (List.max grades)    
    let norm = grades |> List.map (fun g -> float g / maxGrade * 100.0)    
    let filt = norm |> List.filter (fun g -> g >= 70.0)    
    let avB = List.sum norm / float norm.Length
    let avA = if filt.Length > 0 then List.sum filt / float filt.Length else 0.0    
    (norm, filt, avB, avA)

////////////////////////////////////////////////////////

[<EntryPoint>]
let main _ =
    
    printfn "Перевірка до завдання №1:" 
    printfn "Факторіал 0: %d" (factorial 0)
    printfn "Факторіал 1: %d" (factorial 1)
    printfn "Факторіал 5: %d" (factorial 5)
    printfn "Факторіал 10: %d" (factorial 10)

    printfn "Перевірка до завдання №2:"
    printfn "Список Фібоначчі (10 елементів): %A" (buildFibs 10)

    printfn "Перевірка до завдання №3:"
    printfn "Максимум у [5, 2, 9, -3, 7]: %A" (findMaxFold [5; 2; 9; -3; 7])
    printfn "Максимум у [42]: %A" (findMaxFold [42])
    printfn "Максимум у [-5, -10, -2]: %A" (findMaxFold [-5; -10; -2])

    printfn "Перевірка до завдання №4:"
    let data4 = [1; 2; 3; 4; 5; 6]
    let sq, ev, sm, res = processData data4
    printfn "Список: %A" data4
    printfn "Квадрати: %A" sq
    printfn "Парні: %A" ev
    printfn "Сума всіх: %d" sm
    printfn "Сума квадратів парних: %d" res

    printfn "Перевірка до завдання №5:"
    let grades = [60; 75; 90; 100; 45; 82; 73]
    let n, f, aB, aA = analyzeGrades grades
    printfn "Початкові оцінки: %A" grades
    printfn "Нормалізовані: %A" (n |> List.map (fun x -> Math.Round(x, 1)))
    printfn "Пройшли фільтр 70: %A" (f |> List.map (fun x -> Math.Round(x, 1)))
    printfn "Середнє до: %.1f" aB
    printfn "Середнє після: %.1f" aA

    0