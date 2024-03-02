using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Globalization;
using static SchoolFoodStamps.Common.GeneralApplicationConstants;

namespace SchoolFoodStamps.Web.Infrastructure.ModelBinders
{
    /// <summary>
    /// Model binder for parsing date values from request.
    /// </summary>
    public class DateModelBinder : IModelBinder
    {
        public Task BindModelAsync(ModelBindingContext bindingContext)
        {

            // Get the value provider result
            var valueProviderResult = bindingContext.ValueProvider.GetValue(bindingContext.ModelName);
            if (valueProviderResult == ValueProviderResult.None)
            {
                //No value was found for the specified model name
                return Task.CompletedTask;
            }

            // Attempt to parse the value as date
            var valueAsString = valueProviderResult.FirstValue;
            if (!DateTime.TryParseExact(valueAsString, DateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out var result))
            {
                // Parsing failed, set ModelState error
                bindingContext.ModelState.TryAddModelError(bindingContext.ModelName, "Invalid date value. Please use the format 'dd-MM-yyyy HH:mm'.");
                return Task.CompletedTask;
            }

            // Set the model value and success state
            bindingContext.Result = ModelBindingResult.Success(result);
            return Task.CompletedTask;
        }
    }
}
