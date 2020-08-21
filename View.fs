module View

open Model
open Msg

let view (model:Model) dispatch =

  let v: Data = model.Value

  dispatch Increment
  dispatch Decrement
  ()
