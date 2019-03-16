' Car - Class that will be used for each car that is entered
' Brennan kerr
' February 25 2019

Option Strict On

Public Class Car
	Private Shared carCount As Integer
	Private myCarNumber As Integer
	Private myMake As String = String.Empty
	Private myModel As String = String.Empty
	Private myYear As Integer = 0
	Private myPrice As Double = 0.00
	Private myStatus As Boolean = False

	''' <summary>
	''' Constructor - Default - creates a new car object
	''' </summary>
	Public Sub New()
		carCount += 1
		myCarNumber = carCount
	End Sub

	''' <summary>
	''' Constructor - Parameterized - creates a new car object
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
		myStatus = isNew

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

	''' <summary>
	''' Returns the car identification number
	''' </summary>
	''' <returns>myCarNumber - The number assigned for the car</returns>
	Public ReadOnly Property IdentificationNumber() As Integer
		Get
			Return myCarNumber
		End Get
	End Property

	''' <summary>
	''' Returns if the car is new or old
	''' </summary>
	''' <returns>myStatus</returns>
	Public Property NewStatus() As Boolean
		Get
			Return myStatus
		End Get
		Set(value As Boolean)
			myStatus = value
		End Set
	End Property

	''' <summary>
	''' Sets or returns the make of the vehicle
	''' </summary>
	''' <returns>myMake</returns>
	Public Property Make() As String
		Get
			Return myMake
		End Get
		Set(value As String)
			myMake = value
		End Set
	End Property

	''' <summary>
	''' Sets or returns the model of the vehicle
	''' </summary>
	''' <returns>myModel</returns>
	Public Property Model() As String
		Get
			Return myModel
		End Get
		Set(value As String)
			myModel = value
		End Set
	End Property

	''' <summary>
	''' Gets or Sets the year of the vehicle
	''' </summary>
	''' <returns>myYear</returns>
	Public Property Year() As Integer
		Get
			Return myYear
		End Get
		Set(value As Integer)
			myYear = value
		End Set
	End Property

	''' <summary>
	''' Sets or gets the price of the vehicle
	''' </summary>
	''' <returns></returns>
	Public Property Price() As Double
		Get
			Return myPrice
		End Get
		Set(value As Double)
			myPrice = value
		End Set
	End Property

	''' <summary>
	''' Displays a verification message if the vehicle was entered successfully
	''' </summary>
	''' <returns></returns>
	Public Function GetSalutation() As String
		Dim status As String

		' determines the status of the vehicle
		If myStatus = True Then
			status = "new"
		Else
			status = "old"
		End If

		' returns the string that displays all the cars information
		Return "It Worked: A " + myYear.ToString() + " " + myMake + " " + myModel + " was added. The vehicle is " + status + " and is being sold for $" + Math.Round(Price, 2).ToString + "."
	End Function
End Class
