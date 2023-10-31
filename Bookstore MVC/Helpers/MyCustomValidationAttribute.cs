// using System.ComponentModel.DataAnnotations;

// namespace BookstoreMVC.Helpers
// {
//     public class MyCustomValidationAttribute : ValidationAttribute
//     {
//         protected override ValidationResult IsValid(object value, ValidationContext validationContext)
//         {
//             if (value != null)
//             {
//                 string bookName = value.ToString();
//                 if (bookName.Contains("mvc"))
//                 {
//                     return ValidationResult.Success;
//                 }

//             }
//             return new ValidationResult(ErrorMessage ?? "BookName does not contain the desired keyword");

//         }
//     }
// }