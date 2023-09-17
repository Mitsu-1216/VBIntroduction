Imports System.Runtime.Serialization.Formatters

Module Module3

    'コメント

    ''' <summary>
    ''' ドキュメントコメント
    ''' </summary>

    Sub Main()
        Dim I As Integer
        Dim J As Integer
        Console.WriteLine("マルチステートメント")
        I = 0 : J = 1

        If I = 0 And
            J = 2 Then
            Console.WriteLine("ステートメント")
        End If

        If I = 0 And
           J = 1 Then
            Console.WriteLine("")
        End If

        '入力値を取得
        Console.ReadLine()

    End Sub

End Module
