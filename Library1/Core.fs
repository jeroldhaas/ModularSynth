namespace ModularSynth

module Core =
    open Microsoft.FSharp.Data.UnitSystems.SI.UnitNames

    module Units =
        [<Measure>] type sample
        [<Measure>] type cycle

    open Units
    let defaultSampleRate = 48000.0<sample/second>
    let defaultFrequency = 440.0<cycle/second>

    module Utilities =
        let unBias xs =
            let max = List.max xs
            let min = List.min xs
            let delta = max - min
            let ratio = 2. / delta
            let scaled = List.map (fun x -> x * ratio) xs
            let newMin = List.min scaled
            let offset = -1. - newMin
            List.map (fun x -> x - offset) scaled // this may need to invert (+)

