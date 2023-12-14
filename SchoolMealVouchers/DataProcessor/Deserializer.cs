namespace SchoolMealVouchers.DataProcessor;

using System.ComponentModel.DataAnnotations;
using System.Text;
using Data;

public class Deserializer
{
    private const string ErrorMessage = "Invalid Data";

    private const string SuccessfullyImportedDepartment = "Imported {0} with {1} cells";

    private const string SuccessfullyImportedPrisoner = "Imported {0} {1} years old";

    private const string SuccessfullyImportedOfficer = "Imported {0} ({1} prisoners)";

    public static string ImportDepartmentsCells(SoftJailDbContext context, string jsonString)
    {
        StringBuilder stringBuilder = new StringBuilder();

        

        return stringBuilder.ToString().TrimEnd();
    }

    public static string ImportPrisonersMails(SoftJailDbContext context, string jsonString)
    {
        StringBuilder stringBuilder = new StringBuilder();

        //ImportPrisonerDto[] prisonerDtos = JsonConvert.DeserializeObject<ImportPrisonerDto[]>(jsonString);

        //ICollection<Prisoner> validPrisoners = new HashSet<Prisoner>();


        //foreach (ImportPrisonerDto prisonerDto in prisonerDtos)
        //{

        //    if (!IsValid(prisonerDto))
        //    {
        //        stringBuilder.AppendLine(ErrorMessage);
        //        continue;
        //    }

        //    DateTime incarcerationDate;
        //    bool isIncarcerationDateValid = DateTime.TryParseExact(prisonerDto.IncarcerationDate, "dd/MM/yyyy",
        //        CultureInfo.InvariantCulture, DateTimeStyles.None, out incarcerationDate);

        //    if (!isIncarcerationDateValid)
        //    {
        //        stringBuilder.AppendLine(ErrorMessage);
        //        continue;
        //    }

        //    DateTime releaseDate;
        //    bool isReleaseDateValid = DateTime.TryParseExact(prisonerDto.ReleaseDate, "dd/MM/yyyy",
        //        CultureInfo.InvariantCulture, DateTimeStyles.None, out releaseDate);

        //    if (!isReleaseDateValid)
        //    {
        //        if (prisonerDto.ReleaseDate != null)
        //        {
        //            stringBuilder.AppendLine(ErrorMessage);
        //            continue;
        //        }
        //    }

        //    Prisoner prisoner = new Prisoner()
        //    {
        //        FullName = prisonerDto.FullName,
        //        Nickname = prisonerDto.Nickname,
        //        Age = prisonerDto.Age,
        //        IncarcerationDate = incarcerationDate,
        //        ReleaseDate = releaseDate == null? null: releaseDate,
        //        CellId = prisonerDto.CellId
        //    };

        //    foreach (ImportMailDto mailDto in prisonerDto.Mails)
        //    {

        //        if (!IsValid(mailDto))
        //        {
        //            stringBuilder.AppendLine(ErrorMessage);
        //            continue;
        //        }

        //        Mail mail = new Mail()
        //        {
        //            Description = mailDto.Description,
        //            Sender = mailDto.Sender,
        //            Address = mailDto.Address
        //        };

        //        prisoner.Mails.Add(mail);
        //    }

        //    validPrisoners.Add(prisoner);
        //    stringBuilder.AppendLine(string.Format(SuccessfullyImportedPrisoner, prisoner.FullName, prisoner.Age));
        //}

        //context.Prisoners.AddRange(validPrisoners);
        //context.SaveChanges();

        return stringBuilder.ToString().TrimEnd();
    }
    private static bool IsValid(object obj)
    {
        var validationContext = new System.ComponentModel.DataAnnotations.ValidationContext(obj);
        var validationResult = new List<ValidationResult>();

        bool isValid = Validator.TryValidateObject(obj, validationContext, validationResult, true);
        return isValid;
    }
}