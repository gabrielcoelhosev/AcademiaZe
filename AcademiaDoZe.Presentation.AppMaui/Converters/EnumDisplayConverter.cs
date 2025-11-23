<<<<<<< HEAD
﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using Microsoft.Maui.Controls;

namespace AcademiaDoZe.Presentation.AppMaui.Converters
{
    public class EnumDisplayConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return string.Empty;

            if (value is not Enum enumValue)
                return value.ToString() ?? string.Empty;

            var enumType = enumValue.GetType();

            // Se o enum possui FlagsAttribute, decompor em valores ativos
            if (enumType.IsDefined(typeof(FlagsAttribute), false))
            {
                // converte uma vez
                long combined = System.Convert.ToInt64(enumValue);

                // se for zero (None), retornar o display de None ou "Nenhuma Restrição"
                if (combined == 0)
                {
                    var noneMember = enumType.GetMember("None").FirstOrDefault();
                    var noneDisplay = noneMember?
                        .GetCustomAttributes(typeof(DisplayAttribute), false)
                        .OfType<DisplayAttribute>()
                        .FirstOrDefault()?.Name;
                    return noneDisplay ?? "Nenhuma Restrição";
                }

                var activeNames = Enum.GetValues(enumType)
                    .Cast<Enum>()
                    // para cada flag, converte uma vez e checa os bits
                    .Select(flag => new { Flag = flag, Value = System.Convert.ToInt64(flag) })
                    .Where(x => x.Value != 0 && (combined & x.Value) == x.Value)
                    .Select(x => GetDisplayName(x.Flag))
                    .Where(name => !string.IsNullOrWhiteSpace(name));

                return string.Join(", ", activeNames);
            }

            // Enum normal (sem Flags)
            return GetDisplayName(enumValue);
        }

        private string GetDisplayName(Enum enumValue)
        {
            var member = enumValue.GetType().GetMember(enumValue.ToString()).FirstOrDefault();
            if (member != null)
            {
                var display = member.GetCustomAttributes(typeof(DisplayAttribute), false)
                                    .OfType<DisplayAttribute>()
                                    .FirstOrDefault();
                if (display != null)
                    return display.Name;
            }
            return enumValue.ToString();
        }


        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
            => throw new NotImplementedException();
    }
}
=======
﻿using AcademiaDoZe.Application.Enums;
using System.Globalization;
namespace AcademiaDoZe.Presentation.AppMaui.Converters
{
    // Converte qualquer Enum para o Display(Name)
    public sealed class EnumDisplayConverter : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        => value is Enum e ? e.GetDisplayName() : string.Empty;
        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        => throw new NotSupportedException();
    }
}
>>>>>>> df0a73ee51b361b095f201897a83dfe9089cce65
