﻿namespace BankApp;

public class BankAccount
{
  // PUBLIKA FÄLT - KLASSENS INFORMATION(DATA) //
  public string AccountNumber = "";
  public decimal Balance;
  public decimal InterestRate;
  // -------------------------------------------------------------- //

  // PUBLIKA METODER - VAD SKA KLASSEN KUNNA UTFÖRA //
  // KALLAS FÖR BETEENDE I OOP //

  // Metod för att sätta in pengar på kontot...
  public void Deposit(decimal amount)
  {
    // Addera mängden som skall sättas in på Balance fältets
    // aktuella värde
    Balance += amount;
  }

  // Metod för att ta ut pengar ifrån kontot...
  public void WithDraw(decimal amount)
  {
    // Kontrollera så att värdet på 'Balance' är större än vad
    // som ska tas ut...
    if (Balance > amount)
    {
      Balance -= amount;
    }
    // Annars så 'kastar' vi ett fel tillbaka till den del av
    // applikationen som försöker ta ut pengar...
    else
    {
      throw new ArgumentException("Uttag medges ej.");
    }
  }

  // Här åsidosätter vi den inbyggda metoden ToString()
  // som finns på alla datatyper i .NET
  public override string ToString()
  {
    // Vi skapar ett eget meddelande som vi vill kunna visa
    // när ToString() metoden anropas...
    return $"Kontonummer: {AccountNumber} Saldo: {Balance}";
  }
}
