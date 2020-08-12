module View

open Fable.React
open Fable.React.Props
open Model
open Msg

let view (model:Model) dispatch =

  let v: Data = model.Value

  div []
      [ button [ OnClick (fun _ -> dispatch Increment) ] [ str "+" ]
        div [] [ str (string v) ]
        button [ OnClick (fun _ -> dispatch Decrement) ] [ str "-" ] ]
