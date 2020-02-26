using System.Data.Entity;

namespace ServiceRequestInformationSystem.Models
{
    internal class SrisDbInitializer : CreateDatabaseIfNotExists<SrisContext>
    {
    }
}