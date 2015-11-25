namespace FizzBuzz.Domain

module FizzBuzzImpl =

  let fizzBuzz number =
    match number with
    | number when number%3 = 0 && number%5 = 0 -> "fizzbuzz"
    | number when number%3 = 0 -> "fizz"
    | number when number%5 = 0 -> "buzz"
    | _ -> number.ToString()

  

