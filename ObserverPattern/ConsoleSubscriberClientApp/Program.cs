
using AccountPublisherLib.Domain;
using ConsoleSubscriberClientApp.Notfications;

Account acc1 = new Account(101, "Hemang");

acc1.AddObserver(new EmailNotification());
acc1.AddObserver(new SmsNotification());
acc1.Deposit(1000);