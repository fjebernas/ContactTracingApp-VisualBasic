﻿Imports System.IO

Public Class User
    Public Shared ReadOnly PATH As String = "C:\Users\franc\Documents\School\ELECTIVE 3\repos\ContactTracingApp-folder\ContactTracingApp\ContactTracingAppEntries\"
#Region "Private backing fields"
    Private _userType As String
    Private _firstName As String
    Private _middleName As String
    Private _lastName As String
    Private _age As Byte
    Private _address As String
    Private _cpNum As String
    Private _gender As String
    Private _firstQuestionAnswer As String
    Private _secondQuestionAnswer As String
    Private _symptoms As New List(Of String)
#End Region
#Region "Properties"
    Public Property UserType As String
        Get
            Return _userType
        End Get
        Set(value As String)
            _userType = value
        End Set
    End Property
    Public Property FirstName As String
        Get
            Return _firstName
        End Get
        Set(value As String)
            _firstName = value
        End Set
    End Property
    Public Property MiddleName As String
        Get
            Return _middleName
        End Get
        Set(value As String)
            _middleName = value
        End Set
    End Property
    Public Property LastName As String
        Get
            Return _lastName
        End Get
        Set(value As String)
            _lastName = value
        End Set
    End Property
    Public Property Age As Byte
        Get
            Return _age
        End Get
        Set(value As Byte)
            _age = value
        End Set
    End Property
    Public Property Address As String
        Get
            Return _address
        End Get
        Set(value As String)
            _address = value
        End Set
    End Property
    Public Property CpNum As String
        Get
            Return _cpNum
        End Get
        Set(value As String)
            _cpNum = value
        End Set
    End Property
    Public Property Gender As String
        Get
            Return _gender
        End Get
        Set(value As String)
            _gender = value
        End Set
    End Property
    Public Property FirstQuestionAnswer As String
        Get
            Return _firstQuestionAnswer
        End Get
        Set(value As String)
            _firstQuestionAnswer = value
        End Set
    End Property
    Public Property SecondQuestionAnswer As String
        Get
            Return _secondQuestionAnswer
        End Get
        Set(value As String)
            _secondQuestionAnswer = value
        End Set
    End Property
    Public WriteOnly Property Symptoms As String
        Set(value As String)
            _symptoms.Add(value)
        End Set
    End Property
#End Region
    Public Sub New()
        _userType = ""
        _firstName = ""
        _middleName = ""
        _lastName = ""
        _age = 0
        _address = ""
        _cpNum = ""
        _gender = ""
        _firstQuestionAnswer = ""
        _secondQuestionAnswer = ""
    End Sub

    Public Sub CreateTxtFile()
        Dim txtFile As StreamWriter
        Try
            txtFile = File.CreateText(PATH & _lastName & "," & _firstName & " " & _middleName & ".txt")
            txtFile.WriteLine("Selected type: " & _userType & vbCrLf & vbCrLf &
                                "Time submitted: " & Date.Now.ToString() & vbCrLf & vbCrLf &
                                "USER'S DETAILS:" & vbCrLf &
                                "   First name: " & _firstName & vbCrLf &
                                "   Middle name: " & _middleName & vbCrLf &
                                "   Last name: " & _lastName & vbCrLf &
                                "   Age: " & _age.ToString() & vbCrLf &
                                "   Phone number: " & _cpNum & vbCrLf &
                                "   Address: " & _address & vbCrLf &
                                "   Gender: " & _gender & vbCrLf & vbCrLf &
                                "USER'S ANSWERS:" & vbCrLf &
                                "1. Have you traveled outside the country anytime from last month until now?" & vbCrLf &
                                "   Answer => " & _firstQuestionAnswer & vbCrLf &
                                "2. Have you come into contact with anyone who has traveled outside your country between the period of last month until now?" & vbCrLf &
                                "   Answer => " & _secondQuestionAnswer & vbCrLf & vbCrLf &
                                "USER'S SYMPTOMS:"
                                )
            'loop through the list and print each item to the txt file
            For Each symptom In _symptoms
                txtFile.WriteLine("   " & symptom)
            Next
            txtFile.Close()
            MessageBox.Show("Submitted successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub ClearUserData()
        _userType = ""
        _firstName = ""
        _middleName = ""
        _lastName = ""
        _age = 0
        _address = ""
        _cpNum = ""
        _gender = ""
        _firstQuestionAnswer = ""
        _secondQuestionAnswer = ""
        _symptoms.Clear()
    End Sub
End Class
