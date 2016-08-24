Public Class TRASFelonyScreener
       Public Property ID As Integer
    Public Property OffenderID As Integer
    Public Property MostSeriousOffenseUnder17 As Nullable(Of Byte)
    Public Property HighestEducation As Nullable(Of Byte)
    Public Property WasEmployedAtArrest As Nullable(Of Byte)
    Public Property HaveUsedIllegalDrugs As Nullable(Of Byte)
    Public Property HasAntiSocialActivities As Nullable(Of Byte)
    Public Property HasCriminalAttitudes As Nullable(Of Byte)
    Public Property WalksAwayFromAFight As Nullable(Of Byte)
    Public Property TotalFelonyScreenerScore As Nullable(Of Byte)
    Public Property RiskLevel As String
    Public Property AssessedOn As Nullable(Of Date)
    Public Property CreatedIn As Nullable(Of Byte)
    Public Property CreatedBy As Integer
    Public Property CreatedOn As Date
    Public Property LastModifiedBy As Nullable(Of Integer)
    Public Property LastModifiedOn As Nullable(Of Date)
    Public Property InactiveOn As Nullable(Of Date)
    Public Property IsDeleted As Nullable(Of Boolean)
    Public Property IsCompleted As Nullable(Of Boolean)
    Public Property TDCJStatus As Nullable(Of Byte)
    Public Property TDCJDate As Nullable(Of Date)
    Public Property TDCJRecordID As Nullable(Of Integer)
End Class
