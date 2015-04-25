namespace NeuralNet
module Program =
    open Perceptron
    open System
 
    [<EntryPoint>]
    let main argv = 
        printfn "%A" argv
        let emptyList = []
        let r = new Random(2)
        let weights = Perceptor.generateRandomWeights r emptyList 3
        Console.WriteLine (Perceptor.feedForward [50.0;-12.0] weights)
        while true do Threading.Thread.Sleep(200)
        0