using System.ComponentModel.DataAnnotations;

namespace TicketManagementUI.Extensions.Helpers;

public class ValidationHelpers(object instance)
{
    #region Private fields declaration

    private readonly ValidationContext m_ValidationContext = new(instance);

    #endregion

    #region Public properties declaration

    public List<ValidationResult> ValidationResults { get; set; } = [];

    #endregion

    #region Public methods declaration

    public bool Validate()
    {
        return Validator.TryValidateObject(instance, m_ValidationContext, ValidationResults, true);
    }

    #endregion
}