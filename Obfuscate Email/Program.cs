class ObfuscateEmail
{
    static void Main(string[] args)
    {
        ObfuscateEmail email = new ObfuscateEmail();
        email.consoreMail();  
    }

    public string introduceMail()
    {
        while (true)
        {
            Console.WriteLine("Introdu Mail-ul");
            var email = Console.ReadLine();
            try
            {
                if (!email.Contains("@"))
                {
                    Console.WriteLine("Email-ul nu este valid,incearca din nou");
                    continue;
                }
                return email;
           
            }catch (Exception ex)
           
            {
                Console.WriteLine(ex.ToString);
            }
        }
    }

    public string consoreMail()
    {
        var email = introduceMail();
        string[] parts = email.Split('@');
        string mail = parts[0];
        string domain = parts[1];
        string censoreMail= new string('*',mail.Length);
        string censoredEmail=$"{censoreMail}@{domain}";
        Console.WriteLine(censoredEmail);
        return censoredEmail;
    }


}