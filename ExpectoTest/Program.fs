open Expecto
open System

let tests =
    testList "Simple tests" [
        yield test "Simple" { Expect.containsAll [0; 1; 3; 2] [1; 2] "foo" }
        yield!
            testParam (2, 4) [
                "One", fun (n, dn) () -> Expect.equal (n + n) dn (sprintf "%d + %d = %d" n n dn)
            ]
    ]

[<EntryPoint>]
let main argv = 
    runTestsWithArgs defaultConfig argv tests |> ignore
    Console.ReadKey() |> ignore
    0