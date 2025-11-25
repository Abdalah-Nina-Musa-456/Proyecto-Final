namespace MedicareWeb.Models;

public record QuickLink(string Title, string Description);

public record ServiceStat(string Name, int Requests, string? Badge = null);

public class SpecialtyHighlight
{
    public string Name { get; set; } = string.Empty;
    public string Duration { get; set; } = string.Empty;
    public string Price { get; set; } = string.Empty;
    public string Contact { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
}

public class DashboardViewModel
{
    public int PendingPrescriptions { get; set; }
    public int Urgencies { get; set; }
    public List<QuickLink> QuickLinks { get; set; } = new();
    public List<ServiceStat> PopularServices { get; set; } = new();
    public SpecialtyHighlight SpecialtyFocus { get; set; } = new();
}

public record Specialty(string Name, string Description, string Contact, string Duration);

public class ContactPanel
{
    public string ClinicName { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public string Mobile { get; set; } = string.Empty;
    public string SupportEmail { get; set; } = string.Empty;
    public string EmergencyEmail { get; set; } = string.Empty;
    public string ReceptionExtension { get; set; } = string.Empty;
    public string CardiologyExtension { get; set; } = string.Empty;
    public string PediatricsExtension { get; set; } = string.Empty;
    public string TraumaExtension { get; set; } = string.Empty;
}

public class ServicesViewModel
{
    public List<Specialty> Specialties { get; set; } = new();
    public ContactPanel Contacts { get; set; } = new();
}

public record Doctor(string Name, string Specialty, string Extension, string Office, string Hours);

public class DoctorDetails
{
    public string Name { get; set; } = string.Empty;
    public string Specialty { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public string Office { get; set; } = string.Empty;
    public IEnumerable<string> Skills { get; set; } = Enumerable.Empty<string>();
    public IEnumerable<string> Availability { get; set; } = Enumerable.Empty<string>();
}

public class DoctorsViewModel
{
    public List<Doctor> Doctors { get; set; } = new();
    public DoctorDetails HighlightedDoctor { get; set; } = new();
}

public class PrescriptionViewModel
{
    public IEnumerable<string> Patients { get; set; } = Enumerable.Empty<string>();
    public IEnumerable<string> Medicines { get; set; } = Enumerable.Empty<string>();
    public IEnumerable<string> Frequencies { get; set; } = Enumerable.Empty<string>();
    public IEnumerable<string> Durations { get; set; } = Enumerable.Empty<string>();
}

public class AppointmentViewModel
{
    public IEnumerable<string> Patients { get; set; } = Enumerable.Empty<string>();
    public IEnumerable<string> Services { get; set; } = Enumerable.Empty<string>();
    public IEnumerable<string> Doctors { get; set; } = Enumerable.Empty<string>();
}
