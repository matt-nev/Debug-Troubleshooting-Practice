Public Class OnlineServices
	Private Shared ran As New Random()

	Public Shared Function GetBankRateFromSystem() As Decimal
		Return CDec(ran.NextDouble()) * 4
	End Function

	Public Shared Function GetLoanFee() As Decimal
		Return CDec(ran.NextDouble()) * 2

	End Function
End Class
