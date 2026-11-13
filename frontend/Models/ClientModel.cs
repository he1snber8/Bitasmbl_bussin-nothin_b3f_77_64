public class ClientModel
{
    [Required(ErrorMessage = "Name is required.")]
    [StringLength(100, MinimumLength = 2)]
    public string Name { get; set; } = "";

    [Required(ErrorMessage = "Email is required.")]
    [EmailAddress(ErrorMessage = "Enter a valid email address.")]
    public string Email { get; set; } = "";

    [StringLength(100)]
    public string Companyaa { get; set; } = "Comp";

}