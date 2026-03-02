using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientOrders.Core;
using Microsoft.AspNetCore.Hosting;

public class FileStorageService : IFileStorageService
{
    private readonly string _webRootPath;

    public FileStorageService(string webRootPath)
    {
        _webRootPath = webRootPath;
    }

    public async Task<string> SaveClientImageAsync(Stream fileStream, string fileName)
    {
        var uploadsFolder = Path.Combine(_webRootPath, "uploads", "clients");

        if (!Directory.Exists(uploadsFolder))
            Directory.CreateDirectory(uploadsFolder);

        var uniqueFileName = $"{Guid.NewGuid()}_{fileName}";
        var filePath = Path.Combine(uploadsFolder, uniqueFileName);

        await using var output = new FileStream(filePath, FileMode.Create);
        await fileStream.CopyToAsync(output);

        return $"/uploads/clients/{uniqueFileName}";
    }
}