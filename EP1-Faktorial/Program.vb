﻿Imports System

Module Program
    Sub Main(args As String())
        Dim cislo As Integer
        Dim soucet As Integer = 0

        Console.Write("Zadej èíslo: ")
        cislo = Console.ReadLine

        For i = 1 To cislo
            soucet = soucet + i
        Next

        Console.WriteLine($"Součet od 1 do {cislo} je {soucet}")

    End Sub
End Module
