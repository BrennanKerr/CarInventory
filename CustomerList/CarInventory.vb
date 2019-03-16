
Option Strict On

''' <summary> (Initial CustomerList) - Used as baseline
''' Author Name:    Alfred Massardo
''' Project Name:   CustomerList
''' Date:           05-Jan-2018
''' Description     Application to keep a list of customers and a little information that describes their importance.
''' 
''' (New Car Inventory)
''' Author Name:	Brennan Kerr
''' Project Name:	Car Inventory
''' Date:			25-Feb-2019
''' Description:	Keeps a list of cars with information such as make, model, year, price, and if it is new
''' </summary>
Public Class frmCarInventory

	Private carList As New SortedList                   ' saves all the cars into the carList
	Private currentCarNumber As String = String.Empty   ' the current car that is selected
	Private editMode As Boolean = False                                 '

	Private Sub frmCustomerList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

	End Sub

	''' <summary>
	''' EnterValues - Validates information
	'''                - If everything is valid, creates a new object from the Car class 
	'''                - The object is added to the carList
	''' </summary>
	''' <param name="sender">Object</param>
	''' <param name="e">EventArgs</param>
	Private Sub EnterValues(sender As Object, e As EventArgs) Handles btnEnter.Click

		Dim car As Car                  ' declare a Customer class
		Dim carItem As ListViewItem     ' declare a ListViewItem class

		' validate the data in the form
		If IsValidInput() = True Then

			' converts both numeric values to numbers to reduce redundancy
			Dim year As Integer = Convert.ToInt32(cmbYear.Text)
			Dim price As Double = Convert.ToDouble(tbPrice.Text)

			' set the edit flag to true
			editMode = True

			' lets the user know the data was valid and saved
			lbResult.Text = "It worked! Information saved to inventory!"

			' if the current car identification number has no value
			' create a new object as it is not in the inventory
			If currentCarNumber.Trim.Length = 0 Then

				' create a new car object using the parameterized constructor
				car = New Car(cmbMakes.Text, tbModel.Text, year, price, chkNew.Checked)

				' adds the car to the list
				carList.Add(car.IdentificationNumber.ToString(), car)

			Else
				' since there is already an identification number for the designated car
				' the user is wishing to customize an already existing one.
				' The desired car is determined by the current car number that was selected
				car = CType(carList.Item(currentCarNumber), Car)

				' update the data in the specific object
				' from the controls
				car.Make = cmbMakes.Text
				car.Model = tbModel.Text
				car.Year = year
				car.Price = price
				car.NewStatus = chkNew.Checked
			End If

			lbResult.Text = car.GetSalutation()     ' creates a message to notify the user the car was entered successfully

			' clear the items from the listview control
			lvwCars.Items.Clear()

			' loop through the carList collection
			' and populate the list view
			For Each carEntry As DictionaryEntry In carList

				' instantiate a new ListViewItem
				carItem = New ListViewItem()

				' get the customer from the list
				car = CType(carEntry.Value, Car)

				' assign the values to the checked control
				' and the subitems
				carItem.Checked = car.NewStatus
				carItem.SubItems.Add(car.IdentificationNumber.ToString())
				carItem.SubItems.Add(car.Make)
				carItem.SubItems.Add(car.Model)
				carItem.SubItems.Add(car.Year.ToString)
				carItem.SubItems.Add("$" + Math.Round(car.Price, 2).ToString)

				' adds the cars to the list view
				lvwCars.Items.Add(carItem)

			Next carEntry

			' clear the controls
			Reset()

			' set the edit flag to false
			editMode = False

		End If

	End Sub

	''' <summary>
	''' Reset - set the controls back to their default state.
	''' </summary>
	Private Sub Reset()

		tbModel.Text = String.Empty
		tbPrice.Text = String.Empty
		chkNew.Checked = False
		cmbMakes.SelectedIndex = -1
		cmbYear.SelectedIndex = -1

		currentCarNumber = String.Empty

	End Sub

	''' <summary>
	''' IsValidInput - validates the data in each control to ensure that the user has entered apprpriate values
	''' </summary>
	''' <returns>Boolean</returns>
	Private Function IsValidInput() As Boolean

		Dim returnValue As Boolean = True
		Dim outputMessage As String = String.Empty

		' check if the make has been selected
		If cmbMakes.SelectedIndex = -1 Then

			' If not set the error message
			outputMessage += "Please select the car's make." & vbCrLf

			' And, set the return value to false
			returnValue = False

		End If

		' checks to see if a model was entered
		If tbModel.Text.Trim.Length = 0 Then

			' If not set the error message
			outputMessage += "Please enter the car's model." & vbCrLf

			' And, set the return value to false
			returnValue = False

		End If

		' check if the year has been selected
		If cmbYear.SelectedIndex = -1 Then
			' If not set the error message
			outputMessage += "Please select the car's year." & vbCrLf

			' And, set the return value to false
			returnValue = False
		End If

		' creates a temporary variable for the price
		Dim tempPrice As Double

		' check if the price has been entered and is valid
		If tbPrice.Text.Trim.Length = 0 Then
			' If not set the error message
			outputMessage += "Please enter the car's price." & vbCrLf

			' And, set the return value to false
			returnValue = False

		ElseIf Double.TryParse(tbPrice.Text, tempPrice) = False Then
			' notify the user the input was not a number
			outputMessage += "The Price is not a number! You Entered: " + tbPrice.Text

			tbPrice.Text = ""
			returnValue = False

		ElseIf tempPrice < 0 Then
			' notify the user the price is less than 0
			outputMessage += "The price is less than 0! You Entered: " + tbPrice.Text

			tbPrice.Text = ""
			returnValue = False
		End If

		' check to see if any value
		' did not validate
		If returnValue = False Then

			' show the message(s) to the user
			lbResult.Text = "ERRORS" & vbCrLf & outputMessage

		End If

		' if the return value is true, that means the validation was valid
		' if it is false, an error arised.
		Return returnValue

	End Function

	''' <summary>
	''' Gets called whenever the user hits the reset button.
	''' Goes to the method Reset()
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Private Sub ResetValues(sender As Object, e As EventArgs) Handles btnReset.Click

		' call the rest sub routine
		Reset()

	End Sub
	''' <summary>
	''' Called whenever the user wants to exit the application
	''' Closes the program
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

		' This will close the form
		Me.Close()

	End Sub

	''' <summary>
	''' Disallows the editing of the checkboxes if the car has not been selected
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Private Sub DisallowEdit(sender As Object, e As ItemCheckEventArgs) Handles lvwCars.ItemCheck

		' if it is not in edit mode
		If editMode = False Then

			' the new value to the current value
			' so it cannot be set in the listview by the user
			e.NewValue = e.CurrentValue

		End If

	End Sub

	''' <summary>
	''' CheckIndex - determine which index (car) the user wants to edit
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Private Sub CheckIndex(sender As Object, e As EventArgs) Handles lvwCars.SelectedIndexChanged

		' determines if a item is selected (fixes issues of crashes)
		If lvwCars.FocusedItem IsNot Nothing Then

			'If Not IsNothing(lvwCars.FocusedItem) Then
			' constant that represents the index of the subitem in the list that
			' holds the customer identification number 
			Const identificationSubItemIndex As Integer = 1

			' Get the customer identification number 
			currentCarNumber = lvwCars.Items(lvwCars.FocusedItem.Index).SubItems(identificationSubItemIndex).Text

			' Use the customer identification number to get the customer from the collection object
			Dim car As Car = CType(carList.Item(currentCarNumber), Car)

			' set the controls on the form
			cmbMakes.Text = car.Make                ' gets the name of the make
			tbModel.Text = car.Model                ' gets the name of the model
			cmbYear.Text = car.Year.ToString()      ' gets the year of the vehicle
			tbPrice.Text = car.Price.ToString()     ' gets the price of the vehicle
			chkNew.Checked = car.NewStatus          ' determines if the vehicle is new
		End If

	End Sub

End Class

