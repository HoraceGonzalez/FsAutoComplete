﻿namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("FSharp.AutoComplete")>]
[<assembly: AssemblyProductAttribute("FSharp.AutoComplete")>]
[<assembly: AssemblyDescriptionAttribute("A command line tool for interfacing with FSharp.Compiler.Service over a pipe.")>]
[<assembly: AssemblyVersionAttribute("0.19.0")>]
[<assembly: AssemblyFileVersionAttribute("0.19.0")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "0.19.0"
