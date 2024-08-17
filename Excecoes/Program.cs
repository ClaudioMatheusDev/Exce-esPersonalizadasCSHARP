using System;
using Excecoes.Entities;

// Solicita o número do quarto
Console.Write("Room number: ");
int number = int.Parse(Console.ReadLine());

// Solicita a data de check-in
Console.Write("Check-in date (dd/MM/yyyy): ");
DateTime checkIn = DateTime.Parse(Console.ReadLine());

// Solicita a data de check-out
Console.Write("Check-out date (dd/MM/yyyy): ");
DateTime checkOut = DateTime.Parse(Console.ReadLine());

// Verifica se a data de check-out é anterior ou igual à data de check-in
if (checkOut <= checkIn)
{
    Console.WriteLine("Error in reservation: Check-out date must be after check-in date");
}
else
{
    // Cria uma nova reserva
    Reservation reservation = new Reservation(number, checkIn, checkOut);
    Console.WriteLine("Reservation: " + reservation);
    Console.WriteLine();

    // Solicita dados para atualizar a reserva
    Console.WriteLine("Enter data to update the reservation: "); //Verificando se o usuario deseja atulizar a data de hospedagem
    Console.Write("Check-in date (dd/MM/yyyy): ");
    checkIn = DateTime.Parse(Console.ReadLine());
    Console.Write("Check-out date (dd/MM/yyyy): ");
    checkOut = DateTime.Parse(Console.ReadLine());

    string error = reservation.UpdateDates(checkIn, checkOut);
    if (error != null)
    {
        Console.WriteLine("Error in reservation: " + error);
    }
    else
    {
        Console.WriteLine("Reservation: " + reservation);
    }

}


