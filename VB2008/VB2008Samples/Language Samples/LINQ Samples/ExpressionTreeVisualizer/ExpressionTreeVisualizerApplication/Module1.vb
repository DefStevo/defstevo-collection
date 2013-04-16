﻿Imports Microsoft.VisualStudio.DebuggerVisualizers
Imports System.Linq.Expressions

Module Module1

    ' The Expression Tree Visualizer can be used in a debug environment to visualize expressions.  To use 
    ' the visualizer the dll generated by the ExpressionTreeVisualizer project must be copied to 
    ' \My Documents\Visual Studio Codename Orcas\Visualizers.  This console program provides the ability to
    ' host the visualizer outside of Visual Studio without copying the DLL.
    Sub Main()
        Dim introduction = "The Visualizer may be hidden behind a window. Try the GuiHost."
        Console.WriteLine(introduction)
        Dim expr As Expression(Of Func(Of Integer, Boolean)) = Function(x) x = 10
        Dim host = New VisualizerDevelopmentHost(expr, _
                    GetType(ExpressionTreeVisualizer), _
                    GetType(ExpressionTreeVisualizerObjectSource))
        host.ShowVisualizer()
    End Sub

End Module
