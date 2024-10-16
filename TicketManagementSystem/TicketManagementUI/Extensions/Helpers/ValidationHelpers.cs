using System.ComponentModel.DataAnnotations;


namespace TicketManagementUI.Extensions.Helpers;

public class ValidationHelpers(object instance)
{
    private readonly ValidationContext m_ValidationContext = new(instance);
    public List<ValidationResult> ValidationResults { get; set; } = [];

    public bool Validate()
    {
        return Validator.TryValidateObject(instance, m_ValidationContext, ValidationResults, true);
    }
}