
#r "../node_modules/fable-core/Fable.Core.dll"
#load "../node_modules/fable-fuse/Observable.fs"

open Fable.Core
open Fuse
open Fable.Import

let mutable clickCount = 0
let buttonText = Observable.createWith("Button")

let onClick() =
    printfn "JOJO"
    clickCount <- clickCount + 1
    buttonText.value <- "Clicks: " + (string clickCount)
