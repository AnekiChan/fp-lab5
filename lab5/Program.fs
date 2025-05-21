module Operations =
    let sum a b = a + b
    let difference a b = a - b
    let product a b = a * b
    let division a b = a / b

    let incrementByOne = sum 1
    let increaseByFive = sum 5
    let multiplyByThree = product 3
    let divideByTwo x = division x 2

    let rec computeFactorial n =
        match n with
        | n when n <= 1 -> 1
        | _ -> n * computeFactorial (n - 1)

open Operations

[<EntryPoint>]
let main _ =
    printfn "Сумма: 8 + 4 = %d" (sum 8 4)
    printfn "Разность: 8 - 4 = %d" (difference 8 4)
    printfn "Произведение: 8 * 4 = %d" (product 8 4)
    printfn "Частное: 8 / 4 = %d" (division 8 4)

    printfn "Факториал 5 = %d" (computeFactorial 5)

    printfn "Увеличение на 1: %d" (incrementByOne 9)
    printfn "Увеличение на 5: %d" (increaseByFive 9)
    printfn "Умножение на 3: %d" (multiplyByThree 7)
    printfn "Деление 10 пополам: %d" (divideByTwo 10)

    0
