

using TextEditor_observer.Publisheres;
using TextEditor_observer.Subscribers;

Editor editor = new Editor();
EmailService emailService = new EmailService();
SmsService smsService = new SmsService();

editor._events.Subscribe(emailService);
editor._events.Subscribe(smsService);

editor.OpenFile();

editor._events.Unsubscribe(smsService);

editor.CloseFile();