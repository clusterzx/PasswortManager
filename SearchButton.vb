Public Class TextBoxButton
    Inherits TextBox

    Public mButton As Button
    Public Property Button As Button
        Get
            Return mButton
        End Get

        Set(value As Button)
            mButton = value
        End Set
    End Property
    Protected Overrides Sub OnCreateControl()
        Me.Controls.Add(Me.mButton)
        Me.mButton.Dock = DockStyle.Right
        MyBase.OnCreateControl()
    End Sub
    Public Sub New()
        MyBase.New()
        mButton = New Button
        With Me.mButton
            .Width = 20
            .FlatAppearance.BorderSize = 0
            .FlatStyle = FlatStyle.Popup
            .BackColor = Color.Transparent
            .Image = My.Resources.search
        End With

    End Sub
End Class