# 📚 Projekt: Klasa `Ulamek` w języku C#

## 📖 Opis
Projekt zawiera implementację klasy `Ulamek`, reprezentującej ułamki zwykłe w języku C#. Klasa umożliwia wykonywanie podstawowych operacji arytmetycznych, porównań oraz konwersji na typ `double`. Dodatkowo projekt zawiera zestaw testów jednostkowych przygotowanych z wykorzystaniem frameworka **xUnit**.

Celem projektu było zapoznanie się z tworzeniem własnych typów, z mechanizmami przeciążania operatorów w C#, implementacją interfejsów: `IComparable`, `IEquatable`, a także testowaniem jednostkowym kodu.

---

## 🔧 Funkcjonalności
✅ Reprezentacja ułamków jako licznik i mianownik  
✅ Operacje arytmetyczne:  
- Dodawanie (`+`)
- Odejmowanie (`-`)
- Mnożenie (`*`)
- Dzielenie (`/`)  

✅ Operatory porównań (`>`, `<`, `>=`, `<=`, `==`, `!=`)  
✅ Konwersja jawna na `double`  
✅ Metoda `CompareTo()` umożliwiająca sortowanie ułamków  
✅ Przeciążona metoda `ToString()` zwracająca postać "licznik/mianownik"  
✅ Obsługa wyjątków (np. dzielenie przez zero)  
✅ Pełne testy jednostkowe w xUnit  

---

## 🧪 Testy jednostkowe
Testy zostały napisane w **xUnit** i obejmują:
- Sprawdzenie poprawności konstruktora oraz obsługę wyjątków
- Testy działania `ToString`, `Equals`, `GetHashCode`
- Testy operatorów arytmetycznych i porównawczych
- Testy konwersji do `double`
- Testy sortowania dzięki `IComparable`

Aby uruchomić testy, użyj polecenia:
```bash
dotnet test
```

---

## ▶️ Uruchomienie programu
Aby uruchomić projekt:
```bash
dotnet run
```

Przykładowe operacje prezentowane w programie:
- Dodawanie, odejmowanie, mnożenie i dzielenie ułamków
- Porównanie dwóch ułamków
- Konwersja ułamka na `double`
- Sortowanie tablicy ułamków

---

## 💡 Możliwości dalszego rozwoju
- Dodanie automatycznego skracania ułamków do najprostszej postaci
- Obsługa ułamków mieszanych (np. `1 1/2`)
- Rozszerzenie o dodatkowe operacje matematyczne (np. potęgowanie)
- Rozbudowa interfejsu użytkownika (np. wczytywanie danych z pliku lub konsoli)
- Lepsza obsługa znaków ujemnych i normalizacja znaków

---

## 📂 Struktura projektu
```
├── lab7Ulamek/
│   ├── Program.cs         // Główna implementacja klasy Ulamek i metoda Main()
│   ├── lab7Ulamek.csproj
├── UlamekTests/
│   ├── UlamekTests.cs     // Testy jednostkowe xUnit
│   ├── UlamekTests.csproj
└── README.md
```

---

## 🛠 Technologie
- C# (.NET)
- xUnit (testy jednostkowe)

---

## 📜 Licencja
Projekt edukacyjny stworzony na potrzeby laboratorium z programowania obiektowego.  
Możesz dowolnie korzystać i modyfikować.

---