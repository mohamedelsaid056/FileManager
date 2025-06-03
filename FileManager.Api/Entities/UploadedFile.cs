namespace FileManager.Api.Entities;

public  class UploadedFile
{

    //this is for version 7 of Guid, which is a sequential Guid that is guaranteed to be unique 
    public Guid Id { get; set; } = Guid.CreateVersion7();
    // orginal file name 
    public string FileName { get; set; } = string.Empty;
    // stored file name in the server  and we will generate this in service using this  Path.GetRandomFileName(); in service 
    public string StoredFileName { get; set; } = string.Empty;
    public string ContentType { get; set; } = string.Empty;
    public string FileExtension { get; set; } = string.Empty;
}