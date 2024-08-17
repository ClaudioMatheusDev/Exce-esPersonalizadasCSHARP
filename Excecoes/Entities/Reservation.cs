using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excecoes.Entities.Exceptions;

namespace Excecoes.Entities
{
    internal class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }


        public Reservation() {
        }// Construtor sem parâmetros

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            // Verifica se a data de check-out é anterior ou igual à data de check-in
            if (checkOut <= checkIn)
            {
                throw new DomainException("Check-out date must be after check-in date");
            }

            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }//Construtor com parâmetros

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays; //RETORNANDO A DATA EM DIAS

        }// Método que calcula a duração da reserva em dias

        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;
            if (checkIn < now || checkOut < now)
            {
                throw new DomainException("Reservation dates for update must be future dates");
            }//VERIFICADO SE AS DATAS SÃO DATAS FUTURAS
             if (checkOut <= checkIn)
            {
                throw new DomainException("Check-out date must be after check-in date");
            }//VERIFICADO SE AS DATAS SÃO DATAS FUTURAS


            CheckIn = checkIn;
            CheckOut = checkOut;
        } // Método para atualizar as datas de check-in e check-out

        public override string ToString()
        {
            return "Room "
                + RoomNumber
                + ", check-in: "
                + CheckIn.ToString("dd/MM/yyyy")
                + ", check-out:  "
                + CheckOut.ToString("dd/MM/yyyy")
                + ", "
                + Duration()
                + " nights";
        }// Sobrescrita do método ToString para exibir as informações da reserva
    }
}
