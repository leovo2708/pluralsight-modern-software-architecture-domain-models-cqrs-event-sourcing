using System;
using Module5.Deluxe.Infrastructure.Extras.Backend;

namespace Module5.Deluxe.Infrastructure.Extras
{
    public class EmailService
    {
        public static void Send(string address, string message)
        {
            using (var db = new merloXtra())
            {
                var email = new SentEmail {Address = address, Body = message, Sent = DateTime.Now};
                db.SentEmails.Add(email);
                db.SaveChanges();
            }
        }
    }
}