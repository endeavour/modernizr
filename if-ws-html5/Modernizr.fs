﻿// $begin{copyright}
//
// This file is confidential and proprietary.
//
// Copyright (c) IntelliFactory, 2004-2010.
//
// All rights reserved.  Reproduction or use in whole or in part is
// prohibited without the written consent of the copyright holder.
//-----------------------------------------------------------------
// $end{copyright}

namespace IntelliFactory.WebSharper.Html5

module Modernizr =
    open IntelliFactory.WebSharper.InterfaceGenerator
    open IntelliFactory.WebSharper.Utils

    let inline RenamedGetter (s: string) (t) (n: int) =
        s =? t |> WithSourceName (Renamer.Rename s n)

    let Availability =
        let Availability = Class "Availability"
        Availability
        |+> [
            "maybe" =? Availability 
            "probably" =? Availability
            "notAvailable" =? Availability |> WithGetterInline "''"
        ]
    
    let AudioFormat = 
        let AudioFormat = Class "AudioFormat"
        AudioFormat
        |+> Protocol [
            "ogg" =? Availability
            "mp3" =? Availability
            "wav" =? Availability
            "m4a" =? Availability
        ]
    
    let VideoFormat = 
        let VideoFormat = Class "VideoFormat"
        VideoFormat
        |+> Protocol [
            "ogg" =? Availability
            "h264" =? Availability
        ]
    
    let InputType =     
        let InputType = Class "InputType"
        InputType
        |+> Protocol [
            "search" =? T<bool>
            "tel" =? T<bool>
            "url" =? T<bool>
            "email" =? T<bool>
            "datetime" =? T<bool> |> WithSourceName "DateTime"
            "date" =? T<bool>
            "month" =? T<bool>
            "week" =? T<bool>
            "time" =? T<bool>
            "datetime-local" =? T<bool> |> WithSourceName "DateTimeLocal"
            "number" =? T<bool>
            "range" =? T<bool>
            "color" =? T<bool>
        ]
    
    let Input =     
        let Input = Class "Input"
        Input
        |+> Protocol [
            "autocomplete" =? T<bool>
            "autofocus" =? T<bool>
            "list" =? T<bool>
            "placeholder" =? T<bool>
            "max" =? T<bool>
            "min" =? T<bool>
            "multiple" =? T<bool>
            "pattern" =? T<bool>
            "required" =? T<bool>
            "step" =? T<bool>
        ]
    
    
    let Modernizr = 
        Class "Modernizr"
        |+> [
            "fontface" =? T<bool>
            "canvas" =? T<bool>
            RenamedGetter "canvastext" T<bool> 2
            "audio" =? T<bool>
            "video" =? T<bool>
            "rgba" =? T<bool>
            "hsla" =? T<bool>
            RenamedGetter "borderimage" T<bool> 2
            RenamedGetter "borderradius" T<bool> 2
            RenamedGetter "boxshadow" T<bool> 2
            "multiplebgs" =? T<bool>
            RenamedGetter "backgroundsize" T<bool> 2
            "opacity" =? T<bool>
            "cssanimations" =? T<bool>
            "csscolumns" =? T<bool>
            "cssgradients" =? T<bool>
            "cssreflections" =? T<bool>
            "csstransforms" =? T<bool>
            "csstransforms3d" =? T<bool>
            "csstransitions" =? T<bool>
            "geolocation" =? T<bool> 
            RenamedGetter "localstorage" T<bool> 2
            RenamedGetter "sessionstorage" T<bool> 2
            RenamedGetter "webworkers" T<bool> 2
            RenamedGetter "applicationcache" T<bool> 2
            "svg" =? T<bool>
            "svgclippaths" =? T<bool>
            "smil" =? T<bool>
            "websqldatabase" =? T<bool>
            "indexeddb" =? T<bool>
            RenamedGetter "websockets" T<bool> 2
            RenamedGetter "hashchange" T<bool> 2
            RenamedGetter "historymanagement" T<bool> 2
            RenamedGetter "draganddrop" T<bool> 3
            RenamedGetter "crosswindowmessaging" T<bool> 3
            RenamedGetter "audioformat" AudioFormat 2
            RenamedGetter "videoformat" VideoFormat 2
            RenamedGetter "inputtypes" InputType 2
            "input" =? Input
        ]
    
    let Assembly =
        Assembly [
            Namespace "IntelliFactory.WebSharper.Modernizr" [
                 Modernizr
            ]
        ]
