namespace FileManager.Api.Settings;

public static class FileSettings
{
    public const int MaxFileSizeInMB = 1;
    public const int MaxFileSizeInBytes = MaxFileSizeInMB * 1024 * 1024; // 1MB in bytes
    public static readonly string[] BlockedSignatures = ["4D-5A", "2F-2A", "D0-CF"]; //signatures of exe, jqery, msi
    public static readonly string[] AllowedImagesExtensions = [".jpg", ".jpeg", ".png"]; // white list for images
}