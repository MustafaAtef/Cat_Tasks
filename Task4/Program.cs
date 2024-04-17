
var e = new EventManager();

e.Subscribe(() => Console.WriteLine("Event handler 1"));
e.Subscribe(() => Console.WriteLine("Event handler 2"));
e.Subscribe(() => Console.WriteLine("Event handler 3"));

e.Trigger();



public delegate void EventHandler();

public class EventManager {

    EventHandler Handlers;


    public void Subscribe(EventHandler handler) {
        if (Handlers is null) Handlers = handler;
        else Handlers += handler;
    }

    public void Trigger() {
        Console.WriteLine("Event has just happened! all handlers will be called now!");

        Handlers?.Invoke();
    }



}