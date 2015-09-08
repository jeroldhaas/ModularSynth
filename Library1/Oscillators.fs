namespace ModularSynth

module Oscillators =
    open FSharpx.Collections
    open Microsoft.FSharp.Data.UnitSystems.SI.UnitNames
    open Core
    open Units

    type SineOscillator() =
        static member Generate (sampleRate:float<sample/second>) (frequency:float<cycle/second>) =
            let periodLength = sampleRate / frequency // TODO: dunno if this is useful yet
            