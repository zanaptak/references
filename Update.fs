module Update

open Model
open Msg

let init() : Model = { Value = 0 }

let update (msg:Msg) (model:Model) =
    match msg with
    | Increment -> { model with Value = model.Value + 1 }
    | Decrement -> { model with Value = model.Value - 1 }
