using System.Collections.Generic;
using Xamarin.Essentials;

namespace XamarinApp.Constants;

public static class FilePickerFileTypes
{
    public static FilePickerFileType SpreadsheetType { get; }
        = new FilePickerFileType(new Dictionary<DevicePlatform, IEnumerable<string>>
        {
            { DevicePlatform.iOS, new[] { "com.microsoft.excel.xlsx" } },
            { DevicePlatform.Android, new[] { "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet" } }
        });

    public static FilePickerFileType WordDocumentType { get; }
        = new FilePickerFileType(new Dictionary<DevicePlatform, IEnumerable<string>>
        {
            { DevicePlatform.iOS, new[] { "org.openxmlformats.wordprocessingml.document" } },
            { DevicePlatform.Android, new[] { "application/vnd.openxmlformats-officedocument.wordprocessingml.document" } }
        });
}