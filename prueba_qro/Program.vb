Imports System

Module Program
    Sub MyMain(args As String())
        Module1.Main()
    End Sub
End Module

Public Module Module1
    Public Sub Main()
        'Const IVA As Integer = 0.16    Linea Orginal, error de declaración
        Const IVA As Single = 0.16
        Console.WriteLine("Inserte el valor")
        Dim valor As Double = Console.ReadLine()
        Dim valorIVA = valor * IVA

        ' Console.WriteLine("El valor del IVA es : ".valorIVA)    Linea Original, error de formato y sintaxis
        Console.WriteLine("El valor del IVA es : {0}", valorIVA.ToString("$#,###.###0"))
    End Sub
End Module
