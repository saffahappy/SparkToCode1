//namespace task2_oop_solution
//{
//    internal class Room
//    {
//        public int RoomNumber { get; set; }
//        public string RoomType { get; set; }
//        public double PricePerNight { get; set; }
//        public bool IsAvailable { get; set; }

//        public Room(int roomNumber, string roomType,
//                    double pricePerNight, bool isAvailable)
//        {
//            RoomNumber = roomNumber;
//            RoomType = roomType;
//            PricePerNight = pricePerNight;
//            IsAvailable = isAvailable;
//        }

//        public void DisplayRoom()
//        {
//            Console.WriteLine("details");
//            Console.WriteLine($"Room Number : {RoomNumber}");
//            Console.WriteLine($"Room Type   : {RoomType}");
//            Console.WriteLine($"Price       : {PricePerNight}");
//            Console.WriteLine($"is it available   : {IsAvailable}");
//        }
//    }
//}

//namespace task2_oop_solution
//{
//    internal class Guest
//    {
//        public string GuestId { get; set; }
//        public string GuestName { get; set; }
//        public string RoomNumber { get; set; }
//        public string CheckInDate { get; set; }
//        public int TotalNights { get; set; }

//        public double PricePerNight { get; set; }

//        public Guest(string guestId,
//                     string guestName,
//                     string roomNumber,
//                     string checkInDate,
//                     int totalNights)
//        {
//            GuestId = guestId;
//            GuestName = guestName;
//            RoomNumber = roomNumber;
//            CheckInDate = checkInDate;
//            TotalNights = totalNights;
//        }

//        public void DisplayGuest()
//        {
//            Console.WriteLine("guest details");
//            Console.WriteLine($"guest ID: {GuestId}");
//            Console.WriteLine($"Guest name: {GuestName}");
//            Console.WriteLine($"room number: {RoomNumber}");
//            Console.WriteLine($"check the date: {CheckInDate}");
//            Console.WriteLine($"Night number: {TotalNights}");
//        }

//        public double CalculateTotalCost()
//        {
//            return PricePerNight * TotalNights;
//        }
//    }
//}
namespace task2_oop_solution



