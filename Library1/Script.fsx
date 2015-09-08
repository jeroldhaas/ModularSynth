#load "scripts/load-references.fsx"

open Accord
open Accord.Audio
open Accord.Audio.Formats
open Accord.Audio.Filters
open Accord.Audio.Generators
open Accord.DirectSound

let mutable handle = new nativeint(System.Random().Next())

let sinegen = new SineGenerator(2000., 1., 48000)
let output = new AudioOutputDevice(handle, 48000, 2)

// output. causes crash