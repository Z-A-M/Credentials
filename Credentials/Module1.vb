Imports RestSharp
Imports System.Windows
Imports System.Threading
Imports System.Net.Http.Headers
Imports System.Net.Http
Imports System.Net

Module Module1

    Sub Main()
        'HttpClient()
        'Dim client = New RestClient("http://wincriproweb01d/OASIS.WebAPI/api")
        Dim client = New RestClient("http://localhost:3863")

        'client.Authenticator = New NtmlAuthenticator("prc", "2crimes@shsu")
        Dim request = New RestRequest(Method.GET)



        request.AddUrlSegment("offenderId", "24")
        request.Resource = "api/TRASFelonyScreeners?offenderId={offenderId}"

        Try
            client.ExecuteAsync(Of List(Of TRASFelonyScreener))(
                     request, Sub(response)

                                  response.Data.ForEach(Sub(x)
                                                            Console.WriteLine("Result")
                                                            Console.WriteLine(x)
                                                            Console.ReadLine()
                                                            System.IO.File.WriteAllText("C:\Users\Public\TestFolder\Test.txt", x.CreatedOn)
                                                            Console.WriteLine("End Result")
                                                            Console.ReadLine()


                                                        End Sub)
                              End Sub)

        Catch ex As Exception
            Console.WriteLine(ex.Message)
            Console.Read()

        End Try
        Thread.Sleep(9999)
    End Sub
    Async Sub HttpClient()
        Try
            'Dim myProxy As WebClient = New WebClient()

            'myProxy.BaseAddress ="http://localhost:3863/"


            ''Create an instance of the CredentialCache class.
            'Dim cache As CredentialCache = New CredentialCache()

            ''Add a NetworkCredential instance to CredentialCache.
            ''Negotiate for NTLM or Kerberos authentication.
            'cache.Add(New Uri(myProxy.BaseAddress), "Negotiate", New NetworkCredential("UserName", "Password", "Domain"))

            ''Assign CredentialCache to the Web service Client Proxy(myProxy) Credetials property.
            'myProxy.Credentials = cache
           

            Dim credentials As ICredentials
            credentials = New NetworkCredential("prc", "2crimes@shsu")
            Dim handler = New HttpClientHandler()
            handler.Credentials = credentials

            Using client As New HttpClient()

                client.BaseAddress = New Uri("http://localhost:3863/api/")
                client.DefaultRequestHeaders.Accept.Clear()
                client.DefaultRequestHeaders.Accept.Add(New MediaTypeWithQualityHeaderValue("application/json"))

                '' New code:
                Dim response As HttpResponseMessage = Await client.GetAsync("TRASFelonyScreeners?offenderId=24")
                Thread.Sleep(9999)

                If (response.IsSuccessStatusCode) Then
                    Console.WriteLine(response.Content)



                End If

            End Using
        Catch ex As Exception
            Throw ex
        End Try


    End Sub

End Module
