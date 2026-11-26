IF NOT EXISTS (
    SELECT 1 FROM dbo.Users WHERE Username = 'admin'
)
BEGIN
    INSERT INTO dbo.Users
        (Username, PasswordHash, PasswordSalt)
    VALUES
        ('admin', '6/mKlSOLCs+XIH2ofARTNNet87tTpD/KYkItrSf8HU0=', 'EkiQeHR9zkxWAdo+OST4/Q==');
END;