#Przegląd projektu:

Projekt obejmuje elementy, jakie zostały przedstawione podczas laboratorium, w tym:

**Lista wykorzystanych technologii:**
- ASP.NET Core 6.0
- ASP.NET Core Web API
- Entity Framework Core z bazą danych SQLite
- Microsoft Identity do autentykacji i autoryzacji
- Bootstrap
- XUnit do testów jednostkowych

**Dane przykładowych użytkowników:**

*Administrator:*
- *Login:* adam@wsei.edu.pl
- *Hasło:* 1234Abcd$

#Proces uruchamiania aplikacji (wersja deweloperska):

1. Sklonuj repozytorium z kodem aplikacji:
   ```bash
   git clone https://github.com/X-dante-X/Laboratorium-ASP.NET
   ```
2. Przejdź do katalogu projektu:
   ```bash
   cd nazwa-projektu
   ```
3. Zainstaluj zależności przy użyciu narzędzia do zarządzania pakietami (np. NuGet):
      ```bash
   dotnet restore
   ```
4. Uruchom aplikację:
   ```bash
   dotnet run
   ``` 
5. Otwórz przeglądarkę i przejdź do https://localhost:7149 (lub inny port, jeśli został zmieniony).

# Opis Własnych Funkcji Aplikacji:

## Utrwalanie Danych w Bazie za pomocą Entity Framework:

- Wykorzystano Entity Framework Core z bazą danych SQLite w osobnym module.
- Zaimplementowano inicjację przykładowymi danymi.

## Istnienie Związków:

- Zdefiniowano trzy związki: organizacje i kontakty, kontakty i rezerwacje, rezerwacje i szczegóły pokoju.

## Serwis do Obsługi Funkcji CRUD:

- Stworzono serwis umożliwiający operacje CRUD na danych.

## Moduł Identity:

- Zaimplementowano moduł Identity do logowania użytkowników.
- Utworzono dwie role: administrator i zwykły użytkownik.

## Formularze do Realizacji CRUD i Widoki z Dostępem dla Administratora:

- Opracowano formularze do obsługi CRUD oraz widoki z listami obiektów.
- Zapewniono dostęp do nich tylko dla administratora.

## Moduł Testów Jednostkowych:

- Zaimplementowano testy jednostkowe dla kontrolerów kontaktów i rezerwacji.

## Kontroler WEBAPI do Udostępniania Wybranych Danych:

- Stworzono kontroler WEBAPI umożliwiający wyszukiwanie właścicieli rezerwacji.

## Dodano Automatyczną Aktualizację Migracji.

## Cały Program Działa Asynchronicznie:

- Projekt został zaimplementowany z wykorzystaniem asynchronicznych operacji przy użyciu async, await oraz Task.
  
## Napisano Dokumentacje Do Projektu
