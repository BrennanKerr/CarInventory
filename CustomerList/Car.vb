' Car - Class that will be used for each car that is entered
' Brennan kerr
' February 25 2019

Option Strict On

Public Class Car
	Private Shared carCount As Integer = 0
	Private myCarNumber As Integer = 0
	Private myMake As String = String.Empty
	Private myModel As String = String.Empty
	Private myYear As Integer = 0
	Private myPrice As Double = 0.00
	Private myNew As Boolean = False

	''' <summary>
	''' Constructor - Default - creates a new customer object
	''' </summary>
	Public Sub New()
		carCount += 1
		myCarNumber = carCount
	End Sub

	''' <summary>
	''' Constructor - Parameterized - creates a new customer object
	''' </summary>
	''' <param name="make">The make of the vehicle</param>
	''' <param name="model">The model of the vehicle</param>
	''' <param name="price">The price of the vehicle</param>
	''' <param name="year">The year of the vehicle</param>
	Public Sub New(make As String, model As String, year As Integer, price As Double, isNew As Boolean)

		' calls for the other constructor.
		' Will determine the current ID based on the current count
		Me.New()

		' assigns the vehicles attributes based on the input
		myMake = make
		myModel = model
		myYear = year
		myPrice = price
		myNew = isNew

	End Sub

	''' <summary>
	''' Gets the current count
	''' </summary>
	''' <return>carCount</return>
	Public ReadOnly Property Count() As Integer
		Get
			Return carCount
		End Get
	End Property


	Public ReadOnly Property IdentificationNumber() As Integer
		Get
			Return IdentificationNumber
		End Get
	End Property

	Public Property NewStatus() As Boolean
		Get
			Return myNew
		End Get
		Set(value As Boolean)
			myNew = value
		End Set
	End Property



	Public Property Make() As String
		Get
			Return myMake
		End Get
		Set(value As String)
			myMake = value
		End Set
	End Property


	Public Property Model() As String
		Get
			Return myMake
		End Get
		Set(value As String)
			myMake = value
		End Set
	End Property

	Public Property Year() As Integer
		Get
			Return myYear
		End Get
		Set(value As Integer)
			myYear = value
		End Set
	End Property


	Public Property Price() As Double
		Get
			Return myPrice
		End Get
		Set(value As Double)
			myPrice = value
		End Set
	End Property

	Public Function GetSalutaion() As String
		Return "It Worked"
	End Function
End Class
