Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Runtime.CompilerServices
Imports Microsoft.Test.CommandLineParsing
Module Module1

#Region "Constants"

  Public Const Gray100 = " "c
  Public Const Gray090 = "."c
  Public Const Gray080 = "*"c
  Public Const Gray070 = ":"c
  Public Const Gray060 = "o"c
  Public Const Gray050 = "&"c
  Public Const Gray040 = "8"c
  Public Const Gray030 = "#"c
  Public Const Gray020 = "@"c
#End Region

  Public Function GetPixels(bmp As Bitmap) As IEnumerable(Of Color)
    Return From x In Enumerable.Range(0, bmp.Width - 1)
           From y In Enumerable.Range(0, bmp.Height - 1)
           Select bmp.GetPixel(y, x)
  End Function



  Public Function GrayScalePixels(pixels As IEnumerable(Of Color)) As IEnumerable(Of Color)
    Return From p In pixels
           Let g = 0.3 * p.R + 0.59 * p.G + 0.11 * p.B
           Select p = Color.FromArgb(g, g, g)
  End Function

  Public Function GetChars(pixels As IEnumerable(Of Color)) As IEnumerable(Of Char)
    Return From p In pixels
    Select If(p.R >= 230, Gray100, If(p.R >= 200, Gray090, If(p.R >= 180, Gray080, If(p.R >= 160, Gray070, If(p.R >= 130, Gray060, If(p.R >= 100, Gray050, If(p.R >= 70, Gray040, If(p.R >= 50, Gray030, Gray020))))))))

  End Function
  Sub Main(args As String())
    Dim currentColor As ConsoleColor = Console.ForegroundColor
    ' use the TestAPI to parse command args
    Dim dictionary = CommandLineDictionary.FromArguments(args)

    Dim myArgs = New CommandLineArgs()
    CommandLineParser.ParseArguments(myArgs, args)

    ' Dim imageNameArg = dictionary("imageName")

    Dim myConsoleColor As ConsoleColor
    Dim ok = [Enum].TryParse(Of ConsoleColor)(myArgs.Color, True, myConsoleColor)
    If (ok = False) Then
      myConsoleColor = currentColor
    End If
    'Dim colorArg = arguments.ContainsKey("color")
    'CommandLineParser()

    SetupConsole()

    Console.ForegroundColor = myConsoleColor
    ' check for file exist
    If File.Exists(myArgs.ImageName) = False Then
      Console.WriteLine("Image file doesn't exist")
      Exit Sub
    End If

    Dim img As Image = Image.FromFile(myArgs.ImageName)
    Dim bmp As New Bitmap(img, 150, 150)
    Dim parts = GetChars(GrayScalePixels(GetPixels(bmp))).Chunk(bmp.Width - 1).Select(Function(part) String.Join("", part))

    Dim data = String.Join(vbCrLf, parts)


    For Each part In parts
      Console.WriteLine(part)
    Next

    File.WriteAllText("AsciiArt.txt", data)
    Console.ReadLine()
  End Sub
  Sub SetupConsole()
    Console.WindowWidth = Console.LargestWindowWidth - 5
    Console.WindowHeight = Console.LargestWindowHeight - 5

  End Sub
  <Extension> _
  Public Iterator Function Chunk(Of T)(source As IEnumerable(Of T), chunksize As Integer) As IEnumerable(Of IEnumerable(Of T))
    While source.Any()
      Yield source.Take(chunksize)
      source = source.Skip(chunksize)
    End While
  End Function
End Module

Public Class CommandLineArgs

  Private _ImageName As String
  Public Property ImageName() As String
    Get
      Return _ImageName
    End Get
    Set(ByVal value As String)
      _ImageName = value
    End Set
  End Property
  Private _Color As String
  Public Property Color() As String
    Get
      Return _Color
    End Get
    Set(ByVal value As String)
      _Color = value
    End Set
  End Property
  Private _Pixelate As String
  Public Property Pixelate() As String
    Get
      Return _Pixelate
    End Get
    Set(ByVal value As String)
      _Pixelate = value
    End Set
  End Property



End Class
