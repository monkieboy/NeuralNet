namespace Perceptron
open System
module Perceptor =
    let bias = 1.0
    let constant = 0.01
 
    let activate sum =
        if sum > 0.0 then 1.0 else -1.0
 
    let feedForward (inputs:list<float>) (weights:list<float>) =
        (0.0, bias :: inputs, weights)
        |||> List.fold2 (fun s i w -> s + i * w)
        |> activate
 
    let rec generateRandomWeights (r:Random) numbers limit =
        //let r = new Random(2)
        let next = (r.Next(-1,1) |> float) :: numbers
        if limit > 0 then 
            generateRandomWeights r next (limit-1)
        else
            numbers

    let train r inputs expected numbers limit =
        let weights = generateRandomWeights r numbers limit
        let guess = feedForward inputs weights
        let error = expected - guess
        (0.0, inputs, weights)
        |||> List.fold2 (fun s i w -> s + (w + constant * error * i))

