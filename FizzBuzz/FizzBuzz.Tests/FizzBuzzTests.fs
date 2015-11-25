namespace FizzBuzz.Tests

open NUnit.Framework
open Swensen.Unquote
open FizzBuzz.Domain.FizzBuzzImpl

[<TestFixture>]
module FizzBuzzTests =

  [<Test>]
  let `` one returns one `` () =
    let expected = "1"
    let actual = fizzBuzz 1
    test <@ expected = actual @>

  [<Test>]
  let `` 3 returns fizz `` () =
    let expected = "fizz"
    let actual = fizzBuzz 3
    test <@ expected = actual @>

  [<Test>]
  let `` 5 returns buzz `` () =
    let expected = "buzz"
    let actual = fizzBuzz 5
    test <@ expected = actual @>

  [<Test>]
  let `` 15 returns fizzbuzz `` () =
    let expected = "fizzbuzz"
    let actual = fizzBuzz 15
    test <@ expected = actual @>
