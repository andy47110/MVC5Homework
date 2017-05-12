	SELECT 
		客戶名稱,
		Email,
		(SELECT Count(*) FROM DBO.客戶聯絡人 c WHERE c.id = Cust.id) AS 聯絡人數量,
		(SELECT COUNT(*) FROM DBO.客戶銀行資訊 b WHERE b.Id=Cust.Id) AS 銀行帳戶數量
	FROM dbo.客戶資料 Cust