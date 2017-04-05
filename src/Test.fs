module Test

open Fable.Core
open Fuse
open Fable.Import

let mutable clickCount = 0
let buttonText = Observable.createWith("Button")

let onClick() =
    clickCount <- clickCount + 10
    buttonText.value <- "Clicks: " + (string clickCount)
