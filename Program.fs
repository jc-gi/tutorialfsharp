module declararacionVariables =

    let a = 5

    printfn "El valor de a= %d" a  ///%d se utiliza para enteros

    let b = 3.13

    printfn "El valor de b = %f" b ///%f se utiliza para flotantes

    let varBoleano = true
    let varBoleano2= false

    let resultBoleano = not varBoleano && not varBoleano2

    printfn "El valor resultante es = %b " resultBoleano

    let string1 = "Teoria"
    let string2 = "Computacional"

    printfn "La cadena es = %s" string1
    let string3 = string1 + " " + string2
    printfn "La cadena completa es = %s" string3

    let substring = string3.[0..6]
    printfn "La subcadena de string3 = %s" substring  


    /// dato [1] -> especificar la direccion que se une con el siguiente elemento

    let list = [1;2;3;4;5]
    printfn "%A" list;;
    let list2 = [
        1
        2
        3
        4
        5
    ]
    printfn "%A" list2;;
    let list3 = [1 .. 200]
    ///printfn "%A" list3;;

    let array1 = [|1;2;3;4;5|]
    printfn "%A" array1

    ///|0 1|
    ///|1 0|
    let matriz = array2D [[0;1];[1;0]]
    printfn "%A" matriz
    
    module condicionales =
        let test x y =
            if x = y then "iguales"
            elif x < y then "Es menor"
            else "Es mayor"

        printfn "%d %s %d " 10 (test 10 20) 20 
        printfn ""

        let funcion() =
            for i=1 to 10 do 
                printfn "%d" i
            printfn ""

        ///funcion()

        let funcion2 () =
            for i = 10 downto 1 do
                printfn "%d" i
            printfn ""

        ///funcion2()


        let inicio x y = x - 2*y  // 10 - 2*4 = 2 Rango inicial 
        let fin x y = x + 2*y     // 10 + 2*4 = 18 Rango final

        let funcion3 x y =
            for i = (inicio x y) to (fin x y) do
                printfn "%d" i 
            printfn ""

        ///funcion3 10 4

        let list4 = [1;2;3;4;5]
        for i in list4 do
            printfn "%d" i
            printfn""   

        let secuencia = seq { for i in 1..10 ->(i, i*i) }
        for (a, asqr) in secuencia do
            printfn "%d su raiz cuadrada es %d" a asqr
            printfn ""

        let funcionchar () =
            for c in 'a' .. 'z' do
                printfn "%c" c 
            printfn ""
        
        funcionchar()

        let mutable x = 4
        while x >= 0 do
            printfn "%A" x
            x <- x - 1
            printfn ""

        /// Case o Switch permite elegir dentro de diferentes valores 

        let patron = 
            match 1 with
            | 1 -> "a"
            | 2 -> "b"
            | _ -> "cualquier caracter"
        
    ///Funciones recursivas
    ///Declaracion 

    module recursividad =

        let rec factorial n = 
            if n = 0 then  1 else n * factorial (n-1)

        printfn "Factorial de 0 es = %d" (factorial 0)


        

       

         

     







