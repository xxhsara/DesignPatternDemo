// See https://aka.ms/new-console-template for more information

//增加观察者
using ObserverPattern;
using ObserverPattern.Observers;

var door = new Door();
door.AddObserver(new Lamp());
door.AddObserver(new Airconditioner());
door.AddObserver(new Heater());

door.Open();
