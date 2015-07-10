// include Fake lib
#r @"tools\FAKE\tools\FakeLib.dll"
open Fake 


Target "Foo" (fun _ ->
    trace "Hello World from Foo"
)

Target "Bar" (fun _ -> 
    trace "Hello World from Bar"
)

"Bar"
  ==> "Foo"

RunTargetOrDefault "Foo"