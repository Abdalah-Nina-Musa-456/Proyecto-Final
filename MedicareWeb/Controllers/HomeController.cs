using Microsoft.AspNetCore.Mvc;
using MedicareWeb.Models;

namespace MedicareWeb.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Dashboard()
    {
        var model = new DashboardViewModel
        {
            PendingPrescriptions = 8,
            Urgencies = 2,
            QuickLinks = new List<QuickLink>
            {
                new("Nueva receta", "Crea una receta con firma digital"),
                new("Historial del día", "Revisa el resumen diario"),
                new("Contactar urgencias", "Comunícate con urgencias 24/7")
            },
            PopularServices = new List<ServiceStat>
            {
                new("Cardiología", 255, "Servicio más solicitado"),
                new("Pediatría", 189),
                new("Neurología", 156),
                new("Odontología", 95)
            },
            SpecialtyFocus = new SpecialtyHighlight
            {
                Name = "Cardiología",
                Duration = "30-60 min",
                Price = "Consultar",
                Contact = "Dr. Martínez",
                Description = "Consulta cardiológica con evaluación y ecocardiograma."
            }
        };

        return View(model);
    }

    public IActionResult Services()
    {
        var model = new ServicesViewModel
        {
            Specialties = new List<Specialty>
            {
                new("Cardiología", "Consulta cardiológica y ecocardiograma", "Dr. Martínez", "30-60 min"),
                new("Pediatría", "Atención pediátrica integral", "Dra. Castillo", "20-30 min"),
                new("Traumatología", "Evaluación músculo-esquelética", "Dr. López", "30 min"),
                new("Neurología", "Diagnóstico y control neurológico", "Dra. González", "45 min")
            },
            Contacts = new ContactPanel
            {
                ClinicName = "Clínica Médica Medicare",
                Address = "C/ Principal, 123, 28001 Madrid, España",
                Phone = "+34 900 123 590",
                Mobile = "+34 600 123 456",
                SupportEmail = "soporte@medicare.com",
                EmergencyEmail = "emergencias@medicare.com",
                ReceptionExtension = "100",
                CardiologyExtension = "101",
                PediatricsExtension = "102",
                TraumaExtension = "103"
            }
        };

        return View(model);
    }

    public IActionResult Doctors()
    {
        var model = new DoctorsViewModel
        {
            Doctors = new List<Doctor>
            {
                new("Dr. Martínez", "Cardiología", "Ext. 101", "Consultorio 1A", "08:00 - 12:00"),
                new("Dra. González", "Neurología", "Ext. 102", "Consultorio 2A", "09:00 - 13:00"),
                new("Dr. López", "Traumatología", "Ext. 103", "Consultorio 3A", "10:00 - 14:00"),
                new("Dra. Castillo", "Pediatría", "Ext. 104", "Consultorio 4A", "08:00 - 12:00"),
            },
            HighlightedDoctor = new DoctorDetails
            {
                Name = "Dr. Martínez",
                Specialty = "Cardiología",
                Email = "dr.martinez@medicare.com",
                Phone = "+34 600 123 111",
                Office = "Consultorio 1A - Planta 1",
                Skills = new [] {"Ecocardiografía", "Electrocardiografía", "Monitoreo Holter"},
                Availability = new [] {"Lunes", "Miércoles", "Viernes"}
            }
        };

        return View(model);
    }

    public IActionResult Prescriptions()
    {
        var model = new PrescriptionViewModel
        {
            Patients = new []{"Ana López", "Carlos Pérez", "María González"},
            Medicines = new []{"Amoxicilina", "Lisinopril", "Ibuprofeno"},
            Frequencies = new []{"Cada 8h", "Cada 12h", "Diaria"},
            Durations = new []{"5 días", "7 días", "14 días"}
        };

        return View(model);
    }

    public IActionResult Appointments()
    {
        var model = new AppointmentViewModel
        {
            Patients = new []{"Ana López", "Carlos Pérez", "María González"},
            Services = new []{"Cardiología", "Pediatría", "Neurología"},
            Doctors = new []{"Dr. Martínez", "Dra. González", "Dra. Castillo"}
        };

        return View(model);
    }
}
