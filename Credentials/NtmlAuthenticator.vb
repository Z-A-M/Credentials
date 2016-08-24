Imports System.Net
Imports RestSharp
Imports RestSharp.Authenticators

Public Class NtmlAuthenticator
    Implements IAuthenticator

    Private ReadOnly credentials As ICredentials
    Public Sub New(ByVal username As String, ByVal password As String)
      Me.credentials=  new NetworkCredential(username, password)
    End Sub
    Public Sub Authenticate(client As IRestClient, request As IRestRequest) Implements IAuthenticator.Authenticate
       request.Credentials = Me.credentials

         
    End Sub
End Class
