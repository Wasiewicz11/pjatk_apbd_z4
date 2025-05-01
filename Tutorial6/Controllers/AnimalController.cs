using Microsoft.AspNetCore.Mvc;
using Tutorial6.Dtos;
using Tutorial6.Models;

namespace Tutorial6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAnimals()
        {
            var result = Database.Animals.ToList();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetAnimal(int id)
        {
            var result = Database.Animals.FirstOrDefault(animal => animal.Id == id);
            if (result != null) 
                return Ok(result);
            
            return NotFound("Animal does not exist");
        }

        [HttpPost]
        public IActionResult AddAnimal(Animal animal)
        {
            Database.Animals.Add(animal);
            return Created();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateAnimal(int id, [FromBody] AnimalDto animalUpdateDto)
        {
            var animalToUpdate = Database.Animals.FirstOrDefault(animal => animal.Id == id);

            if (animalToUpdate == null)
            {
                return NotFound("Animal does not exist");
            }

            if (animalUpdateDto.Name != null)
                animalToUpdate.Name = animalUpdateDto.Name;

            if (animalUpdateDto.Category != null)
                animalToUpdate.Category = animalUpdateDto.Category;

            if (animalUpdateDto.Weight != null)
                animalToUpdate.Weight = animalUpdateDto.Weight.Value;
            
            if (animalUpdateDto.CoatColor != null)
                animalToUpdate.CoatColor = animalUpdateDto.CoatColor;

            return Ok(animalToUpdate);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteAnimal(int id)
        {
            var animalToBeRemoved = Database.Animals.FirstOrDefault(animal => animal.Id == id);
            if (animalToBeRemoved != null) 
                Database.Animals.Remove(animalToBeRemoved);

            return Ok("Removed");
        }

        [HttpGet("{name}")]
        public IActionResult GetAnimal(string name)
        {
            var animals = Database.Animals.Where(animal => animal.Name.ToLower() == name.ToLower()).ToList();
            if (animals.Any())
                return Ok(animals);

            return NotFound("Animal does not exist");
        }

        [HttpGet("{id}/visits")]
        public IActionResult GetVisits(int animalId)
        {
            var visits = Database.Visits.Where(visit => visit.Animal.Id == animalId).ToList();
            if (visits.Any())
            {
                var visitsDto = new List<VeterinaryAppointmentDto>();
                foreach (var visit in visits)
                {
                    visitsDto.Add(new VeterinaryAppointmentDto(){
                        Id = visit.Id,
                        AppointmentDate = visit.AppointmentDate, 
                        Destription = visit.Destription, 
                        Price = visit.Price
                    });
                }
                return Ok(visitsDto);
            }
            return NotFound();
        }
        
        [HttpPost("{id}/visits")]
        public IActionResult AddVisit(int animalId, [FromBody] CreateVeterinaryAppointmentDto createVisitDto)   
        {
            var animal = Database.Animals.FirstOrDefault(animal => animal.Id == animalId);
            if ( animal  == null)
                return NotFound("Animal does not exist");
            
            var newId = Database.Visits.Any() ? Database.Visits.Max(v => v.Id) + 1 : 1;
            

            var newVisit = new VeterinaryAppointment()
            {
                Id = newId,
                AppointmentDate = createVisitDto.AppointmentDate,
                Animal = animal,
                Destription = createVisitDto.Destription,
                Price = createVisitDto.Price
            };
            
            Database.Visits.Add(newVisit);

            return Ok(newVisit);
        }
    }
}
