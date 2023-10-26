using M01A22_Events;

internal class Program
{
    private static void Main()
    {
        var room = new Room(3);
        room.RoomSoldOutEvent += OnRoomSoldOut;

        room.ReserveSeat();
        room.ReserveSeat();
        room.ReserveSeat();
        room.ReserveSeat();
        room.ReserveSeat();
        room.ReserveSeat();

    }

    static void OnRoomSoldOut(object sender, EventArgs e)
    {
        Console.WriteLine("Sala está lotada!");
    }
}