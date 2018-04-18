
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FirstCode.Constants;

namespace FirstCode.Models
{
    public class User
    {
        [Key, StringLength(15), Required(ErrorMessage = ErrorMessage.EmptyId), Column(DataBase.IdField)]
        public string Id { get; set; }
        [Column(DataBase.NameField)]
        public string Name { get; set; }
        [Required(ErrorMessage = ErrorMessage.EmptyPassword), Column(DataBase.PasswordField)]
        public string Password { get; set; }
        [Column(DataBase.GenderField)]
        public Gender Gender { get; set; }
        [Required(ErrorMessage = ErrorMessage.EmptyIdentity), Column(DataBase.IdentityField)]
        public Identity Identity { get; set; }
    }

    public enum Gender
    {
        MALE, FEMALE
    }

    public enum Identity
    {
        STUDENT, ADMINISTRATOR, DORMITORY_ADMINISTRATOR, WORKER
    }
}