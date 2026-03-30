# APBD-cw1-s27401

Stworzony kod zakłada system w którym mogą znajdować się 3 typy użytkowników: Student, Teacher i Teaching Assistant. Ten ostatni jest zarówno jak i nauczycielem i studentem. Posiada numer indexu, limit 2 rezerwacji i implementuje interfejs IStudent.
Program posiada także 3 różne sprzęty dostępne do wynajęcia: Laptop, Projector i Camera.
Klasy abstrakcyjne Person i DeviceBase implementują interfejs IReservation, który posiada szkielety metod odpowiedzialnych za ustawianie referencji zwrotnych pomiędzy obiektem Reservation a Person/DeviceBase.
Wszystkie konstruktory jak i settery (w tym przypadku zaimplementowane jako proxy), posiadają odpowiednią dla swoejgo typu walidację. Dla atrybutów typu string jest sprawdzane czy nie są one puste, ale składają się tylko ze znaków białych,
a dla atrybutów liczbowych czy wartości nie przyjmują wartości <= 0.
Program posiada także stworzone nowe wyjątki: MaxReservationsReachedException i ReservationNotFoundException. Pierwszy jest podnoszony gdy próbujemy przypisać do użytkownika zbyt wiele rezerwacji, a drugi jeżeli w kolekcji nie znajduje się rezerwacja o podanym kluczu.
Program także posiada mozliwość naliczenia kar jeżeli rezerwacja zostanie zakończona po terminie (10 pln za każdy dzień spóźnienia).
