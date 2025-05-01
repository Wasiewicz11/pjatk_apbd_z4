using Tutorial6.Models;

namespace Tutorial6;

public static class Database
{
    public static List<Animal> Animals = new List<Animal>()
        {
            new Animal(){Id = 1, Name = "Felek", Category = "Dog", CoatColor = "White", Weight = 15.1},
            new Animal(){Id = 2, Name = "Mruczek", Category = "Cat", CoatColor = "Gray", Weight = 4.3},
            new Animal(){Id = 3, Name = "Reksio", Category = "Dog", CoatColor = "Brown", Weight = 18.7},
            new Animal(){Id = 4, Name = "Luna", Category = "Cat", CoatColor = "Black", Weight = 3.9},
            new Animal(){Id = 5, Name = "Burek", Category = "Dog", CoatColor = "Beige", Weight = 20.0},
            new Animal(){Id = 6, Name = "Puszek", Category = "Rabbit", CoatColor = "White", Weight = 2.5},
            new Animal(){Id = 7, Name = "Milo", Category = "Dog", CoatColor = "Golden", Weight = 23.4},
            new Animal(){Id = 8, Name = "Zuzia", Category = "Cat", CoatColor = "Orange", Weight = 4.0},
            new Animal(){Id = 9, Name = "Brutus", Category = "Dog", CoatColor = "Black", Weight = 30.2},
            new Animal(){Id = 10, Name = "Tosia", Category = "Hamster", CoatColor = "Brown", Weight = 0.2},
            new Animal(){Id = 11, Name = "Kira", Category = "Dog", CoatColor = "White", Weight = 19.5},
            new Animal(){Id = 12, Name = "Ciapek", Category = "Dog", CoatColor = "Spotted", Weight = 21.3},
            new Animal(){Id = 13, Name = "Felix", Category = "Cat", CoatColor = "Tabby", Weight = 5.1},
            new Animal(){Id = 14, Name = "Leo", Category = "Cat", CoatColor = "Cream", Weight = 4.6},
            new Animal(){Id = 15, Name = "Bambi", Category = "Deer", CoatColor = "Light Brown", Weight = 45.0},
            new Animal(){Id = 16, Name = "Roki", Category = "Dog", CoatColor = "Gray", Weight = 24.9},
            new Animal(){Id = 17, Name = "Misia", Category = "Cat", CoatColor = "Calico", Weight = 3.7},
            new Animal(){Id = 18, Name = "Daisy", Category = "Goat", CoatColor = "White", Weight = 34.8},
            new Animal(){Id = 19, Name = "Frodo", Category = "Dog", CoatColor = "Dark Brown", Weight = 17.2},
            new Animal(){Id = 20, Name = "Nala", Category = "Cat", CoatColor = "Silver", Weight = 4.8}
        };

    public static List<VeterinaryAppointment> Visits { get; set; } = new List<VeterinaryAppointment>()
    {
        new VeterinaryAppointment() { Id = 1, AppointmentDate = DateTime.Now, Destription = "Szczepienie", Price = 50.0, Animal = Animals.FirstOrDefault(a => a.Id == 1) },
        new VeterinaryAppointment() { Id = 2, AppointmentDate = DateTime.Now.AddDays(-1), Destription = "Operacja nosa", Price = 70.0, Animal = Animals.FirstOrDefault(a => a.Id == 2) },
        new VeterinaryAppointment() { Id = 3, AppointmentDate = DateTime.Now.AddDays(-2), Destription = "Operacja lewej łapy", Price = 60.0, Animal = Animals.FirstOrDefault(a => a.Id == 3) },
        new VeterinaryAppointment() { Id = 4, AppointmentDate = DateTime.Now.AddDays(-3), Destription = "Szczepienie", Price = 55.0, Animal = Animals.FirstOrDefault(a => a.Id == 4) },
        new VeterinaryAppointment() { Id = 5, AppointmentDate = DateTime.Now.AddDays(-4), Destription = "Odrobaczanie", Price = 80.0, Animal = Animals.FirstOrDefault(a => a.Id == 5) }
    };
}