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

//Q1:add new room
//static void AddRoom()
//{
//    Console.Write("room number:");
//    if (!int.TryParse(Console.ReadLine(), out int roomNumber) || roomNumber <= 0)
//    {
//        Console.WriteLine("invalid");
//        return;
//    }

//    if (rooms.Any(r => r.RoomNumber == roomNumber))
//    {
//        Console.WriteLine("room already exists");
//        return;
//    }

//    Console.Write("Room Type:");
//    string roomType = Console.ReadLine();

//    Console.Write("Price in one  Night:");
//    if (!double.TryParse(Console.ReadLine(), out double price) || price <= 0)
//    {
//        Console.WriteLine("Invalid price");
//        return;
//    }

//    rooms.Add(new Room(roomNumber, roomType, price, true));

//    Console.WriteLine("room is added .");
//    Console.WriteLine($"total rooms: {rooms.Count}");
//}

//Q2:reigster new guest
//static void RegisterGuest()
//{
//    Console.Write("guest name: ");
//    string name = Console.ReadLine();

//    Console.Write("check: ");
//    string date = Console.ReadLine();

//    Console.Write("nights number: ");
//    if (!int.TryParse(Console.ReadLine(), out int nights) || nights <= 0)
//    {
//        Console.WriteLine("invalid number");
//        return;
//    }

//    string guestId = $"G{(guests.Count + 1):}";

//    Guest guest = new Guest(
//        guestId,
//        name,
//        "Not Assigned",
//        date,
//        nights);

//    guests.Add(guest);

//    Console.WriteLine("guest is registered .");
//    guest.DisplayGuest();
//}

//Q3:book room
//static void BookRoom()
//{
//    Console.Write("guest ID: ");
//    string guestId = Console.ReadLine();

//    Guest guest = guests.FirstOrDefault(g => g.GuestId == guestId);

//    if (guest == null)
//    {
//        Console.WriteLine("guest is not found.");
//        return;
//    }

//    Console.Write("number of room:");
//    int roomNumber = Convert.ToInt32(Console.ReadLine());

//    Room room = rooms.FirstOrDefault(r => r.RoomNumber == roomNumber);

//    if (room == null)
//    {
//        Console.WriteLine("room not found");
//        return;
//    }

//    if (!room.IsAvailable)
//    {
//        Console.WriteLine("room is booked");
//        return;
//    }

//    guest.RoomNumber = room.RoomNumber.ToString();
//    guest.PricePerNight = room.PricePerNight;

//    room.IsAvailable = false;

//    Console.WriteLine("booking successful");
//    Console.WriteLine($"guest: {guest.GuestName}");
//    Console.WriteLine($"room number is : {room.RoomNumber}");
//    Console.WriteLine($"room type: {room.RoomType}");
//    Console.WriteLine($"the price: {room.PricePerNight:C}");
//    Console.WriteLine($"Total Cost: {guest.CalculateTotalCost():C}");
//}

//Q4:view all rooms
//static void ViewRooms()
//{
//    if (rooms.Count == 0)
//    {
//        Console.WriteLine("no rooms is added");
//        return;
//    }

//    Console.WriteLine($"total rooms: {rooms.Count}");

//    foreach (Room room in rooms.OrderBy(r => r.RoomNumber))
//    {
//        room.DisplayRoom();
//    }
//}

//Q5:view all guests
//static void ViewGuests()
//{
//    if (guests.Count == 0)
//    {
//        Console.WriteLine("not registered");
//        return;
//    }

//    Console.WriteLine($"number of guests: {guests.Count}");

//    foreach (Guest guest in guests.OrderBy(g => g.GuestName))
//    {
//        guest.DisplayGuest();
//    }
//}
//Q6:search  room
//static void SearchRooms()
//{
//    Console.WriteLine(" show available rooms");
//    Console.WriteLine("filter  room type");
//    Console.WriteLine("filter by Price");
//    Console.WriteLine("room statistics");
//    Console.WriteLine("go back");

//    Console.Write("Choice: ");
//    int option = Convert.ToInt32(Console.ReadLine());

//    switch (option)
//    {
//        case 1:
//            var availableRooms = rooms
//                .Where(r => r.IsAvailable)
//                .OrderBy(r => r.PricePerNight);

//            if (!availableRooms.Any())
//            {
//                Console.WriteLine("No room is found");
//                return;
//            }

//            Console.WriteLine($"available rooms: {availableRooms.Count()}");

//            foreach (var room in availableRooms)
//                room.DisplayRoom();
//            break;

//        case 2:

//            Console.Write("Enter Room Type: ");
//            string type = Console.ReadLine();

//            var roomType = rooms
//                .Where(r => r.RoomType.Equals(type,
//                StringComparison.OrdinalIgnoreCase));

//            if (!roomType.Any())
//            {
//                Console.WriteLine("No rooms found.");
//                return;
//            }

//            Console.WriteLine($"found {roomType.Count()} room number");

//            foreach (var room in roomType)
//                room.DisplayRoom();

//            break;

//        case 3:

//            Console.Write("highest price: ");
//            double maxPrice = Convert.ToDouble(Console.ReadLine());

//            var priceRooms = rooms
//                .Where(r => r.IsAvailable && r.PricePerNight <= maxPrice)
//                .OrderBy(r => r.PricePerNight);

//            if (!priceRooms.Any())
//            {
//                Console.WriteLine("No rooms found.");
//                return;
//            }

//            foreach (var room in priceRooms)
//                room.DisplayRoom();

//            break;

//        case 4:

//            Console.WriteLine($"total rooms : {rooms.Count()}");
//            Console.WriteLine($"available room is: {rooms.Count(r => r.IsAvailable)}");
//            Console.WriteLine($"average price of the room is : {rooms.Average(r => r.PricePerNight):F2}");
//            Console.WriteLine($"minimum price: {rooms.Min(r => r.PricePerNight):F2}");
//            Console.WriteLine($"Maximum price: {rooms.Max(r => r.PricePerNight):F2}");

//            break;
//    }
//}
//Q7
//Q8
//Q9
//Q10