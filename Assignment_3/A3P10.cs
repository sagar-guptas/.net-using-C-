using System;
abstract class Notification
{
    public abstract void SendNotification();
}

class EmailNotification : Notification
{
    public override void SendNotification()
    {
        Console.WriteLine("Email notification sent.");
    }
}
sealed class ImportantEmailNotification : EmailNotification
{
    public void SendImportantNotification()
    {
        Console.WriteLine("Important email notification sent.");
    }
}

class A3P10
{
    static void Main(string[] args)
    {
        EmailNotification email = new EmailNotification();

        email.SendNotification();
        ImportantEmailNotification importantEmail =
            new ImportantEmailNotification();

        importantEmail.SendNotification();
        importantEmail.SendImportantNotification();
    }
}