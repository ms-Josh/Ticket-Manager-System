Imports System
Imports System.Collections.Generic
Imports MongoDB.Driver

Namespace UniqueTicketingNamespace

    Public Class TicketManager

        ' MongoDB connection components
        Private client As MongoClient
        Private database As IMongoDatabase
        Private ticketsCollection As IMongoCollection(Of Ticket)

        ' Ticket model
        Public Class Ticket
            Public Property Id As String
            Public Property Title As String
            Public Property Description As String
            Public Property Status As String
        End Class

        ' Ticket pricing by stage
        Private ticketPrices As New Dictionary(Of String, (adult As Integer, child As Integer)) From {
            {"group_stage", (50, 50)},
            {"quarter_finals", (65, 50)},
            {"semi_finals", (120, 50)},
            {"final", (150, 50)}
        }

        ' Ticket inventory by stage
        Private ticketInventory As New Dictionary(Of String, Integer) From {
            {"group_stage", 85000},
            {"quarter_finals", 85000},
            {"semi_finals", 85000},
            {"final", 85000}
        }

        ' Constructor: initialize MongoDB connection
        Public Sub New()
            client = New MongoClient("mongodb://localhost:27017")
            database = client.GetDatabase("TicketSystemDB")
            ticketsCollection = database.GetCollection(Of Ticket)("Tickets")
        End Sub

        ' Calculate total cost based on stage and ticket quantities
        Public Function CalculateTotal(stage As String, numAdults As Integer, numChildren As Integer) As Integer
            If Not ticketPrices.ContainsKey(stage) Then
                Throw New ArgumentException("Invalid stage selected")
            End If

            Dim prices = ticketPrices(stage)
            Dim total As Integer = (numAdults * prices.adult) + (numChildren * prices.child)
            Return total
        End Function

        ' Print ticket details and update inventory
        Public Sub PrintTicket(stage As String, numAdults As Integer, numChildren As Integer, total As Integer)
            If Not ticketInventory.ContainsKey(stage) OrElse ticketInventory(stage) < (numAdults + numChildren) Then
                Throw New InvalidOperationException("Not enough tickets available for the selected stage")
            End If

            ticketInventory(stage) -= (numAdults + numChildren)

            Dim ticketInfo As String = $"
Stage: {stage}
Number of Adults: {numAdults}
Number of Children: {numChildren}
Total Amount: ${total}
Tickets Remaining: {ticketInventory(stage)}
"
            Console.WriteLine(ticketInfo)
        End Sub

        ' Reset form fields (placeholder)
        Public Sub ResetForm()
            ' Logic to reset form fields
        End Sub

        ' Add a new ticket to the database
        Public Sub AddTicket(ticket As Ticket)
            ticketsCollection.InsertOne(ticket)
        End Sub

        ' Retrieve all tickets from the database
        Public Function GetAllTickets() As List(Of Ticket)
            Return ticketsCollection.Find(Function(t) True).ToList()
        End Function

        ' Update an existing ticket
        Public Sub UpdateTicket(ticket As Ticket)
            Dim filter = Builders(Of Ticket).Filter.Eq(Function(t) t.Id, ticket.Id)
            ticketsCollection.ReplaceOne(filter, ticket)
        End Sub

        ' Delete a ticket by ID
        Public Sub DeleteTicket(id As String)
            Dim filter = Builders(Of Ticket).Filter.Eq(Function(t) t.Id, id)
            ticketsCollection.DeleteOne(filter)
        End Sub

    End Class

End Namespace
