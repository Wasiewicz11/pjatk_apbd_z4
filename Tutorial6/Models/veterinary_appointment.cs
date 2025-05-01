namespace Tutorial6.Models;

public class VeterinaryAppointment
{
    public int Id { get; set; }
    public DateTime AppointmentDate { get; set; }
    public Animal Animal { get; set; }
    public string Destription { get; set; }
    public double Price { get; set; }
}