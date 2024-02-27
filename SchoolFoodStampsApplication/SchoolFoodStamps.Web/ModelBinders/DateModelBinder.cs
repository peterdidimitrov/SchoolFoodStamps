﻿using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Globalization;

namespace SchoolFoodStamps.Web.ModelBinders
{
    public class DateModelBinder : IModelBinder
    {
        public Task BindModelAsync(ModelBindingContext bindingContext)
        {

            // Get the value provider result
            var valueProviderResult = bindingContext.ValueProvider.GetValue(bindingContext.ModelName);
            if (valueProviderResult == ValueProviderResult.None)
            {
                // No value was found for the specified model name
                return Task.CompletedTask;
            }

            // Attempt to parse the value as date
            var valueAsString = valueProviderResult.FirstValue;
            if (!DateTime.TryParseExact(valueAsString, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out var result))
            {
                // Parsing failed, set ModelState error
                bindingContext.ModelState.TryAddModelError(bindingContext.ModelName, "Invalid date value. Please use the format 'yyyy-MM-dd'.");
                return Task.CompletedTask;
            }

            // Set the model value and success state
            bindingContext.Result = ModelBindingResult.Success(result);
            return Task.CompletedTask;
        }
    }
}