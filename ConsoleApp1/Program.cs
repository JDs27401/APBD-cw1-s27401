// See https://aka.ms/new-console-template for more information

using ConsoleApp1.Models;
using ConsoleApp1.Services;

var s1 = new Student("Dominik", "Dominikowski", "Informatyka");
// var s1 = new Student("", "Dominikowski", "Informatyka"); //wyrzuci wyjątek
// var s1 = new Student(" ", "Dominikowski", "Informatyka"); //to też
var s2 = new Student("John", "Johnowski", "Informatyka");
var s3 = new Student("Jane", "Janeowski", "Informatyka");
var ta1 = new TeachingAssistant("Bartek", "Bartkowski", "Matma", "Informatyka");
var t1 = new Teacher("Jakub", "Jakubowski", "Fizyka");

Laptop l1 = new Laptop(90000, 16, "L1");
Laptop l2 = new Laptop(90000, 16, "L2");
Laptop l3 = new Laptop(90000, 16, "L3");

Camera c1 = new Camera(3500, 1600, "Sony");
Camera c2 = new Camera(3200, 2600, "Canon");
Camera c3 = new Camera(3000, 1000, "Nikon");

Projector p1 = new Projector(400, 1000, "BenQ");

DeviceBase[] dlist = new DeviceBase[] { l1};
DeviceBase[] dlist2 = new DeviceBase[] { l2};
DeviceBase[] dlist3 = new DeviceBase[] { l3};

DeviceBase[] dlist4 = new DeviceBase[] { l3, c1, p1};

Reservation.CreateReservation(s1, dlist, DateTime.Today, new DateTime(2026,03,31));
// Reservation.CreateReservation(s1, dlist, new DateTime(2026,03,30), new DateTime(2026,03,30)); //wyrzuci wyjątek tego samego dnia
// Reservation.CreateReservation(s1, dlist, DateTime.Today, new DateTime(2026,03,31)); //wyrzuci wyjątek zajętego już urządzenia
Reservation.CreateReservation(s1, dlist2, DateTime.Today, new DateTime(2026,03,31));
// Reservation.CreateReservation(s1, dlist3, DateTime.Today, new DateTime(2026,03,31)); //wyrzuci wyjątek zbyt wielu rezerwacji

Reservation.CreateReservation(t1, dlist4, DateTime.Today, new DateTime(2026,03,31));

RaportGenerator.GenerateRaport();

Reservation.EndReservation("R3", new DateTime(2026,03,31));
RaportGenerator.GenerateRaport();