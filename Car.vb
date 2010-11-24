Public Class Car

    'member variables
    Private m_year As Integer
    Private m_make As String
    Private m_model As String
    Private m_color As String
    Private m_license As String

    'constructor method
    Public Sub New()

    End Sub
    Public Property Year() As Integer
        Get
            Return m_year
        End Get
        Set(ByVal value As Integer)

        End Set
    End Property
    Public Property Make() As String
        Get
            Return m_make
        End Get
        Set(ByVal value As String)

        End Set
    End Property
    Public Property Model() As String
        Get
            Return m_model
        End Get
        Set(ByVal value As String)

        End Set
    End Property
    Public Property Color() As String
        Get
            Return m_color
        End Get
        Set(ByVal value As String)

        End Set
    End Property
    Public Property License() As String
        Get
            Return m_license
        End Get
        Set(ByVal value As String)

        End Set
    End Property

End Class


