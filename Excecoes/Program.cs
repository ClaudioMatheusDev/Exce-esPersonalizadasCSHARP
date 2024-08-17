using System;
using Excecoes.Entities;
using Excecoes.Entities.Exceptions;


try
{
    // Solicita o número do quarto
    Console.Write("Room number: ");
    int number = int.Parse(Console.ReadLine());

    // Solicita a data de check-in
    Console.Write("Check-in date (dd/MM/yyyy): ");
    DateTime checkIn = DateTime.Parse(Console.ReadLine());

    // Solicita a data de check-out
    Console.Write("Check-out date (dd/MM/yyyy): ");
    DateTime checkOut = DateTime.Parse(Console.ReadLine());


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

    reservation.UpdateDates(checkIn, checkOut);
    Console.WriteLine("Reservation: " + reservation);

}

catch (DomainException e)
{
    Console.WriteLine("Error in reservation: " + e.Message);
}
catch(FormatException e){
    Console.WriteLine("Format error: " + e.Message);
}
catch(Exception e)
{
    Console.WriteLine("Unexpected error: " + e.Message);
}





