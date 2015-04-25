namespace Training
open System
open Perceptron
module Trainer =
    
    let train r inputs numbers limit expected =
        let weights = Perceptor.generateRandomWeights r numbers limit
        let guess = Perceptor.feedForward inputs weights
        let error = expected - guess
        (0.0, inputs, weights)
        |||> List.fold2 (fun s i w -> s + (w + Perceptor.constant * error * i))

    let trainer x y a =
        (x,y,1,a)

    let yLine x = 2*x+1

    let evaluatePoint y line =
        if y < line then -1 else 1