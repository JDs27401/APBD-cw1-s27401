// See https://aka.ms/new-console-template for more information

using ConsoleApp1.Models;
using ConsoleApp1.Services;

var s1 = new Student("Dominik", "Dominikowski", "Informatyka");
var ta1 = new TeachingAssistant("Bartek", "Bartkowski", "Matma", "Informatyka");

Laptop l1 = new Laptop(90000, 16, "L1");
Laptop l2 = new Laptop(90000, 16, "L2");
Laptop l3 = new Laptop(90000, 16, "L3");

DeviceBase[] dlist = new DeviceBase[] { l1};
DeviceBase[] dlist2 = new DeviceBase[] { l2};
DeviceBase[] dlist3 = new DeviceBase[] { l3};

Reservation.CreateReservation(s1, dlist, DateTime.Today, new DateTime(2026,03,31));
Reservation.CreateReservation(s1, dlist2, DateTime.Today, new DateTime(2026,03,31));
// Reservation.CreateReservation(s1, dlist3, DateTime.Today, new DateTime(2026,03,31));
RaportGenerator.GenerateRaport();