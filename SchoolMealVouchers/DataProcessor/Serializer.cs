namespace SchoolMealVouchers.DataProcessor;

using Data;

public class Serializer
{
    public static string ExportPrisonersByCells(SoftJailDbContext context, int[] ids)
    {
        //var prisoners = context.Prisoners
        //    .Where(p => ids.Contains(p.Id))
        //.Select(p => new
        //    {
        //        Id = p.Id,
        //        Name = p.FullName,
        //        CellNumber = p.Cell.CellNumber,
        //        Officers = p.PrisonerOfficers
        //        .Select(po => new
        //        {
        //            OfficerName = po.Officer.FullName,
        //            Department = po.Officer.Department.Name
        //        })
        //        .OrderBy(o => o.OfficerName)
        //        .ToArray(),
        //    TotalOfficerSalary = Math.Round(p.PrisonerOfficers.Sum(po => po.Officer.Salary), 2)
        //    })
        //    .OrderBy(p => p.Name)
        //    .ThenBy(p => p.Id)
        //    .ToArray();


        return ""; //JsonConvert.SerializeObject(prisoners, Formatting.Indented);
    }
}