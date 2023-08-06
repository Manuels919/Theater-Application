Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    'create array constants
    Private Const NUM_ROWS As Integer = 4
    Private Const NUM_SEATS As Integer = 8

    'ticket price constants and variables

    Private Const ROW_A As Integer = 32
    Private Const ROW_B As Integer = 28
    Private Const ROW_C_D As Integer = 24
    Private Const SALES_TAX As Double = 0.085
    Private dblTotalSales As Double = 0
    Private intTicketsSold As Integer = 0

    'file constants
    Private intNumRows As Integer = 4
    Private intNumSeatsPerRow As Integer = 8
    Private strPatrons(intNumRows * intNumSeatsPerRow - 1, 1) As String

    Private strFilename As String = "seats.txt"

    'file saved boolean
    Private documentSaved As Boolean = True

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'check if file exists. if not populate array with sub procedure byref
        If Not IO.File.Exists(strFilename) Then
            'if seats.txt does not exist create one and fill the seat values
            System.IO.File.Create(strFilename).Close()
            fillSeatValues()

            'display number of seats
            lblTotalSeatsOutput.Text = strPatrons.GetLength(0).ToString()
            'display number of seats remaining
            lblSeatsRemaining.Text = lstAvailableSeats.Items.Count.ToString
            Exit Sub
        Else
            Dim inFile As IO.StreamReader
            inFile = IO.File.OpenText(strFilename)

            'store seat numbers and patrons in 2D array from the access file
            Dim intTwoDimRowNumber As Integer = 0
            Do Until inFile.Peek = -1
                strPatrons(intTwoDimRowNumber, 0) = inFile.ReadLine
                strPatrons(intTwoDimRowNumber, 1) = inFile.ReadLine

                intTwoDimRowNumber += 1
            Loop
            inFile.Close()

            populateSeats()

            'displays the number of seats
            lblTotalSeatsOutput.Text = strPatrons.GetLength(0).ToString()
            'display number of seats remaining
            lblSeatsRemaining.Text = lstAvailableSeats.Items.Count.ToString
        End If

    End Sub

    'subprocedure to refresh the available seats list box
    Private Sub populateSeats()
        'clears list box 
        lstAvailableSeats.Items.Clear()
        'repopulates list box with available seats
        For i As Integer = 0 To strPatrons.GetUpperBound(0)
            If strPatrons(i, 1) = String.Empty Then
                lstAvailableSeats.Items.Add(strPatrons(i, 0))
            End If
        Next

        'when all the seats were sold the application would
        'crash because there would be no value to select
        If lstAvailableSeats.Items.Count <> 0 Then
            'sets the selected index to the first item
            lstAvailableSeats.SelectedIndex = 0
        End If
    End Sub

    'subprocedure to calculate total
    Private Function calculateTotal(seatTax As Double, ticketPrice As Integer) As Double
        Return seatTax + ticketPrice
    End Function

    'subprocedure to calculate sales tax
    Private Function calculateSalesTax(intTicketPrice As Integer) As Double
        'return the Sales tax
        Return intTicketPrice * SALES_TAX
    End Function

    'subprocedure to fill seats if file does not exist
    Private Sub fillSeatValues()
        'i am pretty sure this is not the best way to do it. But it made the most
        'sense in that if the file was not there the user would not be able save the
        'their changes. So by creating the file the application is still able to run
        'and be saved
        'it was also easier to create the structure of the txt file and then read it
        'into the array than it was to add the values directly to the 2D array

        'in the newly created seats file write to it
        Dim outFile As New System.IO.StreamWriter(strFilename)
        For i As Integer = 1 To NUM_ROWS
            For j As Integer = 1 To NUM_SEATS
                outFile.WriteLine(Chr(64 + i).ToString + j.ToString)
                outFile.WriteLine()
            Next
        Next
        outFile.Close()

        Dim inFile As IO.StreamReader
        inFile = IO.File.OpenText(strFilename)

        'after writing to it read the file into strPatrons and populate list box
        Dim intTwoDimRowNumber As Integer = 0
        Do Until inFile.Peek = -1
            strPatrons(intTwoDimRowNumber, 0) = inFile.ReadLine
            strPatrons(intTwoDimRowNumber, 1) = inFile.ReadLine

            intTwoDimRowNumber += 1
        Loop

        inFile.Close()
        populateSeats()
    End Sub

    Private Sub lstAvailableSeats_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstAvailableSeats.SelectedIndexChanged
        'when user selects a seat display ticket price including tax(use function)
        Dim strSeat As String = lstAvailableSeats.SelectedItem.ToString()

        If strSeat.Contains("A") Then
            Dim seatTax As Double = calculateSalesTax(ROW_A)
            Dim total As Double = calculateTotal(seatTax, ROW_A)

            lblTicketPriceOutput.Text = ROW_A.ToString("c2")
            lblTaxOutput.Text = seatTax.ToString("c2")
            lblTotalOutput.Text = total.ToString("c2")

        End If

        If strSeat.Contains("B") Then
            Dim seatTax As Double = calculateSalesTax(ROW_B)
            Dim total As Double = calculateTotal(seatTax, ROW_B)

            lblTicketPriceOutput.Text = ROW_B.ToString("c2")
            lblTaxOutput.Text = seatTax.ToString("c2")
            lblTotalOutput.Text = total.ToString("c2")

        End If

        If strSeat.Contains("C") Or strSeat.Contains("D") Then
            Dim seatTax As Double = calculateSalesTax(ROW_C_D)
            Dim total As Double = calculateTotal(seatTax, ROW_C_D)

            lblTicketPriceOutput.Text = ROW_C_D.ToString("c2")
            lblTaxOutput.Text = seatTax.ToString("c2")
            lblTotalOutput.Text = total.ToString("c2")

        End If
    End Sub
    Private Function propercase(strName As String) As String
        Return strName(0).ToString.ToUpper + strName.Substring(1).ToLower
    End Function

    Private Sub btnSellSeat_Click(sender As Object, e As EventArgs) Handles btnSellSeat.Click
        'program crashes if users attempts to purchase ticket
        'when there are none left. so display a message and exit sub
        If lstAvailableSeats.Items.Count = 0 Then
            MessageBox.Show("There Are No More Available Seats",
                          "Sold Out",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Information)
            Exit Sub
        Else
            'when user enters first and last name "sell" the seat. display warning if this fails
            'save the data into access file on manual save
            If txtName.Text.Trim = "" Then
                MessageBox.Show("Please Enter a Valid Name",
                                "Input Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error)
                Exit Sub
            End If

            'proper case function to make sure first and last name are entered by user
            'displays error message if not
            Dim strFullName As String = txtName.Text.Trim()
            Dim intSpace As Integer = strFullName.IndexOf(" "c)

            If intSpace = -1 Then
                MessageBox.Show("Please Enter First and Last Name",
                                "Input Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error)
                Exit Sub
            Else
                Dim strFirstName As String = propercase(strFullName.Substring(0, intSpace))
                Dim strLastName As String = propercase(Trim(strFullName.Substring(intSpace + 1)))

                '"sells" selected seat by assignning name to second column value
                For i As Integer = 0 To strPatrons.GetUpperBound(0)
                    If lstAvailableSeats.SelectedItem.ToString = strPatrons(i, 0) Then
                        strPatrons(i, 1) = (strFirstName + " " + strLastName)
                    End If
                Next
            End If

            'refreshes available seats in list box
            populateSeats()

            'if user makes a change to the document a message will pop up prompting the user to save
            documentSaved = False

            'everytime a seat is sold the total value that was displayed to the user is
            'added to total sales
            'and increments the total sales dbl which is then displayed
            dblTotalSales += Double.Parse(lblTotalOutput.Text.Remove(0, 1))
            lblTotalSalesOutput.Text = dblTotalSales.ToString("C2")

            'everytime a seat is sold intTicketsSold is incremented
            intTicketsSold += 1
            lblTicketsSoldOutput.Text = intTicketsSold.ToString

            'seats remaining is also adjusted
            lblSeatsRemaining.Text = lstAvailableSeats.Items.Count.ToString

            txtName.Focus()
        End If
    End Sub

    Private Sub btnSave(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click, btnSaveData.Click

        'document saved is defaulted to True. if the user has made changes it will save as normal
        'however if the user saved previously and attempts to save again without making changes
        'it well tell the user the file has already been saved and exit the sub
        If documentSaved Then
            MessageBox.Show("File Already Saved",
                                "Save",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information)
            Exit Sub
        Else
            'initialize stream writer to the seats.txt file
            Dim outFile As New System.IO.StreamWriter(strFilename)
            'loop through 2D array and rewrite file with sold seats
            For I As Integer = 0 To strPatrons.GetUpperBound(0)
                For J As Integer = 0 To strPatrons.GetUpperBound(1)
                    outFile.WriteLine(strPatrons(I, J))
                Next
            Next
            MessageBox.Show("File Saved Successfully",
                                "Save",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information)
            outFile.Close()

            'Once user saves the document warning message will no longer appear
            documentSaved = True

        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        If documentSaved Then
            Me.Close()
        Else
            MessageBox.Show("Please Save File Before Exiting",
                                "Save",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub ResetSeatsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetSeatsToolStripMenuItem.Click
        'if the user confirms that they want to reset seats then reset and reload list box
        'with new seats
        'if not then exit the sub
        If MessageBox.Show("Are you Sure?",
                           "Confirmation",
                           MessageBoxButtons.YesNo,
                            MessageBoxIcon.Exclamation) = DialogResult.Yes Then
            'loops through the array if the seat is not empty then erase the name
            For i As Integer = 0 To strPatrons.GetUpperBound(0)
                If strPatrons(i, 1) <> String.Empty Then
                    strPatrons(i, 1) = ""
                End If
            Next
            'allows user to save changes once seats are reset
            documentSaved = False
        Else
            Exit Sub
        End If

        populateSeats()

        'display number of seats remaining after reset
        lblSeatsRemaining.Text = lstAvailableSeats.Items.Count.ToString
    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'if the user has saved then close the document as normal
        If documentSaved Then
            e.Cancel = False
        Else
            'if document hasnt been saved ask the user if they are sure
            If MessageBox.Show("Exit Without Saving?",
                           "Question",
                           MessageBoxButtons.YesNo,
                            MessageBoxIcon.Exclamation) = DialogResult.Yes Then
                e.Cancel = False
            Else
                e.Cancel = True
            End If
        End If

    End Sub
End Class
