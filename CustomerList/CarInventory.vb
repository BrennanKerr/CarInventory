
Option Strict On

''' <summary>
''' Author Name:    Alfred Massardo
''' Project Name:   CustomerList
''' Date:           05-Jan-2018
''' Description     Application to keep a list of customers and a little information that describes their importance.
''' </summary>

Public Class frmCustomerList

	Private carList As New SortedList                   ' saves all the cars into the carList
	Private currentCarNumber As String = String.Empty   ' the current car that is selected
	Private editMode As Boolean = False                                 '

	''' <summary>
	''' btnEnter_Click - Validates information
	'''                - If everything is valid, creates a new object from the Car class 
	'''                - The object is added to the carList
	''' </summary>
	''' <param name="sender">Object</param>
	''' <param name="e">EventArgs</param>
	Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

		Dim car As Car            ' declare a Customer class
		Dim carItem As ListViewItem    ' declare a ListViewItem class

		' validate the data in the form
		If IsValidInput() = True Then

			' converts both numeric values to numbers
			Dim year As Integer = Convert.ToInt32(cmbYear.Text)
			Dim price As Double = Convert.ToDouble(tbPrice.Text)

			' set the edit flag to true
			editMode = True

            ' 
            lbResult.Text = "It worked!"

			' if the current car identification number has a no value
			' then this is not an existing item from the listview
			If currentCarNumber.Trim.Length = 0 Then

				' create a new car object using the parameterized constructor
				car = New Car(cmbMakes.Text, tbModel.Text, year, price, chkNew.Checked)

				' add the customer to the customerList collection
				' using the identoification number as the key
				' which will make the customer object easier to
				' find in the customerList collection later
				carList.Add(car.IdentificationNumber.ToString(), car)

			Else
				' if the current car identification number has a value
				' then the user has selected something from the list view
				' so the data in the car object in the customerList collection
				' must be updated

				' so get the car from the cars collection
				' using the selected key
				car = CType(carList.Item(currentCarNumber), Car)

				' update the data in the specific object
				' from the controls
				car.Make = cmbMakes.Text
				car.Model = tbModel.Text
				car.Year = year
				car.Price = price
				car.NewStatus = chkNew.Checked
			End If

			' clear the items from the listview control
			lvwCustomers.Items.Clear()

			' loop through the carList collection
			' and populate the list view
			For Each carEntry As DictionaryEntry In carList

				' instantiate a new ListViewItem
				carItem = New ListViewItem()

				' get the customer from the list
				car = CType(carEntry.Value, Car)

				' assign the values to the ckecked control
				' and the subitems
				carItem.Checked = car.NewStatus
				carItem.SubItems.Add(car.IdentificationNumber.ToString())
				carItem.SubItems.Add(car.Make)
				carItem.SubItems.Add(car.Model)
				carItem.SubItems.Add(car.Year.ToString)
				carItem.SubItems.Add(car.Price.ToString)

				' add the new instantiated and populated ListViewItem
				' to the listview control
				lvwCustomers.Items.Add(carItem)

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
		lbResult.Text = String.Empty

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

		' check if the model is valid
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

		Dim tempPrice As Double

		' check if the price has been entered and is valid
		If tbPrice.Text.Trim.Length = 0 Or Double.TryParse(tbPrice.Text, tempPrice) = False Then
			' If not set the error message
			outputMessage += "Please enter the customer's last name." & vbCrLf

			' And, set the return value to false
			returnValue = False
		End If

		' check to see if any value
		' did not validate
		If returnValue = False Then

			' show the message(s) to the user
			lbResult.Text = "ERRORS" & vbCrLf & outputMessage

		End If

		' return the boolean value
		' true if it passed validation
		' false if it did not pass validation
		Return returnValue

	End Function

	''' <summary>
	''' Event is declared as private because it is only accessible within the form
	''' The code in the btnReset_Click EventHandler will clear the form and set
	''' focus back to the input text box. 
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

		' call the rest sub routine
		Reset()

	End Sub
	''' <summary>
	''' Event is declared as private because it is only accessible within the form
	''' The code in the btnExit_Click EventHandler will close the application
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

		' This will close the form
		Me.Close()

	End Sub

	''' <summary>
	''' lvwCustomers_ItemCheck - used to prevent the user from checking the check box in the list view
	'''                        - if it is not in edit mode
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Private Sub lvwCustomers_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles lvwCustomers.ItemCheck

		' if it is not in edit mode
		If editMode = False Then

			' the new value to the current value
			' so it cannot be set in the listview by the user
			e.NewValue = e.CurrentValue

		End If

	End Sub

	''' <summary>
	''' lvwCustomers_SelectedIndexChanged - when the user selected a row in the list it will populate the fields for editing
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Private Sub lvwCustomers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvwCustomers.SelectedIndexChanged

		' constant that represents the index of the subitem in the list that
		' holds the customer identification number 
		Const identificationSubItemIndex As Integer = 1

		' Get the customer identification number 
		currentCarNumber = lvwCustomers.Items(lvwCustomers.FocusedItem.Index).SubItems(identificationSubItemIndex).Text

		' Use the customer identification number to get the customer from the collection object
		Dim car As Car = CType(carList.Item(currentCarNumber), Car)

		' set the controls on the form
		tbModel.Text = car.Model               ' get the first name and set the text box
		cmbMakes.Text = car.Make                     ' get the title and set the combo box
		cmbYear.Text = car.Year.ToString()
		tbPrice.Text = car.Price.ToString()                 ' get the last name and set the text box
		chkNew.Checked = car.NewStatus ' get the very important person status and set the combo box

		lbResult.Text = car.GetSalutation()


	End Sub

	Private Sub frmCustomerList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

	End Sub

	'Private Sub lvwCustomers_Click(sender As Object, e As EventArgs) Handles lvwCustomers.Click
	'    lbResult.Text = "aaa"
	'End Sub
End Class

