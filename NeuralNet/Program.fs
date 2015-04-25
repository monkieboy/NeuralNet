namespace NeuralNet
module Program =
    open Perceptron
    open System
    open Training
 
//    [<EntryPoint>]
//    let main argv = 
//        printfn "%A" argv
//        let emptyList = []
//        let r = new Random(2)
//        let weights = Trainer.train r emptyList 3
//        Console.WriteLine (Perceptor.feedForward [50.0;-12.0] weights)
//        while true do Threading.Thread.Sleep(200)
//        0

    let r = new Random(2)    
    
    [<EntryPoint>]
    let main argv = 
        printfn "%A" argv
        let emptyList = []

        let weights = Perceptor.generateRandomWeights r emptyList 3
        let result = Perceptor.feedForward [50.0;-12.0] weights
        Console.WriteLine (result)
        while true do Threading.Thread.Sleep(200)
        0